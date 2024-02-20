library AppropriateTestingforPharyngitisFHIR version '0.1.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include CQMCommon version '2.0.000' called CQMCommon
include Hospice version '6.9.000' called Hospice
include Antibiotic version '1.5.000' called Antibiotic
include Status version '1.6.000' called Status
include QICoreCommon version '2.0.000' called QICoreCommon

codesystem "CPT": 'http://www.ama-assn.org/go/cpt'

valueset "Acute Pharyngitis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1011'
valueset "Acute Tonsillitis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1012'
valueset "Antibiotic Medications for Pharyngitis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1001'
valueset "Comorbid Conditions for Respiratory Conditions": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1025'
valueset "Competing Conditions for Respiratory Conditions": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.102.12.1017'
valueset "Discharge Services Observation Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1039'
valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010'
valueset "Group A Streptococcus Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1012'
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

code "Observation care discharge day management (This code is to be utilized to report all services provided to a patient on discharge from outpatient hospital observation status if the discharge is on other than the initial date of observation status. To report services to a patient designated as observation status or inpatient status and discharged on the same date, use the codes for Observation or Inpatient Care Services [including Admission and Discharge Services, 99234-99236 as appropriate.])": '99217' from "CPT" display 'Observation care discharge day management (This code is to be utilized to report all services provided to a patient on discharge from outpatient hospital observation status if the discharge is on other than the initial date of observation status. To report services to a patient designated as observation status or inpatient status and discharged on the same date, use the codes for Observation or Inpatient Care Services [including Admission and Discharge Services, 99234-99236 as appropriate.])'
code "Unlisted preventive medicine service": '99429' from "CPT" display 'Unlisted preventive medicine service'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

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
    where QICoreCommon."ToPrevalenceInterval" ( AcutePharyngitisTonsillitis ) starts during QICoreCommon."ToInterval" ( VisitWithAntibiotic.period )
    return VisitWithAntibiotic

define "Pharyngitis or Tonsillitis":
  ( Status."Active Condition" ( [Condition: "Acute Pharyngitis"]
      union [Condition: "Acute Tonsillitis"] )
  )

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "In Hospice"
    union Antibiotic."Has Antibiotic Medication History" ( "Encounter With Pharyngitis or Tonsillitis With Antibiotic", ( [MedicationRequest: "Antibiotic Medications for Pharyngitis"] ) )
    union Antibiotic."Has Competing Diagnosis History" ( "Encounter With Pharyngitis or Tonsillitis With Antibiotic", ( [Condition: "Competing Conditions for Respiratory Conditions"] ) )
    union Antibiotic."Has Comorbid Condition History" ( "Encounter With Pharyngitis or Tonsillitis With Antibiotic", ( [Condition: "Comorbid Conditions for Respiratory Conditions"] ) )

define "In Hospice":
  "Initial Population" EligibleEncounters
    where Hospice."Has Hospice Services"

define "Encounter With Antibiotic Ordered Within Three Days":
  "Qualifying Encounter" EDOrAmbulatoryVisit
    with ( Status."Active Medication" ( [MedicationRequest: "Antibiotic Medications for Pharyngitis"] ) ) AntibioticOrdered
      such that ( QICoreCommon."ToInterval" ( EDOrAmbulatoryVisit.period ) starts 3 days or less on or before AntibioticOrdered.authoredOn )

define "Qualifying Encounter":
  ( Status."Finished Encounter" ( [Encounter: "Emergency Department Visit"]
    union ( [Encounter] E
        where exists ( ( E.type ) T
            where T ~ "Observation care discharge day management (This code is to be utilized to report all services provided to a patient on discharge from outpatient hospital observation status if the discharge is on other than the initial date of observation status. To report services to a patient designated as observation status or inpatient status and discharged on the same date, use the codes for Observation or Inpatient Care Services [including Admission and Discharge Services, 99234-99236 as appropriate.])"
        )
    )
    union ["Encounter": "Emergency Department Visit"]
    union ["Encounter": "Home Healthcare Services"]
    union ["Encounter": "Initial Hospital Observation Care"]
    union ["Encounter": "Medical Disability Exam"]
    union ["Encounter": "Observation"]
    union ["Encounter": "Office Visit"]
    union ["Encounter": "Telephone Visits"]
    union ["Encounter": "Online Assessments"]
    union ["Encounter": "Outpatient Consultation"]
    union ["Encounter": "Preventive Care Services Established Office Visit, 18 and Up"]
    union ["Encounter": "Preventive Care Services Group Counseling"]
    union ( [Encounter] E
        where exists ( ( E.type ) T
            where T ~ "Unlisted preventive medicine service"
        )
    )
    union ["Encounter": "Preventive Care Services, Initial Office Visit, 0 to 17"]
    union ["Encounter": "Preventive Care Services Individual Counseling"]
    union ["Encounter": "Preventive Care Services Initial Office Visit, 18 and Up"]
    union ["Encounter": "Preventive Care, Established Office Visit, 0 to 17"] ) ) ValidEncounter
    where QICoreCommon."ToInterval" ( ValidEncounter.period ) during "Measurement Period"

define "Numerator":
  from
    "Group A Streptococcus Lab Test With Result" GroupAStreptococcusTest,
    "Encounter With Pharyngitis or Tonsillitis With Antibiotic" EncounterWithPharyngitis
    where ( QICoreCommon."ToInterval" ( GroupAStreptococcusTest.effective ) starts during day of Interval[( end of EncounterWithPharyngitis.period ) - 3 days, ( end of EncounterWithPharyngitis.period ) + 3 days])
    return EncounterWithPharyngitis

define "Group A Streptococcus Lab Test With Result":
  ( Status."Final Lab Observation" ( [Observation: "Group A Streptococcus Test"] ) ) GroupAStreptococcusTest
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