library ChlamydiaScreeninginWomenFHIR version '0.1.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include QICoreCommon version '2.0.000' called QICoreCommon
include CQMCommon version '2.0.000' called CQMCommon
include SupplementalDataElements version '3.4.000' called SDE
include Hospice version '6.9.000' called Hospice
include CumulativeMedicationDuration version '4.0.000' called CMD
include Status version '1.6.000' called Status

codesystem "AdministrativeGender": 'http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender'
codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Chlamydia Screening": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1052'
valueset "Complications of Pregnancy, Childbirth and the Puerperium": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1012'
valueset "Contraceptive Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1080'
valueset "Diagnoses Used to Indicate Sexual Activity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1018'
valueset "Diagnostic Studies During Pregnancy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1008'
valueset "HIV": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Isotretinoin": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1143'
valueset "Lab Tests During Pregnancy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1007'
valueset "Lab Tests for Sexually Transmitted Infections": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1051'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Online Assessments": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'
valueset "Pap Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1017'
valueset "Pregnancy Test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1011'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Preventive Care Services, Initial Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022'
valueset "Preventive Care, Established Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024'
valueset "Procedures Used to Indicate Sexual Activity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.111.12.1017'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'
valueset "XRay Study": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1034'

code "Female": 'F' from "AdministrativeGender" display 'Female'
code "Have you ever had vaginal intercourse [PhenX]": '64728-9' from "LOINC" display 'Have you ever had vaginal intercourse [PhenX]'
code "Yes (qualifier value)": '373066001' from "SNOMEDCT" display 'Yes (qualifier value)'

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
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) in Interval[16, 24]
    and Patient.gender = 'female'
    and exists ( "Qualifying Encounters" )
    and ( ( "Has Assessments Identifying Sexual Activity" )
        or ( "Has Diagnoses Identifying Sexual Activity" )
        or ( "Has Active Contraceptive Medications" )
        or ( "Has Ordered Contraceptive Medications" )
        or ( "Has Laboratory Tests Identifying Sexual Activity" )
        or ( "Has Diagnostic Studies Identifying Sexual Activity" )
        or ( "Has Procedures Identifying Sexual Activity" )
    )

define "Qualifying Encounters":
  ( ( Status."Finished Encounter" ( [Encounter: "Office Visit"]
      union [Encounter: "Preventive Care Services Established Office Visit, 18 and Up"]
      union [Encounter: "Preventive Care Services Initial Office Visit, 18 and Up"]
      union [Encounter: "Preventive Care Services, Initial Office Visit, 0 to 17"]
      union [Encounter: "Preventive Care, Established Office Visit, 0 to 17"]
      union [Encounter: "Home Healthcare Services"]
      union [Encounter: "Telephone Visits"]
      union [Encounter: "Online Assessments"] ) ) ValidEncounters
      where QICoreCommon."ToInterval" ( ValidEncounters.period ) during day of "Measurement Period"
  )

define "Has Diagnoses Identifying Sexual Activity":
  exists ( ( [Condition: "Diagnoses Used to Indicate Sexual Activity"]
      union [Condition: "HIV"]
      union [Condition: "Complications of Pregnancy, Childbirth and the Puerperium"] ) SexualActivityDiagnosis
      where QICoreCommon."ToPrevalenceInterval" ( SexualActivityDiagnosis ) overlaps "Measurement Period"
  )

define "Has Active Contraceptive Medications":
  exists ( ( Status."Active Medication" ( ["MedicationRequest": "Contraceptive Medications"] ) ) ActiveContraceptives
      where CMD."MedicationRequestPeriod" ( ActiveContraceptives ) overlaps "Measurement Period"
  )

define "Has Ordered Contraceptive Medications":
  exists ( ( Status."Active or Completed Medication Request" ( [MedicationRequest: "Contraceptive Medications"] ) ) OrderedContraceptives
      where QICoreCommon."ToInterval" ( OrderedContraceptives.authoredOn ) during day of "Measurement Period"
  )

