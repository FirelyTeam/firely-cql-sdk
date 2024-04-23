library DepressionRemissionatTwelveMonthsFHIR version '0.1.000'

using QICore version '4.1.1'

/*This spec aligns with AU2024/PY2025 QDM version*/


include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include QICoreCommon version '2.0.000' called QICoreCommon

codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "ConditionVerificationStatusCodes": 'http://terminology.hl7.org/CodeSystem/condition-ver-status'

valueset "Bipolar Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128'
valueset "Contact or Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1080.5'
valueset "Dysthymia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.254'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Hospice Care Ambulatory": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584'
valueset "Hospice Diagnosis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165'
valueset "Hospice Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003'
valueset "Major Depression Including Remission": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.113883.3.67.1.101.3.2444'
valueset "Palliative Care Diagnosis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167'
valueset "Palliative Care Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090'
valueset "Palliative Care Intervention": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135'
valueset "Personality Disorder Emotionally Labile": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.246'
valueset "Pervasive Developmental Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1152'
valueset "PHQ 9 and PHQ 9M Tools": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.263'
valueset "Schizophrenia or Psychotic Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1104'

code "Discharge to healthcare facility for hospice care (procedure)": '428371000124100' from "SNOMEDCT" display 'Discharge to healthcare facility for hospice care (procedure)'
code "Discharge to home for hospice care (procedure)": '428361000124107' from "SNOMEDCT" display 'Discharge to home for hospice care (procedure)'
code "Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)": '71007-9' from "LOINC" display 'Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)'
code "Hospice care [Minimum Data Set]": '45755-6' from "LOINC" display 'Hospice care [Minimum Data Set]'
code "Yes (qualifier value)": '373066001' from "SNOMEDCT" display 'Yes (qualifier value)'
code "confirmed": 'confirmed' from ConditionVerificationStatusCodes display 'Confirmed'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)
  
context Patient

define "Initial Population":
  AgeInYearsAt(start of("Index Depression Assessment".effective.toInterval())) >= 12

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "Has Hospice Services in the Measure Assessment Period"
    or "Has Palliative Care in the Measure Assessment Period"
    or "Patient Expired"
    or "Has Mental Health Disorder Diagnoses"

define "Numerator":
  Last([Observation: "PHQ 9 and PHQ 9M Tools"] DepressionAssessment
      where ToDate(start of DepressionAssessment.effective.toInterval()) during "Measure Assessment Period"
        and DepressionAssessment.status in { 'final', 'amended', 'corrected' }
      sort by start of effective.toInterval()
  ).value < 5

define "Stratification 1":
  "Index Depression Assessment" IndexAssessment
    return AgeInYearsAt(date from start of IndexAssessment.effective.toInterval()) in Interval[12, 17]

define "Stratification 2":
  "Index Depression Assessment" IndexAssessment
    return AgeInYearsAt(date from start of IndexAssessment.effective.toInterval()) >= 18

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Denominator Identification Period":
  Interval[start of "Measurement Period" - 14 months, start of "Measurement Period" - 2 months )

define "Depression Assessments Greater than 9":
  [Observation: "PHQ 9 and PHQ 9M Tools"] DepressionAssessment
    where DepressionAssessment.value > 9
      and DepressionAssessment.status in { 'final', 'amended', 'corrected' }

define "Depression Diagnoses":
  ( [Condition: "Major Depression Including Remission"]
    union [Condition: "Dysthymia"] ) Depression
    where Depression.isActive ( )
      and Depression.verificationStatus ~ "confirmed"

define "Depression Encounter":
  [Encounter: "Contact or Office Visit"] ValidEncounter
    with "Depression Diagnoses" Depression
      such that ValidEncounter.period overlaps Depression.prevalenceInterval ( )
        and ValidEncounter.period ends during "Denominator Identification Period"
        and ValidEncounter.status = 'finished'

