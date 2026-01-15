library CMS996FHIRAptTxforSTEMI version '2.0.000'

using QICore version '6.0.0'

include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon
include FHIRHelpers version '4.4.000' called FHIRHelpers
include CQMCommon version '4.1.000' called CQMCommon
include Status version '1.15.000' called Status

codesystem "LOINC": 'http://loinc.org'
codesystem "HSLOC": 'https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html'
codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "ActCode": 'http://terminology.hl7.org/CodeSystem/v3-ActCode'
codesystem "ICD10CM": 'http://hl7.org/fhir/sid/icd-10-cm'
codesystem "RoleCode": 'http://terminology.hl7.org/CodeSystem/v3-RoleCode'

valueset "Active Bleeding or Bleeding Diathesis, Excluding Menses": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4036'
valueset "Active Peptic Ulcer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4031'
valueset "Thrombolytics Adverse Event": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.6'
valueset "Allergy to thrombolytics": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.5'
valueset "Oral Anticoagulant Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4045'
valueset "Aortic Dissection or Ruptured Aortic Aneurysm": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4028'
valueset "Cardiopulmonary Emergency": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4048'
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
valueset "Mechanical Circulatory Assist Device": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.3157.4052'
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
code "Emergency room": 'ER' from "RoleCode" display 'Emergency room'
code "Emergency trauma unit": 'ETU' from "RoleCode" display 'Emergency trauma unit'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
  "ED Encounter with STEMI Diagnosis"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "Allergy or Intolerance to Thrombolytic Medications Overlaps ED Encounter"
    union "Adverse Effect to Thrombolytic Medications Before End of ED Encounter"
    union "Active Exclusion Diagnosis at Start of ED Encounter"
    union "Active use of Anticoagulants"
    union "Exclusion Diagnosis During ED Encounter or Within 24 Hours of ED Encounter Start"
    union "Major Surgical Procedure 21 Days or Less Before Start of or Starts During ED Encounter"
    union "Intubation or Mechanical Circulatory Assist Device Placement or Removal Procedure During ED Encounter or Within 24 Hours of ED Encounter Start"
    union "Active Exclusion Diagnosis Within 90 Days Before or At the Start of ED Encounter"
    union "Intracranial or Intraspinal Procedure 90 Days or Less Before Start of ED Encounter"
    union "ED Encounter with Discharge Disposition as Patient Expired"
    union "ED Encounter with Discharge Disposition as Left Against Medical Advice"
    union "ED Encounter with Hospice Services"
    union "Currently Pregnant"

define "Denominator Exceptions":
  "Received tPA in Another Facility within 24 hours Prior to Admission"
    union "ED Encounter with a Documented Reason for No PCI Performed"
    union "ED Encounter with a Documented Reason for Not Administering Fibrinolytic Therapy"

define "Numerator":
  "Fibrinolytic Therapy Administration within 30 Minutes of Arrival"
    union "PCI within 90 Minutes of Arrival"
    union "ED Departure with Discharge to Acute Care Facility Within 45 Minutes Of Arrival"

define "Active Exclusion Diagnosis at Start of ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ( ( ["ConditionProblemsHealthConcerns": "Active Bleeding or Bleeding Diathesis, Excluding Menses"]
        union ["ConditionProblemsHealthConcerns": "Malignant Intracranial Neoplasm Group"]
        union ["ConditionProblemsHealthConcerns": "Cerebral Vascular Lesion"]
        union ["ConditionProblemsHealthConcerns": "Dementia and Related Intracranial Pathologies"]
        union ["ConditionProblemsHealthConcerns": "Pregnant State"]
        union ["ConditionProblemsHealthConcerns": "Allergy to thrombolytics"]
    ).verified ( ) ) ActiveExclusionDx
      such that ActiveExclusionDx.prevalenceInterval ( ) overlaps before ( EDwithSTEMI.period )

