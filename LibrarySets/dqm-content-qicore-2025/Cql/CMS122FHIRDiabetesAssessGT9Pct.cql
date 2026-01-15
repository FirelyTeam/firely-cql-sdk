library CMS122FHIRDiabetesAssessGT9Pct version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '4.0.000' called QICoreCommon
include SupplementalDataElements version '5.1.000' called SDE
include Status version '1.15.000' called Status
include AdvancedIllnessandFrailty version '1.27.000' called AIFrailLTCF
include Hospice version '6.18.000' called Hospice
include PalliativeCare version '1.18.000' called PalliativeCare

codesystem "LOINC": 'http://loinc.org'
codesystem "HCPCS": 'http://www.cms.gov/Medicare/Coding/HCPCSReleaseCodeSets'
codesystem "CPT": 'http://www.ama-assn.org/go/cpt'

valueset "Annual Wellness Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240'
valueset "Diabetes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001'
valueset "HbA1c Laboratory Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Nutrition Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1006'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'

code "Glucose management indicator": '97506-0' from "LOINC" display 'Glucose management indicator'
code "Medical nutrition therapy, reassessment and subsequent intervention(s) following second referral in same year for change in diagnosis, medical condition, or treatment regimen (including additional hours needed for renal disease), group (2 or more individuals), each 30 minutes": 'G0271' from "HCPCS" display 'Medical nutrition therapy, reassessment and subsequent intervention(s) following second referral in same year for change in diagnosis, medical condition, or treatment regimen (including additional hours needed for renal disease), group (2 or more individuals), each 30 minutes'
code "Medical nutrition therapy; group (2 or more individual(s)), each 30 minutes": '97804' from "CPT" display 'Medical nutrition therapy; group (2 or more individual(s)), each 30 minutes'
code "Medical nutrition therapy; initial assessment and intervention, individual, face-to-face with the patient, each 15 minutes": '97802' from "CPT" display 'Medical nutrition therapy; initial assessment and intervention, individual, face-to-face with the patient, each 15 minutes'
code "Medical nutrition therapy; re-assessment and intervention, individual, face-to-face with the patient, each 15 minutes": '97803' from "CPT" display 'Medical nutrition therapy; re-assessment and intervention, individual, face-to-face with the patient, each 15 minutes'
code "Medical nutrition therapy; reassessment and subsequent intervention(s) following second referral in same year for change in diagnosis, medical condition or treatment regimen (including additional hours needed for renal disease), individual, face to face with the patient, each 15 minutes": 'G0270' from "HCPCS" display 'Medical nutrition therapy; reassessment and subsequent intervention(s) following second referral in same year for change in diagnosis, medical condition or treatment regimen (including additional hours needed for renal disease), individual, face to face with the patient, each 15 minutes'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

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
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) in Interval[18, 75]
    and exists "Qualifying Encounters"
    and exists ( ( ( [ConditionEncounterDiagnosis: "Diabetes"] ).verified ( ) ) DiabetesDiagnosis
        where DiabetesDiagnosis.prevalenceInterval ( ) overlaps day of "Measurement Period"
    )

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or AIFrailLTCF."Is Age 66 or Older Living Long Term in a Nursing Home"
    or AIFrailLTCF."Is Age 66 or Older with Advanced Illness and Frailty"
    or PalliativeCare."Has Palliative Care in the Measurement Period"

define "Numerator":
  "Has Most Recent Glycemic Status Assessment Without Result"
    or "Has Most Recent Elevated Glycemic Status Assessment"
    or "Has No Record Of Glycemic Status Assessment"

define "Qualifying Encounters":
  ( ( [Encounter: "Office Visit"]
      union [Encounter: "Annual Wellness Visit"]
      union [Encounter: "Preventive Care Services Established Office Visit, 18 and Up"]
      union [Encounter: "Preventive Care Services Initial Office Visit, 18 and Up"]
      union [Encounter: "Home Healthcare Services"]
      union [Encounter: "Nutrition Services"]
      union ( [Encounter] E
          where exists ( ( E.type ) T
              where T ~ "Medical nutrition therapy; initial assessment and intervention, individual, face-to-face with the patient, each 15 minutes"
          )
      )
      union ( [Encounter] E
          where exists ( ( E.type ) T
              where T ~ "Medical nutrition therapy; re-assessment and intervention, individual, face-to-face with the patient, each 15 minutes"
          )
      )
      union ( [Encounter] E
          where exists ( ( E.type ) T
              where T ~ "Medical nutrition therapy; group (2 or more individual(s)), each 30 minutes"
          )
      )
      union ( [Encounter] E
          where exists ( ( E.type ) T
              where T ~ "Medical nutrition therapy; reassessment and subsequent intervention(s) following second referral in same year for change in diagnosis, medical condition or treatment regimen (including additional hours needed for renal disease), individual, face to face with the patient, each 15 minutes"
          )
      )
      union ( [Encounter] E
          where exists ( ( E.type ) T
              where T ~ "Medical nutrition therapy, reassessment and subsequent intervention(s) following second referral in same year for change in diagnosis, medical condition, or treatment regimen (including additional hours needed for renal disease), group (2 or more individuals), each 30 minutes"
          )
      )
      union [Encounter: "Telephone Visits"]
  ).isEncounterPerformed ( ) ) ValidEncounters
    where ValidEncounters.period during day of "Measurement Period"

define "Glycemic Status Assessment":
  ( ( [LaboratoryResultObservation: "HbA1c Laboratory Test"]
      union [LaboratoryResultObservation: "Glucose management indicator"]
  ).isLaboratoryTestPerformed ( ) ) GlycemicStatus
    where GlycemicStatus.effective.latest ( ) during day of "Measurement Period"

define "Lowest Glycemic Status Assessment Reading on Most Recent Day":
  First("Glycemic Status Assessment" QualifyingGlycemicStatus
      where QualifyingGlycemicStatus.effective.latest() same day as "Most Recent Glycemic Status Date"
      return {
        QualifyingGlycemicStatusValue: QualifyingGlycemicStatus.value as Quantity,
        QualifyingGlycemicStatus: QualifyingGlycemicStatus
      }
      sort by QualifyingGlycemicStatusValue
  ).QualifyingGlycemicStatus

define "Most Recent Glycemic Status Date":
  Last(("Glycemic Status Assessment" QualifyingGlycemicStatus
      return date from QualifyingGlycemicStatus.effective.latest()) QualifyingGlycemicStatus
      sort asc
  )

define "Has Most Recent Glycemic Status Assessment Without Result":
  "Lowest Glycemic Status Assessment Reading on Most Recent Day" is not null
    and "Lowest Glycemic Status Assessment Reading on Most Recent Day".value is null

define "Has Most Recent Elevated Glycemic Status Assessment":
  "Lowest Glycemic Status Assessment Reading on Most Recent Day".value > 9 '%'

define "Has No Record Of Glycemic Status Assessment":
  not exists "Glycemic Status Assessment"