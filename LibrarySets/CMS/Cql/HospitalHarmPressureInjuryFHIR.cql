library HospitalHarmPressureInjuryFHIR version '0.1.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
//include FHIRCommon version '4.2.000' called FHIRCommon

include SupplementalDataElements version '3.4.000' called SDE
include CQMCommon version '2.0.000' called CQMCommon
include QICoreCommon version '2.0.000' called QICoreCommon

codesystem "LOINC": 'http://loinc.org'

valueset "COVID 19": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.140'
valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Not Present On Admission or Documentation Insufficient to Determine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198'
valueset "Observation Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143'
valueset "Present on Admission or Clinically Undetermined": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197'
valueset "Pressure Injury Deep Tissue": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.112'
valueset "Pressure Injury Deep Tissue Diagnoses": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.194'
valueset "Pressure Injury Stage 2, 3, 4 or Unstageable": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.113'
valueset "Pressure Injury Stage 2, 3, 4, or Unstageable Diagnoses": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.196'

code "Physical findings of Skin": '8709-8' from "LOINC" display 'Physical findings of Skin'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "Encounter with Deep Tissue Pressure Injury POA"
    union "Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA"
    union "Encounter with Diagnosis of COVID19 Infection"

define "Initial Population":
  "Encounter with Age 18 and Older"

define "Numerator":
  "Encounter with New Deep Tissue Pressure Injury Not POA"
    union "Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA"

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Encounter with Age 18 and Older":
  ["Encounter": "Encounter Inpatient"] InpatientEncounter
    where AgeInYearsAt(date from start of InpatientEncounter.period) >= 18
      and InpatientEncounter.period ends during day of "Measurement Period"
      and InpatientEncounter.status = 'finished'

define "Encounter with Deep Tissue Pressure Injury POA":
  "Encounter with Deep Tissue Pressure Injury POA by Indicator"
    union "Encounter with Deep Tissue Pressure Injury POA by Skin Exam within First 72 Hours"

define "Encounter with Deep Tissue Pressure Injury POA by Indicator":
  "Encounter with Age 18 and Older" InpatientHospitalization
    where exists ( InpatientHospitalization.diagnosis EncounterDiag
        where EncounterDiag.condition.getCondition ( ).code in "Pressure Injury Deep Tissue Diagnoses"
          and ( EncounterDiag.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined" )
    )

define "Encounter with Diagnosis of COVID19 Infection":
  "Encounter with Age 18 and Older" InpatientHospitalization
    where exists ( CQMCommon."EncounterDiagnosis" ( InpatientHospitalization ) ) EncounterDiag
      where EncounterDiag.code in "COVID 19"

define "Encounter with New Deep Tissue Pressure Injury Not POA by Indicator":
  "Encounter with Age 18 and Older" InpatientHospitalization
    where exists ( InpatientHospitalization.diagnosis EncounterDiag
        where EncounterDiag.condition.getCondition ( ).code in "Pressure Injury Deep Tissue Diagnoses"
          and ( EncounterDiag.diagnosisPresentOnAdmission in "Not Present On Admission or Documentation Insufficient to Determine" )
    )

define "Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA by Indicator":
  "Encounter with Age 18 and Older" InpatientHospitalization
    where exists ( InpatientHospitalization.diagnosis Stage234UnstageablePressureInjury
        where Stage234UnstageablePressureInjury.condition.getCondition ( ).code in "Pressure Injury Stage 2, 3, 4, or Unstageable Diagnoses"
          and ( Stage234UnstageablePressureInjury.diagnosisPresentOnAdmission in "Not Present On Admission or Documentation Insufficient to Determine" )
    )

define "Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA":
  "Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury Not POA by Indicator"
    union "Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury by Skin Exam after First 24 Hours"

define "Encounter with Stage 2, 3, 4, or Unstageable Pressure Injury Present on Admission by POA Indicator":
  "Encounter with Age 18 and Older" InpatientHospitalization
    where exists ( InpatientHospitalization.diagnosis Stage234UnstageablePressureInjury
        where Stage234UnstageablePressureInjury.condition.getCondition ( ).code in "Pressure Injury Stage 2, 3, 4, or Unstageable Diagnoses"
          and ( Stage234UnstageablePressureInjury.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined" )
    )

define "Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA":
  "Encounter with Stage 2, 3, 4, or Unstageable Pressure Injury Present on Admission by POA Indicator"
    union "Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA by Skin Exam within 24 Hours"

define "Encounter with New Deep Tissue Pressure Injury Not POA":
  "Encounter with New Deep Tissue Pressure Injury Not POA by Indicator"
    union "Encounter with New Deep Tissue Pressure Injury by Skin Exam after First 72 Hours"

define "Encounter with Deep Tissue Pressure Injury POA by Skin Exam within First 72 Hours":
  "Encounter with Age 18 and Older" InpatientHospitalization
    let hospitalizationPeriod: CQMCommon."HospitalizationWithObservation" ( InpatientHospitalization )
    with ["Observation": "Physical findings of Skin"] SkinExam
      such that QICoreCommon."ToInterval" ( SkinExam.effective ) starts during Interval[start of hospitalizationPeriod, start of hospitalizationPeriod + 72 hours]
        and SkinExam.status in { 'final', 'amended', 'corrected' }
        and SkinExam.code in "Pressure Injury Deep Tissue"

define "Encounter with New Deep Tissue Pressure Injury by Skin Exam after First 72 Hours":
  "Encounter with Age 18 and Older" InpatientHospitalization
    let hospitalizationPeriod: CQMCommon."HospitalizationWithObservation" ( InpatientHospitalization )
    with ["Observation": "Physical findings of Skin"] SkinExam
      such that QICoreCommon."ToInterval" ( SkinExam.effective ) starts during Interval[start of hospitalizationPeriod + 72 hours, end of hospitalizationPeriod]
        and SkinExam.status in { 'final', 'amended', 'corrected' }
        and ( SkinExam.value as Concept in "Pressure Injury Deep Tissue"
            or SkinExam.component.code in "Pressure Injury Deep Tissue"
        )

define "Encounter with New Stage 2, 3, 4 or Unstageable Pressure Injury by Skin Exam after First 24 Hours":
  "Encounter with Age 18 and Older" InpatientHospitalization
    let hospitalizationPeriod: CQMCommon."HospitalizationWithObservation" ( InpatientHospitalization )
    with ["Observation": "Physical findings of Skin"] SkinExam
      such that QICoreCommon."ToInterval" ( SkinExam.effective ) starts during Interval[start of hospitalizationPeriod + 24 hours, end of hospitalizationPeriod]
        and SkinExam.status in { 'final', 'amended', 'corrected' }
        and ( SkinExam.value as Concept in "Pressure Injury Stage 2, 3, 4 or Unstageable"
            or SkinExam.component.code in "Pressure Injury Stage 2, 3, 4 or Unstageable"
        )

define "Encounter with Stage 2, 3, 4 or Unstageable Pressure Injury POA by Skin Exam within 24 Hours":
  "Encounter with Age 18 and Older" InpatientHospitalization
    let hospitalizationPeriod: CQMCommon."HospitalizationWithObservation" ( InpatientHospitalization )
    with ["Observation": "Physical findings of Skin"] SkinExam
      such that QICoreCommon."ToInterval" ( SkinExam.effective ) starts during Interval[start of hospitalizationPeriod, start of hospitalizationPeriod + 24 hours]
        and SkinExam.status in { 'final', 'amended', 'corrected' }
        and SkinExam.code in "Pressure Injury Stage 2, 3, 4 or Unstageable"