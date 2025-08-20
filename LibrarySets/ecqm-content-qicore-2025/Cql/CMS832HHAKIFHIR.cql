library CMS832HHAKIFHIR version '0.2.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include CQMCommon version '4.1.000' called CQMCommon
include QICoreCommon version '4.0.000' called QICoreCommon
include CumulativeMedicationDuration version '6.0.000' called CMD
include HospitalHarm version '2.5.000' called HospitalHarm

codesystem "SNOMEDCT": 'http://snomed.info/sct'
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

code "Female (finding)": '248152002' from "SNOMEDCT" display 'Female'
code "Male (finding)": '248153007' from "SNOMEDCT" display 'Male'
code "Heart rate": '8867-4' from "LOINC" display 'Heart rate'
code "Respiratory rate": '9279-1' from "LOINC" display 'Respiratory rate'
code "Systolic blood pressure": '8480-6' from "LOINC" display 'Systolic blood pressure'

parameter "Measurement Period" Interval<DateTime>

context Patient

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

// -------------------------------- Population Definitions -----------------------------


define "Initial Population":
  "Encounter with Creatinine and without Obstetrical Conditions"

define "Denominator":
  "Initial Population"

define "Denominator Exclusion":
  "Encounter with Less Than 2 Creatinine Results within 48 Hours of Arrival" // clause 1
    
    union "Encounter with Index eGFR Less Than 60 within First 48 Hours"     // clause 2
    
    union "Encounter with 0.3 mg dL or More Increase in Creatinine"          // clause 3
    
    union "Encounter with Kidney Dialysis Started 48 Hours or Less After Arrival without High Creatinine"  // clause 4
    
    union "Encounter with High Risk Diagnosis for AKI"                       // clause 5
    
    union "Encounter with High Risk Procedures for AKI"                      // clause 6 


define "Numerator":
  "Encounter with 2 Times Serum Creatinine Increase" // clause 1
    
    union "Encounter with Kidney Dialysis Started More Than 48 Hours After Arrival without High Creatinine"   // clause 2


//-------------------------------- Supporting Definitions for Initial Population -----------------------------

// Supports Initial Population
// Used in other definitions throughout





define "Encounter with Creatinine and without Obstetrical Conditions":
  "Inpatient Encounter with Creatinine" EncounterWithCreatinine
    where not exists ( ( EncounterWithCreatinine.encounterDiagnosis ( ) ) EncounterDiagnosis
        where EncounterDiagnosis.code in "Obstetrics and VTE Obstetrics"
    )


// Supports Initial Population


define "Inpatient Encounter with Creatinine":
  from
    "Encounter with Age 18 and Length of Stay 48 Hours or More" Encounter48Hours,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] CreatinineTest
    let HospitalizationPeriod: Encounter48Hours.hospitalizationWithObservation ( ),
    CreatinineTestStart: CreatinineTest.effective.earliest ( )
    where CreatinineTest.value is not null
      and CreatinineTestStart during Interval[start of HospitalizationPeriod + 48 hours, end of HospitalizationPeriod]
      and CreatinineTest.status in { 'final', 'amended', 'corrected' }
    return Encounter48Hours
                
// Supports Initial Population

/*
define "Encounter with Age 18 and Length of Stay 48 Hours or More":
  ["Encounter": "Encounter Inpatient"] InpatientEncounter
                    where InpatientEncounter.period ends during day of "Measurement Period"
                        and AgeInYearsAt(date from start of InpatientEncounter.period)>= 18
                        and ( duration in hours of InpatientEncounter.hospitalizationWithObservation() >= 48 )*/ 



define "Encounter with Age 18 and Length of Stay 48 Hours or More":
  ["Encounter": "Encounter Inpatient"] InpatientEncounter
    where Patient.sex in { '248153007', '248152002' }
      and InpatientEncounter.period ends during day of "Measurement Period"
      and AgeInYearsAt(date from start of InpatientEncounter.period) >= 18
      and ( duration in hours of InpatientEncounter.hospitalizationWithObservation ( ) >= 48 )

