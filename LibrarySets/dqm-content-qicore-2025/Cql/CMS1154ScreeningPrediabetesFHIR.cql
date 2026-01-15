library CMS1154ScreeningPrediabetesFHIR version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "LOINC": 'http://loinc.org'
codesystem "CDCREC": 'urn:oid:2.16.840.1.113883.6.238'

valueset "Advanced Illness": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082'
valueset "Diabetes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001'
valueset "Ethnicity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837'
valueset "Glycemic Screening Tests": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1160.5'
valueset "Limited Life Expectancy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1259'
valueset "Outpatient Clinical Encounters": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1160.24'
valueset "Payer Type": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591'
valueset "Prediabetes (Borderline Diabetes)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1222.419'
valueset "Pregnancy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378'
valueset "Preventative Clinical Encounters": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1160.13'

code "Body mass index (BMI) [Ratio]": '39156-5' from "LOINC" display 'Body mass index (BMI) [Ratio]'
code "Asian": '2028-9' from "CDCREC" display 'Asian'

codesystem "ConditionVerificationStatusCodes": 'http://terminology.hl7.org/CodeSystem/condition-ver-status'

code "unconfirmed": 'unconfirmed' from ConditionVerificationStatusCodes display 'Unconfirmed'
code "provisional": 'provisional' from ConditionVerificationStatusCodes display 'Provisional'
code "differential": 'differential' from ConditionVerificationStatusCodes display 'Differential'
code "confirmed": 'confirmed' from ConditionVerificationStatusCodes display 'Confirmed'
code "refuted": 'refuted' from ConditionVerificationStatusCodes display 'Refuted'
code "entered-in-error": 'entered-in-error' from ConditionVerificationStatusCodes display 'Entered in Error'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define fluent function verified(conditions List<Choice<ConditionProblemsHealthConcerns, ConditionEncounterDiagnosis>>):
  conditions C
    where C.verificationStatus is not null implies ( C.verificationStatus ~ "confirmed"
        or C.verificationStatus ~ "unconfirmed"
        or C.verificationStatus ~ "provisional"
        or C.verificationStatus ~ "differential"
    )

define "Has Advanced Illness or Limited Life Expectancy":
  ( ( ["ConditionProblemsHealthConcerns": "Advanced Illness"]
      union ["ConditionEncounterDiagnosis": "Advanced Illness"]
      union ["ConditionProblemsHealthConcerns": "Limited Life Expectancy"]
      union ["ConditionEncounterDiagnosis": "Limited Life Expectancy"]
  ).verified ( ) ) AdvancedIllness
    where "AdvancedIllness".onset before day of end of "Measurement Period"

define "Denominator":
  "Initial Population"

define "Glycemic Laboratory Test Performed During Measurement Period":
  [LaboratoryResultObservation: "Glycemic Screening Tests"] LabTestPerformed
    where QICoreCommon.ToInterval ( LabTestPerformed.effective ) during day of "Measurement Period"
      and LabTestPerformed.status in { 'final', 'amended', 'corrected' }

define "Numerator":
  exists "Glycemic Laboratory Test Performed During Measurement Period"

define "Has Pregnancy Observation During Measurement Period":
  exists ( [USCoreObservationPregnancyStatusProfile] PregnantObservation
      where PregnantObservation.value in "Pregnancy"
        and PregnantObservation.effective.toInterval ( ) overlaps day of "Measurement Period"
  )

define "Has Pregnancy Diagnosis During Measurement Period":
  ( ( [ConditionProblemsHealthConcerns: "Pregnancy"]
      union [ConditionEncounterDiagnosis: "Pregnancy"]
  ).verified ( ) ) PregnancyDx
    where PregnancyDx.prevalenceInterval ( ) overlaps day of "Measurement Period"

define "Preventive Care Outpatient Visits During Measurement Period":
  [Encounter: "Preventative Clinical Encounters"] PreventiveCare
    where PreventiveCare.period ends during day of "Measurement Period"
      and PreventiveCare.status = 'finished'

define "Most Recent BMI Equal to or Greater Than 23 and Is Asian":
  "Most Recent BMI".value >= 23 'kg/m2'
    and "Patient is Asian"

define "Most Recent BMI Equal to or Greater Than 25 and Is Not Asian":
  "Most Recent BMI".value >= 25 'kg/m2'
    and "Patient is not Asian"

define "Initial Population":
  "Patients Aged 35 to 70 with an Office Visit During the Measurement Period"
    and ( "Most Recent BMI Equal to or Greater Than 25 and Is Not Asian"
        or "Most Recent BMI Equal to or Greater Than 23 and Is Asian"
    )

define "Office Visit During the Measurement Period":
  [Encounter: "Outpatient Clinical Encounters"] OfficeVisit
    where OfficeVisit.period during day of "Measurement Period"
      and OfficeVisit.status = 'finished'

define "Patients Aged 35 to 70 with an Office Visit During the Measurement Period":
  ( exists ( "Preventive Care Outpatient Visits During Measurement Period" )
      or Count("Office Visit During the Measurement Period") >= 2
  )
    and "Aged 35 to 70 at Start of Measurement Period" is true

define "Prediabetes Diagnosis Overlaps 2 Year Look Back Period":
  ( ( ["ConditionProblemsHealthConcerns": "Prediabetes (Borderline Diabetes)"]
      union [ConditionEncounterDiagnosis: "Prediabetes (Borderline Diabetes)"]
  ).verified ( ) ) PriorPrediabetes
    where "PriorPrediabetes".prevalenceInterval ( ) overlaps day of "Look Back Period"

define "Denominator Exclusions":
  "Has Pregnancy Observation During Measurement Period"
    or exists "Has Pregnancy Diagnosis During Measurement Period"
    or exists "Has Advanced Illness or Limited Life Expectancy"
    or exists "Diabetes Diagnosis Overlaps 2 Year Look Back Period"
    or exists "Prediabetes Diagnosis Overlaps 2 Year Look Back Period"
    or "Has Glycemic Laboratory Test Performed During 2 Year Look Back Period"

define "Diabetes Diagnosis Overlaps 2 Year Look Back Period":
  ( ( ["ConditionProblemsHealthConcerns": "Diabetes"]
      union [ConditionEncounterDiagnosis: "Diabetes"]
  ).verified ( ) ) PriorDiabetes
    where "PriorDiabetes".prevalenceInterval ( ) overlaps day of "Look Back Period"

define "Has Glycemic Laboratory Test Performed During 2 Year Look Back Period":
  exists ( [LaboratoryResultObservation: "Glycemic Screening Tests"] LabTestPerformed
      where QICoreCommon.ToInterval ( LabTestPerformed.effective ) during day of "Look Back Period"
        and LabTestPerformed.status in { 'final', 'amended', 'corrected' }
  )

define "Look Back Period":
  Interval[start of "Measurement Period" - 2 years, start of "Measurement Period" )

define "Most Recent BMI":
  First([USCoreBMIProfile] BMI
      where BMI.status in { 'final', 'amended', 'corrected' }
      sort by start of effective.toInterval() desc
  )

define "Aged 35 to 70 at Start of Measurement Period":
  "AgeInYearsAt"(date from start of "Measurement Period") between 35 and 70

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Patient is Asian":
  exists ( SDE."SDE Race".codes C
      where C ~ "Asian"
  )

define "Patient is not Asian":
  not ( "Patient is Asian" )