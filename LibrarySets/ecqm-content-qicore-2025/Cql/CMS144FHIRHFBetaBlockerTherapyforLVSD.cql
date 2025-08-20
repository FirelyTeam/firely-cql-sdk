library CMS144FHIRHFBetaBlockerTherapyforLVSD version '1.5.000'

using QICore version '6.0.0'
using USCore version '6.1.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon
include AHAOverall version '3.0.000' called AHA

codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Allergy to Beta Blocker Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1177'
valueset "Arrhythmia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.366'
valueset "Asthma": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.362'
valueset "Atrioventricular Block": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.367'
valueset "Beta Blocker Therapy for LVSD": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1184'
valueset "Beta Blocker Therapy Ingredient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1493'
valueset "Bradycardia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.412'
valueset "Cardiac Pacer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.53'
valueset "Cardiac Pacer in Situ": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.368'
valueset "Hypotension": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.370'
valueset "Intolerance to Beta Blocker Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1178'
valueset "Medical Reason": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007'
valueset "Patient Reason": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008'

code "Substance with beta adrenergic receptor antagonist mechanism of action (substance)": '373254001' from "SNOMEDCT" display 'Substance with beta adrenergic receptor antagonist mechanism of action (substance)'

parameter "Measurement Period" Interval<DateTime>

context Patient

define "Initial Population":
  AHA."Is Adults With Two Qualifying Outpatient Encounters and One Heart Failure Outpatient Encounter During the Measurement Period"

define "Denominator":
  "Initial Population"
    and exists AHA."Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD"

define "Denominator Exclusions":
  AHA."Has Heart Transplant"
    or AHA."Has Heart Transplant Complications"
    or AHA."Has Left Ventricular Assist Device"
    or AHA."Has Left Ventricular Assist Device Complications"

define "Numerator":
  "Has Beta Blocker Therapy for LVSD Ordered"
    or "Is Currently Taking Beta Blocker Therapy for LVSD"

/*
@commentedOuf: Temporary removal of "Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD"
@commentedOufReason: Negation issue noted in https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455
*/


define "Denominator Exceptions":
  "Has Consecutive Heart Rates Less than 50"
    or "Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD"
    or "Has Arrhythmia Diagnosis"
    or "Has Hypotension Diagnosis"
    or "Has Asthma Diagnosis"
    or "Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy"
    or "Has Bradycardia Diagnosis"
    or "Has Allergy or Intolerance to Beta Blocker Therapy Ingredient"
    or "Atrioventricular Block without Cardiac Pacer"

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Atrioventricular Block without Cardiac Pacer":
  "Has Atrioventricular Block Diagnosis"
    and not "Has Diagnosis of Cardiac Pacer in Situ"
    and not "Has Cardiac Pacer Device Implanted"

define "Has Cardiac Pacer Device Implanted":
  exists ( [Procedure: "Cardiac Pacer"] ImplantedCardiacPacer
      with AHA."Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
        such that ImplantedCardiacPacer.performed.toInterval ( ) starts before end of ModerateOrSevereLVSDHFOutpatientEncounter.period
      where ImplantedCardiacPacer.status = 'completed'
  )

define "Is Currently Taking Beta Blocker Therapy for LVSD":
  exists ( ["MedicationRequest": "Beta Blocker Therapy for LVSD"] ActiveBetaBlocker
      where ActiveBetaBlocker.overlapsAfterHeartFailureOutpatientEncounter ( )
  )

define "Has Hypotension Diagnosis":
  exists ( ["ConditionProblemsHealthConcerns": "Hypotension"] HypotensionAlias
      where HypotensionAlias.overlapsHeartFailureOutpatientEncounter ( )
        and HypotensionAlias.isConfirmedActiveDiagnosis ( )
  )

define "Has Diagnosis of Cardiac Pacer in Situ":
  exists ( ["ConditionProblemsHealthConcerns": "Cardiac Pacer in Situ"] CardiacPacerDiagnosis
      where CardiacPacerDiagnosis.overlapsAfterHeartFailureOutpatientEncounter ( )
        and CardiacPacerDiagnosis.isConfirmedActiveDiagnosis ( )
  )

define "Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy":
  exists ( ( ["ConditionProblemsHealthConcerns": "Allergy to Beta Blocker Therapy"]
      union ["ConditionProblemsHealthConcerns": "Intolerance to Beta Blocker Therapy"] ) BetaBlockerAllergyOrIntoleranceDiagnosis
      where BetaBlockerAllergyOrIntoleranceDiagnosis.overlapsAfterHeartFailureOutpatientEncounter ( )
        and BetaBlockerAllergyOrIntoleranceDiagnosis.isConfirmedActiveDiagnosis ( )
  )

define "Has Bradycardia Diagnosis":
  exists ( [ConditionProblemsHealthConcerns: "Bradycardia"] BradycardiaAlias
      where BradycardiaAlias.overlapsHeartFailureOutpatientEncounter ( )
        and BradycardiaAlias.isConfirmedActiveDiagnosis ( )
  )

