library DiabetesHemoglobinA1cHbA1cPoorControl9FHIR version '0.1.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include QICoreCommon version '2.0.000' called QICoreCommon
include CQMCommon version '2.0.000' called CQMCommon
include SupplementalDataElements version '3.4.000' called SDE
include Status version '1.6.000' called Status
include CumulativeMedicationDuration version '4.0.000' called CMD
include AdultOutpatientEncounters version '4.8.000' called AdultOutpatientEncounters
include AdvancedIllnessandFrailty version '1.8.000' called AIFrailLTCF
include Hospice version '6.9.000' called Hospice
include PalliativeCare version '1.9.000' called PalliativeCare

valueset "Diabetes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001'
valueset "HbA1c Laboratory Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013'

parameter "Measurement Period" Interval<DateTime>default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0 )

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
  AgeInYearsAt(date from start of "Measurement Period") in Interval[18, 75]
    and exists AdultOutpatientEncounters."Qualifying Encounters"
    and exists ( [Condition: "Diabetes"] Diabetes
        where QICoreCommon."ToPrevalenceInterval" ( Diabetes ) overlaps "Measurement Period"
    )

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or AIFrailLTCF."Is Age 66 or Older with Advanced Illness and Frailty"
    or AIFrailLTCF."Is Age 66 or Older Living Long Term in a Nursing Home"
    or PalliativeCare."Has Palliative Care in the Measurement Period"

define "Numerator":
  "Has Most Recent HbA1c Without Result"
    or "Has Most Recent Elevated HbA1c"
    or "Has No Record Of HbA1c"

define "Has Most Recent HbA1c Without Result":
  "Most Recent HbA1c" is not null
    and "Most Recent HbA1c".value is null

define "Most Recent HbA1c":
  Last((([Observation: "HbA1c Laboratory Test"]).isLaboratoryTestPerformed()) RecentHbA1c
      where QICoreCommon."Latest"(RecentHbA1c.effective) during day of "Measurement Period"
      sort by start of QICoreCommon."ToInterval"(effective)
  )

define "Has Most Recent Elevated HbA1c":
  ( "Most Recent HbA1c".value as Quantity ) > 9 '%'

define "Has No Record Of HbA1c":
  not exists ( ( [Observation: "HbA1c Laboratory Test"] ).isLaboratoryTestPerformed ( ) ) NoHbA1c
    where QICoreCommon."Latest" ( NoHbA1c.effective ) during day of "Measurement Period"
