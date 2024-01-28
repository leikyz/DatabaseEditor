//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.ComponentModel;
//using System.IO;
//using System.Linq;
//using NLog;
//using Stump.Core.IO;

//namespace Stump.DofusProtocol.D2oClasses.Tools.D2p
//{
//    public class D2pFile : INotifyPropertyChanged, IDisposable
//    {
//        private static readonly Logger logger;

//        private readonly Dictionary<string, D2pEntry> m_entries = new Dictionary<string, D2pEntry>();

//        private readonly List<D2pFile> m_links = new List<D2pFile>();

//        private readonly Queue<D2pFile> m_linksToSave = new Queue<D2pFile>();
//        private readonly bool m_preload;

//        private readonly List<D2pProperty> m_properties = new List<D2pProperty>();

//        private readonly Dictionary<string, D2pDirectory> m_rootDirectories = new Dictionary<string, D2pDirectory>();

//        private string fileName;
//        private D2pIndexTable indexTable;

//        private string m_filePath;

//        private FileStream m_fileStream;

//        private bool m_isDisposed;

//        private IDataReader m_reader;

//        static D2pFile()
//        {
//            logger = LogManager.GetCurrentClassLogger();
//        }

//        public D2pFile()
//        {
//            IndexTable = new D2pIndexTable(this);
//            m_reader = new BigEndianReader(new byte[0]);
//        }

//        public D2pFile(string file, bool preload = false)
//        {
//            m_preload = preload;
//            FilePath = file;
//            if (!preload)
//            {
//                var fileStream = File.OpenRead(file);
//                var fileStream1 = fileStream;
//                m_fileStream = fileStream;
//                m_reader = new BigEndianReader(fileStream1);
//            }
//            else
//            {
//                m_reader = new FastBigEndianReader(File.ReadAllBytes(file));
//            }
//            InternalOpen();
//        }

//        public IEnumerable<D2pEntry> Entries
//        {
//            get { return m_entries.Values; }
//        }

//        public string FileName
//        {
//            get { return fileName; }
//            private set
//            {
//                if (!string.Equals(fileName, value))
//                {
//                    fileName = value;
//                    OnPropertyChanged("FileName");
//                }
//            }
//        }


//        public string FilePath
//        {
//            get { return m_filePath; }
//            private set
//            {
//                if (string.Equals(m_filePath, value))
//                {
//                    return;
//                }
//                m_filePath = value;
//                OnPropertyChanged("FilePath");
//                FileName = Path.GetFileName(value);
//            }
//        }

//        public D2pIndexTable IndexTable
//        {
//            get { return indexTable; }
//            private set
//            {
//                if (indexTable == value)
//                {
//                    return;
//                }
//                indexTable = value;
//                OnPropertyChanged("IndexTable");
//            }
//        }

//        public D2pEntry this[string fileName]
//        {
//            get { return m_entries[fileName]; }
//        }

//        public ReadOnlyCollection<D2pFile> Links
//        {
//            get { return m_links.AsReadOnly(); }
//        }

//        public ReadOnlyCollection<D2pProperty> Properties
//        {
//            get { return m_properties.AsReadOnly(); }
//        }

//        public IEnumerable<D2pDirectory> RootDirectories
//        {
//            get { return m_rootDirectories.Values; }
//        }

//        public void Dispose()
//        {
//            if (!m_isDisposed)
//            {
//                m_isDisposed = true;
//                if (m_reader != null)
//                {
//                    m_reader.Dispose();
//                }
//                if (m_links != null)
//                {
//                    foreach (var mLink in m_links)
//                    {
//                        mLink.Dispose();
//                    }
//                }
//            }
//        }

//        public event PropertyChangedEventHandler PropertyChanged;

//        public void AddEntry(D2pEntry entry)
//        {
//            entry.State = D2pEntryState.Added;
//            InternalAddEntry(entry);
//            var indexTable = IndexTable;
//            indexTable.EntriesCount = indexTable.EntriesCount + 1;
//            OnPropertyChanged("Entries");
//        }

