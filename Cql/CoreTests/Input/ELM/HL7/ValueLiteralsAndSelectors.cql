library ValueLiteralsAndSelectors

context Unfiltered


define "Null Input":
	null
define "Null Output":
	@2000 < @2000-01

define "BooleanFalse Input":
	false
define "BooleanFalse Output":
	1~0

define "BooleanTrue Input":
	true
define "BooleanTrue Output":
	1~1

define "IntegerZero Input":
	0
define "IntegerZero Output":
	42-42

define "IntegerPosZero Input":
	+0
define "IntegerPosZero Output":
	42-42

define "IntegerNegZero Input":
	-0
define "IntegerNegZero Output":
	42-42

define "IntegerOne Input":
	1
define "IntegerOne Output":
	42-41

define "IntegerPosOne Input":
	+1
define "IntegerPosOne Output":
	42-41

define "IntegerNegOne Input":
	-1
define "IntegerNegOne Output":
	42-43

define "IntegerTwo Input":
	2
define "IntegerTwo Output":
	42-40

define "IntegerPosTwo Input":
	+2
define "IntegerPosTwo Output":
	42-40

define "IntegerNegTwo Input":
	-2
define "IntegerNegTwo Output":
	42-44

define "Integer10Pow9 Input":
	1000000000
define "Integer10Pow9 Output":
	Power(10,9)

define "IntegerPos10Pow9 Input":
	+1000000000
define "IntegerPos10Pow9 Output":
	+Power(10,9)

define "IntegerNeg10Pow9 Input":
	-1000000000
define "IntegerNeg10Pow9 Output":
	-Power(10,9)

define "Integer2Pow31ToZero1IntegerMaxValue Input":
	2147483647
define "Integer2Pow31ToZero1IntegerMaxValue Output":
	Power(2,30)-1+Power(2,30)

define "IntegerPos2Pow31ToZero1IntegerMaxValue Input":
	+2147483647
define "IntegerPos2Pow31ToZero1IntegerMaxValue Output":
	+Power(2,30)-1+Power(2,30)

define "IntegerNeg2Pow31ToZero1 Input":
	-2147483647
define "IntegerNeg2Pow31ToZero1 Output":
	-Power(2,30)+1-Power(2,30)

define "Integer2Pow31":
	2147483648

define "IntegerPos2Pow31":
	+2147483648

define "IntegerNeg2Pow31IntegerMinValue Input":
	-2147483648
define "IntegerNeg2Pow31IntegerMinValue Output":
	-Power(2,30)-Power(2,30)

define "Integer2Pow31ToInf1":
	2147483649

define "IntegerPos2Pow31ToInf1":
	+2147483649

define "IntegerNeg2Pow31ToInf1":
	-2147483649

define "DecimalZero Input":
	0.0
define "DecimalZero Output":
	42.0-42.0

define "DecimalPosZero Input":
	+0.0
define "DecimalPosZero Output":
	42.0-42.0

define "DecimalNegZero Input":
	-0.0
define "DecimalNegZero Output":
	42.0-42.0

define "DecimalOne Input":
	1.0
define "DecimalOne Output":
	42.0-41.0

define "DecimalPosOne Input":
	+1.0
define "DecimalPosOne Output":
	42.0-41.0

define "DecimalNegOne Input":
	-1.0
define "DecimalNegOne Output":
	42.0-43.0

define "DecimalTwo Input":
	2.0
define "DecimalTwo Output":
	42.0-40.0

define "DecimalPosTwo Input":
	+2.0
define "DecimalPosTwo Output":
	42.0-40.0

define "DecimalNegTwo Input":
	-2.0
define "DecimalNegTwo Output":
	42.0-44.0

define "Decimal10Pow9 Input":
	1000000000.0
define "Decimal10Pow9 Output":
	Power(10.0,9.0)

define "DecimalPos10Pow9 Input":
	+1000000000.0
define "DecimalPos10Pow9 Output":
	+Power(10.0,9.0)

define "DecimalNeg10Pow9 Input":
	-1000000000.0
define "DecimalNeg10Pow9 Output":
	-Power(10.0,9.0)

define "Decimal2Pow31ToZero1 Input":
	2147483647.0
define "Decimal2Pow31ToZero1 Output":
	Power(2.0,30.0)-1+Power(2.0,30.0)

