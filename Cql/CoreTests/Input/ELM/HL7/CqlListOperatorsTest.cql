library CqlListOperatorsTest version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

context Patient

define "simpleSortAsc":
  ( { 4, 5, 1, 6, 2, 1 } ) sL
    sort asc = { 1, 1, 2, 4, 5, 6 }

define "simpleSortDesc":
  ( { 4, 5, 1, 6, 2, 1 } ) sL
    sort desc = { 6, 5, 4, 2, 1, 1 }

define "simpleSortStringAsc":
  ( { 'back', 'aardvark', 'alligator', 'zebra', 'iguana', 'Wolf', 'Armadillo' } ) sls
    sort asc = { 'Armadillo', 'Wolf', 'aardvark', 'alligator', 'back', 'iguana', 'zebra' }

define "simpleSortStringDesc":
  ( { 'back', 'aardvark', 'alligator', 'zebra', 'iguana', 'Wolf', 'Armadillo' } ) sls
    sort desc = { 'zebra', 'iguana', 'back', 'alligator', 'aardvark', 'Wolf', 'Armadillo' }

define "SortDatesAsc":
  ( { DateTime(2012, 10, 5, 10), DateTime(2012, 1, 1), DateTime(2012, 1, 1, 12), DateTime(2012, 10, 5)} ) S
    sort asc = { DateTime(2012, 1, 1), DateTime(2012, 1, 1, 12), DateTime(2012, 10, 5), DateTime(2012, 10, 5, 10)}

define "SortDatesDesc":
  ( { DateTime(2012, 10, 5, 10), DateTime(2012, 1, 1), DateTime(2012, 1, 1, 12), DateTime(2012, 10, 5)} ) S
    sort desc = { DateTime(2012, 10, 5, 10), DateTime(2012, 10, 5), DateTime(2012, 1, 1, 12), DateTime(2012, 1, 1)}

define "ContainsABNullHasNull":
  ( { 'a', 'b', null } contains null ) = null

define "ContainsNullFirst":
  ( { null, 'b', 'c' } contains 'a' ) = false

define "ContainsABCHasA":
  ( { 'a', 'b', 'c' } contains 'a' ) = true

define "ContainsJan2012True":
  ( { DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 1, 1)} contains DateTime(2012, 1, 1)) = true

define "ContainsJan2012False":
  ( { DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 10, 1)} contains DateTime(2012, 1, 1)) = false

define "ContainsTimeTrue":
  ( { @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 } contains @T05:59:59.999 ) = true

define "ContainsTimeFalse":
  ( { @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 } contains @T08:59:59.999 ) = false

define "ContainsNullLeft":
  ( null as List<String>contains 'a' ) = false

define "DescendentsEmptyList":
  ( null as List<Integer>).descendents ( ) = ( null as List<Any>)

define "DistinctEmptyList":
  ( distinct { } ) = { }

define "DistinctNullNullNull":
  ( ( distinct { null, null, null } ) = { null } ) = null

define "DistinctANullANull":
  ( distinct { 'a', null, 'a', null } ) = { 'a', null }

define "Distinct112233":
  ( distinct { 1, 1, 2, 2, 3, 3 } ) = { 1, 2, 3 }

define "Distinct123123":
  ( distinct { 1, 2, 3, 1, 2, 3 } ) = { 1, 2, 3 }

define "DistinctAABBCC":
  ( distinct { 'a', 'a', 'b', 'b', 'c', 'c' } ) = { 'a', 'b', 'c' }

define "DistinctABCABC":
  ( distinct { 'a', 'b', 'c', 'a', 'b', 'c' } ) = { 'a', 'b', 'c' }

define "DistinctDateTime":
  ( distinct { DateTime(2012, 10, 5), DateTime(2012, 1, 1), DateTime(2012, 1, 1)} ) = { DateTime(2012, 10, 5), DateTime(2012, 1, 1)}

