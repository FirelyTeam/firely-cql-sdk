library CMS826FHIRHHPI version '0.3.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include CQMCommon version '4.1.000' called CQMCommon
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "LOINC": 'http://loinc.org'

valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Not Present On Admission or Documentation Insufficient to Determine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198'
valueset "Present on Admission or Clinically Undetermined": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197'
valueset "Pressure Injury Deep Tissue": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.112'
valueset "Pressure Injury Deep Tissue Diagnoses": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.194'
valueset "Pressure Injury Stage 2, 3, 4 or Unstageable": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.113'
valueset "Pressure Injury Stage 2, 3, 4, or Unstageable Diagnoses": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.196'

code "Physical findings of Skin": '8709-8' from "LOINC" display 'Physical findings of Skin'

parameter "Measurement Period" Interval<DateTime>

context Patient

define "Initial Population":
  "Encounter with Age 18 and Older"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "Encounter with Deep Tissue Pressure Injury POA by Indicator or Skin Exam within First 72 Hours"
    union "Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA"

define "Numerator":
  "Encounter with New Deep Tissue Pressure Injury"
    union "Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury"

define "Encounter with Age 18 and Older":
  ["Encounter": "Encounter Inpatient"] InpatientEncounter
    where AgeInYearsAt(date from start of InpatientEncounter.period) >= 18
      and InpatientEncounter.period ends during day of "Measurement Period"
      and InpatientEncounter.status = 'finished'

define "Encounter with Deep Tissue Pressure Injury POA by Indicator or Skin Exam within First 72 Hours":
  "Encounter with Deep Tissue Pressure Injury POA by Indicator"
    union "Encounter with Deep Tissue Pressure Injury POA by Skin Exam within First 72 Hours"

define "Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA":
  "Encounter with Stage 2, 3, 4, or Unstageable Pressure Injury Present on Admission by POA Indicator"
    union "Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA by Skin Exam within 24 Hours"

define "Encounter with New Deep Tissue Pressure Injury":
  "Encounter with New Deep Tissue Pressure Injury Not POA by Indicator"
    union "Encounter with New Deep Tissue Pressure Injury by Skin Exam after First 72 Hours"

define "Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury":
  "Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA by Indicator"
    union "Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury by Skin Exam after First 24 Hours"

define "Encounter with Deep Tissue Pressure Injury POA by Indicator":
  "Encounter with Age 18 and Older" InpatientHospitalization
    where InpatientHospitalization.isDiagnosisPresentOnAdmission ( "Pressure Injury Deep Tissue Diagnoses", "Present on Admission or Clinically Undetermined" )

define "Encounter with Deep Tissue Pressure Injury POA by Skin Exam within First 72 Hours":
  "Encounter with Age 18 and Older" InpatientHospitalization
    let hospitalizationPeriod: InpatientHospitalization.hospitalizationWithObservation ( )
    with "SkinExams with Pressure Injury" SkinExam
      such that SkinExam.effective.toInterval ( ) starts during Interval[start of hospitalizationPeriod, start of hospitalizationPeriod + 72 hours]

define "Encounter with Stage 2, 3, 4, or Unstageable Pressure Injury Present on Admission by POA Indicator":
  "Encounter with Age 18 and Older" InpatientHospitalization
    where InpatientHospitalization.isDiagnosisPresentOnAdmission ( "Pressure Injury Stage 2, 3, 4, or Unstageable Diagnoses", "Present on Admission or Clinically Undetermined" )

define "Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA by Skin Exam within 24 Hours":
  "Encounter with Age 18 and Older" InpatientHospitalization
    let hospitalizationPeriod: InpatientHospitalization.hospitalizationWithObservation ( )
    with "SkinExams with Pressure Injury" SkinExam
      such that SkinExam.effective.toInterval ( ) starts during Interval[start of hospitalizationPeriod, start of hospitalizationPeriod + 24 hours]

define "Encounter with New Deep Tissue Pressure Injury Not POA by Indicator":
  "Encounter with Age 18 and Older" InpatientHospitalization
    where InpatientHospitalization.isDiagnosisPresentOnAdmission ( "Pressure Injury Deep Tissue Diagnoses", "Not Present On Admission or Documentation Insufficient to Determine" )

define "Encounter with New Deep Tissue Pressure Injury by Skin Exam after First 72 Hours":
  "Encounter with Age 18 and Older" InpatientHospitalization
    let hospitalizationPeriod: InpatientHospitalization.hospitalizationWithObservation ( )
    with "SkinExams with Pressure Injury" SkinExam
      such that SkinExam.effective.toInterval ( ) starts during Interval[start of hospitalizationPeriod + 72 hours, end of hospitalizationPeriod]

define "Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA by Indicator":
  "Encounter with Age 18 and Older" InpatientHospitalization
    where InpatientHospitalization.isDiagnosisPresentOnAdmission ( "Pressure Injury Stage 2, 3, 4, or Unstageable Diagnoses", "Not Present On Admission or Documentation Insufficient to Determine" )

define "Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury by Skin Exam after First 24 Hours":
  "Encounter with Age 18 and Older" InpatientHospitalization
    let hospitalizationPeriod: CQMCommon."HospitalizationWithObservation" ( InpatientHospitalization )
    with "SkinExams with Pressure Injury" SkinExam
      such that SkinExam.effective.toInterval ( ) starts during Interval[start of hospitalizationPeriod + 24 hours, end of hospitalizationPeriod]

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Clinical SkinExams with Pressure Injury":
  ["ObservationClinicalResult": "Physical findings of Skin"] ClinicalSkinExam
    where ClinicalSkinExam.isIn ( "Pressure Injury Stage 2, 3, 4 or Unstageable" )

define "Simple SkinExams with Pressure Injury":
  ["SimpleObservation": "Physical findings of Skin"] ObsSkinExam
    where ObsSkinExam.isIn ( "Pressure Injury Stage 2, 3, 4 or Unstageable" )

// Skin exams may be either a SimpleObservation or an ObservationClinicalResult
// The following union is used to combine the two types of skin exams



define "SkinExams with Pressure Injury":
  "Clinical SkinExams with Pressure Injury"
    union "Simple SkinExams with Pressure Injury"

// @description This function, attached to either a SimpleObseration or an ObservationClinicalResult,  is used to determine if the observation is completed and its value is in the given value set
// @example  anObservation.isIn("Pressure Injury Stage 2, 3, 4 or Unstageable")



define fluent function isIn(observation Choice<"SimpleObservation", "ObservationClinicalResult">, vset ValueSet):
  observation.status in { 'final', 'amended', 'corrected' }
    and observation.effective during "Measurement Period"
    and case
      when observation is SimpleObservation then ( observation as SimpleObservation ).value as Concept in vset
      when observation is ObservationClinicalResult then ( observation as ObservationClinicalResult ).value as Concept in vset 
      else null end


//----------------------  Debugging --------------- ------------------------------------//
