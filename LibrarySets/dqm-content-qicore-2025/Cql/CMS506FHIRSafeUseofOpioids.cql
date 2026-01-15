library CMS506FHIRSafeUseofOpioids version '1.0.000'

using QICore version '6.0.0'

include CQMCommon version '4.1.000' called CQMCommon
include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '4.0.000' called QICoreCommon
include SupplementalDataElements version '5.1.000' called SDE

valueset "Cancer Related Pain": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.180'
valueset "Discharge To Acute Care Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87'
valueset "Hospice Care Referral or Admission": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365'
valueset "Left Against Medical Advice": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308'
valueset "Medications for Opioid Use Disorder (MOUD)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.269'
valueset "Opioid Medication Assisted Treatment (MAT)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.177'
valueset "Opioid Use Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.171'
valueset "Palliative or Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579'
valueset "Patient Expired": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309'
valueset "Schedule II, III and IV Opioid Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.241'
valueset "Schedule IV Benzodiazepines": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1'
valueset "Sickle Cell Disease with and without Crisis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.175'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
  "Inpatient Encounters With An Opioid Or Benzodiazepine At Discharge"

define "Denominator":
  "Initial Population"

define "Inpatient Encounter With Age Greater Than Or Equal To 18":
  CQMCommon."Inpatient Encounter" InpatientHospitalEncounter
    where AgeInYearsAt(date from start of InpatientHospitalEncounter.period) >= 18
                  
/*
@description: Captures encounters of patients with an opioid and/or benzodiazepine at discharge.
*/


define "Inpatient Encounters With An Opioid Or Benzodiazepine At Discharge":
  "Inpatient Encounter With Age Greater Than Or Equal To 18" InpatientEncounter
    with ( "Opioid At Discharge"
      union "Benzodiazepine At Discharge" ) OpioidOrBenzodiazepineAtDischarge
      such that OpioidOrBenzodiazepineAtDischarge.authoredOn during day of InpatientEncounter.period

define "Benzodiazepine At Discharge":
  ["MedicationRequest": "Schedule IV Benzodiazepines"] BenzoMedications
    where ( BenzoMedications.isCommunity ( )
        or BenzoMedications.isDischarge ( )
    )
      and BenzoMedications.status in { 'active', 'completed' }
      and BenzoMedications.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }

define "Opioid At Discharge":
  ["MedicationRequest": "Schedule II, III and IV Opioid Medications"] OpioidMedications
    where ( OpioidMedications.isCommunity ( )
        or OpioidMedications.isDischarge ( )
    )
      and OpioidMedications.status in { 'active', 'completed' }
      and OpioidMedications.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
        
/*
@description: Encounters of patients prescribed two or more opioids or an opioid and benzodiazepine at discharge.
*/


define "Numerator":
  "Denominator" InpatientEncounter
    where ( Count("Opioid At Discharge" OpioidMedications
          where OpioidMedications.authoredOn during day of InpatientEncounter.period
          return distinct OpioidMedications.medication
      ) >= 2
    )
      or ( exists "Opioid At Discharge" OpioidDischargeMedications
          where OpioidDischargeMedications.authoredOn during day of InpatientEncounter.period
            and exists ( "Benzodiazepine At Discharge" BenzodiazepineDischargeMedication
                where BenzodiazepineDischargeMedication.authoredOn during day of InpatientEncounter.period
            )
      )

define "Inpatient Encounter With Encounter Diagnosis Of Cancer Pain":
  "Denominator" QualifyingEncounter
    where QualifyingEncounter.reasonCode in "Cancer Related Pain"
      or QualifyingEncounter.encounterDiagnosis ( ).code in "Cancer Related Pain"

/*
@description: Excludes encounters of patients with cancer pain or who are receiving palliative or hospice care at the time of the encounter or who receive treatment for opioid use disorder, have sickle cell disease, or who are discharged to another inpatient care facility or discharged against medical advice, or expire during the inpatient stay.
*/


define "Denominator Exclusion":
  "Denominator" InpatientEncounter
    where exists ( ["ConditionProblemsHealthConcerns": "Cancer Related Pain"] CancerPain
        where CancerPain.prevalenceInterval ( ) overlaps day of InpatientEncounter.period
          and CancerPain.isVerified ( )
    )
      or exists ( "Inpatient Encounter With Encounter Diagnosis Of Cancer Pain" )
      or exists ( ["ConditionProblemsHealthConcerns": "Sickle Cell Disease with and without Crisis"] SickleCellDisease
          where SickleCellDisease.prevalenceInterval ( ) overlaps day of InpatientEncounter.period
            and SickleCellDisease.isVerified ( )
      )
      or exists ( "Treatment For Opioid Use Disorders" OUDTreatment
          where OUDTreatment.authoredOn during day of InpatientEncounter.period
      )
      or exists ( "Intervention Palliative Or Hospice Care" PalliativeOrHospiceCare
          where Coalesce(start of PalliativeOrHospiceCare.performed.toInterval(), PalliativeOrHospiceCare.authoredOn) during InpatientEncounter.hospitalizationWithObservation ( )
      )
      or ( InpatientEncounter.hospitalization.dischargeDisposition in "Discharge To Acute Care Facility"
          or InpatientEncounter.hospitalization.dischargeDisposition in "Hospice Care Referral or Admission"
          or InpatientEncounter.hospitalization.dischargeDisposition in "Patient Expired"
          or InpatientEncounter.hospitalization.dischargeDisposition in "Left Against Medical Advice"
      )

define "Treatment For Opioid Use Disorders":
  ( "Medications For Opioid Use Disorder" MedicationTreatment
      with ["Procedure": "Opioid Medication Assisted Treatment (MAT)"] MAT
        such that MedicationTreatment.authoredOn during day of MAT.performed.toInterval ( )
          and MedicationTreatment.authoredOn during day of "Measurement Period"
          and MAT.status in { 'completed', 'in-progress' }
  )
    union ( "Medications For Opioid Use Disorder" MedicationTreatment
        with ["ConditionProblemsHealthConcerns": "Opioid Use Disorder"] OUD
          such that MedicationTreatment.authoredOn during day of OUD.prevalenceInterval ( )
            and OUD.prevalenceInterval ( ) overlaps day of "Measurement Period"
            and OUD.isVerified ( )
    )

define "Medications For Opioid Use Disorder":
  ["MedicationRequest": "Medications for Opioid Use Disorder (MOUD)"] DischargeMedication
    where ( DischargeMedication.isCommunity ( )
        or DischargeMedication.isDischarge ( )
    )
      and DischargeMedication.status in { 'active', 'completed' }
      and DischargeMedication.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }

define "Intervention Palliative Or Hospice Care":
  ( ["ServiceRequest": "Palliative or Hospice Care"] PalliativeOrHospiceCareOrder
      where PalliativeOrHospiceCareOrder.status in { 'active', 'completed', 'on-hold' }
  )
    union ( ["Procedure": "Palliative or Hospice Care"] PalliativeOrHospiceCarePerformed
        where PalliativeOrHospiceCarePerformed.status in { 'completed', 'in-progress' }
    )

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


define fluent function isVerified(condition Choice<QICore.ConditionProblemsHealthConcerns, QICore.ConditionEncounterDiagnosis>):
  condition.verificationStatus is not null implies ( condition.verificationStatus ~ QICoreCommon."confirmed"
      or condition.verificationStatus ~ QICoreCommon."unconfirmed"
      or condition.verificationStatus ~ QICoreCommon."provisional"
      or condition.verificationStatus ~ QICoreCommon."differential"
  )