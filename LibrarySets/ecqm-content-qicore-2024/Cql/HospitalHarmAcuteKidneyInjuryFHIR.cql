library HospitalHarmAcuteKidneyInjuryFHIR version '0.0.001'

using QICore version '4.1.1'

include FHIRHelpers version '4.4.000' called FHIRHelpers
// include FHIRCommon version '4.2.000' called FHIRCommon

include SupplementalDataElements version '3.5.000' called SDE
include CQMCommon version '2.2.000' called CQMCommon
include QICoreCommon version '2.1.000' called QICoreCommon

codesystem "AdministrativeGender": 'http://terminology.hl7.org/CodeSystem/v3-AdministrativeGender'
codesystem "LOINC": 'http://loinc.org'

valueset "Body temperature": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152'
valueset "Creatinine Mass Per Volume": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.21'
valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Glomerular Filtration Rate": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.17.4077.2.2038'
valueset "High Risk Diagnosis for AKI": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.12'
valueset "High Risk Procedures for AKI": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.19'
valueset "Hospital Based Dialysis Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.199'
valueset "Observation Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143'
valueset "Obstetrics and VTE Obstetrics": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.33'
valueset "Present on Admission or Clinically Undetermined": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197'

code "Female": 'F' from "AdministrativeGender" display 'Female'
code "Heart rate": '8867-4' from "LOINC" display 'Heart rate'
code "Male": 'M' from "AdministrativeGender" display 'Male'
code "Respiratory rate": '9279-1' from "LOINC" display 'Respiratory rate'
code "Systolic blood pressure": '8480-6' from "LOINC" display 'Systolic blood pressure'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0 )

context Patient

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Encounter with Age 18 and Length of Stay 48 Hours or More":
  ["Encounter": "Encounter Inpatient"] InpatientEncounter
    where InpatientEncounter.period ends during day of "Measurement Period"
      and AgeInYearsAt(date from start of InpatientEncounter.period) >= 18
      and ( duration in hours of InpatientEncounter.hospitalizationWithObservation ( ) >= 48 )

define "Inpatient Encounter with Creatinine":
  from
    "Encounter with Age 18 and Length of Stay 48 Hours or More" Encounter48Hours,
    ["Observation": "Creatinine Mass Per Volume"] CreatinineTest
    let HospitalizationPeriod: Encounter48Hours.hospitalizationWithObservation ( ),
    CreatinineTestStart: CreatinineTest.effective.earliest ( )
    where CreatinineTest.value is not null
      and CreatinineTestStart during Interval[start of HospitalizationPeriod + 48 hours, end of HospitalizationPeriod]
      and CreatinineTest.status in { 'final', 'amended', 'corrected' }
    return Encounter48Hours

define "Encounter with Creatinine and without Obstetrical Conditions":
  "Inpatient Encounter with Creatinine" EncounterWithCreatinine
    where not exists ( ( EncounterWithCreatinine.encounterDiagnosis ( ) ) EncounterDiagnosis
        where EncounterDiagnosis.code in "Obstetrics and VTE Obstetrics"
    )

define "Initial Population":
  "Encounter with Creatinine and without Obstetrical Conditions"

define "Denominator":
  "Initial Population"

define "Encounter with Less Than 2 Creatinine Results within 48 Hours of Arrival":
  "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    where ( Count("CreatinineLabTestwithResultwithinFirst48Hours"(QualifyingEncounter)) < 2 )

define "Encounter with 0.3 mg dL or More Increase in Creatinine":
  Coalesce("Increase of 0.3 or More Using Lowest Creatinine within 24 Hours", "Increase of 0.3 or More Using First Creatinine within First 48 Hours")

