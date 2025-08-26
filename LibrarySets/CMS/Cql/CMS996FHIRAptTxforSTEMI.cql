library CMS996FHIRAptTxforSTEMI version '1.2.001'

using QICore version '4.1.1'

include SupplementalDataElements version '3.5.000' called SDE
include QICoreCommon version '2.1.000' called QICoreCommon
include FHIRHelpers version '4.4.000' called FHIRHelpers
include CQMCommon version '2.2.000' called CQMCommon
include Status version '1.8.000' called Status

codesystem "LOINC": 'http://loinc.org'
codesystem "HSLOC": 'https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html'
codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "ActCode": 'http://terminology.hl7.org/CodeSystem/v3-ActCode'
codesystem "ICD10CM": 'http://hl7.org/fhir/sid/icd-10-cm'

valueset "Active Bleeding Excluding Menses or Bleeding Diathesis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4036'
valueset "Active Peptic Ulcer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4031'
valueset "Thrombolytics Adverse Event": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.6'
valueset "Allergy to thrombolytics": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.5'
valueset "Oral Anticoagulant Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4045'
valueset "Aortic Dissection or Ruptured Aortic Aneurysm": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4028'
valueset "Cardiopulmonary Arrest": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4048'
valueset "Cerebral Vascular Lesion": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4025'
valueset "Closed Head and Facial Trauma": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4026'
valueset "Dementia and Related Intracranial Pathologies": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4043'
valueset "Discharge To Acute Care Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87'
valueset "Emergency Department Evaluation and Management Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010'
valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292'
valueset "Endotracheal Intubation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.69'
valueset "Fibrinolytic Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4019'
valueset "Intracranial or Intraspinal surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.2'
valueset "Ischemic Stroke": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247'
valueset "Major Surgical Procedure": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4056'
valueset "Malignant Intracranial Neoplasm Group": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.3'
valueset "Insertion or Replacement of Mechanical Circulatory Assist Device": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052'
valueset "Neurologic impairment": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1012'
valueset "Patient Expired": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309'
valueset "Percutaneous Coronary Intervention": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.2000.5'
valueset "Pregnant State": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4055'
valueset "STEMI": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4017'
valueset "Thrombolytic medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.4'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Hospice Care Ambulatory": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1584'
valueset "Hospice Diagnosis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165'
valueset "Hospice Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003'
valueset "Insertion, Replacement, or Removal of Mechanical Circulatory Assist Device": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052'
valueset "Patient Refusal": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93'
valueset "Left Against Medical Advice": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308'
valueset "Drug Intervention Not Indicated/Contraindicated": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1282.1'
valueset "Procedure Not Indicated/Contraindicated": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1282.2'

code "EMER": 'EMER' from "ActCode" display 'emergency'
code "Status post administration of tPA (rtPA) in a different facility within the last 24 hours prior to admission to current facility": 'Z92.82' from "ICD10CM" display 'Status post administration of tPA (rtPA) in a different facility within the last 24 hours prior to admission to current facility'
code "Angina pectoris with documented spasm": 'I20.1' from "ICD10CM" display 'Angina pectoris with documented spasm'
code "Long term (current) use of anticoagulants": 'Z79.01' from "ICD10CM" display 'Long term (current) use of anticoagulants'
code "Takotsubo cardiomyopathy (disorder)": '441541008' from "SNOMEDCT" display 'Takotsubo cardiomyopathy (disorder)'
code "Takotsubo syndrome": 'I51.81' from "ICD10CM" display 'Takotsubo syndrome'
code "Ventricular aneurysm due to and following acute myocardial infarction (disorder)": '723858002' from "SNOMEDCT" display 'Ventricular aneurysm due to and following acute myocardial infarction (disorder)'
code "Aneurysm of heart": 'I25.3' from "ICD10CM" display 'Aneurysm of heart'
code "Discharge to healthcare facility for hospice care (procedure)": '428371000124100' from "SNOMEDCT" display 'Discharge to healthcare facility for hospice care (procedure)'
code "Discharge to home for hospice care (procedure)": '428361000124107' from "SNOMEDCT" display 'Discharge to home for hospice care (procedure)'
code "Hospice care [Minimum Data Set]": '45755-6' from "LOINC" display 'Hospice care [Minimum Data Set]'
code "Yes (qualifier value)": '373066001' from "SNOMEDCT" display 'Yes (qualifier value)'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2026-12-31T23:59:59.999Z]

context Patient

