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
/// Spec §9.B, ConvertsToBoolean to ConvertsToTime: <c>ConvertsToX(x)</c> is true when <c>x</c> already is an X or can
/// be converted to one, that is when <c>ToX(x)</c> is not null; false when it cannot; and null when <c>x</c> is null.
/// </summary>
/// <remarks>
/// Each operator has one table. It covers the target type itself, every source type that the matching <c>ToX</c>
/// accepts, strings that do and do not convert, the value-dependent conversions, a type that <c>ToX</c> does not
/// accept, and null.
/// </remarks>
[TestClass]
[TestCategory("UnitTest")]
public class ConvertsToOperatorTests
{
    private static ICqlOperators Operators() => FhirCqlContext.WithDataSource().Operators;

    private static CqlDate SampleDate => new(2024, 1, 1);

    private static CqlDateTime SampleDateTime => new(2024, 1, 1, 10, 30, 0, null, 0, 0);

    private static CqlTime SampleTime => new(10, 30, 0, null, null, null);

    private static CqlQuantity SampleQuantity => new(5m, "mg");

    private static CqlRatio SampleRatio => new(new CqlQuantity(1m, "mg"), new CqlQuantity(2m, "mg"));

    private static CqlCode SampleCode => new("8480-6", "http://loinc.org");

    #region ConvertsToBoolean

    /// <summary>
    /// ToBoolean accepts a Boolean, an Integer, a Long, a Decimal and a String. It converts an Integer or Long only
    /// when it is 0 or 1, a Decimal only when it is 0.0 or 1.0, and a String only when it is one of
    /// true, t, yes, y, 1, false, f, no, n or 0, ignoring case.
    /// </summary>
    private static IEnumerable<object?[]> ConvertsToBooleanCases =>
    [
        ["Boolean true", true, true],
        ["Boolean false", false, true],
        ["Integer 0", 0, true],
        ["Integer 1", 1, true],
        ["Integer 2", 2, false],
        ["Integer -1", -1, false],
        ["Long 0", 0L, true],
        ["Long 1", 1L, true],
        ["Long 2", 2L, false],
        ["Decimal 0.0", 0.0m, true],
        ["Decimal 1.0", 1.0m, true],
        ["Decimal 0.5", 0.5m, false],
        ["Decimal 2.0", 2.0m, false],
        ["String 'y'", "y", true],
        ["String 'FALSE'", "FALSE", true],
        ["String '0'", "0", true],
        ["String 'falsetto'", "falsetto", false],
        ["String 'abc'", "abc", false],
        ["Quantity", SampleQuantity, false],
        ["null", null, null],
    ];

    [TestMethod]
    [DynamicData(nameof(ConvertsToBooleanCases))]
    public void ConvertsToBoolean_IsTrueExactlyWhenTheArgumentIsOrConvertsToABoolean(string argumentDescription, object? argument, bool? expected) =>
        Assert.AreEqual(expected, Operators().ConvertsToBoolean(argument), argumentDescription);

    #endregion

    #region ConvertsToDate

    /// <summary>
    /// ToDate accepts a DateTime, and a String in the ISO-8601 date or datetime format that represents a valid date, or
    /// a datetime whose components are each in range, to any precision.
    /// </summary>
    private static IEnumerable<object?[]> ConvertsToDateCases =>
    [
        ["Date", SampleDate, true],
        ["DateTime", SampleDateTime, true],
        ["String '2014-01-01'", "2014-01-01", true],
        ["String '2014-01'", "2014-01", true],
        ["String '2014-01-01T12:30:00'", "2014-01-01T12:30:00", true],
        ["String '0001-01-01T00:00:00+01:00'", "0001-01-01T00:00:00+01:00", true],
        ["String 'abc'", "abc", false],
        ["String '2014-13-01'", "2014-13-01", false],
        ["String '2014-01-01T25:00:00'", "2014-01-01T25:00:00", false],
        ["Time", SampleTime, false],
        ["null", null, null],
    ];

    [TestMethod]
    [DynamicData(nameof(ConvertsToDateCases))]
    public void ConvertsToDate_IsTrueExactlyWhenTheArgumentIsOrConvertsToADate(string argumentDescription, object? argument, bool? expected) =>
        Assert.AreEqual(expected, Operators().ConvertsToDate(argument), argumentDescription);

    #endregion

    #region ConvertsToDateTime

