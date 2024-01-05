library CqlListOperatorsTest

context Unfiltered


define "simpleSortAsc Input":
	({4, 5, 1, 6, 2, 1}) sL sort asc
define "simpleSortAsc Output":
	{1, 1, 2, 4, 5, 6}

define "simpleSortDesc Input":
	({4, 5, 1, 6, 2, 1}) sL sort desc
define "simpleSortDesc Output":
	{6, 5, 4, 2, 1, 1}

define "simpleSortStringAsc Input":
	({'back', 'aardvark', 'alligator', 'zebra', 'iguana', 'Wolf', 'Armadillo'}) sls sort asc
define "simpleSortStringAsc Output":
	{'Armadillo', 'Wolf', 'aardvark', 'alligator', 'back', 'iguana', 'zebra'}

define "simpleSortStringDesc Input":
	({'back', 'aardvark', 'alligator', 'zebra', 'iguana', 'Wolf', 'Armadillo'}) sls sort desc
define "simpleSortStringDesc Output":
	{'zebra', 'iguana', 'back', 'alligator', 'aardvark', 'Wolf', 'Armadillo'}

define "SortDatesAsc Input":
	({ DateTime(2012, 10, 5, 10), DateTime(2012, 1, 1), DateTime(2012, 1, 1, 12), DateTime(2012, 10, 5) }) S sort asc
define "SortDatesAsc Output":
	{DateTime(2012, 1, 1), DateTime(2012, 1, 1, 12), DateTime(2012, 10, 5), DateTime(2012, 10, 5, 10)}

define "SortDatesDesc Input":
	({ DateTime(2012, 10, 5, 10), DateTime(2012, 1, 1), DateTime(2012, 1, 1, 12), DateTime(2012, 10, 5) }) S sort desc
define "SortDatesDesc Output":
	{DateTime(2012, 10, 5, 10), DateTime(2012, 10, 5), DateTime(2012, 1, 1, 12), DateTime(2012, 1, 1)}

define "intList Input":
	{ 3, 2, 1 }
define "intList Output":
	{3, 2, 1}

define "decimalList Input":
	{ 3.8, 2.4, 1.9 }
define "decimalList Output":
	{3.8, 2.4, 1.9}

define "quantityList Input":
	{ 19.99 '[lb_av]', 17.33 '[lb_av]', 10.66 '[lb_av]' }
define "quantityList Output":
	{19.99 '[lb_av]', 17.33 '[lb_av]', 10.66 '[lb_av]'}

define "dateTimeList Input":
	{ DateTime(2016), DateTime(2015), DateTime(2010) }
define "dateTimeList Output":
	{@2016T, @2015T, @2010T}

define "timeList Input":
	{ @T15:59:59.999, @T15:12:59.999, @T15:12:13.999 }
define "timeList Output":
	{@T15:59:59.999, @T15:12:59.999, @T15:12:13.999}

define "ContainsABNullHasNull Input":
	{ 'a', 'b', null } contains null
define "ContainsABNullHasNull Output":
	null

define "ContainsNullFirst Input":
	{ null, 'b', 'c' } contains 'a'
define "ContainsNullFirst Output":
	false

define "ContainsABCHasA Input":
	{ 'a', 'b', 'c' } contains 'a'
define "ContainsABCHasA Output":
	true

define "ContainsJan2012True Input":
	{ DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 1, 1) } contains DateTime(2012, 1, 1)
define "ContainsJan2012True Output":
	true

define "ContainsJan2012False Input":
	{ DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 10, 1) } contains DateTime(2012, 1, 1)
define "ContainsJan2012False Output":
	false

define "ContainsTimeTrue Input":
	{ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 } contains @T05:59:59.999
define "ContainsTimeTrue Output":
	true

define "ContainsTimeFalse Input":
	{ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 } contains @T08:59:59.999
define "ContainsTimeFalse Output":
	false

define "ContainsNullLeft Input":
	null contains 'a'
