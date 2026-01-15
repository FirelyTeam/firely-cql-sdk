library CMS1173FHIRDiagnosticDelayVTE version '1.0.000'

using QICore version '6.0.0'

include CQMCommon version '4.1.000' called CQMCommon
include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '4.0.000' called QICoreCommon
include SupplementalDataElements version '5.1.000' called SDE

codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Anticoagulant Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1206.19'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Ethnicity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837'
valueset "Hospice Care Ambulatory": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15'
valueset "Hospice Diagnosis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165'
valueset "Hospice Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003'
valueset "Imaging Related to VTE": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1206.47'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Outpatient Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087'
valueset "Palliative Care Diagnosis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167'
valueset "Palliative Care Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090'
valueset "Palliative Care Intervention": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135'
valueset "VTE Diagnoses": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1206.49'
valueset "VTE Symptoms": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1206.51'

code "Discharge to healthcare facility for hospice care (procedure)": '428371000124100' from "SNOMEDCT" display 'Discharge to healthcare facility for hospice care (procedure)'
code "Discharge to home for hospice care (procedure)": '428361000124107' from "SNOMEDCT" display 'Discharge to home for hospice care (procedure)'
code "Hospice care [Minimum Data Set]": '45755-6' from "LOINC" display 'Hospice care [Minimum Data Set]'
code "Yes (qualifier value)": '373066001' from "SNOMEDCT" display 'Yes (qualifier value)'
code "Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)": '71007-9' from "LOINC" display 'Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
    /***
    * Includes all Qualified VTE Encounters in which the patient was aged 18 or older at the start of the qualified VTE encounter.
    ***/
  
  "Qualified VTE Encounters During Measurement Period" QualifiedEncounter
    where AgeInYearsAt(date from start of QualifiedEncounter.period) >= 18

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "Qualified VTE Encounter With Hospice Services Within Previous 90 Days"
    union "Qualified VTE Encounter With Palliative Care Within Previous 90 Days"
    union "Qualified VTE Encounter With Other Qualified VTE Encounter Documented Within Previous 6 Months"

define "Numerator":
    /***
    * Includes all qualified VTE encounters in which the VTE diagnosis started greater than 24 hours after a qualifying PCP visit.
    ****/
  
  "Qualifying Delayed VTE Encounter"

define "Qualifying Performed Encounters":
  ( ["Encounter": "Office Visit"]
    union ["Encounter": "Outpatient Encounter"]
    union ["Encounter": "Encounter Inpatient"] ) Encounter
    where Encounter.status = 'finished'
      and Encounter.period starts during day of Interval[start of "Measurement Period" - 180 days, end of "Measurement Period"]

define "Qualifying Performed PCP Visits":
  ( ["Encounter": "Outpatient Encounter"]
    union ["Encounter": "Office Visit"] ) PCPVisit
    where PCPVisit.status = 'finished'
      and PCPVisit.period ends during day of Interval[start of "Measurement Period" - 210 days, end of "Measurement Period"]

define "Qualifying Performed PCP Visits With VTE Symptom":
  "Qualifying Performed PCP Visits" IndexPCPVisit
    where IndexPCPVisit.reasonCode in "VTE Symptoms"
      or exists ( [ConditionEncounterDiagnosis: "VTE Symptoms"] VTESymptomCondition
          where VTESymptomCondition.isVerified ( )
            and IndexPCPVisit.reasonReference.references ( VTESymptomCondition )
      )

define "Qualifying Performed VTE Encounters":
  "Qualifying Performed Encounters" VTEEncounter
    where VTEEncounter.reasonCode in "VTE Diagnoses"
      or exists ( [ConditionEncounterDiagnosis: "VTE Diagnoses"] VTECondition
          where VTECondition.isConfirmedCondition ( )
            and VTEEncounter.reasonReference.references ( VTECondition )
      )

define "Qualifying VTE Imaging Diagnostic Report":
  ["DiagnosticReportNote": "Imaging Related to VTE"] VTEDiagnosticReport
    where VTEDiagnosticReport.status in { 'final', 'amended', 'corrected' }

define "AntiCoagulant Therapy Ordered":
  ["MedicationRequest": "Anticoagulant Medications"] AntiCoagulant
    where AntiCoagulant.status in { 'active', 'completed' }
      and AntiCoagulant.intent = 'order'

define "Qualified VTE Encounters":
  from
    "Qualifying Performed VTE Encounters" VTEEncounter,
    "Qualifying Performed PCP Visits With VTE Symptom" IndexPCP,
    "Qualifying VTE Imaging Diagnostic Report" VTEStudy,
    "AntiCoagulant Therapy Ordered" AntiCoagulantOrdered
    where VTEStudy.effective.toInterval ( ) starts during day of VTEEncounter.period
      and ( AntiCoagulantOrdered.authoredOn 12 hours or less before VTEStudy.effective
          or AntiCoagulantOrdered.authoredOn 12 hours or less after VTEStudy.effective
      )
      and IndexPCP.period starts 30 days or less on or before VTEStudy.effective
    return VTEEncounter

define "Qualified VTE Encounters During Measurement Period":
  "Qualified VTE Encounters" QualifiedVTEEncounter
    where QualifiedVTEEncounter.period starts during day of "Measurement Period"

