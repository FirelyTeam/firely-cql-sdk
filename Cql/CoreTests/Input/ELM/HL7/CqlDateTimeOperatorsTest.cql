library CqlDateTimeOperatorsTest version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

context Patient

define "DateTimeAdd5Years":
  DateTime(2005, 10, 10)+ 5 years = @2010-10-10

define "DateTimeAddInvalidYears":
  DateTime(2005, 10, 10)+ 8000 years

define "DateTimeAdd5Months":
  DateTime(2005, 5, 10)+ 5 months = @2005-10-10

define "DateTimeAddMonthsOverflow":
  DateTime(2005, 5, 10)+ 10 months = @2006-03-10

define "DateTimeAdd5Days":
  DateTime(2005, 5, 10)+ 5 days = @2005-05-15

define "DateTimeAddDaysOverflow":
  DateTime(2016, 6, 10)+ 21 days = @2016-07-01

define "DateTimeAdd5Hours":
  DateTime(2005, 5, 10, 5)+ 5 hours = @2005-05-10T10

define "DateTimeAddHoursOverflow":
  DateTime(2016, 6, 10, 5)+ 19 hours = @2016-06-11T00

define "DateTimeAdd5Minutes":
  DateTime(2005, 5, 10, 5, 5)+ 5 minutes = @2005-05-10T05:10

define "DateTimeAddMinutesOverflow":
  DateTime(2016, 6, 10, 5, 5)+ 55 minutes = @2016-06-10T06:00

define "DateTimeAdd5Seconds":
  DateTime(2005, 5, 10, 5, 5, 5)+ 5 seconds = @2005-05-10T05:05:10

define "DateTimeAddSecondsOverflow":
  DateTime(2016, 6, 10, 5, 5, 5)+ 55 seconds = @2016-06-10T05:06:00

define "DateTimeAdd5Milliseconds":
  DateTime(2005, 5, 10, 5, 5, 5, 5)+ 5 milliseconds = @2005-05-10T05:05:05.010

define "DateTimeAddMillisecondsOverflow":
  DateTime(2016, 6, 10, 5, 5, 5, 5)+ 995 milliseconds = @2016-06-10T05:05:06.000

define "DateTimeAddLeapYear":
  DateTime(2012, 2, 29)+ 1 year = @2013-02-28

define "DateTimeAdd2YearsByMonths":
  DateTime(2014)+ 24 months = @2016

define "DateTimeAdd2YearsByDays":
  DateTime(2014)+ 730 days = @2016

define "DateTimeAdd2YearsByDaysRem5Days":
  DateTime(2014)+ 735 days = @2016

define "TimeAdd5Hours":
  @T15:59:59.999 + 5 hours = @T20:59:59.999

define "TimeAdd1Minute":
  @T15:59:59.999 + 1 minute = @T16:00:59.999

define "TimeAdd1Second":
  @T15:59:59.999 + 1 seconds = @T16:00:00.999

define "TimeAdd1Millisecond":
  @T15:59:59.999 + 1 milliseconds = @T16:00:00.000

define "TimeAdd5Hours1Minute":
  @T15:59:59.999 + 5 hours + 1 minutes = @T21:00:59.999

define "TimeAdd5hoursByMinute":
  @T15:59:59.999 + 300 minutes = @T20:59:59.999

define "DateTimeAfterYearTrue":
  DateTime(2005, 10, 10)after year of DateTime(2004, 10, 10)= true

define "DateTimeAfterYearFalse":
  DateTime(2004, 11, 10)after year of DateTime(2004, 10, 10)= false

define "DateTimeAfterMonthTrue":
  DateTime(2004, 12, 10)after month of DateTime(2004, 11, 10)= true

define "DateTimeAfterMonthFalse":
  DateTime(2004, 9, 10)after month of DateTime(2004, 10, 10)= false

define "DateTimeAfterDayTrue":
  DateTime(2004, 12, 11)after day of DateTime(2004, 10, 10)= true

define "DateTimeAfterDayTrue2":
  DateTime(2004, 12, 09)after day of DateTime(2003, 10, 10)= true

define "DateTimeAfterDayFalse":
  DateTime(2004, 10, 9)after day of DateTime(2004, 10, 10)= false

define "DateTimeAfterHourTrue":
  DateTime(2004, 10, 10, 10)after hour of DateTime(2004, 10, 10, 5)= true

define "DateTimeAfterHourFalse":
  DateTime(2004, 10, 10, 20)after hour of DateTime(2004, 10, 10, 21)= false

define "DateTimeAfterMinuteTrue":
  DateTime(2004, 10, 10, 20, 30)after minute of DateTime(2004, 10, 10, 20, 29)= true

define "DateTimeAfterMinuteFalse":
  DateTime(2004, 10, 10, 20, 30)after minute of DateTime(2004, 10, 10, 20, 31)= false

define "DateTimeAfterSecondTrue":
  DateTime(2004, 10, 10, 20, 30, 15)after second of DateTime(2004, 10, 10, 20, 30, 14)= true

define "DateTimeAfterSecondFalse":
  DateTime(2004, 10, 10, 20, 30, 15)after second of DateTime(2004, 10, 10, 20, 30, 16)= false