define "ContainsNullLeft Output":
	false

define "DescendentsEmptyList Input":
	(null).descendents()
define "DescendentsEmptyList Output":
	null

define "DistinctEmptyList Input":
	distinct {}
define "DistinctEmptyList Output":
	{}

define "DistinctNullNullNull Input":
	distinct { null, null, null}
define "DistinctNullNullNull Output":
	{ null }

define "DistinctANullANull Input":
	distinct { 'a', null, 'a', null}
define "DistinctANullANull Output":
	{'a', null}

define "Distinct112233 Input":
	distinct { 1, 1, 2, 2, 3, 3}
define "Distinct112233 Output":
	{1,2,3}

define "Distinct123123 Input":
	distinct { 1, 2, 3, 1, 2, 3}
define "Distinct123123 Output":
	{1,2,3}

define "DistinctAABBCC Input":
	distinct { 'a', 'a', 'b', 'b', 'c', 'c'}
define "DistinctAABBCC Output":
	{'a','b','c'}

define "DistinctABCABC Input":
	distinct { 'a', 'b', 'c', 'a', 'b', 'c'}
define "DistinctABCABC Output":
	{'a','b','c'}

define "DistinctDateTime Input":
	distinct { DateTime(2012, 10, 5), DateTime(2012, 1, 1), DateTime(2012, 1, 1)}
define "DistinctDateTime Output":
	{ DateTime(2012, 10, 5), DateTime(2012, 1, 1)}

define "DistinctTime Input":
	distinct { @T15:59:59.999, @T20:59:59.999 }
define "DistinctTime Output":
	{ @T15:59:59.999, @T20:59:59.999 }

define "EqualNullNull Input":
	{null} = {null}
define "EqualNullNull Output":
	null

define "EqualEmptyListNull Input":
	{} as List<String> = null
define "EqualEmptyListNull Output":
	null

define "EqualNullEmptyList Input":
	null = {} as List<String>
define "EqualNullEmptyList Output":
	null

define "EqualEmptyListAndEmptyList Input":
	{} = {}
define "EqualEmptyListAndEmptyList Output":
	true

define "Equal12And123 Input":
	{ 1, 2 } = { 1, 2, 3 }
define "Equal12And123 Output":
	false

define "Equal123And12 Input":
	{ 1, 2, 3 } = { 1, 2 }
define "Equal123And12 Output":
	false

define "Equal123And123 Input":
	{ 1, 2, 3 } = { 1, 2, 3 }
define "Equal123And123 Output":
	true

define "EqualDateTimeTrue Input":
	{DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} = {DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)}
define "EqualDateTimeTrue Output":
	true

define "EqualDateTimeFalse Input":
	{DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} = {DateTime(2012, 1, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)}
define "EqualDateTimeFalse Output":
	false

define "EqualTimeTrue Input":
	{ @T15:59:59.999, @T20:59:59.999, @T20:59:59.999 } = { @T15:59:59.999, @T20:59:59.999, @T20:59:59.999 }
define "EqualTimeTrue Output":
	true

define "EqualTimeFalse Input":
	{ @T15:59:59.999, @T20:59:59.999, @T20:59:59.999 } = { @T10:59:59.999, @T20:59:59.999, @T20:59:59.999 }
define "EqualTimeFalse Output":
	false

define "ExceptEmptyListAndEmptyList Input":
	{} except {}
define "ExceptEmptyListAndEmptyList Output":
	{}

define "Except1234And23 Input":
	{ 1, 2, 3, 4 } except { 2, 3 }
define "Except1234And23 Output":
	{ 1, 4 }

define "Except23And1234 Input":
	{ 2, 3 } except { 1, 2, 3, 4 }
define "Except23And1234 Output":
	{}

define "ExceptDateTimeList Input":
	{ DateTime(2012, 5, 10), DateTime(2014, 12, 10), DateTime(2010, 1, 1)} except {DateTime(2014, 12, 10), DateTime(2010, 1, 1) }
