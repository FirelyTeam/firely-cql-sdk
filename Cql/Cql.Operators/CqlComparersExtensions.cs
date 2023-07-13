﻿/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace Cql.Operators
{
    public static class CqlComparersExtensions
    {
        public static CqlComparers AddIntervalComparisons(this CqlComparers Comparers, ICqlOperators operators) =>
            Comparers
                .Register(typeof(CqlInterval<int?>), new IntervalComparer<int?>(Comparers, operators.Predecessor, operators.Successor))
                .Register(typeof(CqlInterval<long?>), new IntervalComparer<long?>(Comparers, operators.Predecessor, operators.Successor))
                .Register(typeof(CqlInterval<decimal?>), new IntervalComparer<decimal?>(Comparers, operators.Predecessor, operators.Successor))
                .Register(typeof(CqlInterval<CqlQuantity>), new IntervalComparer<CqlQuantity?>(Comparers, operators.Predecessor, operators.Successor))
                .Register(typeof(CqlInterval<CqlDateTime>), new IntervalComparer<CqlDateTime?>(Comparers, operators.Predecessor, operators.Successor))
                .Register(typeof(CqlInterval<CqlDate>), new IntervalComparer<CqlDate?>(Comparers, operators.Predecessor, operators.Successor))
                .Register(typeof(CqlInterval<CqlTime>), new IntervalComparer<CqlTime?>(Comparers, operators.Predecessor, operators.Successor));
    }
}
