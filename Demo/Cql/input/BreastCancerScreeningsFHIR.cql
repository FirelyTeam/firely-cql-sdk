library BreastCancerScreeningsFHIR version '0.0.009'
/* 20220609 modified valueset, Numer, Diagnostic Report, MP 2021
may need to increment increment version number */
using FHIR version '4.0.1'

include FHIRHelpers version '4.0.001' called FHIRHelpers
include SupplementalDataElementsFHIR4 version '2.0.000' called SDE
include MATGlobalCommonFunctionsFHIR4 version '6.1.000' called Global
include AdultOutpatientEncountersFHIR4 version '2.2.000' called AdultOutpatientEncounters
include AdvancedIllnessandFrailtyExclusionECQMFHIR4 version '5.17.000' called FrailtyLTI
include PalliativeCareFHIR version '0.6.000' called PalliativeCare
include CumulativeMedicationDurationFHIR4 version '1.0.000' called CMD
include HospiceFHIR4 version '2.3.000' called Hospice

valueset "Bilateral Mastectomy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1005'
valueset "History of bilateral mastectomy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1068'
valueset "Left": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1036'
//valueset "Mammography": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.12.1018'
// PJM above valueset not expanded
valueset "Mammography": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.108.11.1047'
valueset "Online Assessments": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'
valueset "Right": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1035'
valueset "Status Post Left Mastectomy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1069'
valueset "Status Post Right Mastectomy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1070'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'
valueset "Unilateral Mastectomy Left": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1133'
valueset "Unilateral Mastectomy Right": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1134'
valueset "Unilateral Mastectomy, Unspecified Laterality": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1071'

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

/* add age to result output */
define "Age at start of Measurement Period":
  AgeInYearsAt(date from start of "Measurement Period")

define "Initial Population":
  AgeInYearsAt(date from start of "Measurement Period")in Interval[51, 74 )
                  and Patient.gender = 'female'
                  and exists ( AdultOutpatientEncounters."Qualifying Encounters"
                      union "Telehealth Services"
                  )

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  ( Hospice."Has Hospice"
                    or ( ( exists "Right Mastectomy Diagnosis"
                          or exists "Right Mastectomy Procedure"
                      )
                        and ( exists "Left Mastectomy Diagnosis"
                            or exists "Left Mastectomy Procedure"
                        )
                    )
                    or exists "Bilateral Mastectomy Diagnosis"
                    or exists "Bilateral Mastectomy Procedure"
                    or ( FrailtyLTI."Advanced Illness and Frailty Exclusion Not Including Over Age 80" )
                    or ( AgeInYearsAt(date from start of "Measurement Period")>= 65
                        and FrailtyLTI."Has Long Term Care Periods Longer Than 90 Consecutive Days"
                    )
                    or PalliativeCare."Palliative Care in the Measurement Period"
                )

/* original Numerator definition */
/*
define "Numerator":
  exists ( [Observation: "Mammography"] Mammogram
                    where Mammogram.status in { 'final', 'amended', 'corrected', 'appended' }
                      and ( Global."Normalize Interval" ( Mammogram.effective ) ends 27 months or less on or before
                        end of "Measurement Period"
                      )
                )
*/

/* new definition to capture base FHIR observation or USCore Diagnostic Report */
define "Numerator":
  "Observation with status"
    or "Diagnostic Report with status"

/* Final Numerator Population in IP DENOM not in DENEX */
define "Final Numerator Population":
  "Numerator" 
  and "Initial Population"
  and "Denominator"
  and not "Denominator Exclusions"

/* renamed definition to capture base FHIR observation */
define "Observation with status":
  exists ( [Observation: "Mammography"] Mammogram
                    where Mammogram.status in { 'final', 'amended', 'corrected', 'appended' }
                      and ( Global."Normalize Interval" ( Mammogram.effective ) ends 27 months or less on or before
                        end of "Measurement Period"
                      )
                )

/* new definition to capture base FHIR observation where status not appropriate */
define "Observation without appropriate status":
  exists ( [Observation: "Mammography"] Mammogram
                    where not ( Mammogram.status in { 'final', 'amended', 'corrected', 'appended' } )
                      and ( Global."Normalize Interval" ( Mammogram.effective ) ends 27 months or less on or before
                        end of "Measurement Period"
                      )
                )

/* new definition to capture USCore Diagnostic Report (note that Imaging Study contains DICOM data ) */
define "Diagnostic Report with status":
  exists ( [DiagnosticReport: "Mammography"] Mammogram
                    where Mammogram.status in { 'final', 'amended', 'corrected', 'appended' }
                      and ( Global."Normalize Interval" ( Mammogram.effective ) ends 27 months or less on or before
                        end of "Measurement Period"
                      )
                )

/* new definition to capture USCore Diagnostic Report where status not appropriate */
define "Diagnostic Report without appropriate status":
  exists ( [DiagnosticReport: "Mammography"] Mammogram
                    where not ( Mammogram.status in { 'final', 'amended', 'corrected', 'appended' } )
                      and ( Global."Normalize Interval" ( Mammogram.effective ) ends 27 months or less on or before
                        end of "Measurement Period"
                      )
                )

define "Right Mastectomy Diagnosis":
  (  [Condition: "Status Post Right Mastectomy"]
              union ( [Condition: "Unilateral Mastectomy, Unspecified Laterality"] UnilateralMastectomyDiagnosis
                  where UnilateralMastectomyDiagnosis.bodySite in "Right"
              ) ) RightMastectomy
              where Global."Prevalence Period" ( RightMastectomy ) starts on or before
              end of "Measurement Period"

define "Right Mastectomy Procedure":
  [Procedure: "Unilateral Mastectomy Right"] UnilateralMastectomyRightPerformed
                  where UnilateralMastectomyRightPerformed.status = 'completed'
                    and Global."Normalize Interval" ( UnilateralMastectomyRightPerformed.performed ) ends on or before
                    end of "Measurement Period"

define "Left Mastectomy Diagnosis":
  ( [Condition: "Status Post Left Mastectomy"]
              union ( [Condition: "Unilateral Mastectomy, Unspecified Laterality"] UnilateralMastectomyDiagnosis
                  where UnilateralMastectomyDiagnosis.bodySite in "Left"
              ) ) LeftMastectomy
              where Global."Prevalence Period" ( LeftMastectomy ) starts on or before
              end of "Measurement Period"

define "Left Mastectomy Procedure":
  [Procedure: "Unilateral Mastectomy Left"] UnilateralMastectomyLeftPerformed
                  where UnilateralMastectomyLeftPerformed.status = 'completed'
                    and Global."Normalize Interval" ( UnilateralMastectomyLeftPerformed.performed ) ends on or before
                    end of "Measurement Period"

define "Bilateral Mastectomy Diagnosis":
  [Condition: "History of bilateral mastectomy"] BilateralMastectomyHistory
              where Global."Prevalence Period" ( BilateralMastectomyHistory ) starts on or before
              end of "Measurement Period"

define "Bilateral Mastectomy Procedure":
  [Procedure: "Bilateral Mastectomy"] BilateralMastectomyPerformed
                  where BilateralMastectomyPerformed.status = 'completed'
                    and Global."Normalize Interval" ( BilateralMastectomyPerformed.performed ) ends on or before
                    end of "Measurement Period"
