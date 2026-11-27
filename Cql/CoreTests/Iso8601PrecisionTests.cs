/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Iso8601;

namespace CoreTests;

/// <summary>
/// The text form of an ISO 8601 value and its <c>Precision</c> property describe the same value: a requested
/// precision cuts the value off there, with and without <c>strict</c>, and
/// <see cref="DateTimePrecision.Unknown"/> keeps every component given.
/// </summary>
/// <remarks>
/// Two cases are left out, because the types do not hold this for them. A value constructed with a component
/// after a missing one has a precision that its text does not show; issue #1942 tracks it. The
/// <see cref="TimeIso8601.TimeSpan"/> of a time keeps the parts that its precision cuts off; issue #1943 tracks it.
/// </remarks>
[TestClass]
[TestCategory("UnitTest")]
public class Iso8601PrecisionTests
{
    private static readonly DateTimeOffset Instant = new(2024, 3, 15, 10, 30, 45, 123, TimeSpan.FromHours(1));
    private static readonly TimeSpan TimeOfDay = new(0, 10, 30, 45, 123);

    private static IEnumerable<object[]> DateTimePrecisions() =>
        Precisions(DateTimePrecision.Year, DateTimePrecision.Millisecond);

    // A date and a time accept every precision; one outside their own range gives the nearest one inside it.
    private static IEnumerable<object[]> DatePrecisions() =>
        Precisions(DateTimePrecision.Year, DateTimePrecision.Millisecond);

    private static IEnumerable<object[]> TimePrecisions() =>
        Precisions(DateTimePrecision.Year, DateTimePrecision.Millisecond);

    private static DateTimePrecision WithinDate(DateTimePrecision precision) =>
        precision > DateTimePrecision.Day ? DateTimePrecision.Day : precision;

    private static DateTimePrecision WithinTime(DateTimePrecision precision) =>
        precision < DateTimePrecision.Hour ? DateTimePrecision.Hour : precision;

    private static IEnumerable<object[]> Precisions(DateTimePrecision coarsest, DateTimePrecision finest) =>
        from precision in Enum.GetValues<DateTimePrecision>()
        where precision >= coarsest && precision <= finest
        from strict in new[] { false, true }
        select new object[] { precision, strict };

    [TestMethod]
    [DynamicData(nameof(DateTimePrecisions))]
    public void DateTimeIso8601_RequestedPrecision_CutsTheValueOffThere(DateTimePrecision precision, bool strict)
    {
        var value = new DateTimeIso8601(Instant, precision, strict);

        Assert.AreEqual(precision, value.Precision);
        Assert.AreEqual(ExpectedDateTimeText(precision), value.ToString());
        Assert.AreEqual(precision >= DateTimePrecision.Month ? 3 : null, value.Month);
        Assert.AreEqual(precision >= DateTimePrecision.Day ? 15 : null, value.Day);
        Assert.AreEqual(precision >= DateTimePrecision.Hour ? 10 : null, value.Hour);
        Assert.AreEqual(precision >= DateTimePrecision.Minute ? 30 : null, value.Minute);
        Assert.AreEqual(precision >= DateTimePrecision.Second ? 45 : null, value.Second);
        Assert.AreEqual(precision >= DateTimePrecision.Millisecond ? 123 : null, value.Millisecond);
        Assert.AreEqual(precision >= DateTimePrecision.Hour ? 1 : null, value.OffsetHour);
    }

    [TestMethod]
    [DynamicData(nameof(DateTimePrecisions))]
    public void DateTimeIso8601_TextParsedBack_HasTheSamePrecisionAndComponents(DateTimePrecision precision, bool strict)
    {
        var value = new DateTimeIso8601(Instant, precision, strict);

        Assert.IsTrue(DateTimeIso8601.TryParse(value.ToString(), out var parsed));
        Assert.IsNotNull(parsed);
        Assert.AreEqual(value.Precision, parsed.Precision);
        Assert.AreEqual(
            (value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second, value.Millisecond, value.OffsetHour, value.OffsetMinute),
            (parsed.Year, parsed.Month, parsed.Day, parsed.Hour, parsed.Minute, parsed.Second, parsed.Millisecond, parsed.OffsetHour, parsed.OffsetMinute));
        Assert.AreEqual(value.DateTimeOffset, parsed.DateTimeOffset);
    }

    [TestMethod]
    [DataRow(false)]
    [DataRow(true)]
    public void DateTimeIso8601_UnknownPrecision_KeepsEveryComponent(bool strict)
    {
        var value = new DateTimeIso8601(Instant, DateTimePrecision.Unknown, strict);

        Assert.AreEqual(DateTimePrecision.Millisecond, value.Precision);
        Assert.AreEqual("2024-03-15T10:30:45.123+01:00", value.ToString());
    }