define "Has Laboratory Tests Identifying Sexual Activity But Not Pregnancy":
  exists ( ( Status."Completed or Ongoing Service Request" ( [ServiceRequest: "Pap Test"]
      union [ServiceRequest: "Lab Tests During Pregnancy"]
      union [ServiceRequest: "Lab Tests for Sexually Transmitted Infections"] ) ) LabOrders
      where QICoreCommon."ToInterval" ( LabOrders.authoredOn ) during day of "Measurement Period"
  )

define "Has Laboratory Tests Identifying Sexual Activity":
  exists ( ( Status."Completed or Ongoing Service Request" ( [ServiceRequest: "Pregnancy Test"] ) ) PregnancyTest
      where QICoreCommon."ToInterval" ( PregnancyTest.authoredOn ) during day of "Measurement Period"
  )
    or "Has Laboratory Tests Identifying Sexual Activity But Not Pregnancy"

define "Has Diagnostic Studies Identifying Sexual Activity":
  exists ( ( Status."Completed or Ongoing Service Request" ( [ServiceRequest: "Diagnostic Studies During Pregnancy"] ) ) SexualActivityDiagnostics
      where QICoreCommon."ToInterval" ( SexualActivityDiagnostics.authoredOn ) during day of "Measurement Period"
  )

define "Has Procedures Identifying Sexual Activity":
  exists ( ( Status."Completed Procedure" ( [Procedure: "Procedures Used to Indicate Sexual Activity"] ) ) ProceduresForSexualActivity
      where QICoreCommon."ToInterval" ( ProceduresForSexualActivity.performed ) during day of "Measurement Period"
  )

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or ( ( "Has Pregnancy Test Exclusion" )
        and not ( "Has Assessments Identifying Sexual Activity" )
        and not ( "Has Diagnoses Identifying Sexual Activity" )
        and not ( "Has Active Contraceptive Medications" )
        and not ( "Has Ordered Contraceptive Medications" )
        and not ( "Has Laboratory Tests Identifying Sexual Activity But Not Pregnancy" )
        and not ( "Has Diagnostic Studies Identifying Sexual Activity" )
        and not ( "Has Procedures Identifying Sexual Activity" )
    )

define "Has Pregnancy Test Exclusion":
  exists ( ( ( Status."Completed or Ongoing Service Request" ( [ServiceRequest: "Pregnancy Test"] ) ) PregnancyTest
        with ( Status."Completed or Ongoing Service Request" ( [ServiceRequest: "XRay Study"] ) ) XrayOrder
          such that QICoreCommon."ToInterval" ( XrayOrder.authoredOn ) occurs 6 days or less on or after day of QICoreCommon."ToInterval" ( PregnancyTest.authoredOn )
            and QICoreCommon."ToInterval" ( PregnancyTest.authoredOn ) during "Measurement Period"
    )
      union ( ( Status."Completed or Ongoing Service Request" ( [ServiceRequest: "Pregnancy Test"] ) ) PregnancyTestOrder
          with ( Status."Active or Completed Medication Request" ( [MedicationRequest: "Isotretinoin"] ) ) AccutaneOrder
            such that QICoreCommon."ToInterval" ( AccutaneOrder.authoredOn ) occurs 6 days or less on or after day of QICoreCommon."ToInterval" ( PregnancyTestOrder.authoredOn )
              and QICoreCommon."ToInterval" ( PregnancyTestOrder.authoredOn ) during "Measurement Period"
      )
  )

define "Numerator":
  exists ( ( Status."Final Lab Observation" ( [Observation: "Chlamydia Screening"] ) ) ChlamydiaTest
      where QICoreCommon."Latest" ( ChlamydiaTest.effective ) during day of "Measurement Period"
        and ChlamydiaTest.value is not null
  )

define "Stratification 1":
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) in Interval[16, 20]

define "Stratification 2":
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) in Interval[21, 24]

define "Has Assessments Identifying Sexual Activity":
  exists ( ( Status."Final Survey Observation" ( [Observation: "Have you ever had vaginal intercourse [PhenX]"] ) ) SexualActivityAssessment
      where SexualActivityAssessment.value ~ "Yes (qualifier value)"
        and QICoreCommon."ToInterval" ( SexualActivityAssessment.effective ) on or before end of "Measurement Period"
  )