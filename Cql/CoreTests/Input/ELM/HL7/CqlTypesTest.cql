library CqlTypesTest version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

context Patient

define "AnyQuantity":
  5.0 'g' = 5.0 'g'

define "AnyDateTime":
  DateTime(2012, 4, 4)= @2012-04-04

define "AnyTime":
  @T09:00:00.000 = @T09:00:00.000

define "AnyInterval":
  Interval[2, 7]= Interval[2, 7]

define "AnyList":
  { 1, 2, 3 } = { 1, 2, 3 }

define "AnyTuple":
  Tuple {
    id: 5,
    name: 'Chris'
  } = Tuple {
    id: 5,
    name: 'Chris'
  }

define "AnyString":
  Tuple {
    id: 5,
    name: 'Chris'
  }.name = 'Chris'

define "DateTimeNull":
  DateTime(null)= null

define "DateTimeUpperBoundExcept":
  DateTime(10000, 12, 31, 23, 59, 59, 999)

define "DateTimeLowerBoundExcept":
  DateTime(0000, 1, 1, 0, 0, 0, 0)

define "DateTimeProper":
  DateTime(2016, 7, 7, 6, 25, 33, 910)= @2016-07-07T06:25:33.910

define "DateTimeIncomplete":
  DateTime(2015, 2, 10)= @2015-02-10

define "DateTimeUncertain":
  ( days between DateTime(2015, 2, 10)and DateTime(2015, 3)) = 30

define "DateTimeMin":
  DateTime(0001, 1, 1, 0, 0, 0, 0)= @0001-01-01T00:00:00.000

define "DateTimeMax":
  DateTime(9999, 12, 31, 23, 59, 59, 999)= @9999-12-31T23:59:59.999

// 'lbs' was a unit of measure that is not defined, compiling to ELM failed. using 'kg' instead
define "QuantityTest":
  150.2 'kg' = 150.2 'kg'

// 'eskimo kisses' is a unit of measure that is not in the UCUM standard, compiling to ELM failed
//define "QuantityTest2":
//  2.5589 'eskimo kisses' = 2.5589 'eskimo kisses'

define "QuantityFractionalTooBig":
  5.999999999 'g' = 5.999999999 'g'

define "StringTestEscapeQuotes":
  '\'I start with a single quote and end with a double quote\"' = '\u0027I start with a single quote and end with a double quote\u0022'

define "StringUnicodeTest":
  '\u0048\u0069' = 'Hi'

// define "TimeUpperBoundHours":
//   @T24:59:59.999

// define "TimeUpperBoundMinutes":
//   @T23:60:59.999

// define "TimeUpperBoundSeconds":
//   @T23:59:60.999

// define "TimeUpperBoundMillis":
//   @T23:59:59.10000

define "TimeProper":
  @T10:25:12.863 = @T10:25:12.863

define "TimeAllMax":
  @T23:59:59.999 = @T23:59:59.999

define "TimeAllMin":
  @T00:00:00.000 = @T00:00:00.000