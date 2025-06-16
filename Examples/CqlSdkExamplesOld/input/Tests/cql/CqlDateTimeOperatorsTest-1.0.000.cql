library CqlDateTimeOperatorsTest version '1.0.000'

define "Add.DateTimeAdd5Years": DateTime(2005, 10, 10) + 5 years

define "Add.DateTimeAddInvalidYears": DateTime(2005, 10, 10) + 8000 years

define "Add.DateTimeAdd5Months": DateTime(2005, 5, 10) + 5 months

define "Add.DateTimeAddMonthsOverflow": DateTime(2005, 5, 10) + 10 months

define "Add.DateTimeAdd5Days": DateTime(2005, 5, 10) + 5 days

define "Add.DateTimeAddDaysOverflow": DateTime(2016, 6, 10) + 21 days

define "Add.DateTimeAdd5Hours": DateTime(2005, 5, 10, 5) + 5 hours

define "Add.DateTimeAddHoursOverflow": DateTime(2016, 6, 10, 5) + 19 hours

define "Add.DateTimeAdd5Minutes": DateTime(2005, 5, 10, 5, 5) + 5 minutes

define "Add.DateTimeAddMinutesOverflow": DateTime(2016, 6, 10, 5, 5) + 55 minutes

define "Add.DateTimeAdd5Seconds": DateTime(2005, 5, 10, 5, 5, 5) + 5 seconds

define "Add.DateTimeAddSecondsOverflow": DateTime(2016, 6, 10, 5, 5, 5) + 55 seconds

define "Add.DateTimeAdd5Milliseconds": DateTime(2005, 5, 10, 5, 5, 5, 5) + 5 milliseconds

define "Add.DateTimeAddMillisecondsOverflow": DateTime(2016, 6, 10, 5, 5, 5, 5) + 995 milliseconds

define "Add.DateTimeAddLeapYear": DateTime(2012, 2, 29) + 1 year

define "Add.DateTimeAdd2YearsByMonths": DateTime(2014) + 24 months

define "Add.DateTimeAdd2YearsByDays": DateTime(2014) + 730 days

define "Add.DateTimeAdd2YearsByDaysRem5Days": DateTime(2014) + 735 days

define "Add.TimeAdd5Hours": @T15:59:59.999 + 5 hours

define "Add.TimeAdd1Minute": @T15:59:59.999 + 1 minute

define "Add.TimeAdd1Second": @T15:59:59.999 + 1 seconds

define "Add.TimeAdd1Millisecond": @T15:59:59.999 + 1 milliseconds

define "Add.TimeAdd5Hours1Minute": @T15:59:59.999 + 5 hours + 1 minutes

define "Add.TimeAdd5hoursByMinute": @T15:59:59.999 + 300 minutes

define "After.DateTimeAfterYearTrue": DateTime(2005, 10, 10) after year of DateTime(2004, 10, 10)

define "After.DateTimeAfterYearFalse": DateTime(2004, 11, 10) after year of DateTime(2004, 10, 10)

define "After.DateTimeAfterMonthTrue": DateTime(2004, 12, 10) after month of DateTime(2004, 11, 10)

define "After.DateTimeAfterMonthFalse": DateTime(2004, 9, 10) after month of DateTime(2004, 10, 10)

define "After.DateTimeAfterDayTrue": DateTime(2004, 12, 11) after day of DateTime(2004, 10, 10)

define "After.DateTimeAfterDayTrue2": DateTime(2004, 12, 09) after day of DateTime(2003, 10, 10)

define "After.DateTimeAfterDayFalse": DateTime(2004, 10, 9) after day of DateTime(2004, 10, 10)

define "After.DateTimeAfterHourTrue": DateTime(2004, 10, 10, 10) after hour of DateTime(2004, 10, 10, 5)

define "After.DateTimeAfterHourFalse": DateTime(2004, 10, 10, 20) after hour of DateTime(2004, 10, 10, 21)

define "After.DateTimeAfterMinuteTrue": DateTime(2004, 10, 10, 20, 30) after minute of DateTime(2004, 10, 10, 20, 29)

define "After.DateTimeAfterMinuteFalse": DateTime(2004, 10, 10, 20, 30) after minute of DateTime(2004, 10, 10, 20, 31)

define "After.DateTimeAfterSecondTrue": DateTime(2004, 10, 10, 20, 30, 15) after second of DateTime(2004, 10, 10, 20, 30, 14)

define "After.DateTimeAfterSecondFalse": DateTime(2004, 10, 10, 20, 30, 15) after second of DateTime(2004, 10, 10, 20, 30, 16)

define "After.DateTimeAfterMillisecondTrue": DateTime(2004, 10, 10, 20, 30, 15, 512) after millisecond of DateTime(2004, 10, 10, 20, 30, 15, 510)

define "After.DateTimeAfterMillisecondFalse": DateTime(2004, 10, 10, 20, 30, 15, 512) after millisecond of DateTime(2004, 10, 10, 20, 30, 15, 513)

define "After.DateTimeAfterUncertain": DateTime(2005, 10, 10) after day of DateTime(2005, 9)

