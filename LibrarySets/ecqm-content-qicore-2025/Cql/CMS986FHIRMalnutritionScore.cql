library CMS986FHIRMalnutritionScore version '0.3.003'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon
include CQMCommon version '4.1.000' called CQMCommon

codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "ICD10CM": 'http://hl7.org/fhir/sid/icd-10-cm'

valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Hospice Status": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.101'
valueset "Hospice Care Referral or Admission": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365'
valueset "Dietitian Referral": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1095.91'
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

code "Birth date": '21112-8' from "LOINC" display 'Birth date'

parameter "Measurement Period" Interval<DateTime>

context Patient

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer Type":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Measure Population":
  "Initial Population"

define "Initial Population":
  [Encounter: "Encounter Inpatient"] EncounterInpatient
    where EncounterInpatient.period ends during day of "Measurement Period"
      and AgeInYearsAt(date from start of EncounterInpatient.period) >= 18
      and ( duration in hours of EncounterInpatient.period >= 24 )
      and EncounterInpatient.status = 'finished'

define "Measure Population Exclusion":
  "Encounter with Discharge for Hospice Care"
    union "Encounter with Hospice during Eligible Encounter"

define "Encounter with Discharge for Hospice Care":
  "Measure Population" QualifyingEncounter
    where QualifyingEncounter.hospitalization.dischargeDisposition in "Hospice Care Referral or Admission"

define "Intervention Hospice Care":
  ( ["ServiceRequest": code in "Hospice Status"] HospiceStatusOrder
      where HospiceStatusOrder.status in { 'active', 'completed', 'on-hold' }
        and HospiceStatusOrder.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
        and HospiceStatusOrder.doNotPerform is not true
  )
    union ( ["Procedure": "Hospice Status"] HospiceStatusPerformed
        where HospiceStatusPerformed.status in { 'completed', 'in-progress' }
    )

define "Encounter with Hospice during Eligible Encounter":
  "Measure Population" QualifyingEncounter
    with "Intervention Hospice Care" HospiceStatus
      such that Coalesce(start of HospiceStatus.performed.toInterval(), HospiceStatus.authoredOn) during day of QualifyingEncounter.hospitalizationWithObservation ( )

define "Intervention Dietitian Referral":
  ( ["ServiceRequest": code in "Dietitian Referral"] DietitianReferralOrder
      where DietitianReferralOrder.status in { 'active', 'completed', 'on-hold' }
        and DietitianReferralOrder.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
        and DietitianReferralOrder.doNotPerform is not true
  )
    union ( ["Procedure": "Dietitian Referral"] DietitianReferralPerformed
        where DietitianReferralPerformed.status in { 'completed', 'in-progress' }
    )

define "Encounter with Dietitian Referral":
  "Measure Population" QualifyingEncounter
    with "Intervention Dietitian Referral" DietitianReferral
      such that Coalesce(start of DietitianReferral.performed.toInterval(), DietitianReferral.authoredOn) during day of QualifyingEncounter.hospitalizationWithObservation ( )

define "Encounter with Malnutrition Risk Screening":
  "Measure Population" QualifyingEncounter
    with ["ObservationScreeningAssessment": "Malnutrition Risk Screening"] MalnutritionRiskScreening
      such that ( MalnutritionRiskScreening.status in { 'final', 'amended', 'corrected' }
          and MalnutritionRiskScreening.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
          and ( MalnutritionRiskScreening.value as Concept in "Malnutrition Screening Finding of Not At Risk Result"
              or MalnutritionRiskScreening.value as Concept in "Malnutrition Screening Finding of At Risk Result"
          )
      )
    return QualifyingEncounter

define "Encounter with Malnutrition Risk Screening or with Dietitian Referral":
  "Measure Population" QualifyingEncounter
    where ( "Encounter with Malnutrition Risk Screening" contains QualifyingEncounter
        or "Encounter with Dietitian Referral" contains QualifyingEncounter
    )
    return QualifyingEncounter

define "Encounter with Malnutrition Risk Screening Not At Risk":
  "Measure Population" QualifyingEncounter
    with ["ObservationScreeningAssessment": "Malnutrition Risk Screening"] MalnutritionRiskScreening
      such that MalnutritionRiskScreening.status in { 'final', 'amended', 'corrected' }
        and MalnutritionRiskScreening.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
        and ( MalnutritionRiskScreening.value as Concept in "Malnutrition Screening Finding of Not At Risk Result" )
    return QualifyingEncounter

