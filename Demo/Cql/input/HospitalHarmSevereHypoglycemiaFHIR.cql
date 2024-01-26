library HospitalHarmSevereHypoglycemiaFHIR version '0.1.000'

using QICore version '4.1.1'

include SupplementalDataElements version '3.4.000' called SDE
include CQMCommon version '2.0.000' called CQMCommon
include QICoreCommon version '2.0.000' called QICoreCommon
include FHIRHelpers version '4.3.000' called FHIRHelpers

valueset "birth date": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4'
valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Glucose Lab Test Mass Per Volume": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34'
valueset "Hypoglycemics Severe Hypoglycemia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393'
valueset "Observation Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "Denominator":
  "Initial Population"

define "Encounter with Severe Hypoglycemic Harm Event":
  from
    "Denominator" QualifyingEncounter,
    "Severe Hypoglycemic Harm Event" HypoglycemicEvent
    let GlucoseTestTime: QICoreCommon."Earliest" ( HypoglycemicEvent.effective ),
    HospitalizationInterval: CQMCommon."HospitalizationWithObservation" ( QualifyingEncounter )
    where GlucoseTestTime during HospitalizationInterval
    return QualifyingEncounter

define "Glucose Test with Result Less Than 40":
  from
    "Denominator" QualifyingEncounter,
    "Hypoglycemic Medication Administration" HypoglycemicMedication,
    ["Observation": "Glucose Lab Test Mass Per Volume"] GlucoseTest
    let HospitalizationInterval: CQMCommon."HospitalizationWithObservation" ( QualifyingEncounter ),
    HypoglycemicMedicationStart: QICoreCommon."ToInterval" ( HypoglycemicMedication.effective ),
    GlucoseTestTime: QICoreCommon."Earliest" ( GlucoseTest.effective )
    where GlucoseTestTime during HospitalizationInterval
      and GlucoseTest.status in { 'final', 'amended', 'corrected' }
      and GlucoseTest.value < 40 'mg/dL'
      and HypoglycemicMedicationStart starts 24 hours or less before or on GlucoseTestTime
    return GlucoseTest

define "Hypoglycemic Medication Administration":
  ["MedicationAdministration": "Hypoglycemics Severe Hypoglycemia"] HypoMedication
    where HypoMedication.status = 'completed'
      and HypoMedication.status != 'not-done'

define "Initial Population":
  "Encounter with Hypoglycemic Medication Administration"

define "Numerator":
  "Encounter with Severe Hypoglycemic Harm Event"

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

define "Encounter with Hypoglycemic Medication Administration":
  "Qualifying Encounter" InpatientHospitalization
    with "Hypoglycemic Medication Administration" HypoglycemicMedication
      such that QICoreCommon."ToInterval" ( HypoglycemicMedication.effective ) starts during CQMCommon."HospitalizationWithObservation" ( InpatientHospitalization )

define "Low Glucose Test Followed By Glucose Test Result Greater Than 80":
  from
    "Denominator" QualifyingEncounter,
    "Glucose Test with Result Less Than 40" LowGlucoseTest,
    ["Observation": "Glucose Lab Test Mass Per Volume"] FollowupGlucoseTest
    let GlucoseTestTime: QICoreCommon."Earliest" ( LowGlucoseTest.effective ),
    FollowupGlucoseTestTime: QICoreCommon."Earliest" ( FollowupGlucoseTest.effective )
  //    FollowupInterval: duration in minutes between LowGlucoseTestResultTime and FollowupGlucoseTestTime//
    
    where FollowupGlucoseTestTime 5 minutes or less after GlucoseTestTime
      and GlucoseTestTime during CQMCommon."HospitalizationWithObservation" ( QualifyingEncounter )
      and FollowupGlucoseTestTime during CQMCommon."HospitalizationWithObservation" ( QualifyingEncounter )
      and FollowupGlucoseTest.id !~ LowGlucoseTest.id
      and FollowupGlucoseTest.status in { 'final', 'amended', 'corrected' }
      and FollowupGlucoseTest.value > 80 'mg/dL'
    return LowGlucoseTest

define "Severe Hypoglycemic Harm Event":
  "Glucose Test with Result Less Than 40" LowGlucoseTest
    where not ( LowGlucoseTest.id in "Low Glucose Test Followed By Glucose Test Result Greater Than 80".id )