define "Increase of 0.3 or More Using Lowest Creatinine within 24 Hours":
  from
    "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter,
    ["Observation": "Creatinine Mass Per Volume"] IndexCreatinineLabResult,
    ["Observation": "Creatinine Mass Per Volume"] SubsequentCreatinineLabResult
    let IndexCreatinineLabResultTime: IndexCreatinineLabResult.effective.earliest ( ),
    SubsequentCreatinineLabResultTime: SubsequentCreatinineLabResult.effective.earliest ( ),
    HospitalWithObservationPeriod: QualifyingEncounter.hospitalizationWithObservation ( )
    where IndexCreatinineLabResult.status in { 'final', 'amended', 'corrected' }
      and SubsequentCreatinineLabResult.status in { 'final', 'amended', 'corrected' }
      and ( ( SubsequentCreatinineLabResult.value as Quantity ) - ( IndexCreatinineLabResult.value as Quantity ) ) > 0.299 'mg/dL'
      and IndexCreatinineLabResult.value = "LowestSerumCreatinineResult"(QualifyingEncounter)
      and IndexCreatinineLabResultTime during Interval[SubsequentCreatinineLabResultTime - 48 hours, SubsequentCreatinineLabResultTime]
      and IndexCreatinineLabResultTime during HospitalWithObservationPeriod
      and IndexCreatinineLabResultTime during Interval[start of HospitalWithObservationPeriod, start of HospitalWithObservationPeriod + 24 hours]
      and SubsequentCreatinineLabResultTime during HospitalWithObservationPeriod
      and SubsequentCreatinineLabResultTime during Interval[start of HospitalWithObservationPeriod, start of HospitalWithObservationPeriod + 48 hours]
      and IndexCreatinineLabResult.id != SubsequentCreatinineLabResult.id
    return QualifyingEncounter

define "Increase of 0.3 or More Using First Creatinine within First 48 Hours":
  from
    "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter,
    ["Observation": "Creatinine Mass Per Volume"] IndexCreatinineLabResult,
    ["Observation": "Creatinine Mass Per Volume"] SubsequentCreatinineLabResult
    let IndexCreatinineLabResultTime: IndexCreatinineLabResult.effective.earliest ( ),
    SubsequentCreatinineLabResultTime: SubsequentCreatinineLabResult.effective.earliest ( ),
    HospitalWithObservationPeriod: QualifyingEncounter.hospitalizationWithObservation ( )
    where IndexCreatinineLabResult.status in { 'final', 'amended', 'corrected' }
      and SubsequentCreatinineLabResult.status in { 'final', 'amended', 'corrected' }
      and ( ( SubsequentCreatinineLabResult.value as Quantity ) - ( IndexCreatinineLabResult.value as Quantity ) ) > 0.299 'mg/dL'
      and IndexCreatinineLabResult.value as Quantity = singleton from "EarliestSerumCreatinineResult"(QualifyingEncounter)
      and IndexCreatinineLabResultTime during Interval[SubsequentCreatinineLabResultTime - 48 hours, SubsequentCreatinineLabResultTime]
      and IndexCreatinineLabResultTime during HospitalWithObservationPeriod
      and SubsequentCreatinineLabResultTime during Interval[start of HospitalWithObservationPeriod, start of HospitalWithObservationPeriod + 48 hours]
      and SubsequentCreatinineLabResultTime during HospitalWithObservationPeriod
      and IndexCreatinineLabResultTime during Interval[start of HospitalWithObservationPeriod, start of HospitalWithObservationPeriod + 48 hours]
      and SubsequentCreatinineLabResultTime during Interval[start of HospitalWithObservationPeriod, start of HospitalWithObservationPeriod + 48 hours]
      and IndexCreatinineLabResult.id != SubsequentCreatinineLabResult.id
    return QualifyingEncounter

define "Encounter with High Risk Diagnosis for AKI":
  "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    where exists ( ( QualifyingEncounter.encounterDiagnosis ( ) ) EncounterDiagnosis
        where ( EncounterDiagnosis.code in "High Risk Diagnosis for AKI" )
    )

define "Encounter with High Risk Procedures for AKI":
  "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    with ["Procedure": "High Risk Procedures for AKI"] HighRiskProcedures
      such that HighRiskProcedures.performed.toInterval ( ) starts during QualifyingEncounter.hospitalizationWithObservation ( )

define "Encounter with Kidney Dialysis Started 48 Hours or Less After Arrival":
  from
    ["Procedure": "Hospital Based Dialysis Services"] Dialysis,
    "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    let HospitalWithObservationPeriod: QualifyingEncounter.hospitalizationWithObservation ( )
    where Dialysis.performed.toInterval ( ) starts during Interval[start of HospitalWithObservationPeriod, start of HospitalWithObservationPeriod + 48 hours]
      and Dialysis.performed.toInterval ( ) starts during HospitalWithObservationPeriod
    return QualifyingEncounter