define "Currently Pregnant":
  "ED Encounter with STEMI Diagnosis" EDwSTEMI
    with ( ["USCoreObservationPregnancyStatusProfile"] ) PregStatus
      such that PregStatus.status = 'final'
        and ( PregStatus.value in "Pregnant State" )
        and ( PregStatus.effective during EDwSTEMI.period )

define "Active Exclusion Diagnosis Within 90 Days Before or At the Start of ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwSTEMI
    with ( ( ["ConditionProblemsHealthConcerns": "Ischemic Stroke"]
        union ["ConditionProblemsHealthConcerns": "Closed Head and Facial Trauma"]
        union ["ConditionProblemsHealthConcerns": "Active Peptic Ulcer"]
    ).verified ( ) ) ExclusionCondition
      such that ExclusionCondition.prevalenceInterval ( ) starts during Interval[start of ( EDwSTEMI.period ) - 90 days, start of ( EDwSTEMI.period )]

define "Active Oral Anticoagulant Medication at the Start of ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ["MedicationRequest": "Oral Anticoagulant Medications"] OralAnticoagulant
      such that OralAnticoagulant.status in { 'active', 'completed' }
        and OralAnticoagulant.intent = 'order'
        and OralAnticoagulant.authoredOn 90 days or less before or on start of EDwithSTEMI.period

define "Active Long Term use of Anticoagulants":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ( ( ["ConditionProblemsHealthConcerns": "Long term (current) use of anticoagulants"]
        union ["ConditionEncounterDiagnosis": "Long term (current) use of anticoagulants"]
    ).verified ( ) ) LongTermAnticoagulant
      such that ( LongTermAnticoagulant.prevalenceInterval ( ) starts before or on start of EDwithSTEMI.period
          and LongTermAnticoagulant.prevalenceInterval ( ) ends on or after start of EDwithSTEMI.period
      )

define "Active use of Anticoagulants":
  "Active Oral Anticoagulant Medication at the Start of ED Encounter"
    union "Active Long Term use of Anticoagulants"

define "Adverse Effect to Thrombolytic Medications Before End of ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwSTEMI
    with [AdverseEvent: "Thrombolytics Adverse Event"] ThrombolyticAdverseEvent
      such that Coalesce(ThrombolyticAdverseEvent.date, ThrombolyticAdverseEvent.detected, ThrombolyticAdverseEvent.recordedDate) before end of ( EDwSTEMI.period )
        and ThrombolyticAdverseEvent.actuality = 'actual'

define "Allergy or Intolerance to Thrombolytic Medications Overlaps ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwSTEMI
    with ["AllergyIntolerance": "Thrombolytic medications"] ThrombolyticAllergy
      such that ThrombolyticAllergy.clinicalStatus ~ QICoreCommon."allergy-active"
        and ( ThrombolyticAllergy.verificationStatus is not null implies ( ThrombolyticAllergy.verificationStatus ~ QICoreCommon."allergy-confirmed"
              or ThrombolyticAllergy.verificationStatus ~ QICoreCommon."allergy-unconfirmed"
          )
        )
        and ( ThrombolyticAllergy.onset.toInterval ( ) overlaps ( EDwSTEMI.period )
            or ThrombolyticAllergy.onset before end EDwSTEMI.period
        )

define "ED Departure with Discharge to Acute Care Facility Within 45 Minutes Of Arrival":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    where EDwithSTEMI.currentemergencyDepartmentDepartTime ( ) 45 minutes or less after EDwithSTEMI.currentemergencyDepartmentArrivalTime ( )
      and EDwithSTEMI.hospitalization.dischargeDisposition in "Discharge To Acute Care Facility"

define "ED Encounter During MP":
  ["Encounter": class ~ "EMER"] EDEncounter
    where EDEncounter.type in "Emergency Department Evaluation and Management Visit"
      and EDEncounter.period ends during day of "Measurement Period"
      and EDEncounter.status = 'finished'
      and AgeInYearsAt(date from start of(EDEncounter.period)) >= 18

