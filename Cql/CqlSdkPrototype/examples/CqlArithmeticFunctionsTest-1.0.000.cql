library CqlArithmeticFunctionsTest version '1.0.000'

define "Abs.AbsNull": Abs(null as Integer)

define "Abs.Abs0": Abs(0)

define "Abs.AbsNeg1": Abs(-1)

define "Abs.AbsNeg1Dec": Abs(-1.0)

define "Abs.Abs0Dec": Abs(0.0)

define "Abs.Abs1cm": Abs(-1.0'cm')

define "Abs.AbsLong": Abs(-1L)

define "Add.AddNull": 1 + null

define "Add.Add11": 1 + 1

define "Add.Add1D1D": 1.0 + 1.0

define "Add.Add1Q1Q": 1'g/cm3' + 1'g/cm3'

define "Add.AddIAndD": 1 + 2.0

define "Add.Add1L1L": 1L + 1L

define "Ceiling.CeilingNull": Ceiling(null as Decimal)

define "Ceiling.Ceiling1D": Ceiling(1.0)

define "Ceiling.Ceiling1D1": Ceiling(1.1)

define "Ceiling.CeilingNegD1": Ceiling(-0.1)

define "Ceiling.CeilingNeg1": Ceiling(-1.0)

define "Ceiling.CeilingNeg1D1": Ceiling(-1.1)

define "Ceiling.Ceiling1I": Ceiling(1)

define "Divide.DivideNull": 1 / null

define "Divide.Divide10": 1 / 0

define "Divide.Divide01": 0 / 1

define "Divide.Divide11": 1 / 1

define "Divide.Divide1d1d": 1.0 / 1.0

define "Divide.Divide103": Round(10 / 3, 8)

define "Divide.Divide1Q1": 1'g/cm3' / 1.0

define "Divide.Divide1Q1Q": 1'g/cm3' / 1'g/cm3'

define "Divide.Divide10I5D": 10 / 5.0

define "Divide.Divide10I5I": 10 / 5

define "Divide.Divide10Q5I": 10.0 'g' / 5

define "Floor.FloorNull": Floor(null as Decimal)

define "Floor.Floor1": Floor(1)

define "Floor.Floor1D": Floor(1.0)

define "Floor.Floor1D1": Floor(1.1)

define "Floor.FloorNegD1": Floor(-0.1)

define "Floor.FloorNeg1": Floor(-1.0)

define "Floor.FloorNeg1D1": Floor(-1.1)

define "Floor.Floor2I": Floor(2)

define "Exp.ExpNull": Exp(null as Decimal)

define "Exp.Exp0": Exp(0)

define "Exp.ExpNeg0": Exp(-0)

define "Exp.Exp1": Round(Exp(1), 8)

define "Exp.ExpNeg1": Round(Exp(-1), 8)

define "Exp.Exp1000": Exp(1000)

define "Exp.Exp1000D": Exp(1000.0)

define "HighBoundary.HighBoundaryDecimal": HighBoundary(1.587, 8)

define "HighBoundary.HighBoundaryDateMonth": HighBoundary(@2014, 6)

define "HighBoundary.HighBoundaryDateTimeMillisecond": HighBoundary(@2014-01-01T08, 17)

define "HighBoundary.HighBoundaryTimeMillisecond": HighBoundary(@T10:30, 9)

define "Log.LogNullNull": Log(null, null)

define "Log.Log1BaseNull": Log(1, null)

define "Log.Log1Base1": Log(1, 1)

define "Log.Log1Base2": Log(1, 2)

define "Log.Log1Base100": Log(1, 100)

define "Log.Log16Base2": Log(16, 2)

define "Log.LogD125Base2": Log(0.125, 2)

define "LowBoundary.LowBoundaryDecimal": LowBoundary(1.587, 8)

define "LowBoundary.LowBoundaryDateMonth": LowBoundary(@2014, 6)

define "LowBoundary.LowBoundaryDateTimeMillisecond": LowBoundary(@2014-01-01T08, 17)

define "LowBoundary.LowBoundaryTimeMillisecond": LowBoundary(@T10:30, 9)

define "Ln.LnNull": Ln(null)

define "Ln.Ln0": Ln(0)

define "Ln.LnNeg0": Ln(-0)

define "Ln.Ln1": Ln(1)

define "Ln.LnNeg1": Ln(-1)