//        public D2pEntry AddFile(string file)
//        {
//            var numArray = File.ReadAllBytes(file);
//            var relativePath = file;
//            if (HasFilePath())
//            {
//                relativePath = GetRelativePath(file, Path.GetDirectoryName(FilePath));
//            }
//            return AddFile(relativePath, numArray);
//        }

//        public D2pEntry AddFile(string fileName, byte[] data)
//        {
//            var d2pEntry = new D2pEntry(this, fileName, data);
//            AddEntry(d2pEntry);
//            return d2pEntry;
//        }

//        public void AddLink(string linkFile)
//        {
//            InternalAddLink(linkFile);
//            var d2pProperty = new D2pProperty
//            {
//                Key = "link",
//                Value = linkFile
//            };
//            InternalAddProperty(d2pProperty);
//        }

//        public void AddProperty(D2pProperty property)
//        {
//            if (property.Key == "link")
//            {
//                InternalAddLink(property.Value);
//            }
//            InternalAddProperty(property);
//        }

//        public bool Exists(string fileName)
//        {
//            return m_entries.ContainsKey(fileName);
//        }

//        public void ExtractAllFiles(string destination, bool overwrite = false, bool progress = false)
//        {
//            string str;
//            if (!Directory.Exists(Path.GetDirectoryName(destination)))
//            {
//                Directory.CreateDirectory(destination);
//            }
//            foreach (var strArrays in (
//                from entry in m_entries
//                select entry.Value.GetDirectoriesName()).Distinct())
//            {
//                str = Path.Combine(Path.GetFullPath(destination), Path.Combine(strArrays));
//                if (!Directory.Exists(str))
//                {
//                    Directory.CreateDirectory(str);
//                }
//            }
//            double num = 0;
//            var num1 = 0;
//            foreach (var mEntry in m_entries)
//            {
//                if (!File.Exists(Path.GetFullPath(destination)) ? false : !overwrite)
//                {
//                    throw new InvalidOperationException(string.Format("Cannot overwrite {0}", destination));
//                }
//                str = Path.Combine(Path.GetFullPath(destination), mEntry.Value.FullFileName);
//                File.WriteAllBytes(str, ReadFile(mEntry.Value));
//                num = num + 1;
//                if (progress)
//                {
//                    if ((int) (num/m_entries.Count*100) != num1)
//                    {
//                        var count = (int) (num/m_entries.Count*100);
//                        num1 = count;
//                        OnExtractPercentProgress(count);
//                    }
//                }
//            }
//        }

//        public void ExtractDirectory(string directoryName, string destination)
//        {
//            if (!HasDirectory(directoryName))
//            {
//                throw new InvalidOperationException(string.Format("Directory {0} does not exist", directoryName));
//            }
//            var d2pDirectory = TryGetDirectory(directoryName);
//            if (!Directory.Exists(Path.Combine(destination, d2pDirectory.FullName)))
//            {
//                Directory.CreateDirectory(Path.Combine(destination, d2pDirectory.FullName));
//            }
//            foreach (var entry in d2pDirectory.Entries)
//            {
//                ExtractFile(entry.FullFileName, Path.Combine(destination, entry.FullFileName), false);
//            }
//            foreach (var directory in d2pDirectory.Directories)
//            {
//                ExtractDirectory(directory.Value.FullName, destination);
//            }
//        }

//        public void ExtractFile(string fileName, bool overwrite = false)
//        {
//            if (!Exists(fileName))
//            {
//                throw new FileNotFoundException(fileName);
//            }
//            var entry = GetEntry(fileName);
//            var str = Path.Combine("./", entry.FullFileName);
//            if (!Directory.Exists(Path.GetDirectoryName(str)))
//            {
//                Directory.CreateDirectory(str);
//            }
//            ExtractFile(fileName, str, overwrite);
//        }

