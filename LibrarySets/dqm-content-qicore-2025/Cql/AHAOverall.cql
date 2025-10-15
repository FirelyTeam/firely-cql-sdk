library AHAOverall version '4.1.000'

using QICore version '6.0.0'
using USCore version '6.1.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Care Services in Long Term Residential Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014'
valueset "Ejection Fraction": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134'
valueset "Heart Failure": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376'
valueset "Heart Transplant": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.33'
valueset "Heart Transplant Complications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.56'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Left Ventricular Assist Device Complications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.58'
valueset "Left Ventricular Assist Device Placement": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.61'
valueset "Moderate or Severe": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092'
valueset "Moderate or Severe LVSD": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090'
valueset "Nursing Facility Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008'
valueset "Patient Provider Interaction": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012'

code "Left ventricular systolic dysfunction (disorder)": '134401001' from "SNOMEDCT" display 'Left ventricular systolic dysfunction (disorder)'

parameter "Measurement Period" Interval<DateTime>

context Patient

/*
@description: Returns certain finished encounter types that overlap a Heart Failure condition and are during the measurement period: 
                * care services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)
                * home healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)
                * nursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)
                * office visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)
                * outpatient consultation (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)
*/
define "Heart Failure Outpatient Encounter":
  "Outpatient Encounter" QualifyingEncounter
    with ( [ConditionProblemsHealthConcerns: "Heart Failure"]
      union [ConditionEncounterDiagnosis: "Heart Failure"] ) HeartFailure
      such that HeartFailure.prevalenceInterval ( ) overlaps day of QualifyingEncounter.period
        and HeartFailure.isVerified ( )
    where QualifyingEncounter.period during day of "Measurement Period"
      and QualifyingEncounter.isEncounterFinished ( )

define "Outpatient Encounter":
  ( [Encounter: "Care Services in Long Term Residential Facility"]
      union [Encounter: "Home Healthcare Services"]
      union [Encounter: "Nursing Facility Visit"]
      union [Encounter: "Office Visit"]
      union [Encounter: "Outpatient Consultation"]
  ) 

/*
@description: Returns true if patient has confirmed heart transplant complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD 
*/
define "Has Heart Transplant Complications":
  exists ( ( [ConditionEncounterDiagnosis: "Heart Transplant Complications"]
      union [ConditionProblemsHealthConcerns: "Heart Transplant Complications"] ) HeartTransplantComplications
      let diagnosisStart: Coalesce(start of HeartTransplantComplications.prevalenceInterval(), HeartTransplantComplications.recordedDate)
      with "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
        such that date from diagnosisStart on or before date from end of ModerateOrSevereLVSDHFOutpatientEncounter.period
      where HeartTransplantComplications.isVerified ( )
  )

/*
@description: Returns true if patient has a completed LVAD placement that starts before the end of a heart failure outpatient encounter with history of moderate or severe LVSD
*/
define "Has Left Ventricular Assist Device":
  exists ( [Procedure: "Left Ventricular Assist Device Placement"] LVADPlacement
      with "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
        such that LVADPlacement.performed.toInterval ( ) starts before day of end of ModerateOrSevereLVSDHFOutpatientEncounter.period
      where LVADPlacement.status = 'completed'
  )

/*
@description: Returns true if patient has active LVAD complications that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD
*/
define "Has Left Ventricular Assist Device Complications":
  exists ( ( [ConditionEncounterDiagnosis: "Left Ventricular Assist Device Complications"]
      union [ConditionProblemsHealthConcerns: "Left Ventricular Assist Device Complications"] ) LVADComplications
      let diagnosisStart: Coalesce(start of LVADComplications.prevalenceInterval(), LVADComplications.recordedDate)
      with "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
        such that date from diagnosisStart on or before date from end of ModerateOrSevereLVSDHFOutpatientEncounter.period
      where LVADComplications.isVerified ( )
  )             

/*
@description: Returns certain finished encounter types that occurred during the measurement period: 
                * office visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001)
                * outpatient consultation (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008)
                * nursing facility visits (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012)
                * care services in long term residential facility (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014)
                * home healthcare services (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016)
                * patient provider interactions (http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012) 
*/
define "Qualifying Outpatient Encounter During Measurement Period":
  "Outpatient Encounter or Patient Provider Interaction" ValidEncounter
    where ValidEncounter.period during day of "Measurement Period"
      and ValidEncounter.isEncounterFinished ( )

