library CMS159FHIRDepRemissionat12Months version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon

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
valueset "Palliative or Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579'
valueset "Personality Disorder Emotionally Labile": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.246'
valueset "Pervasive Developmental Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1152'
valueset "PHQ 9 and PHQ 9M Tools": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.263'
valueset "Schizophrenia or Psychotic Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1104'

code "Discharge to healthcare facility for hospice care (procedure)": '428371000124100' from "SNOMEDCT" display 'Discharge to healthcare facility for hospice care (procedure)'
code "Discharge to home for hospice care (procedure)": '428361000124107' from "SNOMEDCT" display 'Discharge to home for hospice care (procedure)'
code "Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)": '71007-9' from "LOINC" display 'Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)'
code "Hospice care [Minimum Data Set]": '45755-6' from "LOINC" display 'Hospice care [Minimum Data Set]'
code "Yes (qualifier value)": '373066001' from "SNOMEDCT" display 'Yes (qualifier value)'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
  AgeInYearsAt(start of("Index Depression Assessment".effective.toInterval())) >= 12

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "Has Hospice Services prior to or during the Measure Assessment Period"
    or "Has Palliative Care prior to or during the Measure Assessment Period"
    or "Patient Expired"
    or "Has Mental Health Disorder Diagnoses"

define "Numerator":
  Last([ObservationScreeningAssessment: "PHQ 9 and PHQ 9M Tools"] DepressionAssessment
      where start of DepressionAssessment.effective.toInterval() during day of "Measure Assessment Period"
        and DepressionAssessment.status in { 'final', 'amended', 'corrected' }
      sort by start of effective.toInterval()
  ).value < 5

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

define "Depression Assessments Greater Than 9":
  [ObservationScreeningAssessment: "PHQ 9 and PHQ 9M Tools"] DepressionAssessment
    where DepressionAssessment.value > 9
      and DepressionAssessment.status in { 'final', 'amended', 'corrected' }

define "Depression Diagnoses":
  ( [ConditionProblemsHealthConcerns: "Major Depression Including Remission"]
    union [ConditionEncounterDiagnosis: "Major Depression Including Remission"]
    union [ConditionProblemsHealthConcerns: "Dysthymia"]
    union [ConditionEncounterDiagnosis: "Dysthymia"] ) Depression
    where Depression.isVerified ( )

define "Depression Encounter":
  [Encounter: "Contact or Office Visit"] ValidEncounter
    with "Depression Diagnoses" Depression
      such that ValidEncounter.period overlaps Depression.prevalenceInterval ( )
        and ValidEncounter.period ends during day of "Denominator Identification Period"
        and ValidEncounter.status = 'finished'

define "Has Mental Health Disorder Diagnoses":
  exists ( ( [ConditionProblemsHealthConcerns: "Bipolar Disorder"]
      union [ConditionEncounterDiagnosis: "Bipolar Disorder"]
      union [ConditionProblemsHealthConcerns: "Personality Disorder Emotionally Labile"]
      union [ConditionEncounterDiagnosis: "Personality Disorder Emotionally Labile"]
      union [ConditionProblemsHealthConcerns: "Schizophrenia or Psychotic Disorder"]
      union [ConditionEncounterDiagnosis: "Schizophrenia or Psychotic Disorder"]
      union [ConditionProblemsHealthConcerns: "Pervasive Developmental Disorder"]
      union [ConditionEncounterDiagnosis: "Pervasive Developmental Disorder"] ) MentalHealthDisorderDiagnoses
      where start of MentalHealthDisorderDiagnoses.prevalenceInterval ( ) on or before day of end of "Measure Assessment Period"
        and MentalHealthDisorderDiagnoses.isVerified ( )
  )

define "Measure Assessment Period":
  "Index Depression Assessment" FirstIndexAssessment
    let YearAfterIndexAssessment: date from start of FirstIndexAssessment.effective.toInterval ( ) + 12 months
    return Interval[YearAfterIndexAssessment - 60 days, YearAfterIndexAssessment + 60 days]