define "Encounter with Malnutrition Not At Risk Screening and without Dietitian Referral":
  "Measure Population" QualifyingEncounter
    where "Encounter with Malnutrition Risk Screening Not At Risk" contains QualifyingEncounter
      and not exists ( "Encounter with Dietitian Referral" )
    return QualifyingEncounter

define "Encounter with Malnutrition Risk Screening At Risk":
  "Measure Population" QualifyingEncounter
    with ["ObservationScreeningAssessment": "Malnutrition Risk Screening"] MalnutritionRiskScreening
      such that MalnutritionRiskScreening.status in { 'final', 'amended', 'corrected' }
        and MalnutritionRiskScreening.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
        and ( MalnutritionRiskScreening.value as Concept in "Malnutrition Screening Finding of At Risk Result" )
    return QualifyingEncounter

define "Encounter with Malnutrition Risk Screening At Risk or with Dietitian Referral":
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
    ["ObservationScreeningAssessment": "Nutrition Assessment"] NutritionAssessment
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

define "Encounter With Most Recent Nutrition Assessment And Identified Status":
  "Measure Population" QualifyingEncounter
    with ["ObservationScreeningAssessment": "Nutrition Assessment"] NutritionAssessment
      such that ( NutritionAssessment.status in { 'final', 'amended', 'corrected' }
          and NutritionAssessment.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
          and ( NutritionAssessment.value as Concept in "Nutrition Assessment Status Finding of Well Nourished or Not Malnourished or Mildly Malnourished"
              or ( NutritionAssessment.value as Concept in "Nutrition Assessment Status Finding of Moderately Malnourished" )
              or ( NutritionAssessment.value as Concept in "Nutrition Assessment Status Finding of Severely Malnourished" )
          )
          and ( exists ( "Encounter with Malnutrition Risk Screening At Risk" )
              or exists ( "Encounter with Dietitian Referral" )
          )
          and NutritionAssessment.effective.latest ( ) same day as "Last Nutrition Assessment Day During Encounter"(QualifyingEncounter)
      )
    return QualifyingEncounter

define "Encounter With Most Recent Nutrition Assessment Status of Moderately Or Severely Malnourished":
  "Measure Population" QualifyingEncounter
    with ["ObservationScreeningAssessment": "Nutrition Assessment"] NutritionAssessment
      such that NutritionAssessment.status in { 'final', 'amended', 'corrected' }
        and NutritionAssessment.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
        and ( NutritionAssessment.value as Concept in "Nutrition Assessment Status Finding of Moderately Malnourished"
            or NutritionAssessment.value as Concept in "Nutrition Assessment Status Finding of Severely Malnourished"
        )
        and NutritionAssessment.effective.latest ( ) same day as "Last Nutrition Assessment Day During Encounter"(QualifyingEncounter)
    return QualifyingEncounter

define "Encounter With Most Recent Nutrition Assessment Status of Not or Mildly Malnourished":
  "Measure Population" QualifyingEncounter
    with ["ObservationScreeningAssessment": "Nutrition Assessment"] NutritionAssessment
      such that ( NutritionAssessment.status in { 'final', 'amended', 'corrected' }
          and NutritionAssessment.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
          and ( NutritionAssessment.value as Concept in "Nutrition Assessment Status Finding of Well Nourished or Not Malnourished or Mildly Malnourished" )
          and NutritionAssessment.effective.latest ( ) same day as "Last Nutrition Assessment Day During Encounter"(QualifyingEncounter)
      )
    return QualifyingEncounter

define "Encounter with Malnutrition Diagnosis":
  "Measure Population" QualifyingEncounter
    where exists ( "Has Malnutrition Diagnosis" MalnutritionDiagnosis
        where MalnutritionDiagnosis.prevalenceInterval ( ) overlaps day of QualifyingEncounter.hospitalizationWithObservation ( )
    )
      or exists "Encounter With Encounter Diagnosis Of Malnutrition Diagnosis"

define "Has Malnutrition Diagnosis":
  [ConditionProblemsHealthConcerns: "Malnutrition Diagnosis"] MalnutritionDiagnosis
    where MalnutritionDiagnosis.prevalenceInterval ( ) overlaps "Measurement Period"

