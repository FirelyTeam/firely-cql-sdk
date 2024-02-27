library CqlIntervalOperatorsTest

context Unfiltered


define "TestAfterNull Input":
	(null as Integer) after Interval[1, 10]
define "TestAfterNull Output":
	null

define "IntegerIntervalAfterTrue Input":
	Interval[11, 20] after Interval[1, 10]
define "IntegerIntervalAfterTrue Output":
	true

define "IntegerIntervalAfterFalse Input":
	Interval[1, 10] after Interval[11, 20]
define "IntegerIntervalAfterFalse Output":
	false

define "IntegerIntervalPointAfterTrue Input":
	12 after Interval[1, 10]
define "IntegerIntervalPointAfterTrue Output":
	true

define "IntegerIntervalPointAfterFalse Input":
	9 after Interval[1, 10]
define "IntegerIntervalPointAfterFalse Output":
	false

define "IntegerIntervalAfterPointTrue Input":
	Interval[11, 20] after 5
define "IntegerIntervalAfterPointTrue Output":
	true

define "IntegerIntervalAfterPointFalse Input":
	Interval[11, 20] after 12
define "IntegerIntervalAfterPointFalse Output":
	false

define "DecimalIntervalAfterTrue Input":
	Interval[11.0, 20.0] after Interval[1.0, 10.0]
define "DecimalIntervalAfterTrue Output":
	true

define "DecimalIntervalAfterFalse Input":
	Interval[1.0, 10.0] after Interval[11.0, 20.0]
define "DecimalIntervalAfterFalse Output":
	false

define "DecimalIntervalPointAfterTrue Input":
	12.0 after Interval[1.0, 10.0]
define "DecimalIntervalPointAfterTrue Output":
	true

define "DecimalIntervalPointAfterFalse Input":
	9.0 after Interval[1.0, 10.0]
define "DecimalIntervalPointAfterFalse Output":
	false

define "DecimalIntervalAfterPointTrue Input":
	Interval[11.0, 20.0] after 5.0
define "DecimalIntervalAfterPointTrue Output":
	true

define "DecimalIntervalAfterPointFalse Input":
	Interval[11.0, 20.0] after 12.0
define "DecimalIntervalAfterPointFalse Output":
	false

define "QuantityIntervalAfterTrue Input":
	Interval[11.0 'g', 20.0 'g'] after Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalAfterTrue Output":
	true

define "QuantityIntervalAfterFalse Input":
	Interval[1.0 'g', 10.0 'g'] after Interval[11.0 'g', 20.0 'g']
define "QuantityIntervalAfterFalse Output":
	false

define "QuantityIntervalPointAfterTrue Input":
	12.0'g' after Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalPointAfterTrue Output":
	true

define "QuantityIntervalPointAfterFalse Input":
	9.0'g' after Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalPointAfterFalse Output":
	false

define "QuantityIntervalAfterPointTrue Input":
	Interval[11.0 'g', 20.0 'g'] after 5.0'g'
define "QuantityIntervalAfterPointTrue Output":
	true

define "QuantityIntervalAfterPointFalse Input":
	Interval[11.0 'g', 20.0 'g'] after 12.0'g'
define "QuantityIntervalAfterPointFalse Output":
	false

define "DateTimeAfterTrue Input":
	Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] after DateTime(2011, 12, 31)
define "DateTimeAfterTrue Output":
	true

define "DateTimeAfterFalse Input":
	Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] after DateTime(2012, 12, 31)
define "DateTimeAfterFalse Output":
	false

define "TimeAfterTrue Input":
	Interval[@T15:59:59.999, @T20:59:59.999] after @T12:59:59.999
define "TimeAfterTrue Output":
	true

define "TimeAfterFalse Input":
	Interval[@T15:59:59.999, @T20:59:59.999] after @T17:59:59.999
define "TimeAfterFalse Output":
	false

define "TestBeforeNull Input":
	(null as Integer) before Interval[1, 10]
define "TestBeforeNull Output":
	null

define "IntegerIntervalBeforeFalse Input":
	Interval[11, 20] before Interval[1, 10]
define "IntegerIntervalBeforeFalse Output":
	false

define "IntegerIntervalBeforeTrue Input":
	Interval[1, 10] before Interval[11, 20]
define "IntegerIntervalBeforeTrue Output":
	true

define "IntegerIntervalPointBeforeTrue Input":
	9 before Interval[11, 20]
define "IntegerIntervalPointBeforeTrue Output":
	true

define "IntegerIntervalPointBeforeFalse Input":
	9 before Interval[1, 10]
define "IntegerIntervalPointBeforeFalse Output":
	false

define "IntegerIntervalBeforePointTrue Input":
	Interval[1, 10] before 11
define "IntegerIntervalBeforePointTrue Output":
	true

define "IntegerIntervalBeforePointFalse Input":
	Interval[1, 10] before 8
define "IntegerIntervalBeforePointFalse Output":
	false

define "DecimalIntervalBeforeFalse Input":
	Interval[11.0, 20.0] before Interval[1.0, 10.0]
define "DecimalIntervalBeforeFalse Output":
	false

define "DecimalIntervalBeforeTrue Input":
	Interval[1.0, 10.0] before Interval[11.0, 20.0]
define "DecimalIntervalBeforeTrue Output":
	true

define "DecimalIntervalPointBeforeTrue Input":
	9.0 before Interval[11.0, 20.0]
define "DecimalIntervalPointBeforeTrue Output":
	true

define "DecimalIntervalPointBeforeFalse Input":
	9.0 before Interval[1.0, 10.0]
define "DecimalIntervalPointBeforeFalse Output":
	false

define "DecimalIntervalBeforePointTrue Input":
	Interval[1.0, 10.0] before 11.0
define "DecimalIntervalBeforePointTrue Output":
	true

define "DecimalIntervalBeforePointFalse Input":
	Interval[1.0, 10.0] before 8.0
define "DecimalIntervalBeforePointFalse Output":
	false

define "QuantityIntervalBeforeTrue Input":
	Interval[1.0 'g', 10.0 'g'] before Interval[11.0 'g', 20.0 'g']
define "QuantityIntervalBeforeTrue Output":
	true

define "QuantityIntervalBeforeFalse Input":
	Interval[11.0 'g', 20.0 'g'] before Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalBeforeFalse Output":
	false

define "QuantityIntervalPointBeforeTrue Input":
	Interval[1.0 'g', 10.0 'g'] before 12.0'g'
define "QuantityIntervalPointBeforeTrue Output":
	true

define "QuantityIntervalPointBeforeFalse Input":
	Interval[1.0 'g', 10.0 'g'] before 9.0'g'
define "QuantityIntervalPointBeforeFalse Output":
	false

define "QuantityIntervalBeforePointTrue Input":
	5.0'g' before Interval[11.0 'g', 20.0 'g']
define "QuantityIntervalBeforePointTrue Output":
	true

define "QuantityIntervalBeforePointFalse Input":
	12.0'g' before Interval[11.0 'g', 20.0 'g']
define "QuantityIntervalBeforePointFalse Output":
	false

define "DateTimeBeforeTrue Input":
	Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] before DateTime(2012, 2, 27)
define "DateTimeBeforeTrue Output":
	true

define "DateTimeBeforeFalse Input":
	Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] before DateTime(2011, 12, 31)
define "DateTimeBeforeFalse Output":
	false

define "TimeBeforeTrue Input":
	Interval[@T15:59:59.999, @T20:59:59.999] before @T22:59:59.999
define "TimeBeforeTrue Output":
	true

define "TimeBeforeFalse Input":
	Interval[@T15:59:59.999, @T20:59:59.999] before @T10:59:59.999
define "TimeBeforeFalse Output":
	false

define "ExpandPerDay Input":
	expand { Interval[@2018-01-01, @2018-01-04] } per day
define "ExpandPerDay Output":
	{ Interval[@2018-01-01, @2018-01-01], Interval[@2018-01-02, @2018-01-02], Interval[@2018-01-03, @2018-01-03], Interval[@2018-01-04, @2018-01-04] }

define "ExpandPer2Days Input":
	expand { Interval[@2018-01-01, @2018-01-04] } per 2 days
