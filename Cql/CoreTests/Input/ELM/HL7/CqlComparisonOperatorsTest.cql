library CqlComparisonOperatorsTest version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

context Patient

define "BetweenIntTrue":
  4 between 2 and 6 = true

define "SimpleEqTrueTrue":
  true = true = true

define "SimpleEqTrueFalse":
  true = false = false

define "SimpleEqFalseFalse":
  false = false = true

define "SimpleEqFalseTrue":
  false = true = false

define "SimpleEqNullNull":
  ( null as String = null as String ) = null

define "SimpleEqTrueNull":
  true = null = null

define "SimpleEqNullTrue":
  null = true = null

define "SimpleEqInt1Int1":
  1 = 1 = true

define "SimpleEqInt1Int2":
  1 = 2 = false

define "SimpleEqStringAStringA":
  'a' = 'a' = true

define "SimpleEqStringAStringB":
  'a' = 'b' = false

define "SimpleEqFloat1Float1":
  1.0 = 1.0 = true

define "SimpleEqFloat1Float2":
  1.0 = 2.0 = false

define "SimpleEqFloat1Int1":
  1.0 = 1 = true

define "SimpleEqFloat1Int2":
  1.0 = 2 = false

define "QuantityEqCM1CM1":
  1 'cm' = 1 'cm' = true

define "QuantityEqCM1M01":
  1 'cm' = 0.01 'm' = true

define "QuantityEqDiffPrecision":
  2.0 'cm' = 2.00 'cm' = true

define "TupleEqJohnJohn":
  Tuple {
    Id: 1,
    Name: 'John'
  } = Tuple {
    Id: 1,
    Name: 'John'
  } = true

define "TupleEqJohnJane":
  Tuple {
    Id: 1,
    Name: 'John'
  } = Tuple {
    Id: 2,
    Name: 'Jane'
  } = false

define "TupleEqJohn1John2":
  Tuple {
    Id: 1,
    Name: 'John'
  } = Tuple {
    Id: 2,
    Name: 'John'
  } = false

define "TupleEqDateTimeTrue":
  Tuple {
    dateId: 1,
    Date: DateTime(2012, 10, 5, 0, 0, 0, 0)
  } = Tuple {
    dateId: 1,
    Date: DateTime(2012, 10, 5, 0, 0, 0, 0)
  } = true

define "TupleEqDateTimeFalse":
  Tuple {
    dateId: 1,
    Date: DateTime(2012, 10, 5, 0, 0, 0, 0)
  } = Tuple {
    dateId: 1,
    Date: DateTime(2012, 10, 5, 5, 0, 0, 0)
  } = false

define "TupleEqTimeTrue":
  Tuple {
    timeId: 55,
    TheTime: @T05:15:15.541
  } = Tuple {
    timeId: 55,
    TheTime: @T05:15:15.541
  } = true

define "TupleEqTimeFalse":
  Tuple {
    timeId: 55,
    TheTime: @T05:15:15.541
  } = Tuple {
    timeId: 55,
    TheTime: @T05:15:15.540
  } = false

define "DateTimeEqTodayToday":
  Today()= Today()= true

define "DateTimeEqTodayYesterday":
  Today()= Today()- 1 days = false

define "DateTimeEqJanJan":
  DateTime(2014, 1, 5, 5, 0, 0, 0, 0)= DateTime(2014, 1, 5, 5, 0, 0, 0, 0)= true

define "DateTimeEqJanJuly":
  DateTime(2014, 1, 5, 5, 0, 0, 0, 0)= DateTime(2014, 7, 5, 5, 0, 0, 0, 0)= false

define "DateTimeEqNull":
  DateTime(null)= DateTime(null)= null

define "DateTimeUTC":
  @2014-01-25T14:30:14.559+01:00 = @2014-01-25T14:30:14.559+01:00 = true

define "TimeEq10A10A":
  @T10:00:00.000 = @T10:00:00.000 = true

define "TimeEq10A10P":
  @T10:00:00.000 = @T22:00:00.000 = false

define "GreaterZZ":
  0 > 0 = false

define "GreaterZ1":
  0 > 1 = false

define "GreaterZNeg1":
  0 > - 1 = true

define "GreaterDecZZ":
  0.0 > 0.0 = false

define "GreaterDecZ1":
  0.0 > 1.0 = false

