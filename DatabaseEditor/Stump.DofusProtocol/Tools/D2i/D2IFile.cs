using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Stump.Core.IO;

namespace Stump.DofusProtocol.D2oClasses.Tools.D2i
{
    public class D2IFile
    {
        //caches
        private readonly Dictionary<int, string> _cache = new Dictionary<int, string>();
        private readonly Dictionary<string, string> _cacheTexts = new Dictionary<string, string>();
        //index stuff
        private readonly Dictionary<int, int> _indexes = new Dictionary<int, int>();


        private readonly BigEndianReader _reader;
        private readonly Dictionary<string, int> _textIndexes = new Dictionary<string, int>();

        //sort ellements ?? 
        private readonly Dictionary<int, int> _textSortIndexes = new Dictionary<int, int>();

        private readonly Dictionary<int, Tuple<bool, int>> _unDiacriticalIndexes =
            new Dictionary<int, Tuple<bool, int>>();

        public D2IFile(string uri)
        {
            FilePath = uri;
            _reader = new BigEndianReader(File.OpenRead(FilePath));
            Initialize();
        }

        public string FilePath { get; }

        private void Initialize()
        {
            var indexesPointer = _reader.ReadInt(); //index offset
            _reader.Seek(indexesPointer, SeekOrigin.Begin);

            long indexesLength = _reader.ReadInt();
            var i = 0;
            while (i < indexesLength) //texts
            {
                var key = _reader.ReadInt();
                var dialectCriticalText = _reader.ReadBoolean();
                var pointer = _reader.ReadInt();

                _indexes.Add(key, pointer);

                if (dialectCriticalText)
                {
                    i += 4;
                    _unDiacriticalIndexes.Add(key, Tuple.Create(true, _reader.ReadInt()));
                }
                else
                {
                    _unDiacriticalIndexes.Add(key, Tuple.Create(false, pointer));
                }
                i += 9;
            }

            indexesLength = _reader.ReadInt();
            while (indexesLength > 0) //ui texts
            {
                var position = _reader.Position;
                _textIndexes.Add(_reader.ReadUTF(), _reader.ReadInt());
                indexesLength = indexesLength - (_reader.Position - position);
            }

            indexesLength = _reader.ReadInt();
            i = 0;
            while (indexesLength > 0) //texts sorts
            {
                var position = _reader.Position;
                _textSortIndexes.Add(_reader.ReadInt(), i++);
                indexesLength = indexesLength - (_reader.Position - position);
            }

            foreach (var key in _indexes.Keys)
            {
                GetText(key);
            }

            foreach (var textKey in _textIndexes.Keys)
            {
                GetText(textKey);
            }

            _reader.Dispose();
        }

        public int getOrderIndex(int index)
        {
            return _textSortIndexes[index];
        }

        public string GetText(int key)
        {
            if (!_cache.ContainsKey(key))
            {
                if (_indexes.ContainsKey(key))
                {
                    var pointer = _indexes[key];
                    _reader.Seek(pointer, SeekOrigin.Begin);
                    _cache.Add(key, _reader.ReadUTF());
                }
                else
                {
                    _cache.Add(key, "{null}");
                }
            }
            return _cache[key];
        }


        public string GetText(string key)
        {
            if (!_cacheTexts.ContainsKey(key))
            {
                if (_textIndexes.ContainsKey(key))
                {
                    var pointer = _textIndexes[key];
                    _reader.Seek(pointer, SeekOrigin.Begin);
                    _cacheTexts.Add(key, _reader.ReadUTF());
                }
                else
                {
                    _cacheTexts.Add(key, "{null}");
                }
            }
            return _cacheTexts[key];
        }

        public void SetText(uint key, string value)
        {
            SetText((int) key, value);
        }

        public void SetText(int key, string value)
        {
            if (_cache.ContainsKey(key))
            {
                _cache[key] = value;
            }
        }

        public void SetText(string key, string value)
        {
            if (_cacheTexts.ContainsKey(key))
            {
                _cacheTexts[key] = value;
            }
        }

        public Dictionary<int, string> GetAllText()
        {
            return _cache;
        }

        public Dictionary<string, string> GetAllUiText()
        {
            return _cacheTexts;
        }

        public void Save()
        {
            Save(FilePath);
        }

        public void Save(string uri)
        {
            File.Delete(uri);
            var writer = new BigEndianWriter();
            writer.Seek(4, SeekOrigin.Begin);

            var newIndexes = new Dictionary<int, long>();
            var newTextIndexes = new Dictionary<string, long>();
            foreach (var oldIndex in _indexes)
            {
                newIndexes.Add(oldIndex.Key, writer.Position);
                writer.WriteUTF(GetText(oldIndex.Key));
            }
            foreach (var oldIndex in _textIndexes)
            {
                newTextIndexes.Add(oldIndex.Key, writer.Position);
                writer.WriteUTF(GetText(oldIndex.Key));
            }

            var oldPos = writer.Position; //end of the strings and start of the indexes
            writer.Seek(0, SeekOrigin.Begin);
            writer.WriteInt((int) oldPos);
            writer.Seek((int) oldPos, SeekOrigin.Begin);

            var subWriter = new BigEndianWriter();
            foreach (var newIndex in newIndexes)
            {
                Tuple<bool, int> newUnDiacriticalIndex;
                _unDiacriticalIndexes.TryGetValue(newIndex.Key, out newUnDiacriticalIndex);

                subWriter.WriteInt(newIndex.Key); //id
                // ReSharper disable once PossibleNullReferenceException
                subWriter.WriteBoolean(newUnDiacriticalIndex.Item1); //dialectCriticalText
                subWriter.WriteInt((int) newIndex.Value); //position

                if (newUnDiacriticalIndex.Item1)
                {
                    subWriter.WriteInt(newUnDiacriticalIndex.Item2);
                }
            }
            var subData = subWriter.Data;
            writer.WriteInt(subData.Length);
            writer.WriteBytes(subData);

            subWriter.Clear();
            foreach (var textIndex in newTextIndexes)
            {
                subWriter.WriteUTF(textIndex.Key);
                subWriter.WriteInt((int) textIndex.Value);
            }
            subData = subWriter.Data;
            writer.WriteInt(subData.Length);
            writer.WriteBytes(subData);

            subWriter.Clear();
            foreach (var textSortIndex in newIndexes)
            {
                subWriter.WriteInt(textSortIndex.Key);
            }
            subData = subWriter.Data;
            writer.WriteInt(subData.Length);
            writer.WriteBytes(subData);

            File.WriteAllBytes(uri, writer.Data);
            writer.Dispose();
        }

        public bool DeleteText(uint key)
        {
            return DeleteText((int) key);
        }

        public bool DeleteText(int key)
        {
            return _cache.Remove(key);
        }

        public bool DeleteText(string key)
        {
            return _cacheTexts.Remove(key);
        }

        public int FindFreeId()
        {
            return _indexes.Keys.Max() + 1;
        }

        public void Dispose()
        {
            _reader.Dispose();
        }
    }
}