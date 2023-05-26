library CumulativeMedicationDurationFHIR4 version '1.0.000'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.001' called FHIRHelpers

codesystem "V3TimingEvent": 'http://terminology.hl7.org/CodeSystem/v3-TimingEvent' 
codesystem "EventTiming": 'http://hl7.org/fhir/event-timing' 

code "AC": 'AC' from "V3TimingEvent" display 'AC'
code "ACD": 'ACD' from "V3TimingEvent" display 'ACD'
code "ACM": 'ACM' from "V3TimingEvent" display 'ACM'
code "ACV": 'ACV' from "V3TimingEvent" display 'ACV'
code "AFT": 'AFT' from "EventTiming" display 'AFT'
code "AFT.early": 'AFT.early' from "EventTiming" display 'AFT.early'
code "AFT.late": 'AFT.late' from "EventTiming" display 'AFT.late'
code "C": 'C' from "V3TimingEvent" display 'C'
code "CD": 'CD' from "V3TimingEvent" display 'CD'
code "CM": 'CM' from "V3TimingEvent" display 'CM'
code "CV": 'CV' from "V3TimingEvent" display 'CV'
code "EVE": 'EVE' from "EventTiming" display 'EVE'
code "EVE.early": 'EVE.early' from "EventTiming" display 'EVE.early'
code "EVE.late": 'EVE.late' from "EventTiming" display 'EVE.late'
code "HS": 'HS' from "V3TimingEvent" display 'HS'
code "MORN": 'MORN' from "EventTiming" display 'MORN'
code "MORN.early": 'MORN.early' from "EventTiming" display 'MORN.early'
code "MORN.late": 'MORN.late' from "EventTiming" display 'MORN.late'
code "NIGHT": 'NIGHT' from "EventTiming" display 'NIGHT'
code "NOON": 'NOON' from "EventTiming" display 'NOON'
code "PC": 'PC' from "V3TimingEvent" display 'PC'
code "PCD": 'PCD' from "V3TimingEvent" display 'PCD'
code "PCM": 'PCM' from "V3TimingEvent" display 'PCM'
code "PCV": 'PCV' from "V3TimingEvent" display 'PCV'
code "PHS": 'PHS' from "EventTiming" display 'PHS'
code "WAKE": 'WAKE' from "V3TimingEvent" display 'WAKE'

parameter "ErrorLevel" String default 'Warning'

context Patient

/*Calculates daily frequency given frequency within a period*/
define function "ToDaily"(frequency System.Integer, period System.Quantity ):
  case period.unit
    when 'h' then frequency * (24.0 / period.value)
    when 'min' then frequency * (24.0 / period.value) * 60
    when 's' then frequency * (24.0 / period.value) * 60 * 60
    when 'd' then frequency * (24.0 / period.value) / 24
    when 'wk' then frequency * (24.0 / period.value) / (24 * 7)
    when 'mo' then frequency * (24.0 / period.value) / (24 * 30) /* assuming 30 days in month */
    when 'a' then frequency * (24.0 / period.value) / (24 * 365) /* assuming 365 days in year */
    when 'hour' then frequency * (24.0 / period.value)
    when 'minute' then frequency * (24.0 / period.value) * 60
    when 'second' then frequency * (24.0 / period.value) * 60 * 60
    when 'day' then frequency * (24.0 / period.value) / 24
    when 'week' then frequency * (24.0 / period.value) / (24 * 7)
    when 'month' then frequency * (24.0 / period.value) / (24 * 30) /* assuming 30 days in month */
    when 'year' then frequency * (24.0 / period.value) / (24 * 365) /* assuming 365 days in year */
    when 'hours' then frequency * (24.0 / period.value)
    when 'minutes' then frequency * (24.0 / period.value) * 60
    when 'seconds' then frequency * (24.0 / period.value) * 60 * 60
    when 'days' then frequency * (24.0 / period.value) / 24
    when 'weeks' then frequency * (24.0 / period.value) / (24 * 7)
    when 'months' then frequency * (24.0 / period.value) / (24 * 30) /* assuming 30 days in month */
    when 'years' then frequency * (24.0 / period.value) / (24 * 365) /* assuming 365 days in year */
    else Message(null, true, 'CMDLogic.ToDaily.UnknownUnit', ErrorLevel, 'Unknown unit ' & period.unit)
  end

/*Returns a daily frequency for the given code representation of frequency.
  The function expects codes from the [EventTiming](http://hl7.org/fhir/codesystem-event-timing.html) or
  [V3TimingEvent](http://hl7.org/fhir/v3/TimingEvent/cs.html) code systems.
  // TODO: Determine whether or not we should use timing.code at all....*/
