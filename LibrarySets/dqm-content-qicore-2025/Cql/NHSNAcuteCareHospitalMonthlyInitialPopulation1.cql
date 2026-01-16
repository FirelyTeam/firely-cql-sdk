library NHSNAcuteCareHospitalMonthlyInitialPopulation1 version '0.0.000'

// Rebased to QI Core 6.0.0


using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '4.0.000' called QICoreCommon
include CQMCommon version '4.1.000' called CQMCommon
// NHSNHelpers logic is inlined below


codesystem "ActCode": 'http://terminology.hl7.org/CodeSystem/v3-ActCode'
codesystem "Observation Category": 'http://terminology.hl7.org/CodeSystem/observation-category'
codesystem "LOINC": 'http://loinc.org'
codesystem "Condition Category": 'http://terminology.hl7.org/CodeSystem/condition-category'
codesystem "US Core Condition Category": 'http://hl7.org/fhir/us/core/CodeSystem/condition-category'
codesystem "Condition Clinical Status": 'http://terminology.hl7.org/CodeSystem/condition-clinical'
codesystem "SNOMEDCT": 'http://snomed.info/sct'
codesystem "MedicationRequest Category": 'http://terminology.hl7.org/CodeSystem/medicationrequest-category'

valueset "Inpatient, Emergency, and Observation Locations": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.265'
valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Observation Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143'
valueset "NHSN Inpatient Encounter Class Codes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1046.274'

// Observation Category codes


code "laboratory": 'laboratory' from "Observation Category" display 'Laboratory'
code "social-history": 'social-history' from "Observation Category" display 'Social History'
code "vital-signs": 'vital-signs' from "Observation Category" display 'Vital Signs'
code "imaging": 'imaging' from "Observation Category" display 'Imaging'
code "procedure": 'procedure' from "Observation Category" display 'Procedure'
code "survey": 'survey' from "Observation Category" display 'Survey'

// Condition category

code "encounter-diagnosis": 'encounter-diagnosis' from "Condition Category" display 'Encounter Diagnosis'

// Diagnostic Report Category (LOINC-based)

code "Radiology": 'LP29684-5' from "LOINC" display 'Radiology'
code "Pathology": 'LP7839-6' from "LOINC" display 'Pathology'
code "Cardiology": 'LP29708-2' from "LOINC" display 'Cardiology'

// Emergency Encounter Class

code "emergency": 'EMER' from "ActCode" display 'emergency'
code "observation encounter": 'OBSENC' from "ActCode" display 'observation encounter'

// Condition clinicalStatus

code "active": 'active' from "Condition Clinical Status" display 'active'

// Procedure category

code "Surgical procedure": '387713003' from "SNOMEDCT" display 'Surgical procedure'
code "Diagnostic procedure": '103693007' from "SNOMEDCT" display 'Diagnostic procedure'

// MedicationRequest category

code "inpatient": 'inpatient' from "MedicationRequest Category" display 'Inpatient'
code "outpatient": 'outpatient' from "MedicationRequest Category" display 'Outpatient'

// ServiceRequest category

code "Laboratory procedure": '108252007' from "SNOMEDCT" display 'Laboratory procedure'
code "Imaging": '363679005' from "SNOMEDCT" display 'Imaging'

parameter "Measurement Period" Interval<DateTime>default Interval[@2025-01-01T00:00:00.0, @2025-01-31T23:59:59.0 )

context Patient 

// ----------------------------------------------------------------------
// Core encounter logic
// ----------------------------------------------------------------------

// Encounters with NHSN class codes (IMP, ACUTE, NONAC, SS)





define "Encounters with NHSN Inpatient Class":
  [Encounter] Enc
    where Enc.class ~ QICoreCommon."inpatient encounter"
      or Enc.class ~ QICoreCommon."inpatient acute"
      or Enc.class ~ QICoreCommon."inpatient non-acute"
      or Enc.class ~ QICoreCommon."short stay"

