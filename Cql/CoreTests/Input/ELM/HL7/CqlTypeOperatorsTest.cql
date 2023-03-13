library CqlTypeOperatorsTest version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

context Patient

define "AsQuantity":
  ( 45.5 'g' as System.Quantity ) = 45.5 'g'

define "CastAsQuantity":
  ( cast 45.5 'g' as System.Quantity ) = 45.5 'g'

define "AsDateTime":
  DateTime(2014, 01, 01)as DateTime = @2014-01-01

define "IntegerToDecimal":
  convert 5 to Decimal = 5.0

define "IntegerToString":
  convert 5 to String = '5'

define "StringToIntegerError":
  convert 'foo' to Integer

define "StringToDateTime":
  convert '2014-01-01' to DateTime = @2014-01-01

define "StringToTime":
  convert 'T14:30:00.0' to Time = @T14:30:00.000

define "StringToDateTimeMalformed":
  convert '2014/01/01' to DateTime

define "IntegerIsInteger":
  5 is Integer = true

define "StringIsInteger":
  '5' is Integer = false

define "StringNoToBoolean":
  ToBoolean('NO')= false

define "CodeToConcept1":
  ToConcept(Code { code: '8480-6' })= Concept { codes: { Code { code: '8480-6' } } }

define "ToDateTime1":
  ToDateTime('2014-01-01')= @2014-01-01

define "ToDateTime2":
  ToDateTime('2014-01-01T12:05')= @2014-01-01T12:05

define "ToDateTime3":
  ToDateTime('2014-01-01T12:05:05.955')= @2014-01-01T12:05:05.955

define "ToDateTime4":
  ToDateTime('2014-01-01T12:05:05.955+01:30')= @2014-01-01T12:05:05.955

define "ToDateTime5":
  ToDateTime('2014-01-01T12:05:05.955-01:15')= @2014-01-01T12:05:05.955

define "ToDateTime6":
  ToDateTime('2014-01-01T12:05:05.955Z')= @2014-01-01T12:05:05.955

define "ToDateTimeMalformed":
  ToDateTime('2014/01/01T12:05:05.955Z')

define "String25D5ToDecimal":
  ToDecimal('+25.5')= 25.5

define "StringNeg25ToInteger":
  ToInteger('-25')= - 25

define "String5D5CMToQuantity":
  ToQuantity('5.5 cm')= 5.5 'cm'

define "IntegerNeg5ToString":
  ToString(- 5)= '-5'

define "Decimal18D55ToString":
  ToString(18.55)= '18.55'

define "Quantity5D5CMToString":
  ToString(5.5 'cm')= '5.5cm'

define "BooleanTrueToString":
  ToString(true)= 'true'

define "ToTime1":
  ToTime('T14:30:00.0')= @T14:30:00.000

define "ToTime2":
  ToTime('T14:30:00.0+05:30')= @T14:30:00.000

define "ToTime3":
  ToTime('T14:30:00.0-05:45')= @T14:30:00.000

define "ToTime4":
  ToTime('T14:30:00.0Z')= @T14:30:00.000

define "ToTimeMalformed":
  ToTime('T14-30-00.0')