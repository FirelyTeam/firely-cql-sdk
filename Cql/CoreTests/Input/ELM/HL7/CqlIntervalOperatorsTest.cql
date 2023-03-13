library CqlIntervalOperatorsTest version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

context Patient

define "TestAfterNull":
  ( null as Interval<Integer>after Interval[1, 10]) = null

define "IntegerIntervalAfterTrue":
  ( Interval[11, 20]after Interval[1, 10]) = true

define "IntegerIntervalAfterFalse":
  ( Interval[1, 10]after Interval[11, 20]) = false

define "IntegerIntervalPointAfterTrue":
  ( 12 after Interval[1, 10]) = true

define "IntegerIntervalPointAfterFalse":
  ( 9 after Interval[1, 10]) = false

define "IntegerIntervalAfterPointTrue":
  ( Interval[11, 20]after 5 ) = true

define "IntegerIntervalAfterPointFalse":
  ( Interval[11, 20]after 12 ) = false

define "DecimalIntervalAfterTrue":
  ( Interval[11.0, 20.0]after Interval[1.0, 10.0]) = true

define "DecimalIntervalAfterFalse":
  ( Interval[1.0, 10.0]after Interval[11.0, 20.0]) = false

define "DecimalIntervalPointAfterTrue":
  ( 12.0 after Interval[1.0, 10.0]) = true

define "DecimalIntervalPointAfterFalse":
  ( 9.0 after Interval[1.0, 10.0]) = false

define "DecimalIntervalAfterPointTrue":
  ( Interval[11.0, 20.0]after 5.0 ) = true

define "DecimalIntervalAfterPointFalse":
  ( Interval[11.0, 20.0]after 12.0 ) = false

define "QuantityIntervalAfterTrue":
  ( Interval[11.0 'g', 20.0 'g']after Interval[1.0 'g', 10.0 'g']) = true

define "QuantityIntervalAfterFalse":
  ( Interval[1.0 'g', 10.0 'g']after Interval[11.0 'g', 20.0 'g']) = false

define "QuantityIntervalPointAfterTrue":
  ( 12.0 'g' after Interval[1.0 'g', 10.0 'g']) = true

define "QuantityIntervalPointAfterFalse":
  ( 9.0 'g' after Interval[1.0 'g', 10.0 'g']) = false

define "QuantityIntervalAfterPointTrue":
  ( Interval[11.0 'g', 20.0 'g']after 5.0 'g' ) = true

define "QuantityIntervalAfterPointFalse":
  ( Interval[11.0 'g', 20.0 'g']after 12.0 'g' ) = false

define "DateTimeAfterTrue":
  ( Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)]after DateTime(2011, 12, 31)) = true

define "DateTimeAfterFalse":
  ( Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)]after DateTime(2012, 12, 31)) = false

define "TimeAfterTrue":
  ( Interval[@T15:59:59.999, @T20:59:59.999]after @T12:59:59.999 ) = true

define "TimeAfterFalse":
  ( Interval[@T15:59:59.999, @T20:59:59.999]after @T17:59:59.999 ) = false

define "TestBeforeNull":
  ( null as Interval<Integer>before Interval[1, 10]) = null

define "IntegerIntervalBeforeFalse":
  ( Interval[11, 20]before Interval[1, 10]) = false

define "IntegerIntervalBeforeTrue":
  ( Interval[1, 10]before Interval[11, 20]) = true

define "IntegerIntervalPointBeforeTrue":
  ( 9 before Interval[11, 20]) = true

define "IntegerIntervalPointBeforeFalse":
  ( 9 before Interval[1, 10]) = false

define "IntegerIntervalBeforePointTrue":
  ( Interval[1, 10]before 11 ) = true

define "IntegerIntervalBeforePointFalse":
  ( Interval[1, 10]before 8 ) = false

define "DecimalIntervalBeforeFalse":
  ( Interval[11.0, 20.0]before Interval[1.0, 10.0]) = false

define "DecimalIntervalBeforeTrue":
  ( Interval[1.0, 10.0]before Interval[11.0, 20.0]) = true

define "DecimalIntervalPointBeforeTrue":
  ( 9.0 before Interval[11.0, 20.0]) = true

define "DecimalIntervalPointBeforeFalse":
  ( 9.0 before Interval[1.0, 10.0]) = false

define "DecimalIntervalBeforePointTrue":
  ( Interval[1.0, 10.0]before 11.0 ) = true

define "DecimalIntervalBeforePointFalse":
  ( Interval[1.0, 10.0]before 8.0 ) = false

define "QuantityIntervalBeforeTrue":
  ( Interval[1.0 'g', 10.0 'g']before Interval[11.0 'g', 20.0 'g']) = true

define "QuantityIntervalBeforeFalse":
  ( Interval[11.0 'g', 20.0 'g']before Interval[1.0 'g', 10.0 'g']) = false

define "QuantityIntervalPointBeforeTrue":
  ( Interval[1.0 'g', 10.0 'g']before 12.0 'g' ) = true

define "QuantityIntervalPointBeforeFalse":
  ( Interval[1.0 'g', 10.0 'g']before 9.0 'g' ) = false

define "QuantityIntervalBeforePointTrue":
  ( 5.0 'g' before Interval[11.0 'g', 20.0 'g']) = true

define "QuantityIntervalBeforePointFalse":
  ( 12.0 'g' before Interval[11.0 'g', 20.0 'g']) = false

define "DateTimeBeforeTrue":
  ( Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)]before DateTime(2012, 2, 27)) = true

define "DateTimeBeforeFalse":
  ( Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)]before DateTime(2011, 12, 31)) = false

define "TimeBeforeTrue":
  ( Interval[@T15:59:59.999, @T20:59:59.999]before @T22:59:59.999 ) = true

define "TimeBeforeFalse":
  ( Interval[@T15:59:59.999, @T20:59:59.999]before @T10:59:59.999 ) = false

define "TestCollapseNull":
  ( collapse { Interval ( null as Integer, null as Integer ) } ) = null as List<Interval<Integer>>

define "IntegerIntervalCollapse":
  ( collapse { Interval[1, 5], Interval[3, 7], Interval[12, 19], Interval[7, 10]} ) = { Interval[1, 10], Interval[12, 19]}

define "IntegerIntervalCollapse2":
  ( collapse { Interval[1, 2], Interval[3, 7], Interval[10, 19], Interval[7, 10]} ) = { Interval[1, 19]}

define "IntegerIntervalCollapse3":
  ( collapse { Interval[4, 6], Interval[7, 8]} ) = { Interval[4, 8]}