define "After.AfterTimezoneTrue": @2012-03-10T10:20:00.999+07:00 after hour of @2012-03-10T08:20:00.999+06:00

define "After.AfterTimezoneFalse": @2012-03-10T10:20:00.999+07:00 after hour of @2012-03-10T10:20:00.999+06:00

define "After.TimeAfterHourTrue": @T15:59:59.999 after hour of @T14:59:59.999

define "After.TimeAfterHourFalse": @T15:59:59.999 after hour of @T16:59:59.999

define "After.TimeAfterMinuteTrue": @T15:59:59.999 after minute of @T15:58:59.999

define "After.TimeAfterMinuteFalse": @T15:58:59.999 after minute of @T15:59:59.999

define "After.TimeAfterSecondTrue": @T15:59:59.999 after second of @T15:59:58.999

define "After.TimeAfterSecondFalse": @T15:59:58.999 after second of @T15:59:59.999

define "After.TimeAfterMillisecondTrue": @T15:59:59.999 after millisecond of @T15:59:59.998

define "After.TimeAfterMillisecondFalse": @T15:59:59.998 after millisecond of @T15:59:59.999

define "After.TimeAfterTimeCstor": Time(12, 30) after hour of Time(11, 55)

define "Before.DateTimeBeforeYearTrue": DateTime(2003) before year of DateTime(2004, 10, 10)

define "Before.DateTimeBeforeYearFalse": DateTime(2004, 11, 10) before year of DateTime(2003, 10, 10)

define "Before.DateTimeBeforeMonthTrue": DateTime(2004, 10, 10) before month of DateTime(2004, 11, 10)

define "Before.DateTimeBeforeMonthFalse": DateTime(2004, 11, 10) before month of DateTime(2004, 10, 10)

define "Before.DateTimeBeforeDayTrue": DateTime(2004, 10, 1) before day of DateTime(2004, 10, 10)

define "Before.DateTimeBeforeDayTrue2": DateTime(2003, 10, 11) before day of DateTime(2004, 10, 10)

define "Before.DateTimeBeforeDayFalse": DateTime(2004, 10, 11) before day of DateTime(2004, 10, 10)

define "Before.DateTimeBeforeHourTrue": DateTime(2004, 10, 10, 1) before hour of DateTime(2004, 10, 10, 5)

define "Before.DateTimeBeforeHourFalse": DateTime(2004, 10, 10, 23) before hour of DateTime(2004, 10, 10, 21)

define "Before.DateTimeBeforeMinuteTrue": DateTime(2004, 10, 10, 20, 28) before minute of DateTime(2004, 10, 10, 20, 29)

define "Before.DateTimeBeforeMinuteFalse": DateTime(2004, 10, 10, 20, 35) before minute of DateTime(2004, 10, 10, 20, 31)

define "Before.DateTimeBeforeSecondTrue": DateTime(2004, 10, 10, 20, 30, 12) before second of DateTime(2004, 10, 10, 20, 30, 14)

define "Before.DateTimeBeforeSecondFalse": DateTime(2004, 10, 10, 20, 30, 55) before second of DateTime(2004, 10, 10, 20, 30, 16)

define "Before.DateTimeBeforeMillisecondTrue": DateTime(2004, 10, 10, 20, 30, 15, 508) before millisecond of DateTime(2004, 10, 10, 20, 30, 15, 510)

define "Before.DateTimeBeforeMillisecondFalse": DateTime(2004, 10, 10, 20, 30, 15, 599) before millisecond of DateTime(2004, 10, 10, 20, 30, 15, 513)

define "Before.BeforeTimezoneTrue": @2012-03-10T10:20:00.999+07:00 before hour of @2012-03-10T10:20:00.999+06:00

define "Before.BeforeTimezoneFalse": @2012-03-10T10:20:00.999+07:00 before hour of @2012-03-10T09:20:00.999+06:00

define "Before.TimeBeforeHourTrue": @T13:59:59.999 before hour of @T14:59:59.999

define "Before.TimeBeforeHourFalse": @T16:59:59.999 before hour of @T15:59:59.999

define "Before.TimeBeforeMinuteTrue": @T15:57:59.999 before minute of @T15:58:59.999

define "Before.TimeBeforeMinuteFalse": @T15:59:59.999 before minute of @T15:59:59.999

define "Before.TimeBeforeSecondTrue": @T15:59:57.999 before second of @T15:59:58.999

define "Before.TimeBeforeSecondFalse": @T15:59:56.999 before second of @T15:59:55.999

define "Before.TimeBeforeMillisecondTrue": @T15:59:59.997 before millisecond of @T15:59:59.998

define "Before.TimeBeforeMillisecondFalse": @T15:59:59.998 before millisecond of @T15:59:59.997

define "DateTime.DateTimeYear": DateTime(2003)

define "DateTime.DateTimeMonth": DateTime(2003, 10)

define "DateTime.DateTimeDay": DateTime(2003, 10, 29)

define "DateTime.DateTimeHour": DateTime(2003, 10, 29, 20)

define "DateTime.DateTimeMinute": DateTime(2003, 10, 29, 20, 50)

