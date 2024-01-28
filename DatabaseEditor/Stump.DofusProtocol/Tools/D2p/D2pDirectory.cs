using System.Collections.Generic;
using System.Linq;

namespace Stump.DofusProtocol.D2oClasses.Tools.D2p
{
    public class D2pDirectory
    {
        private string m_name;

        private D2pDirectory m_parent;

        public D2pDirectory(D2pFile container, string name)
        {
            Container = container;
            Name = name;
            FullName = name;
        }

        public D2pFile Container { get; set; }

        public Dictionary<string, D2pDirectory> Directories { get; set; } = new Dictionary<string, D2pDirectory>();

        public List<D2pEntry> Entries { get; set; } = new List<D2pEntry>();

        public string FullName { get; private set; }

        public bool IsRoot
        {
            get { return Parent == null; }
        }

        public string Name
        {
            get { return m_name; }
            internal set
            {
                m_name = value;
                UpdateFullName();
            }
        }

        public D2pDirectory Parent
        {
            get { return m_parent; }
            set
            {
                m_parent = value;
                UpdateFullName();
            }
        }

        public IEnumerable<D2pEntry> GetAllEntries()
        {
            var d2pEntries =
                Entries.Concat(Directories.SelectMany((KeyValuePair<string, D2pDirectory> x) => x.Value.GetAllEntries()));
            return d2pEntries;
        }

        public bool HasDirectory(string directory)
        {
            return Directories.ContainsKey(directory);
        }

        public bool HasEntry(string entryName)
        {
            var flag = Entries.Any((D2pEntry entry) => entry.FullFileName == entryName);
            return flag;
        }

        public D2pDirectory TryGetDirectory(string name)
        {
            D2pDirectory d2pDirectory;
            D2pDirectory d2pDirectory1;
            if (!Directories.TryGetValue(name, out d2pDirectory))
            {
                d2pDirectory1 = null;
            }
            else
            {
                d2pDirectory1 = d2pDirectory;
            }
            return d2pDirectory1;
        }

        public D2pEntry TryGetEntry(string entryName)
        {
            var d2pEntry = Entries.SingleOrDefault((D2pEntry entry) => entry.FullFileName == entryName);
            return d2pEntry;
        }

        private void UpdateFullName()
        {
            var parent = this;
            FullName = parent.Name;
            while (parent.Parent != null)
            {
                FullName = FullName.Insert(0, string.Concat(parent.Parent.Name, "\\"));
                parent = parent.Parent;
            }
        }
    }
}