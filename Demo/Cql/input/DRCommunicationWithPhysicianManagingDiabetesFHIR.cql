library DRCommunicationWithPhysicianManagingDiabetesFHIR version '0.0.004'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.001' called FHIRHelpers
include SupplementalDataElementsFHIR4 version '2.0.000' called SDE
include MATGlobalCommonFunctionsFHIR4 version '6.1.000' called Global

codesystem "LOINC": 'http://loinc.org' 
codesystem "SNOMEDCT": 'http://snomed.info/sct' 

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

code "Birth date": '21112-8' from "LOINC" display 'Birth date'
code "Healthcare professional (occupation)": '223366009' from "SNOMEDCT" display 'Healthcare professional (occupation)'
code "Macular edema absent (situation)": '428341000124108' from "SNOMEDCT" display 'Macular edema absent (situation)'
code "Medical practitioner (occupation)": '158965000' from "SNOMEDCT" display 'Medical practitioner (occupation)'
code "Ophthalmologist (occupation)": '422234006' from "SNOMEDCT" display 'Ophthalmologist (occupation)'
code "Optometrist (occupation)": '28229004' from "SNOMEDCT" display 'Optometrist (occupation)'
code "Physician (occupation)": '309343006' from "SNOMEDCT" display 'Physician (occupation)'

parameter "Measurement Period" Interval<DateTime>

context Patient

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Denominator Exceptions":
  exists "Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy"
          or exists "Medical or Patient Reason for Not Communicating Absence of Macular Edema"
          or exists "Medical or Patient Reason for Not Communicating Presence of Macular Edema"

define "Denominator":
  "Initial Population"
          and exists "Macular Exam Performed"

define "Results of Dilated Macular or Fundus Exam Communicated":
  exists "Level of Severity of Retinopathy Findings Communicated"
          and ( exists "Macular Edema Absence Communicated"
              or exists "Macular Edema Presence Communicated"
          )

define "Initial Population":
  AgeInYearsAt (start of "Measurement Period") >= 18
          and exists "Diabetic Retinopathy Encounter"

define "Diabetic Retinopathy Encounter":
  "Qualifying Encounter During Measurement Period" ValidQualifyingEncounter
          with ["Condition": "Diabetic Retinopathy"] DiabeticRetinopathy
            such that DiabeticRetinopathy.clinicalStatus ~ Global."active"
              and Global."Prevalence Period"(DiabeticRetinopathy) overlaps ValidQualifyingEncounter.period

define "Qualifying Encounter During Measurement Period":
  ( ["Encounter": "Office Visit"]
          union ["Encounter": "Ophthalmological Services"]
          union ["Encounter": "Outpatient Consultation"]
          union ["Encounter": "Care Services in Long-Term Residential Facility"]
          union ["Encounter": "Nursing Facility Visit"] ) QualifyingEncounter
          where QualifyingEncounter.period during "Measurement Period"
              and QualifyingEncounter.status = 'finished'

define "Numerator":
  exists "Level of Severity of Retinopathy Findings Communicated"
          and ( exists "Macular Edema Absence Communicated"
              or exists "Macular Edema Presence Communicated"
          )

define "Macular Exam Performed":
  ["Observation": "Macular Exam"] MacularExam
          with "Diabetic Retinopathy Encounter" EncounterDiabeticRetinopathy
            such that Global."Normalize Interval" (MacularExam.effective) during EncounterDiabeticRetinopathy.period
          where MacularExam.status in {'final', 'amended', 'corrected'}
              and MacularExam.value is not null

define "Medical or Patient Reason for Not Communicating Absence of Macular Edema":
  ["Communication": "Macular edema absent (situation)"] MacularEdemaAbsentNotCommunicated
    with "Diabetic Retinopathy Encounter" EncounterDiabeticRetinopathy
      such that Global."GetExtension" ( MacularEdemaAbsentNotCommunicated, 'qicore-recorded' ).value during EncounterDiabeticRetinopathy.period
    where MacularEdemaAbsentNotCommunicated.status = 'not-done'
      and "GetModifierExtension"(MacularEdemaAbsentNotCommunicated, 'qicore-notDone').value is true
      and ( MacularEdemaAbsentNotCommunicated.statusReason in "Medical Reason"
          or MacularEdemaAbsentNotCommunicated.statusReason in "Patient Reason"
      )

define "Medical or Patient Reason for Not Communicating Level of Severity of Retinopathy":
  ["Communication": "Level of Severity of Retinopathy Findings"] LevelOfSeverityNotCommunicated
    with "Diabetic Retinopathy Encounter" EncounterDiabeticRetinopathy
      such that Global."GetExtension" ( LevelOfSeverityNotCommunicated, 'qicore-recorded' ).value during EncounterDiabeticRetinopathy.period
    where LevelOfSeverityNotCommunicated.status = 'not-done'
      and "GetModifierExtension"(LevelOfSeverityNotCommunicated, 'qicore-notDone').value is true
      and ( LevelOfSeverityNotCommunicated.statusReason in "Medical Reason"
          or LevelOfSeverityNotCommunicated.statusReason in "Patient Reason"
      )

define "Medical or Patient Reason for Not Communicating Presence of Macular Edema":
  ["Communication": "Macular Edema Findings Present"] MacularEdemaPresentNotCommunicated
    with "Diabetic Retinopathy Encounter" EncounterDiabeticRetinopathy
      such that Global."GetExtension" ( MacularEdemaPresentNotCommunicated, 'qicore-recorded' ).value during EncounterDiabeticRetinopathy.period
    where MacularEdemaPresentNotCommunicated.status = 'not-done'
      and "GetModifierExtension"(MacularEdemaPresentNotCommunicated, 'qicore-notDone').value is true
      and ( MacularEdemaPresentNotCommunicated.statusReason in "Medical Reason"
          or MacularEdemaPresentNotCommunicated.statusReason in "Patient Reason"
      )

define "Level of Severity of Retinopathy Findings Communicated":
  ["Communication": "Level of Severity of Retinopathy Findings"] LevelOfSeverityCommunicated
    with "Diabetic Retinopathy Encounter" EncounterDiabeticRetinopathy
      such that LevelOfSeverityCommunicated.sent after start of EncounterDiabeticRetinopathy.period
    where LevelOfSeverityCommunicated.status = 'completed'

define "Macular Edema Absence Communicated":
  ["Communication": "Macular edema absent (situation)"] MacularEdemaAbsentCommunicated
    with "Diabetic Retinopathy Encounter" EncounterDiabeticRetinopathy
      such that MacularEdemaAbsentCommunicated.sent after start of EncounterDiabeticRetinopathy.period
    where MacularEdemaAbsentCommunicated.status = 'completed'

define "Macular Edema Presence Communicated":
  ["Communication": "Macular Edema Findings Present"] MacularEdemaPresentCommunicated
    with "Diabetic Retinopathy Encounter" EncounterDiabeticRetinopathy
      such that MacularEdemaPresentCommunicated.sent after start of EncounterDiabeticRetinopathy.period
    where MacularEdemaPresentCommunicated.status = 'completed'

define function "GetModifierExtensions"(domainResource DomainResource, url String ):
  domainResource.modifierExtension E
      where E.url = ('http://hl7.org/fhir/us/qicore/StructureDefinition/' + url)
        return E

define function "GetModifierExtension"(domainResource DomainResource, url String ):
  singleton from "GetModifierExtensions"(domainResource, url)

