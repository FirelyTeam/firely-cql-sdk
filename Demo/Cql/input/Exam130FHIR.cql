library Exam130FHIR version '0.0.003'
/* 20220609 modified from ColorectalCancerScreeningsFHIR
default Interval, colonoscopy with inappropriate status, MP 2021, 
display order and test case content definitions to assist edge testing, may need to increment increment version number */
using FHIR version '4.0.1'

include FHIRHelpers version '4.0.001' called FHIRHelpers
include SupplementalDataElementsFHIR4 version '2.0.000' called SDE
include MATGlobalCommonFunctionsFHIR4 version '6.1.000' called Global
include AdultOutpatientEncountersFHIR4 version '2.2.000' called AdultOutpatientEncounters
include HospiceFHIR4 version '2.3.000' called Hospice
include AdvancedIllnessandFrailtyExclusionECQMFHIR4 version '5.17.000' called FrailtyLTI
include PalliativeCareFHIR version '0.6.000' called PalliativeCare
include CumulativeMedicationDurationFHIR4 version '1.0.000' called CMD

codesystem "ObservationCategoryCodes": 'http://terminology.hl7.org/CodeSystem/observation-category' 

valueset "Acute Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1083' 
valueset "Advanced Illness": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1082' 
valueset "Annual Wellness Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240' 
valueset "Care Services in Long-Term Residential Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014' 
valueset "Colonoscopy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1020' 
valueset "CT Colonography": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1038' 
valueset "Dementia Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1510' 
valueset "Discharged to Health Care Facility for Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207' 
valueset "Discharged to Home for Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209' 
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307' 
valueset "Fecal Occult Blood Test (FOBT)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1011' 
valueset "FIT DNA": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1039' 
valueset "Flexible Sigmoidoscopy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1010' 
valueset "Frailty Device": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.118.12.1300' 
valueset "Frailty Diagnosis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1074' 
valueset "Frailty Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1088' 
valueset "Frailty Symptom": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.113.12.1075' 
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016' 
valueset "Hospice care ambulatory": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15' 
valueset "Malignant Neoplasm of Colon": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1001' 
valueset "Nonacute Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1084' 
valueset "Nursing Facility Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012' 
valueset "Observation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1086' 
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001' 
valueset "Online Assessments": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089' 
valueset "Outpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087' 
valueset "Preventive Care Services - Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025' 
valueset "Preventive Care Services-Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023' 
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080' 
valueset "Total Colectomy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1019' 
// add for Condition
valueset "Total Colectomy ICD9": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.11.1136' 


code "laboratory": 'laboratory' from "ObservationCategoryCodes" display 'laboratory'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2021-01-01T00:00:00.0, @2022-01-01T00:00:00.0)

context Patient

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Telehealth Services":
  ( [Encounter: "Online Assessments"]
            union [Encounter: "Telephone Visits"] ) TelehealthEncounter
            where TelehealthEncounter.status = 'finished'
              and Global."Normalize Interval" ( TelehealthEncounter.period ) during "Measurement Period"

/* add display of age to result output for edge testing*/
define "Age at start of Measurement Period":
  AgeInYearsAt(date from start of "Measurement Period")


define "Initial Population":
  AgeInYearsAt(date from start of "Measurement Period")in Interval[51, 75 )
    and exists ( AdultOutpatientEncounters."Qualifying Encounters"
      union "Telehealth Services"
    )

define "Denominator":
  "Initial Population"

// add "Total Colectomy Condition" for DxCodes
define "Denominator Exclusions":
  Hospice."Has Hospice"
            or exists "Malignant Neoplasm"
            or exists "Total Colectomy Performed"
            or exists "Total Colectomy Condition"
            or FrailtyLTI."Advanced Illness and Frailty Exclusion Not Including Over Age 80"
            or ( AgeInYearsAt(date from start of "Measurement Period")>= 65
                and FrailtyLTI."Has Long Term Care Periods Longer Than 90 Consecutive Days"
            )
            or PalliativeCare."Palliative Care in the Measurement Period"

define "Malignant Neoplasm":
  [Condition: "Malignant Neoplasm of Colon"] ColorectalCancer
            where Global."Prevalence Period" ( ColorectalCancer ) starts on or before 
              end of "Measurement Period"

define "Total Colectomy Performed":
  [Procedure: "Total Colectomy"] Colectomy
            where Colectomy.status = 'completed'
              and Global."Normalize Interval" ( Colectomy.performed ) ends on or before 
              end of "Measurement Period"

// add Condition for DxCodes
define "Total Colectomy Condition":
  [Condition: "Total Colectomy ICD9"] ColectomyDx
              where Global."Prevalence Period" ( ColectomyDx ) starts on or before
              end of "Measurement Period"


// --- Fecal Occult Blood Test ---

