/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CqlToElm.Test
{
    internal static class SkippedTests
    {
        internal static Dictionary<string, string> DoesNotCompile = new()
        {
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

<<<<<<< HEAD
            { "CodeToConcept1", "Expectation throws NotImplementedException in VisitInstanceSelector: coercing 'codes:' from a single Code needs ListPromotion." },
=======
            { "CodeToConcept1", "Requires ListPromotion to be enabled; without it translation reports an error because Code cannot be converted to the List<Code> type of Concept.codes." },
>>>>>>> origin/develop

            { "Decimal10Pow28ToZeroOneStepDecimalMaxValue", "The spec requires decimals to have no more than 28 total digits; this test has 36." },
            { "DecimalPos10Pow28ToZeroOneStepDecimalMaxValue", "The spec requires decimals to have no more than 28 total digits; this test has 36." },
            { "DecimalNeg10Pow28ToZeroOneStepDecimalMinValue", "The spec requires decimals to have no more than 28 total digits; this test has 36." },

<<<<<<< HEAD
            { "ExpandPer0D1", "Compiles, but hangs at runtime: Expand of an integer interval with a decimal per loops forever." },
=======
            { "ExpandPer0D1", "Throws NotSupportedException: a fractional per over integer intervals would produce Decimal intervals (value-dependent typing); the reference Java translator rejects this expression at compile time." },
            { "ExpandIntervalPer2", "Not working" },
>>>>>>> origin/develop

            { "TestExceptNull", "This is ambiguous with every valid interval overload." }
        };

        internal static Dictionary<string, string> DoesNotMatchExpectation = new()
        {
            { "DateTimeDurationBetweenMonthUncertain2", "We don't support uncertainty" },
            { "DateTimeDurationBetweenUncertainAdd", "We don't support uncertainty" },
            { "DateTimeDurationBetweenUncertainDiv", "We don't support uncertainty." },
            { "DateTimeDurationBetweenUncertainInterval", "We don't support uncertainty" },
            { "DateTimeDurationBetweenUncertainInterval2", "We don't support uncertainty" },
            { "DateTimeDurationBetweenUncertainMultiply", "We don't support uncertainty" },
            { "DateTimeDurationBetweenUncertainSubtract", "We don't support uncertainty" },
            { "DateTimeDurationBetweenYear", "We don't support uncertainty" },
            { "DateTimeUncertain", "We don't support uncertainty" },
            { "DecimalMaxValue", "Our implementation returns a larger value" },
            { "DecimalMinValue", "Our implementation returns a smaller value" },
            { "EquivEqCM1M01", "Returns false: CqlQuantityCqlComparer.EquivalentValues does not canonicalize UCUM units like CompareValues does." },
            { "ReplaceMatchesSpaces", "Returns 'All\\$that...': .NET keeps backslash escapes in the Regex.Replace substitution literally, unlike Java's Matcher." },
            { "SortDatesAsc", "Sort tests shouldn't contain differing precision" },
            { "SortDatesDesc", "Sort tests shouldn't contain differing precision" },
        };
    }


}
