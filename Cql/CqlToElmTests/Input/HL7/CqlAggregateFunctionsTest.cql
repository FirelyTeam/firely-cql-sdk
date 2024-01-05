library CqlAggregateFunctionsTest

context Unfiltered


define "AllTrueAllTrue Input":
	AllTrue({true,true})
define "AllTrueAllTrue Output":
	true

define "AllTrueTrueFirst Input":
	AllTrue({true,false})
define "AllTrueTrueFirst Output":
	false

define "AllTrueFalseFirst Input":
	AllTrue({false,true})
define "AllTrueFalseFirst Output":
	false

define "AllTrueAllTrueFalseTrue Input":
	AllTrue({true,false,true})
define "AllTrueAllTrueFalseTrue Output":
	false

define "AllTrueAllFalseTrueFalse Input":
	AllTrue({false,true,false})
define "AllTrueAllFalseTrueFalse Output":
	false

define "AllTrueNullFirst Input":
	AllTrue({null,true,true})
define "AllTrueNullFirst Output":
	true

define "AllTrueEmptyList Input":
	AllTrue({})
define "AllTrueEmptyList Output":
	true

define "AnyTrueAllTrue Input":
	AnyTrue({true,true})
define "AnyTrueAllTrue Output":
	true

define "AnyTrueAllFalse Input":
	AnyTrue({false,false})
define "AnyTrueAllFalse Output":
	false

define "AnyTrueAllTrueFalseTrue Input":
	AnyTrue({true,false,true})
define "AnyTrueAllTrueFalseTrue Output":
	true

define "AnyTrueAllFalseTrueFalse Input":
	AnyTrue({false,true,false})
define "AnyTrueAllFalseTrueFalse Output":
	true

define "AnyTrueTrueFirst Input":
	AnyTrue({true,false})
define "AnyTrueTrueFirst Output":
	true

define "AnyTrueFalseFirst Input":
	AnyTrue({false,true})
define "AnyTrueFalseFirst Output":
	true

define "AnyTrueNullFirstThenTrue Input":
	AnyTrue({null,true})
define "AnyTrueNullFirstThenTrue Output":
	true

define "AnyTrueNullFirstThenFalse Input":
	AnyTrue({null,false})
define "AnyTrueNullFirstThenFalse Output":
	false

define "AnyTrueEmptyList Input":
	AnyTrue({})
define "AnyTrueEmptyList Output":
	false

define "AvgTest1 Input":
	Avg({ 1.0, 2.0, 3.0, 6.0 })
define "AvgTest1 Output":
	3.0

define "CountTest1 Input":
	Count({ 15, 5, 99, null, 1 })
define "CountTest1 Output":
	4

define "CountTestDateTime Input":
	Count({ DateTime(2014), DateTime(2001), DateTime(2010) })
define "CountTestDateTime Output":
	3

define "CountTestTime Input":
	Count({ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 })
define "CountTestTime Output":
	3

define "CountTestNull Input":
	Count({})
define "CountTestNull Output":
	0

define "MaxTestInteger Input":
	Max({ 5, 12, 1, 15, 0, 4, 90, 44 })
define "MaxTestInteger Output":
	90

define "MaxTestString Input":
	Max({ 'hi', 'bye', 'zebra' })
define "MaxTestString Output":
	'zebra'

define "MaxTestDateTime Input":
	Max({ DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 10, 6) })
define "MaxTestDateTime Output":
	DateTime(2012, 10, 6)

define "MaxTestTime Input":
	Max({ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 })
define "MaxTestTime Output":
	@T20:59:59.999

define "MedianTestDecimal Input":
	Median({6.0, 5.0, 4.0, 3.0, 2.0, 1.0})
define "MedianTestDecimal Output":
	3.5

define "MinTestInteger Input":
	Min({5, 12, 1, 15, 0, 4, 90, 44})
define "MinTestInteger Output":
	0

define "MinTestString Input":
	Min({'hi', 'bye', 'zebra'})
define "MinTestString Output":
	'bye'

define "MinTestDateTime Input":
	Min({ DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 10, 6) })
define "MinTestDateTime Output":
	DateTime(2012, 9, 5)

define "MinTestTime Input":
	Min({ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 })
define "MinTestTime Output":
	@T05:59:59.999

define "ModeTestInteger Input":
	Mode({ 2, 1, 8, 2, 9, 1, 9, 9 })
define "ModeTestInteger Output":
	9

define "ModeTestDateTime Input":
	Mode({ DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 10, 6), DateTime(2012, 9, 5) })
define "ModeTestDateTime Output":
	DateTime(2012, 9, 5)

define "ModeTestTime Input":
	Mode({ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999, @T05:59:59.999 })
define "ModeTestTime Output":
	@T05:59:59.999

define "PopStdDevTest1 Input":
	PopulationStdDev({ 1.0, 2.0, 3.0, 4.0, 5.0 })
define "PopStdDevTest1 Output":
	1.41421356

define "PopVarianceTest1 Input":
	PopulationVariance({ 1.0, 2.0, 3.0, 4.0, 5.0 })
define "PopVarianceTest1 Output":
	2.0

define "StdDevTest1 Input":
	StdDev({ 1.0, 2.0, 3.0, 4.0, 5.0 })
define "StdDevTest1 Output":
	1.58113883

define "SumTest1 Input":
	Sum({ 6.0, 2.0, 3.0, 4.0, 5.0 })
define "SumTest1 Output":
	20.0

define "SumTestNull Input":
	Sum({ null, 1, null })
define "SumTestNull Output":
	1

define "VarianceTest1 Input":
	Variance({ 1.0, 2.0, 3.0, 4.0, 5.0 })
define "VarianceTest1 Output":
	2.5