define "Qualifying Encounters During Measurement Period":
  ( [Encounter: "Encounter Inpatient"]
    union [Encounter: "Emergency Department Visit"]
    union [Encounter: "Observation Services"]
    union "Encounters with NHSN Inpatient Class"
    union [Encounter: class ~ "emergency"]
    union [Encounter: class ~ "observation encounter"] ) QualifyingEncounters
    where QualifyingEncounters.status in { 'in-progress', 'finished', 'triaged', 'onleave', 'entered-in-error' }
      and QualifyingEncounters.period overlaps "Measurement Period"

define "Encounters":
  [Encounter]

define "Encounters with Patient Hospital Locations":
  "Encounters" Ens
    where exists ( Ens.location EncounterLocation
        where EncounterLocation.period overlaps Ens.period
          and EncounterLocation.location.getLocation ( ).type in "Inpatient, Emergency, and Observation Locations"
    )
      and Ens.status in { 'in-progress', 'finished', 'triaged', 'onleave', 'entered-in-error' }
      and Ens.period overlaps "Measurement Period"

define "Initial Population":
  "Qualifying Encounters During Measurement Period"
    union "Encounters with Patient Hospital Locations"

// ----------------------------------------------------------------------
// Core retrieves
// ----------------------------------------------------------------------

// Locations from IP encounters





define "Get Locations from IP Encounters in Measurement Period":
  flatten ( "Initial Population" IP
      let locationElements: IP.location
      return locationElements LE
        let locationReference: LE.location
        return locationReference.getLocation ( )
  )

// ----------------------------------------------------------------------
// SDEs
// ----------------------------------------------------------------------




define "SDE Condition Problems HealthConcerns":
  [ConditionProblemsHealthConcerns] Diagnosis
    where exists ( "Initial Population" IP
        where Diagnosis.prevalenceInterval ( ) overlaps day of IP.period
    )
    return {
      id: Diagnosis.id,
      meta: Diagnosis.meta,
      status: Diagnosis.clinicalStatus,
      verificationStatus: Diagnosis.verificationStatus,
      category: Diagnosis.category,
      severity: Diagnosis.severity,
      code: Diagnosis.code,
      bodySite: Diagnosis.bodySite,
      subject: Diagnosis.subject,
      encounterReferenceId: Diagnosis.encounter.reference.getId ( ),
      onset: Diagnosis.onset,
      stage: Diagnosis.stage,
      evidence: Diagnosis.evidence,
      note: Diagnosis.note
    }

define "SDE Condition Diagnosis":
  [ConditionEncounterDiagnosis] Diagnosis
    where exists ( "Initial Population" IP
        where Diagnosis.prevalenceInterval ( ) overlaps day of IP.period
    )
    return {
      id: Diagnosis.id,
      meta: Diagnosis.meta,
      status: Diagnosis.clinicalStatus,
      verificationStatus: Diagnosis.verificationStatus,
      category: Diagnosis.category,
      severity: Diagnosis.severity,
      code: Diagnosis.code,
      bodySite: Diagnosis.bodySite,
      subject: Diagnosis.subject,
      encounterReferenceId: Diagnosis.encounter.reference.getId ( ),
      onset: Diagnosis.onset,
      stage: Diagnosis.stage,
      evidence: Diagnosis.evidence,
      note: Diagnosis.note
    }

// Coverage SDE – tuples of Coverage data


define "SDE Coverage":
  [Coverage] Coverages
    where exists ( "Initial Population" IP
        where Coverages.period overlaps IP.period
    )
    return {
      id: Coverages.id,
      meta: Coverages.meta,
      status: Coverages.status,
      type: Coverages.type,
      policyHolder: Coverages.policyHolder,
      subscriber: Coverages.subscriber,
      subscriberId: Coverages.subscriberId,
      beneficiary: Coverages.beneficiary,
      dependent: Coverages.dependent,
      relationship: Coverages.relationship,
      period: Coverages.period,
      payor: Coverages.payor,
      class: Coverages.class,
      order: Coverages.order,
      network: Coverages.network,
      subrogation: Coverages.subrogation,
      contract: Coverages.contract
    }

// Device SDE – tuples of Device data


define "SDE Device":
  [Device] Devices
    where exists ( "Initial Population" )
    return {
      id: Devices.id,
      meta: Devices.meta,
      extension: Devices.extension,
      status: Devices.status,
      expirationDate: Devices.expirationDate,
      lotNumber: Devices.lotNumber,
      serialNumber: Devices.serialNumber,
      modelNumber: Devices.modelNumber,
      partNumber: Devices.partNumber,
      type: Devices.type,
      patient: Devices.patient,
      parent: Devices.parent
    }

