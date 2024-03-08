library IntensiveCareUnitVenousThromboembolismProphylaxisFHIR version '0.2.000'

using QICore version '4.1.1'

include CQMCommon version '2.0.000' called CQMCommon
include FHIRHelpers version '4.3.000' called FHIRHelpers
include QICoreCommon version '2.0.000' called QICoreCommon
include SupplementalDataElements version '3.4.000' called SDE
include TJCOverall version '8.11.000' called TJC
include VTE version '8.6.000' called VTE

codesystem "LOINC": 'http://loinc.org'

valueset "Application of Graduated Compression Stockings": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.66'
valueset "Application of Intermittent Pneumatic Compression Devices": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.65'
valueset "Application of Venous Foot Pumps": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.64'
valueset "Atrial Fibrillation or Flutter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.202'
valueset "Comfort Measures": 'http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45'
valueset "Direct Thrombin Inhibitor": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.205'
valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292'
valueset "General or Neuraxial Anesthesia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1743'
valueset "General Surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.255'
valueset "Glycoprotein IIb/IIIa Inhibitors": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.41'
valueset "Graduated compression stockings": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.256'
valueset "Gynecological Surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.257'
valueset "Hip Fracture Surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.258'
valueset "Hip Replacement Surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.259'
valueset "Injectable Factor Xa Inhibitor for VTE Prophylaxis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.211'
valueset "INR": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.213'
valueset "Intensive Care Unit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206'
valueset "Intermittent pneumatic compression devices": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.214'
valueset "Intracranial Neurosurgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.260'
valueset "Intravenous route": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.222'
valueset "Knee Replacement Surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.261'
valueset "Low Dose Unfractionated Heparin for VTE Prophylaxis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.39'
valueset "Low Molecular Weight Heparin for VTE Prophylaxis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.219'
valueset "Low Risk": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.400'
valueset "Medical Reason For Not Providing Treatment": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473'
valueset "Mental Health Diagnoses": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1004'
valueset "Obstetrical or Pregnancy Related Conditions": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263'
valueset "Obstetrics VTE": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.264'
valueset "Oral Factor Xa Inhibitor for VTE Prophylaxis or VTE Treatment": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.134'
valueset "Patient Refusal": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93'
valueset "Rivaroxaban for VTE Prophylaxis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.50'
valueset "Subcutaneous route": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.223'
valueset "Unfractionated Heparin": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.218'
valueset "Urological Surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.272'
valueset "Venous foot pumps": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.230'
valueset "Venous Thromboembolism": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.279'
valueset "Warfarin": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.232'

code "Risk for venous thromboembolism": '72136-5' from "LOINC" display 'Risk for venous thromboembolism'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Initial Population":
  VTE."Encounter with Age Range and without VTE Diagnosis or Obstetrical Conditions"

define "Denominator":
  "Encounter with ICU Location"

define "Encounter with ICU Location":
  VTE."Encounter with Age Range and without VTE Diagnosis or Obstetrical Conditions" QualifyingEncounter
    where exists ( QualifyingEncounter.location Location
        where Location.location.getLocation ( ).type in "Intensive Care Unit"
          and Location.period during QualifyingEncounter.period
    )

define "Denominator Exclusions":
  "Encounter with ICU Location And Encounter Less Than 2 Days"
    union "Encounter with First ICU Stay with Principal Procedure of SCIP VTE Selected Surgery"
    union "Encounter with Intervention Comfort Measures From Day Of Start of Hospitalization To Day After First ICU Stay"
    union "Encounter with Intervention Comfort Measures on Day of or Day After Procedure"

define "Encounter with ICU Location And Encounter Less Than 2 Days":
  "Encounter with ICU Location" QualifyingEncounterICU
    where QualifyingEncounterICU.period.lengthInDays ( ) < 2

define "SCIP VTE Selected Surgery":
  ( ["Procedure": "General Surgery"]
    union ["Procedure": "Gynecological Surgery"]
    union ["Procedure": "Hip Fracture Surgery"]
    union ["Procedure": "Hip Replacement Surgery"]
    union ["Procedure": "Intracranial Neurosurgery"]
    union ["Procedure": "Knee Replacement Surgery"]
    union ["Procedure": "Urological Surgery"] ) Procedure
    where Procedure.status = 'completed'