define "ExceptDateTimeList Output":
	{@2012-05-10T}

define "ExceptTimeList Input":
	{ @T15:59:59.999, @T20:59:59.999, @T12:59:59.999 } except { @T20:59:59.999, @T12:59:59.999 }
define "ExceptTimeList Output":
	{@T15:59:59.999}

define "ExceptNullRight Input":
	{ 1, 4 } except null
define "ExceptNullRight Output":
	{1, 4}

define "ExistsEmpty Input":
	Exists({})
define "ExistsEmpty Output":
	false

define "ExistsListNull Input":
	Exists({ null })
define "ExistsListNull Output":
	false

define "Exists1 Input":
	Exists({ 1 })
define "Exists1 Output":
	true

define "Exists12 Input":
	Exists({ 1, 2 })
define "Exists12 Output":
	true

define "ExistsDateTime Input":
	Exists({ DateTime(2012, 5, 10), DateTime(2014, 12, 10) })
define "ExistsDateTime Output":
	true

define "ExistsTime Input":
	Exists({ @T15:59:59.999, @T20:59:59.999 })
define "ExistsTime Output":
	true

define "ExistsNull Input":
	Exists(null)
define "ExistsNull Output":
	false

define "FlattenEmpty Input":
	Flatten({{},{}})
define "FlattenEmpty Output":
	{}

define "FlattenListNullAndNull Input":
	Flatten({{null}, {null}})
define "FlattenListNullAndNull Output":
	{null, null}

define "FlattenList12And34 Input":
	Flatten({{1,2}, {3,4}})
define "FlattenList12And34 Output":
	{1,2,3,4}

define "FlattenDateTime Input":
	Flatten({ {DateTime(2012, 5, 10)}, {DateTime(2014, 12, 10)} })
define "FlattenDateTime Output":
	{ DateTime(2012, 5, 10), DateTime(2014, 12, 10) }

define "FlattenTime Input":
	Flatten({ {@T15:59:59.999}, {@T20:59:59.999} })
define "FlattenTime Output":
	{ @T15:59:59.999, @T20:59:59.999 }

define "FirstEmpty Input":
	First({})
define "FirstEmpty Output":
	null

define "FirstNull1 Input":
	First({ null, 1 })
define "FirstNull1 Output":
	null

define "First1Null Input":
	First({ 1, null })
define "First1Null Output":
	1

define "First12 Input":
	First({ 1, 2 })
define "First12 Output":
	1

define "FirstDateTime Input":
	First({ DateTime(2012, 5, 10), DateTime(2014, 12, 10) })
define "FirstDateTime Output":
	DateTime(2012, 5, 10)

define "FirstTime Input":
	First({ @T15:59:59.999, @T20:59:59.999 })
define "FirstTime Output":
	@T15:59:59.999

define "InNullEmpty Input":
	null in {}
define "InNullEmpty Output":
	null

define "InNullAnd1Null Input":
	null in { 1, null }
define "InNullAnd1Null Output":
	null

define "In1Null Input":
	1 in null
define "In1Null Output":
	false

define "In1And12 Input":
	1 in { 1, 2 }
define "In1And12 Output":
	true

define "In3And12 Input":
	3 in { 1, 2 }
define "In3And12 Output":
	false

define "InDateTimeTrue Input":
	DateTime(2012, 5, 10) in { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10) }
define "InDateTimeTrue Output":
	true

define "InDateTimeFalse Input":
	DateTime(2012, 6, 10) in { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10) }
define "InDateTimeFalse Output":
	false

define "InTimeTrue Input":
	@T15:59:59.999 in { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 }
define "InTimeTrue Output":
	true

define "InTimeFalse Input":
	@T16:59:59.999 in { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 }
define "InTimeFalse Output":
	false

define "IncludesEmptyAndEmpty Input":
	{} includes {}
define "IncludesEmptyAndEmpty Output":
	true