define "DateTimeAfterMillisecondTrue":
  DateTime(2004, 10, 10, 20, 30, 15, 512)after millisecond of DateTime(2004, 10, 10, 20, 30, 15, 510)= true

define "DateTimeAfterMillisecondFalse":
  DateTime(2004, 10, 10, 20, 30, 15, 512)after millisecond of DateTime(2004, 10, 10, 20, 30, 15, 513)= false

define "DateTimeAfterUncertain":
  DateTime(2005, 10, 10)after day of DateTime(2005, 9)= true

define "AfterTimezoneTrue":
  @2012-03-10T10:20:00.999+07:00 after hour of @2012-03-10T08:20:00.999+06:00 = true

define "AfterTimezoneFalse":
  @2012-03-10T10:20:00.999+07:00 after hour of @2012-03-10T10:20:00.999+06:00 = false

define "TimeAfterHourTrue":
  @T15:59:59.999 after hour of @T14:59:59.999 = true

define "TimeAfterHourFalse":
  @T15:59:59.999 after hour of @T16:59:59.999 = false

define "TimeAfterMinuteTrue":
  @T15:59:59.999 after minute of @T15:58:59.999 = true

define "TimeAfterMinuteFalse":
  @T15:58:59.999 after minute of @T15:59:59.999 = false

define "TimeAfterSecondTrue":
  @T15:59:59.999 after second of @T15:59:58.999 = true

define "TimeAfterSecondFalse":
  @T15:59:58.999 after second of @T15:59:59.999 = false

define "TimeAfterMillisecondTrue":
  @T15:59:59.999 after millisecond of @T15:59:59.998 = true

define "TimeAfterMillisecondFalse":
  @T15:59:59.998 after millisecond of @T15:59:59.999 = false

define "TimeAfterTimeCstor":
  Time(12, 30)after hour of Time(11, 55)= true

define "DateTimeBeforeYearTrue":
  DateTime(2003)before year of DateTime(2004, 10, 10)= true

define "DateTimeBeforeYearFalse":
  DateTime(2004, 11, 10)before year of DateTime(2003, 10, 10)= false

define "DateTimeBeforeMonthTrue":
  DateTime(2004, 10, 10)before month of DateTime(2004, 11, 10)= true

define "DateTimeBeforeMonthFalse":
  DateTime(2004, 11, 10)before month of DateTime(2004, 10, 10)= false

define "DateTimeBeforeDayTrue":
  DateTime(2004, 10, 1)before day of DateTime(2004, 10, 10)= true

define "DateTimeBeforeDayTrue2":
  DateTime(2003, 10, 11)before day of DateTime(2004, 10, 10)= true

define "DateTimeBeforeDayFalse":
  DateTime(2004, 10, 11)before day of DateTime(2004, 10, 10)= false

define "DateTimeBeforeHourTrue":
  DateTime(2004, 10, 10, 1)before hour of DateTime(2004, 10, 10, 5)= true

define "DateTimeBeforeHourFalse":
  DateTime(2004, 10, 10, 23)before hour of DateTime(2004, 10, 10, 21)= false

define "DateTimeBeforeMinuteTrue":
  DateTime(2004, 10, 10, 20, 28)before minute of DateTime(2004, 10, 10, 20, 29)= true

define "DateTimeBeforeMinuteFalse":
  DateTime(2004, 10, 10, 20, 35)before minute of DateTime(2004, 10, 10, 20, 31)= false

define "DateTimeBeforeSecondTrue":
  DateTime(2004, 10, 10, 20, 30, 12)before second of DateTime(2004, 10, 10, 20, 30, 14)= true

define "DateTimeBeforeSecondFalse":
  DateTime(2004, 10, 10, 20, 30, 55)before second of DateTime(2004, 10, 10, 20, 30, 16)= false

define "DateTimeBeforeMillisecondTrue":
  DateTime(2004, 10, 10, 20, 30, 15, 508)before millisecond of DateTime(2004, 10, 10, 20, 30, 15, 510)= true

define "DateTimeBeforeMillisecondFalse":
  DateTime(2004, 10, 10, 20, 30, 15, 599)before millisecond of DateTime(2004, 10, 10, 20, 30, 15, 513)= false

define "BeforeTimezoneTrue":
  @2012-03-10T10:20:00.999+07:00 before hour of @2012-03-10T10:20:00.999+06:00 = true

define "BeforeTimezoneFalse":
  @2012-03-10T10:20:00.999+07:00 before hour of @2012-03-10T09:20:00.999+06:00 = false

define "TimeBeforeHourTrue":
  @T13:59:59.999 before hour of @T14:59:59.999 = true

define "TimeBeforeHourFalse":
  @T16:59:59.999 before hour of @T15:59:59.999 = false

define "TimeBeforeMinuteTrue":
  @T15:57:59.999 before minute of @T15:58:59.999 = true

define "TimeBeforeMinuteFalse":
  @T15:59:59.999 before minute of @T15:59:59.999 = false

define "TimeBeforeSecondTrue":
  @T15:59:57.999 before second of @T15:59:58.999 = true