define "Encounter with First ICU Stay with Principal Procedure of SCIP VTE Selected Surgery":
  from
    "Encounter with ICU Location" QualifyingEncounterICU,
    "SCIP VTE Selected Surgery" SelectedProcedure
    let EncounterProcedure: singleton from ( QualifyingEncounterICU.procedure P
        where P.rank = 1
    )
    where EncounterProcedure.procedure.reference.getId ( ) = SelectedProcedure.id
      and end of SelectedProcedure.performed.toInterval ( ) during day of QualifyingEncounterICU.StartOfFirstICU ( ).CalendarDayOfOrDayAfter ( )
    return QualifyingEncounterICU

define "Encounter with Intervention Comfort Measures From Day Of Start of Hospitalization To Day After First ICU Stay":
  "Encounter with ICU Location" QualifyingEncounterICU
    with "Intervention Comfort Measures" ComfortMeasure
      such that Coalesce(start of ComfortMeasure.performed.toInterval(), ComfortMeasure.authoredOn) during day of QualifyingEncounterICU.FromDayOfStartOfHospitalizationToDayAfterFirstICU ( )

define "Intervention Comfort Measures":
  ( ["ServiceRequest": "Comfort Measures"] InterventionRequest
      where InterventionRequest.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
        and InterventionRequest.status in { 'active', 'on-hold', 'completed' }
        and InterventionRequest.doNotPerform is not true
  )
    union ( ["Procedure": "Comfort Measures"] InterventionPerformed
        where InterventionPerformed.status in { 'completed', 'in-progress' }
    )

define "Encounter with Intervention Comfort Measures on Day of or Day After Procedure":
  from
    "Encounter with ICU Location" QualifyingEncounterICU,
    ["Procedure": "General or Neuraxial Anesthesia"] AnesthesiaProcedure,
    "Intervention Comfort Measures" ComfortMeasure
    where AnesthesiaProcedure.status = 'completed'
      and AnesthesiaProcedure.performed.toInterval ( ) ends 1 day after day of QualifyingEncounterICU.StartOfFirstICU ( )
      and Coalesce(start of ComfortMeasure.performed.toInterval(), ComfortMeasure.authoredOn) during day of ( end of AnesthesiaProcedure.performed.toInterval ( ) ).CalendarDayOfOrDayAfter ( )
    return QualifyingEncounterICU

define "Numerator":
  "Encounter with VTE Prophylaxis Received on Day of or Day After First ICU Stay or Procedure"
    union ( "Encounter with Medication Oral Factor Xa Inhibitor Administered on Day of or Day After First ICU Stay or Procedure"
        intersect ( "Encounter with Prior or Present Diagnosis of Atrial Fibrillation or Prior Diagnosis of VTE"
            union "Encounter with Prior or Present Procedure of Hip or Knee Replacement Surgery"
        )
    )
    union "Encounter with Low Risk for VTE or Anticoagulant Administered"
    union "Encounter with No VTE Prophylaxis Due to Medical Reason"
    union "Encounter with No VTE Prophylaxis Due to Patient Refusal"

define "Pharmacological or Mechanical VTE Prophylaxis Received":
  ( ["MedicationAdministration": "Low Dose Unfractionated Heparin for VTE Prophylaxis"] VTEMedication
      where VTEMedication.status = 'completed'
        and VTEMedication.dosage.route in "Subcutaneous route"
  )
    union ( ["MedicationAdministration": "Low Molecular Weight Heparin for VTE Prophylaxis"] LMWH
        where LMWH.status = 'completed'
    )
    union ( ["MedicationAdministration": "Injectable Factor Xa Inhibitor for VTE Prophylaxis"] FactorXa
        where FactorXa.status = 'completed'
    )
    union ( ["MedicationAdministration": "Warfarin"] Warfarin
        where Warfarin.status = 'completed'
    )
    union ( ["MedicationAdministration": "Rivaroxaban for VTE Prophylaxis"] Rivaroxaban
        where Rivaroxaban.status = 'completed'
    )
    union ( ( ["Procedure": "Application of Intermittent Pneumatic Compression Devices"]
        union ["Procedure": "Application of Venous Foot Pumps"]
        union ["Procedure": "Application of Graduated Compression Stockings"] ) DeviceApplied
        where DeviceApplied.status = 'completed'
    )

