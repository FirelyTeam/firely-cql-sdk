/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace CoreTests
{
    /// <summary>
    /// A period that starts on 29 February completes a whole year on 28 February when the end year has no leap day,
    /// the same day that adding one year to the leap day lands on. CQL 1.5.3 Errata 2, Appendix B - CQL Reference,
    /// section "Duration": the operator "returns the number of whole calendar periods for the specified precision
    /// between the first and second arguments." The HL7 CQL conformance suite (CqlDateTimeOperatorsTest, group
    /// Duration, tests YearsBetweenLeapYearDatesEquals2 and YearsBetweenLeapYearDateTimesEquals2) expects
    /// <c>years between @2012-02-29 and @2014-02-28</c> to be 2.
    /// </summary>
    [TestClass]
    [TestCategory("UnitTest")]
    public class YearsBetweenLeapDayStartTests
    {
        private static readonly CqlContext Context = FhirCqlContext.WithDataSource();

        private static CqlDateTime Dt(string value) =>
            CqlDateTime.TryParse(value, out var dateTime) ? dateTime! : throw new ArgumentException(value);

        [TestMethod]
        [DataRow(2013, 2, 27, 0, DisplayName = "27 February of a non-leap year is short of the first anniversary")]
        [DataRow(2013, 2, 28, 1, DisplayName = "28 February of a non-leap year completes the first year")]
        [DataRow(2014, 2, 28, 2, DisplayName = "28 February of a non-leap year completes the second year")]
        [DataRow(2014, 3, 1, 2, DisplayName = "1 March of a non-leap year")]
        [DataRow(2016, 2, 28, 3, DisplayName = "28 February of a leap year is short of the 29th")]
        [DataRow(2016, 2, 29, 4, DisplayName = "29 February of a leap year completes the year")]
        public void YearsBetween_FromALeapDay(int year, int month, int day, int expected) =>
            Assert.AreEqual(expected, Context.Operators.DurationBetween(new CqlDate(2012, 2, 29), new CqlDate(year, month, day), "year"));

        [TestMethod]
        public void YearsBetween_FromALeapDayDateTime_ToTheSameTimeOn28February_IsWhole() =>
            Assert.AreEqual(2, Context.Operators.DurationBetween(Dt("2012-02-29T12:34:56"), Dt("2014-02-28T12:34:56"), "year"));

        [TestMethod]
        public void YearsBetween_From28FebruaryBackToTheLeapDay_IsTheNegativeOfTheForwardResult()
        {
            var leapDay = new CqlDate(2012, 2, 29);
            var anniversary = new CqlDate(2014, 2, 28);

            Assert.AreEqual(2, Context.Operators.DurationBetween(leapDay, anniversary, "year"));
            Assert.AreEqual(-2, Context.Operators.DurationBetween(anniversary, leapDay, "year"));
        }

        [TestMethod]
        public void AgeInYearsAt_BornOnALeapDay_On28FebruaryOfANonLeapYear_HasHadTheBirthday() =>
            Assert.AreEqual(18, Context.Operators.CalculateAgeAt(new CqlDate(2008, 2, 29), new CqlDate(2026, 2, 28), "year"));
    }
}
