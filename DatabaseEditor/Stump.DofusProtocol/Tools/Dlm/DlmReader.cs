using System;
using System.IO;
using Stump.Core.IO;

namespace Stump.DofusProtocol.D2oClasses.Tools.Dlm
{
    public class DlmReader : IDisposable
    {
        public delegate string KeyProvider(int mapId);

        private IDataReader m_reader;

        public DlmReader(string filePath)
        {
            m_reader = new FastBigEndianReader(File.ReadAllBytes(filePath));
        }

        public DlmReader(string filePath, string decryptionKey)
        {
            m_reader = new FastBigEndianReader(File.ReadAllBytes(filePath));
            DecryptionKey = decryptionKey;
        }

        public DlmReader(IDataReader reader)
        {
            m_reader = reader;
        }

        public DlmReader(Stream stream)
        {
            m_reader = new BigEndianReader(stream);
        }

        public DlmReader(byte[] buffer)
        {
            m_reader = new FastBigEndianReader(buffer);
        }

        public string DecryptionKey { get; set; }

        public KeyProvider DecryptionKeyProvider { get; set; }

        public void Dispose()
        {
            m_reader.Dispose();
        }

        public DlmMap ReadMap()
        {
            m_reader.Seek(0, SeekOrigin.Begin);
            if (m_reader.ReadByte() != 77)
            {
                try
                {
                    m_reader.Seek(0, SeekOrigin.Begin);
                    var memoryStream = new MemoryStream();
                    ZipHelper.Deflate(new MemoryStream(m_reader.ReadBytes((int) m_reader.BytesAvailable)), memoryStream);
                    var array = memoryStream.ToArray();
                    m_reader.Dispose();
                    m_reader = new FastBigEndianReader(array);
                    if (m_reader.ReadByte() != 77)
                    {
                        throw new FileLoadException("Wrong header file");
                    }
                }
                catch (Exception exception)
                {
                    throw new FileLoadException("Wrong header file");
                }
            }
            return DlmMap.ReadFromStream(m_reader, this);
        }
    }
}