library CqlComparisonOperatorsTest version '1.0.000'

define "Between.BetweenIntTrue": 4 between 2 and 6

define "Equal.SimpleEqTrueTrue": true = true

define "Equal.SimpleEqTrueFalse": true = false

define "Equal.SimpleEqFalseFalse": false = false

define "Equal.SimpleEqFalseTrue": false = true

define "Equal.SimpleEqNullNull": null as String = null

define "Equal.SimpleEqTrueNull": true = null

define "Equal.SimpleEqNullTrue": null = true

define "Equal.SimpleEqInt1Int1": 1 = 1

define "Equal.SimpleEqInt1Int2": 1 = 2

define "Equal.SimpleEqStringAStringA": 'a' = 'a'

define "Equal.SimpleEqStringAStringB": 'a' = 'b'

define "Equal.SimpleEqFloat1Float1": 1.0 = 1.0

define "Equal.SimpleEqFloat1Float2": 1.0 = 2.0

define "Equal.SimpleEqFloat1Int1": 1.0 = 1

define "Equal.SimpleEqFloat1Int2": 1.0 = 2

define "Equal.QuantityEqCM1CM1": 1'cm' = 1'cm'

define "Equal.QuantityEqCM1M01": 1'cm' = 0.01'm'

define "Equal.QuantityEqDiffPrecision": 2.0'cm' = 2.00'cm'

define "Equal.TupleEqJohnJohn": Tuple { Id : 1, Name : 'John' } = Tuple { Id : 1, Name : 'John' }

define "Equal.TupleEqJohnJane": Tuple { Id : 1, Name : 'John' } = Tuple { Id : 2, Name : 'Jane' }

define "Equal.TupleEqJohn1John2": Tuple { Id : 1, Name : 'John' } = Tuple { Id : 2, Name : 'John' }

define "Equal.TupleEqDateTimeTrue": Tuple { dateId: 1, Date: DateTime(2012, 10, 5, 0, 0, 0, 0) } = Tuple { dateId: 1, Date: DateTime(2012, 10, 5, 0, 0, 0, 0) }

define "Equal.TupleEqDateTimeFalse": Tuple { dateId: 1, Date: DateTime(2012, 10, 5, 0, 0, 0, 0) } = Tuple { dateId: 1, Date: DateTime(2012, 10, 5, 5, 0, 0, 0) }

define "Equal.TupleEqTimeTrue": Tuple { timeId: 55, TheTime: @T05:15:15.541 } = Tuple { timeId: 55, TheTime: @T05:15:15.541 }

define "Equal.TupleEqTimeFalse": Tuple { timeId: 55, TheTime: @T05:15:15.541 } = Tuple { timeId: 55, TheTime: @T05:15:15.540 }

define "Equal.DateTimeEqTodayToday": Today() = Today()

define "Equal.DateTimeEqTodayYesterday": Today() = Today() - 1 days

define "Equal.DateTimeEqJanJan": DateTime(2014, 1, 5, 5, 0, 0, 0, 0) = DateTime(2014, 1, 5, 5, 0, 0, 0, 0)

define "Equal.DateTimeEqJanJuly": DateTime(2014, 1, 5, 5, 0, 0, 0, 0) = DateTime(2014, 7, 5, 5, 0, 0, 0, 0)

define "Equal.DateTimeEqNull": DateTime(null) = DateTime(null)

define "Equal.DateTimeUTC": @2014-01-25T14:30:14.559+01:00 = @2014-01-25T14:30:14.559+01:00

define "Equal.DateTimeDayCompare": @2022-02-22T00:00:00.000-05:00 same day as @2022-02-22T04:59:00.000Z

define "Equal.TimeEq10A10A": @T10:00:00.000 = @T10:00:00.000

define "Equal.TimeEq10A10P": @T10:00:00.000 = @T22:00:00.000

define "Greater.GreaterZZ": 0 > 0

define "Greater.GreaterZ1": 0 > 1

define "Greater.GreaterZNeg1": 0 > -1

define "Greater.GreaterDecZZ": 0.0 > 0.0

define "Greater.GreaterDecZ1": 0.0 > 1.0

define "Greater.GreaterDecZNeg1": 0.0 > -1.0

define "Greater.GreaterDec1Int2": 1.0 > 2

define "Greater.GreaterCM0CM0": 0'cm' > 0'cm'

define "Greater.GreaterCM0CM1": 0'cm' > 1'cm'

define "Greater.GreaterCM0NegCM1": 0'cm' > -1'cm'

