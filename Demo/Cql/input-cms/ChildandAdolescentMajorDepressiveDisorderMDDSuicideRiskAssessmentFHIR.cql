library ChildandAdolescentMajorDepressiveDisorderMDDSuicideRiskAssessmentFHIR version '0.1.000'

using QICore version '4.1.1'

include SupplementalDataElements version '3.4.000' called SDE
include QICoreCommon version '2.0.000' called QICoreCommon
include FHIRHelpers version '4.3.000' called FHIRHelpers
include CQMCommon version '2.0.000' called CQMCommon

codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "ActCode": 'http://terminology.hl7.org/CodeSystem/v3-ActCode'
codesystem "ICD10CM": 'http://hl7.org/fhir/sid/icd-10-cm'

valueset "Group Psychotherapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1187'
valueset "Major Depressive Disorder Active": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1491'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008'
valueset "Psych Visit Diagnostic Evaluation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492'
valueset "Psych Visit for Family Psychotherapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1018'
valueset "Psych Visit Psychotherapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496'
valueset "Psychoanalysis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141'
valueset "Telehealth Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1031'

code "Birth date": '21112-8' from "LOINC" display 'Birth date'
code "Suicide risk assessment (procedure)": '225337009' from "SNOMEDCT" display 'Suicide risk assessment (procedure)'
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
  "Major Depressive Disorder Encounter" MDDEncounter
    where ( "AgeInYearsAt"(date from start of "Measurement Period") >= 6
        and "AgeInYearsAt"(date from start of "Measurement Period") <= 16
    )

define "Denominator":
  "Initial Population"

define "Numerator":
  "Major Depressive Disorder Encounter" MDDEncounter
    with ["Procedure": "Suicide risk assessment (procedure)"] SuicideRiskAssessment
      such that SuicideRiskAssessment.status = 'completed'
        and QICoreCommon."ToInterval" ( SuicideRiskAssessment.performed ) during MDDEncounter.period

define "Major Depressive Disorder Encounter":
  ( ["Encounter": "Office Visit"]
    union ["Encounter": "Outpatient Consultation"]
    union ["Encounter": "Psych Visit Diagnostic Evaluation"]
    union ["Encounter": "Psych Visit for Family Psychotherapy"]
    union ["Encounter": "Psych Visit Psychotherapy"]
    union ["Encounter": "Psychoanalysis"]
    union ["Encounter": "Group Psychotherapy"]
    union ["Encounter": "Telehealth Services"] ) ValidEncounter
    where ValidEncounter.status = 'finished'
      and ( ValidEncounter.reasonCode in "Major Depressive Disorder Active"
          or exists ( ( CQMCommon."EncounterDiagnosis" ( ValidEncounter ) ) EncounterDiagnosis
              where EncounterDiagnosis.code in "Major Depressive Disorder Active"
          )
      )
      and ValidEncounter.period during "Measurement Period"