define "TimeBeforeSecondFalse":
  @T15:59:56.999 before second of @T15:59:55.999 = false

define "TimeBeforeMillisecondTrue":
  @T15:59:59.997 before millisecond of @T15:59:59.998 = true

define "TimeBeforeMillisecondFalse":
  @T15:59:59.998 before millisecond of @T15:59:59.997 = false

define "DateTimeYear":
  DateTime(2003)= @2003

define "DateTimeMonth":
  DateTime(2003, 10)= @2003-10

define "DateTimeDay":
  DateTime(2003, 10, 29)= @2003-10-29

define "DateTimeHour":
  DateTime(2003, 10, 29, 20)= @2003-10-29T20

define "DateTimeMinute":
  DateTime(2003, 10, 29, 20, 50)= @2003-10-29T20:50

define "DateTimeSecond":
  DateTime(2003, 10, 29, 20, 50, 33)= @2003-10-29T20:50:33

define "DateTimeMillisecond":
  DateTime(2003, 10, 29, 20, 50, 33, 955)= @2003-10-29T20:50:33.955

define "DateTimeComponentFromYear":
  year from DateTime(2003, 10, 29, 20, 50, 33, 955)= 2003

define "DateTimeComponentFromMonth":
  month from DateTime(2003, 10, 29, 20, 50, 33, 955)= 10

define "DateTimeComponentFromMonthMinBoundary":
  month from DateTime(2003, 01, 29, 20, 50, 33, 955)= 1

define "DateTimeComponentFromDay":
  day from DateTime(2003, 10, 29, 20, 50, 33, 955)= 29

define "DateTimeComponentFromHour":
  hour from DateTime(2003, 10, 29, 20, 50, 33, 955)= 20

define "DateTimeComponentFromMinute":
  minute from DateTime(2003, 10, 29, 20, 50, 33, 955)= 50

define "DateTimeComponentFromSecond":
  second from DateTime(2003, 10, 29, 20, 50, 33, 955)= 33

define "DateTimeComponentFromMillisecond":
  millisecond from DateTime(2003, 10, 29, 20, 50, 33, 955)= 955

define "DateTimeComponentFromDate":
  date from DateTime(2003, 10, 29, 20, 50, 33, 955, 1)= @2003-10-29

define "TimeComponentFromHour":
  hour from @T23:20:15.555 = 23

define "TimeComponentFromMinute":
  minute from @T23:20:15.555 = 20

define "TimeComponentFromSecond":
  second from @T23:20:15.555 = 15

define "TimeComponentFromMilli":
  millisecond from @T23:20:15.555 = 555

define "DateTimeDifferenceYear":
  difference in years between DateTime(2000)and DateTime(2005, 12)= 5

define "DateTimeDifferenceMonth":
  difference in months between DateTime(2000, 2)and DateTime(2000, 10)= 8

define "DateTimeDifferenceDay":
  difference in days between DateTime(2000, 10, 15, 10, 30)and DateTime(2000, 10, 25, 10, 0)= 10

define "DateTimeDifferenceHour":
  difference in hours between DateTime(2000, 4, 1, 12)and DateTime(2000, 4, 1, 20)= 8

define "DateTimeDifferenceMinute":
  difference in minutes between DateTime(2005, 12, 10, 5, 16)and DateTime(2005, 12, 10, 5, 25)= 9

define "DateTimeDifferenceSecond":
  difference in seconds between DateTime(2000, 10, 10, 10, 5, 45)and DateTime(2000, 10, 10, 10, 5, 50)= 5

define "DateTimeDifferenceMillisecond":
  difference in milliseconds between DateTime(2000, 10, 10, 10, 5, 45, 500, - 6.0)and DateTime(2000, 10, 10, 10, 5, 45, 900, - 7.0)= 3600400

define "DateTimeDifferenceWeeks":
  difference in weeks between DateTime(2000, 10, 15)and DateTime(2000, 10, 28)= 1

define "DateTimeDifferenceWeeks2":
  difference in weeks between DateTime(2000, 10, 15)and DateTime(2000, 10, 29)= 2

define "DateTimeDifferenceWeeks3":
  difference in weeks between @2012-03-10T22:05:09 and @2012-03-24T07:19:33 = 2

define "DateTimeDifferenceNegative":
  difference in years between DateTime(2016)and DateTime(1998)= - 18

define "DateTimeDifferenceUncertain":
  difference in months between DateTime(2005)and DateTime(2006, 7)> 5 = true

define "TimeDifferenceHour":
  difference in hours between @T20 and @T23:25:15.555 = 3

define "TimeDifferenceMinute":
  difference in minutes between @T20:20:15.555 and @T20:25:15.555 = 5

define "TimeDifferenceSecond":
  difference in seconds between @T20:20:15.555 and @T20:20:20.555 = 5

define "TimeDifferenceMillis":
  difference in milliseconds between @T20:20:15.555 and @T20:20:15.550 = - 5

define "DateTimeA":
  @2017-03-12T01:00:00-07:00 = @2017-03-12T01:00:00

define "DateTimeAA":
  DateTime(2017, 3, 12, 1, 0, 0, 0, - 7.0)= @2017-03-12T01:00:00.000