define "DateTime.DateTimeSecond": DateTime(2003, 10, 29, 20, 50, 33)

define "DateTime.DateTimeMillisecond": DateTime(2003, 10, 29, 20, 50, 33, 955)

define "DateTimeComponentFrom.DateTimeComponentFromYear": year from DateTime(2003, 10, 29, 20, 50, 33, 955)

define "DateTimeComponentFrom.DateTimeComponentFromMonth": month from DateTime(2003, 10, 29, 20, 50, 33, 955)

define "DateTimeComponentFrom.DateTimeComponentFromMonthMinBoundary": month from DateTime(2003, 01, 29, 20, 50, 33, 955)

define "DateTimeComponentFrom.DateTimeComponentFromDay": day from DateTime(2003, 10, 29, 20, 50, 33, 955)

define "DateTimeComponentFrom.DateTimeComponentFromHour": hour from DateTime(2003, 10, 29, 20, 50, 33, 955)

define "DateTimeComponentFrom.DateTimeComponentFromMinute": minute from DateTime(2003, 10, 29, 20, 50, 33, 955)

define "DateTimeComponentFrom.DateTimeComponentFromSecond": second from DateTime(2003, 10, 29, 20, 50, 33, 955)

define "DateTimeComponentFrom.DateTimeComponentFromMillisecond": millisecond from DateTime(2003, 10, 29, 20, 50, 33, 955)

define "DateTimeComponentFrom.DateTimeComponentFromTimezone": timezone from DateTime(2003, 10, 29, 20, 50, 33, 955, 1)

define "DateTimeComponentFrom.DateTimeComponentFromDate": date from DateTime(2003, 10, 29, 20, 50, 33, 955, 1)

define "DateTimeComponentFrom.TimeComponentFromHour": hour from @T23:20:15.555

define "DateTimeComponentFrom.TimeComponentFromMinute": minute from @T23:20:15.555

define "DateTimeComponentFrom.TimeComponentFromSecond": second from @T23:20:15.555

define "DateTimeComponentFrom.TimeComponentFromMilli": millisecond from @T23:20:15.555

define "Difference.DateTimeDifferenceYear": difference in years between DateTime(2000) and DateTime(2005, 12)

define "Difference.DateTimeDifferenceMonth": difference in months between DateTime(2000, 2) and DateTime(2000, 10)

define "Difference.DateTimeDifferenceDay": difference in days between DateTime(2000, 10, 15, 10, 30) and DateTime(2000, 10, 25, 10, 0)

define "Difference.DateTimeDifferenceHour": difference in hours between DateTime(2000, 4, 1, 12) and DateTime(2000, 4, 1, 20)

define "Difference.DateTimeDifferenceMinute": difference in minutes between DateTime(2005, 12, 10, 5, 16) and DateTime(2005, 12, 10, 5, 25)

define "Difference.DateTimeDifferenceSecond": difference in seconds between DateTime(2000, 10, 10, 10, 5, 45) and DateTime(2000, 10, 10, 10, 5, 50)

define "Difference.DateTimeDifferenceMillisecond": difference in milliseconds between DateTime(2000, 10, 10, 10, 5, 45, 500, -6.0) and DateTime(2000, 10, 10, 10, 5, 45, 900, -7.0)

define "Difference.DateTimeDifferenceWeeks": difference in weeks between DateTime(2000, 10, 15) and DateTime(2000, 10, 28)

define "Difference.DateTimeDifferenceWeeks2": difference in weeks between DateTime(2000, 10, 15) and DateTime(2000, 10, 29)

define "Difference.DateTimeDifferenceWeeks3": difference in weeks between @2012-03-10T22:05:09 and @2012-03-24T07:19:33

define "Difference.DateTimeDifferenceNegative": difference in years between DateTime(2016) and DateTime(1998)

define "Difference.DateTimeDifferenceUncertain": difference in months between DateTime(2005) and DateTime(2006, 7) > 5

define "Difference.TimeDifferenceHour": difference in hours between @T20 and @T23:25:15.555

define "Difference.TimeDifferenceMinute": difference in minutes between @T20:20:15.555 and @T20:25:15.555

define "Difference.TimeDifferenceSecond": difference in seconds between @T20:20:15.555 and @T20:20:20.555

define "Difference.TimeDifferenceMillis": difference in milliseconds between @T20:20:15.555 and @T20:20:15.550

define "From Github issue #29.DateTimeA": @2017-03-12T01:00:00-07:00

define "From Github issue #29.DateTimeAA": DateTime(2017, 3, 12, 1, 0, 0, 0, -7.0)

define "From Github issue #29.DateTimeB": @2017-03-12T03:00:00-06:00

define "From Github issue #29.DateTimeBB": DateTime(2017, 3, 12, 3, 0, 0, 0, -6.0)

define "From Github issue #29.DateTimeC": @2017-11-05T01:30:00-06:00

define "From Github issue #29.DateTimeCC": DateTime(2017, 11, 5, 1, 30, 0, 0, -6.0)

define "From Github issue #29.DateTimeD": @2017-11-05T01:15:00-07:00