define "Greater.GreaterM1CM1": 1'm' > 1'cm'

define "Greater.GreaterM1CM10": 1'm' > 10'cm'

define "Greater.GreaterAA": 'a' > 'a'

define "Greater.GreaterAB": 'a' > 'b'

define "Greater.GreaterBA": 'b' > 'a'

define "Greater.GreaterAThanAA": 'a' > 'aa'

define "Greater.GreaterAAThanA": 'aa' > 'a'

define "Greater.GreaterJackJill": 'Jack' > 'Jill'

define "Greater.DateTimeGreaterTrue": DateTime(2012, 2, 12) > DateTime(2012, 2, 10)

define "Greater.DateTimeGreaterFalse": DateTime(2012, 2, 12) > DateTime(2012, 2, 13)

define "Greater.TimeGreaterTrue": @T10:00:00.001 > @T10:00:00.000

define "Greater.TimeGreaterFalse": @T10:00:00.000 > @T10:00:00.001

define "Greater.UncertaintyGreaterNull": DateTime(2014) > DateTime(2014, 2, 15)

define "Greater.UncertaintyGreaterTrue": DateTime(2015) > DateTime(2014, 2, 15)

define "Greater.UncertaintyGreaterFalse": DateTime(2013) > DateTime(2014, 2, 15)

define "Greater Or Equal.GreaterOrEqualZZ": 0 >= 0

define "Greater Or Equal.GreaterOrEqualZ1": 0 >= 1

define "Greater Or Equal.GreaterOrEqualZNeg1": 0 >= -1

define "Greater Or Equal.GreaterOrEqualDecZZ": 0.0 >= 0.0

define "Greater Or Equal.GreaterOrEqualDecZ1": 0.0 >= 1.0

define "Greater Or Equal.GreaterOrEqualDecZNeg1": 0.0 >= -1.0

define "Greater Or Equal.GreaterOrEqualDec1Int2": 1.0 >= 2

define "Greater Or Equal.GreaterOrEqualCM0CM0": 0'cm' >= 0'cm'

define "Greater Or Equal.GreaterOrEqualCM0CM1": 0'cm' >= 1'cm'

define "Greater Or Equal.GreaterOrEqualCM0NegCM1": 0'cm' >= -1'cm'

define "Greater Or Equal.GreaterOrEqualM1CM1": 1'm' >= 1'cm'

define "Greater Or Equal.GreaterOrEqualM1CM10": 1'm' >= 10'cm'

define "Greater Or Equal.GreaterOrEqualAA": 'a' >= 'a'

define "Greater Or Equal.GreaterOrEqualAB": 'a' >= 'b'

define "Greater Or Equal.GreaterOrEqualBA": 'b' >= 'a'

define "Greater Or Equal.GreaterOrEqualAThanAA": 'a' >= 'aa'

define "Greater Or Equal.GreaterOrEqualAAThanA": 'aa' >= 'a'

define "Greater Or Equal.GreaterOrEqualJackJill": 'Jack' >= 'Jill'

define "Greater Or Equal.DateTimeGreaterEqTrue": DateTime(2012, 2, 12, 0, 0, 0, 0) >= DateTime(2012, 2, 10, 0, 0, 0, 0)

define "Greater Or Equal.DateTimeGreaterEqTrue2": DateTime(2012, 2, 12, 0, 0, 0, 0) >= DateTime(2012, 2, 12, 0, 0, 0, 0)

define "Greater Or Equal.DateTimeGreaterEqFalse": DateTime(2012, 2, 12, 0, 0, 0, 0) >= DateTime(2012, 2, 13, 0, 0, 0, 0)

define "Greater Or Equal.TimeGreaterEqTrue": @T10:00:00.001 >= @T10:00:00.000

define "Greater Or Equal.TimeGreaterEqTrue2": @T10:00:00.000 >= @T10:00:00.000

define "Greater Or Equal.TimeGreaterEqFalse": @T10:00:00.000 >= @T10:00:00.001

define "Greater Or Equal.UncertaintyGreaterEqualNull": DateTime(2014) >= DateTime(2014, 2, 15)

define "Greater Or Equal.UncertaintyGreaterEqualTrue": DateTime(2015) >= DateTime(2014, 2, 15)

define "Greater Or Equal.UncertaintyGreaterEqualFalse": DateTime(2013) >= DateTime(2014, 2, 15)

define "Less.LessZZ": 0 < 0

define "Less.LessZ1": 0 < 1

