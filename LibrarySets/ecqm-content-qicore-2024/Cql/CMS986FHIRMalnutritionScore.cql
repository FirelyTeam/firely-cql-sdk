library CMS986FHIRMalnutritionScore version '0.2.002'

using QICore version '4.1.1'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '3.5.000' called SDE
include QICoreCommon version '2.1.000' called QICoreCommon
include CQMCommon version '2.2.000' called CQMCommon
include Status version '1.8.000'

codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "ICD10CM": 'http://hl7.org/fhir/sid/icd-10-cm'

valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Hospice Status": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.101'
valueset "Hospice Care Referral or Admission": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365'
valueset "Ethnicity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837'
valueset "Hospital Dietitian Referral": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91'
valueset "Malnutrition Diagnosis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.55'
valueset "Malnutrition Risk Screening": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.92'
valueset "Malnutrition Screening Finding of At Risk Result": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.89'
valueset "Malnutrition Screening Finding of Not At Risk Result": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.34'
valueset "Nutrition Assessment": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.21'
valueset "Nutrition Assessment Status Finding of Moderately Malnourished": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.47'
valueset "Nutrition Assessment Status Finding of Well Nourished or Not Malnourished or Mildly Malnourished": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.96'
valueset "Nutrition Assessment Status Finding of Severely Malnourished": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.43'
valueset "Nutrition Care Plan": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.93'
valueset "Observation Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143'
valueset "Patient sex for quality measurement": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1021.120'
valueset "Payer Type": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591'
valueset "Race": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836'

code "Birth date": '21112-8' from "LOINC" display 'Birth date'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2026-12-31T23:59:59.999Z]

context Patient

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer Type":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Patient sex for quality measurement":
  SDE."SDE Sex"

define "Initial Population":
  "Measure Population"

define "Measure Population":
  [Encounter: "Encounter Inpatient"] EncounterInpatient
    where EncounterInpatient.period ends during day of "Measurement Period"
      and AgeInYearsAt(date from start of EncounterInpatient.period) >= 18
      and ( duration in hours of EncounterInpatient.period >= 24 )
      and EncounterInpatient.status = 'finished'

define "Measure Population Exclusion":
  "Encounter with Discharge for Hospice Care"
    union "Encounter with Hospice during Eligible Encounter"

define "Encounter with Discharge for Hospice Care":
  ( "Measure Population" QualifyingEncounter
      where QualifyingEncounter.status = 'finished'
        and ( QualifyingEncounter.hospitalization.dischargeDisposition in "Hospice Care Referral or Admission" )
  )

define "Encounter with Hospice during Eligible Encounter":
  from
    "Measure Population" QualifyingEncounter,
    ( ["ServiceRequest": code in "Hospice Status"]
      union ["Procedure": "Hospice Status"] ) HospiceStatus
    where "Hospice Status" contains HospiceStatus.code as Concept
      and HospiceStatus.status in { 'active', 'completed' }
      and Coalesce(start of HospiceStatus.performed.toInterval(), HospiceStatus.authoredOn) during day of QualifyingEncounter."hospitalizationWithObservation" ( )
    return QualifyingEncounter

define "Encounter with Dietitian Referral":
  from
    "Measure Population" QualifyingEncounter,
    ["Procedure": "Hospital Dietitian Referral"] HospitalDietitianReferral
    where "Hospital Dietitian Referral" contains HospitalDietitianReferral.code as Concept
      and HospitalDietitianReferral.status in { 'active', 'completed', 'in-progress' }
      and HospitalDietitianReferral.performed.earliest ( ) during day of QualifyingEncounter.hospitalizationWithObservation ( )
    return QualifyingEncounter

define "Encounter with Malnutrition Risk Screening":
  from
    "Measure Population" QualifyingEncounter,
    ["Observation": "Malnutrition Risk Screening"] MalnutritionRiskScreening
    where ( "Malnutrition Risk Screening" contains MalnutritionRiskScreening.code as Concept
        and MalnutritionRiskScreening.status in { 'final', 'amended', 'corrected' }
        and MalnutritionRiskScreening.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
        and ( "Malnutrition Screening Finding of Not At Risk Result" contains MalnutritionRiskScreening.value as Concept
            or "Malnutrition Screening Finding of At Risk Result" contains MalnutritionRiskScreening.value as Concept
        )
    )
    return QualifyingEncounter

define "Encounter with Malnutrition Risk Screening or with Hospital Dietitian Referral":
  from
    "Measure Population" QualifyingEncounter
    where "Encounter with Malnutrition Risk Screening" contains QualifyingEncounter
      or "Encounter with Dietitian Referral" contains QualifyingEncounter
    return QualifyingEncounter

define "Encounter with Malnutrition Risk Screening Not At Risk":
  from
    "Measure Population" QualifyingEncounter,
    ["Observation": "Malnutrition Risk Screening"] MalnutritionRiskScreening
    where "Malnutrition Risk Screening" contains MalnutritionRiskScreening.code as Concept
      and MalnutritionRiskScreening.status in { 'final', 'amended', 'corrected' }
      and MalnutritionRiskScreening.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
      and ( "Malnutrition Screening Finding of Not At Risk Result" contains MalnutritionRiskScreening.value as Concept )
    return QualifyingEncounter