define "DistinctTime":
  ( distinct { @T15:59:59.999, @T20:59:59.999 } ) = { @T15:59:59.999, @T20:59:59.999 }

define "EqualNullNull":
  { null } = { null } = null

define "EqualEmptyListNull":
  ( { } = null as List<Integer>) = null

define "EqualNullEmptyList":
  ( null = { } as List<Integer>) = null

define "EqualEmptyListAndEmptyList":
  { } = { } = true

define "Equal12And123":
  { 1, 2 } = { 1, 2, 3 } = false

define "Equal123And12":
  { 1, 2, 3 } = { 1, 2 } = false

define "Equal123And123":
  { 1, 2, 3 } = { 1, 2, 3 } = true

define "EqualDateTimeTrue":
  { DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} = { DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} = true

define "EqualDateTimeFalse":
  { DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} = { DateTime(2012, 1, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} = false

define "EqualTimeTrue":
  { @T15:59:59.999, @T20:59:59.999, @T20:59:59.999 } = { @T15:59:59.999, @T20:59:59.999, @T20:59:59.999 } = true

define "EqualTimeFalse":
  { @T15:59:59.999, @T20:59:59.999, @T20:59:59.999 } = { @T10:59:59.999, @T20:59:59.999, @T20:59:59.999 } = false

define "ExceptEmptyListAndEmptyList":
  ( { }
      except { }
  ) = { }

define "Except1234And23":
  ( { 1, 2, 3, 4 }
      except { 2, 3 }
  ) = { 1, 4 }

define "Except23And1234":
  ( { 2, 3 }
      except { 1, 2, 3, 4 }
  ) = ( { } as List<Integer>)

define "ExceptDateTimeList":
  ( { DateTime(2012, 5, 10), DateTime(2014, 12, 10), DateTime(2010, 1, 1)}
      except { DateTime(2014, 12, 10), DateTime(2010, 1, 1)}
  ) = { @2012-05-10 }

define "ExceptTimeList":
  ( { @T15:59:59.999, @T20:59:59.999, @T12:59:59.999 }
      except { @T20:59:59.999, @T12:59:59.999 }
  ) = { @T15:59:59.999 }

define "ExceptNullRight":
  ( { 1, 4 }
      except null
  ) = { 1, 4 }

define "ExistsEmpty":
  Exists({ })= false

define "ExistsListNull":
  Exists({ null })= false

define "Exists1":
  Exists({ 1 })= true

define "Exists12":
  Exists({ 1, 2 })= true

define "ExistsDateTime":
  Exists({ DateTime(2012, 5, 10), DateTime(2014, 12, 10)})= true

define "ExistsTime":
  Exists({ @T15:59:59.999, @T20:59:59.999 })= true

define "ExistsNull":
  Exists(null)= false

define "FlattenEmpty":
  Flatten({ { }, { } })= { }

define "FlattenListNullAndNull":
  ( Flatten({ { null }, { null } })= { null, null } ) = null

define "FlattenList12And34":
  Flatten({ { 1, 2 }, { 3, 4 } })= { 1, 2, 3, 4 }

define "FlattenDateTime":
  Flatten({ { DateTime(2012, 5, 10)}, { DateTime(2014, 12, 10)} })= { DateTime(2012, 5, 10), DateTime(2014, 12, 10)}

define "FlattenTime":
  Flatten({ { @T15:59:59.999 }, { @T20:59:59.999 } })= { @T15:59:59.999, @T20:59:59.999 }

define "FirstEmpty":
  First({ } as List<Integer>)= null

define "FirstNull1":
  First({ null, 1 })= null

define "First1Null":
  First({ 1, null })= 1

define "First12":
  First({ 1, 2 })= 1

define "FirstDateTime":
  First({ DateTime(2012, 5, 10), DateTime(2014, 12, 10)})= DateTime(2012, 5, 10)

define "FirstTime":
  First({ @T15:59:59.999, @T20:59:59.999 })= @T15:59:59.999

define "InNullEmpty":
  ( null in { } ) = null

define "InNullAnd1Null":
  ( null in { 1, null } ) = null

define "In1Null":
  ( 1 in null ) = false

define "In1And12":
  ( 1 in { 1, 2 } ) = true

define "In3And12":
  ( 3 in { 1, 2 } ) = false

define "InDateTimeTrue":
  ( DateTime(2012, 5, 10)in { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} ) = true

define "InDateTimeFalse":
  ( DateTime(2012, 6, 10)in { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} ) = false

define "InTimeTrue":
  ( @T15:59:59.999 in { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } ) = true

define "InTimeFalse":
  ( @T16:59:59.999 in { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } ) = false

define "IncludesEmptyAndEmpty":
  { } includes { } = true

define "IncludesListNullAndListNull":
  { null } includes { null } = true

define "Includes123AndEmpty":
  { 1, 2, 3 } includes ( { } as List<Integer>) = true

define "Includes123And2":
  { 1, 2, 3 } includes { 2 } = true

define "Includes123And4":
  { 1, 2, 3 } includes { 4 } = false

define "IncludesDateTimeTrue":
  { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} includes { DateTime(2012, 5, 10)} = true

define "IncludesDateTimeFalse":
  { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} includes { DateTime(2012, 5, 11)} = false

define "IncludesTimeTrue":
  { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } includes @T15:59:59.999 = true

define "IncludesTimeFalse":
  { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } includes @T16:59:59.999 = false

define "IncludesNullLeft":
  ( null as List<Integer>) includes { 2 } = null

define "IncludesNullRight":
  { 's', 'a', 'm' } includes ( null as String ) = null

define "IncludedInEmptyAndEmpty":
  { } included in { } = true

define "IncludedInListNullAndListNull":
  { null } included in { null } = true

define "IncludedInEmptyAnd123":
  ( { } as List<Integer>) included in { 1, 2, 3 } = true

define "IncludedIn2And123":
  { 2 } included in { 1, 2, 3 } = true

define "IncludedIn4And123":
  { 4 } included in { 1, 2, 3 } = false

define "IncludedInDateTimeTrue":
  { DateTime(2012, 5, 10)} included in { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} = true

define "IncludedInDateTimeFalse":
  { DateTime(2012, 5, 11)} included in { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} = false

define "IncludedInTimeTrue":
  @T15:59:59.999 included in { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } = true

define "IncludedInTimeFalse":
  @T16:59:59.999 included in { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } = false

define "IncludedInNullLeft":
  null included in { 2 } = null

define "IncludedInNullRight":
  { 's', 'a', 'm' } included in ( null as List<String>) = null

define "IndexerNull1List":
  ( null as List<System.Integer>)[1]= null

define "Indexer0Of12":
  { 1, 2 }[0]= 1

define "Indexer1Of12":
  { 1, 2 }[1]= 2

define "Indexer2Of12":
  { 1, 2 }[2]= null

define "IndexerNeg1Of12":
  { 1, 2 }[- 1]= null

define "IndexerDateTime":
  { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)}[1]= DateTime(2012, 5, 10)