//        public void ExtractFile(string fileName, string destination, bool overwrite = false)
//        {
//            var numArray = ReadFile(fileName);
//            if (Directory.Exists(destination))
//            {
//                if ((File.GetAttributes(destination) & FileAttributes.Directory) == FileAttributes.Directory)
//                {
//                    destination = Path.Combine(destination, Path.GetFileName(fileName));
//                }
//            }
//            if (!File.Exists(destination) ? false : !overwrite)
//            {
//                throw new InvalidOperationException(string.Format("Cannot overwrite {0}", destination));
//            }
//            if (!Directory.Exists(Path.GetDirectoryName(destination)))
//            {
//                Directory.CreateDirectory(Path.GetDirectoryName(destination));
//            }
//            File.WriteAllBytes(destination, numArray);
//        }

//        public D2pDirectory[] GetDirectoriesTree(string directory)
//        {
//            D2pDirectory[] array;
//            var d2pDirectories = new List<D2pDirectory>();
//            char[] chrArray = {'/', '\\'};
//            var strArrays = directory.Split(chrArray, StringSplitOptions.RemoveEmptyEntries);
//            if (strArrays.Length != 0)
//            {
//                D2pDirectory d2pDirectory = null;
//                m_rootDirectories.TryGetValue(strArrays[0], out d2pDirectory);
//                if (d2pDirectory != null)
//                {
//                    d2pDirectories.Add(d2pDirectory);
//                    foreach (var str in strArrays.Skip(1))
//                    {
//                        if (d2pDirectory.HasDirectory(str))
//                        {
//                            d2pDirectory = d2pDirectory.TryGetDirectory(str);
//                            d2pDirectories.Add(d2pDirectory);
//                        }
//                        else
//                        {
//                            array = d2pDirectories.ToArray();
//                            return array;
//                        }
//                    }
//                    array = d2pDirectories.ToArray();
//                }
//                else
//                {
//                    array = new D2pDirectory[0];
//                }
//            }
//            else
//            {
//                array = new D2pDirectory[0];
//            }
//            return array;
//        }

//        public D2pEntry[] GetEntriesOfInstanceOnly()
//        {
//            var array = (
//                from entry in m_entries.Values
//                where entry.Container == this
//                select entry).ToArray();
//            return array;
//        }

//        public D2pEntry GetEntry(string fileName)
//        {
//            return m_entries[fileName];
//        }

//        public string[] GetFilesName()
//        {
//            return m_entries.Keys.ToArray();
//        }

//        private string GetLinkFileAbsolutePath(string linkFile)
//        {
//            string str;
//            if (!File.Exists(linkFile))
//            {
//                if (HasFilePath())
//                {
//                    var str1 = Path.Combine(Path.GetDirectoryName(FilePath), linkFile);
//                    if (File.Exists(str1))
//                    {
//                        str = str1;
//                        return str;
//                    }
//                }
//                str = linkFile;
//            }
//            else
//            {
//                str = linkFile;
//            }
//            return str;
//        }

//        private string GetRelativePath(string file, string directory)
//        {
//            var uri = new Uri(Path.GetFullPath(file));
//            var uri1 = new Uri(Path.GetFullPath(directory));
//            return uri1.MakeRelativeUri(uri).ToString();
//        }

//        public bool HasDirectory(string directory)
//        {
//            bool flag;
//            char[] chrArray = {'/', '\\'};
//            var strArrays = directory.Split(chrArray, StringSplitOptions.RemoveEmptyEntries);
//            if (strArrays.Length != 0)
//            {
//                D2pDirectory d2pDirectory = null;
//                m_rootDirectories.TryGetValue(strArrays[0], out d2pDirectory);
//                if (d2pDirectory != null)
//                {
//                    foreach (var str in strArrays.Skip(1))
//                    {
//                        if (d2pDirectory.HasDirectory(str))
//                        {
//                            d2pDirectory = d2pDirectory.TryGetDirectory(str);
//                        }
//                        else
//                        {
//                            flag = false;
//                            return flag;
//                        }
//                    }
//                    flag = true;
//                }
//                else
//                {
//                    flag = false;
//                }
//            }
//            else
//            {
//                flag = false;
//            }
//            return flag;
//        }