define "DecimalIntervalCollapse":
  ( collapse { Interval[1.0, 5.0], Interval[3.0, 7.0], Interval[12.0, 19.0], Interval[7.0, 10.0]} ) = { Interval[1.0, 10.0], Interval[12.0, 19.0]}

define "DecimalIntervalCollapse2":
  ( collapse { Interval[4.0, 6.0], Interval[6.00000001, 8.0]} ) = { Interval[4.0, 8.0]}

define "QuantityIntervalCollapse":
  ( collapse { Interval[1.0 'g', 5.0 'g'], Interval[3.0 'g', 7.0 'g'], Interval[12.0 'g', 19.0 'g'], Interval[7.0 'g', 10.0 'g']} ) = { Interval[1.0 'g', 10.0 'g'], Interval[12.0 'g', 19.0 'g']}

define "DateTimeCollapse":
  ( collapse { Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)], Interval[DateTime(2012, 1, 10), DateTime(2012, 1, 25)], Interval[DateTime(2012, 5, 10), DateTime(2012, 5, 25)], Interval[DateTime(2012, 5, 20), DateTime(2012, 5, 30)]} ) = { Interval[@2012-01-01, @2012-01-25], Interval[@2012-05-10, @2012-05-30]}

define "DateTimeCollapse2":
  ( collapse { Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)], Interval[DateTime(2012, 1, 16), DateTime(2012, 5, 25)]} ) = { Interval[@2012-01-01, @2012-05-25]}

define "TimeCollapse":
  ( collapse { Interval[@T01:59:59.999, @T10:59:59.999], Interval[@T08:59:59.999, @T15:59:59.999], Interval[@T17:59:59.999, @T20:59:59.999], Interval[@T18:59:59.999, @T22:59:59.999]} ) = { Interval[@T01:59:59.999, @T15:59:59.999], Interval[@T17:59:59.999, @T22:59:59.999]}

define "TimeCollapse2":
  ( collapse { Interval[@T01:59:59.999, @T10:59:59.999], Interval[@T11:00:00.000, @T15:59:59.999]} ) = { Interval[@T01:59:59.999, @T15:59:59.999]}

define "ExpandPerDay":
  ( expand { Interval[@2018-01-01, @2018-01-04]} per day ) = { Interval[@2018-01-01, @2018-01-01], Interval[@2018-01-02, @2018-01-02], Interval[@2018-01-03, @2018-01-03], Interval[@2018-01-04, @2018-01-04]}

define "ExpandPer2Days":
  ( expand { Interval[@2018-01-01, @2018-01-04]} per 2 days ) = { Interval[@2018-01-01, @2018-01-02], Interval[@2018-01-03, @2018-01-04]}

define "ExpandPerHour":
  ( expand { Interval[@T10:00, @T12:30]} per hour ) = { Interval[@T10, @T10], Interval[@T11, @T11], Interval[@T12, @T12]}

define "ExpandPerMinute":
  ( expand { Interval[@T10, @T10]} per minute ) = { }

define "TestContainsNull":
  ( Interval[1, 10]contains null ) = null

define "TestNullElement1":
  ( null contains 5 ) = false

define "TestNullElement2":
  ( Interval[null, 5]contains 10 ) = false

define "IntegerIntervalContainsTrue":
  ( Interval[1, 10]contains 5 ) = true

define "IntegerIntervalContainsFalse":
  ( Interval[1, 10]contains 25 ) = false

define "DecimalIntervalContainsTrue":
  ( Interval[1.0, 10.0]contains 8.0 ) = true

define "DecimalIntervalContainsFalse":
  ( Interval[1.0, 10.0]contains 255.0 ) = false

define "QuantityIntervalContainsTrue":
  ( Interval[1.0 'g', 10.0 'g']contains 2.0 'g' ) = true

define "QuantityIntervalContainsFalse":
  ( Interval[1.0 'g', 10.0 'g']contains 100.0 'g' ) = false

define "DateTimeContainsTrue":
  ( Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)]contains DateTime(2012, 1, 10)) = true

define "DateTimeContainsFalse":
  ( Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)]contains DateTime(2012, 1, 16)) = false

define "TimeContainsTrue":
  ( Interval[@T01:59:59.999, @T10:59:59.999]contains @T05:59:59.999 ) = true

define "TimeContainsFalse":
  ( Interval[@T01:59:59.999, @T10:59:59.999]contains @T15:59:59.999 ) = false

define "IntegerIntervalEnd":
  ( 
    end of Interval[1, 10]
  ) = 10

define "DecimalIntervalEnd":
  ( 
    end of Interval[1.0, 10.0]
  ) = 10.0

define "QuantityIntervalEnd":
  ( 
    end of Interval[1.0 'g', 10.0 'g']
  ) = 10.0 'g'

define "DateTimeIntervalEnd":
  ( 
    end of Interval[@2016-05-01T00:00:00.000, @2016-05-02T00:00:00.000]
  ) = @2016-05-02T00:00:00.000

define "TimeIntervalEnd":
  ( 
    end of Interval[@T00:00:00.000, @T23:59:59.599]
  ) = @T23:59:59.599

define "TestEndsNull":
  ( Interval[1, 10]ends Interval ( null, null ) ) = null

define "IntegerIntervalEndsTrue":
  ( Interval[4, 10]ends Interval[1, 10]) = true

define "IntegerIntervalEndsFalse":
  ( Interval[44, 50]ends Interval[1, 10]) = false

define "DecimalIntervalEndsTrue":
  ( Interval[4.0, 10.0]ends Interval[1.0, 10.0]) = true

define "DecimalIntervalEndsFalse":
  ( Interval[11.0, 20.0]ends Interval[1.0, 10.0]) = false

define "QuantityIntervalEndsTrue":
  ( Interval[5.0 'g', 10.0 'g']ends Interval[1.0 'g', 10.0 'g']) = true

define "QuantityIntervalEndsFalse":
  ( Interval[11.0 'g', 20.0 'g']ends Interval[1.0 'g', 10.0 'g']) = false

define "DateTimeEndsTrue":
  ( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)]ends Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)]) = true

define "DateTimeEndsFalse":
  ( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)]ends Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 16)]) = false

define "TimeEndsTrue":
  ( Interval[@T05:59:59.999, @T10:59:59.999]ends Interval[@T01:59:59.999, @T10:59:59.999]) = true

define "TimeEndsFalse":
  ( Interval[@T05:59:59.999, @T10:59:59.999]ends Interval[@T01:59:59.999, @T11:59:59.999]) = false

define "TestEqualNull":
  ( Interval[1, 10]= Interval ( null, null ) ) = null

define "IntegerIntervalEqualTrue":
  ( Interval[1, 10]= Interval[1, 10]) = true