define "Initial Population":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    where AgeInYearsAt(date from start of(EDwithSTEMI.period)) >= 18

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "Allergy or Intolerance to Thrombolytic Medications Overlaps ED Encounter"
    union "Adverse Effect to Thrombolytic Medications Before End of ED Encounter"
    union "Active Exclusion Diagnosis at Start of ED Encounter"
    union "Active use of Anticoagulants"
    union "Exclusion Diagnosis During ED Encounter or Within 24 Hours of ED Encounter Start"
    union "Major Surgical Procedure 21 Days or Less Before Start of ED Encounter"
    union "Intubation or Mechanical Circulatory Assist Device Placement or Removal Procedure During ED Encounter or Within 24 Hours of ED Encounter Start"
    union "Active Exclusion Diagnosis Within 90 Days Before or At the Start of ED Encounter"
    union "Intracranial or Intraspinal Procedure 90 Days or Less Before Start of ED Encounter"
    union "ED Encounter with Discharge Disposition as Patient Expired"
    union "ED Encounter with Discharge Disposition as Left Against Medical Advice"
    union "ED Encounter with Hospice Services"

define "Denominator Exceptions":
  "Received tPA in Another Facility within 24 hours Prior to Admission"
    union "ED Encounter with a Documented Reason for No PCI Performed Within 90 Minutes of ED Arrival"
    union "ED Encounter with a Documented Reason for Not Administering Fibrinolytic Therapy Within 30 Minutes of ED Arrival"

define "Numerator":
  "Fibrinolytic Therapy within 30 Minutes of Arrival"
    union "PCI within 90 Minutes of Arrival"
    union "ED Departure with Transfer to Acute Care Facility Within 45 Minutes of Arrival"

define "Active Exclusion Diagnosis at Start of ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ( ["Condition": "Active Bleeding Excluding Menses or Bleeding Diathesis"]
      union ["Condition": "Malignant Intracranial Neoplasm Group"]
      union ["Condition": "Cerebral Vascular Lesion"]
      union ["Condition": "Dementia and Related Intracranial Pathologies"]
      union ["Condition": "Pregnant State"]
      union ["Condition": "Allergy to thrombolytics"] ) ActiveExclusionDx
      such that ActiveExclusionDx.prevalenceInterval ( ) overlaps before ( EDwithSTEMI.period )

define "Active Exclusion Diagnosis Within 90 Days Before or At the Start of ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwSTEMI
    with ( ["Condition": "Ischemic Stroke"]
      union ["Condition": "Closed Head and Facial Trauma"]
      union ["Condition": "Active Peptic Ulcer"] ) ExclusionCondition
      such that ExclusionCondition.prevalenceInterval ( ) starts during Interval[start of ( EDwSTEMI.period ) - 90 days, start of ( EDwSTEMI.period )]

define "Active Oral Anticoagulant Medication at the Start of ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ["MedicationRequest": "Oral Anticoagulant Medications"] OralAnticoagulant
      such that OralAnticoagulant.status = 'active'
        and OralAnticoagulant.intent = 'order'
        and OralAnticoagulant.authoredOn 90 days or less before or on start of EDwithSTEMI.period

define "Active Long Term use of Anticoagulants":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ["Condition": "Long term (current) use of anticoagulants"] LongTermAnticoagulant
      such that ( LongTermAnticoagulant.prevalenceInterval ( ) starts before or on start of EDwithSTEMI.period
          and LongTermAnticoagulant.prevalenceInterval ( ) ends on or after start of EDwithSTEMI.period
      )

define "Active use of Anticoagulants":
  "Active Oral Anticoagulant Medication at the Start of ED Encounter"
    union "Active Long Term use of Anticoagulants"

define "Adverse Effect to Thrombolytic Medications Before End of ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwSTEMI
    with [AdverseEvent: event in "Thrombolytics Adverse Event"] ThrombolyticAdverseEvent
      such that ThrombolyticAdverseEvent.recordedDate before end of ( EDwSTEMI.period )
        and ThrombolyticAdverseEvent.actuality = 'actual'

define "Allergy or Intolerance to Thrombolytic Medications Overlaps ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwSTEMI
    with ["AllergyIntolerance": "Thrombolytic medications"] ThrombolyticAllergy
      such that ThrombolyticAllergy.clinicalStatus ~ QICoreCommon."allergy-active"
        and ThrombolyticAllergy.onset.toInterval ( ) overlaps ( EDwSTEMI.period )

