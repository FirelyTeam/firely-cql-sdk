library CMS177FHIRChildMDDSuicideAssmt version '1.0.000'

using QICore version '6.0.0'

include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon
include FHIRHelpers version '4.4.000' called FHIRHelpers
include CQMCommon version '4.1.000' called CQMCommon

codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Group Psychotherapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1187'
valueset "Major Depressive Disorder Active": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1491'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008'
valueset "Psych Visit Diagnostic Evaluation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492'
valueset "Psych Visit for Family Psychotherapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1018'
valueset "Psych Visit Psychotherapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496'
valueset "Psychoanalysis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1141'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'

code "Suicide risk assessment (procedure)": '225337009' from "SNOMEDCT" display 'Suicide risk assessment (procedure)'

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
  "Major Depressive Disorder Encounter" MDDEncounter
    where ( "AgeInYearsAt"(date from start of "Measurement Period") >= 6
        and "AgeInYearsAt"(date from start of "Measurement Period") <= 16
    )

define "Denominator":
  "Initial Population"

define "Numerator":
  "Encounter With Procedure For Suicide Risk Assessment"
    union "Encounter With Observation For Suicide Risk Assessment"

define "Encounter With Procedure For Suicide Risk Assessment":
  "Major Depressive Disorder Encounter" MDDEncounter
    with ["Procedure": "Suicide risk assessment (procedure)"] SuicideRiskAssessmentProcedure
      such that SuicideRiskAssessmentProcedure.status = 'completed'
        and SuicideRiskAssessmentProcedure.performed.toInterval ( ) during MDDEncounter.period

define "Encounter With Observation For Suicide Risk Assessment":
  "Major Depressive Disorder Encounter" MDDEncounter
    with ( ["ObservationScreeningAssessment": "Suicide risk assessment (procedure)"]
      union ["ObservationClinicalResult": "Suicide risk assessment (procedure)"] ) ObservationSuicideRiskAssmt
      such that ObservationSuicideRiskAssmt.effective.toInterval ( ) during MDDEncounter.period
        and ObservationSuicideRiskAssmt.status in { 'final', 'corrected', 'amended' }

define "Major Depressive Disorder Encounter":
  "Encounter With Condition Major Depressive Disorder"
    union "Encounter With Reason Major Depressive Disorder"

define "Encounter With Condition Major Depressive Disorder":
  ( ["Encounter": "Office Visit"]
    union ["Encounter": "Outpatient Consultation"]
    union ["Encounter": "Psych Visit Diagnostic Evaluation"]
    union ["Encounter": "Psych Visit for Family Psychotherapy"]
    union ["Encounter": "Psych Visit Psychotherapy"]
    union ["Encounter": "Psychoanalysis"]
    union ["Encounter": "Group Psychotherapy"]
    union ["Encounter": "Telephone Visits"] ) ValidEncounter
    where ValidEncounter.status = 'finished'
      and ValidEncounter.period during day of "Measurement Period"
      and exists ( ( ["ConditionProblemsHealthConcerns": "Major Depressive Disorder Active"] MDDConditionProb
            where ValidEncounter.reasonReference.references ( MDDConditionProb )
        )
          union ( ["ConditionEncounterDiagnosis": "Major Depressive Disorder Active"] MDDEncDx
              where ValidEncounter.reasonReference.references ( MDDEncDx )
          )
      )

define "Encounter With Reason Major Depressive Disorder":
  ( ["Encounter": "Office Visit"]
    union ["Encounter": "Outpatient Consultation"]
    union ["Encounter": "Psych Visit Diagnostic Evaluation"]
    union ["Encounter": "Psych Visit for Family Psychotherapy"]
    union ["Encounter": "Psych Visit Psychotherapy"]
    union ["Encounter": "Psychoanalysis"]
    union ["Encounter": "Group Psychotherapy"]
    union ["Encounter": "Telephone Visits"] ) ValidEncounter
    where ValidEncounter.status = 'finished'
      and ValidEncounter.period during day of "Measurement Period"
      and ( ValidEncounter.reasonCode in "Major Depressive Disorder Active" )