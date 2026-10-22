/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace CoreTests;

/// <summary>
/// Spec §9.B, Type Operators: the String overloads of ToDate, ToDateTime, ToDecimal, ToInteger, ToLong, ToQuantity
/// and ToTime, and the number overloads of ToBoolean and ToInteger. Each conversion gives the value the
/// specification describes for an argument in its format, and null, never an exception, for any other argument.
/// </summary>
/// <remarks>
/// Each table holds the forms a conversion accepts, followed by the forms it rejects.
/// </remarks>
[TestClass]
[TestCategory("UnitTest")]
public class ToOperatorTests
{
    private static ICqlOperators Operators() => FhirCqlContext.WithDataSource().Operators;

    #region ToBoolean

    /// <summary>
    /// "If the input is an Integer or Long, the result is true if the integer is 1, false if the integer is 0. If the
    /// input is a Decimal, the result is true if the decimal is 1.0, false if the decimal is 0.0." Any other number
    /// "cannot be interpreted as a valid Boolean value", so the result is null.
    /// </summary>
    private static IEnumerable<object?[]> ToBooleanOfANumberCases =>
    [
        ["Integer 1", 1, true],
        ["Integer 0", 0, false],
        ["Long 1", 1L, true],
        ["Long 0", 0L, false],
        ["Decimal 1.0", 1.0m, true],
        ["Decimal 0.0", 0.0m, false],
        ["Integer 2", 2, null],
        ["Integer -1", -1, null],
        ["Long 2", 2L, null],
        ["Decimal 0.5", 0.5m, null],
        ["Decimal 2.0", 2.0m, null],
    ];

    [TestMethod]
    [DynamicData(nameof(ToBooleanOfANumberCases))]
    public void ToBoolean_OfANumber_IsTrueForOneFalseForZeroAndNullOtherwise(string argumentDescription, object argument, bool? expected)
    {
        var operators = Operators();
        var actual = argument switch
        {
            int i => operators.ConvertIntegerToBoolean(i),
            long l => operators.ConvertLongToBoolean(l),
            decimal d => operators.ConvertDecimalToBoolean(d),
            _ => throw new ArgumentException($"Not a number: {argument}", nameof(argument)),
        };

        Assert.AreEqual(expected, actual, argumentDescription);
    }

    #endregion

    #region ToDateTime

    /// <summary>
    /// "The operator expects the string to be formatted using the ISO-8601 datetime representation:
    /// YYYY-MM-DDThh:mm:ss.fff(Z|((+|-)hh:mm)) [...] In addition, the string must be interpretable as a valid DateTime
    /// value. [...] If the input string is not formatted correctly, or does not represent a valid DateTime value, the
    /// result is null." Table 5-H bounds the hour to [0, 23] and the minute and second to [0, 59].
    /// </summary>
    private static IEnumerable<object?[]> ToDateTimeCases =>
    [
        ["Day precision '2014-01-01'", "2014-01-01", new CqlDateTime(2014, 1, 1, null, null, null, null, null, null)],
        ["UTC '2014-01-01T14:30:00.0Z'", "2014-01-01T14:30:00.0Z", new CqlDateTime(2014, 1, 1, 14, 30, 0, 0, 0, 0)],
        ["Offset '2014-01-01T14:30:00.0-07:00'", "2014-01-01T14:30:00.0-07:00", new CqlDateTime(2014, 1, 1, 14, 30, 0, 0, -7, 0)],
        ["Offset '2014-01-01T14:30:00+05:30'", "2014-01-01T14:30:00+05:30", new CqlDateTime(2014, 1, 1, 14, 30, 0, null, 5, 30)],
        ["Largest offset '2014-01-01T23:59:59.999+14:00'", "2014-01-01T23:59:59.999+14:00", new CqlDateTime(2014, 1, 1, 23, 59, 59, 999, 14, 0)],
        ["Smallest offset '2014-01-01T00:00:00-14:00'", "2014-01-01T00:00:00-14:00", new CqlDateTime(2014, 1, 1, 0, 0, 0, null, -14, 0)],
        ["Minimum '0001-01-01T00:00:00.000Z'", "0001-01-01T00:00:00.000Z", new CqlDateTime(1, 1, 1, 0, 0, 0, 0, 0, 0)],
        ["Maximum '9999-12-31T23:59:59.999Z'", "9999-12-31T23:59:59.999Z", new CqlDateTime(9999, 12, 31, 23, 59, 59, 999, 0, 0)],
        ["Hour 25 '2014-01-01T25:00:00Z'", "2014-01-01T25:00:00Z", null],
        ["Hour 24 '2014-01-01T24:00:00'", "2014-01-01T24:00:00", null],
        ["Minute 61 '2014-01-01T10:61:00'", "2014-01-01T10:61:00", null],
        ["Second 60 '2014-01-01T10:00:60'", "2014-01-01T10:00:60", null],
        ["Offset +15:00 '2014-01-01T10:00:00+15:00'", "2014-01-01T10:00:00+15:00", null],
        ["Offset +14:01 '2014-01-01T10:00:00+14:01'", "2014-01-01T10:00:00+14:01", null],
        ["Offset minute 60 '2014-01-01T10:00:00+05:60'", "2014-01-01T10:00:00+05:60", null],
        ["Before the minimum in UTC '0001-01-01T00:00:00+01:00'", "0001-01-01T00:00:00+01:00", null],
        ["After the maximum in UTC '9999-12-31T23:00:00-05:00'", "9999-12-31T23:00:00-05:00", null],
        ["February 30 '2014-02-30T10:00:00'", "2014-02-30T10:00:00", null],
        ["Slashes '2014/01/01T12:05:05.955Z'", "2014/01/01T12:05:05.955Z", null],
        ["'abc'", "abc", null],
    ];