define "GreaterDecZNeg1":
  0.0 > - 1.0 = true

define "GreaterCM0CM0":
  0 'cm' > 0 'cm' = false

define "GreaterCM0CM1":
  0 'cm' > 1 'cm' = false

define "GreaterCM0NegCM1":
  0 'cm' > - 1 'cm' = true

define "GreaterM1CM1":
  1 'm' > 1 'cm' = true

define "GreaterM1CM10":
  1 'm' > 10 'cm' = true

define "GreaterAA":
  'a' > 'a' = false

define "GreaterAB":
  'a' > 'b' = false

define "GreaterBA":
  'b' > 'a' = true

define "GreaterAThanAA":
  'a' > 'aa' = false

define "GreaterAAThanA":
  'aa' > 'a' = true

define "GreaterJackJill":
  'Jack' > 'Jill' = false

define "DateTimeGreaterTrue":
  DateTime(2012, 2, 12)> DateTime(2012, 2, 10)= true

define "DateTimeGreaterFalse":
  DateTime(2012, 2, 12)> DateTime(2012, 2, 13)= false

define "TimeGreaterTrue":
  @T10:00:00.001 > @T10:00:00.000 = true

define "TimeGreaterFalse":
  @T10:00:00.000 > @T10:00:00.001 = false

define "UncertaintyGreaterNull":
  DateTime(2014)> DateTime(2014, 2, 15)= null

define "UncertaintyGreaterTrue":
  DateTime(2015)> DateTime(2014, 2, 15)= true

define "UncertaintyGreaterFalse":
  DateTime(2013)> DateTime(2014, 2, 15)= false

define "GreaterOrEqualZZ":
  0 >= 0 = true

define "GreaterOrEqualZ1":
  0 >= 1 = false

define "GreaterOrEqualZNeg1":
  0 >= - 1 = true

define "GreaterOrEqualDecZZ":
  0.0 >= 0.0 = true

define "GreaterOrEqualDecZ1":
  0.0 >= 1.0 = false

define "GreaterOrEqualDecZNeg1":
  0.0 >= - 1.0 = true

define "GreaterOrEqualCM0CM0":
  0 'cm' >= 0 'cm' = true

define "GreaterOrEqualCM0CM1":
  0 'cm' >= 1 'cm' = false

define "GreaterOrEqualCM0NegCM1":
  0 'cm' >= - 1 'cm' = true

define "GreaterOrEqualM1CM1":
  1 'm' >= 1 'cm' = true

define "GreaterOrEqualM1CM10":
  1 'm' >= 10 'cm' = true

define "GreaterOrEqualAA":
  'a' >= 'a' = true

define "GreaterOrEqualAB":
  'a' >= 'b' = false

define "GreaterOrEqualBA":
  'b' >= 'a' = true

define "GreaterOrEqualAThanAA":
  'a' >= 'aa' = false

define "GreaterOrEqualAAThanA":
  'aa' >= 'a' = true

define "GreaterOrEqualJackJill":
  'Jack' >= 'Jill' = false

define "DateTimeGreaterEqTrue":
  DateTime(2012, 2, 12, 0, 0, 0, 0)>= DateTime(2012, 2, 10, 0, 0, 0, 0)= true

define "DateTimeGreaterEqTrue2":
  DateTime(2012, 2, 12, 0, 0, 0, 0)>= DateTime(2012, 2, 12, 0, 0, 0, 0)= true

define "DateTimeGreaterEqFalse":
  DateTime(2012, 2, 12, 0, 0, 0, 0)>= DateTime(2012, 2, 13, 0, 0, 0, 0)= false

define "TimeGreaterEqTrue":
  @T10:00:00.001 >= @T10:00:00.000 = true

define "TimeGreaterEqTrue2":
  @T10:00:00.000 >= @T10:00:00.000 = true

define "TimeGreaterEqFalse":
  @T10:00:00.000 >= @T10:00:00.001 = false

define "UncertaintyGreaterEqualNull":
  DateTime(2014)>= DateTime(2014, 2, 15)= null

define "UncertaintyGreaterEqualTrue":
  DateTime(2015)>= DateTime(2014, 2, 15)= true

define "UncertaintyGreaterEqualFalse":
  DateTime(2013)>= DateTime(2014, 2, 15)= false

define "LessZZ":
  0 < 0 = false

define "LessZ1":
  0 < 1 = true