define "ED Encounter with STEMI Diagnosis":
  "ED Encounter During MP" EDEncounterinMP
    where ( EDEncounterinMP.reasonCode in "STEMI"
        or exists ( ( ( [ConditionProblemsHealthConcerns: "STEMI"]
              union [ConditionEncounterDiagnosis: "STEMI"]
          ).verified ( ) ) DxSTEMI
            where ( EDEncounterinMP.encounterDiagnosis ( ).code in "STEMI"
                or ( DxSTEMI.prevalenceInterval ( ) starts during EDEncounterinMP.period )
            )
        )
    )

define "ED Encounter with Discharge Disposition as Patient Expired":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    where EDwithSTEMI.hospitalization.dischargeDisposition in "Patient Expired"

define "ED Encounter with Discharge Disposition as Left Against Medical Advice":
  "ED Encounter with STEMI Diagnosis" EDwSTEMI
    where EDwSTEMI.hospitalization.dischargeDisposition in "Left Against Medical Advice"

define "ED Encounter with Hospice Services":
  from
    "ED Encounter with STEMI Diagnosis" EDwSTEMI
    let SixMonthsBeforeToEndOfSTEMI: Interval[start of ( EDwSTEMI.period ) - 6 months, end of ( EDwSTEMI.period )]
    where ( exists ( ( ( [Encounter: "Encounter Inpatient"] ).isEncounterPerformed ( ) ) InpatientEncounter
          where ( InpatientEncounter.hospitalization.dischargeDisposition ~ "Discharge to home for hospice care (procedure)"
              or InpatientEncounter.hospitalization.dischargeDisposition ~ "Discharge to healthcare facility for hospice care (procedure)"
          )
            and InpatientEncounter.period starts before or on start of ( EDwSTEMI.period )
            and InpatientEncounter.period overlaps day of SixMonthsBeforeToEndOfSTEMI
      )
        or exists ( ( ( [Encounter: "Hospice Encounter"] ).isEncounterPerformed ( ) ) HospiceEncounter
            where HospiceEncounter.period starts before or on start of ( EDwSTEMI.period )
              and ( HospiceEncounter.period overlaps day of SixMonthsBeforeToEndOfSTEMI )
        )
        or exists ( ( ( [ObservationScreeningAssessment: "Hospice care [Minimum Data Set]"] ).isAssessmentPerformed ( ) ) HospiceAssessment
            where ( HospiceAssessment as ObservationScreeningAssessment ).value ~ "Yes (qualifier value)"
              and HospiceAssessment.effective.toInterval ( ) starts before or on start of ( EDwSTEMI.period )
              and ( HospiceAssessment.effective.toInterval ( ) overlaps day of SixMonthsBeforeToEndOfSTEMI )
        )
        or exists ( ( ( [ServiceRequest: "Hospice Care Ambulatory"] ).isInterventionOrder ( ) ) HospiceOrder
            where HospiceOrder.authoredOn 6 months or less before start of ( EDwSTEMI.period )
        )
        or exists ( ( ( [Procedure: "Hospice Care Ambulatory"] ).isInterventionPerformed ( ) ) HospicePerformed
            where HospicePerformed.performed.toInterval ( ) starts before or on start of ( EDwSTEMI.period )
              and ( HospicePerformed.performed.toInterval ( ) overlaps day of SixMonthsBeforeToEndOfSTEMI )
        )
        or exists ( ( ( [ConditionProblemsHealthConcerns: "Hospice Diagnosis"] ).verified ( ) ) HospiceCareDiagnosis
            where HospiceCareDiagnosis.prevalenceInterval ( ) ends on or after start of ( EDwSTEMI.period )
        )
    )