//        public bool HasFilePath()
//        {
//            return !string.IsNullOrEmpty(FilePath);
//        }

//        private void InternalAddDirectories(D2pEntry entry)
//        {
//            var directoriesName = entry.GetDirectoriesName();
//            if (directoriesName.Length != 0)
//            {
//                D2pDirectory item = null;
//                if (m_rootDirectories.ContainsKey(directoriesName[0]))
//                {
//                    item = m_rootDirectories[directoriesName[0]];
//                }
//                else
//                {
//                    var mRootDirectories = m_rootDirectories;
//                    var str = directoriesName[0];
//                    var d2pDirectory = new D2pDirectory(this, directoriesName[0]);
//                    item = d2pDirectory;
//                    mRootDirectories.Add(str, d2pDirectory);
//                }
//                if (directoriesName.Length == 1)
//                {
//                    item.Entries.Add(entry);
//                }
//                for (var i = 1; i < directoriesName.Length; i++)
//                {
//                    var str1 = directoriesName[i];
//                    var d2pDirectory1 = item.TryGetDirectory(str1);
//                    if (d2pDirectory1 != null)
//                    {
//                        item = d2pDirectory1;
//                    }
//                    else
//                    {
//                        var d2pDirectory2 = new D2pDirectory(this, str1)
//                        {
//                            Parent = item
//                        };
//                        item.Directories.Add(str1, d2pDirectory2);
//                        item = d2pDirectory2;
//                    }
//                    if (i == directoriesName.Length - 1)
//                    {
//                        item.Entries.Add(entry);
//                    }
//                }
//                entry.Directory = item;
//            }
//        }

//        private void InternalAddEntry(D2pEntry entry)
//        {
//            var d2pEntry = TryGetEntry(entry.FullFileName);
//            if (d2pEntry == null)
//            {
//                m_entries.Add(entry.FullFileName, entry);
//            }
//            else
//            {
//                logger.Warn("Entry '{0}'({1}) already added and will be override ({2})", d2pEntry.FullFileName,
//                    d2pEntry.Container.FileName, FileName);
//                m_entries[d2pEntry.FullFileName] = entry;
//            }
//            InternalAddDirectories(entry);
//        }

//        private void InternalAddLink(string linkFile)
//        {
//            var linkFileAbsolutePath = GetLinkFileAbsolutePath(linkFile);
//            if (!File.Exists(linkFileAbsolutePath))
//            {
//                throw new FileNotFoundException(linkFile);
//            }
//            var d2pFile = new D2pFile(linkFileAbsolutePath, false);
//            foreach (var entry in d2pFile.Entries)
//            {
//                InternalAddEntry(entry);
//            }
//            m_links.Add(d2pFile);
//            OnPropertyChanged("Links");
//        }

//        private void InternalAddProperty(D2pProperty property)
//        {
//            m_properties.Add(property);
//            OnPropertyChanged("Properties");
//            var indexTable = IndexTable;
//            indexTable.PropertiesCount = indexTable.PropertiesCount + 1;
//        }

//        private void InternalOpen()
//        {
//            if (m_reader.ReadByte() != 2 ? true : m_reader.ReadByte() != 1)
//            {
//                throw new FileLoadException("Corrupted d2p header");
//            }
//            ReadTable();
//            ReadProperties();
//            ReadEntriesDefinitions();
//        }

//        private void InternalRemoveDirectories(D2pEntry entry)
//        {
//            for (var i = entry.Directory; i != null; i = i.Parent)
//            {
//                i.Entries.Remove(entry);
//                if (!(i.Parent == null ? true : i.Entries.Count != 0))
//                {
//                    i.Parent.Directories.Remove(i.Name);
//                }
//                else if (!i.IsRoot ? false : i.Entries.Count == 0)
//                {
//                    m_rootDirectories.Remove(i.Name);
//                }
//            }
//        }