define "Encounter with VTE Prophylaxis Received on Day of or Day After First ICU Stay or Procedure":
  ( "Encounter with ICU Location" QualifyingEncounterICU
      with "Pharmacological or Mechanical VTE Prophylaxis Received" VTEProphylaxis
        such that start of Coalesce(VTEProphylaxis.effective.toInterval(), VTEProphylaxis.performed.toInterval()) during day of QualifyingEncounterICU.StartOfFirstICU ( ).CalendarDayOfOrDayAfter ( )
  )
    union ( from
        "Encounter with ICU Location" QualifyingEncounterICU,
        ["Procedure": "General or Neuraxial Anesthesia"] AnesthesiaProcedure,
        "Pharmacological or Mechanical VTE Prophylaxis Received" VTEProphylaxis
        where AnesthesiaProcedure.status = 'completed'
          and AnesthesiaProcedure.performed.toInterval ( ) ends 1 day after day of QualifyingEncounterICU.StartOfFirstICU ( )
          and start of Coalesce(VTEProphylaxis.effective.toInterval(), VTEProphylaxis.performed.toInterval()) during day of ( end of AnesthesiaProcedure.performed.toInterval ( ) ).CalendarDayOfOrDayAfter ( )
        return QualifyingEncounterICU
    )

define "Encounter with Medication Oral Factor Xa Inhibitor Administered on Day of or Day After First ICU Stay or Procedure":
  ( "Encounter with ICU Location" QualifyingEncounterICU
      with ["MedicationAdministration": "Oral Factor Xa Inhibitor for VTE Prophylaxis or VTE Treatment"] FactorXaMedication
        such that FactorXaMedication.status = 'completed'
          and FactorXaMedication.effective.toInterval ( ) starts during day of QualifyingEncounterICU.StartOfFirstICU ( ).CalendarDayOfOrDayAfter ( )
  )
    union ( from
        "Encounter with ICU Location" QualifyingEncounterICU,
        ["Procedure": "General or Neuraxial Anesthesia"] AnesthesiaProcedure,
        ["MedicationAdministration": "Oral Factor Xa Inhibitor for VTE Prophylaxis or VTE Treatment"] FactorXaMedication
        where FactorXaMedication.status = 'completed'
          and AnesthesiaProcedure.status = 'completed'
          and AnesthesiaProcedure.performed.toInterval ( ) ends 1 day after day of QualifyingEncounterICU.StartOfFirstICU ( )
          and FactorXaMedication.effective.toInterval ( ) starts during day of ( end of AnesthesiaProcedure.performed.toInterval ( ) ).CalendarDayOfOrDayAfter ( )
        return QualifyingEncounterICU
    )

define "Encounter with Prior or Present Diagnosis of Atrial Fibrillation or Prior Diagnosis of VTE":
  ( "Encounter with ICU Location" QualifyingEncounterICU
      with ["Condition": "Atrial Fibrillation or Flutter"] AtrialFibrillation
        such that AtrialFibrillation.isActive ( )
          and AtrialFibrillation.verificationStatus is not null
          and AtrialFibrillation.verificationStatus ~ QICoreCommon."confirmed"
          and AtrialFibrillation.onset.toInterval ( ) starts on or before end of QualifyingEncounterICU.period
  )
    union ( "Encounter with ICU Location" QualifyingEncounterICU
        where QualifyingEncounterICU.encounterDiagnosis ( ).code in "Atrial Fibrillation or Flutter"
    )
    union ( "Encounter with ICU Location" QualifyingEncounterICU
        with ["Condition": "Venous Thromboembolism"] VTEDiagnosis
          such that ( VTEDiagnosis.clinicalStatus ~ QICoreCommon."inactive"
              or VTEDiagnosis.clinicalStatus ~ QICoreCommon."remission"
              or VTEDiagnosis.clinicalStatus ~ QICoreCommon."resolved"
          )
            and VTEDiagnosis.verificationStatus is not null
            and VTEDiagnosis.verificationStatus ~ QICoreCommon."confirmed"
            and VTEDiagnosis.onset.toInterval ( ) before start of QualifyingEncounterICU.period
    )

