library AppropriateTreatmentforSTEMIFHIR version '1.0.000'

using QICore version '4.1.1'

/*This spec aligns with AU2023/PY2024 QDM version*/


include SupplementalDataElements version '3.4.000' called SDE
include QICoreCommon version '2.0.000' called QICoreCommon
include FHIRHelpers version '4.3.000' called FHIRHelpers
include CQMCommon version '2.0.000' called CQMCommon

codesystem "LOINC": 'http://loinc.org'
codesystem "HSLOC": 'https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html'
codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "ActCode": 'http://terminology.hl7.org/CodeSystem/v3-ActCode'

valueset "Active Bleeding Excluding Menses or Bleeding Diathesis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4036'
valueset "Active Peptic Ulcer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4031'
valueset "Adverse reaction to thrombolytics": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.6'
valueset "Allergy to thrombolytics": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.5'
valueset "Oral Anticoagulant Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4045'
valueset "Aortic Dissection and Rupture": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4028'
valueset "birth date": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4'
valueset "Cardiopulmonary Arrest": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4048'
valueset "Cerebral Vascular Lesion": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4025'
valueset "Closed Head and Facial Trauma": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4026'
valueset "Dementia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4043'
valueset "Discharge To Acute Care Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87'
valueset "ED": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1085'
valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292'
valueset "Endotracheal Intubation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.69'
valueset "Fibrinolytic Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4020'
valueset "Intracranial or Intraspinal surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.2'
valueset "Ischemic Stroke": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.104.12.1024'
valueset "Major Surgical Procedure": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4056'
valueset "Malignant Intracranial Neoplasm Group": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.3'
valueset "Insertion or Replacement of Mechanical Circulatory Assist Device": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052'
valueset "Neurologic impairment": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1012'
valueset "Patient Expired": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309'
valueset "Percutaneous Coronary Intervention": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.2000.5'
valueset "Pregnancy ICD10 SNOMEDCT": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4055'
valueset "STEMI": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4017'
valueset "Thrombolytic medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.4'

code "Birthdate": '21112-8' from "LOINC" display 'Birthdate'
code "Emergency Department": '1108-0' from "HSLOC" display 'Emergency Department'
code "Patient transfer (procedure)": '107724000' from "SNOMEDCT" display 'Patient transfer (procedure)'
code "Streptokinase adverse reaction (disorder)": '293571007' from "SNOMEDCT" display 'Streptokinase adverse reaction (disorder)'
code "EMER": 'EMER' from "ActCode" display 'emergency'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

/***Population Criteria***/


define "Initial Population":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    where AgeInYearsAt(date from start of(EDwithSTEMI.period)) >= 18

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "Allergy or Intolerance to Thrombolytic Medications Overlaps ED Encounter"
    union "Adverse Effect to Thrombolytic Medications Before End of ED Encounter"
    union "Active Exclusion Diagnosis at Start of ED Encounter"
    union "Active Oral Anticoagulant Medication at the Start of ED Encounter"
    union "Exclusion Diagnosis During ED Encounter or Within 24 Hours of ED Encounter Start"
    union "Major Surgical Procedure 21 Days or Less Before Start of or Starts During ED Encounter"
    union "Intubation or Mechanical Circulatory Assist Procedure During ED Encounter or Within 24 Hours of ED Encounter Start"
    union "Active Exclusion Diagnosis Within 90 Days Before or At the Start of ED Encounter"
    union "Intracranial or Intraspinal Procedure 90 Days or Less Before Start of ED Encounter"
    union "ED Encounter with Discharge Disposition as Patient Expired"

define "Numerator":
  "Fibrinolytic Therapy within 30 Minutes of Arrival"
    union "PCI within 90 Minutes of Arrival"
    union "ED Departure with Transfer to Acute Care Facility Within 45 Minutes of Arrival"


/***Definitions***/


