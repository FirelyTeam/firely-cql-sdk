library CqlComparisonOperatorsTest

context Unfiltered


define "BetweenIntTrue Input":
	4 between 2 and 6
define "BetweenIntTrue Output":
	true

define "SimpleEqTrueTrue Input":
	true = true
define "SimpleEqTrueTrue Output":
	true

define "SimpleEqTrueFalse Input":
	true = false
define "SimpleEqTrueFalse Output":
	false

define "SimpleEqFalseFalse Input":
	false = false
define "SimpleEqFalseFalse Output":
	true

define "SimpleEqFalseTrue Input":
	false = true
define "SimpleEqFalseTrue Output":
	false

define "SimpleEqNullNull Input":
	null as String = null
define "SimpleEqNullNull Output":
	null

define "SimpleEqTrueNull Input":
	true = null
define "SimpleEqTrueNull Output":
	null

define "SimpleEqNullTrue Input":
	null = true
define "SimpleEqNullTrue Output":
	null

define "SimpleEqInt1Int1 Input":
	1 = 1
define "SimpleEqInt1Int1 Output":
	true

define "SimpleEqInt1Int2 Input":
	1 = 2
define "SimpleEqInt1Int2 Output":
	false

define "SimpleEqStringAStringA Input":
	'a' = 'a'
define "SimpleEqStringAStringA Output":
	true

define "SimpleEqStringAStringB Input":
	'a' = 'b'
define "SimpleEqStringAStringB Output":
	false

define "SimpleEqFloat1Float1 Input":
	1.0 = 1.0
define "SimpleEqFloat1Float1 Output":
	true

define "SimpleEqFloat1Float2 Input":
	1.0 = 2.0
define "SimpleEqFloat1Float2 Output":
	false

define "SimpleEqFloat1Int1 Input":
	1.0 = 1
define "SimpleEqFloat1Int1 Output":
	true

define "SimpleEqFloat1Int2 Input":
	1.0 = 2
define "SimpleEqFloat1Int2 Output":
	false

define "QuantityEqCM1CM1 Input":
	1'cm' = 1'cm'
define "QuantityEqCM1CM1 Output":
	true

define "QuantityEqCM1M01 Input":
	1'cm' = 0.01'm'
define "QuantityEqCM1M01 Output":
	true

define "QuantityEqDiffPrecision Input":
	2.0'cm' = 2.00'cm'
define "QuantityEqDiffPrecision Output":
	true

define "TupleEqJohnJohn Input":
	Tuple { Id : 1, Name : 'John' } = Tuple { Id : 1, Name : 'John' }
define "TupleEqJohnJohn Output":
	true

define "TupleEqJohnJane Input":
	Tuple { Id : 1, Name : 'John' } = Tuple { Id : 2, Name : 'Jane' }
define "TupleEqJohnJane Output":
	false

define "TupleEqJohn1John2 Input":
	Tuple { Id : 1, Name : 'John' } = Tuple { Id : 2, Name : 'John' }
define "TupleEqJohn1John2 Output":
	false

define "TupleEqDateTimeTrue Input":
	Tuple { dateId: 1, Date: DateTime(2012, 10, 5, 0, 0, 0, 0) } = Tuple { dateId: 1, Date: DateTime(2012, 10, 5, 0, 0, 0, 0) }
define "TupleEqDateTimeTrue Output":
	true

define "TupleEqDateTimeFalse Input":
	Tuple { dateId: 1, Date: DateTime(2012, 10, 5, 0, 0, 0, 0) } = Tuple { dateId: 1, Date: DateTime(2012, 10, 5, 5, 0, 0, 0) }
define "TupleEqDateTimeFalse Output":
	false

define "TupleEqTimeTrue Input":
	Tuple { timeId: 55, TheTime: @T05:15:15.541 } = Tuple { timeId: 55, TheTime: @T05:15:15.541 }
define "TupleEqTimeTrue Output":
	true

define "TupleEqTimeFalse Input":
	Tuple { timeId: 55, TheTime: @T05:15:15.541 } = Tuple { timeId: 55, TheTime: @T05:15:15.540 }
define "TupleEqTimeFalse Output":
	false

define "DateTimeEqTodayToday Input":
	Today() = Today()
define "DateTimeEqTodayToday Output":
	true

define "DateTimeEqTodayYesterday Input":
	Today() = Today() - 1 days