define "DateTimeB":
  @2017-03-12T03:00:00-06:00 = @2017-03-12T03:00:00

define "DateTimeBB":
  DateTime(2017, 3, 12, 3, 0, 0, 0, - 6.0)= @2017-03-12T03:00:00.000

define "DateTimeC":
  @2017-11-05T01:30:00-06:00 = @2017-11-05T01:30:00

define "DateTimeCC":
  DateTime(2017, 11, 5, 1, 30, 0, 0, - 6.0)= @2017-11-05T01:30:00.000

define "DateTimeD":
  @2017-11-05T01:15:00-07:00 = @2017-11-05T01:15:00

define "DateTimeDD":
  DateTime(2017, 11, 5, 1, 15, 0, 0, - 7.0)= @2017-11-05T01:15:00.000

define "DateTimeE":
  @2017-03-12T00:00:00-07:00 = @2017-03-12T00:00:00

define "DateTimeEE":
  DateTime(2017, 3, 12, 0, 0, 0, 0, - 7.0)= @2017-03-12T00:00:00.000

define "DateTimeF":
  @2017-03-13T00:00:00-06:00 = @2017-03-13T00:00:00

define "DateTimeFF":
  DateTime(2017, 3, 13, 0, 0, 0, 0, - 6.0)= @2017-03-13T00:00:00.000

define "DifferenceInHoursA":
  difference in hours between @2017-03-12T01:00:00-07:00 and @2017-03-12T03:00:00-06:00 = 1

define "DifferenceInMinutesA":
  difference in minutes between @2017-11-05T01:30:00-06:00 and @2017-11-05T01:15:00-07:00 = 45

define "DifferenceInDaysA":
  difference in days between @2017-03-12T00:00:00-07:00 and @2017-03-13T00:00:00-06:00 = 1

define "DifferenceInHoursAA":
  difference in hours between DateTime(2017, 3, 12, 1, 0, 0, 0, - 7.0)and DateTime(2017, 3, 12, 3, 0, 0, 0, - 6.0)= 1

define "DifferenceInMinutesAA":
  difference in minutes between DateTime(2017, 11, 5, 1, 30, 0, 0, - 6.0)and DateTime(2017, 11, 5, 1, 15, 0, 0, - 7.0)= 45

define "DifferenceInDaysAA":
  difference in days between DateTime(2017, 3, 12, 0, 0, 0, 0, - 7.0)and DateTime(2017, 3, 13, 0, 0, 0, 0, - 6.0)= 1

define "DateTimeDurationBetweenYear":
  years between DateTime(2005)and DateTime(2010)= 5

define "DateTimeDurationBetweenYearOffset":
  years between DateTime(2005, 5)and DateTime(2010, 4)= 4

define "DateTimeDurationBetweenMonth":
  months between @2014-01-31 and @2014-02-01 = 0

define "DateTimeDurationBetweenDaysDiffYears":
  days between DateTime(2010, 10, 12, 12, 5)and DateTime(2008, 8, 15, 8, 8)= - 788

define "DateTimeDurationBetweenUncertainInterval":
  days between DateTime(2014, 1, 15)and DateTime(2014, 2)= 27

define "DateTimeDurationBetweenUncertainInterval2":
  months between DateTime(2005)and DateTime(2006, 5)= 11

define "DateTimeDurationBetweenUncertainAdd":
  ( days between DateTime(2014, 1, 15)and DateTime(2014, 2)) + ( days between DateTime(2014, 1, 15)and DateTime(2014, 2)) = 54

define "DateTimeDurationBetweenUncertainSubtract":
  ( days between DateTime(2014, 1, 15)and DateTime(2014, 2)) - ( months between DateTime(2005)and DateTime(2006, 5)) = 16

define "DateTimeDurationBetweenUncertainMultiply":
  ( days between DateTime(2014, 1, 15)and DateTime(2014, 2)) * ( days between DateTime(2014, 1, 15)and DateTime(2014, 2)) = 1647

define "DateTimeDurationBetweenUncertainDiv":
  ( days between DateTime(2014, 1, 15)and DateTime(2014, 2)) div ( months between DateTime(2005)and DateTime(2006, 5))

define "DateTimeDurationBetweenMonthUncertain":
  months between DateTime(2005)and DateTime(2006, 7)> 5 = true

define "DateTimeDurationBetweenMonthUncertain2":
  months between DateTime(2005)and DateTime(2006, 2)> 5 = null

define "DateTimeDurationBetweenMonthUncertain3":
  months between DateTime(2005)and DateTime(2006, 7)> 25 = false

define "DateTimeDurationBetweenMonthUncertain4":
  months between DateTime(2005)and DateTime(2006, 7)< 24 = true

define "DateTimeDurationBetweenMonthUncertain5":
  months between DateTime(2005)and DateTime(2006, 7)= 24 = false

define "DateTimeDurationBetweenMonthUncertain6":
  months between DateTime(2005)and DateTime(2006, 7)>= 5 = true

define "DateTimeDurationBetweenMonthUncertain7":
  months between DateTime(2005)and DateTime(2006, 7)<= 24 = true

