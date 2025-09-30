library Antibiotic version '1.11.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '4.0.000' called QICoreCommon
include CumulativeMedicationDuration version '6.0.000' called CMD

parameter "Measurement Period" Interval<DateTime>

context Patient

define function "Encounter with Comorbid Condition History"(episodes List<Encounter>, comorbidConditions List<ConditionEncounterDiagnosis>):
  episodes episode
      with comorbidConditions comcondition
        such that date from start of comcondition.prevalenceInterval() during Interval[date from start of episode.period - 1 year, date from start of episode.period]
      return episode

define function "Encounter with Competing Diagnosis History"(episodes List<Encounter>, competingConditions List<ConditionEncounterDiagnosis>):
  episodes episode
      with competingConditions competcondition
        such that competcondition.prevalenceInterval() starts 3 days or less on or after day of start of episode.period
      return episode

define function "Encounter with Antibiotic Medication History"(episodes List<Encounter>, antibioticMedications List<MedicationRequest>):
   episodes episode
    with antibioticMedications ActiveMedication
      such that ActiveMedication.medicationRequestPeriod() overlaps day of Interval[date from start of episode.period  - 30 days, date from start of episode.period - 1 day]