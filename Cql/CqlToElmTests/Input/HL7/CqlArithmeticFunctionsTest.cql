library CqlArithmeticFunctionsTest

context Unfiltered


define "AbsNull Input":
	Abs(null as Integer)
define "AbsNull Output":
	null

define "Abs0 Input":
	Abs(0)
define "Abs0 Output":
	0

define "AbsNeg1 Input":
	Abs(-1)
define "AbsNeg1 Output":
	1

define "AbsNeg1Dec Input":
	Abs(-1.0)
define "AbsNeg1Dec Output":
	1.0

define "Abs0Dec Input":
	Abs(0.0)
define "Abs0Dec Output":
	0.0

define "Abs1cm Input":
	Abs(-1.0'cm')
define "Abs1cm Output":
	1.0'cm'

define "AbsLong Input":
	Abs(-1L)
define "AbsLong Output":
	1L

define "AddNull Input":
	1 + null
define "AddNull Output":
	null

define "Add11 Input":
	1 + 1
define "Add11 Output":
	2

define "Add1D1D Input":
	1.0 + 1.0
define "Add1D1D Output":
	2.0

define "Add1Q1Q Input":
	1'g/cm3' + 1'g/cm3'
define "Add1Q1Q Output":
	2.0'g/cm3'

define "AddIAndD Input":
	1 + 2.0
define "AddIAndD Output":
	3.0

define "Add1L1L Input":
	1L + 1L
define "Add1L1L Output":
	2L

define "CeilingNull Input":
	Ceiling(null as Decimal)
define "CeilingNull Output":
	null

define "Ceiling1D Input":
	Ceiling(1.0)
define "Ceiling1D Output":
	1

define "Ceiling1D1 Input":
	Ceiling(1.1)
define "Ceiling1D1 Output":
	2

define "CeilingNegD1 Input":
	Ceiling(-0.1)
define "CeilingNegD1 Output":
	0

define "CeilingNeg1 Input":
	Ceiling(-1.0)
define "CeilingNeg1 Output":
	-1

define "CeilingNeg1D1 Input":
	Ceiling(-1.1)
define "CeilingNeg1D1 Output":
	-1

define "Ceiling1I Input":
	Ceiling(1)
define "Ceiling1I Output":
	1

define "DivideNull Input":
	1 / null
define "DivideNull Output":
	null

define "Divide10 Input":
	1 / 0
define "Divide10 Output":
	null

define "Divide01 Input":
	0 / 1
define "Divide01 Output":
	0.0

define "Divide11 Input":
	1 / 1
define "Divide11 Output":
	1.0

define "Divide1d1d Input":
	1.0 / 1.0
define "Divide1d1d Output":
	1.0

define "Divide103 Input":
	Round(10 / 3, 8)
define "Divide103 Output":
	3.33333333

define "Divide1Q1 Input":
	1'g/cm3' / 1.0
define "Divide1Q1 Output":
	1.0'g/cm3'

define "Divide1Q1Q Input":
	1'g/cm3' / 1'g/cm3'
define "Divide1Q1Q Output":
	1.0'1'

define "Divide10I5D Input":
	10 / 5.0
define "Divide10I5D Output":
	2.0

define "Divide10I5I Input":
	10 / 5
define "Divide10I5I Output":
	2.0

define "Divide10Q5I Input":
	10.0 'g' / 5
define "Divide10Q5I Output":
	2.0'g'

define "FloorNull Input":
	Floor(null as Decimal)
define "FloorNull Output":
	null

define "Floor1 Input":
	Floor(1)
define "Floor1 Output":
	1

define "Floor1D Input":
	Floor(1.0)
define "Floor1D Output":
	1

define "Floor1D1 Input":
	Floor(1.1)
define "Floor1D1 Output":
	1

define "FloorNegD1 Input":
	Floor(-0.1)
define "FloorNegD1 Output":
	-1

define "FloorNeg1 Input":
	Floor(-1.0)
define "FloorNeg1 Output":
	-1

define "FloorNeg1D1 Input":
	Floor(-1.1)
define "FloorNeg1D1 Output":
	-2

define "Floor2I Input":
	Floor(2)
define "Floor2I Output":
	2

define "ExpNull Input":
	Exp(null as Decimal)
define "ExpNull Output":
	null

define "Exp0 Input":
	Exp(0)
define "Exp0 Output":
	1.0

define "ExpNeg0 Input":
	Exp(-0)