define "IndexerTime":
  { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 }[1]= @T15:59:59.999

define "IndexOfEmptyNull":
  IndexOf({ }, null)= null

define "IndexOfNullEmpty":
  IndexOf(null, { })= null

define "IndexOfNullIn1Null":
  IndexOf({ 1, null }, null as Integer)= null

define "IndexOf1In12":
  IndexOf({ 1, 2 }, 1)= 0

define "IndexOf2In12":
  IndexOf({ 1, 2 }, 2)= 1

define "IndexOf3In12":
  IndexOf({ 1, 2 }, 3)= - 1

define "IndexOfDateTime":
  IndexOf({ DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)}, DateTime(2014, 12, 10))= 2

define "IndexOfTime":
  IndexOf({ @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 }, @T15:59:59.999)= 1

define "IntersectEmptyListAndEmptyList":
  ( { }
      intersect { }
  ) = { }

define "Intersect1234And23":
  ( { 1, 2, 3, 4 }
      intersect { 2, 3 }
  ) = { 2, 3 }

define "Intersect23And1234":
  ( { 2, 3 }
      intersect { 1, 2, 3, 4 }
  ) = { 2, 3 }

define "IntersectDateTime":
  ( { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)}
      intersect { DateTime(2012, 5, 10), DateTime(2014, 12, 10), DateTime(2000, 5, 5)}
  ) = { @2012-05-10, @2014-12-10 }