// -------------------------------- Supporting Definitions for Denominator Exclusion  -----------------------------

// Denominator Exclusion clause 1



define "Encounter with Less Than 2 Creatinine Results within 48 Hours of Arrival":
  "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    where ( Count("CreatinineLabTestwithResultwithinFirst48Hours"(QualifyingEncounter)) < 2 ) 

// Denonminator Exclusion clause 2


define "Encounter with Index eGFR Less Than 60 within First 48 Hours":
  "Male Encounter with eGFR Less Than 60"
    union "Female Encounter with eGFR Less Than 60"

// Supporting Denominator Exclusion clause 2    


define "Female Encounter with eGFR Less Than 60":
  "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    where "FemaleeGFR"(QualifyingEncounter) is not null
      and "FemaleeGFR"(QualifyingEncounter) as Decimal < 60

// Supporting Denominator Exclusion clause 2  


define "Male Encounter with eGFR Less Than 60":
  "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    where "MaleeGFR"(QualifyingEncounter) is not null
      and "MaleeGFR"(QualifyingEncounter) as Decimal < 60

// Denominator Exclusion clause 3  (Coalesce doesn't seem to work as intended)


define "Encounter with 0.3 mg dL or More Increase in Creatinine":
  "Increase of 0.3 or More Using Lowest Creatinine within 24 Hours"
    union "Increase of 0.3 or More Using First Creatinine within First 48 Hours"

   
//define "Encounter with 0.3 mg dL or More Increase in Creatinine":
  //Coalesce("Increase of 0.3 or More Using Lowest Creatinine within 24 Hours","Increase of 0.3 or More Using First Creatinine within First 48 Hours")

/*
define "Encounter with 0.3 mg dL or More Increase in Creatinine":
  case
    when "Increase of 0.3 or More Using Lowest Creatinine within 24 Hours" is not null
      then "Increase of 0.3 or More Using Lowest Creatinine within 24 Hours"
    when "Increase of 0.3 or More Using First Creatinine within First 48 Hours" is not null
      then "Increase of 0.3 or More Using First Creatinine within First 48 Hours"
    else null
  end */

  
// Supporting Denominator Exclusion clause 3





define "Increase of 0.3 or More Using Lowest Creatinine within 24 Hours":
  from
    "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] IndexCreatinineLabResult,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] SubsequentCreatinineLabResult
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

// Supporting Denominator Exclusion clause 3            


define "Increase of 0.3 or More Using First Creatinine within First 48 Hours":
  from
    "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] IndexCreatinineLabResult,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] SubsequentCreatinineLabResult
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
 
// Denominator Exclusion clause 4


define "Encounter with Kidney Dialysis Started 48 Hours or Less After Arrival without High Creatinine":
  "Encounter with Kidney Dialysis Started 48 Hours or Less After Arrival" EncounterWithKidneyDialysis48HoursOrAfter
    where not ( exists ( "Encounter with 2 Times Serum Creatinine Increase" EncounterWithHighCreatinine
          where ( EncounterWithHighCreatinine.period includes EncounterWithKidneyDialysis48HoursOrAfter.period )
      )
    )
 
// Supporting Denominator Exclusion clause 4


define "Encounter with Kidney Dialysis Started 48 Hours or Less After Arrival":
  from
    ["Procedure": "Hospital Based Dialysis Services"] Dialysis,
    "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    let HospitalWithObservationPeriod: QualifyingEncounter.hospitalizationWithObservation ( )
    where Dialysis.performed.toInterval ( ) starts during Interval[start of HospitalWithObservationPeriod, start of HospitalWithObservationPeriod + 48 hours]
      and Dialysis.performed.toInterval ( ) starts during HospitalWithObservationPeriod
    return QualifyingEncounter


