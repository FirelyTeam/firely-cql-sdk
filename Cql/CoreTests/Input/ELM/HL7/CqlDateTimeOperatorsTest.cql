library CqlDateTimeOperatorsTest

context Unfiltered


define "DateTimeAdd5Years Input":
	DateTime(2005, 10, 10) + 5 years
define "DateTimeAdd5Years Output":
	@2010-10-10T

define "DateTimeAddInvalidYears":
	DateTime(2005, 10, 10) + 8000 years

define "DateTimeAdd5Months Input":
	DateTime(2005, 5, 10) + 5 months
define "DateTimeAdd5Months Output":
	@2005-10-10T

define "DateTimeAddMonthsOverflow Input":
	DateTime(2005, 5, 10) + 10 months
define "DateTimeAddMonthsOverflow Output":
	@2006-03-10T

define "DateTimeAdd5Days Input":
	DateTime(2005, 5, 10) + 5 days
define "DateTimeAdd5Days Output":
	@2005-05-15T

define "DateTimeAddDaysOverflow Input":
	DateTime(2016, 6, 10) + 21 days
define "DateTimeAddDaysOverflow Output":
	@2016-07-01T

define "DateTimeAdd5Hours Input":
	DateTime(2005, 5, 10, 5) + 5 hours
define "DateTimeAdd5Hours Output":
	@2005-05-10T10

define "DateTimeAddHoursOverflow Input":
	DateTime(2016, 6, 10, 5) + 19 hours
define "DateTimeAddHoursOverflow Output":
	@2016-06-11T00

define "DateTimeAdd5Minutes Input":
	DateTime(2005, 5, 10, 5, 5) + 5 minutes
define "DateTimeAdd5Minutes Output":
	@2005-05-10T05:10

define "DateTimeAddMinutesOverflow Input":
	DateTime(2016, 6, 10, 5, 5) + 55 minutes
define "DateTimeAddMinutesOverflow Output":
	@2016-06-10T06:00

define "DateTimeAdd5Seconds Input":
	DateTime(2005, 5, 10, 5, 5, 5) + 5 seconds
define "DateTimeAdd5Seconds Output":
	@2005-05-10T05:05:10

define "DateTimeAddSecondsOverflow Input":
	DateTime(2016, 6, 10, 5, 5, 5) + 55 seconds
define "DateTimeAddSecondsOverflow Output":
	@2016-06-10T05:06:00

define "DateTimeAdd5Milliseconds Input":
	DateTime(2005, 5, 10, 5, 5, 5, 5) + 5 milliseconds
define "DateTimeAdd5Milliseconds Output":
	@2005-05-10T05:05:05.010

define "DateTimeAddMillisecondsOverflow Input":
	DateTime(2016, 6, 10, 5, 5, 5, 5) + 995 milliseconds
define "DateTimeAddMillisecondsOverflow Output":
	@2016-06-10T05:05:06.000

define "DateTimeAddLeapYear Input":
	DateTime(2012, 2, 29) + 1 year
define "DateTimeAddLeapYear Output":
	@2013-02-28T

define "DateTimeAdd2YearsByMonths Input":
	DateTime(2014) + 24 months
define "DateTimeAdd2YearsByMonths Output":
	@2016T

define "DateTimeAdd2YearsByDays Input":
	DateTime(2014) + 730 days
define "DateTimeAdd2YearsByDays Output":
	@2016T

define "DateTimeAdd2YearsByDaysRem5Days Input":
	DateTime(2014) + 735 days
define "DateTimeAdd2YearsByDaysRem5Days Output":
	@2016T

define "TimeAdd5Hours Input":
	@T15:59:59.999 + 5 hours
define "TimeAdd5Hours Output":
	@T20:59:59.999

define "TimeAdd1Minute Input":
	@T15:59:59.999 + 1 minute
define "TimeAdd1Minute Output":
	@T16:00:59.999

define "TimeAdd1Second Input":
	@T15:59:59.999 + 1 seconds
define "TimeAdd1Second Output":
	@T16:00:00.999

define "TimeAdd1Millisecond Input":
	@T15:59:59.999 + 1 milliseconds
define "TimeAdd1Millisecond Output":
	@T16:00:00.000

define "TimeAdd5Hours1Minute Input":
	@T15:59:59.999 + 5 hours + 1 minutes
define "TimeAdd5Hours1Minute Output":
	@T21:00:59.999

define "TimeAdd5hoursByMinute Input":
	@T15:59:59.999 + 300 minutes
define "TimeAdd5hoursByMinute Output":
	@T20:59:59.999

define "DateTimeAfterYearTrue Input":
	DateTime(2005, 10, 10) after year of DateTime(2004, 10, 10)
define "DateTimeAfterYearTrue Output":
	true

define "DateTimeAfterYearFalse Input":
	DateTime(2004, 11, 10) after year of DateTime(2004, 10, 10)
define "DateTimeAfterYearFalse Output":
	false

define "DateTimeAfterMonthTrue Input":
	DateTime(2004, 12, 10) after month of DateTime(2004, 11, 10)
define "DateTimeAfterMonthTrue Output":
	true

define "DateTimeAfterMonthFalse Input":
	DateTime(2004, 9, 10) after month of DateTime(2004, 10, 10)
define "DateTimeAfterMonthFalse Output":
	false

define "DateTimeAfterDayTrue Input":
	DateTime(2004, 12, 11) after day of DateTime(2004, 10, 10)
define "DateTimeAfterDayTrue Output":
	true

define "DateTimeAfterDayTrue2 Input":
	DateTime(2004, 12, 09) after day of DateTime(2003, 10, 10)
define "DateTimeAfterDayTrue2 Output":
	true

define "DateTimeAfterDayFalse Input":
	DateTime(2004, 10, 9) after day of DateTime(2004, 10, 10)
define "DateTimeAfterDayFalse Output":
	false

define "DateTimeAfterHourTrue Input":
	DateTime(2004, 10, 10, 10) after hour of DateTime(2004, 10, 10, 5)
define "DateTimeAfterHourTrue Output":
	true

define "DateTimeAfterHourFalse Input":
	DateTime(2004, 10, 10, 20) after hour of DateTime(2004, 10, 10, 21)
define "DateTimeAfterHourFalse Output":
	false

define "DateTimeAfterMinuteTrue Input":
	DateTime(2004, 10, 10, 20, 30) after minute of DateTime(2004, 10, 10, 20, 29)
define "DateTimeAfterMinuteTrue Output":
	true

define "DateTimeAfterMinuteFalse Input":
	DateTime(2004, 10, 10, 20, 30) after minute of DateTime(2004, 10, 10, 20, 31)
define "DateTimeAfterMinuteFalse Output":
	false

define "DateTimeAfterSecondTrue Input":
	DateTime(2004, 10, 10, 20, 30, 15) after second of DateTime(2004, 10, 10, 20, 30, 14)
define "DateTimeAfterSecondTrue Output":
	true

define "DateTimeAfterSecondFalse Input":
	DateTime(2004, 10, 10, 20, 30, 15) after second of DateTime(2004, 10, 10, 20, 30, 16)
define "DateTimeAfterSecondFalse Output":
	false

