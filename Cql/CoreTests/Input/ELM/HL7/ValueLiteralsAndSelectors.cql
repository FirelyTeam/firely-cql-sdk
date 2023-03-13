library ValueLiteralsAndSelectors version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

context Patient

define "Null":
  ( null ) = @2000 < @2000-01

define "BooleanFalse":
  ( false ) = ( 1 ~ 0 )

define "BooleanTrue":
  ( true ) = ( 1 ~ 1 )

define "IntegerZero":
  ( 0 ) = 42 - 42

define "IntegerPosZero":
  ( + 0 ) = 42 - 42

define "IntegerNegZero":
  ( - 0 ) = 42 - 42

define "IntegerOne":
  ( 1 ) = 42 - 41

define "IntegerPosOne":
  ( + 1 ) = 42 - 41

define "IntegerNegOne":
  ( - 1 ) = 42 - 43

define "IntegerTwo":
  ( 2 ) = 42 - 40

define "IntegerPosTwo":
  ( + 2 ) = 42 - 40

define "IntegerNegTwo":
  ( - 2 ) = 42 - 44

define "Integer10Pow9":
  ( 1000000000 ) = Power(10, 9)

define "IntegerPos10Pow9":
  ( + 1000000000 ) = + Power(10, 9)

define "IntegerNeg10Pow9":
  ( - 1000000000 ) = - Power(10, 9)

define "Integer2Pow31ToZero1IntegerMaxValue":
  ( 2147483647 ) = Power(2, 30)- 1 + Power(2, 30)

define "IntegerPos2Pow31ToZero1IntegerMaxValue":
  ( + 2147483647 ) = + Power(2, 30)- 1 + Power(2, 30)

define "IntegerNeg2Pow31ToZero1":
  ( - 2147483647 ) = - Power(2, 30)+ 1 - Power(2, 30)

define "Integer2Pow31":
  2147483648

define "IntegerPos2Pow31":
  + 2147483648

define "IntegerNeg2Pow31IntegerMinValue":
  ( - 2147483648 ) = - Power(2, 30)- Power(2, 30)

define "Integer2Pow31ToInf1":
  2147483649

define "IntegerPos2Pow31ToInf1":
  + 2147483649

define "IntegerNeg2Pow31ToInf1":
  - 2147483649

define "DecimalZero":
  ( 0.0 ) = 42.0 - 42.0

define "DecimalPosZero":
  ( + 0.0 ) = 42.0 - 42.0

define "DecimalNegZero":
  ( - 0.0 ) = 42.0 - 42.0

define "DecimalOne":
  ( 1.0 ) = 42.0 - 41.0

define "DecimalPosOne":
  ( + 1.0 ) = 42.0 - 41.0

define "DecimalNegOne":
  ( - 1.0 ) = 42.0 - 43.0

define "DecimalTwo":
  ( 2.0 ) = 42.0 - 40.0

define "DecimalPosTwo":
  ( + 2.0 ) = 42.0 - 40.0

define "DecimalNegTwo":
  ( - 2.0 ) = 42.0 - 44.0

define "Decimal10Pow9":
  ( 1000000000.0 ) = Power(10.0, 9.0)

define "DecimalPos10Pow9":
  ( + 1000000000.0 ) = + Power(10.0, 9.0)

define "DecimalNeg10Pow9":
  ( - 1000000000.0 ) = - Power(10.0, 9.0)

define "Decimal2Pow31ToZero1":
  ( 2147483647.0 ) = Power(2.0, 30.0)- 1 + Power(2.0, 30.0)

define "DecimalPos2Pow31ToZero1":
  ( + 2147483647.0 ) = + Power(2.0, 30.0)- 1 + Power(2.0, 30.0)

define "DecimalNeg2Pow31ToZero1":
  ( - 2147483647.0 ) = - Power(2.0, 30.0)+ 1.0 - Power(2.0, 30.0)

define "Decimal2Pow31":
  ( 2147483648.0 ) = Power(2.0, 30.0)+ Power(2.0, 30.0)

define "DecimalPos2Pow31":
  ( + 2147483648.0 ) = + Power(2.0, 30.0)+ Power(2.0, 30.0)

define "DecimalNeg2Pow31":
  ( - 2147483648.0 ) = - Power(2.0, 30.0)- Power(2.0, 30.0)

define "Decimal2Pow31ToInf1":
  ( 2147483649.0 ) = Power(2.0, 30.0)+ 1.0 + Power(2.0, 30.0)

define "DecimalPos2Pow31ToInf1":
  ( + 2147483649.0 ) = + Power(2.0, 30.0)+ 1.0 + Power(2.0, 30.0)

define "DecimalNeg2Pow31ToInf1":
  ( - 2147483649.0 ) = - Power(2.0, 30.0)- 1.0 - Power(2.0, 30.0)

define "DecimalZeroStep":
  ( 0.00000000 ) = 42.0 - 42.0

define "DecimalPosZeroStep":
  ( + 0.00000000 ) = 42.0 - 42.0

define "DecimalNegZeroStep":
  ( - 0.00000000 ) = 42.0 - 42.0

define "DecimalOneStep":
  ( 0.00000001 ) = Power(10.0, - 8)

define "DecimalPosOneStep":
  ( + 0.00000001 ) = + Power(10.0, - 8)

define "DecimalNegOneStep":
  ( - 0.00000001 ) = - Power(10.0, - 8)

define "DecimalTwoStep":
  ( 0.00000002 ) = 2.0 * Power(10.0, - 8)

define "DecimalPosTwoStep":
  ( + 0.00000002 ) = + 2.0 * Power(10.0, - 8)

define "DecimalNegTwoStep":
  ( - 0.00000002 ) = - 2.0 * Power(10.0, - 8)

define "DecimalTenStep":
  ( 0.0000001 ) = Power(10.0, - 7)

define "DecimalPosTenStep":
  ( + 0.0000001 ) = + Power(10.0, - 7)

define "DecimalNegTenStep":
  ( - 0.0000001 ) = - Power(10.0, - 7)

define "DecimalTenthStep":
  0.000000001

define "DecimalPosTenthStep":
  + 0.000000001

define "DecimalNegTenthStep":
  - 0.000000001

define "Decimal10Pow28ToZeroOneStepDecimalMaxValue":
  ( 9999999999999999999999999999.99999999 ) = 10 * 1000000000000000000000000000.00000000 - 0.00000001

define "DecimalPos10Pow28ToZeroOneStepDecimalMaxValue":
  ( + 9999999999999999999999999999.99999999 ) = + 10 * 1000000000000000000000000000.00000000 - 0.00000001

define "DecimalNeg10Pow28ToZeroOneStepDecimalMinValue":
  ( - 9999999999999999999999999999.99999999 ) = - 10 * 1000000000000000000000000000.00000000 + 0.00000001

define "Decimal10Pow28":
  10000000000000000000000000000.00000000

define "DecimalPos10Pow28":
  + 10000000000000000000000000000.00000000

define "DecimalNeg10Pow28":
  - 10000000000000000000000000000.00000000