define "LessZNeg1":
  0 < - 1 = false

define "LessDecZZ":
  0.0 < 0.0 = false

define "LessDecZ1":
  0.0 < 1.0 = true

define "LessDecZNeg1":
  0.0 < - 1.0 = false

define "LessCM0CM0":
  0 'cm' < 0 'cm' = false

define "LessCM0CM1":
  0 'cm' < 1 'cm' = true

define "LessCM0NegCM1":
  0 'cm' < - 1 'cm' = false

define "LessM1CM1":
  1 'm' < 1 'cm' = false

define "LessM1CM10":
  1 'm' < 10 'cm' = false

define "LessAA":
  'a' < 'a' = false

define "LessAB":
  'a' < 'b' = true

define "LessBA":
  'b' < 'a' = false

define "LessAThanAA":
  'a' < 'aa' = true

define "LessAAThanA":
  'aa' < 'a' = false

define "LessJackJill":
  'Jack' < 'Jill' = true

define "DateTimeLessTrue":
  DateTime(2012, 2, 9)< DateTime(2012, 2, 10)= true

define "DateTimeLessFalse":
  DateTime(2012, 2, 14)< DateTime(2012, 2, 13)= false

define "TimeLessTrue":
  @T10:00:00.001 < @T10:00:00.002 = true

define "TimeLessFalse":
  @T10:10:00.000 < @T10:00:00.001 = false

define "UncertaintyLessNull":
  DateTime(2014)< DateTime(2014, 2, 15)= null

define "UncertaintyLessTrue":
  DateTime(2013)< DateTime(2014, 2, 15)= true

define "UncertaintyLessFalse":
  DateTime(2015)< DateTime(2014, 2, 15)= false

define "LessOrEqualZZ":
  0 <= 0 = true

define "LessOrEqualZ1":
  0 <= 1 = true

define "LessOrEqualZNeg1":
  0 <= - 1 = false

define "LessOrEqualDecZZ":
  0.0 <= 0.0 = true

define "LessOrEqualDecZ1":
  0.0 <= 1.0 = true

define "LessOrEqualDecZNeg1":
  0.0 <= - 1.0 = false

define "LessOrEqualCM0CM0":
  0 'cm' <= 0 'cm' = true

define "LessOrEqualCM0CM1":
  0 'cm' <= 1 'cm' = true

define "LessOrEqualCM0NegCM1":
  0 'cm' <= - 1 'cm' = false

define "LessOrEqualM1CM1":
  1 'm' <= 1 'cm' = false

define "LessOrEqualM1CM10":
  1 'm' <= 10 'cm' = false

define "LessOrEqualAA":
  'a' <= 'a' = true

define "LessOrEqualAB":
  'a' <= 'b' = true

define "LessOrEqualBA":
  'b' <= 'a' = false

define "LessOrEqualAThanAA":
  'a' <= 'aa' = true

define "LessOrEqualAAThanA":
  'aa' <= 'a' = false

define "LessOrEqualJackJill":
  'Jack' <= 'Jill' = true

define "DateTimeLessEqTrue":
  DateTime(2012, 2, 9, 0, 0, 0, 0)<= DateTime(2012, 2, 10, 0, 0, 0, 0)= true

define "DateTimeLessEqTrue2":
  DateTime(2012, 2, 12, 0, 0, 0, 0)<= DateTime(2012, 2, 12, 0, 0, 0, 0)= true

define "DateTimeLessEqFalse":
  DateTime(2012, 2, 12, 1, 0, 0, 0)<= DateTime(2012, 2, 12, 0, 0, 0, 0)= false

define "TimeLessEqTrue":
  @T10:00:00.001 <= @T10:00:00.002 = true

define "TimeLessEqTrue2":
  @T10:00:00.000 <= @T10:00:00.000 = true

define "TimeLessEqFalse":
  @T10:00:00.002 <= @T10:00:00.001 = false

define "UncertaintyLessEqualNull":
  DateTime(2014)<= DateTime(2014, 2, 15)= null

define "UncertaintyLessEqualTrue":
  DateTime(2013)<= DateTime(2014, 2, 15)= true

define "UncertaintyLessEqualFalse":
  DateTime(2015)<= DateTime(2014, 2, 15)= false

define "EquivTrueTrue":
  true ~ true = true

define "EquivTrueFalse":
  true ~ false = false

