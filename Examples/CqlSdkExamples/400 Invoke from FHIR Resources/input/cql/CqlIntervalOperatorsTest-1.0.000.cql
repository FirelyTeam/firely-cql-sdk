library CqlIntervalOperatorsTest version '1.0.000'

define "After.TestAfterNull": (null as Integer) after Interval[1, 10]

define "After.IntegerIntervalAfterTrue": Interval[11, 20] after Interval[1, 10]

define "After.IntegerIntervalAfterFalse": Interval[1, 10] after Interval[11, 20]

define "After.IntegerIntervalPointAfterTrue": 12 after Interval[1, 10]

define "After.IntegerIntervalPointAfterFalse": 9 after Interval[1, 10]

define "After.IntegerIntervalAfterPointTrue": Interval[11, 20] after 5

define "After.IntegerIntervalAfterPointFalse": Interval[11, 20] after 12

define "After.DecimalIntervalAfterTrue": Interval[11.0, 20.0] after Interval[1.0, 10.0]

define "After.DecimalIntervalAfterFalse": Interval[1.0, 10.0] after Interval[11.0, 20.0]

define "After.DecimalIntervalPointAfterTrue": 12.0 after Interval[1.0, 10.0]

define "After.DecimalIntervalPointAfterFalse": 9.0 after Interval[1.0, 10.0]

define "After.DecimalIntervalAfterPointTrue": Interval[11.0, 20.0] after 5.0

define "After.DecimalIntervalAfterPointFalse": Interval[11.0, 20.0] after 12.0

define "After.QuantityIntervalAfterTrue": Interval[11.0 'g', 20.0 'g'] after Interval[1.0 'g', 10.0 'g']

define "After.QuantityIntervalAfterFalse": Interval[1.0 'g', 10.0 'g'] after Interval[11.0 'g', 20.0 'g']

define "After.QuantityIntervalPointAfterTrue": 12.0'g' after Interval[1.0 'g', 10.0 'g']

define "After.QuantityIntervalPointAfterFalse": 9.0'g' after Interval[1.0 'g', 10.0 'g']

define "After.QuantityIntervalAfterPointTrue": Interval[11.0 'g', 20.0 'g'] after 5.0'g'

define "After.QuantityIntervalAfterPointFalse": Interval[11.0 'g', 20.0 'g'] after 12.0'g'

define "After.DateTimeAfterTrue": Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] after DateTime(2011, 12, 31)

define "After.DateTimeAfterFalse": Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] after DateTime(2012, 12, 31)

define "After.TimeAfterTrue": Interval[@T15:59:59.999, @T20:59:59.999] after @T12:59:59.999

define "After.TimeAfterFalse": Interval[@T15:59:59.999, @T20:59:59.999] after @T17:59:59.999

define "Before.TestBeforeNull": (null as Integer) before Interval[1, 10]

define "Before.IntegerIntervalBeforeFalse": Interval[11, 20] before Interval[1, 10]

define "Before.IntegerIntervalBeforeTrue": Interval[1, 10] before Interval[11, 20]

define "Before.IntegerIntervalPointBeforeTrue": 9 before Interval[11, 20]

define "Before.IntegerIntervalPointBeforeFalse": 9 before Interval[1, 10]

define "Before.IntegerIntervalBeforePointTrue": Interval[1, 10] before 11

define "Before.IntegerIntervalBeforePointFalse": Interval[1, 10] before 8

define "Before.DecimalIntervalBeforeFalse": Interval[11.0, 20.0] before Interval[1.0, 10.0]

define "Before.DecimalIntervalBeforeTrue": Interval[1.0, 10.0] before Interval[11.0, 20.0]

define "Before.DecimalIntervalPointBeforeTrue": 9.0 before Interval[11.0, 20.0]

define "Before.DecimalIntervalPointBeforeFalse": 9.0 before Interval[1.0, 10.0]

define "Before.DecimalIntervalBeforePointTrue": Interval[1.0, 10.0] before 11.0

define "Before.DecimalIntervalBeforePointFalse": Interval[1.0, 10.0] before 8.0

define "Before.QuantityIntervalBeforeTrue": Interval[1.0 'g', 10.0 'g'] before Interval[11.0 'g', 20.0 'g']

define "Before.QuantityIntervalBeforeFalse": Interval[11.0 'g', 20.0 'g'] before Interval[1.0 'g', 10.0 'g']

define "Before.QuantityIntervalPointBeforeTrue": Interval[1.0 'g', 10.0 'g'] before 12.0'g'

define "Before.QuantityIntervalPointBeforeFalse": Interval[1.0 'g', 10.0 'g'] before 9.0'g'

define "Before.QuantityIntervalBeforePointTrue": 5.0'g' before Interval[11.0 'g', 20.0 'g']

define "Before.QuantityIntervalBeforePointFalse": 12.0'g' before Interval[11.0 'g', 20.0 'g']

define "Before.DateTimeBeforeTrue": Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] before DateTime(2012, 2, 27)

define "Before.DateTimeBeforeFalse": Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] before DateTime(2011, 12, 31)

define "Before.TimeBeforeTrue": Interval[@T15:59:59.999, @T20:59:59.999] before @T22:59:59.999

define "Before.TimeBeforeFalse": Interval[@T15:59:59.999, @T20:59:59.999] before @T10:59:59.999

define "Collapse.TestCollapseNull": collapse {Interval(null, null)}

define "Collapse.IntegerIntervalCollapse": collapse { Interval[1,5], Interval[3,7], Interval[12,19], Interval[7,10] }

define "Collapse.IntegerIntervalCollapse2": collapse { Interval[1,2], Interval[3,7], Interval[10,19], Interval[7,10] }

define "Collapse.IntegerIntervalCollapse3": collapse { Interval[4,6], Interval[7,8] }

define "Collapse.DecimalIntervalCollapse": collapse { Interval[1.0,5.0], Interval[3.0,7.0], Interval[12.0,19.0], Interval[7.0,10.0] }

define "Collapse.DecimalIntervalCollapse2": collapse { Interval[4.0,6.0], Interval[6.00000001,8.0] }