define "ED Departure with Transfer to Acute Care Facility Within 45 Minutes of Arrival":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    where EDwithSTEMI.currentemergencyDepartmentDepartTime ( ) 45 minutes or less after EDwithSTEMI.currentemergencyDepartmentArrivalTime ( )
      and EDwithSTEMI.hospitalization.dischargeDisposition in "Discharge To Acute Care Facility"

define "ED Encounter During MP":
  ["Encounter": "Emergency Department Evaluation and Management Visit"] EDEncounter
    where EDEncounter.period ends during day of "Measurement Period"
      and EDEncounter.status = 'finished'
      and EDEncounter.class ~ "EMER"

define "ED Encounter with STEMI Diagnosis":
  "ED Encounter During MP" EDEncounter
    where ( EDEncounter.reasonCode in "STEMI"
        or exists ( ( EDEncounter.encounterDiagnosis ( ) ) EncDiagnosis
            where EncDiagnosis.code in "STEMI"
        )
        or exists ( ["Condition": "STEMI"] DxSTEMI
            where DxSTEMI.clinicalStatus ~ QICoreCommon."active"
              and DxSTEMI.prevalenceInterval ( ) starts during EDEncounter.period
        )
    )

define "ED Encounter with Discharge Disposition as Patient Expired":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    where EDwithSTEMI.hospitalization.dischargeDisposition in "Patient Expired"

define "ED Encounter with Discharge Disposition as Left Against Medical Advice":
  "ED Encounter with STEMI Diagnosis" EDwSTEMI
    where EDwSTEMI.hospitalization.dischargeDisposition in "Left Against Medical Advice"

define "ED Encounter with Hospice Services":
  "ED Encounter with STEMI Diagnosis" EDwSTEMI
    where ( exists ( ( ( [Encounter: "Encounter Inpatient"] ).isEncounterPerformed ( ) ) InpatientEncounter
          where ( InpatientEncounter.hospitalization.dischargeDisposition ~ "Discharge to home for hospice care (procedure)"
              or InpatientEncounter.hospitalization.dischargeDisposition ~ "Discharge to healthcare facility for hospice care (procedure)"
          )
            and InpatientEncounter.period.toInterval ( ) starts before or on start of ( EDwSTEMI.period )
            and ( InpatientEncounter.period.toInterval ( ) ends 6 months or less before day of start of ( EDwSTEMI.period )
                or InpatientEncounter.period.toInterval ( ) ends on or after start of ( EDwSTEMI.period )
            )
      )
        or exists ( ( ( [Encounter: "Hospice Encounter"] ).isEncounterPerformed ( ) ) HospiceEncounter
            where HospiceEncounter.period.toInterval ( ) starts before or on start of ( EDwSTEMI.period )
              and ( HospiceEncounter.period.toInterval ( ) ends 6 months or less before day of start of ( EDwSTEMI.period )
                  or HospiceEncounter.period.toInterval ( ) ends on or after start of ( EDwSTEMI.period )
              )
        )
        or exists ( ( ( [Observation: "Hospice care [Minimum Data Set]"] ).isAssessmentPerformed ( ) ) HospiceAssessment
            where HospiceAssessment.value ~ "Yes (qualifier value)"
              and HospiceAssessment.effective.toInterval ( ) starts before or on start of ( EDwSTEMI.period )
              and ( HospiceAssessment.effective.toInterval ( ) ends 6 months or less before day of start of ( EDwSTEMI.period )
                  or HospiceAssessment.effective.toInterval ( ) ends on or after start of ( EDwSTEMI.period )
              )
        )
        or exists ( ( ( [ServiceRequest: "Hospice Care Ambulatory"] ).isInterventionOrder ( ) ) HospiceOrder
            where HospiceOrder.authoredOn.toInterval ( ) 6 months or less before start of ( EDwSTEMI.period )
        )
        or exists ( ( ( [Procedure: "Hospice Care Ambulatory"] ).isInterventionPerformed ( ) ) HospicePerformed
            where HospicePerformed.performed.toInterval ( ) starts before or on start of ( EDwSTEMI.period )
              and ( HospicePerformed.performed.toInterval ( ) ends 6 months or less before day of start of ( EDwSTEMI.period )
                  or HospicePerformed.performed.toInterval ( ) ends on or after start of ( EDwSTEMI.period )
              )
        )
        or exists ( ( [Condition: "Hospice Diagnosis"] ) HospiceCareDiagnosis
            where HospiceCareDiagnosis.prevalenceInterval ( ) ends on or after start of ( EDwSTEMI.period )
        )
    )

