library CMS832FHIRHHAKI version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include CQMCommon version '4.1.000' called CQMCommon
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "LOINC": 'http://loinc.org'

valueset "Body temperature": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.152'
valueset "Creatinine Mass Per Volume": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.21'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Glomerular Filtration Rate": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.17.4077.2.2038'
valueset "High Risk Diagnosis for AKI": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.12'
valueset "High Risk Procedures for AKI": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.19'
valueset "Hospital Based Dialysis Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.199'
valueset "Obstetrics and VTE Obstetrics": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.33'
valueset "Present on Admission or Clinically Undetermined": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197'

code "Female (finding)": '248152002' from "SNOMEDCT" display 'Female'
code "Male (finding)": '248153007' from "SNOMEDCT" display 'Male'
code "Heart rate": '8867-4' from "LOINC" display 'Heart rate'
code "Respiratory rate": '9279-1' from "LOINC" display 'Respiratory rate'
code "Systolic blood pressure": '8480-6' from "LOINC" display 'Systolic blood pressure'

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
  "Encounter With Creatinine And Without Obstetrical Conditions"

define "Denominator":
  "Initial Population"

define "Denominator Exclusion":
  "Encounter With Less Than 2 Creatinine Results Within 48 Hours Of Arrival"
    union "Encounter With Index eGFR Less Than 60 Within First 48 Hours"
    union "Encounter With 0.3 mg dL Or More Increase In Creatinine"
    union "Encounter With Kidney Dialysis Started 48 Hours Or Less After Arrival Without High Creatinine"
    union "Encounter With High Risk Diagnosis For AKI"
    union "Encounter With High Risk Procedures For AKI"

define "Numerator":
  "Encounter With 2 Times Serum Creatinine Increase"
    union "Encounter With Kidney Dialysis Started More Than 48 Hours After Arrival Without High Creatinine"

define "Encounter With Age 18 And Length Of Stay 48 Hours Or More":
  ["Encounter": "Encounter Inpatient"] InpatientEncounter
    where Patient.sex in { "Male (finding)".code, "Female (finding)".code }
      and InpatientEncounter.period ends during day of "Measurement Period"
      and InpatientEncounter.status = 'finished'
      and AgeInYearsAt(date from start of InpatientEncounter.period) >= 18
      and ( duration in hours of InpatientEncounter.hospitalizationWithObservation ( ) >= 48 )

define "Inpatient Encounter With Creatinine":
  from
    "Encounter With Age 18 And Length Of Stay 48 Hours Or More" Encounter48Hours,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] CreatinineTest
    let HospitalizationPeriod: Encounter48Hours.hospitalizationWithObservation ( ),
    CreatinineTestStart: CreatinineTest.effective.earliest ( )
    where CreatinineTest.value as Quantity is not null
      and CreatinineTestStart during Interval[start of HospitalizationPeriod + 48 hours, end of HospitalizationPeriod]
      and CreatinineTest.status in { 'final', 'amended', 'corrected' }
    return Encounter48Hours

define "Encounter With Creatinine And Without Obstetrical Conditions":
  "Inpatient Encounter With Creatinine" EncounterWithCreatinine
    where not ( EncounterWithCreatinine.reasonCode in "Obstetrics and VTE Obstetrics"
        or EncounterWithCreatinine.encounterDiagnosis ( ).code in "Obstetrics and VTE Obstetrics"
    )

define "Encounter With Less Than 2 Creatinine Results Within 48 Hours Of Arrival":
  "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter
    where ( Count("QualifyingEncounter".creatinineLabTestwithResultwithinFirst48Hours()) < 2 )

define "Encounter With Index eGFR Less Than 60 Within First 48 Hours":
  "Male Encounter With eGFR Less Than 60"
    union "Female Encounter With eGFR Less Than 60"

define "Female Encounter With eGFR Less Than 60":
  "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter
    where "QualifyingEncounter".femaleeGFR ( ) is not null
      and "QualifyingEncounter".femaleeGFR ( ) as Decimal < 60

define "Male Encounter With eGFR Less Than 60":
  "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter
    where "QualifyingEncounter".maleeGFR ( ) is not null
      and "QualifyingEncounter".maleeGFR ( ) as Decimal < 60

define "Encounter With 0.3 mg dL Or More Increase In Creatinine":
  "Increase Of 0.3 Or More Using Lowest Creatinine Within 24 Hours"
    union "Increase Of 0.3 Or More Using First Creatinine Within First 48 Hours"

