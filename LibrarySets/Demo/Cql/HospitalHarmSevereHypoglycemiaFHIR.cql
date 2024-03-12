library HospitalHarmSevereHypoglycemiaFHIR version '0.0.012'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.001' called FHIRHelpers
include SupplementalDataElementsFHIR4 version '2.0.000' called SDE
include MATGlobalCommonFunctionsFHIR4 version '6.1.000' called Global

codesystem "LOINC": 'http://loinc.org'

valueset "birth date": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4'
valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Glucose lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134'
valueset "Hypoglycemics": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3'
valueset "Hypoglycemics Severe Hypoglycemia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393'
valueset "Observation Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143'

code "Birth date": '21112-8' from "LOINC" display 'Birth date'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2019-01-01T00:00:00.0, @2020-01-01T00:00:00.0)
  
context Patient

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Initial Population":
  "Qualifying Encounter with Hypoglycemic Medication Administration"

define "Inpatient Encounter During Measurement Period":
  [Encounter: "Encounter Inpatient"] EncounterInpatient
                		where EncounterInpatient.status = 'finished'
                		       			and EncounterInpatient.period ends during "Measurement Period"

define "Numerator":
  "Severe Hypoglycemic Harm Event"

define "Qualifying Encounter":
  "Inpatient Encounter During Measurement Period" InpatientEncounter
  where AgeInYearsAt (start of Global."HospitalizationWithObservation"(InpatientEncounter))>=18

define "Qualifying Encounter with Hypoglycemic Medication Administration":
  "Qualifying Encounter" QualifyingEncounter
                           with "Hypoglycemic Medication Administration" HypoglycemicMedication
                             such that Global."Normalize Interval"(HypoglycemicMedication.effective) starts during Global.HospitalizationWithObservation ( QualifyingEncounter)

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "Denominator":
  "Initial Population"

define "Hypoglycemic Medication Administration":
  ["MedicationAdministration": "Hypoglycemics Severe Hypoglycemia"] HypoMedication
    where HypoMedication.status = 'completed'
      and HypoMedication.status != 'not-done'

define "Severe Hypoglycemic Harm Event":
  "Denominator" QualifyingEncounter
    where exists ( ["Observation": "Glucose lab test"] BloodGlucoseLab
        with "Hypoglycemic Medication Administration" HypoglycemicMeds
          such that Global."Normalize Interval" ( HypoglycemicMeds.effective ) starts 24 hours or less on or before start of Global."Normalize Interval" ( BloodGlucoseLab.effective )
            and BloodGlucoseLab.status = 'final'
            and BloodGlucoseLab.status != 'cancelled'
            and Global."Normalize Interval" ( HypoglycemicMeds.effective ) starts during Global."HospitalizationWithObservation" ( QualifyingEncounter )
        without ["Observation": "Glucose lab test"] FollowupBloodGlucoseLab
          such that Global."Normalize Interval" ( FollowupBloodGlucoseLab.effective ) starts during Global."HospitalizationWithObservation" ( QualifyingEncounter )
            and Global."Normalize Interval" ( FollowupBloodGlucoseLab.effective ) starts 5 minutes or less after start of Global."Normalize Interval" ( BloodGlucoseLab.effective )
            and FollowupBloodGlucoseLab.status = 'final'
            and FollowupBloodGlucoseLab.status != 'cancelled'
            and FollowupBloodGlucoseLab.value > 80 'mg/dL'
        where Global."Normalize Interval" ( BloodGlucoseLab.effective ) starts during Global."HospitalizationWithObservation" ( QualifyingEncounter )
          and BloodGlucoseLab.value < 40 'mg/dL'
    )
