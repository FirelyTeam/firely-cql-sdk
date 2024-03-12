library HybridHospitalWideReadmissionFHIR version '0.0.001'

using QICore version '4.1.1'

include CQMCommon version '2.0.000' called CQMCommon
include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include QICoreCommon version '2.0.000' called QICoreCommon

codesystem "LOINC": 'http://loinc.org'
codesystem "ActCode": 'http://terminology.hl7.org/CodeSystem/v3-ActCode'
codesystem "Source of Payment Typology": 'https://nahdo.org/sopt'

valueset "Bicarbonate lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139'
valueset "Creatinine lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Glucose lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134'
valueset "Hematocrit lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114'
valueset "Medicare Advantage payer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12'
valueset "Medicare FFS payer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10'
valueset "Oxygen Saturation by Pulse Oximetry": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151'
valueset "Potassium lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.117'
valueset "Sodium lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119'
valueset "White blood cells count lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129'

code "Oxygen saturation in Arterial blood": '2708-6' from "LOINC" display 'Oxygen saturation in Arterial blood'
code "Oxygen saturation in Arterial blood by Pulse oximetry": '59408-5' from "LOINC" display 'Oxygen saturation in Arterial blood by Pulse oximetry'
code "Systolic blood pressure": '8480-6' from "LOINC" display 'Systolic BP'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "Initial Population":
  "Inpatient Encounters"

define "Inpatient Encounters":
  [Encounter: "Encounter Inpatient"] InpatientEncounter
    with ( [Coverage: "Medicare FFS payer"]
      union [Coverage: "Medicare Advantage payer"] ) MedicarePayer
      such that ( InpatientEncounter.hospitalizationWithObservationAndOutpatientSurgeryService ( ).lengthInDays ( ) ) < 365
        and InpatientEncounter.status = 'finished'
        and AgeInYearsAt(date from start of InpatientEncounter.period) >= 65
        and InpatientEncounter.period ends during day of "Measurement Period"

define "Encounter with First Body Temperature":
  "Inpatient Encounters" EncounterInpatient
    let FirstTemperature: First(["observation-bodytemp"] temperature
        where temperature.effective.earliest() during Interval[start of EncounterInpatient.period - 1440 minutes, start of EncounterInpatient.period + 120 minutes]
          and temperature.status in { 'final', 'amended', 'corrected' }
          and temperature.value is not null
        sort by effective.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstTemperatureResult: FirstTemperature.value as Quantity,
      Timing: FirstTemperature.effective.earliest ( )
    }

define "Encounter with First Heart Rate":
  "Inpatient Encounters" EncounterInpatient
    let FirstHeartRate: First(["observation-heartrate"] HeartRate
        where HeartRate.effective.earliest() during Interval[start of EncounterInpatient.period - 1440 minutes, start of EncounterInpatient.period + 120 minutes]
          and HeartRate.status in { 'final', 'amended', 'corrected' }
          and HeartRate.value is not null
        sort by effective.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstHeartRateResult: FirstHeartRate.value as Quantity,
      Timing: FirstHeartRate.effective.earliest ( )
    }

define "Encounter with First Oxygen Saturation":
  "Inpatient Encounters" EncounterInpatient
    let FirstOxygenSat: First([Observation: "Oxygen Saturation by Pulse Oximetry"] O2Saturation
        where O2Saturation.effective.earliest() during Interval[start of EncounterInpatient.period - 1440 minutes, start of EncounterInpatient.period + 120 minutes]
          and O2Saturation.status in { 'final', 'amended', 'corrected' }
          and O2Saturation.value is not null
        sort by effective.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstOxygenSatResult: FirstOxygenSat.value as Quantity,
      Timing: FirstOxygenSat.effective.earliest ( )
    }

define "Encounter with First Respiratory Rate":
  "Inpatient Encounters" EncounterInpatient
    let FirstRespRate: First(["observation-resprate"] RespRate
        where RespRate.effective.earliest() during Interval[start of EncounterInpatient.period - 1440 minutes, start of EncounterInpatient.period + 120 minutes]
          and RespRate.status in { 'final', 'amended', 'corrected' }
          and RespRate.value is not null
        sort by effective.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstRespRateResult: FirstRespRate.value as Quantity,
      Timing: FirstRespRate.effective.earliest ( )
    }

define "Blood Pressure Reading":
  ["observation-bp"] BloodPressure
    where BloodPressure.status in { 'final', 'amended', 'corrected' }

define "Encounter with First Systolic Blood Pressure":
  "Inpatient Encounters" EncounterInpatient
    let FirstSystolicBP: First("Blood Pressure Reading" SBPReading
        where SBPReading.effective.earliest() during Interval[start of EncounterInpatient.period - 1440 minutes, start of EncounterInpatient.period + 120 minutes]
        return singleton from(SBPReading.component SBPComponent
            where SBPComponent.code ~ "Systolic blood pressure"
            return SBPComponent.value as Quantity
        )
        sort ascending
    )
    return EncounterInpatient.id

