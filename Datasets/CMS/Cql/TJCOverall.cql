library TJCOverall version '8.11.000'


using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include CQMCommon   version '2.0.000' called CQMCommon
include QICoreCommon version '2.0.000' called QICoreCommon

valueset "Comfort Measures": 'http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45'
valueset "Discharge To Acute Care Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87'
valueset "Discharged to Health Care Facility for Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207'
valueset "Discharged to Home for Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209'
valueset "Hemorrhagic Stroke": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212'
valueset "Ischemic Stroke": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247'
valueset "Left Against Medical Advice": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308'
valueset "Nonelective Inpatient Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.424'
valueset "Patient Expired": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309'

parameter "Measurement Period" Interval<DateTime>

context Patient


define "Non Elective Inpatient Encounter":
  ["Encounter": "Nonelective Inpatient Encounter"] NonElectiveEncounter
        where NonElectiveEncounter.period ends during day of "Measurement Period"

define "All Stroke Encounter":
  "Non Elective Inpatient Encounter" NonElectiveEncounter
  let ConditionCode: NonElectiveEncounter.principalDiagnosis().code
    where ( ConditionCode in "Hemorrhagic Stroke"
       or   ConditionCode in "Ischemic Stroke" )  

define "Ischemic Stroke Encounter":
  "Encounter with Principal Diagnosis and Age" EncounterWithAge
    where EncounterWithAge.principalDiagnosis().code in "Ischemic Stroke"

define "Ischemic Stroke Encounters with Discharge Disposition":
  "Ischemic Stroke Encounter" IschemicStrokeEncounter
  let DischDisp: IschemicStrokeEncounter.hospitalization.dischargeDisposition
  	where  DischDisp in "Discharge To Acute Care Facility"
		or DischDisp in "Left Against Medical Advice"
		or DischDisp in "Patient Expired"
		or DischDisp in "Discharged to Home for Hospice Care"
		or DischDisp in "Discharged to Health Care Facility for Hospice Care"			

define "Encounter with Principal Diagnosis and Age":
  "All Stroke Encounter" AllStrokeEncounter
    where AgeInYearsAt(date from start of AllStrokeEncounter.period ) >= 18

define "Comfort Measures during Hospitalization":
  "Ischemic Stroke Encounter" IschemicStrokeEncounter
    with "Intervention Comfort Measures" ComfortMeasure
     such that Coalesce(start of ComfortMeasure.performed.toInterval(), ComfortMeasure.authoredOn) during IschemicStrokeEncounter.hospitalizationWithObservation()

define "Encounter with Comfort Measures during Hospitalization":
  "Ischemic Stroke Encounter" IschemicStrokeEncounter
    with "Intervention Comfort Measures" ComfortMeasure
     such that Coalesce(start of ComfortMeasure.performed.toInterval(), ComfortMeasure.authoredOn) during IschemicStrokeEncounter.hospitalizationWithObservation()

define "Intervention Comfort Measures":
  ( ["ServiceRequest": code in "Comfort Measures"] SR
    where SR.status in { 'active', 'completed', 'on-hold' }
      and SR.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
      and SR.doNotPerform is not true
  )  
  union ( ["Procedure": "Comfort Measures"] InterventionPerformed
        where InterventionPerformed.status in { 'completed', 'in-progress' }
  )
  
define fluent function CalendarDayOfOrDayAfter(StartValue DateTime):
  Interval [date from (StartValue), date from (StartValue) + 1 day]