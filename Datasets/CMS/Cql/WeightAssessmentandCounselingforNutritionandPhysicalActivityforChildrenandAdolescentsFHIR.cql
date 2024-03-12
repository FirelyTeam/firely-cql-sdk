library WeightAssessmentandCounselingforNutritionandPhysicalActivityforChildrenandAdolescentsFHIR version '0.1.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include QICoreCommon version '2.0.000' called QICoreCommon
include SupplementalDataElements version '3.4.000' called SDE
include Hospice version '6.9.000' called Hospice
include Status version '1.6.000' called Status

codesystem "UCUM": 'http://unitsofmeasure.org'
codesystem "LOINC": 'http://loinc.org'
codesystem "ObservationCategoryCodes": 'http://terminology.hl7.org/CodeSystem/observation-category'

valueset "BMI percentile": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1012'
valueset "Counseling for Nutrition": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.195.12.1003'
valueset "Counseling for Physical Activity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1035'
valueset "Discharged to Health Care Facility for Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207'
valueset "Discharged to Home for Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Height": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1014'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Hospice care ambulatory": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Pregnancy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.378'
valueset "Preventive Care Services - Group Counseling": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027'
valueset "Preventive Care Services, Initial Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022'
valueset "Preventive Care Services-Individual Counseling": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026'
valueset "Preventive Care, Established Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'
valueset "Weight": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.121.12.1015'

code "[in_i]": '[in_i]' from "UCUM" display 'inch (international)'
code "[lb_av]": '[lb_av]' from "UCUM" display 'pound (US and British)'
code "Birth date": '21112-8' from "LOINC" display 'Birth date'
code "Body height": '8302-2' from "LOINC" display 'Body height'
code "Body mass index (BMI) [Ratio]": '39156-5' from "LOINC" display 'Body mass index (BMI) [Ratio]'
code "Body weight": '29463-7' from "LOINC" display 'Body weight'
code "cm": 'cm' from "UCUM" display 'centimeter'
code "exam": 'exam' from "ObservationCategoryCodes" display 'exam'
code "g": 'g' from "UCUM" display 'gram'
code "kg": 'kg' from "UCUM" display 'kilogram'
code "vital-signs": 'vital-signs' from "ObservationCategoryCodes" display 'Vital Signs'

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
  ) in Interval[3, 17]
    and exists ( "Qualifying Encounter" )

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or exists ( "Pregnancy Diagnosis Which Overlaps Measurement Period" )

define "Pregnancy Diagnosis Which Overlaps Measurement Period":
  ( Status."Active Condition" ( [Condition: "Pregnancy"] ) ) Pregnancy
    where QICoreCommon."ToPrevalenceInterval" ( Pregnancy ) overlaps "Measurement Period"

define "Numerator 1":
  exists ( "BMI Percentile in Measurement Period" )
    and exists ( "Height in Measurement Period" )
    and exists ( "Weight in Measurement Period" )

define "Numerator 2":
  exists ( Status."Completed Procedure" ( [Procedure: "Counseling for Nutrition"] ) ) NutritionCounseling
    where QICoreCommon."ToInterval" ( NutritionCounseling.performed ) during day of "Measurement Period"

define "Numerator 3":
  exists ( Status."Completed Procedure" ( [Procedure: "Counseling for Physical Activity"] ) ) ActivityCounseling
    where QICoreCommon."ToInterval" ( ActivityCounseling.performed ) during day of "Measurement Period"

define "Stratifaction 1":
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) in Interval[3, 11]

define "Stratifaction 2":
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) in Interval[12, 17]

define "Qualifying Encounter":
  ( Status."Finished Encounter" ( ( [Encounter: "Office Visit"]
      union [Encounter: "Preventive Care Services-Individual Counseling"]
      union [Encounter: "Preventive Care Services, Initial Office Visit, 0 to 17"]
      union [Encounter: "Preventive Care, Established Office Visit, 0 to 17"]
      union [Encounter: "Preventive Care Services - Group Counseling"]
      union [Encounter: "Home Healthcare Services"]
      union [Encounter: "Telephone Visits"]
  ) ) ) ValidEncounters
    where QICoreCommon."ToInterval" ( ValidEncounters.period ) during "Measurement Period"

define "Height in Measurement Period":
  ( Status."BodyHeight" ( ["observation-bodyheight"] ) ) Height
    where QICoreCommon."ToInterval" ( Height.effective ) during day of "Measurement Period"
      and Height.value is not null

define "Weight in Measurement Period":
  ( Status."BodyWeight" ( ["observation-bodyweight"] ) ) Weight
    where QICoreCommon."ToInterval" ( Weight.effective ) during day of "Measurement Period"
      and Weight.value is not null

define "BMI Percentile in Measurement Period":
  ( Status."BMI" ( ["observation-bmi"] ) ) BMIPercentile
    where QICoreCommon."ToInterval" ( BMIPercentile.effective ) during day of "Measurement Period"
      and BMIPercentile.value is not null