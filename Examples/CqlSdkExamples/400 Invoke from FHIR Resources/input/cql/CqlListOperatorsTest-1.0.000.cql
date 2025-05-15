library CqlListOperatorsTest version '1.0.000'

define "Sort.simpleSortAsc": ({4, 5, 1, 6, 2, 1}) sL sort asc

define "Sort.simpleSortDesc": ({4, 5, 1, 6, 2, 1}) sL sort desc

define "Sort.simpleSortStringAsc": ({'back', 'aardvark', 'alligator', 'zebra', 'iguana', 'Wolf', 'Armadillo'}) sls sort asc

define "Sort.simpleSortStringDesc": ({'back', 'aardvark', 'alligator', 'zebra', 'iguana', 'Wolf', 'Armadillo'}) sls sort desc

define "Sort.SortDatesAsc": ({ DateTime(2012, 10, 5, 10), DateTime(2012, 1, 1), DateTime(2012, 1, 1, 12), DateTime(2012, 10, 5) }) S sort asc

define "Sort.SortDatesDesc": ({ DateTime(2012, 10, 5, 10), DateTime(2012, 1, 1), DateTime(2012, 1, 1, 12), DateTime(2012, 10, 5) }) S sort desc

define "Sort.intList": { 3, 2, 1 }

define "Sort.decimalList": { 3.8, 2.4, 1.9 }

define "Sort.quantityList": { 19.99 '[lb_av]', 17.33 '[lb_av]', 10.66 '[lb_av]' }

define "Sort.dateTimeList": { DateTime(2016), DateTime(2015), DateTime(2010) }

define "Sort.timeList": { @T15:59:59.999, @T15:12:59.999, @T15:12:13.999 }

define "Contains.ContainsABNullHasNull": { 'a', 'b', null } contains null

define "Contains.ContainsNullFirst": { null, 'b', 'c' } contains 'a'

define "Contains.ContainsABCHasA": { 'a', 'b', 'c' } contains 'a'

define "Contains.ContainsJan2012True": { DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 1, 1) } contains DateTime(2012, 1, 1)

define "Contains.ContainsJan2012False": { DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 10, 1) } contains DateTime(2012, 1, 1)

define "Contains.ContainsTimeTrue": { @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 } contains @T05:59:59.999

define "Contains.ContainsTimeFalse": { @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 } contains @T08:59:59.999

define "Contains.ContainsNullLeft": null contains 'a'

define "Descendents.DescendentsEmptyList": (null).descendents()

define "Distinct.DistinctEmptyList": distinct {}

define "Distinct.DistinctNullNullNull": distinct { null, null, null}

define "Distinct.DistinctANullANull": distinct { 'a', null, 'a', null}

define "Distinct.Distinct112233": distinct { 1, 1, 2, 2, 3, 3}

define "Distinct.Distinct123123": distinct { 1, 2, 3, 1, 2, 3}

define "Distinct.DistinctAABBCC": distinct { 'a', 'a', 'b', 'b', 'c', 'c'}

define "Distinct.DistinctABCABC": distinct { 'a', 'b', 'c', 'a', 'b', 'c'}

define "Distinct.DistinctDateTime": distinct { DateTime(2012, 10, 5), DateTime(2012, 1, 1), DateTime(2012, 1, 1)}

define "Distinct.DistinctTime": distinct { @T15:59:59.999, @T20:59:59.999 }

define "Equal.EqualNullNull": {null} = {null}

define "Equal.EqualEmptyListNull": {} as List<String> = null

define "Equal.EqualNullEmptyList": null = {} as List<String>

define "Equal.EqualEmptyListAndEmptyList": {} = {}

define "Equal.Equal12And123": { 1, 2 } = { 1, 2, 3 }

define "Equal.Equal123And12": { 1, 2, 3 } = { 1, 2 }

define "Equal.Equal123And123": { 1, 2, 3 } = { 1, 2, 3 }

define "Equal.EqualDateTimeTrue": {DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} = {DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)}

define "Equal.EqualDateTimeFalse": {DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} = {DateTime(2012, 1, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)}