//        private bool InternalRemoveLink(D2pFile link)
//        {
//            bool flag;
//            if (!m_links.Remove(link))
//            {
//                flag = false;
//            }
//            else
//            {
//                OnPropertyChanged("Links");
//                flag = true;
//            }
//            return flag;
//        }

//        private void InternalSave(Stream stream)
//        {
//            D2pEntry position;
//            int i;
//            var bigEndianWriter = new BigEndianWriter(stream);
//            bigEndianWriter.WriteByte(2);
//            bigEndianWriter.WriteByte(1);
//            var entriesOfInstanceOnly = GetEntriesOfInstanceOnly();
//            var num = 2;
//            var d2pEntryArray = entriesOfInstanceOnly;
//            for (i = 0; i < d2pEntryArray.Length; i++)
//            {
//                position = d2pEntryArray[i];
//                var numArray = ReadFile(position);
//                position.Index = (int) bigEndianWriter.Position - num;
//                bigEndianWriter.WriteBytes(numArray);
//            }
//            var position1 = (int) bigEndianWriter.Position;
//            d2pEntryArray = entriesOfInstanceOnly;
//            for (i = 0; i < d2pEntryArray.Length; i++)
//            {
//                position = d2pEntryArray[i];
//                position.WriteEntryDefinition(bigEndianWriter);
//            }
//            var num1 = (int) bigEndianWriter.Position;
//            foreach (var mProperty in m_properties)
//            {
//                mProperty.WriteProperty(bigEndianWriter);
//            }
//            IndexTable.OffsetBase = num;
//            IndexTable.EntriesCount = entriesOfInstanceOnly.Length;
//            IndexTable.EntriesDefinitionOffset = position1;
//            IndexTable.PropertiesCount = m_properties.Count;
//            IndexTable.PropertiesOffset = num1;
//            IndexTable.Size = IndexTable.EntriesDefinitionOffset - IndexTable.OffsetBase;
//            IndexTable.WriteTable(bigEndianWriter);
//        }

//        public bool ModifyFile(string file, byte[] data)
//        {
//            bool flag;
//            var d2pEntry = TryGetEntry(file);
//            if (d2pEntry != null)
//            {
//                d2pEntry.ModifyEntry(data);
//                lock (m_linksToSave)
//                {
//                    if (d2pEntry.Container == this ? false : !m_linksToSave.Contains(d2pEntry.Container))
//                    {
//                        m_linksToSave.Enqueue(d2pEntry.Container);
//                    }
//                }
//                flag = true;
//            }
//            else
//            {
//                flag = false;
//            }
//            return flag;
//        }

//        private void OnExtractPercentProgress(int percent)
//        {
//            var action = ExtractPercentProgress;
//            if (action != null)
//            {
//                action(this, percent);
//            }
//        }

//        private void OnPropertyChanged(string propertyName)
//        {
//            var propertyChangedEventHandler = PropertyChanged;
//            if (propertyChangedEventHandler != null)
//            {
//                propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
//            }
//        }

//        public Dictionary<D2pEntry, byte[]> ReadAllFiles()
//        {
//            var d2pEntries = new Dictionary<D2pEntry, byte[]>();
//            foreach (var mEntry in m_entries)
//            {
//                d2pEntries.Add(mEntry.Value, ReadFile(mEntry.Value));
//            }
//            return d2pEntries;
//        }

//        private void ReadEntriesDefinitions()
//        {
//            m_reader.Seek(IndexTable.EntriesDefinitionOffset, SeekOrigin.Begin);
//            for (var i = 0; i < IndexTable.EntriesCount; i++)
//            {
//                InternalAddEntry(D2pEntry.CreateEntryDefinition(this, m_reader));
//            }
//        }