define "Exclusion Diagnosis During ED Encounter or Within 24 Hours of ED Encounter Start":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ( ["Condition": "Aortic Dissection or Ruptured Aortic Aneurysm"]
      union ["Condition": "Neurologic impairment"]
      union ["Condition": "Angina pectoris with documented spasm"]
      union ["Condition": "Ventricular aneurysm due to and following acute myocardial infarction (disorder)"]
      union ["Condition": "Aneurysm of heart"]
      union ["Condition": "Takotsubo cardiomyopathy (disorder)"]
      union ["Condition": "Takotsubo syndrome"]
      union ["Condition": "Cardiopulmonary Arrest"] ) ExclusionDiagnosis
      such that ( ExclusionDiagnosis.prevalenceInterval ( ) starts during EDwithSTEMI.period )
        or ( ExclusionDiagnosis.prevalenceInterval ( ) starts 24 hours or less before start of EDwithSTEMI.period )

define "Received tPA in Another Facility within 24 hours Prior to Admission":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ( ["Condition": "Status post administration of tPA (rtPA) in a different facility within the last 24 hours prior to admission to current facility"] ) TPA
      such that TPA.prevalenceInterval ( ) starts during EDwithSTEMI.period

define "Documented Reason for No PCI Performed Within 90 Minutes of ED Arrival":
  ["ProcedureNotDone": "Percutaneous Coronary Intervention"] PCINotDone
    where ( PCINotDone.statusReason in "Patient Refusal"
        or PCINotDone.statusReason in "Procedure Not Indicated/Contraindicated"
    )
    return {
      id: PCINotDone.id,
      authoredOn: PCINotDone.recorded
    }

define "ED Encounter with a Documented Reason for No PCI Performed Within 90 Minutes of ED Arrival":
  "ED Encounter with STEMI Diagnosis" EDwSTEMI
    with "Documented Reason for No PCI Performed Within 90 Minutes of ED Arrival" NoPCI
      such that NoPCI.authoredOn during EDwSTEMI.period

define "Documented Reason for Not Administering Fibrinolytic Therapy Within 30 Minutes of ED Arrival":
  ["MedicationAdministrationNotDone": "Fibrinolytic Therapy"] FibrinolyticNoMed
    where ( FibrinolyticNoMed.statusReason in "Patient Refusal"
        or FibrinolyticNoMed.statusReason in "Drug Intervention Not Indicated/Contraindicated"
    )
    return {
      id: FibrinolyticNoMed.id,
      authoredOn: FibrinolyticNoMed.recorded
    }

define "ED Encounter with a Documented Reason for Not Administering Fibrinolytic Therapy Within 30 Minutes of ED Arrival":
  "ED Encounter with STEMI Diagnosis" EDwSTEMI
    with "Documented Reason for Not Administering Fibrinolytic Therapy Within 30 Minutes of ED Arrival" NoFibrinolytic
      such that NoFibrinolytic.authoredOn during EDwSTEMI.period

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

define "Intubation or Mechanical Circulatory Assist Device Placement or Removal Procedure During ED Encounter or Within 24 Hours of ED Encounter Start":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ( ["Procedure": "Endotracheal Intubation"]
      union ["Procedure": "Insertion, Replacement, or Removal of Mechanical Circulatory Assist Device"] ) AirwayProcedure
      such that ( ( AirwayProcedure.performed.toInterval ( ) starts during ( EDwithSTEMI.period ) )
          or ( AirwayProcedure.performed.toInterval ( ) starts 24 hours or less before start of ( EDwithSTEMI.period ) )
      )
        and AirwayProcedure.status = 'completed'

define "Major Surgical Procedure 21 Days or Less Before Start of ED Encounter":
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

define fluent function currentemergencyDepartmentArrivalTime(EDEncounter Encounter):
  start of ( singleton from ( ( ( EDEncounter.location ) ) EDLocation
        where CQMCommon.GetLocation ( EDLocation.location ).type in "Emergency Department Visit"
    )
  ).period

define fluent function currentemergencyDepartmentDepartTime(EDEncounter Encounter):
  end of ( singleton from ( ( ( EDEncounter.location ) ) EDLocation
        where CQMCommon.GetLocation ( EDLocation.location ).type in "Emergency Department Visit"
    )
  ).period