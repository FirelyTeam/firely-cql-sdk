using System.Collections.Generic;

namespace Hl7.Cql.CqlToElm.Test
{
    internal static class SkippedTests
    {
        internal static Dictionary<string, string> DoesNotCompile = new()
        {
            { "EquivEqCM1M01", "Mixed unit equivalence is not supported." },
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

            { "ExpandPer0D1", "Not working" },
            { "ExpandIntervalPer2", "Not working" },

            { "TestExceptNull", "This is ambiguous with every valid interval overload." },

            { "DescendentsEmptyList", "Not implemented" },

            { "EqualNullNull", "The spec states that null elements are considered equal for list equality." },
            { "ReplaceMatchesSpaces", "The first argument should have four backslashes instead of 2" },

            // This compiler error should be repaired by https://github.com/FirelyTeam/firely-cql-sdk/issues/542
            { "Issue32DateTime", "We incorrectly compile a DateTime to an interval without a point type." }
        };

        internal static Dictionary<string, string> DoesNotMatchExpectation = new()
        {

            { "ExpandPerHour", "The expectation does not match the same example as published in the specification." },
            { "ExpandPer1", "The expectation should have decimal values, not integers; the test does not compile in reference cql-to-elm." },
            { "ProperContainsTimeNull", "There is no spec language justifying null instead of false." },
            { "ProperInTimeNull", "There is no spec language justifying null instead of false." },
            { "SortDatesAsc", "Sort tests shouldn't contain differing precision." },
            { "SortDatesDesc", "Sort tests shouldn't contain differing precision." },

            { "DecimalMinValue", "Our implementation returns a smaller value." },
            { "DecimalMaxValue", "Our implementation returns a larger value." },
            { "Power2ToNeg2", "Power returns integers, not decimals." },
            { "DecimalOneStep", "Power returns integers, not decimals." },
            { "DecimalPosOneStep", "Power returns integers, not decimals." },
            { "DecimalTwoStep", "Power returns integers, not decimals." },
            { "DecimalPosTwoStep", "Power returns integers, not decimals." },
            { "DecimalNegTwoStep", "Power returns integers, not decimals." },
            { "DecimalTenStep", "Power returns integers, not decimals." },
            { "DecimalPosTenStep", "Power returns integers, not decimals." },
            { "DecimalNegTenStep", "Power returns integers, not decimals." },
            { "DecimalNegOneStep", "Power returns integers, not decimals." },

            { "RoundNeg0D5", "This rounding test doesn't behave like the others." },
            { "RoundNeg1D5", "This rounding test doesn't behave like the others." },

            { "DateTimeDurationBetweenYear", "We don't support uncertainty." },
            { "DateTimeDurationBetweenUncertainInterval", "We don't support uncertainty." },
            { "DateTimeDurationBetweenUncertainInterval2", "We don't support uncertainty." },
            { "DateTimeDurationBetweenUncertainAdd", "We don't support uncertainty." },
            { "DateTimeDurationBetweenUncertainSubtract", "We don't support uncertainty." },
            { "DateTimeDurationBetweenUncertainMultiply", "We don't support uncertainty." },
            { "DateTimeDurationBetweenUncertainDiv", "We don't support uncertainty." },
            { "DateTimeDurationBetweenMonthUncertain2", "We don't support uncertainty." },
            { "DateTimeUncertain", "We don't support uncertainty." },




        };
    }


}
