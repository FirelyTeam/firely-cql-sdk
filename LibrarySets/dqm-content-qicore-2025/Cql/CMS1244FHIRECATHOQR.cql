library CMS1244FHIRECATHOQR version '1.0.000'

using QICore version '6.0.0'

include CQMCommon version '4.1.000' called CQMCommon
include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '4.0.000' called QICoreCommon
include SupplementalDataElements version '5.1.000' called SDE

codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "RoleCode": 'http://terminology.hl7.org/CodeSystem/v3-RoleCode'

valueset "Admit Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.164'
valueset "Mental Health Diagnosis without Substance Use Disorders": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.285'
valueset "Decision to Admit to Hospital Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.294'
valueset "Emergency Department Evaluation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.163'
valueset "Emergency Department Evaluation and Management Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010'
valueset "Emergency Department Location": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.284'
valueset "Emergency Department Treatment Location": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.278'
valueset "Observation Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Triage": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.279'

code "Patient bed assigned (finding)": '5751000175101' from "SNOMEDCT" display 'Patient bed assigned (finding)'
code "Patient left without being seen (finding)": '21541000119102' from "SNOMEDCT" display 'Patient left without being seen (finding)'
code "Emergency room": 'ER' from "RoleCode" display 'Emergency room'
code "Emergency trauma unit": 'ETU' from "RoleCode" display 'Emergency trauma unit'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
  "ED Evaluation and Management"
    union "ED Triage Excluding Those Prior To ED Encounters"

define "Denominator":
  "Initial Population"

define "Numerator":
  "Time to Treatment Room Greater Than 60 Minutes"
    union "ED Arrival Left Without Being Seen"
    union "Boarded Time Greater Than 240 Minutes and No Observation Stay"
    union "ED Length of Stay Greater Than 480 Minutes and No Observation Stay"

define "Pediatric With No Mental Health Diagnosis":
  ( "ED Encounter or Triage of Patients Less Than 18 Years" PediatricEDEncounters
      where not ( PediatricEDEncounters.hasPrincipalDiagnosisOf ( "Mental Health Diagnosis without Substance Use Disorders" ) )
  )

define "Adult With No Mental Health Diagnosis":
  ( "ED Encounter or Triage of Patients 18 Years and Older" AdultEDEncounters
      where not ( AdultEDEncounters.hasPrincipalDiagnosisOf ( "Mental Health Diagnosis without Substance Use Disorders" ) )
  )

define "Pediatric With Mental Health Diagnosis":
  ( "ED Encounter or Triage of Patients Less Than 18 Years" PediatricEDEncounters
      where ( PediatricEDEncounters.hasPrincipalDiagnosisOf ( "Mental Health Diagnosis without Substance Use Disorders" ) )
  )

define "Adult With Mental Health Diagnosis":
  ( "ED Encounter or Triage of Patients 18 Years and Older" AdultEDEncounters
      where ( AdultEDEncounters.hasPrincipalDiagnosisOf ( "Mental Health Diagnosis without Substance Use Disorders" ) )
  )

define "Stratification 1":
  "Pediatric With No Mental Health Diagnosis"

define "Stratification 2":
  "Adult With No Mental Health Diagnosis"

define "Stratification 3":
  "Pediatric With Mental Health Diagnosis"

define "Stratification 4":
  "Adult With Mental Health Diagnosis"

define "Admitted to Inpatient 241 Minutes or More Before Departure":
  "Denominator" EDEncounter
    with CQMCommon."Inpatient Encounter" Inpatient
      such that Inpatient.holdingInEDAfterAdmission ( ) 241 minutes or more before EDEncounter.edDepartureTime ( )

define "Boarded Time Greater Than 240 Minutes":
  "Decision to Admit Encounter Order"
    union "Decision to Admit Using Assessment"
    union "Time of Admit Order Or Bed Assignment to Departure Greater Than 241 Minutes"
    union "Admitted to Inpatient 241 Minutes or More Before Departure"

define "Boarded Time Greater Than 240 Minutes and No Observation Stay":
  ( "Boarded Time Greater Than 240 Minutes" Boarding
      where not exists ( "ED Observation Status" EDObs
          where ( EDObs.period during Boarding.period )
      )
  )