define "Patient Expired":
  Patient.deceased occurs on or before day of end of "Measure Assessment Period"

define "Has Hospice Services prior to or during the Measure Assessment Period":
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
    or exists ( [ObservationScreeningAssessment: "Hospice care [Minimum Data Set]"] HospiceAssessment
        where HospiceAssessment.value ~ "Yes (qualifier value)"
          and HospiceAssessment.effective.toInterval ( ) overlaps day of Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
          and HospiceAssessment.status in { 'final', 'amended', 'corrected' }
    )
    or exists ( [ServiceRequest: "Hospice Care Ambulatory"] HospiceOrder
        where HospiceOrder.authoredOn during day of Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
          and HospiceOrder.status in { 'active', 'completed' }
          and HospiceOrder.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
    )
    or exists ( [Procedure: "Hospice Care Ambulatory"] HospicePerformed
        where HospicePerformed.performed.toInterval ( ) overlaps day of Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
          and not ( HospicePerformed.status in { 'not-done', 'entered-in-error', 'unknown' } )
    )
    or exists ( ( [ConditionProblemsHealthConcerns: "Hospice Diagnosis"]
        union [ConditionEncounterDiagnosis: "Hospice Diagnosis"] ) HospiceCareDiagnosis
        where HospiceCareDiagnosis.prevalenceInterval ( ) overlaps day of Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
          and HospiceCareDiagnosis.isVerified ( )
    )

define "Index Depression Assessment":
  First("Depression Assessments Greater Than 9" DepressionAssessment
      with "Depression Encounter" DepressionEncounter
        such that DepressionAssessment.effective.toInterval() during day of Interval[start of DepressionEncounter.period - 7 days, 
        end of DepressionEncounter.period]
      sort by start of effective.toInterval()
  )

define "Has Palliative Care prior to or during the Measure Assessment Period":
  exists ( [ObservationScreeningAssessment: "Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)"] PalliativeAssessment
      where PalliativeAssessment.effective.toInterval ( ) overlaps day of Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
        and PalliativeAssessment.status in { 'final', 'amended', 'corrected' }
  )
    or exists ( ( [ConditionProblemsHealthConcerns: "Palliative Care Diagnosis"]
        union [ConditionEncounterDiagnosis: "Palliative Care Diagnosis"] ) PalliativeDiagnosis
        where PalliativeDiagnosis.prevalenceInterval ( ) overlaps day of Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
          and PalliativeDiagnosis.isVerified ( )
    )
    or exists ( [Encounter: "Palliative Care Encounter"] PalliativeEncounter
        where PalliativeEncounter.period overlaps day of Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
          and PalliativeEncounter.status = 'finished'
    )
    or exists ( [Procedure: "Palliative Care Intervention"] PalliativeIntervention
        where PalliativeIntervention.performed.toInterval ( ) overlaps day of Interval[start of "Denominator Identification Period", end of "Measure Assessment Period"]
          and not ( PalliativeIntervention.status in { 'not-done', 'entered-in-error', 'unknown' } )
    )

define fluent function isVerified(condition Choice<ConditionEncounterDiagnosis, ConditionProblemsHealthConcerns>):
  condition.verificationStatus is not null implies ( condition.verificationStatus ~ QICoreCommon."confirmed"
      or condition.verificationStatus ~ QICoreCommon."unconfirmed"
      or condition.verificationStatus ~ QICoreCommon."provisional"
      or condition.verificationStatus ~ QICoreCommon."differential"
  )

define "Stratification 1":
  "Index Depression Assessment" IndexAssessment
    return AgeInYearsAt(date from start of IndexAssessment.effective.toInterval()) in Interval[12, 17]

define "Stratification 2":
  "Index Depression Assessment" IndexAssessment
    return AgeInYearsAt(date from start of IndexAssessment.effective.toInterval()) >= 18