define "DateTime1":
  @2012-03-10T10:20:00 = @2012-03-10T10:20:00

define "DateTime2":
  @2013-03-10T09:20:00 = @2013-03-10T09:20:00

define "DurationInYears":
  years between ( date from @2012-03-10T10:20:00 ) and ( date from @2013-03-10T09:20:00 ) = 1

define "DurationInWeeks":
  weeks between @2012-03-10T22:05:09 and @2012-03-20T07:19:33 = 1

define "DurationInWeeks2":
  weeks between @2012-03-10T22:05:09 and @2012-03-24T07:19:33 = 1

define "DurationInWeeks3":
  weeks between @2012-03-10T06:05:09 and @2012-03-24T07:19:33 = 2

define "TimeDurationBetweenHour":
  hours between @T20:26:15.555 and @T23:25:15.555 = 2

define "TimeDurationBetweenHourDiffPrecision":
  hours between @T06 and @T07:00:00 = 1

define "TimeDurationBetweenMinute":
  minutes between @T23:20:16.555 and @T23:25:15.555 = 4

define "TimeDurationBetweenSecond":
  seconds between @T23:25:10.556 and @T23:25:15.555 = 4

define "TimeDurationBetweenMillis":
  milliseconds between @T23:25:25.555 and @T23:25:25.560 = 5

define "DurationInHoursA":
  hours between @2017-03-12T01:00:00-07:00 and @2017-03-12T03:00:00-06:00 = 1

define "DurationInMinutesA":
  minutes between @2017-11-05T01:30:00-06:00 and @2017-11-05T01:15:00-07:00 = 45

define "DurationInDaysA":
  days between @2017-03-12T00:00:00-07:00 and @2017-03-13T00:00:00-06:00 = 0

define "DurationInHoursAA":
  hours between DateTime(2017, 3, 12, 1, 0, 0, 0, - 7.0)and DateTime(2017, 3, 12, 3, 0, 0, 0, - 6.0)= 1

define "DurationInMinutesAA":
  minutes between DateTime(2017, 11, 5, 1, 30, 0, 0, - 6.0)and DateTime(2017, 11, 5, 1, 15, 0, 0, - 7.0)= 45

define "DurationInDaysAA":
  days between DateTime(2017, 3, 12, 0, 0, 0, 0, - 7.0)and DateTime(2017, 3, 13, 0, 0, 0, 0, - 6.0)= 0

define "DateTimeNow":
  Now()= Now()= true

define "DateTimeSameAsYearTrue":
  DateTime(2014)same year as DateTime(2014)= true

define "DateTimeSameAsYearFalse":
  DateTime(2013)same year as DateTime(2014)= false

define "DateTimeSameAsMonthTrue":
  DateTime(2014, 12)same month as DateTime(2014, 12)= true

define "DateTimeSameAsMonthFalse":
  DateTime(2014, 12)same month as DateTime(2014, 10)= false

define "DateTimeSameAsDayTrue":
  DateTime(2014, 12, 10)same day as DateTime(2014, 12, 10)= true

define "DateTimeSameAsDayFalse":
  DateTime(2014, 10, 10)same day as DateTime(2014, 10, 11)= false

define "DateTimeSameAsHourTrue":
  DateTime(2014, 12, 10, 20)same hour as DateTime(2014, 12, 10, 20)= true

define "DateTimeSameAsHourFalse":
  DateTime(2014, 10, 10, 20)same hour as DateTime(2014, 10, 10, 21)= false

define "DateTimeSameAsMinuteTrue":
  DateTime(2014, 12, 10, 20, 55)same minute as DateTime(2014, 12, 10, 20, 55)= true

define "DateTimeSameAsMinuteFalse":
  DateTime(2014, 10, 10, 20, 55)same minute as DateTime(2014, 10, 10, 21, 56)= false

define "DateTimeSameAsSecondTrue":
  DateTime(2014, 12, 10, 20, 55, 45)same second as DateTime(2014, 12, 10, 20, 55, 45)= true

define "DateTimeSameAsSecondFalse":
  DateTime(2014, 10, 10, 20, 55, 45)same second as DateTime(2014, 10, 10, 21, 55, 44)= false

define "DateTimeSameAsMillisecondTrue":
  DateTime(2014, 12, 10, 20, 55, 45, 500)same millisecond as DateTime(2014, 12, 10, 20, 55, 45, 500)= true

define "DateTimeSameAsMillisecondFalse":
  DateTime(2014, 10, 10, 20, 55, 45, 500)same millisecond as DateTime(2014, 10, 10, 21, 55, 45, 501)= false

define "DateTimeSameAsNull":
  DateTime(2014, 10)same day as DateTime(2014, 10, 12)= null

define "SameAsTimezoneTrue":
  @2012-03-10T10:20:00.999+07:00 same hour as @2012-03-10T09:20:00.999+06:00 = true

define "SameAsTimezoneFalse":
  @2012-03-10T10:20:00.999+07:00 same hour as @2012-03-10T10:20:00.999+06:00 = false

define "TimeSameAsHourTrue":
  @T23:25:25.555 same hour as @T23:55:25.900 = true

define "TimeSameAsHourFalse":
  @T22:25:25.555 same hour as @T23:25:25.555 = false

