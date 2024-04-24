using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    internal static class SkippedTests
    {
        internal static Dictionary<string, string> Map = new()
        {
            { "EquivEqCM1M01", "Mixed unit equivalence is not supported." },
            { "Power2ToNeg2", "Power returns integers, not decimals." },
            { "RoundNeg0D5", "This rounding test doesn't behave like the others." },
            { "RoundNeg1D5", "This rounding test doesn't behave like the others." },
            { "Multiply1CMBy2CM", "Unit arithmetic is not supported." },
            { "TruncatedDivide10d1ByNeg3D1Quantity", "Unit arithmetic is not supported." },
            { "TestCollapseNull", "Collapse should not be supported for Interval<Any>." },
            { "TestNullElement1", "This expression is ambiguous between the List and Interval overloads." },
            { "In1Null", "This expression is ambiguous between the List and Interval overloads." },
            { "EquivalentABCAnd123", "Equivalent is not defined for two disparate list types." },
            { "Equivalent123AndABC",  "Equivalent is not defined for two disparate list types." },
            { "Equivalent123AndString123",  "Equivalent is not defined for two disparate list types." },
            { "NotEqualABCAnd123",  "Equal is not defined for two disparate list types." },
            { "NotEqual123AndABC",  "Equal is not defined for two disparate list types." },
            { "NotEqual123AndString123",  "Equal is not defined for two disparate list types." },
            { "CodeToConcept1", "The expectation requires ListPromotion to be enabled to evaluate properly." },
            { "Decimal10Pow28ToZeroOneStepDecimalMaxValue", "The spec requires decimals to have no more than 28 total digits; this test has 36." },
            { "DecimalPos10Pow28ToZeroOneStepDecimalMaxValue", "The spec requires decimals to have no more than 28 total digits; this test has 36." },
            { "DecimalNeg10Pow28ToZeroOneStepDecimalMinValue", "The spec requires decimals to have no more than 28 total digits; this test has 36." },
        }; 
    }
}
