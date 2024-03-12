library UrinarySymptomScoreChangeAfterBenignProstaticHyperplasiaFHIR version '1.3.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include QICoreCommon version '2.0.000' called QICoreCommon

codesystem "LOINC": 'http://loinc.org'
codesystem "ICD10CM": 'http://hl7.org/fhir/sid/icd-10-cm'
codesystem "ObservationCategoryCodes": 'http://terminology.hl7.org/CodeSystem/observation-category'
codesystem "ActCode": 'http://terminology.hl7.org/CodeSystem/v3-ActCode'

valueset "Hospital Services for urology care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.64'
valueset "Morbid Obesity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.67'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Urinary retention": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1164.52'

code "American Urological Association Symptom Index [AUASI]": '80883-2' from "LOINC" display 'American Urological Association Symptom Index [AUASI]'
code "Benign prostatic hyperplasia with lower urinary tract symptoms": 'N40.1' from "ICD10CM" display 'Benign prostatic hyperplasia with lower urinary tract symptoms'
code "If you were to spend the rest of your life with your urinary condition just the way it is now, how would you feel about that [IPSS]": '81090-3' from "LOINC" display 'If you were to spend the rest of your life with your urinary condition just the way it is now, how would you feel about that [IPSS]'
code "International Prostate Symptom Score [IPSS]": '80976-4' from "LOINC" display 'International Prostate Symptom Score [IPSS]'
code "survey": 'survey' from "ObservationCategoryCodes" display 'survey'
code "virtual": 'VR' from "ActCode" display 'virtual'

parameter "Measurement Period" Interval<DateTime>default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0 )

context Patient

define "Initial Population":
  "Patient is Male"
    and "Has Qualifying Encounter"
    and "Has Qualifying BPH Diagnosis"
    and "Urinary Symptom Score Within 1 Month after Initial BPH Diagnosis" is not null
    and "Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis" is not null

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  exists ( "Urinary Retention Diagnosis Starts Within 1 Year After Initial BPH Diagnosis" )
    or ( "Initial BPH Diagnosis Starts During or Within 30 Days After End of Hospitalization" is not null )
    or ( "Has Morbid Obesity Diagnosis or BMI Exam Result  Greater Than or Equal to 40 Starts On or Before Follow Up USS Assessment" )

define "Numerator":
  "Has Urinary Symptom Score Improvement Greater Than or Equal To 3"

define "Patient is Male":
  Patient.gender = 'male'

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "AUA Symptom Index and Quality of Life Assessment Result":
  [Observation: "American Urological Association Symptom Index [AUASI]"] AUASIAssessment
    let LastQOLOnDate: Last([Observation: "If you were to spend the rest of your life with your urinary condition just the way it is now, how would you feel about that [IPSS]"] QOLAssessment
        where QOLAssessment.effective.earliest() same day as QOLAssessment.effective.earliest()
          and exists(QOLAssessment.category QOLAssessmentCategory
              where QOLAssessmentCategory ~ "survey"
          )
          and QOLAssessment.status in { 'final', 'amended', 'corrected' }
          and QOLAssessment.value is not null
        sort by effective.earliest()
    )
    where exists ( AUASIAssessment.category AUASIAssessmentCategory
        where AUASIAssessmentCategory ~ "survey"
    )
      and AUASIAssessment.status in { 'final', 'amended', 'corrected' }
      and AUASIAssessment.value is not null
    return {
      effectiveDatetime: AUASIAssessment.effective.earliest ( ),
      valueInteger: ( AUASIAssessment.value as Integer ) + ( LastQOLOnDate.value as Integer )
    }

define "Documented IPSS Assessment Result":
  [Observation: "International Prostate Symptom Score [IPSS]"] IPSSAssessment
    where IPSSAssessment.status in { 'final', 'amended', 'corrected' }
      and IPSSAssessment.value is not null
    return {
      effectiveDatetime: IPSSAssessment.effective.earliest ( ),
      valueInteger: IPSSAssessment.value as Integer
    }

define "Has Qualifying Encounter":
  exists ( [Encounter: "Office Visit"] ValidEncounter
      where ValidEncounter.period during day of "Measurement Period"
        and ValidEncounter.class !~ "virtual"
        and ValidEncounter.status = 'finished'
  )

define "Has BMI Exam Result Greater Than or Equal To 40 During Measurement Period and On or Before Follow Up USS Assessment":
  exists ( ["observation-bmi"] BMIExam
      with "Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis" FollowUpUSSAssessment
        such that BMIExam.value > 40 'kg/m2'
          and BMIExam.status in { 'final', 'amended', 'corrected' }
          and BMIExam.effective.earliest ( ) during day of "Measurement Period"
          and BMIExam.effective.earliest ( ) on or before FollowUpUSSAssessment.effectiveDatetime
      return BMIExam.effective.earliest ( )
  )

