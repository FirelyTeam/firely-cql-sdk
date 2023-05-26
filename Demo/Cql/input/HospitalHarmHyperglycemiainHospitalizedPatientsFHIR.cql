library HospitalHarmHyperglycemiainHospitalizedPatientsFHIR version '0.0.006'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.001' called FHIRHelpers
include SupplementalDataElementsFHIR4 version '2.0.000' called SDE
include MATGlobalCommonFunctionsFHIR4 version '6.1.000' called Global

codesystem "LOINC": 'http://loinc.org' 

valueset "birth date": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4' 
valueset "Diabetes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001' 
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307' 
valueset "Glucose lab test": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134' 
valueset "Hypoglycemics Treatment Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394' 

code "Birth date": '21112-8' from "LOINC" display 'Birth date'

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

define "Denominator":
  "Initial Population"

define "Initial Population":
  "Qualifying Encounters With Existing Diabetes Diagnosis"
            union "Qualifying Encounters With Hypoglycemic Medication"
            union "Qualifying Encounters With Elevated Blood Glucose Lab"

define "Inpatient Encounter During Measurement Period":
  [Encounter: "Encounter Inpatient"] EncounterInpatient
/*
                      		where EncounterInpatient.status = 'finished'
                      		       			and EncounterInpatient.period ends during "Measurement Period"
*/
/***/
define "Numerator":
  "Pertinent Encounters With Hyperglycemic Event Days" EncounterWithEventDays
            where exists ( EncounterWithEventDays.eligibleEventDays EligibleEventDay
                where EligibleEventDay.hasHyperglycemicEvent
            )
            return EncounterWithEventDays.encounter

/***/
define "Pertinent Encounters With Days":
  "Initial Population" PertinentEncounter
            let period: Global."HospitalizationWithObservation" ( PertinentEncounter ),
            relevantPeriod: "Crop Interval to 10 Days"(period)
            return Tuple {
              encounter: PertinentEncounter,
              hospitalizationPeriod: period,
              relevantPeriod: relevantPeriod,
              relevantDays: "Days In Period"(relevantPeriod)
            }

/*# hyper days uses "Relevant Encounters With Glucose Result Days" to find if hyper event on each day. Skips 1st day in 'RelevantDays`. Returns boolean based on: Today high result OR Today no result AND Yesterday high result AND 2 days ago high result*/
define "Pertinent Encounters With Hyperglycemic Event Days":
  "Pertinent Encounters With Glucose Result Days" EncounterWithResultDays
            let eligibleEventDays: EncounterWithResultDays.relevantDays EncounterDay
              where EncounterDay.dayIndex > 1
              return Tuple {
                dayIndex: EncounterDay.dayIndex,
                dayPeriod: EncounterDay.dayPeriod,
                hasHyperglycemicEvent: ( EncounterDay.hasSevereResult
                    or ( EncounterDay.hasNoResult
                        and EncounterWithResultDays.relevantDays[EncounterDay.dayIndex - 2].hasElevatedResult
                        and EncounterWithResultDays.relevantDays[EncounterDay.dayIndex - 3].hasElevatedResult
                    )
                )
              }
            return Tuple {
              encounter: EncounterWithResultDays.encounter,
              relevantPeriod: EncounterWithResultDays.relevantPeriod,
              eligibleEventDays: eligibleEventDays
            }

define "Qualifying Encounters":
  "Inpatient Encounter During Measurement Period" InpatientEncounter 
        where AgeInYearsAt (start of Global."HospitalizationWithObservation"(InpatientEncounter))>=18

/**
 * Using the already calculated pairing of hospitalization periods with encounters, filter on ones with 
 * diabetes and return the encounter.*/
define "Qualifying Encounters With Existing Diabetes Diagnosis":
  "Qualifying Encounters With Hospitalization Period" EncounterWithHospitalization
        with ["Condition": "Diabetes"] DiabetesDiagnosis
          such that DiabetesDiagnosis.verificationStatus ~ ToConcept(Global."confirmed")
          and (Global."Prevalence Period"(DiabetesDiagnosis) starts before end of EncounterWithHospitalization.hospitalizationPeriod)
        return EncounterWithHospitalization.encounter

/**
 * Create paring of encounters to hospitalization period so this calculation can be inspected and the result 
 * can be reused, making the logic faster.*/
define "Qualifying Encounters With Hospitalization Period":
  "Qualifying Encounters" QualifyingEncounter
            return Tuple {
              encounter: QualifyingEncounter,
              hospitalizationPeriod: Global."HospitalizationWithObservation" ( QualifyingEncounter )
            }

/**
 * Using the already calculated pairing of hospitalization periods with encounters, filter on ones with 
 * hypoglycemic medicatons and return the encounter.*/