define "ExpandPer2Days Output":
	{ Interval[@2018-01-01, @2018-01-02], Interval[@2018-01-03, @2018-01-04] }

define "ExpandPerHour Input":
	expand { Interval[@T10:00, @T12:30] } per hour
define "ExpandPerHour Output":
	{ Interval[@T10:00, @T11:00), Interval[@T11:00, @T12:00) }

define "ExpandPerMinute Input":
	expand { Interval[@T10, @T10] } per minute
define "ExpandPerMinute Output":
	{ }

define "ExpandInterval Input":
	expand { Interval[1, 10] }
define "ExpandInterval Output":
	{ Interval[1, 1], Interval[2, 2], Interval[3, 3], Interval[4, 4], Interval[5, 5], Interval[6, 6], Interval[7, 7], Interval[8, 8], Interval[9, 9], Interval[10, 10] }

define "ExpandIntervalPer2 Input":
	expand { Interval[1, 10] } per 2
define "ExpandIntervalPer2 Output":
	{ Interval[1, 2], Interval[3, 4], Interval[5, 6], Interval[7, 8], Interval[9, 10] }

define "TestContainsNull Input":
	Interval[1, 10] contains null
define "TestContainsNull Output":
	null

define "TestNullElement2 Input":
	Interval[null, 5] contains 10
define "TestNullElement2 Output":
	false

define "IntegerIntervalContainsTrue Input":
	Interval[1, 10] contains 5
define "IntegerIntervalContainsTrue Output":
	true

define "IntegerIntervalContainsFalse Input":
	Interval[1, 10] contains 25
define "IntegerIntervalContainsFalse Output":
	false

define "DecimalIntervalContainsTrue Input":
	Interval[1.0, 10.0] contains 8.0
define "DecimalIntervalContainsTrue Output":
	true

define "DecimalIntervalContainsFalse Input":
	Interval[1.0, 10.0] contains 255.0
define "DecimalIntervalContainsFalse Output":
	false

define "QuantityIntervalContainsTrue Input":
	Interval[1.0 'g', 10.0 'g'] contains 2.0 'g'
define "QuantityIntervalContainsTrue Output":
	true

define "QuantityIntervalContainsFalse Input":
	Interval[1.0 'g', 10.0 'g'] contains 100.0 'g'
define "QuantityIntervalContainsFalse Output":
	false

define "DateTimeContainsTrue Input":
	Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] contains DateTime(2012, 1, 10)
define "DateTimeContainsTrue Output":
	true

define "DateTimeContainsFalse Input":
	Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] contains DateTime(2012, 1, 16)
define "DateTimeContainsFalse Output":
	false

define "TimeContainsTrue Input":
	Interval[@T01:59:59.999, @T10:59:59.999] contains @T05:59:59.999
define "TimeContainsTrue Output":
	true

define "TimeContainsFalse Input":
	Interval[@T01:59:59.999, @T10:59:59.999] contains @T15:59:59.999
define "TimeContainsFalse Output":
	false

define "IntegerIntervalEnd Input":
	end of Interval[1, 10]
define "IntegerIntervalEnd Output":
	10

define "DecimalIntervalEnd Input":
	end of Interval[1.0, 10.0]
define "DecimalIntervalEnd Output":
	10.0

define "QuantityIntervalEnd Input":
	end of Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalEnd Output":
	10.0'g'

define "DateTimeIntervalEnd Input":
	end of Interval[@2016-05-01T00:00:00.000, @2016-05-02T00:00:00.000]
define "DateTimeIntervalEnd Output":
	@2016-05-02T00:00:00.000

define "TimeIntervalEnd Input":
	end of Interval[@T00:00:00.000, @T23:59:59.599]
define "TimeIntervalEnd Output":
	@T23:59:59.599

define "TestEndsNull Input":
	Interval[1, 10] ends Interval(null, null)
define "TestEndsNull Output":
	null

define "IntegerIntervalEndsTrue Input":
	Interval[4, 10] ends Interval[1, 10]
define "IntegerIntervalEndsTrue Output":
	true

define "IntegerIntervalEndsFalse Input":
	Interval[44, 50] ends Interval[1, 10]
define "IntegerIntervalEndsFalse Output":
	false

define "DecimalIntervalEndsTrue Input":
	Interval[4.0, 10.0] ends Interval[1.0, 10.0]
define "DecimalIntervalEndsTrue Output":
	true

define "DecimalIntervalEndsFalse Input":
	Interval[11.0, 20.0] ends Interval[1.0, 10.0]
define "DecimalIntervalEndsFalse Output":
	false

define "QuantityIntervalEndsTrue Input":
	Interval[5.0 'g', 10.0 'g'] ends Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalEndsTrue Output":
	true

define "QuantityIntervalEndsFalse Input":
	Interval[11.0 'g', 20.0 'g'] ends Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalEndsFalse Output":
	false

define "DateTimeEndsTrue Input":
	Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] ends Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)]
define "DateTimeEndsTrue Output":
	true

define "DateTimeEndsFalse Input":
	Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] ends Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 16)]
define "DateTimeEndsFalse Output":
	false

define "TimeEndsTrue Input":
	Interval[@T05:59:59.999, @T10:59:59.999] ends Interval[@T01:59:59.999, @T10:59:59.999]
define "TimeEndsTrue Output":
	true

define "TimeEndsFalse Input":
	Interval[@T05:59:59.999, @T10:59:59.999] ends Interval[@T01:59:59.999, @T11:59:59.999]
define "TimeEndsFalse Output":
	false

define "TestEqualNull Input":
	Interval[1, 10] = Interval(null, null)
define "TestEqualNull Output":
	null

define "IntegerIntervalEqualTrue Input":
	Interval[1, 10] = Interval[1, 10]
define "IntegerIntervalEqualTrue Output":
	true

define "IntegerIntervalEqualFalse Input":
	Interval[1, 10] = Interval[11, 20]
define "IntegerIntervalEqualFalse Output":
	false

define "DecimalIntervalEqualTrue Input":
	Interval[1.0, 10.0] = Interval[1.0, 10.0]
define "DecimalIntervalEqualTrue Output":
	true

define "DecimalIntervalEqualFalse Input":
	Interval[1.0, 10.0] = Interval[11.0, 20.0]
define "DecimalIntervalEqualFalse Output":
	false

define "QuantityIntervalEqualTrue Input":
	Interval[1.0 'g', 10.0 'g'] = Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalEqualTrue Output":
	true

define "QuantityIntervalEqualFalse Input":
	Interval[1.0 'g', 10.0 'g'] = Interval[11.0 'g', 20.0 'g']
define "QuantityIntervalEqualFalse Output":
	false

define "DateTimeEqualTrue Input":
	Interval[DateTime(2012, 1, 5, 0, 0, 0, 0), DateTime(2012, 1, 15, 0, 0, 0, 0)] = Interval[DateTime(2012, 1, 5, 0, 0, 0, 0), DateTime(2012, 1, 15, 0, 0, 0, 0)]
define "DateTimeEqualTrue Output":
	true

define "DateTimeEqualFalse Input":
	Interval[DateTime(2012, 1, 5, 0, 0, 0, 0), DateTime(2012, 1, 15, 0, 0, 0, 0)] = Interval[DateTime(2012, 1, 5, 0, 0, 0, 0), DateTime(2012, 1, 16, 0, 0, 0, 0)]
define "DateTimeEqualFalse Output":
	false

define "TimeEqualTrue Input":
	Interval[@T05:59:59.999, @T10:59:59.999] = Interval[@T05:59:59.999, @T10:59:59.999]
define "TimeEqualTrue Output":
	true

define "TimeEqualFalse Input":
	Interval[@T05:59:59.999, @T10:59:59.999] = Interval[@T05:59:59.999, @T10:58:59.999]
define "TimeEqualFalse Output":
	false

define "NullInterval Input":
	Interval[null, null]
define "NullInterval Output":
	null

define "TestExceptNull Input":
	Interval[null, null] except Interval[null, null]
define "TestExceptNull Output":
	null