define "Decision to Admit Encounter Order":
  "Denominator" EDEncounter
    with CQMCommon."Inpatient Encounter" EncounterInpatient
      such that EncounterInpatient.admitDecisionUsingEncounterOrder ( ) 241 minutes or more before EDEncounter.edDepartureTime ( )

define "Decision to Admit Using Assessment":
  "Denominator" EDEncounter
    with CQMCommon."Inpatient Encounter" EncounterInpatient
      such that EncounterInpatient.admitDecisionUsingAssessment ( ) 241 minutes or more before EDEncounter.edDepartureTime ( )

define "ED Arrival Left Without Being Seen":
  "Denominator" EDEncounter
    where EDEncounter.hospitalization.dischargeDisposition ~ "Patient left without being seen (finding)"

define "ED Evaluation and Management":
  [Encounter: "Emergency Department Evaluation and Management Visit"] EDEvalManagementVisit
    where EDEvalManagementVisit.period ends during day of "Measurement Period"
      and EDEvalManagementVisit.status = 'finished'

define "ED Encounter or Triage of Patients 18 Years and Older":
  "Denominator" EDEncounter
    where AgeInYearsAt(date from start of "Measurement Period") >= 18

define "ED Encounter or Triage of Patients Less Than 18 Years":
  "Denominator" EDEncounter
    where AgeInYearsAt(date from start of "Measurement Period") < 18

define "ED Length of Stay Greater Than 480 Minutes":
  "Denominator" EDEncounter
    where EDEncounter.edArrivalTime ( ) 481 minutes or more before EDEncounter.edDepartureTime ( )

define "ED Length of Stay Greater Than 480 Minutes and No Observation Stay":
  ( "ED Length of Stay Greater Than 480 Minutes" EDStay
      where not exists ( "ED Observation Status" EDObs
          where ( EDObs.period during EDStay.period )
      )
  )

define "ED Observation Status":
  [Encounter: "Observation Services"] EDObsEncounter
    with "Denominator" EDEncounter
      such that EDObsEncounter.period during EDEncounter.period
        and EDObsEncounter.status = 'finished'

define "ED Triage":
  ( [Encounter: "Triage"] EDTriage
      where EDTriage.period ends during day of "Measurement Period"
        and EDTriage.status in { 'finished', 'triaged' }
  )

define "ED Triage Excluding Those Prior To ED Encounters":
  "ED Triage" EDTriageinMP
    where not exists ( "ED Evaluation and Management" EDEvalManagementInMP
        where ( ( EDTriageinMP.period overlaps before EDEvalManagementInMP.period )
            or ( EDTriageinMP.period during EDEvalManagementInMP.period )
            or ( EDEvalManagementInMP.period during EDTriageinMP.period )
            or ( EDTriageinMP.period ends 120 minutes or less before start of EDEvalManagementInMP.period )
        )
    )

define "ED Triage Before Evaluation Management":
  "ED Triage" EDTriageinMP
    with "Denominator" EDEncounter
      such that ( ( EDTriageinMP.period overlaps before EDEncounter.period )
          or ( EDTriageinMP.period during EDEncounter.period )
          or ( EDEncounter.period during EDTriageinMP.period )
          or ( EDTriageinMP.period ends 120 minutes or less before start of EDEncounter.period )
      )

define "ED Triage and Evaluation Management":
  "Denominator"
    union "ED Triage Before Evaluation Management"

define "Time of Admit Order Or Bed Assignment to Departure Greater Than 241 Minutes":
  "Denominator" EDEncounter
    with CQMCommon."Inpatient Encounter" InpatientEncounter
      such that InpatientEncounter.admitInpatientOrBedAssignmentEncounterOrder ( ) 241 minutes or more before EDEncounter.edDepartureTime ( )

define "Time to Treatment Room Greater Than 60 Minutes":
  "ED Evaluation and Management" EDEvalManagementInMP
    where EDEvalManagementInMP.edArrivalTime ( ) 61 minutes or more before EDEvalManagementInMP.edTreatmentRoomTimeArrivalTime ( )

define "Assessment In ED":
  ["ObservationClinicalResult": "Emergency Department Evaluation"]
    union ["SimpleObservation": "Emergency Department Evaluation"] ObsInED
      where ObsInED.value as Concept in "Admit Inpatient"

