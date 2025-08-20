library Antibiotic version '1.9.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '4.0.000' called QICoreCommon
include CumulativeMedicationDuration version '6.0.000' called CMD

parameter "Measurement Period" Interval<DateTime>

context Patient

define function "Has Comorbid Condition History"(episodeDate List<Encounter>, comorbidConditions List<ConditionEncounterDiagnosis>):
  episodeDate eDate
      with comorbidConditions comcondition
        such that date from start of comcondition.prevalenceInterval() during Interval[date from start of eDate.period.toInterval() - 1 year, date from start of eDate.period.toInterval()]
      return eDate

define function "Has Competing Diagnosis History"(episodeDate List<Encounter>, competingConditions List<ConditionEncounterDiagnosis>):
  episodeDate eDate
      with competingConditions competcondition
        such that competcondition.prevalenceInterval() starts 3 days or less on or after day of start of eDate.period
      return eDate

define function "Has Antibiotic Medication History"(episodeDate List<Encounter>, antibioticMedications List<MedicationRequest>):
   episodeDate DateOfEpisode
    with antibioticMedications ActiveMedication
      such that ActiveMedication.medicationRequestPeriod() overlaps day of Interval[date from start of DateOfEpisode.period.toInterval()  - 30 days, date from start of DateOfEpisode.period.toInterval() - 1 day]