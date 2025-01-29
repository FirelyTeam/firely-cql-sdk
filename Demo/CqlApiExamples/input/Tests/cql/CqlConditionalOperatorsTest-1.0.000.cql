library CqlConditionalOperatorsTest version '1.0.000'

define "if-then-else.IfTrue1": if 10 > 5 then 5 else 10

define "if-then-else.IfFalse1": if 10 = 5 then 10 + 5 else 10 - 5

define "if-then-else.IfNull1": if 10 = null then 5 else 10

define "standard case.StandardCase1": case
					when 10 > 5 then 5
					when 5 > 10 then 10
					else null
				end

define "standard case.StandardCase2": case
					when 5 > 10 then 5 + 10
					when 5 = 10 then 10
					else 10 - 5
				end

define "standard case.StandardCase3": case
					when null ~ 10 then null + 10
					when null ~ 5 then 5
					else 5 + 10
				end

define "selected case.SelectedCase1": case 5
					when 5 then 12
					when 10 then 10 + 5
					else 10 - 5
				end

define "selected case.SelectedCase2": case 10
					when 5 then 12
					when 10 then 10 + 5
					else 10 - 5
				end

define "selected case.SelectedCase3": case 10 + 5
					when 5 then 12
					when 10 then 10 + 5
					else 10 - 5
				end