define function "ToDaily"(frequency Code ):
  case frequency
    when "C" then 3.0
    // etc.
    else Message(null, true, 'CMDLogic.ToDaily.UnknownFrequencyCode', ErrorLevel, 'Unknown frequency code ' & frequency.code)
  end
  
  /*
  Now that we have a ToDaily function, we can approach calculation of the
  duration of medication for an order. First, consider the definitions
  for each element:
  
  * 1 and only 1 dosageInstruction
  * 1 and only 1 doseAndRate
  * 1 timing with 1 repeat
  * frequency, frequencyMax, defaulting to 1
  * period, periodUnit, defaulting to 1 'd'
  * doseQuantity or doseRange
  * timeOfDay
  
  * authoredOn: The date the prescription was written
  * dispenseRequest.validityPeriod: Time period supply is authorized for
  * dispenseRequest.quantity: amount of medication supplied per dispense
  * dispenseRequest.numberOfRepeatsAllowed: number of refills authorized
  * dispenseRequest.expectedSupplyDuration: number of days supply per dispense
  * dosageInstruction.timing.repeat.boundsDuration: total duration of the repeat
  * dosageInstruction.timing.repeat.boundsRange: range of durations of the repeat
  * dosageInstruction.timing.repeat.boundsPeriod: period bounds of the repeat
  * dosageInstruction.timing.repeat.count: number of times to repeat
  * dosageInstruction.timing.repeat.countMax: maximum number of times to repeat
  * dosageInstruction.timing.repeat.frequency: event occurs frequency times per period
  * dosageInstruction.timing.repeat.frequencyMax: event occurs up to frequencyMax times per period
  * dosageInstruction.timing.repeat.period: event occurs frequency times per period
  * dosageInstruction.timing.repeat.periodMax: upper limit of period
  * dosageInstruction.timing.repeat.periodUnit: period duration (s | min | h | d | wk | mo | a)
  * dosageInstruction.timing.repeat.timeOfDay: time of day for the event (0..*)
  * dosageInstruction.timing.repeat.when: event timing (HS | WAKE | C | CM | CD | CV | AC | ACM...)
  * dosageInstruction.timing.code: BID | TID | QID | AM | PM | QD | QOD...
  * dosageInstruction.asNeeded
  * dosageInstruction.doseAndRate.doseQuantity
  * dosageInstruction.doseAndRate.doseRange
  
  If the boundsPeriod is present (and completely specified), we can use that directly
  
    dosage.timing.repeat.boundsPeriod
  
  If expectedSupplyDuration is present, then the duration is
  
    expectedSupplyDuration * (1 + numberOfRepeatsAllowed)
  
  If expectedSupplyDuration is not present, then it must be calculated based on the quantity, dosage, and frequency:
  
    (quantity / (dosage * frequency)) * (1 + numberOfRepeatsAllowed)
  
    dosage: Coalesce(end of doseAndRate.doseRange, doseAndRate.doseQuantity)
    frequency: Coalesce(frequencyMax, frequency)
    period: Quantity(period, periodUnit)
  
  This calculation results in a number of days, which can then be turned into a period by anchoring that to the
  start of the validityPeriod or the authoredOn:
  
    Interval[earliestDispensable, earliestDispensable + expectedSupplyDuration]
  
    earliestDispensable: Coalesce(start of validityPeriod, authoredOn)
  
  The following function illustrates this completely:
  */