define "Equal.EqualTimeTrue": { @T15:59:59.999, @T20:59:59.999, @T20:59:59.999 } = { @T15:59:59.999, @T20:59:59.999, @T20:59:59.999 }

define "Equal.EqualTimeFalse": { @T15:59:59.999, @T20:59:59.999, @T20:59:59.999 } = { @T10:59:59.999, @T20:59:59.999, @T20:59:59.999 }

define "Except.ExceptEmptyListAndEmptyList": {} except {}

define "Except.Except1234And23": { 1, 2, 3, 4 } except { 2, 3 }

define "Except.Except23And1234": { 2, 3 } except { 1, 2, 3, 4 }

define "Except.ExceptDateTimeList": { DateTime(2012, 5, 10), DateTime(2014, 12, 10), DateTime(2010, 1, 1)} except {DateTime(2014, 12, 10), DateTime(2010, 1, 1) }

define "Except.ExceptTimeList": { @T15:59:59.999, @T20:59:59.999, @T12:59:59.999 } except { @T20:59:59.999, @T12:59:59.999 }

define "Except.ExceptNullRight": { 1, 4 } except null

define "Exists.ExistsEmpty": Exists({})

define "Exists.ExistsListNull": Exists({ null })

define "Exists.Exists1": Exists({ 1 })

define "Exists.Exists12": Exists({ 1, 2 })

define "Exists.ExistsDateTime": Exists({ DateTime(2012, 5, 10), DateTime(2014, 12, 10) })

define "Exists.ExistsTime": Exists({ @T15:59:59.999, @T20:59:59.999 })

define "Exists.ExistsNull": Exists(null)

define "Flatten.FlattenEmpty": Flatten({{},{}})

define "Flatten.FlattenListNullAndNull": Flatten({{null}, {null}})

define "Flatten.FlattenList12And34": Flatten({{1,2}, {3,4}})

define "Flatten.FlattenDateTime": Flatten({ {DateTime(2012, 5, 10)}, {DateTime(2014, 12, 10)} })

define "Flatten.FlattenTime": Flatten({ {@T15:59:59.999}, {@T20:59:59.999} })

define "First.FirstEmpty": First({})

define "First.FirstNull1": First({ null, 1 })

define "First.First1Null": First({ 1, null })

define "First.First12": First({ 1, 2 })

define "First.FirstDateTime": First({ DateTime(2012, 5, 10), DateTime(2014, 12, 10) })

define "First.FirstTime": First({ @T15:59:59.999, @T20:59:59.999 })

define "In.InNullEmpty": null in {}

define "In.InNullAnd1Null": null in { 1, null }

define "In.In1Null": 1 in null

define "In.In1And12": 1 in { 1, 2 }

define "In.In3And12": 3 in { 1, 2 }

define "In.InDateTimeTrue": DateTime(2012, 5, 10) in { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10) }

define "In.InDateTimeFalse": DateTime(2012, 6, 10) in { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10) }

define "In.InTimeTrue": @T15:59:59.999 in { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 }

define "In.InTimeFalse": @T16:59:59.999 in { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 }

define "Includes.IncludesEmptyAndEmpty": {} includes {}

define "Includes.IncludesListNullAndListNull": {null} includes {null}

define "Includes.Includes123AndEmpty": {1, 2, 3} includes {}

define "Includes.Includes123And2": {1, 2, 3} includes {2}

define "Includes.Includes123And4": {1, 2, 3} includes {4}

define "Includes.IncludesDateTimeTrue": {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} includes {DateTime(2012, 5, 10)}

define "Includes.IncludesDateTimeFalse": {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} includes {DateTime(2012, 5, 11)}

define "Includes.IncludesTimeTrue": { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } includes @T15:59:59.999

define "Includes.IncludesTimeFalse": { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } includes @T16:59:59.999

define "Includes.IncludesNullLeft": null includes {2}

define "Includes.IncludesNullRight": {'s', 'a', 'm'} includes null

define "IncludedIn.IncludedInEmptyAndEmpty": {} included in {}

define "IncludedIn.IncludedInListNullAndListNull": { null } included in { null }

