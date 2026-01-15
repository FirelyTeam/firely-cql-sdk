library CMS349FHIRHIVScreening version '1.1.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "LOINC": 'http://loinc.org'

valueset "HIV": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003'
valueset "Human Immunodeficiency Virus (HIV) Laboratory Test Codes (Ab and Ag)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1056.50'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Preventive Care Services - Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services, Initial Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022'
valueset "Preventive Care Services-Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Preventive Care, Established Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024'

code "HIV 1 and 2 tests - Meaningful Use set": '75622-1' from "LOINC" display 'HIV 1 and 2 tests - Meaningful Use set'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
  AgeInYearsAt(date from start of "Measurement Period") in Interval[15, 65]
    and exists "Qualifying Encounters"

define "Denominator":
  "Initial Population"

define "Numerator":
  ( "Has HIV Test Performed" )

define "Denominator Exclusions":
  exists ( ( [ConditionProblemsHealthConcerns: "HIV"]
      union [ConditionEncounterDiagnosis: "HIV"] ) HIVDiagnosis
      where HIVDiagnosis.prevalenceInterval ( ) starts before day of start of "Measurement Period"
        and HIVDiagnosis.isVerified ( )
  )

define "Denominator Exceptions":
  "Patient Expired"

define "Qualifying Encounters":
  ( ["Encounter": "Preventive Care Services, Initial Office Visit, 0 to 17"]
    union ["Encounter": "Preventive Care Services-Initial Office Visit, 18 and Up"]
    union ["Encounter": "Preventive Care, Established Office Visit, 0 to 17"]
    union ["Encounter": "Preventive Care Services - Established Office Visit, 18 and Up"]
    union ["Encounter": "Office Visit"] ) Encounter
    where Encounter.period during day of "Measurement Period"
      and Encounter.status = 'finished'

define "Patient Expired":
  Patient.deceased on or before day of end of "Measurement Period"

define "Has HIV Test Performed":
  exists ( ["LaboratoryResultObservation": "Human Immunodeficiency Virus (HIV) Laboratory Test Codes (Ab and Ag)"]
    union ["LaboratoryResultObservation": "HIV 1 and 2 tests - Meaningful Use set"] ) HIVTest
    where HIVTest.value is not null
      and AgeInYearsAt(date from start of HIVTest.effective.toInterval()) in Interval[15, 65]
      and HIVTest.effective.toInterval ( ) starts before day of end of "Measurement Period"
      and ( HIVTest.status = 'final'
          or HIVTest.status = 'amended'
          or HIVTest.status = 'corrected'
      )

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

/*
@description: Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential
*/


define fluent function isVerified(condition Choice<ConditionEncounterDiagnosis, ConditionProblemsHealthConcerns>):
  condition.verificationStatus is not null implies ( condition.verificationStatus ~ QICoreCommon."confirmed"
      or condition.verificationStatus ~ QICoreCommon."unconfirmed"
      or condition.verificationStatus ~ QICoreCommon."provisional"
      or condition.verificationStatus ~ QICoreCommon."differential"
  )