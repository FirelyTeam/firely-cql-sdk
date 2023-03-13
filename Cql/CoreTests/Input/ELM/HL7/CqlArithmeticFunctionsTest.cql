library CqlArithmeticFunctionsTest version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

context Patient

define "AbsNull":
  Abs(null as Integer)= null

define "Abs0":
  Abs(0)= 0

define "AbsNeg1":
  Abs(- 1)= 1

define "AbsNeg1Dec":
  Abs(- 1.0)= 1.0

define "Abs0Dec":
  Abs(0.0)= 0.0

define "Abs1cm":
  Abs(- 1.0 'cm')= 1.0 'cm'

define "AbsLong":
  Abs(- 1)= 1

define "AddNull":
  1 + null = null

define "Add11":
  1 + 1 = 2

define "Add1D1D":
  1.0 + 1.0 = 2.0

define "Add1Q1Q":
  1 'g/cm3' + 1 'g/cm3' = 2.0 'g/cm3'

define "AddIAndD":
  1 + 2.0 = 3.0

define "Add1L1L":
  1 + 1 = 2

define "CeilingNull":
  Ceiling(null as Decimal)= null

define "Ceiling1D":
  Ceiling(1.0)= 1

define "Ceiling1D1":
  Ceiling(1.1)= 2

define "CeilingNegD1":
  Ceiling(- 0.1)= 0

define "CeilingNeg1":
  Ceiling(- 1.0)= - 1

define "CeilingNeg1D1":
  Ceiling(- 1.1)= - 1

define "Ceiling1I":
  Ceiling(1)= 1

define "DivideNull":
  1 / null = null

define "Divide10":
  1 / 0 = null

define "Divide01":
  0 / 1 = 0.0

define "Divide11":
  1 / 1 = 1.0

define "Divide1d1d":
  1.0 / 1.0 = 1.0

define "Divide103":
  10 / 3 = 3.33333333

define "Divide1Q1":
  1 'g/cm3' / 1.0 = 1.0 'g/cm3'

define "Divide1Q1Q":
  1 'g/cm3' / 1 'g/cm3' = 1.0 '1'

define "Divide10I5D":
  10 / 5.0 = 2.0

define "Divide10I5I":
  10 / 5 = 2.0

define "Divide10Q5I":
  10.0 'g' / 5 = 2.0 'g'

define "FloorNull":
  Floor(null as Decimal)= null

define "Floor1":
  Floor(1)= 1

define "Floor1D":
  Floor(1.0)= 1

define "Floor1D1":
  Floor(1.1)= 1

define "FloorNegD1":
  Floor(- 0.1)= - 1

define "FloorNeg1":
  Floor(- 1.0)= - 1

define "FloorNeg1D1":
  Floor(- 1.1)= - 2

define "Floor2I":
  Floor(2)= 2

define "ExpNull":
  Exp(null as Decimal)= null

define "Exp0":
  Exp(0)= 1.0

define "ExpNeg0":
  Exp(- 0)= 1.0

define "Exp1":
  Exp(1)= 2.718281828459045090795598298427648842334747314453125

define "ExpNeg1":
  Exp(- 1)= 0.367879441171442334024277442949824035167694091796875

define "Exp1000":
  Exp(1000)

define "Exp1000D":
  Exp(1000.0)

define "HighBoundaryDecimal":
  HighBoundary(1.587, 8)= 1.58799999

define "HighBoundaryDateMonth":
  HighBoundary(@2014, 6)= @2014-12

define "HighBoundaryDateTimeMillisecond":
  HighBoundary(@2014-01-01T08, 17)= @2014-01-01T08:59:59.999

define "HighBoundaryTimeMillisecond":
  HighBoundary(@T10:30, 9)= @T10:30:59.999

define "LogNullNull":
  Log(null, null)= null

define "Log1BaseNull":
  Log(1, null)= null

define "Log1Base1":
  Log(1, 1)= 0.0

define "Log1Base2":
  Log(1, 2)= 0.0

define "Log1Base100":
  Log(1, 100)= 0.0

define "Log16Base2":
  Log(16, 2)= 4.0

define "LogD125Base2":
  Log(0.125, 2)= - 3.0

define "LowBoundaryDecimal":
  LowBoundary(1.587, 8)= 1.58700000

define "LowBoundaryDateMonth":
  LowBoundary(@2014, 6)= @2014-01

define "LowBoundaryDateTimeMillisecond":
  LowBoundary(@2014-01-01T08, 17)= @2014-01-01T08:00:00.000

