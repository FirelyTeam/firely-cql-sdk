library CMS986FHIRMalnutritionScore version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon
include CQMCommon version '4.1.000' called CQMCommon
include Status version '1.15.000' called Status

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

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

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
  "Encounters with Discharge for Hospice Care"
    union "Encounters with Hospice during Eligible Encounter"

define "Encounters with Discharge for Hospice Care":
  "Measure Population" QualifyingEncounter
    where QualifyingEncounter.hospitalization.dischargeDisposition in "Hospice Care Referral or Admission"

/*define "Intervention Hospice Care":
    ( ["ServiceRequest": "Hospice Status"] HospiceStatusOrder
    where HospiceStatusOrder.status in { 'active', 'completed', 'on-hold' }
        and HospiceStatusOrder.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
  )
    union ( ["Procedure": "Hospice Status"] HospiceStatusPerformed
            where HospiceStatusPerformed.status in { 'completed', 'in-progress' } 
           )

define "Encounters with Hospice during Eligible Encounter":
    "Measure Population" QualifyingEncounter
    with "Intervention Hospice Care" HospiceStatus
            such that Coalesce (start of HospiceStatus.performed.toInterval(), HospiceStatus.authoredOn) during day of QualifyingEncounter.hospitalizationWithObservation ( )
*/
//Testing definitions based on Codev comment



define "Intervention Hospice Care":
  ( ["ServiceRequest": "Hospice Status"] HospiceStatusOrder
      where HospiceStatusOrder.status in { 'active', 'completed', 'on-hold' }
        and HospiceStatusOrder.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
      return HospiceStatusOrder.authoredOn
  )
    union ( ["Procedure": "Hospice Status"] HospiceStatusPerformed
        where HospiceStatusPerformed.status in { 'completed', 'in-progress' }
        return start of HospiceStatusPerformed.performed.toInterval ( )
    )

define "Encounters with Hospice during Eligible Encounter":
  "Measure Population" QualifyingEncounter
    with "Intervention Hospice Care" HospiceStatusDate
      such that HospiceStatusDate during day of QualifyingEncounter.hospitalizationWithObservation ( )

/*define "Intervention Dietitian Referral":
( ["ServiceRequest": "Dietitian Referral"] DietitianReferralOrder
    where DietitianReferralOrder.status in { 'active', 'completed', 'on-hold' }
        and DietitianReferralOrder.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
  
  )
    union ( ["Procedure": "Dietitian Referral"] DietitianReferralPerformed
            where DietitianReferralPerformed.status in { 'completed', 'in-progress' } 
           )

define "Encounters with Dietitian Referral":
    "Measure Population" QualifyingEncounter
    with "Intervention Dietitian Referral" DietitianReferral
            such that Coalesce (start of DietitianReferral.performed.toInterval(), DietitianReferral.authoredOn) during day of QualifyingEncounter.hospitalizationWithObservation ( )
*/
//New definition from Codev comments



define "Intervention Dietitian Referral":
  ( ["ServiceRequest": "Dietitian Referral"] DietitianReferralOrder
      where DietitianReferralOrder.status in { 'active', 'completed', 'on-hold' }
        and DietitianReferralOrder.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
      return DietitianReferralOrder.authoredOn
  )
    union ( ["Procedure": "Dietitian Referral"] DietitianReferralPerformed
        where DietitianReferralPerformed.status in { 'completed', 'in-progress' }
        return start of DietitianReferralPerformed.performed.toInterval ( )
    )

define "Encounters with Dietitian Referral":
  "Measure Population" QualifyingEncounter
    with "Intervention Dietitian Referral" DietitianReferralDate
      such that DietitianReferralDate during day of QualifyingEncounter.hospitalizationWithObservation ( )

define "Encounters with Malnutrition Risk Screening":
  "Encounters with Malnutrition Risk Screening Not At Risk"
    union "Encounters with Malnutrition Risk Screening At Risk"

define "Encounters with Malnutrition Risk Screening or with Dietitian Referral":
  "Encounters with Malnutrition Risk Screening"
    union "Encounters with Dietitian Referral"

define "Encounters with Malnutrition Risk Screening Not At Risk":
  "Measure Population" QualifyingEncounter
    with ["ObservationScreeningAssessment": "Malnutrition Risk Screening"] MalnutritionRiskScreening
      such that MalnutritionRiskScreening.status in { 'final', 'amended', 'corrected' }
        and MalnutritionRiskScreening.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
        and ( MalnutritionRiskScreening.value as Concept in "Malnutrition Screening Finding of Not At Risk Result" )

define "Encounters with Malnutrition Not At Risk Screening and without Dietitian Referral":
  "Encounters with Malnutrition Risk Screening Not At Risk"
    except "Encounters with Dietitian Referral"