// add definition to Display Date, Result, Category, Status of hemoccult, 2 year for edge testing
define "Fecal Occult Blood Test Display Date, Result, Category, Status":
  [Observation: "Fecal Occult Blood Test (FOBT)"] FecalOccult
    where Global."Latest" ( FecalOccult.effective ) during Interval ( start of "Measurement Period" - 1 year, end of "Measurement Period" )
    return Tuple { 
      occultDate: Global."Latest" ( FecalOccult.effective ),
      occultResult: FecalOccult.value.coding.display,
      occultCategoryCode: FecalOccult.category.coding.code.value,
      occultStatus: FecalOccult.status 
    }

// add- PROBLEM - category evaluation was not working - THIS WORKS
define "Fecal Occult Blood Test Performed":
  [Observation: "Fecal Occult Blood Test (FOBT)"] FecalOccult
            where FecalOccult.status in { 'final', 'amended', 'corrected' }
              and exists ( FecalOccult.category FecalOccultCategory
                  where FecalOccultCategory.coding.code.value  ~ { 'laboratory' } )
              and FecalOccult.value is not null
              and Global."Latest" ( FecalOccult.effective ) during "Measurement Period"

// add - PROBLEM - TZoffset issue corrected by use of 'day of' - THIS WORKS
define "Fecal Occult Blood Test Performed, day of TZoffset":
  [Observation: "Fecal Occult Blood Test (FOBT)"] FecalOccult
            where FecalOccult.status in { 'final', 'amended', 'corrected' }
              and exists ( FecalOccult.category FecalOccultCategory
                  where FecalOccultCategory.coding.code.value  ~ { 'laboratory' } )
              and FecalOccult.value is not null
              and Global."Latest" ( FecalOccult.effective ) during day of "Measurement Period"

// add for edge testing of category but ignore status, use day of for TZoffset issue
// consider potential for presence of EHR data as category 'exam', 'procedure', 'survey' ??? 
define "Fecal Occult Blood Test Performed without appropriate category, ignore status, day of TZoffset":
  [Observation: "Fecal Occult Blood Test (FOBT)"] FecalOccult
            where 
//             FecalOccult.status in { 'final', 'amended', 'corrected' }
//              and 
              exists ( FecalOccult.category FecalOccultCategory
                  where FecalOccultCategory.coding.code.value  !~ { 'laboratory' } )
              and FecalOccult.value is not null
              and Global."Latest" ( FecalOccult.effective ) during day of "Measurement Period"

// add for edge testing of status but ignore category, use day of for TZoffset issue
define "Fecal Occult Blood Test Performed without appropriate status, ignore category, day of TZoffset":
  [Observation: "Fecal Occult Blood Test (FOBT)"] FecalOccult
            where not ( FecalOccult.status in { 'final', 'amended', 'corrected' } )
//              and exists ( FecalOccult.category FecalOccultCategory
//                  where FecalOccultCategory.coding.code.value  ~ { 'laboratory' } )
              and FecalOccult.value is not null
              and Global."Latest" ( FecalOccult.effective ) during day of "Measurement Period"


// --- Fecal Immunochemical Test DNA ---

// add definition to Display Date, Result, Category, Status of FitDNA, 4 year for edge testing
define "Fecal Immunochemical Test DNA Display Date, Result, Category, Status":
  [Observation: "FIT DNA"] FitDNA
    where Global."Latest" ( FitDNA.effective )  4 years or less on or before 
      end of "Measurement Period"
    return Tuple { 
      occultDate: Global."Latest" ( FitDNA.effective ),
      occultResult: FitDNA.value.coding.display,
      occultCategoryCode: FitDNA.category.coding.code.value,
      occultStatus: FitDNA.status 
    }

// add - PROBLEM - category evaluation was not working - THIS WORKS
define "Fecal Immunochemical Test DNA Performed":
  [Observation: "FIT DNA"] FitDNA
            where FitDNA.status in { 'final', 'amended', 'corrected' }
              and exists ( FitDNA.category FitDNACategory
                  where FitDNACategory.coding.code.value  ~ { 'laboratory' } )
              and FitDNA.value is not null
              and Global."Latest" ( FitDNA.effective ) 3 years or less on or before 
              end of "Measurement Period"

// add - PROBLEM - TZoffset issue corrected by use of 'day of' - THIS WORKS
define "Fecal Immunochemical Test DNA Performed, day of TZoffset":
  [Observation: "FIT DNA"] FitDNA
            where FitDNA.status in { 'final', 'amended', 'corrected' }
              and exists ( FitDNA.category FitDNACategory
                  where FitDNACategory.coding.code.value  ~ { 'laboratory' } )
              and FitDNA.value is not null
              and Global."Latest" ( FitDNA.effective ) 3 years or less on or before 
              day of end of "Measurement Period"

// add for edge testing of category but ignore status, use day of for TZoffset issue
// consider potential for presence of EHR data as category 'exam', 'procedure', 'survey' ??? 
define "Fecal Immunochemical Test DNA Performed without appropriate category, ignore status, day of TZoffset":
  [Observation: "FIT DNA"] FitDNA
            where 