define "Qualifying Encounters With Hypoglycemic Medication":
  from "Qualifying Encounters With Hospitalization Period" EncounterWithHospitalization,
      ["MedicationAdministration": "Hypoglycemics Treatment Medications"] HypoglycemicMedication
            where HypoglycemicMedication.status = 'completed'
           and Global."Normalize Interval" ( HypoglycemicMedication.effective )   during EncounterWithHospitalization.hospitalizationPeriod   
            return EncounterWithHospitalization.encounter

/**
 * Using the already calculated pairing of hospitalization periods with encounters, filter on ones with 
 * any elevated (>= 200) blood glucose reading during the hospitalization*/
define "Qualifying Encounters With Elevated Blood Glucose Lab":
  "Qualifying Encounters With Hospitalization Period" EncounterWithHospitalization
    with ["Observation": "Glucose lab test"] BloodGlucoseLab
      such that BloodGlucoseLab.effective as dateTime during EncounterWithHospitalization.hospitalizationPeriod
        and BloodGlucoseLab.status = 'final'
        and BloodGlucoseLab.value >= 200 'mg/dL'
    return EncounterWithHospitalization.encounter

define "Pertinent Encounters With Glucose Result Days":
  "Pertinent Encounters With Days" PertinentEncounterDays
    return Tuple {
      encounter: PertinentEncounterDays.encounter,
      relevantPeriod: PertinentEncounterDays.relevantPeriod,
      relevantDays: ( PertinentEncounterDays.relevantDays EncounterDay
          return Tuple {
            dayIndex: EncounterDay.dayIndex,
            dayPeriod: EncounterDay.dayPeriod,
            hasSevereResult: exists ( ["Observation": "Glucose lab test"] BloodGlucoseLab1
                where BloodGlucoseLab1.status = 'final'
                  and BloodGlucoseLab1.value > 300 'mg/dL'
                  and BloodGlucoseLab1.effective as dateTime during EncounterDay.dayPeriod
            ),
            hasElevatedResult: exists ( ["Observation": "Glucose lab test"] BloodGlucoseLab2
                where BloodGlucoseLab2.status = 'final'
                  and BloodGlucoseLab2.value >= 200 'mg/dL'
                  and BloodGlucoseLab2.effective as dateTime during EncounterDay.dayPeriod
            ),
            hasNoResult: not exists ( ["Observation": "Glucose lab test"] BloodGlucoseLab3
                where BloodGlucoseLab3.status = 'final'
                  and BloodGlucoseLab3.effective as dateTime during EncounterDay.dayPeriod
            )
          }
      )
    }

/**
 * Crops an interval to a maximum length of 10 days.*/
define function "Crop Interval to 10 Days"(Period Interval<DateTime> ):
  Interval[start of Period, Min({ 
    end of Period, start of Period + 10 days }
  )]

/**
 * Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.*/
define function "Days In Period"(Period Interval<DateTime> ):
  ( "Interval To Day Numbers"(Period)) DayIndex
    let startPeriod: start of Period + ( 24 hours * ( DayIndex - 1 ) ),
    endPeriod: if ( hours between startPeriod and 
      end of Period < 24
    ) then startPeriod 
      else start of Period + ( 24 hours * DayIndex )
    return Tuple {
      dayIndex: DayIndex,
      dayPeriod: Interval[startPeriod, endPeriod )
    }

/**
 * Counts the number of eligible days in an encounter. This simply filters and counts the data built in
 * "Relevant Encounters With Hyperglycemic Event Days".*/
define function "Denominator Observations"(QualifyingEncounter Encounter ):
  singleton from ( "Pertinent Encounters With Hyperglycemic Event Days" EncounterWithEventDays
      where EncounterWithEventDays.encounter = QualifyingEncounter
      return Count(EncounterWithEventDays.eligibleEventDays)
  )

/**
 * Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for
 * the final day if it is less than 24 hours. This also includes the first 24 hour period.*/
define function "Interval To Day Numbers"(Period Interval<DateTime> ):
  ( expand { Interval[1, days between start of Period and 
  end of Period]} ) DayExpand
    return 
    end of DayExpand

/**
 * Counts the number of eligible days with a hyperglycemic event in an encounter. This simply filters and counts the data built in
 * "Relevant Encounters With Hyperglycemic Event Days".*/
define function "Numerator Observations"(QualifyingEncounter Encounter ):
  singleton from ( "Pertinent Encounters With Hyperglycemic Event Days" EncounterWithEventDays
      where EncounterWithEventDays.encounter = QualifyingEncounter
      return Count(EncounterWithEventDays.eligibleEventDays EligibleEventDay
          where EligibleEventDay.hasHyperglycemicEvent
      )
  )