define "IntegerIntervalExcept1to3 Input":
	Interval[1, 10] except Interval[4, 10]
define "IntegerIntervalExcept1to3 Output":
	Interval [ 1, 3 ]

define "IntegerIntervalExceptNull Input":
	Interval[1, 10] except Interval[3, 7]
define "IntegerIntervalExceptNull Output":
	null

define "DecimalIntervalExcept1to3 Input":
	Interval[1.0, 10.0] except Interval[4.0, 10.0]
define "DecimalIntervalExcept1to3 Output":
	Interval [ 1.0, 3.99999999 ]

define "DecimalIntervalExceptNull Input":
	Interval[1.0, 10.0] except Interval[3.0, 7.0]
define "DecimalIntervalExceptNull Output":
	null

define "QuantityIntervalExcept1to4 Input":
	Interval[1.0 'g', 10.0 'g'] except Interval[5.0 'g', 10.0 'g']
define "QuantityIntervalExcept1to4 Output":
	Interval [ 1.0 'g', 4.99999999 'g' ]

define "Except12 Input":
	Interval[1, 4] except Interval[3, 6]
define "Except12 Output":
	Interval [ 1, 2 ]

define "ExceptDateTimeInterval Input":
	Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] except Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 15)]
define "ExceptDateTimeInterval Output":
	Interval [ @2012-01-05T, @2012-01-06T ]

define "ExceptDateTime2 Input":
	Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 16)] except Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 12)]
define "ExceptDateTime2 Output":
	Interval [ @2012-01-13T, @2012-01-16T ]

define "ExceptTimeInterval Input":
	Interval[@T05:59:59.999, @T10:59:59.999] except Interval[@T08:59:59.999, @T10:59:59.999]
define "ExceptTimeInterval Output":
	Interval [ @T05:59:59.999, @T08:59:59.998 ]

define "ExceptTime2 Input":
	Interval[@T08:59:59.999, @T11:59:59.999] except Interval[@T05:59:59.999, @T10:59:59.999]
define "ExceptTime2 Output":
	Interval [ @T11:00:00.000, @T11:59:59.999 ]

define "TestInNullBoundaries Input":
	5 in Interval[null, null]
define "TestInNullBoundaries Output":
	false

define "IntegerIntervalInTrue Input":
	5 in Interval[1, 10]
define "IntegerIntervalInTrue Output":
	true

define "IntegerIntervalInFalse Input":
	500 in Interval[1, 10]
define "IntegerIntervalInFalse Output":
	false

define "DecimalIntervalInTrue Input":
	9.0 in Interval[1.0, 10.0]
define "DecimalIntervalInTrue Output":
	true

define "DecimalIntervalInFalse Input":
	-2.0 in Interval[1.0, 10.0]
define "DecimalIntervalInFalse Output":
	false

define "QuantityIntervalInTrue Input":
	1.0 'g' in Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalInTrue Output":
	true

define "QuantityIntervalInFalse Input":
	55.0 'g' in Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalInFalse Output":
	false

define "DateTimeInTrue Input":
	DateTime(2012, 1, 7) in Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)]
define "DateTimeInTrue Output":
	true

define "DateTimeInFalse Input":
	DateTime(2012, 1, 17) in Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)]
define "DateTimeInFalse Output":
	false

define "DateTimeInNullTrue Input":
	DateTime(2012, 1, 7) in Interval[DateTime(2012, 1, 5), null]
define "DateTimeInNullTrue Output":
	true

define "TimeInTrue Input":
	@T07:59:59.999 in Interval[@T05:59:59.999, @T10:59:59.999]
define "TimeInTrue Output":
	true

define "TimeInFalse Input":
	@T17:59:59.999 in Interval[@T05:59:59.999, @T10:59:59.999]
define "TimeInFalse Output":
	false

define "TimeInNull Input":
	null in Interval[@T05:59:59.999, @T10:59:59.999]
define "TimeInNull Output":
	null

define "TestPeriod1 Input":
	Interval[@2017-12-20T11:00:00, @2017-12-21T21:00:00]
define "TestPeriod1 Output":
	Interval [ @2017-12-20T11:00:00, @2017-12-21T21:00:00 ]

define "TestPeriod2 Input":
	Interval[@2017-12-20T10:30:00, @2017-12-20T12:00:00]
define "TestPeriod2 Output":
	Interval [ @2017-12-20T10:30:00, @2017-12-20T12:00:00 ]

define "Issue32Interval Input":
	
				Interval[@2017-12-20T10:30:00, @2017-12-20T12:00:00]
				starts 1 day or less on or after day of start of
				Interval[@2017-12-20T11:00:00, @2017-12-21T21:00:00]
			
define "Issue32Interval Output":
	true

define "TestIncludesNull Input":
	Interval[1, 10] includes null as Integer
define "TestIncludesNull Output":
	null

define "IntegerIntervalIncludesTrue Input":
	Interval[1, 10] includes Interval[4, 10]
define "IntegerIntervalIncludesTrue Output":
	true

define "IntegerIntervalIncludesFalse Input":
	Interval[1, 10] includes Interval[44, 50]
define "IntegerIntervalIncludesFalse Output":
	false

define "DecimalIntervalIncludesTrue Input":
	Interval[1.0, 10.0] includes Interval[4.0, 10.0]
define "DecimalIntervalIncludesTrue Output":
	true

define "DecimalIntervalIncludesFalse Input":
	Interval[1.0, 10.0] includes Interval[11.0, 20.0]
define "DecimalIntervalIncludesFalse Output":
	false

define "QuantityIntervalIncludesTrue Input":
	Interval[1.0 'g', 10.0 'g'] includes Interval[5.0 'g', 10.0 'g']
define "QuantityIntervalIncludesTrue Output":
	true

define "QuantityIntervalIncludesFalse Input":
	Interval[1.0 'g', 10.0 'g'] includes Interval[11.0 'g', 20.0 'g']
define "QuantityIntervalIncludesFalse Output":
	false

define "DateTimeIncludesTrue Input":
	Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] includes Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]
define "DateTimeIncludesTrue Output":
	true

define "DateTimeIncludesFalse Input":
	Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] includes Interval[DateTime(2012, 1, 4), DateTime(2012, 1, 14)]
define "DateTimeIncludesFalse Output":
	false

define "TimeIncludesTrue Input":
	Interval[@T05:59:59.999, @T10:59:59.999] includes Interval[@T06:59:59.999, @T09:59:59.999]
define "TimeIncludesTrue Output":
	true

define "TimeIncludesFalse Input":
	Interval[@T05:59:59.999, @T10:59:59.999] includes Interval[@T04:59:59.999, @T09:59:59.999]
define "TimeIncludesFalse Output":
	false

define "TestIncludedInNull Input":
	null included in Interval[1, 10]
define "TestIncludedInNull Output":
	null

define "IntegerIntervalIncludedInTrue Input":
	Interval[4, 10] included in Interval[1, 10]
define "IntegerIntervalIncludedInTrue Output":
	true

define "IntegerIntervalIncludedInFalse Input":
	Interval[44, 50] included in Interval[1, 10]
define "IntegerIntervalIncludedInFalse Output":
	false

define "DecimalIntervalIncludedInTrue Input":
	Interval[4.0, 10.0] included in Interval[1.0, 10.0]
define "DecimalIntervalIncludedInTrue Output":
	true

define "DecimalIntervalIncludedInFalse Input":
	Interval[11.0, 20.0] included in Interval[1.0, 10.0]
define "DecimalIntervalIncludedInFalse Output":
	false

define "QuantityIntervalIncludedInTrue Input":
	Interval[5.0 'g', 10.0 'g'] included in Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalIncludedInTrue Output":
	true

define "QuantityIntervalIncludedInFalse Input":
	Interval[11.0 'g', 20.0 'g'] included in Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalIncludedInFalse Output":
	false

define "DateTimeIncludedInTrue Input":
	Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] included in Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)]
define "DateTimeIncludedInTrue Output":
	true

define "DateTimeIncludedInFalse Input":
	Interval[DateTime(2012, 1, 4), DateTime(2012, 1, 14)] included in Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)]
define "DateTimeIncludedInFalse Output":
	false

