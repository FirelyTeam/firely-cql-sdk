library CMS1206ALARACTOQRFHIR version '0.4.003'

using QICore version '4.1.1'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include CQMCommon version '2.2.000' called CQMCommon
include QICoreCommon version '2.1.000' called QICoreCommon
include SupplementalDataElements version '3.5.000' called SDE
include AlaraCommonFunctions version '1.5.000' called AlaraCommon

codesystem "LOINC": 'http://loinc.org'

valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'

code "CT dose and image quality category": '96914-7' from "LOINC" display 'CT dose and image quality category'
code "Full Body": 'LA31771-1' from "LOINC" display 'Full Body'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Denominator":
  "Qualified Scan with Values"

define "Denominator Exclusion":
  "Qualified Scan with Values" CTScan
    where ( CTScan.value as Concept ).codes contains "Full Body"

define "Initial Population":
  "Qualified Scan without Inpatient Encounter"

define "Numerator":
  "Qualified Scan with Values" CTScan
    where AlaraCommon."CT Scan Qualifies" ( CTScan )

define "Qualified Scan with Values":
  "Qualified Scan without Inpatient Encounter" CTScan
    where AlaraCommon."Global Noise Value" ( CTScan ) is not null
      and AlaraCommon."Size Adjusted Value" ( CTScan ) is not null
      and CTScan.value is not null

define "Qualified Scan without Inpatient Encounter":
  "Qualified Scan" QualifiedCTScan
    without [Encounter: "Encounter Inpatient"] InpatientEncounter
      such that QICoreCommon.ToInterval ( QualifiedCTScan.effective ) starts during QICoreCommon.ToInterval ( InpatientEncounter.period )

define "Qualified Scan":
  [Observation: "CT dose and image quality category"] CTScan
    where QICoreCommon.ToInterval ( CTScan.effective ) ends during day of "Measurement Period"
      and AgeInYearsAt(date from start of "Measurement Period") >= 18

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"