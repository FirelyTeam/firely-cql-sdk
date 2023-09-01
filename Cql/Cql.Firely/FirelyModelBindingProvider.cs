/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Cql.Operators;
using Hl7.Cql.Comparers;
using Hl7.Cql.Conversion;
using Hl7.Cql.Firely.Comparers;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Operators;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;

namespace Hl7.Cql.Firely
{
    /// <summary>
    /// Supplies binding information to the CQL engine on how to use the
    /// .NET SDK's POCOs as data model.
    /// </summary>
    internal class FirelyModelBindingProvider : ICqlModelBindingProvider
    {
        public static readonly FirelyModelBindingProvider Default = new();

        private readonly ModelBindingOptions _options;

        /// <summary>
        /// Creates the binding provider using the given options.
        /// </summary>
        public FirelyModelBindingProvider(ModelBindingOptions options)
        {
            _options = options;
        }

        /// <summary>
        /// Creates the binding provider using default options.
        /// </summary>
        public FirelyModelBindingProvider() : this(ModelBindingOptions.Default)
        {
            // Nothing
        }

        public CqlOperators NewOperators(
            IDataRetriever? retriever,
            IValueSetDictionary? valuesets,
            DateTimeOffset? now)
        {
            var unitConverter = new UnitConverter();
            var typeResolver = FirelyTypeResolver.Default;

            var cqlComparers = new CqlComparers();
            var operators = CqlOperators.Create(
                    typeResolver,
                    FirelyTypeConverter.Default,
                    retriever,
                    cqlComparers,
                    valuesets,
                    unitConverter,
                    now is not null ?
                        new DateTimeIso8601(now.Value, DateTimePrecision.Millisecond) : null,
                    FirelyEnumComparer.Default);

            cqlComparers
                .AddIntervalComparisons(operators)
                .AddFirelyComparers();

            if (_options.ResourceIdComparer != null)
                cqlComparers.CompareResourcesById(_options.ResourceIdComparer);

            return operators;
        }
    }
}