/*Calculates the Medication Period for a single MedicationRequest.
MedicationRequest instances provided to this function are expected
to conform to the [MMEMedicationRequest](http://build.fhir.org/ig/cqframework/opioid-mme-r4/StructureDefinition-mmemedicationrequest.html)
profile, which expects:
* 1 and only 1 dosageInstruction, multiple dosageInstruction elements will result in an error
* 1 and only 1 doseAndRate, multiple doseAndRate elements will result in an error
* 1 timing with 1 repeat, missing timing or repeat elements will result in a null
* frequency, frequencyMax, defaulting to 1
* period, periodUnit, defaulting to 1 'd'
* timeOfDay
* doseQuantity or doseRange, missing doseQuantity and doseRange will result in a null
Note that MedicationRequest status is not considered by this calculation, as the
list of MedicationRequest instances provided to this function should already have
considered appropriate statuses, depending on the use case, typically `completed`.*/
define function "MedicationRequestPeriod"(Request "MedicationRequest" ):
  Request R
    let
      dosage: singleton from R.dosageInstruction,
      doseAndRate: singleton from dosage.doseAndRate,
      doseRange: doseAndRate.dose as Range,
      doseQuantity: doseAndRate.dose as SimpleQuantity,
      dose: Coalesce(end of doseRange, doseQuantity),
      timing: dosage.timing,
      frequency: Coalesce(timing.repeat.frequencyMax, timing.repeat.frequency),
      period: System.Quantity { value: timing.repeat.period, unit: timing.repeat.periodUnit.value },
      dosesPerDay: Coalesce(ToDaily(frequency, period), Count(timing.repeat.timeOfDay), 1.0),
      boundsPeriod: timing.repeat.bounds as Period,
      daysSupply: R.dispenseRequest.expectedSupplyDuration,
      quantity: R.dispenseRequest.quantity,
      refills: Coalesce(R.dispenseRequest.numberOfRepeatsAllowed, 0),
      startDate:
        Coalesce(
          start of boundsPeriod,
          start of R.dispenseRequest.validityPeriod,
          R.authoredOn
        )
    return
      if not (end of boundsPeriod is null or end of boundsPeriod = maximum DateTime) then
        Interval[startDate, end of boundsPeriod]
      else
        Interval[startDate, startDate + Coalesce(daysSupply, quantity / (dose * dosesPerDay)) * (1 + refills)]
  
  /*
  Next, consider the MedicationDispense case:
  
  * whenPrepared: When product was prepared
  * whenHandedOver: When product was given out
  * quantity: Amount dispensed
  * daysSupply: Amount of medication expressed as a timing amount
  * dosageInstruction.timing.repeat.boundsDuration: total duration of the repeat
  * dosageInstruction.timing.repeat.boundsRange: range of durations of the repeat
  * dosageInstruction.timing.repeat.boundsPeriod: period bounds of the repeat
  * dosageInstruction.timing.repeat.count: number of times to repeat
  * dosageInstruction.timing.repeat.countMax: maximum number of times to repeat
  * dosageInstruction.timing.repeat.frequency: event occurs frequency times per period
  * dosageInstruction.timing.repeat.frequencyMax: event occurs up to frequencyMax times per period
  * dosageInstruction.timing.repeat.period: event occurs frequency times per period
  * dosageInstruction.timing.repeat.periodMax: upper limit of period
  * dosageInstruction.timing.repeat.periodUnit: period duration (s | min | h | d | wk | mo | a)
  * dosageInstruction.timing.repeat.timeOfDay: time of day for the event (0..*)
  * dosageInstruction.timing.repeat.when: event timing (HS | WAKE | C | CM | CD | CV | AC | ACM...)
  * dosageInstruction.timing.code: BID | TID | QID | AM | PM | QD | QOD...
  * dosageInstruction.asNeeded
  * dosageInstruction.doseAndRate.doseQuantity
  * dosageInstruction.doseAndRate.doseRange
  
  We have effectively the same elements, with the same meanings, with the exception that the
  event is documenting a single dispense, and does not contain refill information. In addition,
  multiple dispense events would typically be present, and those would all have to be considered
  as part of an overall calculation. That will be considered when we combine results, but for
  this function, we'll focus on calculating the duration of a single dispense.
  
  With a MedicationDispense, dosage information is expected to be the same as the related
  MedicationRequest, so boundsPeriod would still cover the entire prescription (including refills)
  and so cannot be used to calculate the interval covered by the dispense.
  
  If the daysSupply element is present, then the duration in days is simply
  
    daysSupply
  
  Note specifically that we are not considering refills, as those would be covered
  by subsequent dispense records.
  
  If daysSupplied is not present, then daysSupplied must be calculated based on
  the quantity, dosage, and frequency:
  
    (quantity / (dosage * frequency))
  
  This calculation results in a number of days, which can then be turned into a
  period by anchoring that to the startDate, as determined by the first available
  value of the start of the boundsPeriod, whenHandedOver, and whenPrepared.
  
   Interval[startDate, startDate + durationInDays]
  */

/*Calculates Medication Period for a given MedicationDispense
MedicationDispense instances provided to this function are expected
to conform to the [TODO: MMEMedicationDispense](http://build.fhir.org/ig/cqframework/opioid-mme-r4/StructureDefinition-mmemedicationdispense.html)
profile, which expects:
* 1 and only 1 dosageInstruction, multiple dosageInstruction elements will result in an error
* 1 and only 1 doseAndRate, multiple doseAndRate elements will result in an error
* 1 timing with 1 repeat, missing timing or repeat elements will result in a null
* frequency, frequencyMax, defaulting to 1
* period, periodUnit, defaulting to 1 'd'
* timeOfDay
* doseQuantity or doseRange, missing doseQuantity and doseRange will result in a null
* whenHandedOver or whenPrepared, if missing both whenHandedOver and whenPrepared will result in a null

Note that MedicationDispense status is not considered by this calculation, as the
list of MedicationDispense instances provided to this function should already have
considered appropriate statuses, depending on the use case, typically `completed`,
especially since whenHandedOver would be expected to be present for a completed
MedicationDispense.

Note also that the dosage information recorded in a dispense is expected to be a copy of the
dispense information from the related medication request. As such, the boundsPeriod would be expected
to cover the entire range, and should _not_ be used for timing of the event.

There is also active discussion in the Pharmacy WG about what date should be used if whenPrepared/whenHandedOver is not present.
This may take the form of an "original creation date", but may also be a "status change date" for dispense events that are updating
status of an existing dispense. That discussion is ongoing, so until that is resolved, this logic will return
null if whenPrepared/whenHandedOver are not available.*/
define function "MedicationDispensePeriod"(Dispense "MedicationDispense" ):
  Dispense D
    let
      dosage: singleton from D.dosageInstruction,
      doseAndRate: singleton from dosage.doseAndRate,
      doseRange: doseAndRate.dose as Range,
      doseQuantity: doseAndRate.dose as SimpleQuantity,
      dose: Coalesce(end of doseRange, doseQuantity),
      timing: dosage.timing,
      frequency: Coalesce(timing.repeat.frequencyMax, timing.repeat.frequency),
      period: System.Quantity { value: timing.repeat.period, unit: timing.repeat.periodUnit.value },
      dosesPerDay: Coalesce(ToDaily(frequency, period), Count(timing.repeat.timeOfDay), 1.0),
      startDate:
        Coalesce(
          D.whenHandedOver,
          D.whenPrepared
        )
    return
        Interval[startDate, startDate + Coalesce(D.daysSupply, D.quantity / (dose * dosesPerDay))]

