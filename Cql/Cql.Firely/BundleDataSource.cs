/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir
{
    /// <summary>
    /// A <see cref="IDataSource"/> that uses POCO Bundles as a source of information.
    /// </summary>
    /// <remarks>
    /// <para>A simple model that assumes the Bundles contain all the information about a
    /// patient, e.g. as the result of a $everything operation.</para>
    /// <para>The index built over the bundle is complete once the constructor returns and is read-only from then on,
    /// so it supports any number of concurrent readers. <see cref="WithValueSets"/> hands out an extra source over
    /// that same index: the index for a bundle can be built once and reused by cheap, short-lived sources that each
    /// bind their own <see cref="IValueSetDictionary"/>. An individual source is only as thread-safe as the value
    /// sets it is bound to, so a source bound to scoped value sets must not outlive or leave that scope.</para>
    /// </remarks>
    internal class BundleDataSource : IDataSource
    {
        /// <summary>
        /// Construct a new source passing in the necessary terminology information
        /// </summary>
        /// <param name="bundle"></param>
        /// <param name="valueSets"></param>
        /// <param name="codeComparer"></param>
        /// <param name="systemComparer"></param>
        /// <param name="profileFilter"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public BundleDataSource(Bundle bundle,
            IValueSetDictionary valueSets,
            ICqlComparer<string>? codeComparer = null,
            ICqlComparer<string>? systemComparer = null,
            IRetrieveProfileFilter? profileFilter = null)
        {
            ValueSets = valueSets ?? throw new ArgumentNullException(nameof(valueSets));
            _codeComparer = codeComparer ?? DefaultStringComparer.Value;
            _systemComparer = systemComparer ?? DefaultStringComparer.Value;
            _usesDefaultComparers = ReferenceEquals(_codeComparer, DefaultStringComparer.Value) && ReferenceEquals(_systemComparer, DefaultStringComparer.Value);
            _profileFilter = profileFilter ?? QICoreRetrieveProfileFilter.Default;
            Bundle = bundle is not null ? new IndexedBundle(bundle.Entry) : throw new ArgumentNullException(nameof(bundle));
        }

        /// <summary>
        /// Construct a source over the index of <paramref name="source"/>, binding different value sets
        /// and an optional profile filter override.
        /// </summary>
        private BundleDataSource(BundleDataSource source, IValueSetDictionary valueSets, IRetrieveProfileFilter? profileFilter)
        {
            ValueSets = valueSets;
            _codeComparer = source._codeComparer;
            _systemComparer = source._systemComparer;
            _usesDefaultComparers = source._usesDefaultComparers;
            _profileFilter = profileFilter ?? source._profileFilter;
            Bundle = source.Bundle;
        }

        /// <summary>
        /// Returns a source that shares this source's index over the bundle, but resolves value set membership
        /// through <paramref name="valueSets"/>, and optionally applies a different profile filter.
        /// </summary>
        /// <remarks>
        /// Building the index is the expensive part of constructing a source and the result is immutable, so the
        /// returned source is cheap and needs no pass over the bundle's entries. Any number of them may read from
        /// the shared index concurrently. The returned source captures <paramref name="valueSets"/> permanently and
        /// is therefore bound to the lifetime of those value sets, while the source it was cloned from is not.
        /// When <paramref name="profileFilter"/> is <see langword="null"/> the source's own filter is kept;
        /// otherwise the supplied filter takes precedence.
        /// </remarks>
        /// <param name="valueSets">The value sets the returned source resolves value set membership through.</param>
        /// <param name="profileFilter">
        /// An optional profile filter override. When non-<see langword="null"/>, replaces the filter on this source
        /// for the returned clone; when <see langword="null"/>, the source's own filter is inherited.
        /// </param>
        /// <exception cref="ArgumentNullException">When <paramref name="valueSets"/> is <see langword="null"/>.</exception>
        public BundleDataSource WithValueSets(IValueSetDictionary valueSets, IRetrieveProfileFilter? profileFilter = null)
        {
            if (valueSets is null) throw new ArgumentNullException(nameof(valueSets));

            return ReferenceEquals(valueSets, ValueSets) &&
                   (profileFilter is null || ReferenceEquals(profileFilter, _profileFilter))
                ? this
                : new BundleDataSource(this, valueSets, profileFilter);
        }

        private static readonly Lazy<ICqlComparer<string>> DefaultStringComparer = new(() =>
            new StringCqlComparer(StringComparer.OrdinalIgnoreCase));

        /// <summary>
        /// A sentinel value-set dictionary that throws on use so that a source created by
        /// <see cref="FhirCqlContext.DataSourceForBundle"/> fails loudly when it is used without first
        /// being passed to <see cref="FhirCqlContext.WithDataSource"/> with actual value sets.
        /// </summary>
        internal static readonly IValueSetDictionary UnboundSentinel = new UnboundValueSetDictionary();

        private sealed class UnboundValueSetDictionary : IValueSetDictionary
        {
            private static InvalidOperationException Fail() => new(
                "This data source was created by FhirCqlContext.DataSourceForBundle and holds no value sets. " +
                "Pass it to FhirCqlContext.WithDataSource together with an IValueSetDictionary before use.");

            public bool IsCodeInValueSet(string valueSetUri, CqlCode code) => throw Fail();
            public bool IsCodeInValueSet(string valueSetUri, string code) => throw Fail();
            public bool IsCodeInValueSet(string valueSetUri, string code, string? system) => throw Fail();
            public bool TryGetCodesInValueSet(string valueSetUri, out IEnumerable<CqlCode>? codes) => throw Fail();
        }

        /// <summary>
        /// The index over the bundle's entries, shared with every source created from this one through
        /// <see cref="WithValueSets"/>.
        /// </summary>
        internal IndexedBundle Bundle { get; }

        private IValueSetDictionary ValueSets { get; }

        private readonly ICqlComparer<string> _codeComparer;
        private readonly ICqlComparer<string> _systemComparer;
        private readonly bool _usesDefaultComparers;
        private readonly IRetrieveProfileFilter _profileFilter;

#if VNEXT
        /// <inheritdoc/>
        /// <remarks>Since it is not possible to monitor changes in a FHIR POCO, this source will not trigger when
        /// external changes are made to the Bundle.</remarks>
        public event EventHandler? DataChanged;
#endif

        /// <inheritdoc/>
        /// <remarks>
        /// The result is fully evaluated before it is returned. Callers walk a retrieve repeatedly — a cached
        /// definition read from several expressions, the inner source of a cross join — and this bundle's contents
        /// do not change during an evaluation, so a lazy result would keep re-deciding the same membership question.
        /// </remarks>
        public IEnumerable<T> Retrieve<T>(RetrieveParameters? parameters) where T : class
        {
            var result = parameters switch
            {
                null => Bundle.FilterByType<T>(),
                { Codes: { } codes }   => RetrieveByCodes<T>(codes, parameters.CodeProperty),
                { ValueSet: { } valueSet } => RetrieveByValueSet<T>(valueSet, parameters.CodeProperty),
                _ => Bundle.FilterByType<T>()
            };

            return ApplyProfileFilter(result, parameters?.TemplateId);
        }

        private IReadOnlyList<T> ApplyProfileFilter<T>(IReadOnlyList<T> source, string? templateId) where T : class
        {
            if (templateId is null || _profileFilter.GetFilter(templateId) is not { } filter)
                return source;

            List<T>? kept = null;
            foreach (var instance in source)
            {
                if (instance is not Resource resource || filter(resource))
                    (kept ??= []).Add(instance);
            }

            return (IReadOnlyList<T>?)kept ?? [];
        }

        /// <inheritdoc/>
        private IReadOnlyList<T> RetrieveByCodes<T>(IEnumerable<CqlCode?> allowedCodes, PropertyInfo? codeProperty = null) where T : class
        {
            Predicate<Coding> filter = allowedCodes switch
            {
                IValueSetFacade valueSet => c => c.Code is { } code && valueSet.IsCodeInValueSet(code, c.System),
                _ when _usesDefaultComparers => BuildSetFilter(allowedCodes),
                _ => listFilter
            };

            return ExecuteFilter<T>(filter, codeProperty);

            bool listFilter(Coding l) => allowedCodes.Any(allowed =>
                allowed is not null &&
                _systemComparer.Equivalent(l.System, allowed.system, null) &&
                _codeComparer.Equivalent(l.Code, allowed.code, null));
        }

        /// <summary>
        /// Builds a filter that looks the coding up in a set, which is equivalent to scanning
        /// <paramref name="allowedCodes"/> with the default comparers, but does not grow with the number of codes.
        /// </summary>
        /// <remarks>
        /// The default comparers consider two strings equivalent when both are null, or when neither is null and
        /// their Unicode normalized forms are equal ignoring case. The set reproduces that: keys hold the
        /// normalized system and code, a null system or code stays null and so only matches another null, and
        /// the keys are compared case-insensitively.
        /// </remarks>
        private static Predicate<Coding> BuildSetFilter(IEnumerable<CqlCode?> allowedCodes)
        {
            var codes = new HashSet<(string? System, string? Code)>(CodeKeyComparer.Instance);

            foreach (var allowed in allowedCodes)
            {
                if (allowed is not null)
                    codes.Add((normalize(allowed.system), normalize(allowed.code)));
            }

            return coding => codes.Contains((normalize(coding.System), normalize(coding.Code)));

            static string? normalize(string? value) => value?.Normalize();
        }

        private sealed class CodeKeyComparer : IEqualityComparer<(string? System, string? Code)>
        {
            public static readonly CodeKeyComparer Instance = new();

            public bool Equals((string? System, string? Code) x, (string? System, string? Code) y) =>
                StringComparer.OrdinalIgnoreCase.Equals(x.System, y.System) &&
                StringComparer.OrdinalIgnoreCase.Equals(x.Code, y.Code);

            public int GetHashCode((string? System, string? Code) obj) =>
                HashCode.Combine(
                    obj.System is null ? 0 : StringComparer.OrdinalIgnoreCase.GetHashCode(obj.System),
                    obj.Code is null ? 0 : StringComparer.OrdinalIgnoreCase.GetHashCode(obj.Code)
                );
        }

        /// <inheritdoc/>
        private IReadOnlyList<T> RetrieveByValueSet<T>(CqlValueSet valueSet, PropertyInfo? codeProperty = null) where T : class
        {
            return valueSet.id != null ?
                       ExecuteFilter<T>(c => c.Code is {} code && ValueSets.IsCodeInValueSet(valueSet.id, code, c.System), codeProperty) :
                       Bundle.FilterByType<T>();
        }

        private IReadOnlyList<T> ExecuteFilter<T>(Predicate<Coding> filter, PropertyInfo? codeProperty) where T : class
        {
            if (codeProperty is null)
            {
                if (!typeof(T).IsAssignableTo(typeof(ICoded)))
                    throw new InvalidOperationException($"When retrieving with a code filter, a primary code path must exist for {typeof(T)}. None is defined.");

                return Bundle.FilterByType<T>(filter);
            }
            else
            {
                var getValue = CompiledPropertyAccessor.For(codeProperty);

                return Bundle.FilterByType<T>(filter, codeProperty, getCodedValues);

                IEnumerable<Coding> getCodedValues(T instance) =>
                    getValue(instance) switch
                    {
                        IEnumerable<DataType> idt => idt.ToCodings(),
                        DataType dt => dt.ToCodings(),
                        _ => []
                    };
            }
        }
    }
}