define "TimeIncludedInTrue Input":
	Interval[@T06:59:59.999, @T09:59:59.999] included in Interval[@T05:59:59.999, @T10:59:59.999]
define "TimeIncludedInTrue Output":
	true

define "TimeIncludedInFalse Input":
	Interval[@T04:59:59.999, @T09:59:59.999] included in Interval[@T05:59:59.999, @T10:59:59.999]
define "TimeIncludedInFalse Output":
	false

define "DateTimeIncludedInNull Input":
	Interval [@2017-09-01T00:00:00, @2017-09-01T00:00:00] included in Interval [@2017-09-01T00:00:00.000, @2017-12-30T23:59:59.999]
define "DateTimeIncludedInNull Output":
	null

define "DateTimeIncludedInPrecisionTrue Input":
	Interval [@2017-09-01T00:00:00, @2017-09-01T00:00:00] included in day of Interval [@2017-09-01T00:00:00.000, @2017-12-30T23:59:59.999]
define "DateTimeIncludedInPrecisionTrue Output":
	true

define "DateTimeIncludedInPrecisionNull Input":
	Interval [@2017-09-01T00:00:00, @2017-09-01T00:00:00] included in millisecond of Interval [@2017-09-01T00:00:00.000, @2017-12-30T23:59:59.999]
define "DateTimeIncludedInPrecisionNull Output":
	null

define "TestIntersectNull Input":
	Interval[1, 10] intersect Interval[5, null)
define "TestIntersectNull Output":
	null

define "IntegerIntervalIntersectTest4to10 Input":
	Interval[1, 10] intersect Interval[4, 10]
define "IntegerIntervalIntersectTest4to10 Output":
	Interval [ 4, 10 ]

define "IntegerIntervalIntersectTestNull Input":
	Interval[1, 10] intersect Interval[11, 20]
define "IntegerIntervalIntersectTestNull Output":
	null

define "DecimalIntervalIntersectTest4to10 Input":
	Interval[1.0, 10.0] intersect Interval[4.0, 10.0]
define "DecimalIntervalIntersectTest4to10 Output":
	Interval [ 4.0, 10.0 ]

define "DecimalIntervalIntersectTestNull Input":
	Interval[1.0, 10.0] intersect Interval[11.0, 20.0]
define "DecimalIntervalIntersectTestNull Output":
	null

define "QuantityIntervalIntersectTest5to10 Input":
	Interval[1.0 'g', 10.0 'g'] intersect Interval[5.0 'g', 10.0 'g']
define "QuantityIntervalIntersectTest5to10 Output":
	Interval [ 5.0 'g', 10.0 'g' ]

define "QuantityIntervalIntersectTestNull Input":
	Interval[1.0 'g', 10.0 'g'] intersect Interval[11.0 'g', 20.0 'g']
define "QuantityIntervalIntersectTestNull Output":
	null

define "DateTimeIntersect Input":
	Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] intersect Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 10)]
define "DateTimeIntersect Output":
	Interval [ @2012-01-07T, @2012-01-10T ]

define "TimeIntersect Input":
	Interval[@T04:59:59.999, @T09:59:59.999] intersect Interval[@T04:59:59.999, @T06:59:59.999]
define "TimeIntersect Output":
	Interval [ @T04:59:59.999, @T06:59:59.999 ]

define "IntegerIntervalEquivalentTrue Input":
	Interval[1, 10] ~ Interval[1, 10]
define "IntegerIntervalEquivalentTrue Output":
	true

define "IntegerIntervalEquivalentFalse Input":
	Interval[44, 50] ~ Interval[1, 10]
define "IntegerIntervalEquivalentFalse Output":
	false

define "DecimalIntervalEquivalentTrue Input":
	Interval[1.0, 10.0] ~ Interval[1.0, 10.0]
define "DecimalIntervalEquivalentTrue Output":
	true

define "DecimalIntervalEquivalentFalse Input":
	Interval[11.0, 20.0] ~ Interval[1.0, 10.0]
define "DecimalIntervalEquivalentFalse Output":
	false

define "QuantityIntervalEquivalentTrue Input":
	Interval[1.0 'g', 10.0 'g'] ~ Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalEquivalentTrue Output":
	true

define "QuantityIntervalEquivalentFalse Input":
	Interval[11.0 'g', 20.0 'g'] ~ Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalEquivalentFalse Output":
	false

define "DateTimeEquivalentTrue Input":
	Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] ~ Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]
define "DateTimeEquivalentTrue Output":
	true

define "DateTimeEquivalentFalse Input":
	Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] ~ Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 15)]
define "DateTimeEquivalentFalse Output":
	false

define "TimeEquivalentTrue Input":
	Interval[@T04:59:59.999, @T09:59:59.999] ~ Interval[@T04:59:59.999, @T09:59:59.999]
define "TimeEquivalentTrue Output":
	true

define "TimeEquivalentFalse Input":
	Interval[@T04:59:59.999, @T09:59:59.999] ~ Interval[@T04:58:59.999, @T09:59:59.999]
define "TimeEquivalentFalse Output":
	false

define "TestMeetsNull Input":
	Interval(null, 5] meets Interval(null, 15)
define "TestMeetsNull Output":
	null

define "IntegerIntervalMeetsTrue Input":
	Interval[1, 10] meets Interval[11, 20]
define "IntegerIntervalMeetsTrue Output":
	true

define "IntegerIntervalMeetsFalse Input":
	Interval[1, 10] meets Interval[44, 50]
define "IntegerIntervalMeetsFalse Output":
	false

define "DecimalIntervalMeetsTrue Input":
	Interval[3.01, 5.00000001] meets Interval[5.00000002, 8.50]
define "DecimalIntervalMeetsTrue Output":
	true

define "DecimalIntervalMeetsFalse Input":
	Interval[3.01, 5.00000001] meets Interval[5.5, 8.50]
define "DecimalIntervalMeetsFalse Output":
	false

define "QuantityIntervalMeetsTrue Input":
	Interval[3.01 'g', 5.00000001 'g'] meets Interval[5.00000002 'g', 8.50 'g']
define "QuantityIntervalMeetsTrue Output":
	true

define "QuantityIntervalMeetsFalse Input":
	Interval[3.01 'g', 5.00000001 'g'] meets Interval[5.5 'g', 8.50 'g']
define "QuantityIntervalMeetsFalse Output":
	false

define "DateTimeMeetsTrue Input":
	Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] meets Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 25)]
define "DateTimeMeetsTrue Output":
	true

define "DateTimeMeetsFalse Input":
	Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] meets Interval[DateTime(2012, 1, 20), DateTime(2012, 1, 25)]
define "DateTimeMeetsFalse Output":
	false

define "TimeMeetsTrue Input":
	Interval[@T04:59:59.999, @T09:59:59.999] meets Interval[@T10:00:00.000, @T19:59:59.999]
define "TimeMeetsTrue Output":
	true

define "TimeMeetsFalse Input":
	Interval[@T04:59:59.999, @T09:59:59.999] meets Interval[@T10:12:00.000, @T19:59:59.999]
define "TimeMeetsFalse Output":
	false

define "TestMeetsBeforeNull Input":
	Interval(null, 5] meets before Interval(null, 25]
define "TestMeetsBeforeNull Output":
	null

define "IntegerIntervalMeetsBeforeTrue Input":
	Interval[1, 10] meets before Interval[11, 20]
define "IntegerIntervalMeetsBeforeTrue Output":
	true

define "IntegerIntervalMeetsBeforeFalse Input":
	Interval[1, 10] meets before Interval[44, 50]
define "IntegerIntervalMeetsBeforeFalse Output":
	false

define "DecimalIntervalMeetsBeforeTrue Input":
	Interval[3.50000001, 5.00000011] meets before Interval[5.00000012, 8.50]
define "DecimalIntervalMeetsBeforeTrue Output":
	true

define "DecimalIntervalMeetsBeforeFalse Input":
	Interval[8.01, 15.00000001] meets before Interval[15.00000000, 18.50]
define "DecimalIntervalMeetsBeforeFalse Output":
	false