define "Encounter with Prior or Present Procedure of Hip or Knee Replacement Surgery":
  "Encounter with ICU Location" QualifyingEncounterICU
    with ( ["Procedure": "Hip Replacement Surgery"]
      union ["Procedure": "Knee Replacement Surgery"] ) HipKneeProcedure
      such that HipKneeProcedure.status = 'completed'
        and HipKneeProcedure.performed.toInterval ( ) starts on or before end of QualifyingEncounterICU.period

define "Encounter with Low Risk for VTE or Anticoagulant Administered":
  "Low Risk for VTE or Anticoagulant Administered From Day of Start of Hospitalization To Day After First ICU Stay"
    union "Low Risk for VTE or Anticoagulant Administered on Day of or Day After Procedure"

define "Low Risk Indicator For VTE":
  ( ["Observation": "Risk for venous thromboembolism"] VTERiskAssessment
      where VTERiskAssessment.value as Concept in "Low Risk"
        and VTERiskAssessment.status in { 'final', 'amended', 'corrected' }
      return {
        id: VTERiskAssessment.id,
        LowRiskDatetime: VTERiskAssessment.effective.earliest ( )
      }
  )
    union ( ["US Core Laboratory Result Observation Profile": "INR"] INRLabTest
        where INRLabTest.value as Quantity > 3.0
          and INRLabTest.status in { 'final', 'amended', 'corrected' }
        return {
          id: INRLabTest.id,
          LowRiskDatetime: INRLabTest.issued
        }
    )
    union ( ( ( ["MedicationAdministration": "Unfractionated Heparin"] UnfractionatedHeparin
          where UnfractionatedHeparin.dosage.route in "Intravenous route"
      )
        union ["MedicationAdministration": "Direct Thrombin Inhibitor"]
        union ["MedicationAdministration": "Glycoprotein IIb/IIIa Inhibitors"] ) AnticoagulantMedication
        where AnticoagulantMedication.status = 'completed'
        return {
          id: AnticoagulantMedication.id,
          LowRiskDatetime: start of AnticoagulantMedication.effective.toInterval ( )
        }
    )

define "Low Risk for VTE or Anticoagulant Administered From Day of Start of Hospitalization To Day After First ICU Stay":
  "Encounter with ICU Location" QualifyingEncounterICU
    with "Low Risk Indicator For VTE" LowRiskForVTE
      such that LowRiskForVTE.LowRiskDatetime during day of QualifyingEncounterICU.FromDayOfStartOfHospitalizationToDayAfterFirstICU ( )

define "Low Risk for VTE or Anticoagulant Administered on Day of or Day After Procedure":
  from
    "Encounter with ICU Location" QualifyingEncounterICU,
    ["Procedure": "General or Neuraxial Anesthesia"] AnesthesiaProcedure,
    "Low Risk Indicator For VTE" LowRiskForVTE
    where AnesthesiaProcedure.status = 'completed'
      and AnesthesiaProcedure.performed.toInterval ( ) ends 1 day after day of QualifyingEncounterICU.StartOfFirstICU ( )
      and LowRiskForVTE.LowRiskDatetime during day of ( end of AnesthesiaProcedure.performed.toInterval ( ) ).CalendarDayOfOrDayAfter ( )
    return QualifyingEncounterICU

