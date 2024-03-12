library AnticoagulationTherapyforAtrialFibrillationFlutterFHIR version '0.3.000'

using QICore version '4.1.1'

/* 2024 AU */


include FHIRHelpers version '4.3.000' called FHIRHelpers
include CQMCommon version '2.0.000' called CQMCommon
include QICoreCommon version '2.0.000' called QICoreCommon
include SupplementalDataElements version '3.4.000' called SDE
include TJCOverall version '8.11.000' called TJC

valueset "Anticoagulant Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.200'
valueset "Atrial Ablation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.203'
valueset "Atrial Fibrillation or Flutter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.202'
valueset "Discharge To Acute Care Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87'
valueset "Discharged to Health Care Facility for Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207'
valueset "Discharged to Home for Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209'
valueset "History of Atrial Ablation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.76'
valueset "Left Against Medical Advice": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308'
valueset "Medical Reason For Not Providing Treatment": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473'
valueset "Patient Expired": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309'
valueset "Patient Refusal": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "Initial Population":
  TJC."Encounter with Principal Diagnosis and Age"

define "Denominator":
  "Encounter with a History of Atrial Ablation"
    union "Encounter with Prior or Present Diagnosis of Atrial Fibrillation or Flutter"

define "Encounter with a History of Atrial Ablation":
  ( TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
      where exists ( ["Procedure": "Atrial Ablation"] AtrialAblationProcedure
          where AtrialAblationProcedure.status = 'completed'
            and AtrialAblationProcedure.performed.toInterval ( ) starts before start of IschemicStrokeEncounter.period
      )
  )
    union ( TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
        with ["Condition": "History of Atrial Ablation"] AtrialAblationDiagnosis
          such that AtrialAblationDiagnosis.verificationStatus is not null
            and AtrialAblationDiagnosis.verificationStatus ~ QICoreCommon."confirmed"
            and AtrialAblationDiagnosis.onset.toInterval ( ) starts before start of IschemicStrokeEncounter.period
    )
    union ( TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
        with ["Observation": "History of Atrial Ablation"] AtrialAblationObservation
          such that AtrialAblationObservation.status in { 'final', 'amended', 'corrected' }
            and AtrialAblationObservation.effective.earliest ( ) on or before end of IschemicStrokeEncounter.period
    )

define "Encounter with Prior or Present Diagnosis of Atrial Fibrillation or Flutter":
  ( TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
      with ["Condition": "Atrial Fibrillation or Flutter"] AtrialFibrillationFlutter
        such that AtrialFibrillationFlutter.verificationStatus is not null
          and AtrialFibrillationFlutter.verificationStatus ~ QICoreCommon."confirmed"
          and AtrialFibrillationFlutter.onset.toInterval ( ) starts on or before end of IschemicStrokeEncounter.period
  )
    union TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
      where exists ( ( IschemicStrokeEncounter.encounterDiagnosis ( ) ) EncounterDiagnosis
          where EncounterDiagnosis.code in "Atrial Fibrillation or Flutter"
      )

define "Denominator Exclusions":
  ( "Denominator" Encounter
      where Encounter.status = 'finished'
        and ( Encounter.hospitalization.dischargeDisposition in "Discharge To Acute Care Facility"
            or Encounter.hospitalization.dischargeDisposition in "Left Against Medical Advice"
            or Encounter.hospitalization.dischargeDisposition in "Patient Expired"
            or Encounter.hospitalization.dischargeDisposition in "Discharged to Home for Hospice Care"
            or Encounter.hospitalization.dischargeDisposition in "Discharged to Health Care Facility for Hospice Care"
        )
  )
    union "Encounter with Comfort Measures during Hospitalization for Patients with Documented Atrial Fibrillation or Flutter"

define "Encounter with Comfort Measures during Hospitalization for Patients with Documented Atrial Fibrillation or Flutter":
  "Denominator" Encounter
    with TJC."Intervention Comfort Measures" ComfortMeasure
      such that Coalesce(start of ComfortMeasure.performed.toInterval(), ComfortMeasure.authoredOn) during Encounter.hospitalizationWithObservation ( )

define "Numerator":
  "Denominator" Encounter
    with ["MedicationRequest": "Anticoagulant Therapy"] DischargeAnticoagulant
      such that ( DischargeAnticoagulant.isCommunity ( )
          or DischargeAnticoagulant.isDischarge ( )
      )
        and DischargeAnticoagulant.status in { 'active', 'completed' }
        and DischargeAnticoagulant.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
        and DischargeAnticoagulant.doNotPerform is not true
        and DischargeAnticoagulant.authoredOn during Encounter.period
      //BONNIEMAT-1617-Since there is an anticipated resolution for STU 5 for both Medication.Request and Medication.Discharge which leaves two blockers on coverage, will leave the assertion logic as is and update the test cases for coverage.


define "Denominator Exceptions":
  "Denominator" Encounter
    with "Documented Reason for Not Giving Anticoagulant at Discharge" NoDischargeAnticoagulant
      such that NoDischargeAnticoagulant.authoredOn during Encounter.period

define "Documented Reason for Not Giving Anticoagulant at Discharge":
  ["MedicationNotRequested": medication in "Anticoagulant Therapy"] NoAnticoagulant
    where ( NoAnticoagulant.reasonCode in "Medical Reason For Not Providing Treatment"
        or NoAnticoagulant.reasonCode in "Patient Refusal"
    )
      and ( NoAnticoagulant.isCommunity ( )
          or NoAnticoagulant.isDischarge ( )
      )
      and NoAnticoagulant.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"