define "Outpatient Encounter or Patient Provider Interaction":
  "Outpatient Encounter"
    union [Encounter: "Patient Provider Interaction"]

/*
@description: Returns completed heart tansplant procedures that start before the end of a heart failure outpatient encounter with history of moderate or severe LVSD
*/
define "Has Heart Transplant":
  exists ( [Procedure: "Heart Transplant"] HeartTransplant
      with "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
        such that HeartTransplant.performed.toInterval ( ) starts before end of ModerateOrSevereLVSDHFOutpatientEncounter.period
      where HeartTransplant.status = 'completed'
  )

/*
@description: Returns heart failure outpatient encounters that start before the end of a moderate or severe LVSD finding
*/
define "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD":
  "Heart Failure Outpatient Encounter" HFOutpatientEncounter
    with "Moderate or Severe LVSD Findings" LVSDFindings
      such that Coalesce(LVSDFindings.prevalenceInterval(), LVSDFindings.effective.toInterval()) starts before end of HFOutpatientEncounter.period 

/*
@description: Returns a union  of the following:
                * Observations where the final, amended or correction ejection fraction result is <= 40
                * Moderate or Severe LVSD conditions where the diagnosis has been confirmed as active
*/
define "Moderate or Severe LVSD Findings":
  ( [ObservationClinicalResult: "Ejection Fraction"] EjectionFraction
      where EjectionFraction.value as Quantity <= 40 '%'
        and EjectionFraction.status in { 'final', 'amended', 'corrected' }
  )
    union ( ( ( [ConditionProblemsHealthConcerns: "Moderate or Severe LVSD"]
          union [ConditionEncounterDiagnosis: "Moderate or Severe LVSD"]
      )
        union ( ( [ConditionProblemsHealthConcerns: "Left ventricular systolic dysfunction (disorder)"]
            union [ConditionEncounterDiagnosis: "Left ventricular systolic dysfunction (disorder)"] ) LVSDDiagnosis
            where LVSDDiagnosis.severity in "Moderate or Severe"
        ) ) ModerateOrSevereLVSD
        where ModerateOrSevereLVSD.isVerified ( )
    ) 

/*
@description: Returns true if the patient meets the following criteria:
                * 18 years of age or older,
                * Has two Qualifying Outpatient Encounters During Measurement Period
                * Has a Heart Failure Outpatient Encounter
*/
define "Is Adult With Two Qualifying Outpatient Encounters and One Heart Failure Outpatient Encounter During the Measurement Period":
  AgeInYearsAt(date from start of "Measurement Period") >= 18
    and exists ( "Qualifying Outpatient Encounter During Measurement Period" Encounter1
        with "Qualifying Outpatient Encounter During Measurement Period" Encounter2
          such that Encounter2.id !~ Encounter1.id
    )
    and exists "Heart Failure Outpatient Encounter"   


/*
@description: Returns true if the given Condition has a verification status of "confirmed", "unconfirmed", "provisional", or "differential"
*/
define fluent function isVerified(condition Choice<ConditionEncounterDiagnosis, ConditionProblemsHealthConcerns>):
  condition.verificationStatus is not null implies ( condition.verificationStatus ~ QICoreCommon."confirmed"
      or condition.verificationStatus ~ QICoreCommon."unconfirmed"
      or condition.verificationStatus ~ QICoreCommon."provisional"
      or condition.verificationStatus ~ QICoreCommon."differential"
  )

/*
@description: Returns true if the given Encounter is finished
*/
define fluent function isEncounterFinished(Encounter Encounter):
  Encounter.status = 'finished'

/*
@description: Returns true if the given MedicationRequest is ordered during the heart failure outpatient encounter with history of moderate or severe LVSD at any point
*/
define fluent function isOrderedDuringHeartFailureOutpatientEncounter(MedicationRequest MedicationRequest):
  exists ( "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
      where MedicationRequest.authoredOn during day of ModerateOrSevereLVSDHFOutpatientEncounter.period
        and MedicationRequest.status in { 'active', 'completed' }
        and MedicationRequest.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
        and not exists ( ["TaskRejected"] TaskReject
            where TaskReject.focus.references ( MedicationRequest )
              and TaskReject.code ~ QICoreCommon."Fulfill"
        )
  )

