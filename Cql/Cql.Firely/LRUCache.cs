using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Fhir
{
    internal class LRUValue<T>
    {
        public T Value;
        public LRUValue<T>? NextLRU;
        public LRUValue<T>? PrevLRU;
        public string Key;

        public LRUValue(string key, T value)
        {
            Value = value;
            Key = key;
        }
    }

    internal class LRUCache<T>
    {
        private Dictionary<string, LRUValue<T>> Cache;
        private LRUValue<T>? Head;
        private LRUValue<T>? Tail;
        private int Count;
        private int Capacity;

        public LRUCache(int capacity)
        {
            Cache = new Dictionary<string, LRUValue<T>>();
            Count = 0;
            Capacity = capacity;
        }

        public void Touch(LRUValue<T> val)
        {
            if(val.PrevLRU != null)
            {
                val.PrevLRU.NextLRU = val.NextLRU;
                if(val == Tail)
                {
                    Tail = val.PrevLRU;
                }
            }
            if(val.NextLRU != null)
            {
                val.NextLRU.PrevLRU = val.PrevLRU;
            }

            if(Head != null)
            {
                Head.PrevLRU = val;
                val.NextLRU = Head;
                Head = val;
                val.PrevLRU = null;
            }
        }

        public void Insert(string key, T item)
        {
            if (item == null) return;


            lock (Cache)
            {
                if (Cache.ContainsKey(key))
                {
                    Touch(Cache[key]);
                    return;
                }


                if (Head == null)
                {
                    Head = new LRUValue<T>(key, item);
                    Tail = Head;
                    Cache[key] = Head;
                    Count++;
                    return;
                }

                // NOTE(agw): theoretically Tail should never be null here if Count > 0
                if (Count > Capacity && Tail != null)
                {
                    Cache.Remove(Tail.Key, out var _);

                    Tail.Value = item;
                    Tail.Key = key;

                    Cache[key] = Tail;
                    Touch(Tail);
                }
                else
                {
                    var newValue = new LRUValue<T>(key, item);
                    Head.PrevLRU = newValue;
                    newValue.NextLRU = Head;
                    Head = newValue;

                    Cache[key] = newValue;
                    Count++;
                }
            }
        }

        public bool TryGetValue(string key, [MaybeNullWhen(false)] out T value)
        {
            lock (Cache)
            {
                if (key != null && Cache.TryGetValue(key, out var lruValue))
                {
                    value = lruValue.Value;
                    return true;
                }
            }

            value = default;
            return false;
        }
    }
}
