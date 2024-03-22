library AHAOverall version '2.6.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include QICoreCommon version '2.0.000' called QICoreCommon

codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "AllergyIntoleranceVerificationStatusCodes": 'http://terminology.hl7.org/CodeSystem/allergyintolerance-verification'

valueset "Care Services in Long Term Residential Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014'
valueset "Ejection Fraction": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134'
valueset "Heart Failure": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376'
valueset "Heart Transplant": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.33'
valueset "Heart Transplant Complications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.56'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Left Ventricular Assist Device Complications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.58'
valueset "Left Ventricular Assist Device Placement": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61'
valueset "Moderate or Severe": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092'
valueset "Moderate or Severe LVSD": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090'
valueset "Nursing Facility Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008'
valueset "Patient Provider Interaction": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012'

code "Left ventricular systolic dysfunction (disorder)": '134401001' from "SNOMEDCT" display 'Left ventricular systolic dysfunction (disorder)'
code "allergy-entered-in-error": 'entered-in-error' from AllergyIntoleranceVerificationStatusCodes

parameter "Measurement Period" Interval<DateTime>default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0 )

context Patient

define "Heart Failure Outpatient Encounter":
  ( [Encounter: "Care Services in Long Term Residential Facility"]
      union [Encounter: "Home Healthcare Services"]
      union [Encounter: "Nursing Facility Visit"]
      union [Encounter: "Office Visit"]
      union [Encounter: "Outpatient Consultation"]
     ) QualifyingEncounter
    with [Condition: "Heart Failure"] HeartFailure
      such that HeartFailure.prevalenceInterval() overlaps QualifyingEncounter.period
        and HeartFailure.isConfirmedActiveDiagnosis()
    where QualifyingEncounter.period during "Measurement Period"
      and QualifyingEncounter.isFinished()

define "Has Heart Transplant Complications":
  exists (
          [Condition: "Heart Transplant Complications"] HeartTransplantComplications
            with "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
              such that ( Coalesce( HeartTransplantComplications.recordedDate.toInterval(), HeartTransplantComplications.prevalenceInterval() ) ) starts before end of ModerateOrSevereLVSDHFOutpatientEncounter.period
            where HeartTransplantComplications.isConfirmedActiveDiagnosis()
          )

define "Has Left Ventricular Assist Device":
  exists (
            [Procedure: "Left Ventricular Assist Device Placement"] LVADOutpatient
              with "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
                such that LVADOutpatient.performed.toInterval() starts before end of ModerateOrSevereLVSDHFOutpatientEncounter.period
              where LVADOutpatient.status = 'completed'
            )

define "Has Left Ventricular Assist Device Complications":
  exists (
            [Condition: "Left Ventricular Assist Device Complications"] LVADComplications
              with "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
                such that ( Coalesce( LVADComplications.recordedDate.toInterval(), LVADComplications.prevalenceInterval() ) ) starts before end of ModerateOrSevereLVSDHFOutpatientEncounter.period
              where LVADComplications.isConfirmedActiveDiagnosis()
          )

define "Has Two Qualifying Outpatient Encounters and Heart Failure Outpatient Encounter During the Measurement Period":
  AgeInYearsAt(date from start of "Measurement Period") >= 18
    and exists ( "Qualifying Outpatient Encounter During Measurement Period" Encounter1
        with "Qualifying Outpatient Encounter During Measurement Period" Encounter2
          such that Encounter2.id !~ Encounter1.id
    )
    and exists "Heart Failure Outpatient Encounter"

define "Moderate or Severe LVSD Findings":
    ( [Observation: "Ejection Fraction"] EjectionFraction
        where EjectionFraction.value as Quantity <= 40 '%'
         and EjectionFraction.status in {'final', 'amended', 'corrected'}
      )
    union [Condition: "Moderate or Severe LVSD"]
    union ( [Condition: "Left ventricular systolic dysfunction (disorder)"] LVSDDiagnosis
             where LVSDDiagnosis.severity in "Moderate or Severe"
           )

