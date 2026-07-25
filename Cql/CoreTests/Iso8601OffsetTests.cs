/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Iso8601;

namespace CoreTests;

[TestClass]
[TestCategory("UnitTest")]
public class Iso8601OffsetTests
{
    [TestMethod]
    public void TimeIso8601_NegativeOffsetWithMinutes_SignsTheWholeOffset()
    {
        var time = new TimeIso8601(10, 30, 0, null, -5, 30);

        Assert.AreEqual(new TimeSpan(-5, -30, 0), time.Offset);
        Assert.AreEqual(-5, time.OffsetHour);
        Assert.AreEqual(-30, time.OffsetMinute);
        Assert.AreEqual("10:30:00-05:30", time.ToString());
    }

    [TestMethod]
    public void TimeIso8601_PositiveOffsetWithMinutes_SignsTheWholeOffset()
    {
        var time = new TimeIso8601(10, 30, 0, null, 5, 30);

        Assert.AreEqual(new TimeSpan(5, 30, 0), time.Offset);
        Assert.AreEqual(30, time.OffsetMinute);
        Assert.AreEqual("10:30:00+05:30", time.ToString());
    }

    [TestMethod]
    public void TimeIso8601_ParsesNegativeOffsetWithMinutes()
    {
        Assert.IsTrue(TimeIso8601.TryParse("10:30:00-05:30", out var time));

        Assert.AreEqual(new TimeSpan(-5, -30, 0), time!.Offset);
        Assert.AreEqual("10:30:00-05:30", time.ToString());
    }

    [TestMethod]
    public void TimeIso8601_ParsesNegativeOffsetWithoutHours()
    {
        // The hour component is zero here, so only the minutes can carry the sign.
        Assert.IsTrue(TimeIso8601.TryParse("10:30:00-00:30", out var time));

        Assert.AreEqual(new TimeSpan(0, -30, 0), time!.Offset);
        Assert.AreEqual("10:30:00-00:30", time.ToString());
    }

    [TestMethod]
    public void TimeIso8601_ParsesPositiveOffsetWithoutHours()
    {
        Assert.IsTrue(TimeIso8601.TryParse("10:30:00+00:30", out var time));

        Assert.AreEqual(new TimeSpan(0, 30, 0), time!.Offset);
        Assert.AreEqual("10:30:00+00:30", time.ToString());
    }

    [TestMethod]
    public void TimeIso8601_UtcOffset_RendersAsZ()
    {
        var time = new TimeIso8601(10, 30, 0, null, 0, 0);

        Assert.AreEqual(TimeSpan.Zero, time.Offset);
        Assert.AreEqual("10:30:00Z", time.ToString());
    }

    [TestMethod]
    public void DateTimeIso8601_NegativeOffsetWithMinutes_SignsTheWholeOffset()
    {
        var dateTime = new DateTimeIso8601(2024, 1, 1, 10, 30, 0, null, -5, 30);

        Assert.AreEqual(new TimeSpan(-5, -30, 0), dateTime.DateTimeOffset.Offset);
        Assert.AreEqual(-30, dateTime.OffsetMinute);
        Assert.AreEqual("2024-01-01T10:30:00-05:30", dateTime.ToString());
    }

    [TestMethod]
    public void DateTimeIso8601_ParsesNegativeOffsetWithMinutes()
    {
        Assert.IsTrue(DateTimeIso8601.TryParse("2024-01-01T10:30:00-05:30", out var dateTime));

        Assert.AreEqual(new TimeSpan(-5, -30, 0), dateTime!.DateTimeOffset.Offset);
        Assert.AreEqual(-5, dateTime.OffsetHour);
        Assert.AreEqual(-30, dateTime.OffsetMinute);
        Assert.AreEqual("2024-01-01T10:30:00-05:30", dateTime.ToString());
    }

    [TestMethod]
    public void DateTimeIso8601_ParsesNegativeOffsetWithoutHours()
    {
        Assert.IsTrue(DateTimeIso8601.TryParse("2024-01-01T10:30:00-00:30", out var dateTime));

        Assert.AreEqual(new TimeSpan(0, -30, 0), dateTime!.DateTimeOffset.Offset);
    }

    [TestMethod]
    public void DateTimeIso8601_PositiveOffsetWithoutHours_RendersSign()
    {
        var dateTime = new DateTimeIso8601(2024, 1, 1, 10, 30, 0, null, 0, 30);

        Assert.AreEqual(new TimeSpan(0, 30, 0), dateTime.DateTimeOffset.Offset);
        Assert.AreEqual("2024-01-01T10:30:00+00:30", dateTime.ToString());
    }
}