define "From Github issue #29.DateTimeDD": DateTime(2017, 11, 5, 1, 15, 0, 0, -7.0)

define "From Github issue #29.DateTimeE": @2017-03-12T00:00:00-07:00

define "From Github issue #29.DateTimeEE": DateTime(2017, 3, 12, 0, 0, 0, 0, -7.0)

define "From Github issue #29.DateTimeF": @2017-03-13T00:00:00-06:00

define "From Github issue #29.DateTimeFF": DateTime(2017, 3, 13, 0, 0, 0, 0, -6.0)

define "From Github issue #29.DifferenceInHoursA": difference in hours between @2017-03-12T01:00:00-07:00 and @2017-03-12T03:00:00-06:00

define "From Github issue #29.DifferenceInMinutesA": difference in minutes between @2017-11-05T01:30:00-06:00 and @2017-11-05T01:15:00-07:00

define "From Github issue #29.DifferenceInDaysA": difference in days between @2017-03-12T00:00:00-07:00 and @2017-03-13T00:00:00-06:00

define "From Github issue #29.DifferenceInHoursAA": difference in hours between DateTime(2017, 3, 12, 1, 0, 0, 0, -7.0) and DateTime(2017, 3, 12, 3, 0, 0, 0, -6.0)

define "From Github issue #29.DifferenceInMinutesAA": difference in minutes between DateTime(2017, 11, 5, 1, 30, 0, 0, -6.0) and DateTime(2017, 11, 5, 1, 15, 0, 0, -7.0)

define "From Github issue #29.DifferenceInDaysAA": difference in days between DateTime(2017, 3, 12, 0, 0, 0, 0, -7.0) and DateTime(2017, 3, 13, 0, 0, 0, 0, -6.0)

define "Duration.DateTimeDurationBetweenYear": years between DateTime(2005) and DateTime(2010)

define "Duration.DateTimeDurationBetweenYearOffset": years between DateTime(2005, 5) and DateTime(2010, 4)

define "Duration.DateTimeDurationBetweenMonth": months between @2014-01-31 and @2014-02-01

define "Duration.DateTimeDurationBetweenDaysDiffYears": days between DateTime(2010, 10, 12, 12, 5) and DateTime(2008, 8, 15, 8, 8)

define "Uncertainty tests.DateTimeDurationBetweenUncertainInterval": days between DateTime(2014, 1, 15) and DateTime(2014, 2)

define "Uncertainty tests.DateTimeDurationBetweenUncertainInterval2": months between DateTime(2005) and DateTime(2006, 5)

define "Uncertainty tests.DateTimeDurationBetweenUncertainAdd": (days between DateTime(2014, 1, 15) and DateTime(2014, 2))
				+ (days between DateTime(2014, 1, 15) and DateTime(2014, 2))

define "Uncertainty tests.DateTimeDurationBetweenUncertainSubtract": (days between DateTime(2014, 1, 15) and DateTime(2014, 2))
				- (months between DateTime(2005) and DateTime(2006, 5))

define "Uncertainty tests.DateTimeDurationBetweenUncertainMultiply": (days between DateTime(2014, 1, 15) and DateTime(2014, 2))
				* (days between DateTime(2014, 1, 15) and DateTime(2014, 2))

define "Uncertainty tests.DateTimeDurationBetweenUncertainDiv": (days between DateTime(2014, 1, 15) and DateTime(2014, 2))
				div (months between DateTime(2005) and DateTime(2006, 5))

define "Uncertainty tests.DateTimeDurationBetweenMonthUncertain": months between DateTime(2005) and DateTime(2006, 7) > 5

define "Uncertainty tests.DateTimeDurationBetweenMonthUncertain2": months between DateTime(2005) and DateTime(2006, 2) > 5

define "Uncertainty tests.DateTimeDurationBetweenMonthUncertain3": months between DateTime(2005) and DateTime(2006, 7) > 25

define "Uncertainty tests.DateTimeDurationBetweenMonthUncertain4": months between DateTime(2005) and DateTime(2006, 7) < 24

define "Uncertainty tests.DateTimeDurationBetweenMonthUncertain5": months between DateTime(2005) and DateTime(2006, 7) = 24

define "Uncertainty tests.DateTimeDurationBetweenMonthUncertain6": months between DateTime(2005) and DateTime(2006, 7) >= 5

define "Uncertainty tests.DateTimeDurationBetweenMonthUncertain7": months between DateTime(2005) and DateTime(2006, 7) <= 24

define "Uncertainty tests.DateTime1": @2012-03-10T10:20:00

define "Uncertainty tests.DateTime2": @2013-03-10T09:20:00

define "Uncertainty tests.DurationInYears": years between (date from @2012-03-10T10:20:00) and (date from @2013-03-10T09:20:00)

define "Uncertainty tests.DurationInWeeks": weeks between @2012-03-10T22:05:09 and @2012-03-20T07:19:33

define "Uncertainty tests.DurationInWeeks2": weeks between @2012-03-10T22:05:09 and @2012-03-24T07:19:33

