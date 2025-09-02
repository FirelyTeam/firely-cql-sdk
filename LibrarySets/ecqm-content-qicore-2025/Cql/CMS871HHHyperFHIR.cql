library CMS871HHHyperFHIR version '0.3.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include CQMCommon version '4.1.000' called CQMCommon
include QICoreCommon version '4.0.000' called QICoreCommon
include CumulativeMedicationDuration version '6.0.000' called CMD

codesystem "LOINC": 'http://loinc.org'

valueset "birth date": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4'
valueset "Comfort Measures": 'http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45'
valueset "Diabetes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001'
valueset "Discharged to Health Care Facility for Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207'
valueset "Discharged to Home for Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Glucose Lab Test Mass Per Volume": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34'
valueset "Hypoglycemics Treatment Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394'

code "Birth date": '21112-8' from "LOINC" display 'Birth date'

parameter "Measurement Period" Interval<DateTime>

context Patient

/***/


define "Comfort Measures Care":
  ["ServiceRequest": "Comfort Measures"]
    union ["Procedure": "Comfort Measures"]

define "Days in Hospitalization":
  "Measurement Population" EligibleInpatientHospitalization
    let period: CQMCommon."HospitalizationWithObservation" ( EligibleInpatientHospitalization ),
    relevantPeriod: "Hospital Days Max 10"(period)
    return Tuple {
      encounter: EligibleInpatientHospitalization,
      hospitalizationPeriod: period,
      relevantPeriod: relevantPeriod,
      relevantDays: "Days In Period"(relevantPeriod)
    }

define "Days with Glucose Results":
  "Days in Hospitalization" InpatientHospitalDays
    return Tuple {
      encounter: InpatientHospitalDays.encounter,
      relevantPeriod: InpatientHospitalDays.relevantPeriod,
      relevantDays: ( InpatientHospitalDays.relevantDays EncounterDay
          return Tuple {
            dayNumber: EncounterDay.dayNumber,
            dayPeriod: EncounterDay.dayPeriod,
            hasSevereResult: exists ( ["LaboratoryResultObservation": "Glucose Lab Test Mass Per Volume"] GlucoseTest
                where GlucoseTest.status in { 'final', 'amended', 'corrected' }
                  and GlucoseTest.value > 300 'mg/dL'
                  and QICoreCommon."Earliest" ( GlucoseTest.effective ) during EncounterDay.dayPeriod
            ),
            hasElevatedResult: exists ( ["LaboratoryResultObservation": "Glucose Lab Test Mass Per Volume"] GlucoseTest
                where GlucoseTest.status in { 'final', 'amended', 'corrected' }
                  and GlucoseTest.value >= 200 'mg/dL'
                  and QICoreCommon."Earliest" ( GlucoseTest.effective ) during EncounterDay.dayPeriod
            ),
            hasNoGlucoseTest: not exists ( ["LaboratoryResultObservation": "Glucose Lab Test Mass Per Volume"] GlucoseTest
                where GlucoseTest.status in { 'final', 'amended', 'corrected' }
                  and QICoreCommon."Earliest" ( GlucoseTest.effective ) during EncounterDay.dayPeriod
            )
          }
      )
    }

/*# hyper days uses "Relevant Encounters With Glucose Result Days" to find if hyper event on each day. Skips 1st day in 'RelevantDays`. Returns boolean based on: Today high result OR Today no result AND Yesterday high result AND 2 days ago high result*/


define "Days with Hyperglycemic Events":
  "Days with Glucose Results" EncounterWithResultDays
    let eligibleEventDays: EncounterWithResultDays.relevantDays EncounterDay
      where EncounterDay.dayNumber > 1
      return Tuple {
        dayIndex: EncounterDay.dayNumber,
        dayPeriod: EncounterDay.dayPeriod,
        hasHyperglycemicEvent: ( EncounterDay.hasSevereResult
            or ( EncounterDay.hasNoGlucoseTest
                and EncounterWithResultDays.relevantDays[EncounterDay.dayNumber - 2].hasElevatedResult
                and EncounterWithResultDays.relevantDays[EncounterDay.dayNumber - 3].hasElevatedResult
            )
        )
      }
    return Tuple {
      encounter: EncounterWithResultDays.encounter,
      relevantPeriod: EncounterWithResultDays.relevantPeriod,
      eligibleEventDays: eligibleEventDays
    }

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "Encounter with Early Glucose Greater Than 600 or with Comfort or Hospice Care"

define "Encounter with Comfort Measures during Hospitalization":
  "Initial Population" InpatientHospitalization
    with "Comfort Measures Care" ComfortCare
      such that Coalesce(ComfortCare.performed.toInterval(), ComfortCare.authoredOn.toInterval()) during CQMCommon."HospitalizationWithObservation" ( InpatientHospitalization )