    /// <summary>
    /// ToDateTime accepts a Date and a String in the ISO-8601 datetime format that represents a valid DateTime, to any
    /// precision.
    /// </summary>
    private static IEnumerable<object?[]> ConvertsToDateTimeCases =>
    [
        ["DateTime", SampleDateTime, true],
        ["Date", SampleDate, true],
        ["String '2014-01-01T14:30:00.0Z'", "2014-01-01T14:30:00.0Z", true],
        ["String '2014-01-01'", "2014-01-01", true],
        ["String 'abc'", "abc", false],
        ["String '2014-02-30'", "2014-02-30", false],
        ["String '2014-01-01T25:00:00Z'", "2014-01-01T25:00:00Z", false],
        ["String '2014-01-01T10:61:00'", "2014-01-01T10:61:00", false],
        ["String '2014-01-01T10:00:00+15:00'", "2014-01-01T10:00:00+15:00", false],
        ["Time", SampleTime, false],
        ["null", null, null],
    ];

    [TestMethod]
    [DynamicData(nameof(ConvertsToDateTimeCases))]
    public void ConvertsToDateTime_IsTrueExactlyWhenTheArgumentIsOrConvertsToADateTime(string argumentDescription, object? argument, bool? expected) =>
        Assert.AreEqual(expected, Operators().ConvertsToDateTime(argument), argumentDescription);

    #endregion

    #region ConvertsToDecimal

    /// <summary>
    /// ToDecimal accepts a Boolean and a String in the format <c>(+|-)?#0(.0#)?</c>. An Integer or a Long converts
    /// implicitly to a Decimal, so ToDecimal accepts those too.
    /// </summary>
    private static IEnumerable<object?[]> ConvertsToDecimalCases =>
    [
        ["Decimal 1.5", 1.5m, true],
        ["Boolean true", true, true],
        ["Integer 5", 5, true],
        ["Long 5", 5L, true],
        ["String '-0.1'", "-0.1", true],
        ["String '+-0.1'", "+-0.1", false],
        ["String ' 1 '", " 1 ", false],
        ["String '1,000'", "1,000", false],
        ["String '1-'", "1-", false],
        ["String '.5'", ".5", false],
        ["String 'abc'", "abc", false],
        ["Quantity", SampleQuantity, false],
        ["null", null, null],
    ];

    [TestMethod]
    [DynamicData(nameof(ConvertsToDecimalCases))]
    public void ConvertsToDecimal_IsTrueExactlyWhenTheArgumentIsOrConvertsToADecimal(string argumentDescription, object? argument, bool? expected) =>
        Assert.AreEqual(expected, Operators().ConvertsToDecimal(argument), argumentDescription);

    #endregion

    #region ConvertsToInteger

    /// <summary>
    /// ToInteger accepts a Boolean, a Long within the Integer range, and a String in the format <c>(+|-)?#0</c> that
    /// lies within the Integer range.
    /// </summary>
    private static IEnumerable<object?[]> ConvertsToIntegerCases =>
    [
        ["Integer 5", 5, true],
        ["Boolean true", true, true],
        ["Boolean false", false, true],
        ["Long 5", 5L, true],
        ["Long Integer maximum", (long)int.MaxValue, true],
        ["Long Integer minimum", (long)int.MinValue, true],
        ["Long above the Integer maximum", (long)int.MaxValue + 1, false],
        ["Long below the Integer minimum", (long)int.MinValue - 1, false],
        ["String '-1'", "-1", true],
        ["String 'abc'", "abc", false],
        ["String '1.5'", "1.5", false],
        ["String ' 1 '", " 1 ", false],
        ["String above the Integer maximum", "2147483648", false],
        ["Decimal 1.0", 1.0m, false],
        ["null", null, null],
    ];

    [TestMethod]
    [DynamicData(nameof(ConvertsToIntegerCases))]
    public void ConvertsToInteger_IsTrueExactlyWhenTheArgumentIsOrConvertsToAnInteger(string argumentDescription, object? argument, bool? expected) =>
        Assert.AreEqual(expected, Operators().ConvertsToInteger(argument), argumentDescription);

    #endregion

    #region ConvertsToLong

    /// <summary>
    /// ToLong accepts a Boolean, an Integer, and a String in the format <c>(+|-)?#0</c> that lies within the Long
    /// range.
    /// </summary>
    private static IEnumerable<object?[]> ConvertsToLongCases =>
    [
        ["Long 5", 5L, true],
        ["Boolean true", true, true],
        ["Integer 5", 5, true],
        ["String '-1'", "-1", true],
        ["String Long maximum", "9223372036854775807", true],
        ["String 'one'", "one", false],
        ["String ' 1 '", " 1 ", false],
        ["String above the Long maximum", "9223372036854775808", false],
        ["Decimal 5.0", 5.0m, false],
        ["null", null, null],
    ];