define "DateTimeAfterMillisecondTrue Input":
	DateTime(2004, 10, 10, 20, 30, 15, 512) after millisecond of DateTime(2004, 10, 10, 20, 30, 15, 510)
define "DateTimeAfterMillisecondTrue Output":
	true

define "DateTimeAfterMillisecondFalse Input":
	DateTime(2004, 10, 10, 20, 30, 15, 512) after millisecond of DateTime(2004, 10, 10, 20, 30, 15, 513)
define "DateTimeAfterMillisecondFalse Output":
	false

define "DateTimeAfterUncertain Input":
	DateTime(2005, 10, 10) after day of DateTime(2005, 9)
define "DateTimeAfterUncertain Output":
	true

define "AfterTimezoneTrue Input":
	@2012-03-10T10:20:00.999+07:00 after hour of @2012-03-10T08:20:00.999+06:00
define "AfterTimezoneTrue Output":
	true

define "AfterTimezoneFalse Input":
	@2012-03-10T10:20:00.999+07:00 after hour of @2012-03-10T10:20:00.999+06:00
define "AfterTimezoneFalse Output":
	false

define "TimeAfterHourTrue Input":
	@T15:59:59.999 after hour of @T14:59:59.999
define "TimeAfterHourTrue Output":
	true

define "TimeAfterHourFalse Input":
	@T15:59:59.999 after hour of @T16:59:59.999
define "TimeAfterHourFalse Output":
	false

define "TimeAfterMinuteTrue Input":
	@T15:59:59.999 after minute of @T15:58:59.999
define "TimeAfterMinuteTrue Output":
	true

define "TimeAfterMinuteFalse Input":
	@T15:58:59.999 after minute of @T15:59:59.999
define "TimeAfterMinuteFalse Output":
	false

define "TimeAfterSecondTrue Input":
	@T15:59:59.999 after second of @T15:59:58.999
define "TimeAfterSecondTrue Output":
	true

define "TimeAfterSecondFalse Input":
	@T15:59:58.999 after second of @T15:59:59.999
define "TimeAfterSecondFalse Output":
	false

define "TimeAfterMillisecondTrue Input":
	@T15:59:59.999 after millisecond of @T15:59:59.998
define "TimeAfterMillisecondTrue Output":
	true

define "TimeAfterMillisecondFalse Input":
	@T15:59:59.998 after millisecond of @T15:59:59.999
define "TimeAfterMillisecondFalse Output":
	false

define "TimeAfterTimeCstor Input":
	Time(12, 30) after hour of Time(11, 55)
define "TimeAfterTimeCstor Output":
	true

define "DateTimeBeforeYearTrue Input":
	DateTime(2003) before year of DateTime(2004, 10, 10)
define "DateTimeBeforeYearTrue Output":
	true

define "DateTimeBeforeYearFalse Input":
	DateTime(2004, 11, 10) before year of DateTime(2003, 10, 10)
define "DateTimeBeforeYearFalse Output":
	false

define "DateTimeBeforeMonthTrue Input":
	DateTime(2004, 10, 10) before month of DateTime(2004, 11, 10)
define "DateTimeBeforeMonthTrue Output":
	true

define "DateTimeBeforeMonthFalse Input":
	DateTime(2004, 11, 10) before month of DateTime(2004, 10, 10)
define "DateTimeBeforeMonthFalse Output":
	false

define "DateTimeBeforeDayTrue Input":
	DateTime(2004, 10, 1) before day of DateTime(2004, 10, 10)
define "DateTimeBeforeDayTrue Output":
	true

define "DateTimeBeforeDayTrue2 Input":
	DateTime(2003, 10, 11) before day of DateTime(2004, 10, 10)
define "DateTimeBeforeDayTrue2 Output":
	true

define "DateTimeBeforeDayFalse Input":
	DateTime(2004, 10, 11) before day of DateTime(2004, 10, 10)
define "DateTimeBeforeDayFalse Output":
	false

define "DateTimeBeforeHourTrue Input":
	DateTime(2004, 10, 10, 1) before hour of DateTime(2004, 10, 10, 5)
define "DateTimeBeforeHourTrue Output":
	true

define "DateTimeBeforeHourFalse Input":
	DateTime(2004, 10, 10, 23) before hour of DateTime(2004, 10, 10, 21)
define "DateTimeBeforeHourFalse Output":
	false

define "DateTimeBeforeMinuteTrue Input":
	DateTime(2004, 10, 10, 20, 28) before minute of DateTime(2004, 10, 10, 20, 29)
define "DateTimeBeforeMinuteTrue Output":
	true

define "DateTimeBeforeMinuteFalse Input":
	DateTime(2004, 10, 10, 20, 35) before minute of DateTime(2004, 10, 10, 20, 31)
define "DateTimeBeforeMinuteFalse Output":
	false

define "DateTimeBeforeSecondTrue Input":
	DateTime(2004, 10, 10, 20, 30, 12) before second of DateTime(2004, 10, 10, 20, 30, 14)
define "DateTimeBeforeSecondTrue Output":
	true

define "DateTimeBeforeSecondFalse Input":
	DateTime(2004, 10, 10, 20, 30, 55) before second of DateTime(2004, 10, 10, 20, 30, 16)
define "DateTimeBeforeSecondFalse Output":
	false

define "DateTimeBeforeMillisecondTrue Input":
	DateTime(2004, 10, 10, 20, 30, 15, 508) before millisecond of DateTime(2004, 10, 10, 20, 30, 15, 510)
define "DateTimeBeforeMillisecondTrue Output":
	true

define "DateTimeBeforeMillisecondFalse Input":
	DateTime(2004, 10, 10, 20, 30, 15, 599) before millisecond of DateTime(2004, 10, 10, 20, 30, 15, 513)
define "DateTimeBeforeMillisecondFalse Output":
	false

define "BeforeTimezoneTrue Input":
	@2012-03-10T10:20:00.999+07:00 before hour of @2012-03-10T10:20:00.999+06:00
define "BeforeTimezoneTrue Output":
	true

define "BeforeTimezoneFalse Input":
	@2012-03-10T10:20:00.999+07:00 before hour of @2012-03-10T09:20:00.999+06:00
define "BeforeTimezoneFalse Output":
	false

define "TimeBeforeHourTrue Input":
	@T13:59:59.999 before hour of @T14:59:59.999
define "TimeBeforeHourTrue Output":
	true

define "TimeBeforeHourFalse Input":
	@T16:59:59.999 before hour of @T15:59:59.999
define "TimeBeforeHourFalse Output":
	false

define "TimeBeforeMinuteTrue Input":
	@T15:57:59.999 before minute of @T15:58:59.999
define "TimeBeforeMinuteTrue Output":
	true

define "TimeBeforeMinuteFalse Input":
	@T15:59:59.999 before minute of @T15:59:59.999
define "TimeBeforeMinuteFalse Output":
	false

define "TimeBeforeSecondTrue Input":
	@T15:59:57.999 before second of @T15:59:58.999
define "TimeBeforeSecondTrue Output":
	true

define "TimeBeforeSecondFalse Input":
	@T15:59:56.999 before second of @T15:59:55.999
define "TimeBeforeSecondFalse Output":
	false

define "TimeBeforeMillisecondTrue Input":
	@T15:59:59.997 before millisecond of @T15:59:59.998