define "IntersectTime":
  ( { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 }
      intersect { @T01:29:15.156, @T15:59:59.999, @T20:59:59.999 }
  ) = { @T15:59:59.999, @T20:59:59.999 }

define "LastEmpty":
  Last({ } as List<Integer>)= null

define "LastNull1":
  Last({ null, 1 })= 1

define "Last1Null":
  Last({ 1, null })= null

define "Last12":
  Last({ 1, 2 })= 2

define "LastDateTime":
  Last({ DateTime(2012, 5, 10), DateTime(2014, 12, 10)})= DateTime(2014, 12, 10)

define "LastTime":
  Last({ @T15:59:59.999, @T20:59:59.999 })= @T20:59:59.999

define "LengthEmptyList":
  Length({ })= 0

define "LengthNull1":
  Length({ null, 1 })= 2

define "Length1Null":
  Length({ 1, null })= 2

define "Length12":
  Length({ 1, 2 })= 2

define "LengthDateTime":
  Length({ DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)})= 3

define "LengthTime":
  Length({ @T15:59:59.999, @T20:59:59.999, @T15:59:59.999, @T20:59:59.999, @T15:59:59.999, @T20:59:59.999 })= 6

define "LengthNullList":
  Length(null as String)= 0

define "EquivalentEmptyAndEmpty":
  { } ~ { } = true

define "EquivalentABCAndABC":
  { 'a', 'b', 'c' } ~ { 'a', 'b', 'c' } = true

define "EquivalentABCAndAB":
  { 'a', 'b', 'c' } ~ { 'a', 'b' } = false

define "EquivalentABCAnd123":
  { 'a', 'b', 'c' } ~ { 1, 2, 3 } = false

define "Equivalent123AndABC":
  { 1, 2, 3 } ~ { 'a', 'b', 'c' } = false

define "Equivalent123AndString123":
  { 1, 2, 3 } ~ { '1', '2', '3' } = false

define "EquivalentDateTimeTrue":
  { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10), null } ~ { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10), null } = true

define "EquivalentDateTimeNull":
  { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} ~ { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10), null } = false

define "EquivalentDateTimeFalse":
  { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} ~ { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 1)} = false

define "EquivalentTimeTrue":
  { @T15:59:59.999, @T20:59:59.999 } ~ { @T15:59:59.999, @T20:59:59.999 } = true

define "EquivalentTimeNull":
  { @T15:59:59.999, @T20:59:59.999 } ~ { @T15:59:59.999, @T20:59:59.999, null } = false

define "EquivalentTimeFalse":
  { @T15:59:59.999, @T20:59:59.999 } ~ { @T15:59:59.999, @T20:59:59.995 } = false

define "NotEqualEmptyAndEmpty":
  { } != { } = false

define "EmptyIsNotNull":
  ( {} is not null ) = true

define "NotEqualABCAndABC":
  { 'a', 'b', 'c' } != { 'a', 'b', 'c' } = false

define "NotEqualABCAndAB":
  { 'a', 'b', 'c' } != { 'a', 'b' } = true

define "NotEqualABCAnd123":
  { 'a', 'b', 'c' } != { 1, 2, 3 } = true

define "NotEqual123AndABC":
  { 1, 2, 3 } != { 'a', 'b', 'c' } = true

define "NotEqual123AndString123":
  { 1, 2, 3 } != { '1', '2', '3' } = true