define "IntegerIntervalEqualFalse":
  ( Interval[1, 10]= Interval[11, 20]) = false

define "DecimalIntervalEqualTrue":
  ( Interval[1.0, 10.0]= Interval[1.0, 10.0]) = true

define "DecimalIntervalEqualFalse":
  ( Interval[1.0, 10.0]= Interval[11.0, 20.0]) = false

define "QuantityIntervalEqualTrue":
  ( Interval[1.0 'g', 10.0 'g']= Interval[1.0 'g', 10.0 'g']) = true

define "QuantityIntervalEqualFalse":
  ( Interval[1.0 'g', 10.0 'g']= Interval[11.0 'g', 20.0 'g']) = false

define "DateTimeEqualTrue":
  ( Interval[DateTime(2012, 1, 5, 0, 0, 0, 0), DateTime(2012, 1, 15, 0, 0, 0, 0)]= Interval[DateTime(2012, 1, 5, 0, 0, 0, 0), DateTime(2012, 1, 15, 0, 0, 0, 0)]) = true

define "DateTimeEqualFalse":
  ( Interval[DateTime(2012, 1, 5, 0, 0, 0, 0), DateTime(2012, 1, 15, 0, 0, 0, 0)]= Interval[DateTime(2012, 1, 5, 0, 0, 0, 0), DateTime(2012, 1, 16, 0, 0, 0, 0)]) = false

define "TimeEqualTrue":
  ( Interval[@T05:59:59.999, @T10:59:59.999]= Interval[@T05:59:59.999, @T10:59:59.999]) = true

define "TimeEqualFalse":
  ( Interval[@T05:59:59.999, @T10:59:59.999]= Interval[@T05:59:59.999, @T10:58:59.999]) = false

define "NullInterval":
  ( Interval[null as Integer, null as Integer]) = null as Interval<Integer>

define "TestExceptNull":
  ( Interval[null as Integer, null as Integer]
      except Interval[null as Integer, null as Integer]
  ) = null as Interval<Integer>

define "IntegerIntervalExcept1to3":
  ( Interval[1, 10]
      except Interval[4, 10]
  ) = Interval[1, 3]

define "IntegerIntervalExceptNull":
  ( Interval[1, 10]
      except Interval[3, 7]
  ) = null

define "DecimalIntervalExcept1to3":
  ( Interval[1.0, 10.0]
      except Interval[4.0, 10.0]
  ) = Interval[1.0, 3.99999999]

define "DecimalIntervalExceptNull":
  ( Interval[1.0, 10.0]
      except Interval[3.0, 7.0]
  ) = null

define "QuantityIntervalExcept1to4":
  ( Interval[1.0 'g', 10.0 'g']
      except Interval[5.0 'g', 10.0 'g']
  ) = Interval[1.0 'g', 4.99999999 'g']

define "Except12":
  ( Interval[1, 4]
      except Interval[3, 6]
  ) = Interval[1, 2]

define "ExceptDateTimeInterval":
  ( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)]
      except Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 15)]
  ) = Interval[@2012-01-05, @2012-01-06]

define "ExceptDateTime2":
  ( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 16)]
      except Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 12)]
  ) = Interval[@2012-01-13, @2012-01-16]

define "ExceptTimeInterval":
  ( Interval[@T05:59:59.999, @T10:59:59.999]
      except Interval[@T08:59:59.999, @T10:59:59.999]
  ) = Interval[@T05:59:59.999, @T08:59:59.998]

define "ExceptTime2":
  ( Interval[@T08:59:59.999, @T11:59:59.999]
      except Interval[@T05:59:59.999, @T10:59:59.999]
  ) = Interval[@T11:00:00.000, @T11:59:59.999]

define "TestInNull":
  ( 5 in Interval[null as Integer, null as Integer]) = false

define "IntegerIntervalInTrue":
  ( 5 in Interval[1, 10]) = true

define "IntegerIntervalInFalse":
  ( 500 in Interval[1, 10]) = false

define "DecimalIntervalInTrue":
  ( 9.0 in Interval[1.0, 10.0]) = true

define "DecimalIntervalInFalse":
  ( - 2.0 in Interval[1.0, 10.0]) = false

define "QuantityIntervalInTrue":
  ( 1.0 'g' in Interval[1.0 'g', 10.0 'g']) = true

define "QuantityIntervalInFalse":
  ( 55.0 'g' in Interval[1.0 'g', 10.0 'g']) = false

define "DateTimeInTrue":
  ( DateTime(2012, 1, 7)in Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)]) = true

define "DateTimeInFalse":
  ( DateTime(2012, 1, 17)in Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)]) = false

define "DateTimeInNullTrue":
  ( DateTime(2012, 1, 7)in Interval[DateTime(2012, 1, 5), null]) = true

define "TimeInTrue":
  ( @T07:59:59.999 in Interval[@T05:59:59.999, @T10:59:59.999]) = true

define "TimeInFalse":
  ( @T17:59:59.999 in Interval[@T05:59:59.999, @T10:59:59.999]) = false

define "TimeInNull":
  ( null in Interval[@T05:59:59.999, @T10:59:59.999]) = null

define "TestPeriod1":
  ( Interval[@2017-12-20T11:00:00, @2017-12-21T21:00:00]) = Interval[@2017-12-20T11:00:00, @2017-12-21T21:00:00]

define "TestPeriod2":
  ( Interval[@2017-12-20T10:30:00, @2017-12-20T12:00:00]) = Interval[@2017-12-20T10:30:00, @2017-12-20T12:00:00]

define "Issue32Interval":
  ( Interval[@2017-12-20T10:30:00, @2017-12-20T12:00:00]starts 1 day or less on or after day of start of Interval[@2017-12-20T11:00:00, @2017-12-21T21:00:00]) = true

define "TestIncludesNull":
  ( Interval[1, 10]includes null ) = null

define "IntegerIntervalIncludesTrue":
  ( Interval[1, 10]includes Interval[4, 10]) = true

define "IntegerIntervalIncludesFalse":
  ( Interval[1, 10]includes Interval[44, 50]) = false

define "DecimalIntervalIncludesTrue":
  ( Interval[1.0, 10.0]includes Interval[4.0, 10.0]) = true

define "DecimalIntervalIncludesFalse":
  ( Interval[1.0, 10.0]includes Interval[11.0, 20.0]) = false

define "QuantityIntervalIncludesTrue":
  ( Interval[1.0 'g', 10.0 'g']includes Interval[5.0 'g', 10.0 'g']) = true

define "QuantityIntervalIncludesFalse":
  ( Interval[1.0 'g', 10.0 'g']includes Interval[11.0 'g', 20.0 'g']) = false