define "Uncertainty tests.DurationInWeeks3": weeks between @2012-03-10T06:05:09 and @2012-03-24T07:19:33

define "Uncertainty tests.TimeDurationBetweenHour": hours between @T20:26:15.555 and @T23:25:15.555

define "Uncertainty tests.TimeDurationBetweenHourDiffPrecision": hours between @T06Z and @T07:00:00Z

define "Uncertainty tests.TimeDurationBetweenMinute": minutes between @T23:20:16.555 and @T23:25:15.555

define "Uncertainty tests.TimeDurationBetweenSecond": seconds between @T23:25:10.556 and @T23:25:15.555

define "Uncertainty tests.TimeDurationBetweenMillis": milliseconds between @T23:25:25.555 and @T23:25:25.560

define "Uncertainty tests.DurationInHoursA": hours between @2017-03-12T01:00:00-07:00 and @2017-03-12T03:00:00-06:00

define "Uncertainty tests.DurationInMinutesA": minutes between @2017-11-05T01:30:00-06:00 and @2017-11-05T01:15:00-07:00

define "Uncertainty tests.DurationInDaysA": days between @2017-03-12T00:00:00-07:00 and @2017-03-13T00:00:00-06:00

define "Uncertainty tests.DurationInHoursAA": hours between DateTime(2017, 3, 12, 1, 0, 0, 0, -7.0) and DateTime(2017, 3, 12, 3, 0, 0, 0, -6.0)

define "Uncertainty tests.DurationInMinutesAA": minutes between DateTime(2017, 11, 5, 1, 30, 0, 0, -6.0) and DateTime(2017, 11, 5, 1, 15, 0, 0, -7.0)

define "Uncertainty tests.DurationInDaysAA": days between DateTime(2017, 3, 12, 0, 0, 0, 0, -7.0) and DateTime(2017, 3, 13, 0, 0, 0, 0, -6.0)

define "Now.DateTimeNow": Now() = Now()

define "SameAs.DateTimeSameAsYearTrue": DateTime(2014) same year as DateTime(2014)

define "SameAs.DateTimeSameAsYearFalse": DateTime(2013) same year as DateTime(2014)

define "SameAs.DateTimeSameAsMonthTrue": DateTime(2014, 12) same month as DateTime(2014, 12)

define "SameAs.DateTimeSameAsMonthFalse": DateTime(2014, 12) same month as DateTime(2014, 10)

define "SameAs.DateTimeSameAsDayTrue": DateTime(2014, 12, 10) same day as DateTime(2014, 12, 10)

define "SameAs.DateTimeSameAsDayFalse": DateTime(2014, 10, 10) same day as DateTime(2014, 10, 11)

define "SameAs.DateTimeSameAsHourTrue": DateTime(2014, 12, 10, 20) same hour as DateTime(2014, 12, 10, 20)

define "SameAs.DateTimeSameAsHourFalse": DateTime(2014, 10, 10, 20) same hour as DateTime(2014, 10, 10, 21)

define "SameAs.DateTimeSameAsMinuteTrue": DateTime(2014, 12, 10, 20, 55) same minute as DateTime(2014, 12, 10, 20, 55)

define "SameAs.DateTimeSameAsMinuteFalse": DateTime(2014, 10, 10, 20, 55) same minute as DateTime(2014, 10, 10, 21, 56)

define "SameAs.DateTimeSameAsSecondTrue": DateTime(2014, 12, 10, 20, 55, 45) same second as DateTime(2014, 12, 10, 20, 55, 45)

define "SameAs.DateTimeSameAsSecondFalse": DateTime(2014, 10, 10, 20, 55, 45) same second as DateTime(2014, 10, 10, 21, 55, 44)

define "SameAs.DateTimeSameAsMillisecondTrue": DateTime(2014, 12, 10, 20, 55, 45, 500) same millisecond as DateTime(2014, 12, 10, 20, 55, 45, 500)

define "SameAs.DateTimeSameAsMillisecondFalse": DateTime(2014, 10, 10, 20, 55, 45, 500) same millisecond as DateTime(2014, 10, 10, 21, 55, 45, 501)

define "SameAs.DateTimeSameAsNull": DateTime(2014, 10) same day as DateTime(2014, 10, 12)

define "SameAs.SameAsTimezoneTrue": @2012-03-10T10:20:00.999+07:00 same hour as @2012-03-10T09:20:00.999+06:00

define "SameAs.SameAsTimezoneFalse": @2012-03-10T10:20:00.999+07:00 same hour as @2012-03-10T10:20:00.999+06:00

define "SameAs.TimeSameAsHourTrue": @T23:25:25.555 same hour as @T23:55:25.900

define "SameAs.TimeSameAsHourFalse": @T22:25:25.555 same hour as @T23:25:25.555

define "SameAs.TimeSameAsMinuteTrue": @T23:55:22.555 same minute as @T23:55:25.900

define "SameAs.TimeSameAsMinuteFalse": @T23:26:25.555 same minute as @T23:25:25.555

define "SameAs.TimeSameAsSecondTrue": @T23:55:25.555 same second as @T23:55:25.900

