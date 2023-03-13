library CqlConditionalOperatorsTest version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

context Patient

define "IfTrue1":
  ( if 10 > 5 then 5 
      else 10
  ) = 5

define "IfFalse1":
  ( if 10 = 5 then 10 + 5 
      else 10 - 5
  ) = 5

define "IfNull1":
  ( if 10 = null then 5 
      else 10
  ) = 10

define "StandardCase1":
  case
    when 10 > 5 then 5
    when 5 > 10 then 10 
    else null 
  end = 5

define "StandardCase2":
  case
    when 5 > 10 then 5 + 10
    when 5 = 10 then 5 
    else 10 - 5 
  end = 5

define "StandardCase3":
  case
    when null ~ 10 then null + 10
    when null ~ 5 then 5 
    else 5 + 10 
  end = 15

define "SelectedCase1":
  case 5
    when 5 then 12
    when 10 then 10 + 5 
    else 10 - 5 
  end = 12

define "SelectedCase2":
  case 10
    when 5 then 12
    when 10 then 10 + 5 
    else 10 - 5 
  end = 15

define "SelectedCase3":
  case 10 + 5
    when 5 then 12
    when 10 then 10 + 5 
    else 10 - 5 
  end = 5