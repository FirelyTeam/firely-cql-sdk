library CMS1206FHIRCTOQR version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include CQMCommon version '4.1.000' called CQMCommon
include QICoreCommon version '4.0.000' called QICoreCommon
include SupplementalDataElements version '5.1.000' called SDE
include AlaraCommonFunctions version '1.10.000' called AlaraCommon

codesystem "LOINC": 'http://loinc.org'

valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'

code "CT dose and image quality category": '96914-7' from "LOINC" display 'CT dose and image quality category'
code "Full Body": 'LA31771-1' from "LOINC" display 'Full Body'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Denominator":
  "Qualified Scan With Values"

define "Denominator Exclusion":
  "Qualified Scan With Values" CTScanWithValues
    where ( CTScanWithValues.value as Concept ).codes contains "Full Body"

define "Initial Population":
  "Qualified Scan Without Inpatient Encounter"

define "Numerator":
  "Qualified Scan With Values" CTScanWithValues
    where CTScanWithValues.ctScanQualifies ( )

define "Qualified Scan With Values":
  "Qualified Scan Without Inpatient Encounter" CTScan
    where CTScan.globalNoiseValue ( ) is not null
      and CTScan.sizeAdjustedValue ( ) is not null
      and CTScan.value is not null

define "Qualified Scan Without Inpatient Encounter":
  "Qualified Scan" QualifiedCTScan
    without [Encounter: "Encounter Inpatient"] InpatientEncounter
      such that InpatientEncounter.status ~ 'finished'
        and InpatientEncounter.period ends during day of "Measurement Period"
        and QualifiedCTScan.effective.toInterval ( ) starts during InpatientEncounter.period

define "Qualified Scan":
  [ObservationClinicalResult: "CT dose and image quality category"] CTScanResult
    where CTScanResult.status in { 'final', 'amended', 'corrected' }
      and CTScanResult.effective.toInterval ( ) ends during day of "Measurement Period"
      and AgeInYearsAt(date from start of "Measurement Period") >= 18

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"