define "IncludesListNullAndListNull Input":
	{null} includes {null}
define "IncludesListNullAndListNull Output":
	true

define "Includes123AndEmpty Input":
	{1, 2, 3} includes {}
define "Includes123AndEmpty Output":
	true

define "Includes123And2 Input":
	{1, 2, 3} includes {2}
define "Includes123And2 Output":
	true

define "Includes123And4 Input":
	{1, 2, 3} includes {4}
define "Includes123And4 Output":
	false

define "IncludesDateTimeTrue Input":
	{DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} includes {DateTime(2012, 5, 10)}
define "IncludesDateTimeTrue Output":
	true

define "IncludesDateTimeFalse Input":
	{DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} includes {DateTime(2012, 5, 11)}
define "IncludesDateTimeFalse Output":
	false

define "IncludesTimeTrue Input":
	{ @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } includes @T15:59:59.999
define "IncludesTimeTrue Output":
	true

define "IncludesTimeFalse Input":
	{ @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } includes @T16:59:59.999
define "IncludesTimeFalse Output":
	false

define "IncludesNullLeft Input":
	null includes {2}
define "IncludesNullLeft Output":
	null

define "IncludesNullRight Input":
	{'s', 'a', 'm'} includes null
define "IncludesNullRight Output":
	null

define "IncludedInEmptyAndEmpty Input":
	{} included in {}
define "IncludedInEmptyAndEmpty Output":
	true

define "IncludedInListNullAndListNull Input":
	{ null } included in { null }
define "IncludedInListNullAndListNull Output":
	true

define "IncludedInEmptyAnd123 Input":
	{} included in { 1, 2, 3 }
define "IncludedInEmptyAnd123 Output":
	true

define "IncludedIn2And123 Input":
	{ 2 } included in { 1, 2, 3 }
define "IncludedIn2And123 Output":
	true

define "IncludedIn4And123 Input":
	{ 4 } included in { 1, 2, 3 }
define "IncludedIn4And123 Output":
	false

define "IncludedInDateTimeTrue Input":
	{ DateTime(2012, 5, 10)} included in {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)}
define "IncludedInDateTimeTrue Output":
	true

define "IncludedInDateTimeFalse Input":
	{DateTime(2012, 5, 11)} included in {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)}
define "IncludedInDateTimeFalse Output":
	false

define "IncludedInTimeTrue Input":
	@T15:59:59.999 included in { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 }
define "IncludedInTimeTrue Output":
	true

define "IncludedInTimeFalse Input":
	@T16:59:59.999 included in { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 }
define "IncludedInTimeFalse Output":
	false

define "IncludedInNullLeft Input":
	null included in {2}
define "IncludedInNullLeft Output":
	null

define "IncludedInNullRight Input":
	{'s', 'a', 'm'} included in null
define "IncludedInNullRight Output":
	null

define "IndexerNull1List Input":
	(null as List<System.Any>)[1]
define "IndexerNull1List Output":
	null

define "Indexer0Of12 Input":
	{ 1, 2 }[0]
define "Indexer0Of12 Output":
	1

define "Indexer1Of12 Input":
	{ 1, 2 }[1]
define "Indexer1Of12 Output":
	2

define "Indexer2Of12 Input":
	{ 1, 2 }[2]
define "Indexer2Of12 Output":
	null

define "IndexerNeg1Of12 Input":
	{ 1, 2 }[-1]
define "IndexerNeg1Of12 Output":
	null

define "IndexerDateTime Input":
	{ DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10) }[1]
define "IndexerDateTime Output":
	DateTime(2012, 5, 10)

define "IndexerTime Input":
	{ @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 }[1]
define "IndexerTime Output":
	@T15:59:59.999

define "IndexOfEmptyNull Input":
	IndexOf({}, null)
define "IndexOfEmptyNull Output":
	null

define "IndexOfNullEmpty Input":
	IndexOf(null, {})
