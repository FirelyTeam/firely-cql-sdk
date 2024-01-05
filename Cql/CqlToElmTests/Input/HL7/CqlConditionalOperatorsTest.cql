library CqlConditionalOperatorsTest

context Unfiltered


define "IfTrue1 Input":
	if 10 > 5 then 5 else 10
define "IfTrue1 Output":
	5

define "IfFalse1 Input":
	if 10 = 5 then 10 + 5 else 10 - 5
define "IfFalse1 Output":
	5

define "IfNull1 Input":
	if 10 = null then 5 else 10
define "IfNull1 Output":
	10

define "StandardCase1 Input":
	
				case
					when 10 > 5 then 5
					when 5 > 10 then 10
					else null
				end
			
define "StandardCase1 Output":
	5

define "StandardCase2 Input":
	
				case
					when 5 > 10 then 5 + 10
					when 5 = 10 then 10
					else 10 - 5
				end
			
define "StandardCase2 Output":
	5

define "StandardCase3 Input":
	
				case
					when null ~ 10 then null + 10
					when null ~ 5 then 5
					else 5 + 10
				end
			
define "StandardCase3 Output":
	15

define "SelectedCase1 Input":
	
				case 5
					when 5 then 12
					when 10 then 10 + 5
					else 10 - 5
				end
			
define "SelectedCase1 Output":
	12

define "SelectedCase2 Input":
	
				case 10
					when 5 then 12
					when 10 then 10 + 5
					else 10 - 5
				end
			
define "SelectedCase2 Output":
	15

define "SelectedCase3 Input":
	
				case 10 + 5
					when 5 then 12
					when 10 then 10 + 5
					else 10 - 5
				end
			
define "SelectedCase3 Output":
	5