define "TimeSameAsMinuteTrue":
  @T23:55:22.555 same minute as @T23:55:25.900 = true

define "TimeSameAsMinuteFalse":
  @T23:26:25.555 same minute as @T23:25:25.555 = false

define "TimeSameAsSecondTrue":
  @T23:55:25.555 same second as @T23:55:25.900 = true

define "TimeSameAsSecondFalse":
  @T23:25:35.555 same second as @T23:25:25.555 = false

define "TimeSameAsMillisTrue":
  @T23:55:25.555 same millisecond as @T23:55:25.555 = true

define "TimeSameAsMillisFalse":
  @T23:25:25.555 same millisecond as @T23:25:25.554 = false

define "DateTimeSameOrAfterYearTrue1":
  DateTime(2014)same year or after DateTime(2014)= true

define "DateTimeSameOrAfterYearTrue2":
  DateTime(2016)same year or after DateTime(2014)= true

define "DateTimeSameOrAfterYearFalse":
  DateTime(2013)same year or after DateTime(2014)= false

define "DateTimeSameOrAfterMonthTrue1":
  DateTime(2014, 12)same month or after DateTime(2014, 12)= true

define "DateTimeSameOrAfterMonthTrue2":
  DateTime(2014, 10)same month or after DateTime(2014, 9)= true

define "DateTimeSameOrAfterMonthFalse":
  DateTime(2014, 10)same month or after DateTime(2014, 11)= false

define "DateTimeSameOrAfterDayTrue1":
  DateTime(2014, 12, 20)same day or after DateTime(2014, 12, 20)= true

define "DateTimeSameOrAfterDayTrue2":
  DateTime(2014, 10, 25)same day or after DateTime(2014, 10, 20)= true

define "DateTimeSameOrAfterDayFalse":
  DateTime(2014, 10, 20)same day or after DateTime(2014, 10, 25)= false

define "DateTimeSameOrAfterHourTrue1":
  DateTime(2014, 12, 20, 12)same hour or after DateTime(2014, 12, 20, 12)= true

define "DateTimeSameOrAfterHourTrue2":
  DateTime(2014, 10, 25, 12)same hour or after DateTime(2014, 10, 25, 10)= true

define "DateTimeSameOrAfterHourFalse":
  DateTime(2014, 10, 25, 12)same hour or after DateTime(2014, 10, 25, 15)= false

define "DateTimeSameOrAfterMinuteTrue1":
  DateTime(2014, 12, 20, 12, 30)same minute or after DateTime(2014, 12, 20, 12, 30)= true

define "DateTimeSameOrAfterMinuteTrue2":
  DateTime(2014, 10, 25, 10, 30)same minute or after DateTime(2014, 10, 25, 10, 25)= true

define "DateTimeSameOrAfterMinuteFalse":
  DateTime(2014, 10, 25, 15, 30)same minute or after DateTime(2014, 10, 25, 15, 45)= false

define "DateTimeSameOrAfterSecondTrue1":
  DateTime(2014, 12, 20, 12, 30, 15)same second or after DateTime(2014, 12, 20, 12, 30, 15)= true

define "DateTimeSameOrAfterSecondTrue2":
  DateTime(2014, 10, 25, 10, 25, 25)same second or after DateTime(2014, 10, 25, 10, 25, 20)= true

define "DateTimeSameOrAfterSecondFalse":
  DateTime(2014, 10, 25, 15, 45, 20)same second or after DateTime(2014, 10, 25, 15, 45, 21)= false

define "DateTimeSameOrAfterMillisecondTrue1":
  DateTime(2014, 12, 20, 12, 30, 15, 250)same millisecond or after DateTime(2014, 12, 20, 12, 30, 15, 250)= true

define "DateTimeSameOrAfterMillisecondTrue2":
  DateTime(2014, 10, 25, 10, 25, 20, 500)same millisecond or after DateTime(2014, 10, 25, 10, 25, 20, 499)= true

define "DateTimeSameOrAfterMillisecondFalse":
  DateTime(2014, 10, 25, 15, 45, 20, 500)same millisecond or after DateTime(2014, 10, 25, 15, 45, 20, 501)= false

define "DateTimeSameOrAfterNull1":
  DateTime(2014, 12, 20)same day or after DateTime(2014, 12)= null

define "SameOrAfterTimezoneTrue":
  @2012-03-10T10:20:00.999+07:00 same hour or after @2012-03-10T09:20:00.999+06:00 = true

define "SameOrAfterTimezoneFalse":
  @2012-03-10T10:20:00.999+07:00 same hour or after @2012-03-10T10:20:00.999+06:00 = false

define "TimeSameOrAfterHourTrue1":
  @T23:25:25.555 same hour or after @T23:55:25.900 = true

define "TimeSameOrAfterHourTrue2":
  @T23:25:25.555 same hour or after @T22:55:25.900 = true

define "TimeSameOrAfterHourFalse":
  @T22:25:25.555 same hour or after @T23:55:25.900 = false

define "TimeSameOrAfterMinuteTrue1":
  @T23:25:25.555 same minute or after @T23:25:25.900 = true