define "IncludedIn.IncludedInEmptyAnd123": {} included in { 1, 2, 3 }

define "IncludedIn.IncludedIn2And123": { 2 } included in { 1, 2, 3 }

define "IncludedIn.IncludedIn4And123": { 4 } included in { 1, 2, 3 }

define "IncludedIn.IncludedInDateTimeTrue": { DateTime(2012, 5, 10)} included in {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)}

define "IncludedIn.IncludedInDateTimeFalse": {DateTime(2012, 5, 11)} included in {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)}

define "IncludedIn.IncludedInTimeTrue": @T15:59:59.999 included in { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 }

define "IncludedIn.IncludedInTimeFalse": @T16:59:59.999 included in { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 }

define "IncludedIn.IncludedInNullLeft": null included in {2}

define "IncludedIn.IncludedInNullRight": {'s', 'a', 'm'} included in null

define "Indexer.IndexerNull1List": (null as List<System.Any>)[1]

define "Indexer.Indexer0Of12": { 1, 2 }[0]

define "Indexer.Indexer1Of12": { 1, 2 }[1]

define "Indexer.Indexer2Of12": { 1, 2 }[2]

define "Indexer.IndexerNeg1Of12": { 1, 2 }[-1]

define "Indexer.IndexerDateTime": { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10) }[1]

define "Indexer.IndexerTime": { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 }[1]

define "IndexOf.IndexOfEmptyNull": IndexOf({}, null)

define "IndexOf.IndexOfNullEmpty": IndexOf(null, {})

define "IndexOf.IndexOfNullIn1Null": IndexOf({ 1, null }, null)

define "IndexOf.IndexOf1In12": IndexOf({ 1, 2 }, 1)

define "IndexOf.IndexOf2In12": IndexOf({ 1, 2 }, 2)

define "IndexOf.IndexOf3In12": IndexOf({ 1, 2 }, 3)

define "IndexOf.IndexOfDateTime": IndexOf({ DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10) }, DateTime(2014, 12, 10))

define "IndexOf.IndexOfTime": IndexOf({ @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 }, @T15:59:59.999)

define "Intersect.IntersectEmptyListAndEmptyList": {} intersect {}

define "Intersect.Intersect1234And23": { 1, 2, 3, 4 } intersect { 2, 3 }

define "Intersect.Intersect23And1234": {2, 3} intersect { 1, 2, 3, 4 }

define "Intersect.IntersectDateTime": { DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10) } intersect { DateTime(2012, 5, 10), DateTime(2014, 12, 10), DateTime(2000, 5, 5) }

define "Intersect.IntersectTime": { @T02:29:15.156, @T15:59:59.999, @T20:59:59.999 } intersect { @T01:29:15.156, @T15:59:59.999, @T20:59:59.999 }

define "Last.LastEmpty": Last({})

define "Last.LastNull1": Last({null, 1})

define "Last.Last1Null": Last({1, null})

define "Last.Last12": Last({1, 2})

define "Last.LastDateTime": Last({DateTime(2012, 5, 10), DateTime(2014, 12, 10)})

define "Last.LastTime": Last({ @T15:59:59.999, @T20:59:59.999 })

define "Length.LengthEmptyList": Length({})

define "Length.LengthNull1": Length({null, 1})

define "Length.Length1Null": Length({1, null})

define "Length.Length12": Length({1, 2})

define "Length.LengthDateTime": Length({DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)})

define "Length.LengthTime": Length({ @T15:59:59.999, @T20:59:59.999, @T15:59:59.999, @T20:59:59.999, @T15:59:59.999, @T20:59:59.999 })

define "Length.LengthNullList": Length(null as List<Any>)

define "Equivalent.EquivalentEmptyAndEmpty": {} ~ {}

define "Equivalent.EquivalentABCAndABC": { 'a', 'b', 'c' } ~ { 'a', 'b', 'c' }

define "Equivalent.EquivalentABCAndAB": { 'a', 'b', 'c' } ~ { 'a', 'b' }

define "Equivalent.EquivalentABCAnd123": { 'a', 'b', 'c' } ~ { 1, 2, 3 }

