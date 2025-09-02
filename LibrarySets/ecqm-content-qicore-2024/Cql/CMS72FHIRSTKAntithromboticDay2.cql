library CMS72FHIRSTKAntithromboticDay2 version '0.7.001'

/* 2025 AU */


using QICore version '4.1.1'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include CQMCommon version '2.2.000' called CQMCommon
include QICoreCommon version '2.1.000' called QICoreCommon
include SupplementalDataElements version '3.5.000' called SDE
include TJCOverall version '8.15.000' called TJC

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
  default Interval[@2026-01-01T00:00:00.000, @2026-12-31T23:59:59.999]

context Patient

define "Initial Population":
  TJC."Ischemic Stroke Encounter"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "Encounter Less Than Two Days"
    union "Encounter With Comfort Measures During Day Of Or Day After Arrival"
    union "Encounter With Thrombolytic Therapy Given Prior To Arrival Or During Hospitalization"

define "Encounter Less Than Two Days":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    where IschemicStrokeEncounter.hospitalizationWithObservation ( ).lengthInDays ( ) < 2

define "Encounter With Comfort Measures During Day Of Or Day After Arrival":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    with TJC."Intervention Comfort Measures" ComfortMeasure
      such that Coalesce(start of ComfortMeasure.performed.toInterval(), ComfortMeasure.authoredOn) during day of ( start of IschemicStrokeEncounter.hospitalizationWithObservation ( ) ).CalendarDayOfOrDayAfter ( )

define "Encounter With Thrombolytic Therapy Given Prior To Arrival Or During Hospitalization":
  "Encounter With Thrombolytic Therapy Medication Or Procedures"
    union "Encounter With Thrombolytic Therapy Prior To Arrival"
    union "Encounter With Thrombolytic Therapy Documented As Already Given"

define "Encounter With Thrombolytic Therapy Medication Or Procedures":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    with "Thrombolytic Therapy Medication Or Procedures" ThrombolyticTherapy
      such that ThrombolyticTherapy.effective.toInterval ( ) starts during Interval[start of IschemicStrokeEncounter.hospitalizationWithObservation ( ) - 24 hours, end of IschemicStrokeEncounter.hospitalizationWithObservation ( ) )

define "Thrombolytic Therapy Medication Or Procedures":
  ( ["MedicationAdministration": medication in "Thrombolytic tPA Therapy"] ThrombolyticMedication
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

define "Encounter With Thrombolytic Therapy Prior To Arrival":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    where exists ( ( IschemicStrokeEncounter.encounterDiagnosis ( ) ) EncounterDiagnosis
        where ( EncounterDiagnosis.code in "Intravenous or Intraarterial Thrombolytic tPA Therapy Prior to Arrival" )
    )

define "Encounter With Thrombolytic Therapy Documented As Already Given":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    with [Condition: "Intravenous or Intraarterial Thrombolytic tPA Therapy Prior to Arrival"] PriorTPA
      such that PriorTPA.recordedDate during CQMCommon."HospitalizationWithObservation" ( IschemicStrokeEncounter )
        and PriorTPA.isActive ( )
        and PriorTPA.verificationStatus is not null
        and PriorTPA.verificationStatus ~ QICoreCommon."confirmed"

define "Numerator":
  "Encounter With Antithrombotic Therapy"

define "Encounter With Antithrombotic Therapy":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    with ["MedicationAdministration": medication in "Antithrombotic Therapy for Ischemic Stroke"] Antithrombotic
      such that Antithrombotic.status in { 'in-progress', 'completed' }
        and Antithrombotic.effective.toInterval ( ) starts during day of ( start of IschemicStrokeEncounter.hospitalizationWithObservation ( ) ).CalendarDayOfOrDayAfter ( )

define "Denominator Exceptions":
  "Encounter With Documented Reason For No Antithrombotic Ordered Or Administered Day Of Or Day After Hospital Arrival"
    union "Encounter With Pharmacological Contraindications For Antithrombotic Therapy Given Day Of Or Day After Hospital Arrival"
    union "Encounter With An INR Greater Than 3.5"

define "Encounter With Documented Reason For No Antithrombotic Ordered Or Administered Day Of Or Day After Hospital Arrival":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    with "Documented Reason For No Antithrombotic Ordered Or Administered" NoAntithrombotic
      such that NoAntithrombotic.authoredOn during day of ( start of IschemicStrokeEncounter.hospitalizationWithObservation ( ) ).CalendarDayOfOrDayAfter ( )

define "Documented Reason For No Antithrombotic Ordered Or Administered":
  "Reason For Not Ordering Antithrombotic"
    union "Reason For Not Administering Antithrombotic"

define "Reason For Not Administering Antithrombotic":
  ["MedicationAdministrationNotDone": medication in "Antithrombotic Therapy for Ischemic Stroke"] MedicationAdm
    where ( MedicationAdm.statusReason in "Medical Reason for Not Providing Treatment"
        or MedicationAdm.statusReason in "Patient Refusal"
    )
    return {
      id: MedicationAdm.id,
      authoredOn: MedicationAdm.recorded
    }

define "Reason For Not Ordering Antithrombotic":
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

define "Encounter With Pharmacological Contraindications For Antithrombotic Therapy Given Day Of Or Day After Hospital Arrival":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    with ["MedicationAdministration": medication in "Pharmacological Contraindications For Antithrombotic Therapy"] PharmacologicalContraindications
      such that PharmacologicalContraindications.status in { 'in-progress', 'completed' }
        and PharmacologicalContraindications.effective.toInterval ( ) starts during day of ( start of IschemicStrokeEncounter.hospitalizationWithObservation ( ) ).CalendarDayOfOrDayAfter ( )

define "Encounter With An INR Greater Than 3.5":
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