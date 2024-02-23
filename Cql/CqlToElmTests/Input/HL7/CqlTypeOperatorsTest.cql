library CqlTypeOperatorsTest

context Unfiltered


define "AsQuantity Input":
	45.5 'g' as Quantity
define "AsQuantity Output":
	45.5 'g'

define "CastAsQuantity Input":
	cast 45.5 'g' as Quantity
define "CastAsQuantity Output":
	45.5 'g'

define "AsDateTime Input":
	DateTime(2014, 01, 01) as DateTime
define "AsDateTime Output":
	@2014-01-01T

define "IntegerToDecimal Input":
	convert 5 to Decimal
define "IntegerToDecimal Output":
	5.0

define "IntegerToString Input":
	convert 5 to String
define "IntegerToString Output":
	'5'


define "StringToDateTime Input":
	convert '2014-01-01' to DateTime
define "StringToDateTime Output":
	@2014-01-01T

define "StringToTime Input":
	convert 'T14:30:00.0' to Time
define "StringToTime Output":
	@T14:30:00.000

define "StringToDateTimeMalformed":
	convert '2014/01/01' to DateTime

define "IntegerIsInteger Input":
	5 is Integer
define "IntegerIsInteger Output":
	true

define "StringIsInteger Input":
	'5' is Integer
define "StringIsInteger Output":
	false

define "StringNoToBoolean Input":
	ToBoolean('NO')
define "StringNoToBoolean Output":
	false

define "CodeToConcept1 Input":
	ToConcept(Code { code: '8480-6' })
define "CodeToConcept1 Output":
	
				Concept {
					codes: Code { code: '8480-6' }
				}
			

define "ToDateTime1 Input":
	ToDateTime('2014-01-01')
define "ToDateTime1 Output":
	@2014-01-01T

define "ToDateTime2 Input":
	ToDateTime('2014-01-01T12:05')
define "ToDateTime2 Output":
	@2014-01-01T12:05

define "ToDateTime3 Input":
	ToDateTime('2014-01-01T12:05:05.955')
define "ToDateTime3 Output":
	@2014-01-01T12:05:05.955

define "ToDateTime4 Input":
	ToDateTime('2014-01-01T12:05:05.955+01:30')
define "ToDateTime4 Output":
	@2014-01-01T12:05:05.955+01:30

define "ToDateTime5 Input":
	ToDateTime('2014-01-01T12:05:05.955-01:15')
define "ToDateTime5 Output":
	@2014-01-01T12:05:05.955-01:15

define "ToDateTime6 Input":
	ToDateTime('2014-01-01T12:05:05.955Z')
define "ToDateTime6 Output":
	@2014-01-01T12:05:05.955+00:00

define "ToDateTimeMalformed":
	ToDateTime('2014/01/01T12:05:05.955Z')

define "String25D5ToDecimal Input":
	ToDecimal('+25.5')
define "String25D5ToDecimal Output":
	25.5

define "StringNeg25ToInteger Input":
	ToInteger('-25')
define "StringNeg25ToInteger Output":
	-25

define "String5D5CMToQuantity Input":
	ToQuantity('5.5 \'cm\'')
define "String5D5CMToQuantity Output":
	5.5'cm'

define "IntegerNeg5ToString Input":
	ToString(-5)
define "IntegerNeg5ToString Output":
	'-5'

define "Decimal18D55ToString Input":
	ToString(18.55)
define "Decimal18D55ToString Output":
	'18.55'

define "Quantity5D5CMToString Input":
	ToString(5.5 'cm')
define "Quantity5D5CMToString Output":
	'5.5 \'cm\''

define "BooleanTrueToString Input":
	ToString(true)
define "BooleanTrueToString Output":
	'true'

define "ToTime1 Input":
	ToTime('T14:30:00.0')
define "ToTime1 Output":
	@T14:30:00.000

define "ToTime2 Input":
	ToTime('T14:30:00.0+05:30')
define "ToTime2 Output":
	@T14:30:00.000

define "ToTime3 Input":
	ToTime('T14:30:00.0-05:45')
define "ToTime3 Output":
	@T14:30:00.000

define "ToTime4 Input":
	ToTime('T14:30:00.0Z')
define "ToTime4 Output":
	@T14:30:00.000

define "ToTimeMalformed":
	ToTime('T14-30-00.0')