define "Initial BPH Diagnosis Starts During or Within 30 Days After End of Hospitalization":
  "Initial BPH Diagnosis Starts Within 6 Months Before or After Start of Measurement Period" InitialBPHDiagnosis
    with [Encounter: "Hospital Services for urology care"] InHospitalServices
      such that InitialBPHDiagnosis.prevalenceInterval ( ) starts during Interval[start of InHospitalServices.period, end of InHospitalServices.period + 31 days]
        and InHospitalServices.status = 'finished'

define "Has Qualifying BPH Diagnosis":
  "Initial BPH Diagnosis Starts Within 6 Months Before or After Start of Measurement Period" is not null

define "Morbid Obesity Diagnosis On or Before Follow Up USS Assessment":
  [Condition: "Morbid Obesity"] MorbidObesity
    with "Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis" FollowUpUSSAssessment
      such that MorbidObesity.prevalenceInterval ( ) overlaps "Measurement Period"
        and MorbidObesity.prevalenceInterval ( ) starts on or before FollowUpUSSAssessment.effectiveDatetime
        and MorbidObesity.isConfirmedActiveDiagnosis ( )

define "Has Morbid Obesity Diagnosis or BMI Exam Result  Greater Than or Equal to 40 Starts On or Before Follow Up USS Assessment":
  exists "Morbid Obesity Diagnosis On or Before Follow Up USS Assessment"
    or "Has BMI Exam Result Greater Than or Equal To 40 During Measurement Period and On or Before Follow Up USS Assessment"

define "Urinary Retention Diagnosis Starts Within 1 Year After Initial BPH Diagnosis":
  [Condition: "Urinary retention"] UrinaryRetention
    with "Initial BPH Diagnosis Starts Within 6 Months Before or After Start of Measurement Period" InitialBPHDiagnosis
      such that UrinaryRetention.prevalenceInterval ( ) starts 1 year or less on or after day of start of InitialBPHDiagnosis.prevalenceInterval ( )
    where UrinaryRetention.isConfirmedActiveDiagnosis ( )

define "Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis":
  Last("Urinary Symptom Score Assessment" USSAssessment
      with "Initial BPH Diagnosis Starts Within 6 Months Before or After Start of Measurement Period" InitialBPHDiagnosis
        such that months between start of InitialBPHDiagnosis.prevalenceInterval() and USSAssessment.effectiveDatetime in Interval[6, 12]
      sort by effectiveDatetime
  )

define "Urinary Symptom Score Assessment":
  "Documented IPSS Assessment Result"
    union "AUA Symptom Index and Quality of Life Assessment Result"

define "Urinary Symptom Score Change":
  from
    "Urinary Symptom Score Within 1 Month after Initial BPH Diagnosis" FirstUSSAssessment,
    "Urinary Symptom Score 6 to 12 Months After Initial BPH Diagnosis" FollowUpUSSAssessment
    let USSChange: ( FirstUSSAssessment.valueInteger ) - ( FollowUpUSSAssessment.valueInteger )
    return USSChange

define "Has Urinary Symptom Score Improvement Greater Than or Equal To 3":
  ( "Urinary Symptom Score Change" USSImprovement
      where USSImprovement >= 3
  ) is not null

define "Urinary Symptom Score Within 1 Month after Initial BPH Diagnosis":
  First("Urinary Symptom Score Assessment" USSAssessment
      with "Initial BPH Diagnosis Starts Within 6 Months Before or After Start of Measurement Period" InitialBPHDiagnosis
        such that USSAssessment.effectiveDatetime 1 month or less on or after day of start of InitialBPHDiagnosis.prevalenceInterval()
      sort by effectiveDatetime
  )

define "Initial BPH Diagnosis Starts Within 6 Months Before or After Start of Measurement Period":
  First([Condition: "Benign prostatic hyperplasia with lower urinary tract symptoms"] NewBPHDiagnosis
      where NewBPHDiagnosis.prevalenceInterval() starts during day of Interval[start of "Measurement Period" - 6 months,
      end of "Measurement Period"]
        and NewBPHDiagnosis.isConfirmedActiveDiagnosis()
      sort by start of onset.toInterval()
  )

define fluent function isConfirmedActiveDiagnosis(Condition Condition):
  ( Condition Diagnosis
      where Diagnosis.clinicalStatus ~ QICoreCommon."active"
        and not ( Diagnosis.verificationStatus ~ QICoreCommon."unconfirmed"
            or Diagnosis.verificationStatus ~ QICoreCommon."refuted"
            or Diagnosis.verificationStatus ~ QICoreCommon."entered-in-error"
        )
  ) is not null
