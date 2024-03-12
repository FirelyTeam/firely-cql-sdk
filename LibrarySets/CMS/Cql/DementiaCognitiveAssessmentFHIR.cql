library DementiaCognitiveAssessmentFHIR version '0.1.000'

using QICore version '4.1.1'

/*Note ws 1. 8/09/2023: Negation issue as outlined in BonnieMat-1455 and ticket https://github.com/cqframework/cql-execution/issues/296 */


include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include QICoreCommon version '2.0.000' called QICoreCommon

codesystem "ActCode": 'http://terminology.hl7.org/CodeSystem/v3-ActCode'

valueset "Behavioral/Neuropsych Assessment": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1023'
valueset "Care Services in Long Term Residential Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014'
valueset "Cognitive Assessment": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1332'
valueset "Dementia & Mental Degenerations": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1005'
valueset "Face-to-Face Interaction": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Nursing Facility Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012'
valueset "Occupational Therapy Evaluation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1011'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008'
valueset "Patient Provider Interaction": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012'
valueset "Patient Reason": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008'
valueset "Psych Visit Diagnostic Evaluation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492'
valueset "Psych Visit Psychotherapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496'
valueset "Standardized Tools Score for Assessment of Cognition": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1006'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "Initial Population":
  exists "Dementia Encounter During Measurement Period"
    and ( Count("Qualifying Encounter During Measurement Period") >= 2 )

define "Denominator":
  "Initial Population"

define "Numerator":
  exists "Assessment of Cognition Using Standardized Tools or Alternate Methods"

define "Denominator Exceptions":
  exists "Patient Reason for Not Performing Assessment of Cognition Using Standardized Tools or Alternate Methods"

define "Assessment of Cognition Using Standardized Tools or Alternate Methods":
  ( ["Observation": "Standardized Tools Score for Assessment of Cognition"]
    union ["Observation": "Cognitive Assessment"] ) CognitiveAssessment
    with "Dementia Encounter During Measurement Period" EncounterDementia
      such that CognitiveAssessment.effective.toInterval ( ) starts 12 months or less on or before day of end of EncounterDementia.period
    where CognitiveAssessment.value is not null
      and CognitiveAssessment.status in { 'final', 'amended', 'corrected', 'preliminary' }

define "Dementia Encounter During Measurement Period":
  "Encounter to Assess Cognition" EncounterAssessCognition
    with [Condition: "Dementia & Mental Degenerations"] Dementia
      such that EncounterAssessCognition.period during "Measurement Period"
        and Dementia.prevalenceInterval ( ) overlaps day of EncounterAssessCognition.period
        and Dementia.isActive ( )
        and not ( Dementia.verificationStatus ~ QICoreCommon."unconfirmed"
            or Dementia.verificationStatus ~ QICoreCommon."refuted"
            or Dementia.verificationStatus ~ QICoreCommon."entered-in-error"
        )

define "Encounter to Assess Cognition":
  ["Encounter": "Psych Visit Diagnostic Evaluation"]
    union ["Encounter": "Nursing Facility Visit"]
    union ["Encounter": "Care Services in Long Term Residential Facility"]
    union ["Encounter": "Home Healthcare Services"]
    union ["Encounter": "Psych Visit Psychotherapy"]
    union ["Encounter": "Behavioral/Neuropsych Assessment"]
    union ["Encounter": "Occupational Therapy Evaluation"]
    union ["Encounter": "Office Visit"]
    union ["Encounter": "Outpatient Consultation"]

define "Patient Reason for Not Performing Assessment of Cognition Using Standardized Tools or Alternate Methods":
/*8/09/2023: Negation issue as outlined in BonnieMat-1455 and ticket https://github.com/cqframework/cql-execution/issues/296 */
  
  ( [ObservationNotDone: code in "Standardized Tools Score for Assessment of Cognition"]
    union [ObservationNotDone: code in "Cognitive Assessment"] ) NoCognitiveAssessment
    with "Dementia Encounter During Measurement Period" EncounterDementia
      such that NoCognitiveAssessment.issued during EncounterDementia.period
    where NoCognitiveAssessment.notDoneReason in "Patient Reason"

define "Qualifying Encounter During Measurement Period":
  ( "Encounter to Assess Cognition"
    union ["Encounter": "Patient Provider Interaction"] ) ValidEncounter
    where ValidEncounter.period during "Measurement Period"
      and ValidEncounter.status = 'finished'

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "SDE Payer":
  SDE."SDE Payer"
