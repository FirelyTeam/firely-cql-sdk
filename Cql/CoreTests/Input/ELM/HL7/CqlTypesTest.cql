library CqlTypesTest

context Unfiltered


define "AnyQuantity Input":
	5.0 'g'
define "AnyQuantity Output":
	5.0'g'

define "AnyDateTime Input":
	DateTime(2012, 4, 4)
define "AnyDateTime Output":
	@2012-04-04T

define "AnyTime Input":
	@T09:00:00.000
define "AnyTime Output":
	@T09:00:00.000

define "AnyInterval Input":
	Interval[2, 7]
define "AnyInterval Output":
	Interval[2, 7]

define "AnyList Input":
	{1, 2, 3}
define "AnyList Output":
	{1, 2, 3}

define "AnyTuple Input":
	Tuple { id: 5, name: 'Chris'}
define "AnyTuple Output":
	Tuple { id: 5, name: 'Chris'}

define "AnyString Input":
	Tuple { id: 5, name: 'Chris'}.name
define "AnyString Output":
	'Chris'

define "DateTimeNull Input":
	DateTime(null)
define "DateTimeNull Output":
	null

define "DateTimeUpperBoundExcept":
	DateTime(10000, 12, 31, 23, 59, 59, 999)

define "DateTimeLowerBoundExcept":
	DateTime(0000, 1, 1, 0, 0, 0, 0)

define "DateTimeProper Input":
	DateTime(2016, 7, 7, 6, 25, 33, 910)
define "DateTimeProper Output":
	@2016-07-07T06:25:33.910

define "DateTimeIncomplete Input":
	DateTime(2015, 2, 10)
define "DateTimeIncomplete Output":
	@2015-02-10T

define "DateTimeUncertain Input":
	days between DateTime(2015, 2, 10) and DateTime(2015, 3)
define "DateTimeUncertain Output":
	Interval [ 18, 49 ]

define "DateTimeMin Input":
	DateTime(0001, 1, 1, 0, 0, 0, 0)
define "DateTimeMin Output":
	@0001-01-01T00:00:00.000

define "DateTimeMax Input":
	DateTime(9999, 12, 31, 23, 59, 59, 999)
define "DateTimeMax Output":
	@9999-12-31T23:59:59.999

define "QuantityTest Input":
	150.2 '[lb_av]'
define "QuantityTest Output":
	150.2 '[lb_av]'

define "QuantityTest2 Input":
	2.5589 '{eskimo kisses}'
define "QuantityTest2 Output":
	2.5589 '{eskimo kisses}'

define "QuantityFractionalTooBig Input":
	5.999999999 'g'
define "QuantityFractionalTooBig Output":
	5.999999999 'g'

define "StringTestEscapeQuotes Input":
	'\'I start with a single quote and end with a double quote\"'
define "StringTestEscapeQuotes Output":
	'\u0027I start with a single quote and end with a double quote\u0022'

define "StringUnicodeTest Input":
	'\u0048\u0069'
define "StringUnicodeTest Output":
	'Hi'

define "TimeProper Input":
	@T10:25:12.863
define "TimeProper Output":
	@T10:25:12.863

define "TimeAllMax Input":
	@T23:59:59.999
define "TimeAllMax Output":
	@T23:59:59.999

define "TimeAllMin Input":
	@T00:00:00.000
define "TimeAllMin Output":
	@T00:00:00.000
