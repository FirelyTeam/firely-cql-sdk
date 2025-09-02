library CMS349FHIRHIVScreening version '0.3.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include CQMCommon version '4.1.000' called CQMCommon
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "LOINC": 'http://loinc.org'
codesystem "ActCode": 'http://terminology.hl7.org/CodeSystem/v3-ActCode'
codesystem "ConditionClinicalStatusCodes": 'http://terminology.hl7.org/CodeSystem/condition-clinical'
codesystem "ConditionVerificationStatus": 'http://terminology.hl7.org/CodeSystem/condition-ver-status'
codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "HIV": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003'
valueset "Human Immunodeficiency Virus (HIV) Laboratory Test Codes (Ab and Ag)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1056.50'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Preventive Care Services - Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services, Initial Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022'
valueset "Preventive Care Services-Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Preventive Care, Established Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024'

code "Birth date": '21112-8' from "LOINC" display 'Birth date'
code "HIV 1 and 2 tests - Meaningful Use set": '75622-1' from "LOINC" display 'HIV 1 and 2 tests - Meaningful Use set'
code "AMB": 'AMB' from "ActCode" display 'Ambulatory'
code "active": 'active' from "ConditionClinicalStatusCodes"
code "refuted": 'refuted' from "ConditionVerificationStatus"
code "Dead (finding)": '419099009' from "SNOMEDCT" display 'Dead (finding)'

parameter "Measurement Period" Interval<DateTime>

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
        and HIVDiagnosis.verificationStatus !~ "refuted"
  )

define "Denominator Exceptions":
  "Patient Expired"

define "Qualifying Encounters":
  ( ["Encounter": type in "Preventive Care Services, Initial Office Visit, 0 to 17"]
    union ["Encounter": type in "Preventive Care Services-Initial Office Visit, 18 and Up"]
    union ["Encounter": type in "Preventive Care, Established Office Visit, 0 to 17"]
    union ["Encounter": type in "Preventive Care Services - Established Office Visit, 18 and Up"]
    union ["Encounter": type in "Office Visit"] ) Encounter
    where Encounter.period during day of "Measurement Period"
      and Encounter.status = 'finished'

define "Patient Expired":
  Patient.deceased on or before end of "Measurement Period"

define "Has HIV Test Performed":
  exists ( ["LaboratoryResultObservation": "Human Immunodeficiency Virus (HIV) Laboratory Test Codes (Ab and Ag)"]
    union ["LaboratoryResultObservation": "HIV 1 and 2 tests - Meaningful Use set"] ) HIVTest
    where HIVTest.value is not null
      and AgeInYearsAt(date from start of HIVTest.effective.toInterval()) in Interval[15, 65]
      and HIVTest.effective.toInterval ( ) starts before end of "Measurement Period"
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