define "QuantityIntervalMeetsBeforeTrue Input":
	Interval[3.50000001 'g', 5.00000011 'g'] meets before Interval[5.00000012 'g', 8.50 'g']
define "QuantityIntervalMeetsBeforeTrue Output":
	true

define "QuantityIntervalMeetsBeforeFalse Input":
	Interval[8.01 'g', 15.00000001 'g'] meets before Interval[15.00000000 'g', 18.50 'g']
define "QuantityIntervalMeetsBeforeFalse Output":
	false

define "DateTimeMeetsBeforeTrue Input":
	Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] meets Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 25)]
define "DateTimeMeetsBeforeTrue Output":
	true

define "DateTimeMeetsBeforeFalse Input":
	Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] meets Interval[DateTime(2012, 1, 20), DateTime(2012, 1, 25)]
define "DateTimeMeetsBeforeFalse Output":
	false

define "TimeMeetsBeforeTrue Input":
	Interval[@T04:59:59.999, @T09:59:59.999] meets Interval[@T10:00:00.000, @T19:59:59.999]
define "TimeMeetsBeforeTrue Output":
	true

define "TimeMeetsBeforeFalse Input":
	Interval[@T04:59:59.999, @T09:59:59.999] meets Interval[@T10:12:00.000, @T19:59:59.999]
define "TimeMeetsBeforeFalse Output":
	false

define "TestMeetsAfterNull Input":
	Interval(null, 5] meets after Interval[11, null)
define "TestMeetsAfterNull Output":
	false

define "IntegerIntervalMeetsAfterTrue Input":
	Interval[11, 20] meets after Interval[1, 10]
define "IntegerIntervalMeetsAfterTrue Output":
	true

define "IntegerIntervalMeetsAfterFalse Input":
	Interval[44, 50] meets after Interval[1, 10]
define "IntegerIntervalMeetsAfterFalse Output":
	false

define "DecimalIntervalMeetsAfterTrue Input":
	Interval[55.00000123, 128.032156] meets after Interval[12.00258, 55.00000122]
define "DecimalIntervalMeetsAfterTrue Output":
	true

define "DecimalIntervalMeetsAfterFalse Input":
	Interval[55.00000124, 150.222222] meets after Interval[12.00258, 55.00000122]
define "DecimalIntervalMeetsAfterFalse Output":
	false

define "QuantityIntervalMeetsAfterTrue Input":
	Interval[55.00000123 'g', 128.032156 'g'] meets after Interval[12.00258 'g', 55.00000122 'g']
define "QuantityIntervalMeetsAfterTrue Output":
	true

define "QuantityIntervalMeetsAfterFalse Input":
	Interval[55.00000124 'g', 150.222222 'g'] meets after Interval[12.00258 'g', 55.00000122 'g']
define "QuantityIntervalMeetsAfterFalse Output":
	false

define "DateTimeMeetsAfterTrue Input":
	Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 25)] meets Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]
define "DateTimeMeetsAfterTrue Output":
	true

define "DateTimeMeetsAfterFalse Input":
	Interval[DateTime(2012, 1, 20), DateTime(2012, 1, 25)] meets Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]
define "DateTimeMeetsAfterFalse Output":
	false

define "TimeMeetsAfterTrue Input":
	Interval[@T10:00:00.000, @T19:59:59.999] meets Interval[@T04:59:59.999, @T09:59:59.999]
define "TimeMeetsAfterTrue Output":
	true

define "TimeMeetsAfterFalse Input":
	Interval[@T10:12:00.000, @T19:59:59.999] meets Interval[@T04:59:59.999, @T09:59:59.999]
define "TimeMeetsAfterFalse Output":
	false

define "IntegerIntervalNotEqualTrue Input":
	Interval[1, 10] != Interval[11, 20]
define "IntegerIntervalNotEqualTrue Output":
	true

define "IntegerIntervalNotEqualFalse Input":
	Interval[1, 10] != Interval[1, 10]
define "IntegerIntervalNotEqualFalse Output":
	false

define "DecimalIntervalNotEqualTrue Input":
	Interval[1.0, 10.0] != Interval[11.0, 20.0]
define "DecimalIntervalNotEqualTrue Output":
	true

define "DecimalIntervalNotEqualFalse Input":
	Interval[1.0, 10.0] != Interval[1.0, 10.0]
define "DecimalIntervalNotEqualFalse Output":
	false

define "QuantityIntervalNotEqualTrue Input":
	Interval[1.0 'g', 10.0 'g'] != Interval[11.0 'g', 20.0 'g']
define "QuantityIntervalNotEqualTrue Output":
	true

define "QuantityIntervalNotEqualFalse Input":
	Interval[1.0 'g', 10.0 'g'] != Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalNotEqualFalse Output":
	false

define "DateTimeNotEqualTrue Input":
	Interval[DateTime(2012, 1, 15, 0, 0, 0, 0), DateTime(2012, 1, 25, 0, 0, 0, 0)] != Interval[DateTime(2012, 1, 15, 0, 0, 0, 0), DateTime(2012, 1, 25, 0, 0, 0, 22)]
define "DateTimeNotEqualTrue Output":
	true

define "DateTimeNotEqualFalse Input":
	Interval[DateTime(2012, 1, 15, 0, 0, 0, 0), DateTime(2012, 1, 25, 0, 0, 0, 0)] != Interval[DateTime(2012, 1, 15, 0, 0, 0, 0), DateTime(2012, 1, 25, 0, 0, 0, 0)]
define "DateTimeNotEqualFalse Output":
	false

define "TimeNotEqualTrue Input":
	Interval[@T10:00:00.000, @T19:59:59.999] != Interval[@T10:10:00.000, @T19:59:59.999]
define "TimeNotEqualTrue Output":
	true

define "TimeNotEqualFalse Input":
	Interval[@T10:00:00.000, @T19:59:59.999] != Interval[@T10:00:00.000, @T19:59:59.999]
define "TimeNotEqualFalse Output":
	false

define "TestOnOrAfterNull Input":
	Interval[@2012-12-01, @2013-12-01] on or after (null as Interval<Date>)
define "TestOnOrAfterNull Output":
	null

define "TestOnOrAfterDateTrue Input":
	Interval[@2012-12-01, @2013-12-01] on or after month of @2012-11-15
define "TestOnOrAfterDateTrue Output":
	true

define "TestOnOrAfterDateFalse Input":
	@2012-11-15 on or after month of Interval[@2012-12-01, @2013-12-01]
define "TestOnOrAfterDateFalse Output":
	false

define "TestOnOrAfterTimeTrue Input":
	Interval[@T10:00:00.000, @T19:59:59.999] on or after hour of Interval[@T08:00:00.000, @T09:59:59.999]
define "TestOnOrAfterTimeTrue Output":
	true

define "TestOnOrAfterTimeFalse Input":
	Interval[@T10:00:00.000, @T19:59:59.999] on or after hour of Interval[@T08:00:00.000, @T11:59:59.999]
define "TestOnOrAfterTimeFalse Output":
	false

define "TestOnOrAfterIntegerTrue Input":
	Interval[6, 10] on or after 6
define "TestOnOrAfterIntegerTrue Output":
	true

define "TestOnOrAfterDecimalFalse Input":
	2.5 on or after Interval[1.666, 2.50000001]
define "TestOnOrAfterDecimalFalse Output":
	false

define "TestOnOrAfterQuantityTrue Input":
	2.5 'mg' on or after Interval[1.666 'mg', 2.50000000 'mg']
define "TestOnOrAfterQuantityTrue Output":
	true

define "TestOnOrBeforeNull Input":
	Interval[@2012-12-01, @2013-12-01] on or before (null as Interval<Date>)
define "TestOnOrBeforeNull Output":
	null

define "TestOnOrBeforeDateTrue Input":
	Interval[@2012-10-01, @2012-11-01] on or before month of @2012-11-15
define "TestOnOrBeforeDateTrue Output":
	true

define "TestOnOrBeforeDateFalse Input":
	@2012-11-15 on or before month of Interval[@2012-10-01, @2013-12-01]
define "TestOnOrBeforeDateFalse Output":
	false

