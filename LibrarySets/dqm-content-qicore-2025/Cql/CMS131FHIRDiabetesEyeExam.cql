library CMS131FHIRDiabetesEyeExam version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon
include Hospice version '6.18.000' called Hospice
include Status version '1.15.000' called Status
include PalliativeCare version '1.18.000' called PalliativeCare
include AdvancedIllnessandFrailty version '1.27.000' called AIFrailLTCF

codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Annual Wellness Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240'
valueset "Autonomous Eye Exam Result or Finding": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1004.2616'
valueset "Diabetes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001'
valueset "Diabetic Retinopathy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327'
valueset "Diabetic Retinopathy Severity Level": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1266'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Ophthalmological Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Retinal or Dilated Eye Exam": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.115.12.1088'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'

code "Anophthalmos of bilateral eyes (disorder)": '15665641000119103' from "SNOMEDCT" display 'Anophthalmos of bilateral eyes (disorder)'
code "Eye Diabetic retinopathy screening Autonomous artificial intelligence": '105914-6' from "LOINC" display 'Eye Diabetic retinopathy screening Autonomous artificial intelligence'
code "Left eye Diabetic retinopathy severity level by Ophthalmoscopy": '71490-7' from "LOINC" display 'Left eye Diabetic retinopathy severity level by Ophthalmoscopy'
code "No apparent retinopathy": 'LA18643-9' from "LOINC" display 'No apparent retinopathy'
code "Right eye Diabetic retinopathy severity level by Ophthalmoscopy": '71491-5' from "LOINC" display 'Right eye Diabetic retinopathy severity level by Ophthalmoscopy'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) in Interval[18, 75]
    and exists ( "Qualifying Encounters" )
    and exists ( ( ( [ConditionEncounterDiagnosis: "Diabetes"] ).verified ( ) ) DiabetesDx
        where DiabetesDx.prevalenceInterval ( ) overlaps day of "Measurement Period"
    )

define "Qualifying Encounters":
  ( ( [Encounter: "Office Visit"]
      union [Encounter: "Annual Wellness Visit"]
      union [Encounter: "Preventive Care Services Established Office Visit, 18 and Up"]
      union [Encounter: "Preventive Care Services Initial Office Visit, 18 and Up"]
      union [Encounter: "Home Healthcare Services"]
      union [Encounter: "Ophthalmological Services"]
      union [Encounter: "Telephone Visits"]
  ).isEncounterPerformed ( ) ) ValidEncounters
    where ValidEncounters.period during day of "Measurement Period"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or AIFrailLTCF."Is Age 66 or Older with Advanced Illness and Frailty"
    or AIFrailLTCF."Is Age 66 or Older Living Long Term in a Nursing Home"
    or PalliativeCare."Has Palliative Care in the Measurement Period"
    or "Bilateral Absence of Eyes"

define "Numerator":
  ( "Diabetic Retinopathy Overlapping Measurement Period"
      and ( "Retinal Exam in Measurement Period" )
  )
    or ( not ( "Diabetic Retinopathy Overlapping Measurement Period" )
        and ( "Retinal Exam in Measurement Period or Year Prior" )
    )
    or "Autonomous Eye Exam in Measurement Period"
    or "Retinal Exam Finding with Retinopathy Severity Level in Measurement Period"
    or "Retinal Exam Finding with No Retinopathy Severity Level in Year Prior"

define "Autonomous Eye Exam in Measurement Period":
  exists ( ( [ObservationClinicalResult: "Eye Diabetic retinopathy screening Autonomous artificial intelligence"] ).isPhysicalExamPerformed ( ) ) AutonomousEyeExam
    where AutonomousEyeExam.value as Concept in "Autonomous Eye Exam Result or Finding"
      and AutonomousEyeExam.effective.toInterval ( ) during day of "Measurement Period"