define "IndexOfNullEmpty Output":
	null

define "IndexOfNullIn1Null Input":
	IndexOf({ 1, null }, null)
define "IndexOfNullIn1Null Output":
	null

define "IndexOf1In12 Input":
	IndexOf({ 1, 2 }, 1)
define "IndexOf1In12 Output":
	0

define "IndexOf2In12 Input":
	IndexOf({ 1, 2 }, 2)
define "IndexOf2In12 Output":
	1

define "IndexOf3In12 Input":
	IndexOf({ 1, 2 }, 3)
define "IndexOf3In12 Output":
	-1

define "IndexOfDateTime Input":
	IndexOf({ DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10) }, DateTime(2014, 12, 10))
define "IndexOfDateTime Output":
	2

define "IndexOfTime Input":
	IndexOf({ @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 }, @T15:59:59.999)
define "IndexOfTime Output":
	1

define "IntersectEmptyListAndEmptyList Input":
	{} intersect {}
define "IntersectEmptyListAndEmptyList Output":
	{}

define "Intersect1234And23 Input":
	{ 1, 2, 3, 4 } intersect { 2, 3 }
define "Intersect1234And23 Output":
	{ 2, 3 }

define "Intersect23And1234 Input":
	{2, 3} intersect { 1, 2, 3, 4 }
define "Intersect23And1234 Output":
	{ 2, 3 }

define "IntersectDateTime Input":
	{ DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10) } intersect { DateTime(2012, 5, 10), DateTime(2014, 12, 10), DateTime(2000, 5, 5) }
define "IntersectDateTime Output":
	{@2012-05-10T, @2014-12-10T}

define "IntersectTime Input":
	{ @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } intersect { @T01:29:15.156, @T15:59:59.999, @T20:59:59.999 }
define "IntersectTime Output":
	{@T15:59:59.999, @T20:59:59.999}

define "LastEmpty Input":
	Last({})
define "LastEmpty Output":
	null

define "LastNull1 Input":
	Last({null, 1})
define "LastNull1 Output":
	1

define "Last1Null Input":
	Last({1, null})
define "Last1Null Output":
	null

define "Last12 Input":
	Last({1, 2})
define "Last12 Output":
	2

define "LastDateTime Input":
	Last({DateTime(2012, 5, 10), DateTime(2014, 12, 10)})
define "LastDateTime Output":
	DateTime(2014, 12, 10)

define "LastTime Input":
	Last({ @T15:59:59.999, @T20:59:59.999 })
define "LastTime Output":
	@T20:59:59.999

define "LengthEmptyList Input":
	Length({})
define "LengthEmptyList Output":
	0

define "LengthNull1 Input":
	Length({null, 1})
define "LengthNull1 Output":
	2

define "Length1Null Input":
	Length({1, null})
define "Length1Null Output":
	2

define "Length12 Input":
	Length({1, 2})
define "Length12 Output":
	2

define "LengthDateTime Input":
	Length({DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)})
define "LengthDateTime Output":
	3

define "LengthTime Input":
	Length({ @T15:59:59.999, @T20:59:59.999, @T15:59:59.999, @T20:59:59.999, @T15:59:59.999, @T20:59:59.999 })
define "LengthTime Output":
	6

define "LengthNullList Input":
	Length(null as List<Any>)
define "LengthNullList Output":
	0

define "EquivalentEmptyAndEmpty Input":
	{} ~ {}
define "EquivalentEmptyAndEmpty Output":
	true

define "EquivalentABCAndABC Input":
	{ 'a', 'b', 'c' } ~ { 'a', 'b', 'c' }
define "EquivalentABCAndABC Output":
	true

define "EquivalentABCAndAB Input":
	{ 'a', 'b', 'c' } ~ { 'a', 'b' }
define "EquivalentABCAndAB Output":
	false

define "EquivalentABCAnd123 Input":
	{ 'a', 'b', 'c' } ~ { 1, 2, 3 }
