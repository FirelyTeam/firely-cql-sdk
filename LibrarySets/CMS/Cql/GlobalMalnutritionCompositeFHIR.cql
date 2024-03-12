library GlobalMalnutritionCompositeFHIR version '0.1.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include QICoreCommon version '2.0.000' called QICoreCommon
include CQMCommon version '2.0.000' called CQMCommon

codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "ICD10CM": 'http://hl7.org/fhir/sid/icd-10-cm'

valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Ethnicity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837'
valueset "Hospital Dietitian Referral": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91'
valueset "Malnutrition Diagnosis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.55'
valueset "Malnutrition Risk Screening": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.92'
valueset "Malnutrition Screening At Risk Result": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.38'
valueset "Malnutrition Screening Not At Risk Result": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.34'
valueset "Nutrition Assessment": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.21'
valueset "Nutrition Assessment Status Moderately Malnourished": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.44'
valueset "Nutrition Assessment Status Not or Mildly Malnourished": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.48'
valueset "Nutrition Assessment Status Severely Malnourished": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.42'
valueset "Nutrition Care Plan": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.93'
valueset "ONC Administrative Sex": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1'
valueset "Payer Type": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591'
valueset "Race": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836'

code "Birth date": '21112-8' from "LOINC" display 'Birth date'

parameter "Measurement Period" Interval<DateTime>default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0 )

context Patient

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer Type":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Qualifying Encounter":
  [Encounter: "Encounter Inpatient"] EncounterInpatient
    where EncounterInpatient.period ends during day of "Measurement Period"
      and AgeInYearsAt(date from start of EncounterInpatient.period) >= 65
      and ( duration in hours of EncounterInpatient.period >= 24 )
      and EncounterInpatient.status = 'finished'

define "Initial Population":
  "Qualifying Encounter"

define "Measure Population":
  "Initial Population"

define "Encounter with Hospital Dietitian Referral":
  from
    "Qualifying Encounter" QualifyingEncounter,
    ["Procedure": "Hospital Dietitian Referral"] HospitalDietitianReferral
    where "Hospital Dietitian Referral" contains HospitalDietitianReferral.code as Concept
      and HospitalDietitianReferral.status in { 'active', 'completed', 'in-progress' }
      and HospitalDietitianReferral.performed.earliest ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
    return QualifyingEncounter

define "Encounter with Malnutrition Risk Screening":
  from
    "Qualifying Encounter" QualifyingEncounter,
    ["Observation": "Malnutrition Risk Screening"] MalnutritionRiskScreening
    where ( "Malnutrition Risk Screening" contains MalnutritionRiskScreening.code as Concept
        and MalnutritionRiskScreening.status in { 'final', 'amended', 'corrected' }
        and MalnutritionRiskScreening.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
        and ( "Malnutrition Screening Not At Risk Result" contains MalnutritionRiskScreening.value as Concept
            or "Malnutrition Screening At Risk Result" contains MalnutritionRiskScreening.value as Concept
        )
    )
    return QualifyingEncounter

define "Encounter with Malnutrition Risk Screening or with Hospital Dietitian Referral":
  from
    "Qualifying Encounter" QualifyingEncounter
    where "Encounter with Malnutrition Risk Screening" contains QualifyingEncounter
      or "Encounter with Hospital Dietitian Referral" contains QualifyingEncounter
    return QualifyingEncounter

define "Encounter with Malnutrition Risk Screening Not at Risk":
  from
    "Qualifying Encounter" QualifyingEncounter,
    ["Observation": "Malnutrition Risk Screening"] MalnutritionRiskScreening
    where "Malnutrition Risk Screening" contains MalnutritionRiskScreening.code as Concept
      and MalnutritionRiskScreening.status in { 'final', 'amended', 'corrected' }
      and MalnutritionRiskScreening.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
      and ( "Malnutrition Screening Not At Risk Result" contains MalnutritionRiskScreening.value as Concept )
    return QualifyingEncounter

