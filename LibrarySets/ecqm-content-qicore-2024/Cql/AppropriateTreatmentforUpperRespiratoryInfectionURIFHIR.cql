library AppropriateTreatmentforUpperRespiratoryInfectionURIFHIR version '0.1.001'

using QICore version '4.1.1'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '3.5.000' called SDE
include Hospice version '6.12.000' called Hospice
include Status version '1.8.000' called Status
include QICoreCommon version '2.1.000' called QICoreCommon
include Antibiotic version '1.7.000' called Antibiotic

codesystem "CPT": 'http://www.ama-assn.org/go/cpt'

valueset "Acute Pharyngitis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011'
valueset "Acute Tonsillitis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012'
valueset "Antibiotic Medications for Upper Respiratory Infection": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001'
valueset "Comorbid Conditions for Respiratory Conditions": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025'
valueset "Competing Conditions for Respiratory Conditions": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017'
valueset "Emergency Department Evaluation and Management Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Medical Disability Exam": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1073'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Group Counseling": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027'
valueset "Preventive Care Services Individual Counseling": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Preventive Care Services, Initial Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022'
valueset "Preventive Care, Established Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'
valueset "Upper Respiratory Infection": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1022'
valueset "Virtual Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'

code "Unlisted preventive medicine service": '99429' from "CPT" display 'Unlisted preventive medicine service'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.000Z, @2025-12-31T23:59:59.999Z]

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
    union Antibiotic."Has Competing Diagnosis History" ( "Encounter with Upper Respiratory Infection", ( [Condition: "Competing Conditions for Respiratory Conditions"]
        union [Condition: "Acute Pharyngitis"]
        union [Condition: "Acute Tonsillitis"]
    ) )

define "Encounter with Upper Respiratory Infection":
  from
    "Qualifying Encounters" QualifyingEncounters,
    [Condition: "Upper Respiratory Infection"] URI
    where URI.prevalenceInterval ( ) starts during day of QualifyingEncounters.period.toInterval ( )
      or URI.prevalenceInterval ( ) overlaps before QualifyingEncounters.period.toInterval ( )
    return QualifyingEncounters

define "Qualifying Encounters":
  ( ( [Encounter: "Emergency Department Evaluation and Management Visit"]
      union [Encounter: "Home Healthcare Services"]
      union [Encounter: "Medical Disability Exam"]
      union [Encounter: "Office Visit"]
      union [Encounter: "Outpatient Consultation"]
      union [Encounter: "Preventive Care Services Group Counseling"]
      union [Encounter: "Preventive Care Services Individual Counseling"]
      union [Encounter: "Preventive Care Services, Initial Office Visit, 0 to 17"]
      union [Encounter: "Preventive Care, Established Office Visit, 0 to 17"]
      union [Encounter: "Preventive Care Services Established Office Visit, 18 and Up"]
      union [Encounter: "Preventive Care Services Initial Office Visit, 18 and Up"]
      union [Encounter: "Telephone Visits"]
      union [Encounter: "Virtual Encounter"]
      union ( [Encounter] E
          where exists ( ( E.type ) T
              where T ~ "Unlisted preventive medicine service"
          )
      )
  ).isEncounterPerformed ( ) ) ValidEncounter
    where ValidEncounter.period.toInterval ( ) ends during day of Interval[( start of "Measurement Period" ), ( end of "Measurement Period" ) - 3 days]

define "Numerator":
  "Encounter with Upper Respiratory Infection" EncounterWithURI
    without ( ( [MedicationRequest: "Antibiotic Medications for Upper Respiratory Infection"] ).isMedicationOrder ( ) ) OrderedAntibiotic
      such that OrderedAntibiotic.authoredOn 3 days or less on or after start of EncounterWithURI.period.toInterval ( )
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