define "ExpNeg0 Output":
	1.0

define "Exp1 Input":
	Round(Exp(1), 8)
define "Exp1 Output":
	2.71828183

define "ExpNeg1 Input":
	Round(Exp(-1), 8)
define "ExpNeg1 Output":
	0.36787944

define "Exp1000":
	Exp(1000)

define "Exp1000D":
	Exp(1000.0)

define "HighBoundaryDecimal Input":
	HighBoundary(1.587, 8)
define "HighBoundaryDecimal Output":
	1.58799999

define "HighBoundaryDateMonth Input":
	HighBoundary(@2014, 6)
define "HighBoundaryDateMonth Output":
	@2014-12

define "HighBoundaryDateTimeMillisecond Input":
	HighBoundary(@2014-01-01T08, 17)
define "HighBoundaryDateTimeMillisecond Output":
	@2014-01-01T08:59:59.999

define "HighBoundaryTimeMillisecond Input":
	HighBoundary(@T10:30, 9)
define "HighBoundaryTimeMillisecond Output":
	@T10:30:59.999

define "LogNullNull Input":
	Log(null, null)
define "LogNullNull Output":
	null

define "Log1BaseNull Input":
	Log(1, null)
define "Log1BaseNull Output":
	null

define "Log1Base1 Input":
	Log(1, 1)
define "Log1Base1 Output":
	null

define "Log1Base2 Input":
	Log(1, 2)
define "Log1Base2 Output":
	0.0

define "Log1Base100 Input":
	Log(1, 100)
define "Log1Base100 Output":
	0.0

define "Log16Base2 Input":
	Log(16, 2)
define "Log16Base2 Output":
	4.0

define "LogD125Base2 Input":
	Log(0.125, 2)
define "LogD125Base2 Output":
	-3.0

define "LowBoundaryDecimal Input":
	LowBoundary(1.587, 8)
define "LowBoundaryDecimal Output":
	1.58700000

define "LowBoundaryDateMonth Input":
	LowBoundary(@2014, 6)
define "LowBoundaryDateMonth Output":
	@2014-01

define "LowBoundaryDateTimeMillisecond Input":
	LowBoundary(@2014-01-01T08, 17)
define "LowBoundaryDateTimeMillisecond Output":
	@2014-01-01T08:00:00.000

define "LowBoundaryTimeMillisecond Input":
	LowBoundary(@T10:30, 9)
define "LowBoundaryTimeMillisecond Output":
	@T10:30:00.000

define "LnNull Input":
	Ln(null)
define "LnNull Output":
	null

define "Ln0":
	Ln(0)

define "LnNeg0":
	Ln(-0)

define "Ln1 Input":
	Ln(1)
define "Ln1 Output":
	0.0

define "LnNeg1 Input":
	Ln(-1)
define "LnNeg1 Output":
	null

define "Ln1000 Input":
	Round(Ln(1000), 8)
define "Ln1000 Output":
	6.90775528

define "Ln1000D Input":
	Round(Ln(1000.0), 8)
define "Ln1000D Output":
	6.90775528

define "IntegerMinValue Input":
	minimum Integer
define "IntegerMinValue Output":
	-2147483648

define "LongMinValue Input":
	minimum Long
define "LongMinValue Output":
	-9223372036854775808L

define "DecimalMinValue Input":
	minimum Decimal
define "DecimalMinValue Output":
	-99999999999999999999.99999999

define "DateTimeMinValue Input":
	minimum DateTime
define "DateTimeMinValue Output":
	@0001-01-01T00:00:00.000Z

define "DateMinValue Input":
	minimum Date
define "DateMinValue Output":
	@0001-01-01

define "TimeMinValue Input":
	minimum Time
define "TimeMinValue Output":
	@T00:00:00.000

define "IntegerMaxValue Input":
	maximum Integer
define "IntegerMaxValue Output":
	2147483647

define "LongMaxValue Input":
	maximum Long
define "LongMaxValue Output":
	9223372036854775807L

define "DecimalMaxValue Input":
	maximum Decimal
define "DecimalMaxValue Output":
	99999999999999999999.99999999

define "DateTimeMaxValue Input":
	maximum DateTime
define "DateTimeMaxValue Output":
	@9999-12-31T23:59:59.999Z

define "DateMaxValue Input":
	maximum Date
define "DateMaxValue Output":
	@9999-12-31

define "TimeMaxValue Input":
	maximum Time
