library CMS1188FHIRHIVSTITesting version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon

valueset "Annual Wellness Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240'
valueset "Chlamydia Screening": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052'
valueset "Face-to-Face Interaction": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.375'
valueset "Gonorrhea Screening": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1258.1'
valueset "HIV": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Preventive Care Services, Initial Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022'
valueset "Preventive Care, Established Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024'
valueset "Preventive Care Services Other": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150'
valueset "Syphilis Tests": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.389'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Denominator":
  "Initial Population"

define "Initial Population":
  AgeInYearsAt(date from start of "Measurement Period") >= 13
    and "Has Qualifying Encounter During Measurement Period"
    and "Has HIV Diagnosis Before End of Measurement Period"

define "Numerator":
  "Has Chlamydia Testing"
    and "Has Gonorrhea Testing"
    and "Has Syphilis Testing"

define "Has Qualifying Encounter During Measurement Period":
  exists ( ( ["Encounter": "Office Visit"]
      union ["Encounter": "Outpatient Consultation"]
      union ["Encounter": "Annual Wellness Visit"]
      union ["Encounter": "Face-to-Face Interaction"]
      union ["Encounter": "Home Healthcare Services"]
      union ["Encounter": "Preventive Care Services Established Office Visit, 18 and Up"]
      union ["Encounter": "Preventive Care Services Initial Office Visit, 18 and Up"]
      union ["Encounter": "Preventive Care Services, Initial Office Visit, 0 to 17"]
      union ["Encounter": "Preventive Care, Established Office Visit, 0 to 17"]
      union ["Encounter": "Telephone Visits"]
      union ["Encounter": "Preventive Care Services Other"] ) QualifyingEncounter
      where QualifyingEncounter.period during day of "Measurement Period"
        and QualifyingEncounter.status = 'finished'
  )

define "Has HIV Diagnosis Before End of Measurement Period":
  exists ( ["ConditionProblemsHealthConcerns": "HIV"]
    union ["ConditionEncounterDiagnosis": "HIV"] ) HIVDx
    where HIVDx.prevalenceInterval ( ) starts on or before day of end of "Measurement Period"
      and HIVDx.isVerified ( )

define "Has Chlamydia Testing":
  exists ["LaboratoryResultObservation": "Chlamydia Screening"] ChlamydiaTest
    where ChlamydiaTest.value is not null
      and ChlamydiaTest.status in { 'final', 'amended', 'corrected' }
      and ChlamydiaTest.effective.latest ( ) during day of "Measurement Period"

define "Has Gonorrhea Testing":
  exists ["LaboratoryResultObservation": "Gonorrhea Screening"] GonorrheaTest
    where GonorrheaTest.value is not null
      and GonorrheaTest.status in { 'final', 'amended', 'corrected' }
      and GonorrheaTest.effective.latest ( ) during day of "Measurement Period"

define "Has Syphilis Testing":
  exists ["LaboratoryResultObservation": "Syphilis Tests"] SyphilisTest
    where SyphilisTest.value is not null
      and SyphilisTest.status in { 'final', 'amended', 'corrected' }
      and SyphilisTest.effective.latest ( ) during day of "Measurement Period"

define fluent function isVerified(condition Choice<QICore.ConditionProblemsHealthConcerns, QICore.ConditionEncounterDiagnosis>):
  condition.verificationStatus is not null implies ( condition.verificationStatus ~ QICoreCommon."confirmed"
      or condition.verificationStatus ~ QICoreCommon."unconfirmed"
      or condition.verificationStatus ~ QICoreCommon."provisional"
      or condition.verificationStatus ~ QICoreCommon."differential"
  )

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"