define "Encounter with Discharge for Hospice Care":
  "Initial Population" InpatientHospitalization
    where InpatientHospitalization.hospitalization.dischargeDisposition in "Discharged to Home for Hospice Care"
      or InpatientHospitalization.hospitalization.dischargeDisposition in "Discharged to Health Care Facility for Hospice Care"

define "Encounter with Early Glucose Greater Than 600 or with Comfort or Hospice Care":
  "Encounter with Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start"
    union "Encounter with Comfort Measures during Hospitalization"
    union "Encounter with Discharge for Hospice Care"


/**
 * Using the already calculated pairing of hospitalization periods with encounters, filter on ones with 
 * any elevated (>= 200) blood glucose reading during the hospitalization*/


define "Encounter with Elevated Glucose Greater Than or Equal to 200":
  "Encounter with Hospitalization Period" Hospitalization
    with ["LaboratoryResultObservation": "Glucose Lab Test Mass Per Volume"] GlucoseTest
      such that QICoreCommon."Earliest" ( GlucoseTest.effective ) during Hospitalization.hospitalizationPeriod
        and GlucoseTest.status in { 'final', 'amended', 'corrected' }
            //and GlucoseTest.status != 'cancelled'
        
        and GlucoseTest.value >= 200 'mg/dL'
    return Hospitalization.encounter

/**
 * Using the already calculated pairing of hospitalization periods with encounters, filter on ones with 
 * diabetes and return the encounter.*/


define "Encounter with Existing Diabetes Diagnosis":
  "Encounter with Hospitalization Period" Hospitalization
    with ["ConditionEncounterDiagnosis": "Diabetes"] Diabetes
      such that ( QICoreCommon."ToPrevalenceInterval" ( Diabetes ) starts before end of Hospitalization.hospitalizationPeriod )
    return Hospitalization.encounter

define "Encounter with Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start":
  from
    "Initial Population" InpatientHospitalization,
    "Initial Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start" EarlyGlucoseResult
    where EarlyGlucoseResult.value as Quantity > 600 'mg/dL'
      and EarlyGlucoseResult.status in { 'final', 'amended', 'corrected' }
      and QICoreCommon."Earliest" ( EarlyGlucoseResult.effective ) during Interval[( start of CQMCommon."HospitalizationWithObservation" ( InpatientHospitalization ) - 1 hour ), ( start of CQMCommon."HospitalizationWithObservation" ( InpatientHospitalization ) + 6 hours )]
    return InpatientHospitalization


/**
 * Create paring of encounters to hospitalization period so this calculation can be inspected and the result 
 * can be reused, making the logic faster.*/


define "Encounter with Hospitalization Period":
  "Qualifying Encounter" QualifyingHospitalization
    return Tuple {
      encounter: QualifyingHospitalization,
      hospitalizationPeriod: CQMCommon."HospitalizationWithObservation" ( QualifyingHospitalization )
    }

/***/


define "Encounter with Hyperglycemic Events":
  "Days with Hyperglycemic Events" HyperglycemicEventDays
    where exists ( HyperglycemicEventDays.eligibleEventDays EligibleEventDay
        where EligibleEventDay.hasHyperglycemicEvent
    )
    return HyperglycemicEventDays.encounter

/**
 * Using the already calculated pairing of hospitalization periods with encounters, filter on ones with 
 * hypoglycemic medicatons and return the encounter.*/


define "Encounter with Hypoglycemic Medication":
  from
    "Encounter with Hospitalization Period" Hospitalization,
    ["MedicationAdministration": "Hypoglycemics Treatment Medications"] HypoglycemicMed
    where HypoglycemicMed.status in { 'completed', 'in-progress' }
          //and HypoglycemicMed.status != 'not-done'
      
      and QICoreCommon."ToInterval" ( HypoglycemicMed.effective ) during Hospitalization.hospitalizationPeriod
    return Hospitalization.encounter

define "Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start":
  from
    "Initial Population" InpatientHospitalization,
    ["LaboratoryResultObservation": "Glucose Lab Test Mass Per Volume"] GlucoseTest
    let HospitalizationInterval: CQMCommon."HospitalizationWithObservation" ( InpatientHospitalization ),
    GlucoseTestTime: QICoreCommon."Earliest" ( GlucoseTest.effective )
    where GlucoseTest.value as Quantity > 600 'mg/dL'
      and GlucoseTest.status in { 'final', 'amended', 'corrected' }
      and GlucoseTestTime during Interval[( start of HospitalizationInterval - 1 hour ), ( start of HospitalizationInterval + 6 hours )]
    return GlucoseTest

