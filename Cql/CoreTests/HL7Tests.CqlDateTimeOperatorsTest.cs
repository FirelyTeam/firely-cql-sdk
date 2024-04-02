using Hl7.Cql.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace CoreTests
{
    public partial class HL7Tests
    {

        /// <summary>
		///define "DateTimeAdd5Years":
		///	( DateTime(2005, 10, 10) + 5 years ) = @2010-10-10
		/// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAdd5Years_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAdd5Years"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAdd5Months":
        ///	( DateTime(2005, 5, 10) + 5 months ) = @2005-10-10
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAdd5Months_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAdd5Months"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAddMonthsOverflow":
        ///	( DateTime(2005, 5, 10) + 10 months ) = @2006-03-10
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAddMonthsOverflow_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAddMonthsOverflow"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAdd5Days":
        ///	( DateTime(2005, 5, 10) + 5 days ) = @2005-05-15
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAdd5Days_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAdd5Days"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAddDaysOverflow":
        ///	( DateTime(2016, 6, 10) + 21 days ) = @2016-07-01
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAddDaysOverflow_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAddDaysOverflow"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAdd5Hours":
        ///	( DateTime(2005, 5, 10, 5) + 5 hours ) = @2005-05-10T10
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAdd5Hours_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAdd5Hours"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAddHoursOverflow":
        ///	( DateTime(2016, 6, 10, 5) + 19 hours ) = @2016-06-11T00
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAddHoursOverflow_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAddHoursOverflow"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAdd5Minutes":
        ///	( DateTime(2005, 5, 10, 5, 5) + 5 minutes ) = @2005-05-10T05:10
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAdd5Minutes_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAdd5Minutes"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAddMinutesOverflow":
        ///	( DateTime(2016, 6, 10, 5, 5) + 55 minutes ) = @2016-06-10T06:00
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAddMinutesOverflow_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAddMinutesOverflow"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAdd5Seconds":
        ///	( DateTime(2005, 5, 10, 5, 5, 5) + 5 seconds ) = @2005-05-10T05:05:10
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAdd5Seconds_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAdd5Seconds"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAddSecondsOverflow":
        ///	( DateTime(2016, 6, 10, 5, 5, 5) + 55 seconds ) = @2016-06-10T05:06:00
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAddSecondsOverflow_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAddSecondsOverflow"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAdd5Milliseconds":
        ///	( DateTime(2005, 5, 10, 5, 5, 5, 5) + 5 milliseconds ) = @2005-05-10T05:05:05.010
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAdd5Milliseconds_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAdd5Milliseconds"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAddMillisecondsOverflow":
        ///	( DateTime(2016, 6, 10, 5, 5, 5, 5) + 995 milliseconds ) = @2016-06-10T05:05:06.000
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAddMillisecondsOverflow_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAddMillisecondsOverflow"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAddLeapYear":
        ///	( DateTime(2012, 2, 29) + 1 year ) = @2013-02-28
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAddLeapYear_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAddLeapYear"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAdd2YearsByMonths":
        ///	( DateTime(2014) + 24 months ) = @2016
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAdd2YearsByMonths_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAdd2YearsByMonths"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAdd2YearsByDays":
        ///	( DateTime(2014) + 730 days ) = @2016
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAdd2YearsByDays_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAdd2YearsByDays"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAdd2YearsByDaysRem5Days":
        ///	( DateTime(2014) + 735 days ) = @2016
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAdd2YearsByDaysRem5Days_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAdd2YearsByDaysRem5Days"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeAdd5Hours":
        ///	( @T15:59:59.999 + 5 hours ) = @T20:59:59.999
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeAdd5Hours_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeAdd5Hours"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeAdd1Minute":
        ///	( @T15:59:59.999 + 1 minute ) = @T16:00:59.999
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeAdd1Minute_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeAdd1Minute"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeAdd1Second":
        ///	( @T15:59:59.999 + 1 seconds ) = @T16:00:00.999
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeAdd1Second_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeAdd1Second"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeAdd1Millisecond":
        ///	( @T15:59:59.999 + 1 milliseconds ) = @T16:00:00.000
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeAdd1Millisecond_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeAdd1Millisecond"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeAdd5Hours1Minute":
        ///	( @T15:59:59.999 + 5 hours + 1 minutes ) = @T21:00:59.999
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeAdd5Hours1Minute_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeAdd5Hours1Minute"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeAdd5hoursByMinute":
        ///	( @T15:59:59.999 + 300 minutes ) = @T20:59:59.999
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeAdd5hoursByMinute_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeAdd5hoursByMinute"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAfterYearTrue":
        ///	( DateTime(2005, 10, 10) after year of DateTime(2004, 10, 10) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterYearTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAfterYearTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAfterYearFalse":
        ///	( DateTime(2004, 11, 10) after year of DateTime(2004, 10, 10) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterYearFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAfterYearFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAfterMonthTrue":
        ///	( DateTime(2004, 12, 10) after month of DateTime(2004, 11, 10) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterMonthTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAfterMonthTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAfterMonthFalse":
        ///	( DateTime(2004, 9, 10) after month of DateTime(2004, 10, 10) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterMonthFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAfterMonthFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAfterDayTrue":
        ///	( DateTime(2004, 12, 11) after day of DateTime(2004, 10, 10) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterDayTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAfterDayTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAfterDayTrue2":
        ///	( DateTime(2004, 12, 09) after day of DateTime(2003, 10, 10) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterDayTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAfterDayTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAfterDayFalse":
        ///	( DateTime(2004, 10, 9) after day of DateTime(2004, 10, 10) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterDayFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAfterDayFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAfterHourTrue":
        ///	( DateTime(2004, 10, 10, 10) after hour of DateTime(2004, 10, 10, 5) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterHourTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAfterHourTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAfterHourFalse":
        ///	( DateTime(2004, 10, 10, 20) after hour of DateTime(2004, 10, 10, 21) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterHourFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAfterHourFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAfterMinuteTrue":
        ///	( DateTime(2004, 10, 10, 20, 30) after minute of DateTime(2004, 10, 10, 20, 29) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterMinuteTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAfterMinuteTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAfterMinuteFalse":
        ///	( DateTime(2004, 10, 10, 20, 30) after minute of DateTime(2004, 10, 10, 20, 31) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterMinuteFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAfterMinuteFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAfterSecondTrue":
        ///	( DateTime(2004, 10, 10, 20, 30, 15) after second of DateTime(2004, 10, 10, 20, 30, 14) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterSecondTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAfterSecondTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAfterSecondFalse":
        ///	( DateTime(2004, 10, 10, 20, 30, 15) after second of DateTime(2004, 10, 10, 20, 30, 16) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterSecondFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAfterSecondFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAfterMillisecondTrue":
        ///	( DateTime(2004, 10, 10, 20, 30, 15, 512) after millisecond of DateTime(2004, 10, 10, 20, 30, 15, 510) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterMillisecondTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAfterMillisecondTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAfterMillisecondFalse":
        ///	( DateTime(2004, 10, 10, 20, 30, 15, 512) after millisecond of DateTime(2004, 10, 10, 20, 30, 15, 513) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterMillisecondFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAfterMillisecondFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAfterUncertain":
        ///	( DateTime(2005, 10, 10) after day of DateTime(2005, 9) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAfterUncertain_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAfterUncertain"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "AfterTimezoneTrue":
        ///	( @2012-03-10T10:20:00.999+07:00 after hour of @2012-03-10T08:20:00.999+06:00 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void AfterTimezoneTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "AfterTimezoneTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "AfterTimezoneFalse":
        ///	( @2012-03-10T10:20:00.999+07:00 after hour of @2012-03-10T10:20:00.999+06:00 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void AfterTimezoneFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "AfterTimezoneFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeAfterHourTrue":
        ///	( @T15:59:59.999 after hour of @T14:59:59.999 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeAfterHourTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeAfterHourTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeAfterHourFalse":
        ///	( @T15:59:59.999 after hour of @T16:59:59.999 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeAfterHourFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeAfterHourFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeAfterMinuteTrue":
        ///	( @T15:59:59.999 after minute of @T15:58:59.999 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeAfterMinuteTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeAfterMinuteTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeAfterMinuteFalse":
        ///	( @T15:58:59.999 after minute of @T15:59:59.999 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeAfterMinuteFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeAfterMinuteFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeAfterSecondTrue":
        ///	( @T15:59:59.999 after second of @T15:59:58.999 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeAfterSecondTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeAfterSecondTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeAfterSecondFalse":
        ///	( @T15:59:58.999 after second of @T15:59:59.999 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeAfterSecondFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeAfterSecondFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeAfterMillisecondTrue":
        ///	( @T15:59:59.999 after millisecond of @T15:59:59.998 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeAfterMillisecondTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeAfterMillisecondTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeAfterMillisecondFalse":
        ///	( @T15:59:59.998 after millisecond of @T15:59:59.999 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeAfterMillisecondFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeAfterMillisecondFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeAfterTimeCstor":
        ///	( Time(12, 30) after hour of Time(11, 55) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeAfterTimeCstor_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeAfterTimeCstor"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeBeforeYearTrue":
        ///	( DateTime(2003) before year of DateTime(2004, 10, 10) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeBeforeYearTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeBeforeYearTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeBeforeYearFalse":
        ///	( DateTime(2004, 11, 10) before year of DateTime(2003, 10, 10) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeBeforeYearFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeBeforeYearFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeBeforeMonthTrue":
        ///	( DateTime(2004, 10, 10) before month of DateTime(2004, 11, 10) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeBeforeMonthTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeBeforeMonthTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeBeforeMonthFalse":
        ///	( DateTime(2004, 11, 10) before month of DateTime(2004, 10, 10) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeBeforeMonthFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeBeforeMonthFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeBeforeDayTrue":
        ///	( DateTime(2004, 10, 1) before day of DateTime(2004, 10, 10) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeBeforeDayTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeBeforeDayTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeBeforeDayTrue2":
        ///	( DateTime(2003, 10, 11) before day of DateTime(2004, 10, 10) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeBeforeDayTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeBeforeDayTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeBeforeDayFalse":
        ///	( DateTime(2004, 10, 11) before day of DateTime(2004, 10, 10) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeBeforeDayFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeBeforeDayFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeBeforeHourTrue":
        ///	( DateTime(2004, 10, 10, 1) before hour of DateTime(2004, 10, 10, 5) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeBeforeHourTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeBeforeHourTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeBeforeHourFalse":
        ///	( DateTime(2004, 10, 10, 23) before hour of DateTime(2004, 10, 10, 21) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeBeforeHourFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeBeforeHourFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeBeforeMinuteTrue":
        ///	( DateTime(2004, 10, 10, 20, 28) before minute of DateTime(2004, 10, 10, 20, 29) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeBeforeMinuteTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeBeforeMinuteTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeBeforeMinuteFalse":
        ///	( DateTime(2004, 10, 10, 20, 35) before minute of DateTime(2004, 10, 10, 20, 31) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeBeforeMinuteFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeBeforeMinuteFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeBeforeSecondTrue":
        ///	( DateTime(2004, 10, 10, 20, 30, 12) before second of DateTime(2004, 10, 10, 20, 30, 14) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeBeforeSecondTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeBeforeSecondTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeBeforeSecondFalse":
        ///	( DateTime(2004, 10, 10, 20, 30, 55) before second of DateTime(2004, 10, 10, 20, 30, 16) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeBeforeSecondFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeBeforeSecondFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeBeforeMillisecondTrue":
        ///	( DateTime(2004, 10, 10, 20, 30, 15, 508) before millisecond of DateTime(2004, 10, 10, 20, 30, 15, 510) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeBeforeMillisecondTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeBeforeMillisecondTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeBeforeMillisecondFalse":
        ///	( DateTime(2004, 10, 10, 20, 30, 15, 599) before millisecond of DateTime(2004, 10, 10, 20, 30, 15, 513) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeBeforeMillisecondFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeBeforeMillisecondFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "BeforeTimezoneTrue":
        ///	( @2012-03-10T10:20:00.999+07:00 before hour of @2012-03-10T10:20:00.999+06:00 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void BeforeTimezoneTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "BeforeTimezoneTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "BeforeTimezoneFalse":
        ///	( @2012-03-10T10:20:00.999+07:00 before hour of @2012-03-10T09:20:00.999+06:00 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void BeforeTimezoneFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "BeforeTimezoneFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeBeforeHourTrue":
        ///	( @T13:59:59.999 before hour of @T14:59:59.999 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeBeforeHourTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeBeforeHourTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeBeforeHourFalse":
        ///	( @T16:59:59.999 before hour of @T15:59:59.999 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeBeforeHourFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeBeforeHourFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeBeforeMinuteTrue":
        ///	( @T15:57:59.999 before minute of @T15:58:59.999 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeBeforeMinuteTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeBeforeMinuteTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeBeforeMinuteFalse":
        ///	( @T15:59:59.999 before minute of @T15:59:59.999 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeBeforeMinuteFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeBeforeMinuteFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeBeforeSecondTrue":
        ///	( @T15:59:57.999 before second of @T15:59:58.999 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeBeforeSecondTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeBeforeSecondTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeBeforeSecondFalse":
        ///	( @T15:59:56.999 before second of @T15:59:55.999 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeBeforeSecondFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeBeforeSecondFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeBeforeMillisecondTrue":
        ///	( @T15:59:59.997 before millisecond of @T15:59:59.998 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeBeforeMillisecondTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeBeforeMillisecondTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeBeforeMillisecondFalse":
        ///	( @T15:59:59.998 before millisecond of @T15:59:59.997 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeBeforeMillisecondFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeBeforeMillisecondFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeYear":
        ///	( DateTime(2003) ) = @2003
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeYear_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeYear"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeMonth":
        ///	( DateTime(2003, 10) ) = @2003-10
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeMonth_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeMonth"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDay":
        ///	( DateTime(2003, 10, 29) ) = @2003-10-29
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDay_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDay"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeHour":
        ///	( DateTime(2003, 10, 29, 20) ) = @2003-10-29T20
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeHour_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeHour"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeMinute":
        ///	( DateTime(2003, 10, 29, 20, 50) ) = @2003-10-29T20:50
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeMinute_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeMinute"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSecond":
        ///	( DateTime(2003, 10, 29, 20, 50, 33) ) = @2003-10-29T20:50:33
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSecond_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSecond"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeMillisecond":
        ///	( DateTime(2003, 10, 29, 20, 50, 33, 955) ) = @2003-10-29T20:50:33.955
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeMillisecond_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeMillisecond"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeComponentFromYear":
        ///	( year from DateTime(2003, 10, 29, 20, 50, 33, 955) ) = 2003
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeComponentFromYear_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeComponentFromYear"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeComponentFromMonth":
        ///	( month from DateTime(2003, 10, 29, 20, 50, 33, 955) ) = 10
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeComponentFromMonth_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeComponentFromMonth"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeComponentFromMonthMinBoundary":
        ///	( month from DateTime(2003, 01, 29, 20, 50, 33, 955) ) = 1
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeComponentFromMonthMinBoundary_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeComponentFromMonthMinBoundary"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeComponentFromDay":
        ///	( day from DateTime(2003, 10, 29, 20, 50, 33, 955) ) = 29
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeComponentFromDay_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeComponentFromDay"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeComponentFromHour":
        ///	( hour from DateTime(2003, 10, 29, 20, 50, 33, 955) ) = 20
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeComponentFromHour_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeComponentFromHour"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeComponentFromMinute":
        ///	( minute from DateTime(2003, 10, 29, 20, 50, 33, 955) ) = 50
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeComponentFromMinute_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeComponentFromMinute"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeComponentFromSecond":
        ///	( second from DateTime(2003, 10, 29, 20, 50, 33, 955) ) = 33
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeComponentFromSecond_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeComponentFromSecond"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeComponentFromMillisecond":
        ///	( millisecond from DateTime(2003, 10, 29, 20, 50, 33, 955) ) = 955
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeComponentFromMillisecond_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeComponentFromMillisecond"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeComponentFromTimezone":
        ///	( timezone from DateTime(2003, 10, 29, 20, 50, 33, 955, 1) ) = 1.00
        /// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeComponentFromTimezone_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeComponentFromTimezone"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeComponentFromDate":
        ///	( date from DateTime(2003, 10, 29, 20, 50, 33, 955, 1) ) = @2003-10-29
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeComponentFromDate_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeComponentFromDate"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeComponentFromHour":
        ///	( hour from @T23:20:15.555 ) = 23
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeComponentFromHour_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeComponentFromHour"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeComponentFromMinute":
        ///	( minute from @T23:20:15.555 ) = 20
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeComponentFromMinute_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeComponentFromMinute"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeComponentFromSecond":
        ///	( second from @T23:20:15.555 ) = 15
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeComponentFromSecond_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeComponentFromSecond"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeComponentFromMilli":
        ///	( millisecond from @T23:20:15.555 ) = 555
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeComponentFromMilli_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeComponentFromMilli"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDifferenceYear":
        ///	( difference in years between DateTime(2000) and DateTime(2005, 12) ) = 5
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDifferenceYear_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDifferenceYear"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDifferenceMonth":
        ///	( difference in months between DateTime(2000, 2) and DateTime(2000, 10) ) = 8
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDifferenceMonth_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDifferenceMonth"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDifferenceDay":
        ///	( difference in days between DateTime(2000, 10, 15, 10, 30) and DateTime(2000, 10, 25, 10, 0) ) = 10
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDifferenceDay_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDifferenceDay"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDifferenceHour":
        ///	( difference in hours between DateTime(2000, 4, 1, 12) and DateTime(2000, 4, 1, 20) ) = 8
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDifferenceHour_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDifferenceHour"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDifferenceMinute":
        ///	( difference in minutes between DateTime(2005, 12, 10, 5, 16) and DateTime(2005, 12, 10, 5, 25) ) = 9
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDifferenceMinute_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDifferenceMinute"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDifferenceSecond":
        ///	( difference in seconds between DateTime(2000, 10, 10, 10, 5, 45) and DateTime(2000, 10, 10, 10, 5, 50) ) = 5
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDifferenceSecond_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDifferenceSecond"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDifferenceMillisecond":
        ///	( difference in milliseconds between DateTime(2000, 10, 10, 10, 5, 45, 500, -6.0) and DateTime(2000, 10, 10, 10, 5, 45, 900, -7.0) ) = 3600400
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDifferenceMillisecond_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDifferenceMillisecond"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDifferenceWeeks":
        ///	( difference in weeks between DateTime(2000, 10, 15) and DateTime(2000, 10, 28) ) = 1
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDifferenceWeeks_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDifferenceWeeks"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDifferenceWeeks2":
        ///	( difference in weeks between DateTime(2000, 10, 15) and DateTime(2000, 10, 29) ) = 2
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDifferenceWeeks2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDifferenceWeeks2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDifferenceWeeks3":
        ///	( difference in weeks between @2012-03-10T22:05:09 and @2012-03-24T07:19:33 ) = 2
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDifferenceWeeks3_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDifferenceWeeks3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDifferenceNegative":
        ///	( difference in years between DateTime(2016) and DateTime(1998) ) = -18
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDifferenceNegative_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDifferenceNegative"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDifferenceUncertain":
        ///	( difference in months between DateTime(2005) and DateTime(2006, 7) > 5 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDifferenceUncertain_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDifferenceUncertain"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeDifferenceHour":
        ///	( difference in hours between @T20 and @T23:25:15.555 ) = 3
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeDifferenceHour_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeDifferenceHour"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeDifferenceMinute":
        ///	( difference in minutes between @T20:20:15.555 and @T20:25:15.555 ) = 5
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeDifferenceMinute_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeDifferenceMinute"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeDifferenceSecond":
        ///	( difference in seconds between @T20:20:15.555 and @T20:20:20.555 ) = 5
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeDifferenceSecond_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeDifferenceSecond"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeDifferenceMillis":
        ///	( difference in milliseconds between @T20:20:15.555 and @T20:20:15.550 ) = -5
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeDifferenceMillis_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeDifferenceMillis"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeA":
        ///	( @2017-03-12T01:00:00-07:00 ) = @2017-03-12T01:00:00
        /// </summary>
        [Ignore(DoesNotConformToSpec)]
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeA_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAA":
        ///	( DateTime(2017, 3, 12, 1, 0, 0, 0, -7.0) ) = @2017-03-12T01:00:00.000
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAA_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeB":
        ///	( @2017-03-12T03:00:00-06:00 ) = @2017-03-12T03:00:00
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeB_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeB"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeBB":
        ///	( DateTime(2017, 3, 12, 3, 0, 0, 0, -6.0) ) = @2017-03-12T03:00:00.000
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeBB_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeBB"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeC":
        ///	( @2017-11-05T01:30:00-06:00 ) = @2017-11-05T01:30:00
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeC_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeC"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeCC":
        ///	( DateTime(2017, 11, 5, 1, 30, 0, 0, -6.0) ) = @2017-11-05T01:30:00.000
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeCC_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeCC"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeD":
        ///	( @2017-11-05T01:15:00-07:00 ) = @2017-11-05T01:15:00
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeD_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeD"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDD":
        ///	( DateTime(2017, 11, 5, 1, 15, 0, 0, -7.0) ) = @2017-11-05T01:15:00.000
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDD_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDD"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeE":
        ///	( @2017-03-12T00:00:00-07:00 ) = @2017-03-12T00:00:00
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeE_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeE"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        public static string GetDebugView(Expression exp)
        {
            if (exp == null)
                return null;

            var propertyInfo = typeof(Expression).GetProperty("DebugView", BindingFlags.Instance | BindingFlags.NonPublic);
            return propertyInfo.GetValue(exp) as string;
        }

        /// <summary>
        ///define "DateTimeEE":
        ///	( DateTime(2017, 3, 12, 0, 0, 0, 0, -7.0) ) = @2017-03-12T00:00:00.000
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeEE_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeEE"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeF":
        ///	( @2017-03-13T00:00:00-06:00 ) = @2017-03-13T00:00:00
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeF_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeF"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeFF":
        ///	( DateTime(2017, 3, 13, 0, 0, 0, 0, -6.0) ) = @2017-03-13T00:00:00.000
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeFF_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeFF"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DifferenceInHoursA":
        ///	( difference in hours between @2017-03-12T01:00:00-07:00 and @2017-03-12T03:00:00-06:00 ) = 1
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DifferenceInHoursA_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DifferenceInHoursA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DifferenceInMinutesA":
        ///	( difference in minutes between @2017-11-05T01:30:00-06:00 and @2017-11-05T01:15:00-07:00 ) = 45
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DifferenceInMinutesA_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DifferenceInMinutesA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DifferenceInDaysA":
        ///	( difference in days between @2017-03-12T00:00:00-07:00 and @2017-03-13T00:00:00-06:00 ) = 1
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DifferenceInDaysA_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DifferenceInDaysA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DifferenceInHoursAA":
        ///	( difference in hours between DateTime(2017, 3, 12, 1, 0, 0, 0, -7.0) and DateTime(2017, 3, 12, 3, 0, 0, 0, -6.0) ) = 1
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DifferenceInHoursAA_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DifferenceInHoursAA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DifferenceInMinutesAA":
        ///	( difference in minutes between DateTime(2017, 11, 5, 1, 30, 0, 0, -6.0) and DateTime(2017, 11, 5, 1, 15, 0, 0, -7.0) ) = 45
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DifferenceInMinutesAA_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DifferenceInMinutesAA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DifferenceInDaysAA":
        ///	( difference in days between DateTime(2017, 3, 12, 0, 0, 0, 0, -7.0) and DateTime(2017, 3, 13, 0, 0, 0, 0, -6.0) ) = 1
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DifferenceInDaysAA_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DifferenceInDaysAA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDurationBetweenYear":
        ///	( years between DateTime(2005) and DateTime(2010) ) = 5
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDurationBetweenYear_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDurationBetweenYear"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDurationBetweenYearOffset":
        ///	( years between DateTime(2005, 5) and DateTime(2010, 4) ) = 4
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDurationBetweenYearOffset_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDurationBetweenYearOffset"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDurationBetweenMonth":
        ///	( months between @2014-01-31 and @2014-02-01 ) = 0
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDurationBetweenMonth_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDurationBetweenMonth"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDurationBetweenDaysDiffYears":
        ///	( days between DateTime(2010, 10, 12, 12, 5) and DateTime(2008, 8, 15, 8, 8) ) = -788
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDurationBetweenDaysDiffYears_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDurationBetweenDaysDiffYears"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDurationBetweenUncertainInterval":
        ///	( days between DateTime(2014, 1, 15) and DateTime(2014, 2) ) = Interval[ 17, 44 ]
        /// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDurationBetweenUncertainInterval_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDurationBetweenUncertainInterval"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDurationBetweenUncertainInterval2":
        ///	( months between DateTime(2005) and DateTime(2006, 5) ) = Interval[ 5, 16 ]
        /// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDurationBetweenUncertainInterval2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDurationBetweenUncertainInterval2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDurationBetweenUncertainAdd":
        ///	( (days between DateTime(2014, 1, 15) and DateTime(2014, 2))
        ///				+ (days between DateTime(2014, 1, 15) and DateTime(2014, 2)) ) = Interval[ 34, 88 ]
        /// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDurationBetweenUncertainAdd_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDurationBetweenUncertainAdd"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDurationBetweenUncertainSubtract":
        ///	( (days between DateTime(2014, 1, 15) and DateTime(2014, 2))
        ///				- (months between DateTime(2005) and DateTime(2006, 5)) ) = Interval[ 12, 28 ]
        /// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDurationBetweenUncertainSubtract_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDurationBetweenUncertainSubtract"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDurationBetweenUncertainMultiply":
        ///	( (days between DateTime(2014, 1, 15) and DateTime(2014, 2))
        ///				* (days between DateTime(2014, 1, 15) and DateTime(2014, 2)) ) = Interval[ 289, 1936 ]
        /// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDurationBetweenUncertainMultiply_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDurationBetweenUncertainMultiply"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDurationBetweenMonthUncertain":
        ///	( months between DateTime(2005) and DateTime(2006, 7) > 5 ) = true
        /// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDurationBetweenMonthUncertain_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDurationBetweenMonthUncertain"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDurationBetweenMonthUncertain2":
        ///	( months between DateTime(2005) and DateTime(2006, 2) > 5 ) = null
        /// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDurationBetweenMonthUncertain2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDurationBetweenMonthUncertain2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }

        /// <summary>
        ///define "DateTimeDurationBetweenMonthUncertain3":
        ///	( months between DateTime(2005) and DateTime(2006, 7) > 25 ) = false
        /// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDurationBetweenMonthUncertain3_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDurationBetweenMonthUncertain3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDurationBetweenMonthUncertain4":
        ///	( months between DateTime(2005) and DateTime(2006, 7) &lt; 24 ) = true
        /// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDurationBetweenMonthUncertain4_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDurationBetweenMonthUncertain4"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDurationBetweenMonthUncertain5":
        ///	( months between DateTime(2005) and DateTime(2006, 7) = 24 ) = false
        /// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDurationBetweenMonthUncertain5_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDurationBetweenMonthUncertain5"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDurationBetweenMonthUncertain6":
        ///	( months between DateTime(2005) and DateTime(2006, 7) >= 5 ) = true
        /// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDurationBetweenMonthUncertain6_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDurationBetweenMonthUncertain6"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeDurationBetweenMonthUncertain7":
        ///	( months between DateTime(2005) and DateTime(2006, 7) &lt;= 24 ) = true
        /// </summary>
        [Ignore(NotTestedByReferenceEngine)]
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeDurationBetweenMonthUncertain7_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeDurationBetweenMonthUncertain7"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTime1":
        ///	( @2012-03-10T10:20:00 ) = @2012-03-10T10:20:00
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTime1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTime1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTime2":
        ///	( @2013-03-10T09:20:00 ) = @2013-03-10T09:20:00
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTime2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTime2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DurationInYears":
        ///	( years between (date from @2012-03-10T10:20:00) and (date from @2013-03-10T09:20:00) ) = 1
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DurationInYears_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DurationInYears"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DurationInWeeks":
        ///	( weeks between @2012-03-10T22:05:09 and @2012-03-20T07:19:33 ) = 1
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DurationInWeeks_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DurationInWeeks"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DurationInWeeks2":
        ///	( weeks between @2012-03-10T22:05:09 and @2012-03-24T07:19:33 ) = 1
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DurationInWeeks2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DurationInWeeks2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DurationInWeeks3":
        ///	( weeks between @2012-03-10T06:05:09 and @2012-03-24T07:19:33 ) = 2
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DurationInWeeks3_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DurationInWeeks3"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeDurationBetweenHour":
        ///	( hours between @T20:26:15.555 and @T23:25:15.555 ) = 2
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeDurationBetweenHour_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeDurationBetweenHour"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeDurationBetweenHourDiffPrecision":
        ///	( hours between @T06Z and @T07:00:00Z ) = 1
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeDurationBetweenHourDiffPrecision_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeDurationBetweenHourDiffPrecision"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeDurationBetweenMinute":
        ///	( minutes between @T23:20:16.555 and @T23:25:15.555 ) = 4
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeDurationBetweenMinute_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeDurationBetweenMinute"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeDurationBetweenSecond":
        ///	( seconds between @T23:25:10.556 and @T23:25:15.555 ) = 4
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeDurationBetweenSecond_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeDurationBetweenSecond"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeDurationBetweenMillis":
        ///	( milliseconds between @T23:25:25.555 and @T23:25:25.560 ) = 5
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeDurationBetweenMillis_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeDurationBetweenMillis"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DurationInHoursA":
        ///	( hours between @2017-03-12T01:00:00-07:00 and @2017-03-12T03:00:00-06:00 ) = 1
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DurationInHoursA_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DurationInHoursA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DurationInMinutesA":
        ///	( minutes between @2017-11-05T01:30:00-06:00 and @2017-11-05T01:15:00-07:00 ) = 45
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DurationInMinutesA_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DurationInMinutesA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DurationInDaysA":
        ///	( days between @2017-03-12T00:00:00-07:00 and @2017-03-13T00:00:00-06:00 ) = 0
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DurationInDaysA_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DurationInDaysA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DurationInHoursAA":
        ///	( hours between DateTime(2017, 3, 12, 1, 0, 0, 0, -7.0) and DateTime(2017, 3, 12, 3, 0, 0, 0, -6.0) ) = 1
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DurationInHoursAA_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DurationInHoursAA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DurationInMinutesAA":
        ///	( minutes between DateTime(2017, 11, 5, 1, 30, 0, 0, -6.0) and DateTime(2017, 11, 5, 1, 15, 0, 0, -7.0) ) = 45
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DurationInMinutesAA_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DurationInMinutesAA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DurationInDaysAA":
        ///	( days between DateTime(2017, 3, 12, 0, 0, 0, 0, -7.0) and DateTime(2017, 3, 13, 0, 0, 0, 0, -6.0) ) = 0
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DurationInDaysAA_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DurationInDaysAA"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeNow":
        ///	( Now() = Now() ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeNow_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeNow"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameAsYearTrue":
        ///	( DateTime(2014) same year as DateTime(2014) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameAsYearTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameAsYearTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameAsYearFalse":
        ///	( DateTime(2013) same year as DateTime(2014) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameAsYearFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameAsYearFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameAsMonthTrue":
        ///	( DateTime(2014, 12) same month as DateTime(2014, 12) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameAsMonthTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameAsMonthTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameAsMonthFalse":
        ///	( DateTime(2014, 12) same month as DateTime(2014, 10) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameAsMonthFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameAsMonthFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameAsDayTrue":
        ///	( DateTime(2014, 12, 10) same day as DateTime(2014, 12, 10) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameAsDayTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameAsDayTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameAsDayFalse":
        ///	( DateTime(2014, 10, 10) same day as DateTime(2014, 10, 11) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameAsDayFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameAsDayFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameAsHourTrue":
        ///	( DateTime(2014, 12, 10, 20) same hour as DateTime(2014, 12, 10, 20) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameAsHourTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameAsHourTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameAsHourFalse":
        ///	( DateTime(2014, 10, 10, 20) same hour as DateTime(2014, 10, 10, 21) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameAsHourFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameAsHourFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameAsMinuteTrue":
        ///	( DateTime(2014, 12, 10, 20, 55) same minute as DateTime(2014, 12, 10, 20, 55) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameAsMinuteTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameAsMinuteTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameAsMinuteFalse":
        ///	( DateTime(2014, 10, 10, 20, 55) same minute as DateTime(2014, 10, 10, 21, 56) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameAsMinuteFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameAsMinuteFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameAsSecondTrue":
        ///	( DateTime(2014, 12, 10, 20, 55, 45) same second as DateTime(2014, 12, 10, 20, 55, 45) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameAsSecondTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameAsSecondTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameAsSecondFalse":
        ///	( DateTime(2014, 10, 10, 20, 55, 45) same second as DateTime(2014, 10, 10, 21, 55, 44) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameAsSecondFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameAsSecondFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameAsMillisecondTrue":
        ///	( DateTime(2014, 12, 10, 20, 55, 45, 500) same millisecond as DateTime(2014, 12, 10, 20, 55, 45, 500) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameAsMillisecondTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameAsMillisecondTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameAsMillisecondFalse":
        ///	( DateTime(2014, 10, 10, 20, 55, 45, 500) same millisecond as DateTime(2014, 10, 10, 21, 55, 45, 501) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameAsMillisecondFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameAsMillisecondFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameAsNull":
        ///	( DateTime(2014, 10) same day as DateTime(2014, 10, 12) ) = null
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameAsNull_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameAsNull"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }

        /// <summary>
        ///define "SameAsTimezoneTrue":
        ///	( @2012-03-10T10:20:00.999+07:00 same hour as @2012-03-10T09:20:00.999+06:00 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void SameAsTimezoneTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "SameAsTimezoneTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "SameAsTimezoneFalse":
        ///	( @2012-03-10T10:20:00.999+07:00 same hour as @2012-03-10T10:20:00.999+06:00 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void SameAsTimezoneFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "SameAsTimezoneFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameAsHourTrue":
        ///	( @T23:25:25.555 same hour as @T23:55:25.900 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameAsHourTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameAsHourTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameAsHourFalse":
        ///	( @T22:25:25.555 same hour as @T23:25:25.555 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameAsHourFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameAsHourFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameAsMinuteTrue":
        ///	( @T23:55:22.555 same minute as @T23:55:25.900 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameAsMinuteTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameAsMinuteTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameAsMinuteFalse":
        ///	( @T23:26:25.555 same minute as @T23:25:25.555 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameAsMinuteFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameAsMinuteFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameAsSecondTrue":
        ///	( @T23:55:25.555 same second as @T23:55:25.900 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameAsSecondTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameAsSecondTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameAsSecondFalse":
        ///	( @T23:25:35.555 same second as @T23:25:25.555 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameAsSecondFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameAsSecondFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameAsMillisTrue":
        ///	( @T23:55:25.555 same millisecond as @T23:55:25.555 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameAsMillisTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameAsMillisTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameAsMillisFalse":
        ///	( @T23:25:25.555 same millisecond as @T23:25:25.554 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameAsMillisFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameAsMillisFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterYearTrue1":
        ///	( DateTime(2014) same year or after DateTime(2014) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterYearTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterYearTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterYearTrue2":
        ///	( DateTime(2016) same year or after DateTime(2014) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterYearTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterYearTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterYearFalse":
        ///	( DateTime(2013) same year or after DateTime(2014) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterYearFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterYearFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterMonthTrue1":
        ///	( DateTime(2014, 12) same month or after DateTime(2014, 12) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterMonthTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterMonthTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterMonthTrue2":
        ///	( DateTime(2014, 10) same month or after DateTime(2014, 9) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterMonthTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterMonthTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterMonthFalse":
        ///	( DateTime(2014, 10) same month or after DateTime(2014, 11) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterMonthFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterMonthFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterDayTrue1":
        ///	( DateTime(2014, 12, 20) same day or after DateTime(2014, 12, 20) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterDayTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterDayTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterDayTrue2":
        ///	( DateTime(2014, 10, 25) same day or after DateTime(2014, 10, 20) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterDayTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterDayTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterDayFalse":
        ///	( DateTime(2014, 10, 20) same day or after DateTime(2014, 10, 25) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterDayFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterDayFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterHourTrue1":
        ///	( DateTime(2014, 12, 20, 12) same hour or after DateTime(2014, 12, 20, 12) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterHourTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterHourTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterHourTrue2":
        ///	( DateTime(2014, 10, 25, 12) same hour or after DateTime(2014, 10, 25, 10) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterHourTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterHourTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterHourFalse":
        ///	( DateTime(2014, 10, 25, 12) same hour or after DateTime(2014, 10, 25, 15) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterHourFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterHourFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterMinuteTrue1":
        ///	( DateTime(2014, 12, 20, 12, 30) same minute or after DateTime(2014, 12, 20, 12, 30) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterMinuteTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterMinuteTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterMinuteTrue2":
        ///	( DateTime(2014, 10, 25, 10, 30) same minute or after DateTime(2014, 10, 25, 10, 25) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterMinuteTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterMinuteTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterMinuteFalse":
        ///	( DateTime(2014, 10, 25, 15, 30) same minute or after DateTime(2014, 10, 25, 15, 45) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterMinuteFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterMinuteFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterSecondTrue1":
        ///	( DateTime(2014, 12, 20, 12, 30, 15) same second or after DateTime(2014, 12, 20, 12, 30, 15) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterSecondTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterSecondTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterSecondTrue2":
        ///	( DateTime(2014, 10, 25, 10, 25, 25) same second or after DateTime(2014, 10, 25, 10, 25, 20) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterSecondTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterSecondTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterSecondFalse":
        ///	( DateTime(2014, 10, 25, 15, 45, 20) same second or after DateTime(2014, 10, 25, 15, 45, 21) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterSecondFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterSecondFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterMillisecondTrue1":
        ///	( DateTime(2014, 12, 20, 12, 30, 15, 250) same millisecond or after DateTime(2014, 12, 20, 12, 30, 15, 250) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterMillisecondTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterMillisecondTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterMillisecondTrue2":
        ///	( DateTime(2014, 10, 25, 10, 25, 20, 500) same millisecond or after DateTime(2014, 10, 25, 10, 25, 20, 499) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterMillisecondTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterMillisecondTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterMillisecondFalse":
        ///	( DateTime(2014, 10, 25, 15, 45, 20, 500) same millisecond or after DateTime(2014, 10, 25, 15, 45, 20, 501) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterMillisecondFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterMillisecondFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrAfterNull1":
        ///	( DateTime(2014, 12, 20) same day or after DateTime(2014, 12) ) = null
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrAfterNull1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrAfterNull1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }

        /// <summary>
        ///define "SameOrAfterTimezoneTrue":
        ///	( @2012-03-10T10:20:00.999+07:00 same hour or after @2012-03-10T09:20:00.999+06:00 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void SameOrAfterTimezoneTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "SameOrAfterTimezoneTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "SameOrAfterTimezoneFalse":
        ///	( @2012-03-10T10:20:00.999+07:00 same hour or after @2012-03-10T10:20:00.999+06:00 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void SameOrAfterTimezoneFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "SameOrAfterTimezoneFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrAfterHourTrue1":
        ///	( @T23:25:25.555 same hour or after @T23:55:25.900 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrAfterHourTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrAfterHourTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrAfterHourTrue2":
        ///	( @T23:25:25.555 same hour or after @T22:55:25.900 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrAfterHourTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrAfterHourTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrAfterHourFalse":
        ///	( @T22:25:25.555 same hour or after @T23:55:25.900 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrAfterHourFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrAfterHourFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrAfterMinuteTrue1":
        ///	( @T23:25:25.555 same minute or after @T23:25:25.900 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrAfterMinuteTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrAfterMinuteTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrAfterMinuteTrue2":
        ///	( @T23:25:25.555 same minute or after @T22:15:25.900 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrAfterMinuteTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrAfterMinuteTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrAfterMinuteFalse":
        ///	( @T23:25:25.555 same minute or after @T23:55:25.900 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrAfterMinuteFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrAfterMinuteFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrAfterSecondTrue1":
        ///	( @T23:25:25.555 same second or after @T23:25:25.900 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrAfterSecondTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrAfterSecondTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrAfterSecondTrue2":
        ///	( @T23:25:35.555 same second or after @T22:25:25.900 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrAfterSecondTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrAfterSecondTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrAfterSecondFalse":
        ///	( @T23:55:25.555 same second or after @T23:55:35.900 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrAfterSecondFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrAfterSecondFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrAfterMillisTrue1":
        ///	( @T23:25:25.555 same millisecond or after @T23:25:25.555 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrAfterMillisTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrAfterMillisTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrAfterMillisTrue2":
        ///	( @T23:25:25.555 same millisecond or after @T22:25:25.550 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrAfterMillisTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrAfterMillisTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrAfterMillisFalse":
        ///	( @T23:55:25.555 same millisecond or after @T23:55:25.900 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrAfterMillisFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrAfterMillisFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "OnOrAfterTrue":
        ///	( @2017-12-20T11:00:00.000 on or after @2017-12-20T11:00:00.000 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void OnOrAfterTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "OnOrAfterTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "Issue32DateTime":
        ///	( @2017-12-21T02:00:00.0 same or after @2017-12-20T11:00:00.0 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void Issue32DateTime_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "Issue32DateTime"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeYearTrue1":
        ///	( DateTime(2014) same year or before DateTime(2014) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeYearTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeYearTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeYearTrue2":
        ///	( DateTime(2013) same year or before DateTime(2014) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeYearTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeYearTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeYearFalse":
        ///	( DateTime(2015) same year or before DateTime(2014) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeYearFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeYearFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeMonthTrue1":
        ///	( DateTime(2014, 12) same month or before DateTime(2014, 12) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeMonthTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeMonthTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeMonthTrue2":
        ///	( DateTime(2014, 8) same month or before DateTime(2014, 9) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeMonthTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeMonthTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeMonthFalse":
        ///	( DateTime(2014, 12) same month or before DateTime(2014, 11) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeMonthFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeMonthFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeDayTrue1":
        ///	( DateTime(2014, 12, 20) same day or before DateTime(2014, 12, 20) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeDayTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeDayTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeDayTrue2":
        ///	( DateTime(2014, 10, 15) same day or before DateTime(2014, 10, 20) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeDayTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeDayTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeDayFalse":
        ///	( DateTime(2014, 10, 30) same day or before DateTime(2014, 10, 25) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeDayFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeDayFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeHourTrue1":
        ///	( DateTime(2014, 12, 20, 12) same hour or before DateTime(2014, 12, 20, 12) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeHourTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeHourTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeHourTrue2":
        ///	( DateTime(2014, 10, 25, 5) same hour or before DateTime(2014, 10, 25, 10) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeHourTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeHourTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeHourFalse":
        ///	( DateTime(2014, 10, 25, 20) same hour or before DateTime(2014, 10, 25, 15) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeHourFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeHourFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeMinuteTrue1":
        ///	( DateTime(2014, 12, 20, 12, 30) same minute or before DateTime(2014, 12, 20, 12, 30) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeMinuteTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeMinuteTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeMinuteTrue2":
        ///	( DateTime(2014, 10, 25, 10, 20) same minute or before DateTime(2014, 10, 25, 10, 25) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeMinuteTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeMinuteTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeMinuteFalse":
        ///	( DateTime(2014, 10, 25, 15, 55) same minute or before DateTime(2014, 10, 25, 15, 45) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeMinuteFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeMinuteFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeSecondTrue1":
        ///	( DateTime(2014, 12, 20, 12, 30, 15) same second or before DateTime(2014, 12, 20, 12, 30, 15) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeSecondTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeSecondTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeSecondTrue2":
        ///	( DateTime(2014, 10, 25, 10, 25, 15) same second or before DateTime(2014, 10, 25, 10, 25, 20) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeSecondTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeSecondTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeSecondFalse":
        ///	( DateTime(2014, 10, 25, 15, 45, 25) same second or before DateTime(2014, 10, 25, 15, 45, 21) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeSecondFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeSecondFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeMillisecondTrue1":
        ///	( DateTime(2014, 12, 20, 12, 30, 15, 250) same millisecond or before DateTime(2014, 12, 20, 12, 30, 15, 250) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeMillisecondTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeMillisecondTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeMillisecondTrue2":
        ///	( DateTime(2014, 10, 25, 10, 25, 20, 450) same millisecond or before DateTime(2014, 10, 25, 10, 25, 20, 499) ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeMillisecondTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeMillisecondTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeMillisecondFalse":
        ///	( DateTime(2014, 10, 25, 15, 45, 20, 505) same millisecond or before DateTime(2014, 10, 25, 15, 45, 20, 501) ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeMillisecondFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeMillisecondFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeNull1":
        ///	( DateTime(2014, 12, 20) same minute or before DateTime(2014, 12, 20, 15) ) = null
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeNull1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeNull1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(null, result);
        }

        /// <summary>
        ///define "SameOrBeforeTimezoneTrue":
        ///	( @2012-03-10T09:20:00.999+07:00 same hour or before @2012-03-10T10:20:00.999+06:00 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void SameOrBeforeTimezoneTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "SameOrBeforeTimezoneTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "SameOrBeforeTimezoneFalse":
        ///	( @2012-03-10T10:20:00.999+06:00 same hour or before @2012-03-10T10:20:00.999+07:00 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void SameOrBeforeTimezoneFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "SameOrBeforeTimezoneFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrBeforeHourTrue1":
        ///	( @T23:25:25.555 same hour or before @T23:55:25.900 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrBeforeHourTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrBeforeHourTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrBeforeHourTrue2":
        ///	( @T21:25:25.555 same hour or before @T22:55:25.900 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrBeforeHourTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrBeforeHourTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrBeforeHourFalse":
        ///	( @T22:25:25.555 same hour or before @T21:55:25.900 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrBeforeHourFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrBeforeHourFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrBeforeMinuteTrue1":
        ///	( @T23:25:25.555 same minute or before @T23:25:25.900 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrBeforeMinuteTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrBeforeMinuteTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrBeforeMinuteFalse0":
        ///	( @T23:10:25.555 same minute or before @T22:15:25.900 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrBeforeMinuteFalse0_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrBeforeMinuteFalse0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrBeforeMinuteFalse":
        ///	( @T23:56:25.555 same minute or before @T23:55:25.900 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrBeforeMinuteFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrBeforeMinuteFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrBeforeSecondTrue1":
        ///	( @T23:25:25.555 same second or before @T23:25:25.900 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrBeforeSecondTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrBeforeSecondTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrBeforeSecondFalse0":
        ///	( @T23:25:35.555 same second or before @T22:25:45.900 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrBeforeSecondFalse0_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrBeforeSecondFalse0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrBeforeSecondFalse":
        ///	( @T23:55:45.555 same second or before @T23:55:35.900 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrBeforeSecondFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrBeforeSecondFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrBeforeMillisTrue1":
        ///	( @T23:25:25.555 same millisecond or before @T23:25:25.555 ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrBeforeMillisTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrBeforeMillisTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrBeforeMillisFalse0":
        ///	( @T23:25:25.200 same millisecond or before @T22:25:25.550 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrBeforeMillisFalse0_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrBeforeMillisFalse0"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSameOrBeforeMillisFalse":
        ///	( @T23:55:25.966 same millisecond or before @T23:55:25.900 ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSameOrBeforeMillisFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSameOrBeforeMillisFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSubtract5Years":
        ///	( DateTime(2005, 10, 10) - 5 years ) = @2000-10-10
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSubtract5Years_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSubtract5Years"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSubtract5Months":
        ///	( DateTime(2005, 6, 10) - 5 months ) = @2005-01-10
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSubtract5Months_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSubtract5Months"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSubtractMonthsUnderflow":
        ///	( DateTime(2005, 5, 10) - 6 months ) = @2004-11-10
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSubtractMonthsUnderflow_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSubtractMonthsUnderflow"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSubtract5Days":
        ///	( DateTime(2005, 5, 10) - 5 days ) = @2005-05-05
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSubtract5Days_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSubtract5Days"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSubtractDaysUnderflow":
        ///	( DateTime(2016, 6, 10) - 11 days ) = @2016-05-30
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSubtractDaysUnderflow_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSubtractDaysUnderflow"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSubtract5Hours":
        ///	( DateTime(2005, 5, 10, 10) - 5 hours ) = @2005-05-10T05
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSubtract5Hours_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSubtract5Hours"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSubtractHoursUnderflow":
        ///	( DateTime(2016, 6, 10, 5) - 6 hours ) = @2016-06-09T23
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSubtractHoursUnderflow_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSubtractHoursUnderflow"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSubtract5Minutes":
        ///	( DateTime(2005, 5, 10, 5, 10) - 5 minutes ) = @2005-05-10T05:05
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSubtract5Minutes_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSubtract5Minutes"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSubtractMinutesUnderflow":
        ///	( DateTime(2016, 6, 10, 5, 5) - 6 minutes ) = @2016-06-10T04:59
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSubtractMinutesUnderflow_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSubtractMinutesUnderflow"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSubtract5Seconds":
        ///	( DateTime(2005, 5, 10, 5, 5, 10) - 5 seconds ) = @2005-05-10T05:05:05
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSubtract5Seconds_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSubtract5Seconds"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSubtractSecondsUnderflow":
        ///	( DateTime(2016, 6, 10, 5, 5, 5) - 6 seconds ) = @2016-06-10T05:04:59
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSubtractSecondsUnderflow_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSubtractSecondsUnderflow"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSubtract5Milliseconds":
        ///	( DateTime(2005, 5, 10, 5, 5, 5, 10) - 5 milliseconds ) = @2005-05-10T05:05:05.005
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSubtract5Milliseconds_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSubtract5Milliseconds"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSubtractMillisecondsUnderflow":
        ///	( DateTime(2016, 6, 10, 5, 5, 5, 5) - 6 milliseconds ) = @2016-06-10T05:05:04.999
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSubtractMillisecondsUnderflow_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSubtractMillisecondsUnderflow"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSubtract2YearsAsMonths":
        ///	( DateTime(2014) - 24 months ) = @2012
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSubtract2YearsAsMonths_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSubtract2YearsAsMonths"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSubtract2YearsAsMonthsRem1":
        ///	( DateTime(2014) - 25 months ) = @2011
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSubtract2YearsAsMonthsRem1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSubtract2YearsAsMonthsRem1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSubtract5Hours":
        ///	( @T15:59:59.999 - 5 hours ) = @T10:59:59.999
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSubtract5Hours_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSubtract5Hours"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSubtract1Minute":
        ///	( @T15:59:59.999 - 1 minutes ) = @T15:58:59.999
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSubtract1Minute_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSubtract1Minute"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSubtract1Second":
        ///	( @T15:59:59.999 - 1 seconds ) = @T15:59:58.999
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSubtract1Second_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSubtract1Second"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSubtract1Millisecond":
        ///	( @T15:59:59.0 - 1 milliseconds ) = @T15:59:58.999
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSubtract1Millisecond_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSubtract1Millisecond"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSubtract5Hours1Minute":
        ///	( @T15:59:59.999 - 5 hours - 1 minutes ) = @T10:58:59.999
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSubtract5Hours1Minute_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSubtract5Hours1Minute"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeSubtract5hoursByMinute":
        ///	( @T15:59:59.999 - 300 minutes ) = @T10:59:59.999
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeSubtract5hoursByMinute_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeSubtract5hoursByMinute"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeTest2":
        ///	( @T23:59:59.999 ) = @T23:59:59.999
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeTest2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeTest2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "TimeOfDayTest":
        ///	( TimeOfDay() ) = TimeOfDay()
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void TimeOfDayTest_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "TimeOfDayTest"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeTodayTrue1":
        ///	( Today() same day or before Today() ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeTodayTrue1_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeTodayTrue1"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeTodayTrue2":
        ///	( Today() same day or before Today() + 1 days ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeTodayTrue2_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeTodayTrue2"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeSameOrBeforeTodayFalse":
        ///	( Today() + 1 years same day or before Today() ) = false
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeSameOrBeforeTodayFalse_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeSameOrBeforeTodayFalse"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "DateTimeAddTodayTrue":
        ///	( Today() + 1 days > Today() ) = true
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void DateTimeAddTodayTrue_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "DateTimeAddTodayTrue"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        ///define "Issue34B":
        ///	( Today() ) = Today()
        /// </summary>
        [TestCategory("CqlDateTimeOperatorsTest")]
        [TestMethod]
        public void Issue34B_Test()
        {
            var lambda = LambdasByTestName["CqlDateTimeOperatorsTest", "Issue34B"];
            var function = (Func<CqlContext, bool?>)lambda.Compile();
            bool? result = function(Context);
            Assert.AreEqual(true, result);
        }

    }
}