define "Collapse.QuantityIntervalCollapse": collapse { Interval[1.0 'g',5.0 'g'], Interval[3.0 'g',7.0 'g'], Interval[12.0 'g',19.0 'g'], Interval[7.0 'g',10.0 'g'] }

define "Collapse.DateTimeCollapse": collapse { Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)], Interval[DateTime(2012, 1, 10), DateTime(2012, 1, 25)], Interval[DateTime(2012, 5, 10), DateTime(2012, 5, 25)], Interval[DateTime(2012, 5, 20), DateTime(2012, 5, 30)] }

define "Collapse.DateTimeCollapse2": collapse { Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)], Interval[DateTime(2012, 1, 16), DateTime(2012, 5, 25)] }

define "Collapse.TimeCollapse": collapse { Interval[@T01:59:59.999, @T10:59:59.999], Interval[@T08:59:59.999, @T15:59:59.999], Interval[@T17:59:59.999, @T20:59:59.999], Interval[@T18:59:59.999, @T22:59:59.999] }

define "Collapse.TimeCollapse2": collapse { Interval[@T01:59:59.999, @T10:59:59.999], Interval[@T11:00:00.000, @T15:59:59.999] }

define "Expand.ExpandPerDay": expand { Interval[@2018-01-01, @2018-01-04] } per day

define "Expand.ExpandPer2Days": expand { Interval[@2018-01-01, @2018-01-04] } per 2 days

define "Expand.ExpandPerHour": expand { Interval[@T10:00, @T12:30] } per hour

define "Expand.ExpandPer1": expand { Interval[10.0, 12.5] } per 1

define "Expand.ExpandPerMinute": expand { Interval[@T10, @T10] } per minute

define "Expand.ExpandPer0D1": expand { Interval[10, 10] } per 0.1

define "Expand.ExpandInterval": expand { Interval[1, 10] }

define "Expand.ExpandIntervalPer2": expand { Interval[1, 10] } per 2

define "Contains.TestContainsNull": Interval[1, 10] contains null

define "Contains.TestNullElement1": null contains 5

define "Contains.TestNullElement2": Interval[null, 5] contains 10

define "Contains.IntegerIntervalContainsTrue": Interval[1, 10] contains 5

define "Contains.IntegerIntervalContainsFalse": Interval[1, 10] contains 25

define "Contains.DecimalIntervalContainsTrue": Interval[1.0, 10.0] contains 8.0

define "Contains.DecimalIntervalContainsFalse": Interval[1.0, 10.0] contains 255.0

define "Contains.QuantityIntervalContainsTrue": Interval[1.0 'g', 10.0 'g'] contains 2.0 'g'

define "Contains.QuantityIntervalContainsFalse": Interval[1.0 'g', 10.0 'g'] contains 100.0 'g'

define "Contains.DateTimeContainsTrue": Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] contains DateTime(2012, 1, 10)

define "Contains.DateTimeContainsFalse": Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)] contains DateTime(2012, 1, 16)

define "Contains.TimeContainsTrue": Interval[@T01:59:59.999, @T10:59:59.999] contains @T05:59:59.999

define "Contains.TimeContainsFalse": Interval[@T01:59:59.999, @T10:59:59.999] contains @T15:59:59.999

define "End.IntegerIntervalEnd": end of Interval[1, 10]

define "End.DecimalIntervalEnd": end of Interval[1.0, 10.0]

define "End.QuantityIntervalEnd": end of Interval[1.0 'g', 10.0 'g']

define "End.DateTimeIntervalEnd": end of Interval[@2016-05-01T00:00:00.000, @2016-05-02T00:00:00.000]

define "End.TimeIntervalEnd": end of Interval[@T00:00:00.000, @T23:59:59.599]

define "Ends.TestEndsNull": Interval[1, 10] ends Interval(null, null)

define "Ends.IntegerIntervalEndsTrue": Interval[4, 10] ends Interval[1, 10]

define "Ends.IntegerIntervalEndsFalse": Interval[44, 50] ends Interval[1, 10]

define "Ends.DecimalIntervalEndsTrue": Interval[4.0, 10.0] ends Interval[1.0, 10.0]

define "Ends.DecimalIntervalEndsFalse": Interval[11.0, 20.0] ends Interval[1.0, 10.0]

define "Ends.QuantityIntervalEndsTrue": Interval[5.0 'g', 10.0 'g'] ends Interval[1.0 'g', 10.0 'g']

define "Ends.QuantityIntervalEndsFalse": Interval[11.0 'g', 20.0 'g'] ends Interval[1.0 'g', 10.0 'g']

define "Ends.DateTimeEndsTrue": Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] ends Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)]

define "Ends.DateTimeEndsFalse": Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] ends Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 16)]

define "Ends.TimeEndsTrue": Interval[@T05:59:59.999, @T10:59:59.999] ends Interval[@T01:59:59.999, @T10:59:59.999]

define "Ends.TimeEndsFalse": Interval[@T05:59:59.999, @T10:59:59.999] ends Interval[@T01:59:59.999, @T11:59:59.999]

define "Equal.TestEqualNull": Interval[1, 10] = Interval(null, null)

define "Equal.IntegerIntervalEqualTrue": Interval[1, 10] = Interval[1, 10]

define "Equal.IntegerIntervalEqualFalse": Interval[1, 10] = Interval[11, 20]

define "Equal.DecimalIntervalEqualTrue": Interval[1.0, 10.0] = Interval[1.0, 10.0]

define "Equal.DecimalIntervalEqualFalse": Interval[1.0, 10.0] = Interval[11.0, 20.0]

define "Equal.QuantityIntervalEqualTrue": Interval[1.0 'g', 10.0 'g'] = Interval[1.0 'g', 10.0 'g']

define "Equal.QuantityIntervalEqualFalse": Interval[1.0 'g', 10.0 'g'] = Interval[11.0 'g', 20.0 'g']