define "NotEqualDateTimeTrue":
  { DateTime(2001, 9, 11, 0, 0, 0, 0), DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} != { DateTime(2001, 9, 11, 0, 0, 0, 0), DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 1, 0, 0, 0, 0)} = true

define "NotEqualDateTimeFalse":
  { DateTime(2001, 9, 11, 0, 0, 0, 0), DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} != { DateTime(2001, 9, 11, 0, 0, 0, 0), DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} = false

define "NotEqualTimeTrue":
  { @T15:59:59.999, @T20:59:59.999 } = { @T15:59:59.999, @T20:59:59.999 } = true

define "NotEqualTimeFalse":
  { @T15:59:59.999, @T20:59:59.999 } = { @T15:59:59.999, @T20:59:49.999 } = false

define "ProperContainsNullRightFalse":
  { 's', 'u', 'n' } properly includes ( null as String ) = false

define "ProperContainsNullRightTrue":
  { 's', 'u', 'n', null } properly includes ( null as String ) = true

define "ProperContainsTimeTrue":
  { @T15:59:59, @T20:59:59.999, @T20:59:49.999 } properly includes @T15:59:59 = true

define "ProperContainsTimeFalse":
  { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } properly includes @T15:59:59 = false

define "ProperInNullRightFalse":
  ( null as String ) properly included in { 's', 'u', 'n' } = false

define "ProperInNullRightTrue":
  ( null as String ) properly included in { 's', 'u', 'n', null } = true

define "ProperInTimeTrue":
  @T15:59:59 properly included in { @T15:59:59, @T20:59:59.999, @T20:59:49.999 } = true

define "ProperInTimeFalse":
  @T15:59:59 properly included in { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } = false

define "ProperIncludesEmptyAndEmpty":
  { } properly includes { } = false

define "ProperIncludesListNullAndListNull":
  { null } properly includes { null } = false

define "ProperIncludes123AndEmpty":
  { 1, 2, 3 } properly includes ( { } as List<Integer>) = true

define "ProperIncludes123And2":
  { 1, 2, 3 } properly includes { 2 } = true

define "ProperIncludes123And4":
  { 1, 2, 3 } properly includes { 4 } = false

define "ProperIncludesDateTimeTrue":
  { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} properly includes { DateTime(2012, 5, 10), DateTime(2014, 12, 10)} = true

define "ProperIncludesDateTimeFalse":
  { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} properly includes { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} = false

define "ProperIncludesTimeTrue":
  { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } properly includes { @T15:59:59.999, @T20:59:59.999 } = true

define "ProperIncludesTimeFalse":
  { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } properly includes { @T15:59:59.999, @T20:59:59.999, @T14:59:22.999 } = false

define "ProperlyIncludesNullLeft":
  ( null as List<Integer>) properly includes { 2 } = null

define "ProperIncludedInEmptyAndEmpty":
  { } properly included in { } = false

define "ProperIncludedInListNullAndListNull":
  { null } properly included in { null } = false

define "ProperIncludedInEmptyAnd123":
  ( { } as List<Integer>) properly included in { 1, 2, 3 } = true

define "ProperIncludedIn2And123":
  { 2 } properly included in { 1, 2, 3 } = true

define "ProperIncludedIn4And123":
  { 4 } properly included in { 1, 2, 3 } = false

define "ProperIncludedInDateTimeTrue":
  { DateTime(2012, 5, 10), DateTime(2014, 12, 10)} properly included in { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} = true

define "ProperIncludedInDateTimeFalse":
  { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} properly included in { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} = false

define "ProperIncludedInTimeTrue":
  { @T15:59:59.999, @T20:59:59.999 } properly included in { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } = true

define "ProperIncludedInTimeFalse":
  { @T15:59:59.999, @T20:59:59.999, @T14:59:22.999 } properly included in { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } = false

define "ProperlyIncludedInNulRight":
  { 's', 'u', 'n' } properly included in ( null as List<String>) = null