    [TestMethod]
    [DynamicData(nameof(ToDateTimeCases))]
    public void ToDateTime_OfAString_GivesTheDateTimeOfAValidStringAndNullOtherwise(string argumentDescription, string argument, CqlDateTime? expected) =>
        Assert.AreEqual(Components(expected), Components(Operators().ConvertStringToDateTime(argument)), argumentDescription);

    private static (int, int?, int?, int?, int?, int?, int?, int?, int?)? Components(CqlDateTime? dateTime) =>
        dateTime?.Value is { } v
            ? (v.Year, v.Month, v.Day, v.Hour, v.Minute, v.Second, v.Millisecond, v.OffsetHour, v.OffsetMinute)
            : null;

    #endregion

    #region ToDecimal

    /// <summary>
    /// "The operator accepts strings using the following format: (+|-)?#0(.0#)? Meaning an optional polarity
    /// indicator, followed by any number of digits (including none), followed by at least one digit, followed
    /// optionally by a decimal point, at least one digit, and any number of additional digits (including none)."
    /// </summary>
    private static IEnumerable<object?[]> ToDecimalCases =>
    [
        ["'-0.1'", "-0.1", -0.1m],
        ["'+25.5'", "+25.5", 25.5m],
        ["'1'", "1", 1m],
        ["'007.50'", "007.50", 7.5m],
        ["Integer part only, many digits", "12345678901234567890", 12345678901234567890m],
        ["Surrounding spaces ' 1 '", " 1 ", null],
        ["Leading space ' 1'", " 1", null],
        ["Trailing space '1 '", "1 ", null],
        ["Thousands separator '1,000'", "1,000", null],
        ["Trailing sign '1-'", "1-", null],
        ["No digit before the point '.5'", ".5", null],
        ["No digit after the point '1.'", "1.", null],
        ["Two polarity indicators '+-0.1'", "+-0.1", null],
        ["Exponent '1e3'", "1e3", null],
        ["Two points '1.5.3'", "1.5.3", null],
        ["Sign only '-'", "-", null],
        ["Empty string", "", null],
        ["'abc'", "abc", null],
        ["Outside the Decimal range", "99999999999999999999999999999999", null],
    ];

    [TestMethod]
    [DynamicData(nameof(ToDecimalCases))]
    public void ToDecimal_OfAString_AcceptsOnlyTheSpecificationsFormat(string argumentDescription, string argument, decimal? expected) =>
        Assert.AreEqual(expected, Operators().ConvertStringToDecimal(argument), argumentDescription);

    #endregion

    #region ToInteger

    /// <summary>
    /// "The operator accepts strings using the following format: (+|-)?#0 Meaning an optional polarity indicator,
    /// followed by any number of digits (including none), followed by at least one digit. [...] the integer value
    /// returned by this operator must be a valid value in the range representable for Integer values in CQL."
    /// </summary>
    private static IEnumerable<object?[]> ToIntegerOfAStringCases =>
    [
        ["'-25'", "-25", -25],
        ["'+25'", "+25", 25],
        ["'0'", "0", 0],
        ["'007'", "007", 7],
        ["Integer maximum", "2147483647", int.MaxValue],
        ["Integer minimum", "-2147483648", int.MinValue],
        ["Surrounding spaces ' 1 '", " 1 ", null],
        ["Leading tab '\\t1'", "\t1", null],
        ["Thousands separator '1,000'", "1,000", null],
        ["Trailing sign '1-'", "1-", null],
        ["Decimal '1.0'", "1.0", null],
        ["Two polarity indicators '+-1'", "+-1", null],
        ["Sign only '+'", "+", null],
        ["Empty string", "", null],
        ["'one'", "one", null],
        ["Above the Integer maximum", "2147483648", null],
    ];

