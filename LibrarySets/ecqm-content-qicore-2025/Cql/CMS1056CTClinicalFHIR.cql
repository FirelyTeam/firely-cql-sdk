library CMS1056CTClinicalFHIR version '0.6.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include CQMCommon version '4.1.000' called CQMCommon
include QICoreCommon version '4.0.000' called QICoreCommon
include SupplementalDataElements version '5.1.000' called SDE
include AlaraCommonFunctions version '1.10.000' called AlaraCommon

codesystem "LOINC": 'http://loinc.org'

code "Birth date": '21112-8' from "LOINC" display 'Birth date'
code "CT dose and image quality category": '96914-7' from "LOINC" display 'CT dose and image quality category'
code "Full Body": 'LA31771-1' from "LOINC" display 'Full Body'

parameter "Measurement Period" Interval<DateTime>

context Patient

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Patients with Qualifying CTScan":
  [LaboratoryResultObservation: "CT dose and image quality category"] CTScanResult
    where QICoreCommon.ToInterval ( CTScanResult.effective ) ends during day of "Measurement Period"
      and ( AgeInYearsAt(start of "Measurement Period") >= 18 )

define "Patients with Qualifying CTScan with Values":
  "Patients with Qualifying CTScan" CTScan
    where AlaraCommon."Global Noise Value" ( CTScan ) is not null
      and AlaraCommon."Size Adjusted Value" ( CTScan ) is not null
      and CTScan.value is not null

define "Initial Population":
  exists ( "Patients with Qualifying CTScan" )

define "Denominator":
  exists ( "Patients with Qualifying CTScan with Values" )

define "Denominator Exclusion":
  exists ( "Patients with Qualifying CTScan with Values" CTScan
      where ( CTScan.value as Concept ).codes contains "Full Body"
  )

define "Numerator":
  exists ( "Patients with Qualifying CTScan with Values" CTScan
      where AlaraCommon."CT Scan Qualifies" ( CTScan )
  )