library CMS819FHIRHHORAE version '1.0.000'

using QICore version '6.0.0'

include SupplementalDataElements version '5.1.000' called SDE
include CQMCommon version '4.1.000' called CQMCommon
include QICoreCommon version '4.0.000' called QICoreCommon
include FHIRHelpers version '4.4.000' called FHIRHelpers

codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Operating Room Suite": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.141'
valueset "Opioid Antagonist": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.119'
valueset "Opioids, All": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.226'
valueset "Routes of Administration for Opioid Antagonists": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.187'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Denominator":
  "Initial Population"

define "Initial Population":
  "Encounter With Opioid Administration Outside Of Operating Room"

define "Numerator":
  "Encounter With NonOperating Room Opioid And Antagonist Administration"

define "Opioid Administration":
  ["MedicationAdministration": "Opioids, All"] Opioids
    where Opioids.status = 'completed'

define "Non Enteral Opioid Antagonist Administration":
  ["MedicationAdministration": "Opioid Antagonist"] AntagonistGiven
    where AntagonistGiven.status = 'completed'

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

define "Encounter With Opioid Administration Outside Of Operating Room":
  "Qualifying Encounter" InpatientEncounter
    with "Opioid Administration" OpioidGiven
      such that OpioidGiven.effective.toInterval ( ) starts during InpatientEncounter.hospitalizationWithObservation ( )
        and not exists ( InpatientEncounter.location EncounterLocation
            where EncounterLocation.location.getLocation ( ).type in "Operating Room Suite"
              and OpioidGiven.effective.toInterval ( ) starts during EncounterLocation.period
        )


 /*
@author: Measure developer
@description: Provides guidance to implementers to interpret logic in following defintion correctly
@comment:Excludes opioid antagonist administered in operating room AND excludes opioids administered in operating room AND opioid is administered before opioid antagonist AND limits opioid antagonist to non-enteral routes
 */


define "Encounter With NonOperating Room Opioid And Antagonist Administration":
  from
    "Non Enteral Opioid Antagonist Administration" NonEnteralOpioidAntagonistGiven,
    "Opioid Administration" OpioidGiven,
    "Denominator" InpatientHospitalization
    where not exists ( InpatientHospitalization.location EncounterLocation
        where EncounterLocation.location.getLocation ( ).type in "Operating Room Suite"
          and NonEnteralOpioidAntagonistGiven.effective.toInterval ( ) starts during EncounterLocation.period
    )
      and ( NonEnteralOpioidAntagonistGiven.effective.toInterval ( ) starts during InpatientHospitalization.hospitalizationWithObservation ( )
          and OpioidGiven.effective.toInterval ( ) starts during InpatientHospitalization.hospitalizationWithObservation ( )
          and OpioidGiven.effective.toInterval ( ) ends 12 hours or less before start of NonEnteralOpioidAntagonistGiven.effective.toInterval ( )
          and NonEnteralOpioidAntagonistGiven.dosage.route in "Routes of Administration for Opioid Antagonists"
      )
    return InpatientHospitalization