define "Equal.DateTimeEqualTrue": Interval[DateTime(2012, 1, 5, 0, 0, 0, 0), DateTime(2012, 1, 15, 0, 0, 0, 0)] = Interval[DateTime(2012, 1, 5, 0, 0, 0, 0), DateTime(2012, 1, 15, 0, 0, 0, 0)]

define "Equal.DateTimeEqualFalse": Interval[DateTime(2012, 1, 5, 0, 0, 0, 0), DateTime(2012, 1, 15, 0, 0, 0, 0)] = Interval[DateTime(2012, 1, 5, 0, 0, 0, 0), DateTime(2012, 1, 16, 0, 0, 0, 0)]

define "Equal.TimeEqualTrue": Interval[@T05:59:59.999, @T10:59:59.999] = Interval[@T05:59:59.999, @T10:59:59.999]

define "Equal.TimeEqualFalse": Interval[@T05:59:59.999, @T10:59:59.999] = Interval[@T05:59:59.999, @T10:58:59.999]

define "Except.NullInterval": Interval[null, null]

define "Except.TestExceptNull": Interval[null, null] except Interval[null, null]

define "Except.IntegerIntervalExcept1to3": Interval[1, 10] except Interval[4, 10]

define "Except.IntegerIntervalExceptNull": Interval[1, 10] except Interval[3, 7]

define "Except.DecimalIntervalExcept1to3": Interval[1.0, 10.0] except Interval[4.0, 10.0]

define "Except.DecimalIntervalExceptNull": Interval[1.0, 10.0] except Interval[3.0, 7.0]

define "Except.QuantityIntervalExcept1to4": Interval[1.0 'g', 10.0 'g'] except Interval[5.0 'g', 10.0 'g']

define "Except.Except12": Interval[1, 4] except Interval[3, 6]

define "Except.ExceptDateTimeInterval": Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] except Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 15)]

define "Except.ExceptDateTime2": Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 16)] except Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 12)]

define "Except.ExceptTimeInterval": Interval[@T05:59:59.999, @T10:59:59.999] except Interval[@T08:59:59.999, @T10:59:59.999]

define "Except.ExceptTime2": Interval[@T08:59:59.999, @T11:59:59.999] except Interval[@T05:59:59.999, @T10:59:59.999]

define "In.TestInNullBoundaries": 5 in Interval[null, null]

define "In.IntegerIntervalInTrue": 5 in Interval[1, 10]

define "In.IntegerIntervalInFalse": 500 in Interval[1, 10]

define "In.DecimalIntervalInTrue": 9.0 in Interval[1.0, 10.0]

define "In.DecimalIntervalInFalse": -2.0 in Interval[1.0, 10.0]

define "In.QuantityIntervalInTrue": 1.0 'g' in Interval[1.0 'g', 10.0 'g']

define "In.QuantityIntervalInFalse": 55.0 'g' in Interval[1.0 'g', 10.0 'g']

define "In.DateTimeInTrue": DateTime(2012, 1, 7) in Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)]

define "In.DateTimeInFalse": DateTime(2012, 1, 17) in Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)]

define "In.DateTimeInNullTrue": DateTime(2012, 1, 7) in Interval[DateTime(2012, 1, 5), null]

define "In.TimeInTrue": @T07:59:59.999 in Interval[@T05:59:59.999, @T10:59:59.999]

define "In.TimeInFalse": @T17:59:59.999 in Interval[@T05:59:59.999, @T10:59:59.999]

define "In.TimeInNull": null in Interval[@T05:59:59.999, @T10:59:59.999]

define "In.TestPeriod1": Interval[@2017-12-20T11:00:00, @2017-12-21T21:00:00]

define "In.TestPeriod2": Interval[@2017-12-20T10:30:00, @2017-12-20T12:00:00]

define "In.Issue32Interval": Interval[@2017-12-20T10:30:00, @2017-12-20T12:00:00]
				starts 1 day or less on or after day of start of
				Interval[@2017-12-20T11:00:00, @2017-12-21T21:00:00]

define "Includes.TestIncludesNull": Interval[1, 10] includes null

define "Includes.IntegerIntervalIncludesTrue": Interval[1, 10] includes Interval[4, 10]

define "Includes.IntegerIntervalIncludesFalse": Interval[1, 10] includes Interval[44, 50]

define "Includes.DecimalIntervalIncludesTrue": Interval[1.0, 10.0] includes Interval[4.0, 10.0]

define "Includes.DecimalIntervalIncludesFalse": Interval[1.0, 10.0] includes Interval[11.0, 20.0]

define "Includes.QuantityIntervalIncludesTrue": Interval[1.0 'g', 10.0 'g'] includes Interval[5.0 'g', 10.0 'g']

define "Includes.QuantityIntervalIncludesFalse": Interval[1.0 'g', 10.0 'g'] includes Interval[11.0 'g', 20.0 'g']

define "Includes.DateTimeIncludesTrue": Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] includes Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]

define "Includes.DateTimeIncludesFalse": Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)] includes Interval[DateTime(2012, 1, 4), DateTime(2012, 1, 14)]

define "Includes.TimeIncludesTrue": Interval[@T05:59:59.999, @T10:59:59.999] includes Interval[@T06:59:59.999, @T09:59:59.999]

define "Includes.TimeIncludesFalse": Interval[@T05:59:59.999, @T10:59:59.999] includes Interval[@T04:59:59.999, @T09:59:59.999]

define "Included In.TestIncludedInNull": null included in Interval[1, 10]

define "Included In.IntegerIntervalIncludedInTrue": Interval[4, 10] included in Interval[1, 10]

define "Included In.IntegerIntervalIncludedInFalse": Interval[44, 50] included in Interval[1, 10]

define "Included In.DecimalIntervalIncludedInTrue": Interval[4.0, 10.0] included in Interval[1.0, 10.0]

define "Included In.DecimalIntervalIncludedInFalse": Interval[11.0, 20.0] included in Interval[1.0, 10.0]

define "Included In.QuantityIntervalIncludedInTrue": Interval[5.0 'g', 10.0 'g'] included in Interval[1.0 'g', 10.0 'g']