//            FitDNA.status in { 'final', 'amended', 'corrected' }
//              and 
              exists ( FitDNA.category FitDNACategory
                  where FitDNACategory.coding.code.value  !~ { 'laboratory' } )
              and FitDNA.value is not null
              and Global."Latest" ( FitDNA.effective ) 3 years or less on or before 
              day of end of "Measurement Period"

/* add for edge testing of status but ignore category, use day of for TZoffset issue*/
define "Fecal Immunochemical Test DNA Performed without appropriate status, ignore category, day of TZoffset":
  [Observation: "FIT DNA"] FitDNA
            where not ( FitDNA.status in { 'final', 'amended', 'corrected' } )
//              and exists ( FitDNA.category FitDNACategory
//                  where FitDNACategory.coding.code.value  ~ { 'laboratory' } )
              and FitDNA.value is not null
              and Global."Latest" ( FitDNA.effective ) 3 years or less on or before 
              day of end of "Measurement Period"


// --- CT Colonography ---

// add definition to Display Date of Colonography as 6 years for edge testing
define "CT Colonography Display Date":
  [Observation: "CT Colonography"] Colonography
    let ctDate: Global."Latest" ( Colonography.effective )
            where Global."Normalize Interval" ( Colonography.effective ) ends 6 years or less on or before 
              end of "Measurement Period"
  return ctDate

define "CT Colonography Performed":
  [Observation: "CT Colonography"] Colonography
            where Colonography.status in { 'final', 'amended', 'corrected', 'appended' }
              and Global."Normalize Interval" ( Colonography.effective ) ends 5 years or less on or before 
              end of "Measurement Period"

// add for edge testing of status, caution re status
define "CT Colonography Performed without appropriate status":
  [Observation: "CT Colonography"] Colonography
            where not ( Colonography.status in { 'final', 'amended', 'corrected', 'appended' } )
              and Global."Normalize Interval" ( Colonography.effective ) ends 5 years or less on or before 
              end of "Measurement Period"


// --- Flexible Sigmoidoscopy ---

// add definition to Display Date of sigmoidoscopy as 6 years for edge testing 
define "Flexible Sigmoidoscopy Display Date":
  [Procedure: "Flexible Sigmoidoscopy"] FlexibleSigmoidoscopy
    let sigmoidDate: Global."Latest" ( FlexibleSigmoidoscopy.performed )
    where Global."Normalize Interval" ( FlexibleSigmoidoscopy.performed ) ends 6 years or less on or before 
      end of "Measurement Period"
    return sigmoidDate

define "Flexible Sigmoidoscopy Performed":
  [Procedure: "Flexible Sigmoidoscopy"] FlexibleSigmoidoscopy
            where FlexibleSigmoidoscopy.status = 'completed'
              and Global."Normalize Interval" ( FlexibleSigmoidoscopy.performed ) ends 5 years or less on or before 
              end of "Measurement Period"

// add for edge testing of status, caution re status 
define "Flexible Sigmoidoscopy Performed without appropriate status":
  [Procedure: "Flexible Sigmoidoscopy"] FlexibleSigmoidoscopy
            where not ( FlexibleSigmoidoscopy.status = 'completed' )
              and Global."Normalize Interval" ( FlexibleSigmoidoscopy.performed ) ends 5 years or less on or before 
              end of "Measurement Period"


// --- Colonoscopy ---

// add definition to Display Date of colonoscopy as 11 years for edge testing 
define "Colonoscopy Display Date":
  [Procedure: "Colonoscopy"] Colonoscopy
    let colonoscopyDate: Global."Latest" ( Colonoscopy.performed )
    where Global."Normalize Interval" ( Colonoscopy.performed ) ends 11 years or less on or before 
      end of "Measurement Period"
    return colonoscopyDate      

define "Colonoscopy Performed":
  [Procedure: "Colonoscopy"] Colonoscopy
            where Colonoscopy.status = 'completed'
              and Global."Normalize Interval" ( Colonoscopy.performed ) ends 10 years or less on or before 
              end of "Measurement Period"

// add for edge testing of status 
define "Colonoscopy Performed without appropriate status":
  [Procedure: "Colonoscopy"] Colonoscopy
            where not ( Colonoscopy.status = 'completed' )
              and Global."Normalize Interval" ( Colonoscopy.performed ) ends 10 years or less on or before 
              end of "Measurement Period"

define "Numerator":
  exists "Colonoscopy Performed"
            or exists "Fecal Occult Blood Test Performed"
            or exists "Flexible Sigmoidoscopy Performed"
            or exists "Fecal Immunochemical Test DNA Performed"
            or exists "CT Colonography Performed"

// add Final Numerator Population in IP DENOM not in DENEX
define "Final Numerator Population":
  "Numerator" 
  and "Initial Population"
  and "Denominator"
  and not "Denominator Exclusions"



