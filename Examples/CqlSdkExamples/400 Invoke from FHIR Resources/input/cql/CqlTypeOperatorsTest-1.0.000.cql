library CqlTypeOperatorsTest version '1.0.000'

define "As.AsQuantity": 45.5 'g' as Quantity

define "As.CastAsQuantity": cast 45.5 'g' as Quantity

define "As.AsDateTime": DateTime(2014, 01, 01) as DateTime

define "Convert.IntegerToDecimal": convert 5 to Decimal

define "Convert.IntegerToString": convert 5 to String

define "Convert.StringToIntegerError": convert 'foo' to Integer

define "Convert.StringToDateTime": convert '2014-01-01' to DateTime

define "Convert.StringToTime": convert 'T14:30:00.0' to Time

define "Convert.StringToDateTimeMalformed": convert '2014/01/01' to DateTime

define "Is.IntegerIsInteger": 5 is Integer

define "Is.StringIsInteger": '5' is Integer

define "ToBoolean.StringNoToBoolean": ToBoolean('NO')

define "ToConcept.CodeToConcept1": ToConcept(Code { code: '8480-6' })

define "ToDateTime.ToDateTime1": ToDateTime('2014-01-01')

define "ToDateTime.ToDateTime2": ToDateTime('2014-01-01T12:05')

define "ToDateTime.ToDateTime3": ToDateTime('2014-01-01T12:05:05.955')

define "ToDateTime.ToDateTime4": ToDateTime('2014-01-01T12:05:05.955+01:30')

define "ToDateTime.ToDateTime5": ToDateTime('2014-01-01T12:05:05.955-01:15')

define "ToDateTime.ToDateTime6": ToDateTime('2014-01-01T12:05:05.955Z')

define "ToDateTime.ToDateTimeMalformed": ToDateTime('2014/01/01T12:05:05.955Z')

define "ToDateTime.ToDateTimeDate": ToDateTime(@2014-01-01)

define "ToDateTime.ToDateTimeTimeUnspecified": hour from ToDateTime(@2014-01-01) is null

define "ToDecimal.String25D5ToDecimal": ToDecimal('+25.5')

define "ToInteger.StringNeg25ToInteger": ToInteger('-25')

define "ToQuantity.String5D5CMToQuantity": ToQuantity('5.5 \'cm\'')

define "ToString.IntegerNeg5ToString": ToString(-5)

define "ToString.Decimal18D55ToString": ToString(18.55)

define "ToString.Quantity5D5CMToString": ToString(5.5 'cm')

define "ToString.BooleanTrueToString": ToString(true)

define "ToTime.ToTime1": ToTime('T14:30:00.0')

define "ToTime.ToTime2": ToTime('T14:30:00.0+05:30')

define "ToTime.ToTime3": ToTime('T14:30:00.0-05:45')

define "ToTime.ToTime4": ToTime('T14:30:00.0Z')

define "ToTime.ToTimeMalformed": ToTime('T14-30-00.0')

