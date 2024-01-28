using System.ComponentModel;
using Stump.Core.IO;

namespace Stump.DofusProtocol.D2oClasses.Tools.D2p
{
    public class D2pProperty : INotifyPropertyChanged
    {
        private string key;
        private string value;

        public D2pProperty()
        {
        }

        public D2pProperty(string key, string property)
        {
            Key = key;
            Value = property;
        }

        public string Key
        {
            get { return key; }
            set
            {
                if (string.Equals(key, value))
                {
                    return;
                }
                key = value;
                OnPropertyChanged("Key");
            }
        }

        public string Value
        {
            get { return value; }
            set
            {
                if (string.Equals(this.value, value))
                {
                    return;
                }
                this.value = value;
                OnPropertyChanged("Value");
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

        public void ReadProperty(IDataReader reader)
        {
            Key = reader.ReadUTF();
            Value = reader.ReadUTF();
        }

        public void WriteProperty(IDataWriter writer)
        {
            writer.WriteUTF(Key);
            writer.WriteUTF(Value);
        }
    }
}