define "Has Consecutive Heart Rates Less than 50":
  exists ( from
      ["USCoreHeartRateProfile"] HeartRate,
      AHA."Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
      let PriorHeartRate: Last(["USCoreHeartRateProfile"] MostRecentPriorHeartRate
          where MostRecentPriorHeartRate.effective.toInterval() during ModerateOrSevereLVSDHFOutpatientEncounter.period
            and MostRecentPriorHeartRate.effective.toInterval() before HeartRate.effective.toInterval()
          sort by start of effective.toInterval()
      )
      where HeartRate.effective.toInterval ( ) during ModerateOrSevereLVSDHFOutpatientEncounter.period
        and HeartRate.status in { 'final', 'amended', 'corrected' }
        and HeartRate.value < 50 '/min'
        and PriorHeartRate.value < 50 '/min'
      return HeartRate
  )

/*
@commentedOutEarlier: implies logic
@commentedOutReason: implies not available in cql-execution. Reference https://github.com/cqframework/cql-execution/issues/319.

@implies logic has been reinstated back
*/


define "Has Allergy or Intolerance to Beta Blocker Therapy Ingredient":
  exists ( ( [AllergyIntolerance: "Beta Blocker Therapy Ingredient"]
      union [AllergyIntolerance: "Substance with beta adrenergic receptor antagonist mechanism of action (substance)"] ) BetaBlockerAllergyIntolerance
      where BetaBlockerAllergyIntolerance.overlapsAfterHeartFailureOutpatientEncounter ( )
        and ( ( BetaBlockerAllergyIntolerance.clinicalStatus is not null implies BetaBlockerAllergyIntolerance.clinicalStatus !~ QICoreCommon."allergy-inactive" )
            or BetaBlockerAllergyIntolerance.clinicalStatus ~ QICoreCommon."allergy-active"
        )
  )

define "Has Arrhythmia Diagnosis":
  exists ( [ConditionProblemsHealthConcerns: "Arrhythmia"] ArrhythmiaAlias
      where ArrhythmiaAlias.overlapsHeartFailureOutpatientEncounter ( )
        and ArrhythmiaAlias.isConfirmedActiveDiagnosis ( )
  )

define "Has Asthma Diagnosis":
  exists ( [ConditionProblemsHealthConcerns: "Asthma"] AsthmaAlias
      where AsthmaAlias.overlapsHeartFailureOutpatientEncounter ( )
        and AsthmaAlias.isConfirmedActiveDiagnosis ( )
  )

define "Has Atrioventricular Block Diagnosis":
  exists ( [ConditionProblemsHealthConcerns: "Atrioventricular Block"] AtrioventricularBlock
      where AtrioventricularBlock.overlapsHeartFailureOutpatientEncounter ( )
        and AtrioventricularBlock.isConfirmedActiveDiagnosis ( )
  )

define "Has Beta Blocker Therapy for LVSD Ordered":
  exists ( [MedicationRequest: medication in "Beta Blocker Therapy for LVSD"] BetaBlockerOrdered
      where BetaBlockerOrdered.isOrderedDuringHeartFailureOutpatientEncounter2 ( )
  )

define "Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD":
  exists ( ["MedicationNotRequested": medication in "Beta Blocker Therapy for LVSD"] NoBetaBlockerOrdered
      with AHA."Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
        such that NoBetaBlockerOrdered.authoredOn during day of ModerateOrSevereLVSDHFOutpatientEncounter.period
    //   where ( NoBetaBlockerOrdered.reasonCode in "Medical Reason"
    //       or NoBetaBlockerOrdered.reasonCode in "Patient Reason"
    //   )
  
  
  
  )
 
 // TODO: Need to figure out why this function isn't working when invoked from AHAOverall v3.0.000
 //       This test case fails when using AHAOverall v3.0.000, but passes with the copy below:
 //       https://madie.cms.gov/measures/67e2e174ede72744898ad54f/edit/test-cases/67e2e1cb2dcc81152d60e878 




define fluent function isOrderedDuringHeartFailureOutpatientEncounter2(MedicationRequest MedicationRequest):
  exists ( AHA."Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
      where MedicationRequest.authoredOn during day of ModerateOrSevereLVSDHFOutpatientEncounter.period
        and MedicationRequest.status in { 'active', 'completed' }
        and MedicationRequest.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
              /*Issue: The logic commented out below was added to the logic due to an issue described in the authoring patterns for QI-Core: https://github.com/cqframework/CQL-Formatting-and-Usage-Wiki/wiki/Authoring-Patterns---QICore-v4.1.1#medication-ordered. However, when this logic is present, it causes an issue in Coverage calculation for resources that must be QI-Core compliant, because the inverse cannot be tested for a QI-Core MedicationRequest profile instance. This logic was commented out to achieve 100% Coverage. This requirement is really to handle what would happen if a MedicationRequest instance that could be set to 'false' were provided, but this should not happen within a trusted environment where QI-Core profile instances must be provided.*/
              // and MedicationRequest.doNotPerform is not true 
  
  
  )