library DiabetesGlycemicStatusAssessmentGreaterThan9PercentFHIR version '0.1.002'

using QICore version '4.1.1'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '2.1.000' called QICoreCommon
include SupplementalDataElements version '3.5.000' called SDE
include Status version '1.8.000' called Status
include CumulativeMedicationDuration version '4.1.000' called CMD
include AdultOutpatientEncounters version '4.11.000' called AdultOutpatientEncounters
include AdvancedIllnessandFrailty version '1.16.000' called AIFrailLTCF
include Hospice version '6.12.000' called Hospice
include PalliativeCare version '1.11.000' called PalliativeCare

codesystem "LOINC": 'http://loinc.org'

valueset "Diabetes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001'
valueset "HbA1c Laboratory Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013'

code "Glucose management indicator": '97506-0' from "LOINC" display 'Glucose management indicator'

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
  ) in Interval[18, 75]
    and exists AdultOutpatientEncounters."Qualifying Encounters"
    and exists ( [Condition: "Diabetes"] Diabetes
        where Diabetes.prevalenceInterval ( ) overlaps day of "Measurement Period"
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

define "Glycemic Status Assessment":
  ( ( [Observation: "HbA1c Laboratory Test"]
      union [Observation: "Glucose management indicator"]
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