define "Bilateral Absence of Eyes":
  exists ( ( [ConditionProblemsHealthConcerns: "Anophthalmos of bilateral eyes (disorder)"]
      union [ConditionEncounterDiagnosis: "Anophthalmos of bilateral eyes (disorder)"]
  ).verified ( ) ) BilateralAbsenceEyes
    where BilateralAbsenceEyes.prevalenceInterval ( ) starts on or before day of end of "Measurement Period"

define "Retinal Exam in Measurement Period":
  exists ( ( [ObservationClinicalResult: "Retinal or Dilated Eye Exam"] ).isPhysicalExamPerformed ( ) ) RetinalExam
    where RetinalExam.effective.toInterval ( ) during day of "Measurement Period"

define "Retinal Exam in Measurement Period or Year Prior":
  exists ( ( [ObservationClinicalResult: "Retinal or Dilated Eye Exam"] ).isPhysicalExamPerformed ( ) ) RetinalExam
    where RetinalExam.effective.toInterval ( ) during day of Interval[start of "Measurement Period" - 1 year, end of "Measurement Period"]

define "Diabetic Retinopathy Overlapping Measurement Period":
  exists ( ( [ConditionProblemsHealthConcerns: "Diabetic Retinopathy"]
      union [ConditionEncounterDiagnosis: "Diabetic Retinopathy"]
  ).verified ( ) ) Retinopathy
    where Retinopathy.prevalenceInterval ( ) overlaps day of "Measurement Period"

define "Has Left Eye No Retinopathy in Year Prior":
  exists ( ( [ObservationClinicalResult: "Left eye Diabetic retinopathy severity level by Ophthalmoscopy"] ).isPhysicalExamPerformed ( ) ) LeftEyeNoRetinopathy
    where LeftEyeNoRetinopathy.value ~ "No apparent retinopathy"
      and LeftEyeNoRetinopathy.effective.toInterval ( ) during day of Interval[start of "Measurement Period" - 1 year, end of "Measurement Period" - 1 year]

define "Has Left Eye Retinopathy":
  exists ( ( [ObservationClinicalResult: "Left eye Diabetic retinopathy severity level by Ophthalmoscopy"] ).isPhysicalExamPerformed ( ) ) LeftEyeRetinopathy
    where LeftEyeRetinopathy.value as Concept in "Diabetic Retinopathy Severity Level"
      and LeftEyeRetinopathy.effective.toInterval ( ) during day of "Measurement Period"

define "Has Right Eye No Retinopathy in Year Prior":
  exists ( ( [ObservationClinicalResult: "Right eye Diabetic retinopathy severity level by Ophthalmoscopy"] ).isPhysicalExamPerformed ( ) ) RightEyeNoRetinopathy
    where RightEyeNoRetinopathy.value ~ "No apparent retinopathy"
      and RightEyeNoRetinopathy.effective.toInterval ( ) during day of Interval[start of "Measurement Period" - 1 year, end of "Measurement Period" - 1 year]

define "Has Right Eye Retinopathy":
  exists ( ( [ObservationClinicalResult: "Right eye Diabetic retinopathy severity level by Ophthalmoscopy"] ).isPhysicalExamPerformed ( ) ) RightEyeRetinopathy
    where RightEyeRetinopathy.value as Concept in "Diabetic Retinopathy Severity Level"
      and RightEyeRetinopathy.effective.toInterval ( ) during day of "Measurement Period"

define "Retinal Exam Finding with No Retinopathy Severity Level in Year Prior":
  ( "Has Left Eye No Retinopathy in Year Prior"
      and "Has Right Eye No Retinopathy in Year Prior"
  )

define "Retinal Exam Finding with Retinopathy Severity Level in Measurement Period":
  ( "Has Left Eye Retinopathy"
      and "Has Right Eye Retinopathy"
  )
    or ( "Has Left Eye Retinopathy"
        and "Has Right Eye No Retinopathy in Year Prior"
    )
    or ( "Has Right Eye Retinopathy"
        and "Has Left Eye No Retinopathy in Year Prior"
    )

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"