define "TimeSameOrAfterMinuteTrue2":
  @T23:25:25.555 same minute or after @T22:15:25.900 = true

define "TimeSameOrAfterMinuteFalse":
  @T23:25:25.555 same minute or after @T23:55:25.900 = false

define "TimeSameOrAfterSecondTrue1":
  @T23:25:25.555 same second or after @T23:25:25.900 = true

define "TimeSameOrAfterSecondTrue2":
  @T23:25:35.555 same second or after @T22:25:25.900 = true

define "TimeSameOrAfterSecondFalse":
  @T23:55:25.555 same second or after @T23:55:35.900 = false

define "TimeSameOrAfterMillisTrue1":
  @T23:25:25.555 same millisecond or after @T23:25:25.555 = true

define "TimeSameOrAfterMillisTrue2":
  @T23:25:25.555 same millisecond or after @T22:25:25.550 = true

define "TimeSameOrAfterMillisFalse":
  @T23:55:25.555 same millisecond or after @T23:55:25.900 = false

define "OnOrAfterTrue":
  @2017-12-20T11:00:00.000 on or after @2017-12-20T11:00:00.000 = true

define "Issue32DateTime":
  @2017-12-21T02:00:00.0 same or after @2017-12-20T11:00:00.0 = true

define "DateTimeSameOrBeforeYearTrue1":
  DateTime(2014)same year or before DateTime(2014)= true

define "DateTimeSameOrBeforeYearTrue2":
  DateTime(2013)same year or before DateTime(2014)= true

define "DateTimeSameOrBeforeYearFalse":
  DateTime(2015)same year or before DateTime(2014)= false

define "DateTimeSameOrBeforeMonthTrue1":
  DateTime(2014, 12)same month or before DateTime(2014, 12)= true

define "DateTimeSameOrBeforeMonthTrue2":
  DateTime(2014, 8)same month or before DateTime(2014, 9)= true

define "DateTimeSameOrBeforeMonthFalse":
  DateTime(2014, 12)same month or before DateTime(2014, 11)= false

define "DateTimeSameOrBeforeDayTrue1":
  DateTime(2014, 12, 20)same day or before DateTime(2014, 12, 20)= true

define "DateTimeSameOrBeforeDayTrue2":
  DateTime(2014, 10, 15)same day or before DateTime(2014, 10, 20)= true

define "DateTimeSameOrBeforeDayFalse":
  DateTime(2014, 10, 30)same day or before DateTime(2014, 10, 25)= false

define "DateTimeSameOrBeforeHourTrue1":
  DateTime(2014, 12, 20, 12)same hour or before DateTime(2014, 12, 20, 12)= true

define "DateTimeSameOrBeforeHourTrue2":
  DateTime(2014, 10, 25, 5)same hour or before DateTime(2014, 10, 25, 10)= true

define "DateTimeSameOrBeforeHourFalse":
  DateTime(2014, 10, 25, 20)same hour or before DateTime(2014, 10, 25, 15)= false

define "DateTimeSameOrBeforeMinuteTrue1":
  DateTime(2014, 12, 20, 12, 30)same minute or before DateTime(2014, 12, 20, 12, 30)= true

define "DateTimeSameOrBeforeMinuteTrue2":
  DateTime(2014, 10, 25, 10, 20)same minute or before DateTime(2014, 10, 25, 10, 25)= true

define "DateTimeSameOrBeforeMinuteFalse":
  DateTime(2014, 10, 25, 15, 55)same minute or before DateTime(2014, 10, 25, 15, 45)= false

define "DateTimeSameOrBeforeSecondTrue1":
  DateTime(2014, 12, 20, 12, 30, 15)same second or before DateTime(2014, 12, 20, 12, 30, 15)= true

define "DateTimeSameOrBeforeSecondTrue2":
  DateTime(2014, 10, 25, 10, 25, 15)same second or before DateTime(2014, 10, 25, 10, 25, 20)= true

define "DateTimeSameOrBeforeSecondFalse":
  DateTime(2014, 10, 25, 15, 45, 25)same second or before DateTime(2014, 10, 25, 15, 45, 21)= false

define "DateTimeSameOrBeforeMillisecondTrue1":
  DateTime(2014, 12, 20, 12, 30, 15, 250)same millisecond or before DateTime(2014, 12, 20, 12, 30, 15, 250)= true

define "DateTimeSameOrBeforeMillisecondTrue2":
  DateTime(2014, 10, 25, 10, 25, 20, 450)same millisecond or before DateTime(2014, 10, 25, 10, 25, 20, 499)= true

define "DateTimeSameOrBeforeMillisecondFalse":
  DateTime(2014, 10, 25, 15, 45, 20, 505)same millisecond or before DateTime(2014, 10, 25, 15, 45, 20, 501)= false

define "DateTimeSameOrBeforeNull1":
  DateTime(2014, 12, 20)same minute or before DateTime(2014, 12, 20, 15)= null

define "SameOrBeforeTimezoneTrue":
  @2012-03-10T09:20:00.999+07:00 same hour or before @2012-03-10T10:20:00.999+06:00 = true