define "TimeBeforeMillisecondTrue Output":
	true

define "TimeBeforeMillisecondFalse Input":
	@T15:59:59.998 before millisecond of @T15:59:59.997
define "TimeBeforeMillisecondFalse Output":
	false

define "DateTimeYear Input":
	DateTime(2003)
define "DateTimeYear Output":
	@2003T

define "DateTimeMonth Input":
	DateTime(2003, 10)
define "DateTimeMonth Output":
	@2003-10T

define "DateTimeDay Input":
	DateTime(2003, 10, 29)
define "DateTimeDay Output":
	@2003-10-29T

define "DateTimeHour Input":
	DateTime(2003, 10, 29, 20)
define "DateTimeHour Output":
	@2003-10-29T20

define "DateTimeMinute Input":
	DateTime(2003, 10, 29, 20, 50)
define "DateTimeMinute Output":
	@2003-10-29T20:50

define "DateTimeSecond Input":
	DateTime(2003, 10, 29, 20, 50, 33)
define "DateTimeSecond Output":
	@2003-10-29T20:50:33

define "DateTimeMillisecond Input":
	DateTime(2003, 10, 29, 20, 50, 33, 955)
define "DateTimeMillisecond Output":
	@2003-10-29T20:50:33.955

define "DateTimeComponentFromYear Input":
	year from DateTime(2003, 10, 29, 20, 50, 33, 955)
define "DateTimeComponentFromYear Output":
	2003

define "DateTimeComponentFromMonth Input":
	month from DateTime(2003, 10, 29, 20, 50, 33, 955)
define "DateTimeComponentFromMonth Output":
	10

define "DateTimeComponentFromMonthMinBoundary Input":
	month from DateTime(2003, 01, 29, 20, 50, 33, 955)
define "DateTimeComponentFromMonthMinBoundary Output":
	1

define "DateTimeComponentFromDay Input":
	day from DateTime(2003, 10, 29, 20, 50, 33, 955)
define "DateTimeComponentFromDay Output":
	29

define "DateTimeComponentFromHour Input":
	hour from DateTime(2003, 10, 29, 20, 50, 33, 955)
define "DateTimeComponentFromHour Output":
	20

define "DateTimeComponentFromMinute Input":
	minute from DateTime(2003, 10, 29, 20, 50, 33, 955)
define "DateTimeComponentFromMinute Output":
	50

define "DateTimeComponentFromSecond Input":
	second from DateTime(2003, 10, 29, 20, 50, 33, 955)
define "DateTimeComponentFromSecond Output":
	33

define "DateTimeComponentFromMillisecond Input":
	millisecond from DateTime(2003, 10, 29, 20, 50, 33, 955)
define "DateTimeComponentFromMillisecond Output":
	955

define "DateTimeComponentFromDate Input":
	date from DateTime(2003, 10, 29, 20, 50, 33, 955, 1)
define "DateTimeComponentFromDate Output":
	@2003-10-29

define "TimeComponentFromHour Input":
	hour from @T23:20:15.555
define "TimeComponentFromHour Output":
	23

define "TimeComponentFromMinute Input":
	minute from @T23:20:15.555
define "TimeComponentFromMinute Output":
	20

define "TimeComponentFromSecond Input":
	second from @T23:20:15.555
define "TimeComponentFromSecond Output":
	15

define "TimeComponentFromMilli Input":
	millisecond from @T23:20:15.555
define "TimeComponentFromMilli Output":
	555

define "DateTimeDifferenceYear Input":
	difference in years between DateTime(2000) and DateTime(2005, 12)
define "DateTimeDifferenceYear Output":
	5

define "DateTimeDifferenceMonth Input":
	difference in months between DateTime(2000, 2) and DateTime(2000, 10)
define "DateTimeDifferenceMonth Output":
	8

define "DateTimeDifferenceDay Input":
	difference in days between DateTime(2000, 10, 15, 10, 30) and DateTime(2000, 10, 25, 10, 0)
define "DateTimeDifferenceDay Output":
	10

define "DateTimeDifferenceHour Input":
	difference in hours between DateTime(2000, 4, 1, 12) and DateTime(2000, 4, 1, 20)
define "DateTimeDifferenceHour Output":
	8

define "DateTimeDifferenceMinute Input":
	difference in minutes between DateTime(2005, 12, 10, 5, 16) and DateTime(2005, 12, 10, 5, 25)
define "DateTimeDifferenceMinute Output":
	9

define "DateTimeDifferenceSecond Input":
	difference in seconds between DateTime(2000, 10, 10, 10, 5, 45) and DateTime(2000, 10, 10, 10, 5, 50)
define "DateTimeDifferenceSecond Output":
	5

define "DateTimeDifferenceMillisecond Input":
	difference in milliseconds between DateTime(2000, 10, 10, 10, 5, 45, 500, -6.0) and DateTime(2000, 10, 10, 10, 5, 45, 900, -7.0)
define "DateTimeDifferenceMillisecond Output":
	3600400

define "DateTimeDifferenceWeeks Input":
	difference in weeks between DateTime(2000, 10, 15) and DateTime(2000, 10, 28)
define "DateTimeDifferenceWeeks Output":
	1

define "DateTimeDifferenceWeeks2 Input":
	difference in weeks between DateTime(2000, 10, 15) and DateTime(2000, 10, 29)
define "DateTimeDifferenceWeeks2 Output":
	2

define "DateTimeDifferenceWeeks3 Input":
	difference in weeks between @2012-03-10T22:05:09 and @2012-03-24T07:19:33
define "DateTimeDifferenceWeeks3 Output":
	2

define "DateTimeDifferenceNegative Input":
	difference in years between DateTime(2016) and DateTime(1998)
define "DateTimeDifferenceNegative Output":
	-18

define "DateTimeDifferenceUncertain Input":
	difference in months between DateTime(2005) and DateTime(2006, 7) > 5
define "DateTimeDifferenceUncertain Output":
	true

define "TimeDifferenceHour Input":
	difference in hours between @T20 and @T23:25:15.555
define "TimeDifferenceHour Output":
	3

define "TimeDifferenceMinute Input":
	difference in minutes between @T20:20:15.555 and @T20:25:15.555
define "TimeDifferenceMinute Output":
	5

define "TimeDifferenceSecond Input":
	difference in seconds between @T20:20:15.555 and @T20:20:20.555
define "TimeDifferenceSecond Output":
	5

define "TimeDifferenceMillis Input":
	difference in milliseconds between @T20:20:15.555 and @T20:20:15.550
define "TimeDifferenceMillis Output":
	-5

define "DateTimeA Input":
	@2017-03-12T01:00:00-07:00
define "DateTimeA Output":
	@2017-03-12T01:00:00-07:00

define "DateTimeAA Input":
	DateTime(2017, 3, 12, 1, 0, 0, 0, -7.0)
define "DateTimeAA Output":
	@2017-03-12T01:00:00.000-07:00

define "DateTimeB Input":
	@2017-03-12T03:00:00-06:00
define "DateTimeB Output":
	@2017-03-12T03:00:00-06:00

define "DateTimeBB Input":
	DateTime(2017, 3, 12, 3, 0, 0, 0, -6.0)
define "DateTimeBB Output":
	@2017-03-12T03:00:00.000-06:00

