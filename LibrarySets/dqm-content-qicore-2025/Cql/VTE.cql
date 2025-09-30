library VTE version '8.18.000'


using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '4.0.000' called QICoreCommon
include CQMCommon version '4.1.000' called CQMCommon

valueset "Obstetrical or Pregnancy Related Conditions": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263' 
valueset "Obstetrics VTE": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.264'
valueset "Venous Thromboembolism": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.279' 

parameter "Measurement Period" Interval<DateTime>

context Patient

  
define "Initial Population":
"Encounter With Age Range And Without VTE Diagnosis Or Obstetrical Conditions"


define "Admission Without VTE Or Obstetrical Conditions":
  CQMCommon."Inpatient Encounter" InpatientEncounter
  where not (InpatientEncounter.hasEncDiagnosisOf("Obstetrical or Pregnancy Related Conditions")
             or InpatientEncounter.hasEncDiagnosisOf("Venous Thromboembolism")
             or InpatientEncounter.hasEncDiagnosisOf("Obstetrics VTE")
            )


define "Encounter With Age Range And Without VTE Diagnosis Or Obstetrical Conditions":
 "Admission Without VTE Or Obstetrical Conditions" EncounterWithoutConditions
     where AgeInYearsAt(date from start of EncounterWithoutConditions.period) >= 18
    
    
define fluent function fromDayOfStartOfHospitalizationToDayAfterAdmission(TheEncounter Encounter):
	Interval[ date from (start of TheEncounter.hospitalizationWithObservation()), date from (start of TheEncounter.period) + 1 days]
	
	
define fluent function hasEncDiagnosisOf(TheEncounter Encounter, DiagnosisValueSet ValueSet):
   TheEncounter E
     return (E.encounterDiagnosis()).code in DiagnosisValueSet
       or E.reasonCode in DiagnosisValueSet
       
       
define fluent function hasPrincipalProcedureOf(TheEncounter Encounter, DiagnosisValueSet ValueSet):
   TheEncounter E
   let
        PPx: E.principalProcedure(),
        CPx: singleton from ([Procedure] P where PPx.procedure.references(P.id))
     return PPx.procedure in DiagnosisValueSet
       or CPx.code in DiagnosisValueSet