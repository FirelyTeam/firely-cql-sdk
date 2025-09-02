library NHSNGlycemicControlHypoglycemiaInitialPopulation version '0.0.001'

using QICore version '6.0.0'

include CQMCommon version '4.1.000' called CQMCommon
include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon
include NHSNHelpers version '0.1.000' called NHSNHelpers

codesystem "ActCode": 'http://terminology.hl7.org/CodeSystem/v3-ActCode'
codesystem "HSLOC": 'https://www.cdc.gov/nhsn/cdaportal/terminology/codesystem/hsloc.html'
codesystem "LOINC": 'http://loinc.org'
codesystem "RxNorm": 'https://www.nlm.nih.gov/research/umls/rxnorm/index.html'
codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Blood Glucose Laboratory and Point of Care Tests": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1190.38'
valueset "Diabetes Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1190.58'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Inpatient, Emergency, and Observation Locations": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.265'
valueset "NHSN Inpatient Encounter Class Codes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.274'

parameter "Measurement Period" Interval<DateTime> default Interval[@2026-01-01T00:00:00.0Z, @2026-12-31T23:59:00.0Z )

context Patient

// Initial Population


define "Initial Population":
  ( "Inpatient Encounters During Measurement Period"
    union "Encounters with Patient Hospital Locations" ) InpatientEncounters
    with "Antidiabetic Drugs Administered or Ordered" ADD
      such that Coalesce(start of ADD.effective.toInterval(), ADD.authoredOn) during InpatientEncounters."hospitalizationWithObservation" ( )
    where ( InpatientEncounters.status = 'finished'
        or InpatientEncounters.status = 'in-progress'
        or InpatientEncounters.status = 'triaged'
        or InpatientEncounters.status = 'onleave'
        or InpatientEncounters.status = 'entered-in-error'
    )

define "Inpatient Encounters During Measurement Period":
  [Encounter: "Encounter Inpatient"] InpatientEncounters
    where InpatientEncounters.period ends during day of "Measurement Period"
      and ( InpatientEncounters.class ~ QICoreCommon."inpatient non-acute"
          or InpatientEncounters.class ~ QICoreCommon."inpatient non-acute"
          or InpatientEncounters.class ~ QICoreCommon."short stay"
          or InpatientEncounters.class ~ QICoreCommon."inpatient acute"
          or InpatientEncounters.class ~ QICoreCommon."inpatient encounter"
      )

define "Encounters with Patient Hospital Locations":
  "Inpatient Encounters During Measurement Period" InpatientEncounter
    where exists ( InpatientEncounter.location HospitalLocation
        where HospitalLocation.location.getLocation ( ).type in "Inpatient, Emergency, and Observation Locations"
          and HospitalLocation.period during day of InpatientEncounter.period
    )

define "Antidiabetic Drugs Administered or Ordered":
  ( ( [MedicationAdministration: medication in "Diabetes Medications"] ADDMedAdmin
        where ADDMedAdmin.status ~ 'completed'
    )
      union ( [MedicationRequest: medication in "Diabetes Medications"] ADDOrder
          where ADDOrder.status ~ 'completed'
      )
  ) 
   

//Supplemental Data Elements


define "SDE Blood Glucose Observation":
  ( ["LaboratoryResultObservation": "Blood Glucose Laboratory and Point of Care Tests"] GlucoseTest
      where exists ( "Initial Population" InitialPopulation
          where start of GlucoseTest.effective.toInterval ( ) during day of InitialPopulation.period
            or GlucoseTest.issued during day of InitialPopulation.period
      )
      return { GlucoseTest.id, GlucoseTest.extension, GlucoseTest.text, GlucoseTest.referenceRange, GlucoseTest.component, GlucoseTest.basedOn, GlucoseTest.partOf, GlucoseTest.category, GlucoseTest.status, GlucoseTest.subject, GlucoseTest.focus, GlucoseTest.encounter, GlucoseTest.effective, GlucoseTest.issued, GlucoseTest.performer, GlucoseTest.value, GlucoseTest.dataAbsentReason, GlucoseTest.interpretation, GlucoseTest.note, GlucoseTest.bodySite, GlucoseTest.method, GlucoseTest.specimen, GlucoseTest.device, GlucoseTest.hasMember, GlucoseTest.derivedFrom }
  )