define "Increase Of 0.3 Or More Using Lowest Creatinine Within 24 Hours":
  from
    "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] IndexCreatinineLabResult,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] SubsequentCreatinineLabResult
    let IndexCreatinineLabResultTime: IndexCreatinineLabResult.effective.earliest ( ),
    SubsequentCreatinineLabResultTime: SubsequentCreatinineLabResult.effective.earliest ( ),
    HospitalWithObservationPeriod: QualifyingEncounter.hospitalizationWithObservation ( )
    where IndexCreatinineLabResult.status in { 'final', 'amended', 'corrected' }
      and SubsequentCreatinineLabResult.status in { 'final', 'amended', 'corrected' }
      and ( ( SubsequentCreatinineLabResult.value as Quantity ) - ( IndexCreatinineLabResult.value as Quantity ) ) > 0.299 'mg/dL'
      and IndexCreatinineLabResult.value = "QualifyingEncounter".lowestSerumCreatinineResult ( )
      and IndexCreatinineLabResultTime during Interval[SubsequentCreatinineLabResultTime - 48 hours, SubsequentCreatinineLabResultTime]
      and IndexCreatinineLabResultTime during HospitalWithObservationPeriod
      and IndexCreatinineLabResultTime during Interval[start of HospitalWithObservationPeriod, start of HospitalWithObservationPeriod + 24 hours]
      and SubsequentCreatinineLabResultTime during HospitalWithObservationPeriod
      and SubsequentCreatinineLabResultTime during Interval[start of HospitalWithObservationPeriod, start of HospitalWithObservationPeriod + 48 hours]
      and IndexCreatinineLabResult.id != SubsequentCreatinineLabResult.id
    return QualifyingEncounter

define "Increase Of 0.3 Or More Using First Creatinine Within First 48 Hours":
  from
    "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] IndexCreatinineLabResult,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] SubsequentCreatinineLabResult
    let IndexCreatinineLabResultTime: IndexCreatinineLabResult.effective.earliest ( ),
    SubsequentCreatinineLabResultTime: SubsequentCreatinineLabResult.effective.earliest ( ),
    HospitalWithObservationPeriod: QualifyingEncounter.hospitalizationWithObservation ( )
    where IndexCreatinineLabResult.status in { 'final', 'amended', 'corrected' }
      and SubsequentCreatinineLabResult.status in { 'final', 'amended', 'corrected' }
      and ( ( SubsequentCreatinineLabResult.value as Quantity ) - ( IndexCreatinineLabResult.value as Quantity ) ) > 0.299 'mg/dL'
      and IndexCreatinineLabResult.value as Quantity = singleton from "QualifyingEncounter".earliestSerumCreatinineResult ( )
      and IndexCreatinineLabResultTime during Interval[SubsequentCreatinineLabResultTime - 48 hours, SubsequentCreatinineLabResultTime]
      and IndexCreatinineLabResultTime during HospitalWithObservationPeriod
      and SubsequentCreatinineLabResultTime during Interval[start of HospitalWithObservationPeriod, start of HospitalWithObservationPeriod + 48 hours]
      and SubsequentCreatinineLabResultTime during HospitalWithObservationPeriod
      and IndexCreatinineLabResultTime during Interval[start of HospitalWithObservationPeriod, start of HospitalWithObservationPeriod + 48 hours]
      and IndexCreatinineLabResult.id != SubsequentCreatinineLabResult.id
    return QualifyingEncounter

define "Encounter With Kidney Dialysis Started 48 Hours Or Less After Arrival Without High Creatinine":
  "Encounter With Kidney Dialysis Started 48 Hours Or Less After Arrival" EncounterWithKidneyDialysis48HoursOrAfter
    where not ( exists ( "Encounter With 2 Times Serum Creatinine Increase" EncounterWithHighCreatinine
          where ( EncounterWithHighCreatinine.period includes EncounterWithKidneyDialysis48HoursOrAfter.period )
      )
    )

define "Encounter With Kidney Dialysis Started 48 Hours Or Less After Arrival":
  from
    ["Procedure": "Hospital Based Dialysis Services"] Dialysis,
    "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter
    let HospitalWithObservationPeriod: QualifyingEncounter.hospitalizationWithObservation ( )
    where Dialysis.status = 'completed'
      and Dialysis.performed.toInterval ( ) starts during Interval[start of HospitalWithObservationPeriod, start of HospitalWithObservationPeriod + 48 hours]
      and Dialysis.performed.toInterval ( ) starts during HospitalWithObservationPeriod
    return QualifyingEncounter

