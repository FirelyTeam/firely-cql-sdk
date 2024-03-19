using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Hl7.Cql.CqlToElm
{
    internal record CoercionResult<T>(T Result, CoercionCost Cost)
    {
        public bool Success => Cost != CoercionCost.Incompatible;
    }
}