define "Encounter with Kidney Dialysis Started 48 Hours or Less After Arrival without High Creatinine":
  "Encounter with Kidney Dialysis Started 48 Hours or Less After Arrival" EncounterWithKidneyDialysis48HoursOrAfter
    where not ( exists ( "Encounter with 2 Times Serum Creatinine Increase" EncounterWithHighCreatinine
          where ( EncounterWithHighCreatinine.period includes EncounterWithKidneyDialysis48HoursOrAfter.period )
      )
    )

define "Encounter with Kidney Dialysis Started More Than 48 Hours After Arrival":
  from
    ["Procedure": "Hospital Based Dialysis Services"] Dialysis,
    "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    let HospitalWithObservationPeriod: QualifyingEncounter.hospitalizationWithObservation ( )
    where Dialysis.performed.toInterval ( ) starts during Interval[start of HospitalWithObservationPeriod + 48 hours, end of HospitalWithObservationPeriod]
      and Dialysis.performed.toInterval ( ) starts during HospitalWithObservationPeriod
    return QualifyingEncounter

define "Encounter with Kidney Dialysis Started More Than 48 Hours After Arrival without High Creatinine":
  "Encounter with Kidney Dialysis Started More Than 48 Hours After Arrival" EncounterWithDialysisAfter48Hours
    where not ( exists ( "Encounter with 2 Times Serum Creatinine Increase" EncounterWithHighCreatinine
          where ( EncounterWithHighCreatinine.period includes EncounterWithDialysisAfter48Hours.period )
      )
    )

define "Denominator Exclusion":
  "Encounter with Less Than 2 Creatinine Results within 48 Hours of Arrival"
    union "Encounter with Index eGFR Less Than 60 within First 48 Hours"
    union "Encounter with 0.3 mg dL or More Increase in Creatinine"
    union "Encounter with Kidney Dialysis Started 48 Hours or Less After Arrival without High Creatinine"
    union "Encounter with High Risk Diagnosis for AKI"
    union "Encounter with High Risk Procedures for AKI"

define "Numerator":
  "Encounter with 2 Times Serum Creatinine Increase"
    union "Encounter with Kidney Dialysis Started More Than 48 Hours After Arrival without High Creatinine"

define "Serum Creatinine Normal":
  if ( Patient.gender = 'female' ) then 1.02 'mg/dL' 
    else if ( Patient.gender = 'male' ) then 1.18 'mg/dL' 
    else null

define "Encounter with Index eGFR Less Than 60 within First 48 Hours":
  "Male Encounter with eGFR Less Than 60"
    union "Female Encounter with eGFR Less Than 60"

define "Female Encounter with eGFR Less Than 60":
  "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    where "FemaleeGFR"(QualifyingEncounter) is not null
      and "FemaleeGFR"(QualifyingEncounter) as Decimal < 60

define "Male Encounter with eGFR Less Than 60":
  "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    where "MaleeGFR"(QualifyingEncounter) is not null
      and "MaleeGFR"(QualifyingEncounter) as Decimal < 60

define "Qualifying Creatinine Lab Result by Time":
  from
    "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter,
    ["Observation": "Creatinine Mass Per Volume"] CreatinineTestByTime
    let CrEncId: QualifyingEncounter.id,
    CrHospPeriod: QualifyingEncounter.hospitalizationWithObservation ( ),
    CrLabId: CreatinineTestByTime.id,
    CrTime: CreatinineTestByTime.effective.earliest ( ),
    CrTimeIssued: CreatinineTestByTime.issued,
    CrResult: CreatinineTestByTime.value as Quantity,
    CrResultValue: CrResult.value,
    CrResultUnit: CrResult.unit
    where CrTime during CrHospPeriod
      and CreatinineTestByTime.isLaboratory ( )
      and CreatinineTestByTime.status in { 'final', 'amended', 'corrected' }
      and CrResultUnit = 'mg/dL'
      and CreatinineTestByTime.value is not null
      and CreatinineTestByTime.value as Quantity > 0 'mg/dL'
    return Tuple {
      CrEncInPtId: CrEncId,
      CrHospitalization: CrHospPeriod,
      CrLabObsId: CrLabId,
//                    LabCategory: CreatinineTestByQuantity.isLaboratory(),
      
      CrLabObsCategory: if CreatinineTestByTime.isLaboratory ( ) then 'laboratory' 
        else CreatinineTestByTime.isLaboratory ( ),
      CrLabObsStatus: CreatinineTestByTime.status,
      CrLabResult: CrResult,
      CrLabResultUnit: CrResultUnit,
      CrLabResultValue: CrResultValue,
      CrLabTime: CrTime,
      CrLabTimeIssued: CrTimeIssued
    }
    sort by CrLabTime

