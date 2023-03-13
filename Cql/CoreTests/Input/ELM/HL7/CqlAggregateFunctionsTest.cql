library CqlAggregateFunctionsTest version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

context Patient

define "AllTrueAllTrue":
  AllTrue({ true, true })= true

define "AllTrueTrueFirst":
  AllTrue({ true, false })= false

define "AllTrueFalseFirst":
  AllTrue({ false, true })= false

define "AllTrueAllTrueFalseTrue":
  AllTrue({ true, false, true })= false

define "AllTrueAllFalseTrueFalse":
  AllTrue({ false, true, false })= false

define "AllTrueNullFirst":
  AllTrue({ null, true, true })= true

define "AllTrueEmptyList":
  AllTrue({ })= true

define "AnyTrueAllTrue":
  AnyTrue({ true, true })= true

define "AnyTrueAllFalse":
  AnyTrue({ false, false })= false

define "AnyTrueAllTrueFalseTrue":
  AnyTrue({ true, false, true })= true

define "AnyTrueAllFalseTrueFalse":
  AnyTrue({ false, true, false })= true

define "AnyTrueTrueFirst":
  AnyTrue({ true, false })= true

define "AnyTrueFalseFirst":
  AnyTrue({ false, true })= true

define "AnyTrueNullFirstThenTrue":
  AnyTrue({ null, true })= true

define "AnyTrueNullFirstThenFalse":
  AnyTrue({ null, false })= false

define "AnyTrueEmptyList":
  AnyTrue({ })= false

define "AvgTest1":
  Avg({ 1.0, 2.0, 3.0, 6.0 })= 3.0

define "CountTest1":
  Count({ 15, 5, 99, null, 1 })= 4

define "CountTestDateTime":
  Count({ DateTime(2014), DateTime(2001), DateTime(2010)})= 3

define "CountTestTime":
  Count({ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 })= 3

define "CountTestNull":
  Count({ })= 0

define "MaxTestInteger":
  Max({ 5, 12, 1, 15, 0, 4, 90, 44 })= 90

define "MaxTestString":
  Max({ 'hi', 'bye', 'zebra' })= 'zebra'

define "MaxTestDateTime":
  Max({ DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 10, 6)})= DateTime(2012, 10, 6)

define "MaxTestTime":
  Max({ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 })= @T20:59:59.999

define "MedianTestDecimal":
  Median({ 6.0, 5.0, 4.0, 3.0, 2.0, 1.0 })= 3.5

define "MinTestInteger":
  Min({ 5, 12, 1, 15, 0, 4, 90, 44 })= 0

define "MinTestString":
  Min({ 'hi', 'bye', 'zebra' })= 'bye'

define "MinTestDateTime":
  Min({ DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 10, 6)})= DateTime(2012, 9, 5)

define "MinTestTime":
  Min({ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999 })= @T05:59:59.999

define "ModeTestInteger":
  Mode({ 2, 1, 8, 2, 9, 1, 9, 9 })= 9

define "ModeTestDateTime":
  Mode({ DateTime(2012, 10, 5), DateTime(2012, 9, 5), DateTime(2012, 10, 6), DateTime(2012, 9, 5)})= DateTime(2012, 9, 5)

define "ModeTestTime":
  Mode({ @T15:59:59.999, @T05:59:59.999, @T20:59:59.999, @T05:59:59.999 })= @T05:59:59.999

define "PopStdDevTest1":
  PopulationStdDev({ 1.0, 2.0, 3.0, 4.0, 5.0 })= 1.41421356

define "PopVarianceTest1":
  PopulationVariance({ 1.0, 2.0, 3.0, 4.0, 5.0 })= 2.0

define "StdDevTest1":
  StdDev({ 1.0, 2.0, 3.0, 4.0, 5.0 })= 1.58113883

define "SumTest1":
  Sum({ 6.0, 2.0, 3.0, 4.0, 5.0 })= 20.0

define "SumTestNull":
  Sum({ null, 1, null })= 1

define "VarianceTest1":
  Variance({ 1.0, 2.0, 3.0, 4.0, 5.0 })= 2.5