define "Glucose Tests Earlier Than Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start":
  from
    "Initial Population" InpatientHospitalization,
    "Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start" GlucoseResult600,
    ["LaboratoryResultObservation": "Glucose Lab Test Mass Per Volume"] EarlierGlucoseTest
    let HospitalizationInterval: CQMCommon."HospitalizationWithObservation" ( InpatientHospitalization ),
    GlucoseTest600Time: QICoreCommon."Earliest" ( GlucoseResult600.effective ),
    EarlierGlucoseTestTime: QICoreCommon."Earliest" ( EarlierGlucoseTest.effective )
    where GlucoseTest600Time during Interval[( start of HospitalizationInterval - 1 hour ), ( start of HospitalizationInterval + 6 hour )]
      and EarlierGlucoseTestTime during Interval[( start of HospitalizationInterval - 1 hour ), GlucoseTest600Time )
      and EarlierGlucoseTest.id !~ GlucoseResult600.id
    return GlucoseResult600

define "Initial Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start":
  "Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start" GlucoseResult600
    where not ( GlucoseResult600.id in "Glucose Tests Earlier Than Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start".id )

define "Initial Population":
  "Encounter with Existing Diabetes Diagnosis"
    union "Encounter with Hypoglycemic Medication"
    union "Encounter with Elevated Glucose Greater Than or Equal to 200"

define "Measurement Population":
  "Denominator"

define "Numerator":
  "Encounter with Hyperglycemic Events"

define "Numerator Exclusions":
  "Encounter with Early Glucose Greater Than 600 or with Comfort or Hospice Care"

define "Qualifying Encounter":
  ["Encounter": "Encounter Inpatient"] InpatientEncounter
    where AgeInYearsAt(date from start of InpatientEncounter.period) >= 18
      and InpatientEncounter.period ends during day of "Measurement Period"
      and InpatientEncounter.status = 'finished'

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

/**
 * Crops an interval to a maximum length of 10 days.*/


define function "Hospital Days Max 10"(Period Interval<DateTime>):
  Interval[start of Period, Min({ 
    end of Period, start of Period + 10 days }
  )]

/**
 * Creates a list of integers from 1 to how many days are in the interval. Note, this wont create an index for
 * the final day if it is less than 24 hours. This also includes the first 24 hour period.*/


define function "Interval To Day Numbers"(Period Interval<DateTime>):
  ( expand { Interval[1, duration in days between start of Period and end of Period]} ) DayExpand
    return end of DayExpand

/**
 * Counts the number of eligible days in an encounter. This simply filters and counts the data built in
 * "Relevant Encounters With Hyperglycemic Event Days".*/


define function "Denominator Observations"(QualifyingEncounter Encounter):
  if QualifyingEncounter.id in "Denominator Exclusions".id then singleton from ( "Days with Hyperglycemic Events" EncounterWithEventDays
      where EncounterWithEventDays.encounter = QualifyingEncounter
      return 0
  ) 
    else singleton from ( "Days with Hyperglycemic Events" EncounterWithEventDays
      where EncounterWithEventDays.encounter = QualifyingEncounter
      return Count(EncounterWithEventDays.eligibleEventDays)
  )

/**
 * Counts the number of eligible days with a hyperglycemic event in an encounter. This simply filters and counts the data built in
 * "Relevant Encounters With Hyperglycemic Event Days".*/


define function "Numerator Observations"(QualifyingEncounter Encounter):
  if QualifyingEncounter.id in "Denominator Exclusions".id then singleton from ( "Days with Hyperglycemic Events" EncounterWithEventDays
      where EncounterWithEventDays.encounter = QualifyingEncounter
      return 0
  ) 
    else singleton from ( "Days with Hyperglycemic Events" EncounterWithEventDays
      where EncounterWithEventDays.encounter = QualifyingEncounter
      return Count(EncounterWithEventDays.eligibleEventDays EligibleEventDay
          where EligibleEventDay.hasHyperglycemicEvent
      )
  )

/**
 * Creates a list of 24 hour long intervals in an interval paired with the index (1 indexed) to which 24 hour interval it is.*/


define function "Days In Period"(Period Interval<DateTime>):
  ( "Interval To Day Numbers"(Period) ) DayNumber
    let startPeriod: start of Period + ( 24 hours * ( DayNumber - 1 ) ),
    endPeriod: if ( hours between startPeriod and end of Period < 24 ) then startPeriod 
      else start of Period + ( 24 hours * DayNumber )
    return Tuple {
      dayNumber: DayNumber,
      dayPeriod: Interval[startPeriod, endPeriod )
    }