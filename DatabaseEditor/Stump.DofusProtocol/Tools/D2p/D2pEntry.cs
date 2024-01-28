using System;
using System.ComponentModel;
using System.IO;
using Stump.Core.IO;

namespace Stump.DofusProtocol.D2oClasses.Tools.D2p
{
    public class D2pEntry : INotifyPropertyChanged
    {
        private D2pFile container;
        private D2pDirectory directory;
        private int index;
        private D2pDirectory[] m_directories;

        private string m_fullFileName;

        private byte[] m_newData;
        private int size;
        private D2pEntryState state;

        private D2pEntry(D2pFile container)
        {
            Container = container;
            Index = -1;
        }

        public D2pEntry(D2pFile container, string fileName)
        {
            Container = container;
            FullFileName = fileName;
            Index = -1;
        }

        public D2pEntry(D2pFile container, string fileName, byte[] data)
        {
            Container = container;
            FullFileName = fileName;
            m_newData = data;
            State = D2pEntryState.Added;
            Size = data.Length;
            Index = -1;
        }

        public D2pFile Container
        {
            get { return container; }
            set
            {
                if (container == value)
                {
                    return;
                }
                container = value;
                OnPropertyChanged("Container");
            }
        }

        public D2pDirectory Directory
        {
            get { return directory; }
            set
            {
                if (directory == value)
                {
                    return;
                }
                directory = value;
                OnPropertyChanged("Directory");
            }
        }

        public string FileName
        {
            get { return Path.GetFileName(m_fullFileName); }
            set
            {
                if (string.Equals(m_fullFileName, value))
                {
                    return;
                }
                m_fullFileName = Path.Combine(Path.GetDirectoryName(m_fullFileName), value);
                OnPropertyChanged("FullFileName");
                OnPropertyChanged("FileName");
            }
        }

        public string FullFileName
        {
            get { return m_fullFileName; }
            set
            {
                if (string.Equals(m_fullFileName, value))
                {
                    return;
                }
                m_fullFileName = value;
                OnPropertyChanged("FullFileName");
            }
        }

        public int Index
        {
            get { return index; }
            set
            {
                if (index == value)
                {
                    return;
                }
                index = value;
                OnPropertyChanged("Index");
            }
        }

        public int Size
        {
            get { return size; }
            set
            {
                if (size == value)
                {
                    return;
                }
                size = value;
                OnPropertyChanged("Size");
            }
        }

        public D2pEntryState State
        {
            get { return state; }
            set
            {
                if (state == value)
                {
                    return;
                }
                state = value;
                OnPropertyChanged("State");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public static D2pEntry CreateEntryDefinition(D2pFile container, IDataReader reader)
        {
            var d2pEntry = new D2pEntry(container);
            d2pEntry.ReadEntryDefinition(reader);
            return d2pEntry;
        }

        public string[] GetDirectoriesName()
        {
            var directoryName = Path.GetDirectoryName(FullFileName);
            char[] chrArray = {'/', '\\'};
            return directoryName.Split(chrArray, StringSplitOptions.RemoveEmptyEntries);
        }

        public void ModifyEntry(byte[] data)
        {
            m_newData = data;
            Size = data.Length;
            State = D2pEntryState.Dirty;
        }

        public virtual void OnPropertyChanged(string propertyName)
        {
            var propertyChangedEventHandler = PropertyChanged;
            if (propertyChangedEventHandler != null)
            {
                propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public byte[] ReadEntry(IDataReader reader)
        {
            byte[] numArray;
            if (State == D2pEntryState.Removed)
            {
                throw new InvalidOperationException("Cannot read a deleted entry");
            }
            numArray = (State == D2pEntryState.Dirty ? false : State != D2pEntryState.Added)
                ? reader.ReadBytes(Size)
                : m_newData;
            return numArray;
        }

        public void ReadEntryDefinition(IDataReader reader)
        {
            FullFileName = reader.ReadUTF();
            Index = reader.ReadInt();
            Size = reader.ReadInt();
        }

        public void WriteEntryDefinition(IDataWriter writer)
        {
            if (Index == -1)
            {
                throw new InvalidOperationException("Invalid entry, index = -1");
            }
            writer.WriteUTF(FullFileName);
            writer.WriteInt(Index);
            writer.WriteInt(Size);
        }
    }
}