using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Hl7.Cql.CqlToElm
{
    internal record ConversionResult<T>(T Result, ConversionCost Cost, string? Error = null)
    {
        public bool Success => Cost != ConversionCost.Incompatible && Error is null;
    }
}