// DiagnosticReport SDEs


define "SDE DiagnosticReport Lab":
  [DiagnosticReportLab] dr
    where exists ( "Initial Population" IP
        where "Normalize Interval"(dr.effective) overlaps IP.period
    )

define "SDE DiagnosticReport Note":
  [DiagnosticReportNote] dr
    where ( exists ( dr.category Category
          where Category ~ "Radiology"
      )
        or exists ( dr.category Category
            where Category ~ "Pathology"
        )
        or exists ( dr.category Category
            where Category ~ "Cardiology"
        )
    )
      and exists ( "Initial Population" IP
          where "Normalize Interval"(dr.effective) overlaps IP.period
      )
    return {
      id: dr.id,
      meta: dr.meta,
      extension: dr.extension,
      basedOn: dr.basedOn,
      status: dr.status,
      category: dr.category,
      code: dr.code,
      subject: dr.subject,
      encounter: dr.encounter,
      effective: dr.effective,
      issued: dr.issued,
      specimen: dr.specimen,
      result: dr.result,
      conclusion: dr.conclusion,
      conclusionCode: dr.conclusionCode
    }

define "SDE DiagnosticReport Others":
  [DiagnosticReportNote] dr
    where not ( exists ( dr.category Category
          where Category ~ "Radiology"
      )
        or exists ( dr.category Category
            where Category ~ "Pathology"
        )
        or exists ( dr.category Category
            where Category ~ "Cardiology"
        )
    )
      and exists ( "Initial Population" IP
          where "Normalize Interval"(dr.effective) overlaps IP.period
      )
    return {
      id: dr.id,
      meta: dr.meta,
      extension: dr.extension,
      basedOn: dr.basedOn,
      status: dr.status,
      category: dr.category,
      code: dr.code,
      subject: dr.subject,
      encounter: dr.encounter,
      effective: dr.effective,
      issued: dr.issued,
      specimen: dr.specimen,
      result: dr.result,
      conclusion: dr.conclusion,
      conclusionCode: dr.conclusionCode
    }

// Encounter SDEs


define "SDE Encounter":
  "Encounters" Ens
    where not "CheckIP"(Ens)
      and exists ( "Initial Population" IP
          where Ens.period overlaps IP.period
      )
    return {
      id: Ens.id,
      meta: Ens.meta,
      identifier: Ens.identifier,
      status: Ens.status,
      statusHistory: Ens.statusHistory,
      class: Ens.class,
      classHistory: Ens.classHistory,
      type: Ens.type,
      serviceType: Ens.serviceType,
      priority: Ens.priority,
      subject: Ens.subject,
      period: Ens.period,
      length: Ens.length,
      reasonCode: Ens.reasonCode,
      reasonReference: Ens.reasonReference,
      diagnosis: Ens.diagnosis,
      account: Ens.account,
      hospitalization: Ens.hospitalization,
      location: Ens.location,
      partOf: Ens.partOf
    }

define "SDE IP Encounters":
  "Initial Population" IP
    return {
      id: IP.id,
      meta: IP.meta,
      identifier: IP.identifier,
      status: IP.status,
      statusHistory: IP.statusHistory,
      class: IP.class,
      classHistory: IP.classHistory,
      type: IP.type,
      serviceType: IP.serviceType,
      priority: IP.priority,
      subject: IP.subject,
      period: IP.period,
      length: IP.length,
      reasonCode: IP.reasonCode,
      reasonReference: IP.reasonReference,
      diagnosis: IP.diagnosis,
      account: IP.account,
      hospitalization: IP.hospitalization,
      location: IP.location,
      partOf: IP.partOf
    }

// Location SDE