define "Encounter With Encounter Diagnosis Of Malnutrition Diagnosis":
  "Measure Population" QualifyingEncounter
    where QualifyingEncounter.reasonCode in "Malnutrition Diagnosis"
      or exists ( [ConditionEncounterDiagnosis: "Malnutrition Diagnosis"] EncounterDiagnosis
          where QualifyingEncounter.reasonReference.references ( EncounterDiagnosis )
      )

define "Encounter with Nutrition Care Plan":
  "Measure Population" QualifyingEncounter
    with ["Procedure": "Nutrition Care Plan"] NutritionCarePlan
      such that NutritionCarePlan.status in { 'completed', 'in-progress' }
        and NutritionCarePlan.performed.earliest ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
    return QualifyingEncounter

define function "Measure Observation 1"(MalnutritionRiskScreening Encounter):
  if "Encounter with Malnutrition Risk Screening or with Dietitian Referral" contains MalnutritionRiskScreening then 1 
    else 0

define function "Measure Observation 2"(NutritionAssessment Encounter):
  if "Encounter with Malnutrition Not At Risk Screening and without Dietitian Referral" contains NutritionAssessment then 0 
    else if "Encounter with Malnutrition Risk Screening At Risk or with Dietitian Referral" contains NutritionAssessment then if "Encounter With Most Recent Nutrition Assessment And Identified Status" contains NutritionAssessment then 1 
    else 0 
    else 0

define function "Measure Observation 3"(MalnutritionDiagnosis Encounter):
  if "Encounter with Malnutrition Not At Risk Screening and without Dietitian Referral" contains MalnutritionDiagnosis then 0 
    else if "Encounter with Malnutrition Risk Screening At Risk or with Dietitian Referral" contains MalnutritionDiagnosis then if "Encounter with Malnutrition Diagnosis" contains MalnutritionDiagnosis then if "Encounter With Most Recent Nutrition Assessment Status of Not or Mildly Malnourished" contains MalnutritionDiagnosis then 0 
    else if "Encounter With Most Recent Nutrition Assessment Status of Moderately Or Severely Malnourished" contains MalnutritionDiagnosis then 1 
    else 0 
    else 0 
    else 0

define function "Measure Observation 4"(NutritionCarePlan Encounter):
  if "Encounter with Malnutrition Not At Risk Screening and without Dietitian Referral" contains NutritionCarePlan then 0 
    else if "Encounter with Malnutrition Risk Screening At Risk or with Dietitian Referral" contains NutritionCarePlan then if "Encounter with Nutrition Care Plan" contains NutritionCarePlan then if "Encounter With Most Recent Nutrition Assessment Status of Not or Mildly Malnourished" contains NutritionCarePlan then 0 
    else if "Encounter With Most Recent Nutrition Assessment Status of Moderately Or Severely Malnourished" contains NutritionCarePlan then 1 
    else 0 
    else 0 
    else 0

define function "Total Malnutrition Care Score Eligible Occurrences"(QualifyingEncounter Encounter):
  if ( ( "Encounter with Malnutrition Risk Screening or with Dietitian Referral" contains QualifyingEncounter )
      and ( "Encounter with Malnutrition Risk Screening Not At Risk" contains QualifyingEncounter )
  )
    and not ( "Encounter with Dietitian Referral" contains QualifyingEncounter ) then 1 
    else if ( ( ( "Encounter with Malnutrition Risk Screening or with Dietitian Referral" contains QualifyingEncounter )
        and ( "Encounter with Malnutrition Risk Screening At Risk" contains QualifyingEncounter )
    )
      or ( "Encounter with Dietitian Referral" contains QualifyingEncounter )
  )
    and ( "Encounter With Most Recent Nutrition Assessment Status of Not or Mildly Malnourished" contains QualifyingEncounter )
    or not ( "Encounter With Most Recent Nutrition Assessment And Identified Status" contains QualifyingEncounter ) then 2 
    else 4

define function "Measure Observation Total Malnutrition Components Score"(QualifyingEncounter Encounter):
  Sum({ "Measure Observation 1"(QualifyingEncounter), "Measure Observation 2"(QualifyingEncounter), "Measure Observation 3"(QualifyingEncounter), "Measure Observation 4"(QualifyingEncounter) })

define function "Measure Observation Total Malnutrition Care Score as Percentage"(QualifyingEncounter Encounter):
  100 * ( "Measure Observation Total Malnutrition Components Score"(QualifyingEncounter) / "Total Malnutrition Care Score Eligible Occurrences"(QualifyingEncounter) )