define "Encounter with Malnutrition Not at Risk Screening and without Hospital Dietitian Referral":
  from
    "Qualifying Encounter" QualifyingEncounter
    where "Encounter with Malnutrition Risk Screening Not at Risk" contains QualifyingEncounter
      and not exists ( "Encounter with Hospital Dietitian Referral" )
    return QualifyingEncounter

define "Encounter with Malnutrition Risk Screening at Risk":
  from
    "Qualifying Encounter" QualifyingEncounter,
    ["Observation": "Malnutrition Risk Screening"] MalnutritionRiskScreening
    where "Malnutrition Risk Screening" contains MalnutritionRiskScreening.code as Concept
      and MalnutritionRiskScreening.status in { 'final', 'amended', 'corrected' }
      and MalnutritionRiskScreening.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
      and ( "Malnutrition Screening At Risk Result" contains MalnutritionRiskScreening.value as Concept )
    return QualifyingEncounter

define "Encounter with Malnutrition Risk Screening at Risk or with Hospital Dietitian Referral":
  from
    "Qualifying Encounter" QualifyingEncounter
    where "Encounter with Malnutrition Risk Screening at Risk" contains QualifyingEncounter
      or "Encounter with Hospital Dietitian Referral" contains QualifyingEncounter
    return QualifyingEncounter

define "Encounter with Nutrition Assessment and Identified Status":
  from
    "Qualifying Encounter" QualifyingEncounter,
    ["Observation": "Nutrition Assessment"] NutritionAssessment
    where "Nutrition Assessment" contains NutritionAssessment.code as Concept
      and NutritionAssessment.status in { 'final', 'amended', 'corrected' }
      and NutritionAssessment.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
      and ( "Nutrition Assessment Status Moderately Malnourished" contains NutritionAssessment.value as Concept
          or "Nutrition Assessment Status Not or Mildly Malnourished" contains NutritionAssessment.value as Concept
          or "Nutrition Assessment Status Severely Malnourished" contains NutritionAssessment.value as Concept
      )
    return QualifyingEncounter

define "Encounter with Nutrition Assessment Status Moderately Or Severely Malnourished":
  from
    "Qualifying Encounter" QualifyingEncounter,
    ["Observation": "Nutrition Assessment"] NutritionAssessment
    where ( "Nutrition Assessment" contains NutritionAssessment.code as Concept
        and NutritionAssessment.status in { 'final', 'amended', 'corrected' }
        and NutritionAssessment.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
        and ( "Nutrition Assessment Status Moderately Malnourished" contains NutritionAssessment.value as Concept
            or "Nutrition Assessment Status Severely Malnourished" contains NutritionAssessment.value as Concept
        )
    )
    return QualifyingEncounter

define "Encounter with Nutrition Assessment Not or Mildly Malnourished":
  from
    "Qualifying Encounter" QualifyingEncounter,
    ["Observation": "Nutrition Assessment"] NutritionAssessment
    where "Nutrition Assessment" contains NutritionAssessment.code as Concept
      and NutritionAssessment.status in { 'final', 'amended', 'corrected' }
      and NutritionAssessment.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
      and ( "Nutrition Assessment Status Not or Mildly Malnourished" contains NutritionAssessment.value as Concept )
    return QualifyingEncounter

define "Encounter with Malnutrition Diagnosis":
  from
    "Qualifying Encounter" QualifyingEncounter,
    ["Condition": "Malnutrition Diagnosis"] MalnutritionDiagnosis
    where "Malnutrition Diagnosis" contains MalnutritionDiagnosis.code as Concept
      and MalnutritionDiagnosis.prevalenceInterval ( ) starts during QualifyingEncounter.hospitalizationWithObservation ( )
    return QualifyingEncounter

define "Encounter with Nutrition Care Plan":
  from
    "Qualifying Encounter" QualifyingEncounter,
    ["Procedure": "Nutrition Care Plan"] NutritionCarePlan
    where "Nutrition Care Plan" contains NutritionCarePlan.code as Concept
      and NutritionCarePlan.status in { 'completed', 'in-progress' }
      and NutritionCarePlan.performed.earliest ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
    return QualifyingEncounter

