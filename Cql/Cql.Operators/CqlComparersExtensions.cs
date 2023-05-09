using Ncqa.Cql.Comparers;
using Ncqa.Cql.Operators;
using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

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
