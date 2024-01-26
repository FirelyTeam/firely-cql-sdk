library HIVRetentionFHIR version '0.1.000'

using QICore version '4.1.1'

include CQMCommon version '2.0.000' called CQMCommon
include FHIRHelpers version '4.3.000' called FHIRHelpers
include QICoreCommon version '2.0.000' called QICoreCommon
include SupplementalDataElements version '3.4.000' called SDE
include CumulativeMedicationDuration version '4.0.000' called CMD

codesystem "CPT": 'http://www.ama-assn.org/go/cpt'

valueset "Annual Wellness Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240'
valueset "Face-to-Face Interaction": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048'
valueset "HIV": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003'
valueset "HIV Viral Load": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Preventive Care Services, Initial Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022'
valueset "Preventive Care, Established Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'
valueset "Preventive Care Services Other": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Ethnicity":
  Patient.ethnicity E
    return Tuple {
      codes: { E.ombCategory }
        union E.detailed,
      display: E.text
    }

define "SDE Race":
  Patient.race R
    return Tuple {
      codes: R.ombCategory
        union R.detailed,
      display: R.text
    }

define "SDE Sex":
  SDE."SDE Sex"

define "Denominator":
  "Initial Population"

define "Encounter During Measurement Period With HIV":
  ( ( ["Encounter": "Office Visit"]
      union ["Encounter": "Outpatient Consultation"]
      union ["Encounter": "Annual Wellness Visit"]
      union ["Encounter": "Face-to-Face Interaction"]
      union ["Encounter": "Home Healthcare Services"]
      union ["Encounter": "Preventive Care Services Established Office Visit, 18 and Up"]
      union ["Encounter": "Preventive Care Services Initial Office Visit, 18 and Up"]
      union ["Encounter": "Preventive Care Services, Initial Office Visit, 0 to 17"]
      union ["Encounter": "Preventive Care, Established Office Visit, 0 to 17"]
      union ["Encounter": "Telephone Visits"]
      union ["Encounter": "Preventive Care Services Other"] ) ValidEncounter
      with ["Condition": "HIV"] HIVDiagnosis
        such that ValidEncounter.period during "Measurement Period"
          and HIVDiagnosis.prevalenceInterval ( ) starts on or before day of ValidEncounter.period
          and HIVDiagnosis.isActive ( )
  )

define "Has Active HIV Diagnosis Starts On or Before First 240 Days of Measurement Period":
  exists ( ["Condition": "HIV"] HIVDx
      where HIVDx.prevalenceInterval ( ) starts on or before date from ( start of "Measurement Period" + 240 days )
        and HIVDx.isActive ( )
  )

define "Has HIV Viral Load Test During Measurement Period":
  exists ( ["Observation": "HIV Viral Load"] ViralLoadTest
      where QICoreCommon."ToInterval" ( ViralLoadTest.effective ) during day of "Measurement Period"
  )

define "Has One Encounter With HIV and One Viral Load Test At Least 90 Days Apart":
  exists ( "Encounter During Measurement Period With HIV" ) EncounterWithHIV
    with ["Observation": "HIV Viral Load"] ViralLoadTest
      such that ( QICoreCommon."ToInterval" ( ViralLoadTest.effective ) during "Measurement Period" )
        and ( ( QICoreCommon."ToInterval" ( ViralLoadTest.effective ) starts 90 days or more after day of end of EncounterWithHIV.period )
            or ( EncounterWithHIV.period starts 90 days or more after day of end of QICoreCommon."ToInterval" ( ViralLoadTest.effective ) )
        )

define "Has Qualifying Encounter During First 240 Days of Measurement Period":
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

define "Has Two Encounters With HIV At Least 90 Days Apart":
  exists "Encounter During Measurement Period With HIV" EncounterWithHIV
    with "Encounter During Measurement Period With HIV" AnotherEncounterWithHIV
      such that EncounterWithHIV !~ AnotherEncounterWithHIV
        and AnotherEncounterWithHIV.period starts 90 days or more after day of end of EncounterWithHIV.period

define "Initial Population":
  "Has Active HIV Diagnosis Starts On or Before First 240 Days of Measurement Period"
    and "Has Qualifying Encounter During First 240 Days of Measurement Period"

define "Numerator":
  "Has One Encounter With HIV and One Viral Load Test At Least 90 Days Apart"
    or "Has Two Encounters With HIV At Least 90 Days Apart"