define "Included In.QuantityIntervalIncludedInFalse": Interval[11.0 'g', 20.0 'g'] included in Interval[1.0 'g', 10.0 'g']

define "Included In.DateTimeIncludedInTrue": Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] included in Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)]

define "Included In.DateTimeIncludedInFalse": Interval[DateTime(2012, 1, 4), DateTime(2012, 1, 14)] included in Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)]

define "Included In.TimeIncludedInTrue": Interval[@T06:59:59.999, @T09:59:59.999] included in Interval[@T05:59:59.999, @T10:59:59.999]

define "Included In.TimeIncludedInFalse": Interval[@T04:59:59.999, @T09:59:59.999] included in Interval[@T05:59:59.999, @T10:59:59.999]

define "Included In.DateTimeIncludedInNull": Interval [@2017-09-01T00:00:00, @2017-09-01T00:00:00] included in Interval [@2017-09-01T00:00:00.000, @2017-12-30T23:59:59.999]

define "Included In.DateTimeIncludedInPrecisionTrue": Interval [@2017-09-01T00:00:00, @2017-09-01T00:00:00] included in day of Interval [@2017-09-01T00:00:00.000, @2017-12-30T23:59:59.999]

define "Included In.DateTimeIncludedInPrecisionNull": Interval [@2017-09-01T00:00:00, @2017-09-01T00:00:00] included in millisecond of Interval [@2017-09-01T00:00:00.000, @2017-12-30T23:59:59.999]

define "Intersect.TestIntersectNull": Interval[1, 10] intersect Interval[5, null)

define "Intersect.TestIntersectNull1": start of (Interval[1, 10] intersect Interval[5, null)) <= 10

define "Intersect.TestIntersectNull2": start of (Interval[1, 10] intersect Interval[5, null)) >= 5

define "Intersect.TestIntersectNull3": start of (Interval[1, 10] intersect Interval[5, null)) > 10

define "Intersect.TestIntersectNull4": start of (Interval[1, 10] intersect Interval[5, null)) < 5

define "Intersect.IntegerIntervalIntersectTest4to10": Interval[1, 10] intersect Interval[4, 10]

define "Intersect.IntegerIntervalIntersectTestNull": Interval[1, 10] intersect Interval[11, 20]

define "Intersect.DecimalIntervalIntersectTest4to10": Interval[1.0, 10.0] intersect Interval[4.0, 10.0]

define "Intersect.DecimalIntervalIntersectTestNull": Interval[1.0, 10.0] intersect Interval[11.0, 20.0]

define "Intersect.QuantityIntervalIntersectTest5to10": Interval[1.0 'g', 10.0 'g'] intersect Interval[5.0 'g', 10.0 'g']

define "Intersect.QuantityIntervalIntersectTestNull": Interval[1.0 'g', 10.0 'g'] intersect Interval[11.0 'g', 20.0 'g']

define "Intersect.DateTimeIntersect": Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] intersect Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 10)]

define "Intersect.TimeIntersect": Interval[@T04:59:59.999, @T09:59:59.999] intersect Interval[@T04:59:59.999, @T06:59:59.999]

define "Equivalent.IntegerIntervalEquivalentTrue": Interval[1, 10] ~ Interval[1, 10]

define "Equivalent.IntegerIntervalEquivalentFalse": Interval[44, 50] ~ Interval[1, 10]

define "Equivalent.DecimalIntervalEquivalentTrue": Interval[1.0, 10.0] ~ Interval[1.0, 10.0]

define "Equivalent.DecimalIntervalEquivalentFalse": Interval[11.0, 20.0] ~ Interval[1.0, 10.0]

define "Equivalent.QuantityIntervalEquivalentTrue": Interval[1.0 'g', 10.0 'g'] ~ Interval[1.0 'g', 10.0 'g']

define "Equivalent.QuantityIntervalEquivalentFalse": Interval[11.0 'g', 20.0 'g'] ~ Interval[1.0 'g', 10.0 'g']

define "Equivalent.DateTimeEquivalentTrue": Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] ~ Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]

define "Equivalent.DateTimeEquivalentFalse": Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] ~ Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 15)]

define "Equivalent.TimeEquivalentTrue": Interval[@T04:59:59.999, @T09:59:59.999] ~ Interval[@T04:59:59.999, @T09:59:59.999]

define "Equivalent.TimeEquivalentFalse": Interval[@T04:59:59.999, @T09:59:59.999] ~ Interval[@T04:58:59.999, @T09:59:59.999]

define "Meets.TestMeetsNull": Interval(null, 5] meets Interval(null, 15)

define "Meets.IntegerIntervalMeetsTrue": Interval[1, 10] meets Interval[11, 20]

define "Meets.IntegerIntervalMeetsFalse": Interval[1, 10] meets Interval[44, 50]

define "Meets.DecimalIntervalMeetsTrue": Interval[3.01, 5.00000001] meets Interval[5.00000002, 8.50]

define "Meets.DecimalIntervalMeetsFalse": Interval[3.01, 5.00000001] meets Interval[5.5, 8.50]

define "Meets.QuantityIntervalMeetsTrue": Interval[3.01 'g', 5.00000001 'g'] meets Interval[5.00000002 'g', 8.50 'g']

define "Meets.QuantityIntervalMeetsFalse": Interval[3.01 'g', 5.00000001 'g'] meets Interval[5.5 'g', 8.50 'g']

define "Meets.DateTimeMeetsTrue": Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] meets Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 25)]

define "Meets.DateTimeMeetsFalse": Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] meets Interval[DateTime(2012, 1, 20), DateTime(2012, 1, 25)]

define "Meets.TimeMeetsTrue": Interval[@T04:59:59.999, @T09:59:59.999] meets Interval[@T10:00:00.000, @T19:59:59.999]

define "Meets.TimeMeetsFalse": Interval[@T04:59:59.999, @T09:59:59.999] meets Interval[@T10:12:00.000, @T19:59:59.999]

define "MeetsBefore.TestMeetsBeforeNull": Interval(null, 5] meets before Interval(null, 25]

define "MeetsBefore.IntegerIntervalMeetsBeforeTrue": Interval[1, 10] meets before Interval[11, 20]