define "SameOrBeforeTimezoneFalse":
  @2012-03-10T10:20:00.999+06:00 same hour or before @2012-03-10T10:20:00.999+07:00 = false

define "TimeSameOrBeforeHourTrue1":
  @T23:25:25.555 same hour or before @T23:55:25.900 = true

define "TimeSameOrBeforeHourTrue2":
  @T21:25:25.555 same hour or before @T22:55:25.900 = true

define "TimeSameOrBeforeHourFalse":
  @T22:25:25.555 same hour or before @T21:55:25.900 = false

define "TimeSameOrBeforeMinuteTrue1":
  @T23:25:25.555 same minute or before @T23:25:25.900 = true

define "TimeSameOrBeforeMinuteFalse0":
  @T23:10:25.555 same minute or before @T22:15:25.900 = false

define "TimeSameOrBeforeMinuteFalse":
  @T23:56:25.555 same minute or before @T23:55:25.900 = false

define "TimeSameOrBeforeSecondTrue1":
  @T23:25:25.555 same second or before @T23:25:25.900 = true

define "TimeSameOrBeforeSecondFalse0":
  @T23:25:35.555 same second or before @T22:25:45.900 = false

define "TimeSameOrBeforeSecondFalse":
  @T23:55:45.555 same second or before @T23:55:35.900 = false

define "TimeSameOrBeforeMillisTrue1":
  @T23:25:25.555 same millisecond or before @T23:25:25.555 = true

define "TimeSameOrBeforeMillisFalse0":
  @T23:25:25.200 same millisecond or before @T22:25:25.550 = false

define "TimeSameOrBeforeMillisFalse":
  @T23:55:25.966 same millisecond or before @T23:55:25.900 = false

define "DateTimeSubtract5Years":
  DateTime(2005, 10, 10)- 5 years = @2000-10-10

define "DateTimeSubtractInvalidYears":
  DateTime(2005, 10, 10)- 2005 years

define "DateTimeSubtract5Months":
  DateTime(2005, 6, 10)- 5 months = @2005-01-10

define "DateTimeSubtractMonthsUnderflow":
  DateTime(2005, 5, 10)- 6 months = @2004-11-10

define "DateTimeSubtract5Days":
  DateTime(2005, 5, 10)- 5 days = @2005-05-05

define "DateTimeSubtractDaysUnderflow":
  DateTime(2016, 6, 10)- 11 days = @2016-05-30

define "DateTimeSubtract5Hours":
  DateTime(2005, 5, 10, 10)- 5 hours = @2005-05-10T05

define "DateTimeSubtractHoursUnderflow":
  DateTime(2016, 6, 10, 5)- 6 hours = @2016-06-09T23

define "DateTimeSubtract5Minutes":
  DateTime(2005, 5, 10, 5, 10)- 5 minutes = @2005-05-10T05:05

define "DateTimeSubtractMinutesUnderflow":
  DateTime(2016, 6, 10, 5, 5)- 6 minutes = @2016-06-10T04:59

define "DateTimeSubtract5Seconds":
  DateTime(2005, 5, 10, 5, 5, 10)- 5 seconds = @2005-05-10T05:05:05

define "DateTimeSubtractSecondsUnderflow":
  DateTime(2016, 6, 10, 5, 5, 5)- 6 seconds = @2016-06-10T05:04:59

define "DateTimeSubtract5Milliseconds":
  DateTime(2005, 5, 10, 5, 5, 5, 10)- 5 milliseconds = @2005-05-10T05:05:05.005

define "DateTimeSubtractMillisecondsUnderflow":
  DateTime(2016, 6, 10, 5, 5, 5, 5)- 6 milliseconds = @2016-06-10T05:05:04.999

define "DateTimeSubtract2YearsAsMonths":
  DateTime(2014)- 24 months = @2012

define "DateTimeSubtract2YearsAsMonthsRem1":
  DateTime(2014)- 25 months = @2011

define "TimeSubtract5Hours":
  @T15:59:59.999 - 5 hours = @T10:59:59.999

define "TimeSubtract1Minute":
  @T15:59:59.999 - 1 minutes = @T15:58:59.999

define "TimeSubtract1Second":
  @T15:59:59.999 - 1 seconds = @T15:59:58.999

define "TimeSubtract1Millisecond":
  @T15:59:59.0 - 1 milliseconds = @T15:59:58.999

define "TimeSubtract5Hours1Minute":
  @T15:59:59.999 - 5 hours - 1 minutes = @T10:58:59.999

define "TimeSubtract5hoursByMinute":
  @T15:59:59.999 - 300 minutes = @T10:59:59.999

define "TimeTest2":
  @T23:59:59.999 = @T23:59:59.999

define "TimeOfDayTest":
  TimeOfDay()= TimeOfDay()

define "DateTimeSameOrBeforeTodayTrue1":
  Today()same day or before Today()= true

define "DateTimeSameOrBeforeTodayTrue2":
  Today()same day or before Today()+ 1 days = true

define "DateTimeSameOrBeforeTodayFalse":
  Today()+ 1 years same day or before Today()= false

define "DateTimeAddTodayTrue":
  Today()+ 1 days > Today()= true

define "Issue34B":
  Today()= Today()