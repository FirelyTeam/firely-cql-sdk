library CMSFHIR844HybridHospitalWideMortality version '0.5.001'

using QICore version '6.0.0'

include CQMCommon version '4.1.000' called CQMCommon
include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '4.0.000' called QICoreCommon
include SupplementalDataElements version '5.1.000' called SDE

codesystem "LOINC": 'http://loinc.org'

valueset "Bicarbonate lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.139'
valueset "Creatinine lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.2363'
valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Hematocrit lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.114'
valueset "Medicare Advantage payer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.12'
valueset "Medicare FFS payer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1104.10'
valueset "Non Invasive Oxygen Therapy by Nasal Cannula or Mask": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.209'
valueset "Non Invasive Oxygen Therapy Device Codes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.57'
valueset "Oxygen Saturation by Pulse Oximetry": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.151'
valueset "Platelet count lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.127'
valueset "Sodium lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.119'
valueset "White blood cells count lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.129'

code "Systolic blood pressure": '8480-6' from "LOINC" display 'Systolic BP'

parameter "Measurement Period" Interval<DateTime>

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

define "SDE Encounter With First Body Temperature":
  "Inpatient Encounters" EncounterInpatient
    let FirstTemperature: First([USCoreBodyTemperatureProfile] Temperature
        where Temperature.effective.earliest() during EncounterInpatient.hospitalizationWithObservationAndOutpatientSurgeryService()
          and Temperature.status in { 'final', 'amended', 'corrected' }
          and Temperature.value is not null
        sort by effective.earliest()
    )
    return {
      EncounterId: EncounterInpatient.id,
      FirstTemperatureResult: FirstTemperature.value as Quantity,
      Timing: FirstTemperature.effective.earliest ( )
    }

define "SDE Encounter With First Heart Rate":
  "Inpatient Encounters" EncounterInpatient
    let FirstHeartRate: First([USCoreHeartRateProfile] HeartRate
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

define "SDE Encounter With First Oxygen Saturation":
  "Inpatient Encounters" EncounterInpatient
    let FirstOxygenSat: First(["USCorePulseOximetryProfile": "Oxygen Saturation by Pulse Oximetry"] O2Saturation
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

define "SDE Encounter With First Systolic Blood Pressure":
  "Inpatient Encounters" EncounterInpatient
    let FirstSystolicBP: First(["USCoreBloodPressureProfile"] BP
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

define "SDE Encounter With First Bicarbonate Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstBicarbonateLab: First(["LaboratoryResultObservation": "Bicarbonate lab test"] BicarbonateLab
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

define "SDE Encounter With First Creatinine Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstCreatinineLab: First(["LaboratoryResultObservation": "Creatinine lab test"] CreatinineLab
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

define "SDE Encounter With First Hematocrit Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstHematocritLab: First(["LaboratoryResultObservation": "Hematocrit lab test"] HematocritLab
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

define "SDE Encounter With First Platelet Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstPlateletLab: First(["LaboratoryResultObservation": "Platelet count lab test"] PlateletLab
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

define "SDE Encounter With First Sodium Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstSodiumLab: First(["LaboratoryResultObservation": "Sodium lab test"] SodiumLab
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

define "SDE Encounter With First White Blood Cells Lab Test":
  "Inpatient Encounters" EncounterInpatient
    let FirstWhiteBloodCellLab: First(["LaboratoryResultObservation": "White blood cells count lab test"] WhiteBloodCellLab
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

define "SDE Encounter With Oxygen 60 Minutes Or Less Prior To ED Admission Or During ED":
  "Initial Population" EncounterInpatient
    where exists ( ( [ServiceRequest: "Non Invasive Oxygen Therapy by Nasal Cannula or Mask"]
        union [ServiceRequest: "Non Invasive Oxygen Therapy Device Codes"] ) OxygenTherapyOrder
        where ( OxygenTherapyOrder.authoredOn during EncounterInpatient.edVisit ( ).period
            or OxygenTherapyOrder.authoredOn 60 minutes or less before or on start of EncounterInpatient.edVisit ( ).period
        )
          and OxygenTherapyOrder.status in { 'active', 'completed' }
          and OxygenTherapyOrder.intent = 'order'
        return {
          EncounterId: EncounterInpatient.id,
          OrderStatus: OxygenTherapyOrder.status,
          OrderTiming: OxygenTherapyOrder.authoredOn
        }
    )
      or exists ( [Procedure: "Non Invasive Oxygen Therapy by Nasal Cannula or Mask"] OxygenAdminInterv
          where ( OxygenAdminInterv.performed.toInterval ( ) starts during EncounterInpatient.edVisit ( ).period
              or OxygenAdminInterv.performed.toInterval ( ) 60 minutes or less before or on start of EncounterInpatient.edVisit ( ).period
          )
            and OxygenAdminInterv.status = 'completed'
          return {
            EncounterId: EncounterInpatient.id,
            EDEncounterTiming: EncounterInpatient.edVisit ( ).period,
            PerformedStatus: OxygenAdminInterv.status,
            PerformedTiming: OxygenAdminInterv.performed.toInterval ( )
          }
      )

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"