define "EquivalentABCAnd123 Output":
	false

define "Equivalent123AndABC Input":
	{ 1, 2, 3 } ~ { 'a', 'b', 'c' }
define "Equivalent123AndABC Output":
	false

define "Equivalent123AndString123 Input":
	{ 1, 2, 3 } ~ { '1', '2', '3' }
define "Equivalent123AndString123 Output":
	false

define "EquivalentDateTimeTrue Input":
	{DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10), null} ~ {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10), null}
define "EquivalentDateTimeTrue Output":
	true

define "EquivalentDateTimeNull Input":
	{DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} ~ {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10), null}
define "EquivalentDateTimeNull Output":
	false

define "EquivalentDateTimeFalse Input":
	{DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} ~ {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 1)}
define "EquivalentDateTimeFalse Output":
	false

define "EquivalentTimeTrue Input":
	{ @T15:59:59.999, @T20:59:59.999 } ~ { @T15:59:59.999, @T20:59:59.999 }
define "EquivalentTimeTrue Output":
	true

define "EquivalentTimeNull Input":
	{ @T15:59:59.999, @T20:59:59.999 } ~ { @T15:59:59.999, @T20:59:59.999, null }
define "EquivalentTimeNull Output":
	false

define "EquivalentTimeFalse Input":
	{ @T15:59:59.999, @T20:59:59.999 } ~ { @T15:59:59.999, @T20:59:59.995 }
define "EquivalentTimeFalse Output":
	false

define "NotEqualEmptyAndEmpty Input":
	{} != {}
define "NotEqualEmptyAndEmpty Output":
	false

define "NotEqualABCAndABC Input":
	{ 'a', 'b', 'c' } != { 'a', 'b', 'c' }
define "NotEqualABCAndABC Output":
	false

define "NotEqualABCAndAB Input":
	{ 'a', 'b', 'c' } != { 'a', 'b' }
define "NotEqualABCAndAB Output":
	true

define "NotEqualABCAnd123 Input":
	{ 'a', 'b', 'c' } != { 1, 2, 3 }
define "NotEqualABCAnd123 Output":
	true

define "NotEqual123AndABC Input":
	{ 1, 2, 3 } != { 'a', 'b', 'c' }
define "NotEqual123AndABC Output":
	true

define "NotEqual123AndString123 Input":
	{ 1, 2, 3 } != { '1', '2', '3' }
define "NotEqual123AndString123 Output":
	true

define "NotEqualDateTimeTrue Input":
	{DateTime(2001, 9, 11, 0, 0, 0, 0), DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} != {DateTime(2001, 9, 11, 0, 0, 0, 0), DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 1, 0, 0, 0, 0)}
define "NotEqualDateTimeTrue Output":
	true

define "NotEqualDateTimeFalse Input":
	{DateTime(2001, 9, 11, 0, 0, 0, 0), DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} != {DateTime(2001, 9, 11, 0, 0, 0, 0), DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)}
define "NotEqualDateTimeFalse Output":
	false

define "NotEqualTimeTrue Input":
	{ @T15:59:59.999, @T20:59:59.999 } = { @T15:59:59.999, @T20:59:59.999 }
define "NotEqualTimeTrue Output":
	true

define "NotEqualTimeFalse Input":
	{ @T15:59:59.999, @T20:59:59.999 } = { @T15:59:59.999, @T20:59:49.999 }
define "NotEqualTimeFalse Output":
	false

define "ProperContainsNullRightFalse Input":
	{'s', 'u', 'n'} properly includes null
define "ProperContainsNullRightFalse Output":
	false

define "ProperContainsNullRightTrue Input":
	{'s', 'u', 'n', null} properly includes null
define "ProperContainsNullRightTrue Output":
	true

define "ProperContainsTimeTrue Input":
	{ @T15:59:59, @T20:59:59.999, @T20:59:49.999 } properly includes @T15:59:59
define "ProperContainsTimeTrue Output":
	true

