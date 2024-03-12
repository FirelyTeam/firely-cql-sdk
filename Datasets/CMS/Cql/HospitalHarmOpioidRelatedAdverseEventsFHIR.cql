library HospitalHarmOpioidRelatedAdverseEventsFHIR version '0.1.000'

using QICore version '4.1.1'

include SupplementalDataElements version '3.4.000' called SDE
include CQMCommon version '2.0.000' called CQMCommon
include QICoreCommon version '2.0.000' called QICoreCommon
include FHIRHelpers version '4.3.000' called FHIRHelpers

codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "HSLOC": 'http://cts.nlm.nih.gov/fhir/cs/hsloc'

valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Observation Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143'
valueset "Operating Room Suite": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.141'
valueset "Opioid Antagonist": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.119'
valueset "Opioids, All": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.226'
valueset "Routes of Administration for Opioid Antagonists": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.187'

code "Dead": '419099009' from "SNOMEDCT" display 'Dead'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "Denominator":
  "Initial Population"

define "Initial Population":
  "Encounter with Opioid Administration Outside of Operating Room"

define "Numerator":
  "Encounter with Non Enteral Opioid Antagonist Administration Outside of Operating Room and within 12 Hrs After Opioid"

define "Opioid Administration":
  ["MedicationAdministration": "Opioids, All"] Opioids
    where Opioids.status = 'completed'
      and Opioids.status != 'not-done'

define "Opioid Antagonist Administration":
  ["MedicationAdministration": "Opioid Antagonist"] AntagonistGiven
    where AntagonistGiven.status = 'completed'
      and AntagonistGiven.status != 'not-done'

define "Qualifying Encounter":
  ["Encounter": "Encounter Inpatient"] InpatientEncounter
    where AgeInYearsAt(date from start of InpatientEncounter.period) >= 18
      and InpatientEncounter.period ends during day of "Measurement Period"
      and InpatientEncounter.status = 'finished'

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Encounter with Opioid Administration Outside of Operating Room":
  "Qualifying Encounter" InpatientEncounter
    with "Opioid Administration" OpioidGiven
      such that QICoreCommon."ToInterval" ( OpioidGiven.effective ) starts during CQMCommon."HospitalizationWithObservation" ( InpatientEncounter )
        and not exists ( InpatientEncounter.location EncounterLocation
            where CQMCommon.GetLocation ( EncounterLocation.location ).type in "Operating Room Suite"
              and QICoreCommon."ToInterval" ( OpioidGiven.effective ) starts during EncounterLocation.period
        )

define "Encounter with Non Enteral Opioid Antagonist Administration Outside of Operating Room and within 12 Hrs After Opioid":
  // Opioids administered before opioid antagonist AND excludes opioid antagonist administered in operating room AND limits opioid antagonist to non-enteral routes//
  
  from
    "Opioid Antagonist Administration" OpioidAntagonistGiven,
    "Opioid Administration" OpioidGiven,
    "Denominator" EncounterWithQualifyingAge
    where not exists ( EncounterWithQualifyingAge.location EncounterLocation
        where CQMCommon.GetLocation ( EncounterLocation.location ).type in "Operating Room Suite"
          and QICoreCommon."ToInterval" ( OpioidAntagonistGiven.effective ) starts during EncounterLocation.period
    )
      and ( QICoreCommon."ToInterval" ( OpioidAntagonistGiven.effective ) starts during CQMCommon."HospitalizationWithObservation" ( EncounterWithQualifyingAge )
          and QICoreCommon."ToInterval" ( OpioidGiven.effective ) starts during CQMCommon."HospitalizationWithObservation" ( EncounterWithQualifyingAge )
          and QICoreCommon."ToInterval" ( OpioidGiven.effective ) ends 12 hours or less before start of QICoreCommon."ToInterval" ( OpioidAntagonistGiven.effective )
          and OpioidAntagonistGiven.dosage.route in "Routes of Administration for Opioid Antagonists"
      )
    return EncounterWithQualifyingAge