define "DecimalPos2Pow31ToZero1 Input":
	+2147483647.0
define "DecimalPos2Pow31ToZero1 Output":
	+Power(2.0,30.0)-1+Power(2.0,30.0)

define "DecimalNeg2Pow31ToZero1 Input":
	-2147483647.0
define "DecimalNeg2Pow31ToZero1 Output":
	-Power(2.0,30.0)+1.0-Power(2.0,30.0)

define "Decimal2Pow31 Input":
	2147483648.0
define "Decimal2Pow31 Output":
	Power(2.0,30.0)+Power(2.0,30.0)

define "DecimalPos2Pow31 Input":
	+2147483648.0
define "DecimalPos2Pow31 Output":
	+Power(2.0,30.0)+Power(2.0,30.0)

define "DecimalNeg2Pow31 Input":
	-2147483648.0
define "DecimalNeg2Pow31 Output":
	-Power(2.0,30.0)-Power(2.0,30.0)

define "Decimal2Pow31ToInf1 Input":
	2147483649.0
define "Decimal2Pow31ToInf1 Output":
	Power(2.0,30.0)+1.0+Power(2.0,30.0)

define "DecimalPos2Pow31ToInf1 Input":
	+2147483649.0
define "DecimalPos2Pow31ToInf1 Output":
	+Power(2.0,30.0)+1.0+Power(2.0,30.0)

define "DecimalNeg2Pow31ToInf1 Input":
	-2147483649.0
define "DecimalNeg2Pow31ToInf1 Output":
	-Power(2.0,30.0)-1.0-Power(2.0,30.0)

define "DecimalZeroStep Input":
	0.00000000
define "DecimalZeroStep Output":
	42.0-42.0

define "DecimalPosZeroStep Input":
	+0.00000000
define "DecimalPosZeroStep Output":
	42.0-42.0

define "DecimalNegZeroStep Input":
	-0.00000000
define "DecimalNegZeroStep Output":
	42.0-42.0

define "DecimalOneStep Input":
	0.00000001
define "DecimalOneStep Output":
	Power(10,-8)

define "DecimalPosOneStep Input":
	+0.00000001
define "DecimalPosOneStep Output":
	+Power(10,-8)

define "DecimalNegOneStep Input":
	-0.00000001
define "DecimalNegOneStep Output":
	-Power(10,-8)

define "DecimalTwoStep Input":
	0.00000002
define "DecimalTwoStep Output":
	2.0*Power(10,-8)

define "DecimalPosTwoStep Input":
	+0.00000002
define "DecimalPosTwoStep Output":
	+2.0*Power(10,-8)

define "DecimalNegTwoStep Input":
	-0.00000002
define "DecimalNegTwoStep Output":
	-2.0*Power(10,-8)

define "DecimalTenStep Input":
	0.0000001
define "DecimalTenStep Output":
	Power(10,-7)

define "DecimalPosTenStep Input":
	+0.0000001
define "DecimalPosTenStep Output":
	+Power(10,-7)

define "DecimalNegTenStep Input":
	-0.0000001
define "DecimalNegTenStep Output":
	-Power(10,-7)

define "DecimalTenthStep":
	0.000000001

define "DecimalPosTenthStep":
	+0.000000001

define "DecimalNegTenthStep":
	-0.000000001

define "Decimal10Pow28ToZeroOneStepDecimalMaxValue Input":
	9999999999999999999999999999.99999999
define "Decimal10Pow28ToZeroOneStepDecimalMaxValue Output":
	10*1000000000000000000000000000.00000000-0.00000001

define "DecimalPos10Pow28ToZeroOneStepDecimalMaxValue Input":
	+9999999999999999999999999999.99999999
define "DecimalPos10Pow28ToZeroOneStepDecimalMaxValue Output":
	+10*1000000000000000000000000000.00000000-0.00000001

define "DecimalNeg10Pow28ToZeroOneStepDecimalMinValue Input":
	-9999999999999999999999999999.99999999
define "DecimalNeg10Pow28ToZeroOneStepDecimalMinValue Output":
	-10*1000000000000000000000000000.00000000+0.00000001

define "Decimal10Pow28":
	10000000000000000000000000000.00000000

define "DecimalPos10Pow28":
	+10000000000000000000000000000.00000000

define "DecimalNeg10Pow28":
	-10000000000000000000000000000.00000000
