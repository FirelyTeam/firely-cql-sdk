library CMS871FHIRHHHyper version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include CQMCommon version '4.1.000' called CQMCommon
include QICoreCommon version '4.0.000' called QICoreCommon

valueset "Comfort Measures": 'http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45'
valueset "Diabetes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001'
valueset "Discharged to Health Care Facility for Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207'
valueset "Discharged to Home for Hospice Care": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Glucose Lab Test Mass Per Volume": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34'
valueset "Hypoglycemics Treatment Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394'

parameter "Measurement Period" Interval<DateTime>

context Patient

define "Comfort Measures Care":
  ( ["Procedure": "Comfort Measures"] ProcedureCM
      where ProcedureCM.status = 'completed'
  )
    union ( ["ServiceRequest": "Comfort Measures"] ServiceReq
        where ServiceReq.status in { 'active', 'completed' }
    )

define "Days in Hospitalization":
  "Measurement Population" EligibleInpatientHospitalization
    let period: EligibleInpatientHospitalization.hospitalizationWithObservation ( ),
    relevantPeriod: period.hospitalDaysMax10 ( )
    return Tuple {
      encounter: EligibleInpatientHospitalization,
      hospitalizationPeriod: period,
      relevantPeriod: relevantPeriod,
      relevantDays: relevantPeriod.daysInPeriod ( )
    }

define "Days with Glucose Results":
  "Days in Hospitalization" InpatientHospitalDays
    return Tuple {
      encounter: InpatientHospitalDays.encounter,
      relevantPeriod: InpatientHospitalDays.relevantPeriod,
      relevantDays: ( InpatientHospitalDays.relevantDays EncounterDay
          return Tuple {
            dayNumber: EncounterDay.dayIndex,
            dayPeriod: EncounterDay.dayPeriod,
            hasSevereResult: exists ( ["LaboratoryResultObservation": "Glucose Lab Test Mass Per Volume"] GlucoseTest
                where GlucoseTest.status in { 'final', 'amended', 'corrected' }
                  and GlucoseTest.value > 300 'mg/dL'
                  and GlucoseTest.effective.earliest ( ) during EncounterDay.dayPeriod
            ),
            hasElevatedResult: exists ( ["LaboratoryResultObservation": "Glucose Lab Test Mass Per Volume"] GlucoseTest
                where GlucoseTest.status in { 'final', 'amended', 'corrected' }
                  and GlucoseTest.value >= 200 'mg/dL'
                  and GlucoseTest.effective.earliest ( ) during EncounterDay.dayPeriod
            ),
            hasNoGlucoseTest: not exists ( ["LaboratoryResultObservation": "Glucose Lab Test Mass Per Volume"] GlucoseTest
                where GlucoseTest.status in { 'final', 'amended', 'corrected' }
                  and GlucoseTest.effective.earliest ( ) during EncounterDay.dayPeriod
            )
          }
      )
    }

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
      such that Coalesce(ComfortCare.performed.toInterval(), ComfortCare.authoredOn.toInterval()) starts during InpatientHospitalization.hospitalizationWithObservation ( )

define "Encounter with Discharge for Hospice Care":
  "Initial Population" InpatientHospitalization
    where InpatientHospitalization.hospitalization.dischargeDisposition in "Discharged to Home for Hospice Care"
      or InpatientHospitalization.hospitalization.dischargeDisposition in "Discharged to Health Care Facility for Hospice Care"

define "Encounter with Early Glucose Greater Than 600 or with Comfort or Hospice Care":
  "Encounter with Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start"
    union "Encounter with Comfort Measures during Hospitalization"
    union "Encounter with Discharge for Hospice Care"

define "Encounter with Elevated Glucose Greater Than or Equal to 200":
  "Encounter with Hospitalization Period" Hospitalization
    with ["LaboratoryResultObservation": "Glucose Lab Test Mass Per Volume"] GlucoseTest
      such that GlucoseTest.effective.earliest ( ) during Hospitalization.hospitalizationPeriod
        and GlucoseTest.status in { 'final', 'amended', 'corrected' }
        and GlucoseTest.value >= 200 'mg/dL'
    return Hospitalization.encounter

