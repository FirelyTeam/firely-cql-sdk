library KidneyHealthEvaluationFHIR version '0.1.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include CQMCommon version '2.0.000' called CQMCommon
include Hospice version '6.9.000' called Hospice
include PalliativeCare version '1.9.000' called PalliativeCare
include QICoreCommon version '2.0.000' called QICoreCommon

codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "ActCode": 'http://terminology.hl7.org/CodeSystem/v3-ActCode'
codesystem "ConditionClinicalStatusCodes": 'http://terminology.hl7.org/CodeSystem/condition-clinical'

valueset "Acute Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083'
valueset "Annual Wellness Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240'
valueset "Chronic Kidney Disease, Stage 5": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002'
valueset "Diabetes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "End Stage Renal Disease": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353'
valueset "Estimated Glomerular Filtration Rate": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1000'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Hospice Care Ambulatory": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008'
valueset "Palliative or Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'
valueset "Urine Albumin Creatinine Ratio": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1007'

code "Discharge to healthcare facility for hospice care (procedure)": '428371000124100' from "SNOMEDCT" display 'Discharge to healthcare facility for hospice care (procedure)'
code "Discharge to home for hospice care (procedure)": '428361000124107' from "SNOMEDCT" display 'Discharge to home for hospice care (procedure)'
code "AMB": 'AMB' from "ActCode" display 'Ambulatory'
code "active": 'active' from "ConditionClinicalStatusCodes"

parameter "Measurement Period" Interval<DateTime>
default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)  

context Patient

define "Initial Population":
  AgeInYearsAt(date from start of "Measurement Period") in Interval[18, 85]
    and "Has Active Diabetes Overlaps Measurement Period"
    and "Has Outpatient Visit During Measurement Period"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  exists "Has CKD Stage 5 or ESRD Diagnosis Overlaps Measurement Period"
    or Hospice."Has Hospice Services"
    or PalliativeCare."Has Palliative Care in the Measurement Period"

define "Numerator":
  "Has Kidney Panel Performed During Measurement Period"

define "Has Kidney Panel Performed During Measurement Period":
  exists ( ["Observation": "Estimated Glomerular Filtration Rate"] eGFRTest
      where QICoreCommon."ToInterval" ( eGFRTest.effective ) during "Measurement Period"
        and eGFRTest.value is not null
        and eGFRTest.status in { 'final', 'amended', 'corrected' }
  )
    and exists ( ["Observation": "Urine Albumin Creatinine Ratio"] uACRTest
        where QICoreCommon."ToInterval" ( uACRTest.effective ) during "Measurement Period"
          and uACRTest.value is not null
          and uACRTest.status in { 'final', 'amended', 'corrected' }
    )

define "Has Outpatient Visit During Measurement Period":
  exists ( ( ["Encounter": "Annual Wellness Visit"]
      union ["Encounter": "Home Healthcare Services"]
      union ["Encounter": "Office Visit"]
      union ["Encounter": "Outpatient Consultation"]
      union ["Encounter": "Preventive Care Services Established Office Visit, 18 and Up"]
      union ["Encounter": "Preventive Care Services Initial Office Visit, 18 and Up"]
      union ["Encounter": "Telephone Visits"] ) ValidEncounter
      where ValidEncounter.period during "Measurement Period"
        and ValidEncounter.status = 'finished'
  )

define "Has Active Diabetes Overlaps Measurement Period":
  exists ( ["Condition": "Diabetes"] Diabetes
      where QICoreCommon."ToPrevalenceInterval" ( Diabetes ) overlaps "Measurement Period"
        and Diabetes.clinicalStatus ~ "active"
  )

define "Has CKD Stage 5 or ESRD Diagnosis Overlaps Measurement Period":
  ( ["Condition": "Chronic Kidney Disease, Stage 5"]
    union ["Condition": "End Stage Renal Disease"] ) CKDOrESRD
    where QICoreCommon."ToPrevalenceInterval" ( CKDOrESRD ) overlaps "Measurement Period"
      and CKDOrESRD.clinicalStatus ~ "active"

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"