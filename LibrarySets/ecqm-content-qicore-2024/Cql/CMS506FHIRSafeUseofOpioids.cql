library CMS506FHIRSafeUseofOpioids version '0.2.004'

using QICore version '4.1.1'

include CQMCommon version '2.2.000' called CQMCommon
include FHIRHelpers version '4.4.000' called FHIRHelpers
include Hospice version '6.12.000' called Hospice
include QICoreCommon version '2.1.000' called QICoreCommon
include SupplementalDataElements version '3.5.000' called SDE

codesystem "LOINC": 'http://loinc.org'

valueset "Cancer Related Pain": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.180'
valueset "Discharge To Acute Care Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87'
valueset "Ethnicity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837'
valueset "Hospice Care Referral or Admission": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365'
valueset "Left Against Medical Advice": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.308'
valueset "Medications for Opioid Use Disorder (MOUD)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.269'
valueset "Patient sex for quality measurement": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1021.120'
valueset "Opioid Medication Assisted Treatment (MAT)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.177'
valueset "Opioid Use Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.171'
valueset "Palliative or Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579'
valueset "Patient Expired": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309'
valueset "Payer Type": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591'
valueset "Race": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836'
valueset "Schedule II, III and IV Opioid Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.241'
valueset "Schedule IV Benzodiazepines": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1'
valueset "Sickle Cell Disease with and without Crisis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.175'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2024-01-01T00:00:00.000Z, @2024-12-31T23:59:59.999Z]

context Patient

define "Denominator":
  "Initial Population"

define "Inpatient Encounter with Age Greater than or Equal to 18":
  CQMCommon."Inpatient Encounter" InpatientHospitalEncounter
    where AgeInYearsAt(date from start of InpatientHospitalEncounter.period) >= 18

define "Intervention Palliative or Hospice Care":
  ["ServiceRequest": "Palliative or Hospice Care"]
    union ["Procedure": "Palliative or Hospice Care"]

define "Initial Population":
  "Inpatient Encounters with an Opioid or Benzodiazepine at Discharge"

define "Treatment for Opioid Use Disorders":
  ( ["MedicationRequest": "Medications for Opioid Use Disorder (MOUD)"] MedicationTreatment
      with ["Procedure": "Opioid Medication Assisted Treatment (MAT)"] MAT
        such that MedicationTreatment.authoredOn during day of MAT.performed.toInterval ( )
          and MedicationTreatment.authoredOn during day of "Measurement Period"
  )
    union ( ["MedicationRequest": "Medications for Opioid Use Disorder (MOUD)"] MedicationTreatment
        with ["Condition": "Opioid Use Disorder"] OUD
          such that MedicationTreatment.authoredOn during day of OUD.prevalenceInterval ( )
            and OUD.prevalenceInterval ( ) overlaps day of "Measurement Period"
    )

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Denominator Exclusion":
  /*Excludes encounters of patients with cancer pain or who are receiving palliative or hospice care at the time of the encounter or who receive treatment for opioid use disorder, have sickle cell disease, or who are discharged to another inpatient care facility or discharged against medical advice, or expire during the inpatient stay*/
  
  ( "Inpatient Encounters with an Opioid or Benzodiazepine at Discharge" InpatientEncounter
      where exists ( ["Condition": "Cancer Related Pain"] CancerPain
          where ( CancerPain.isProblemListItem ( )
              or CancerPain.isHealthConcern ( )
          )
            and CancerPain.prevalenceInterval ( ) overlaps day of InpatientEncounter.period
      )
        or exists ( ( InpatientEncounter.encounterDiagnosis ( ) ) InpatientEncounterDiagnosis
            where InpatientEncounterDiagnosis.code in "Cancer Related Pain"
        )
        or exists ( ["Condition": "Sickle Cell Disease with and without Crisis"] SickleCellDisease
            where SickleCellDisease.prevalenceInterval ( ) overlaps day of InpatientEncounter.period
        )
        or exists ( "Treatment for Opioid Use Disorders" OUDTreatment
            where OUDTreatment.authoredOn during day of InpatientEncounter.period
        )
        or exists ( "Intervention Palliative or Hospice Care" PalliativeOrHospiceCare
            where Coalesce(start of PalliativeOrHospiceCare.performed.toInterval(), PalliativeOrHospiceCare.authoredOn) during day of InpatientEncounter."hospitalizationWithObservation" ( )
        )
        or ( InpatientEncounter.hospitalization.dischargeDisposition in "Discharge To Acute Care Facility"
            or InpatientEncounter.hospitalization.dischargeDisposition in "Hospice Care Referral or Admission"
            or InpatientEncounter.hospitalization.dischargeDisposition in "Patient Expired"
            or InpatientEncounter.hospitalization.dischargeDisposition in "Left Against Medical Advice"
        )
  )

define "Inpatient Encounters with an Opioid or Benzodiazepine at Discharge":
/*Captures encounters of patients with an opioid and/or benzodiazepine at discharge*/
  
  "Inpatient Encounter with Age Greater than or Equal to 18" InpatientEncounter
    with ( "Opioid at Discharge"
      union "Benzodiazepine at Discharge" ) OpioidOrBenzodiazepineAtDischarge
      such that OpioidOrBenzodiazepineAtDischarge.authoredOn during day of InpatientEncounter.period

define "Numerator":
  /*Encounters of patients prescribed two or more opioids or an opioid and benzodiazepine at discharge.*/
  
  ( ( "Inpatient Encounters with an Opioid or Benzodiazepine at Discharge" InpatientEncounter
        where ( Count("Opioid at Discharge" OpioidMedications
              where OpioidMedications.authoredOn during day of InpatientEncounter.period
              return distinct OpioidMedications.medication
          ) >= 2
        )
          or exists ( "Opioid at Discharge" OpioidDischargeMedications
              where OpioidDischargeMedications.authoredOn during day of InpatientEncounter.period
                and exists "Benzodiazepine at Discharge" BenzodiazepineDischargeMedication
                  where BenzodiazepineDischargeMedication.authoredOn during day of InpatientEncounter.period
          )
    )
  )

define "Benzodiazepine at Discharge":
  ( ["MedicationRequest": medication in "Schedule IV Benzodiazepines"] BenzoMedications
    where ( BenzoMedications.isCommunity ( )
        or BenzoMedications.isDischarge ( )
    ) ) BenzodiazepineDischargeMedication
    where BenzodiazepineDischargeMedication.status in { 'active', 'completed' }
      and BenzodiazepineDischargeMedication.intent = 'order'

define "Opioid at Discharge":
  ( ["MedicationRequest": "Schedule II, III and IV Opioid Medications"] OpioidMedications
    where ( OpioidMedications.isCommunity ( )
        or OpioidMedications.isDischarge ( )
    ) ) OpioidDischargeMedication
    where OpioidDischargeMedication.status in { 'active', 'completed' }
      and OpioidDischargeMedication.intent = 'order'