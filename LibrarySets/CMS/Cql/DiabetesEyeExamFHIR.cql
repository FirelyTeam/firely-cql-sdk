library DiabetesEyeExamFHIR version '0.0.002'

using QICore version '4.1.1'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '3.5.000' called SDE
include QICoreCommon version '2.1.000' called QICoreCommon
include Hospice version '6.12.000' called Hospice
include Status version '1.8.000' called Status
include PalliativeCare version '1.11.000' called PalliativeCare
include AdvancedIllnessandFrailty version '1.16.000' called AIFrailLTCF

valueset "Annual Wellness Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240'
valueset "Diabetes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001'
valueset "Diabetic Retinopathy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Ophthalmological Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "Retinal or Dilated Eye Exam": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.115.12.1088'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.000Z, @2025-12-31T23:59:59.999Z]

context Patient

define "Initial Population":
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) in Interval[18, 75]
    and exists ( "Qualifying Encounters" )
    and exists ( [Condition: "Diabetes"] Diabetes
        where Diabetes.prevalenceInterval ( ) overlaps day of "Measurement Period"
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
    where ValidEncounters.period.toInterval ( ) during day of "Measurement Period"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or AIFrailLTCF."Is Age 66 or Older with Advanced Illness and Frailty"
    or AIFrailLTCF."Is Age 66 or Older Living Long Term in a Nursing Home"
    or PalliativeCare."Has Palliative Care in the Measurement Period"

define "Numerator":
  ( "Diabetic Retinopathy Overlapping Measurement Period"
      and exists ( "Retinal Exam in Measurement Period" )
  )
    or ( not ( "Diabetic Retinopathy Overlapping Measurement Period" )
        and exists ( "Retinal Exam in Measurement Period or Year Prior" )
    )

define "Retinal Exam in Measurement Period":
  ( ( [Observation: "Retinal or Dilated Eye Exam"] ).isPhysicalExamPerformed ( ) ) RetinalExam
    where RetinalExam.effective.toInterval ( ) during day of "Measurement Period"

define "Retinal Exam in Measurement Period or Year Prior":
  ( ( [Observation: "Retinal or Dilated Eye Exam"] ).isPhysicalExamPerformed ( ) ) RetinalExam
    where RetinalExam.effective.toInterval ( ) during day of Interval[start of "Measurement Period" - 1 year, end of "Measurement Period"]

define "Diabetic Retinopathy Overlapping Measurement Period":
  exists ( [Condition: "Diabetic Retinopathy"] Retinopathy
      where Retinopathy.prevalenceInterval ( ) overlaps day of "Measurement Period"
  )

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"