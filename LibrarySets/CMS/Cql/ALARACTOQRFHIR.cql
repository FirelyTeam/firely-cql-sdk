library ALARACTOQRFHIR version '0.1.001'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include CQMCommon version '2.0.000' called CQMCommon
include QICoreCommon version '2.0.000' called QICoreCommon
include SupplementalDataElements version '3.4.000' called SDE

codesystem "LOINC": 'http://loinc.org'

valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'

code "Calculated CT global noise": '96912-1' from "LOINC" display 'Calculated CT global noise'
code "Calculated CT size-adjusted dose": '96913-9' from "LOINC" display 'Calculated CT size-adjusted dose'
code "CT dose and image quality category": '96914-7' from "LOINC" display 'CT dose and image quality category'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "Denominator":
  "Initial Population" IP
    where "Global Noise Value"(IP) is not null
      and "Size Adjusted Value"(IP) is not null
      and IP.value is not null

define "Denominator Exclusion":
  "Denominator" Denominator
    where ( Denominator.value as Concept ).codes.code contains 'FULLBODY'

define "Initial Population":
  "Qualified Scan" CTScan
    without [Encounter: "Encounter Inpatient"] InpatientEncounter
      such that QICoreCommon.ToInterval ( CTScan.effective ) occurs during "Measurement Period"

define "Numerator":
  "Denominator" Denominator
    where "CT Scan Qualifies"(Denominator)

define "Qualified Scan":
  [Observation: "CT dose and image quality category"] CTScan
    where QICoreCommon.ToInterval ( CTScan.effective ) occurs during "Measurement Period"
      and AgeInYearsAt(date from start of "Measurement Period") >= 18

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define function "Global Noise Value"(Obs Observation):
  singleton from ( Obs.component C
      where C.code ~ "Calculated CT global noise"
        and ( C.value as Quantity ).unit = '[hnsf\'U]'
      return ( C.value as Quantity ).value
  )

define function "Size Adjusted Value"(Obs Observation):
  singleton from ( Obs.component C
      where C.code ~ "Calculated CT size-adjusted dose"
        and ( C.value as Quantity ).unit = 'mGy.cm'
      return ( C.value as Quantity ).value
  )

define function "Qualifies"(Obs Observation, code String, noiseThreshold Decimal, sizeDoseThreshold Decimal):
  ( Obs.value as Concept ).codes.code contains code
    and ( "Global Noise Value"(Obs) >= noiseThreshold
        or "Size Adjusted Value"(Obs) >= sizeDoseThreshold
    )

define function "CT Scan Qualifies"(IP Observation):
  "Qualifies"(IP, 'ABDOPEL LD', 64, 598)
    or "Qualifies"(IP, 'ABDOPEL RT', 29, 644)
    or "Qualifies"(IP, 'ABDOPEL HD', 29, 1260)
    or "Qualifies"(IP, 'CARDIAC LD', 55, 93)
    or "Qualifies"(IP, 'CARDIAC RT', 32, 576)
    or "Qualifies"(IP, 'CHEST LD', 55, 377)
    or "Qualifies"(IP, 'CHEST RT', 49, 377)
    or "Qualifies"(IP, 'CHEST-CARDIAC HD', 49, 1282)
    or "Qualifies"(IP, 'HEAD LD', 115, 582)
    or "Qualifies"(IP, 'HEAD RT', 115, 1025)
    or "Qualifies"(IP, 'HEAD HD', 115, 1832)
    or "Qualifies"(IP, 'EXTREMITIES', 73, 320)
    or "Qualifies"(IP, 'NECK-CSPINE', 25, 1260)
    or "Qualifies"(IP, 'TSPINE-LSPINE', 25, 1260)
    or "Qualifies"(IP, 'CAP', 29, 1637)
    or "Qualifies"(IP, 'TLSPINE', 25, 2520)
    or "Qualifies"(IP, 'HEADNECK RT', 25, 2285)
    or "Qualifies"(IP, 'HEADNECK HD', 25, 3092)