define "ProperContainsTimeNull Input":
	{ @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } properly includes @T15:59:59
define "ProperContainsTimeNull Output":
	null

define "ProperInNullRightFalse Input":
	null properly included in {'s', 'u', 'n'}
define "ProperInNullRightFalse Output":
	false

define "ProperInNullRightTrue Input":
	null properly included in {'s', 'u', 'n', null}
define "ProperInNullRightTrue Output":
	true

define "ProperInTimeTrue Input":
	@T15:59:59 properly included in { @T15:59:59, @T20:59:59.999, @T20:59:49.999 }
define "ProperInTimeTrue Output":
	true

define "ProperInTimeNull Input":
	@T15:59:59 properly included in { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 }
define "ProperInTimeNull Output":
	null

define "ProperIncludesEmptyAndEmpty Input":
	{} properly includes {}
define "ProperIncludesEmptyAndEmpty Output":
	false

define "ProperIncludesListNullAndListNull Input":
	{null} properly includes {null}
define "ProperIncludesListNullAndListNull Output":
	false

define "ProperIncludes123AndEmpty Input":
	{1, 2, 3} properly includes {}
define "ProperIncludes123AndEmpty Output":
	true

define "ProperIncludes123And2 Input":
	{1, 2, 3} properly includes {2}
define "ProperIncludes123And2 Output":
	true

define "ProperIncludes123And4 Input":
	{1, 2, 3} properly includes {4}
define "ProperIncludes123And4 Output":
	false

define "ProperIncludesDateTimeTrue Input":
	{DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} properly includes {DateTime(2012, 5, 10), DateTime(2014, 12, 10)}
define "ProperIncludesDateTimeTrue Output":
	true

define "ProperIncludesDateTimeFalse Input":
	{DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} properly includes {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)}
define "ProperIncludesDateTimeFalse Output":
	false

define "ProperIncludesTimeTrue Input":
	{ @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } properly includes { @T15:59:59.999, @T20:59:59.999 }
define "ProperIncludesTimeTrue Output":
	true

define "ProperIncludesTimeFalse Input":
	{ @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } properly includes { @T15:59:59.999, @T20:59:59.999, @T14:59:22.999 }
define "ProperIncludesTimeFalse Output":
	false

define "ProperlyIncludesNullLeft Input":
	null properly includes {2}
define "ProperlyIncludesNullLeft Output":
	null

define "ProperIncludedInEmptyAndEmpty Input":
	{} properly included in {}
define "ProperIncludedInEmptyAndEmpty Output":
	false

define "ProperIncludedInListNullAndListNull Input":
	{null} properly included in {null}
define "ProperIncludedInListNullAndListNull Output":
	false

define "ProperIncludedInEmptyAnd123 Input":
	{} properly included in {1, 2, 3}
define "ProperIncludedInEmptyAnd123 Output":
	true

define "ProperIncludedIn2And123 Input":
	{2} properly included in {1, 2, 3}
define "ProperIncludedIn2And123 Output":
	true

define "ProperIncludedIn4And123 Input":
	{4} properly included in {1, 2, 3}
define "ProperIncludedIn4And123 Output":
	false

define "ProperIncludedInDateTimeTrue Input":
	{DateTime(2012, 5, 10), DateTime(2014, 12, 10)} properly included in {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)}
define "ProperIncludedInDateTimeTrue Output":
	true

define "ProperIncludedInDateTimeFalse Input":
	{DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} properly included in {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)}
define "ProperIncludedInDateTimeFalse Output":
	false

define "ProperIncludedInTimeTrue Input":
	{ @T15:59:59.999, @T20:59:59.999 } properly included in { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 }
define "ProperIncludedInTimeTrue Output":
	true

define "ProperIncludedInTimeFalse Input":
	{ @T15:59:59.999, @T20:59:59.999, @T14:59:22.999 } properly included in { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 }
define "ProperIncludedInTimeFalse Output":
	false

