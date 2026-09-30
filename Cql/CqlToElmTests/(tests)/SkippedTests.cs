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

            { "TestCollapseNull", "Collapse over a list of Interval<Any> is ambiguous with every typed interval overload (#1627)." },
            { "TestNullElement1", "This expression is ambiguous between the List and Interval overloads." },
            { "In1Null", "This expression is ambiguous between the List and Interval overloads." },

            { "EquivalentABCAnd123", "Equivalent is not defined for two disparate list types." },
            { "Equivalent123AndABC",  "Equivalent is not defined for two disparate list types." },
            { "Equivalent123AndString123",  "Equivalent is not defined for two disparate list types." },
            { "NotEqualABCAnd123",  "Equal is not defined for two disparate list types." },
            { "NotEqual123AndABC",  "Equal is not defined for two disparate list types." },
            { "NotEqual123AndString123",  "Equal is not defined for two disparate list types." },

            { "CodeToConcept1", "Requires ListPromotion to be enabled; without it translation reports an error because Code cannot be converted to the List<Code> type of Concept.codes." },

            { "Decimal10Pow28ToZeroOneStepDecimalMaxValue", "The spec requires decimals to have no more than 28 total digits; this test has 36." },
            { "DecimalPos10Pow28ToZeroOneStepDecimalMaxValue", "The spec requires decimals to have no more than 28 total digits; this test has 36." },
            { "DecimalNeg10Pow28ToZeroOneStepDecimalMinValue", "The spec requires decimals to have no more than 28 total digits; this test has 36." },

            { "ExpandPer0D1", "Throws NotSupportedException: a fractional per over integer intervals would produce Decimal intervals (value-dependent typing); the reference Java translator rejects this expression at compile time." },

            { "TestMaxIntervalExceptNull", "Except over two Interval<Any> operands is ambiguous with every typed interval overload (#1627)." },
            { "ExpandListWithNull", "Expand over a List<Any> operand is ambiguous with every typed interval overload (#1627)." },
            { "ExpandEmptyList", "Expand over a List<Any> operand is ambiguous with every typed interval overload (#1627)." },
            { "ExpandNull", "Expand over an Any operand is ambiguous with every typed interval overload (#1627)." },
            { "ExpandPer0D1IntervalOverload", "Throws NotSupportedException: a fractional per over an integer interval would produce Decimal values (value-dependent typing)." },

            { "FloorIntegerLessThanMinInteger", "An integer literal outside the Integer range is not read as a Long literal, so the call has no argument to resolve." },
            { "FloorIntegerGreaterThanMaxInteger", "An integer literal outside the Integer range is not read as a Long literal, so the call has no argument to resolve." },

            { "RatioEqual", "The expression builder does not support Ratio." },
            { "RatioNotEqualDiffNumerator", "The expression builder does not support Ratio." },
            { "RatioNotEqualDiffDenominator", "The expression builder does not support Ratio." },
            { "RatioEquivalent", "The expression builder does not support Ratio." },
            { "RatioNotEquivalentDiffNumerator", "The expression builder does not support Ratio." },
            { "RatioNotEquivalentDiffDenominator", "The expression builder does not support Ratio." },

            { "MegaMultiDistinct", "`aggregate distinct` over a multi-source query binds Distinct with the aggregate's type instead of the source tuple type, and no overload matches." },
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
            { "ReplaceMatchesSpaces", "Returns 'All\\$that...': .NET keeps backslash escapes in the Regex.Replace substitution literally, unlike Java's Matcher." },
            { "SortDatesAsc", "Sort tests shouldn't contain differing precision" },
            { "SortDatesDesc", "Sort tests shouldn't contain differing precision" },

            { "CeilingDecimalLessThanMinInteger", "Throws OverflowException for a result outside the Integer range instead of returning null." },
            { "CeilingDecimalGreaterThanMaxInteger", "Throws OverflowException for a result outside the Integer range instead of returning null." },
            { "CeilingMaxIntegerAsDecimalWhereDecimalIsNonZero", "Throws OverflowException for a result outside the Integer range instead of returning null." },
            { "FloorDecimalLessThanMinInteger", "Throws OverflowException for a result outside the Integer range instead of returning null." },
            { "FloorDecimalGreaterThanMaxInteger", "Throws OverflowException for a result outside the Integer range instead of returning null." },
            { "FloorMinIntegerAsDecimalWhereDecimalIsNonZero", "Throws OverflowException for a result outside the Integer range instead of returning null." },

            { "HighBoundaryNullPrecision", "A null precision returns null instead of the maximum precision of the type." },
            { "LowBoundaryNullPrecision", "A null precision returns null instead of the maximum precision of the type." },

            { "YearsBetweenLeapYearDatesEquals2", "`years between` a 29 February start and 28 February of a year without a leap day is one year short (#1681)." },
            { "YearsBetweenLeapYearDateTimesEquals2", "`years between` a 29 February start and 28 February of a year without a leap day is one year short (#1681)." },

            { "DateSubtract2YearsAsMonthsRem1", "A quantity finer than the date's precision is subtracted at its own precision instead of being truncated to the date's precision first." },
            { "DateTimeSubtract2YearsAsMonthsRem1", "A quantity finer than the date's precision is subtracted at its own precision instead of being truncated to the date's precision first." },
            { "DateSubtract33Days", "A quantity finer than the date's precision is subtracted at its own precision instead of being truncated to the date's precision first." },

            { "DateTimeOverlapsPrecisioLeftPossiblyEndsDuringRight", "Overlaps decides a boundary comparison between DateTimes of different precision instead of leaving it unknown." },
            { "DateTimeOverlapsPrecisionLeftPossiblyStartsDuringRight", "Overlaps decides a boundary comparison between DateTimes of different precision instead of leaving it unknown." },
            { "DateTimeOverlapsPrecisionLeftPossiblyStartsAndEndsDuringRight", "Overlaps decides a boundary comparison between DateTimes of different precision instead of leaving it unknown." },

            { "TestIntersectNull", "Intersect with a null interval boundary returns null instead of the intersection (#1457)." },
            { "TestIntersectNull1", "Intersect with a null interval boundary returns null instead of the intersection (#1457)." },
            { "TestIntersectNull2", "Intersect with a null interval boundary returns null instead of the intersection (#1457)." },
            { "TestIntersectNull3", "Intersect with a null interval boundary returns null instead of the intersection (#1457)." },
            { "TestIntersectNull4", "Intersect with a null interval boundary returns null instead of the intersection (#1457)." },

            { "TestQuantityYearEqualA", "A calendar duration compares as equal to the definite-time UCUM unit 'a' or 'mo' instead of yielding null (#1650)." },
            { "TestQuantityYearNotEqualA", "A calendar duration compares as equal to the definite-time UCUM unit 'a' or 'mo' instead of yielding null (#1650)." },
            { "TestQuantityYearsNotEqualA", "A calendar duration compares as equal to the definite-time UCUM unit 'a' or 'mo' instead of yielding null (#1650)." },
            { "TestQuantityMonthEqualMo", "A calendar duration compares as equal to the definite-time UCUM unit 'a' or 'mo' instead of yielding null (#1650)." },
            { "TestQuantityMonthNotEqualMo", "A calendar duration compares as equal to the definite-time UCUM unit 'a' or 'mo' instead of yielding null (#1650)." },
            { "TestQuantityMonthsNotEqualMo", "A calendar duration compares as equal to the definite-time UCUM unit 'a' or 'mo' instead of yielding null (#1650)." },
            { "TestYearEquivalentDays", "1 year ~ 365 days returns false; a calendar duration is not equivalent to its length in days (#1650)." },
            { "TestMonthEquivalentDays", "1 month ~ 30 days returns false; a calendar duration is not equivalent to its length in days (#1650)." },

            { "TupleEqDifferentNamesWithOneNullId", "Tuple equality returns false when one element differs and another is null; the suite expects null." },
            { "TupleNotEqDifferingNamesWithOneNullId", "Tuple inequality returns true when one element differs and another is null; the suite expects null." },
            { "Equal123AndABC", "Equality of two List<Any> whose elements have different types returns null instead of false." },
            { "Equal123AndString123", "Equality of two List<Any> whose elements have different types returns null instead of false." },
            { "ProperContains1", "`properly includes` with a null list returns null instead of false." },
            { "ProperIn1", "`properly included in` with a null list returns null instead of false." },

            { "SubstringEmptyAnd0", "Returns null, as the specification requires for a startIndex that is out of range (index 0 of an empty string); the suite expects ''." },
        };
    }


}