    [TestMethod]
    [DynamicData(nameof(DatePrecisions))]
    public void DateIso8601_RequestedPrecision_CutsTheValueOffThere(DateTimePrecision precision, bool strict)
    {
        var value = new DateIso8601(Instant, precision, strict);

        Assert.AreEqual(WithinDate(precision), value.Precision);
        Assert.AreEqual(ExpectedDateTimeText(WithinDate(precision)), value.ToString());
        Assert.AreEqual(precision >= DateTimePrecision.Month ? 3 : null, value.Month);
        Assert.AreEqual(precision >= DateTimePrecision.Day ? 15 : null, value.Day);
    }

    [TestMethod]
    [DynamicData(nameof(DatePrecisions))]
    public void DateIso8601_TextParsedBack_HasTheSamePrecisionAndComponents(DateTimePrecision precision, bool strict)
    {
        var value = new DateIso8601(Instant, precision, strict);

        Assert.IsTrue(DateIso8601.TryParse(value.ToString(), out var parsed));
        Assert.IsNotNull(parsed);
        Assert.AreEqual(value.Precision, parsed.Precision);
        Assert.AreEqual((value.Year, value.Month, value.Day), (parsed.Year, parsed.Month, parsed.Day));
        Assert.AreEqual(value.DateTimeOffset, parsed.DateTimeOffset);
    }

    [TestMethod]
    [DataRow(false)]
    [DataRow(true)]
    public void DateIso8601_UnknownPrecision_KeepsEveryComponent(bool strict)
    {
        var value = new DateIso8601(Instant, DateTimePrecision.Unknown, strict);

        Assert.AreEqual(DateTimePrecision.Day, value.Precision);
        Assert.AreEqual("2024-03-15", value.ToString());
    }

    [TestMethod]
    [DynamicData(nameof(TimePrecisions))]
    public void TimeIso8601_RequestedPrecision_CutsTheValueOffThere(DateTimePrecision precision, bool strict)
    {
        var value = new TimeIso8601(TimeOfDay, 1, 0, precision, strict);

        Assert.AreEqual(WithinTime(precision), value.Precision);
        Assert.AreEqual(ExpectedTimeText(WithinTime(precision)) + "+01:00", value.ToString());
        Assert.AreEqual(10, value.Hour);
        Assert.AreEqual(precision >= DateTimePrecision.Minute ? 30 : null, value.Minute);
        Assert.AreEqual(precision >= DateTimePrecision.Second ? 45 : null, value.Second);
        Assert.AreEqual(precision >= DateTimePrecision.Millisecond ? 123 : null, value.Millisecond);
    }

    [TestMethod]
    [DynamicData(nameof(TimePrecisions))]
    public void TimeIso8601_TextParsedBack_HasTheSamePrecisionAndComponents(DateTimePrecision precision, bool strict)
    {
        var value = new TimeIso8601(TimeOfDay, 1, 0, precision, strict);

        Assert.IsTrue(TimeIso8601.TryParse(value.ToString(), out var parsed));
        Assert.IsNotNull(parsed);
        Assert.AreEqual(value.Precision, parsed.Precision);
        Assert.AreEqual(
            (value.Hour, value.Minute, value.Second, value.Millisecond, value.OffsetHour, value.OffsetMinute),
            (parsed.Hour, parsed.Minute, parsed.Second, parsed.Millisecond, parsed.OffsetHour, parsed.OffsetMinute));
    }

    [TestMethod]
    [DataRow(false)]
    [DataRow(true)]
    public void TimeIso8601_UnknownPrecision_KeepsEveryComponent(bool strict)
    {
        var value = new TimeIso8601(TimeOfDay, 1, 0, DateTimePrecision.Unknown, strict);

        Assert.AreEqual(DateTimePrecision.Millisecond, value.Precision);
        Assert.AreEqual("10:30:45.123+01:00", value.ToString());
    }

    private static string ExpectedDateTimeText(DateTimePrecision precision) =>
        precision switch
        {
            DateTimePrecision.Year => "2024",
            DateTimePrecision.Month => "2024-03",
            DateTimePrecision.Day => "2024-03-15",
            _ => $"2024-03-15T{ExpectedTimeText(precision)}+01:00",
        };

    private static string ExpectedTimeText(DateTimePrecision precision) =>
        precision switch
        {
            DateTimePrecision.Hour => "10",
            DateTimePrecision.Minute => "10:30",
            DateTimePrecision.Second => "10:30:45",
            DateTimePrecision.Millisecond => "10:30:45.123",
            _ => throw new ArgumentOutOfRangeException(nameof(precision), precision, "The precision has no time part."),
        };
}