define "Encounter with 1.5 Times Serum Creatinine Increase":
  from
    "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter,
    ["Observation": "Creatinine Mass Per Volume"] HighCreatinineTest,
    ["Observation": "Creatinine Mass Per Volume"] LowCreatinineTest
    let LowCreatinineTestTime: LowCreatinineTest.effective.earliest ( ),
    HighCreatinineTestTime: HighCreatinineTest.effective.earliest ( ),
    HospitalWithObservationPeriod: QualifyingEncounter.hospitalizationWithObservation ( )
    where ( HighCreatinineTest.value > "Serum Creatinine Normal" )
      and LowCreatinineTest.status in { 'final', 'amended', 'corrected' }
      and HighCreatinineTest.status in { 'final', 'amended', 'corrected' }
      and HighCreatinineTest.value = "HighestSerumCreatinineResult"(QualifyingEncounter)
      and LowCreatinineTest.value = "LowestSerumCreatinineResult"(QualifyingEncounter)
      and "1.5IncreaseInCreatinine"(QualifyingEncounter) >= LowCreatinineTest.value
      and LowCreatinineTestTime 7 days or less before HighCreatinineTestTime
      and LowCreatinineTestTime during HospitalWithObservationPeriod
      and HighCreatinineTestTime during Interval[start of HospitalWithObservationPeriod + 48 hours, start of HospitalWithObservationPeriod + 30 days]
      and HighCreatinineTestTime during HospitalWithObservationPeriod
    return QualifyingEncounter

define "Encounter with 2 Times Serum Creatinine Increase":
  from
    "Encounter with 1.5 Times Serum Creatinine Increase" EncounterWithHighCreatinine,
    ["Observation": "Creatinine Mass Per Volume"] HighCreatinineTest,
    ["Observation": "Creatinine Mass Per Volume"] LowCreatinineTest
    let LowCreatinineTestTime: LowCreatinineTest.effective.earliest ( ),
    HighCreatinineTestTime: HighCreatinineTest.effective.earliest ( ),
    HospitalWithObservationPeriod: EncounterWithHighCreatinine.hospitalizationWithObservation ( )
    where ( HighCreatinineTest.value > "Serum Creatinine Normal" )
      and LowCreatinineTest.status in { 'final', 'amended', 'corrected' }
      and HighCreatinineTest.status in { 'final', 'amended', 'corrected' }
      and HighCreatinineTest.value = "HighestSerumCreatinineResult"(EncounterWithHighCreatinine)
      and LowCreatinineTest.value = "LowestSerumCreatinineResult"(EncounterWithHighCreatinine)
      and ( "2.0IncreaseInCreatinine"(EncounterWithHighCreatinine) as Quantity ) >= ( LowCreatinineTest.value as Quantity )
      and LowCreatinineTestTime 7 days or less before HighCreatinineTestTime
      and LowCreatinineTestTime during HospitalWithObservationPeriod
      and HighCreatinineTestTime during Interval[start of HospitalWithObservationPeriod + 48 hours, start of HospitalWithObservationPeriod + 30 days]
      and HighCreatinineTestTime during HospitalWithObservationPeriod
    return EncounterWithHighCreatinine

