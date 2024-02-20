library DRCommunicationWithPhysicianManagingDiabetesFHIR version '0.1.000'

using QICore version '4.1.1'

/*
Notes: 
- Per BonnieMat-1455 and ticket  https://github.com/cqframework/cql-execution/issues/296  
--https://oncprojectracking.healthit.gov/support/browse/CQLIT-371 (formerly BonnieMat-1420)
--surrounding negation with QI-Core 4.1.1 DRC are not supported as resource filters and must be replaced with valueset or used on unfiltered resource in predicate
--cardinality issues surrounding negation coding to be addressed in future execution engine update
*/


include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include QICoreCommon version '2.0.000' called QICoreCommon

codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "ActCode": 'http://terminology.hl7.org/CodeSystem/v3-ActCode'

valueset "Care Services in Long-Term Residential Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014'
valueset "Diabetic Retinopathy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327'
valueset "Level of Severity of Retinopathy Findings": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1283'
valueset "Macular Edema Findings Present": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1320'
valueset "Macular Exam": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1251'
valueset "Medical Reason": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007'
valueset "Nursing Facility Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Ophthalmological Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285'
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008'
valueset "Patient Reason": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008'
valueset "Macular edema absent (situation)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.2.1391'

code "Healthcare professional (occupation)": '223366009' from "SNOMEDCT" display 'Healthcare professional (occupation)'
code "Medical practitioner (occupation)": '158965000' from "SNOMEDCT" display 'Medical practitioner (occupation)'
code "Ophthalmologist (occupation)": '422234006' from "SNOMEDCT" display 'Ophthalmologist (occupation)'
code "Optometrist (occupation)": '28229004' from "SNOMEDCT" display 'Optometrist (occupation)'
code "Physician (occupation)": '309343006' from "SNOMEDCT" display 'Physician (occupation)'
code "virtual": 'VR' from "ActCode" display 'virtual'
// code "Macular edema absent (situation)": '428341000124108' from "SNOMEDCT" display 'Macular edema absent (situation)'

code "AMB": 'AMB' from "ActCode" display 'Ambulatory'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

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
  AgeInYearsAt(date from start of "Measurement Period") >= 18
    and exists "Diabetic Retinopathy Encounter"

define "Denominator":
  "Initial Population"
    and exists "Macular Exam Performed"

define "Numerator":
  exists "Level of Severity of Retinopathy Findings Communicated"
    and ( exists "Macular Edema Absence Communicated"
        or exists "Macular Edema Presence Communicated"
    )

define "Denominator Exceptions":
  exists "Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy"
    or exists "Medical or Patient Reason for Not Communicating Absence of Macular Edema"
    or exists "Medical or Patient Reason for Not Communicating Presence of Macular Edema"

define "Qualifying Encounter During Measurement Period":
  ( ["Encounter": "Office Visit"]
    union ["Encounter": "Ophthalmological Services"]
    union ["Encounter": "Outpatient Consultation"]
    union ["Encounter": "Care Services in Long-Term Residential Facility"]
    union ["Encounter": "Nursing Facility Visit"] ) QualifyingEncounter
    where QualifyingEncounter.period during "Measurement Period"
      and QualifyingEncounter.status = 'finished'
      and QualifyingEncounter.class !~ "virtual"

define "Diabetic Retinopathy Encounter":
  "Qualifying Encounter During Measurement Period" ValidQualifyingEncounter
    with ["Condition": "Diabetic Retinopathy"] DiabeticRetinopathy
      such that DiabeticRetinopathy.prevalenceInterval ( ) overlaps ValidQualifyingEncounter.period
        and DiabeticRetinopathy.isActive ( )
        and not ( DiabeticRetinopathy.verificationStatus ~ QICoreCommon."unconfirmed"
            or DiabeticRetinopathy.verificationStatus ~ QICoreCommon."refuted"
            or DiabeticRetinopathy.verificationStatus ~ QICoreCommon."entered-in-error"
        )

