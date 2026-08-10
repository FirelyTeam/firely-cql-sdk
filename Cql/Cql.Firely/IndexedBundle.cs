/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System.Collections.ObjectModel;
using Hl7.Fhir.Model;

#nullable enable

namespace Hl7.Cql.Fhir
{
    /// <summary>
    /// An index over the entries of a bundle, grouping the resources by type so that a retrieve does not have to
    /// scan every entry.
    /// </summary>
    /// <remarks>
    /// The index is complete once the constructor returns and the bundle it indexes is assumed to be immutable, so
    /// an instance supports any number of concurrent readers and may be shared by several
    /// <see cref="BundleDataSource"/>s. The coding caches the retrieves fill on demand are concurrent dictionaries;
    /// two threads racing for the same key may both extract the codings, but they extract the same ones and only
    /// one result is kept.
    /// </remarks>
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

        // Idem, for retrieves that specify the property holding the codes. Keyed by the getter the property
        // resolves to rather than the PropertyInfo instance: FhirModelPropertyInfo wrappers are created anew on
        // every lookup without value equality, so instance keys would neither hit nor keep this cache bounded.
        private readonly ConcurrentDictionary<(Type Type, MemberInfo Property), CodedResource[]> _codedByProperty = new();

        private readonly record struct CodedResource(Resource Resource, Coding[] Codings);

        // The resources of a retrieved type, cast once and reused. A retrieve that has no code filter hands its
        // result straight to the caller, which may walk it repeatedly (a cached definition read from several
        // expressions, the inner source of a cross join), and casting an entire bundle-sized list per walk is
        // pure overhead over this (immutable) bundle. Holds the read-only wrapper rather than the array - see
        // TypedResources. The value type is object because the wrapper's element type differs per entry.
        private readonly ConcurrentDictionary<Type, object> _typedByType = new();

        public IReadOnlyList<T> FilterByType<T>() =>
            (IReadOnlyList<T>)_typedByType.GetOrAdd(typeof(T), static (_, self) => self.TypedResources<T>(), this);

        // The cached instance is handed to callers verbatim, and IDataSource is public, so the array itself must
        // not escape: a consumer casting the result back to T[] and sorting or overwriting it in place would
        // corrupt every later retrieve of that type over this bundle. Wrapping is one allocation per type, and
        // the wrapper is what gets cached, so repeated retrieves still hand back the same instance.
        private ReadOnlyCollection<T> TypedResources<T>()
        {
            T[] typed = _byType.TryGetValue(typeof(T), out var resources)
                ? resources.Cast<T>().ToArray()
                : [];

            return Array.AsReadOnly(typed);
        }

        public IReadOnlyList<T> FilterByType<T>(Predicate<Coding> filter) =>
            Filter<T>(
                _codedByType.GetOrAdd(typeof(T), static (_, self) => self.ExtractCodings<T>(static candidate => candidate is ICoded coded ? coded.ToCodings() : []), this),
                filter
            );

        public IReadOnlyList<T> FilterByType<T>(Predicate<Coding> filter, PropertyInfo codeProperty, Func<T, IEnumerable<Coding>> getCodes) =>
            Filter<T>(
                _codedByProperty.GetOrAdd((typeof(T), CompiledPropertyAccessor.GetterIdentity(codeProperty)), (_, state) => state.Self.ExtractCodings(state.GetCodes), (Self: this, GetCodes: getCodes)),
                filter
            );

        // Runs the filter now rather than returning a lazy sequence that re-runs it on every walk: a retrieve
        // typically feeds a definition whose value is cached and then read many times, and the codings the filter
        // tests are fixed for this (immutable) bundle, so re-running it can only produce the same answer again.
        private static IReadOnlyList<T> Filter<T>(CodedResource[] candidates, Predicate<Coding> filter)
        {
            List<T>? matches = null;
            foreach (var candidate in candidates)
            {
                // Include each candidate at most once, even when multiple codings match the filter.
                if (Array.Exists(candidate.Codings, filter))
                    (matches ??= []).Add((T)(object)candidate.Resource);
            }

            return (IReadOnlyList<T>?)matches ?? [];
        }

        private CodedResource[] ExtractCodings<T>(Func<T, IEnumerable<Coding>> getCodes) =>
            _byType.TryGetValue(typeof(T), out var resources)
                ? resources.Select(resource => new CodedResource(resource, getCodes((T)(object)resource).ToArray())).ToArray()
                : [];
    }
}

#nullable disable