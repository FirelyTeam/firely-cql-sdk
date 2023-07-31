﻿/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Cql.Operators;
using Hl7.Cql.Comparers;
using Hl7.Cql.Conversion;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Operators;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Firely
{
    public static class FirelyCqlContext
    {


        public static CqlContext Create(Bundle? bundle = null,
            IReadOnlyDictionary<string, object>? parameters = null,
            IValueSetDictionary? valueSets = null,
            DateTimeOffset? now = null,
            DefinitionDictionary<Delegate>? delegates = null)
        {
            valueSets ??= new InMemoryValueSetDictionary();
            var unitConverter = new UnitConverter();
            var typeResolver = new FirelyTypeResolver(Hl7.Fhir.Model.ModelInfo.ModelInspector);
            IDataRetriever dataRetriever = bundle != null
                ? new BundleDataRetriever(bundle, valueSets, typeResolver)
                : new CompositeDataRetriever();

            var cqlComparers = new CqlComparers();
            var operators = CqlOperators.Create(typeResolver,
                FirelyTypeConverter.Create(Fhir.Model.ModelInfo.ModelInspector),
                dataRetriever,
                cqlComparers,
                valueSets,
                null,
                new DateTimeIso8601(now ?? DateTimeOffset.UtcNow, DateTimePrecision.Millisecond));
            cqlComparers.AddIntervalComparisons(operators);
            var ctx = new CqlContext(operators, delegates, parameters);
            return ctx;
        }
    }
}
