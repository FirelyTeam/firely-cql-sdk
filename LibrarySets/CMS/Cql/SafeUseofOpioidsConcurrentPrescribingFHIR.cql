library SafeUseofOpioidsConcurrentPrescribingFHIR version '0.2.000'

using QICore version '4.1.1'

include CQMCommon version '2.0.000' called CQMCommon
include FHIRHelpers version '4.3.000' called FHIRHelpers
include Hospice version '6.9.000' called Hospice
include QICoreCommon version '2.0.000' called QICoreCommon
include SupplementalDataElements version '3.4.000' called SDE

codesystem "LOINC": 'http://loinc.org'

valueset "All Primary and Secondary Cancer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.161'
valueset "Discharge To Acute Care Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Hospice Care Referral or Admission": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365'
valueset "Palliative or Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579'
valueset "Patient Expired": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309'
valueset "Schedule II & III Opioid Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165'
valueset "Schedule IV Benzodiazepines": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1'

code "Birth date": '21112-8' from "LOINC" display 'Birth date'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)
context Patient

define "Initial Population":
  "Inpatient Encounters with an Opioid or Benzodiazepine at Discharge"

define "Denominator":
  "Initial Population"

define "Denominator Exclusion":
  /*Excludes encounters of patients with cancer or who are receiving palliative or hospice care at the time of the encounter or who are discharged to another inpatient care facility or expire during the inpatient stay*/
  
  "Inpatient Encounters with an Opioid or Benzodiazepine at Discharge" InpatientEncounter
    where exists ( [Condition: "All Primary and Secondary Cancer"] Cancer
        where ( Cancer.isProblemListItem ( )
            or Cancer.isHealthConcern ( )
        )
          and Cancer.isActive ( )
          and Cancer.prevalenceInterval ( ) overlaps InpatientEncounter.period
    )
      or exists ( ( InpatientEncounter.encounterDiagnosis ( ) ) InpatientEncounterDiagnosis
          where InpatientEncounterDiagnosis.code in "All Primary and Secondary Cancer"
      )
      or exists ( "Intervention Palliative or Hospice Care" PalliativeOrHospiceCare
          where Coalesce(start of PalliativeOrHospiceCare.performed.toInterval(), PalliativeOrHospiceCare.authoredOn) during day of CQMCommon."HospitalizationWithObservation" ( InpatientEncounter )
      )
      or ( InpatientEncounter.hospitalization.dischargeDisposition in "Discharge To Acute Care Facility"
          or InpatientEncounter.hospitalization.dischargeDisposition in "Hospice Care Referral or Admission"
          or InpatientEncounter.hospitalization.dischargeDisposition in "Patient Expired"
      )

define "Numerator":
  /*Encounters of patients prescribed two or more opioids or an opioid and benzodiazepine at discharge.*/
  
  ( "Inpatient Encounters with an Opioid or Benzodiazepine at Discharge" InpatientEncounter
      where ( Count("Opioid at Discharge" Opioids
            return distinct Opioids.medication
        ) >= 2
      )
  )
    union ( "Inpatient Encounters with an Opioid or Benzodiazepine at Discharge" InpatientEncounter
        with "Opioid at Discharge" OpioidsDischarge
          such that OpioidsDischarge.authoredOn during day of InpatientEncounter.period
        with "Benzodiazepine at Discharge" BenzodiazepinesDischarge
          such that BenzodiazepinesDischarge.authoredOn during day of InpatientEncounter.period
    )

define "Benzodiazepine at Discharge":
  ( [MedicationRequest: medication in "Schedule IV Benzodiazepines"] BenzoMedications
    where ( BenzoMedications.isCommunity ( )
        or BenzoMedications.isDischarge ( )
    ) ) BenzodiazepineDischargeMedication
    where BenzodiazepineDischargeMedication.status in { 'active', 'completed' }
      and BenzodiazepineDischargeMedication.intent = 'order'

define "Inpatient Encounter with Age Greater than or Equal to 18":
  CQMCommon."Inpatient Encounter" InpatientHospitalEncounter
    where AgeInYearsAt(date from start of InpatientHospitalEncounter.period) >= 18

define "Inpatient Encounters with an Opioid or Benzodiazepine at Discharge":
  "Inpatient Encounter with Age Greater than or Equal to 18" InpatientEncounter
    with ( "Opioid at Discharge"
      union "Benzodiazepine at Discharge" ) OpioidOrBenzodiazepineAtDischarge
      such that OpioidOrBenzodiazepineAtDischarge.authoredOn during day of InpatientEncounter.period

define "Intervention Palliative or Hospice Care":
  [ServiceRequest: "Palliative or Hospice Care"]
    union [Procedure: "Palliative or Hospice Care"]

define "Opioid at Discharge":
  ( [MedicationRequest: "Schedule II & III Opioid Medications"] OpioidMedications
    where ( OpioidMedications.isCommunity ( )
        or OpioidMedications.isDischarge ( )
    ) ) OpioidDischargeMedication
    where OpioidDischargeMedication.status in { 'active', 'completed' }
      and OpioidDischargeMedication.intent = 'order'

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"