define "DateTimeEqTodayYesterday Output":
	false

define "DateTimeEqJanJan Input":
	DateTime(2014, 1, 5, 5, 0, 0, 0, 0) = DateTime(2014, 1, 5, 5, 0, 0, 0, 0)
define "DateTimeEqJanJan Output":
	true

define "DateTimeEqJanJuly Input":
	DateTime(2014, 1, 5, 5, 0, 0, 0, 0) = DateTime(2014, 7, 5, 5, 0, 0, 0, 0)
define "DateTimeEqJanJuly Output":
	false

define "DateTimeEqNull Input":
	DateTime(null) = DateTime(null)
define "DateTimeEqNull Output":
	null

define "DateTimeUTC Input":
	@2014-01-25T14:30:14.559+01:00 = @2014-01-25T14:30:14.559+01:00
define "DateTimeUTC Output":
	true

define "TimeEq10A10A Input":
	@T10:00:00.000 = @T10:00:00.000
define "TimeEq10A10A Output":
	true

define "TimeEq10A10P Input":
	@T10:00:00.000 = @T22:00:00.000
define "TimeEq10A10P Output":
	false

define "GreaterZZ Input":
	0 > 0
define "GreaterZZ Output":
	false

define "GreaterZ1 Input":
	0 > 1
define "GreaterZ1 Output":
	false

define "GreaterZNeg1 Input":
	0 > -1
define "GreaterZNeg1 Output":
	true

define "GreaterDecZZ Input":
	0.0 > 0.0
define "GreaterDecZZ Output":
	false

define "GreaterDecZ1 Input":
	0.0 > 1.0
define "GreaterDecZ1 Output":
	false

define "GreaterDecZNeg1 Input":
	0.0 > -1.0
define "GreaterDecZNeg1 Output":
	true

define "GreaterCM0CM0 Input":
	0'cm' > 0'cm'
define "GreaterCM0CM0 Output":
	false

define "GreaterCM0CM1 Input":
	0'cm' > 1'cm'
define "GreaterCM0CM1 Output":
	false

define "GreaterCM0NegCM1 Input":
	0'cm' > -1'cm'
define "GreaterCM0NegCM1 Output":
	true

define "GreaterM1CM1 Input":
	1'm' > 1'cm'
define "GreaterM1CM1 Output":
	true

define "GreaterM1CM10 Input":
	1'm' > 10'cm'
define "GreaterM1CM10 Output":
	true

define "GreaterAA Input":
	'a' > 'a'
define "GreaterAA Output":
	false

define "GreaterAB Input":
	'a' > 'b'
define "GreaterAB Output":
	false

define "GreaterBA Input":
	'b' > 'a'
define "GreaterBA Output":
	true

define "GreaterAThanAA Input":
	'a' > 'aa'
define "GreaterAThanAA Output":
	false

define "GreaterAAThanA Input":
	'aa' > 'a'
define "GreaterAAThanA Output":
	true

define "GreaterJackJill Input":
	'Jack' > 'Jill'
define "GreaterJackJill Output":
	false

define "DateTimeGreaterTrue Input":
	DateTime(2012, 2, 12) > DateTime(2012, 2, 10)
define "DateTimeGreaterTrue Output":
	true

define "DateTimeGreaterFalse Input":
	DateTime(2012, 2, 12) > DateTime(2012, 2, 13)
define "DateTimeGreaterFalse Output":
	false

define "TimeGreaterTrue Input":
	@T10:00:00.001 > @T10:00:00.000
define "TimeGreaterTrue Output":
	true

define "TimeGreaterFalse Input":
	@T10:00:00.000 > @T10:00:00.001
define "TimeGreaterFalse Output":
	false

define "UncertaintyGreaterNull Input":
	DateTime(2014) > DateTime(2014, 2, 15)
define "UncertaintyGreaterNull Output":
	null

define "UncertaintyGreaterTrue Input":
	DateTime(2015) > DateTime(2014, 2, 15)
define "UncertaintyGreaterTrue Output":
	true

define "UncertaintyGreaterFalse Input":
	DateTime(2013) > DateTime(2014, 2, 15)
define "UncertaintyGreaterFalse Output":
	false

define "GreaterOrEqualZZ Input":
	0 >= 0
define "GreaterOrEqualZZ Output":
	true

define "GreaterOrEqualZ1 Input":
	0 >= 1