define "DateTimeIncludesTrue":
  ( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)]includes Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]) = true

define "DateTimeIncludesFalse":
  ( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)]includes Interval[DateTime(2012, 1, 4), DateTime(2012, 1, 14)]) = false

define "TimeIncludesTrue":
  ( Interval[@T05:59:59.999, @T10:59:59.999]includes Interval[@T06:59:59.999, @T09:59:59.999]) = true

define "TimeIncludesFalse":
  ( Interval[@T05:59:59.999, @T10:59:59.999]includes Interval[@T04:59:59.999, @T09:59:59.999]) = false

define "TestIncludedInNull":
  ( null included in Interval[1, 10]) = null

define "IntegerIntervalIncludedInTrue":
  ( Interval[4, 10]included in Interval[1, 10]) = true

define "IntegerIntervalIncludedInFalse":
  ( Interval[44, 50]included in Interval[1, 10]) = false

define "DecimalIntervalIncludedInTrue":
  ( Interval[4.0, 10.0]included in Interval[1.0, 10.0]) = true

define "DecimalIntervalIncludedInFalse":
  ( Interval[11.0, 20.0]included in Interval[1.0, 10.0]) = false

define "QuantityIntervalIncludedInTrue":
  ( Interval[5.0 'g', 10.0 'g']included in Interval[1.0 'g', 10.0 'g']) = true

define "QuantityIntervalIncludedInFalse":
  ( Interval[11.0 'g', 20.0 'g']included in Interval[1.0 'g', 10.0 'g']) = false

define "DateTimeIncludedInTrue":
  ( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]included in Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)]) = true

define "DateTimeIncludedInFalse":
  ( Interval[DateTime(2012, 1, 4), DateTime(2012, 1, 14)]included in Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 15)]) = false

define "TimeIncludedInTrue":
  ( Interval[@T06:59:59.999, @T09:59:59.999]included in Interval[@T05:59:59.999, @T10:59:59.999]) = true

define "TimeIncludedInFalse":
  ( Interval[@T04:59:59.999, @T09:59:59.999]included in Interval[@T05:59:59.999, @T10:59:59.999]) = false

define "DateTimeIncludedInNull":
  ( Interval[@2017-09-01T00:00:00, @2017-09-01T00:00:00]included in Interval[@2017-09-01T00:00:00.000, @2017-12-30T23:59:59.999]) = null

define "DateTimeIncludedInPrecisionTrue":
  ( Interval[@2017-09-01T00:00:00, @2017-09-01T00:00:00]included in day of Interval[@2017-09-01T00:00:00.000, @2017-12-30T23:59:59.999]) = true

define "DateTimeIncludedInPrecisionNull":
  ( Interval[@2017-09-01T00:00:00, @2017-09-01T00:00:00]included in millisecond of Interval[@2017-09-01T00:00:00.000, @2017-12-30T23:59:59.999]) = null

define "TestIntersectNull":
  ( Interval[1, 10]
      intersect Interval[5, null )
  ) = null

define "IntegerIntervalIntersectTest4to10":
  ( Interval[1, 10]
      intersect Interval[4, 10]
  ) = Interval[4, 10]

define "IntegerIntervalIntersectTestNull":
  ( Interval[1, 10]
      intersect Interval[11, 20]
  ) = null

define "DecimalIntervalIntersectTest4to10":
  ( Interval[1.0, 10.0]
      intersect Interval[4.0, 10.0]
  ) = Interval[4.0, 10.0]

define "DecimalIntervalIntersectTestNull":
  ( Interval[1.0, 10.0]
      intersect Interval[11.0, 20.0]
  ) = null

define "QuantityIntervalIntersectTest5to10":
  ( Interval[1.0 'g', 10.0 'g']
      intersect Interval[5.0 'g', 10.0 'g']
  ) = Interval[5.0 'g', 10.0 'g']

define "QuantityIntervalIntersectTestNull":
  ( Interval[1.0 'g', 10.0 'g']
      intersect Interval[11.0 'g', 20.0 'g']
  ) = null

define "DateTimeIntersect":
  ( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]
      intersect Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 10)]
  ) = Interval[@2012-01-07, @2012-01-10]

define "TimeIntersect":
  ( Interval[@T04:59:59.999, @T09:59:59.999]
      intersect Interval[@T04:59:59.999, @T06:59:59.999]
  ) = Interval[@T04:59:59.999, @T06:59:59.999]

define "IntegerIntervalEquivalentTrue":
  ( Interval[1, 10]~ Interval[1, 10]) = true

define "IntegerIntervalEquivalentFalse":
  ( Interval[44, 50]~ Interval[1, 10]) = false

define "DecimalIntervalEquivalentTrue":
  ( Interval[1.0, 10.0]~ Interval[1.0, 10.0]) = true

define "DecimalIntervalEquivalentFalse":
  ( Interval[11.0, 20.0]~ Interval[1.0, 10.0]) = false

define "QuantityIntervalEquivalentTrue":
  ( Interval[1.0 'g', 10.0 'g']~ Interval[1.0 'g', 10.0 'g']) = true

define "QuantityIntervalEquivalentFalse":
  ( Interval[11.0 'g', 20.0 'g']~ Interval[1.0 'g', 10.0 'g']) = false

define "DateTimeEquivalentTrue":
  ( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]~ Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]) = true

define "DateTimeEquivalentFalse":
  ( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]~ Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 15)]) = false

define "TimeEquivalentTrue":
  ( Interval[@T04:59:59.999, @T09:59:59.999]~ Interval[@T04:59:59.999, @T09:59:59.999]) = true

define "TimeEquivalentFalse":
  ( Interval[@T04:59:59.999, @T09:59:59.999]~ Interval[@T04:58:59.999, @T09:59:59.999]) = false

define "TestMeetsNull":
  ( Interval ( null, 5]meets Interval ( null, 15 ) ) = null

define "IntegerIntervalMeetsTrue":
  ( Interval[1, 10]meets Interval[11, 20]) = true

define "IntegerIntervalMeetsFalse":
  ( Interval[1, 10]meets Interval[44, 50]) = false

define "DecimalIntervalMeetsTrue":
  ( Interval[3.01, 5.00000001]meets Interval[5.00000002, 8.50]) = true

define "DecimalIntervalMeetsFalse":
  ( Interval[3.01, 5.00000001]meets Interval[5.5, 8.50]) = false

define "QuantityIntervalMeetsTrue":
  ( Interval[3.01 'g', 5.00000001 'g']meets Interval[5.00000002 'g', 8.50 'g']) = true