define "DateTimeC Input":
	@2017-11-05T01:30:00-06:00
define "DateTimeC Output":
	@2017-11-05T01:30:00-06:00

define "DateTimeCC Input":
	DateTime(2017, 11, 5, 1, 30, 0, 0, -6.0)
define "DateTimeCC Output":
	@2017-11-05T01:30:00.000-06:00

define "DateTimeD Input":
	@2017-11-05T01:15:00-07:00
define "DateTimeD Output":
	@2017-11-05T01:15:00-07:00

define "DateTimeDD Input":
	DateTime(2017, 11, 5, 1, 15, 0, 0, -7.0)
define "DateTimeDD Output":
	@2017-11-05T01:15:00.000-07:00

define "DateTimeE Input":
	@2017-03-12T00:00:00-07:00
define "DateTimeE Output":
	@2017-03-12T00:00:00-07:00

define "DateTimeEE Input":
	DateTime(2017, 3, 12, 0, 0, 0, 0, -7.0)
define "DateTimeEE Output":
	@2017-03-12T00:00:00.000-07:00

define "DateTimeF Input":
	@2017-03-13T00:00:00-06:00
define "DateTimeF Output":
	@2017-03-13T00:00:00-06:00

define "DateTimeFF Input":
	DateTime(2017, 3, 13, 0, 0, 0, 0, -6.0)
define "DateTimeFF Output":
	@2017-03-13T00:00:00.000-06:00

define "DifferenceInHoursA Input":
	difference in hours between @2017-03-12T01:00:00-07:00 and @2017-03-12T03:00:00-06:00
define "DifferenceInHoursA Output":
	1

define "DifferenceInMinutesA Input":
	difference in minutes between @2017-11-05T01:30:00-06:00 and @2017-11-05T01:15:00-07:00
define "DifferenceInMinutesA Output":
	45

define "DifferenceInDaysA Input":
	difference in days between @2017-03-12T00:00:00-07:00 and @2017-03-13T00:00:00-06:00
define "DifferenceInDaysA Output":
	1

define "DifferenceInHoursAA Input":
	difference in hours between DateTime(2017, 3, 12, 1, 0, 0, 0, -7.0) and DateTime(2017, 3, 12, 3, 0, 0, 0, -6.0)
define "DifferenceInHoursAA Output":
	1

define "DifferenceInMinutesAA Input":
	difference in minutes between DateTime(2017, 11, 5, 1, 30, 0, 0, -6.0) and DateTime(2017, 11, 5, 1, 15, 0, 0, -7.0)
define "DifferenceInMinutesAA Output":
	45

define "DifferenceInDaysAA Input":
	difference in days between DateTime(2017, 3, 12, 0, 0, 0, 0, -7.0) and DateTime(2017, 3, 13, 0, 0, 0, 0, -6.0)
define "DifferenceInDaysAA Output":
	1

define "DateTimeDurationBetweenYear Input":
	years between DateTime(2005) and DateTime(2010)
define "DateTimeDurationBetweenYear Output":
	Interval[ 4, 5 ]

define "DateTimeDurationBetweenYearOffset Input":
	years between DateTime(2005, 5) and DateTime(2010, 4)
define "DateTimeDurationBetweenYearOffset Output":
	4

define "DateTimeDurationBetweenMonth Input":
	months between @2014-01-31 and @2014-02-01
define "DateTimeDurationBetweenMonth Output":
	0

define "DateTimeDurationBetweenDaysDiffYears Input":
	days between DateTime(2010, 10, 12, 12, 5) and DateTime(2008, 8, 15, 8, 8)
define "DateTimeDurationBetweenDaysDiffYears Output":
	-788

define "DateTimeDurationBetweenUncertainInterval Input":
	days between DateTime(2014, 1, 15) and DateTime(2014, 2)
define "DateTimeDurationBetweenUncertainInterval Output":
	Interval[ 16, 44 ]

define "DateTimeDurationBetweenUncertainInterval2 Input":
	months between DateTime(2005) and DateTime(2006, 5)
define "DateTimeDurationBetweenUncertainInterval2 Output":
	Interval[ 4, 16 ]

define "DateTimeDurationBetweenUncertainAdd Input":
	(days between DateTime(2014, 1, 15) and DateTime(2014, 2))
				+ (days between DateTime(2014, 1, 15) and DateTime(2014, 2))
define "DateTimeDurationBetweenUncertainAdd Output":
	Interval[ 32, 88 ]

define "DateTimeDurationBetweenUncertainSubtract Input":
	(days between DateTime(2014, 1, 15) and DateTime(2014, 2))
				- (months between DateTime(2005) and DateTime(2006, 5))
define "DateTimeDurationBetweenUncertainSubtract Output":
	Interval[ 0, 40 ]

define "DateTimeDurationBetweenUncertainMultiply Input":
	(days between DateTime(2014, 1, 15) and DateTime(2014, 2))
				* (days between DateTime(2014, 1, 15) and DateTime(2014, 2))
define "DateTimeDurationBetweenUncertainMultiply Output":
	Interval[ 256, 1936 ]

define "DateTimeDurationBetweenUncertainDiv":
	(days between DateTime(2014, 1, 15) and DateTime(2014, 2))
				div (months between DateTime(2005) and DateTime(2006, 5))

define "DateTimeDurationBetweenMonthUncertain Input":
	months between DateTime(2005) and DateTime(2006, 7) > 5
define "DateTimeDurationBetweenMonthUncertain Output":
	true

define "DateTimeDurationBetweenMonthUncertain2 Input":
	months between DateTime(2005) and DateTime(2006, 2) > 5
define "DateTimeDurationBetweenMonthUncertain2 Output":
	null

define "DateTimeDurationBetweenMonthUncertain3 Input":
	months between DateTime(2005) and DateTime(2006, 7) > 25
define "DateTimeDurationBetweenMonthUncertain3 Output":
	false

define "DateTimeDurationBetweenMonthUncertain4 Input":
	months between DateTime(2005) and DateTime(2006, 7) < 24
define "DateTimeDurationBetweenMonthUncertain4 Output":
	true

define "DateTimeDurationBetweenMonthUncertain5 Input":
	months between DateTime(2005) and DateTime(2006, 7) = 24
define "DateTimeDurationBetweenMonthUncertain5 Output":
	false

define "DateTimeDurationBetweenMonthUncertain6 Input":
	months between DateTime(2005) and DateTime(2006, 7) >= 5
define "DateTimeDurationBetweenMonthUncertain6 Output":
	true

define "DateTimeDurationBetweenMonthUncertain7 Input":
	months between DateTime(2005) and DateTime(2006, 7) <= 24
define "DateTimeDurationBetweenMonthUncertain7 Output":
	true

define "DateTime1 Input":
	@2012-03-10T10:20:00
define "DateTime1 Output":
	@2012-03-10T10:20:00

define "DateTime2 Input":
	@2013-03-10T09:20:00
define "DateTime2 Output":
	@2013-03-10T09:20:00

define "DurationInYears Input":
	years between (date from @2012-03-10T10:20:00) and (date from @2013-03-10T09:20:00)
define "DurationInYears Output":
	1

define "DurationInWeeks Input":
	weeks between @2012-03-10T22:05:09 and @2012-03-20T07:19:33