define "SDE Location":
  "Get Locations from IP Encounters in Measurement Period" Locations
    where exists ( "Initial Population" )
      and Locations is not null
    return {
      id: Locations.id,
      meta: Locations.meta,
      extension: Locations.extension,
      status: Locations.status,
      operationalStatus: Locations.operationalStatus,
      name: Locations.name,
      alias: Locations.alias,
      description: Locations.description,
      mode: Locations.mode,
      type: Locations.type,
      telecom: Locations.telecom,
      address: Locations.address,
      physicalType: Locations.physicalType,
      position: Locations.position,
      managingOrganization: Locations.managingOrganization,
      partOf: Locations.partOf,
      hoursOfOperation: Locations.hoursOfOperation,
      availabilityExceptions: Locations.availabilityExceptions,
      endpoint: Locations.endpoint
    }

// Medication SDEs


define "SDE Medication Administration":
  "SDE Medication Administration Base"
    union "SDE Medication Administration Not Done"

define "SDE Medication Administration Base":
  [MedicationAdministration] MedAdministrations
    where exists ( "Initial Population" IP
        where "Normalize Interval"(MedAdministrations.effective) overlaps IP.period
    )
    return {
      id: MedAdministrations.id,
      meta: MedAdministrations.meta,
      instantiates: MedAdministrations.instantiates,
      partOf: MedAdministrations.partOf,
      status: MedAdministrations.status,
      statusReason: MedAdministrations.statusReason,
      category: MedAdministrations.category,
      medication: MedAdministrations.medication,
      subject: MedAdministrations.subject,
      context: MedAdministrations.context,
      supportingInformation: MedAdministrations.supportingInformation,
      effective: MedAdministrations.effective,
      performer: MedAdministrations.performer,
      reasonCode: MedAdministrations.reasonCode,
      reasonReference: MedAdministrations.reasonReference,
      request: MedAdministrations.request,
      device: MedAdministrations.device,
      note: MedAdministrations.note,
      dosage: MedAdministrations.dosage
    }

define "SDE Medication Administration Not Done":
  [MedicationAdministrationNotDone] MedAdministrations
    where exists ( "Initial Population" IP
        where "Normalize Interval"(MedAdministrations.effective) overlaps IP.period
    )
    return {
      id: MedAdministrations.id,
      meta: MedAdministrations.meta,
      instantiates: MedAdministrations.instantiates,
      partOf: MedAdministrations.partOf,
      status: MedAdministrations.status,
      statusReason: MedAdministrations.statusReason,
      category: MedAdministrations.category,
      medication: MedAdministrations.medication,
      subject: MedAdministrations.subject,
      context: MedAdministrations.context,
      supportingInformation: MedAdministrations.supportingInformation,
      effective: MedAdministrations.effective,
      performer: MedAdministrations.performer,
      reasonCode: MedAdministrations.reasonCode,
      reasonReference: MedAdministrations.reasonReference,
      request: MedAdministrations.request,
      device: MedAdministrations.device,
      note: MedAdministrations.note,
      dosage: MedAdministrations.dosage
    }

// SDE Medication Request - regular requests (doNotPerform is false or absent)


define "SDE Medication Request Base":
  [MedicationRequest] MedRequests
    where exists ( "Initial Population" IP
        where MedRequests.authoredOn during IP.period
    )
    return {
      id: MedRequests.id,
      meta: MedRequests.meta,
      status: MedRequests.status,
      statusReason: MedRequests.statusReason,
      intent: MedRequests.intent,
      category: MedRequests.category,
      priority: MedRequests.priority,
      //doNotPerform: MedRequests.doNotPerform,
      
      reported: MedRequests.reported,
      medication: MedRequests.medication,
      subject: MedRequests.subject,
      encounter: MedRequests.encounter,
      authoredOn: MedRequests.authoredOn,
      requester: MedRequests.requester,
      recorder: MedRequests.recorder,
      reasonCode: MedRequests.reasonCode,
      reasonReference: MedRequests.reasonReference,
      instantiatesCanonical: MedRequests.instantiatesCanonical,
      instantiatesUri: MedRequests.instantiatesUri,
      courseOfTherapyType: MedRequests.courseOfTherapyType,
      dosageInstruction: MedRequests.dosageInstruction
    }

// SDE Medication Not Requested - negation requests (doNotPerform is true)