define "Encounter with Existing Diabetes Diagnosis":
  "Encounter with Hospitalization Period" Hospitalization
    with ( ( [ConditionEncounterDiagnosis: "Diabetes"] DiabetesEncounter
        where ( Hospitalization.encounter.reasonReference.references ( DiabetesEncounter )
            or Hospitalization.encounter.reasonCode in "Diabetes"
        )
          and DiabetesEncounter.prevalenceInterval ( ) starts before end of Hospitalization.hospitalizationPeriod
    )
      union ( [ConditionProblemsHealthConcerns: "Diabetes"] DiabetesProblem
          where DiabetesProblem.verificationStatus is not null implies ( DiabetesProblem.verificationStatus ~ QICoreCommon."confirmed"
              or DiabetesProblem.verificationStatus ~ QICoreCommon."unconfirmed"
              or DiabetesProblem.verificationStatus ~ QICoreCommon."provisional"
              or DiabetesProblem.verificationStatus ~ QICoreCommon."differential"
          )
            and DiabetesProblem.prevalenceInterval ( ) starts before end of Hospitalization.hospitalizationPeriod
      ) ) DiabetesCondition
      such that DiabetesCondition.subject.reference = Hospitalization.encounter.subject.reference
    return Hospitalization.encounter

define "Encounter with Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start":
  from
    "Initial Population" InpatientHospitalization,
    "Initial Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start" EarlyGlucoseResult
    where EarlyGlucoseResult.value as Quantity > 600 'mg/dL'
      and EarlyGlucoseResult.status in { 'final', 'amended', 'corrected' }
      and EarlyGlucoseResult.effective.earliest ( ) during Interval[( start of InpatientHospitalization.hospitalizationWithObservation ( ) - 1 hour ), ( start of InpatientHospitalization.hospitalizationWithObservation ( ) + 6 hours )]
    return InpatientHospitalization

define "Encounter with Hospitalization Period":
  "Qualifying Encounter" QualifyingHospitalization
    return Tuple {
      encounter: QualifyingHospitalization,
      hospitalizationPeriod: QualifyingHospitalization.hospitalizationWithObservation ( )
    }

define "Encounter with Hyperglycemic Events":
  "Days with Hyperglycemic Events" HyperglycemicEventDays
    where exists ( HyperglycemicEventDays.eligibleEventDays EligibleEventDay
        where EligibleEventDay.hasHyperglycemicEvent
    )
    return HyperglycemicEventDays.encounter

define "Encounter with Hypoglycemic Medication":
  from
    "Encounter with Hospitalization Period" Hospitalization,
    ["MedicationAdministration": "Hypoglycemics Treatment Medications"] HypoglycemicMed
    where HypoglycemicMed.status in { 'completed', 'in-progress' }
      and HypoglycemicMed.effective.toInterval ( ) during Hospitalization.hospitalizationPeriod
    return Hospitalization.encounter

define "Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start":
  from
    "Initial Population" InpatientHospitalization,
    ["LaboratoryResultObservation": "Glucose Lab Test Mass Per Volume"] GlucoseTest
    let HospitalizationInterval: InpatientHospitalization.hospitalizationWithObservation ( ),
    GlucoseTestTime: GlucoseTest.effective.earliest ( )
    where GlucoseTest.value as Quantity > 600 'mg/dL'
      and GlucoseTest.status in { 'final', 'amended', 'corrected' }
      and GlucoseTestTime during Interval[( start of HospitalizationInterval - 1 hour ), ( start of HospitalizationInterval + 6 hours )]
    return GlucoseTest

define "Glucose Tests Earlier Than Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start":
  from
    "Initial Population" InpatientHospitalization,
    "Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start" GlucoseResult600,
    ["LaboratoryResultObservation": "Glucose Lab Test Mass Per Volume"] EarlierGlucoseTest
    let HospitalizationInterval: InpatientHospitalization.hospitalizationWithObservation ( ),
    GlucoseTest600Time: GlucoseResult600.effective.earliest ( ),
    EarlierGlucoseTestTime: EarlierGlucoseTest.effective.earliest ( )
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

define fluent function hospitalDaysMax10(Period Interval<DateTime>):
  Interval[start of Period, Min({ 
    end of Period, start of Period + 10 days }
  )]

define function "Denominator Observations"(QualifyingEncounter Encounter):
  if QualifyingEncounter.id in "Denominator Exclusions".id then singleton from ( "Days with Hyperglycemic Events" EncounterWithEventDays
      where EncounterWithEventDays.encounter = QualifyingEncounter
      return 0
  ) 
    else singleton from ( "Days with Hyperglycemic Events" EncounterWithEventDays
      where EncounterWithEventDays.encounter = QualifyingEncounter
      return Count(EncounterWithEventDays.eligibleEventDays)
  )

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