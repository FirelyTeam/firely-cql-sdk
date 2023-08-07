using Hl7.Fhir.Model;

#nullable enable

namespace Hl7.Cql.Firely
{
    internal class IndexedBundle
    {
        public IndexedBundle(IEnumerable<Bundle.EntryComponent> entries)
        {
            Entries = entries;

            foreach(var entry in entries)
            {
                var type = entry.Resource.GetType();
                while(type != typeof(object) && type != null)
                {
                    if (!_byType.TryGetValue(type, out var resources))
                    {
                        resources = new LinkedList<Resource>();
                        _byType.Add(type, resources);
                    }
                    resources.AddLast(entry.Resource);
                    type = type.BaseType;
                }
            }
        }

        public IEnumerable<Bundle.EntryComponent> Entries { get; }

        private readonly Dictionary<Type, LinkedList<Resource>> _byType = new();

        public IEnumerable<T> FilterByType<T>()
        {
            if (_byType.TryGetValue(typeof(T), out var resources))
                return resources?.Cast<T>() ?? Enumerable.Empty<T>();
            else return Enumerable.Empty<T>();
        }

        public IEnumerable<T> FilterByType<T>(Predicate<Coding> filter)
        {
            var candidates = FilterByType<T>();

            foreach (var candidate in candidates)
            {
                if (candidate is ICoded codedCandidate)
                {
                    var codings = codedCandidate.ToCodings();
                    foreach (var coding in codings)
                        if (filter(coding)) yield return candidate;
                }
            }
        }

        public IEnumerable<T> FilterByType<T>(Predicate<Coding> filter, Func<T, IEnumerable<Coding>> getCodes)
        {
            var candidates = FilterByType<T>();

            foreach (var candidate in candidates)
            {
                var codings = getCodes.Invoke(candidate);
                foreach (var coding in codings)
                    if (filter(coding)) yield return candidate;
            }
        }

    }
}

#nullable disable