define "MeetsBefore.IntegerIntervalMeetsBeforeFalse": Interval[1, 10] meets before Interval[44, 50]

define "MeetsBefore.DecimalIntervalMeetsBeforeTrue": Interval[3.50000001, 5.00000011] meets before Interval[5.00000012, 8.50]

define "MeetsBefore.DecimalIntervalMeetsBeforeFalse": Interval[8.01, 15.00000001] meets before Interval[15.00000000, 18.50]

define "MeetsBefore.QuantityIntervalMeetsBeforeTrue": Interval[3.50000001 'g', 5.00000011 'g'] meets before Interval[5.00000012 'g', 8.50 'g']

define "MeetsBefore.QuantityIntervalMeetsBeforeFalse": Interval[8.01 'g', 15.00000001 'g'] meets before Interval[15.00000000 'g', 18.50 'g']

define "MeetsBefore.DateTimeMeetsBeforeTrue": Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] meets Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 25)]

define "MeetsBefore.DateTimeMeetsBeforeFalse": Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)] meets Interval[DateTime(2012, 1, 20), DateTime(2012, 1, 25)]

define "MeetsBefore.TimeMeetsBeforeTrue": Interval[@T04:59:59.999, @T09:59:59.999] meets Interval[@T10:00:00.000, @T19:59:59.999]

define "MeetsBefore.TimeMeetsBeforeFalse": Interval[@T04:59:59.999, @T09:59:59.999] meets Interval[@T10:12:00.000, @T19:59:59.999]

define "MeetsAfter.TestMeetsAfterNull": Interval(null, 5] meets after Interval[11, null)

define "MeetsAfter.IntegerIntervalMeetsAfterTrue": Interval[11, 20] meets after Interval[1, 10]

define "MeetsAfter.IntegerIntervalMeetsAfterFalse": Interval[44, 50] meets after Interval[1, 10]

define "MeetsAfter.DecimalIntervalMeetsAfterTrue": Interval[55.00000123, 128.032156] meets after Interval[12.00258, 55.00000122]

define "MeetsAfter.DecimalIntervalMeetsAfterFalse": Interval[55.00000124, 150.222222] meets after Interval[12.00258, 55.00000122]

define "MeetsAfter.QuantityIntervalMeetsAfterTrue": Interval[55.00000123 'g', 128.032156 'g'] meets after Interval[12.00258 'g', 55.00000122 'g']

define "MeetsAfter.QuantityIntervalMeetsAfterFalse": Interval[55.00000124 'g', 150.222222 'g'] meets after Interval[12.00258 'g', 55.00000122 'g']

define "MeetsAfter.DateTimeMeetsAfterTrue": Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 25)] meets Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]

define "MeetsAfter.DateTimeMeetsAfterFalse": Interval[DateTime(2012, 1, 20), DateTime(2012, 1, 25)] meets Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]

define "MeetsAfter.TimeMeetsAfterTrue": Interval[@T10:00:00.000, @T19:59:59.999] meets Interval[@T04:59:59.999, @T09:59:59.999]

define "MeetsAfter.TimeMeetsAfterFalse": Interval[@T10:12:00.000, @T19:59:59.999] meets Interval[@T04:59:59.999, @T09:59:59.999]

define "NotEqual.IntegerIntervalNotEqualTrue": Interval[1, 10] != Interval[11, 20]

define "NotEqual.IntegerIntervalNotEqualFalse": Interval[1, 10] != Interval[1, 10]

define "NotEqual.DecimalIntervalNotEqualTrue": Interval[1.0, 10.0] != Interval[11.0, 20.0]

define "NotEqual.DecimalIntervalNotEqualFalse": Interval[1.0, 10.0] != Interval[1.0, 10.0]

define "NotEqual.QuantityIntervalNotEqualTrue": Interval[1.0 'g', 10.0 'g'] != Interval[11.0 'g', 20.0 'g']

define "NotEqual.QuantityIntervalNotEqualFalse": Interval[1.0 'g', 10.0 'g'] != Interval[1.0 'g', 10.0 'g']

define "NotEqual.DateTimeNotEqualTrue": Interval[DateTime(2012, 1, 15, 0, 0, 0, 0), DateTime(2012, 1, 25, 0, 0, 0, 0)] != Interval[DateTime(2012, 1, 15, 0, 0, 0, 0), DateTime(2012, 1, 25, 0, 0, 0, 22)]

define "NotEqual.DateTimeNotEqualFalse": Interval[DateTime(2012, 1, 15, 0, 0, 0, 0), DateTime(2012, 1, 25, 0, 0, 0, 0)] != Interval[DateTime(2012, 1, 15, 0, 0, 0, 0), DateTime(2012, 1, 25, 0, 0, 0, 0)]

define "NotEqual.TimeNotEqualTrue": Interval[@T10:00:00.000, @T19:59:59.999] != Interval[@T10:10:00.000, @T19:59:59.999]

define "NotEqual.TimeNotEqualFalse": Interval[@T10:00:00.000, @T19:59:59.999] != Interval[@T10:00:00.000, @T19:59:59.999]

define "OnOrAfter.TestOnOrAfterNull": Interval[@2012-12-01, @2013-12-01] on or after (null as Interval<Date>)

define "OnOrAfter.TestOnOrAfterDateTrue": Interval[@2012-12-01, @2013-12-01] on or after month of @2012-11-15

define "OnOrAfter.TestOnOrAfterDateFalse": @2012-11-15 on or after month of Interval[@2012-12-01, @2013-12-01]

define "OnOrAfter.TestOnOrAfterTimeTrue": Interval[@T10:00:00.000, @T19:59:59.999] on or after hour of Interval[@T08:00:00.000, @T09:59:59.999]

define "OnOrAfter.TestOnOrAfterTimeFalse": Interval[@T10:00:00.000, @T19:59:59.999] on or after hour of Interval[@T08:00:00.000, @T11:59:59.999]

define "OnOrAfter.TestOnOrAfterIntegerTrue": Interval[6, 10] on or after 6

