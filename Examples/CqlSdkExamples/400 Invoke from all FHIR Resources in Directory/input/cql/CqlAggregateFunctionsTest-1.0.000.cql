library CqlAggregateFunctionsTest version '1.0.000'

define "AllTrue.AllTrueAllTrue": AllTrue({true,true})

define "AllTrue.AllTrueTrueFirst": AllTrue({true,false})

define "AllTrue.AllTrueFalseFirst": AllTrue({false,true})

define "AllTrue.AllTrueAllTrueFalseTrue": AllTrue({true,false,true})

define "AllTrue.AllTrueAllFalseTrueFalse": AllTrue({false,true,false})

define "AllTrue.AllTrueNullFirst": AllTrue({null,true,true})

define "AllTrue.AllTrueEmptyList": AllTrue({})

define "AnyTrue.AnyTrueAllTrue": AnyTrue({true,true})

define "AnyTrue.AnyTrueAllFalse": AnyTrue({false,false})

define "AnyTrue.AnyTrueAllTrueFalseTrue": AnyTrue({true,false,true})

define "AnyTrue.AnyTrueAllFalseTrueFalse": AnyTrue({false,true,false})

define "AnyTrue.AnyTrueTrueFirst": AnyTrue({true,false})

define "AnyTrue.AnyTrueFalseFirst": AnyTrue({false,true})

define "AnyTrue.AnyTrueNullFirstThenTrue": AnyTrue({null,true})

define "AnyTrue.AnyTrueNullFirstThenFalse": AnyTrue({null,false})

define "AnyTrue.AnyTrueEmptyList": AnyTrue({})

define "Avg.AvgTest1": Avg({ 1.0, 2.0, 3.0, 6.0 })

define "Count.CountTest1": Count({ 15, 5, 99, null, 1 })

define "Count.CountTestDateTime": Count({ DateTime(2014), DateTime(2001), DateTime(2010) })

define "Count.CountTestTime": Count({ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 })

define "Count.CountTestNull": Count({})

define "Max.MaxTestInteger": Max({ 5, 12, 1, 15, 0, 4, 90, 44 })

define "Max.MaxTestString": Max({ 'hi', 'bye', 'zebra' })

define "Max.MaxTestDateTime": Max({ DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 10, 6) })

define "Max.MaxTestTime": Max({ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 })

define "Median.MedianTestDecimal": Median({6.0, 5.0, 4.0, 3.0, 2.0, 1.0})

define "Min.MinTestInteger": Min({5, 12, 1, 15, 0, 4, 90, 44})

define "Min.MinTestString": Min({'hi', 'bye', 'zebra'})

define "Min.MinTestDateTime": Min({ DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 10, 6) })

define "Min.MinTestTime": Min({ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 })

define "Mode.ModeTestInteger": Mode({ 2, 1, 8, 2, 9, 1, 9, 9 })

define "Mode.ModeTestDateTime": Mode({ DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 10, 6), DateTime(2012, 9, 5) })

define "Mode.ModeTestTime": Mode({ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999, @T05:59:59.999 })

define "PopulationStdDev.PopStdDevTest1": PopulationStdDev({ 1.0, 2.0, 3.0, 4.0, 5.0 })

define "PopulationVariance.PopVarianceTest1": PopulationVariance({ 1.0, 2.0, 3.0, 4.0, 5.0 })

define "StdDev.StdDevTest1": StdDev({ 1.0, 2.0, 3.0, 4.0, 5.0 })

define "Sum.SumTest1": Sum({ 6.0, 2.0, 3.0, 4.0, 5.0 })

define "Sum.SumTestNull": Sum({ null, 1, null })

define "Variance.VarianceTest1": Variance({ 1.0, 2.0, 3.0, 4.0, 5.0 })