define "DurationInWeeks Output":
	1

define "DurationInWeeks2 Input":
	weeks between @2012-03-10T22:05:09 and @2012-03-24T07:19:33
define "DurationInWeeks2 Output":
	1

define "DurationInWeeks3 Input":
	weeks between @2012-03-10T06:05:09 and @2012-03-24T07:19:33
define "DurationInWeeks3 Output":
	2

define "TimeDurationBetweenHour Input":
	hours between @T20:26:15.555 and @T23:25:15.555
define "TimeDurationBetweenHour Output":
	2

define "TimeDurationBetweenHourDiffPrecision Input":
	hours between @T06 and @T07:00:00
define "TimeDurationBetweenHourDiffPrecision Output":
	1

define "TimeDurationBetweenMinute Input":
	minutes between @T23:20:16.555 and @T23:25:15.555
define "TimeDurationBetweenMinute Output":
	4

define "TimeDurationBetweenSecond Input":
	seconds between @T23:25:10.556 and @T23:25:15.555
define "TimeDurationBetweenSecond Output":
	4

define "TimeDurationBetweenMillis Input":
	milliseconds between @T23:25:25.555 and @T23:25:25.560
define "TimeDurationBetweenMillis Output":
	5

define "DurationInHoursA Input":
	hours between @2017-03-12T01:00:00-07:00 and @2017-03-12T03:00:00-06:00
define "DurationInHoursA Output":
	1

define "DurationInMinutesA Input":
	minutes between @2017-11-05T01:30:00-06:00 and @2017-11-05T01:15:00-07:00
define "DurationInMinutesA Output":
	45

define "DurationInDaysA Input":
	days between @2017-03-12T00:00:00-07:00 and @2017-03-13T00:00:00-06:00
define "DurationInDaysA Output":
	0

define "DurationInHoursAA Input":
	hours between DateTime(2017, 3, 12, 1, 0, 0, 0, -7.0) and DateTime(2017, 3, 12, 3, 0, 0, 0, -6.0)
define "DurationInHoursAA Output":
	1

define "DurationInMinutesAA Input":
	minutes between DateTime(2017, 11, 5, 1, 30, 0, 0, -6.0) and DateTime(2017, 11, 5, 1, 15, 0, 0, -7.0)
define "DurationInMinutesAA Output":
	45

define "DurationInDaysAA Input":
	days between DateTime(2017, 3, 12, 0, 0, 0, 0, -7.0) and DateTime(2017, 3, 13, 0, 0, 0, 0, -6.0)
define "DurationInDaysAA Output":
	0

define "DateTimeNow Input":
	Now() = Now()
define "DateTimeNow Output":
	true

define "DateTimeSameAsYearTrue Input":
	DateTime(2014) same year as DateTime(2014)
define "DateTimeSameAsYearTrue Output":
	true

define "DateTimeSameAsYearFalse Input":
	DateTime(2013) same year as DateTime(2014)
define "DateTimeSameAsYearFalse Output":
	false

define "DateTimeSameAsMonthTrue Input":
	DateTime(2014, 12) same month as DateTime(2014, 12)
define "DateTimeSameAsMonthTrue Output":
	true

define "DateTimeSameAsMonthFalse Input":
	DateTime(2014, 12) same month as DateTime(2014, 10)
define "DateTimeSameAsMonthFalse Output":
	false

define "DateTimeSameAsDayTrue Input":
	DateTime(2014, 12, 10) same day as DateTime(2014, 12, 10)
define "DateTimeSameAsDayTrue Output":
	true

define "DateTimeSameAsDayFalse Input":
	DateTime(2014, 10, 10) same day as DateTime(2014, 10, 11)
define "DateTimeSameAsDayFalse Output":
	false

define "DateTimeSameAsHourTrue Input":
	DateTime(2014, 12, 10, 20) same hour as DateTime(2014, 12, 10, 20)
define "DateTimeSameAsHourTrue Output":
	true

define "DateTimeSameAsHourFalse Input":
	DateTime(2014, 10, 10, 20) same hour as DateTime(2014, 10, 10, 21)
define "DateTimeSameAsHourFalse Output":
	false

define "DateTimeSameAsMinuteTrue Input":
	DateTime(2014, 12, 10, 20, 55) same minute as DateTime(2014, 12, 10, 20, 55)
define "DateTimeSameAsMinuteTrue Output":
	true

define "DateTimeSameAsMinuteFalse Input":
	DateTime(2014, 10, 10, 20, 55) same minute as DateTime(2014, 10, 10, 21, 56)
define "DateTimeSameAsMinuteFalse Output":
	false

define "DateTimeSameAsSecondTrue Input":
	DateTime(2014, 12, 10, 20, 55, 45) same second as DateTime(2014, 12, 10, 20, 55, 45)
define "DateTimeSameAsSecondTrue Output":
	true

define "DateTimeSameAsSecondFalse Input":
	DateTime(2014, 10, 10, 20, 55, 45) same second as DateTime(2014, 10, 10, 21, 55, 44)
define "DateTimeSameAsSecondFalse Output":
	false

define "DateTimeSameAsMillisecondTrue Input":
	DateTime(2014, 12, 10, 20, 55, 45, 500) same millisecond as DateTime(2014, 12, 10, 20, 55, 45, 500)
define "DateTimeSameAsMillisecondTrue Output":
	true

define "DateTimeSameAsMillisecondFalse Input":
	DateTime(2014, 10, 10, 20, 55, 45, 500) same millisecond as DateTime(2014, 10, 10, 21, 55, 45, 501)
define "DateTimeSameAsMillisecondFalse Output":
	false

define "DateTimeSameAsNull Input":
	DateTime(2014, 10) same day as DateTime(2014, 10, 12)
define "DateTimeSameAsNull Output":
	null

define "SameAsTimezoneTrue Input":
	@2012-03-10T10:20:00.999+07:00 same hour as @2012-03-10T09:20:00.999+06:00
define "SameAsTimezoneTrue Output":
	true

define "SameAsTimezoneFalse Input":
	@2012-03-10T10:20:00.999+07:00 same hour as @2012-03-10T10:20:00.999+06:00
define "SameAsTimezoneFalse Output":
	false

define "TimeSameAsHourTrue Input":
	@T23:25:25.555 same hour as @T23:55:25.900
define "TimeSameAsHourTrue Output":
	true

define "TimeSameAsHourFalse Input":
	@T22:25:25.555 same hour as @T23:25:25.555
define "TimeSameAsHourFalse Output":
	false

define "TimeSameAsMinuteTrue Input":
	@T23:55:22.555 same minute as @T23:55:25.900
define "TimeSameAsMinuteTrue Output":
	true

define "TimeSameAsMinuteFalse Input":
	@T23:26:25.555 same minute as @T23:25:25.555
define "TimeSameAsMinuteFalse Output":
	false

define "TimeSameAsSecondTrue Input":
	@T23:55:25.555 same second as @T23:55:25.900
define "TimeSameAsSecondTrue Output":
	true

define "TimeSameAsSecondFalse Input":
	@T23:25:35.555 same second as @T23:25:25.555
define "TimeSameAsSecondFalse Output":
	false