define "SameAs.TimeSameAsSecondFalse": @T23:25:35.555 same second as @T23:25:25.555

define "SameAs.TimeSameAsMillisTrue": @T23:55:25.555 same millisecond as @T23:55:25.555

define "SameAs.TimeSameAsMillisFalse": @T23:25:25.555 same millisecond as @T23:25:25.554

define "SameOrAfter.DateTimeSameOrAfterYearTrue1": DateTime(2014) same year or after DateTime(2014)

define "SameOrAfter.DateTimeSameOrAfterYearTrue2": DateTime(2016) same year or after DateTime(2014)

define "SameOrAfter.DateTimeSameOrAfterYearFalse": DateTime(2013) same year or after DateTime(2014)

define "SameOrAfter.DateTimeSameOrAfterMonthTrue1": DateTime(2014, 12) same month or after DateTime(2014, 12)

define "SameOrAfter.DateTimeSameOrAfterMonthTrue2": DateTime(2014, 10) same month or after DateTime(2014, 9)

define "SameOrAfter.DateTimeSameOrAfterMonthFalse": DateTime(2014, 10) same month or after DateTime(2014, 11)

define "SameOrAfter.DateTimeSameOrAfterDayTrue1": DateTime(2014, 12, 20) same day or after DateTime(2014, 12, 20)

define "SameOrAfter.DateTimeSameOrAfterDayTrue2": DateTime(2014, 10, 25) same day or after DateTime(2014, 10, 20)

define "SameOrAfter.DateTimeSameOrAfterDayFalse": DateTime(2014, 10, 20) same day or after DateTime(2014, 10, 25)

define "SameOrAfter.DateTimeSameOrAfterHourTrue1": DateTime(2014, 12, 20, 12) same hour or after DateTime(2014, 12, 20, 12)

define "SameOrAfter.DateTimeSameOrAfterHourTrue2": DateTime(2014, 10, 25, 12) same hour or after DateTime(2014, 10, 25, 10)

define "SameOrAfter.DateTimeSameOrAfterHourFalse": DateTime(2014, 10, 25, 12) same hour or after DateTime(2014, 10, 25, 15)

define "SameOrAfter.DateTimeSameOrAfterMinuteTrue1": DateTime(2014, 12, 20, 12, 30) same minute or after DateTime(2014, 12, 20, 12, 30)

define "SameOrAfter.DateTimeSameOrAfterMinuteTrue2": DateTime(2014, 10, 25, 10, 30) same minute or after DateTime(2014, 10, 25, 10, 25)

define "SameOrAfter.DateTimeSameOrAfterMinuteFalse": DateTime(2014, 10, 25, 15, 30) same minute or after DateTime(2014, 10, 25, 15, 45)

define "SameOrAfter.DateTimeSameOrAfterSecondTrue1": DateTime(2014, 12, 20, 12, 30, 15) same second or after DateTime(2014, 12, 20, 12, 30, 15)

define "SameOrAfter.DateTimeSameOrAfterSecondTrue2": DateTime(2014, 10, 25, 10, 25, 25) same second or after DateTime(2014, 10, 25, 10, 25, 20)

define "SameOrAfter.DateTimeSameOrAfterSecondFalse": DateTime(2014, 10, 25, 15, 45, 20) same second or after DateTime(2014, 10, 25, 15, 45, 21)

define "SameOrAfter.DateTimeSameOrAfterMillisecondTrue1": DateTime(2014, 12, 20, 12, 30, 15, 250) same millisecond or after DateTime(2014, 12, 20, 12, 30, 15, 250)

define "SameOrAfter.DateTimeSameOrAfterMillisecondTrue2": DateTime(2014, 10, 25, 10, 25, 20, 500) same millisecond or after DateTime(2014, 10, 25, 10, 25, 20, 499)

define "SameOrAfter.DateTimeSameOrAfterMillisecondFalse": DateTime(2014, 10, 25, 15, 45, 20, 500) same millisecond or after DateTime(2014, 10, 25, 15, 45, 20, 501)

define "SameOrAfter.DateTimeSameOrAfterNull1": DateTime(2014, 12, 20) same day or after DateTime(2014, 12)

define "SameOrAfter.SameOrAfterTimezoneTrue": @2012-03-10T10:20:00.999+07:00 same hour or after @2012-03-10T09:20:00.999+06:00

define "SameOrAfter.SameOrAfterTimezoneFalse": @2012-03-10T10:20:00.999+07:00 same hour or after @2012-03-10T10:20:00.999+06:00

define "SameOrAfter.TimeSameOrAfterHourTrue1": @T23:25:25.555 same hour or after @T23:55:25.900

define "SameOrAfter.TimeSameOrAfterHourTrue2": @T23:25:25.555 same hour or after @T22:55:25.900

define "SameOrAfter.TimeSameOrAfterHourFalse": @T22:25:25.555 same hour or after @T23:55:25.900

define "SameOrAfter.TimeSameOrAfterMinuteTrue1": @T23:25:25.555 same minute or after @T23:25:25.900

define "SameOrAfter.TimeSameOrAfterMinuteTrue2": @T23:25:25.555 same minute or after @T22:15:25.900

