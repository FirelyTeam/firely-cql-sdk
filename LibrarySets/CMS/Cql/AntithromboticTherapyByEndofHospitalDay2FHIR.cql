library AntithromboticTherapyByEndofHospitalDay2FHIR version '0.7.000'

/* based upon QDM library Antithrombotic Therapy By End of Hospital Day 2, 2023AU, version '12.0.000'  */
/* 2023 AU */



using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include CQMCommon version '2.0.000' called CQMCommon
include QICoreCommon version '2.0.000' called QICoreCommon
include SupplementalDataElements version '3.4.000' called SDE
include TJCOverall version '8.11.000' called TJC

valueset "Antithrombotic Therapy for Ischemic Stroke": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62'
valueset "Comfort Measures": 'http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45'
valueset "INR": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.213'
valueset "Intravenous or Intraarterial Thrombolytic tPA Therapy Prior to Arrival": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.21'
valueset "Intravenous or Intraarterial Thrombolytic tPA Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.21'
valueset "Medical Reason for Not Providing Treatment": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473'
valueset "Patient Refusal": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93'
valueset "Pharmacological Contraindications For Antithrombotic Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52'
valueset "Thrombolytic tPA Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.226'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "Initial Population":
  TJC."Encounter with Principal Diagnosis and Age"

define "Denominator":
  TJC."Ischemic Stroke Encounter"

define "Denominator Exclusions":
  "Encounter Less Than Two Days"
    union "Encounter with Comfort Measures during Day of or Day After Arrival"
    union "Encounter with Thrombolytic Therapy Given Prior To Arrival Or During Hospitalization"

define "Encounter Less Than Two Days":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    where IschemicStrokeEncounter.hospitalizationWithObservation ( ).lengthInDays ( ) < 2

define "Encounter with Comfort Measures during Day of or Day After Arrival":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    with TJC."Intervention Comfort Measures" ComfortMeasure
      such that Coalesce(start of ComfortMeasure.performed.toInterval(), ComfortMeasure.authoredOn) during day of ( start of IschemicStrokeEncounter.hospitalizationWithObservation ( ) ).CalendarDayOfOrDayAfter ( )

define "Encounter with Thrombolytic Therapy Given Prior To Arrival Or During Hospitalization":
  "Encounter with Thrombolytic Therapy Medication or Procedures"
    union "Encounter with Thrombolytic Therapy Prior to Arrival"
    union "Encounter with Thrombolytic Therapy Documented As Already Given"

define "Encounter with Thrombolytic Therapy Medication or Procedures":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    with "Thrombolytic Therapy Medication or Procedures" ThrombolyticTherapy
      such that ThrombolyticTherapy.effective.toInterval ( ) starts during Interval[start of IschemicStrokeEncounter.hospitalizationWithObservation ( ) - 24 hours, end of IschemicStrokeEncounter.hospitalizationWithObservation ( ) )

define "Thrombolytic Therapy Medication or Procedures":
  ( ["MedicationAdministration": "Thrombolytic tPA Therapy"] ThrombolyticMedication
      where ThrombolyticMedication.status in { 'in-progress', 'completed' }
      return {
        id: ThrombolyticMedication.id,
        effective: ThrombolyticMedication.effective
      }
  )
    union ( ["Procedure": "Intravenous or Intraarterial Thrombolytic tPA Therapy"] ThrombolyticProcedure
        where ThrombolyticProcedure.status = 'completed'
        return {
          id: ThrombolyticProcedure.id,
          effective: ThrombolyticProcedure.performed
        }
    )

define "Encounter with Thrombolytic Therapy Prior to Arrival":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    where exists ( ( IschemicStrokeEncounter.encounterDiagnosis ( ) ) EncounterDiagnosis
        where ( EncounterDiagnosis.code in "Intravenous or Intraarterial Thrombolytic tPA Therapy Prior to Arrival" )
    )