define "TestOnOrBeforeTimeTrue Input":
	Interval[@T05:00:00.000, @T07:59:59.999] on or before hour of Interval[@T08:00:00.000, @T09:59:59.999]
define "TestOnOrBeforeTimeTrue Output":
	true

define "TestOnOrBeforeTimeFalse Input":
	Interval[@T10:00:00.000, @T19:59:59.999] on or before hour of Interval[@T08:00:00.000, @T11:59:59.999]
define "TestOnOrBeforeTimeFalse Output":
	false

define "TestOnOrBeforeIntegerTrue Input":
	Interval[4, 6] on or before 6
define "TestOnOrBeforeIntegerTrue Output":
	true

define "TestOnOrBeforeDecimalFalse Input":
	1.6667 on or before Interval[1.666, 2.50000001]
define "TestOnOrBeforeDecimalFalse Output":
	false

define "TestOnOrBeforeQuantityTrue Input":
	1.666 'mg' on or before Interval[1.666 'mg', 2.50000000 'mg']
define "TestOnOrBeforeQuantityTrue Output":
	true

define "TestOverlapsNull Input":
	Interval[null, null] overlaps Interval[1, 10]
define "TestOverlapsNull Output":
	null

define "IntegerIntervalOverlapsTrue Input":
	Interval[1, 10] overlaps Interval[4, 10]
define "IntegerIntervalOverlapsTrue Output":
	true

define "IntegerIntervalOverlapsFalse Input":
	Interval[1, 10] overlaps Interval[11, 20]
define "IntegerIntervalOverlapsFalse Output":
	false

define "DecimalIntervalOverlapsTrue Input":
	Interval[1.0, 10.0] overlaps Interval[4.0, 10.0]
define "DecimalIntervalOverlapsTrue Output":
	true

define "DecimalIntervalOverlapsFalse Input":
	Interval[1.0, 10.0] overlaps Interval[11.0, 20.0]
define "DecimalIntervalOverlapsFalse Output":
	false

define "QuantityIntervalOverlapsTrue Input":
	Interval[1.0 'g', 10.0 'g'] overlaps Interval[5.0 'g', 10.0 'g']
define "QuantityIntervalOverlapsTrue Output":
	true

define "QuantityIntervalOverlapsFalse Input":
	Interval[1.0 'g', 10.0 'g'] overlaps Interval[11.0 'g', 20.0 'g']
define "QuantityIntervalOverlapsFalse Output":
	false

define "DateTimeOverlapsTrue Input":
	Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] overlaps Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)]
define "DateTimeOverlapsTrue Output":
	true

define "DateTimeOverlapsFalse Input":
	Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] overlaps Interval[DateTime(2012, 1, 26), DateTime(2012, 1, 28)]
define "DateTimeOverlapsFalse Output":
	false

define "TimeOverlapsTrue Input":
	Interval[@T10:00:00.000, @T19:59:59.999] overlaps Interval[@T12:00:00.000, @T21:59:59.999]
define "TimeOverlapsTrue Output":
	true

define "TimeOverlapsFalse Input":
	Interval[@T10:00:00.000, @T19:59:59.999] overlaps Interval[@T20:00:00.000, @T21:59:59.999]
define "TimeOverlapsFalse Output":
	false

define "TestOverlapsBeforeNull Input":
	Interval[null, null] overlaps before Interval[1, 10]
define "TestOverlapsBeforeNull Output":
	null

define "IntegerIntervalOverlapsBeforeTrue Input":
	Interval[1, 10] overlaps before Interval[4, 10]
define "IntegerIntervalOverlapsBeforeTrue Output":
	true

define "IntegerIntervalOverlapsBeforeFalse Input":
	Interval[4, 10] overlaps before Interval[1, 10]
define "IntegerIntervalOverlapsBeforeFalse Output":
	false

define "DecimalIntervalOverlapsBeforeTrue Input":
	Interval[1.0, 10.0] overlaps before Interval[4.0, 10.0]
define "DecimalIntervalOverlapsBeforeTrue Output":
	true

define "DecimalIntervalOverlapsBeforeFalse Input":
	Interval[4.0, 10.0] overlaps before Interval[1.0, 10.0]
define "DecimalIntervalOverlapsBeforeFalse Output":
	false

define "QuantityIntervalOverlapsBeforeTrue Input":
	Interval[1.0 'g', 10.0 'g'] overlaps before Interval[5.0 'g', 10.0 'g']
define "QuantityIntervalOverlapsBeforeTrue Output":
	true

define "QuantityIntervalOverlapsBeforeFalse Input":
	Interval[5.0 'g', 10.0 'g'] overlaps before Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalOverlapsBeforeFalse Output":
	false

define "DateTimeOverlapsBeforeTrue Input":
	Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] overlaps Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)]
define "DateTimeOverlapsBeforeTrue Output":
	true

define "DateTimeOverlapsBeforeFalse Input":
	Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] overlaps Interval[DateTime(2012, 1, 26), DateTime(2012, 1, 28)]
define "DateTimeOverlapsBeforeFalse Output":
	false

define "TimeOverlapsBeforeTrue Input":
	Interval[@T10:00:00.000, @T19:59:59.999] overlaps Interval[@T12:00:00.000, @T21:59:59.999]
define "TimeOverlapsBeforeTrue Output":
	true

define "TimeOverlapsBeforeFalse Input":
	Interval[@T10:00:00.000, @T19:59:59.999] overlaps Interval[@T20:00:00.000, @T21:59:59.999]
define "TimeOverlapsBeforeFalse Output":
	false

define "TestOverlapsAfterNull Input":
	Interval[null, null] overlaps after Interval[1, 10]
define "TestOverlapsAfterNull Output":
	null

define "IntegerIntervalOverlapsAfterTrue Input":
	Interval[4, 15] overlaps after Interval[1, 10]
define "IntegerIntervalOverlapsAfterTrue Output":
	true

define "IntegerIntervalOverlapsAfterFalse Input":
	Interval[4, 10] overlaps after Interval[1, 10]
define "IntegerIntervalOverlapsAfterFalse Output":
	false

define "DecimalIntervalOverlapsAfterTrue Input":
	Interval[4.0, 15.0] overlaps after Interval[1.0, 10.0]
define "DecimalIntervalOverlapsAfterTrue Output":
	true

define "DecimalIntervalOverlapsAfterFalse Input":
	Interval[4.0, 10.0] overlaps after Interval[1.0, 10.0]
define "DecimalIntervalOverlapsAfterFalse Output":
	false

define "QuantityIntervalOverlapsAfterTrue Input":
	Interval[5.0 'g', 15.0 'g'] overlaps after Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalOverlapsAfterTrue Output":
	true

define "QuantityIntervalOverlapsAfterFalse Input":
	Interval[5.0 'g', 10.0 'g'] overlaps after Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalOverlapsAfterFalse Output":
	false

define "DateTimeOverlapsAfterTrue Input":
	Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)] overlaps Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)]
define "DateTimeOverlapsAfterTrue Output":
	true

define "DateTimeOverlapsAfterFalse Input":
	Interval[DateTime(2012, 1, 26), DateTime(2012, 1, 28)] overlaps Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)]
define "DateTimeOverlapsAfterFalse Output":
	false

define "TimeOverlapsAfterTrue Input":
	Interval[@T12:00:00.000, @T21:59:59.999] overlaps Interval[@T10:00:00.000, @T19:59:59.999]
define "TimeOverlapsAfterTrue Output":
	true

define "TimeOverlapsAfterFalse Input":
	Interval[@T20:00:00.000, @T21:59:59.999] overlaps Interval[@T10:00:00.000, @T19:59:59.999]
define "TimeOverlapsAfterFalse Output":
	false

define "TestPointFromNull Input":
	point from Interval[null, null]
define "TestPointFromNull Output":
	null

define "TestPointFromInteger Input":
	point from Interval[1, 1]
define "TestPointFromInteger Output":
	1

define "TestPointFromDecimal Input":
	point from Interval[1.0, 1.0]
define "TestPointFromDecimal Output":
	1.0

define "TestPointFromQuantity Input":
	point from Interval[1.0 'cm', 1.0 'cm']