// Supporting Denominator Exclusion clause 4
// Also Supporting Numerator clause 1



define "Encounter with 2 Times Serum Creatinine Increase":
  from
    "Encounter with 1.5 Times Serum Creatinine Increase" EncounterWithHighCreatinine,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] HighCreatinineTest,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] LowCreatinineTest
    let LowCreatinineTestTime: LowCreatinineTest.effective.earliest ( ),
    HighCreatinineTestTime: HighCreatinineTest.effective.earliest ( ),
    HospitalWithObservationPeriod: EncounterWithHighCreatinine.hospitalizationWithObservation ( )
    where ( HighCreatinineTest.value > "Serum Creatinine Normal" )
      and LowCreatinineTest.status in { 'final', 'amended', 'corrected' }
      and HighCreatinineTest.status in { 'final', 'amended', 'corrected' }
      and HighCreatinineTest.value = "HighestSerumCreatinineResult"(EncounterWithHighCreatinine)
      and LowCreatinineTest.value = "LowestSerumCreatinineResult"(EncounterWithHighCreatinine)
      and ( HighCreatinineTest.value as Quantity ) >= ( LowCreatinineTest.value as Quantity )
      and LowCreatinineTestTime 7 days or less before HighCreatinineTestTime
      and LowCreatinineTestTime during HospitalWithObservationPeriod
      and HighCreatinineTestTime during Interval[start of HospitalWithObservationPeriod + 48 hours, start of HospitalWithObservationPeriod + 30 days]
      and HighCreatinineTestTime during HospitalWithObservationPeriod
    return EncounterWithHighCreatinine



// Supports "Encounter with 2 Times Serum Creatinine Increase"
// Supports "Encounter with 1.5 Times Serum Creatinine Increase"



define "Serum Creatinine Normal":
  if ( Patient.sex = '248152002' ) then 1.02 'mg/dL' 
    else 1.18 'mg/dL' 


// Denominator Exclusion clause 5


define "Encounter with High Risk Diagnosis for AKI":
  "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    where exists ( ( QualifyingEncounter.encounterDiagnosis ( ) ) EncounterDiagnosis
        where ( EncounterDiagnosis.code in "High Risk Diagnosis for AKI" )
    )


// Denominator Exclusion clause 6


define "Encounter with High Risk Procedures for AKI":
  "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    with ["Procedure": "High Risk Procedures for AKI"] HighRiskProcedures
      such that HighRiskProcedures.performed.toInterval ( ) starts during QualifyingEncounter.hospitalizationWithObservation ( )


// -------------------------------- Supporting Definitions for Numerator  -----------------------------

// Numerator clause 1:  See "Encounter with 2 Times Serum Creatinine Increase"

// Numerator union clause 2




define "Encounter with Kidney Dialysis Started More Than 48 Hours After Arrival without High Creatinine":
  "Encounter with Kidney Dialysis Started More Than 48 Hours After Arrival" EncounterWithDialysisAfter48Hours
    where not ( exists ( "Encounter with 2 Times Serum Creatinine Increase" EncounterWithHighCreatinine
          where ( EncounterWithHighCreatinine.period includes EncounterWithDialysisAfter48Hours.period )
      )
    )

// Supports Numerator union clause 2


define "Encounter with Kidney Dialysis Started More Than 48 Hours After Arrival":
  from
    ["Procedure": "Hospital Based Dialysis Services"] Dialysis,
    "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter
    let HospitalWithObservationPeriod: QualifyingEncounter.hospitalizationWithObservation ( )
    where Dialysis.performed.toInterval ( ) starts during Interval[start of HospitalWithObservationPeriod + 48 hours, end of HospitalWithObservationPeriod]
      and Dialysis.performed.toInterval ( ) starts during HospitalWithObservationPeriod
    return QualifyingEncounter