define "TimeSameAsMillisTrue Input":
	@T23:55:25.555 same millisecond as @T23:55:25.555
define "TimeSameAsMillisTrue Output":
	true

define "TimeSameAsMillisFalse Input":
	@T23:25:25.555 same millisecond as @T23:25:25.554
define "TimeSameAsMillisFalse Output":
	false

define "DateTimeSameOrAfterYearTrue1 Input":
	DateTime(2014) same year or after DateTime(2014)
define "DateTimeSameOrAfterYearTrue1 Output":
	true

define "DateTimeSameOrAfterYearTrue2 Input":
	DateTime(2016) same year or after DateTime(2014)
define "DateTimeSameOrAfterYearTrue2 Output":
	true

define "DateTimeSameOrAfterYearFalse Input":
	DateTime(2013) same year or after DateTime(2014)
define "DateTimeSameOrAfterYearFalse Output":
	false

define "DateTimeSameOrAfterMonthTrue1 Input":
	DateTime(2014, 12) same month or after DateTime(2014, 12)
define "DateTimeSameOrAfterMonthTrue1 Output":
	true

define "DateTimeSameOrAfterMonthTrue2 Input":
	DateTime(2014, 10) same month or after DateTime(2014, 9)
define "DateTimeSameOrAfterMonthTrue2 Output":
	true

define "DateTimeSameOrAfterMonthFalse Input":
	DateTime(2014, 10) same month or after DateTime(2014, 11)
define "DateTimeSameOrAfterMonthFalse Output":
	false

define "DateTimeSameOrAfterDayTrue1 Input":
	DateTime(2014, 12, 20) same day or after DateTime(2014, 12, 20)
define "DateTimeSameOrAfterDayTrue1 Output":
	true

define "DateTimeSameOrAfterDayTrue2 Input":
	DateTime(2014, 10, 25) same day or after DateTime(2014, 10, 20)
define "DateTimeSameOrAfterDayTrue2 Output":
	true

define "DateTimeSameOrAfterDayFalse Input":
	DateTime(2014, 10, 20) same day or after DateTime(2014, 10, 25)
define "DateTimeSameOrAfterDayFalse Output":
	false

define "DateTimeSameOrAfterHourTrue1 Input":
	DateTime(2014, 12, 20, 12) same hour or after DateTime(2014, 12, 20, 12)
define "DateTimeSameOrAfterHourTrue1 Output":
	true

define "DateTimeSameOrAfterHourTrue2 Input":
	DateTime(2014, 10, 25, 12) same hour or after DateTime(2014, 10, 25, 10)
define "DateTimeSameOrAfterHourTrue2 Output":
	true

define "DateTimeSameOrAfterHourFalse Input":
	DateTime(2014, 10, 25, 12) same hour or after DateTime(2014, 10, 25, 15)
define "DateTimeSameOrAfterHourFalse Output":
	false

define "DateTimeSameOrAfterMinuteTrue1 Input":
	DateTime(2014, 12, 20, 12, 30) same minute or after DateTime(2014, 12, 20, 12, 30)
define "DateTimeSameOrAfterMinuteTrue1 Output":
	true

define "DateTimeSameOrAfterMinuteTrue2 Input":
	DateTime(2014, 10, 25, 10, 30) same minute or after DateTime(2014, 10, 25, 10, 25)
define "DateTimeSameOrAfterMinuteTrue2 Output":
	true

define "DateTimeSameOrAfterMinuteFalse Input":
	DateTime(2014, 10, 25, 15, 30) same minute or after DateTime(2014, 10, 25, 15, 45)
define "DateTimeSameOrAfterMinuteFalse Output":
	false

define "DateTimeSameOrAfterSecondTrue1 Input":
	DateTime(2014, 12, 20, 12, 30, 15) same second or after DateTime(2014, 12, 20, 12, 30, 15)
define "DateTimeSameOrAfterSecondTrue1 Output":
	true

define "DateTimeSameOrAfterSecondTrue2 Input":
	DateTime(2014, 10, 25, 10, 25, 25) same second or after DateTime(2014, 10, 25, 10, 25, 20)
define "DateTimeSameOrAfterSecondTrue2 Output":
	true

define "DateTimeSameOrAfterSecondFalse Input":
	DateTime(2014, 10, 25, 15, 45, 20) same second or after DateTime(2014, 10, 25, 15, 45, 21)
define "DateTimeSameOrAfterSecondFalse Output":
	false

define "DateTimeSameOrAfterMillisecondTrue1 Input":
	DateTime(2014, 12, 20, 12, 30, 15, 250) same millisecond or after DateTime(2014, 12, 20, 12, 30, 15, 250)
define "DateTimeSameOrAfterMillisecondTrue1 Output":
	true

define "DateTimeSameOrAfterMillisecondTrue2 Input":
	DateTime(2014, 10, 25, 10, 25, 20, 500) same millisecond or after DateTime(2014, 10, 25, 10, 25, 20, 499)
define "DateTimeSameOrAfterMillisecondTrue2 Output":
	true

define "DateTimeSameOrAfterMillisecondFalse Input":
	DateTime(2014, 10, 25, 15, 45, 20, 500) same millisecond or after DateTime(2014, 10, 25, 15, 45, 20, 501)
define "DateTimeSameOrAfterMillisecondFalse Output":
	false

define "DateTimeSameOrAfterNull1 Input":
	DateTime(2014, 12, 20) same day or after DateTime(2014, 12)
define "DateTimeSameOrAfterNull1 Output":
	null

define "SameOrAfterTimezoneTrue Input":
	@2012-03-10T10:20:00.999+07:00 same hour or after @2012-03-10T09:20:00.999+06:00
define "SameOrAfterTimezoneTrue Output":
	true

define "SameOrAfterTimezoneFalse Input":
	@2012-03-10T10:20:00.999+07:00 same hour or after @2012-03-10T10:20:00.999+06:00
define "SameOrAfterTimezoneFalse Output":
	false

define "TimeSameOrAfterHourTrue1 Input":
	@T23:25:25.555 same hour or after @T23:55:25.900
define "TimeSameOrAfterHourTrue1 Output":
	true

define "TimeSameOrAfterHourTrue2 Input":
	@T23:25:25.555 same hour or after @T22:55:25.900
define "TimeSameOrAfterHourTrue2 Output":
	true

define "TimeSameOrAfterHourFalse Input":
	@T22:25:25.555 same hour or after @T23:55:25.900
define "TimeSameOrAfterHourFalse Output":
	false

define "TimeSameOrAfterMinuteTrue1 Input":
	@T23:25:25.555 same minute or after @T23:25:25.900
define "TimeSameOrAfterMinuteTrue1 Output":
	true

define "TimeSameOrAfterMinuteTrue2 Input":
	@T23:25:25.555 same minute or after @T22:15:25.900
define "TimeSameOrAfterMinuteTrue2 Output":
	true

define "TimeSameOrAfterMinuteFalse Input":
	@T23:25:25.555 same minute or after @T23:55:25.900
define "TimeSameOrAfterMinuteFalse Output":
	false

define "TimeSameOrAfterSecondTrue1 Input":
	@T23:25:25.555 same second or after @T23:25:25.900
define "TimeSameOrAfterSecondTrue1 Output":
	true