define "SDE Medication Not Requested":
  [MedicationNotRequested] MedNotRequests
    where exists ( "Initial Population" IP
        where MedNotRequests.authoredOn during IP.period
    )
    return {
      id: MedNotRequests.id,
      meta: MedNotRequests.meta,
      status: MedNotRequests.status,
      statusReason: MedNotRequests.statusReason,
      intent: MedNotRequests.intent,
      category: MedNotRequests.category,
      priority: MedNotRequests.priority,
      doNotPerform: MedNotRequests.doNotPerform,
      reported: MedNotRequests.reported,
      medication: MedNotRequests.medication,
      subject: MedNotRequests.subject,
      encounter: MedNotRequests.encounter,
      authoredOn: MedNotRequests.authoredOn,
      requester: MedNotRequests.requester,
      recorder: MedNotRequests.recorder,
      reasonCode: MedNotRequests.reasonCode,
      reasonReference: MedNotRequests.reasonReference,
      instantiatesCanonical: MedNotRequests.instantiatesCanonical,
      instantiatesUri: MedNotRequests.instantiatesUri,
      courseOfTherapyType: MedNotRequests.courseOfTherapyType,
      dosageInstruction: MedNotRequests.dosageInstruction
    }

// Combined SDE for all Medication Requests (both regular and negation)


define "SDE Medication Request":
  "SDE Medication Request Base"
    union "SDE Medication Not Requested"

define function "GetMedication"(reference Reference):
  singleton from ( [Medication] Medication
      where reference.references ( Medication )
  )

define "SDE Medication":
  ( [MedicationRequest]
    union [MedicationAdministration] ) MedReqOrAdmin
    let medication: GetMedication(MedReqOrAdmin.medication as Reference)
    where medication is not null
      and exists ( "Initial Population" IP
          where Coalesce("Normalize Interval"(MedReqOrAdmin.effective), MedReqOrAdmin.authoredOn.toInterval()) overlaps IP.period
      )
    return {
      id: medication.id,
      meta: medication.meta,
      code: medication.code,
      status: medication.status,
      manufacturer: medication.manufacturer,
      form: medication.form,
      amount: medication.amount,
      ingredient: medication.ingredient,
      batch: medication.batch
    }


// Observation SDEs


define "SDE Observation Lab Category":
  [LaboratoryResultObservation] Obs
    where exists ( "Initial Population" IP
        where "Normalize Interval"(Obs.effective) overlaps IP.period
    )
    return {
      id: Obs.id,
      meta: Obs.meta,
      extension: Obs.extension,
      partOf: Obs.partOf,
      status: Obs.status,
      category: Obs.category,
      code: Obs.code,
      subject: Obs.subject,
      encounter: Obs.encounter,
      effective: Obs.effective,
      issued: Obs.issued,
      value: Obs.value,
      dataAbsentReason: Obs.dataAbsentReason,
      interpretation: Obs.interpretation,
      bodySite: Obs.bodySite,
      method: Obs.method,
      specimen: Obs.specimen,
      referenceRange: Obs.referenceRange,
      hasMember: Obs.hasMember,
      derivedFrom: Obs.derivedFrom,
      component: Obs.component
    }

define "SDE Observation Simple":
  [SimpleObservation] Obs
    where ( exists ( Obs.category Category
          where Category ~ "social-history"
      )
        or exists ( Obs.category Category
            where Category ~ "imaging"
        )
        or exists ( Obs.category Category
            where Category ~ "procedure"
        )
    )
      and exists ( "Initial Population" IP
          where "Normalize Interval"(Obs.effective) overlaps IP.period
      )
    return {
      id: Obs.id,
      meta: Obs.meta,
      extension: Obs.extension,
      partOf: Obs.partOf,
      status: Obs.status,
      category: Obs.category,
      code: Obs.code,
      subject: Obs.subject,
      encounter: Obs.encounter,
      effective: Obs.effective,
      issued: Obs.issued,
      value: Obs.value,
      dataAbsentReason: Obs.dataAbsentReason,
      interpretation: Obs.interpretation,
      bodySite: Obs.bodySite,
      method: Obs.method,
      specimen: Obs.specimen,
      referenceRange: Obs.referenceRange,
      hasMember: Obs.hasMember,
      derivedFrom: Obs.derivedFrom,
      component: Obs.component
    }
    