define "Encounter with Thrombolytic Therapy Documented As Already Given":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    with [Condition: "Intravenous or Intraarterial Thrombolytic tPA Therapy Prior to Arrival"] PriorTPA
      such that PriorTPA.recordedDate during CQMCommon."HospitalizationWithObservation" ( IschemicStrokeEncounter )
        and PriorTPA.isActive ( )
        and PriorTPA.verificationStatus is not null
        and PriorTPA.verificationStatus ~ QICoreCommon."confirmed"

define "Numerator":
  "Encounter with Antithrombotic Therapy"

define "Encounter with Antithrombotic Therapy":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    with ["MedicationAdministration": "Antithrombotic Therapy for Ischemic Stroke"] Antithrombotic
      such that Antithrombotic.status in { 'in-progress', 'completed' }
        and Antithrombotic.effective.toInterval ( ) starts during day of ( start of IschemicStrokeEncounter.hospitalizationWithObservation ( ) ).CalendarDayOfOrDayAfter ( )

define "Denominator Exceptions":
  "Encounter with Documented Reason for No Antithrombotic Ordered or Administered Day Of or Day After Hospital Arrival"
    union "Encounter with Pharmacological Contraindications for Antithrombotic Therapy Given Day Of or Day After Hospital Arrival"
    union "Encounter with An INR Greater Than 3.5"

define "Encounter with Documented Reason for No Antithrombotic Ordered or Administered Day Of or Day After Hospital Arrival":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    with "Documented Reason for No Antithrombotic Ordered or Administered" NoAntithrombotic
      such that NoAntithrombotic.authoredOn during day of ( start of IschemicStrokeEncounter.hospitalizationWithObservation ( ) ).CalendarDayOfOrDayAfter ( )

define "Documented Reason for No Antithrombotic Ordered or Administered":
  "Reason for Not Ordering Antithrombotic"
    union "Reason for Not Administering Antithrombotic"

define "Reason for Not Administering Antithrombotic":
  ["MedicationAdministrationNotDone": medication in "Antithrombotic Therapy for Ischemic Stroke"] MedicationAdm
    where ( MedicationAdm.statusReason in "Medical Reason for Not Providing Treatment"
        or MedicationAdm.statusReason in "Patient Refusal"
    )
    return {
      id: MedicationAdm.id,
      authoredOn: MedicationAdm.recorded
    }

define "Reason for Not Ordering Antithrombotic":
  ["MedicationNotRequested": medication in "Antithrombotic Therapy for Ischemic Stroke"] NoAntithromboticOrder
    where NoAntithromboticOrder.status = 'completed'
      and NoAntithromboticOrder.intent = 'order'
      and ( NoAntithromboticOrder.reasonCode in "Medical Reason for Not Providing Treatment"
          or NoAntithromboticOrder.reasonCode in "Patient Refusal"
      )
    return {
      id: NoAntithromboticOrder.id,
      authoredOn: NoAntithromboticOrder.authoredOn
    }

define "Encounter with Pharmacological Contraindications for Antithrombotic Therapy Given Day Of or Day After Hospital Arrival":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    with ["MedicationAdministration": "Pharmacological Contraindications For Antithrombotic Therapy"] PharmacologicalContraindications
      such that PharmacologicalContraindications.status in { 'in-progress', 'completed' }
        and PharmacologicalContraindications.effective.toInterval ( ) starts during day of ( start of IschemicStrokeEncounter.hospitalizationWithObservation ( ) ).CalendarDayOfOrDayAfter ( )

define "Encounter with An INR Greater Than 3.5":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    with ["Observation": "INR"] INR
      such that INR.value as Quantity > 3.5
        and INR.status in { 'final', 'amended', 'corrected' }
        and INR.issued during day of ( start of IschemicStrokeEncounter.hospitalizationWithObservation ( ) ).CalendarDayOfOrDayAfter ( )

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"