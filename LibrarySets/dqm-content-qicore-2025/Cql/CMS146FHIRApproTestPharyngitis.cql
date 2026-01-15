library CMS146FHIRApproTestPharyngitis version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include Hospice version '6.18.000' called Hospice
include Antibiotic version '1.11.000' called Antibiotic
include Status version '1.15.000' called Status
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "CPT": 'http://www.ama-assn.org/go/cpt'

valueset "Acute Pharyngitis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011'
valueset "Acute Tonsillitis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012'
valueset "Antibiotic Medications for Pharyngitis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001'
valueset "Comorbid Conditions for Respiratory Conditions": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025'
valueset "Competing Conditions for Respiratory Conditions": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017'
valueset "Emergency Department Evaluation and Management Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010'
valueset "Group A Streptococcus Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012'
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
valueset "Virtual Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'

code "Unlisted preventive medicine service": '99429' from "CPT" display 'Unlisted preventive medicine service'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

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
  "Encounter With Pharyngitis or Tonsillitis With Antibiotic" EncounterWithPharyngitis
    where AgeInYearsAt(date from start of "Measurement Period") >= 3
    return EncounterWithPharyngitis

define "Encounter With Pharyngitis or Tonsillitis With Antibiotic":
  from
    "Encounter With Antibiotic Ordered Within Three Days" VisitWithAntibiotic,
    "Pharyngitis or Tonsillitis" AcutePharyngitisTonsillitis
    where AcutePharyngitisTonsillitis.prevalenceInterval ( ) starts during day of VisitWithAntibiotic.period
    return VisitWithAntibiotic

define "Pharyngitis or Tonsillitis":
  ( [ConditionEncounterDiagnosis: "Acute Pharyngitis"]
      union [ConditionEncounterDiagnosis: "Acute Tonsillitis"]
  ).verified ( )

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "Encounters and Assessments with Hospice Patient"
    union Antibiotic."Encounter with Comorbid Condition History" ( "Encounter With Pharyngitis or Tonsillitis With Antibiotic", ( [ConditionEncounterDiagnosis: "Comorbid Conditions for Respiratory Conditions"] ).verified ( ) )
    union Antibiotic."Encounter with Antibiotic Medication History" ( "Encounter With Pharyngitis or Tonsillitis With Antibiotic", ( [MedicationRequest: "Antibiotic Medications for Pharyngitis"] ).isMedicationActive ( ) )
    union Antibiotic."Encounter with Competing Diagnosis History" ( "Encounter With Pharyngitis or Tonsillitis With Antibiotic", ( [ConditionEncounterDiagnosis: "Competing Conditions for Respiratory Conditions"] ).verified ( ) )

define "Encounter With Antibiotic Ordered Within Three Days":
  "Qualifying Encounters" EDOrAmbulatoryVisit
    with ( ( [MedicationRequest: "Antibiotic Medications for Pharyngitis"] ).isMedicationOrder ( ) ) AntibioticOrdered
      such that EDOrAmbulatoryVisit.period.toInterval ( ) starts 3 days or less on or before day of AntibioticOrdered.authoredOn

define "Encounters and Assessments with Hospice Patient":
  "Initial Population" EligibleEncounters
    where Hospice."Has Hospice Services"

define "Qualifying Encounters":
  ( ( [Encounter: "Emergency Department Evaluation and Management Visit"]
      union [Encounter: "Home Healthcare Services"]
      union [Encounter: "Medical Disability Exam"]
      union [Encounter: "Office Visit"]
      union [Encounter: "Telephone Visits"]
      union [Encounter: "Virtual Encounter"]
      union [Encounter: "Outpatient Consultation"]
      union [Encounter: "Preventive Care Services Established Office Visit, 18 and Up"]
      union [Encounter: "Preventive Care Services Group Counseling"]
      union ( [Encounter] E
          where exists ( ( E.type ) T
              where T ~ "Unlisted preventive medicine service"
          )
      )
      union [Encounter: "Preventive Care Services, Initial Office Visit, 0 to 17"]
      union [Encounter: "Preventive Care Services Individual Counseling"]
      union [Encounter: "Preventive Care Services Initial Office Visit, 18 and Up"]
      union [Encounter: "Preventive Care, Established Office Visit, 0 to 17"]
  ).isEncounterPerformed ( ) ) ValidEncounter
    where ValidEncounter.period ends during day of Interval[( start of "Measurement Period" ), ( end of "Measurement Period" ) - 3 days]

define "Numerator":
  from
    "Group A Streptococcus Lab Test With Result" GroupAStreptococcusTest,
    "Encounter With Pharyngitis or Tonsillitis With Antibiotic" EncounterWithPharyngitis
    where GroupAStreptococcusTest.effective.toInterval ( ) starts during day of Interval[( end of EncounterWithPharyngitis.period ) - 3 days, ( end of EncounterWithPharyngitis.period ) + 3 days]
    return EncounterWithPharyngitis

define "Group A Streptococcus Lab Test With Result":
  ( ( [LaboratoryResultObservation: "Group A Streptococcus Test"] ).isLaboratoryTestPerformed ( ) ) GroupAStreptococcusTest
    where GroupAStreptococcusTest.value is not null

define "Stratification 1":
  "Encounter With Pharyngitis or Tonsillitis With Antibiotic" EncounterWithPharyngitis
    where AgeInYearsAt(date from start of "Measurement Period") in Interval[3, 17]
    return EncounterWithPharyngitis

define "Stratification 2":
  "Encounter With Pharyngitis or Tonsillitis With Antibiotic" EncounterWithPharyngitis
    where AgeInYearsAt(date from start of "Measurement Period") in Interval[18, 64]
    return EncounterWithPharyngitis

define "Stratification 3":
  "Encounter With Pharyngitis or Tonsillitis With Antibiotic" EncounterWithPharyngitis
    where AgeInYearsAt(date from start of "Measurement Period") >= 65
    return EncounterWithPharyngitis