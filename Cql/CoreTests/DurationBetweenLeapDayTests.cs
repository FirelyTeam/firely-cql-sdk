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
/// Whole years counted back from or to 29 February are the negative of those counted forwards. A year that starts on
/// 29 February ends on 29 February of a leap year and on 28 February of any other year. CQL 1.5.3 Errata 2,
/// Appendix H - Time Interval Calculations, "Calculating Duration in Years", the note on Example 4.b: "Because there is
/// no February 29 in 2014, per the Date and Time Arithmetic section, the last day of the calendar month is used. Thus
/// the number of years can only change when the date reaches February 28. (e.g. 2012-02-29 + 1 year = 2013-02-28)".
/// The negative examples of that section (Scenarios 5 to 8) give the count back from the later date as the negative of
/// the count forwards from the earlier one.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class DurationBetweenLeapDayTests
{
    private static readonly CqlContext Context = FhirCqlContext.WithDataSource();

    /// <summary>The time of day given to both values when a case is evaluated on DateTimes.</summary>
    private const string TimeOfDay = "T12:34:56";

    private static CqlDate D(string value) =>
        CqlDate.TryParse(value, out var date) ? date! : throw new ArgumentException(value);

    private static CqlDateTime Dt(string value) =>
        CqlDateTime.TryParse(value, out var dateTime) ? dateTime! : throw new ArgumentException(value);

    private static int? Between(CqlDate low, CqlDate high, string precision) =>
        Context.Operators.DurationBetween(low, high, precision);

    private static int? Between(CqlDateTime low, CqlDateTime high, string precision) =>
        Context.Operators.DurationBetween(low, high, precision);

    /// <summary>
    /// An earlier and a later date, one of them 29 February, and the whole years from the earlier to the later.
    /// </summary>
    private static IEnumerable<object[]> YearCases =>
    [
        // From 29 February.
        ["2012-02-29", "2012-03-01", 0],
        ["2012-02-29", "2013-01-15", 0],
        ["2012-02-29", "2013-02-27", 0],
        ["2012-02-29", "2013-02-28", 1],
        ["2012-02-29", "2013-03-01", 1],
        ["2012-02-29", "2015-03-01", 3],
        ["2012-02-29", "2016-02-28", 3],
        ["2012-02-29", "2016-02-29", 4],
        ["2012-02-29", "2016-03-01", 4],
        // To 29 February.
        ["2011-01-15", "2012-02-29", 1],
        ["2011-02-28", "2012-02-29", 1],
        ["2011-03-01", "2012-02-29", 0],
        ["2012-01-15", "2012-02-29", 0],
        ["2012-02-28", "2012-02-29", 0],
        ["2012-01-15", "2016-02-29", 4],
        ["2012-03-01", "2016-02-29", 3],
        ["2015-02-28", "2016-02-29", 1],
        ["2015-03-01", "2016-02-29", 0],
    ];

    /// <summary>
    /// An earlier and a later DateTime, one of them on 29 February, whose times of day decide the count, and the whole
    /// years from the earlier to the later.
    /// </summary>
    private static IEnumerable<object[]> YearTimeOfDayCases =>
    [
        ["2012-02-29T12:34:56", "2013-02-28T12:34:55", 0],
        ["2012-02-29T12:34:56", "2013-02-28T12:34:56", 1],
        ["2012-02-29T12:34:56", "2016-02-29T12:34:55", 3],
        ["2012-02-29T12:34:56", "2016-02-29T12:34:56", 4],
        ["2012-02-29T23:59:59", "2012-03-01T00:00:00", 0],
        ["2012-02-28T12:34:56", "2012-02-29T12:34:55", 0],
        ["2011-02-28T12:34:56", "2012-02-29T12:34:55", 1],
    ];

    /// <summary>
    /// An earlier and a later date, one of them 29 February, and the whole months from the earlier to the later. A
    /// month that would end on a day its end month does not have ends on the first day of the next month, as the
    /// definition in Appendix H, "Calculating Duration in Months", gives it.
    /// </summary>
    private static IEnumerable<object[]> MonthCases =>
    [
        ["2012-01-15", "2012-02-29", 1],
        ["2012-01-29", "2012-02-29", 1],
        ["2012-01-30", "2012-02-29", 0],
        ["2012-01-31", "2012-02-29", 0],
        ["2012-02-29", "2012-03-28", 0],
        ["2012-02-29", "2012-03-29", 1],
        ["2012-02-29", "2013-02-28", 11],
        ["2012-02-29", "2013-03-01", 12],
        ["2011-02-28", "2012-02-29", 12],
    ];

    [TestMethod]
    [DynamicData(nameof(YearCases))]
    public void YearsBetween_Dates_FromOrTo29February_Forwards(string earlier, string later, int years) =>
        Assert.AreEqual(years, Between(D(earlier), D(later), "year"));

    [TestMethod]
    [DynamicData(nameof(YearCases))]
    public void YearsBetween_Dates_BackFromOrTo29February_IsTheNegativeOfForwards(string earlier, string later, int years) =>
        Assert.AreEqual(-years, Between(D(later), D(earlier), "year"));

    [TestMethod]
    [DynamicData(nameof(YearCases))]
    public void YearsBetween_DateTimes_FromOrTo29February_Forwards(string earlier, string later, int years) =>
        Assert.AreEqual(years, Between(Dt(earlier + TimeOfDay), Dt(later + TimeOfDay), "year"));

    [TestMethod]
    [DynamicData(nameof(YearCases))]
    public void YearsBetween_DateTimes_BackFromOrTo29February_IsTheNegativeOfForwards(string earlier, string later, int years) =>
        Assert.AreEqual(-years, Between(Dt(later + TimeOfDay), Dt(earlier + TimeOfDay), "year"));

    [TestMethod]
    [DynamicData(nameof(YearTimeOfDayCases))]
    public void YearsBetween_DateTimes_FromOrTo29February_TheTimeOfDayDecides_InBothDirections(string earlier, string later, int years)
    {
        Assert.AreEqual(years, Between(Dt(earlier), Dt(later), "year"), "forwards");
        Assert.AreEqual(-years, Between(Dt(later), Dt(earlier), "year"), "backwards");
    }

    [TestMethod]
    [DynamicData(nameof(MonthCases))]
    public void MonthsBetween_Dates_FromOrTo29February_BackwardsIsTheNegativeOfForwards(string earlier, string later, int months)
    {
        Assert.AreEqual(months, Between(D(earlier), D(later), "month"), "forwards");
        Assert.AreEqual(-months, Between(D(later), D(earlier), "month"), "backwards");
    }

    [TestMethod]
    [DynamicData(nameof(MonthCases))]
    public void MonthsBetween_DateTimes_FromOrTo29February_BackwardsIsTheNegativeOfForwards(string earlier, string later, int months)
    {
        Assert.AreEqual(months, Between(Dt(earlier + TimeOfDay), Dt(later + TimeOfDay), "month"), "forwards");
        Assert.AreEqual(-months, Between(Dt(later + TimeOfDay), Dt(earlier + TimeOfDay), "month"), "backwards");
    }

    /// <summary>
    /// <c>CalculateAgeAt</c> is "defined in terms of a datetime duration calculation" (Appendix B, "CalculateAgeAt"),
    /// so an age at a date before a birth on 29 February counts back the same way.
    /// </summary>
    [TestMethod]
    public void CalculateAgeAt_ADateBeforeABirthOn29February_IsTheNegativeOfTheYearsForwards()
    {
        Assert.AreEqual(0, Context.Operators.CalculateAgeAt(D("2012-02-29"), D("2012-01-15"), "year"));
        Assert.AreEqual(-3, Context.Operators.CalculateAgeAt(D("2016-02-29"), D("2012-03-01"), "year"));
    }
}