define "Ln.Ln1000": Round(Ln(1000), 8)

define "Ln.Ln1000D": Round(Ln(1000.0), 8)

define "MinValue.IntegerMinValue": minimum Integer

define "MinValue.LongMinValue": minimum Long

define "MinValue.DecimalMinValue": minimum Decimal

define "MinValue.DateTimeMinValue": minimum DateTime

define "MinValue.DateMinValue": minimum Date

define "MinValue.TimeMinValue": minimum Time

define "MaxValue.IntegerMaxValue": maximum Integer

define "MaxValue.LongMaxValue": maximum Long

define "MaxValue.DecimalMaxValue": maximum Decimal

define "MaxValue.DateTimeMaxValue": maximum DateTime

define "MaxValue.DateMaxValue": maximum Date

define "MaxValue.TimeMaxValue": maximum Time

define "Modulo.ModuloNull": 1 mod null

define "Modulo.Modulo0By0": 0 mod 0

define "Modulo.Modulo4By2": 4 mod 2

define "Modulo.Modulo4LBy2L": 4L mod 2L

define "Modulo.Modulo4DBy2D": 4.0 mod 2.0

define "Modulo.Modulo10By3": 10 mod 3

define "Modulo.Modulo10DBy3D": 10.0 mod 3.0

define "Modulo.Modulo10IBy3D": 10 mod 3.0

define "Modulo.ModuloDResult": 3.5 mod 3

define "Modulo.ModuloQuantity": 3.5 'cm' mod 3 'cm'

define "Multiply.MultiplyNull": 1 * null

define "Multiply.Multiply1By1": 1 * 1

define "Multiply.Multiply1DBy2D": 1.0 * 2.0

define "Multiply.Multiply1By1L": 1 * 1L

define "Multiply.Multiply1IBy2D": 1 * 2.0

define "Multiply.Multiply1CMBy2CM": 1.0 'cm' * 2.0 'cm'

define "Negate.NegateNull": -(null as Integer)

define "Negate.Negate0": -0

define "Negate.NegateNeg0": -(-0)

define "Negate.Negate1": -1

define "Negate.NegateNeg1": -(-1)

define "Negate.NegateNeg1L": -(-1L)

define "Negate.Negate0D": -(0.0)

define "Negate.NegateNeg0D": -(-0.0)

define "Negate.Negate1D": -(1.0)

define "Negate.NegateNeg1D": -(-1.0)

define "Negate.Negate1CM": -(1'cm')

define "Precision.PrecisionDecimal": Precision(1.58700)

define "Precision.PrecisionYear": Precision(@2014)

define "Precision.PrecisionDateTimeMilliseconds": Precision(@2014-01-05T10:30:00.000)

define "Precision.PrecisionTimeMinutes": Precision(@T10:30)

define "Precision.PrecisionTimeMilliseconds": Precision(@T10:30:00.000)

define "Predecessor.PredecessorNull": predecessor of (null as Integer)

define "Predecessor.PredecessorOf0": predecessor of 0

define "Predecessor.PredecessorOf1": predecessor of 1

define "Predecessor.PredecessorOf1L": predecessor of 1L

define "Predecessor.PredecessorOf1D": predecessor of 1.0

define "Predecessor.PredecessorOf101D": predecessor of 1.01

define "Predecessor.PredecessorOf1QCM": predecessor of 1.0 'cm'

define "Predecessor.PredecessorOfJan12000": predecessor of DateTime(2000,1,1)

define "Predecessor.PredecessorOfNoon": predecessor of @T12:00:00.000

define "Predecessor.PredecessorUnderflowDt": predecessor of DateTime(0001, 1, 1, 0, 0, 0, 0)

define "Predecessor.PredecessorUnderflowT": predecessor of @T00:00:00.000

define "Power.PowerNullToNull": Power(null as Integer, null as Integer)

define "Power.Power0To0": Power(0, 0)

define "Power.Power2To2": Power(2, 2)

define "Power.PowerNeg2To2": Power(-2, 2)

define "Power.Power2ToNeg2": Power(2, -2)

define "Power.Power2LTo2L": Power(2L, 2L)

define "Power.Power2DTo2D": Power(2.0, 2.0)

define "Power.PowerNeg2DTo2D": Power(-2.0, 2.0)