define function "Measure Observation 1"(MalnutritionRiskScreening Encounter):
  if "Encounter with Malnutrition Risk Screening or with Hospital Dietitian Referral" contains MalnutritionRiskScreening then 1 
    else 0

define function "Measure Observation 2"(NutritionAssessment Encounter):
  if "Encounter with Malnutrition Not at Risk Screening and without Hospital Dietitian Referral" contains NutritionAssessment then 0 
    else if "Encounter with Malnutrition Risk Screening at Risk or with Hospital Dietitian Referral" contains NutritionAssessment then if "Encounter with Nutrition Assessment and Identified Status" contains NutritionAssessment then 1 
    else 0 
    else 0

define function "Measure Observation 3"(MalnutritionDiagonsis Encounter):
  if "Encounter with Malnutrition Not at Risk Screening and without Hospital Dietitian Referral" contains MalnutritionDiagonsis then 0 
    else if "Encounter with Malnutrition Risk Screening at Risk or with Hospital Dietitian Referral" contains MalnutritionDiagonsis then if "Encounter with Malnutrition Diagnosis" contains MalnutritionDiagonsis then if "Encounter with Nutrition Assessment Not or Mildly Malnourished" contains MalnutritionDiagonsis then 0 
    else if "Encounter with Nutrition Assessment Status Moderately Or Severely Malnourished" contains MalnutritionDiagonsis then 1 
    else 0 
    else 0 
    else 0

define function "Measure Observation 4"(NutritionCarePlan Encounter):
  if "Encounter with Malnutrition Not at Risk Screening and without Hospital Dietitian Referral" contains NutritionCarePlan then 0 
    else if "Encounter with Malnutrition Risk Screening at Risk or with Hospital Dietitian Referral" contains NutritionCarePlan then if "Encounter with Nutrition Care Plan" contains NutritionCarePlan then if "Encounter with Nutrition Assessment Not or Mildly Malnourished" contains NutritionCarePlan then 0 
    else if "Encounter with Nutrition Assessment Status Moderately Or Severely Malnourished" contains NutritionCarePlan then 1 
    else 0 
    else 0 
    else 0

define function "Measure Observation TotalMalnutritionComponentsScore"(QualifyingEncounter Encounter):
  Sum({ "Measure Observation 1"(QualifyingEncounter), "Measure Observation 2"(QualifyingEncounter), "Measure Observation 3"(QualifyingEncounter), "Measure Observation 4"(QualifyingEncounter) })

define function "TotalMalnutritionCompositeScore Eligible Denominators"(QualifyingEncounter Encounter):
  if ( ( "Encounter with Malnutrition Risk Screening or with Hospital Dietitian Referral" contains QualifyingEncounter )
      and ( "Encounter with Malnutrition Risk Screening Not at Risk" contains QualifyingEncounter )
  )
    and not ( "Encounter with Hospital Dietitian Referral" contains QualifyingEncounter ) then 1 
    else if ( ( ( "Encounter with Malnutrition Risk Screening or with Hospital Dietitian Referral" contains QualifyingEncounter )
        and ( "Encounter with Malnutrition Risk Screening at Risk" contains QualifyingEncounter )
    )
      or ( "Encounter with Hospital Dietitian Referral" contains QualifyingEncounter )
  )
    and ( "Encounter with Nutrition Assessment Not or Mildly Malnourished" contains QualifyingEncounter )
    or not ( "Encounter with Nutrition Assessment and Identified Status" contains QualifyingEncounter ) then 2 
    else 4

define function "Measure Observation TotalMalnutritionCompositeScore as Percentage"(QualifyingEncounter Encounter):
  100 * ( "Measure Observation TotalMalnutritionComponentsScore"(QualifyingEncounter) / "TotalMalnutritionCompositeScore Eligible Denominators"(QualifyingEncounter) )