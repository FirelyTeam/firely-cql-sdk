library ColonCancerScreeningFHIR version '0.1.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '3.5.000' called SDE
include Hospice version '6.12.000' called Hospice
include PalliativeCare version '1.11.000' called PalliativeCare
include AdultOutpatientEncounters version '4.11.000' called AdultOutpatientEncounters
include AdvancedIllnessandFrailty version '1.16.000' called AIFrailLTCF
include Status version '1.8.000' called Status
include QICoreCommon version '2.1.000' called QICoreCommon

valueset "Colonoscopy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020'
valueset "CT Colonography": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038'
valueset "Fecal Occult Blood Test (FOBT)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011'
valueset "sDNA FIT Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039'
valueset "Flexible Sigmoidoscopy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010'
valueset "Malignant Neoplasm of Colon": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001'
valueset "Total Colectomy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.000Z, @2025-12-31T23:59:59.999Z]

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
  ) in Interval[46, 75]
    and exists AdultOutpatientEncounters."Qualifying Encounters"

define "Denominator":
  "Initial Population"

define "Denominator Exclusion":
  Hospice."Has Hospice Services"
    or exists "Malignant Neoplasm"
    or exists "Total Colectomy Performed"
    or AIFrailLTCF."Is Age 66 or Older with Advanced Illness and Frailty"
    or AIFrailLTCF."Is Age 66 or Older Living Long Term in a Nursing Home"
    or PalliativeCare."Has Palliative Care in the Measurement Period"

define "Numerator":
  exists "Fecal Occult Blood Test Performed"
    or exists "Stool DNA with FIT Test Performed"
    or exists "Flexible Sigmoidoscopy Performed"
    or exists "CT Colonography Performed"
    or exists "Colonoscopy Performed"

define "Fecal Occult Blood Test Performed":
  ( ( [Observation: "Fecal Occult Blood Test (FOBT)"] ).isLaboratoryTestPerformed ( ) ) FecalOccultResult
    where FecalOccultResult.value is not null
      and FecalOccultResult.effective.latest ( ) during day of "Measurement Period"

define "Malignant Neoplasm":
  ( [Condition: "Malignant Neoplasm of Colon"] ) ColorectalCancer
    where ColorectalCancer.prevalenceInterval ( ) starts on or before day of end of "Measurement Period"

define "Total Colectomy Performed":
  ( ( [Procedure: "Total Colectomy"] ).isProcedurePerformed ( ) ) Colectomy
    where Colectomy.performed.toInterval ( ) ends on or before day of end of "Measurement Period"

define "Stratification 1":
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) in Interval[46, 49]

define "Stratification 2":
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) in Interval[50, 75]

define "Colonoscopy Performed":
  ( ( [Procedure: "Colonoscopy"] ).isProcedurePerformed ( ) ) Colonoscopy
    where Colonoscopy.performed.toInterval ( ) ends during day of Interval[start of "Measurement Period" - 9 years, end of "Measurement Period"]

define "Flexible Sigmoidoscopy Performed":
  ( ( [Procedure: "Flexible Sigmoidoscopy"] ).isProcedurePerformed ( ) ) FlexibleSigmoidoscopy
    where FlexibleSigmoidoscopy.performed.toInterval ( ) ends during day of Interval[start of "Measurement Period" - 4 years, end of "Measurement Period"]

define "CT Colonography Performed":
  ( ( [Observation: "CT Colonography"] ).isDiagnosticStudyPerformed ( ) ) Colonography
    where Colonography.effective.toInterval ( ) ends during day of Interval[start of "Measurement Period" - 4 years, end of "Measurement Period"]

define "Stool DNA with FIT Test Performed":
  ( ( [Observation: "sDNA FIT Test"] ).isLaboratoryTestPerformed ( ) ) sDNATest
    where sDNATest.value is not null
      and sDNATest.effective.latest ( ) during day of Interval[start of "Measurement Period" - 2 years, end of "Measurement Period"]