define "Power.Power2DToNeg2D": Power(2.0, -2.0)

define "Power.Power2DTo2": Power(2.0, 2)

define "Power.Power2To2D": Power(2, 2.0)

define "Power.Power2To4": 2^4

define "Power.Power2DTo4D": 2.0^4.0

define "Power.Power2DToNeg2DEquivalence": Power(2, -2) ~ 0.25

define "Round.RoundNull": Round(null as Decimal)

define "Round.Round1": Round(1)

define "Round.Round0D5": Round(0.5)

define "Round.Round0D4": Round(0.4)

define "Round.Round3D14159": Round(3.14159, 2)

define "Round.RoundNeg0D5": Round(-0.5)

define "Round.RoundNeg0D4": Round(-0.4)

define "Round.RoundNeg0D6": Round(-0.6)

define "Round.RoundNeg1D1": Round(-1.1)

define "Round.RoundNeg1D5": Round(-1.5)

define "Round.RoundNeg1D6": Round(-1.6)

define "Subtract.SubtractNull": 1 - null

define "Subtract.Subtract1And1": 1 - 1

define "Subtract.Subtract1LAnd1L": 1L - 1L

define "Subtract.Subtract1DAnd2D": 1.0 - 2.0

define "Subtract.Subtract1CMAnd2CM": 1.0 'cm' - 2.0 'cm'

define "Subtract.Subtract2And11D": 2 - 1.1

define "Successor.SuccessorNull": successor of (null as Integer)

define "Successor.SuccessorOf0": successor of 0

define "Successor.SuccessorOf1": successor of 1

define "Successor.SuccessorOf1L": successor of 1L

define "Successor.SuccessorOf1D": successor of 1.0

define "Successor.SuccessorOf101D": successor of 1.01

define "Successor.SuccessorOfJan12000": successor of DateTime(2000,1,1)

define "Successor.SuccessorOfNoon": successor of @T12:00:00.000

define "Successor.SuccessorOverflowDt": successor of DateTime(9999, 12, 31, 23, 59, 59, 999)

define "Successor.SuccessorOverflowT": successor of @T23:59:59.999

define "Truncate.TruncateNull": Truncate(null as Decimal)

define "Truncate.Truncate0": Truncate(0)

define "Truncate.Truncate0D0": Truncate(0.0)

define "Truncate.Truncate0D1": Truncate(0.1)

define "Truncate.Truncate1": Truncate(1)

define "Truncate.Truncate1D0": Truncate(1.0)

define "Truncate.Truncate1D1": Truncate(1.1)

define "Truncate.Truncate1D9": Truncate(1.9)

define "Truncate.TruncateNeg1": Truncate(-1)

define "Truncate.TruncateNeg1D0": Truncate(-1.0)

define "Truncate.TruncateNeg1D1": Truncate(-1.1)

define "Truncate.TruncateNeg1D9": Truncate(-1.9)

define "Truncated Divide.TruncatedDivideNull": (null as Integer) div (null as Integer)

define "Truncated Divide.TruncatedDivide2By1": 2 div 1

define "Truncated Divide.TruncatedDivide10By3": 10 div 3

define "Truncated Divide.TruncatedDivide10LBy3L": 10L div 3L

define "Truncated Divide.TruncatedDivide10d1By3D1": 10.1 div 3.1

define "Truncated Divide.TruncatedDivideNeg2ByNeg1": -2 div -1

define "Truncated Divide.TruncatedDivideNeg10ByNeg3": -10 div -3

define "Truncated Divide.TruncatedDivideNeg10d1ByNeg3D1": -10.1 div -3.1

define "Truncated Divide.TruncatedDivideNeg2By1": -2 div 1

define "Truncated Divide.TruncatedDivideNeg10By3": -10 div 3

define "Truncated Divide.TruncatedDivideNeg10d1By3D1": -10.1 div 3.1

define "Truncated Divide.TruncatedDivide2ByNeg1": 2 div -1

define "Truncated Divide.TruncatedDivide10ByNeg3": 10 div -3

define "Truncated Divide.TruncatedDivide10d1ByNeg3D1": 10.1 div -3.1

define "Truncated Divide.TruncatedDivide10By5D": 10 div 5.0

define "Truncated Divide.TruncatedDivide10d1ByNeg3D1Quantity": 10.1 'cm' div -3.1 'cm'