define "QuantityIntervalMeetsFalse":
  ( Interval[3.01 'g', 5.00000001 'g']meets Interval[5.5 'g', 8.50 'g']) = false

define "DateTimeMeetsTrue":
  ( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]meets Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 25)]) = true

define "DateTimeMeetsFalse":
  ( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]meets Interval[DateTime(2012, 1, 20), DateTime(2012, 1, 25)]) = false

define "TimeMeetsTrue":
  ( Interval[@T04:59:59.999, @T09:59:59.999]meets Interval[@T10:00:00.000, @T19:59:59.999]) = true

define "TimeMeetsFalse":
  ( Interval[@T04:59:59.999, @T09:59:59.999]meets Interval[@T10:12:00.000, @T19:59:59.999]) = false

define "TestMeetsBeforeNull":
  ( Interval ( null, 5]meets before Interval ( null, 25]) = null

define "IntegerIntervalMeetsBeforeTrue":
  ( Interval[1, 10]meets before Interval[11, 20]) = true

define "IntegerIntervalMeetsBeforeFalse":
  ( Interval[1, 10]meets before Interval[44, 50]) = false

define "DecimalIntervalMeetsBeforeTrue":
  ( Interval[3.50000001, 5.00000011]meets before Interval[5.00000012, 8.50]) = true

define "DecimalIntervalMeetsBeforeFalse":
  ( Interval[8.01, 15.00000001]meets before Interval[15.00000000, 18.50]) = false

define "QuantityIntervalMeetsBeforeTrue":
  ( Interval[3.50000001 'g', 5.00000011 'g']meets before Interval[5.00000012 'g', 8.50 'g']) = true

define "QuantityIntervalMeetsBeforeFalse":
  ( Interval[8.01 'g', 15.00000001 'g']meets before Interval[15.00000000 'g', 18.50 'g']) = false

define "DateTimeMeetsBeforeTrue":
  ( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]meets Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 25)]) = true

define "DateTimeMeetsBeforeFalse":
  ( Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]meets Interval[DateTime(2012, 1, 20), DateTime(2012, 1, 25)]) = false

define "TimeMeetsBeforeTrue":
  ( Interval[@T04:59:59.999, @T09:59:59.999]meets Interval[@T10:00:00.000, @T19:59:59.999]) = true

define "TimeMeetsBeforeFalse":
  ( Interval[@T04:59:59.999, @T09:59:59.999]meets Interval[@T10:12:00.000, @T19:59:59.999]) = false

define "TestMeetsAfterNull":
  ( Interval ( null, 5]meets after Interval[11, null ) ) = null

define "IntegerIntervalMeetsAfterTrue":
  ( Interval[11, 20]meets after Interval[1, 10]) = true

define "IntegerIntervalMeetsAfterFalse":
  ( Interval[44, 50]meets after Interval[1, 10]) = false

define "DecimalIntervalMeetsAfterTrue":
  ( Interval[55.00000123, 128.032156]meets after Interval[12.00258, 55.00000122]) = true

define "DecimalIntervalMeetsAfterFalse":
  ( Interval[55.00000124, 150.222222]meets after Interval[12.00258, 55.00000122]) = false

define "QuantityIntervalMeetsAfterTrue":
  ( Interval[55.00000123 'g', 128.032156 'g']meets after Interval[12.00258 'g', 55.00000122 'g']) = true

define "QuantityIntervalMeetsAfterFalse":
  ( Interval[55.00000124 'g', 150.222222 'g']meets after Interval[12.00258 'g', 55.00000122 'g']) = false

define "DateTimeMeetsAfterTrue":
  ( Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 25)]meets Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]) = true

define "DateTimeMeetsAfterFalse":
  ( Interval[DateTime(2012, 1, 20), DateTime(2012, 1, 25)]meets Interval[DateTime(2012, 1, 7), DateTime(2012, 1, 14)]) = false

define "TimeMeetsAfterTrue":
  ( Interval[@T10:00:00.000, @T19:59:59.999]meets Interval[@T04:59:59.999, @T09:59:59.999]) = true

define "TimeMeetsAfterFalse":
  ( Interval[@T10:12:00.000, @T19:59:59.999]meets Interval[@T04:59:59.999, @T09:59:59.999]) = false

define "IntegerIntervalNotEqualTrue":
  ( Interval[1, 10]!= Interval[11, 20]) = true

define "IntegerIntervalNotEqualFalse":
  ( Interval[1, 10]!= Interval[1, 10]) = false

define "DecimalIntervalNotEqualTrue":
  ( Interval[1.0, 10.0]!= Interval[11.0, 20.0]) = true

define "DecimalIntervalNotEqualFalse":
  ( Interval[1.0, 10.0]!= Interval[1.0, 10.0]) = false

define "QuantityIntervalNotEqualTrue":
  ( Interval[1.0 'g', 10.0 'g']!= Interval[11.0 'g', 20.0 'g']) = true

define "QuantityIntervalNotEqualFalse":
  ( Interval[1.0 'g', 10.0 'g']!= Interval[1.0 'g', 10.0 'g']) = false

define "DateTimeNotEqualTrue":
  ( Interval[DateTime(2012, 1, 15, 0, 0, 0, 0), DateTime(2012, 1, 25, 0, 0, 0, 0)]!= Interval[DateTime(2012, 1, 15, 0, 0, 0, 0), DateTime(2012, 1, 25, 0, 0, 0, 22)]) = true

define "DateTimeNotEqualFalse":
  ( Interval[DateTime(2012, 1, 15, 0, 0, 0, 0), DateTime(2012, 1, 25, 0, 0, 0, 0)]!= Interval[DateTime(2012, 1, 15, 0, 0, 0, 0), DateTime(2012, 1, 25, 0, 0, 0, 0)]) = false

define "TimeNotEqualTrue":
  ( Interval[@T10:00:00.000, @T19:59:59.999]!= Interval[@T10:10:00.000, @T19:59:59.999]) = true

define "TimeNotEqualFalse":
  ( Interval[@T10:00:00.000, @T19:59:59.999]!= Interval[@T10:00:00.000, @T19:59:59.999]) = false

define "TestOnOrAfterNull":
  ( Interval[@2012-12-01, @2013-12-01]on or after null ) = null

define "TestOnOrAfterDateTrue":
  ( Interval[@2012-12-01, @2013-12-01]on or after month of @2012-11-15 ) = true

define "TestOnOrAfterDateFalse":
  ( @2012-11-15 on or after month of Interval[@2012-12-01, @2013-12-01]) = false

define "TestOnOrAfterTimeTrue":
  ( Interval[@T10:00:00.000, @T19:59:59.999]on or after hour of Interval[@T08:00:00.000, @T09:59:59.999]) = true

