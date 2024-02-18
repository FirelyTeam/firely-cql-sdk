using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    internal record SignatureMatchResult(FunctionDef Function,
        ConversionResult<Expression>[] Arguments,
        IDictionary<string, TypeSpecifier> GenericInferences, SignatureMatchFlags Flags = SignatureMatchFlags.None,
        string? Error = null)
    {
        public ConversionCost MostExpensive => Arguments.Length == 0 ? ConversionCost.ExactMatch : Arguments.Max(op => op.Cost);
        public int TotalCost => Arguments.Sum(op => (int)op.Cost);
        public bool Compatible => Error is null && Flags == SignatureMatchFlags.None && Arguments.All(op => op.Cost != ConversionCost.Incompatible);
        public bool HasTooFewArguments => Flags.HasFlag(SignatureMatchFlags.TooFewArguments);
        public bool HasTooManyArguments => Flags.HasFlag(SignatureMatchFlags.TooManyArguments);
    }

    [Flags]
    internal enum SignatureMatchFlags
    {
        None = 0,
        TooFewArguments = 0x1,
        TooManyArguments = 0x2,
        Ambiguous = 0x4
    }
}