define "ProperlyIncludedInNulRight Input":
	{'s', 'u', 'n'} properly included in null
define "ProperlyIncludedInNulRight Output":
	null

define "SingletonFromEmpty Input":
	singleton from {}
define "SingletonFromEmpty Output":
	null

define "SingletonFromListNull Input":
	singleton from {null}
define "SingletonFromListNull Output":
	null

define "SingletonFrom1 Input":
	singleton from { 1 }
define "SingletonFrom1 Output":
	1

define "SingletonFrom12":
	singleton from { 1, 2 }

define "SingletonFromDateTime Input":
	singleton from { DateTime(2012, 5, 10) }
define "SingletonFromDateTime Output":
	DateTime(2012, 5, 10)

define "SingletonFromTime Input":
	singleton from { @T15:59:59.999 }
define "SingletonFromTime Output":
	@T15:59:59.999

define "SkipNull Input":
	Skip(null, 3)
define "SkipNull Output":
	null

define "SkipEven Input":
	Skip({1,2,3,4,5}, 2)
define "SkipEven Output":
	{3, 4, 5}

define "SkipOdd Input":
	Skip({1,2,3,4,5}, 3)
define "SkipOdd Output":
	{4, 5}

define "SkipNone Input":
	Skip({1,2,3,4,5}, 0)
define "SkipNone Output":
	{1,2,3,4,5}

define "SkipAll Input":
	Skip({1,2,3,4,5}, 5)
define "SkipAll Output":
	{}

define "TailNull Input":
	Tail(null)
define "TailNull Output":
	null

define "TailEven Input":
	Tail({1,2,3,4})
define "TailEven Output":
	{2,3,4}

define "TailOdd Input":
	Tail({1,2,3,4,5})
define "TailOdd Output":
	{2,3,4,5}

define "TailEmpty Input":
	Tail({})
define "TailEmpty Output":
	{}

define "TailOneElement Input":
	Tail({1})
define "TailOneElement Output":
	{}

define "TakeNull Input":
	Take(null, 3)
define "TakeNull Output":
	null

define "TakeNullEmpty Input":
	Take({1,2,3}, null as Integer)
define "TakeNullEmpty Output":
	{}

define "TakeEmpty Input":
	Take({1,2,3}, 0)
define "TakeEmpty Output":
	{}

define "TakeEven Input":
	Take({1,2,3,4}, 2)
define "TakeEven Output":
	{1, 2}

define "TakeOdd Input":
	Take({1,2,3,4}, 3)
define "TakeOdd Output":
	{1, 2, 3}

define "TakeAll Input":
	Take({1,2,3,4}, 4)
define "TakeAll Output":
	{1, 2, 3, 4}

define "UnionEmptyAndEmpty Input":
	{} union {}
define "UnionEmptyAndEmpty Output":
	{}

define "UnionListNullAndListNull Input":
	{ null } union { null }
define "UnionListNullAndListNull Output":
	{null}

define "Union123AndEmpty Input":
	{ 1, 2, 3 } union {}
define "Union123AndEmpty Output":
	{1, 2, 3}

define "Union123And2 Input":
	{ 1, 2, 3 } union { 2 }
define "Union123And2 Output":
	{1, 2, 3}

define "Union123And4 Input":
	{ 1, 2, 3 } union { 4 }
define "Union123And4 Output":
	{1, 2, 3, 4}

define "UnionDateTime Input":
	{ DateTime(2001, 9, 11)} union {DateTime(2012, 5, 10), DateTime(2014, 12, 10) }
define "UnionDateTime Output":
	{@2001-09-11T, @2012-05-10T, @2014-12-10T}

define "UnionTime Input":
	{ @T15:59:59.999, @T20:59:59.999, @T12:59:59.999 } union { @T10:59:59.999 }
define "UnionTime Output":
	{@T15:59:59.999, @T20:59:59.999, @T12:59:59.999, @T10:59:59.999}
