library DiabetesHemoglobinA1cHbA1cPoorControl9FHIR version '0.0.015'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.001' called FHIRHelpers
include SupplementalDataElementsFHIR4 version '2.0.000' called SDE
include MATGlobalCommonFunctionsFHIR4 version '6.1.000' called Global
include PalliativeCareFHIR version '0.6.000' called PalliativeCare
include AdultOutpatientEncountersFHIR4 version '2.2.000' called AdultOutpatientEncounters
include HospiceFHIR4 version '2.3.000' called Hospice
include AdvancedIllnessandFrailtyExclusionECQMFHIR4 version '5.17.000' called FrailtyLTI
include CumulativeMedicationDurationFHIR4 version '1.0.000' called CMD

codesystem "LOINC": 'http://loinc.org' 

valueset "Annual Wellness Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240' 
valueset "Diabetes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001' 
valueset "Discharged to Health Care Facility for Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207' 
valueset "Discharged to Home for Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209' 
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307' 
valueset "HbA1c Laboratory Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1013' 
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016' 
valueset "Hospice care ambulatory": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15' 
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001' 
valueset "Preventive Care Services - Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025' 
valueset "Preventive Care Services-Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023' 
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080' 

code "Birth date": '21112-8' from "LOINC" display 'Birth date'

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

define "Denominator":
  "Initial Population"

define "Numerator":
  "Has Most Recent HbA1c Without Result"
                                    or "Has Most Recent Elevated HbA1c"
                                    or "Has No Record Of HbA1c"

define "Has Most Recent Elevated HbA1c":
  ("Most Recent HbA1c".value as Quantity) > 9 '%'

define "Has Most Recent HbA1c Without Result":
  "Most Recent HbA1c" is not null
                                and "Most Recent HbA1c".value is null

define "Initial Population":
  AgeInYearsAt(date from start of "Measurement Period" ) in Interval[18, 75)
                              and exists (AdultOutpatientEncounters."Qualifying Encounters"
                                  union "Telehealth Services")
                              and exists ( [Condition: "Diabetes"] Diabetes
                                  where Global."Prevalence Period"(Diabetes) overlaps "Measurement Period"
                                        )

define "Telehealth Services":
  [Encounter: "Telephone Visits"] TelehealthEncounter
                                    where TelehealthEncounter.status = 'finished'
                                        and Global."Normalize Interval"(TelehealthEncounter.period) during "Measurement Period"

define "Has No Record Of HbA1c":
  not exists ( [Observation: "HbA1c Laboratory Test"] NoHbA1c
                                        where ( NoHbA1c.status in {'final', 'amended', 'corrected'}
                                          and Global."Latest"(NoHbA1c.effective) during "Measurement Period")
                                  )

define "Most Recent HbA1c":
  Last([Observation: "HbA1c Laboratory Test"] RecentHbA1c
                                        where RecentHbA1c.status in {'final', 'amended', 'corrected'} 
                                          and Global."Latest"(RecentHbA1c.effective) during "Measurement Period"
                                          sort by start of Global."Normalize Interval"(effective)
                              )

define "Denominator Exclusions":
  Hospice."Has Hospice"
                              or (FrailtyLTI."Advanced Illness and Frailty Exclusion Not Including Over Age 80")
                              or (AgeInYearsAt( date from start of "Measurement Period" ) >= 65 
                                  and FrailtyLTI."Has Long Term Care Periods Longer Than 90 Consecutive Days")
                              or (PalliativeCare."Palliative Care in the Measurement Period")

