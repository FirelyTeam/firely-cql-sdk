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
/// Two ISO 8601 values are equal when they are of the same type and have the same components.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class Iso8601EqualityTests
{
    [TestMethod]
    [DataRow("2024")]
    [DataRow("2024-03")]
    [DataRow("2024-03-15")]
    public void DateIso8601_SameComponents_AreEqualWithTheSameHashCode(string text)
    {
        Assert.IsTrue(DateIso8601.TryParse(text, out var parsed));
        Assert.IsTrue(DateIso8601.TryParse(text, out var other));
        Assert.IsNotNull(parsed);
        Assert.IsNotNull(other);
        var constructed = new DateIso8601(parsed.Year, parsed.Month, parsed.Day);

        AssertEqualValues(parsed, other);
        AssertEqualValues(parsed, constructed);
    }

    [TestMethod]
    [DataRow("2024-03-15", "2025-03-15")]
    [DataRow("2024-03-15", "2024-04-15")]
    [DataRow("2024-03-15", "2024-03-16")]
    [DataRow("2024-03", "2024-03-01")]
    [DataRow("2024", "2024-01")]
    public void DateIso8601_DifferentComponents_AreNotEqual(string left, string right)
    {
        Assert.IsTrue(DateIso8601.TryParse(left, out var a));
        Assert.IsTrue(DateIso8601.TryParse(right, out var b));

        AssertDifferentValues(a, b);
    }

    [TestMethod]
    [DataRow("2024")]
    [DataRow("2024-03-15")]
    [DataRow("2024-03-15T10")]
    [DataRow("2024-03-15T10:30:45.123+01:00")]
    [DataRow("2024-03-15T10:30:45.123Z")]
    public void DateTimeIso8601_SameComponents_AreEqualWithTheSameHashCode(string text)
    {
        Assert.IsTrue(DateTimeIso8601.TryParse(text, out var parsed));
        Assert.IsTrue(DateTimeIso8601.TryParse(text, out var other));
        Assert.IsNotNull(parsed);
        Assert.IsNotNull(other);
        var constructed = new DateTimeIso8601(
            parsed.Year, parsed.Month, parsed.Day, parsed.Hour, parsed.Minute, parsed.Second, parsed.Millisecond, parsed.OffsetHour, parsed.OffsetMinute);

        AssertEqualValues(parsed, other);
        AssertEqualValues(parsed, constructed);
    }

    [TestMethod]
    [DataRow("2024-03-15T10:30:45.123+01:00", "2025-03-15T10:30:45.123+01:00")]
    [DataRow("2024-03-15T10:30:45.123+01:00", "2024-04-15T10:30:45.123+01:00")]
    [DataRow("2024-03-15T10:30:45.123+01:00", "2024-03-16T10:30:45.123+01:00")]
    [DataRow("2024-03-15T10:30:45.123+01:00", "2024-03-15T11:30:45.123+01:00")]
    [DataRow("2024-03-15T10:30:45.123+01:00", "2024-03-15T10:31:45.123+01:00")]
    [DataRow("2024-03-15T10:30:45.123+01:00", "2024-03-15T10:30:46.123+01:00")]
    [DataRow("2024-03-15T10:30:45.123+01:00", "2024-03-15T10:30:45.124+01:00")]
    [DataRow("2024-03-15T10:30:45.123+01:00", "2024-03-15T10:30:45.123+02:00")]
    [DataRow("2024-03-15T10:30:45.123+01:00", "2024-03-15T10:30:45.123+01:30")]
    [DataRow("2024-03-15T10:30:45.123+01:00", "2024-03-15T10:30:45.123")]
    [DataRow("2024-03-15T10:30:45", "2024-03-15T10:30:45.000")]
    [DataRow("2024-03-15", "2024-03-15T00")]
    public void DateTimeIso8601_DifferentComponents_AreNotEqual(string left, string right)
    {
        Assert.IsTrue(DateTimeIso8601.TryParse(left, out var a));
        Assert.IsTrue(DateTimeIso8601.TryParse(right, out var b));

        AssertDifferentValues(a, b);
    }

    [TestMethod]
    public void DateTimeIso8601_SameInstantAtAnotherOffset_IsNotEqual()
    {
        Assert.IsTrue(DateTimeIso8601.TryParse("2024-03-15T10:00:00+01:00", out var a));
        Assert.IsTrue(DateTimeIso8601.TryParse("2024-03-15T09:00:00Z", out var b));
        Assert.IsNotNull(a);
        Assert.IsNotNull(b);

        Assert.AreEqual(a.DateTimeOffsetUtc, b.DateTimeOffsetUtc);
        AssertDifferentValues(a, b);
    }

    [TestMethod]
    [DataRow("2024-03-15T10:00:00Z", "2024-03-15T10:00:00+00:00")]
    [DataRow("2024-03-15T10:00:00+01", "2024-03-15T10:00:00+01:00")]
    public void DateTimeIso8601_SameOffsetWrittenTwoWays_IsEqual(string left, string right)
    {
        Assert.IsTrue(DateTimeIso8601.TryParse(left, out var a));
        Assert.IsTrue(DateTimeIso8601.TryParse(right, out var b));

        AssertEqualValues(a, b);
    }

    [TestMethod]
    [DataRow("10:00:00Z", "10:00:00+00:00")]
    [DataRow("10:00:00-05", "10:00:00-05:00")]
    public void TimeIso8601_SameOffsetWrittenTwoWays_IsEqual(string left, string right)
    {
        Assert.IsTrue(TimeIso8601.TryParse(left, out var a));
        Assert.IsTrue(TimeIso8601.TryParse(right, out var b));

        AssertEqualValues(a, b);
    }

    [TestMethod]
    [DataRow("10")]
    [DataRow("10:30")]
    [DataRow("10:30:45.123")]
    [DataRow("10:30:45.123-05:30")]
    public void TimeIso8601_SameComponents_AreEqualWithTheSameHashCode(string text)
    {
        Assert.IsTrue(TimeIso8601.TryParse(text, out var parsed));
        Assert.IsTrue(TimeIso8601.TryParse(text, out var other));
        Assert.IsNotNull(parsed);
        Assert.IsNotNull(other);
        var constructed = new TimeIso8601(parsed.Hour, parsed.Minute, parsed.Second, parsed.Millisecond, parsed.OffsetHour, parsed.OffsetMinute);

        AssertEqualValues(parsed, other);
        AssertEqualValues(parsed, constructed);
    }

    [TestMethod]
    [DataRow("10:30:45.123+01:00", "11:30:45.123+01:00")]
    [DataRow("10:30:45.123+01:00", "10:31:45.123+01:00")]
    [DataRow("10:30:45.123+01:00", "10:30:46.123+01:00")]
    [DataRow("10:30:45.123+01:00", "10:30:45.124+01:00")]
    [DataRow("10:30:45.123+01:00", "10:30:45.123+02:00")]
    [DataRow("10:30:45.123+01:00", "10:30:45.123+01:30")]
    [DataRow("10:30:45.123+01:00", "10:30:45.123")]
    [DataRow("10:30", "10:30:00")]
    [DataRow("10:00:00+01:00", "09:00:00Z")]
    public void TimeIso8601_DifferentComponents_AreNotEqual(string left, string right)
    {
        Assert.IsTrue(TimeIso8601.TryParse(left, out var a));
        Assert.IsTrue(TimeIso8601.TryParse(right, out var b));

        AssertDifferentValues(a, b);
    }

    [TestMethod]
    public void TimeIso8601_OffsetWithoutMinutes_EqualsTheOffsetWithZeroMinutes()
    {
        var withoutMinutes = new TimeIso8601(10, 30, 0, null, 1, null);
        var withZeroMinutes = new TimeIso8601(10, 30, 0, null, 1, 0);

        AssertEqualValues(withoutMinutes, withZeroMinutes);
    }

    [TestMethod]
    public void DateTimeIso8601_OffsetMinutesWithoutOffsetHours_AreNotPartOfTheValue()
    {
        var withMinutes = new DateTimeIso8601(2024, 3, 15, 10, 30, null, null, null, 30);
        var withoutOffset = new DateTimeIso8601(2024, 3, 15, 10, 30, null, null, null, null);

        Assert.AreEqual(withoutOffset.ToString(), withMinutes.ToString());
        AssertEqualValues(withMinutes, withoutOffset);
    }

    [TestMethod]
    public void TimeIso8601_OffsetMinutesWithoutOffsetHours_AreNotPartOfTheValue()
    {
        var withMinutes = new TimeIso8601(10, 30, null, null, null, 30);
        var withoutOffset = new TimeIso8601(10, 30, null, null, null, null);

        Assert.AreEqual(withoutOffset.ToString(), withMinutes.ToString());
        AssertEqualValues(withMinutes, withoutOffset);
    }

    [TestMethod]
    public void TimeIso8601_NegativeOffsetWithMinutesOfEitherSign_IsEqual()
    {
        var unsignedMinutes = new TimeIso8601(10, 0, 0, null, -5, 30);
        var signedMinutes = new TimeIso8601(10, 0, 0, null, -5, -30);

        AssertEqualValues(unsignedMinutes, signedMinutes);
    }

    [TestMethod]
    public void Iso8601Value_IsNotEqualToItsText()
    {
        var date = new DateIso8601(2024, 3, 15);
        var dateTime = new DateTimeIso8601(2024, 3, 15, 10, 30, null, null, null, null);
        var time = new TimeIso8601(10, 30, null, null, null, null);

        Assert.IsFalse(date.Equals(date.ToString()));
        Assert.IsFalse(dateTime.Equals(dateTime.ToString()));
        Assert.IsFalse(time.Equals(time.ToString()));
    }

    [TestMethod]
    public void Iso8601Value_IsNotEqualToAnotherTypeWithTheSameText()
    {
        var date = new DateIso8601(2024, 3, 15);
        var dateTime = new DateTimeIso8601(2024, 3, 15, null, null, null, null, null, null);

        Assert.AreEqual(date.ToString(), dateTime.ToString());
        Assert.IsFalse(date.Equals(dateTime));
        Assert.IsFalse(dateTime.Equals(date));
    }

    [TestMethod]
    public void Iso8601Value_IsNotEqualToNull()
    {
        Assert.IsFalse(new DateIso8601(2024, 3, 15).Equals(null));
        Assert.IsFalse(new DateTimeIso8601(2024, 3, 15, null, null, null, null, null, null).Equals(null));
        Assert.IsFalse(new TimeIso8601(10, 30, null, null, null, null).Equals(null));
    }

    private static void AssertEqualValues<T>(T? left, T? right)
        where T : class, IEquatable<T>
    {
        Assert.IsNotNull(left);
        Assert.IsNotNull(right);
        Assert.IsTrue(left.Equals(right), "IEquatable<T>.Equals");
        Assert.IsTrue(right.Equals(left), "IEquatable<T>.Equals, reversed");
        Assert.IsTrue(left.Equals((object)right), "Equals(object)");
        Assert.AreEqual(left.GetHashCode(), right.GetHashCode());
        Assert.HasCount(1, new HashSet<T> { left, right });
    }

    private static void AssertDifferentValues<T>(T? left, T? right)
        where T : class, IEquatable<T>
    {
        Assert.IsNotNull(left);
        Assert.IsNotNull(right);
        Assert.IsFalse(left.Equals(right), "IEquatable<T>.Equals");
        Assert.IsFalse(right.Equals(left), "IEquatable<T>.Equals, reversed");
        Assert.IsFalse(left.Equals((object)right), "Equals(object)");
        Assert.HasCount(2, new HashSet<T> { left, right });
    }
}