define "Encounters with Malnutrition Risk Screening At Risk":
  "Measure Population" QualifyingEncounter
    with ["ObservationScreeningAssessment": "Malnutrition Risk Screening"] MalnutritionRiskScreening
      such that MalnutritionRiskScreening.status in { 'final', 'amended', 'corrected' }
        and MalnutritionRiskScreening.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
        and ( MalnutritionRiskScreening.value as Concept in "Malnutrition Screening Finding of At Risk Result" )

define "Encounters with Malnutrition Risk Screening At Risk or with Dietitian Referral":
  "Encounters with Malnutrition Risk Screening At Risk"
    union "Encounters with Dietitian Referral"
   

/*define function "Last Nutrition Assessment Day During Encounter"(QualifyingEncounter Encounter):
  Max("Nutrition Assessment Performed" NutritionAssessmentTuple
    where NutritionAssessmentTuple.HospEncId = QualifyingEncounter.id
    return NutritionAssessmentTuple.NutrAssessTimingLatest
  )

define "Nutrition Assessment Performed":
    from
    "Measure Population" QualifyingEncounter,
    ["ObservationScreeningAssessment": "Nutrition Assessment"] NutritionAssessment
        where NutritionAssessment.status in { 'final', 'amended', 'corrected' }
            and NutritionAssessment.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
            and NutritionAssessment.value is not null
            return Tuple {
        HospEncId: QualifyingEncounter.id,
        NutrAssessTimingLatest: NutritionAssessment.effective.latest()
        }
*/
//Test definition per CODev feedback



define function "Last Nutrition Assessment Day During Encounter"(QualifyingEncounter Encounter):
  Max(["ObservationScreeningAssessment": "Nutrition Assessment"] NutritionAssessment
      where NutritionAssessment.status in { 'final', 'amended', 'corrected' }
        and NutritionAssessment.effective.toInterval() during QualifyingEncounter.hospitalizationWithObservation()
        and NutritionAssessment.value is not null
      return NutritionAssessment.effective.latest()
  )

define "Encounter With Most Recent Nutrition Assessment And Identified Status":
  "Encounters with Malnutrition Risk Screening At Risk or with Dietitian Referral" QualifyingEncounter
    with ["ObservationScreeningAssessment": "Nutrition Assessment"] NutritionAssessment
      such that ( NutritionAssessment.status in { 'final', 'amended', 'corrected' }
          and NutritionAssessment.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
          and ( NutritionAssessment.value as Concept in "Nutrition Assessment Status Finding of Well Nourished or Not Malnourished or Mildly Malnourished"
              or ( NutritionAssessment.value as Concept in "Nutrition Assessment Status Finding of Moderately Malnourished" )
              or ( NutritionAssessment.value as Concept in "Nutrition Assessment Status Finding of Severely Malnourished" )
          )
          and NutritionAssessment.effective.latest ( ) same day as "Last Nutrition Assessment Day During Encounter"(QualifyingEncounter)
      )

define "Encounter With Most Recent Nutrition Assessment Status of Moderately Or Severely Malnourished":
  "Measure Population" QualifyingEncounter
    with ["ObservationScreeningAssessment": "Nutrition Assessment"] NutritionAssessment
      such that NutritionAssessment.status in { 'final', 'amended', 'corrected' }
        and NutritionAssessment.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
        and ( NutritionAssessment.value as Concept in "Nutrition Assessment Status Finding of Moderately Malnourished"
            or NutritionAssessment.value as Concept in "Nutrition Assessment Status Finding of Severely Malnourished"
        )
        and NutritionAssessment.effective.latest ( ) same day as "Last Nutrition Assessment Day During Encounter"(QualifyingEncounter)

define "Encounter With Most Recent Nutrition Assessment Status of Not or Mildly Malnourished":
  "Measure Population" QualifyingEncounter
    with ["ObservationScreeningAssessment": "Nutrition Assessment"] NutritionAssessment
      such that ( NutritionAssessment.status in { 'final', 'amended', 'corrected' }
          and NutritionAssessment.effective.toInterval ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
          and ( NutritionAssessment.value as Concept in "Nutrition Assessment Status Finding of Well Nourished or Not Malnourished or Mildly Malnourished" )
          and NutritionAssessment.effective.latest ( ) same day as "Last Nutrition Assessment Day During Encounter"(QualifyingEncounter)
      )

define "Encounters with Malnutrition Diagnosis":
  ( "Measure Population" QualifyingEncounter
      where exists ( "Has Malnutrition Diagnosis" MalnutritionDiagnosis
          where MalnutritionDiagnosis.prevalenceInterval ( ) overlaps day of QualifyingEncounter.hospitalizationWithObservation ( )
      )
  )
    union "Encounters With Encounter Diagnosis Of Malnutrition Diagnosis"

define "Has Malnutrition Diagnosis":
  [ConditionProblemsHealthConcerns: "Malnutrition Diagnosis"] MalnutritionDiagnosis
    where MalnutritionDiagnosis.prevalenceInterval ( ) overlaps "Measurement Period"
      and MalnutritionDiagnosis.isVerified ( )