define "TestOnOrAfterTimeFalse":
  ( Interval[@T10:00:00.000, @T19:59:59.999]on or after hour of Interval[@T08:00:00.000, @T11:59:59.999]) = false

define "TestOnOrAfterIntegerTrue":
  ( Interval[6, 10]on or after 6 ) = true

define "TestOnOrAfterDecimalFalse":
  ( 2.5 on or after Interval[1.666, 2.50000001]) = false

define "TestOnOrAfterQuantityTrue":
  ( 2.5 'mg' on or after Interval[1.666 'mg', 2.50000000 'mg']) = true

define "TestOnOrBeforeNull":
  ( Interval[@2012-12-01, @2013-12-01]on or before null ) = null

define "TestOnOrBeforeDateTrue":
  ( Interval[@2012-10-01, @2012-11-01]on or before month of @2012-11-15 ) = true

define "TestOnOrBeforeDateFalse":
  ( @2012-11-15 on or before month of Interval[@2012-10-01, @2013-12-01]) = false

define "TestOnOrBeforeTimeTrue":
  ( Interval[@T05:00:00.000, @T07:59:59.999]on or before hour of Interval[@T08:00:00.000, @T09:59:59.999]) = true

define "TestOnOrBeforeTimeFalse":
  ( Interval[@T10:00:00.000, @T19:59:59.999]on or before hour of Interval[@T08:00:00.000, @T11:59:59.999]) = false

define "TestOnOrBeforeIntegerTrue":
  ( Interval[4, 6]on or before 6 ) = true

define "TestOnOrBeforeDecimalFalse":
  ( 1.6667 on or before Interval[1.666, 2.50000001]) = false

define "TestOnOrBeforeQuantityTrue":
  ( 1.666 'mg' on or before Interval[1.666 'mg', 2.50000000 'mg']) = true

define "TestOverlapsNull":
  ( Interval[null as Integer, null as Integer]overlaps Interval[1, 10]) = null

define "IntegerIntervalOverlapsTrue":
  ( Interval[1, 10]overlaps Interval[4, 10]) = true

define "IntegerIntervalOverlapsFalse":
  ( Interval[1, 10]overlaps Interval[11, 20]) = false

define "DecimalIntervalOverlapsTrue":
  ( Interval[1.0, 10.0]overlaps Interval[4.0, 10.0]) = true

define "DecimalIntervalOverlapsFalse":
  ( Interval[1.0, 10.0]overlaps Interval[11.0, 20.0]) = false

define "QuantityIntervalOverlapsTrue":
  ( Interval[1.0 'g', 10.0 'g']overlaps Interval[5.0 'g', 10.0 'g']) = true

define "QuantityIntervalOverlapsFalse":
  ( Interval[1.0 'g', 10.0 'g']overlaps Interval[11.0 'g', 20.0 'g']) = false

define "DateTimeOverlapsTrue":
  ( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)]overlaps Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)]) = true

define "DateTimeOverlapsFalse":
  ( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)]overlaps Interval[DateTime(2012, 1, 26), DateTime(2012, 1, 28)]) = false

define "TimeOverlapsTrue":
  ( Interval[@T10:00:00.000, @T19:59:59.999]overlaps Interval[@T12:00:00.000, @T21:59:59.999]) = true

define "TimeOverlapsFalse":
  ( Interval[@T10:00:00.000, @T19:59:59.999]overlaps Interval[@T20:00:00.000, @T21:59:59.999]) = false

define "TestOverlapsBeforeNull":
  ( Interval[null as Integer, null as Integer]overlaps before Interval[1, 10]) = null

define "IntegerIntervalOverlapsBeforeTrue":
  ( Interval[1, 10]overlaps before Interval[4, 10]) = true

define "IntegerIntervalOverlapsBeforeFalse":
  ( Interval[4, 10]overlaps before Interval[1, 10]) = false

define "DecimalIntervalOverlapsBeforeTrue":
  ( Interval[1.0, 10.0]overlaps before Interval[4.0, 10.0]) = true

define "DecimalIntervalOverlapsBeforeFalse":
  ( Interval[4.0, 10.0]overlaps before Interval[1.0, 10.0]) = false

define "QuantityIntervalOverlapsBeforeTrue":
  ( Interval[1.0 'g', 10.0 'g']overlaps before Interval[5.0 'g', 10.0 'g']) = true

define "QuantityIntervalOverlapsBeforeFalse":
  ( Interval[5.0 'g', 10.0 'g']overlaps before Interval[1.0 'g', 10.0 'g']) = false

define "DateTimeOverlapsBeforeTrue":
  ( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)]overlaps Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)]) = true

define "DateTimeOverlapsBeforeFalse":
  ( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)]overlaps Interval[DateTime(2012, 1, 26), DateTime(2012, 1, 28)]) = false

define "TimeOverlapsBeforeTrue":
  ( Interval[@T10:00:00.000, @T19:59:59.999]overlaps Interval[@T12:00:00.000, @T21:59:59.999]) = true

define "TimeOverlapsBeforeFalse":
  ( Interval[@T10:00:00.000, @T19:59:59.999]overlaps Interval[@T20:00:00.000, @T21:59:59.999]) = false

define "TestOverlapsAfterNull":
  ( Interval[null as Integer, null as Integer]overlaps after Interval[1, 10]) = null

define "IntegerIntervalOverlapsAfterTrue":
  ( Interval[4, 15]overlaps after Interval[1, 10]) = true

define "IntegerIntervalOverlapsAfterFalse":
  ( Interval[4, 10]overlaps after Interval[1, 10]) = false

define "DecimalIntervalOverlapsAfterTrue":
  ( Interval[4.0, 15.0]overlaps after Interval[1.0, 10.0]) = true

define "DecimalIntervalOverlapsAfterFalse":
  ( Interval[4.0, 10.0]overlaps after Interval[1.0, 10.0]) = false

define "QuantityIntervalOverlapsAfterTrue":
  ( Interval[5.0 'g', 15.0 'g']overlaps after Interval[1.0 'g', 10.0 'g']) = true

define "QuantityIntervalOverlapsAfterFalse":
  ( Interval[5.0 'g', 10.0 'g']overlaps after Interval[1.0 'g', 10.0 'g']) = false

define "DateTimeOverlapsAfterTrue":
  ( Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)]overlaps Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)]) = true

define "DateTimeOverlapsAfterFalse":
  ( Interval[DateTime(2012, 1, 26), DateTime(2012, 1, 28)]overlaps Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)]) = false