define "Less.LessZNeg1": 0 < -1

define "Less.LessDecZZ": 0.0 < 0.0

define "Less.LessDecZ1": 0.0 < 1.0

define "Less.LessDecZNeg1": 0.0 < -1.0

define "Less.LessDec1Int2": 1.0 < 2

define "Less.LessCM0CM0": 0'cm' < 0'cm'

define "Less.LessCM0CM1": 0'cm' < 1'cm'

define "Less.LessCM0NegCM1": 0'cm' < -1'cm'

define "Less.LessM1CM1": 1'm' < 1'cm'

define "Less.LessM1CM10": 1'm' < 10'cm'

define "Less.LessAA": 'a' < 'a'

define "Less.LessAB": 'a' < 'b'

define "Less.LessBA": 'b' < 'a'

define "Less.LessAThanAA": 'a' < 'aa'

define "Less.LessAAThanA": 'aa' < 'a'

define "Less.LessJackJill": 'Jack' < 'Jill'

define "Less.DateTimeLessTrue": DateTime(2012, 2, 9) < DateTime(2012, 2, 10)

define "Less.DateTimeLessFalse": DateTime(2012, 2, 14) < DateTime(2012, 2, 13)

define "Less.TimeLessTrue": @T10:00:00.001 < @T10:00:00.002

define "Less.TimeLessFalse": @T10:10:00.000 < @T10:00:00.001

define "Less.UncertaintyLessNull": DateTime(2014) < DateTime(2014, 2, 15)

define "Less.UncertaintyLessTrue": DateTime(2013) < DateTime(2014, 2, 15)

define "Less.UncertaintyLessFalse": DateTime(2015) < DateTime(2014, 2, 15)

define "Less Or Equal.LessOrEqualZZ": 0 <= 0

define "Less Or Equal.LessOrEqualZ1": 0 <= 1

define "Less Or Equal.LessOrEqualZNeg1": 0 <= -1

define "Less Or Equal.LessOrEqualDecZZ": 0.0 <= 0.0

define "Less Or Equal.LessOrEqualDecZ1": 0.0 <= 1.0

define "Less Or Equal.LessOrEqualDecZNeg1": 0.0 <= -1.0

define "Less Or Equal.LessOrEqualDec1Int2": 1.0 <= 2

define "Less Or Equal.LessOrEqualCM0CM0": 0'cm' <= 0'cm'

define "Less Or Equal.LessOrEqualCM0CM1": 0'cm' <= 1'cm'

define "Less Or Equal.LessOrEqualCM0NegCM1": 0'cm' <= -1'cm'

define "Less Or Equal.LessOrEqualM1CM1": 1'm' <= 1'cm'

define "Less Or Equal.LessOrEqualM1CM10": 1'm' <= 10'cm'

define "Less Or Equal.LessOrEqualAA": 'a' <= 'a'

define "Less Or Equal.LessOrEqualAB": 'a' <= 'b'

define "Less Or Equal.LessOrEqualBA": 'b' <= 'a'

define "Less Or Equal.LessOrEqualAThanAA": 'a' <= 'aa'

define "Less Or Equal.LessOrEqualAAThanA": 'aa' <= 'a'

define "Less Or Equal.LessOrEqualJackJill": 'Jack' <= 'Jill'

define "Less Or Equal.DateTimeLessEqTrue": DateTime(2012, 2, 9, 0, 0, 0, 0) <= DateTime(2012, 2, 10, 0, 0, 0, 0)

define "Less Or Equal.DateTimeLessEqTrue2": DateTime(2012, 2, 12, 0, 0, 0, 0) <= DateTime(2012, 2, 12, 0, 0, 0, 0)

define "Less Or Equal.DateTimeLessEqFalse": DateTime(2012, 2, 12, 1, 0, 0, 0) <= DateTime(2012, 2, 12, 0, 0, 0, 0)

define "Less Or Equal.TimeLessEqTrue": @T10:00:00.001 <= @T10:00:00.002

define "Less Or Equal.TimeLessEqTrue2": @T10:00:00.000 <= @T10:00:00.000

define "Less Or Equal.TimeLessEqFalse": @T10:00:00.002 <= @T10:00:00.001

define "Less Or Equal.UncertaintyLessEqualNull": DateTime(2014) <= DateTime(2014, 2, 15)

define "Less Or Equal.UncertaintyLessEqualTrue": DateTime(2013) <= DateTime(2014, 2, 15)

define "Less Or Equal.UncertaintyLessEqualFalse": DateTime(2015) <= DateTime(2014, 2, 15)