define "Qualifying Outpatient Encounter During Measurement Period":
    ( [Encounter: "Care Services in Long Term Residential Facility"]
              union [Encounter: "Home Healthcare Services"]
              union [Encounter: "Nursing Facility Visit"]
              union [Encounter: "Office Visit"]
              union [Encounter: "Outpatient Consultation"]
              union [Encounter: "Patient Provider Interaction"]
     ) ValidEncounter
      where ValidEncounter.period during "Measurement Period"
        and ValidEncounter.isFinished()

define "Has Heart Transplant":
  exists (
          [Procedure: "Heart Transplant"] HeartTransplant
            with "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
              such that HeartTransplant.performed.toInterval() starts before end of ModerateOrSevereLVSDHFOutpatientEncounter.period
            where HeartTransplant.status = 'completed'
          )

define "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD":
    "Heart Failure Outpatient Encounter" HFOutpatientEncounter
        with "Moderate or Severe LVSD Findings" LVSDFindings
            such that Coalesce(LVSDFindings.prevalenceInterval(), LVSDFindings.effective.toInterval()) starts before end of HFOutpatientEncounter.period

define fluent function isConfirmedActiveDiagnosis(Condition Condition):
  ( Condition Diagnosis
    where Diagnosis.clinicalStatus ~ QICoreCommon."active"
        and not ( Diagnosis.verificationStatus ~ QICoreCommon."unconfirmed"
                     or Diagnosis.verificationStatus ~ QICoreCommon."refuted"
                     or Diagnosis.verificationStatus ~ QICoreCommon."entered-in-error" )
    ) is not null

define fluent function isFinished(Visit Encounter):
  Visit.status = 'finished'

define fluent function isOrderedDuringHeartFailureOutpatientEncounter(Order MedicationRequest):
  exists ( "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
            where Order.authoredOn during day of ModerateOrSevereLVSDHFOutpatientEncounter.period
              and Order.status in {'active', 'completed'}
              and Order.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
              and Order.doNotPerform is not true
          )

define fluent function overlapsHeartFailureOutpatientEncounter(Diagnosis Condition):
  exists ( "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
            where Diagnosis.prevalenceInterval() overlaps day of ModerateOrSevereLVSDHFOutpatientEncounter.period
              and Diagnosis.isConfirmedActiveDiagnosis()
          )

define fluent function overlapsAfterHeartFailureOutpatientEncounter(Event Choice<Condition, Procedure, AllergyIntolerance, MedicationRequest, "observation-heartrate">):
  exists ( "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
            where
              case
                when Event is Condition then
                  (Event as Condition).prevalenceInterval() overlaps after day of ModerateOrSevereLVSDHFOutpatientEncounter.period
                    and (Event as Condition).isConfirmedActiveDiagnosis()
                when Event is Procedure then
                  (Event as Procedure).performed.toInterval() overlaps after day of ModerateOrSevereLVSDHFOutpatientEncounter.period
                    and (Event as Procedure).status = 'completed'
                when Event is AllergyIntolerance then
                  Interval[start of (Event as AllergyIntolerance).onset.toInterval(), (Event as AllergyIntolerance).lastOccurrence] overlaps after day of ModerateOrSevereLVSDHFOutpatientEncounter.period
                    and (Event as AllergyIntolerance).clinicalStatus ~ QICoreCommon."allergy-active"
                    and not ((Event as AllergyIntolerance).verificationStatus ~ QICoreCommon."allergy-unconfirmed"
                        or (Event as AllergyIntolerance).verificationStatus ~ QICoreCommon."allergy-refuted"
                        or (Event as AllergyIntolerance).verificationStatus ~ "allergy-entered-in-error")
                when Event is MedicationRequest then
                  First( ( collapse (Event.dosageInstruction.timing.repeat.bounds DoseTime
                                        return DoseTime.toInterval()) ) DrugPeriods
                           sort by start of $this ) overlaps after day of ModerateOrSevereLVSDHFOutpatientEncounter.period
                    and (Event as MedicationRequest).status in { 'active', 'completed' }
                    and (Event as MedicationRequest).intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
                    and (Event as MedicationRequest).doNotPerform is not true
                when Event is "observation-heartrate" then
                  (Event as "observation-heartrate").effective.toInterval() overlaps after day of ModerateOrSevereLVSDHFOutpatientEncounter.period
                    and (Event as "observation-heartrate").status in {'final', 'amended', 'corrected'}
                else false
              end
          )