define "TimeOverlapsAfterTrue":
  ( Interval[@T12:00:00.000, @T21:59:59.999]overlaps Interval[@T10:00:00.000, @T19:59:59.999]) = true

define "TimeOverlapsAfterFalse":
  ( Interval[@T20:00:00.000, @T21:59:59.999]overlaps Interval[@T10:00:00.000, @T19:59:59.999]) = false

define "TestPointFromNull":
  ( point from Interval[null as Integer, null as Integer]) = null as Integer

define "TestPointFromInteger":
  ( point from Interval[1, 1]) = 1

define "TestPointFromDecimal":
  ( point from Interval[1.0, 1.0]) = 1.0

define "TestPointFromQuantity":
  ( point from Interval[1.0 'cm', 1.0 'cm']) = 1.0 'cm'

define "TimeProperContainsTrue":
  ( Interval[@T12:00:00.000, @T21:59:59.999]properly includes @T12:00:00.001 ) = true

define "TimeProperContainsFalse":
  ( Interval[@T12:00:00.000, @T21:59:59.999]properly includes @T12:00:00.000 ) = false

define "TimeProperContainsNull":
  ( Interval[@T12:00:00.001, @T21:59:59.999]properly includes @T12:00:00 ) = null

define "TimeProperContainsPrecisionTrue":
  ( Interval[@T12:00:00.000, @T21:59:59.999]properly includes second of @T12:00:01 ) = true

define "TimeProperContainsPrecisionFalse":
  ( Interval[@T12:00:00.001, @T21:59:59.999]properly includes second of @T12:00:00 ) = false

define "TimeProperContainsPrecisionNull":
  ( Interval[@T12:00:00.001, @T21:59:59.999]properly includes millisecond of @T12:00:00 ) = null

define "TimeProperInTrue":
  ( @T12:00:00.001 properly included in Interval[@T12:00:00.000, @T21:59:59.999]) = true

define "TimeProperInFalse":
  ( @T12:00:00.000 properly included in Interval[@T12:00:00.000, @T21:59:59.999]) = false

define "TimeProperInNull":
  ( @T12:00:00 properly included in Interval[@T12:00:00.001, @T21:59:59.999]) = null

define "TimeProperInPrecisionTrue":
  ( @T12:00:01 properly included in second of Interval[@T12:00:00.000, @T21:59:59.999]) = true

define "TimeProperInPrecisionFalse":
  ( @T12:00:00 properly included in second of Interval[@T12:00:00.001, @T21:59:59.999]) = false

define "TimeProperInPrecisionNull":
  ( @T12:00:00 properly included in millisecond of Interval[@T12:00:00.001, @T21:59:59.999]) = null

define "TestProperlyIncludesNull":
  ( Interval[null as Integer, null as Integer]properly includes Interval[1, 10]) = false

define "IntegerIntervalProperlyIncludesTrue":
  ( Interval[1, 10]properly includes Interval[4, 10]) = true

define "IntegerIntervalProperlyIncludesFalse":
  ( Interval[1, 10]properly includes Interval[4, 15]) = false

define "DecimalIntervalProperlyIncludesTrue":
  ( Interval[1.0, 10.0]properly includes Interval[4.0, 10.0]) = true

define "DecimalIntervalProperlyIncludesFalse":
  ( Interval[1.0, 10.0]properly includes Interval[4.0, 15.0]) = false

define "QuantityIntervalProperlyIncludesTrue":
  ( Interval[1.0 'g', 10.0 'g']properly includes Interval[5.0 'g', 10.0 'g']) = true

define "QuantityIntervalProperlyIncludesFalse":
  ( Interval[1.0 'g', 10.0 'g']properly includes Interval[5.0 'g', 15.0 'g']) = false

define "DateTimeProperlyIncludesTrue":
  ( Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)]properly includes Interval[DateTime(2012, 1, 16), DateTime(2012, 1, 27)]) = true

define "DateTimeProperlyIncludesFalse":
  ( Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)]properly includes Interval[DateTime(2012, 1, 16), DateTime(2012, 1, 29)]) = false

define "TimeProperlyIncludesTrue":
  ( Interval[@T12:00:00.000, @T21:59:59.999]properly includes Interval[@T12:01:01.000, @T21:59:59.998]) = true

define "TimeProperlyIncludesFalse":
  ( Interval[@T12:00:00.000, @T21:59:59.999]properly includes Interval[@T12:01:01.000, @T22:00:00.000]) = false

define "TestProperlyIncludedInNull":
  ( Interval[1, 10]properly included in Interval[null as Integer, null as Integer]) = false

define "IntegerIntervalProperlyIncludedInTrue":
  ( Interval[4, 10]properly included in Interval[1, 10]) = true

define "IntegerIntervalProperlyIncludedInFalse":
  ( Interval[4, 15]properly included in Interval[1, 10]) = false

define "DecimalIntervalProperlyIncludedInTrue":
  ( Interval[4.0, 10.0]properly included in Interval[1.0, 10.0]) = true

define "DecimalIntervalProperlyIncludedInFalse":
  ( Interval[4.0, 15.0]properly included in Interval[1.0, 10.0]) = false

define "QuantityIntervalProperlyIncludedInTrue":
  ( Interval[5.0 'g', 10.0 'g']properly included in Interval[1.0 'g', 10.0 'g']) = true

define "QuantityIntervalProperlyIncludedInFalse":
  ( Interval[1.0 'g', 10.0 'g']properly included in Interval[5.0 'g', 15.0 'g']) = false

define "DateTimeProperlyIncludedInTrue":
  ( Interval[DateTime(2012, 1, 16), DateTime(2012, 1, 27)]properly included in Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)]) = true

define "DateTimeProperlyIncludedInFalse":
  ( Interval[DateTime(2012, 1, 16), DateTime(2012, 1, 29)]properly included in Interval[DateTime(2012, 1, 15), DateTime(2012, 1, 28)]) = false

define "TimeProperlyIncludedInTrue":
  ( Interval[@T12:01:01.000, @T21:59:59.998]properly included in Interval[@T12:00:00.000, @T21:59:59.999]) = true

define "TimeProperlyIncludedInFalse":
  ( Interval[@T12:01:01.000, @T22:00:00.000]properly included in Interval[@T12:00:00.000, @T21:59:59.999]) = false

define "IntegerIntervalStart":
  ( start of Interval[1, 10]) = 1

define "DecimalIntervalStart":
  ( start of Interval[1.0, 10.0]) = 1.0

define "QuantityIntervalStart":
  ( start of Interval[1.0 'g', 10.0 'g']) = 1.0 'g'

define "DateTimeIntervalStart":
  ( start of Interval[@2016-05-01T00:00:00.000, @2016-05-02T00:00:00.000]) = @2016-05-01T00:00:00.000