define "OnOrAfter.TestOnOrAfterDecimalFalse": 2.5 on or after Interval[1.666, 2.50000001]

define "OnOrAfter.TestOnOrAfterQuantityTrue": 2.5 'mg' on or after Interval[1.666 'mg', 2.50000000 'mg']

define "OnOrBefore.TestOnOrBeforeNull": Interval[@2012-12-01, @2013-12-01] on or before (null as Interval<Date>)

define "OnOrBefore.TestOnOrBeforeDateTrue": Interval[@2012-10-01, @2012-11-01] on or before month of @2012-11-15

define "OnOrBefore.TestOnOrBeforeDateFalse": @2012-11-15 on or before month of Interval[@2012-10-01, @2013-12-01]

define "OnOrBefore.TestOnOrBeforeTimeTrue": Interval[@T05:00:00.000, @T07:59:59.999] on or before hour of Interval[@T08:00:00.000, @T09:59:59.999]

define "OnOrBefore.TestOnOrBeforeTimeFalse": Interval[@T10:00:00.000, @T19:59:59.999] on or before hour of Interval[@T08:00:00.000, @T11:59:59.999]

define "OnOrBefore.TestOnOrBeforeIntegerTrue": Interval[4, 6] on or before 6

define "OnOrBefore.TestOnOrBeforeDecimalFalse": 1.6667 on or before Interval[1.666, 2.50000001]

define "OnOrBefore.TestOnOrBeforeQuantityTrue": 1.666 'mg' on or before Interval[1.666 'mg', 2.50000000 'mg']

define "Overlaps.TestOverlapsNull": Interval[null, null] overlaps Interval[1, 10]

define "Overlaps.IntegerIntervalOverlapsTrue": Interval[1, 10] overlaps Interval[4, 10]

define "Overlaps.IntegerIntervalOverlapsFalse": Interval[1, 10] overlaps Interval[11, 20]

define "Overlaps.DecimalIntervalOverlapsTrue": Interval[1.0, 10.0] overlaps Interval[4.0, 10.0]

define "Overlaps.DecimalIntervalOverlapsFalse": Interval[1.0, 10.0] overlaps Interval[11.0, 20.0]

define "Overlaps.QuantityIntervalOverlapsTrue": Interval[1.0 'g', 10.0 'g'] overlaps Interval[5.0 'g', 10.0 'g']

define "Overlaps.QuantityIntervalOverlapsFalse": Interval[1.0 'g', 10.0 'g'] overlaps Interval[11.0 'g', 20.0 'g']

define "Overlaps.DateTimeOverlapsTrue": Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] overlaps Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)]

define "Overlaps.DateTimeOverlapsFalse": Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] overlaps Interval[DateTime(2012, 1, 26), DateTime(2012, 1, 28)]

define "Overlaps.TimeOverlapsTrue": Interval[@T10:00:00.000, @T19:59:59.999] overlaps Interval[@T12:00:00.000, @T21:59:59.999]

define "Overlaps.TimeOverlapsFalse": Interval[@T10:00:00.000, @T19:59:59.999] overlaps Interval[@T20:00:00.000, @T21:59:59.999]

define "OverlapsBefore.TestOverlapsBeforeNull": Interval[null, null] overlaps before Interval[1, 10]

define "OverlapsBefore.IntegerIntervalOverlapsBeforeTrue": Interval[1, 10] overlaps before Interval[4, 10]

define "OverlapsBefore.IntegerIntervalOverlapsBeforeFalse": Interval[4, 10] overlaps before Interval[1, 10]

define "OverlapsBefore.DecimalIntervalOverlapsBeforeTrue": Interval[1.0, 10.0] overlaps before Interval[4.0, 10.0]

define "OverlapsBefore.DecimalIntervalOverlapsBeforeFalse": Interval[4.0, 10.0] overlaps before Interval[1.0, 10.0]

define "OverlapsBefore.QuantityIntervalOverlapsBeforeTrue": Interval[1.0 'g', 10.0 'g'] overlaps before Interval[5.0 'g', 10.0 'g']

define "OverlapsBefore.QuantityIntervalOverlapsBeforeFalse": Interval[5.0 'g', 10.0 'g'] overlaps before Interval[1.0 'g', 10.0 'g']

define "OverlapsBefore.DateTimeOverlapsBeforeTrue": Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] overlaps Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)]

define "OverlapsBefore.DateTimeOverlapsBeforeFalse": Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] overlaps Interval[DateTime(2012, 1, 26), DateTime(2012, 1, 28)]

define "OverlapsBefore.TimeOverlapsBeforeTrue": Interval[@T10:00:00.000, @T19:59:59.999] overlaps Interval[@T12:00:00.000, @T21:59:59.999]

define "OverlapsBefore.TimeOverlapsBeforeFalse": Interval[@T10:00:00.000, @T19:59:59.999] overlaps Interval[@T20:00:00.000, @T21:59:59.999]

define "OverlapsAfter.TestOverlapsAfterNull": Interval[null, null] overlaps after Interval[1, 10]

define "OverlapsAfter.IntegerIntervalOverlapsAfterTrue": Interval[4, 15] overlaps after Interval[1, 10]

define "OverlapsAfter.IntegerIntervalOverlapsAfterFalse": Interval[4, 10] overlaps after Interval[1, 10]

define "OverlapsAfter.DecimalIntervalOverlapsAfterTrue": Interval[4.0, 15.0] overlaps after Interval[1.0, 10.0]

define "OverlapsAfter.DecimalIntervalOverlapsAfterFalse": Interval[4.0, 10.0] overlaps after Interval[1.0, 10.0]

define "OverlapsAfter.QuantityIntervalOverlapsAfterTrue": Interval[5.0 'g', 15.0 'g'] overlaps after Interval[1.0 'g', 10.0 'g']

define "OverlapsAfter.QuantityIntervalOverlapsAfterFalse": Interval[5.0 'g', 10.0 'g'] overlaps after Interval[1.0 'g', 10.0 'g']

define "OverlapsAfter.DateTimeOverlapsAfterTrue": Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)] overlaps Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)]

