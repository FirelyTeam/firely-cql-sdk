library MedicationRequestExample version '0.1.001'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.001' called FHIRHelpers

define function "MedicationRequestResource"(medicationRequest MedicationRequest):
    medicationRequest m
    return MedicationRequest {
        id: FHIR.id {value: 'LCR-' + m.id},
        meta: m.meta,
        extension: m.extension,
        identifier: m.identifier,
        status: m.status,
        statusReason: m.statusReason,
        intent: m.intent,
        category: m.category,
        priority: m.priority,
        doNotPerform: m.doNotPerform,
        reported: m.reported,
        medication: m.medication,
        subject: m.subject,
        encounter: m.encounter,
        supportingInformation: m.supportingInformation,
        authoredOn: m.authoredOn,
        requester: m.requester,
        performer: m.performer,
        performerType: m.performerType,
        recorder: m.recorder,
        reasonCode: m.reasonCode,
        reasonReference: m.reasonReference,
        instantiatesCanonical: m.instantiatesCanonical,
        instantiatesUri: m.instantiatesUri,
        basedOn: m.basedOn,
        groupIdentifier: m.groupIdentifier,
        courseOfTherapyType: m.courseOfTherapyType,
        insurance: m.insurance,
        note: m.note,
        dosageInstruction: m.dosageInstruction,
        dispenseRequest: m.dispenseRequest,
        substitution: m.substitution,
        priorPrescription: m.priorPrescription,
        detectedIssue: m.detectedIssue,
        eventHistory: m.eventHistory
    }