define "Qualifying Delayed VTE Encounter":
  "Qualified VTE Encounters During Measurement Period" DelayedVTEEncounter
    with "Qualifying Performed PCP Visits With VTE Symptom" IndexPCPVisit
      such that DelayedVTEEncounter.period starts during day of Interval[end of IndexPCPVisit.period + 2 day, end of IndexPCPVisit.period + 30 days]

define "Qualified VTE Encounter With Hospice Services Within Previous 90 Days":
  from
    "Qualified VTE Encounters" QualifiedVTEEncounter
    let NinetyDaysBeforeVTEEncounter: Interval[start of QualifiedVTEEncounter.period - 90 days, end of QualifiedVTEEncounter.period]
    where exists ( ["Encounter": "Encounter Inpatient"] InpatientEncounter
        where ( InpatientEncounter.hospitalization.dischargeDisposition ~ "Discharge to home for hospice care (procedure)"
            or InpatientEncounter.hospitalization.dischargeDisposition ~ "Discharge to healthcare facility for hospice care (procedure)"
        )
          and InpatientEncounter.period ends during day of NinetyDaysBeforeVTEEncounter
          and InpatientEncounter.status = 'finished'
    )
      or exists ( ["Encounter": "Hospice Encounter"] HospiceEncounter
          where HospiceEncounter.period overlaps day of NinetyDaysBeforeVTEEncounter
      )
      or exists ( ( [ObservationScreeningAssessment: "Hospice care [Minimum Data Set]"] ) HospiceAssessment
          where HospiceAssessment.value ~ "Yes (qualifier value)"
            and HospiceAssessment.effective.toInterval ( ) overlaps day of NinetyDaysBeforeVTEEncounter
      )
      or exists ( ( [ServiceRequest: "Hospice Care Ambulatory"] ) HospiceOrder
          where HospiceOrder.authoredOn during day of NinetyDaysBeforeVTEEncounter
            and HospiceOrder.status in { 'active', 'completed' }
      )
      or exists ( ( [Procedure: "Hospice Care Ambulatory"] ) HospicePerformed
          where HospicePerformed.performed.toInterval ( ) overlaps day of NinetyDaysBeforeVTEEncounter
      )
      or exists ( ( [ConditionEncounterDiagnosis: "Hospice Diagnosis"] ) HospiceCareDiagnosis
          where HospiceCareDiagnosis.prevalenceInterval ( ) overlaps day of NinetyDaysBeforeVTEEncounter
            and HospiceCareDiagnosis.isVerified ( )
      )
      or exists ( ( [ConditionProblemsHealthConcerns: "Hospice Diagnosis"] ) HospiceCareConcern
          where HospiceCareConcern.prevalenceInterval ( ) overlaps day of NinetyDaysBeforeVTEEncounter
            and HospiceCareConcern.isVerified ( )
      )

define "Qualified VTE Encounter With Palliative Care Within Previous 90 Days":
  from
    "Qualified VTE Encounters" QualifiedVTEEncounter
    let NinetyDaysBeforeVTEEncounter: Interval[start of QualifiedVTEEncounter.period - 90 days, end of QualifiedVTEEncounter.period]
    where exists ( ( [ObservationScreeningAssessment: "Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)"] ) PalliativeAssessment
        where PalliativeAssessment.effective.toInterval ( ) overlaps day of NinetyDaysBeforeVTEEncounter
          and PalliativeAssessment.status in { 'final', 'amended', 'corrected' }
    )
      or exists ( ( ( [ConditionEncounterDiagnosis: "Palliative Care Diagnosis"] ) ) PalliativeCareDiagnosis
          where PalliativeCareDiagnosis.prevalenceInterval ( ) overlaps day of NinetyDaysBeforeVTEEncounter
            and PalliativeCareDiagnosis.isVerified ( )
      )
      or exists ( ( [ConditionProblemsHealthConcerns: "Palliative Care Diagnosis"] ) PalliativeCareConcern
          where PalliativeCareConcern.prevalenceInterval ( ) overlaps day of NinetyDaysBeforeVTEEncounter
            and PalliativeCareConcern.isVerified ( )
      )
      or exists ( ( [Encounter: "Palliative Care Encounter"] ) PalliativeEncounter
          where PalliativeEncounter.period overlaps day of NinetyDaysBeforeVTEEncounter
      )
      or exists ( ( [Procedure: "Palliative Care Intervention"] ) PalliativeIntervention
          where PalliativeIntervention.performed.toInterval ( ) overlaps day of NinetyDaysBeforeVTEEncounter
      )

define "Qualified VTE Encounter With Other Qualified VTE Encounter Documented Within Previous 6 Months":
  "Qualified VTE Encounters" CurrentQualifiedVTE
    with "Qualified VTE Encounters" PreviousQualifiedVTE
      such that PreviousQualifiedVTE.period starts 6 months or less before start of CurrentQualifiedVTE.period

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"
  
/*
@description: Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential
*/


define fluent function isVerified(condition Choice<ConditionEncounterDiagnosis, ConditionProblemsHealthConcerns>):
  condition.verificationStatus is not null implies ( condition.verificationStatus ~ QICoreCommon."confirmed"
      or condition.verificationStatus ~ QICoreCommon."unconfirmed"
      or condition.verificationStatus ~ QICoreCommon."provisional"
      or condition.verificationStatus ~ QICoreCommon."differential"
  )

/*

/*
@description: Returns true if the given Condition is confirmed
*/


define fluent function isConfirmedCondition(condition ConditionEncounterDiagnosis):
  condition.verificationStatus ~ QICoreCommon."confirmed"