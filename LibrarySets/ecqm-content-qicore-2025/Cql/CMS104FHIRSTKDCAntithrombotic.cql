library CMS104FHIRSTKDCAntithrombotic version '0.9.003'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include CQMCommon version '4.1.000' called CQMCommon
include QICoreCommon version '4.0.000' called QICoreCommon
include SupplementalDataElements version '5.1.000' called SDE
include TJCOverall version '8.24.000' called TJC

codesystem "TaskCode": 'http://hl7.org/fhir/CodeSystem/task-code'

code "fulfill": 'fulfill' from "TaskCode"

valueset "Antithrombotic Therapy for Ischemic Stroke": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.62'
valueset "Medical Reason For Not Providing Treatment": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473'
valueset "Patient Refusal": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93'
valueset "Pharmacological Contraindications For Antithrombotic Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.52'

parameter "Measurement Period" Interval<DateTime>

context Patient

define "Initial Population":
  TJC."Ischemic Stroke Encounter"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  TJC."Ischemic Stroke Encounters With Discharge Disposition"
    union TJC."Encounter With Comfort Measures During Hospitalization"

define "Numerator":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    with ["MedicationRequest": medication in "Antithrombotic Therapy for Ischemic Stroke"] DischargeAntithrombotic
      such that DischargeAntithrombotic.status in { 'active', 'completed' }
        and DischargeAntithrombotic.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
        and ( DischargeAntithrombotic.isCommunity ( )
            or DischargeAntithrombotic.isDischarge ( )
        )
        and DischargeAntithrombotic.authoredOn during IschemicStrokeEncounter.period
        and not exists ( ["TaskRejected"] TaskReject
            where TaskReject.focus.references ( DischargeAntithrombotic )
              and TaskReject.code ~ "fulfill"
        )

define "Denominator Exceptions":
  "Encounter With Documented Reason For No Antithrombotic At Discharge"
    union "Encounter With Pharmacological Contraindications For Antithrombotic Therapy At Discharge"

define "Encounter With Documented Reason For No Antithrombotic At Discharge":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    with "Reason For Not Giving Antithrombotic At Discharge" NoDischargeAntithrombotic
      such that NoDischargeAntithrombotic.authoredOn during IschemicStrokeEncounter.period

define "Reason For Not Giving Antithrombotic At Discharge":
  ( ["MedicationNotRequested": "Antithrombotic Therapy for Ischemic Stroke"] NoAntithromboticDischarge
      where ( NoAntithromboticDischarge.reasonCode in "Medical Reason For Not Providing Treatment"
          or NoAntithromboticDischarge.reasonCode in "Patient Refusal"
      )
        and ( NoAntithromboticDischarge.isCommunity ( )
            or NoAntithromboticDischarge.isDischarge ( )
        )
        and NoAntithromboticDischarge.status in { 'active', 'completed' }
        and NoAntithromboticDischarge.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
  )
    union ( ["MedicationRequest": "Antithrombotic Therapy for Ischemic Stroke"] MedReqAntithrombotic
        with ["TaskRejected"] TaskReject
          such that TaskReject.focus.references ( MedReqAntithrombotic )
            and ( TaskReject.statusReason in "Medical Reason For Not Providing Treatment"
                or TaskReject.statusReason in "Patient Refusal"
            )
            and MedReqAntithrombotic.status = 'active'
            and TaskReject.code ~ "fulfill"
    )

define "Encounter With Pharmacological Contraindications For Antithrombotic Therapy At Discharge":
  TJC."Ischemic Stroke Encounter" IschemicStrokeEncounter
    with "Pharmacological Contraindications For Antithrombotic Therapy At Discharge" DischargePharmacological
      such that DischargePharmacological.authoredOn during IschemicStrokeEncounter.period

define "Pharmacological Contraindications For Antithrombotic Therapy At Discharge":
  ["MedicationRequest": medication in "Pharmacological Contraindications For Antithrombotic Therapy"] PharmacologicalContraindications
    where ( PharmacologicalContraindications.isCommunity ( )
        or PharmacologicalContraindications.isDischarge ( )
    )
      and PharmacologicalContraindications.status in { 'active', 'completed' }
      and PharmacologicalContraindications.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"