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


            { "CodeToConcept1", "Requires ListPromotion to be enabled; without it translation reports an error because Code cannot be converted to the List<Code> type of Concept.codes." },

            { "Decimal10Pow28ToZeroOneStepDecimalMaxValue", "The operand literal 10^27 lies outside the Decimal literal range 0.0 to (10^28-1)/10^8 (Developer's Guide, Literals, Table 3-B) and the expected value exceeds the maximum Decimal 99999999999999999999.99999999 (Appendix B, Maximum); the specification sets 28 digits as a minimum precision, not a maximum. See cqframework/cql-tests#145." },
            { "DecimalPos10Pow28ToZeroOneStepDecimalMaxValue", "The operand literal 10^27 lies outside the Decimal literal range 0.0 to (10^28-1)/10^8 (Developer's Guide, Literals, Table 3-B) and the expected value exceeds the maximum Decimal 99999999999999999999.99999999 (Appendix B, Maximum); the specification sets 28 digits as a minimum precision, not a maximum. See cqframework/cql-tests#145." },
            { "DecimalNeg10Pow28ToZeroOneStepDecimalMinValue", "The operand literal 10^27 lies outside the Decimal literal range 0.0 to (10^28-1)/10^8 (Developer's Guide, Literals, Table 3-B) and the expected value lies below the minimum Decimal -99999999999999999999.99999999 (Appendix B, Minimum); the specification sets 28 digits as a minimum precision, not a maximum. See cqframework/cql-tests#145." },

            { "ExpandPer0D1", "Throws NotSupportedException: a fractional per over an integer interval would produce Decimal intervals (value-dependent typing). The specification contradicts itself here: the Expand signature yields List<Interval<T>> with T the integer point type, while the section's own example gives Decimal intervals for this expression." },

            { "TestMaxIntervalExceptNull", "Except over two Interval<Any> operands is ambiguous with every typed interval overload (#1627)." },
            { "ExpandListWithNull", "Expand over a List<Any> operand is ambiguous with every typed interval overload (#1627)." },
            { "ExpandEmptyList", "Expand over a List<Any> operand is ambiguous with every typed interval overload (#1627)." },
            { "ExpandNull", "Expand over an Any operand is ambiguous with every typed interval overload (#1627)." },
            { "ExpandPer0D1IntervalOverload", "Throws NotSupportedException: a fractional per over an integer interval would produce Decimal values (value-dependent typing). The Expand signature yields List<T> with T the integer point type; the suite extrapolates the Decimal result from the list overload's example." },

            { "FloorIntegerLessThanMinInteger", "The suite expects a result from an integer literal outside the Integer range, which its own Ceiling cases with the same literals mark invalid=\"syntax\"; the CQL grammar has no overflow rule for NUMBER and a Long literal needs the L suffix." },
            { "FloorIntegerGreaterThanMaxInteger", "The suite expects a result from an integer literal outside the Integer range, which its own Ceiling cases with the same literals mark invalid=\"syntax\"; the CQL grammar has no overflow rule for NUMBER and a Long literal needs the L suffix." },

            { "RatioEqual", "Ratio is not supported: the expression builder throws NotSupportedException for a Ratio literal, and the runtime has no Ratio equality or equivalence (Appendix B, Equal: \"the numerator and denominator must be the same, using quantity equality semantics\"; Equivalent: \"the numerator and denominator represent the same ratio\")." },
            { "RatioNotEqualDiffNumerator", "Ratio is not supported: the expression builder throws NotSupportedException for a Ratio literal, and the runtime has no Ratio equality or equivalence (Appendix B, Equal: \"the numerator and denominator must be the same, using quantity equality semantics\"; Equivalent: \"the numerator and denominator represent the same ratio\")." },
            { "RatioNotEqualDiffDenominator", "Ratio is not supported: the expression builder throws NotSupportedException for a Ratio literal, and the runtime has no Ratio equality or equivalence (Appendix B, Equal: \"the numerator and denominator must be the same, using quantity equality semantics\"; Equivalent: \"the numerator and denominator represent the same ratio\")." },
            { "RatioEquivalent", "Ratio is not supported: the expression builder throws NotSupportedException for a Ratio literal, and the runtime has no Ratio equality or equivalence (Appendix B, Equal: \"the numerator and denominator must be the same, using quantity equality semantics\"; Equivalent: \"the numerator and denominator represent the same ratio\")." },
            { "RatioNotEquivalentDiffNumerator", "Ratio is not supported: the expression builder throws NotSupportedException for a Ratio literal, and the runtime has no Ratio equality or equivalence (Appendix B, Equal: \"the numerator and denominator must be the same, using quantity equality semantics\"; Equivalent: \"the numerator and denominator represent the same ratio\")." },
            { "RatioNotEquivalentDiffDenominator", "Ratio is not supported: the expression builder throws NotSupportedException for a Ratio literal, and the runtime has no Ratio equality or equivalence (Appendix B, Equal: \"the numerator and denominator must be the same, using quantity equality semantics\"; Equivalent: \"the numerator and denominator represent the same ratio\")." },

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
            { "DecimalMaxValue", "Returns System.Decimal.MaxValue (79228162514264337593543950335) where the suite expects the minimum required maximum 99999999999999999999.99999999; Appendix B, Maximum: implementations that support larger values \"will return the maximum representable decimal for the implementation\"." },
            { "DecimalMinValue", "Returns System.Decimal.MinValue (-79228162514264337593543950335) where the suite expects the minimum required minimum -99999999999999999999.99999999; Appendix B, Minimum: implementations that support larger values \"will return the minimum representable decimal for the implementation\"." },
            { "ReplaceMatchesSpaces", "Returns 'All\\$that...': .NET keeps backslash escapes in the Regex.Replace substitution literally, unlike Java's Matcher." },
            { "SortDatesAsc", "The list mixes DateTimes that are equal up to the coarser precision, whose comparison is null (Appendix B, Less: \"if one input has a value for the precision and the other does not, the comparison stops and the result is null\"); the specification defines no order for such values, so the expected order is one arbitrary choice." },
            { "SortDatesDesc", "The list mixes DateTimes that are equal up to the coarser precision, whose comparison is null (Appendix B, Less: \"if one input has a value for the precision and the other does not, the comparison stops and the result is null\"); the specification defines no order for such values, so the expected order is one arbitrary choice." },

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
            { "TestYearEquivalentDays", "1 year ~ 365 days returns false because the comparer converts calendar durations through UCUM, where a year is 365.25 days; Appendix B, Equivalent says calendar-time conversions \"shall be performed according to calendar duration semantics\" (1 year ~ 365 days), while the same section also says implementations \"are not required to support unit conversion\"." },
            { "TestMonthEquivalentDays", "1 month ~ 30 days returns false because the comparer converts calendar durations through UCUM, where a month is 30.4375 days; Appendix B, Equivalent says calendar-time conversions \"shall be performed according to calendar duration semantics\" (1 month ~ 30 days), while the same section also says implementations \"are not required to support unit conversion\"." },

            { "TupleEqDifferentNamesWithOneNullId", "Conflicting suite expectation: tuple equality is false when one element differs, even if another is null (specification example: { x: 1, y: 1 } = { x: null, y: 2 } is false, and the suite's own TupleEqJohn1John2WithNullName expects false); this case expects null." },
            { "TupleNotEqDifferingNamesWithOneNullId", "Conflicting suite expectation: tuple equality is false when one element differs, even if another is null (Author's Guide, Comparison Operators: Tuple { x: 1, y: 1 } = Tuple { x: null, y: 2 } \"returns false because the y elements are known unequal\"), and Not Equal is \"a shorthand for invocation of logical negation (not) of the equal operator\" (Appendix B), so the result is true, as the suite's own TupleNotEqJohn1John2WithNullName expects; this case expects null." },

            { "SubstringEmptyAnd0", "Returns null for a startIndex equal to the string's length; the suite expects ''. The specification is ambiguous: Appendix B, Substring leaves \"out of range\" undefined, the Developer's Guide, String Operators says null only when the index is \"greater than the length of the string\", and the suite's own SubstringAB2 expects null for the same situation. See cqframework/cql-tests#149." },
            { "TimeProperContainsFalse", "A point at the boundary of an interval wider than the point is properly included, as the specification's point-interval rule requires (\"the interval is not a unit interval containing only the point\"); the suite expects false, see cqframework/cql-tests#152." },
            { "TimeProperContainsPrecisionFalse", "A point at the boundary of an interval wider than the point is properly included, as the specification's point-interval rule requires (\"the interval is not a unit interval containing only the point\"); the suite expects false, see cqframework/cql-tests#152." },
            { "TimeProperInFalse", "A point at the boundary of an interval wider than the point is properly included, as the specification's point-interval rule requires (\"the interval is not a unit interval containing only the point\"); the suite expects false, see cqframework/cql-tests#152." },
            { "TimeProperInPrecisionFalse", "A point at the boundary of an interval wider than the point is properly included, as the specification's point-interval rule requires (\"the interval is not a unit interval containing only the point\"); the suite expects false, see cqframework/cql-tests#152." },
            { "TestIntersectNull", "The expected result, Interval[5, null), has a null boundary, so comparing it with CQL Equal is null and cannot confirm it; CoreTests.IntervalIntersectNullBoundaryTests checks the boundaries directly." },
        };
    }


}