define "TimeMaxValue Output":
	@T23:59:59.999

define "ModuloNull Input":
	1 mod null
define "ModuloNull Output":
	null

define "Modulo0By0 Input":
	0 mod 0
define "Modulo0By0 Output":
	null

define "Modulo4By2 Input":
	4 mod 2
define "Modulo4By2 Output":
	0

define "Modulo4LBy2L Input":
	4L mod 2L
define "Modulo4LBy2L Output":
	0L

define "Modulo4DBy2D Input":
	4.0 mod 2.0
define "Modulo4DBy2D Output":
	0.0

define "Modulo10By3 Input":
	10 mod 3
define "Modulo10By3 Output":
	1

define "Modulo10DBy3D Input":
	10.0 mod 3.0
define "Modulo10DBy3D Output":
	1.0

define "Modulo10IBy3D Input":
	10 mod 3.0
define "Modulo10IBy3D Output":
	1.0

define "ModuloDResult Input":
	3.5 mod 3
define "ModuloDResult Output":
	0.5

define "ModuloQuantity Input":
	3.5 'cm' mod 3 'cm'
define "ModuloQuantity Output":
	0.5 'cm'

define "MultiplyNull Input":
	1 * null
define "MultiplyNull Output":
	null

define "Multiply1By1 Input":
	1 * 1
define "Multiply1By1 Output":
	1

define "Multiply1DBy2D Input":
	1.0 * 2.0
define "Multiply1DBy2D Output":
	2.0

define "Multiply1By1L Input":
	1 * 1L
define "Multiply1By1L Output":
	1L

define "Multiply1IBy2D Input":
	1 * 2.0
define "Multiply1IBy2D Output":
	2.0

define "Multiply1CMBy2CM Input":
	1.0 'cm' * 2.0 'cm'
define "Multiply1CMBy2CM Output":
	2.0'cm2'

define "NegateNull Input":
	-(null as Integer)
define "NegateNull Output":
	null

define "Negate0 Input":
	-0
define "Negate0 Output":
	0

define "NegateNeg0 Input":
	-(-0)
define "NegateNeg0 Output":
	0

define "Negate1 Input":
	-1
define "Negate1 Output":
	-1

define "NegateNeg1 Input":
	-(-1)
define "NegateNeg1 Output":
	1

define "NegateNeg1L Input":
	-(-1L)
define "NegateNeg1L Output":
	1L

define "Negate0D Input":
	-(0.0)
define "Negate0D Output":
	0.0

define "NegateNeg0D Input":
	-(-0.0)
define "NegateNeg0D Output":
	0.0

define "Negate1D Input":
	-(1.0)
define "Negate1D Output":
	-1.0

define "NegateNeg1D Input":
	-(-1.0)
define "NegateNeg1D Output":
	1.0

define "Negate1CM Input":
	-(1'cm')
define "Negate1CM Output":
	-1.0'cm'

define "PrecisionDecimal Input":
	Precision(1.58700)
define "PrecisionDecimal Output":
	5

define "PrecisionYear Input":
	Precision(@2014)
define "PrecisionYear Output":
	4

define "PrecisionDateTimeMilliseconds Input":
	Precision(@2014-01-05T10:30:00.000)
define "PrecisionDateTimeMilliseconds Output":
	17

define "PrecisionTimeMinutes Input":
	Precision(@T10:30)
define "PrecisionTimeMinutes Output":
	4

define "PrecisionTimeMilliseconds Input":
	Precision(@T10:30:00.000)
define "PrecisionTimeMilliseconds Output":
	9

define "PredecessorNull Input":
	predecessor of (null as Integer)
define "PredecessorNull Output":
	null

define "PredecessorOf0 Input":
	predecessor of 0
define "PredecessorOf0 Output":
	-1

define "PredecessorOf1 Input":
	predecessor of 1
define "PredecessorOf1 Output":
	0

define "PredecessorOf1L Input":
	predecessor of 1L
define "PredecessorOf1L Output":
	0L

define "PredecessorOf1D Input":
	predecessor of 1.0
define "PredecessorOf1D Output":
	0.99999999

define "PredecessorOf101D Input":
	predecessor of 1.01
define "PredecessorOf101D Output":
	1.00999999

define "PredecessorOf1QCM Input":
	predecessor of 1.0 'cm'
define "PredecessorOf1QCM Output":
	0.99999999'cm'