define "OverlapsAfter.DateTimeOverlapsAfterFalse": Interval[DateTime(2012, 1, 26), DateTime(2012, 1, 28)] overlaps Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)]

define "OverlapsAfter.TimeOverlapsAfterTrue": Interval[@T12:00:00.000, @T21:59:59.999] overlaps Interval[@T10:00:00.000, @T19:59:59.999]

define "OverlapsAfter.TimeOverlapsAfterFalse": Interval[@T20:00:00.000, @T21:59:59.999] overlaps Interval[@T10:00:00.000, @T19:59:59.999]

define "PointFrom.TestPointFromNull": point from Interval[null, null]

define "PointFrom.TestPointFromInteger": point from Interval[1, 1]

define "PointFrom.TestPointFromDecimal": point from Interval[1.0, 1.0]

define "PointFrom.TestPointFromQuantity": point from Interval[1.0 'cm', 1.0 'cm']

define "ProperContains.TimeProperContainsTrue": Interval[@T12:00:00.000, @T21:59:59.999] properly includes @T12:00:00.001

define "ProperContains.TimeProperContainsFalse": Interval[@T12:00:00.000, @T21:59:59.999] properly includes @T12:00:00.000

define "ProperContains.TimeProperContainsNull": Interval[@T12:00:00.001, @T21:59:59.999] properly includes @T12:00:00

define "ProperContains.TimeProperContainsPrecisionTrue": Interval[@T12:00:00.000, @T21:59:59.999] properly includes second of @T12:00:01

define "ProperContains.TimeProperContainsPrecisionFalse": Interval[@T12:00:00.001, @T21:59:59.999] properly includes second of @T12:00:00

define "ProperContains.TimeProperContainsPrecisionNull": Interval[@T12:00:00.001, @T21:59:59.999] properly includes millisecond of @T12:00:00

define "ProperIn.TimeProperInTrue": @T12:00:00.001 properly included in Interval[@T12:00:00.000, @T21:59:59.999]

define "ProperIn.TimeProperInFalse": @T12:00:00.000 properly included in  Interval[@T12:00:00.000, @T21:59:59.999]

define "ProperIn.TimeProperInNull": @T12:00:00 properly included in Interval[@T12:00:00.001, @T21:59:59.999]

define "ProperIn.TimeProperInPrecisionTrue": @T12:00:01 properly included in second of Interval[@T12:00:00.000, @T21:59:59.999]

define "ProperIn.TimeProperInPrecisionFalse": @T12:00:00 properly included in second of Interval[@T12:00:00.001, @T21:59:59.999]

define "ProperIn.TimeProperInPrecisionNull": @T12:00:00 properly included in millisecond of Interval[@T12:00:00.001, @T21:59:59.999]

define "ProperlyIncludes.NullBoundariesProperlyIncludesIntegerInterval": Interval[null as Integer, null as Integer] properly includes Interval[1, 10]

define "ProperlyIncludes.IntegerIntervalProperlyIncludesTrue": Interval[1, 10] properly includes Interval[4, 10]

define "ProperlyIncludes.IntegerIntervalProperlyIncludesFalse": Interval[1, 10] properly includes Interval[4, 15]

define "ProperlyIncludes.DecimalIntervalProperlyIncludesTrue": Interval[1.0, 10.0] properly includes Interval[4.0, 10.0]

define "ProperlyIncludes.DecimalIntervalProperlyIncludesFalse": Interval[1.0, 10.0] properly includes Interval[4.0, 15.0]

define "ProperlyIncludes.QuantityIntervalProperlyIncludesTrue": Interval[1.0 'g', 10.0 'g'] properly includes Interval[5.0 'g', 10.0 'g']

define "ProperlyIncludes.QuantityIntervalProperlyIncludesFalse": Interval[1.0 'g', 10.0 'g'] properly includes Interval[5.0 'g', 15.0 'g']

define "ProperlyIncludes.DateTimeProperlyIncludesTrue": Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)] properly includes Interval[DateTime(2012, 1, 16), DateTime(2012, 1, 27)]

define "ProperlyIncludes.DateTimeProperlyIncludesFalse": Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)] properly includes Interval[DateTime(2012, 1, 16), DateTime(2012, 1, 29)]

define "ProperlyIncludes.TimeProperlyIncludesTrue": Interval[@T12:00:00.000, @T21:59:59.999] properly includes Interval[@T12:01:01.000, @T21:59:59.998]

define "ProperlyIncludes.TimeProperlyIncludesFalse": Interval[@T12:00:00.000, @T21:59:59.999] properly includes Interval[@T12:01:01.000, @T22:00:00.000]

define "ProperlyIncludedIn.IntegerIntervalProperlyIncludedInNullBoundaries": Interval[1, 10] properly included in Interval[null, null]

define "ProperlyIncludedIn.IntegerIntervalProperlyIncludedInTrue": Interval[4, 10] properly included in Interval[1, 10]

define "ProperlyIncludedIn.IntegerIntervalProperlyIncludedInFalse": Interval[4, 15] properly included in Interval[1, 10]

define "ProperlyIncludedIn.DecimalIntervalProperlyIncludedInTrue": Interval[4.0, 10.0] properly included in Interval[1.0, 10.0]

define "ProperlyIncludedIn.DecimalIntervalProperlyIncludedInFalse": Interval[4.0, 15.0] properly included in Interval[1.0, 10.0]

define "ProperlyIncludedIn.QuantityIntervalProperlyIncludedInTrue": Interval[5.0 'g', 10.0 'g'] properly included in Interval[1.0 'g', 10.0 'g']

define "ProperlyIncludedIn.QuantityIntervalProperlyIncludedInFalse": Interval[1.0 'g', 10.0 'g'] properly included in Interval[5.0 'g', 15.0 'g']

define "ProperlyIncludedIn.DateTimeProperlyIncludedInTrue": Interval[DateTime(2012, 1, 16), DateTime(2012, 1, 27)] properly included in Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)]

