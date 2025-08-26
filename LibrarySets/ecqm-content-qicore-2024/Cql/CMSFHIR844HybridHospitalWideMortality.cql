library CMSFHIR844HybridHospitalWideMortality version '0.1.001'

using QICore version '4.1.1'

include CQMCommon version '2.2.000' called CQMCommon
include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '3.5.000' called SDE
include QICoreCommon version '2.1.000' called QICoreCommon

codesystem "ActCode": 'http://terminology.hl7.org/CodeSystem/v3-ActCode'
codesystem "LOINC": 'http://loinc.org'
codesystem "Source of Payment Typology": 'https://nahdo.org/sopt'

valueset "Bicarbonate lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139'
valueset "Creatinine lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Hematocrit lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114'
valueset "Medicare Advantage payer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12'
valueset "Medicare FFS payer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10'
valueset "Oxygen Saturation by Pulse Oximetry": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151'
valueset "Platelet count lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127'
valueset "Sodium lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119'
valueset "White blood cells count lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129'

code "Oxygen saturation in Arterial blood by Pulse oximetry": '59408-5' from "LOINC" display 'Oxygen saturation in Arterial blood by Pulse oximetry'
code "Systolic blood pressure": '8480-6' from "LOINC" display 'Systolic BP'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2026-12-31T23:59:59.999Z]

context Patient

define "Initial Population":
  "Inpatient Encounters"

define "Inpatient Encounters":
  [Encounter: "Encounter Inpatient"] EncounterInpatient
    with ( [Coverage: "Medicare FFS payer"]
      union [Coverage: "Medicare Advantage payer"] ) MedicarePayer
      such that ( EncounterInpatient.hospitalizationWithObservationAndOutpatientSurgeryService ( ).lengthInDays ( ) ) < 365
        and EncounterInpatient.status = 'finished'
        and AgeInYearsAt(date from start of EncounterInpatient.period) in Interval[65, 94]
        and EncounterInpatient.period ends during day of "Measurement Period"

define "Encounter with First Body Temperature":
  "Inpatient Encounters" EncounterInpatient
    let FirstTemperature: First(["observation-bodytemp"] temperature
        where temperature.effective.earliest() during EncounterInpatient.hospitalizationWithObservationAndOutpatientSurgeryService()
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
        where HeartRate.effective.earliest() during EncounterInpatient.hospitalizationWithObservationAndOutpatientSurgeryService()
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
        where O2Saturation.effective.earliest() during EncounterInpatient.hospitalizationWithObservationAndOutpatientSurgeryService()
          and O2Saturation.status in { 'final', 'amended', 'corrected' }
          and O2Saturation.value is not null
        sort by effective.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstOxygenSatResult: FirstOxygenSat.value as Quantity,
      Timing: FirstOxygenSat.effective.earliest ( )
    }

define "Encounter with First Systolic Blood Pressure":
  "Inpatient Encounters" EncounterInpatient
    let FirstSystolicBP: First(["observation-bp"] BP
        where BP.effective.earliest() during EncounterInpatient.hospitalizationWithObservationAndOutpatientSurgeryService()
          and BP.status in { 'final', 'amended', 'corrected' }
          and BP.component.value is not null
        sort by effective.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstSBPResult: FirstSystolicBP.component C
        where C.code ~ "Systolic blood pressure"
        return C.value as Quantity,
      Timing: FirstSystolicBP.effective.earliest ( )
    }

define "Encounter with First Bicarbonate Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstBicarbonateLab: First(["USCoreLaboratoryResultObservationProfile": "Bicarbonate lab test"] BicarbonateLab
        where BicarbonateLab.effective.earliest() during EncounterInpatient.hospitalizationWithObservationAndOutpatientSurgeryService()
          and BicarbonateLab.status in { 'final', 'amended', 'corrected' }
          and BicarbonateLab.value is not null
        sort by issued.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstBicarbonateResult: FirstBicarbonateLab.value as Quantity,
      Timing: FirstBicarbonateLab.issued
    }

define "Encounter with First Creatinine Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstCreatinineLab: First(["USCoreLaboratoryResultObservationProfile": "Creatinine lab test"] CreatinineLab
        where CreatinineLab.effective.earliest() during EncounterInpatient.hospitalizationWithObservationAndOutpatientSurgeryService()
          and CreatinineLab.status in { 'final', 'amended', 'corrected' }
          and CreatinineLab.value is not null
        sort by issued.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstCreatinineResult: FirstCreatinineLab.value as Quantity,
      Timing: FirstCreatinineLab.issued
    }

define "Encounter with First Hematocrit Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstHematocritLab: First(["USCoreLaboratoryResultObservationProfile": "Hematocrit lab test"] HematocritLab
        where HematocritLab.effective.earliest() during EncounterInpatient.hospitalizationWithObservationAndOutpatientSurgeryService()
          and HematocritLab.status in { 'final', 'amended', 'corrected' }
          and HematocritLab.value is not null
        sort by issued.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstHematocritResult: FirstHematocritLab.value as Quantity,
      Timing: FirstHematocritLab.issued
    }

define "Encounter with First Platelet Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstPlateletLab: First(["USCoreLaboratoryResultObservationProfile": "Platelet count lab test"] PlateletLab
        where PlateletLab.effective.earliest() during EncounterInpatient.hospitalizationWithObservationAndOutpatientSurgeryService()
          and PlateletLab.status in { 'final', 'amended', 'corrected' }
          and PlateletLab.value is not null
        sort by issued.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstPlateletResult: FirstPlateletLab.value as Quantity,
      Timing: FirstPlateletLab.issued
    }

define "Encounter with First Sodium Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstSodiumLab: First(["USCoreLaboratoryResultObservationProfile": "Sodium lab test"] SodiumLab
        where SodiumLab.effective.earliest() during EncounterInpatient.hospitalizationWithObservationAndOutpatientSurgeryService()
          and SodiumLab.status in { 'final', 'amended', 'corrected' }
          and SodiumLab.value is not null
        sort by issued.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstSodiumResult: FirstSodiumLab.value as Quantity,
      Timing: FirstSodiumLab.issued
    }

define "Encounter with First White Blood Cells Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstWhiteBloodCellLab: First(["USCoreLaboratoryResultObservationProfile": "White blood cells count lab test"] WhiteBloodCellLab
        where WhiteBloodCellLab.effective.earliest() during EncounterInpatient.hospitalizationWithObservationAndOutpatientSurgeryService()
          and WhiteBloodCellLab.status in { 'final', 'amended', 'corrected' }
          and WhiteBloodCellLab.value is not null
        sort by issued.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstWhiteBloodCellResult: FirstWhiteBloodCellLab.value as Quantity,
      Timing: FirstWhiteBloodCellLab.issued
    }

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"