define "SameOrAfter.TimeSameOrAfterMinuteFalse": @T23:25:25.555 same minute or after @T23:55:25.900

define "SameOrAfter.TimeSameOrAfterSecondTrue1": @T23:25:25.555 same second or after @T23:25:25.900

define "SameOrAfter.TimeSameOrAfterSecondTrue2": @T23:25:35.555 same second or after @T22:25:25.900

define "SameOrAfter.TimeSameOrAfterSecondFalse": @T23:55:25.555 same second or after @T23:55:35.900

define "SameOrAfter.TimeSameOrAfterMillisTrue1": @T23:25:25.555 same millisecond or after @T23:25:25.555

define "SameOrAfter.TimeSameOrAfterMillisTrue2": @T23:25:25.555 same millisecond or after @T22:25:25.550

define "SameOrAfter.TimeSameOrAfterMillisFalse": @T23:55:25.555 same millisecond or after @T23:55:25.900

define "SameOrAfter.OnOrAfterTrue": @2017-12-20T11:00:00.000 on or after @2017-12-20T11:00:00.000

define "SameOrAfter.Issue32DateTime": @2017-12-21T02:00:00.0 same or after @2017-12-20T11:00:00.0

define "SameOrBefore.DateTimeSameOrBeforeYearTrue1": DateTime(2014) same year or before DateTime(2014)

define "SameOrBefore.DateTimeSameOrBeforeYearTrue2": DateTime(2013) same year or before DateTime(2014)

define "SameOrBefore.DateTimeSameOrBeforeYearFalse": DateTime(2015) same year or before DateTime(2014)

define "SameOrBefore.DateTimeSameOrBeforeMonthTrue1": DateTime(2014, 12) same month or before DateTime(2014, 12)

define "SameOrBefore.DateTimeSameOrBeforeMonthTrue2": DateTime(2014, 8) same month or before DateTime(2014, 9)

define "SameOrBefore.DateTimeSameOrBeforeMonthFalse": DateTime(2014, 12) same month or before DateTime(2014, 11)

define "SameOrBefore.DateTimeSameOrBeforeDayTrue1": DateTime(2014, 12, 20) same day or before DateTime(2014, 12, 20)

define "SameOrBefore.DateTimeSameOrBeforeDayTrue2": DateTime(2014, 10, 15) same day or before DateTime(2014, 10, 20)

define "SameOrBefore.DateTimeSameOrBeforeDayFalse": DateTime(2014, 10, 30) same day or before DateTime(2014, 10, 25)

define "SameOrBefore.DateTimeSameOrBeforeHourTrue1": DateTime(2014, 12, 20, 12) same hour or before DateTime(2014, 12, 20, 12)

define "SameOrBefore.DateTimeSameOrBeforeHourTrue2": DateTime(2014, 10, 25, 5) same hour or before DateTime(2014, 10, 25, 10)

define "SameOrBefore.DateTimeSameOrBeforeHourFalse": DateTime(2014, 10, 25, 20) same hour or before DateTime(2014, 10, 25, 15)

define "SameOrBefore.DateTimeSameOrBeforeMinuteTrue1": DateTime(2014, 12, 20, 12, 30) same minute or before DateTime(2014, 12, 20, 12, 30)

define "SameOrBefore.DateTimeSameOrBeforeMinuteTrue2": DateTime(2014, 10, 25, 10, 20) same minute or before DateTime(2014, 10, 25, 10, 25)

define "SameOrBefore.DateTimeSameOrBeforeMinuteFalse": DateTime(2014, 10, 25, 15, 55) same minute or before DateTime(2014, 10, 25, 15, 45)

define "SameOrBefore.DateTimeSameOrBeforeSecondTrue1": DateTime(2014, 12, 20, 12, 30, 15) same second or before DateTime(2014, 12, 20, 12, 30, 15)

define "SameOrBefore.DateTimeSameOrBeforeSecondTrue2": DateTime(2014, 10, 25, 10, 25, 15) same second or before DateTime(2014, 10, 25, 10, 25, 20)

define "SameOrBefore.DateTimeSameOrBeforeSecondFalse": DateTime(2014, 10, 25, 15, 45, 25) same second or before DateTime(2014, 10, 25, 15, 45, 21)

define "SameOrBefore.DateTimeSameOrBeforeMillisecondTrue1": DateTime(2014, 12, 20, 12, 30, 15, 250) same millisecond or before DateTime(2014, 12, 20, 12, 30, 15, 250)

define "SameOrBefore.DateTimeSameOrBeforeMillisecondTrue2": DateTime(2014, 10, 25, 10, 25, 20, 450) same millisecond or before DateTime(2014, 10, 25, 10, 25, 20, 499)

define "SameOrBefore.DateTimeSameOrBeforeMillisecondFalse": DateTime(2014, 10, 25, 15, 45, 20, 505) same millisecond or before DateTime(2014, 10, 25, 15, 45, 20, 501)

define "SameOrBefore.DateTimeSameOrBeforeNull1": DateTime(2014, 12, 20) same minute or before DateTime(2014, 12, 20, 15)