// -------------------------------- Supporting Definitions for Creatinine calculations -----------------------------

// Used throughout creatinine functions and defines  



define "Qualifying Creatinine Lab Result by Time":
  from
    "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter,
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

// Supporting Denominator Exclusion clause 4
// Supporting Numerator               



define "Encounter with 1.5 Times Serum Creatinine Increase":
  from
    "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] HighCreatinineTest,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] LowCreatinineTest
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

/*
define "Encounter with 1.5 Times Serum Creatinine Increase":
  from
    "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter,
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] CreatinineTest
  let 
    LowestCreatinineTestWithin7DaysPrior: "LowestSerumCreatinineWithin7DaysPrior"(QualifyingEncounter, CreatinineTest),
    CreatinineTestTime: CreatinineTest.effective.earliest(),
    HospitalWithObservationPeriod: QualifyingEncounter.hospitalizationWithObservation()
  where 
    CreatinineTest.value >= LowestCreatinineTestWithin7DaysPrior * 1.5
    and CreatinineTest.value > "Serum Creatinine Normal"
    and CreatinineTestTime during Interval[start of HospitalWithObservationPeriod + 48 hours, start of HospitalWithObservationPeriod + 30 days]
  return QualifyingEncounter*/
            

// -------------------------------- Supporting Functions  for Creatinine calculations  -----------------------------

// Supports Denominator Exclusion clause 1




define function "CreatinineLabTestwithResultwithinFirst48Hours"(QualifyingEncounter Encounter):
  from
    ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] CreatinineTest
    where CreatinineTest.value is not null
      and CreatinineTest.effective.earliest ( ) during Interval[start of QualifyingEncounter.hospitalizationWithObservation ( ), start of QualifyingEncounter.hospitalizationWithObservation ( ) + 48 hours]
      and CreatinineTest.effective.earliest ( ) during QualifyingEncounter.hospitalizationWithObservation ( )
      and CreatinineTest.status in { 'final', 'amended', 'corrected' }
    return CreatinineTest

// eGFR functions return as decimal value rather than Quantity
// Supports Denominator Exclusion clause 2
// Supports risk variable "Risk Variable Estimated Glomerular Filtration Rate for Females"




define function "FemaleeGFR"(QualifyingEncounter Encounter):
  if Patient.sex = '248152002' then ( 142 * Min({("IndexCreatinine"(QualifyingEncounter).value / 0.7), 1 }) ^ ( - 0.241 ) * Max({("IndexCreatinine"(QualifyingEncounter).value / 0.7), 1 }) ^ ( - 1.200 ) * 0.9938 ^ ( AgeInYearsAt(start of QualifyingEncounter.hospitalizationWithObservation()) ) * 1.012 ) 
    else null

// eGFR functions return as decimal value rather than Quantity
// Supports Denominator Exclusion clause 2
// Supports risk variable "Risk Variable Estimated Glomerular Filtration Rate for Females"




define function "MaleeGFR"(QualifyingEncounter Encounter):
  if Patient.sex = '248153007' then ( 142 * Min({("IndexCreatinine"(QualifyingEncounter).value / 0.9), 1 }) ^ ( - 0.302 ) * Max({("IndexCreatinine"(QualifyingEncounter).value / 0.9), 1 }) ^ ( - 1.200 ) * 0.9938 ^ ( AgeInYearsAt(start of QualifyingEncounter.hospitalizationWithObservation()) ) ) 
    else null


// Used in GFR calculations, above


define function "IndexCreatinine"(QualifyingEncounter Encounter):
  Coalesce("LowestSerumCreatinineIn24Hours"(QualifyingEncounter), singleton from "FirstSerumCreatinineIn48Hours"(QualifyingEncounter))  

// Supports IndexCreatinine function  


