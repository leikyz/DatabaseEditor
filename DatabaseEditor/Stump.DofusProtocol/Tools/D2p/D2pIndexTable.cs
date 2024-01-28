using System.ComponentModel;
using System.IO;
using Stump.Core.IO;

namespace Stump.DofusProtocol.D2oClasses.Tools.D2p
{
    public class D2pIndexTable : INotifyPropertyChanged
    {
        public const int TableOffset = -24;

        public const SeekOrigin TableSeekOrigin = SeekOrigin.End;
        private D2pFile container;
        private int entriesCount;
        private int entriesDefinitionOffset;
        private int offsetBase;
        private int propertiesCount;
        private int propertiesOffset;
        private int size;

        public D2pIndexTable(D2pFile container)
        {
            Container = container;
        }

        public D2pFile Container
        {
            get { return Container; }
            private set
            {
                if (container == value)
                {
                    return;
                }
                container = value;
                OnPropertyChanged("Container");
            }
        }

        public int EntriesCount
        {
            get { return entriesCount; }
            set
            {
                if (entriesCount == value)
                {
                    return;
                }
                entriesCount = value;
                OnPropertyChanged("EntriesCount");
            }
        }

        public int EntriesDefinitionOffset
        {
            get { return entriesDefinitionOffset; }
            set
            {
                if (entriesDefinitionOffset == value)
                {
                    return;
                }
                entriesDefinitionOffset = value;
                OnPropertyChanged("EntriesDefinitionOffset");
            }
        }

        public int OffsetBase
        {
            get { return offsetBase; }
            set
            {
                if (offsetBase == value)
                {
                    return;
                }
                offsetBase = value;
                OnPropertyChanged("OffsetBase");
            }
        }

        public int PropertiesCount
        {
            get { return propertiesCount; }
            set
            {
                if (propertiesCount == value)
                {
                    return;
                }
                propertiesCount = value;
                OnPropertyChanged("PropertiesCount");
            }
        }

        public int PropertiesOffset
        {
            get { return propertiesOffset; }
            set
            {
                if (propertiesOffset == value)
                {
                    return;
                }
                propertiesOffset = value;
                OnPropertyChanged("PropertiesOffset");
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

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            var propertyChangedEventHandler = PropertyChanged;
            if (propertyChangedEventHandler != null)
            {
                propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void ReadTable(IDataReader reader)
        {
            OffsetBase = reader.ReadInt();
            Size = reader.ReadInt();
            EntriesDefinitionOffset = reader.ReadInt();
            EntriesCount = reader.ReadInt();
            PropertiesOffset = reader.ReadInt();
            PropertiesCount = reader.ReadInt();
        }

        public void WriteTable(IDataWriter writer)
        {
            writer.WriteInt(OffsetBase);
            writer.WriteInt(Size);
            writer.WriteInt(EntriesDefinitionOffset);
            writer.WriteInt(EntriesCount);
            writer.WriteInt(PropertiesOffset);
            writer.WriteInt(PropertiesCount);
        }
    }
}