define "TimeIntervalStart":
  ( start of Interval[@T00:00:00.000, @T23:59:59.599]) = @T00:00:00.000

define "TestStartsNull":
  ( Interval[null as Integer, null as Integer]starts Interval[1, 10]) = null

define "IntegerIntervalStartsTrue":
  ( Interval[4, 10]starts Interval[4, 15]) = true

define "IntegerIntervalStartsFalse":
  ( Interval[1, 10]starts Interval[4, 10]) = false

define "DecimalIntervalStartsTrue":
  ( Interval[4.0, 10.0]starts Interval[4.0, 15.0]) = true

define "DecimalIntervalStartsFalse":
  ( Interval[1.0, 10.0]starts Interval[4.0, 10.0]) = false

define "QuantityIntervalStartsTrue":
  ( Interval[5.0 'g', 10.0 'g']starts Interval[5.0 'g', 15.0 'g']) = true

define "QuantityIntervalStartsFalse":
  ( Interval[1.0 'g', 10.0 'g']starts Interval[5.0 'g', 10.0 'g']) = false

define "DateTimeStartsTrue":
  ( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)]starts Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 27)]) = true

define "DateTimeStartsFalse":
  ( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)]starts Interval[DateTime(2012, 1, 6), DateTime(2012, 1, 27)]) = false

define "TimeStartsTrue":
  ( Interval[@T05:59:59.999, @T15:59:59.999]starts Interval[@T05:59:59.999, @T17:59:59.999]) = true

define "TimeStartsFalse":
  ( Interval[@T05:59:59.999, @T15:59:59.999]starts Interval[@T04:59:59.999, @T17:59:59.999]) = false

define "TestUnionNull":
  ( Interval[null as Integer, null as Integer]
      union Interval[1, 10]
  ) = null

define "IntegerIntervalUnion1To15":
  ( Interval[1, 10]
      union Interval[4, 15]
  ) = Interval[1, 15]

define "IntegerIntervalUnionNull":
  ( Interval[1, 10]
      union Interval[44, 50]
  ) = null

define "DecimalIntervalUnion1To15":
  ( Interval[1.0, 10.0]
      union Interval[4.0, 15.0]
  ) = Interval[1.0, 15.0]

define "DecimalIntervalUnionNull":
  ( Interval[1.0, 10.0]
      union Interval[14.0, 15.0]
  ) = null

define "QuantityIntervalUnion1To15":
  ( Interval[1.0 'g', 10.0 'g']
      union Interval[5.0 'g', 15.0 'g']
  ) = Interval[1.0 'g', 15.0 'g']

define "QuantityIntervalUnionNull":
  ( Interval[1.0 'g', 10.0 'g']
      union Interval[14.0 'g', 15.0 'g']
  ) = null

define "DateTimeUnion":
  ( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)]
      union Interval[DateTime(2012, 1, 25), DateTime(2012, 1, 28)]
  ) = Interval[@2012-01-05, @2012-01-28]

define "DateTimeUnionNull":
  ( Interval[DateTime(2012, 1, 5), DateTime(2012, 1, 25)]
      union Interval[DateTime(2012, 1, 27), DateTime(2012, 1, 28)]
  ) = null

define "TimeUnion":
  ( Interval[@T05:59:59.999, @T15:59:59.999]
      union Interval[@T10:59:59.999, @T20:59:59.999]
  ) = Interval[@T05:59:59.999, @T20:59:59.999]

define "TimeUnionNull":
  ( Interval[@T05:59:59.999, @T15:59:59.999]
      union Interval[@T16:59:59.999, @T20:59:59.999]
  ) = null

define "IntegerIntervalTestWidth9":
  ( width of Interval[1, 10]) = 9

define "IntervalTestWidthNull":
  ( width of ( null as Interval<Any>) ) = null as Integer

define "DecimalIntervalTestWidth11":
  ( width of Interval[4.0, 15.0]) = 11.0

define "QuantityIntervalTestWidth5":
  ( width of Interval[5.0 'g', 10.0 'g']) = 5.0 'g'

define "IntegerIntervalTest":
  ( Interval[1, 10]) = Interval[1, 10]

define "IntegerIntervalTest2":
  ( Interval[11, 20]) = Interval[11, 20]

define "IntegerIntervalTest3":
  ( Interval[44, 50]) = Interval[44, 50]

define "IntegerIntervalTest4":
  ( Interval[4, 10]) = Interval[4, 10]

define "IntegerIntervalTest5":
  ( Interval[4, 15]) = Interval[4, 15]

define "DecimalIntervalTest":
  ( Interval[1.0, 10.0]) = Interval[1.0, 10.0]

define "DecimalIntervalTest2":
  ( Interval[11.0, 20.0]) = Interval[11.0, 20.0]

define "DecimalIntervalTest3":
  ( Interval[4.0, 10.0]) = Interval[4.0, 10.0]

define "DecimalIntervalTest4":
  ( Interval[4.0, 15.0]) = Interval[4.0, 15.0]

define "DecimalIntervalTest5":
  ( Interval[14.0, 15.0]) = Interval[14.0, 15.0]

define "QuantityIntervalTest":
  ( Interval[1.0 'g', 10.0 'g']) = Interval[1.0 'g', 10.0 'g']

define "QuantityIntervalTest2":
  ( Interval[11.0 'g', 20.0 'g']) = Interval[11.0 'g', 20.0 'g']

define "QuantityIntervalTest3":
  ( Interval[5.0 'g', 10.0 'g']) = Interval[5.0 'g', 10.0 'g']

define "QuantityIntervalTest4":
  ( Interval[5.0 'g', 15.0 'g']) = Interval[5.0 'g', 15.0 'g']

define "QuantityIntervalTest5":
  ( Interval[14.0 'g', 15.0 'g']) = Interval[14.0 'g', 15.0 'g']

define "DateTimeIntervalTest":
  ( Interval[@2016-05-01T00:00:00.000, @2016-05-02T00:00:00.000]) = Interval[@2016-05-01T00:00:00.000, @2016-05-02T00:00:00.000]

define "TimeIntervalTest":
  ( Interval[@T00:00:00.000, @T23:59:59.599]) = Interval[@T00:00:00.000, @T23:59:59.599]

define "CollapseIntervalTestInteger":
  ( { Interval[1, 10], Interval[11, 20], Interval[44, 50]} ) = { Interval[1, 10], Interval[11, 20], Interval[44, 50]}

define "InvalidIntegerInterval":
  Interval[5, 3]

define "InvalidIntegerIntervalA":
  Interval[5, 5 )