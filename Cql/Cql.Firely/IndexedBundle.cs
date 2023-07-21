using Hl7.Fhir.Model;

#nullable enable

namespace Hl7.Cql.Firely
{
    internal class IndexedBundle
    {
        public IndexedBundle(IEnumerable<Bundle.EntryComponent> entries)
        {
            Entries = entries;

            _byType = Entries.Where(e => e.Resource is not null).ToLookup(e => e.Resource.GetType(), e => e.Resource);
        }

        public IEnumerable<Bundle.EntryComponent> Entries { get; }

        private readonly ILookup<Type, Resource> _byType;

        public IEnumerable<T> FilterByType<T>() => _byType[typeof(T)].Cast<T>();

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
    }
}

#nullable disable