define "SDE Chief Complaint":
  "Initial Population" IP
    where exists ( IP.diagnosis InitialPopulationDiagnosis
        where InitialPopulationDiagnosis.use ~ QICoreCommon."CC"
    )
    return { IP.id, IP.meta, IP.identifier, IP.status, IP.statusHistory, IP.class, IP.classHistory, IP.type, IP.serviceType, IP.priority, IP.subject, IP.period, IP.length, IP.reasonCode, IP.reasonReference, IP.diagnosis, IP.account, IP.hospitalization, IP.location, IP.partOf }

define "Conditions":
  ["ConditionProblemsHealthConcerns"]
    union ["ConditionEncounterDiagnosis"]

define "SDE Condition":
  ["ConditionProblemsHealthConcerns"] Diagnosis
    where exists ( "Initial Population" IP
        where Diagnosis.prevalenceInterval ( ) overlaps day of IP.period
    )
    return { Diagnosis.id, Diagnosis.meta, Diagnosis.clinicalStatus, Diagnosis.verificationStatus, Diagnosis.category, Diagnosis.severity, Diagnosis.code, Diagnosis.bodySite, Diagnosis.subject, Diagnosis.encounter.reference.getId ( ), Diagnosis.onset, Diagnosis.stage, Diagnosis.evidence, Diagnosis.note }

define "SDE Coverage":
  [Coverage] Coverages
    where exists ( "Initial Population" IP
        where Coverages.period starts before or on day of IP.period
          and end of Coverages.period on or after day of end of IP.period
    )
    return { Coverages.id, Coverages.meta, Coverages.status, Coverages.type, Coverages.policyHolder, Coverages.subscriber, Coverages.subscriberId, Coverages.beneficiary, Coverages.dependent, Coverages.relationship, Coverages.period, Coverages.payor, Coverages.class, Coverages.order, Coverages.network, Coverages.subrogation, Coverages.contract }

define "Encounters":
  [Encounter]

define "SDE Encounter Locations":
  "Initial Population" IP
    where exists ( IP.location InitialPopulationLocation
        let types: ( InitialPopulationLocation.location ).getLocation ( ).type
        where exists ( types type
            where type in "Inpatient, Emergency, and Observation Locations"
        )
          and InitialPopulationLocation.period during IP.period
    )
    return { IP.id, IP.meta, IP.identifier, IP.status, IP.statusHistory, IP.class, IP.classHistory, IP.type, IP.serviceType, IP.priority, IP.subject, IP.period, IP.length, IP.reasonCode, IP.reasonReference, IP.diagnosis, IP.account, IP.hospitalization, IP.location, IP.partOf }

define "Get Locations from Initial Population":
  flatten ( "Initial Population" IP
      let locationElements: IP.location
      return locationElements LE
        let locationReference: LE.location
        return ( locationReference.getLocation ( ) )
  )

define "SDE Location":
  "Get Locations from Initial Population" Locations
    where exists "Initial Population"
      and Locations is not null
    return { Locations.id, Locations.meta, Locations.extension, Locations.status, Locations.operationalStatus, Locations.name, Locations.alias, Locations.description, Locations.mode, Locations.type, Locations.telecom, Locations.address, Locations.physicalType, Locations.position, Locations.managingOrganization, Locations.partOf, Locations.hoursOfOperation, Locations.availabilityExceptions, Locations.endpoint }

define "SDE Initial Population Encounters":
  "Initial Population" IP
    return { IP.id, IP.meta, IP.identifier, IP.status, IP.statusHistory, IP.class, IP.classHistory, IP.type, IP.serviceType, IP.priority, IP.subject, IP.period, IP.length, IP.reasonCode, IP.reasonReference, IP.diagnosis, IP.account, IP.hospitalization, IP.location, IP.partOf }

