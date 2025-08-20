library CMS1074FHIRCTIQR version '0.9.000'

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

context Patient

define "Qualifying Inpatient Encounters":
  ["Encounter": "Encounter Inpatient"] InpatientEncounter
    where InpatientEncounter.status ~ 'finished'
      and InpatientEncounter.period ends during day of "Measurement Period"
      and AgeInYearsAt(date from start of "Measurement Period") >= 18

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Numerator":
  "Qualifying Scan with Values" CTScanWithValues
    where CTScanWithValues."ctScanQualifies" ( )

define "Initial Population":
  "Qualifying Scan During Inpatient Encounter"

define "Denominator":
  "Qualifying Scan with Values"

define "Denominator Exclusion":
  "Qualifying Scan with Values" CTScanWithValues
    where ( CTScanWithValues.value as Concept ).codes contains "Full Body"

define "Qualifying Scan with Values":
  "Qualifying Scan During Inpatient Encounter" CTScan
    where CTScan."globalNoiseValue" ( ) is not null
      and CTScan."sizeAdjustedValue" ( ) is not null
      and CTScan.value is not null

define "Qualifying Scan During Inpatient Encounter":
  [ObservationClinicalResult: "CT dose and image quality category"] CTScan
    with "Qualifying Inpatient Encounters" InpatientEncounters
      such that CTScan.effective.toInterval ( ) starts during InpatientEncounters.period
        and CTScan.effective.toInterval ( ) ends during day of "Measurement Period"