define "TestPointFromQuantity Output":
	1.0'cm'

define "TimeProperContainsTrue Input":
	Interval[@T12:00:00.000, @T21:59:59.999] properly includes @T12:00:00.001
define "TimeProperContainsTrue Output":
	true

define "TimeProperContainsFalse Input":
	Interval[@T12:00:00.000, @T21:59:59.999] properly includes @T12:00:00.000
define "TimeProperContainsFalse Output":
	false

define "TimeProperContainsNull Input":
	Interval[@T12:00:00.001, @T21:59:59.999] properly includes @T12:00:00
define "TimeProperContainsNull Output":
	null

define "TimeProperContainsPrecisionTrue Input":
	Interval[@T12:00:00.000, @T21:59:59.999] properly includes second of @T12:00:01
define "TimeProperContainsPrecisionTrue Output":
	true

define "TimeProperContainsPrecisionFalse Input":
	Interval[@T12:00:00.001, @T21:59:59.999] properly includes second of @T12:00:00
define "TimeProperContainsPrecisionFalse Output":
	false

define "TimeProperContainsPrecisionNull Input":
	Interval[@T12:00:00.001, @T21:59:59.999] properly includes millisecond of @T12:00:00
define "TimeProperContainsPrecisionNull Output":
	null

define "TimeProperInTrue Input":
	@T12:00:00.001 properly included in Interval[@T12:00:00.000, @T21:59:59.999]
define "TimeProperInTrue Output":
	true

define "TimeProperInFalse Input":
	@T12:00:00.000 properly included in  Interval[@T12:00:00.000, @T21:59:59.999]
define "TimeProperInFalse Output":
	false

define "TimeProperInNull Input":
	@T12:00:00 properly included in Interval[@T12:00:00.001, @T21:59:59.999]
define "TimeProperInNull Output":
	null

define "TimeProperInPrecisionTrue Input":
	@T12:00:01 properly included in second of Interval[@T12:00:00.000, @T21:59:59.999]
define "TimeProperInPrecisionTrue Output":
	true

define "TimeProperInPrecisionFalse Input":
	@T12:00:00 properly included in second of Interval[@T12:00:00.001, @T21:59:59.999]
define "TimeProperInPrecisionFalse Output":
	false

define "TimeProperInPrecisionNull Input":
	@T12:00:00 properly included in millisecond of Interval[@T12:00:00.001, @T21:59:59.999]
define "TimeProperInPrecisionNull Output":
	null

define "NullBoundariesProperlyIncludesIntegerInterval Input":
	Interval[null as Integer, null as Integer] properly includes Interval[1, 10]
define "NullBoundariesProperlyIncludesIntegerInterval Output":
	null

define "IntegerIntervalProperlyIncludesTrue Input":
	Interval[1, 10] properly includes Interval[4, 10]
define "IntegerIntervalProperlyIncludesTrue Output":
	true

define "IntegerIntervalProperlyIncludesFalse Input":
	Interval[1, 10] properly includes Interval[4, 15]
define "IntegerIntervalProperlyIncludesFalse Output":
	false

define "DecimalIntervalProperlyIncludesTrue Input":
	Interval[1.0, 10.0] properly includes Interval[4.0, 10.0]
define "DecimalIntervalProperlyIncludesTrue Output":
	true

define "DecimalIntervalProperlyIncludesFalse Input":
	Interval[1.0, 10.0] properly includes Interval[4.0, 15.0]
define "DecimalIntervalProperlyIncludesFalse Output":
	false

define "QuantityIntervalProperlyIncludesTrue Input":
	Interval[1.0 'g', 10.0 'g'] properly includes Interval[5.0 'g', 10.0 'g']
define "QuantityIntervalProperlyIncludesTrue Output":
	true

define "QuantityIntervalProperlyIncludesFalse Input":
	Interval[1.0 'g', 10.0 'g'] properly includes Interval[5.0 'g', 15.0 'g']
define "QuantityIntervalProperlyIncludesFalse Output":
	false

define "DateTimeProperlyIncludesTrue Input":
	Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)] properly includes Interval[DateTime(2012, 1, 16), DateTime(2012, 1, 27)]
define "DateTimeProperlyIncludesTrue Output":
	true

define "DateTimeProperlyIncludesFalse Input":
	Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)] properly includes Interval[DateTime(2012, 1, 16), DateTime(2012, 1, 29)]
define "DateTimeProperlyIncludesFalse Output":
	false

define "TimeProperlyIncludesTrue Input":
	Interval[@T12:00:00.000, @T21:59:59.999] properly includes Interval[@T12:01:01.000, @T21:59:59.998]
define "TimeProperlyIncludesTrue Output":
	true

define "TimeProperlyIncludesFalse Input":
	Interval[@T12:00:00.000, @T21:59:59.999] properly includes Interval[@T12:01:01.000, @T22:00:00.000]
define "TimeProperlyIncludesFalse Output":
	false

define "IntegerIntervalProperlyIncludedInNullBoundaries Input":
	Interval[1, 10] properly included in Interval[null, null]
define "IntegerIntervalProperlyIncludedInNullBoundaries Output":
	null

define "IntegerIntervalProperlyIncludedInTrue Input":
	Interval[4, 10] properly included in Interval[1, 10]
define "IntegerIntervalProperlyIncludedInTrue Output":
	true

define "IntegerIntervalProperlyIncludedInFalse Input":
	Interval[4, 15] properly included in Interval[1, 10]
define "IntegerIntervalProperlyIncludedInFalse Output":
	false

define "DecimalIntervalProperlyIncludedInTrue Input":
	Interval[4.0, 10.0] properly included in Interval[1.0, 10.0]
define "DecimalIntervalProperlyIncludedInTrue Output":
	true

define "DecimalIntervalProperlyIncludedInFalse Input":
	Interval[4.0, 15.0] properly included in Interval[1.0, 10.0]
define "DecimalIntervalProperlyIncludedInFalse Output":
	false

define "QuantityIntervalProperlyIncludedInTrue Input":
	Interval[5.0 'g', 10.0 'g'] properly included in Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalProperlyIncludedInTrue Output":
	true

define "QuantityIntervalProperlyIncludedInFalse Input":
	Interval[1.0 'g', 10.0 'g'] properly included in Interval[5.0 'g', 15.0 'g']
define "QuantityIntervalProperlyIncludedInFalse Output":
	false

define "DateTimeProperlyIncludedInTrue Input":
	Interval[DateTime(2012, 1, 16), DateTime(2012, 1, 27)] properly included in Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)]
define "DateTimeProperlyIncludedInTrue Output":
	true

define "DateTimeProperlyIncludedInFalse Input":
	Interval[DateTime(2012, 1, 16), DateTime(2012, 1, 29)] properly included in Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)]
define "DateTimeProperlyIncludedInFalse Output":
	false

define "TimeProperlyIncludedInTrue Input":
	Interval[@T12:01:01.000, @T21:59:59.998] properly included in Interval[@T12:00:00.000, @T21:59:59.999]
define "TimeProperlyIncludedInTrue Output":
	true

define "TimeProperlyIncludedInFalse Input":
	Interval[@T12:01:01.000, @T22:00:00.000] properly included in Interval[@T12:00:00.000, @T21:59:59.999]
define "TimeProperlyIncludedInFalse Output":
	false

define "IntegerIntervalStart Input":
	start of Interval[1, 10]
define "IntegerIntervalStart Output":
	1

define "DecimalIntervalStart Input":
	start of Interval[1.0, 10.0]
define "DecimalIntervalStart Output":
	1.0

define "QuantityIntervalStart Input":
	start of Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalStart Output":
	1.0'g'

define "DateTimeIntervalStart Input":
	start of Interval[@2016-05-01T00:00:00.000, @2016-05-02T00:00:00.000]
define "DateTimeIntervalStart Output":
	@2016-05-01T00:00:00.000

define "TimeIntervalStart Input":
	start of Interval[@T00:00:00.000, @T23:59:59.599]
define "TimeIntervalStart Output":
	@T00:00:00.000

define "TestStartsNull Input":
	Interval[null, null] starts Interval[1, 10]