define "GreaterOrEqualZ1 Output":
	false

define "GreaterOrEqualZNeg1 Input":
	0 >= -1
define "GreaterOrEqualZNeg1 Output":
	true

define "GreaterOrEqualDecZZ Input":
	0.0 >= 0.0
define "GreaterOrEqualDecZZ Output":
	true

define "GreaterOrEqualDecZ1 Input":
	0.0 >= 1.0
define "GreaterOrEqualDecZ1 Output":
	false

define "GreaterOrEqualDecZNeg1 Input":
	0.0 >= -1.0
define "GreaterOrEqualDecZNeg1 Output":
	true

define "GreaterOrEqualCM0CM0 Input":
	0'cm' >= 0'cm'
define "GreaterOrEqualCM0CM0 Output":
	true

define "GreaterOrEqualCM0CM1 Input":
	0'cm' >= 1'cm'
define "GreaterOrEqualCM0CM1 Output":
	false

define "GreaterOrEqualCM0NegCM1 Input":
	0'cm' >= -1'cm'
define "GreaterOrEqualCM0NegCM1 Output":
	true

define "GreaterOrEqualM1CM1 Input":
	1'm' >= 1'cm'
define "GreaterOrEqualM1CM1 Output":
	true

define "GreaterOrEqualM1CM10 Input":
	1'm' >= 10'cm'
define "GreaterOrEqualM1CM10 Output":
	true

define "GreaterOrEqualAA Input":
	'a' >= 'a'
define "GreaterOrEqualAA Output":
	true

define "GreaterOrEqualAB Input":
	'a' >= 'b'
define "GreaterOrEqualAB Output":
	false

define "GreaterOrEqualBA Input":
	'b' >= 'a'
define "GreaterOrEqualBA Output":
	true

define "GreaterOrEqualAThanAA Input":
	'a' >= 'aa'
define "GreaterOrEqualAThanAA Output":
	false

define "GreaterOrEqualAAThanA Input":
	'aa' >= 'a'
define "GreaterOrEqualAAThanA Output":
	true

define "GreaterOrEqualJackJill Input":
	'Jack' >= 'Jill'
define "GreaterOrEqualJackJill Output":
	false

define "DateTimeGreaterEqTrue Input":
	DateTime(2012, 2, 12, 0, 0, 0, 0) >= DateTime(2012, 2, 10, 0, 0, 0, 0)
define "DateTimeGreaterEqTrue Output":
	true

define "DateTimeGreaterEqTrue2 Input":
	DateTime(2012, 2, 12, 0, 0, 0, 0) >= DateTime(2012, 2, 12, 0, 0, 0, 0)
define "DateTimeGreaterEqTrue2 Output":
	true

define "DateTimeGreaterEqFalse Input":
	DateTime(2012, 2, 12, 0, 0, 0, 0) >= DateTime(2012, 2, 13, 0, 0, 0, 0)
define "DateTimeGreaterEqFalse Output":
	false

define "TimeGreaterEqTrue Input":
	@T10:00:00.001 >= @T10:00:00.000
define "TimeGreaterEqTrue Output":
	true

define "TimeGreaterEqTrue2 Input":
	@T10:00:00.000 >= @T10:00:00.000
define "TimeGreaterEqTrue2 Output":
	true

define "TimeGreaterEqFalse Input":
	@T10:00:00.000 >= @T10:00:00.001
define "TimeGreaterEqFalse Output":
	false

define "UncertaintyGreaterEqualNull Input":
	DateTime(2014) >= DateTime(2014, 2, 15)
define "UncertaintyGreaterEqualNull Output":
	null

define "UncertaintyGreaterEqualTrue Input":
	DateTime(2015) >= DateTime(2014, 2, 15)
define "UncertaintyGreaterEqualTrue Output":
	true

define "UncertaintyGreaterEqualFalse Input":
	DateTime(2013) >= DateTime(2014, 2, 15)
define "UncertaintyGreaterEqualFalse Output":
	false

define "LessZZ Input":
	0 < 0
define "LessZZ Output":
	false

define "LessZ1 Input":
	0 < 1
define "LessZ1 Output":
	true

define "LessZNeg1 Input":
	0 < -1
define "LessZNeg1 Output":
	false

define "LessDecZZ Input":
	0.0 < 0.0
define "LessDecZZ Output":
	false

define "LessDecZ1 Input":
	0.0 < 1.0