define "Encounter with No VTE Prophylaxis Due to Medical Reason":
  ( "No VTE Prophylaxis Medication Due to Medical Reason From Day Of Start of Hospitalization To Day After First ICU Stay"
      intersect "No Mechanical VTE Prophylaxis Due to Medical Reason From Day of Start of Hospitalization To Day After First ICU Stay"
  )
    union ( "No VTE Prophylaxis Medication Due to Medical Reason on Day of or Day After Procedure"
        intersect "No Mechanical VTE Prophylaxis Due to Medical Reason on Day of or Day After Procedure"
    )

define "No VTE Prophylaxis Medication Due to Medical Reason From Day Of Start of Hospitalization To Day After First ICU Stay":
  "Encounter with ICU Location" QualifyingEncounterICU
    with "No VTE Prophylaxis Medication Administered or Ordered" NoVTEMedication
      such that NoVTEMedication.MedicationStatusReason in "Medical Reason For Not Providing Treatment"
        and NoVTEMedication.authoredOn during day of QualifyingEncounterICU.FromDayOfStartOfHospitalizationToDayAfterFirstICU ( )

define "No VTE Prophylaxis Medication Administered or Ordered":
  ( ( [MedicationAdministrationNotDone: "Low Dose Unfractionated Heparin for VTE Prophylaxis"]
      union [MedicationAdministrationNotDone: "Low Molecular Weight Heparin for VTE Prophylaxis"]
      union [MedicationAdministrationNotDone: "Injectable Factor Xa Inhibitor for VTE Prophylaxis"]
      union [MedicationAdministrationNotDone: "Warfarin"]
      union [MedicationAdministrationNotDone: "Rivaroxaban for VTE Prophylaxis"] ) NoMedicationAdm
      return {
        id: NoMedicationAdm.id,
        MedicationStatusReason: NoMedicationAdm.statusReason,
        authoredOn: NoMedicationAdm.recorded
      }
  )
    union ( ( ["MedicationNotRequested": "Low Dose Unfractionated Heparin for VTE Prophylaxis"]
        union ["MedicationNotRequested": "Low Molecular Weight Heparin for VTE Prophylaxis"]
        union ["MedicationNotRequested": "Injectable Factor Xa Inhibitor for VTE Prophylaxis"]
        union ["MedicationNotRequested": "Warfarin"]
        union ["MedicationNotRequested": "Rivaroxaban for VTE Prophylaxis"] ) NoMedicationOrder
        where NoMedicationOrder.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
        return {
          id: NoMedicationOrder.id,
          MedicationStatusReason: NoMedicationOrder.reasonCode,
          authoredOn: NoMedicationOrder.authoredOn
        }
    )

define "No Mechanical VTE Prophylaxis Due to Medical Reason From Day of Start of Hospitalization To Day After First ICU Stay":
  "Encounter with ICU Location" QualifyingEncounterICU
    with "No Mechanical VTE Prophylaxis Performed or Ordered" NoVTEDevice
      such that NoVTEDevice.requestStatusReason in "Medical Reason For Not Providing Treatment"
        and NoVTEDevice.authoredOn during day of QualifyingEncounterICU."FromDayOfStartOfHospitalizationToDayAfterFirstICU" ( )

define "No Mechanical VTE Prophylaxis Performed or Ordered":
  ( ( [ServiceNotRequested: "Venous foot pumps"]
      union [ServiceNotRequested: "Intermittent pneumatic compression devices"]
      union [ServiceNotRequested: "Graduated compression stockings"] ) DeviceNotOrder
      where DeviceNotOrder.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
      return {
        id: DeviceNotOrder.id,
        requestStatusReason: DeviceNotOrder.reasonRefused,
        authoredOn: DeviceNotOrder.authoredOn
      }
  )
    union ( ( [ProcedureNotDone: "Application of Intermittent Pneumatic Compression Devices"]
        union [ProcedureNotDone: "Application of Venous Foot Pumps"]
        union [ProcedureNotDone: "Application of Graduated Compression Stockings"] ) DeviceNotApplied
        let DeviceNotDoneTiming: DeviceNotApplied.recorded
        return {
          id: DeviceNotApplied.id,
          requestStatusReason: DeviceNotApplied.statusReason,
          authoredOn: DeviceNotDoneTiming
        }
    )