//        public byte[] ReadFile(D2pEntry entry)
//        {
//            byte[] numArray;
//            if (entry.Container == this)
//            {
//                lock (m_reader)
//                {
//                    if (entry.Index < 0 ? false : IndexTable.OffsetBase + entry.Index >= 0)
//                    {
//                        m_reader.Seek(IndexTable.OffsetBase + entry.Index, SeekOrigin.Begin);
//                    }
//                    numArray = entry.ReadEntry(m_reader);
//                }
//            }
//            else
//            {
//                numArray = entry.Container.ReadFile(entry);
//            }
//            return numArray;
//        }

//        public byte[] ReadFile(string fileName)
//        {
//            if (!Exists(fileName))
//            {
//                throw new FileNotFoundException(fileName);
//            }
//            return ReadFile(GetEntry(fileName));
//        }

//        private void ReadProperties()
//        {
//            m_reader.Seek(IndexTable.PropertiesOffset, SeekOrigin.Begin);
//            for (var i = 0; i < IndexTable.PropertiesCount; i++)
//            {
//                var d2pProperty = new D2pProperty();
//                d2pProperty.ReadProperty(m_reader);
//                if (d2pProperty.Key == "link")
//                {
//                    InternalAddLink(d2pProperty.Value);
//                }
//                m_properties.Add(d2pProperty);
//            }
//        }

//        private void ReadTable()
//        {
//            m_reader.Seek(-24, SeekOrigin.End);
//            IndexTable = new D2pIndexTable(this);
//            IndexTable.ReadTable(m_reader);
//        }

//        public bool RemoveEntry(D2pEntry entry)
//        {
//            bool flag;
//            if (entry.Container != this)
//            {
//                if (!entry.Container.RemoveEntry(entry))
//                {
//                    flag = false;
//                    return flag;
//                }
//                if (!m_linksToSave.Contains(entry.Container))
//                {
//                    m_linksToSave.Enqueue(entry.Container);
//                }
//            }
//            if (!m_entries.Remove(entry.FullFileName))
//            {
//                flag = false;
//            }
//            else
//            {
//                entry.State = D2pEntryState.Removed;
//                InternalRemoveDirectories(entry);
//                OnPropertyChanged("Entries");
//                if (entry.Container == this)
//                {
//                    var indexTable = IndexTable;
//                    indexTable.EntriesCount = indexTable.EntriesCount - 1;
//                }
//                flag = true;
//            }
//            return flag;
//        }

//        public bool RemoveFile(string file)
//        {
//            var d2pEntry = TryGetEntry(file);
//            return d2pEntry == null ? false : RemoveEntry(d2pEntry);
//        }

//        public bool RemoveLink(D2pFile file)
//        {
//            bool flag;
//            var d2pProperty =
//                m_properties.FirstOrDefault(
//                    (D2pProperty entry) =>
//                        Path.GetFullPath(GetLinkFileAbsolutePath(entry.Value)) == Path.GetFullPath(file.FilePath));
//            if (d2pProperty != null)
//            {
//                var flag1 = !InternalRemoveLink(file) ? false : m_properties.Remove(d2pProperty);
//                if (flag1)
//                {
//                    OnPropertyChanged("Properties");
//                }
//                flag = flag1;
//            }
//            else
//            {
//                flag = false;
//            }
//            return flag;
//        }

//        public bool RemoveProperty(D2pProperty property)
//        {
//            bool flag;
//            if (property.Key == "link")
//            {
//                var d2pFile =
//                    m_links.FirstOrDefault(
//                        (D2pFile entry) =>
//                            Path.GetFullPath(GetLinkFileAbsolutePath(property.Value)) ==
//                            Path.GetFullPath(entry.FilePath));
//                if (d2pFile == null ? true : !InternalRemoveLink(d2pFile))
//                {
//                    throw new Exception(string.Format("Cannot remove the associated link {0} to this property",
//                        property.Value));
//                }
//            }
//            if (!m_properties.Remove(property))
//            {
//                flag = false;
//            }
//            else
//            {
//                OnPropertyChanged("Properties");
//                var indexTable = IndexTable;
//                indexTable.PropertiesCount = indexTable.PropertiesCount - 1;
//                flag = true;
//            }
//            return flag;
//        }