define "Active Exclusion Diagnosis at Start of ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ( ["Condition": "Active Bleeding Excluding Menses or Bleeding Diathesis"]
      union ["Condition": "Malignant Intracranial Neoplasm Group"]
      union ["Condition": "Cerebral Vascular Lesion"]
      union ["Condition": "Dementia"]
      union ["Condition": "Pregnancy ICD10 SNOMEDCT"]
      union ["Condition": "Allergy to thrombolytics"] ) ActiveExclusionDx
      such that /*ActiveExclusionDx.isActive ()
        and */
      ActiveExclusionDx.prevalenceInterval ( ) overlaps before ( EDwithSTEMI.period )
/*KS 8-10-23: in CQLIT-389, discussed the impacts of requiring a clinical status of active but the condition could end before the end (during) the ED Visit, which would trigger an inactive status. Decided to not follow the Authoring Patterns and remove the requirement for a clinicalstatus of 'active'  */


define "Active Exclusion Diagnosis Within 90 Days Before or At the Start of ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwSTEMI
    with ( ["Condition": "Ischemic Stroke"]
      union ["Condition": "Closed Head and Facial Trauma"]
      union ["Condition": "Active Peptic Ulcer"]
      union ["Condition": "Cardiopulmonary Arrest"] ) ExclusionCondition
      such that /* ExclusionCondition.isActive ()
   and */
      ExclusionCondition.prevalenceInterval ( ) starts during Interval[start of ( EDwSTEMI.period ) - 90 days, start of ( EDwSTEMI.period )]

define "Active Oral Anticoagulant Medication at the Start of ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ["MedicationRequest": "Oral Anticoagulant Medications"] OralAnticoagulant
      such that OralAnticoagulant.status = 'active'
        and OralAnticoagulant.intent = 'order'
        and OralAnticoagulant.authoredOn before or on start of EDwithSTEMI.period
    /*this definition differs from QDM re: timing - cannot use overlaps for a single point in time*/

/*define "Adverse Effect to Thrombolytic Medications Before End of ED Encounter":
"ED Encounter with STEMI Diagnosis" EDwSTEMI
    with [AdverseEvent: event in "Thrombolytic medications"] ThrombolyticAdverseEvent
    such that ThrombolyticAdverseEvent.category in "Adverse reaction to thrombolytics"
    and ThrombolyticAdverseEvent.recordedDate before end of ( EDwSTEMI.period )
        and ThrombolyticAdverseEvent.actuality = 'actual'*/
/*KS Note - not sure we need category in the logic - it is must support, but not sure this brings value to the measure logic*/




define "Adverse Effect to Thrombolytic Medications Before End of ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwSTEMI
    with [AdverseEvent: event in "Adverse reaction to thrombolytics"] ThrombolyticAdverseEvent
      such that ThrombolyticAdverseEvent.recordedDate before end of ( EDwSTEMI.period )
        and ThrombolyticAdverseEvent.actuality = 'actual'

define "Allergy or Intolerance to Thrombolytic Medications Overlaps ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwSTEMI
    with ["AllergyIntolerance": "Thrombolytic medications"] ThrombolyticAllergy
      such that ThrombolyticAllergy.clinicalStatus ~ QICoreCommon."allergy-active"
        and ThrombolyticAllergy.onset.toInterval ( ) overlaps ( EDwSTEMI.period )

define "ED Departure with Transfer to Acute Care Facility Within 45 Minutes of Arrival":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    where ( EDwithSTEMI.period ) ends 45 minutes or less after start of ( EDwithSTEMI.period )
      and EDwithSTEMI.hospitalization.dischargeDisposition in "Discharge To Acute Care Facility"

define "ED Encounter with Diagnosis of STEMI":
  ["Encounter": "ED"] EDEncounter
    with ["Condition": "STEMI"] DxSTEMI
      such that DxSTEMI.clinicalStatus ~ QICoreCommon."active"
        and EDEncounter.status = 'finished'
        and EDEncounter.class ~ "EMER"
        and DxSTEMI.prevalenceInterval ( ) starts during EDEncounter.period
        and EDEncounter.period during day of "Measurement Period"