define "Equivalent.Equivalent123AndABC": { 1, 2, 3 } ~ { 'a', 'b', 'c' }

define "Equivalent.Equivalent123AndString123": { 1, 2, 3 } ~ { '1', '2', '3' }

define "Equivalent.EquivalentDateTimeTrue": {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10), null} ~ {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10), null}

define "Equivalent.EquivalentDateTimeNull": {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} ~ {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10), null}

define "Equivalent.EquivalentDateTimeFalse": {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} ~ {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 1)}

define "Equivalent.EquivalentTimeTrue": { @T15:59:59.999, @T20:59:59.999 } ~ { @T15:59:59.999, @T20:59:59.999 }

define "Equivalent.EquivalentTimeNull": { @T15:59:59.999, @T20:59:59.999 } ~ { @T15:59:59.999, @T20:59:59.999, null }

define "Equivalent.EquivalentTimeFalse": { @T15:59:59.999, @T20:59:59.999 } ~ { @T15:59:59.999, @T20:59:59.995 }

define "NotEqual.NotEqualEmptyAndEmpty": {} != {}

define "NotEqual.NotEqualABCAndABC": { 'a', 'b', 'c' } != { 'a', 'b', 'c' }

define "NotEqual.NotEqualABCAndAB": { 'a', 'b', 'c' } != { 'a', 'b' }

define "NotEqual.NotEqualABCAnd123": { 'a', 'b', 'c' } != { 1, 2, 3 }

define "NotEqual.NotEqual123AndABC": { 1, 2, 3 } != { 'a', 'b', 'c' }

define "NotEqual.NotEqual123AndString123": { 1, 2, 3 } != { '1', '2', '3' }

define "NotEqual.NotEqualDateTimeTrue": {DateTime(2001, 9, 11, 0, 0, 0, 0), DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} != {DateTime(2001, 9, 11, 0, 0, 0, 0), DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 1, 0, 0, 0, 0)}

define "NotEqual.NotEqualDateTimeFalse": {DateTime(2001, 9, 11, 0, 0, 0, 0), DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)} != {DateTime(2001, 9, 11, 0, 0, 0, 0), DateTime(2012, 5, 10, 0, 0, 0, 0), DateTime(2014, 12, 10, 0, 0, 0, 0)}

define "NotEqual.NotEqualTimeTrue": { @T15:59:59.999, @T20:59:59.999 } = { @T15:59:59.999, @T20:59:59.999 }

define "NotEqual.NotEqualTimeFalse": { @T15:59:59.999, @T20:59:59.999 } = { @T15:59:59.999, @T20:59:49.999 }

define "ProperContains.ProperContainsNullRightFalse": {'s', 'u', 'n'} properly includes null

define "ProperContains.ProperContainsNullRightTrue": {'s', 'u', 'n', null} properly includes null

define "ProperContains.ProperContainsTimeTrue": { @T15:59:59, @T20:59:59.999, @T20:59:49.999 } properly includes @T15:59:59

define "ProperContains.ProperContainsTimeNull": { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } properly includes @T15:59:59

define "ProperIn.ProperInNullRightFalse": null properly included in {'s', 'u', 'n'}

define "ProperIn.ProperInNullRightTrue": null properly included in {'s', 'u', 'n', null}

define "ProperIn.ProperInTimeTrue": @T15:59:59 properly included in { @T15:59:59, @T20:59:59.999, @T20:59:49.999 }

define "ProperIn.ProperInTimeNull": @T15:59:59 properly included in { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 }

define "ProperlyIncludes.ProperIncludesEmptyAndEmpty": {} properly includes {}

define "ProperlyIncludes.ProperIncludesListNullAndListNull": {null} properly includes {null}

define "ProperlyIncludes.ProperIncludes123AndEmpty": {1, 2, 3} properly includes {}

define "ProperlyIncludes.ProperIncludes123And2": {1, 2, 3} properly includes {2}

define "ProperlyIncludes.ProperIncludes123And4": {1, 2, 3} properly includes {4}

define "ProperlyIncludes.ProperIncludesDateTimeTrue": {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} properly includes {DateTime(2012, 5, 10), DateTime(2014, 12, 10)}