define "LowBoundaryTimeMillisecond":
  LowBoundary(@T10:30, 9)= @T10:30:00.000

define "LnNull":
  Ln(null)= null

define "Ln0":
  Ln(0)

define "LnNeg0":
  Ln(- 0)

define "Ln1":
  Ln(1)= 0.0

define "LnNeg1":
  Ln(- 1)= null

define "Ln1000":
  Ln(1000)= 6.907755278982136815102421678602695465087890625

define "Ln1000D":
  Ln(1000.0)= 6.907755278982136815102421678602695465087890625

define "IntegerMinValue":
  minimum Integer = - 2147483648

define "DecimalMinValue":
  minimum Decimal = - 9999999999999999999999999999.99999999

define "DateTimeMinValue":
  minimum DateTime = @0001-01-01T00:00:00.000

define "DateMinValue":
  minimum Date = @0001-01-01

define "TimeMinValue":
  minimum Time = @T00:00:00.000

define "IntegerMaxValue":
  maximum Integer = 2147483647

define "DecimalMaxValue":
  maximum Decimal = 9999999999999999999999999999.99999999

define "DateTimeMaxValue":
  maximum DateTime = @9999-12-31T23:59:59.999

define "DateMaxValue":
  maximum Date = @9999-12-31

define "TimeMaxValue":
  maximum Time = @T23:59:59.999

define "ModuloNull":
  1 mod null = null

define "Modulo0By0":
  0 mod 0 = null

define "Modulo4By2":
  4 mod 2 = 0

define "Modulo4DBy2D":
  4.0 mod 2.0 = 0.0

define "Modulo10By3":
  10 mod 3 = 1

define "Modulo10DBy3D":
  10.0 mod 3.0 = 1.0

define "Modulo10IBy3D":
  10 mod 3.0 = 1.0

define "ModuloDResult":
  3.5 mod 3 = 0.5

define "MultiplyNull":
  1 * null = null

define "Multiply1By1":
  1 * 1 = 1

define "Multiply1DBy2D":
  1.0 * 2.0 = 2.0

define "Multiply1IBy2D":
  1 * 2.0 = 2.0

define "Multiply1CMBy2CM":
  1.0 'cm' * 2.0 'cm' = 2.0 'cm2'

define "NegateNull":
  - ( null as Integer ) = null

define "Negate0":
  - 0 = 0

define "NegateNeg0":
  - ( - 0 ) = 0

define "Negate1":
  - 1 = - 1

define "NegateNeg1":
  - ( - 1 ) = 1

define "Negate0D":
  - ( 0.0 ) = 0.0

define "NegateNeg0D":
  - ( - 0.0 ) = 0.0

define "Negate1D":
  - ( 1.0 ) = - 1.0

define "NegateNeg1D":
  - ( - 1.0 ) = 1.0

define "Negate1CM":
  - ( 1 'cm' ) = - 1.0 'cm'

define "PrecisionDecimal":
  Precision(1.58700)= 5

define "PrecisionYear":
  Precision(@2014)= 4

define "PrecisionDateTimeMilliseconds":
  Precision(@2014-01-05T10:30:00.000)= 17

define "PrecisionTimeMinutes":
  Precision(@T10:30)= 4

define "PrecisionTimeMilliseconds":
  Precision(@T10:30:00.000)= 9

define "PredecessorNull":
  predecessor of ( null as Integer ) = null

define "PredecessorOf0":
  predecessor of 0 = - 1

define "PredecessorOf1":
  predecessor of 1 = 0

define "PredecessorOf1D":
  predecessor of 1.0 = 0.99999999

define "PredecessorOf101D":
  predecessor of 1.01 = 1.00999999

define "PredecessorOf1QCM":
  predecessor of 1.0 'cm' = 0.99999999 'cm'

define "PredecessorOfJan12000":
  predecessor of DateTime(2000, 1, 1)= @1999-12-31

define "PredecessorOfNoon":
  predecessor of @T12:00:00.000 = @T11:59:59.999

define "PredecessorUnderflowDt":
  predecessor of DateTime(0001, 1, 1, 0, 0, 0, 0)

define "PredecessorUnderflowT":
  predecessor of @T00:00:00.000

define "PowerNullToNull":
  Power(null as Integer, null as Integer)= null

define "Power0To0":
  Power(0, 0)= 1

define "Power2To2":
  Power(2, 2)= 4

define "PowerNeg2To2":
  Power(- 2, 2)= 4

define "Power2ToNeg2":
  Power(2.0, - 2.0)= 0.25

