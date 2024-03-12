library VTE version '8.6.000'


using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include CQMCommon version '2.0.000' called CQMCommon

valueset "Obstetrical or Pregnancy Related Conditions": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263' 
valueset "Obstetrics VTE": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.264'
valueset "Venous Thromboembolism": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.279' 

parameter "Measurement Period" Interval<DateTime>

context Patient

  
define "Initial Population":
"Encounter with Age Range and without VTE Diagnosis or Obstetrical Conditions"

define "Admission without VTE or Obstetrical Conditions":
  CQMCommon."Inpatient Encounter" InpatientEncounter
   where not (exists (InpatientEncounter.encounterDiagnosis()) EncDx
                 where (EncDx.code in "Obstetrical or Pregnancy Related Conditions" 
                      or EncDx.code in "Venous Thromboembolism"
          				or EncDx.code in "Obstetrics VTE"
          			         )
                     )


define "Encounter with Age Range and without VTE Diagnosis or Obstetrical Conditions":
 ( CQMCommon."Inpatient Encounter" InpatientEncounter
     where AgeInYearsAt(date from start of InpatientEncounter.period) >= 18 )
    intersect "Admission without VTE or Obstetrical Conditions"


define fluent function "FromDayOfStartOfHospitalizationToDayAfterAdmission"(Encounter Encounter ):
	Interval[ date from (start of Encounter.hospitalizationWithObservation()), date from (start of Encounter.period) + 1 days]

define fluent function "StartOfFirstICU"(Encounter Encounter ):
	start of Encounter.firstInpatientIntensiveCareUnit().period

define fluent function "FromDayOfStartOfHospitalizationToDayAfterFirstICU"(Encounter Encounter ):
	Interval[date from (start of Encounter.hospitalizationWithObservation()), date from (Encounter.StartOfFirstICU()) + 1 day]