define fluent function "admitDecisionUsingAssessment"(EncounterInpatient Encounter):
  Last("Assessment In ED" EDEvaluation
      let LastEDVisit: EncounterInpatient.lastEDEncounter()
      where EDEvaluation.effective.toInterval() starts during LastEDVisit.period
        and EDEvaluation.status in { 'final', 'amended', 'corrected' }
      return start of EDEvaluation.effective.toInterval()
      sort ascending
  )

define "ED To Inpatient Order":
  [ServiceRequest: "Decision to Admit to Hospital Inpatient"] AdmitIPOrder
    where AdmitIPOrder.status in { 'active', 'completed' }

define fluent function "admitDecisionUsingEncounterOrder"(EncounterInpatient Encounter):
  Last("ED To Inpatient Order" AdmitOrder
      let LastEDVisit: EncounterInpatient.lastEDEncounter()
      where AdmitOrder.authoredOn during LastEDVisit.period
        and AdmitOrder.intent ~ 'order'
      return AdmitOrder.authoredOn
      sort ascending
  )

define "Inpatient Or Bed Assignment Encounter Order":
  ( [ServiceRequest: "Encounter Inpatient"]
    union [ServiceRequest: "Patient bed assigned (finding)"] ) IPRequest
    where IPRequest.status in { 'active', 'completed' }

define fluent function "admitInpatientOrBedAssignmentEncounterOrder"(Encounter Encounter):
  Last(("Inpatient Or Bed Assignment Encounter Order") AdmitInpatientOrder
      let LastEDVisit: Encounter.lastEDEncounter()
      where AdmitInpatientOrder.authoredOn during LastEDVisit.period
      return AdmitInpatientOrder.authoredOn
      sort ascending
  )

define fluent function "edArrivalTime"(EDEncounter Encounter):
  Last("ED Triage and Evaluation Management".location Location
      where exists((Location.location.getLocation().type) LocationType
          where(LocationType in "Emergency Department Location"
              or LocationType ~ "Emergency room"
              or LocationType ~ "Emergency trauma unit"
          )
      )
        and start of Location.period is not null
        and(Location.period ends 120 minutes or less before start of EDEncounter.period
            or Location.period overlaps before EDEncounter.period
            or EDEncounter.period overlaps before Location.period
            or Location.period starts same as start of EDEncounter.period
        )
      return start of Location.period
      sort ascending
  )

define fluent function "edDepartureTime"(EDEncounter Encounter):
  Last("ED Triage and Evaluation Management".location Location
      where exists((Location.location.getLocation().type) LocationType
          where(LocationType in "Emergency Department Location"
              or LocationType ~ "Emergency room"
              or LocationType ~ "Emergency trauma unit"
          )
      )
        and 
        end of Location.period is not null
        and(Location.period ends 120 minutes or less before start of EDEncounter.period
            or Location.period overlaps before EDEncounter.period
            or EDEncounter.period overlaps before Location.period
            or Location.period starts same as start of EDEncounter.period
        )
      return 
      end of Location.period
      sort ascending
  )

define fluent function "edTreatmentRoomTimeArrivalTime"(EDEncounter Encounter):
  First(EDEncounter.location Location
      where Location.location.getLocation().type in "Emergency Department Treatment Location"
        and start of Location.period is not null
      return start of Location.period
      sort ascending
  )

define fluent function holdingInEDAfterAdmission(InpatientEncounter Encounter):
  Last(CQMCommon."Inpatient Encounter" AdmittedInpatient
      let LastEDVisit: InpatientEncounter.lastEDEncounter()
      where start of AdmittedInpatient.period during LastEDVisit.period
      return start of AdmittedInpatient.period
      sort ascending
  )

define fluent function "lastEDEncounter"(EncounterInpatient Encounter):
  Last("ED Evaluation and Management" EDEvalManagementInMP
      where EDEvalManagementInMP.period starts 1 day or less before or on start of EncounterInpatient.period
        and EDEvalManagementInMP.period starts before start of EncounterInpatient.period
        and EDEvalManagementInMP.period during day of "Measurement Period"
        and EDEvalManagementInMP.status = 'finished'
      sort by 
      end of period ascending
  )

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"