define "Power2DTo2D":
  Power(2.0, 2.0)= 4.0

define "PowerNeg2DTo2D":
  Power(- 2.0, 2.0)= 4.0

define "Power2DToNeg2D":
  Power(2.0, - 2.0)= 0.25

define "Power2DTo2":
  Power(2.0, 2)= 4.0

define "Power2To2D":
  Power(2, 2.0)= 4.0

define "Power2To4":
  2 ^ 4 = 16

define "Power2DTo4D":
  2.0 ^ 4.0 = 16.0

define "Power2DToNeg2DEquivalence":
  Power(2.0, - 2.0)~ 0.25 = true

define "RoundNull":
  Round(null as Decimal)= null

define "Round1":
  Round(1)= 1.0

define "Round0D5":
  Round(0.5)= 1.0

define "Round0D4":
  Round(0.4)= 0.0

define "Round3D14159":
  Round(3.14159, 2)= 3.14

define "RoundNeg0D5":
  Round(- 0.5)= 0.0

define "RoundNeg0D4":
  Round(- 0.4)= 0.0

define "RoundNeg0D6":
  Round(- 0.6)= - 1.0

define "RoundNeg1D1":
  Round(- 1.1)= - 1.0

define "RoundNeg1D5":
  Round(- 1.5)= - 1.0

define "RoundNeg1D6":
  Round(- 1.6)= - 2.0

define "SubtractNull":
  1 - null = null

define "Subtract1And1":
  1 - 1 = 0

define "Subtract1DAnd2D":
  1.0 - 2.0 = - 1.0

define "Subtract1CMAnd2CM":
  1.0 'cm' - 2.0 'cm' = - 1.0 'cm'

define "Subtract2And11D":
  2 - 1.1 = 0.9

define "SuccessorNull":
  successor of ( null as Integer ) = null

define "SuccessorOf0":
  successor of 0 = 1

define "SuccessorOf1":
  successor of 1 = 2

define "SuccessorOf1D":
  successor of 1.0 = 1.00000001

define "SuccessorOf101D":
  successor of 1.01 = 1.01000001

define "SuccessorOfJan12000":
  successor of DateTime(2000, 1, 1)= @2000-01-02

define "SuccessorOfNoon":
  successor of @T12:00:00.000 = @T12:00:00.001

define "SuccessorOverflowDt":
  successor of DateTime(9999, 12, 31, 23, 59, 59, 999)

define "SuccessorOverflowT":
  successor of @T23:59:59.999

define "TruncateNull":
  Truncate(null as Decimal)= null

define "Truncate0":
  Truncate(0)= 0

define "Truncate0D0":
  Truncate(0.0)= 0

define "Truncate0D1":
  Truncate(0.1)= 0

define "Truncate1":
  Truncate(1)= 1

define "Truncate1D0":
  Truncate(1.0)= 1

define "Truncate1D1":
  Truncate(1.1)= 1

define "Truncate1D9":
  Truncate(1.9)= 1

define "TruncateNeg1":
  Truncate(- 1)= - 1

define "TruncateNeg1D0":
  Truncate(- 1.0)= - 1

define "TruncateNeg1D1":
  Truncate(- 1.1)= - 1

define "TruncateNeg1D9":
  Truncate(- 1.9)= - 1

define "TruncatedDivideNull":
  ( null as Integer ) div ( null as Integer ) = null

define "TruncatedDivide2By1":
  2 div 1 = 2

define "TruncatedDivide10By3":
  10 div 3 = 3

define "TruncatedDivide10d1By3D1":
  10.1 div 3.1 = 3.0

define "TruncatedDivideNeg2ByNeg1":
  - 2 div - 1 = 2

define "TruncatedDivideNeg10ByNeg3":
  - 10 div - 3 = 3

define "TruncatedDivideNeg10d1ByNeg3D1":
  - 10.1 div - 3.1 = 3.0

define "TruncatedDivideNeg2By1":
  - 2 div 1 = - 2

define "TruncatedDivideNeg10By3":
  - 10 div 3 = - 3

define "TruncatedDivideNeg10d1By3D1":
  - 10.1 div 3.1 = - 3.0

define "TruncatedDivide2ByNeg1":
  2 div - 1 = - 2

define "TruncatedDivide10ByNeg3":
  10 div - 3 = - 3

define "TruncatedDivide10d1ByNeg3D1":
  10.1 div - 3.1 = - 3.0

define "TruncatedDivide10By5D":
  10 div 5.0 = 2.0