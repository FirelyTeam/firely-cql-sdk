using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Poco.Fhir
{

    public abstract class EntryCollection<TEntry> : IEntryCollection<TEntry>
    {
        protected EntryCollection(Func<TEntry, object> getResource)
        {
            Entries = new Dictionary<Type, List<TEntry>>();
            GetResource = getResource ?? throw new ArgumentNullException(nameof(getResource));
        }

        public int Count => Entries.Values
            .Cast<ICollection<TEntry>>()
            .SelectMany(l => l)
            .Count();

        public bool IsReadOnly => false;

        public Func<TEntry, object> GetResource { get; }
        private IDictionary<Type, List<TEntry>> Entries { get; }
        
        public void Add(TEntry item)
        {
            if (item != null)
            {
                var resource = GetResource(item);
                if (resource == null)
                    throw new ArgumentException($"Entry has a null resource.  This is not allowed.", nameof(item));
                var resourceType = resource.GetType();
                if (!Entries.TryGetValue(resourceType, out var resourcesOfType))
                {
                    resourcesOfType = new List<TEntry>();
                    Entries.Add(resourceType, resourcesOfType!);
                }
                resourcesOfType!.Add(item);
            }
            else throw new ArgumentNullException(nameof(item));
        }


        public void Clear() => Entries.Clear();

        public bool Contains(TEntry item)
        {
            if (item != null)
            {
                var type = item.GetType();
                if (!Entries.TryGetValue(type, out var resourcesOfType))
                {
                    return resourcesOfType!.Contains(item);
                }
            }
            return false;
        }

        public void CopyTo(TEntry[] array, int arrayIndex)
        {
            var enumerator = GetEnumerator();
            int i = arrayIndex;
            while (enumerator.MoveNext() && i < array.Length)
            {
                array[i] = enumerator.Current;
                i += 1;
            }
        }

        public IEnumerable<TResource> GetResourcesByType<TResource>() where TResource : class
        {
            if (Entries.TryGetValue(typeof(TResource), out var entries))
            {
                var resources = entries
                    .Select(entry => GetResource(entry) as TResource);
                return resources!;

            }
            else
            {
                var ofType = Entries.Values
                    .SelectMany(e => e)
                    .Select(e => GetResource(e))
                    .OfType<TResource>();
                return ofType;
            }
        }

        public IEnumerator<TEntry> GetEnumerator() =>
            Entries.Values
            .Cast<ICollection<TEntry>>()
            .SelectMany(l => l)
            .GetEnumerator();

        public bool Remove(TEntry item)
        {
            if (item != null)
            {
                var type = item.GetType();
                if (Entries.TryGetValue(type, out var entries))
                {
                    return entries!.Remove(item);
                }
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public abstract TResource? GetResourceById<TResource>(string id) where TResource : class;
        public abstract TResource? GetResourceByUrl<TResource>(string url) where TResource : class;
    }
}