define "ProperlyIncludedIn.DateTimeProperlyIncludedInFalse": Interval[DateTime(2012, 1, 16), DateTime(2012, 1, 29)] properly included in Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)]

define "ProperlyIncludedIn.TimeProperlyIncludedInTrue": Interval[@T12:01:01.000, @T21:59:59.998] properly included in Interval[@T12:00:00.000, @T21:59:59.999]

define "ProperlyIncludedIn.TimeProperlyIncludedInFalse": Interval[@T12:01:01.000, @T22:00:00.000] properly included in Interval[@T12:00:00.000, @T21:59:59.999]

define "Start.IntegerIntervalStart": start of Interval[1, 10]

define "Start.DecimalIntervalStart": start of Interval[1.0, 10.0]

define "Start.QuantityIntervalStart": start of Interval[1.0 'g', 10.0 'g']

define "Start.DateTimeIntervalStart": start of Interval[@2016-05-01T00:00:00.000, @2016-05-02T00:00:00.000]

define "Start.TimeIntervalStart": start of Interval[@T00:00:00.000, @T23:59:59.599]

define "Starts.TestStartsNull": Interval[null, null] starts Interval[1, 10]

define "Starts.IntegerIntervalStartsTrue": Interval[4, 10] starts Interval[4, 15]

define "Starts.IntegerIntervalStartsFalse": Interval[1, 10] starts Interval[4, 10]

define "Starts.DecimalIntervalStartsTrue": Interval[4.0, 10.0] starts Interval[4.0, 15.0]

define "Starts.DecimalIntervalStartsFalse": Interval[1.0, 10.0] starts Interval[4.0, 10.0]

define "Starts.QuantityIntervalStartsTrue": Interval[5.0 'g', 10.0 'g'] starts Interval[5.0 'g', 15.0 'g']

define "Starts.QuantityIntervalStartsFalse": Interval[1.0 'g', 10.0 'g'] starts Interval[5.0 'g', 10.0 'g']

define "Starts.DateTimeStartsTrue": Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] starts Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 27)]

define "Starts.DateTimeStartsFalse": Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] starts Interval[DateTime(2012, 1, 6), DateTime(2012, 1, 27)]

define "Starts.TimeStartsTrue": Interval[@T05:59:59.999, @T15:59:59.999] starts Interval[@T05:59:59.999, @T17:59:59.999]

define "Starts.TimeStartsFalse": Interval[@T05:59:59.999, @T15:59:59.999] starts Interval[@T04:59:59.999, @T17:59:59.999]

define "Union.TestUnionNull": Interval[null, null] union Interval[1, 10]

define "Union.IntegerIntervalUnion1To15": Interval[1, 10] union Interval[4, 15]

define "Union.IntegerIntervalUnionNull": Interval[1, 10] union Interval[44, 50]

define "Union.DecimalIntervalUnion1To15": Interval[1.0, 10.0] union Interval[4.0, 15.0]

define "Union.DecimalIntervalUnionNull": Interval[1.0, 10.0] union Interval[14.0, 15.0]

define "Union.QuantityIntervalUnion1To15": Interval[1.0 'g', 10.0 'g'] union Interval[5.0 'g', 15.0 'g']

define "Union.QuantityIntervalUnionNull": Interval[1.0 'g', 10.0 'g'] union Interval[14.0 'g', 15.0 'g']

define "Union.DateTimeUnion": Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] union Interval[DateTime(2012, 1, 25), DateTime(2012, 1, 28)]

define "Union.DateTimeUnionNull": Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)] union Interval[DateTime(2012, 1, 27), DateTime(2012, 1, 28)]

define "Union.TimeUnion": Interval[@T05:59:59.999, @T15:59:59.999] union Interval[@T10:59:59.999, @T20:59:59.999]

define "Union.TimeUnionNull": Interval[@T05:59:59.999, @T15:59:59.999] union Interval[@T16:59:59.999, @T20:59:59.999]

define "Width.IntegerIntervalTestWidth9": width of Interval[1, 10]

define "Width.IntervalTestWidthNull": width of (null as Interval<Any>)

define "Width.DecimalIntervalTestWidth11": width of Interval[4.0, 15.0]

define "Width.QuantityIntervalTestWidth5": width of Interval[5.0 'g', 10.0 'g']

define "Width.DateTimeWidth": width of Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)]

define "Width.TimeWidth": width of Interval[@T05:59:59.999, @T15:59:59.999]

define "Interval.IntegerIntervalTest": Interval[1, 10]

define "Interval.IntegerIntervalTest2": Interval[11, 20]

define "Interval.IntegerIntervalTest3": Interval[44, 50]

define "Interval.IntegerIntervalTest4": Interval[4, 10]

define "Interval.IntegerIntervalTest5": Interval[4, 15]

define "Interval.DecimalIntervalTest": Interval[1.0, 10.0]

define "Interval.DecimalIntervalTest2": Interval[11.0, 20.0]

define "Interval.DecimalIntervalTest3": Interval[4.0, 10.0]

define "Interval.DecimalIntervalTest4": Interval[4.0, 15.0]

define "Interval.DecimalIntervalTest5": Interval[14.0, 15.0]

define "Interval.QuantityIntervalTest": Interval[1.0 'g', 10.0 'g']

define "Interval.QuantityIntervalTest2": Interval[11.0 'g', 20.0 'g']

define "Interval.QuantityIntervalTest3": Interval[5.0 'g', 10.0 'g']

define "Interval.QuantityIntervalTest4": Interval[5.0 'g', 15.0 'g']

define "Interval.QuantityIntervalTest5": Interval[14.0 'g', 15.0 'g']

define "Interval.DateTimeIntervalTest": Interval[@2016-05-01T00:00:00.000, @2016-05-02T00:00:00.000]

define "Interval.TimeIntervalTest": Interval[@T00:00:00.000, @T23:59:59.599]

define "Interval.CollapseIntervalTestInteger": {Interval[1, 10], Interval[11, 20], Interval[44, 50]}

define "Interval.InvalidIntegerInterval": Interval[5, 3]

define "Interval.InvalidIntegerIntervalA": Interval[5, 5)