define "Encounter With 2 Times Serum Creatinine Increase":
  from
    "Encounter With 1.5 Times Serum Creatinine Increase" EncounterWithHighCreatinine,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] HighCreatinineTest,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] LowCreatinineTest
    let LowCreatinineTestTime: LowCreatinineTest.effective.earliest ( ),
    HighCreatinineTestTime: HighCreatinineTest.effective.earliest ( ),
    HospitalWithObservationPeriod: EncounterWithHighCreatinine.hospitalizationWithObservation ( )
    where ( HighCreatinineTest.value > "Serum Creatinine Normal" )
      and LowCreatinineTest.status in { 'final', 'amended', 'corrected' }
      and HighCreatinineTest.status in { 'final', 'amended', 'corrected' }
      and HighCreatinineTest.value = "EncounterWithHighCreatinine".highestSerumCreatinineResult ( )
      and LowCreatinineTest.value = "EncounterWithHighCreatinine".lowestSerumCreatinineResult ( )
      and ( HighCreatinineTest.value as Quantity ) >= ( LowCreatinineTest.value as Quantity )
      and LowCreatinineTestTime 7 days or less before HighCreatinineTestTime
      and LowCreatinineTestTime during HospitalWithObservationPeriod
      and HighCreatinineTestTime during Interval[start of HospitalWithObservationPeriod + 48 hours, start of HospitalWithObservationPeriod + 30 days]
      and HighCreatinineTestTime during HospitalWithObservationPeriod
    return EncounterWithHighCreatinine

define "Serum Creatinine Normal":
  if ( Patient.sex = "Female (finding)".code ) then 1.02 'mg/dL' 
    else 1.18 'mg/dL'

define "Encounter With High Risk Diagnosis For AKI":
  "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter
    where ( QualifyingEncounter.reasonCode in "High Risk Diagnosis for AKI"
        or QualifyingEncounter.encounterDiagnosis ( ).code in "High Risk Diagnosis for AKI"
    )

define "Encounter With High Risk Procedures For AKI":
  "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter
    with ["Procedure": "High Risk Procedures for AKI"] HighRiskProcedures
      such that HighRiskProcedures.status = 'completed'
        and HighRiskProcedures.performed.toInterval ( ) starts during QualifyingEncounter.hospitalizationWithObservation ( )

define "Encounter With Kidney Dialysis Started More Than 48 Hours After Arrival Without High Creatinine":
  "Encounter With Kidney Dialysis Started More Than 48 Hours After Arrival" EncounterWithDialysisAfter48Hours
    where not ( exists ( "Encounter With 2 Times Serum Creatinine Increase" EncounterWithHighCreatinine
          where ( EncounterWithHighCreatinine.period includes EncounterWithDialysisAfter48Hours.period )
      )
    )

define "Encounter With Kidney Dialysis Started More Than 48 Hours After Arrival":
  from
    ["Procedure": "Hospital Based Dialysis Services"] Dialysis,
    "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter
    let HospitalWithObservationPeriod: QualifyingEncounter.hospitalizationWithObservation ( )
    where Dialysis.performed.toInterval ( ) starts during Interval[start of HospitalWithObservationPeriod + 48 hours, end of HospitalWithObservationPeriod]
      and Dialysis.performed.toInterval ( ) starts during HospitalWithObservationPeriod
      and Dialysis.status = 'completed'
    return QualifyingEncounter

define "Qualifying Creatinine Lab Result By Time":
  from
    "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] CreatinineTestByTime
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
      CrLabObsCategory: if CreatinineTestByTime.isLaboratory ( ) then 'laboratory' 
        else CreatinineTestByTime.isLaboratory ( ),
      CrLabObsCategory: CreatinineTestByTime.category,
      CrLabObsStatus: CreatinineTestByTime.status,
      CrLabResult: CrResult,
      CrLabResultUnit: CrResultUnit,
      CrLabResultValue: CrResultValue,
      CrLabTime: CrTime,
      CrLabTimeIssued: CrTimeIssued
    }
    sort by CrLabTime