define "SDE Medication":
  ( "MedicationRequests"
    union "MedicationAdministrations" ) MedReqOrAdmin
    let medication: GetMedication(MedReqOrAdmin.medication)
    where medication is not null
      and exists ( "Initial Population" IP
          where Coalesce(MedReqOrAdmin.effective.toInterval(), MedReqOrAdmin.authoredOn.toInterval()) overlaps IP."hospitalizationWithObservation" ( )
      )
    return { medication.id, medication.meta, medication.code, medication.status, medication.manufacturer, medication.form, medication.amount, medication.ingredient, medication.batch }

define function "GetMedication"(reference Reference):
  singleton from ( [Medication] Medication
      where reference.references ( Medication )
  )

define "MedicationAdministrations":
  [MedicationAdministration]

define "SDE Medication Administration":
  "MedicationAdministrations" MedAdministrations
    where exists ( "Initial Population" InitialPopulation
        where MedAdministrations.effective.toInterval ( ) overlaps InitialPopulation."hospitalizationWithObservation" ( )
    )
    return { MedAdministrations.id, MedAdministrations.meta, MedAdministrations.instantiates, MedAdministrations.partOf, MedAdministrations.status, MedAdministrations.statusReason, MedAdministrations.category, MedAdministrations.medication, MedAdministrations.subject, MedAdministrations.context, MedAdministrations.supportingInformation, MedAdministrations.effective, MedAdministrations.performer, MedAdministrations.reasonCode, MedAdministrations.reasonReference, MedAdministrations.request, MedAdministrations.device, MedAdministrations.note, MedAdministrations.dosage }

define "MedicationRequests":
  [MedicationRequest]

define "SDE Medication Request":
  "MedicationRequests" MedRequests
    where exists ( "Initial Population" InitialPopulation
        where MedRequests.authoredOn during InitialPopulation."hospitalizationWithObservation" ( )
    )
    return { MedRequests.id, MedRequests.meta, MedRequests.status, MedRequests.statusReason, MedRequests.intent, MedRequests.category, MedRequests.priority, MedRequests.doNotPerform, MedRequests.reported, MedRequests.medication, MedRequests.subject, MedRequests.encounter, MedRequests.authoredOn, MedRequests.requester, MedRequests.recorder, MedRequests.reasonCode, MedRequests.reasonReference, MedRequests.instantiatesCanonical, MedRequests.instantiatesUri, MedRequests.courseOfTherapyType, MedRequests.dosageInstruction }

define "SDE Minimal Patient":
  [Patient] MinPt
    where exists "Initial Population"
    return { MinPt.id, MinPt.meta, MinPt.extension, MinPt.identifier, MinPt.active, MinPt.name, MinPt.telecom, MinPt.gender, MinPt.birthDate, MinPt.deceased, MinPt.address, MinPt.maritalStatus, MinPt.multipleBirth, MinPt.photo, MinPt.contact, MinPt.communication, MinPt.generalPractitioner, MinPt.managingOrganization, MinPt.link }

define "SDE Service Request":
  [ServiceRequest] ServiceRequests
    where exists ( "Initial Population" InitialPopulation
        where ServiceRequests.authoredOn during InitialPopulation.period
    )
    return { ServiceRequests.id, ServiceRequests.meta, ServiceRequests.instantiatesCanonical, ServiceRequests.instantiatesUri, ServiceRequests.basedOn, ServiceRequests.replaces, ServiceRequests.requisition, ServiceRequests.status, ServiceRequests.intent, ServiceRequests.category, ServiceRequests.priority, ServiceRequests.doNotPerform, ServiceRequests.code, ServiceRequests.orderDetail, ServiceRequests.quantity, ServiceRequests.subject, ServiceRequests.encounter, ServiceRequests.occurrence, ServiceRequests.asNeeded, ServiceRequests.authoredOn, ServiceRequests.requester, ServiceRequests.performerType, ServiceRequests.performer, ServiceRequests.locationCode, ServiceRequests.reasonCode, ServiceRequests.reasonReference, ServiceRequests.insurance, ServiceRequests.bodySite, ServiceRequests.note, ServiceRequests.patientInstruction }

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"