define "EquivFalseFalse":
  false ~ false = true

define "EquivFalseTrue":
  false ~ true = false

define "EquivNullNull":
  null as String ~ null as String = true

define "EquivTrueNull":
  true ~ null = false

define "EquivNullTrue":
  null ~ true = false

define "EquivInt1Int1":
  1 ~ 1 = true

define "EquivInt1Int2":
  1 ~ 2 = false

define "EquivStringAStringA":
  'a' ~ 'a' = true

define "EquivStringAStringB":
  'a' ~ 'b' = false

define "EquivFloat1Float1":
  1.0 ~ 1.0 = true

define "EquivFloat1Float2":
  1.0 ~ 2.0 = false

define "EquivFloat1Int1":
  1.0 ~ 1 = true

define "EquivFloat1Int2":
  1.0 ~ 2 = false

define "EquivEqCM1CM1":
  1 'cm' ~ 1 'cm' = true

define "EquivEqCM1M01":
  1 'cm' ~ 0.01 'm' = true

define "EquivTupleJohnJohn":
  Tuple {
    Id: 1,
    Name: 'John'
  } ~ Tuple {
    Id: 1,
    Name: 'John'
  } = true

define "EquivTupleJohnJohnWithNulls":
  Tuple {
    Id: 1,
    Name: 'John',
    Position: null
  } ~ Tuple {
    Id: 1,
    Name: 'John',
    Position: null
  } = true

define "EquivTupleJohnJane":
  Tuple {
    Id: 1,
    Name: 'John'
  } ~ Tuple {
    Id: 2,
    Name: 'Jane'
  } = false

define "EquivTupleJohn1John2":
  Tuple {
    Id: 1,
    Name: 'John'
  } ~ Tuple {
    Id: 2,
    Name: 'John'
  } = false

define "EquivDateTimeTodayToday":
  Today()~ Today()= true

define "EquivDateTimeTodayYesterday":
  Today()~ Today()- 1 days = false

define "EquivTime10A10A":
  @T10:00:00.000 ~ @T10:00:00.000 = true

define "EquivTime10A10P":
  @T10:00:00.000 ~ @T22:00:00.000 = false

define "SimpleNotEqTrueTrue":
  true != true = false

define "SimpleNotEqTrueFalse":
  true != false = true

define "SimpleNotEqFalseFalse":
  false != false = false

define "SimpleNotEqFalseTrue":
  false != true = true

define "SimpleNotEqNullNull":
  ( null as String != null as String ) = null

define "SimpleNotEqTrueNull":
  true != null = null

define "SimpleNotEqNullTrue":
  null != true = null

define "SimpleNotEqInt1Int1":
  1 != 1 = false

define "SimpleNotEqInt1Int2":
  1 != 2 = true

define "SimpleNotEqStringAStringA":
  'a' != 'a' = false

define "SimpleNotEqStringAStringB":
  'a' != 'b' = true

define "SimpleNotEqFloat1Float1":
  1.0 != 1.0 = false

define "SimpleNotEqFloat1Float2":
  1.0 != 2.0 = true

define "SimpleNotEqFloat1Int1":
  1.0 != 1 = false

define "SimpleNotEqFloat1Int2":
  1.0 != 2 = true

define "QuantityNotEqCM1CM1":
  1 'cm' != 1 'cm' = false

define "QuantityNotEqCM1M01":
  1 'cm' != 0.01 'm' = false

define "TupleNotEqJohnJohn":
  Tuple {
    Id: 1,
    Name: 'John'
  } != Tuple {
    Id: 1,
    Name: 'John'
  } = false

define "TupleNotEqJohnJane":
  Tuple {
    Id: 1,
    Name: 'John'
  } != Tuple {
    Id: 2,
    Name: 'Jane'
  } = true

define "TupleNotEqJohn1John2":
  Tuple {
    Id: 1,
    Name: 'John'
  } != Tuple {
    Id: 2,
    Name: 'John'
  } = true

define "DateTimeNotEqTodayToday":
  Today()!= Today()= false

define "DateTimeNotEqTodayYesterday":
  Today()!= Today()- 1 days = true

define "TimeNotEq10A10A":
  @T10:00:00.000 != @T10:00:00.000 = false

define "TimeNotEq10A10P":
  @T10:00:00.000 != @T22:00:00.000 = true