library SafeUseofOpioidsConcurrentPrescribingFHIR version '0.0.012'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.001' called FHIRHelpers
include SupplementalDataElementsFHIR4 version '2.0.000' called SDE
include MATGlobalCommonFunctionsFHIR4 version '6.1.000' called Global

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

context Patient

define "Denominator":
  "Initial Population"

define "Inpatient Encounter with Age Greater than or Equal to 18":
  Global."Inpatient Encounter" EncounterInpatient
                           where  (AgeInYearsAt(date from start of EncounterInpatient.period)) >=18
                             and EncounterInpatient.status = 'finished'

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Initial Population":
  ("Inpatient Encounter with Age Greater than or Equal to 18" InpatientEncounter
                          with ( ["MedicationRequest":  "Schedule II & III Opioid Medications"]
                            union ["MedicationRequest":  "Schedule IV Benzodiazepines"] Medications
             where exists Medications.category C where FHIRHelpers."ToConcept"(C) ~ Global."Discharge" )OpioidOrBenzodiazepineDischargeMedication
                            such that OpioidOrBenzodiazepineDischargeMedication.authoredOn during InpatientEncounter.period
                 and OpioidOrBenzodiazepineDischargeMedication.status = 'active'  and OpioidOrBenzodiazepineDischargeMedication.intent = 'plan')

define "Numerator":
  /*Encounters of patients prescribed two or more opioids or an opioid and benzodiazepine at discharge.
                      */
                    (  ( "Inpatient Encounter with Age Greater than or Equal to 18" InpatientEncounter
                           where (Count(["MedicationRequest": medication in "Schedule II & III Opioid Medications"] Opioids
                                  where Opioids.authoredOn during InpatientEncounter.period
                                  return distinct Opioids.medication
                            )>= 2
                         ))
                            union ( "Inpatient Encounter with Age Greater than or Equal to 18" InpatientEncounter
                            with ["MedicationRequest": medication in "Schedule II & III Opioid Medications"] OpioidsDischarge
                              such that OpioidsDischarge.authoredOn during InpatientEncounter.period
                            with ["MedicationRequest": medication in "Schedule IV Benzodiazepines"] BenzodiazepinesDischarge
                              such that BenzodiazepinesDischarge.authoredOn during InpatientEncounter.period
                        ))

define "Denominator Exclusion":
  /*Excludes encounters of patients with cancer or who are receiving palliative or hospice care at the time of the encounter*/
                       ("Inpatient Encounter with Age Greater than or Equal to 18" InpatientEncounter
                          where exists ( ["Condition": "All Primary and Secondary Cancer"] Cancer
                              where Global."Prevalence Period" (Cancer) overlaps InpatientEncounter.period
                          )

                            or exists ( ["ServiceRequest": "Palliative or Hospice Care"] PalliativeOrHospiceCareOrder
                                where PalliativeOrHospiceCareOrder.authoredOn during InpatientEncounter.period
                                and PalliativeOrHospiceCareOrder.intent = 'order'
                            )
                            or exists ( ["Procedure": "Palliative or Hospice Care"] PalliativeOrHospiceCarePerformed
                                where Global."Normalize Interval" ( PalliativeOrHospiceCarePerformed.performed) overlaps InpatientEncounter.period
                            )
                            or exists ( "Inpatient Encounter with Age Greater than or Equal to 18" InpatientEncounter
                                where InpatientEncounter.hospitalization.dischargeDisposition in "Discharge To Acute Care Facility"
                                  or InpatientEncounter.hospitalization.dischargeDisposition in "Hospice Care Referral or Admission"
                                  or InpatientEncounter.hospitalization.dischargeDisposition in "Patient Expired"
                            ) return InpatientEncounter )