define "Encounter With 1.5 Times Serum Creatinine Increase":
  from
    "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] HighCreatinineTest,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] LowCreatinineTest
    let LowCreatinineTestTime: LowCreatinineTest.effective.earliest ( ),
    HighCreatinineTestTime: HighCreatinineTest.effective.earliest ( ),
    HospitalWithObservationPeriod: QualifyingEncounter.hospitalizationWithObservation ( )
    where ( HighCreatinineTest.value > "Serum Creatinine Normal" )
      and LowCreatinineTest.status in { 'final', 'amended', 'corrected' }
      and HighCreatinineTest.status in { 'final', 'amended', 'corrected' }
      and HighCreatinineTest.value = "QualifyingEncounter".highestSerumCreatinineResult ( )
      and LowCreatinineTest.value = "QualifyingEncounter".lowestSerumCreatinineResult ( )
      and "QualifyingEncounter".oneAndAHalfIncreaseInCreatinine ( ) >= LowCreatinineTest.value
      and LowCreatinineTestTime 7 days or less before HighCreatinineTestTime
      and LowCreatinineTestTime during HospitalWithObservationPeriod
      and HighCreatinineTestTime during Interval[start of HospitalWithObservationPeriod + 48 hours, start of HospitalWithObservationPeriod + 30 days]
      and HighCreatinineTestTime during HospitalWithObservationPeriod
    return QualifyingEncounter

define "Qualifying Blood Pressure Reading":
  ["USCoreBloodPressureProfile"] BloodPressure
    where BloodPressure.effective.earliest ( ) during day of "Measurement Period"

define fluent function "creatinineLabTestwithResultwithinFirst48Hours"(QualifyingEncounter Encounter):
  from
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] CreatinineTest
    where CreatinineTest.value as Quantity is not null
      and CreatinineTest.effective.earliest ( ) during Interval[start of QualifyingEncounter.hospitalizationWithObservation ( ), start of QualifyingEncounter.hospitalizationWithObservation ( ) + 48 hours]
      and CreatinineTest.effective.earliest ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
      and CreatinineTest.status in { 'final', 'amended', 'corrected' }
    return CreatinineTest

define fluent function "femaleeGFR"(QualifyingEncounter Encounter):
  if Patient.sex = "Female (finding)".code then ( 142 * Min({("QualifyingEncounter".indexCreatinine().value / 0.7), 1 }) ^ ( - 0.241 ) * Max({("QualifyingEncounter".indexCreatinine().value / 0.7), 1 }) ^ ( - 1.200 ) * 0.9938 ^ ( AgeInYearsAt(start of QualifyingEncounter.hospitalizationWithObservation()) ) * 1.012 ) 
    else null

define fluent function "maleeGFR"(QualifyingEncounter Encounter):
  if Patient.sex = "Male (finding)".code then ( 142 * Min({("QualifyingEncounter".indexCreatinine().value / 0.9), 1 }) ^ ( - 0.302 ) * Max({("QualifyingEncounter".indexCreatinine().value / 0.9), 1 }) ^ ( - 1.200 ) * 0.9938 ^ ( AgeInYearsAt(start of QualifyingEncounter.hospitalizationWithObservation()) ) ) 
    else null

define fluent function "indexCreatinine"(QualifyingEncounter Encounter):
  Coalesce("QualifyingEncounter".lowestSerumCreatinineIn24Hours(), singleton from "QualifyingEncounter".firstSerumCreatinineIn48Hours())

define fluent function "lowestSerumCreatinineIn24Hours"(QualifyingEncounter Encounter):
  Min((from
        "Qualifying Creatinine Lab Result By Time" LabTestsLow
        let LabResult: LabTestsLow.CrLabResult
        where LabTestsLow.CrEncInPtId = QualifyingEncounter.id
          and LabTestsLow.CrLabTime during Interval[start of QualifyingEncounter.hospitalizationWithObservation(), start of QualifyingEncounter.hospitalizationWithObservation() + 24 hours]
    ).CrLabResult
  )

define fluent function "firstSerumCreatinineIn48Hours"(QualifyingEncounter Encounter):
  from
    "Qualifying Creatinine Lab Result By Time" LabTests
    let LabResult: LabTests.CrLabResult
    where ( "QualifyingEncounter".earliestSerumCreatinineTimeIn48Hours ( ) = LabTests.CrLabTime )
    return LabResult as Quantity

define fluent function "earliestSerumCreatinineTimeIn48Hours"(QualifyingEncounter Encounter):
  ( Min((from
          "Qualifying Creatinine Lab Result By Time" LabTests48
          let LabResult48: LabTests48.CrLabResult
          where LabTests48.CrEncInPtId = QualifyingEncounter.id
            and LabTests48.CrLabTime during Interval[start of QualifyingEncounter.hospitalizationWithObservation(), start of QualifyingEncounter.hospitalizationWithObservation() + 48 hours]
      ).CrLabTime
    )
  )