//        public void Save()
//        {
//            if (!HasFilePath())
//            {
//                throw new InvalidOperationException("Cannot perform Save : No path defined, use SaveAs instead");
//            }
//            lock (m_linksToSave)
//            {
//                while (m_linksToSave.Count > 0)
//                {
//                    m_linksToSave.Dequeue().Save();
//                }
//            }
//            if (m_fileStream == null)
//            {
//                var fileStream = File.OpenWrite(FilePath);
//                try
//                {
//                    InternalSave(fileStream);
//                }
//                finally
//                {
//                    if (fileStream != null)
//                    {
//                        ((IDisposable) fileStream).Dispose();
//                    }
//                }
//                m_reader = new FastBigEndianReader(File.ReadAllBytes(FilePath));
//            }
//            else
//            {
//                var tempFileName = Path.GetTempFileName();
//                var fileStream1 = File.Create(tempFileName);
//                InternalSave(fileStream1);
//                fileStream1.Close();
//                m_reader.Dispose();
//                File.Delete(FilePath);
//                File.Move(tempFileName, FilePath);
//                var fileStream2 = File.OpenRead(FilePath);
//                var fileStream3 = fileStream2;
//                m_fileStream = fileStream2;
//                m_reader = new BigEndianReader(fileStream3);
//            }
//        }

//        public void SaveAs(string destination, bool overwrite = true)
//        {
//            Stream stream;
//            if (!(destination == FilePath))
//            {
//                foreach (var link in Links)
//                {
//                    link.SaveAs(Path.Combine(Path.GetDirectoryName(destination), link.FileName), true);
//                }
//                if (File.Exists(destination))
//                {
//                    if (!overwrite)
//                    {
//                        throw new InvalidOperationException(
//                            "Cannot perform SaveAs : file already exist, notify overwrite parameter to true");
//                    }
//                    stream = File.OpenWrite(destination);
//                }
//                else
//                {
//                    stream = File.Create(destination);
//                }
//                InternalSave(stream);
//                stream.Close();
//                FilePath = destination;
//                m_reader.Dispose();
//                var fileStream = File.OpenRead(destination);
//                var fileStream1 = fileStream;
//                m_fileStream = fileStream;
//                m_reader = new BigEndianReader(fileStream1);
//            }
//            else
//            {
//                Save();
//            }
//        }

//        public D2pDirectory TryGetDirectory(string directory)
//        {
//            D2pDirectory d2pDirectory;
//            char[] chrArray = {'/', '\\'};
//            var strArrays = directory.Split(chrArray, StringSplitOptions.RemoveEmptyEntries);
//            if (strArrays.Length != 0)
//            {
//                D2pDirectory d2pDirectory1 = null;
//                m_rootDirectories.TryGetValue(strArrays[0], out d2pDirectory1);
//                if (d2pDirectory1 != null)
//                {
//                    foreach (var str in strArrays.Skip(1))
//                    {
//                        if (d2pDirectory1.HasDirectory(str))
//                        {
//                            d2pDirectory1 = d2pDirectory1.TryGetDirectory(str);
//                        }
//                        else
//                        {
//                            d2pDirectory = null;
//                            return d2pDirectory;
//                        }
//                    }
//                    d2pDirectory = d2pDirectory1;
//                }
//                else
//                {
//                    d2pDirectory = null;
//                }
//            }
//            else
//            {
//                d2pDirectory = null;
//            }
//            return d2pDirectory;
//        }

//        public D2pEntry TryGetEntry(string fileName)
//        {
//            D2pEntry d2pEntry;
//            D2pEntry d2pEntry1;
//            if (!m_entries.TryGetValue(fileName, out d2pEntry))
//            {
//                d2pEntry1 = null;
//            }
//            else
//            {
//                d2pEntry1 = d2pEntry;
//            }
//            return d2pEntry1;
//        }

//        public event Action<D2pFile, int> ExtractPercentProgress;
//    }
//}