define function "CreatinineLabTestwithResultwithinFirst48Hours"(QualifyingEncounter Encounter):
  from
    ["Observation": "Creatinine Mass Per Volume"] CreatinineTest
    where CreatinineTest.value is not null
      and CreatinineTest.effective.earliest ( ) during Interval[start of QualifyingEncounter.hospitalizationWithObservation ( ), start of QualifyingEncounter.hospitalizationWithObservation ( ) + 48 hours]
      and CreatinineTest.effective.earliest ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
      and CreatinineTest.status in { 'final', 'amended', 'corrected' }
    return CreatinineTest

define function "IndexCreatinine"(QualifyingEncounter Encounter):
  Coalesce("LowestSerumCreatinineIn24Hours"(QualifyingEncounter), singleton from "FirstSerumCreatinineIn48Hours"(QualifyingEncounter))

define function "LowestSerumCreatinineIn24Hours"(QualifyingEncounter Encounter):
  Min((from
        "Qualifying Creatinine Lab Result by Time" LabTests
        let LabResult: LabTests.CrLabResult
        where LabTests.CrEncInPtId = QualifyingEncounter.id
          and LabTests.CrLabTime during Interval[start of QualifyingEncounter.hospitalizationWithObservation(), start of QualifyingEncounter.hospitalizationWithObservation() + 24 hours]
    ).CrLabResult
  ) 

// find earliest time in 48 hrs


define function "EarliestSerumCreatinineTimeIn48Hours"(QualifyingEncounter Encounter):
  ( Min((from
          "Qualifying Creatinine Lab Result by Time" LabTests
          let LabResult: LabTests.CrLabResult
          where LabTests.CrEncInPtId = QualifyingEncounter.id
            and LabTests.CrLabTime during Interval[start of QualifyingEncounter.hospitalizationWithObservation(), start of QualifyingEncounter.hospitalizationWithObservation() + 48 hours]
      ).CrLabTime
    )
  )

// find result from earliest time in 48 hrs


define function "FirstSerumCreatinineIn48Hours"(QualifyingEncounter Encounter):
  from
    "Qualifying Creatinine Lab Result by Time" LabTests
    let LabResult: LabTests.CrLabResult
    where ( "EarliestSerumCreatinineTimeIn48Hours"(QualifyingEncounter) = LabTests.CrLabTime )
    return LabResult as Quantity

define function "EarliestSerumCreatinineTime"(QualifyingEncounter Encounter):
  ( Min((from
          "Qualifying Creatinine Lab Result by Time" LabTests
          let LabResult: LabTests.CrLabResult
          where LabTests.CrEncInPtId = QualifyingEncounter.id
      ).CrLabTime
    )
  )

define function "EarliestSerumCreatinineResult"(QualifyingEncounter Encounter):
  from
    "Qualifying Creatinine Lab Result by Time" LabTests
    let LabResult: LabTests.CrLabResult
    where ( "EarliestSerumCreatinineTime"(QualifyingEncounter) = LabTests.CrLabTime )
    return LabResult as Quantity

define function "SerumCreatinineSequencebyTime"(QualifyingEncounter Encounter):
  ["Observation": "Creatinine Mass Per Volume"] CreatinineTestByTime
    let HospitalWithObservation: QualifyingEncounter.hospitalization ( )
    where CreatinineTestByTime.effective.earliest ( ) during HospitalWithObservation
      and CreatinineTestByTime.value is not null
      and CreatinineTestByTime.isLaboratory ( )
      and CreatinineTestByTime.status in { 'final', 'amended', 'corrected' }
    return CreatinineTestByTime

// following functions work with Cr result as Quantity (not decimal, but Quantity value is decimal)


define function "1.5IncreaseInCreatinine"(QualifyingEncounter Encounter):
  "HighestSerumCreatinineResult"(QualifyingEncounter) / 1.5

define function "2.0IncreaseInCreatinine"(QualifyingEncounter Encounter):
  "HighestSerumCreatinineResult"(QualifyingEncounter) / 2

define function "LowestSerumCreatinineResult"(QualifyingEncounter Encounter):
  ( Min((from
          "Qualifying Creatinine Lab Result by Time" LabTests
          let LabResult: LabTests.CrLabResult
          where LabTests.CrEncInPtId = QualifyingEncounter.id
      ).CrLabResult
    )
  )