// Survey is fixed category code in ObservationScreeningAssessment profile in QI-Core    


define "SDE Observation Survey":
  [ObservationScreeningAssessment] Obs
    where exists ( "Initial Population" IP
        where "Normalize Interval"(Obs.effective) overlaps IP.period
    )
    return {
      id: Obs.id,
      meta: Obs.meta,
      extension: Obs.extension,
      partOf: Obs.partOf,
      status: Obs.status,
      category: Obs.category,
      code: Obs.code,
      subject: Obs.subject,
      encounter: Obs.encounter,
      effective: Obs.effective,
      issued: Obs.issued,
      value: Obs.value,
      dataAbsentReason: Obs.dataAbsentReason,
      interpretation: Obs.interpretation,
      bodySite: Obs.bodySite,
      method: Obs.method,
      specimen: Obs.specimen,
      referenceRange: Obs.referenceRange,
      hasMember: Obs.hasMember,
      derivedFrom: Obs.derivedFrom,
      component: Obs.component
    }

define "SDE Observation Vital Signs Category":
  [USCoreVitalSignsProfile] Obs
    where exists ( "Initial Population" IP
        where "Normalize Interval"(Obs.effective) overlaps IP.period
    )
    return {
      id: Obs.id,
      meta: Obs.meta,
      extension: Obs.extension,
      partOf: Obs.partOf,
      status: Obs.status,
      category: Obs.category,
      code: Obs.code,
      subject: Obs.subject,
      encounter: Obs.encounter,
      effective: Obs.effective,
      issued: Obs.issued,
      value: Obs.value,
      dataAbsentReason: Obs.dataAbsentReason,
      interpretation: Obs.interpretation,
      bodySite: Obs.bodySite,
      method: Obs.method,
      specimen: Obs.specimen,
      referenceRange: Obs.referenceRange,
      hasMember: Obs.hasMember,
      derivedFrom: Obs.derivedFrom,
      component: Obs.component
    }


// Procedure SDE


define "SDE Procedure":
  [Procedure] Procedures
    where exists ( "Initial Population" IP
        where "Normalize Interval"(Procedures.performed) overlaps IP.period
    )
    return {
      id: Procedures.id,
      meta: Procedures.meta,
      extension: Procedures.extension,
      basedOn: Procedures.basedOn,
      partOf: Procedures.partOf,
      status: Procedures.status,
      category: Procedures.category,
      code: Procedures.code,
      subject: Procedures.subject,
      encounter: Procedures.encounter,
      performed: Procedures.performed,
      location: Procedures.location,
      reasonCode: Procedures.reasonCode,
      reasonReference: Procedures.reasonReference,
      bodySite: Procedures.bodySite
    }

// ServiceRequest SDE - regular requests (doNotPerform is false or absent)


define "SDE Service Request Base":
  [ServiceRequest] ServiceRequests
    where exists ( "Initial Population" IP
        where ServiceRequests.authoredOn during IP.period
    )
    return {
      id: ServiceRequests.id,
      meta: ServiceRequests.meta,
      instantiatesCanonical: ServiceRequests.instantiatesCanonical,
      instantiatesUri: ServiceRequests.instantiatesUri,
      basedOn: ServiceRequests.basedOn,
      replaces: ServiceRequests.replaces,
      requisition: ServiceRequests.requisition,
      status: ServiceRequests.status,
      intent: ServiceRequests.intent,
      category: ServiceRequests.category,
      priority: ServiceRequests.priority,
      //doNotPerform: ServiceRequests.doNotPerform,
      
      code: ServiceRequests.code,
      orderDetail: ServiceRequests.orderDetail,
      quantity: ServiceRequests.quantity,
      subject: ServiceRequests.subject,
      encounter: ServiceRequests.encounter,
      occurrence: ServiceRequests.occurrence,
      asNeeded: ServiceRequests.asNeeded,
      authoredOn: ServiceRequests.authoredOn,
      requester: ServiceRequests.requester,
      performerType: ServiceRequests.performerType,
      performer: ServiceRequests.performer,
      locationCode: ServiceRequests.locationCode,
      reasonCode: ServiceRequests.reasonCode,
      reasonReference: ServiceRequests.reasonReference,
      insurance: ServiceRequests.insurance,
      bodySite: ServiceRequests.bodySite,
      note: ServiceRequests.note,
      patientInstruction: ServiceRequests.patientInstruction
    }