define "Encounters With Encounter Diagnosis Of Malnutrition Diagnosis":
  "Measure Population" QualifyingEncounter
    where QualifyingEncounter.reasonCode in "Malnutrition Diagnosis"
      or QualifyingEncounter.encounterDiagnosis ( ).verified ( ).code in "Malnutrition Diagnosis"

define fluent function isVerified(condition Choice<QICore.ConditionProblemsHealthConcerns, QICore.ConditionEncounterDiagnosis>):
  condition.verificationStatus is not null implies ( condition.verificationStatus ~ QICoreCommon."confirmed"
      or condition.verificationStatus ~ QICoreCommon."unconfirmed"
      or condition.verificationStatus ~ QICoreCommon."provisional"
      or condition.verificationStatus ~ QICoreCommon."differential"
  )

define "Encounters with Nutrition Care Plan":
  "Measure Population" QualifyingEncounter
    with ["Procedure": "Nutrition Care Plan"] NutritionCarePlan
      such that NutritionCarePlan.status in { 'completed', 'in-progress' }
        and NutritionCarePlan.performed.earliest ( ) during QualifyingEncounter.hospitalizationWithObservation ( )

define function "Measure Observation 1"(MalnutritionRiskScreening Encounter):
  if "Encounters with Malnutrition Risk Screening or with Dietitian Referral" contains MalnutritionRiskScreening then 1 
    else 0

define function "Measure Observation 2"(NutritionAssessment Encounter):
  if "Encounters with Malnutrition Not At Risk Screening and without Dietitian Referral" contains NutritionAssessment then 0 
    else if "Encounters with Malnutrition Risk Screening At Risk or with Dietitian Referral" contains NutritionAssessment then if "Encounter With Most Recent Nutrition Assessment And Identified Status" contains NutritionAssessment then 1 
    else 0 
    else 0

define function "Measure Observation 3"(MalnutritionDiagnosis Encounter):
  if "Encounters with Malnutrition Not At Risk Screening and without Dietitian Referral" contains MalnutritionDiagnosis then 0 
    else if "Encounters with Malnutrition Risk Screening At Risk or with Dietitian Referral" contains MalnutritionDiagnosis then if "Encounters with Malnutrition Diagnosis" contains MalnutritionDiagnosis then if "Encounter With Most Recent Nutrition Assessment Status of Not or Mildly Malnourished" contains MalnutritionDiagnosis then 0 
    else if "Encounter With Most Recent Nutrition Assessment Status of Moderately Or Severely Malnourished" contains MalnutritionDiagnosis then 1 
    else 0 
    else 0 
    else 0

define function "Measure Observation 4"(NutritionCarePlan Encounter):
  if "Encounters with Malnutrition Not At Risk Screening and without Dietitian Referral" contains NutritionCarePlan then 0 
    else if "Encounters with Malnutrition Risk Screening At Risk or with Dietitian Referral" contains NutritionCarePlan then if "Encounters with Nutrition Care Plan" contains NutritionCarePlan then if "Encounter With Most Recent Nutrition Assessment Status of Not or Mildly Malnourished" contains NutritionCarePlan then 0 
    else if "Encounter With Most Recent Nutrition Assessment Status of Moderately Or Severely Malnourished" contains NutritionCarePlan then 1 
    else 0 
    else 0 
    else 0

define function "Total Malnutrition Care Score Eligible Occurrences"(QualifyingEncounter Encounter):
  if "Encounters with Malnutrition Risk Screening or with Dietitian Referral" contains QualifyingEncounter
    and "Encounters with Malnutrition Risk Screening Not At Risk" contains QualifyingEncounter
    and not ( "Encounters with Dietitian Referral" contains QualifyingEncounter ) then 1 
    else if ( "Encounters with Malnutrition Risk Screening or with Dietitian Referral" contains QualifyingEncounter
      and "Encounters with Malnutrition Risk Screening At Risk" contains QualifyingEncounter
      or "Encounters with Dietitian Referral" contains QualifyingEncounter
  )
    and "Encounter With Most Recent Nutrition Assessment Status of Not or Mildly Malnourished" contains QualifyingEncounter
    or not ( "Encounter With Most Recent Nutrition Assessment And Identified Status" contains QualifyingEncounter ) then 2 
    else 4

define function "Measure Observation Total Malnutrition Components Score"(QualifyingEncounter Encounter):
  Sum({ "Measure Observation 1"(QualifyingEncounter), "Measure Observation 2"(QualifyingEncounter), "Measure Observation 3"(QualifyingEncounter), "Measure Observation 4"(QualifyingEncounter) })

define function "Measure Observation Total Malnutrition Care Score as Percentage"(QualifyingEncounter Encounter):
  100 * ( "Measure Observation Total Malnutrition Components Score"(QualifyingEncounter) / "Total Malnutrition Care Score Eligible Occurrences"(QualifyingEncounter) )