define function "HighestSerumCreatinineResult"(QualifyingEncounter Encounter):
  ( Max((from
          "Qualifying Creatinine Lab Result by Time" LabTests
          let LabResult: LabTests.CrLabResult
          where LabTests.CrEncInPtId = QualifyingEncounter.id
      ).CrLabResult
    )
  )

// eGFR functions return as decimal value rather than Quantity


define function "FemaleeGFR"(QualifyingEncounter Encounter):
  if Patient.gender = 'female' then ( 142 * Min({("IndexCreatinine"(QualifyingEncounter).value / 0.7), 1 }) ^ ( - 0.241 ) * Max({("IndexCreatinine"(QualifyingEncounter).value / 0.7), 1 }) ^ ( - 1.200 ) * 0.9938 ^ ( AgeInYearsAt(start of QualifyingEncounter.hospitalizationWithObservation()) ) * 1.012 ) 
    else null

define function "MaleeGFR"(QualifyingEncounter Encounter):
  if Patient.gender = 'male' then ( 142 * Min({("IndexCreatinine"(QualifyingEncounter).value / 0.9), 1 }) ^ ( - 0.302 ) * Max({("IndexCreatinine"(QualifyingEncounter).value / 0.9), 1 }) ^ ( - 1.200 ) * 0.9938 ^ ( AgeInYearsAt(start of QualifyingEncounter.hospitalizationWithObservation()) ) ) 
    else null

// ===== RISK VARIABLE DEFINITIONS =====


define "Risk Variable Estimated Glomerular Filtration Rate for Females":
  "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      eGFR: "FemaleeGFR"(QualifyingEncounter)
    }

define "Risk Variable Estimated Glomerular Filtration Rate for Males":
  "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      eGFR: "MaleeGFR"(QualifyingEncounter)
    }

define "Risk Variable All Encounter Diagnoses with POA Indication":
  "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    where exists ( QualifyingEncounter.diagnosis D
        where D.diagnosisPresentOnAdmission in "Present on Admission or Clinically Undetermined"
        return Tuple {
          encounterId: QualifyingEncounter.id,
          diagnosis: D.condition.getCondition ( ).code,
          POA: D.diagnosisPresentOnAdmission
        }
    )

define "Risk Variable First Heart Rate in Encounter":
  "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstHeartRate: "FirstHeartRate"(QualifyingEncounter)
    }

define "Risk Variable First Respiratory Rate in Encounter":
  "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstRespiratoryRate: "FirstRespiratoryRate"(QualifyingEncounter)
    }

define "Risk Variable First Systolic Blood Pressure in Encounter":
  "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstSystolicBP: "FirstSystolicBloodPressure"(QualifyingEncounter)
    }

define "Risk Variable First Temperature in Encounter":
  "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstTemperature: "FirstBodyTemperature"(QualifyingEncounter)
    }

// ===== RISK VARIABLE FUNCTIONS =====


define function "FirstBodyTemperature"(QualifyingEncounter Encounter):
  First(["Observation": "Body temperature"] FirstTemperature
      where FirstTemperature.effective.earliest() during QualifyingEncounter.hospitalizationWithObservation()
        and FirstTemperature.value is not null
      sort by effective.earliest()
  ).value as Quantity

define function "FirstHeartRate"(QualifyingEncounter Encounter):
  First(["Observation": "Heart rate"] FirstHeartBeats
      where FirstHeartBeats.effective.earliest() during QualifyingEncounter.hospitalizationWithObservation()
        and FirstHeartBeats.value is not null
      sort by effective.earliest()
  ).value as Quantity

define function "FirstRespiratoryRate"(QualifyingEncounter Encounter):
  First(["Observation": "Respiratory rate"] FirstRespiration
      where FirstRespiration.effective.earliest() during QualifyingEncounter.hospitalizationWithObservation()
        and FirstRespiration.value is not null
      sort by effective.earliest()
  ).value as Quantity

define function "FirstSystolicBloodPressure"(QualifyingEncounter Encounter):
  First(["Observation": "Systolic blood pressure"] FirstSystolic
      where FirstSystolic.effective.earliest() during QualifyingEncounter.hospitalizationWithObservation()
        and FirstSystolic.value is not null
      sort by effective.earliest()
  ).value as Quantity