define "PredecessorOfJan12000 Input":
	predecessor of DateTime(2000,1,1)
define "PredecessorOfJan12000 Output":
	@1999-12-31T

define "PredecessorOfNoon Input":
	predecessor of @T12:00:00.000
define "PredecessorOfNoon Output":
	@T11:59:59.999

define "PredecessorUnderflowDt":
	predecessor of DateTime(0001, 1, 1, 0, 0, 0, 0)

define "PredecessorUnderflowT":
	predecessor of @T00:00:00.000

define "PowerNullToNull Input":
	Power(null as Integer, null as Integer)
define "PowerNullToNull Output":
	null

define "Power0To0 Input":
	Power(0, 0)
define "Power0To0 Output":
	1

define "Power2To2 Input":
	Power(2, 2)
define "Power2To2 Output":
	4

define "PowerNeg2To2 Input":
	Power(-2, 2)
define "PowerNeg2To2 Output":
	4

define "Power2ToNeg2 Input":
	Power(2, -2)
define "Power2ToNeg2 Output":
	0.25

define "Power2LTo2L Input":
	Power(2L, 2L)
define "Power2LTo2L Output":
	4L

define "Power2DTo2D Input":
	Power(2.0, 2.0)
define "Power2DTo2D Output":
	4.0

define "PowerNeg2DTo2D Input":
	Power(-2.0, 2.0)
define "PowerNeg2DTo2D Output":
	4.0

define "Power2DToNeg2D Input":
	Power(2.0, -2.0)
define "Power2DToNeg2D Output":
	0.25

define "Power2DTo2 Input":
	Power(2.0, 2)
define "Power2DTo2 Output":
	4.0

define "Power2To2D Input":
	Power(2, 2.0)
define "Power2To2D Output":
	4.0

define "Power2To4 Input":
	2^4
define "Power2To4 Output":
	16

define "Power2DTo4D Input":
	2.0^4.0
define "Power2DTo4D Output":
	16.0

define "Power2DToNeg2DEquivalence Input":
	Power(2, -2) ~ 0.25
define "Power2DToNeg2DEquivalence Output":
	true

define "RoundNull Input":
	Round(null as Decimal)
define "RoundNull Output":
	null

define "Round1 Input":
	Round(1)
define "Round1 Output":
	1.0

define "Round0D5 Input":
	Round(0.5)
define "Round0D5 Output":
	1.0

define "Round0D4 Input":
	Round(0.4)
define "Round0D4 Output":
	0.0

define "Round3D14159 Input":
	Round(3.14159, 2)
define "Round3D14159 Output":
	3.14

define "RoundNeg0D5 Input":
	Round(-0.5)
define "RoundNeg0D5 Output":
	0.0

define "RoundNeg0D4 Input":
	Round(-0.4)
define "RoundNeg0D4 Output":
	0.0

define "RoundNeg0D6 Input":
	Round(-0.6)
define "RoundNeg0D6 Output":
	-1.0

define "RoundNeg1D1 Input":
	Round(-1.1)
define "RoundNeg1D1 Output":
	-1.0

define "RoundNeg1D5 Input":
	Round(-1.5)
define "RoundNeg1D5 Output":
	-1.0

define "RoundNeg1D6 Input":
	Round(-1.6)
define "RoundNeg1D6 Output":
	-2.0

define "SubtractNull Input":
	1 - null
define "SubtractNull Output":
	null

define "Subtract1And1 Input":
	1 - 1
define "Subtract1And1 Output":
	0

define "Subtract1LAnd1L Input":
	1L - 1L
define "Subtract1LAnd1L Output":
	0L

define "Subtract1DAnd2D Input":
	1.0 - 2.0
define "Subtract1DAnd2D Output":
	-1.0

define "Subtract1CMAnd2CM Input":
	1.0 'cm' - 2.0 'cm'
define "Subtract1CMAnd2CM Output":
	-1.0'cm'

define "Subtract2And11D Input":
	2 - 1.1
define "Subtract2And11D Output":
	0.9

define "SuccessorNull Input":
	successor of (null as Integer)
define "SuccessorNull Output":
	null

define "SuccessorOf0 Input":
	successor of 0
define "SuccessorOf0 Output":
	1

define "SuccessorOf1 Input":
	successor of 1
define "SuccessorOf1 Output":
	2

define "SuccessorOf1L Input":
	successor of 1L
define "SuccessorOf1L Output":
	2L

