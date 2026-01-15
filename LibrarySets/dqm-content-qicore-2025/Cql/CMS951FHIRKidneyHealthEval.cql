library CMS951FHIRKidneyHealthEval version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include Hospice version '6.18.000' called Hospice
include PalliativeCare version '1.18.000' called PalliativeCare
include QICoreCommon version '4.0.000' called QICoreCommon

valueset "Annual Wellness Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240'
valueset "Chronic Kidney Disease, Stage 5": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1002'
valueset "Diabetes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001'
valueset "End Stage Renal Disease": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.353'
valueset "Estimated Glomerular Filtration Rate": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1000'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'
valueset "Undetectable Lab Result Value": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.272'
valueset "Urine Albumin": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.88'
valueset "Urine Albumin Creatinine Ratio": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.6929.3.1007'
valueset "Urine Creatinine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.87'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Initial Population":
  AgeInYearsAt(date from start of "Measurement Period") in Interval[18, 85]
    and "Has Active Diabetes Overlaps Start Of Measurement Period"
    and "Has Outpatient Visit During Measurement Period"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "Has CKD Stage 5 Or ESRD Diagnosis Overlaps Measurement Period"
    or Hospice."Has Hospice Services"
    or PalliativeCare."Has Palliative Care in the Measurement Period"

define "Numerator":
  "Kidney Panel Performed During Measurement Period"

define "Has Active Diabetes Overlaps Start Of Measurement Period":
  exists ( ["ConditionProblemsHealthConcerns": "Diabetes"]
    union ["ConditionEncounterDiagnosis": "Diabetes"] ) DiabetesDiagnosis
    where DiabetesDiagnosis.prevalenceInterval ( ) overlaps before day of "Measurement Period"
      and ( DiabetesDiagnosis.verificationStatus is not null implies ( DiabetesDiagnosis.verificationStatus !~ QICoreCommon."refuted"
            and DiabetesDiagnosis.verificationStatus !~ QICoreCommon."entered-in-error"
        )
      )

define "Has CKD Stage 5 Or ESRD Diagnosis Overlaps Measurement Period":
  exists ( ( ["ConditionProblemsHealthConcerns": "Chronic Kidney Disease, Stage 5"]
      union ["ConditionEncounterDiagnosis": "Chronic Kidney Disease, Stage 5"]
  )
    union ( ["ConditionProblemsHealthConcerns": "End Stage Renal Disease"]
        union ["ConditionEncounterDiagnosis": "End Stage Renal Disease"]
    ) ) CKDOrESRD
    where CKDOrESRD.prevalenceInterval ( ) overlaps day of "Measurement Period"
      and ( CKDOrESRD.verificationStatus is not null implies ( CKDOrESRD.verificationStatus !~ QICoreCommon."refuted"
            and CKDOrESRD.verificationStatus !~ QICoreCommon."entered-in-error"
        )
      )

define "Has Outpatient Visit During Measurement Period":
  exists ( ( ["Encounter": "Annual Wellness Visit"]
      union ["Encounter": "Home Healthcare Services"]
      union ["Encounter": "Office Visit"]
      union ["Encounter": "Outpatient Consultation"]
      union ["Encounter": "Preventive Care Services Established Office Visit, 18 and Up"]
      union ["Encounter": "Preventive Care Services Initial Office Visit, 18 and Up"]
      union ["Encounter": "Telephone Visits"] ) ValidEncounter
      where ValidEncounter.period during day of "Measurement Period"
        and ValidEncounter.status = 'finished'
  )

define "Kidney Panel Performed During Measurement Period":
  "Has Estimated Glomerular Filtration Rate Performed During Measurement Period"
    and ( "Has Urine Albumin Creatinine Ratio Test Performed During Measurement Period"
        or "Has Urine Albumin Test And Urine Creatine Test Less Than Or Equal To Four Days Apart"
    )

define "Has Estimated Glomerular Filtration Rate Performed During Measurement Period":
  exists ( ["LaboratoryResultObservation": "Estimated Glomerular Filtration Rate"] eGFRTest
      where eGFRTest.effective.toInterval ( ) during day of "Measurement Period"
        and eGFRTest.value is not null
        and eGFRTest.status in { 'final', 'amended', 'corrected' }
  )

define "Has Urine Albumin Creatinine Ratio Test Performed During Measurement Period":
  exists ( ["LaboratoryResultObservation": "Urine Albumin Creatinine Ratio"] uACRTest
      where uACRTest.effective.toInterval ( ) during day of "Measurement Period"
        and uACRTest.status in { 'final', 'amended', 'corrected' }
        and ( ( uACRTest.value is Quantity )
            or ( uACRTest.value as Concept in "Undetectable Lab Result Value" )
        )
  )

define "Has Urine Albumin Test And Urine Creatine Test Less Than Or Equal To Four Days Apart":
  exists ( from
      "Urine Albumin Test Performed During The Measurement Period" UrineAlbuminTest,
      "Urine Creatinine Test Performed During The Measurement Period" UrineCreatinineTest
      let UrineAlbuminDocumentedTime: UrineAlbuminTest.effective.toInterval ( ),
      UrineCreatinineDocumentedTime: UrineCreatinineTest.effective.toInterval ( )
      where UrineAlbuminDocumentedTime during Interval[start of UrineCreatinineDocumentedTime - 4 days, end of UrineCreatinineDocumentedTime + 4 days]
  )

define "Urine Albumin Test Performed During The Measurement Period":
  ["LaboratoryResultObservation": "Urine Albumin"] AlbuminTest
    where AlbuminTest.effective.toInterval ( ) during day of "Measurement Period"
      and AlbuminTest.value is not null
      and AlbuminTest.status in { 'final', 'amended', 'corrected' }

define "Urine Creatinine Test Performed During The Measurement Period":
  ["LaboratoryResultObservation": "Urine Creatinine"] CreatinineTest
    where CreatinineTest.effective.toInterval ( ) during day of "Measurement Period"
      and CreatinineTest.value is not null
      and CreatinineTest.status in { 'final', 'amended', 'corrected' }