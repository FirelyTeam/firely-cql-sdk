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
            Entries = entries.ToList();

            foreach (var entry in Entries.Where(e => e.Resource != null))
            {
                var type = entry.Resource!.GetType();
                while (type != typeof(object) && type != null)
                {
                    if (!_byType.TryGetValue(type, out var resources))
                    {
                        resources = [];
                        _byType.Add(type, resources);
                    }
                    resources.Add(entry.Resource);
                    type = type.BaseType;
                }
            }
        }

        public IEnumerable<Bundle.EntryComponent> Entries { get; }

        private readonly Dictionary<Type, List<Resource>> _byType = new();

        // The codings of every resource, extracted once and reused by subsequent retrieves over this
        // (immutable) bundle. The key includes the retrieved type because a resource is indexed under its
        // base types as well, and the primary code path is determined by the type being retrieved.
        private readonly ConcurrentDictionary<Type, CodedResource[]> _codedByType = new();

        // Idem, for retrieves that specify the property holding the codes.
        private readonly ConcurrentDictionary<(Type Type, PropertyInfo Property), CodedResource[]> _codedByProperty = new();

        private readonly record struct CodedResource(Resource Resource, Coding[] Codings);

        public IEnumerable<T> FilterByType<T>() =>
            _byType.TryGetValue(typeof(T), out var resources)
                ? resources.Cast<T>()
                : [];

        public IEnumerable<T> FilterByType<T>(Predicate<Coding> filter) =>
            Filter<T>(
                _codedByType.GetOrAdd(typeof(T), static (_, self) => self.ExtractCodings<T>(static candidate => candidate is ICoded coded ? coded.ToCodings() : []), this),
                filter
            );

        public IEnumerable<T> FilterByType<T>(Predicate<Coding> filter, PropertyInfo codeProperty, Func<T, IEnumerable<Coding>> getCodes) =>
            Filter<T>(
                _codedByProperty.GetOrAdd((typeof(T), codeProperty), (_, state) => state.Self.ExtractCodings(state.GetCodes), (Self: this, GetCodes: getCodes)),
                filter
            );

        private static IEnumerable<T> Filter<T>(CodedResource[] candidates, Predicate<Coding> filter)
        {
            foreach (var candidate in candidates)
            {
                // Yield each candidate at most once, even when multiple codings match the filter.
                if (Array.Exists(candidate.Codings, filter))
                    yield return (T)(object)candidate.Resource;
            }
        }

        private CodedResource[] ExtractCodings<T>(Func<T, IEnumerable<Coding>> getCodes) =>
            _byType.TryGetValue(typeof(T), out var resources)
                ? resources.Select(resource => new CodedResource(resource, getCodes((T)(object)resource).ToArray())).ToArray()
                : [];
    }
}

#nullable disable