define "TimeSameOrAfterSecondTrue2 Input":
	@T23:25:35.555 same second or after @T22:25:25.900
define "TimeSameOrAfterSecondTrue2 Output":
	true

define "TimeSameOrAfterSecondFalse Input":
	@T23:55:25.555 same second or after @T23:55:35.900
define "TimeSameOrAfterSecondFalse Output":
	false

define "TimeSameOrAfterMillisTrue1 Input":
	@T23:25:25.555 same millisecond or after @T23:25:25.555
define "TimeSameOrAfterMillisTrue1 Output":
	true

define "TimeSameOrAfterMillisTrue2 Input":
	@T23:25:25.555 same millisecond or after @T22:25:25.550
define "TimeSameOrAfterMillisTrue2 Output":
	true

define "TimeSameOrAfterMillisFalse Input":
	@T23:55:25.555 same millisecond or after @T23:55:25.900
define "TimeSameOrAfterMillisFalse Output":
	false

define "OnOrAfterTrue Input":
	@2017-12-20T11:00:00.000 on or after @2017-12-20T11:00:00.000
define "OnOrAfterTrue Output":
	true

define "Issue32DateTime Input":
	@2017-12-21T02:00:00.0 same or after @2017-12-20T11:00:00.0
define "Issue32DateTime Output":
	true

define "DateTimeSameOrBeforeYearTrue1 Input":
	DateTime(2014) same year or before DateTime(2014)
define "DateTimeSameOrBeforeYearTrue1 Output":
	true

define "DateTimeSameOrBeforeYearTrue2 Input":
	DateTime(2013) same year or before DateTime(2014)
define "DateTimeSameOrBeforeYearTrue2 Output":
	true

define "DateTimeSameOrBeforeYearFalse Input":
	DateTime(2015) same year or before DateTime(2014)
define "DateTimeSameOrBeforeYearFalse Output":
	false

define "DateTimeSameOrBeforeMonthTrue1 Input":
	DateTime(2014, 12) same month or before DateTime(2014, 12)
define "DateTimeSameOrBeforeMonthTrue1 Output":
	true

define "DateTimeSameOrBeforeMonthTrue2 Input":
	DateTime(2014, 8) same month or before DateTime(2014, 9)
define "DateTimeSameOrBeforeMonthTrue2 Output":
	true

define "DateTimeSameOrBeforeMonthFalse Input":
	DateTime(2014, 12) same month or before DateTime(2014, 11)
define "DateTimeSameOrBeforeMonthFalse Output":
	false

define "DateTimeSameOrBeforeDayTrue1 Input":
	DateTime(2014, 12, 20) same day or before DateTime(2014, 12, 20)
define "DateTimeSameOrBeforeDayTrue1 Output":
	true

define "DateTimeSameOrBeforeDayTrue2 Input":
	DateTime(2014, 10, 15) same day or before DateTime(2014, 10, 20)
define "DateTimeSameOrBeforeDayTrue2 Output":
	true

define "DateTimeSameOrBeforeDayFalse Input":
	DateTime(2014, 10, 30) same day or before DateTime(2014, 10, 25)
define "DateTimeSameOrBeforeDayFalse Output":
	false

define "DateTimeSameOrBeforeHourTrue1 Input":
	DateTime(2014, 12, 20, 12) same hour or before DateTime(2014, 12, 20, 12)
define "DateTimeSameOrBeforeHourTrue1 Output":
	true

define "DateTimeSameOrBeforeHourTrue2 Input":
	DateTime(2014, 10, 25, 5) same hour or before DateTime(2014, 10, 25, 10)
define "DateTimeSameOrBeforeHourTrue2 Output":
	true

define "DateTimeSameOrBeforeHourFalse Input":
	DateTime(2014, 10, 25, 20) same hour or before DateTime(2014, 10, 25, 15)
define "DateTimeSameOrBeforeHourFalse Output":
	false

define "DateTimeSameOrBeforeMinuteTrue1 Input":
	DateTime(2014, 12, 20, 12, 30) same minute or before DateTime(2014, 12, 20, 12, 30)
define "DateTimeSameOrBeforeMinuteTrue1 Output":
	true

define "DateTimeSameOrBeforeMinuteTrue2 Input":
	DateTime(2014, 10, 25, 10, 20) same minute or before DateTime(2014, 10, 25, 10, 25)
define "DateTimeSameOrBeforeMinuteTrue2 Output":
	true

define "DateTimeSameOrBeforeMinuteFalse Input":
	DateTime(2014, 10, 25, 15, 55) same minute or before DateTime(2014, 10, 25, 15, 45)
define "DateTimeSameOrBeforeMinuteFalse Output":
	false

define "DateTimeSameOrBeforeSecondTrue1 Input":
	DateTime(2014, 12, 20, 12, 30, 15) same second or before DateTime(2014, 12, 20, 12, 30, 15)
define "DateTimeSameOrBeforeSecondTrue1 Output":
	true

define "DateTimeSameOrBeforeSecondTrue2 Input":
	DateTime(2014, 10, 25, 10, 25, 15) same second or before DateTime(2014, 10, 25, 10, 25, 20)
define "DateTimeSameOrBeforeSecondTrue2 Output":
	true

define "DateTimeSameOrBeforeSecondFalse Input":
	DateTime(2014, 10, 25, 15, 45, 25) same second or before DateTime(2014, 10, 25, 15, 45, 21)
define "DateTimeSameOrBeforeSecondFalse Output":
	false

define "DateTimeSameOrBeforeMillisecondTrue1 Input":
	DateTime(2014, 12, 20, 12, 30, 15, 250) same millisecond or before DateTime(2014, 12, 20, 12, 30, 15, 250)
define "DateTimeSameOrBeforeMillisecondTrue1 Output":
	true

define "DateTimeSameOrBeforeMillisecondTrue2 Input":
	DateTime(2014, 10, 25, 10, 25, 20, 450) same millisecond or before DateTime(2014, 10, 25, 10, 25, 20, 499)
define "DateTimeSameOrBeforeMillisecondTrue2 Output":
	true

define "DateTimeSameOrBeforeMillisecondFalse Input":
	DateTime(2014, 10, 25, 15, 45, 20, 505) same millisecond or before DateTime(2014, 10, 25, 15, 45, 20, 501)
define "DateTimeSameOrBeforeMillisecondFalse Output":
	false

define "DateTimeSameOrBeforeNull1 Input":
	DateTime(2014, 12, 20) same minute or before DateTime(2014, 12, 20, 15)
define "DateTimeSameOrBeforeNull1 Output":
	null

define "SameOrBeforeTimezoneTrue Input":
	@2012-03-10T09:20:00.999+07:00 same hour or before @2012-03-10T10:20:00.999+06:00
define "SameOrBeforeTimezoneTrue Output":
	true

define "SameOrBeforeTimezoneFalse Input":
	@2012-03-10T10:20:00.999+06:00 same hour or before @2012-03-10T10:20:00.999+07:00
define "SameOrBeforeTimezoneFalse Output":
	false

define "TimeSameOrBeforeHourTrue1 Input":
	@T23:25:25.555 same hour or before @T23:55:25.900
define "TimeSameOrBeforeHourTrue1 Output":
	true