define "LessDecZ1 Output":
	true

define "LessDecZNeg1 Input":
	0.0 < -1.0
define "LessDecZNeg1 Output":
	false

define "LessCM0CM0 Input":
	0'cm' < 0'cm'
define "LessCM0CM0 Output":
	false

define "LessCM0CM1 Input":
	0'cm' < 1'cm'
define "LessCM0CM1 Output":
	true

define "LessCM0NegCM1 Input":
	0'cm' < -1'cm'
define "LessCM0NegCM1 Output":
	false

define "LessM1CM1 Input":
	1'm' < 1'cm'
define "LessM1CM1 Output":
	false

define "LessM1CM10 Input":
	1'm' < 10'cm'
define "LessM1CM10 Output":
	false

define "LessAA Input":
	'a' < 'a'
define "LessAA Output":
	false

define "LessAB Input":
	'a' < 'b'
define "LessAB Output":
	true

define "LessBA Input":
	'b' < 'a'
define "LessBA Output":
	false

define "LessAThanAA Input":
	'a' < 'aa'
define "LessAThanAA Output":
	true

define "LessAAThanA Input":
	'aa' < 'a'
define "LessAAThanA Output":
	false

define "LessJackJill Input":
	'Jack' < 'Jill'
define "LessJackJill Output":
	true

define "DateTimeLessTrue Input":
	DateTime(2012, 2, 9) < DateTime(2012, 2, 10)
define "DateTimeLessTrue Output":
	true

define "DateTimeLessFalse Input":
	DateTime(2012, 2, 14) < DateTime(2012, 2, 13)
define "DateTimeLessFalse Output":
	false

define "TimeLessTrue Input":
	@T10:00:00.001 < @T10:00:00.002
define "TimeLessTrue Output":
	true

define "TimeLessFalse Input":
	@T10:10:00.000 < @T10:00:00.001
define "TimeLessFalse Output":
	false

define "UncertaintyLessNull Input":
	DateTime(2014) < DateTime(2014, 2, 15)
define "UncertaintyLessNull Output":
	null

define "UncertaintyLessTrue Input":
	DateTime(2013) < DateTime(2014, 2, 15)
define "UncertaintyLessTrue Output":
	true

define "UncertaintyLessFalse Input":
	DateTime(2015) < DateTime(2014, 2, 15)
define "UncertaintyLessFalse Output":
	false

define "LessOrEqualZZ Input":
	0 <= 0
define "LessOrEqualZZ Output":
	true

define "LessOrEqualZ1 Input":
	0 <= 1
define "LessOrEqualZ1 Output":
	true

define "LessOrEqualZNeg1 Input":
	0 <= -1
define "LessOrEqualZNeg1 Output":
	false

define "LessOrEqualDecZZ Input":
	0.0 <= 0.0
define "LessOrEqualDecZZ Output":
	true

define "LessOrEqualDecZ1 Input":
	0.0 <= 1.0
define "LessOrEqualDecZ1 Output":
	true

define "LessOrEqualDecZNeg1 Input":
	0.0 <= -1.0
define "LessOrEqualDecZNeg1 Output":
	false

define "LessOrEqualCM0CM0 Input":
	0'cm' <= 0'cm'
define "LessOrEqualCM0CM0 Output":
	true

define "LessOrEqualCM0CM1 Input":
	0'cm' <= 1'cm'
define "LessOrEqualCM0CM1 Output":
	true

define "LessOrEqualCM0NegCM1 Input":
	0'cm' <= -1'cm'
define "LessOrEqualCM0NegCM1 Output":
	false

define "LessOrEqualM1CM1 Input":
	1'm' <= 1'cm'
define "LessOrEqualM1CM1 Output":
	false

define "LessOrEqualM1CM10 Input":
	1'm' <= 10'cm'
define "LessOrEqualM1CM10 Output":
	false

define "LessOrEqualAA Input":
	'a' <= 'a'
define "LessOrEqualAA Output":
	true

define "LessOrEqualAB Input":
	'a' <= 'b'
define "LessOrEqualAB Output":
	true

define "LessOrEqualBA Input":
	'b' <= 'a'
define "LessOrEqualBA Output":
	false

define "LessOrEqualAThanAA Input":
	'a' <= 'aa'
define "LessOrEqualAThanAA Output":
	true