define "Has Hospice Services in the Measure Assessment Period":
  exists ( [Encounter: "Encounter Inpatient"] InpatientEncounter
      where ( InpatientEncounter.hospitalization.dischargeDisposition ~ "Discharge to home for hospice care (procedure)"
          or InpatientEncounter.hospitalization.dischargeDisposition ~ "Discharge to healthcare facility for hospice care (procedure)"
      )
        and InpatientEncounter.period ends during day of Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
        and InpatientEncounter.status = 'finished'
  )
    or exists ( [Encounter: "Hospice Encounter"] HospiceEncounter
        where HospiceEncounter.period overlaps day of Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
          and not ( HospiceEncounter.status in { 'cancelled', 'entered-in-error', 'unknown' } )
    )
    or exists ( [Observation: "Hospice care [Minimum Data Set]"] HospiceAssessment
        where HospiceAssessment.value ~ "Yes (qualifier value)"
          and HospiceAssessment.effective.toInterval ( ) overlaps day of Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
          and HospiceAssessment.status in { 'final', 'amended', 'corrected' }
    )
    or exists ( [ServiceRequest: code in "Hospice Care Ambulatory"] HospiceOrder
        where HospiceOrder.authoredOn during day of Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
          and HospiceOrder.status in { 'active', 'completed' }
          and HospiceOrder.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
    )
    or exists ( [Procedure: "Hospice Care Ambulatory"] HospicePerformed
        where HospicePerformed.performed.toInterval ( ) overlaps day of Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
          and not ( HospicePerformed.status in { 'not-done', 'entered-in-error', 'unknown' } )
    )
    or exists ( [Condition: "Hospice Diagnosis"] HospiceCareDiagnosis
        where HospiceCareDiagnosis.prevalenceInterval ( ) overlaps day of Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
          and HospiceCareDiagnosis.isActive ( )
          and HospiceCareDiagnosis.verificationStatus ~ "confirmed"
    )

define "Has Mental Health Disorder Diagnoses":
  exists ( ( [Condition: "Bipolar Disorder"]
      union [Condition: "Personality Disorder Emotionally Labile"]
      union [Condition: "Schizophrenia or Psychotic Disorder"]
      union [Condition: "Pervasive Developmental Disorder"] ) MentalHealthDisorderDiagnoses
      where ToDate(start of MentalHealthDisorderDiagnoses.prevalenceInterval()) on or before end of "Measure Assessment Period"
        and MentalHealthDisorderDiagnoses.isActive ( )
        and MentalHealthDisorderDiagnoses.verificationStatus ~ "confirmed"
  )

define "Has Palliative Care in the Measure Assessment Period":
  exists ( [Observation: "Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)"] PalliativeAssessment
      where PalliativeAssessment.effective.toInterval ( ) overlaps Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
        and PalliativeAssessment.status in { 'final', 'amended', 'corrected' }
  )
    or exists ( [Condition: "Palliative Care Diagnosis"] PalliativeDiagnosis
        where PalliativeDiagnosis.prevalenceInterval ( ) overlaps Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
          and PalliativeDiagnosis.isActive ( )
          and PalliativeDiagnosis.verificationStatus ~ "confirmed"
    )
    or exists ( [Encounter: "Palliative Care Encounter"] PalliativeEncounter
        where PalliativeEncounter.period overlaps Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
          and PalliativeEncounter.status = 'finished'
    )
    or exists ( [Procedure: "Palliative Care Intervention"] PalliativeIntervention
        where PalliativeIntervention.performed.toInterval ( ) overlaps Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
          and not ( PalliativeIntervention.status in { 'not-done', 'entered-in-error', 'unknown' } )
    )

define "Index Depression Assessment":
  First("Depression Assessments Greater than 9" DepressionAssessment
      with "Depression Encounter" DepressionEncounter
        such that DepressionAssessment.effective.toInterval() during day of Interval[ToDate((start of DepressionEncounter.period) - 7 days), 
        end of DepressionEncounter.period]
      sort by start of effective.toInterval()
  )

define "Measure Assessment Period":
  "Index Depression Assessment" FirstIndexAssessment
    let YearAfterIndexAssessment: date from start of FirstIndexAssessment.effective.toInterval ( ) + 12 months
    return Interval[YearAfterIndexAssessment - 60 days, YearAfterIndexAssessment + 60 days]

define "Patient Expired":
  Patient.deceased on or before end of "Measure Assessment Period"