    [TestMethod]
    [DynamicData(nameof(ConvertsToLongCases))]
    public void ConvertsToLong_IsTrueExactlyWhenTheArgumentIsOrConvertsToALong(string argumentDescription, object? argument, bool? expected) =>
        Assert.AreEqual(expected, Operators().ConvertsToLong(argument), argumentDescription);

    #endregion

    #region ConvertsToQuantity

    /// <summary>
    /// ToQuantity accepts an Integer, a Long and a Decimal, each with the unit '1'; a Ratio, which it divides; and a
    /// String holding a number optionally followed by a quoted unit. A Ratio whose denominator is 0 cannot be divided.
    /// </summary>
    private static IEnumerable<object?[]> ConvertsToQuantityCases =>
    [
        ["Quantity 5 'mg'", SampleQuantity, true],
        ["Integer 5", 5, true],
        ["Long 5", 5L, true],
        ["Decimal 0.1", 0.1m, true],
        ["Ratio 1 'mg' : 2 'mg'", SampleRatio, true],
        ["Ratio 1 'mg' : 0 'mg'", new CqlRatio(new CqlQuantity(1m, "mg"), new CqlQuantity(0m, "mg")), false],
        ["String \"-0.1 'mg'\"", "-0.1 'mg'", true],
        ["String '5'", "5", true],
        ["String \"5'mg'\"", "5'mg'", true],
        ["String \"444 'cm\"", "444 'cm", false],
        ["String 'abc'", "abc", false],
        ["Boolean true", true, false],
        ["null", null, null],
    ];

    [TestMethod]
    [DynamicData(nameof(ConvertsToQuantityCases))]
    public void ConvertsToQuantity_IsTrueExactlyWhenTheArgumentIsOrConvertsToAQuantity(string argumentDescription, object? argument, bool? expected) =>
        Assert.AreEqual(expected, Operators().ConvertsToQuantity(argument), argumentDescription);

    #endregion

    #region ConvertsToString

    /// <summary>
    /// ToString accepts a Boolean, an Integer, a Long, a Decimal, a Quantity, a Ratio, a Date, a DateTime and a Time.
    /// Every String already is a String, so no String fails to convert.
    /// </summary>
    private static IEnumerable<object?[]> ConvertsToStringCases =>
    [
        ["String 'x'", "x", true],
        ["String ''", "", true],
        ["Boolean true", true, true],
        ["Integer 13", 13, true],
        ["Long 10000", 10000L, true],
        ["Decimal 0.1", 0.1m, true],
        ["Quantity", SampleQuantity, true],
        ["Ratio", SampleRatio, true],
        ["Date", SampleDate, true],
        ["DateTime", SampleDateTime, true],
        ["Time", SampleTime, true],
        ["Code", SampleCode, false],
        ["null", null, null],
    ];

    [TestMethod]
    [DynamicData(nameof(ConvertsToStringCases))]
    public void ConvertsToString_IsTrueExactlyWhenTheArgumentIsOrConvertsToAString(string argumentDescription, object? argument, bool? expected) =>
        Assert.AreEqual(expected, Operators().ConvertsToString(argument), argumentDescription);

    #endregion

    #region ConvertsToTime

    /// <summary>
    /// ToTime accepts a String in the ISO-8601 time format that represents a valid time of day, to any precision.
    /// </summary>
    private static IEnumerable<object?[]> ConvertsToTimeCases =>
    [
        ["Time", SampleTime, true],
        ["String '14:30:00.0'", "14:30:00.0", true],
        ["String 'abc'", "abc", false],
        ["String '2:30 PM'", "2:30 PM", false],
        ["String '25:00:00'", "25:00:00", false],
        ["String '10:61'", "10:61", false],
        ["DateTime", SampleDateTime, false],
        ["null", null, null],
    ];

    [TestMethod]
    [DynamicData(nameof(ConvertsToTimeCases))]
    public void ConvertsToTime_IsTrueExactlyWhenTheArgumentIsOrConvertsToATime(string argumentDescription, object? argument, bool? expected) =>
        Assert.AreEqual(expected, Operators().ConvertsToTime(argument), argumentDescription);

    #endregion
}