define "LessOrEqualAAThanA Input":
	'aa' <= 'a'
define "LessOrEqualAAThanA Output":
	false

define "LessOrEqualJackJill Input":
	'Jack' <= 'Jill'
define "LessOrEqualJackJill Output":
	true

define "DateTimeLessEqTrue Input":
	DateTime(2012, 2, 9, 0, 0, 0, 0) <= DateTime(2012, 2, 10, 0, 0, 0, 0)
define "DateTimeLessEqTrue Output":
	true

define "DateTimeLessEqTrue2 Input":
	DateTime(2012, 2, 12, 0, 0, 0, 0) <= DateTime(2012, 2, 12, 0, 0, 0, 0)
define "DateTimeLessEqTrue2 Output":
	true

define "DateTimeLessEqFalse Input":
	DateTime(2012, 2, 12, 1, 0, 0, 0) <= DateTime(2012, 2, 12, 0, 0, 0, 0)
define "DateTimeLessEqFalse Output":
	false

define "TimeLessEqTrue Input":
	@T10:00:00.001 <= @T10:00:00.002
define "TimeLessEqTrue Output":
	true

define "TimeLessEqTrue2 Input":
	@T10:00:00.000 <= @T10:00:00.000
define "TimeLessEqTrue2 Output":
	true

define "TimeLessEqFalse Input":
	@T10:00:00.002 <= @T10:00:00.001
define "TimeLessEqFalse Output":
	false

define "UncertaintyLessEqualNull Input":
	DateTime(2014) <= DateTime(2014, 2, 15)
define "UncertaintyLessEqualNull Output":
	null

define "UncertaintyLessEqualTrue Input":
	DateTime(2013) <= DateTime(2014, 2, 15)
define "UncertaintyLessEqualTrue Output":
	true

define "UncertaintyLessEqualFalse Input":
	DateTime(2015) <= DateTime(2014, 2, 15)
define "UncertaintyLessEqualFalse Output":
	false

define "EquivTrueTrue Input":
	true ~ true
define "EquivTrueTrue Output":
	true

define "EquivTrueFalse Input":
	true ~ false
define "EquivTrueFalse Output":
	false

define "EquivFalseFalse Input":
	false ~ false
define "EquivFalseFalse Output":
	true

define "EquivFalseTrue Input":
	false ~ true
define "EquivFalseTrue Output":
	false

define "EquivNullNull Input":
	null as String ~ null
define "EquivNullNull Output":
	true

define "EquivTrueNull Input":
	true ~ null
define "EquivTrueNull Output":
	false

define "EquivNullTrue Input":
	null ~ true
define "EquivNullTrue Output":
	false

define "EquivInt1Int1 Input":
	1 ~ 1
define "EquivInt1Int1 Output":
	true

define "EquivInt1Int2 Input":
	1 ~ 2
define "EquivInt1Int2 Output":
	false

define "EquivStringAStringA Input":
	'a' ~ 'a'
define "EquivStringAStringA Output":
	true

define "EquivStringAStringB Input":
	'a' ~ 'b'
define "EquivStringAStringB Output":
	false

define "EquivFloat1Float1 Input":
	1.0 ~ 1.0
define "EquivFloat1Float1 Output":
	true

define "EquivFloat1Float2 Input":
	1.0 ~ 2.0
define "EquivFloat1Float2 Output":
	false

define "EquivFloat1Int1 Input":
	1.0 ~ 1
define "EquivFloat1Int1 Output":
	true

define "EquivFloat1Int2 Input":
	1.0 ~ 2
define "EquivFloat1Int2 Output":
	false

define "EquivEqCM1CM1 Input":
	1'cm' ~ 1'cm'
define "EquivEqCM1CM1 Output":
	true

define "EquivEqCM1M01 Input":
	1'cm' ~ 0.01'm'
define "EquivEqCM1M01 Output":
	true

define "EquivTupleJohnJohn Input":
	Tuple { Id : 1, Name : 'John' } ~ Tuple { Id : 1, Name : 'John' }
define "EquivTupleJohnJohn Output":
	true

define "EquivTupleJohnJohnWithNulls Input":
	Tuple { Id : 1, Name : 'John', Position: null } ~ Tuple { Id : 1, Name : 'John', Position: null }
define "EquivTupleJohnJohnWithNulls Output":
	true

define "EquivTupleJohnJane Input":
	Tuple { Id : 1, Name : 'John' } ~ Tuple { Id : 2, Name : 'Jane' }