define "ProperlyIncludes.ProperIncludesDateTimeFalse": {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} properly includes {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)}

define "ProperlyIncludes.ProperIncludesTimeTrue": { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } properly includes { @T15:59:59.999, @T20:59:59.999 }

define "ProperlyIncludes.ProperIncludesTimeFalse": { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } properly includes { @T15:59:59.999, @T20:59:59.999, @T14:59:22.999 }

define "ProperlyIncludes.ProperlyIncludesNullLeft": null properly includes {2}

define "ProperlyIncludedIn.ProperIncludedInEmptyAndEmpty": {} properly included in {}

define "ProperlyIncludedIn.ProperIncludedInListNullAndListNull": {null} properly included in {null}

define "ProperlyIncludedIn.ProperIncludedInEmptyAnd123": {} properly included in {1, 2, 3}

define "ProperlyIncludedIn.ProperIncludedIn2And123": {2} properly included in {1, 2, 3}

define "ProperlyIncludedIn.ProperIncludedIn4And123": {4} properly included in {1, 2, 3}

define "ProperlyIncludedIn.ProperIncludedInDateTimeTrue": {DateTime(2012, 5, 10), DateTime(2014, 12, 10)} properly included in {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)}

define "ProperlyIncludedIn.ProperIncludedInDateTimeFalse": {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)} properly included in {DateTime(2001, 9, 11), DateTime(2012, 5, 10), DateTime(2014, 12, 10)}

define "ProperlyIncludedIn.ProperIncludedInTimeTrue": { @T15:59:59.999, @T20:59:59.999 } properly included in { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 }

define "ProperlyIncludedIn.ProperIncludedInTimeFalse": { @T15:59:59.999, @T20:59:59.999, @T14:59:22.999 } properly included in { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 }

define "ProperlyIncludedIn.ProperlyIncludedInNulRight": {'s', 'u', 'n'} properly included in null

define "SingletonFrom.SingletonFromEmpty": singleton from {}

define "SingletonFrom.SingletonFromListNull": singleton from {null}

define "SingletonFrom.SingletonFrom1": singleton from { 1 }

define "SingletonFrom.SingletonFrom12": singleton from { 1, 2 }

define "SingletonFrom.SingletonFromDateTime": singleton from { DateTime(2012, 5, 10) }

define "SingletonFrom.SingletonFromTime": singleton from { @T15:59:59.999 }

define "Skip.SkipNull": Skip(null, 3)

define "Skip.SkipEven": Skip({1,2,3,4,5}, 2)

define "Skip.SkipOdd": Skip({1,2,3,4,5}, 3)

define "Skip.SkipNone": Skip({1,2,3,4,5}, 0)

define "Skip.SkipAll": Skip({1,2,3,4,5}, 5)

define "Tail.TailNull": Tail(null)

define "Tail.TailEven": Tail({1,2,3,4})

define "Tail.TailOdd": Tail({1,2,3,4,5})

define "Tail.TailEmpty": Tail({})

define "Tail.TailOneElement": Tail({1})

define "Take.TakeNull": Take(null, 3)

define "Take.TakeNullEmpty": Take({1,2,3}, null as Integer)

define "Take.TakeEmpty": Take({1,2,3}, 0)

define "Take.TakeEven": Take({1,2,3,4}, 2)

define "Take.TakeOdd": Take({1,2,3,4}, 3)

define "Take.TakeAll": Take({1,2,3,4}, 4)

define "Union.UnionEmptyAndEmpty": {} union {}

define "Union.UnionListNullAndListNull": { null } union { null }

define "Union.Union123AndEmpty": { 1, 2, 3 } union {}

define "Union.Union123And2": { 1, 2, 3 } union { 2 }

define "Union.Union123And4": { 1, 2, 3 } union { 4 }

define "Union.UnionDateTime": { DateTime(2001, 9, 11)} union {DateTime(2012, 5, 10), DateTime(2014, 12, 10) }

define "Union.UnionTime": { @T15:59:59.999, @T20:59:59.999, @T12:59:59.999 } union { @T10:59:59.999 }

