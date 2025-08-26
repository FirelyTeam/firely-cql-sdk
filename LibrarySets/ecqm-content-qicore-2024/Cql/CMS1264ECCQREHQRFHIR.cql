library CMS1264ECCQREHQRFHIR version '0.3.001'

using QICore version '4.1.1'

include CQMCommon version '2.2.000' called CQMCommon
include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '2.1.000' called QICoreCommon
include SupplementalDataElements version '3.5.000' called SDE

codesystem "CPT": 'http://www.ama-assn.org/go/cpt'
codesystem "HSLOC": 'http://terminology.hl7.org/CodeSystem/hsloc'
codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Mental Health Diagnosis without Substance Use Disorders": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.285'
valueset "Decision to Transfer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.286'
valueset "Emergency Department Evaluation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.163'
valueset "Emergency Department Evaluation and Management Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010'
valueset "Emergency Department Location": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.284'
valueset "Emergency Department Treatment Location": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.278'
valueset "Emergency Department Observation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1170.22'
valueset "Triage": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.279'

code "Patient left without being seen (finding)": '21541000119102' from "SNOMEDCT" display 'Patient left without being seen (finding)'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2026-12-31T23:59:59.999Z]

context Patient

define "Initial Population":
  "ED Encounter"
    union "ED Triage"

define "Denominator":
  "Initial Population"

define "Numerator":
  "Time to Treatment Room Greater Than 60 Minutes"
    union "ED Arrival Left Without Being Seen"
    union "Boarded Time Greater Than 240 Minutes and No Observation Stay"
    union "ED Length of Stay Greater Than 480 Minutes and No Observation Stay"

define "Stratification 1: Pediatric With No Mental Health Diagnosis":
  ( "ED Encounter or Triage of Patients Less Than 18 Years" EDEncounter
      let ConditionCode: EDEncounter.principalDiagnosis ( ).code
      where not ( ConditionCode in "Mental Health Diagnosis without Substance Use Disorders" )
  )

define "Stratification 2: Adult With No Mental Health Diagnosis":
  ( "ED Encounter or Triage of Patients 18 Years and Older" EDEncounter
      let ConditionCode: EDEncounter.principalDiagnosis ( ).code
      where not ( ConditionCode in "Mental Health Diagnosis without Substance Use Disorders" )
  )

define "Stratification 3: Pediatric With Mental Health Diagnosis":
  ( "ED Encounter or Triage of Patients Less Than 18 Years" EDEncounter
      let ConditionCode: EDEncounter.principalDiagnosis ( ).code
      where ( ConditionCode in "Mental Health Diagnosis without Substance Use Disorders" )
  )

define "Stratification 4: Adult With Mental Health Diagnosis":
  ( "ED Encounter or Triage of Patients 18 Years and Older" EDEncounter
      let ConditionCode: EDEncounter.principalDiagnosis ( ).code
      where ( ConditionCode in "Mental Health Diagnosis without Substance Use Disorders" )
  )

define "Boarded Time Greater Than 240 Minutes":
  "Denominator" EDEncounter
    where "TransferDecisionUsingOrder"() 241 minutes or more before "EDDepartureTime"(EDEncounter)

define "Boarded Time Greater Than 240 Minutes and No Observation Stay":
  ( "Boarded Time Greater Than 240 Minutes" Boarding
      where not exists ( "ED Observation Status" EDO
          where ( EDO.period starts during Boarding.period
              or EDO.authoredOn during Boarding.period
          )
      )
  )

define "ED Arrival Left Without Being Seen":
  "ED Triage" EDTriage
    where EDTriage.hospitalization.dischargeDisposition ~ "Patient left without being seen (finding)"

define "ED Encounter":
  [Encounter: "Emergency Department Evaluation and Management Visit"] EDEncounter
    where EDEncounter.period ends during day of "Measurement Period"

define "ED Encounter or Triage of Patients 18 Years and Older":
  "Denominator" EDEncounter
    where AgeInYearsAt(date from start of EDEncounter.period) >= 18

define "ED Encounter or Triage of Patients Less Than 18 Years":
  "Denominator" EDEncounter
    where AgeInYearsAt(date from start of EDEncounter.period) < 18

define "ED Length of Stay Greater Than 480 Minutes":
  "Denominator" EDEncounter
    where "EDArrivalTime"(EDEncounter) 481 minutes or more before "EDDepartureTime"(EDEncounter)

define "ED Length of Stay Greater Than 480 Minutes and No Observation Stay":
  ( "ED Length of Stay Greater Than 480 Minutes" EDStay
      where not exists ( "ED Observation Status" EDO
          where ( EDO.period starts during EDStay.period
              or EDO.authoredOn during EDStay.period
          )
      )
  )

define "ED Observation Status":
  ( "ED Observation Encounter Status"
    union "ED Observation Order Status" ) EDObservation
    with "Denominator" EDStay
      such that EDObservation.period during EDStay.period
        or ( EDObservation.authoredOn during EDStay.period )

define "ED Observation Encounter Status":
  [Encounter: "Emergency Department Observation"] EDObsEncounter
    with "Denominator" EDEncounter
      such that start of EDObsEncounter.period during EDEncounter.period
        and EDEncounter.status = 'finished'
        and EDObsEncounter.status = 'finished'

define "ED Observation Order Status":
  [ServiceRequest: code in "Emergency Department Observation"] EDObsOrder
    with "Denominator" EDEncounter
      such that EDObsOrder.authoredOn during EDEncounter.period
        and EDEncounter.status = 'finished'
        and EDObsOrder.status = 'active'

define "ED Triage":
  [Encounter: "Triage"] EDTriage
    where EDTriage.period ends during day of "Measurement Period"

define "Time to Treatment Room Greater Than 60 Minutes":
  "Denominator" EDEncounter
    where "EDArrivalTime"(EDEncounter) 61 minutes or more before "EDTreatmentRoomTimeArrivalTime"(EDEncounter)

define function "EDArrivalTime"(EDEncounter Encounter):
  Last(EDEncounter.location Location
      where Location.location.getLocation().type in "Emergency Department Location"
        and start of Location.period is not null
      return start of Location.period
      sort ascending
  )

define function "EDDepartureTime"(EDEncounter Encounter):
  Last(EDEncounter.location Location
      where Location.location.getLocation().type in "Emergency Department Location"
        and 
        end of Location.period is not null
      return 
      end of Location.period
      sort ascending
  )

define function "EDTreatmentRoomTimeArrivalTime"(EDEncounter Encounter):
  Last(EDEncounter.location Location
      where Location.location.getLocation().type in "Emergency Department Treatment Location"
        and start of Location.period is not null
      return start of Location.period
      sort ascending
  )

define function "TransferDecisionUsingOrder"():
  Last([ServiceRequest: code in "Decision to Transfer"] TransferOrder
      with [Encounter: "Emergency Department Evaluation and Management Visit"] EDVisit
        such that TransferOrder.authoredOn during EDVisit.period
          and TransferOrder.intent = 'order'
          and TransferOrder.status = 'completed'
          and EDVisit.status = 'finished'
      return TransferOrder.authoredOn
      sort ascending
  )

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"