define "ED Encounter with Discharge Disposition as Patient Expired":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    where EDwithSTEMI.hospitalization.dischargeDisposition in "Patient Expired"

define "ED Encounter with Encounter Diagnosis of STEMI":
  ["Encounter": "ED"] EDEncounter
    where EDEncounter.status = 'finished'
      and EDEncounter.class ~ "EMER"
      and ( EDEncounter.reasonCode in "STEMI"
          or exists ( ( EDEncounter.encounterDiagnosis ( ) ) EncDiagnosis
              where EncDiagnosis.code in "STEMI"
          )
      )
      and EDEncounter.period during "Measurement Period"

define "ED Encounter with STEMI Diagnosis":
  "ED Encounter with Encounter Diagnosis of STEMI"
    union "ED Encounter with Diagnosis of STEMI"

define "Exclusion Diagnosis During ED Encounter or Within 24 Hours of ED Encounter Start":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ( ["Condition": "Aortic Dissection and Rupture"]
      union ["Condition": "Neurologic impairment"]
      union ["Condition": "Cardiopulmonary Arrest"] ) ExclusionDiagnosis
      such that ( ExclusionDiagnosis.prevalenceInterval ( ) starts during EDwithSTEMI.period )
        or ( ExclusionDiagnosis.prevalenceInterval ( ) starts 24 hours or less before start of EDwithSTEMI.period )
/*Did not include a status of active as any diagnosis that resolves during the ED visit would not be counted*/


define "Fibrinolytic Therapy within 30 Minutes of Arrival":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ["MedicationAdministration": "Fibrinolytic Therapy"] Fibrinolytic
      such that Fibrinolytic.status = 'completed'
        and start of ( Fibrinolytic.effective.toInterval ( ) ) 30 minutes or less after EDwithSTEMI.currentemergencyDepartmentArrivalTime ( )

define "Intracranial or Intraspinal Procedure 90 Days or Less Before Start of ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ["Procedure": "Intracranial or Intraspinal surgery"] CranialorSpinalSurgery
      such that CranialorSpinalSurgery.performed.toInterval ( ) starts 90 days or less before start of ( EDwithSTEMI.period )
        and CranialorSpinalSurgery.status = 'completed'

define "Intubation or Mechanical Circulatory Assist Procedure During ED Encounter or Within 24 Hours of ED Encounter Start":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ( ["Procedure": "Endotracheal Intubation"]
      union ["Procedure": "Insertion or Replacement of Mechanical Circulatory Assist Device"] ) AirwayProcedure
      such that ( ( AirwayProcedure.performed.toInterval ( ) starts during ( EDwithSTEMI.period ) )
          or ( AirwayProcedure.performed.toInterval ( ) starts 24 hours or less before start of ( EDwithSTEMI.period ) )
      )
        and AirwayProcedure.status = 'completed'

define "Major Surgical Procedure 21 Days or Less Before Start of or Starts During ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ["Procedure": "Major Surgical Procedure"] MajorSurgery
      such that MajorSurgery.performed.toInterval ( ) starts 21 days or less before start of ( EDwithSTEMI.period )
        and MajorSurgery.status = 'completed'

define "PCI within 90 Minutes of Arrival":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ["Procedure": "Percutaneous Coronary Intervention"] PCI
      such that PCI.performed.toInterval ( ) starts 90 minutes or less after EDwithSTEMI.currentemergencyDepartmentArrivalTime ( )
        and PCI.status = 'completed'

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

/*
@description: Returns the emergency department arrival time for the encounter.
*/


define fluent function currentemergencyDepartmentArrivalTime(EDEncounter Encounter):
  start of ( singleton from ( ( ( EDEncounter.location ) ) EDLocation
        where CQMCommon.GetLocation ( EDLocation.location ).type in "Emergency Department Visit"
    )
  ).period