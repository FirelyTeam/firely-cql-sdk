/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Conversion;
using Hl7.Cql.Fhir.Comparers;
using Hl7.Cql.Fhir.Extensions;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir
{
    /// <summary>
    /// Factory methods to initialize an <see cref="CqlContext"/> that uses the SDK POCO model
    /// as binding for the Cql engine, supplying data using POCO instances.
    /// </summary>
    public static class FhirCqlContext
    {
        internal static CqlContext CreateContext(
            IDataSource? dataSource = null,
            IDictionary<string, object>? parameters = null,
            IValueSetDictionary? valueSets = null,
            DateTimeOffset? now = null,
            FhirCqlContextOptions? options = null)
        {
            options ??= FhirCqlContextOptions.Default;
            ICqlOperators cqlOperators = CreateOperators(dataSource, valueSets, now, options);
            CqlContext cqlContext = new CqlContext(cqlOperators, parameters);

            if (options.EvaluationCache is { } evaluationCache)
                cqlContext.UseNewCache(evaluationCache.InitialCapacity, evaluationCache.ConcurrencyLevel);

            return cqlContext;
        }

        private static ICqlOperators CreateOperators(
            IDataSource? dataSource,
            IValueSetDictionary? valueSets,
            DateTimeOffset? now,
            FhirCqlContextOptions options)
        {
            var typeConverter =
                options.OverrideTypeConverter
                ?? FhirTypeConverter.Create(
                    options.OverrideModelInspector ?? ModelInfo.ModelInspector,
                    options.OverrideFhirTypeConverterCacheSize ?? FhirTypeConverter.DefaultCacheSize);
            DateTimeIso8601? nowIso8601 = now is null ? null : new DateTimeIso8601(now.Value, DateTimePrecision.Millisecond);
            var metricService = options.MetricService;
            CqlComparers comparers = new CqlComparers(metricService);
            FhirTypeResolver typeResolver = FhirTypeResolver.Default;
            IUnitConverter unitConverter = metricService is not null ? new UnitConverter(metricService) : UnitConverter.Default;
            FhirEnumComparer fhirEnumComparer = FhirEnumComparer.Default;
            CqlOperators operators = CqlOperators.Create(
                typeResolver,
                typeConverter,
                dataSource,
                comparers,
                valueSets,
                unitConverter,
                nowIso8601,
                fhirEnumComparer,
                metricService);

            comparers
                .AddIntervalComparisons(operators)
                .AddFhirComparers();

            if (options?.ResourceIdComparer != null)
                comparers.CompareResourcesById(options.ResourceIdComparer);

            if (options?.CodeInOperatorType == FhirCqlContextOptions.CodeInOperatorSemantics.Equivalent)
                comparers.Register(typeof(CqlCode), new CqlCodeCqlEquivalentComparer(StringComparer.OrdinalIgnoreCase));

            return operators;
        }

        /// <summary>
        /// Factory method for creating a setup of the engine with the given <see cref="Bundle"/>.
        /// </summary>
        public static CqlContext ForBundle(
            Bundle? bundle = null,
            IDictionary<string, object>? parameters = null,
            IValueSetDictionary? valueSets = null,
            DateTimeOffset? now = null,
            FhirCqlContextOptions? options = null)
        {
            IDataSource source = CreateDataSource(bundle, valueSets, options);
            CqlContext result = WithDataSource(source, parameters, valueSets, now, options);
            return result;
        }

        private static IDataSource CreateDataSource(Bundle? bundle, IValueSetDictionary? valueSets, FhirCqlContextOptions? options) =>
            bundle is not null ?
                new BundleDataSource(bundle, valueSets ?? new HashValueSetDictionary(),
                    profileFilter: options?.OverrideRetrieveProfileFilter) :
                new CompositeDataSource();

        /// <summary>
        /// Factory method for creating a reusable <see cref="IDataSource"/> over the given <see cref="Bundle"/>,
        /// which can be evaluated against repeatedly through <see cref="WithDataSource"/>.
        /// </summary>
        /// <remarks>
        /// <para>Indexing a bundle costs a pass over its entries, and the retrieves fill caches derived from it.
        /// A host that evaluates the same, unchanging bundle more than once - for instance once per measure group
        /// for the same subject - can build the source once with this method, keep it, and hand it to
        /// <see cref="WithDataSource"/> for every evaluation. The index and its caches are then built once instead
        /// of once per evaluation.</para>
        /// <para>The returned source is bound to an empty value set dictionary, so retrieving from it directly
        /// resolves every value set as empty. Pass it to <see cref="WithDataSource"/> together with value sets
        /// instead: the context then gets a lightweight view over the same index that resolves value set membership
        /// through those value sets, so evaluations that must resolve value sets through different (for instance
        /// request-scoped) terminology are free to share one source. Sharing is safe: the index is read-only once
        /// built and supports any number of concurrent readers.</para>
        /// </remarks>
        /// <param name="bundle">The bundle to index. It is assumed not to change for as long as the returned source is used.</param>
        /// <param name="options">Options to create the source with, of which <see cref="FhirCqlContextOptions.OverrideRetrieveProfileFilter"/> applies here.</param>
        /// <exception cref="ArgumentNullException">When <paramref name="bundle"/> is <see langword="null"/>.</exception>
        public static IDataSource DataSourceForBundle(
            Bundle bundle,
            FhirCqlContextOptions? options = null) =>
            new BundleDataSource(
                bundle ?? throw new ArgumentNullException(nameof(bundle)),
                new HashValueSetDictionary(),
                profileFilter: options?.OverrideRetrieveProfileFilter);

        /// <summary>
        /// Factory method for creating a setup of the engine with the given <see cref="IDataSource"/>.
        /// </summary>
        /// <remarks>
        /// When <paramref name="source"/> is bundle-backed (such as one obtained from
        /// <see cref="DataSourceForBundle"/>) and <paramref name="valueSets"/> is not <see langword="null"/>, the
        /// source is not used directly: the context gets a lightweight view over it that shares its index over the
        /// bundle but resolves value sets through <paramref name="valueSets"/>, so the same source can serve
        /// evaluations with different value sets. Without <paramref name="valueSets"/>, the source is used as-is,
        /// including the value sets it was constructed with.
        /// </remarks>
        public static CqlContext WithDataSource(
            IDataSource? source = null,
            IDictionary<string, object>? parameters = null,
            IValueSetDictionary? valueSets = null,
            DateTimeOffset? now = null,
            FhirCqlContextOptions? options = null)
        {
            IDataSource? boundSource = source is BundleDataSource bundleSource && valueSets is not null
                ? bundleSource.WithValueSets(valueSets)
                : source;
            CqlContext result = CreateContext(boundSource, parameters, valueSets, now, options);
            return result;
        }
    }
}