define "Exclusion Diagnosis During ED Encounter or Within 24 Hours of ED Encounter Start":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ( ( ["ConditionProblemsHealthConcerns": "Aortic Dissection or Ruptured Aortic Aneurysm"]
        union ["ConditionProblemsHealthConcerns": "Neurologic impairment"]
        union ["ConditionProblemsHealthConcerns": "Angina pectoris with documented spasm"]
        union ["ConditionProblemsHealthConcerns": "Ventricular aneurysm due to and following acute myocardial infarction (disorder)"]
        union ["ConditionProblemsHealthConcerns": "Aneurysm of heart"]
        union ["ConditionProblemsHealthConcerns": "Takotsubo cardiomyopathy (disorder)"]
        union ["ConditionProblemsHealthConcerns": "Takotsubo syndrome"]
        union ["ConditionProblemsHealthConcerns": "Cardiopulmonary Emergency"]
    ).verified ( ) ) ExclusionDiagnosis
      such that ( ( ExclusionDiagnosis.prevalenceInterval ( ) starts during EDwithSTEMI.period )
          or ( ExclusionDiagnosis.prevalenceInterval ( ) starts 24 hours or less before start of EDwithSTEMI.period )
      )

define "Received tPA in Another Facility within 24 hours Prior to Admission":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ( ( ["ConditionProblemsHealthConcerns": "Status post administration of tPA (rtPA) in a different facility within the last 24 hours prior to admission to current facility"]
        union ["ConditionEncounterDiagnosis": "Status post administration of tPA (rtPA) in a different facility within the last 24 hours prior to admission to current facility"]
    ).verified ( ) ) TPA
      such that TPA.prevalenceInterval ( ) starts during EDwithSTEMI.period

define "ED Encounter with a Documented Reason for No PCI Performed":
  "ED Encounter with STEMI Diagnosis" EDwSTEMI
    with ["ProcedureNotDone": "Percutaneous Coronary Intervention"] PCINotDone
      such that ( PCINotDone.statusReason in "Patient Refusal"
          or PCINotDone.statusReason in "Procedure Not Indicated/Contraindicated"
      )
        and PCINotDone.recorded during EDwSTEMI.period

define "ED Encounter with a Documented Reason for Not Administering Fibrinolytic Therapy":
  "ED Encounter with STEMI Diagnosis" EDwSTEMI
    with ["MedicationAdministrationNotDone": "Fibrinolytic Therapy"] FibrinolyticNoMed
      such that ( FibrinolyticNoMed.statusReason in "Patient Refusal"
          or FibrinolyticNoMed.statusReason in "Drug Intervention Not Indicated/Contraindicated"
      )
        and FibrinolyticNoMed.recorded during EDwSTEMI.period

define "Fibrinolytic Therapy Administration within 30 Minutes of Arrival":
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
      union ["Procedure": "Mechanical Circulatory Assist Device"] ) AirwayProcedure
      such that ( ( AirwayProcedure.performed.toInterval ( ) starts during ( EDwithSTEMI.period ) )
          or ( AirwayProcedure.performed.toInterval ( ) starts 24 hours or less before start of ( EDwithSTEMI.period ) )
      )
        and AirwayProcedure.status = 'completed'

define "Major Surgical Procedure 21 Days or Less Before Start of or Starts During ED Encounter":
  "ED Encounter with STEMI Diagnosis" EDwithSTEMI
    with ["Procedure": "Major Surgical Procedure"] MajorSurgery
      such that ( MajorSurgery.performed.toInterval ( ) starts 21 days or less before start of EDwithSTEMI.period
          or MajorSurgery.performed.toInterval ( ) starts during EDwithSTEMI.period
      )
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
  First(EDEncounter.location EDLocation
      where exists((EDLocation.location.getLocation().type) LocationType
          where(LocationType in "Emergency Department Visit"
              or LocationType ~ "Emergency room"
              or LocationType ~ "Emergency trauma unit"
          )
            and start of EDLocation.period is not null
      )
      return start of EDLocation.period
      sort ascending
  )

define fluent function currentemergencyDepartmentDepartTime(EDEncounter Encounter):
  Last(EDEncounter.location EDLocation
      where exists((EDLocation.location.getLocation().type) LocationType
          where(LocationType in "Emergency Department Visit"
              or LocationType ~ "Emergency room"
              or LocationType ~ "Emergency trauma unit"
          )
            and 
            end of EDLocation.period is not null
      )
      return 
      end of EDLocation.period
      sort ascending
  )