define function "LowestSerumCreatinineIn24Hours"(QualifyingEncounter Encounter):
  Min((from
        "Qualifying Creatinine Lab Result by Time" LabTestsLow
        let LabResult: LabTestsLow.CrLabResult
        where LabTestsLow.CrEncInPtId = QualifyingEncounter.id
          and LabTestsLow.CrLabTime during Interval[start of QualifyingEncounter.hospitalizationWithObservation(), start of QualifyingEncounter.hospitalizationWithObservation() + 24 hours]
    ).CrLabResult
  ) 

// Find result from earliest time in 48 hrs
// Supports IndexCreatinine function



define function "FirstSerumCreatinineIn48Hours"(QualifyingEncounter Encounter):
  from
    "Qualifying Creatinine Lab Result by Time" LabTests
    let LabResult: LabTests.CrLabResult
    where ( "EarliestSerumCreatinineTimeIn48Hours"(QualifyingEncounter) = LabTests.CrLabTime )
    return LabResult as Quantity


// Find earliest time in 48 hrs
// Supports FirstSerumCreatinineIn48Hours function



define function "EarliestSerumCreatinineTimeIn48Hours"(QualifyingEncounter Encounter):
  ( Min((from
          "Qualifying Creatinine Lab Result by Time" LabTests48
          let LabResult48: LabTests48.CrLabResult
          where LabTests48.CrEncInPtId = QualifyingEncounter.id
            and LabTests48.CrLabTime during Interval[start of QualifyingEncounter.hospitalizationWithObservation(), start of QualifyingEncounter.hospitalizationWithObservation() + 48 hours]
      ).CrLabTime
    )
  )

// Supports Denominator Exclusion clause 3


define function "EarliestSerumCreatinineResult"(QualifyingEncounter Encounter):
  from
    "Qualifying Creatinine Lab Result by Time" LabTests
    let LabResult: LabTests.CrLabResult
    where ( "EarliestSerumCreatinineTime"(QualifyingEncounter) = LabTests.CrLabTime )
    return LabResult as Quantity

//  Supports Denominator Exclusion clause 3 via "EarliestSerumCreatinineResult" function  


define function "EarliestSerumCreatinineTime"(QualifyingEncounter Encounter):
  ( Min((from
          "Qualifying Creatinine Lab Result by Time" LabTestsEarly
          let LabResultEarly: LabTestsEarly.CrLabResult
          where LabTestsEarly.CrEncInPtId = QualifyingEncounter.id
      ).CrLabTime
    )
  )

// Not used anywhere


define function "SerumCreatinineSequencebyTime"(QualifyingEncounter Encounter):
  ["LaboratoryResultObservation": "Creatinine Mass Per Volume"] CreatinineTestByTime
    let HospitalWithObservation: QualifyingEncounter.hospitalization ( )
    where CreatinineTestByTime.effective.earliest ( ) during HospitalWithObservation
      and CreatinineTestByTime.value is not null
      and CreatinineTestByTime.isLaboratory ( )
      and CreatinineTestByTime.status in { 'final', 'amended', 'corrected' }
    return CreatinineTestByTime

// The following functions work with Cr result as Quantity (not decimal, but Quantity value is decimal)

// Supporting Denominator Exclusion clause 4 via "Encounter with 2 Times Serum Creatinine Increase"
// Supporting Numerator via "Encounter with 2 Times Serum Creatinine Increase"




define function "HighestSerumCreatinineResult"(QualifyingEncounter Encounter):
  ( Max((from
          "Qualifying Creatinine Lab Result by Time" LabTests
          let LabResult: LabTests.CrLabResult
          where LabTests.CrEncInPtId = QualifyingEncounter.id
      ).CrLabResult
    )
  )

// Supporting Denominator Exclusion clause 4 via "Encounter with 1.5 Times Serum Creatinine Increase"
// Supporting Numerator  via "Encounter with 1.5 Times Serum Creatinine Increase"             



define function "1.5IncreaseInCreatinine"(QualifyingEncounter Encounter):
  "HighestSerumCreatinineResult"(QualifyingEncounter) / 1.5

