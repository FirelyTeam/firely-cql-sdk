/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace CoreTests;

/// <summary>
/// On the anniversary date, a year or a month between two DateTimes is whole only once the end's time of day has
/// reached the start's. CQL 1.5.3 Errata 2, Appendix H - Time Interval Calculations, "Calculating Duration in Years":
/// a year "starts at a certain time of day at a certain calendar date of the calendar year and ends at: The same time
/// of day on the same calendar date of the next calendar year", and the note on Example 2.a: "Time of day is
/// important in this calculation. If the time of day of Date 2 were less than the time of day for Date 1, the
/// duration of the time interval would be 0 years according to the definition." "Calculating Duration in Months"
/// defines a month the same way, and the negative examples (Scenarios 5 to 8 for years, 3 and 4 for months) mirror
/// the rule.
/// <para>
/// When one value specifies the time of day further than the other, the components only one of them specifies may
/// change the count, and then "the between operator does not return a strict integer, it returns an uncertainty"
/// (Language Semantics, "Determining Difference and Duration"). A Date specifies no time of day, and neither does the
/// DateTime that <c>ToDateTime</c> makes of one: "the result will be a DateTime with the time components unspecified"
/// (Appendix B, "ToDateTime"). Seconds and milliseconds are one precision: "when calculating duration, just like date
/// and time comparison calculations, seconds and milliseconds are considered a single precision with decimal
/// semantics" (Appendix B, "Duration"). The SDK returns a single count for such an uncertainty; the tests that pin that
/// count are kept apart from those that assert the specification's answer, at the end of this class.
/// </para>
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class DurationBetweenTimeOfDayTests
{
    private static readonly CqlContext Context = FhirCqlContext.WithDataSource();

    private static CqlDateTime Dt(string value) =>
        CqlDateTime.TryParse(value, out var dateTime) ? dateTime! : throw new ArgumentException(value);

    private static int? Years(string low, string high) => Context.Operators.DurationBetween(Dt(low), Dt(high), "year");

    private static int? Months(string low, string high) => Context.Operators.DurationBetween(Dt(low), Dt(high), "month");

    [TestMethod]
    [DataRow("2013-03-10T19:10:03", 0, DisplayName = "the note on Example 2.a: earlier in the day on the anniversary")]
    [DataRow("2013-03-10T22:05:08", 0, DisplayName = "a second before the start's time of day on the anniversary")]
    [DataRow("2013-03-10T22:05:09", 1, DisplayName = "Example 2.a: the start's time of day on the anniversary")]
    [DataRow("2013-03-10T22:05:10", 1, DisplayName = "a second after the start's time of day on the anniversary")]
    [DataRow("2013-03-09T23:59:59", 0, DisplayName = "the day before the anniversary")]
    [DataRow("2013-03-11T00:00:00", 1, DisplayName = "the day after the anniversary")]
    [DataRow("2015-03-10T22:05:08", 2, DisplayName = "a second before the third anniversary")]
    [DataRow("2015-03-10T22:05:09", 3, DisplayName = "the third anniversary")]
    public void YearsBetween_OnTheAnniversaryDate_TheTimeOfDayDecides(string end, int expected) =>
        Assert.AreEqual(expected, Years("2012-03-10T22:05:09", end));

    [TestMethod]
    [DataRow("2012-05-11T20:06:10", -1, DisplayName = "Example 6.a: the start's time of day on the anniversary")]
    [DataRow("2012-05-11T20:06:09", -1, DisplayName = "a second earlier in the day on the anniversary")]
    [DataRow("2012-05-11T20:06:11", 0, DisplayName = "a second later in the day: the year from it is not whole")]
    [DataRow("2011-05-11T20:06:11", -1, DisplayName = "a second later in the day, two years back")]
    [DataRow("2011-05-11T20:06:10", -2, DisplayName = "the start's time of day, two years back")]
    public void YearsBetween_BackToTheAnniversaryDate_TheTimeOfDayDecides(string end, int expected) =>
        Assert.AreEqual(expected, Years("2013-05-11T20:06:10", end));

    [TestMethod]
    [DataRow("2012-04-10T19:10:03", 0, DisplayName = "earlier in the day on the monthly anniversary")]
    [DataRow("2012-04-10T22:05:08", 0, DisplayName = "a second before the start's time of day")]
    [DataRow("2012-04-10T22:05:09", 1, DisplayName = "the start's time of day")]
    [DataRow("2012-04-10T22:05:10", 1, DisplayName = "a second after the start's time of day")]
    [DataRow("2013-06-10T22:05:08", 14, DisplayName = "a second before fifteen months")]
    [DataRow("2013-06-10T22:05:09", 15, DisplayName = "fifteen months")]
    public void MonthsBetween_OnTheAnniversaryDate_TheTimeOfDayDecides(string end, int expected) =>
        Assert.AreEqual(expected, Months("2012-03-10T22:05:09", end));

    [TestMethod]
    [DataRow("2012-03-10T22:05:09", 0, DisplayName = "later in the day: the month from it is not whole")]
    [DataRow("2012-03-10T19:10:04", 0, DisplayName = "a second later in the day")]
    [DataRow("2012-03-10T19:10:03", -1, DisplayName = "the start's time of day")]
    [DataRow("2012-03-10T19:10:02", -1, DisplayName = "a second earlier in the day")]
    [DataRow("2011-12-10T19:10:04", -3, DisplayName = "a second later in the day, four months back")]
    public void MonthsBetween_BackToTheAnniversaryDate_TheTimeOfDayDecides(string end, int expected) =>
        Assert.AreEqual(expected, Months("2012-04-10T19:10:03", end));

    /// <summary>
    /// The duration from the later value back to the earlier one is the negative of the duration forward.
    /// </summary>
    [TestMethod]
    [DataRow("2012-03-10T22:05:09", "2013-03-10T19:10:03")]
    [DataRow("2012-03-10T22:05:09", "2013-03-10T22:05:09")]
    [DataRow("2012-03-10T22:05:09", "2014-03-10T22:05:10")]
    [DataRow("2012-03-01T08:00:00", "2013-03-01T07:59:59")]
    [DataRow("2012-12-31T23:59:59.999", "2013-12-31T23:59:59.998")]
    public void YearsAndMonthsBetween_Backwards_IsTheNegativeOfForwards(string earlier, string later)
    {
        Assert.AreEqual(-Years(earlier, later), Years(later, earlier));
        Assert.AreEqual(-Months(earlier, later), Months(later, earlier));
    }

    /// <summary>
    /// A period that starts on 29 February has its anniversary on 29 February in a leap year and on 28 February in
    /// any other year (Appendix H, Example 4.b), and the time of day decides on that date in both directions.
    /// </summary>
    [TestMethod]
    [DataRow("2012-02-29T12:34:56", "2016-02-29T12:34:55", 3, DisplayName = "a second before the start's time of day on 29 February of a leap year")]
    [DataRow("2012-02-29T12:34:56", "2016-02-29T12:34:56", 4, DisplayName = "the start's time of day on 29 February of a leap year")]
    [DataRow("2012-02-29T12:34:56", "2014-02-28T12:34:55", 1, DisplayName = "a second before the start's time of day on 28 February of a year without a leap day")]
    [DataRow("2012-02-29T12:34:56", "2014-02-28T12:34:56", 2, DisplayName = "the start's time of day on 28 February of a year without a leap day")]
    [DataRow("2016-02-29T12:34:56", "2012-02-29T12:34:57", -3, DisplayName = "back to a second after the time of day on 29 February")]
    [DataRow("2016-02-29T12:34:56", "2012-02-29T12:34:56", -4, DisplayName = "back to the time of day on 29 February")]
    [DataRow("2013-02-28T12:34:55", "2012-02-29T12:34:56", 0, DisplayName = "back from a second before the time of day on 28 February of a year without a leap day")]
    [DataRow("2013-02-28T12:34:56", "2012-02-29T12:34:56", -1, DisplayName = "back from the time of day on 28 February of a year without a leap day")]
    public void YearsBetween_FromALeapDay_OnTheAnniversaryDate_TheTimeOfDayDecides(string low, string high, int expected) =>
        Assert.AreEqual(expected, Years(low, high));

    [TestMethod]
    [DataRow("2012-03-29T12:34:55", 0, DisplayName = "a second before the start's time of day")]
    [DataRow("2012-03-29T12:34:56", 1, DisplayName = "the start's time of day")]
    public void MonthsBetween_FromALeapDay_OnTheAnniversaryDate_TheTimeOfDayDecides(string end, int expected) =>
        Assert.AreEqual(expected, Months("2012-02-29T12:34:56", end));

    /// <summary>
    /// The introduction to Appendix H: <c>years between</c> the DateTimes <c>2012-03-10 10:20:00</c> and
    /// <c>2013-03-10 09:20:00</c> "gives zero years, because the year has not passed until 10:20:00 on the day in
    /// the following year. To calculate the number of years, ignoring the time, extract the date from the datetime
    /// value". The conformance suite's <c>DurationInYears</c> expects the latter to be 1.
    /// </summary>
    [TestMethod]
    public void YearsBetween_DatesFromTheDateTimes_IgnoresTheTimeOfDay()
    {
        var first = Dt("2012-03-10T10:20:00");
        var second = Dt("2013-03-10T09:20:00");

        Assert.AreEqual(0, Context.Operators.DurationBetween(first, second, "year"));
        Assert.AreEqual(1, Context.Operators.DurationBetween(first.DateOnly, second.DateOnly, "year"));
    }

    /// <summary>
    /// Times of day of different precisions that already differ at the coarser of the two decide the count: every value
    /// the components only one of them specifies can take gives the same count.
    /// </summary>
    [TestMethod]
    [DataRow("2012-03-10T22", "2013-03-10T21:59:59", 0, DisplayName = "the hour before the start's hour")]
    [DataRow("2012-03-10T22", "2013-03-10T23:00:00", 1, DisplayName = "the hour after the start's hour")]
    [DataRow("2012-03-10T22:05", "2013-03-10T22:04:59.999", 0, DisplayName = "the minute before the start's minute")]
    public void YearsBetween_WithTimesOfDayOfDifferentPrecisions_ThatDifferAtTheCoarserOne_TheTimeOfDayDecides(string low, string high, int expected) =>
        Assert.AreEqual(expected, Years(low, high));

    /// <summary>
    /// A value to the second and one to the millisecond specify the time of day equally far, because seconds and
    /// milliseconds are one precision with decimal semantics (Appendix B, "Duration"), so the count is determinate.
    /// </summary>
    [TestMethod]
    [DataRow("2012-03-10T22:05:09.500", "2013-03-10T22:05:09", 0, DisplayName = "seconds against milliseconds, half a second early")]
    [DataRow("2012-03-10T22:05:09", "2013-03-10T22:05:09.001", 1, DisplayName = "milliseconds against seconds, a millisecond late")]
    public void YearsBetween_SecondsAgainstMilliseconds_CompareAsOnePrecision(string low, string high, int expected) =>
        Assert.AreEqual(expected, Years(low, high));

    [TestMethod]
    public void YearsAndMonthsBetween_Dates_AreUnaffected()
    {
        Assert.AreEqual(1, Context.Operators.DurationBetween(new CqlDate(2012, 3, 10), new CqlDate(2013, 3, 10), "year"));
        Assert.AreEqual(-1, Context.Operators.DurationBetween(new CqlDate(2013, 3, 10), new CqlDate(2012, 3, 10), "year"));
        Assert.AreEqual(1, Context.Operators.DurationBetween(new CqlDate(2012, 3, 10), new CqlDate(2012, 4, 10), "month"));
        Assert.AreEqual(-1, Context.Operators.DurationBetween(new CqlDate(2012, 4, 10), new CqlDate(2012, 3, 10), "month"));
    }

    /// <summary>
    /// <c>CalculateAgeInYearsAt</c> and <c>CalculateAgeInMonthsAt</c>, and with them <c>AgeInYearsAt</c> and
    /// <c>AgeInMonthsAt</c>, are "defined in terms of a datetime duration calculation" (Appendix B, "CalculateAgeAt").
    /// </summary>
    [TestMethod]
    [DataRow("2013-03-10T19:10:03", "year", 0, DisplayName = "years, before the birth time of day on the birthday")]
    [DataRow("2013-03-10T22:05:09", "year", 1, DisplayName = "years, at the birth time of day on the birthday")]
    [DataRow("2012-04-10T19:10:03", "month", 0, DisplayName = "months, before the birth time of day")]
    [DataRow("2012-04-10T22:05:09", "month", 1, DisplayName = "months, at the birth time of day")]
    public void CalculateAgeAt_ABirthDateTime_OnTheBirthday_TheTimeOfDayDecides(string asOf, string precision, int expected) =>
        Assert.AreEqual(expected, Context.Operators.CalculateAgeAt(Dt("2012-03-10T22:05:09"), Dt(asOf), precision));

    /// <summary>
    /// Pins the single count the SDK returns today for durations that the specification defines as an uncertainty
    /// interval, so that a change to it is noticed. These counts are not the specification's answer. When a value does
    /// not specify the time of day as far as the other, "the between operator does not return a strict integer, it
    /// returns an uncertainty": <c>days between @2017-08-07T17:00 and @2017-08-14T</c> is <c>[6, 7]</c> (Language
    /// Semantics, "Determining Difference and Duration"). Each row gives that interval, from the count between the
    /// latest start and the earliest end the values allow to the count between the earliest start and the latest end.
    /// The SDK returns the count with the times of day compared at the coarser precision, one end of the interval.
    /// Uncertainty is tracked in https://github.com/FirelyTeam/firely-cql-sdk/issues/132.
    /// </summary>
    [TestMethod]
    [DataRow("2012-03-10T22:05:09", "2013-03-10", 1, 0, 1, DisplayName = "an end without a time of day on the anniversary")]
    [DataRow("2012-03-10", "2013-03-10T00:00:00", 1, 0, 1, DisplayName = "a start without a time of day, at midnight on the anniversary")]
    [DataRow("2013-03-10", "2012-03-10T22:05:09", -1, -1, 0, DisplayName = "back from a value without a time of day")]
    [DataRow("2013-03-10T19:10:03", "2012-03-10", -1, -1, 0, DisplayName = "back to a value without a time of day")]
    [DataRow("2012-02-29T12:34:56", "2014-02-28", 2, 1, 2, DisplayName = "from a leap day to an end without a time of day on 28 February")]
    [DataRow("2012-03-10T22", "2013-03-10T22:59:59", 1, 0, 1, DisplayName = "an end to the second in the start's hour")]
    [DataRow("2012-03-10T22:30", "2013-03-10T22", 1, 0, 1, DisplayName = "an end to the hour in the start's hour")]
    [DataRow("2012-03-10T22:05", "2013-03-10T22:05:00", 1, 0, 1, DisplayName = "an end to the second in the start's minute")]
    [DataRow("2012-03-10T22:05:30", "2013-03-10T22:05", 1, 0, 1, DisplayName = "an end to the minute in the start's minute")]
    public void YearsBetween_WhereTheSpecificationGivesAnUncertainty_PinsTheCurrentSingleCount(
        string low, string high, int current, int uncertaintyLow, int uncertaintyHigh) =>
        AssertPinnedCountOfAnUncertainty(Years(low, high), current, uncertaintyLow, uncertaintyHigh);

    /// <summary>
    /// Pins the single count the SDK returns today for <c>AgeInYearsAt</c> and <c>AgeInMonthsAt</c> given a DateTime
    /// on the birthday, which the specification defines as an uncertainty interval, so that a change to it is noticed.
    /// This count is not the specification's answer. Both pass <c>ToDateTime(Patient.birthDate)</c>, whose time
    /// components are unspecified (Appendix B, "ToDateTime"), so the birth may be at any time of that day: at midnight
    /// on the first birthday the age is <c>[0, 1]</c> years and <c>[11, 12]</c> months. The SDK counts the year or
    /// month as whole from the first moment of the birthday, the high end of the interval. Uncertainty is tracked in
    /// https://github.com/FirelyTeam/firely-cql-sdk/issues/132.
    /// </summary>
    [TestMethod]
    [DataRow("year", 1, 0, 1)]
    [DataRow("month", 12, 11, 12)]
    public void CalculateAgeAt_ABirthDateAsADateTime_OnTheBirthday_WhereTheSpecificationGivesAnUncertainty_PinsTheCurrentSingleCount(
        string precision, int current, int uncertaintyLow, int uncertaintyHigh)
    {
        var birthDate = Context.Operators.ConvertDateToDateTime(new CqlDate(2012, 3, 10));

        AssertPinnedCountOfAnUncertainty(
            Context.Operators.CalculateAgeAt(birthDate, Dt("2013-03-10T00:00:00.000"), precision),
            current,
            uncertaintyLow,
            uncertaintyHigh);
    }

    /// <summary>
    /// Asserts that <paramref name="count"/> is still <paramref name="current"/>, and that it is an end of the
    /// uncertainty interval from <paramref name="uncertaintyLow"/> to <paramref name="uncertaintyHigh"/> that the
    /// specification defines.
    /// </summary>
    private static void AssertPinnedCountOfAnUncertainty(int? count, int current, int uncertaintyLow, int uncertaintyHigh)
    {
        Assert.AreEqual(current, count);
        Assert.IsTrue(
            count == uncertaintyLow || count == uncertaintyHigh,
            $"{count} is not an end of the uncertainty [{uncertaintyLow}, {uncertaintyHigh}].");
    }
}