define "Encounter with Malnutrition Not At Risk Screening and without Hospital Dietitian Referral":
  from
    "Measure Population" QualifyingEncounter
    where "Encounter with Malnutrition Risk Screening Not At Risk" contains QualifyingEncounter
      and not exists ( "Encounter with Dietitian Referral" )
    return QualifyingEncounter

define "Encounter with Malnutrition Risk Screening At Risk":
  from
    "Measure Population" QualifyingEncounter,
    ["Observation": "Malnutrition Risk Screening"] MalnutritionRiskScreening
    where "Malnutrition Risk Screening" contains MalnutritionRiskScreening.code as Concept
      and MalnutritionRiskScreening.status in { 'final', 'amended', 'corrected' }
      and MalnutritionRiskScreening.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
      and ( "Malnutrition Screening Finding of At Risk Result" contains MalnutritionRiskScreening.value as Concept )
    return QualifyingEncounter

define "Encounter with Malnutrition Risk Screening At Risk or with Hospital Dietitian Referral":
  from
    "Measure Population" QualifyingEncounter
    where "Encounter with Malnutrition Risk Screening At Risk" contains QualifyingEncounter
      or "Encounter with Dietitian Referral" contains QualifyingEncounter
    return QualifyingEncounter

define function "Last Nutrition Assessment Day During Encounter"(QualifyingEncounter Encounter):
  Last("Nutrition Assessment Performed" NutritionAssessmentTuple
      where NutritionAssessmentTuple.HospEncId = QualifyingEncounter.id
      return NutritionAssessmentTuple.NutrAssessTimingLatest
      sort asc
  )

define "Nutrition Assessment Performed":
  from
    "Measure Population" QualifyingEncounter,
    ["Observation": "Nutrition Assessment"] NutritionAssessment
    let NAssessLatest: NutritionAssessment.effective.latest ( )
    where "Nutrition Assessment" contains NutritionAssessment.code as Concept
      and NutritionAssessment.status in { 'final', 'amended', 'corrected' }
      and NutritionAssessment.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
      and NutritionAssessment.value is not null
    return Tuple {
      HospEncId: QualifyingEncounter.id,
      HospitalizationPeriod: QualifyingEncounter.hospitalizationWithObservation ( ),
      NutrAssessCode: NutritionAssessment.code as Concept,
      NutrAssessId: NutritionAssessment.id,
      NutrAssessResult: NutritionAssessment.value,
      NutrAssessTimingEff: NutritionAssessment.effective,
      NutrAssessTimingInt: NutritionAssessment.effective.toInterval ( ),
      NutrAssessTimingLatest: NAssessLatest
    }
    sort by NutrAssessTimingLatest asc

define "Most Recent Encounter with Nutrition Assessment and Identified Status":
  from
    "Measure Population" QualifyingEncounter,
    ["Observation": "Nutrition Assessment"] NutritionAssessment
    where ( "Nutrition Assessment" contains NutritionAssessment.code as Concept
        and NutritionAssessment.status in { 'final', 'amended', 'corrected' }
        and NutritionAssessment.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
        and ( "Nutrition Assessment Status Finding of Well Nourished or Not Malnourished or Mildly Malnourished" contains NutritionAssessment.value as Concept
            or ( "Nutrition Assessment Status Finding of Moderately Malnourished" contains NutritionAssessment.value as Concept )
            or ( "Nutrition Assessment Status Finding of Severely Malnourished" contains NutritionAssessment.value as Concept )
        )
        and ( exists ( "Encounter with Malnutrition Risk Screening At Risk" )
            or exists ( "Encounter with Dietitian Referral" )
        )
        and NutritionAssessment.effective.latest ( ) same day as "Last Nutrition Assessment Day During Encounter"(QualifyingEncounter)
    )
    return QualifyingEncounter

define "Encounter with Nutrition Assessment Status Moderately Or Severely Malnourished":
  from
    "Measure Population" QualifyingEncounter,
    ["Observation": "Nutrition Assessment"] NutritionAssessment
    where ( "Nutrition Assessment" contains NutritionAssessment.code as Concept
        and NutritionAssessment.status in { 'final', 'amended', 'corrected' }
        and NutritionAssessment.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
        and ( "Nutrition Assessment Status Finding of Moderately Malnourished" contains NutritionAssessment.value as Concept
            or "Nutrition Assessment Status Finding of Severely Malnourished" contains NutritionAssessment.value as Concept
        )
        and NutritionAssessment.effective.latest ( ) same day as "Last Nutrition Assessment Day During Encounter"(QualifyingEncounter)
    )
    return QualifyingEncounter

