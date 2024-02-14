/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Comparers;
using Hl7.Cql.Conversion;
using Hl7.Cql.Fhir.Comparers;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir
{
    /// <summary>
    /// Supplies binding information to the CQL engine on how to use the
    /// .NET SDK's POCOs as data model.
    /// </summary>
    internal class FhirModelBindingSetup : ModelBindingSetup
    {
        /// <summary>
        /// Creates a model binding for the .NET SDK POCO's given the default 
        /// <see cref="FhirModelBindingOptions"/>.
        /// </summary>
        public FhirModelBindingSetup(
            IDataSource? dataSource,
            IValueSetDictionary? valuesets,
            DateTimeOffset? now,
            FhirModelBindingOptions? options)
        {
            _options = options ?? FhirModelBindingOptions.Default;

            Comparers = new CqlComparers();
            Operators = CqlOperators.Create(
                    TypeResolver,
                    FhirTypeConverter.Create(ModelInfo.ModelInspector, _options.LRUCacheSize),
                    dataSource,
                    Comparers,
                    valuesets,
                    UnitConverter,
                    now is not null ?
                        new DateTimeIso8601(now.Value, DateTimePrecision.Millisecond) : null,
                    FhirEnumComparer.Default);

            Comparers
                .AddIntervalComparisons(Operators)
                .AddFhirComparers();

            if (_options?.ResourceIdComparer != null)
                Comparers.CompareResourcesById(_options.ResourceIdComparer);

            if (_options?.CodeInOperatorType == FhirModelBindingOptions.CodeInOperatorSemantics.Equivalent)
                Comparers.Register(typeof(CqlCode), new CqlCodeCqlEquivalentComparer(StringComparer.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Creates a model binding for the .NET SDK POCO's with the default 
        /// <see cref="FhirModelBindingOptions"/>.
        /// </summary>
        public FhirModelBindingSetup(
            IDataSource? dataSource,
            IValueSetDictionary? valuesets,
            DateTimeOffset? now) : this(dataSource, valuesets, now, FhirModelBindingOptions.Default)
        {
            // Nothing
        }

        private readonly FhirModelBindingOptions? _options;

        public override TypeResolver TypeResolver => FhirTypeResolver.Default;

        public override TypeConverter TypeConverter => FhirTypeConverter.Default;

        public override CqlComparers Comparers { get; }

        public override IUnitConverter UnitConverter => new UnitConverter();

        public override ICqlOperators Operators { get; }
    }
}