define "Equivalent.EquivTrueTrue": true ~ true

define "Equivalent.EquivTrueFalse": true ~ false

define "Equivalent.EquivFalseFalse": false ~ false

define "Equivalent.EquivFalseTrue": false ~ true

define "Equivalent.EquivNullNull": null as String ~ null

define "Equivalent.EquivTrueNull": true ~ null

define "Equivalent.EquivNullTrue": null ~ true

define "Equivalent.EquivInt1Int1": 1 ~ 1

define "Equivalent.EquivInt1Int2": 1 ~ 2

define "Equivalent.EquivStringAStringA": 'a' ~ 'a'

define "Equivalent.EquivStringAStringB": 'a' ~ 'b'

define "Equivalent.EquivFloat1Float1": 1.0 ~ 1.0

define "Equivalent.EquivFloat1Float2": 1.0 ~ 2.0

define "Equivalent.EquivFloat1Int1": 1.0 ~ 1

define "Equivalent.EquivFloat1Int2": 1.0 ~ 2

define "Equivalent.EquivEqCM1CM1": 1'cm' ~ 1'cm'

define "Equivalent.EquivEqCM1M01": 1'cm' ~ 0.01'm'

define "Equivalent.EquivTupleJohnJohn": Tuple { Id : 1, Name : 'John' } ~ Tuple { Id : 1, Name : 'John' }

define "Equivalent.EquivTupleJohnJohnWithNulls": Tuple { Id : 1, Name : 'John', Position: null } ~ Tuple { Id : 1, Name : 'John', Position: null }

define "Equivalent.EquivTupleJohnJane": Tuple { Id : 1, Name : 'John' } ~ Tuple { Id : 2, Name : 'Jane' }

define "Equivalent.EquivTupleJohn1John2": Tuple { Id : 1, Name : 'John' } ~ Tuple { Id : 2, Name : 'John' }

define "Equivalent.EquivDateTimeTodayToday": Today() ~ Today()

define "Equivalent.EquivDateTimeTodayYesterday": Today() ~ Today() - 1 days

define "Equivalent.EquivTime10A10A": @T10:00:00.000 ~ @T10:00:00.000

define "Equivalent.EquivTime10A10P": @T10:00:00.000 ~ @T22:00:00.000

define "Not Equal.SimpleNotEqTrueTrue": true != true

define "Not Equal.SimpleNotEqTrueFalse": true != false

define "Not Equal.SimpleNotEqFalseFalse": false != false

define "Not Equal.SimpleNotEqFalseTrue": false != true

define "Not Equal.SimpleNotEqNullNull": null as String != null

define "Not Equal.SimpleNotEqTrueNull": true != null

define "Not Equal.SimpleNotEqNullTrue": null != true

define "Not Equal.SimpleNotEqInt1Int1": 1 != 1

define "Not Equal.SimpleNotEqInt1Int2": 1 != 2

define "Not Equal.SimpleNotEqStringAStringA": 'a' != 'a'

define "Not Equal.SimpleNotEqStringAStringB": 'a' != 'b'

define "Not Equal.SimpleNotEqFloat1Float1": 1.0 != 1.0

define "Not Equal.SimpleNotEqFloat1Float2": 1.0 != 2.0

define "Not Equal.SimpleNotEqFloat1Int1": 1.0 != 1

define "Not Equal.SimpleNotEqFloat1Int2": 1.0 != 2

define "Not Equal.QuantityNotEqCM1CM1": 1'cm' != 1'cm'

define "Not Equal.QuantityNotEqCM1M01": 1'cm' != 0.01'm'

define "Not Equal.TupleNotEqJohnJohn": Tuple{ Id : 1, Name : 'John' } != Tuple{ Id : 1, Name : 'John' }

define "Not Equal.TupleNotEqJohnJane": Tuple{ Id : 1, Name : 'John' } != Tuple{ Id : 2, Name : 'Jane' }

define "Not Equal.TupleNotEqJohn1John2": Tuple{ Id : 1, Name : 'John' } != Tuple{ Id : 2, Name : 'John' }

define "Not Equal.DateTimeNotEqTodayToday": Today() != Today()

define "Not Equal.DateTimeNotEqTodayYesterday": Today() != Today() - 1 days

define "Not Equal.TimeNotEq10A10A": @T10:00:00.000 != @T10:00:00.000

define "Not Equal.TimeNotEq10A10P": @T10:00:00.000 != @T22:00:00.000

