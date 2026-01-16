library CMS771FHIRUrinarySymptomScoreBPH version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "LOINC": 'http://loinc.org'
codesystem "ICD10CM": 'http://hl7.org/fhir/sid/icd-10-cm'
codesystem "ActCode": 'http://terminology.hl7.org/CodeSystem/v3-ActCode'

valueset "Hospital Services for Urology Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.360'
valueset "Morbid Obesity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.368'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Urinary Retention": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.372'

code "American Urological Association Symptom Index [AUASI]": '80883-2' from "LOINC" display 'American Urological Association Symptom Index [AUASI]'
code "Benign prostatic hyperplasia with lower urinary tract symptoms": 'N40.1' from "ICD10CM" display 'Benign prostatic hyperplasia with lower urinary tract symptoms'
code "If you were to spend the rest of your life with your urinary condition just the way it is now, how would you feel about that [IPSS]": '81090-3' from "LOINC" display 'If you were to spend the rest of your life with your urinary condition just the way it is now, how would you feel about that [IPSS]'
code "International Prostate Symptom Score [IPSS]": '80976-4' from "LOINC" display 'International Prostate Symptom Score [IPSS]'
code "virtual": 'VR' from "ActCode" display 'virtual'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
  ( "Patient is Male" )
    and "Has Qualifying Encounter"
    and "Has Qualifying BPH Diagnosis"

define "Denominator":
  "Initial Population"
    and "Urinary Symptom Score Within 1 Month After Initial BPH Diagnosis" is not null
    and "Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis" is not null

define "Denominator Exclusions":
  exists ( "Urinary Retention Diagnosis Starts Within 1 Year After Initial BPH Diagnosis" )
    or ( "Has Initial BPH Diagnosis Starts During or Within 30 Days After End of Hospitalization" is not null )
    or ( "Morbid Obesity Diagnosis or BMI Exam Result Greater Than or Equal to 40 Starts On or Before Follow Up USS Assessment" )

define "Numerator":
  "Urinary Symptom Score Improvement Greater Than or Equal To 3"

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Has Qualifying BPH Diagnosis":
  "Initial BPH Diagnosis Starts Within 6 Months Before the Measurement Period" is not null

define "Patient is Male":
  SDE."SDE Sex" ~ SDE."Male (finding)"

define "Urinary Symptom Score Assessment":
  "Documented IPSS Assessment Result"
    union "AUA Symptom Index and Quality of Life Assessment Result"

define "Urinary Symptom Score Change":
  from
    "Urinary Symptom Score Within 1 Month After Initial BPH Diagnosis" FirstUSSAssessment,
    "Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis" FollowUpUSSAssessment
    let USSChange: ( FirstUSSAssessment.valueInteger ) - ( FollowUpUSSAssessment.valueInteger )
    return USSChange

define "Urinary Symptom Score Improvement Greater Than or Equal To 3":
  ( "Urinary Symptom Score Change" USSImprovement
      where USSImprovement >= 3
  ) is not null

define "Documented IPSS Assessment Result":
  [ObservationScreeningAssessment: "International Prostate Symptom Score [IPSS]"] IPSSAssessment
    where IPSSAssessment.status in { 'final', 'amended', 'corrected' }
      and IPSSAssessment.value is not null
    return {
      effectiveDatetime: IPSSAssessment.effective.earliest ( ),
      valueInteger: IPSSAssessment.value as Integer
    }

define "AUA Symptom Index and Quality of Life Assessment Result":
  [ObservationScreeningAssessment: "American Urological Association Symptom Index [AUASI]"] AUASIAssessment
    let LastQOLOnDate: Last([ObservationScreeningAssessment: "If you were to spend the rest of your life with your urinary condition just the way it is now, how would you feel about that [IPSS]"] QOLAssessment
        where QOLAssessment.effective.earliest() same day as AUASIAssessment.effective.earliest()
          and QOLAssessment.status in { 'final', 'amended', 'corrected' }
          and QOLAssessment.value is not null
        sort by effective.earliest()
    )
    where AUASIAssessment.status in { 'final', 'amended', 'corrected' }
      and AUASIAssessment.value is not null
    return {
      effectiveDatetime: AUASIAssessment.effective.earliest ( ),
      valueInteger: ( AUASIAssessment.value as Integer ) + ( LastQOLOnDate.value as Integer )
    }

define "Has Qualifying Encounter":
  exists ( [Encounter: "Office Visit"] ValidEncounter
      where ValidEncounter.period during day of "Measurement Period"
        and ValidEncounter.class !~ "virtual"
        and ValidEncounter.status = 'finished'
  )