define "SingletonFromEmpty":
  ( singleton from { } as List<Integer>) = null

define "SingletonFromListNull":
  ( singleton from { null } as List<Integer>) = null

define "SingletonFrom1":
  singleton from { 1 } = 1

define "SingletonFrom12":
  singleton from { 1, 2 }

define "SingletonFromDateTime":
  singleton from { DateTime(2012, 5, 10)} = DateTime(2012, 5, 10)

define "SingletonFromTime":
  singleton from { @T15:59:59.999 } = @T15:59:59.999

define "SkipNull":
  Skip(null as List<Integer>, 3)= null

define "SkipEven":
  Skip({ 1, 2, 3, 4, 5 }, 2)= { 3, 4, 5 }

define "SkipOdd":
  Skip({ 1, 2, 3, 4, 5 }, 3)= { 4, 5 }

define "SkipNone":
  Skip({ 1, 2, 3, 4, 5 }, 0)= { 1, 2, 3, 4, 5 }

define "SkipAll":
  Skip({ 1, 2, 3, 4, 5 }, 5)= { }

define "TailNull":
  Tail(null as List<Integer>)= null

define "TailEven":
  Tail({ 1, 2, 3, 4 })= { 2, 3, 4 }

define "TailOdd":
  Tail({ 1, 2, 3, 4, 5 })= { 2, 3, 4, 5 }

define "TailEmpty":
  Tail({ })= { }

define "TailOneElement":
  Tail({ 1 })= { }

define "TakeNull":
  Take(null as List<Integer>, 3)= null

define "TakeNullEmpty":
  Take({ 1, 2, 3 }, null as Integer)= { }

define "TakeEmpty":
  Take({ 1, 2, 3 }, 0)= { }

define "TakeEven":
  Take({ 1, 2, 3, 4 }, 2)= { 1, 2 }

define "TakeOdd":
  Take({ 1, 2, 3, 4 }, 3)= { 1, 2, 3 }

define "TakeAll":
  Take({ 1, 2, 3, 4 }, 4)= { 1, 2, 3, 4 }

define "UnionEmptyAndEmpty":
  ( { }
      union { }
  ) = { }

define "UnionListNullAndListNull":
  ( ( { null }
        union { null }
    ) = { null }
  ) = null

define "Union123AndEmpty":
  ( { 1, 2, 3 }
      union ( { } as List<Integer>)
  ) = { 1, 2, 3 }

define "Union123And2":
  ( { 1, 2, 3 }
      union { 2 }
  ) = { 1, 2, 3 }

define "Union123And4":
  ( { 1, 2, 3 }
      union { 4 }
  ) = { 1, 2, 3, 4 }

define "UnionDateTime":
  ( { DateTime(2001, 9, 11)}
      union { DateTime(2012, 5, 10), DateTime(2014, 12, 10)}
  ) = { @2001-09-11, @2012-05-10, @2014-12-10 }

define "UnionTime":
  ( { @T15:59:59.999, @T20:59:59.999, @T12:59:59.999 }
      union { @T10:59:59.999 }
  ) = { @T15:59:59.999, @T20:59:59.999, @T12:59:59.999, @T10:59:59.999 }

define "intList":
  { 3, 2, 1 } = { 3, 2, 1 }

define "decimalList":
  { 3.8, 2.4, 1.9 } = { 3.8, 2.4, 1.9 }

// 'lbs' is not a known unit, so the following will did not compile to ELM. using kg instead
define "quantityList":
  { 19.99 'kg', 17.33 'kg', 10.66 'kg' } = { 19.99 'kg', 17.33 'kg', 10.66 'kg' }

define "dateTimeList":
  { DateTime(2016), DateTime(2015), DateTime(2010)} = { @2016T, @2015T, @2010T }

define "timeList":
  { @T15:59:59.999, @T15:12:59.999, @T15:12:13.999 } = { @T15:59:59.999, @T15:12:59.999, @T15:12:13.999 }