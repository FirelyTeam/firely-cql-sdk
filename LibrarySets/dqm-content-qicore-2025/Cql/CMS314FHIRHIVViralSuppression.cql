library CMS314FHIRHIVViralSuppression version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Annual Wellness Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240'
valueset "Face-to-Face Interaction": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.375'
valueset "HIV": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003'
valueset "HIV Viral Load Tests": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.377'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Preventive Care Services Other": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150'
valueset "Preventive Care Services, Initial Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022'
valueset "Preventive Care, Established Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'

code "Below threshold level (qualifier value)": '260988000' from "SNOMEDCT" display 'Below threshold level (qualifier value)'
code "Not detected (qualifier value)": '260415000' from "SNOMEDCT" display 'Not detected (qualifier value)'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Denominator":
  "Initial Population"

define "Has Active HIV Diagnosis Before or in First 90 Days of Measurement Period":
  exists ( ["ConditionProblemsHealthConcerns": "HIV"]
    union ["ConditionEncounterDiagnosis": "HIV"] ) HIVDx
    where HIVDx.prevalenceInterval ( ) starts before day of ( start of "Measurement Period" + 90 days )
      and HIVDx.isVerified ( )

define "Initial Population":
  "Has Active HIV Diagnosis Before or in First 90 Days of Measurement Period"
    and "Has Qualifying Encounter During First 240 Days of Measurement Period"

define "Most Recent Viral Load Test During Measurement Period":
  Last(["LaboratoryResultObservation": "HIV Viral Load Tests"] ViralLoad
      where ViralLoad.status in { 'final', 'amended', 'corrected' }
        and ViralLoad.effective.latest() during day of "Measurement Period"
      sort by effective.earliest()
  )

define "Has Qualifying Encounter During First 240 Days of Measurement Period":
/*Note: applied workaround using value set 'Preventive Care Services Other', as a DRC cannot be used directly from an encounter retrieve; additional info can be found in CQLIT-368*/
  
  exists ( ["Encounter": "Office Visit"]
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
    where QualifyingEncounter.period during day of Interval[start of "Measurement Period", start of "Measurement Period" + 240 days]
      and QualifyingEncounter.status = 'finished'

define "Numerator":
  "Most Recent Viral Load Test During Measurement Period".value < 200 '{copies}/mL'
    or "Most Recent Viral Load Test During Measurement Period".value ~ "Below threshold level (qualifier value)"
    or "Most Recent Viral Load Test During Measurement Period".value ~ "Not detected (qualifier value)"

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