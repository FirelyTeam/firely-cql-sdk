library CervicalCancerScreeningFHIR version '0.0.001'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include QICoreCommon version '2.0.000' called QICoreCommon
include Hospice version '6.9.000' called Hospice
include PalliativeCare version '1.9.000' called PalliativeCare
include Status version '1.6.000' called Status

valueset "Congenital or Acquired Absence of Cervix": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1016'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "HPV Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1059'
valueset "Hysterectomy with No Residual Cervix": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1014'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Online Assessments": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'
valueset "Pap Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)
context Patient

define "Initial Population":
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) in Interval[24, 64]
    and Patient.gender = 'female'
    and exists "Qualifying Encounters"

define "Qualifying Encounters":
  ( ( ["Encounter": "Office Visit"]
      union ["Encounter": "Preventive Care Services Established Office Visit, 18 and Up"]
      union ["Encounter": "Preventive Care Services Initial Office Visit, 18 and Up"]
      union ["Encounter": "Home Healthcare Services"]
      union ["Encounter": "Telephone Visits"]
      union ["Encounter": "Online Assessments"]
  ).isEncounterPerformed ( ) ) ValidEncounters
    where ValidEncounters.period.toInterval ( ) during day of "Measurement Period"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or exists "Absence of Cervix"
    or PalliativeCare."Has Palliative Care in the Measurement Period"

define "Numerator":
  exists "Cervical Cytology Within 3 Years"
    or exists "HPV Test Within 5 Years for Women Age 30 and Older"

define "Absence of Cervix":
  ( ( ( ["Procedure": "Hysterectomy with No Residual Cervix"] ).isProcedurePerformed ( ) ) NoCervixProcedure
      where NoCervixProcedure.performed.toInterval ( ) ends on or before end of "Measurement Period"
  )
    union ( ["Condition": "Congenital or Acquired Absence of Cervix"] NoCervixDiagnosis
        where NoCervixDiagnosis.prevalenceInterval ( ) starts on or before end of "Measurement Period"
    )

define "Cervical Cytology Within 3 Years":
  ( ( ["Observation": "Pap Test"] ).isLaboratoryTestPerformed ( ) ) CervicalCytology
    where CervicalCytology.effective.latest ( ) during day of Interval[start of "Measurement Period" - 2 years, end of "Measurement Period"]
      and CervicalCytology.value is not null

define "HPV Test Within 5 Years for Women Age 30 and Older":
  ( ( ["Observation": "HPV Test"] ).isLaboratoryTestPerformed ( ) ) HPVTest
    where AgeInYearsAt(date from HPVTest.effective.latest()) >= 30
      and HPVTest.effective.latest ( ) during day of Interval[start of "Measurement Period" - 4 years, end of "Measurement Period"]
      and HPVTest.value is not null

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"