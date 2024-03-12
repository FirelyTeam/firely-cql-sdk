library AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR version '0.1.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include CQMCommon version '2.0.000' called CQMCommon
include Hospice version '6.9.000' called Hospice
include Status version '1.6.000' called Status
include QICoreCommon version '2.0.000' called QICoreCommon
include Antibiotic version '1.5.000' called Antibiotic

codesystem "CPT": 'http://www.ama-assn.org/go/cpt'

valueset "Antibiotic Medications for Upper Respiratory Infection": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001'
valueset "Comorbid Conditions for Respiratory Conditions": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025'
valueset "Competing Conditions for Respiratory Conditions": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017'
valueset "Emergency Department Evaluation and Management Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Initial Hospital Observation Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1002'
valueset "Medical Disability Exam": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073'
valueset "Observation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Online Assessments": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Group Counseling": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027'
valueset "Preventive Care Services Individual Counseling": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Preventive Care Services, Initial Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022'
valueset "Preventive Care, Established Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'
valueset "Upper Respiratory Infection": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1022'

code "Unlisted preventive medicine service": '99429' from "CPT" display 'Unlisted preventive medicine service'

parameter "Measurement Period" Interval<DateTime>default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0 )

context Patient

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Initial Population":
  "Encounter with Upper Respiratory Infection" EncounterWithURI
    where AgeInMonthsAt(date from start of "Measurement Period") >= 3
    return EncounterWithURI

define "Encounters and Assessments with Hospice Patient":
  "Initial Population" EligibleEncounters
    where Hospice."Has Hospice Services"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "Encounters and Assessments with Hospice Patient"
    union Antibiotic."Has Comorbid Condition History" ( "Encounter with Upper Respiratory Infection", ( [Condition: "Comorbid Conditions for Respiratory Conditions"] ) )
    union Antibiotic."Has Antibiotic Medication History" ( "Encounter with Upper Respiratory Infection", ( [MedicationRequest: "Antibiotic Medications for Upper Respiratory Infection"] ) )
    union Antibiotic."Has Competing Diagnosis History" ( "Encounter with Upper Respiratory Infection", ( [Condition: "Competing Conditions for Respiratory Conditions"] ) )

define "Encounter with Upper Respiratory Infection":
  from
    "Qualifying Encounters" QualifyingEncounters,
    [Condition: "Upper Respiratory Infection"] URI
    where QICoreCommon."ToPrevalenceInterval" ( URI ) starts during day of ( QICoreCommon."ToInterval" ( QualifyingEncounters.period ) )
      or QICoreCommon."ToPrevalenceInterval" ( URI ) overlaps before ( QICoreCommon."ToInterval" ( QualifyingEncounters.period ) )
    return QualifyingEncounters

define "Qualifying Encounters":
  ( Status."Finished Encounter" ( [Encounter: "Emergency Department Evaluation and Management Visit"]
    union [Encounter: "Home Healthcare Services"]
    union [Encounter: "Initial Hospital Observation Care"]
    union [Encounter: "Medical Disability Exam"]
    union [Encounter: "Observation"]
    union [Encounter: "Office Visit"]
    union [Encounter: "Outpatient Consultation"]
    union [Encounter: "Preventive Care Services Group Counseling"]
    union [Encounter: "Preventive Care Services Individual Counseling"]
    union [Encounter: "Preventive Care Services, Initial Office Visit, 0 to 17"]
    union [Encounter: "Preventive Care, Established Office Visit, 0 to 17"]
    union [Encounter: "Preventive Care Services Established Office Visit, 18 and Up"]
    union [Encounter: "Preventive Care Services Initial Office Visit, 18 and Up"]
    union [Encounter: "Telephone Visits"]
    union [Encounter: "Online Assessments"]
    union ( [Encounter] E
        where exists ( ( E.type ) T
            where T ~ "Unlisted preventive medicine service"
        )
    ) ) ) ValidEncounter
    where QICoreCommon."ToInterval" ( ValidEncounter.period ) ends during day of Interval[( start of "Measurement Period" ), ( end of "Measurement Period" ) - 3 days]

define "Numerator":
  "Encounter with Upper Respiratory Infection" EncounterWithURI
    without [MedicationRequest: "Antibiotic Medications for Upper Respiratory Infection"] OrderedAntibiotic
      such that OrderedAntibiotic.authoredOn 3 days or less on or after start of ( QICoreCommon."ToInterval" ( EncounterWithURI.period ) )
    return EncounterWithURI

define "Stratification 1":
  "Encounter with Upper Respiratory Infection" EncounterWithURI
    where AgeInMonthsAt(date from start of "Measurement Period") >= 3
      and AgeInYearsAt(date from start of "Measurement Period") <= 17
    return EncounterWithURI

define "Stratification 2":
  "Encounter with Upper Respiratory Infection" EncounterWithURI
    where AgeInYearsAt(date from start of "Measurement Period") in Interval[18, 64]
    return EncounterWithURI

define "Stratification 3":
  "Encounter with Upper Respiratory Infection" EncounterWithURI
    where AgeInYearsAt(date from start of "Measurement Period") >= 65
    return EncounterWithURI
