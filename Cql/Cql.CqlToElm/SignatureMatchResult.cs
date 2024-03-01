using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    internal record SignatureMatchResult(FunctionDef Function,
        CoercionResult<Expression>[] Arguments,
        IDictionary<string, TypeSpecifier> GenericInferences, SignatureMatchFlags Flags = SignatureMatchFlags.None,
        string? Error = null)
    {
        public CoercionCost MostExpensive => Arguments.Length == 0 ? CoercionCost.ExactMatch : Arguments.Max(op => op.Cost);
        public int TotalCost => Arguments.Sum(op => (int)op.Cost);
        public bool Compatible => Error is null && Flags == SignatureMatchFlags.None && Arguments.All(op => op.Cost != CoercionCost.Incompatible);
        public bool HasTooFewArguments => Flags.HasFlag(SignatureMatchFlags.TooFewArguments);
        public bool HasTooManyArguments => Flags.HasFlag(SignatureMatchFlags.TooManyArguments);
        public bool IsAmbiguous => Flags.HasFlag(SignatureMatchFlags.Ambiguous);

        public override string ToString() =>
            $"{Function} [{(Compatible ? "OK" : "FAIL")}, {Enum.GetName(MostExpensive)}, total={TotalCost}]";
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