define "Macular Exam Performed":
  ["Observation": "Macular Exam"] MacularExam
    with "Diabetic Retinopathy Encounter" EncounterDiabeticRetinopathy
      such that MacularExam.effective.toInterval ( ) during EncounterDiabeticRetinopathy.period
    where MacularExam.value is not null
      and MacularExam.status in { 'final', 'amended', 'corrected', 'preliminary' }

define "Results of Dilated Macular or Fundus Exam Communicated":
  exists "Level of Severity of Retinopathy Findings Communicated"
    and ( exists "Macular Edema Absence Communicated"
        or exists "Macular Edema Presence Communicated"
    )

define "Level of Severity of Retinopathy Findings Communicated":
  ["Communication": "Level of Severity of Retinopathy Findings"] LevelOfSeverityCommunicated
    with "Diabetic Retinopathy Encounter" EncounterDiabeticRetinopathy
      such that LevelOfSeverityCommunicated.sent after start of EncounterDiabeticRetinopathy.period
        and LevelOfSeverityCommunicated.sent during day of "Measurement Period"
    where LevelOfSeverityCommunicated.status = 'completed'

define "Macular Edema Absence Communicated":
  ["Communication": "Macular edema absent (situation)"] MacularEdemaAbsentCommunicated
    with "Diabetic Retinopathy Encounter" EncounterDiabeticRetinopathy
      such that MacularEdemaAbsentCommunicated.sent after start of EncounterDiabeticRetinopathy.period
        and MacularEdemaAbsentCommunicated.sent during day of "Measurement Period"
    where MacularEdemaAbsentCommunicated.status = 'completed'

define "Macular Edema Presence Communicated":
  ["Communication": "Macular Edema Findings Present"] MacularEdemaPresentCommunicated
    with "Diabetic Retinopathy Encounter" EncounterDiabeticRetinopathy
      such that MacularEdemaPresentCommunicated.sent after start of EncounterDiabeticRetinopathy.period
        and MacularEdemaPresentCommunicated.sent during day of "Measurement Period"
    where MacularEdemaPresentCommunicated.status = 'completed'

define "Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy":
  [CommunicationNotDone: "Level of Severity of Retinopathy Findings"] LevelOfSeverityNotCommunicated
    with "Diabetic Retinopathy Encounter" EncounterDiabeticRetinopathy
      such that LevelOfSeverityNotCommunicated.recorded during EncounterDiabeticRetinopathy.period
    where ( LevelOfSeverityNotCommunicated.statusReason in "Medical Reason"
        or LevelOfSeverityNotCommunicated.statusReason in "Patient Reason"
    )

define "Medical or Patient Reason for Not Communicating Presence of Macular Edema":
  [CommunicationNotDone: "Macular Edema Findings Present"] MacularEdemaPresentNotCommunicated
    with "Diabetic Retinopathy Encounter" EncounterDiabeticRetinopathy
      such that MacularEdemaPresentNotCommunicated.recorded during EncounterDiabeticRetinopathy.period
    where ( MacularEdemaPresentNotCommunicated.statusReason in "Medical Reason"
        or MacularEdemaPresentNotCommunicated.statusReason in "Patient Reason"
    ) 

/* Note: 
below definition workaround for 
https://oncprojectracking.healthit.gov/support/browse/CQLIT-371. Using value set workaround has been applied for now
but when QI Core STU 5 gets in the tool, it may be reverted back to a DRC */


define "Medical or Patient Reason for Not Communicating Absence of Macular Edema":
  [CommunicationNotDone: "Macular edema absent (situation)"] MacularEdemaAbsentNotCommunicated
    with "Diabetic Retinopathy Encounter" EncounterDiabeticRetinopathy
      such that MacularEdemaAbsentNotCommunicated.recorded during EncounterDiabeticRetinopathy.period
    where ( MacularEdemaAbsentNotCommunicated.statusReason in "Medical Reason"
        or MacularEdemaAbsentNotCommunicated.statusReason in "Patient Reason"
    )