define "SameOrBefore.SameOrBeforeTimezoneTrue": @2012-03-10T09:20:00.999+07:00 same hour or before @2012-03-10T10:20:00.999+06:00

define "SameOrBefore.SameOrBeforeTimezoneFalse": @2012-03-10T10:20:00.999+06:00 same hour or before @2012-03-10T10:20:00.999+07:00

define "SameOrBefore.TimeSameOrBeforeHourTrue1": @T23:25:25.555 same hour or before @T23:55:25.900

define "SameOrBefore.TimeSameOrBeforeHourTrue2": @T21:25:25.555 same hour or before @T22:55:25.900

define "SameOrBefore.TimeSameOrBeforeHourFalse": @T22:25:25.555 same hour or before @T21:55:25.900

define "SameOrBefore.TimeSameOrBeforeMinuteTrue1": @T23:25:25.555 same minute or before @T23:25:25.900

define "SameOrBefore.TimeSameOrBeforeMinuteFalse0": @T23:10:25.555 same minute or before @T22:15:25.900

define "SameOrBefore.TimeSameOrBeforeMinuteFalse": @T23:56:25.555 same minute or before @T23:55:25.900

define "SameOrBefore.TimeSameOrBeforeSecondTrue1": @T23:25:25.555 same second or before @T23:25:25.900

define "SameOrBefore.TimeSameOrBeforeSecondFalse0": @T23:25:35.555 same second or before @T22:25:45.900

define "SameOrBefore.TimeSameOrBeforeSecondFalse": @T23:55:45.555 same second or before @T23:55:35.900

define "SameOrBefore.TimeSameOrBeforeMillisTrue1": @T23:25:25.555 same millisecond or before @T23:25:25.555

define "SameOrBefore.TimeSameOrBeforeMillisFalse0": @T23:25:25.200 same millisecond or before @T22:25:25.550

define "SameOrBefore.TimeSameOrBeforeMillisFalse": @T23:55:25.966 same millisecond or before @T23:55:25.900

define "Subtract.DateTimeSubtract5Years": DateTime(2005, 10, 10) - 5 years

define "Subtract.DateTimeSubtractInvalidYears": DateTime(2005, 10, 10) - 2005 years

define "Subtract.DateTimeSubtract5Months": DateTime(2005, 6, 10) - 5 months

define "Subtract.DateTimeSubtractMonthsUnderflow": DateTime(2005, 5, 10) - 6 months

define "Subtract.DateTimeSubtract5Days": DateTime(2005, 5, 10) - 5 days

define "Subtract.DateTimeSubtractDaysUnderflow": DateTime(2016, 6, 10) - 11 days

define "Subtract.DateTimeSubtract5Hours": DateTime(2005, 5, 10, 10) - 5 hours

define "Subtract.DateTimeSubtractHoursUnderflow": DateTime(2016, 6, 10, 5) - 6 hours

define "Subtract.DateTimeSubtract5Minutes": DateTime(2005, 5, 10, 5, 10) - 5 minutes

define "Subtract.DateTimeSubtractMinutesUnderflow": DateTime(2016, 6, 10, 5, 5) - 6 minutes

define "Subtract.DateTimeSubtract5Seconds": DateTime(2005, 5, 10, 5, 5, 10) - 5 seconds

define "Subtract.DateTimeSubtractSecondsUnderflow": DateTime(2016, 6, 10, 5, 5, 5) - 6 seconds

define "Subtract.DateTimeSubtract5Milliseconds": DateTime(2005, 5, 10, 5, 5, 5, 10) - 5 milliseconds

define "Subtract.DateTimeSubtractMillisecondsUnderflow": DateTime(2016, 6, 10, 5, 5, 5, 5) - 6 milliseconds

define "Subtract.DateTimeSubtract2YearsAsMonths": DateTime(2014) - 24 months

define "Subtract.DateTimeSubtract2YearsAsMonthsRem1": DateTime(2014) - 25 months

define "Subtract.TimeSubtract5Hours": @T15:59:59.999 - 5 hours

define "Subtract.TimeSubtract1Minute": @T15:59:59.999 - 1 minutes

define "Subtract.TimeSubtract1Second": @T15:59:59.999 - 1 seconds

define "Subtract.TimeSubtract1Millisecond": @T15:59:59.0 - 1 milliseconds

define "Subtract.TimeSubtract5Hours1Minute": @T15:59:59.999 - 5 hours - 1 minutes

define "Subtract.TimeSubtract5hoursByMinute": @T15:59:59.999 - 300 minutes

define "Time.TimeTest2": @T23:59:59.999

define "TimeOfDay.TimeOfDayTest": TimeOfDay()

define "Today.DateTimeSameOrBeforeTodayTrue1": Today() same day or before Today()

define "Today.DateTimeSameOrBeforeTodayTrue2": Today() same day or before Today() + 1 days

define "Today.DateTimeSameOrBeforeTodayFalse": Today() + 1 years same day or before Today()

define "Today.DateTimeAddTodayTrue": Today() + 1 days > Today()

define "Today.Issue34B": Today()