define "TimeSameOrBeforeHourTrue2 Input":
	@T21:25:25.555 same hour or before @T22:55:25.900
define "TimeSameOrBeforeHourTrue2 Output":
	true

define "TimeSameOrBeforeHourFalse Input":
	@T22:25:25.555 same hour or before @T21:55:25.900
define "TimeSameOrBeforeHourFalse Output":
	false

define "TimeSameOrBeforeMinuteTrue1 Input":
	@T23:25:25.555 same minute or before @T23:25:25.900
define "TimeSameOrBeforeMinuteTrue1 Output":
	true

define "TimeSameOrBeforeMinuteFalse0 Input":
	@T23:10:25.555 same minute or before @T22:15:25.900
define "TimeSameOrBeforeMinuteFalse0 Output":
	false

define "TimeSameOrBeforeMinuteFalse Input":
	@T23:56:25.555 same minute or before @T23:55:25.900
define "TimeSameOrBeforeMinuteFalse Output":
	false

define "TimeSameOrBeforeSecondTrue1 Input":
	@T23:25:25.555 same second or before @T23:25:25.900
define "TimeSameOrBeforeSecondTrue1 Output":
	true

define "TimeSameOrBeforeSecondFalse0 Input":
	@T23:25:35.555 same second or before @T22:25:45.900
define "TimeSameOrBeforeSecondFalse0 Output":
	false

define "TimeSameOrBeforeSecondFalse Input":
	@T23:55:45.555 same second or before @T23:55:35.900
define "TimeSameOrBeforeSecondFalse Output":
	false

define "TimeSameOrBeforeMillisTrue1 Input":
	@T23:25:25.555 same millisecond or before @T23:25:25.555
define "TimeSameOrBeforeMillisTrue1 Output":
	true

define "TimeSameOrBeforeMillisFalse0 Input":
	@T23:25:25.200 same millisecond or before @T22:25:25.550
define "TimeSameOrBeforeMillisFalse0 Output":
	false

define "TimeSameOrBeforeMillisFalse Input":
	@T23:55:25.966 same millisecond or before @T23:55:25.900
define "TimeSameOrBeforeMillisFalse Output":
	false

define "DateTimeSubtract5Years Input":
	DateTime(2005, 10, 10) - 5 years
define "DateTimeSubtract5Years Output":
	@2000-10-10T

define "DateTimeSubtractInvalidYears":
	DateTime(2005, 10, 10) - 2005 years

define "DateTimeSubtract5Months Input":
	DateTime(2005, 6, 10) - 5 months
define "DateTimeSubtract5Months Output":
	@2005-01-10T

define "DateTimeSubtractMonthsUnderflow Input":
	DateTime(2005, 5, 10) - 6 months
define "DateTimeSubtractMonthsUnderflow Output":
	@2004-11-10T

define "DateTimeSubtract5Days Input":
	DateTime(2005, 5, 10) - 5 days
define "DateTimeSubtract5Days Output":
	@2005-05-05T

define "DateTimeSubtractDaysUnderflow Input":
	DateTime(2016, 6, 10) - 11 days
define "DateTimeSubtractDaysUnderflow Output":
	@2016-05-30T

define "DateTimeSubtract5Hours Input":
	DateTime(2005, 5, 10, 10) - 5 hours
define "DateTimeSubtract5Hours Output":
	@2005-05-10T05

define "DateTimeSubtractHoursUnderflow Input":
	DateTime(2016, 6, 10, 5) - 6 hours
define "DateTimeSubtractHoursUnderflow Output":
	@2016-06-09T23

define "DateTimeSubtract5Minutes Input":
	DateTime(2005, 5, 10, 5, 10) - 5 minutes
define "DateTimeSubtract5Minutes Output":
	@2005-05-10T05:05

define "DateTimeSubtractMinutesUnderflow Input":
	DateTime(2016, 6, 10, 5, 5) - 6 minutes
define "DateTimeSubtractMinutesUnderflow Output":
	@2016-06-10T04:59

define "DateTimeSubtract5Seconds Input":
	DateTime(2005, 5, 10, 5, 5, 10) - 5 seconds
define "DateTimeSubtract5Seconds Output":
	@2005-05-10T05:05:05

define "DateTimeSubtractSecondsUnderflow Input":
	DateTime(2016, 6, 10, 5, 5, 5) - 6 seconds
define "DateTimeSubtractSecondsUnderflow Output":
	@2016-06-10T05:04:59

define "DateTimeSubtract5Milliseconds Input":
	DateTime(2005, 5, 10, 5, 5, 5, 10) - 5 milliseconds
define "DateTimeSubtract5Milliseconds Output":
	@2005-05-10T05:05:05.005

define "DateTimeSubtractMillisecondsUnderflow Input":
	DateTime(2016, 6, 10, 5, 5, 5, 5) - 6 milliseconds
define "DateTimeSubtractMillisecondsUnderflow Output":
	@2016-06-10T05:05:04.999

define "DateTimeSubtract2YearsAsMonths Input":
	DateTime(2014) - 24 months
define "DateTimeSubtract2YearsAsMonths Output":
	@2012T

define "DateTimeSubtract2YearsAsMonthsRem1 Input":
	DateTime(2014) - 25 months
define "DateTimeSubtract2YearsAsMonthsRem1 Output":
	@2012T

define "TimeSubtract5Hours Input":
	@T15:59:59.999 - 5 hours
define "TimeSubtract5Hours Output":
	@T10:59:59.999

define "TimeSubtract1Minute Input":
	@T15:59:59.999 - 1 minutes
define "TimeSubtract1Minute Output":
	@T15:58:59.999

define "TimeSubtract1Second Input":
	@T15:59:59.999 - 1 seconds
define "TimeSubtract1Second Output":
	@T15:59:58.999

define "TimeSubtract1Millisecond Input":
	@T15:59:59.0 - 1 milliseconds
define "TimeSubtract1Millisecond Output":
	@T15:59:58.999

define "TimeSubtract5Hours1Minute Input":
	@T15:59:59.999 - 5 hours - 1 minutes
define "TimeSubtract5Hours1Minute Output":
	@T10:58:59.999

define "TimeSubtract5hoursByMinute Input":
	@T15:59:59.999 - 300 minutes
define "TimeSubtract5hoursByMinute Output":
	@T10:59:59.999

define "TimeTest2 Input":
	@T23:59:59.999
define "TimeTest2 Output":
	@T23:59:59.999

define "TimeOfDayTest Input":
	TimeOfDay()
define "TimeOfDayTest Output":
	TimeOfDay()

define "DateTimeSameOrBeforeTodayTrue1 Input":
	Today() same day or before Today()
define "DateTimeSameOrBeforeTodayTrue1 Output":
	true

define "DateTimeSameOrBeforeTodayTrue2 Input":
	Today() same day or before Today() + 1 days
define "DateTimeSameOrBeforeTodayTrue2 Output":
	true

define "DateTimeSameOrBeforeTodayFalse Input":
	Today() + 1 years same day or before Today()
define "DateTimeSameOrBeforeTodayFalse Output":
	false

define "DateTimeAddTodayTrue Input":
	Today() + 1 days > Today()
define "DateTimeAddTodayTrue Output":
	true

define "Issue34B Input":
	Today()
define "Issue34B Output":
	Today()