/*Returns the established therapeutic duration for a given medication.
This is likely measure specific, though could potentially be established for
any drug and distributed as a CodeSystem supplement.
Defaulting to 14 days here for illustration.*/
define function "TherapeuticDuration"(medication Concept ):
  14 days

/*Next we consider MedicationAdministration. This data type is typically used to
capture specific administration, with the relevantPeriod capturing start and stop
time of the administration event:

* effective[x]: Start and end time of administration

However, when calculating cumulative medication duration, it is typically the
therapeutic period of the medication that should be considered. Currently neither
the Medication nor MedicationKnowledge resources provide this information, so
we model it here as a function that can potentially be implemented in a variety
of ways, including measure-specific values, as well as distribution as an RxNorm
code system supplement.

However it is obtained, if therapeutic duration can be obtained, and the effective
period has a start, the result will be

    Interval[startDate, startDate + therapeuticDuration]*/
define function "MedicationAdministrationPeriod"(Administration "MedicationAdministration" ):
  Administration M
    let
      therapeuticDuration: TherapeuticDuration(Administration.medication),
      startDate: start of Administration.effective
    return
      if startDate is not null and therapeuticDuration is not null then
        Interval[startDate, startDate + therapeuticDuration]
      else
        null

/*Now that we have functions for determining the medication period for individual
prescriptions, administrations, and dispenses, we can combine those using
an overall cumulative medication duration calculation.

There are two broad approaches to calculating cumulative duration, one that _collapses_
overlapping intervals so that calculations are not duplicated, and one that _rolls out_
overlapping intervals so that the durations are laid end-to-end.

First, we define a function that simply calculates CumulativeDuration of a set of
intervals:*/
define function "CumulativeDuration"(Intervals List<Interval<DateTime>> ):
  Sum((collapse Intervals per day) X return all difference in days between start of X and end of X)

/*Next, we define a function that rolls out intervals:*/
define function "RolloutIntervals"(intervals List<Interval<DateTime>> ):
  intervals I
    aggregate all R starting (null as List<Interval<DateTime>>):
      R union ({
        I X
          let
            S: Max({ end of Last(R) + 1 day, start of X }),
            E: S + System.Quantity { value: Coalesce(duration in days of X, 0), unit: 'day' }
          return Interval[S, E]
      })

/*Then, we define a function that allows us to calculate based on the various medication
types:*/
define function "MedicationPeriod"(medication Choice<"MedicationRequest",
    "MedicationDispense",
    "MedicationAdministration"
  > ):
  case
    when medication is MedicationRequest then MedicationRequestPeriod(medication)
    when medication is MedicationDispense then MedicationDispensePeriod(medication)
    when medication is MedicationAdministration then MedicationAdministrationPeriod(medication)
    else null
  end

/*We can then use this function, combined with the MedicationDuration functions above
to calculate Cumulative Medication Duration:

Generally speaking, we want to _roll out_ intervals from dispense and administration
events, and then collapse across that result and intervals from prescriptions.

Note also that the separation of medications by type should already be done
by this stage as well.

Calculations that combine dosages from different types of medications (such as Morphine Milligram Equivalent (MME)
or Average MME) require further consideration.*/
define function "CumulativeMedicationDuration"(Medications List<Choice<"MedicationRequest",
    "MedicationDispense",
    "MedicationAdministration"
  >> ):
  CumulativeDuration((
      Medications M
        where M is MedicationRequest
        return MedicationPeriod(M)
    )
      union (
        RolloutIntervals(
          Medications M
            where M is MedicationDispense or M is MedicationAdministration
            return MedicationPeriod(M)
        )
      )
  )

