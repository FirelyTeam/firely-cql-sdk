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



            { "DateSubtract2YearsAsMonthsRem1", "A quantity finer than the date's precision is subtracted at its own precision instead of being truncated to the date's precision first." },
            { "DateTimeSubtract2YearsAsMonthsRem1", "A quantity finer than the date's precision is subtracted at its own precision instead of being truncated to the date's precision first." },
            { "DateSubtract33Days", "A quantity finer than the date's precision is subtracted at its own precision instead of being truncated to the date's precision first." },



            { "TestQuantityYearEqualA", "A calendar duration compares as equal to the definite-time UCUM unit 'a' or 'mo' instead of yielding null (#1650)." },
            { "TestQuantityYearNotEqualA", "A calendar duration compares as equal to the definite-time UCUM unit 'a' or 'mo' instead of yielding null (#1650)." },
            { "TestQuantityYearsNotEqualA", "A calendar duration compares as equal to the definite-time UCUM unit 'a' or 'mo' instead of yielding null (#1650)." },
            { "TestQuantityMonthEqualMo", "A calendar duration compares as equal to the definite-time UCUM unit 'a' or 'mo' instead of yielding null (#1650)." },
            { "TestQuantityMonthNotEqualMo", "A calendar duration compares as equal to the definite-time UCUM unit 'a' or 'mo' instead of yielding null (#1650)." },
            { "TestQuantityMonthsNotEqualMo", "A calendar duration compares as equal to the definite-time UCUM unit 'a' or 'mo' instead of yielding null (#1650)." },
            { "TestYearEquivalentDays", "1 year ~ 365 days returns false; the suite expects the calendar-duration conversion the specification lists for equivalence (1 year ~ 365 days), which an implementation is not required to support." },
            { "TestMonthEquivalentDays", "1 month ~ 30 days returns false; the suite expects the calendar-duration conversion the specification lists for equivalence (1 month ~ 30 days), which an implementation is not required to support." },

            { "TupleEqDifferentNamesWithOneNullId", "Conflicting suite expectation: tuple equality is false when one element differs, even if another is null (specification example: { x: 1, y: 1 } = { x: null, y: 2 } is false, and the suite's own TupleEqJohn1John2WithNullName expects false); this case expects null." },
            { "TupleNotEqDifferingNamesWithOneNullId", "Conflicting suite expectation: tuple inequality is true when one element differs, even if another is null (the suite's own TupleNotEqJohn1John2WithNullName expects true); this case expects null." },
            { "ProperContains1", "`properly includes` with a null list returns null instead of false." },
            { "ProperIn1", "`properly included in` with a null list returns null instead of false." },

            { "SubstringEmptyAnd0", "Returns null, as the specification requires for a startIndex that is out of range (index 0 of an empty string); the suite expects ''." },
            { "TimeProperContainsFalse", "A point at the boundary of an interval wider than the point is properly included, as the specification's point-interval rule requires (\"the interval is not a unit interval containing only the point\"); the suite expects false, see cqframework/cql-tests#152." },
            { "TimeProperContainsPrecisionFalse", "A point at the boundary of an interval wider than the point is properly included, as the specification's point-interval rule requires (\"the interval is not a unit interval containing only the point\"); the suite expects false, see cqframework/cql-tests#152." },
            { "TimeProperInFalse", "A point at the boundary of an interval wider than the point is properly included, as the specification's point-interval rule requires (\"the interval is not a unit interval containing only the point\"); the suite expects false, see cqframework/cql-tests#152." },
            { "TimeProperInPrecisionFalse", "A point at the boundary of an interval wider than the point is properly included, as the specification's point-interval rule requires (\"the interval is not a unit interval containing only the point\"); the suite expects false, see cqframework/cql-tests#152." },
            { "TestIntersectNull", "The expected result, Interval[5, null), has a null boundary, so comparing it with CQL Equal is null and cannot confirm it; CoreTests.IntervalIntersectNullBoundaryTests checks the boundaries directly." },
        };
    }


}