// ServiceNotRequested SDE - negation requests (doNotPerform is true)


define "SDE Service Not Requested":
  [ServiceNotRequested] ServiceNotReqs
    where exists ( "Initial Population" IP
        where ServiceNotReqs.authoredOn during IP.period
    )
    return {
      id: ServiceNotReqs.id,
      meta: ServiceNotReqs.meta,
      instantiatesCanonical: ServiceNotReqs.instantiatesCanonical,
      instantiatesUri: ServiceNotReqs.instantiatesUri,
      basedOn: ServiceNotReqs.basedOn,
      replaces: ServiceNotReqs.replaces,
      requisition: ServiceNotReqs.requisition,
      status: ServiceNotReqs.status,
      intent: ServiceNotReqs.intent,
      category: ServiceNotReqs.category,
      priority: ServiceNotReqs.priority,
      doNotPerform: ServiceNotReqs.doNotPerform,
      code: ServiceNotReqs.code,
      orderDetail: ServiceNotReqs.orderDetail,
      quantity: ServiceNotReqs.quantity,
      subject: ServiceNotReqs.subject,
      encounter: ServiceNotReqs.encounter,
      occurrence: ServiceNotReqs.occurrence,
      asNeeded: ServiceNotReqs.asNeeded,
      authoredOn: ServiceNotReqs.authoredOn,
      requester: ServiceNotReqs.requester,
      performerType: ServiceNotReqs.performerType,
      performer: ServiceNotReqs.performer,
      locationCode: ServiceNotReqs.locationCode,
      reasonCode: ServiceNotReqs.reasonCode,
      reasonReference: ServiceNotReqs.reasonReference,
      insurance: ServiceNotReqs.insurance,
      bodySite: ServiceNotReqs.bodySite,
      note: ServiceNotReqs.note,
      patientInstruction: ServiceNotReqs.patientInstruction
    }

// Combined SDE for all Service Requests (both regular and negation)


define "SDE Service Request":
  "SDE Service Request Base"
    union "SDE Service Not Requested"

// Minimal patient SDE


define "SDE Minimal Patient":
  [Patient] MinPt
    where exists ( "Initial Population" )
    return {
      id: MinPt.id,
      meta: MinPt.meta,
      extension: MinPt.extension,
      identifier: MinPt.identifier,
      active: MinPt.active,
      name: MinPt.name,
      telecom: MinPt.telecom,
      gender: MinPt.gender,
      birthDate: MinPt.birthDate,
      deceased: MinPt.deceased,
      address: MinPt.address,
      maritalStatus: MinPt.maritalStatus,
      multipleBirth: MinPt.multipleBirth,
      photo: MinPt.photo,
      contact: MinPt.contact,
      communication: MinPt.communication,
      generalPractitioner: MinPt.generalPractitioner,
      managingOrganization: MinPt.managingOrganization,
      link: MinPt.link
    }

define "SDE Specimens":
  [USCoreSpecimenProfile] sp
    where exists ( "Initial Population" IP
        where "Normalize Interval"(sp.collection.collected) overlaps IP.period
    )
    return {
      id: sp.id,
      type: sp.type
    }

// ----------------------------------------------------------------------
// Helper functions
// ----------------------------------------------------------------------




define function "CheckIP"(encounter Encounter):
  exists ( "Initial Population" IP
      where encounter.id = IP.id
  )

// Former NHSNHelpers functions, adapted for QI Core


define function "Normalize Interval"(choice Choice<DateTime, Interval<DateTime>>):
  case
    when choice is DateTime then Interval[choice as DateTime, choice as DateTime]
    when choice is Interval<DateTime>then choice as Interval<DateTime>
    else null as Interval<DateTime>end

define function "GetLocation"(reference QICore.Reference):
  singleton from ( [Location] Locations
      where Locations.id = GetId(reference.reference)
  )

define function "GetId"(uri String):
  Last(Split(uri, '/'))

define function "GetId"(uri FHIR.string):
  Last(Split(FHIRHelpers.ToString(uri), '/'))