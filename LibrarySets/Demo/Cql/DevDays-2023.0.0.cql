library DevDays version '2023.0.0'

using FHIR version '4.0.1'

parameter "Measurement Period" Interval<DateTime>

include FHIRHelpers version '4.0.001' called FHIRHelpers

codesystem "ICD10": 'http://hl7.org/fhir/sid/icd-10'
code "Sucked into jet engine": 'V97.33' from "ICD10"
code "Sucked into jet engine, subsequent encounter": 'V97.33XD' from "ICD10"

context Patient


define "Jet engine conditions":
	[Condition] c
		where 
			exists(c.code.coding coding where coding ~ "Sucked into jet engine")
			and (c.onset as FHIR.dateTime) in "Measurement Period"

define "Subsequent encounters":
	[Condition] c
		where 
			exists(c.code.coding coding where coding ~ "Sucked into jet engine, subsequent encounter")
			and (c.onset as FHIR.dateTime) in "Measurement Period"


define "Initial population":
	exists("Jet engine conditions")

define "Numerator":
	exists("Subsequent encounters")