define "No VTE Prophylaxis Medication Due to Medical Reason on Day of or Day After Procedure":
  from
    "Encounter with ICU Location" QualifyingEncounterICU,
    ["Procedure": "General or Neuraxial Anesthesia"] AnesthesiaProcedure,
    "No VTE Prophylaxis Medication Administered or Ordered" NoVTEMedication
    where NoVTEMedication.MedicationStatusReason in "Medical Reason For Not Providing Treatment"
      and AnesthesiaProcedure.status = 'completed'
      and AnesthesiaProcedure.performed.toInterval ( ) ends 1 day after day of QualifyingEncounterICU.StartOfFirstICU ( )
      and NoVTEMedication.authoredOn during day of ( end of AnesthesiaProcedure.performed.toInterval ( ) ).CalendarDayOfOrDayAfter ( )
    return QualifyingEncounterICU

define "No Mechanical VTE Prophylaxis Due to Medical Reason on Day of or Day After Procedure":
  from
    "Encounter with ICU Location" QualifyingEncounterICU,
    ["Procedure": "General or Neuraxial Anesthesia"] AnesthesiaProcedure,
    "No Mechanical VTE Prophylaxis Performed or Ordered" NoVTEDevice
    where NoVTEDevice.requestStatusReason in "Medical Reason For Not Providing Treatment"
      and AnesthesiaProcedure.status = 'completed'
      and AnesthesiaProcedure.performed.toInterval ( ) ends 1 day after day of QualifyingEncounterICU.StartOfFirstICU ( )
      and NoVTEDevice.authoredOn during day of ( end of AnesthesiaProcedure.performed.toInterval ( ) ).CalendarDayOfOrDayAfter ( )
    return QualifyingEncounterICU

define "Encounter with No VTE Prophylaxis Due to Patient Refusal":
  "No VTE Prophylaxis Due to Patient Refusal From Day of Start of Hospitalization To Day After First ICU Stay"
    union "No VTE Prophylaxis Due to Patient Refusal on Day of or Day After Procedure"

define "No VTE Prophylaxis Due to Patient Refusal From Day of Start of Hospitalization To Day After First ICU Stay":
  "Encounter with ICU Location" QualifyingEncounterICU
    with "No Mechanical or Pharmacological VTE Prophylaxis Due to Patient Refusal" PatientRefusal
      such that PatientRefusal.authoredOn during day of QualifyingEncounterICU.FromDayOfStartOfHospitalizationToDayAfterFirstICU ( )

define "No VTE Prophylaxis Due to Patient Refusal on Day of or Day After Procedure":
  from
    "Encounter with ICU Location" QualifyingEncounterICU,
    ["Procedure": "General or Neuraxial Anesthesia"] AnesthesiaProcedure,
    "No Mechanical or Pharmacological VTE Prophylaxis Due to Patient Refusal" PatientRefusal
    where AnesthesiaProcedure.status = 'completed'
      and AnesthesiaProcedure.performed.toInterval ( ) ends 1 day after day of QualifyingEncounterICU.StartOfFirstICU ( )
      and PatientRefusal.authoredOn during day of ( end of AnesthesiaProcedure.performed.toInterval ( ) ).CalendarDayOfOrDayAfter ( )
    return QualifyingEncounterICU

define "No Mechanical or Pharmacological VTE Prophylaxis Due to Patient Refusal":
  ( "No VTE Prophylaxis Medication Administered or Ordered" NoVTEMedication
      where NoVTEMedication.MedicationStatusReason in "Patient Refusal"
  )
    union ( "No Mechanical VTE Prophylaxis Performed or Ordered" NoVTEDevice
        where NoVTEDevice.requestStatusReason in "Patient Refusal"
    )

define "Denominator Exceptions":
  "Encounter with First ICU Location Stay Less Than 1 day"

define "Encounter with First ICU Location Stay Less Than 1 day":
  "Encounter with ICU Location" QualifyingEncounterICU
    where QualifyingEncounterICU.firstInpatientIntensiveCareUnit ( ).period.lengthInDays ( ) < 1