    [TestMethod]
    [DynamicData(nameof(ToIntegerOfAStringCases))]
    public void ToInteger_OfAString_AcceptsOnlyTheSpecificationsFormat(string argumentDescription, string argument, int? expected) =>
        Assert.AreEqual(expected, Operators().ConvertStringToInteger(argument), argumentDescription);

    /// <summary>
    /// "If the input is a Long value that can be represented within the range of Integer values, the result is the
    /// Integer value; otherwise, the result is null."
    /// </summary>
    private static IEnumerable<object?[]> ToIntegerOfALongCases =>
    [
        ["5", 5L, 5],
        ["-5", -5L, -5],
        ["Integer maximum", (long)int.MaxValue, int.MaxValue],
        ["Integer minimum", (long)int.MinValue, int.MinValue],
        ["3000000000", 3000000000L, null],
        ["Integer maximum + 1", (long)int.MaxValue + 1, null],
        ["Integer minimum - 1", (long)int.MinValue - 1, null],
        ["Long maximum", long.MaxValue, null],
    ];

    [TestMethod]
    [DynamicData(nameof(ToIntegerOfALongCases))]
    public void ToInteger_OfALong_IsNullOutsideTheIntegerRange(string argumentDescription, long argument, int? expected) =>
        Assert.AreEqual(expected, Operators().ConvertLongToInteger(argument), argumentDescription);

    #endregion

    #region ToLong

    /// <summary>
    /// "The operator accepts strings using the following format: (+|-)?#0 [...] Note that the long value returned by
    /// this operator must be a valid value in the range representable for Long values in CQL."
    /// </summary>
    private static IEnumerable<object?[]> ToLongCases =>
    [
        ["'-1'", "-1", -1L],
        ["'+1'", "+1", 1L],
        ["Long maximum", "9223372036854775807", long.MaxValue],
        ["Long minimum", "-9223372036854775808", long.MinValue],
        ["Surrounding spaces ' 1 '", " 1 ", null],
        ["Thousands separator '1,000'", "1,000", null],
        ["Trailing sign '1-'", "1-", null],
        ["Decimal '1.0'", "1.0", null],
        ["Empty string", "", null],
        ["'one'", "one", null],
        ["Above the Long maximum", "9223372036854775808", null],
    ];

    [TestMethod]
    [DynamicData(nameof(ToLongCases))]
    public void ToLong_OfAString_AcceptsOnlyTheSpecificationsFormat(string argumentDescription, string argument, long? expected) =>
        Assert.AreEqual(expected, Operators().ConvertStringToLong(argument), argumentDescription);

    #endregion

    #region ToTime

    /// <summary>
    /// "The operator expects the string to be formatted using ISO-8601 time representation hh:mm:ss.fff [...] In
    /// addition, the string must be interpretable as a valid time-of-day value. [...] If the input string is not
    /// formatted correctly, or does not represent a valid time-of-day value, the result is null." Table 5-H bounds the
    /// hour to [0, 23] and the minute and second to [0, 59].
    /// </summary>
    private static IEnumerable<object?[]> ToTimeCases =>
    [
        ["'14:30:00.0'", "14:30:00.0", new CqlTime(14, 30, 0, 0, null, null)],
        ["'T14:30:00.0'", "T14:30:00.0", new CqlTime(14, 30, 0, 0, null, null)],
        ["Minute precision '14:30'", "14:30", new CqlTime(14, 30, null, null, null, null)],
        ["Minimum '00:00:00.000'", "00:00:00.000", new CqlTime(0, 0, 0, 0, null, null)],
        ["Maximum '23:59:59.999'", "23:59:59.999", new CqlTime(23, 59, 59, 999, null, null)],
        ["Offset, which is dropped, 'T14:30:00.0+05:30'", "T14:30:00.0+05:30", new CqlTime(14, 30, 0, 0, null, null)],
        ["Hour 25 '25:00:00'", "25:00:00", null],
        ["Hour 24 '24:00:00'", "24:00:00", null],
        ["Minute 61 '10:61'", "10:61", null],
        ["Second 60 '10:00:60'", "10:00:60", null],
        ["Offset +15:00 '10:00:00+15:00'", "10:00:00+15:00", null],
        ["Dashes 'T14-30-00.0'", "T14-30-00.0", null],
        ["'abc'", "abc", null],
    ];

    [TestMethod]
    [DynamicData(nameof(ToTimeCases))]
    public void ToTime_OfAString_GivesTheTimeOfAValidStringAndNullOtherwise(string argumentDescription, string argument, CqlTime? expected) =>
        Assert.AreEqual(Components(expected), Components(Operators().ConvertStringToTime(argument)), argumentDescription);

    private static (int, int?, int?, int?, int?, int?)? Components(CqlTime? time) =>
        time?.Value is { } v
            ? (v.Hour, v.Minute, v.Second, v.Millisecond, v.OffsetHour, v.OffsetMinute)
            : null;

    #endregion
}
