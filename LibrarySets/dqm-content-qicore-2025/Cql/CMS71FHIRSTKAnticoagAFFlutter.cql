library CMS71FHIRSTKAnticoagAFFlutter version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include CQMCommon version '4.1.000' called CQMCommon
include QICoreCommon version '4.0.000' called QICoreCommon
include SupplementalDataElements version '5.1.000' called SDE
include TJCOverall version '8.25.000' called TJC

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
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
  TJC."Ischemic Stroke Encounter"

define "Denominator":
  "Encounter With A History Of Atrial Ablation"
    union "Encounter With Prior Or Present Diagnosis Of Atrial Fibrillation Or Flutter"

define "Encounter With A History Of Atrial Ablation":
  ( TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
      where exists ( ["Procedure": "Atrial Ablation"] AtrialAblationProcedure
          where AtrialAblationProcedure.status = 'completed'
            and AtrialAblationProcedure.performed.toInterval ( ) starts before start of IschemicStrokeEncounter.period
      )
  )
    union ( TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
        with ["ConditionProblemsHealthConcerns": "History of Atrial Ablation"] AtrialAblationDiagnosis
          such that AtrialAblationDiagnosis.verificationStatus is not null implies ( AtrialAblationDiagnosis.verificationStatus !~ QICoreCommon."refuted"
              and AtrialAblationDiagnosis.verificationStatus !~ QICoreCommon."entered-in-error"
          )
            and AtrialAblationDiagnosis.onset.toInterval ( ) starts before start of IschemicStrokeEncounter.period
    )
    union ( TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
        with ["SimpleObservation": "History of Atrial Ablation"] AtrialAblationObservation
          such that AtrialAblationObservation.status in { 'final', 'amended', 'corrected' }
            and AtrialAblationObservation.effective.earliest ( ) on or before end of IschemicStrokeEncounter.period
    )
    union ( TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
        with ["ConditionEncounterDiagnosis": "History of Atrial Ablation"] AtrialAblationEncDiagnosis
          such that AtrialAblationEncDiagnosis.verificationStatus is not null implies ( AtrialAblationEncDiagnosis.verificationStatus !~ QICoreCommon."refuted"
              and AtrialAblationEncDiagnosis.verificationStatus !~ QICoreCommon."entered-in-error"
          )
            and AtrialAblationEncDiagnosis.onset.toInterval ( ) starts before start of IschemicStrokeEncounter.period
    )

define "Encounter With Prior Or Present Diagnosis Of Atrial Fibrillation Or Flutter":
  ( TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
      with ["ConditionProblemsHealthConcerns": "Atrial Fibrillation or Flutter"] AtrialFibrillationFlutter
        such that AtrialFibrillationFlutter.verificationStatus is not null implies ( AtrialFibrillationFlutter.verificationStatus !~ QICoreCommon."refuted"
            and AtrialFibrillationFlutter.verificationStatus !~ QICoreCommon."entered-in-error"
        )
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
    union "Encounter With Comfort Measures During Hospitalization For Patients With Documented Atrial Fibrillation Or Flutter"

define "Encounter With Comfort Measures During Hospitalization For Patients With Documented Atrial Fibrillation Or Flutter":
  "Denominator" Encounter
    with TJC."Intervention Comfort Measures" ComfortMeasure
      such that Coalesce(start of ComfortMeasure.performed.toInterval(), ComfortMeasure.authoredOn) during Encounter.hospitalizationWithObservation ( )

define "Numerator":
  "Denominator" Encounter
    with ["MedicationRequest": "Anticoagulant Therapy"] DischargeAnticoagulant
      such that DischargeAnticoagulant.status in { 'active', 'completed' }
        and DischargeAnticoagulant.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
        and ( DischargeAnticoagulant.isCommunity ( )
            or DischargeAnticoagulant.isDischarge ( )
        )
        and DischargeAnticoagulant.authoredOn during Encounter.period
        and not exists ( ["TaskRejected"] TaskReject
            where TaskReject.focus.references ( DischargeAnticoagulant )
              and TaskReject.code ~ QICoreCommon."Fulfill"
        )

define "Denominator Exceptions":
  "Denominator" Encounter
    with "Documented Reason For Not Giving Anticoagulant At Discharge" NoDischargeAnticoagulant
      such that NoDischargeAnticoagulant.authoredOn during Encounter.period

define "Documented Reason For Not Giving Anticoagulant At Discharge":
  ( ["MedicationNotRequested": "Anticoagulant Therapy"] NoAnticoagulant
      where ( NoAnticoagulant.reasonCode in "Medical Reason For Not Providing Treatment"
          or NoAnticoagulant.reasonCode in "Patient Refusal"
      )
        and ( NoAnticoagulant.isCommunity ( )
            or NoAnticoagulant.isDischarge ( )
        )
        and NoAnticoagulant.status in { 'active', 'completed' }
        and NoAnticoagulant.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
  )
    union ( ["MedicationRequest": "Anticoagulant Therapy"] MedReqAntiCoagulant
        with ["TaskRejected"] TaskReject
          such that TaskReject.focus.references ( MedReqAntiCoagulant )
            and ( TaskReject.statusReason in "Medical Reason For Not Providing Treatment"
                or TaskReject.statusReason in "Patient Refusal"
            )
            and MedReqAntiCoagulant.status in { 'active', 'completed' }
            and TaskReject.code ~ QICoreCommon."Fulfill"
    )

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"