define "Encounter with First Bicarbonate Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstBicarbonateLab: First(["US Core Laboratory Result Observation Profile": "Bicarbonate lab test"] bicarbonatelab
        where bicarbonatelab.issued.earliest() during Interval[start of EncounterInpatient.period - 1440 minutes, start of EncounterInpatient.period + 1440 minutes]
          and bicarbonatelab.status in { 'final', 'amended', 'corrected' }
          and bicarbonatelab.value is not null
        sort by issued.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstResult: FirstBicarbonateLab.value as Quantity,
      Timing: FirstBicarbonateLab.issued
    }

define "Encounter with First Creatinine Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstCreatinineLab: First(["US Core Laboratory Result Observation Profile": "Creatinine lab test"] CreatinineLab
        where CreatinineLab.issued.earliest() during Interval[start of EncounterInpatient.period - 1440 minutes, start of EncounterInpatient.period + 1440 minutes]
          and CreatinineLab.status in { 'final', 'amended', 'corrected' }
          and CreatinineLab.value is not null
        sort by issued.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstResult: FirstCreatinineLab.value as Quantity,
      Timing: FirstCreatinineLab.issued
    }

define "Encounter with First Glucose Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstGlucoseLab: First(["US Core Laboratory Result Observation Profile": "Glucose lab test"] GlucoseLab
        where GlucoseLab.issued.earliest() during Interval[start of EncounterInpatient.period - 1440 minutes, start of EncounterInpatient.period + 1440 minutes]
          and GlucoseLab.status in { 'final', 'amended', 'corrected' }
          and GlucoseLab.value is not null
        sort by issued.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstResult: FirstGlucoseLab.value as Quantity,
      Timing: FirstGlucoseLab.issued
    }

define "Encounter with First Hematocrit Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstHematocritLab: First(["US Core Laboratory Result Observation Profile": "Hematocrit lab test"] HematocritLab
        where HematocritLab.issued.earliest() during Interval[start of EncounterInpatient.period - 1440 minutes, start of EncounterInpatient.period + 1440 minutes]
          and HematocritLab.status in { 'final', 'amended', 'corrected' }
          and HematocritLab.value is not null
        sort by issued.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstResult: FirstHematocritLab.value as Quantity,
      Timing: FirstHematocritLab.issued
    }

define "Encounter with First Potassium Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstPotassiumLab: First(["US Core Laboratory Result Observation Profile": "Potassium lab test"] PotassiumLab
        where PotassiumLab.issued.earliest() during Interval[start of EncounterInpatient.period - 1440 minutes, start of EncounterInpatient.period + 1440 minutes]
          and PotassiumLab.status in { 'final', 'amended', 'corrected' }
          and PotassiumLab.value is not null
        sort by issued.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstResult: FirstPotassiumLab.value as Quantity,
      Timing: FirstPotassiumLab.issued
    }

define "Encounter with First Sodium Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstSodiumLab: First(["US Core Laboratory Result Observation Profile": "Sodium lab test"] SodiumLab
        where SodiumLab.issued.earliest() during Interval[start of EncounterInpatient.period - 1440 minutes, start of EncounterInpatient.period + 1440 minutes]
          and SodiumLab.status in { 'final', 'amended', 'corrected' }
          and SodiumLab.value is not null
        sort by issued.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstResult: FirstSodiumLab.value as Quantity,
      Timing: FirstSodiumLab.issued
    }

define "Encounter with First White Blood Cells Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstWhiteBloodCellLab: First(["US Core Laboratory Result Observation Profile": "White blood cells count lab test"] WhiteBloodCellLab
        where WhiteBloodCellLab.issued.earliest() during Interval[start of EncounterInpatient.period - 1440 minutes, start of EncounterInpatient.period + 1440 minutes]
          and WhiteBloodCellLab.status in { 'final', 'amended', 'corrected' }
          and WhiteBloodCellLab.value is not null
        sort by issued.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstResult: FirstWhiteBloodCellLab.value as Quantity,
      Timing: FirstWhiteBloodCellLab.issued
    }

define "Encounter with First Weight Recorded During Stay":
  "Inpatient Encounters" EncounterInpatient
    let FirstWeight: First(["observation-bodyweight"] WeightExam
        where WeightExam.effective.earliest() during EncounterInpatient.hospitalizationWithObservationAndOutpatientSurgeryService()
          and WeightExam.status in { 'final', 'amended', 'corrected' }
          and WeightExam.value is not null
        sort by effective.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstResult: FirstWeight.value as Quantity,
      Timing: FirstWeight.effective.earliest ( )
    }

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"