define "Encounter with Nutrition Assessment Not or Mildly Malnourished":
  from
    "Measure Population" QualifyingEncounter,
    ["Observation": "Nutrition Assessment"] NutritionAssessment
    where ( "Nutrition Assessment" contains NutritionAssessment.code as Concept
        and NutritionAssessment.status in { 'final', 'amended', 'corrected' }
        and NutritionAssessment.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
        and ( "Nutrition Assessment Status Finding of Well Nourished or Not Malnourished or Mildly Malnourished" contains NutritionAssessment.value as Concept )
        and NutritionAssessment.effective.latest ( ) same day as "Last Nutrition Assessment Day During Encounter"(QualifyingEncounter)
    )
    return QualifyingEncounter

define "Encounter with Malnutrition Diagnosis":
  from
    "Measure Population" QualifyingEncounter,
    ["Condition": "Malnutrition Diagnosis"] MalnutritionDiagnosis
    where "Malnutrition Diagnosis" contains MalnutritionDiagnosis.code as Concept
      and MalnutritionDiagnosis.prevalenceInterval ( ) overlaps QualifyingEncounter.hospitalizationWithObservation ( )
    return QualifyingEncounter

define "Encounter with Nutrition Care Plan":
  from
    "Measure Population" QualifyingEncounter,
    ["Procedure": "Nutrition Care Plan"] NutritionCarePlan
    where "Nutrition Care Plan" contains NutritionCarePlan.code as Concept
      and NutritionCarePlan.status in { 'completed', 'in-progress' }
      and NutritionCarePlan.performed.earliest ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
    return QualifyingEncounter

define function "Measure Observation 1"(MalnutritionRiskScreening Encounter):
  if "Encounter with Malnutrition Risk Screening or with Hospital Dietitian Referral" contains MalnutritionRiskScreening then 1 
    else 0

define function "Measure Observation 2"(NutritionAssessment Encounter):
  if "Encounter with Malnutrition Not At Risk Screening and without Hospital Dietitian Referral" contains NutritionAssessment then 0 
    else if "Encounter with Malnutrition Risk Screening At Risk or with Hospital Dietitian Referral" contains NutritionAssessment then if "Most Recent Encounter with Nutrition Assessment and Identified Status" contains NutritionAssessment then 1 
    else 0 
    else 0

define function "Measure Observation 3"(MalnutritionDiagnosis Encounter):
  if "Encounter with Malnutrition Not At Risk Screening and without Hospital Dietitian Referral" contains MalnutritionDiagnosis then 0 
    else if "Encounter with Malnutrition Risk Screening At Risk or with Hospital Dietitian Referral" contains MalnutritionDiagnosis then if "Encounter with Malnutrition Diagnosis" contains MalnutritionDiagnosis then if "Encounter with Nutrition Assessment Not or Mildly Malnourished" contains MalnutritionDiagnosis then 0 
    else if "Encounter with Nutrition Assessment Status Moderately Or Severely Malnourished" contains MalnutritionDiagnosis then 1 
    else 0 
    else 0 
    else 0

define function "Measure Observation 4"(NutritionCarePlan Encounter):
  if "Encounter with Malnutrition Not At Risk Screening and without Hospital Dietitian Referral" contains NutritionCarePlan then 0 
    else if "Encounter with Malnutrition Risk Screening At Risk or with Hospital Dietitian Referral" contains NutritionCarePlan then if "Encounter with Nutrition Care Plan" contains NutritionCarePlan then if "Encounter with Nutrition Assessment Not or Mildly Malnourished" contains NutritionCarePlan then 0 
    else if "Encounter with Nutrition Assessment Status Moderately Or Severely Malnourished" contains NutritionCarePlan then 1 
    else 0 
    else 0 
    else 0

define function "Total Malnutrition Care Score Eligible Occurrences"(QualifyingEncounter Encounter):
  if ( ( "Encounter with Malnutrition Risk Screening or with Hospital Dietitian Referral" contains QualifyingEncounter )
      and ( "Encounter with Malnutrition Risk Screening Not At Risk" contains QualifyingEncounter )
  )
    and not ( "Encounter with Dietitian Referral" contains QualifyingEncounter ) then 1 
    else if ( ( ( "Encounter with Malnutrition Risk Screening or with Hospital Dietitian Referral" contains QualifyingEncounter )
        and ( "Encounter with Malnutrition Risk Screening At Risk" contains QualifyingEncounter )
    )
      or ( "Encounter with Dietitian Referral" contains QualifyingEncounter )
  )
    and ( "Encounter with Nutrition Assessment Not or Mildly Malnourished" contains QualifyingEncounter )
    or not ( "Most Recent Encounter with Nutrition Assessment and Identified Status" contains QualifyingEncounter ) then 2 
    else 4

define function "Measure Observation Total Malnutrition Components Score"(QualifyingEncounter Encounter):
  Sum({ "Measure Observation 1"(QualifyingEncounter), "Measure Observation 2"(QualifyingEncounter), "Measure Observation 3"(QualifyingEncounter), "Measure Observation 4"(QualifyingEncounter) })

define function "Measure Observation Total Malnutrition Care Score as Percentage"(QualifyingEncounter Encounter):
  100 * ( "Measure Observation Total Malnutrition Components Score"(QualifyingEncounter) / "Total Malnutrition Care Score Eligible Occurrences"(QualifyingEncounter) )