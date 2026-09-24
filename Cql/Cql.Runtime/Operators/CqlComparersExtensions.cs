/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Operators
{
    /// <summary>
    /// Extension class for configuring comparers for the Cql types.
    /// </summary>
    internal static class CqlComparersExtensions
    {
        /// <summary>
        /// Add comparison operators for the CQL primitive datatypes.
        /// </summary>
        internal static CqlComparers AddIntervalComparisons(this CqlComparers Comparers, ICqlOperators operators) =>
            Comparers
                .Register(typeof(CqlInterval<int?>), new IntervalComparer<int?>(Comparers, operators.Predecessor, operators.Successor, operators.MinValue<int?>, operators.MaxValue<int?>))
                .Register(typeof(CqlInterval<long?>), new IntervalComparer<long?>(Comparers, operators.Predecessor, operators.Successor, operators.MinValue<long?>, operators.MaxValue<long?>))
                .Register(typeof(CqlInterval<decimal?>), new IntervalComparer<decimal?>(Comparers, operators.Predecessor, operators.Successor, operators.MinValue<decimal?>, operators.MaxValue<decimal?>))
                .Register(typeof(CqlInterval<CqlQuantity>), new IntervalComparer<CqlQuantity?>(Comparers, operators.Predecessor, operators.Successor, operators.MinValue<CqlQuantity?>, operators.MaxValue<CqlQuantity?>))
                .Register(typeof(CqlInterval<CqlDateTime>), new IntervalComparer<CqlDateTime?>(Comparers, operators.Predecessor, operators.Successor, operators.MinValue<CqlDateTime?>, operators.MaxValue<CqlDateTime?>))
                .Register(typeof(CqlInterval<CqlDate>), new IntervalComparer<CqlDate?>(Comparers, operators.Predecessor, operators.Successor, operators.MinValue<CqlDate?>, operators.MaxValue<CqlDate?>))
                .Register(typeof(CqlInterval<CqlTime>), new IntervalComparer<CqlTime?>(Comparers, operators.Predecessor, operators.Successor, operators.MinValue<CqlTime?>, operators.MaxValue<CqlTime?>))
                // An interval over Any carries only null boundaries, which have no successor or predecessor.
                .Register(typeof(CqlInterval<object>), new IntervalComparer<object>(Comparers, static _ => null!, static _ => null!, operators.MinValue<object>, operators.MaxValue<object>));
    }
}