// Supporting Denominator Exclusion clause 4 via "Encounter with 1.5 Times Serum Creatinine Increase"
// Supporting Numerator  via "Encounter with 1.5 Times Serum Creatinine Increase"             



define function "2.0IncreaseInCreatinine"(QualifyingEncounter Encounter):
  "HighestSerumCreatinineResult"(QualifyingEncounter) / 2

// Supporting Denominator Exclusion clause 3 via "Increase of 0.3 or More Using Lowest Creatinine within 24 Hours"
// and clause 4 via "Encounter with 1.5 Times Serum Creatinine Increase"
// Supporting Numerator  via "Encounter with 1.5 Times Serum Creatinine Increase"             




define function "LowestSerumCreatinineResult"(QualifyingEncounter Encounter):
  ( Min((from
          "Qualifying Creatinine Lab Result by Time" LabTests
          let LabResult: LabTests.CrLabResult
          where LabTests.CrEncInPtId = QualifyingEncounter.id
      ).CrLabResult
    )
  )

// -------------------------------- Risk Variable Definitions  -----------------------------


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
  from
    "Encounter with Creatinine and without Obstetrical Conditions" QualifyingEncounter,
    [Claim] claim
    where claim.status = 'active'
      and claim.use = 'claim'
      and exists ( claim.item I
          where I.encounter.references ( QualifyingEncounter )
            and exists ( claim.diagnosis D
                where D.sequence in claim.item.diagnosisSequence
                  and D.onAdmission in "Present on Admission or Clinically Undetermined"
            )
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

// -------------------------------- Risk Variable supportin functions  -----------------------------


define function "FirstBodyTemperature"(QualifyingEncounter Encounter):
  First(["USCoreBodyTemperatureProfile": "Body temperature"] FirstTemperature
      where FirstTemperature.effective.earliest() during QualifyingEncounter.hospitalizationWithObservation()
        and FirstTemperature.value is not null
      sort by effective.earliest()
  ).value as Quantity

define function "FirstHeartRate"(QualifyingEncounter Encounter):
  First(["USCoreHeartRateProfile": "Heart rate"] FirstHeartBeats
      where FirstHeartBeats.effective.earliest() during QualifyingEncounter.hospitalizationWithObservation()
        and FirstHeartBeats.value is not null
      sort by effective.earliest()
  ).value as Quantity

define function "FirstRespiratoryRate"(QualifyingEncounter Encounter):
  First(["USCoreRespiratoryRateProfile": "Respiratory rate"] FirstRespiration
      where FirstRespiration.effective.earliest() during QualifyingEncounter.hospitalizationWithObservation()
        and FirstRespiration.value is not null
      sort by effective.earliest()
  ).value as Quantity

define "Qualifying Systolic Blood Pressure Reading":
  ["USCoreBloodPressureProfile"] BloodPressure
    where BloodPressure.effective.earliest ( ) during day of "Measurement Period"

define function "FirstSystolicBloodPressure"(QualifyingEncounter Encounter):
  First("Qualifying Systolic Blood Pressure Reading" SBPReading
      where SBPReading.effective.earliest() during QualifyingEncounter.hospitalizationWithObservation()
      return singleton from(SBPReading.component SBPComponent
          where SBPComponent.code ~ "Systolic blood pressure"
          return SBPComponent.value as Quantity
      )
  )
/* 
define function "FirstSystolicBloodPressureTest"(QualifyingEncounter Encounter ):
  First(["USCoreBloodPressureProfile": "Systolic blood pressure"] FirstSystolic
      where FirstSystolic.effective.earliest() during QualifyingEncounter.hospitalizationWithObservation()
        and FirstSystolic.value is not null
      sort by effective.earliest()
  ).value as Quantity
*/

// --------------------------------- Temporary debugging defines should go here ---------------------------------------------------

