library CMS155FHIRWgtAssessCounseling version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '4.0.000' called QICoreCommon
include SupplementalDataElements version '5.1.000' called SDE
include Hospice version '6.18.000' called Hospice
include Status version '1.15.000' called Status

valueset "Counseling for Nutrition": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.195.12.1003'
valueset "Counseling for Physical Activity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1035'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Pregnancy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378'
valueset "Preventive Care Services Group Counseling": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027'
valueset "Preventive Care Services, Initial Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022'
valueset "Preventive Care Services Individual Counseling": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026'
valueset "Preventive Care, Established Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'

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
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) in Interval[3, 17]
    and exists "Qualifying Encounters"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or exists "Pregnancy Diagnosis Which Overlaps Measurement Period"

define "Pregnancy Diagnosis Which Overlaps Measurement Period":
  ( ( [ConditionProblemsHealthConcerns: "Pregnancy"]
      union [ConditionEncounterDiagnosis: "Pregnancy"]
  ).verified ( ) ) PregnancyDiag
    where PregnancyDiag.prevalenceInterval ( ) overlaps "Measurement Period"

define "Numerator 1":
  exists "BMI Percentile in Measurement Period"
    and exists "Height in Measurement Period"
    and exists "Weight in Measurement Period"

define "Numerator 2":
  exists ( ( [Procedure: "Counseling for Nutrition"] ).isInterventionPerformed ( ) ) NutritionCounseling
    where NutritionCounseling.performed.toInterval ( ) during day of "Measurement Period"

define "Numerator 3":
  exists ( ( [Procedure: "Counseling for Physical Activity"] ).isInterventionPerformed ( ) ) ActivityCounseling
    where ActivityCounseling.performed.toInterval ( ) during day of "Measurement Period"

define "Stratification 1":
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) in Interval[3, 11]

define "Stratification 2":
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) in Interval[12, 17]

define "Qualifying Encounters":
  ( ( [Encounter: "Office Visit"]
      union [Encounter: "Preventive Care Services Individual Counseling"]
      union [Encounter: "Preventive Care, Established Office Visit, 0 to 17"]
      union [Encounter: "Preventive Care Services, Initial Office Visit, 0 to 17"]
      union [Encounter: "Preventive Care Services Group Counseling"]
      union [Encounter: "Home Healthcare Services"]
      union [Encounter: "Telephone Visits"]
  ).isEncounterPerformed ( ) ) ValidEncounters
    where ValidEncounters.period during day of "Measurement Period"

define "Height in Measurement Period":
  ( ( [USCoreBodyHeightProfile] ).isObservationBodyHeight ( ) ) HeightExam
    where HeightExam.effective.toInterval ( ) during day of "Measurement Period"
      and HeightExam.value is not null

define "Weight in Measurement Period":
  ( ( [USCoreBodyWeightProfile] ).isObservationBodyWeight ( ) ) WeightExam
    where WeightExam.effective.toInterval ( ) during day of "Measurement Period"
      and WeightExam.value is not null

define "BMI Percentile in Measurement Period":
  ( ( [USCorePediatricBMIforAgeObservationProfile] ).isObservationPediatricBMI ( ) ) BMIPercentile
    where BMIPercentile.effective.toInterval ( ) during day of "Measurement Period"
      and BMIPercentile.value is not null