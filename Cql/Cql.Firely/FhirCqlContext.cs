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
using Hl7.Cql.Iso8601;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Introspection;
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
            DefinitionDictionary<Delegate>? delegates = null,
            FhirCqlContextOptions? options = null)
        {
            options ??= FhirCqlContextOptions.Default;
            ICqlOperators cqlOperators = CreateOperators(dataSource, valueSets, now, options);
            CqlContext cqlContext = new CqlContext(cqlOperators, parameters, delegates);
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
            CqlComparers comparers = new CqlComparers();
            FhirTypeResolver typeResolver = FhirTypeResolver.Default;
            IUnitConverter unitConverter = UnitConverter.Default;
            FhirEnumComparer fhirEnumComparer = FhirEnumComparer.Default;
            CqlOperators operators = CqlOperators.Create(
                typeResolver,
                typeConverter,
                dataSource,
                comparers,
                valueSets,
                unitConverter,
                nowIso8601,
                fhirEnumComparer);

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
            DefinitionDictionary<Delegate>? delegates = null,
            FhirCqlContextOptions? options = null)
        {
            IDataSource source = CreateDataSource(bundle, valueSets);
            CqlContext result = WithDataSource(source, parameters, valueSets, now, delegates, options);
            return result;
        }

        private static IDataSource CreateDataSource(Bundle? bundle, IValueSetDictionary? valueSets) =>
            bundle is not null ?
                new BundleDataSource(bundle, valueSets ?? new HashValueSetDictionary()) :
                new CompositeDataSource();

        /// <summary>
        /// Factory method for creating a setup of the engine with the given <see cref="IDataSource"/>.
        /// </summary>
        public static CqlContext WithDataSource(
            IDataSource? source = null,
            IDictionary<string, object>? parameters = null,
            IValueSetDictionary? valueSets = null,
            DateTimeOffset? now = null,
            DefinitionDictionary<Delegate>? delegates = null,
            FhirCqlContextOptions? options = null)
        {
            CqlContext result = CreateContext(source, parameters, valueSets, now, delegates, options);
            return result;
        }
    }
}
