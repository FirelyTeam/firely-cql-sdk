/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Hl7.Fhir.Model;

#nullable enable

namespace Hl7.Cql.Fhir
{
    internal class IndexedBundle
    {
        public IndexedBundle(IEnumerable<Bundle.EntryComponent> entries)
        {
            Entries = entries;

            foreach (var entry in entries)
            {
                var type = entry.Resource.GetType();
                while (type != typeof(object) && type != null)
                {
                    if (!_byType.TryGetValue(type, out var resources))
                    {
                        resources = new List<Resource>();
                        _byType.Add(type, resources);
                    }
                    resources.Add(entry.Resource);
                    type = type.BaseType;
                }
            }
        }

        public IEnumerable<Bundle.EntryComponent> Entries { get; }

        private readonly Dictionary<Type, List<Resource>> _byType = new();

        public IEnumerable<T> FilterByType<T>() =>
            _byType.TryGetValue(typeof(T), out var resources)
                ? resources.Cast<T>()
                : [];

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