library CMS165FHIRControllingHighBP version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '4.0.000' called QICoreCommon
include SupplementalDataElements version '5.1.000' called SDE
include Status version '1.15.000' called Status
include AdvancedIllnessandFrailty version '1.27.000' called AIFrailLTCF
include AdultOutpatientEncounters version '4.19.000' called AdultOutpatientEncounters
include Hospice version '6.18.000' called Hospice
include PalliativeCare version '1.18.000' called PalliativeCare

codesystem "LOINC": 'http://loinc.org'

valueset "Chronic Kidney Disease, Stage 5": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002'
valueset "Dialysis Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1013'
valueset "Emergency Department Evaluation and Management Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "End Stage Renal Disease": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353'
valueset "ESRD Monthly Outpatient Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1014'
valueset "Essential Hypertension": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.104.12.1011'
valueset "Kidney Transplant": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1012'
valueset "Kidney Transplant Recipient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.109.12.1029'
valueset "Pregnancy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378'

code "Diastolic blood pressure": '8462-4' from "LOINC" display 'Diastolic blood pressure'
code "Systolic blood pressure": '8480-6' from "LOINC" display 'Systolic blood pressure'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) in Interval[18, 85]
    and exists "Essential Hypertension Diagnosis"
    and exists AdultOutpatientEncounters."Qualifying Encounters"

define "Essential Hypertension Diagnosis":
  ( ( [ConditionProblemsHealthConcerns: "Essential Hypertension"]
      union [ConditionEncounterDiagnosis: "Essential Hypertension"]
  ).verified ( ) ) Hypertension
    where Hypertension.prevalenceInterval ( ) overlaps Interval[start of "Measurement Period", start of "Measurement Period" + 6 months )

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or exists ( "Pregnancy or Renal Diagnosis" )
    or exists ( "End Stage Renal Disease Procedures" )
    or exists ( "End Stage Renal Disease Encounter" )
    or AIFrailLTCF."Is Age 66 to 80 with Advanced Illness and Frailty or Is Age 81 or Older with Frailty"
    or AIFrailLTCF."Is Age 66 or Older Living Long Term in a Nursing Home"
    or PalliativeCare."Has Palliative Care in the Measurement Period"

define "Pregnancy or Renal Diagnosis":
  ( ( [ConditionProblemsHealthConcerns: "Pregnancy"]
      union [ConditionEncounterDiagnosis: "Pregnancy"]
      union [ConditionProblemsHealthConcerns: "End Stage Renal Disease"]
      union [ConditionEncounterDiagnosis: "End Stage Renal Disease"]
      union [ConditionProblemsHealthConcerns: "Kidney Transplant Recipient"]
      union [ConditionEncounterDiagnosis: "Kidney Transplant Recipient"]
      union [ConditionProblemsHealthConcerns: "Chronic Kidney Disease, Stage 5"]
      union [ConditionEncounterDiagnosis: "Chronic Kidney Disease, Stage 5"]
  ).verified ( ) ) PregnancyESRDDiagnosis
    where PregnancyESRDDiagnosis.prevalenceInterval ( ) overlaps "Measurement Period"

define "End Stage Renal Disease Procedures":
  ( ( [Procedure: "Kidney Transplant"]
      union [Procedure: "Dialysis Services"]
  ).isProcedurePerformed ( ) ) ESRDProcedure
    where ESRDProcedure.performed.toInterval ( ) ends on or before end of "Measurement Period"

define "End Stage Renal Disease Encounter":
  ( ( [Encounter: "ESRD Monthly Outpatient Services"] ).isEncounterPerformed ( ) ) ESRDEncounter
    where ESRDEncounter.period starts on or before end of "Measurement Period"

define "Numerator":
  "Has Systolic Blood Pressure Less Than 140"
    and "Has Diastolic Blood Pressure Less Than 90"

define "Has Systolic Blood Pressure Less Than 140":
  "Lowest Systolic Reading on Most Recent Blood Pressure Day" < 140 'mm[Hg]'

define "Has Diastolic Blood Pressure Less Than 90":
  "Lowest Diastolic Reading on Most Recent Blood Pressure Day" < 90 'mm[Hg]'

define "Lowest Systolic Reading on Most Recent Blood Pressure Day":
  First("Qualifying Blood Pressure Reading" BPReading
      where BPReading.effective.latest() same day as "Most Recent Blood Pressure Day"
      return singleton from(BPReading.component BPComponent
          where BPComponent.code ~ "Systolic blood pressure"
          return BPComponent.value as Quantity
      )
      sort asc
  )

define "Lowest Diastolic Reading on Most Recent Blood Pressure Day":
  First("Qualifying Blood Pressure Reading" BPReading
      where BPReading.effective.latest() same day as "Most Recent Blood Pressure Day"
      return singleton from(BPReading.component BPComponent
          where BPComponent.code ~ "Diastolic blood pressure"
          return BPComponent.value as Quantity
      )
      sort asc
  )

define "Qualifying Blood Pressure Reading":
  ( ( ( [USCoreBloodPressureProfile] ).isObservationBP ( ) ) BloodPressure
      without ( ( [Encounter: "Encounter Inpatient"]
          union [Encounter: "Emergency Department Evaluation and Management Visit"]
      ).isEncounterPerformed ( ) ) DisqualifyingEncounter
        such that BloodPressure.effective.latest ( ) during day of DisqualifyingEncounter.period
      where BloodPressure.effective.latest ( ) during day of "Measurement Period"
  )
    union ( ( ( [USCoreBloodPressureProfile] ).isObservationBP ( ) ) BloodPressure
        where ( not ( ( BloodPressure.encounter.getEncounter ( ) ).class.code in { 'EMER', 'IMP', 'ACUTE', 'NONAC', 'PRENC', 'SS' } ) )
          and BloodPressure.effective.latest ( ) during day of "Measurement Period"
    )

define fluent function getEncounter(reference Reference):
  singleton from ( [Encounter] E
      where E.id = reference.reference.getId ( )
  )

define "Most Recent Blood Pressure Day":
  Last("Blood Pressure Days" BPDays
      sort asc
  )

define "Blood Pressure Days":
  "Qualifying Blood Pressure Reading" BPExam
    return date from BPExam.effective.latest ( )

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"