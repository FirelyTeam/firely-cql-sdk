library CqlAggregateTest version '1.0.0'

using FHIR version '4.0.1'

context Patient

/*
define "FactorialOfFive":
  ({ 1, 2, 3, 4, 5 }) Num
    aggregate Result starting 1: Result * Num = 120
*/

/*
define "RolledOutIntervals":
  MedicationRequestIntervals M
    aggregate R starting (null as List<Interval<DateTime>>): R union ({
      M X
        let S: Max({ end of Last(R) + 1 day, start of X }),
          E: S + duration in days of X
        return Interval[S, E]
    })
 */