define fluent function "earliestSerumCreatinineResult"(QualifyingEncounter Encounter):
  from
    "Qualifying Creatinine Lab Result By Time" LabTests
    let LabResult: LabTests.CrLabResult
    where ( "QualifyingEncounter".earliestSerumCreatinineTime ( ) = LabTests.CrLabTime )
    return LabResult as Quantity

define fluent function "earliestSerumCreatinineTime"(QualifyingEncounter Encounter):
  ( Min((from
          "Qualifying Creatinine Lab Result By Time" LabTestsEarly
          let LabResultEarly: LabTestsEarly.CrLabResult
          where LabTestsEarly.CrEncInPtId = QualifyingEncounter.id
      ).CrLabTime
    )
  )

define fluent function "highestSerumCreatinineResult"(QualifyingEncounter Encounter):
  ( Max((from
          "Qualifying Creatinine Lab Result By Time" LabTests
          let LabResult: LabTests.CrLabResult
          where LabTests.CrEncInPtId = QualifyingEncounter.id
      ).CrLabResult
    )
  )

define fluent function "oneAndAHalfIncreaseInCreatinine"(QualifyingEncounter Encounter):
  "QualifyingEncounter".highestSerumCreatinineResult ( ) / 1.5

define fluent function "lowestSerumCreatinineResult"(QualifyingEncounter Encounter):
  ( Min((from
          "Qualifying Creatinine Lab Result By Time" LabTests
          let LabResult: LabTests.CrLabResult
          where LabTests.CrEncInPtId = QualifyingEncounter.id
      ).CrLabResult
    )
  )

define "Risk Variable Estimated Glomerular Filtration Rate For Females":
  "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      eGFR: "QualifyingEncounter".femaleeGFR ( )
    }

define "Risk Variable Estimated Glomerular Filtration Rate For Males":
  "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      eGFR: "QualifyingEncounter".maleeGFR ( )
    }

define "Risk Variable All Encounter Diagnoses With POA Indication":
  from
    "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter,
    [Claim] clm
    where clm.status = 'active'
      and clm.use = 'claim'
      and exists ( clm.item ClaimItem
          where ClaimItem.encounter.references ( QualifyingEncounter )
            and exists ( clm.diagnosis Dx
                where Dx.sequence in clm.item.diagnosisSequence
                  and Dx.onAdmission in "Present on Admission or Clinically Undetermined"
            )
      )

define "Risk Variable First Heart Rate In Encounter":
  "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstHeartRate: "QualifyingEncounter".firstHeartRate ( )
    }

define "Risk Variable First Respiratory Rate In Encounter":
  "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstRespiratoryRate: "QualifyingEncounter".firstRespiratoryRate ( )
    }

define "Risk Variable First Systolic Blood Pressure In Encounter":
  "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstSystolicBP: "QualifyingEncounter".firstSystolicBloodPressure ( )
    }

define "Risk Variable First Temperature In Encounter":
  "Encounter With Creatinine And Without Obstetrical Conditions" QualifyingEncounter
    return Tuple {
      encounterId: QualifyingEncounter.id,
      firstTemperature: "QualifyingEncounter".firstBodyTemperature ( )
    }

define fluent function "firstBodyTemperature"(QualifyingEncounter Encounter):
  First(["USCoreBodyTemperatureProfile"] FirstTemperature
      where FirstTemperature.effective.earliest() during QualifyingEncounter.hospitalizationWithObservation()
        and FirstTemperature.value is not null
      sort by effective.earliest()
  ).value as Quantity

define fluent function "firstHeartRate"(QualifyingEncounter Encounter):
  First(["USCoreHeartRateProfile"] FirstHeartBeats
      where FirstHeartBeats.effective.earliest() during QualifyingEncounter.hospitalizationWithObservation()
        and FirstHeartBeats.value is not null
      sort by effective.earliest()
  ).value as Quantity

define fluent function "firstRespiratoryRate"(QualifyingEncounter Encounter):
  First(["USCoreRespiratoryRateProfile"] FirstRespiration
      where FirstRespiration.effective.earliest() during QualifyingEncounter.hospitalizationWithObservation()
        and FirstRespiration.value is not null
      sort by effective.earliest()
  ).value as Quantity

define fluent function "firstSystolicBloodPressure"(QualifyingEncounter Encounter):
  First("Qualifying Blood Pressure Reading" SBPReading
      where SBPReading.effective.earliest() during QualifyingEncounter.hospitalizationWithObservation()
      return singleton from(SBPReading.component SBPComponent
          where SBPComponent.code ~ "Systolic blood pressure"
          return SBPComponent.value as Quantity
      )
  )