define "TestStartsNull Output":
	null

define "IntegerIntervalStartsTrue Input":
	Interval[4, 10] starts Interval[4, 15]
define "IntegerIntervalStartsTrue Output":
	true

define "IntegerIntervalStartsFalse Input":
	Interval[1, 10] starts Interval[4, 10]
define "IntegerIntervalStartsFalse Output":
	false

define "DecimalIntervalStartsTrue Input":
	Interval[4.0, 10.0] starts Interval[4.0, 15.0]
define "DecimalIntervalStartsTrue Output":
	true

define "DecimalIntervalStartsFalse Input":
	Interval[1.0, 10.0] starts Interval[4.0, 10.0]
define "DecimalIntervalStartsFalse Output":
	false

define "QuantityIntervalStartsTrue Input":
	Interval[5.0 'g', 10.0 'g'] starts Interval[5.0 'g', 15.0 'g']
define "QuantityIntervalStartsTrue Output":
	true

define "QuantityIntervalStartsFalse Input":
	Interval[1.0 'g', 10.0 'g'] starts Interval[5.0 'g', 10.0 'g']
define "QuantityIntervalStartsFalse Output":
	false

define "DateTimeStartsTrue Input":
	Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] starts Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 27)]
define "DateTimeStartsTrue Output":
	true

define "DateTimeStartsFalse Input":
	Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] starts Interval[DateTime(2012, 1, 6), DateTime(2012, 1, 27)]
define "DateTimeStartsFalse Output":
	false

define "TimeStartsTrue Input":
	Interval[@T05:59:59.999, @T15:59:59.999] starts Interval[@T05:59:59.999, @T17:59:59.999]
define "TimeStartsTrue Output":
	true

define "TimeStartsFalse Input":
	Interval[@T05:59:59.999, @T15:59:59.999] starts Interval[@T04:59:59.999, @T17:59:59.999]
define "TimeStartsFalse Output":
	false

define "TestUnionNull Input":
	Interval[null, null] union Interval[1, 10]
define "TestUnionNull Output":
	null

define "IntegerIntervalUnion1To15 Input":
	Interval[1, 10] union Interval[4, 15]
define "IntegerIntervalUnion1To15 Output":
	Interval [ 1, 15 ]

define "IntegerIntervalUnionNull Input":
	Interval[1, 10] union Interval[44, 50]
define "IntegerIntervalUnionNull Output":
	null

define "DecimalIntervalUnion1To15 Input":
	Interval[1.0, 10.0] union Interval[4.0, 15.0]
define "DecimalIntervalUnion1To15 Output":
	Interval [ 1.0, 15.0 ]

define "DecimalIntervalUnionNull Input":
	Interval[1.0, 10.0] union Interval[14.0, 15.0]
define "DecimalIntervalUnionNull Output":
	null

define "QuantityIntervalUnion1To15 Input":
	Interval[1.0 'g', 10.0 'g'] union Interval[5.0 'g', 15.0 'g']
define "QuantityIntervalUnion1To15 Output":
	Interval [ 1.0 'g', 15.0 'g' ]

define "QuantityIntervalUnionNull Input":
	Interval[1.0 'g', 10.0 'g'] union Interval[14.0 'g', 15.0 'g']
define "QuantityIntervalUnionNull Output":
	null

define "DateTimeUnion Input":
	Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] union Interval[DateTime(2012, 1, 25), DateTime(2012, 1, 28)]
define "DateTimeUnion Output":
	Interval [ @2012-01-05T, @2012-01-28T ]

define "DateTimeUnionNull Input":
	Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] union Interval[DateTime(2012, 1, 27), DateTime(2012, 1, 28)]
define "DateTimeUnionNull Output":
	null

define "TimeUnion Input":
	Interval[@T05:59:59.999, @T15:59:59.999] union Interval[@T10:59:59.999, @T20:59:59.999]
define "TimeUnion Output":
	Interval [ @T05:59:59.999, @T20:59:59.999 ]

define "TimeUnionNull Input":
	Interval[@T05:59:59.999, @T15:59:59.999] union Interval[@T16:59:59.999, @T20:59:59.999]
define "TimeUnionNull Output":
	null

define "IntegerIntervalTestWidth9 Input":
	width of Interval[1, 10]
define "IntegerIntervalTestWidth9 Output":
	9

define "IntervalTestWidthNull Input":
	width of (null as Interval<Any>)
define "IntervalTestWidthNull Output":
	null

define "DecimalIntervalTestWidth11 Input":
	width of Interval[4.0, 15.0]
define "DecimalIntervalTestWidth11 Output":
	11.0

define "QuantityIntervalTestWidth5 Input":
	width of Interval[5.0 'g', 10.0 'g']
define "QuantityIntervalTestWidth5 Output":
	5.0'g'

define "IntegerIntervalTest Input":
	Interval[1, 10]
define "IntegerIntervalTest Output":
	Interval[1, 10]

define "IntegerIntervalTest2 Input":
	Interval[11, 20]
define "IntegerIntervalTest2 Output":
	Interval[11, 20]

define "IntegerIntervalTest3 Input":
	Interval[44, 50]
define "IntegerIntervalTest3 Output":
	Interval[44, 50]

define "IntegerIntervalTest4 Input":
	Interval[4, 10]
define "IntegerIntervalTest4 Output":
	Interval[4, 10]

define "IntegerIntervalTest5 Input":
	Interval[4, 15]
define "IntegerIntervalTest5 Output":
	Interval[4, 15]

define "DecimalIntervalTest Input":
	Interval[1.0, 10.0]
define "DecimalIntervalTest Output":
	Interval[1.0, 10.0]

define "DecimalIntervalTest2 Input":
	Interval[11.0, 20.0]
define "DecimalIntervalTest2 Output":
	Interval[11.0, 20.0]

define "DecimalIntervalTest3 Input":
	Interval[4.0, 10.0]
define "DecimalIntervalTest3 Output":
	Interval[4.0, 10.0]

define "DecimalIntervalTest4 Input":
	Interval[4.0, 15.0]
define "DecimalIntervalTest4 Output":
	Interval[4.0, 15.0]

define "DecimalIntervalTest5 Input":
	Interval[14.0, 15.0]
define "DecimalIntervalTest5 Output":
	Interval[14.0, 15.0]

define "QuantityIntervalTest Input":
	Interval[1.0 'g', 10.0 'g']
define "QuantityIntervalTest Output":
	Interval[1.0 'g', 10.0 'g']

define "QuantityIntervalTest2 Input":
	Interval[11.0 'g', 20.0 'g']
define "QuantityIntervalTest2 Output":
	Interval[11.0 'g', 20.0 'g']

define "QuantityIntervalTest3 Input":
	Interval[5.0 'g', 10.0 'g']
define "QuantityIntervalTest3 Output":
	Interval[5.0 'g', 10.0 'g']

define "QuantityIntervalTest4 Input":
	Interval[5.0 'g', 15.0 'g']
define "QuantityIntervalTest4 Output":
	Interval[5.0 'g', 15.0 'g']

define "QuantityIntervalTest5 Input":
	Interval[14.0 'g', 15.0 'g']
define "QuantityIntervalTest5 Output":
	Interval[14.0 'g', 15.0 'g']

define "DateTimeIntervalTest Input":
	Interval[@2016-05-01T00:00:00.000, @2016-05-02T00:00:00.000]
define "DateTimeIntervalTest Output":
	Interval[@2016-05-01T00:00:00.000, @2016-05-02T00:00:00.000]

define "TimeIntervalTest Input":
	Interval[@T00:00:00.000, @T23:59:59.599]
define "TimeIntervalTest Output":
	Interval[@T00:00:00.000, @T23:59:59.599]

define "CollapseIntervalTestInteger Input":
	{Interval[1, 10], Interval[11, 20], Interval[44, 50]}
define "CollapseIntervalTestInteger Output":
	{Interval[1, 10], Interval[11, 20], Interval[44, 50]}

define "InvalidIntegerInterval":
	Interval[5, 3]

define "InvalidIntegerIntervalA":
	Interval[5, 5)