/*
@description: Returns true if the given MedicationNotRequested overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD
*/
define fluent function isMedicationNotRequestedOrderedDuringHeartFailureOutpatientEncounter(MedicationRequest MedicationNotRequested):
  exists ( "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
      where MedicationRequest.authoredOn during day of ModerateOrSevereLVSDHFOutpatientEncounter.period
        and MedicationRequest.status in { 'completed', 'active' }
        and MedicationRequest.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
        and not exists ( ["TaskRejected"] TaskReject
            where TaskReject.focus.references ( MedicationRequest )
              and TaskReject.code ~ QICoreCommon."Fulfill"
        )
  )

/*
@description: Returns true if the given Condition overlaps the heart failure outpatient encounter with history of moderate or severe LVSD at any point
*/
define fluent function overlapsHeartFailureOutpatientEncounter(Condition Choice<ConditionEncounterDiagnosis, ConditionProblemsHealthConcerns>):
  exists ( "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
      where Condition.prevalenceInterval ( ) overlaps day of ModerateOrSevereLVSDHFOutpatientEncounter.period
        and Condition.isVerified ( )
  )

/*
@overloaded
@description: Returns true if the given Condition overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD
*/
define fluent function overlapsAfterHeartFailureOutpatientEncounter(Condition Choice<ConditionEncounterDiagnosis, ConditionProblemsHealthConcerns>):
  exists ( "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
      where Condition.prevalenceInterval ( ) overlaps after day of ModerateOrSevereLVSDHFOutpatientEncounter.period
        and Condition.isVerified ( )
  )

/*
@overloaded
@description: Returns true if the given Procedure overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD
*/
define fluent function overlapsAfterHeartFailureOutpatientEncounter(Procedure Procedure):
  exists ( "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
      where Procedure.performed.toInterval ( ) overlaps after day of ModerateOrSevereLVSDHFOutpatientEncounter.period
        and Procedure.status = 'completed'
  )

/*
@overloaded
@description: Returns true if the given AllergyIntolerance overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD
*/
define fluent function overlapsAfterHeartFailureOutpatientEncounter(AllergyIntolerance AllergyIntolerance):
  exists ( "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
      where Interval[start of AllergyIntolerance.onset.toInterval ( ), AllergyIntolerance.lastOccurrence]overlaps after day of ModerateOrSevereLVSDHFOutpatientEncounter.period
        and AllergyIntolerance.isVerified ( )
  )
          
/*
@description: Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential
*/
define fluent function isVerified(AllergyIntolerance AllergyIntolerance):
  AllergyIntolerance.verificationStatus is not null implies ( AllergyIntolerance.verificationStatus ~ QICoreCommon."allergy-confirmed"
      or AllergyIntolerance.verificationStatus ~ QICoreCommon."allergy-unconfirmed"
  )

/*
@overloaded
@description: Returns true if the given MedicationRequest overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD
*/
define fluent function overlapsAfterHeartFailureOutpatientEncounter(MedicationRequest MedicationRequest):
  exists ( "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
      where First((collapse(MedicationRequest.dosageInstruction.timing.repeat.bounds DoseTime
            return TimingBoundToInterval(MedicationRequest.authoredOn, DoseTime)
        )) DrugPeriods
          sort by start of $this
      ) overlaps after day of ModerateOrSevereLVSDHFOutpatientEncounter.period
        and MedicationRequest.status in { 'active', 'completed' }
        and MedicationRequest.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
        and not exists ( ["TaskRejected"] TaskReject
            where TaskReject.focus.references ( MedicationRequest )
              and TaskReject.code ~ QICoreCommon."Fulfill"
        )
  )

/*
@overloaded
@description: Returns true if the given HeartRateObservation overlaps after the day of the heart failure outpatient encounter with history of moderate or severe LVSD
*/
define fluent function overlapsAfterHeartFailureOutpatientEncounter(HeartRateObservation USCoreHeartRateProfile):
  exists ( "Heart Failure Outpatient Encounter with History of Moderate or Severe LVSD" ModerateOrSevereLVSDHFOutpatientEncounter
      where HeartRateObservation.effective.toInterval ( ) overlaps after day of ModerateOrSevereLVSDHFOutpatientEncounter.period
        and HeartRateObservation.status in { 'final', 'amended', 'corrected' }
  )
 
define function TimingBoundToInterval(startDate System.DateTime, choice Choice<Quantity, Interval<Quantity>, Interval<DateTime>>):
  case
    when choice is Interval<DateTime> then
        choice as Interval<DateTime>
    when choice is Interval<Quantity> then
        Interval[startDate + (choice.low as Quantity), startDate + (choice.high as Quantity)]
    when choice is Quantity then
        Interval[startDate, startDate + (choice as Quantity))
    else
		null as Interval<DateTime>
	end