define "EquivTupleJohnJane Output":
	false

define "EquivTupleJohn1John2 Input":
	Tuple { Id : 1, Name : 'John' } ~ Tuple { Id : 2, Name : 'John' }
define "EquivTupleJohn1John2 Output":
	false

define "EquivDateTimeTodayToday Input":
	Today() ~ Today()
define "EquivDateTimeTodayToday Output":
	true

define "EquivDateTimeTodayYesterday Input":
	Today() ~ Today() - 1 days
define "EquivDateTimeTodayYesterday Output":
	false

define "EquivTime10A10A Input":
	@T10:00:00.000 ~ @T10:00:00.000
define "EquivTime10A10A Output":
	true

define "EquivTime10A10P Input":
	@T10:00:00.000 ~ @T22:00:00.000
define "EquivTime10A10P Output":
	false

define "SimpleNotEqTrueTrue Input":
	true != true
define "SimpleNotEqTrueTrue Output":
	false

define "SimpleNotEqTrueFalse Input":
	true != false
define "SimpleNotEqTrueFalse Output":
	true

define "SimpleNotEqFalseFalse Input":
	false != false
define "SimpleNotEqFalseFalse Output":
	false

define "SimpleNotEqFalseTrue Input":
	false != true
define "SimpleNotEqFalseTrue Output":
	true

define "SimpleNotEqNullNull Input":
	null as String != null
define "SimpleNotEqNullNull Output":
	null

define "SimpleNotEqTrueNull Input":
	true != null
define "SimpleNotEqTrueNull Output":
	null

define "SimpleNotEqNullTrue Input":
	null != true
define "SimpleNotEqNullTrue Output":
	null

define "SimpleNotEqInt1Int1 Input":
	1 != 1
define "SimpleNotEqInt1Int1 Output":
	false

define "SimpleNotEqInt1Int2 Input":
	1 != 2
define "SimpleNotEqInt1Int2 Output":
	true

define "SimpleNotEqStringAStringA Input":
	'a' != 'a'
define "SimpleNotEqStringAStringA Output":
	false

define "SimpleNotEqStringAStringB Input":
	'a' != 'b'
define "SimpleNotEqStringAStringB Output":
	true

define "SimpleNotEqFloat1Float1 Input":
	1.0 != 1.0
define "SimpleNotEqFloat1Float1 Output":
	false

define "SimpleNotEqFloat1Float2 Input":
	1.0 != 2.0
define "SimpleNotEqFloat1Float2 Output":
	true

define "SimpleNotEqFloat1Int1 Input":
	1.0 != 1
define "SimpleNotEqFloat1Int1 Output":
	false

define "SimpleNotEqFloat1Int2 Input":
	1.0 != 2
define "SimpleNotEqFloat1Int2 Output":
	true

define "QuantityNotEqCM1CM1 Input":
	1'cm' != 1'cm'
define "QuantityNotEqCM1CM1 Output":
	false

define "QuantityNotEqCM1M01 Input":
	1'cm' != 0.01'm'
define "QuantityNotEqCM1M01 Output":
	false

define "TupleNotEqJohnJohn Input":
	Tuple{ Id : 1, Name : 'John' } != Tuple{ Id : 1, Name : 'John' }
define "TupleNotEqJohnJohn Output":
	false

define "TupleNotEqJohnJane Input":
	Tuple{ Id : 1, Name : 'John' } != Tuple{ Id : 2, Name : 'Jane' }
define "TupleNotEqJohnJane Output":
	true

define "TupleNotEqJohn1John2 Input":
	Tuple{ Id : 1, Name : 'John' } != Tuple{ Id : 2, Name : 'John' }
define "TupleNotEqJohn1John2 Output":
	true

define "DateTimeNotEqTodayToday Input":
	Today() != Today()
define "DateTimeNotEqTodayToday Output":
	false

define "DateTimeNotEqTodayYesterday Input":
	Today() != Today() - 1 days
define "DateTimeNotEqTodayYesterday Output":
	true

define "TimeNotEq10A10A Input":
	@T10:00:00.000 != @T10:00:00.000
define "TimeNotEq10A10A Output":
	false

define "TimeNotEq10A10P Input":
	@T10:00:00.000 != @T22:00:00.000
define "TimeNotEq10A10P Output":
	true
