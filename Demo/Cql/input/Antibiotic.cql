library Antibiotic version '1.5.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include QICoreCommon version '2.0.000' called QICoreCommon

parameter "Measurement Period" Interval<DateTime>

context Patient

define function "Has Comorbid Condition History"(episodeDate List<Encounter>, comorbidConditions List<Condition>):
  episodeDate eDate
      with comorbidConditions comcondition
        such that date from start of ( QICoreCommon."ToPrevalenceInterval" ( comcondition ) ) during Interval[date from start of QICoreCommon."ToInterval" ( eDate.period ) - 1 year, date from start of QICoreCommon."ToInterval" ( eDate.period )]
      return eDate

define function "Has Competing Diagnosis History"(episodeDate List<Encounter>, competingConditions List<Condition>):
  episodeDate eDate
      with competingConditions competcondition
        such that ( QICoreCommon."ToPrevalenceInterval" ( competcondition ) ) starts 3 days or less on or after day of start of eDate.period
      return eDate

define function "Has Antibiotic Medication History"(episodeDate List<Encounter>, antibioticMedications List<MedicationRequest>):
   episodeDate DateOfEpisode
    with antibioticMedications ActiveMedication
      such that exists ( ActiveMedication.dosageInstruction.timing T
          where ( QICoreCommon."ToInterval" ( T.repeat.bounds ) ) overlaps day of Interval[date from start of QICoreCommon."ToInterval" ( DateOfEpisode.period ) - 30 days, date from start of QICoreCommon."ToInterval" ( DateOfEpisode.period ) - 1 day]
      )