define "SuccessorOf1D Input":
	successor of 1.0
define "SuccessorOf1D Output":
	1.00000001

define "SuccessorOf101D Input":
	successor of 1.01
define "SuccessorOf101D Output":
	1.01000001

define "SuccessorOfJan12000 Input":
	successor of DateTime(2000,1,1)
define "SuccessorOfJan12000 Output":
	@2000-01-02T

define "SuccessorOfNoon Input":
	successor of @T12:00:00.000
define "SuccessorOfNoon Output":
	@T12:00:00.001

define "SuccessorOverflowDt":
	successor of DateTime(9999, 12, 31, 23, 59, 59, 999)

define "SuccessorOverflowT":
	successor of @T23:59:59.999

define "TruncateNull Input":
	Truncate(null as Decimal)
define "TruncateNull Output":
	null

define "Truncate0 Input":
	Truncate(0)
define "Truncate0 Output":
	0

define "Truncate0D0 Input":
	Truncate(0.0)
define "Truncate0D0 Output":
	0

define "Truncate0D1 Input":
	Truncate(0.1)
define "Truncate0D1 Output":
	0

define "Truncate1 Input":
	Truncate(1)
define "Truncate1 Output":
	1

define "Truncate1D0 Input":
	Truncate(1.0)
define "Truncate1D0 Output":
	1

define "Truncate1D1 Input":
	Truncate(1.1)
define "Truncate1D1 Output":
	1

define "Truncate1D9 Input":
	Truncate(1.9)
define "Truncate1D9 Output":
	1

define "TruncateNeg1 Input":
	Truncate(-1)
define "TruncateNeg1 Output":
	-1

define "TruncateNeg1D0 Input":
	Truncate(-1.0)
define "TruncateNeg1D0 Output":
	-1

define "TruncateNeg1D1 Input":
	Truncate(-1.1)
define "TruncateNeg1D1 Output":
	-1

define "TruncateNeg1D9 Input":
	Truncate(-1.9)
define "TruncateNeg1D9 Output":
	-1

define "TruncatedDivideNull Input":
	(null as Integer) div (null as Integer)
define "TruncatedDivideNull Output":
	null

define "TruncatedDivide2By1 Input":
	2 div 1
define "TruncatedDivide2By1 Output":
	2

define "TruncatedDivide10By3 Input":
	10 div 3
define "TruncatedDivide10By3 Output":
	3

define "TruncatedDivide10LBy3L Input":
	10L div 3L
define "TruncatedDivide10LBy3L Output":
	3L

define "TruncatedDivide10d1By3D1 Input":
	10.1 div 3.1
define "TruncatedDivide10d1By3D1 Output":
	3.0

define "TruncatedDivideNeg2ByNeg1 Input":
	-2 div -1
define "TruncatedDivideNeg2ByNeg1 Output":
	2

define "TruncatedDivideNeg10ByNeg3 Input":
	-10 div -3
define "TruncatedDivideNeg10ByNeg3 Output":
	3

define "TruncatedDivideNeg10d1ByNeg3D1 Input":
	-10.1 div -3.1
define "TruncatedDivideNeg10d1ByNeg3D1 Output":
	3.0

define "TruncatedDivideNeg2By1 Input":
	-2 div 1
define "TruncatedDivideNeg2By1 Output":
	-2

define "TruncatedDivideNeg10By3 Input":
	-10 div 3
define "TruncatedDivideNeg10By3 Output":
	-3

define "TruncatedDivideNeg10d1By3D1 Input":
	-10.1 div 3.1
define "TruncatedDivideNeg10d1By3D1 Output":
	-3.0

define "TruncatedDivide2ByNeg1 Input":
	2 div -1
define "TruncatedDivide2ByNeg1 Output":
	-2

define "TruncatedDivide10ByNeg3 Input":
	10 div -3
define "TruncatedDivide10ByNeg3 Output":
	-3

define "TruncatedDivide10d1ByNeg3D1 Input":
	10.1 div -3.1
define "TruncatedDivide10d1ByNeg3D1 Output":
	-3.0

define "TruncatedDivide10By5D Input":
	10 div 5.0
define "TruncatedDivide10By5D Output":
	2.0

define "TruncatedDivide10d1ByNeg3D1Quantity Input":
	10.1 'cm' div -3.1 'cm'
define "TruncatedDivide10d1ByNeg3D1Quantity Output":
	-3.0 'cm'