define "Morbid Obesity Diagnosis or BMI Exam Result Greater Than or Equal to 40 Starts On or Before Follow Up USS Assessment":
  exists "Morbid Obesity Diagnosis On or Before Follow Up USS Assessment"
    or "BMI Exam Result Greater Than or Equal To 40 During Measurement Period and On or Before Follow Up USS Assessment"

define "Urinary Retention Diagnosis Starts Within 1 Year After Initial BPH Diagnosis":
  ( [ConditionProblemsHealthConcerns: "Urinary Retention"]
    union [ConditionEncounterDiagnosis: "Urinary Retention"] ) UrinaryRetention
    with "Initial BPH Diagnosis Starts Within 6 Months Before the Measurement Period" InitialBPHDiagnosis
      such that UrinaryRetention.prevalenceInterval ( ) starts 1 year or less on or after day of start of InitialBPHDiagnosis.prevalenceInterval ( )
    where UrinaryRetention.verificationStatusIsNotInvalid ( )

define "Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis":
  Last("Urinary Symptom Score Assessment" USSAssessment
      with "Initial BPH Diagnosis Starts Within 6 Months Before the Measurement Period" InitialBPHDiagnosis
        such that difference in months between start of InitialBPHDiagnosis.prevalenceInterval() and USSAssessment.effectiveDatetime in Interval[6, 12]
      sort by effectiveDatetime
  )

define "Urinary Symptom Score Within 1 Month After Initial BPH Diagnosis":
  First("Urinary Symptom Score Assessment" USSAssessment
      with "Initial BPH Diagnosis Starts Within 6 Months Before the Measurement Period" InitialBPHDiagnosis
        such that USSAssessment.effectiveDatetime 1 month or less on or after day of start of InitialBPHDiagnosis.prevalenceInterval()
      sort by effectiveDatetime
  )

define "Has Initial BPH Diagnosis Starts During or Within 30 Days After End of Hospitalization":
  "Initial BPH Diagnosis Starts Within 6 Months Before the Measurement Period" InitialBPHDiagnosis
    with [Encounter: "Hospital Services for Urology Care"] UrologyHospitalServices
      such that InitialBPHDiagnosis.prevalenceInterval ( ) starts during Interval[start of UrologyHospitalServices.period, end of UrologyHospitalServices.period + 31 days]
        and UrologyHospitalServices.status = 'finished'

define "Initial BPH Diagnosis Starts Within 6 Months Before the Measurement Period":
  First(([ConditionProblemsHealthConcerns: "Benign prostatic hyperplasia with lower urinary tract symptoms"]
      union [ConditionEncounterDiagnosis: "Benign prostatic hyperplasia with lower urinary tract symptoms"]) NewBPHDiagnosis
      where NewBPHDiagnosis.prevalenceInterval() starts during Interval[start of "Measurement Period" - 6 months, start of "Measurement Period"]
        and NewBPHDiagnosis.verificationStatusIsNotInvalid()
      sort by start of onset.toInterval()
  )

define "Morbid Obesity Diagnosis On or Before Follow Up USS Assessment":
  ( [ConditionProblemsHealthConcerns: "Morbid Obesity"]
    union [ConditionEncounterDiagnosis: "Morbid Obesity"] ) MorbidObesityDiagnosis
    with "Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis" FollowUpUSSAssessment
      such that MorbidObesityDiagnosis.prevalenceInterval ( ) overlaps "Measurement Period"
        and MorbidObesityDiagnosis.prevalenceInterval ( ) starts on or before FollowUpUSSAssessment.effectiveDatetime
    where MorbidObesityDiagnosis.verificationStatusIsNotInvalid ( )  
  
/*
* @code: Body mass index (BMI) [Ratio] - 39156-5
* @profile: http://hl7.org/fhir/StructureDefinition/bmi
*/


define "BMI Exam Result Greater Than or Equal To 40 During Measurement Period and On or Before Follow Up USS Assessment":
  exists ( ["USCoreBMIProfile"] BMIExam
      with "Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis" FollowUpUSSAssessment
        such that BMIExam.value >= 40 'kg/m2'
          and BMIExam.status in { 'final', 'amended', 'corrected' }
          and BMIExam.effective.earliest ( ) during day of "Measurement Period"
          and BMIExam.effective.earliest ( ) on or before FollowUpUSSAssessment.effectiveDatetime
      return BMIExam.effective.earliest ( )
  )

define fluent function verificationStatusIsNotInvalid(condition Choice<"ConditionEncounterDiagnosis", "ConditionProblemsHealthConcerns">):
  condition.verificationStatus is null
    or not ( condition.verificationStatus ~ QICoreCommon."unconfirmed"
        or condition.verificationStatus ~ QICoreCommon."refuted"
        or condition.verificationStatus ~ QICoreCommon."entered-in-error"
    )