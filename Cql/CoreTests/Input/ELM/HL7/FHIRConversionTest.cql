library FHIRConversionTest version '2023.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

define function "AccountResource"(arg Account):
  arg a
  return Account {
    identifier : a.identifier,
    status : a.status,
    type : a.type,
    name : a.name,
    subject : a.subject,
    servicePeriod : a.servicePeriod,
    coverage : a.coverage,
    owner : a.owner,
    description : a.description,
    guarantor : a.guarantor,
    partOf : a.partOf
  }

define function "ActivityDefinitionResource"(arg ActivityDefinition):
  arg a
  return ActivityDefinition {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    name : a.name,
    title : a.title,
    subtitle : a.subtitle,
    status : a.status,
    experimental : a.experimental,
    subject : a.subject,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    purpose : a.purpose,
    usage : a.usage,
    copyright : a.copyright,
    approvalDate : a.approvalDate,
    lastReviewDate : a.lastReviewDate,
    effectivePeriod : a.effectivePeriod,
    topic : a.topic,
    author : a.author,
    editor : a.editor,
    reviewer : a.reviewer,
    endorser : a.endorser,
    relatedArtifact : a.relatedArtifact,
    library : a.library,
    kind : a.kind,
    profile : a.profile,
    code : a.code,
    intent : a.intent,
    priority : a.priority,
    doNotPerform : a.doNotPerform,
    timing : a.timing,
    location : a.location,
    participant : a.participant,
    product : a.product,
    quantity : a.quantity,
    dosage : a.dosage,
    bodySite : a.bodySite,
    specimenRequirement : a.specimenRequirement,
    observationRequirement : a.observationRequirement,
    observationResultRequirement : a.observationResultRequirement,
    transform : a.transform,
    dynamicValue : a.dynamicValue
  }

define function "AdverseEventResource"(arg AdverseEvent):
  arg a
  return AdverseEvent {
    identifier : a.identifier,
    actuality : a.actuality,
    category : a.category,
    event : a.event,
    subject : a.subject,
    encounter : a.encounter,
    date : a.date,
    detected : a.detected,
    recordedDate : a.recordedDate,
    resultingCondition : a.resultingCondition,
    location : a.location,
    seriousness : a.seriousness,
    severity : a.severity,
    outcome : a.outcome,
    recorder : a.recorder,
    contributor : a.contributor,
    suspectEntity : a.suspectEntity,
    subjectMedicalHistory : a.subjectMedicalHistory,
    referenceDocument : a.referenceDocument,
    study : a.study
  }

define function "AllergyIntoleranceResource"(arg AllergyIntolerance):
  arg a
  return AllergyIntolerance {
    identifier : a.identifier,
    clinicalStatus : a.clinicalStatus,
    verificationStatus : a.verificationStatus,
    type : a.type,
    category : a.category,
    criticality : a.criticality,
    code : a.code,
    patient : a.patient,
    encounter : a.encounter,
    onset : a.onset,
    recordedDate : a.recordedDate,
    recorder : a.recorder,
    asserter : a.asserter,
    lastOccurrence : a.lastOccurrence,
    note : a.note,
    reaction : a.reaction
  }

define function "AppointmentResource"(arg Appointment):
  arg a
  return Appointment {
    identifier : a.identifier,
    status : a.status,
    cancelationReason : a.cancelationReason,
    serviceCategory : a.serviceCategory,
    serviceType : a.serviceType,
    specialty : a.specialty,
    appointmentType : a.appointmentType,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    priority : a.priority,
    description : a.description,
    supportingInformation : a.supportingInformation,
    start : a.start,
    end : a.end,
    minutesDuration : a.minutesDuration,
    slot : a.slot,
    created : a.created,
    comment : a.comment,
    patientInstruction : a.patientInstruction,
    basedOn : a.basedOn,
    participant : a.participant,
    requestedPeriod : a.requestedPeriod
  }

define function "AppointmentResponseResource"(arg AppointmentResponse):
  arg a
  return AppointmentResponse {
    identifier : a.identifier,
    appointment : a.appointment,
    start : a.start,
    end : a.end,
    participantType : a.participantType,
    actor : a.actor,
    participantStatus : a.participantStatus,
    comment : a.comment
  }

define function "AuditEventResource"(arg AuditEvent):
  arg a
  return AuditEvent {
    type : a.type,
    subtype : a.subtype,
    action : a.action,
    period : a.period,
    recorded : a.recorded,
    outcome : a.outcome,
    outcomeDesc : a.outcomeDesc,
    purposeOfEvent : a.purposeOfEvent,
    agent : a.agent,
    source : a.source,
    entity : a.entity
  }

define function "BasicResource"(arg Basic):
  arg a
  return Basic {
    identifier : a.identifier,
    code : a.code,
    subject : a.subject,
    created : a.created,
    author : a.author
  }

define function "BiologicallyDerivedProductResource"(arg BiologicallyDerivedProduct):
  arg a
  return BiologicallyDerivedProduct {
    identifier : a.identifier,
    productCategory : a.productCategory,
    productCode : a.productCode,
    status : a.status,
    request : a.request,
    quantity : a.quantity,
    parent : a.parent,
    collection : a.collection,
    processing : a.processing,
    manipulation : a.manipulation,
    storage : a.storage
  }

define function "BodyStructureResource"(arg BodyStructure):
  arg a
  return BodyStructure {
    identifier : a.identifier,
    active : a.active,
    morphology : a.morphology,
    location : a.location,
    locationQualifier : a.locationQualifier,
    description : a.description,
    image : a.image,
    patient : a.patient
  }

// define function "CapabilityStatementResource"(arg CapabilityStatement):
//   arg a
//   return CapabilityStatement {
//     url : a.url,
//     version : a.version,
//     name : a.name,
//     title : a.title,
//     status : a.status,
//     experimental : a.experimental,
//     date : a.date,
//     publisher : a.publisher,
//     contact : a.contact,
//     description : a.description,
//     useContext : a.useContext,
//     jurisdiction : a.jurisdiction,
//     purpose : a.purpose,
//     copyright : a.copyright,
//     kind : a.kind,
//     instantiates : a.instantiates,
//     imports : a.imports,
//     software : a.software,
//     implementation : a.implementation,
//     fhirVersion : a.fhirVersion,
//     format : a.format,
//     patchFormat : a.patchFormat,
//     implementationGuide : a.implementationGuide,
//     rest : a.rest,
//     messaging : a.messaging,
//     document : a.document
//   }

define function "CarePlanResource"(arg CarePlan):
  arg a
  return CarePlan {
    identifier : a.identifier,
    instantiatesCanonical : a.instantiatesCanonical,
    instantiatesUri : a.instantiatesUri,
    basedOn : a.basedOn,
    replaces : a.replaces,
    partOf : a.partOf,
    status : a.status,
    intent : a.intent,
    category : a.category,
    title : a.title,
    description : a.description,
    subject : a.subject,
    encounter : a.encounter,
    period : a.period,
    created : a.created,
    author : a.author,
    contributor : a.contributor,
    careTeam : a.careTeam,
    addresses : a.addresses,
    supportingInfo : a.supportingInfo,
    goal : a.goal,
    activity : a.activity,
    note : a.note
  }

define function "CareTeamResource"(arg CareTeam):
  arg a
  return CareTeam {
    identifier : a.identifier,
    status : a.status,
    category : a.category,
    name : a.name,
    subject : a.subject,
    encounter : a.encounter,
    period : a.period,
    participant : a.participant,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    managingOrganization : a.managingOrganization,
    telecom : a.telecom,
    note : a.note
  }

define function "CatalogEntryResource"(arg CatalogEntry):
  arg a
  return CatalogEntry {
    identifier : a.identifier,
    type : a.type,
    orderable : a.orderable,
    referencedItem : a.referencedItem,
    additionalIdentifier : a.additionalIdentifier,
    classification : a.classification,
    status : a.status,
    validityPeriod : a.validityPeriod,
    validTo : a.validTo,
    lastUpdated : a.lastUpdated,
    additionalCharacteristic : a.additionalCharacteristic,
    additionalClassification : a.additionalClassification,
    relatedEntry : a.relatedEntry
  }

define function "ChargeItemResource"(arg ChargeItem):
  arg a
  return ChargeItem {
    identifier : a.identifier,
    definitionUri : a.definitionUri,
    definitionCanonical : a.definitionCanonical,
    status : a.status,
    partOf : a.partOf,
    code : a.code,
    subject : a.subject,
    context : a.context,
    occurrence : a.occurrence,
    performer : a.performer,
    performingOrganization : a.performingOrganization,
    requestingOrganization : a.requestingOrganization,
    costCenter : a.costCenter,
    quantity : a.quantity,
    bodysite : a.bodysite,
    factorOverride : a.factorOverride,
    priceOverride : a.priceOverride,
    overrideReason : a.overrideReason,
    enterer : a.enterer,
    enteredDate : a.enteredDate,
    reason : a.reason,
    service : a.service,
    product : a.product,
    account : a.account,
    note : a.note,
    supportingInformation : a.supportingInformation
  }

define function "ChargeItemDefinitionResource"(arg ChargeItemDefinition):
  arg a
  return ChargeItemDefinition {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    title : a.title,
    derivedFromUri : a.derivedFromUri,
    partOf : a.partOf,
    replaces : a.replaces,
    status : a.status,
    experimental : a.experimental,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    copyright : a.copyright,
    approvalDate : a.approvalDate,
    lastReviewDate : a.lastReviewDate,
    effectivePeriod : a.effectivePeriod,
    code : a.code,
    instance : a.instance,
    applicability : a.applicability,
    propertyGroup : a.propertyGroup
  }

define function "ClaimResource"(arg Claim):
  arg a
  return Claim {
    identifier : a.identifier,
    status : a.status,
    type : a.type,
    subType : a.subType,
    use : a.use,
    patient : a.patient,
    billablePeriod : a.billablePeriod,
    created : a.created,
    enterer : a.enterer,
    insurer : a.insurer,
    provider : a.provider,
    priority : a.priority,
    fundsReserve : a.fundsReserve,
    related : a.related,
    prescription : a.prescription,
    originalPrescription : a.originalPrescription,
    payee : a.payee,
    referral : a.referral,
    facility : a.facility,
    careTeam : a.careTeam,
    supportingInfo : a.supportingInfo,
    diagnosis : a.diagnosis,
    procedure : a.procedure,
    insurance : a.insurance,
    accident : a.accident,
    item : a.item,
    total : a.total
  }

define function "ClaimResponseResource"(arg ClaimResponse):
  arg a
  return ClaimResponse {
    identifier : a.identifier,
    status : a.status,
    type : a.type,
    subType : a.subType,
    use : a.use,
    patient : a.patient,
    created : a.created,
    insurer : a.insurer,
    requestor : a.requestor,
    request : a.request,
    outcome : a.outcome,
    disposition : a.disposition,
    preAuthRef : a.preAuthRef,
    preAuthPeriod : a.preAuthPeriod,
    payeeType : a.payeeType,
    item : a.item,
    addItem : a.addItem,
    adjudication : a.adjudication,
    total : a.total,
    payment : a.payment,
    fundsReserve : a.fundsReserve,
    formCode : a.formCode,
    form : a.form,
    processNote : a.processNote,
    communicationRequest : a.communicationRequest,
    insurance : a.insurance,
    error : a.error
  }

define function "ClinicalImpressionResource"(arg ClinicalImpression):
  arg a
  return ClinicalImpression {
    identifier : a.identifier,
    status : a.status,
    statusReason : a.statusReason,
    code : a.code,
    description : a.description,
    subject : a.subject,
    encounter : a.encounter,
    effective : a.effective,
    date : a.date,
    assessor : a.assessor,
    previous : a.previous,
    problem : a.problem,
    investigation : a.investigation,
    protocol : a.protocol,
    summary : a.summary,
    finding : a.finding,
    prognosisCodeableConcept : a.prognosisCodeableConcept,
    prognosisReference : a.prognosisReference,
    supportingInfo : a.supportingInfo,
    note : a.note
  }

define function "CodeSystemResource"(arg CodeSystem):
  arg a
  return CodeSystem {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    name : a.name,
    title : a.title,
    status : a.status,
    experimental : a.experimental,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    purpose : a.purpose,
    copyright : a.copyright,
    caseSensitive : a.caseSensitive,
    valueSet : a.valueSet,
    hierarchyMeaning : a.hierarchyMeaning,
    compositional : a.compositional,
    versionNeeded : a.versionNeeded,
    content : a.content,
    supplements : a.supplements,
    count : a.count,
    filter : a.filter,
    property : a.property,
    concept : a.concept
  }

define function "CommunicationResource"(arg Communication):
  arg a
  return Communication {
    identifier : a.identifier,
    instantiatesCanonical : a.instantiatesCanonical,
    instantiatesUri : a.instantiatesUri,
    basedOn : a.basedOn,
    partOf : a.partOf,
    inResponseTo : a.inResponseTo,
    status : a.status,
    statusReason : a.statusReason,
    category : a.category,
    priority : a.priority,
    medium : a.medium,
    subject : a.subject,
    topic : a.topic,
    about : a.about,
    encounter : a.encounter,
    sent : a.sent,
    received : a.received,
    recipient : a.recipient,
    sender : a.sender,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    payload : a.payload,
    note : a.note
  }

define function "CommunicationRequestResource"(arg CommunicationRequest):
  arg a
  return CommunicationRequest {
    identifier : a.identifier,
    basedOn : a.basedOn,
    replaces : a.replaces,
    groupIdentifier : a.groupIdentifier,
    status : a.status,
    statusReason : a.statusReason,
    category : a.category,
    priority : a.priority,
    doNotPerform : a.doNotPerform,
    medium : a.medium,
    subject : a.subject,
    about : a.about,
    encounter : a.encounter,
    payload : a.payload,
    occurrence : a.occurrence,
    authoredOn : a.authoredOn,
    requester : a.requester,
    recipient : a.recipient,
    sender : a.sender,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    note : a.note
  }

// define function "CompartmentDefinitionResource"(arg CompartmentDefinition):
//   arg a
//   return CompartmentDefinition {
//     url : a.url,
//     version : a.version,
//     name : a.name,
//     status : a.status,
//     experimental : a.experimental,
//     date : a.date,
//     publisher : a.publisher,
//     contact : a.contact,
//     description : a.description,
//     useContext : a.useContext,
//     purpose : a.purpose,
//     code : a.code,
//     search : a.search,
//     resource : a.resource
//   }

define function "CompositionResource"(arg Composition):
  arg a
  return Composition {
    identifier : a.identifier,
    status : a.status,
    type : a.type,
    category : a.category,
    subject : a.subject,
    encounter : a.encounter,
    date : a.date,
    author : a.author,
    title : a.title,
    confidentiality : a.confidentiality,
    attester : a.attester,
    custodian : a.custodian,
    relatesTo : a.relatesTo,
    event : a.event,
    section : a.section
  }

define function "ConceptMapResource"(arg ConceptMap):
  arg a
  return ConceptMap {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    name : a.name,
    title : a.title,
    status : a.status,
    experimental : a.experimental,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    purpose : a.purpose,
    copyright : a.copyright,
    source : a.source,
    target : a.target,
    group : a.group
  }

define function "ConditionResource"(arg Condition):
  arg a
  return Condition {
    identifier : a.identifier,
    clinicalStatus : a.clinicalStatus,
    verificationStatus : a.verificationStatus,
    category : a.category,
    severity : a.severity,
    code : a.code,
    bodySite : a.bodySite,
    subject : a.subject,
    encounter : a.encounter,
    onset : a.onset,
    abatement : a.abatement,
    recordedDate : a.recordedDate,
    recorder : a.recorder,
    asserter : a.asserter,
    stage : a.stage,
    evidence : a.evidence,
    note : a.note
  }

define function "ConsentResource"(arg Consent):
  arg a
  return Consent {
    identifier : a.identifier,
    status : a.status,
    scope : a.scope,
    category : a.category,
    patient : a.patient,
    dateTime : a.dateTime,
    performer : a.performer,
    organization : a.organization,
    source : a.source,
    policy : a.policy,
    policyRule : a.policyRule,
    verification : a.verification,
    provision : a.provision
  }

define function "ContractResource"(arg Contract):
  arg a
  return Contract {
    identifier : a.identifier,
    url : a.url,
    version : a.version,
    status : a.status,
    legalState : a.legalState,
    instantiatesCanonical : a.instantiatesCanonical,
    instantiatesUri : a.instantiatesUri,
    contentDerivative : a.contentDerivative,
    issued : a.issued,
    applies : a.applies,
    expirationType : a.expirationType,
    subject : a.subject,
    authority : a.authority,
    domain : a.domain,
    site : a.site,
    name : a.name,
    title : a.title,
    subtitle : a.subtitle,
    alias : a.alias,
    author : a.author,
    scope : a.scope,
    topic : a.topic,
    type : a.type,
    subType : a.subType,
    contentDefinition : a.contentDefinition,
    term : a.term,
    supportingInfo : a.supportingInfo,
    relevantHistory : a.relevantHistory,
    signer : a.signer,
    friendly : a.friendly,
    legal : a.legal,
    rule : a.rule,
    legallyBinding : a.legallyBinding
  }

define function "CoverageResource"(arg Coverage):
  arg a
  return Coverage {
    identifier : a.identifier,
    status : a.status,
    type : a.type,
    policyHolder : a.policyHolder,
    subscriber : a.subscriber,
    subscriberId : a.subscriberId,
    beneficiary : a.beneficiary,
    dependent : a.dependent,
    relationship : a.relationship,
    period : a.period,
    payor : a.payor,
    class : a.class,
    order : a.order,
    network : a.network,
    costToBeneficiary : a.costToBeneficiary,
    subrogation : a.subrogation,
    contract : a.contract
  }

define function "CoverageEligibilityRequestResource"(arg CoverageEligibilityRequest):
  arg a
  return CoverageEligibilityRequest {
    identifier : a.identifier,
    status : a.status,
    priority : a.priority,
    purpose : a.purpose,
    patient : a.patient,
    serviced : a.serviced,
    created : a.created,
    enterer : a.enterer,
    provider : a.provider,
    insurer : a.insurer,
    facility : a.facility,
    supportingInfo : a.supportingInfo,
    insurance : a.insurance,
    item : a.item
  }

define function "CoverageEligibilityResponseResource"(arg CoverageEligibilityResponse):
  arg a
  return CoverageEligibilityResponse {
    identifier : a.identifier,
    status : a.status,
    purpose : a.purpose,
    patient : a.patient,
    serviced : a.serviced,
    created : a.created,
    requestor : a.requestor,
    request : a.request,
    outcome : a.outcome,
    disposition : a.disposition,
    insurer : a.insurer,
    insurance : a.insurance,
    preAuthRef : a.preAuthRef,
    form : a.form,
    error : a.error
  }

define function "DetectedIssueResource"(arg DetectedIssue):
  arg a
  return DetectedIssue {
    identifier : a.identifier,
    status : a.status,
    code : a.code,
    severity : a.severity,
    patient : a.patient,
    identified : a.identified,
    author : a.author,
    implicated : a.implicated,
    evidence : a.evidence,
    detail : a.detail,
    reference : a.reference,
    mitigation : a.mitigation
  }

define function "DeviceResource"(arg Device):
  arg a
  return Device {
    identifier : a.identifier,
    definition : a.definition,
    udiCarrier : a.udiCarrier,
    status : a.status,
    statusReason : a.statusReason,
    distinctIdentifier : a.distinctIdentifier,
    manufacturer : a.manufacturer,
    manufactureDate : a.manufactureDate,
    expirationDate : a.expirationDate,
    lotNumber : a.lotNumber,
    serialNumber : a.serialNumber,
    deviceName : a.deviceName,
    modelNumber : a.modelNumber,
    partNumber : a.partNumber,
    type : a.type,
    specialization : a.specialization,
    version : a.version,
    property : a.property,
    patient : a.patient,
    owner : a.owner,
    contact : a.contact,
    location : a.location,
    url : a.url,
    note : a.note,
    safety : a.safety,
    parent : a.parent
  }

define function "DeviceDefinitionResource"(arg DeviceDefinition):
  arg a
  return DeviceDefinition {
    identifier : a.identifier,
    udiDeviceIdentifier : a.udiDeviceIdentifier,
    manufacturer : a.manufacturer,
    deviceName : a.deviceName,
    modelNumber : a.modelNumber,
    type : a.type,
    specialization : a.specialization,
    version : a.version,
    safety : a.safety,
    shelfLifeStorage : a.shelfLifeStorage,
    physicalCharacteristics : a.physicalCharacteristics,
    languageCode : a.languageCode,
    capability : a.capability,
    property : a.property,
    owner : a.owner,
    contact : a.contact,
    url : a.url,
    onlineInformation : a.onlineInformation,
    note : a.note,
    quantity : a.quantity,
    parentDevice : a.parentDevice,
    material : a.material
  }

define function "DeviceMetricResource"(arg DeviceMetric):
  arg a
  return DeviceMetric {
    identifier : a.identifier,
    type : a.type,
    unit : a.unit,
    source : a.source,
    parent : a.parent,
    operationalStatus : a.operationalStatus,
    color : a.color,
    category : a.category,
    measurementPeriod : a.measurementPeriod,
    calibration : a.calibration
  }

define function "DeviceRequestResource"(arg DeviceRequest):
  arg a
  return DeviceRequest {
    identifier : a.identifier,
    instantiatesCanonical : a.instantiatesCanonical,
    instantiatesUri : a.instantiatesUri,
    basedOn : a.basedOn,
    priorRequest : a.priorRequest,
    groupIdentifier : a.groupIdentifier,
    status : a.status,
    intent : a.intent,
    priority : a.priority,
    code : a.code,
    parameter : a.parameter,
    subject : a.subject,
    encounter : a.encounter,
    occurrence : a.occurrence,
    authoredOn : a.authoredOn,
    requester : a.requester,
    performerType : a.performerType,
    performer : a.performer,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    insurance : a.insurance,
    supportingInfo : a.supportingInfo,
    note : a.note,
    relevantHistory : a.relevantHistory
  }

define function "DeviceUseStatementResource"(arg DeviceUseStatement):
  arg a
  return DeviceUseStatement {
    identifier : a.identifier,
    basedOn : a.basedOn,
    status : a.status,
    subject : a.subject,
    derivedFrom : a.derivedFrom,
    timing : a.timing,
    recordedOn : a.recordedOn,
    source : a.source,
    device : a.device,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    bodySite : a.bodySite,
    note : a.note
  }

define function "DiagnosticReportResource"(arg DiagnosticReport):
  arg a
  return DiagnosticReport {
    identifier : a.identifier,
    basedOn : a.basedOn,
    status : a.status,
    category : a.category,
    code : a.code,
    subject : a.subject,
    encounter : a.encounter,
    effective : a.effective,
    issued : a.issued,
    performer : a.performer,
    resultsInterpreter : a.resultsInterpreter,
    specimen : a.specimen,
    result : a.result,
    imagingStudy : a.imagingStudy,
    media : a.media,
    conclusion : a.conclusion,
    conclusionCode : a.conclusionCode,
    presentedForm : a.presentedForm
  }

define function "DocumentManifestResource"(arg DocumentManifest):
  arg a
  return DocumentManifest {
    masterIdentifier : a.masterIdentifier,
    identifier : a.identifier,
    status : a.status,
    type : a.type,
    subject : a.subject,
    created : a.created,
    author : a.author,
    recipient : a.recipient,
    source : a.source,
    description : a.description,
    content : a.content,
    related : a.related
  }

define function "DocumentReferenceResource"(arg DocumentReference):
  arg a
  return DocumentReference {
    masterIdentifier : a.masterIdentifier,
    identifier : a.identifier,
    status : a.status,
    docStatus : a.docStatus,
    type : a.type,
    category : a.category,
    subject : a.subject,
    date : a.date,
    author : a.author,
    authenticator : a.authenticator,
    custodian : a.custodian,
    relatesTo : a.relatesTo,
    description : a.description,
    securityLabel : a.securityLabel,
    content : a.content,
    context : a.context
  }

define function "EffectEvidenceSynthesisResource"(arg EffectEvidenceSynthesis):
  arg a
  return EffectEvidenceSynthesis {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    name : a.name,
    title : a.title,
    status : a.status,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    note : a.note,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    copyright : a.copyright,
    approvalDate : a.approvalDate,
    lastReviewDate : a.lastReviewDate,
    effectivePeriod : a.effectivePeriod,
    topic : a.topic,
    author : a.author,
    editor : a.editor,
    reviewer : a.reviewer,
    endorser : a.endorser,
    relatedArtifact : a.relatedArtifact,
    synthesisType : a.synthesisType,
    studyType : a.studyType,
    population : a.population,
    exposure : a.exposure,
    exposureAlternative : a.exposureAlternative,
    outcome : a.outcome,
    sampleSize : a.sampleSize,
    resultsByExposure : a.resultsByExposure,
    effectEstimate : a.effectEstimate,
    certainty : a.certainty
  }

define function "EncounterResource"(arg Encounter):
  arg a
  return Encounter {
    identifier : a.identifier,
    status : a.status,
    statusHistory : a.statusHistory,
    class : a.class,
    classHistory : a.classHistory,
    type : a.type,
    serviceType : a.serviceType,
    priority : a.priority,
    subject : a.subject,
    episodeOfCare : a.episodeOfCare,
    basedOn : a.basedOn,
    participant : a.participant,
    appointment : a.appointment,
    period : a.period,
    length : a.length,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    diagnosis : a.diagnosis,
    account : a.account,
    hospitalization : a.hospitalization,
    location : a.location,
    serviceProvider : a.serviceProvider,
    partOf : a.partOf
  }

define function "EndpointResource"(arg Endpoint):
  arg a
  return Endpoint {
    identifier : a.identifier,
    status : a.status,
    connectionType : a.connectionType,
    name : a.name,
    managingOrganization : a.managingOrganization,
    contact : a.contact,
    period : a.period,
    payloadType : a.payloadType,
    payloadMimeType : a.payloadMimeType,
    address : a.address,
    header : a.header
  }

define function "EnrollmentRequestResource"(arg EnrollmentRequest):
  arg a
  return EnrollmentRequest {
    identifier : a.identifier,
    status : a.status,
    created : a.created,
    insurer : a.insurer,
    provider : a.provider,
    candidate : a.candidate,
    coverage : a.coverage
  }

define function "EnrollmentResponseResource"(arg EnrollmentResponse):
  arg a
  return EnrollmentResponse {
    identifier : a.identifier,
    status : a.status,
    request : a.request,
    outcome : a.outcome,
    disposition : a.disposition,
    created : a.created,
    organization : a.organization,
    requestProvider : a.requestProvider
  }

define function "EpisodeOfCareResource"(arg EpisodeOfCare):
  arg a
  return EpisodeOfCare {
    identifier : a.identifier,
    status : a.status,
    statusHistory : a.statusHistory,
    type : a.type,
    diagnosis : a.diagnosis,
    patient : a.patient,
    managingOrganization : a.managingOrganization,
    period : a.period,
    referralRequest : a.referralRequest,
    careManager : a.careManager,
    team : a.team,
    account : a.account
  }

define function "EventDefinitionResource"(arg EventDefinition):
  arg a
  return EventDefinition {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    name : a.name,
    title : a.title,
    subtitle : a.subtitle,
    status : a.status,
    experimental : a.experimental,
    subject : a.subject,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    purpose : a.purpose,
    usage : a.usage,
    copyright : a.copyright,
    approvalDate : a.approvalDate,
    lastReviewDate : a.lastReviewDate,
    effectivePeriod : a.effectivePeriod,
    topic : a.topic,
    author : a.author,
    editor : a.editor,
    reviewer : a.reviewer,
    endorser : a.endorser,
    relatedArtifact : a.relatedArtifact,
    trigger : a.trigger
  }

define function "EvidenceResource"(arg Evidence):
  arg a
  return Evidence {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    name : a.name,
    title : a.title,
    shortTitle : a.shortTitle,
    subtitle : a.subtitle,
    status : a.status,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    note : a.note,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    copyright : a.copyright,
    approvalDate : a.approvalDate,
    lastReviewDate : a.lastReviewDate,
    effectivePeriod : a.effectivePeriod,
    topic : a.topic,
    author : a.author,
    editor : a.editor,
    reviewer : a.reviewer,
    endorser : a.endorser,
    relatedArtifact : a.relatedArtifact,
    exposureBackground : a.exposureBackground,
    exposureVariant : a.exposureVariant,
    outcome : a.outcome
  }

define function "EvidenceVariableResource"(arg EvidenceVariable):
  arg a
  return EvidenceVariable {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    name : a.name,
    title : a.title,
    shortTitle : a.shortTitle,
    subtitle : a.subtitle,
    status : a.status,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    note : a.note,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    copyright : a.copyright,
    approvalDate : a.approvalDate,
    lastReviewDate : a.lastReviewDate,
    effectivePeriod : a.effectivePeriod,
    topic : a.topic,
    author : a.author,
    editor : a.editor,
    reviewer : a.reviewer,
    endorser : a.endorser,
    relatedArtifact : a.relatedArtifact,
    type : a.type,
    characteristic : a.characteristic
  }

// define function "ExampleScenarioResource"(arg ExampleScenario):
//   arg a
//   return ExampleScenario {
//     url : a.url,
//     identifier : a.identifier,
//     version : a.version,
//     name : a.name,
//     status : a.status,
//     experimental : a.experimental,
//     date : a.date,
//     publisher : a.publisher,
//     contact : a.contact,
//     useContext : a.useContext,
//     jurisdiction : a.jurisdiction,
//     copyright : a.copyright,
//     purpose : a.purpose,
//     actor : a.actor,
//     instance : a.instance,
//     process : a.process,
//     workflow : a.workflow
//   }

define function "ExplanationOfBenefitResource"(arg ExplanationOfBenefit):
  arg a
  return ExplanationOfBenefit {
    identifier : a.identifier,
    status : a.status,
    type : a.type,
    subType : a.subType,
    use : a.use,
    patient : a.patient,
    billablePeriod : a.billablePeriod,
    created : a.created,
    enterer : a.enterer,
    insurer : a.insurer,
    provider : a.provider,
    priority : a.priority,
    fundsReserveRequested : a.fundsReserveRequested,
    fundsReserve : a.fundsReserve,
    related : a.related,
    prescription : a.prescription,
    originalPrescription : a.originalPrescription,
    payee : a.payee,
    referral : a.referral,
    facility : a.facility,
    claim : a.claim,
    claimResponse : a.claimResponse,
    outcome : a.outcome,
    disposition : a.disposition,
    preAuthRef : a.preAuthRef,
    preAuthRefPeriod : a.preAuthRefPeriod,
    careTeam : a.careTeam,
    supportingInfo : a.supportingInfo,
    diagnosis : a.diagnosis,
    procedure : a.procedure,
    precedence : a.precedence,
    insurance : a.insurance,
    accident : a.accident,
    item : a.item,
    addItem : a.addItem,
    adjudication : a.adjudication,
    total : a.total,
    payment : a.payment,
    formCode : a.formCode,
    form : a.form,
    processNote : a.processNote,
    benefitPeriod : a.benefitPeriod,
    benefitBalance : a.benefitBalance
  }

define function "FamilyMemberHistoryResource"(arg FamilyMemberHistory):
  arg a
  return FamilyMemberHistory {
    identifier : a.identifier,
    instantiatesCanonical : a.instantiatesCanonical,
    instantiatesUri : a.instantiatesUri,
    status : a.status,
    dataAbsentReason : a.dataAbsentReason,
    patient : a.patient,
    date : a.date,
    name : a.name,
    relationship : a.relationship,
    sex : a.sex,
    born : a.born,
    age : a.age,
    estimatedAge : a.estimatedAge,
    deceased : a.deceased,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    note : a.note,
    condition : a.condition
  }

define function "FlagResource"(arg Flag):
  arg a
  return Flag {
    identifier : a.identifier,
    status : a.status,
    category : a.category,
    code : a.code,
    subject : a.subject,
    period : a.period,
    encounter : a.encounter,
    author : a.author
  }

define function "GoalResource"(arg Goal):
  arg a
  return Goal {
    identifier : a.identifier,
    lifecycleStatus : a.lifecycleStatus,
    achievementStatus : a.achievementStatus,
    category : a.category,
    priority : a.priority,
    description : a.description,
    subject : a.subject,
    start : a.start,
    target : a.target,
    statusDate : a.statusDate,
    statusReason : a.statusReason,
    expressedBy : a.expressedBy,
    addresses : a.addresses,
    note : a.note,
    outcomeCode : a.outcomeCode,
    outcomeReference : a.outcomeReference
  }

// define function "GraphDefinitionResource"(arg GraphDefinition):
//   arg a
//   return GraphDefinition {
//     url : a.url,
//     version : a.version,
//     name : a.name,
//     status : a.status,
//     experimental : a.experimental,
//     date : a.date,
//     publisher : a.publisher,
//     contact : a.contact,
//     description : a.description,
//     useContext : a.useContext,
//     jurisdiction : a.jurisdiction,
//     purpose : a.purpose,
//     start : a.start,
//     profile : a.profile,
//     link : a.link
//   }

define function "GroupResource"(arg Group):
  arg a
  return Group {
    identifier : a.identifier,
    active : a.active,
    type : a.type,
    actual : a.actual,
    code : a.code,
    name : a.name,
    quantity : a.quantity,
    managingEntity : a.managingEntity,
    characteristic : a.characteristic,
    member : a.member
  }

define function "GuidanceResponseResource"(arg GuidanceResponse):
  arg a
  return GuidanceResponse {
    requestIdentifier : a.requestIdentifier,
    identifier : a.identifier,
    module : a.module,
    status : a.status,
    subject : a.subject,
    encounter : a.encounter,
    occurrenceDateTime : a.occurrenceDateTime,
    performer : a.performer,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    note : a.note,
    evaluationMessage : a.evaluationMessage,
    outputParameters : a.outputParameters,
    result : a.result,
    dataRequirement : a.dataRequirement
  }

define function "HealthcareServiceResource"(arg HealthcareService):
  arg a
  return HealthcareService {
    identifier : a.identifier,
    active : a.active,
    providedBy : a.providedBy,
    category : a.category,
    type : a.type,
    specialty : a.specialty,
    location : a.location,
    name : a.name,
    comment : a.comment,
    extraDetails : a.extraDetails,
    photo : a.photo,
    telecom : a.telecom,
    coverageArea : a.coverageArea,
    serviceProvisionCode : a.serviceProvisionCode,
    eligibility : a.eligibility,
    program : a.program,
    characteristic : a.characteristic,
    communication : a.communication,
    referralMethod : a.referralMethod,
    appointmentRequired : a.appointmentRequired,
    availableTime : a.availableTime,
    notAvailable : a.notAvailable,
    availabilityExceptions : a.availabilityExceptions,
    endpoint : a.endpoint
  }

define function "ImagingStudyResource"(arg ImagingStudy):
  arg a
  return ImagingStudy {
    identifier : a.identifier,
    status : a.status,
    modality : a.modality,
    subject : a.subject,
    encounter : a.encounter,
    started : a.started,
    basedOn : a.basedOn,
    referrer : a.referrer,
    interpreter : a.interpreter,
    endpoint : a.endpoint,
    numberOfSeries : a.numberOfSeries,
    numberOfInstances : a.numberOfInstances,
    procedureReference : a.procedureReference,
    procedureCode : a.procedureCode,
    location : a.location,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    note : a.note,
    description : a.description,
    series : a.series
  }

define function "ImmunizationResource"(arg Immunization):
  arg a
  return Immunization {
    identifier : a.identifier,
    status : a.status,
    statusReason : a.statusReason,
    vaccineCode : a.vaccineCode,
    patient : a.patient,
    encounter : a.encounter,
    occurrence : a.occurrence,
    recorded : a.recorded,
    primarySource : a.primarySource,
    reportOrigin : a.reportOrigin,
    location : a.location,
    manufacturer : a.manufacturer,
    lotNumber : a.lotNumber,
    expirationDate : a.expirationDate,
    site : a.site,
    route : a.route,
    doseQuantity : a.doseQuantity,
    performer : a.performer,
    note : a.note,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    isSubpotent : a.isSubpotent,
    subpotentReason : a.subpotentReason,
    education : a.education,
    programEligibility : a.programEligibility,
    fundingSource : a.fundingSource,
    reaction : a.reaction,
    protocolApplied : a.protocolApplied
  }

define function "ImmunizationEvaluationResource"(arg ImmunizationEvaluation):
  arg a
  return ImmunizationEvaluation {
    identifier : a.identifier,
    status : a.status,
    patient : a.patient,
    date : a.date,
    authority : a.authority,
    targetDisease : a.targetDisease,
    immunizationEvent : a.immunizationEvent,
    doseStatus : a.doseStatus,
    doseStatusReason : a.doseStatusReason,
    description : a.description,
    series : a.series,
    doseNumber : a.doseNumber,
    seriesDoses : a.seriesDoses
  }

define function "ImmunizationRecommendationResource"(arg ImmunizationRecommendation):
  arg a
  return ImmunizationRecommendation {
    identifier : a.identifier,
    patient : a.patient,
    date : a.date,
    authority : a.authority,
    recommendation : a.recommendation
  }

// define function "ImplementationGuideResource"(arg ImplementationGuide):
//   arg a
//   return ImplementationGuide {
//     url : a.url,
//     version : a.version,
//     name : a.name,
//     title : a.title,
//     status : a.status,
//     experimental : a.experimental,
//     date : a.date,
//     publisher : a.publisher,
//     contact : a.contact,
//     description : a.description,
//     useContext : a.useContext,
//     jurisdiction : a.jurisdiction,
//     copyright : a.copyright,
//     packageId : a.packageId,
//     license : a.license,
//     fhirVersion : a.fhirVersion,
//     dependsOn : a.dependsOn,
//     global : a.global,
//     definition : a.definition,
//     manifest : a.manifest
//   }

define function "InsurancePlanResource"(arg InsurancePlan):
  arg a
  return InsurancePlan {
    identifier : a.identifier,
    status : a.status,
    type : a.type,
    name : a.name,
    alias : a.alias,
    period : a.period,
    ownedBy : a.ownedBy,
    administeredBy : a.administeredBy,
    coverageArea : a.coverageArea,
    contact : a.contact,
    endpoint : a.endpoint,
    network : a.network,
    coverage : a.coverage,
    plan : a.plan
  }

define function "InvoiceResource"(arg Invoice):
  arg a
  return Invoice {
    identifier : a.identifier,
    status : a.status,
    cancelledReason : a.cancelledReason,
    type : a.type,
    subject : a.subject,
    recipient : a.recipient,
    date : a.date,
    participant : a.participant,
    issuer : a.issuer,
    account : a.account,
    lineItem : a.lineItem,
    totalPriceComponent : a.totalPriceComponent,
    totalNet : a.totalNet,
    totalGross : a.totalGross,
    paymentTerms : a.paymentTerms,
    note : a.note
  }

define function "LibraryResource"(arg Library):
  arg a
  return Library {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    name : a.name,
    title : a.title,
    subtitle : a.subtitle,
    status : a.status,
    experimental : a.experimental,
    type : a.type,
    subject : a.subject,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    purpose : a.purpose,
    usage : a.usage,
    copyright : a.copyright,
    approvalDate : a.approvalDate,
    lastReviewDate : a.lastReviewDate,
    effectivePeriod : a.effectivePeriod,
    topic : a.topic,
    author : a.author,
    editor : a.editor,
    reviewer : a.reviewer,
    endorser : a.endorser,
    relatedArtifact : a.relatedArtifact,
    parameter : a.parameter,
    dataRequirement : a.dataRequirement,
    content : a.content
  }

define function "LinkageResource"(arg Linkage):
  arg a
  return Linkage {
    active : a.active,
    author : a.author,
    item : a.item
  }

// define function "ListResource"(arg List):
//   arg a
//   return List {
//     identifier : a.identifier,
//     status : a.status,
//     mode : a.mode,
//     title : a.title,
//     code : a.code,
//     subject : a.subject,
//     encounter : a.encounter,
//     date : a.date,
//     source : a.source,
//     orderedBy : a.orderedBy,
//     note : a.note,
//     entry : a.entry,
//     emptyReason : a.emptyReason
//   }

define function "LocationResource"(arg Location):
  arg a
  return Location {
    identifier : a.identifier,
    status : a.status,
    operationalStatus : a.operationalStatus,
    name : a.name,
    alias : a.alias,
    description : a.description,
    mode : a.mode,
    type : a.type,
    telecom : a.telecom,
    address : a.address,
    physicalType : a.physicalType,
    position : a.position,
    managingOrganization : a.managingOrganization,
    partOf : a.partOf,
    hoursOfOperation : a.hoursOfOperation,
    availabilityExceptions : a.availabilityExceptions,
    endpoint : a.endpoint
  }

define function "MeasureResource"(arg Measure):
  arg a
  return Measure {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    name : a.name,
    title : a.title,
    subtitle : a.subtitle,
    status : a.status,
    experimental : a.experimental,
    subject : a.subject,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    purpose : a.purpose,
    usage : a.usage,
    copyright : a.copyright,
    approvalDate : a.approvalDate,
    lastReviewDate : a.lastReviewDate,
    effectivePeriod : a.effectivePeriod,
    topic : a.topic,
    author : a.author,
    editor : a.editor,
    reviewer : a.reviewer,
    endorser : a.endorser,
    relatedArtifact : a.relatedArtifact,
    library : a.library,
    disclaimer : a.disclaimer,
    scoring : a.scoring,
    compositeScoring : a.compositeScoring,
    type : a.type,
    riskAdjustment : a.riskAdjustment,
    rateAggregation : a.rateAggregation,
    rationale : a.rationale,
    clinicalRecommendationStatement : a.clinicalRecommendationStatement,
    improvementNotation : a.improvementNotation,
    definition : a.definition,
    guidance : a.guidance,
    group : a.group,
    supplementalData : a.supplementalData
  }

define function "MeasureReportResource"(arg MeasureReport):
  arg a
  return MeasureReport {
    identifier : a.identifier,
    status : a.status,
    type : a.type,
    measure : a.measure,
    subject : a.subject,
    date : a.date,
    reporter : a.reporter,
    period : a.period,
    improvementNotation : a.improvementNotation,
    group : a.group,
    evaluatedResource : a.evaluatedResource
  }

// define function "MediaResource"(arg Media):
//   arg a
//   return Media {
//     identifier : a.identifier,
//     basedOn : a.basedOn,
//     partOf : a.partOf,
//     status : a.status,
//     type : a.type,
//     modality : a.modality,
//     view : a.view,
//     subject : a.subject,
//     encounter : a.encounter,
//     created : a.created,
//     issued : a.issued,
//     operator : a.operator,
//     reasonCode : a.reasonCode,
//     bodySite : a.bodySite,
//     deviceName : a.deviceName,
//     device : a.device,
//     height : a.height,
//     width : a.width,
//     frames : a.frames,
//     duration : a.duration,
//     content : a.content,
//     note : a.note
//   }

define function "MedicationResource"(arg Medication):
  arg a
  return Medication {
    identifier : a.identifier,
    code : a.code,
    status : a.status,
    manufacturer : a.manufacturer,
    form : a.form,
    amount : a.amount,
    ingredient : a.ingredient,
    batch : a.batch
  }

define function "MedicationAdministrationResource"(arg MedicationAdministration):
  arg a
  return MedicationAdministration {
    identifier : a.identifier,
    instantiates : a.instantiates,
    partOf : a.partOf,
    status : a.status,
    statusReason : a.statusReason,
    category : a.category,
    medication : a.medication,
    subject : a.subject,
    context : a.context,
    supportingInformation : a.supportingInformation,
    effective : a.effective,
    performer : a.performer,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    request : a.request,
    device : a.device,
    note : a.note,
    dosage : a.dosage,
    eventHistory : a.eventHistory
  }

define function "MedicationDispenseResource"(arg MedicationDispense):
  arg a
  return MedicationDispense {
    identifier : a.identifier,
    partOf : a.partOf,
    status : a.status,
    statusReason : a.statusReason,
    category : a.category,
    medication : a.medication,
    subject : a.subject,
    context : a.context,
    supportingInformation : a.supportingInformation,
    performer : a.performer,
    location : a.location,
    authorizingPrescription : a.authorizingPrescription,
    type : a.type,
    quantity : a.quantity,
    daysSupply : a.daysSupply,
    whenPrepared : a.whenPrepared,
    whenHandedOver : a.whenHandedOver,
    destination : a.destination,
    receiver : a.receiver,
    note : a.note,
    dosageInstruction : a.dosageInstruction,
    substitution : a.substitution,
    detectedIssue : a.detectedIssue,
    eventHistory : a.eventHistory
  }

define function "MedicationKnowledgeResource"(arg MedicationKnowledge):
  arg a
  return MedicationKnowledge {
    code : a.code,
    status : a.status,
    manufacturer : a.manufacturer,
    doseForm : a.doseForm,
    amount : a.amount,
    synonym : a.synonym,
    relatedMedicationKnowledge : a.relatedMedicationKnowledge,
    associatedMedication : a.associatedMedication,
    productType : a.productType,
    monograph : a.monograph,
    ingredient : a.ingredient,
    preparationInstruction : a.preparationInstruction,
    intendedRoute : a.intendedRoute,
    cost : a.cost,
    monitoringProgram : a.monitoringProgram,
    administrationGuidelines : a.administrationGuidelines,
    medicineClassification : a.medicineClassification,
    packaging : a.packaging,
    drugCharacteristic : a.drugCharacteristic,
    contraindication : a.contraindication,
    regulatory : a.regulatory,
    kinetics : a.kinetics
  }

define function "MedicationRequestResource"(arg MedicationRequest):
  arg a
  return MedicationRequest {
    identifier : a.identifier,
    status : a.status,
    statusReason : a.statusReason,
    intent : a.intent,
    category : a.category,
    priority : a.priority,
    doNotPerform : a.doNotPerform,
    reported : a.reported,
    medication : a.medication,
    subject : a.subject,
    encounter : a.encounter,
    supportingInformation : a.supportingInformation,
    authoredOn : a.authoredOn,
    requester : a.requester,
    performer : a.performer,
    performerType : a.performerType,
    recorder : a.recorder,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    instantiatesCanonical : a.instantiatesCanonical,
    instantiatesUri : a.instantiatesUri,
    basedOn : a.basedOn,
    groupIdentifier : a.groupIdentifier,
    courseOfTherapyType : a.courseOfTherapyType,
    insurance : a.insurance,
    note : a.note,
    dosageInstruction : a.dosageInstruction,
    dispenseRequest : a.dispenseRequest,
    substitution : a.substitution,
    priorPrescription : a.priorPrescription,
    detectedIssue : a.detectedIssue,
    eventHistory : a.eventHistory
  }

define function "MedicationStatementResource"(arg MedicationStatement):
  arg a
  return MedicationStatement {
    identifier : a.identifier,
    basedOn : a.basedOn,
    partOf : a.partOf,
    status : a.status,
    statusReason : a.statusReason,
    category : a.category,
    medication : a.medication,
    subject : a.subject,
    context : a.context,
    effective : a.effective,
    dateAsserted : a.dateAsserted,
    informationSource : a.informationSource,
    derivedFrom : a.derivedFrom,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    note : a.note,
    dosage : a.dosage
  }

define function "MedicinalProductResource"(arg MedicinalProduct):
  arg a
  return MedicinalProduct {
    identifier : a.identifier,
    type : a.type,
    domain : a.domain,
    combinedPharmaceuticalDoseForm : a.combinedPharmaceuticalDoseForm,
    legalStatusOfSupply : a.legalStatusOfSupply,
    additionalMonitoringIndicator : a.additionalMonitoringIndicator,
    specialMeasures : a.specialMeasures,
    paediatricUseIndicator : a.paediatricUseIndicator,
    productClassification : a.productClassification,
    marketingStatus : a.marketingStatus,
    pharmaceuticalProduct : a.pharmaceuticalProduct,
    packagedMedicinalProduct : a.packagedMedicinalProduct,
    attachedDocument : a.attachedDocument,
    masterFile : a.masterFile,
    contact : a.contact,
    clinicalTrial : a.clinicalTrial,
    name : a.name,
    crossReference : a.crossReference,
    manufacturingBusinessOperation : a.manufacturingBusinessOperation,
    specialDesignation : a.specialDesignation
  }

define function "MedicinalProductAuthorizationResource"(arg MedicinalProductAuthorization):
  arg a
  return MedicinalProductAuthorization {
    identifier : a.identifier,
    subject : a.subject,
    country : a.country,
    jurisdiction : a.jurisdiction,
    status : a.status,
    statusDate : a.statusDate,
    restoreDate : a.restoreDate,
    validityPeriod : a.validityPeriod,
    dataExclusivityPeriod : a.dataExclusivityPeriod,
    dateOfFirstAuthorization : a.dateOfFirstAuthorization,
    internationalBirthDate : a.internationalBirthDate,
    legalBasis : a.legalBasis,
    jurisdictionalAuthorization : a.jurisdictionalAuthorization,
    holder : a.holder,
    regulator : a.regulator,
    procedure : a.procedure
  }

define function "MedicinalProductContraindicationResource"(arg MedicinalProductContraindication):
  arg a
  return MedicinalProductContraindication {
    subject : a.subject,
    disease : a.disease,
    diseaseStatus : a.diseaseStatus,
    comorbidity : a.comorbidity,
    therapeuticIndication : a.therapeuticIndication,
    otherTherapy : a.otherTherapy,
    population : a.population
  }

// define function "MedicinalProductIndicationResource"(arg MedicinalProductIndication):
//   arg a
//   return MedicinalProductIndication {
//     subject : a.subject,
//     diseaseSymptomProcedure : a.diseaseSymptomProcedure,
//     diseaseStatus : a.diseaseStatus,
//     comorbidity : a.comorbidity,
//     intendedEffect : a.intendedEffect,
//     duration : a.duration,
//     otherTherapy : a.otherTherapy,
//     undesirableEffect : a.undesirableEffect,
//     population : a.population
//   }

define function "MedicinalProductIngredientResource"(arg MedicinalProductIngredient):
  arg a
  return MedicinalProductIngredient {
    identifier : a.identifier,
    role : a.role,
    allergenicIndicator : a.allergenicIndicator,
    manufacturer : a.manufacturer,
    specifiedSubstance : a.specifiedSubstance,
    substance : a.substance
  }

define function "MedicinalProductInteractionResource"(arg MedicinalProductInteraction):
  arg a
  return MedicinalProductInteraction {
    subject : a.subject,
    description : a.description,
    interactant : a.interactant,
    type : a.type,
    effect : a.effect,
    incidence : a.incidence,
    management : a.management
  }

define function "MedicinalProductManufacturedResource"(arg MedicinalProductManufactured):
  arg a
  return MedicinalProductManufactured {
    manufacturedDoseForm : a.manufacturedDoseForm,
    unitOfPresentation : a.unitOfPresentation,
    quantity : a.quantity,
    manufacturer : a.manufacturer,
    ingredient : a.ingredient,
    physicalCharacteristics : a.physicalCharacteristics,
    otherCharacteristics : a.otherCharacteristics
  }

define function "MedicinalProductPackagedResource"(arg MedicinalProductPackaged):
  arg a
  return MedicinalProductPackaged {
    identifier : a.identifier,
    subject : a.subject,
    description : a.description,
    legalStatusOfSupply : a.legalStatusOfSupply,
    marketingStatus : a.marketingStatus,
    marketingAuthorization : a.marketingAuthorization,
    manufacturer : a.manufacturer,
    batchIdentifier : a.batchIdentifier,
    packageItem : a.packageItem
  }

define function "MedicinalProductPharmaceuticalResource"(arg MedicinalProductPharmaceutical):
  arg a
  return MedicinalProductPharmaceutical {
    identifier : a.identifier,
    administrableDoseForm : a.administrableDoseForm,
    unitOfPresentation : a.unitOfPresentation,
    ingredient : a.ingredient,
    device : a.device,
    characteristics : a.characteristics,
    routeOfAdministration : a.routeOfAdministration
  }

define function "MedicinalProductUndesirableEffectResource"(arg MedicinalProductUndesirableEffect):
  arg a
  return MedicinalProductUndesirableEffect {
    subject : a.subject,
    symptomConditionEffect : a.symptomConditionEffect,
    classification : a.classification,
    frequencyOfOccurrence : a.frequencyOfOccurrence,
    population : a.population
  }

// define function "MessageDefinitionResource"(arg MessageDefinition):
//   arg a
//   return MessageDefinition {
//     url : a.url,
//     identifier : a.identifier,
//     version : a.version,
//     name : a.name,
//     title : a.title,
//     replaces : a.replaces,
//     status : a.status,
//     experimental : a.experimental,
//     date : a.date,
//     publisher : a.publisher,
//     contact : a.contact,
//     description : a.description,
//     useContext : a.useContext,
//     jurisdiction : a.jurisdiction,
//     purpose : a.purpose,
//     copyright : a.copyright,
//     base : a.base,
//     parent : a.parent,
//     event : a.event,
//     category : a.category,
//     focus : a.focus,
//     responseRequired : a.responseRequired,
//     allowedResponse : a.allowedResponse,
//     graph : a.graph
//   }

define function "MessageHeaderResource"(arg MessageHeader):
  arg a
  return MessageHeader {
    event : a.event,
    destination : a.destination,
    sender : a.sender,
    enterer : a.enterer,
    author : a.author,
    source : a.source,
    responsible : a.responsible,
    reason : a.reason,
    response : a.response,
    focus : a.focus,
    definition : a.definition
  }

define function "MolecularSequenceResource"(arg MolecularSequence):
  arg a
  return MolecularSequence {
    identifier : a.identifier,
    type : a.type,
    coordinateSystem : a.coordinateSystem,
    patient : a.patient,
    specimen : a.specimen,
    device : a.device,
    performer : a.performer,
    quantity : a.quantity,
    referenceSeq : a.referenceSeq,
    variant : a.variant,
    observedSeq : a.observedSeq,
    quality : a.quality,
    readCoverage : a.readCoverage,
    repository : a.repository,
    pointer : a.pointer,
    structureVariant : a.structureVariant
  }

define function "NamingSystemResource"(arg NamingSystem):
  arg a
  return NamingSystem {
    name : a.name,
    status : a.status,
    kind : a.kind,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    responsible : a.responsible,
    type : a.type,
    description : a.description,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    usage : a.usage,
    uniqueId : a.uniqueId
  }

define function "NutritionOrderResource"(arg NutritionOrder):
  arg a
  return NutritionOrder {
    identifier : a.identifier,
    instantiatesCanonical : a.instantiatesCanonical,
    instantiatesUri : a.instantiatesUri,
    instantiates : a.instantiates,
    status : a.status,
    intent : a.intent,
    patient : a.patient,
    encounter : a.encounter,
    dateTime : a.dateTime,
    orderer : a.orderer,
    allergyIntolerance : a.allergyIntolerance,
    foodPreferenceModifier : a.foodPreferenceModifier,
    excludeFoodModifier : a.excludeFoodModifier,
    oralDiet : a.oralDiet,
    supplement : a.supplement,
    enteralFormula : a.enteralFormula,
    note : a.note
  }

define function "ObservationResource"(arg Observation):
  arg a
  return Observation {
    identifier : a.identifier,
    basedOn : a.basedOn,
    partOf : a.partOf,
    status : a.status,
    category : a.category,
    code : a.code,
    subject : a.subject,
    focus : a.focus,
    encounter : a.encounter,
    effective : a.effective,
    issued : a.issued,
    performer : a.performer,
    value : a.value,
    dataAbsentReason : a.dataAbsentReason,
    interpretation : a.interpretation,
    note : a.note,
    bodySite : a.bodySite,
    method : a.method,
    specimen : a.specimen,
    device : a.device,
    referenceRange : a.referenceRange,
    hasMember : a.hasMember,
    derivedFrom : a.derivedFrom,
    component : a.component
  }

define function "ObservationDefinitionResource"(arg ObservationDefinition):
  arg a
  return ObservationDefinition {
    category : a.category,
    code : a.code,
    identifier : a.identifier,
    permittedDataType : a.permittedDataType,
    multipleResultsAllowed : a.multipleResultsAllowed,
    method : a.method,
    preferredReportName : a.preferredReportName,
    quantitativeDetails : a.quantitativeDetails,
    qualifiedInterval : a.qualifiedInterval,
    validCodedValueSet : a.validCodedValueSet,
    normalCodedValueSet : a.normalCodedValueSet,
    abnormalCodedValueSet : a.abnormalCodedValueSet,
    criticalCodedValueSet : a.criticalCodedValueSet
  }

// define function "OperationDefinitionResource"(arg OperationDefinition):
//   arg a
//   return OperationDefinition {
//     url : a.url,
//     version : a.version,
//     name : a.name,
//     title : a.title,
//     status : a.status,
//     kind : a.kind,
//     experimental : a.experimental,
//     date : a.date,
//     publisher : a.publisher,
//     contact : a.contact,
//     description : a.description,
//     useContext : a.useContext,
//     jurisdiction : a.jurisdiction,
//     purpose : a.purpose,
//     affectsState : a.affectsState,
//     code : a.code,
//     comment : a.comment,
//     base : a.base,
//     resource : a.resource,
//     system : a.system,
//     type : a.type,
//     instance : a.instance,
//     inputProfile : a.inputProfile,
//     outputProfile : a.outputProfile,
//     parameter : a.parameter,
//     overload : a.overload
//   }

define function "OperationOutcomeResource"(arg OperationOutcome):
  arg a
  return OperationOutcome {
    issue : a.issue
  }

define function "OrganizationResource"(arg Organization):
  arg a
  return Organization {
    identifier : a.identifier,
    active : a.active,
    type : a.type,
    name : a.name,
    alias : a.alias,
    telecom : a.telecom,
    address : a.address,
    partOf : a.partOf,
    contact : a.contact,
    endpoint : a.endpoint
  }

define function "OrganizationAffiliationResource"(arg OrganizationAffiliation):
  arg a
  return OrganizationAffiliation {
    identifier : a.identifier,
    active : a.active,
    period : a.period,
    organization : a.organization,
    participatingOrganization : a.participatingOrganization,
    network : a.network,
    code : a.code,
    specialty : a.specialty,
    location : a.location,
    healthcareService : a.healthcareService,
    telecom : a.telecom,
    endpoint : a.endpoint
  }

define function "PatientResource"(arg Patient):
  arg a
  return Patient {
    identifier : a.identifier,
    active : a.active,
    name : a.name,
    telecom : a.telecom,
    gender : a.gender,
    birthDate : a.birthDate,
    deceased : a.deceased,
    address : a.address,
    maritalStatus : a.maritalStatus,
    multipleBirth : a.multipleBirth,
    photo : a.photo,
    contact : a.contact,
    communication : a.communication,
    generalPractitioner : a.generalPractitioner,
    managingOrganization : a.managingOrganization,
    link : a.link
  }

define function "PaymentNoticeResource"(arg PaymentNotice):
  arg a
  return PaymentNotice {
    identifier : a.identifier,
    status : a.status,
    request : a.request,
    response : a.response,
    created : a.created,
    provider : a.provider,
    payment : a.payment,
    paymentDate : a.paymentDate,
    payee : a.payee,
    recipient : a.recipient,
    amount : a.amount,
    paymentStatus : a.paymentStatus
  }

define function "PaymentReconciliationResource"(arg PaymentReconciliation):
  arg a
  return PaymentReconciliation {
    identifier : a.identifier,
    status : a.status,
    period : a.period,
    created : a.created,
    paymentIssuer : a.paymentIssuer,
    request : a.request,
    requestor : a.requestor,
    outcome : a.outcome,
    disposition : a.disposition,
    paymentDate : a.paymentDate,
    paymentAmount : a.paymentAmount,
    paymentIdentifier : a.paymentIdentifier,
    detail : a.detail,
    formCode : a.formCode,
    processNote : a.processNote
  }

define function "PersonResource"(arg Person):
  arg a
  return Person {
    identifier : a.identifier,
    name : a.name,
    telecom : a.telecom,
    gender : a.gender,
    birthDate : a.birthDate,
    address : a.address,
    photo : a.photo,
    managingOrganization : a.managingOrganization,
    active : a.active,
    link : a.link
  }

define function "PlanDefinitionResource"(arg PlanDefinition):
  arg a
  return PlanDefinition {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    name : a.name,
    title : a.title,
    subtitle : a.subtitle,
    type : a.type,
    status : a.status,
    experimental : a.experimental,
    subject : a.subject,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    purpose : a.purpose,
    usage : a.usage,
    copyright : a.copyright,
    approvalDate : a.approvalDate,
    lastReviewDate : a.lastReviewDate,
    effectivePeriod : a.effectivePeriod,
    topic : a.topic,
    author : a.author,
    editor : a.editor,
    reviewer : a.reviewer,
    endorser : a.endorser,
    relatedArtifact : a.relatedArtifact,
    library : a.library,
    goal : a.goal,
    action : a.action
  }

define function "PractitionerResource"(arg Practitioner):
  arg a
  return Practitioner {
    identifier : a.identifier,
    active : a.active,
    name : a.name,
    telecom : a.telecom,
    address : a.address,
    gender : a.gender,
    birthDate : a.birthDate,
    photo : a.photo,
    qualification : a.qualification,
    communication : a.communication
  }

define function "PractitionerRoleResource"(arg PractitionerRole):
  arg a
  return PractitionerRole {
    identifier : a.identifier,
    active : a.active,
    period : a.period,
    practitioner : a.practitioner,
    organization : a.organization,
    code : a.code,
    specialty : a.specialty,
    location : a.location,
    healthcareService : a.healthcareService,
    telecom : a.telecom,
    availableTime : a.availableTime,
    notAvailable : a.notAvailable,
    availabilityExceptions : a.availabilityExceptions,
    endpoint : a.endpoint
  }

define function "ProcedureResource"(arg Procedure):
  arg a
  return Procedure {
    identifier : a.identifier,
    instantiatesCanonical : a.instantiatesCanonical,
    instantiatesUri : a.instantiatesUri,
    basedOn : a.basedOn,
    partOf : a.partOf,
    status : a.status,
    statusReason : a.statusReason,
    category : a.category,
    code : a.code,
    subject : a.subject,
    encounter : a.encounter,
    performed : a.performed,
    recorder : a.recorder,
    asserter : a.asserter,
    performer : a.performer,
    location : a.location,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    bodySite : a.bodySite,
    outcome : a.outcome,
    report : a.report,
    complication : a.complication,
    complicationDetail : a.complicationDetail,
    followUp : a.followUp,
    note : a.note,
    focalDevice : a.focalDevice,
    usedReference : a.usedReference,
    usedCode : a.usedCode
  }

define function "ProvenanceResource"(arg Provenance):
  arg a
  return Provenance {
    target : a.target,
    occurred : a.occurred,
    recorded : a.recorded,
    policy : a.policy,
    location : a.location,
    reason : a.reason,
    activity : a.activity,
    agent : a.agent,
    entity : a.entity,
    signature : a.signature
  }

// define function "QuestionnaireResource"(arg Questionnaire):
//   arg a
//   return Questionnaire {
//     url : a.url,
//     identifier : a.identifier,
//     version : a.version,
//     name : a.name,
//     title : a.title,
//     derivedFrom : a.derivedFrom,
//     status : a.status,
//     experimental : a.experimental,
//     subjectType : a.subjectType,
//     date : a.date,
//     publisher : a.publisher,
//     contact : a.contact,
//     description : a.description,
//     useContext : a.useContext,
//     jurisdiction : a.jurisdiction,
//     purpose : a.purpose,
//     copyright : a.copyright,
//     approvalDate : a.approvalDate,
//     lastReviewDate : a.lastReviewDate,
//     effectivePeriod : a.effectivePeriod,
//     code : a.code,
//     item : a.item
//   }

define function "QuestionnaireResponseResource"(arg QuestionnaireResponse):
  arg a
  return QuestionnaireResponse {
    identifier : a.identifier,
    basedOn : a.basedOn,
    partOf : a.partOf,
    questionnaire : a.questionnaire,
    status : a.status,
    subject : a.subject,
    encounter : a.encounter,
    authored : a.authored,
    author : a.author,
    source : a.source,
    item : a.item
  }

define function "RelatedPersonResource"(arg RelatedPerson):
  arg a
  return RelatedPerson {
    identifier : a.identifier,
    active : a.active,
    patient : a.patient,
    relationship : a.relationship,
    name : a.name,
    telecom : a.telecom,
    gender : a.gender,
    birthDate : a.birthDate,
    address : a.address,
    photo : a.photo,
    period : a.period,
    communication : a.communication
  }

define function "RequestGroupResource"(arg RequestGroup):
  arg a
  return RequestGroup {
    identifier : a.identifier,
    instantiatesCanonical : a.instantiatesCanonical,
    instantiatesUri : a.instantiatesUri,
    basedOn : a.basedOn,
    replaces : a.replaces,
    groupIdentifier : a.groupIdentifier,
    status : a.status,
    intent : a.intent,
    priority : a.priority,
    code : a.code,
    subject : a.subject,
    encounter : a.encounter,
    authoredOn : a.authoredOn,
    author : a.author,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    note : a.note,
    action : a.action
  }

define function "ResearchDefinitionResource"(arg ResearchDefinition):
  arg a
  return ResearchDefinition {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    name : a.name,
    title : a.title,
    shortTitle : a.shortTitle,
    subtitle : a.subtitle,
    status : a.status,
    experimental : a.experimental,
    subject : a.subject,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    comment : a.comment,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    purpose : a.purpose,
    usage : a.usage,
    copyright : a.copyright,
    approvalDate : a.approvalDate,
    lastReviewDate : a.lastReviewDate,
    effectivePeriod : a.effectivePeriod,
    topic : a.topic,
    author : a.author,
    editor : a.editor,
    reviewer : a.reviewer,
    endorser : a.endorser,
    relatedArtifact : a.relatedArtifact,
    library : a.library,
    population : a.population,
    exposure : a.exposure,
    exposureAlternative : a.exposureAlternative,
    outcome : a.outcome
  }

define function "ResearchElementDefinitionResource"(arg ResearchElementDefinition):
  arg a
  return ResearchElementDefinition {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    name : a.name,
    title : a.title,
    shortTitle : a.shortTitle,
    subtitle : a.subtitle,
    status : a.status,
    experimental : a.experimental,
    subject : a.subject,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    comment : a.comment,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    purpose : a.purpose,
    usage : a.usage,
    copyright : a.copyright,
    approvalDate : a.approvalDate,
    lastReviewDate : a.lastReviewDate,
    effectivePeriod : a.effectivePeriod,
    topic : a.topic,
    author : a.author,
    editor : a.editor,
    reviewer : a.reviewer,
    endorser : a.endorser,
    relatedArtifact : a.relatedArtifact,
    library : a.library,
    type : a.type,
    variableType : a.variableType,
    characteristic : a.characteristic
  }

define function "ResearchStudyResource"(arg ResearchStudy):
  arg a
  return ResearchStudy {
    identifier : a.identifier,
    title : a.title,
    protocol : a.protocol,
    partOf : a.partOf,
    status : a.status,
    primaryPurposeType : a.primaryPurposeType,
    phase : a.phase,
    category : a.category,
    focus : a.focus,
    condition : a.condition,
    contact : a.contact,
    relatedArtifact : a.relatedArtifact,
    keyword : a.keyword,
    location : a.location,
    description : a.description,
    enrollment : a.enrollment,
    period : a.period,
    sponsor : a.sponsor,
    principalInvestigator : a.principalInvestigator,
    site : a.site,
    reasonStopped : a.reasonStopped,
    note : a.note,
    arm : a.arm,
    objective : a.objective
  }

define function "ResearchSubjectResource"(arg ResearchSubject):
  arg a
  return ResearchSubject {
    identifier : a.identifier,
    status : a.status,
    period : a.period,
    study : a.study,
    individual : a.individual,
    assignedArm : a.assignedArm,
    actualArm : a.actualArm,
    consent : a.consent
  }

define function "RiskAssessmentResource"(arg RiskAssessment):
  arg a
  return RiskAssessment {
    identifier : a.identifier,
    basedOn : a.basedOn,
    parent : a.parent,
    status : a.status,
    method : a.method,
    code : a.code,
    subject : a.subject,
    encounter : a.encounter,
    occurrence : a.occurrence,
    condition : a.condition,
    performer : a.performer,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    basis : a.basis,
    prediction : a.prediction,
    mitigation : a.mitigation,
    note : a.note
  }

define function "RiskEvidenceSynthesisResource"(arg RiskEvidenceSynthesis):
  arg a
  return RiskEvidenceSynthesis {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    name : a.name,
    title : a.title,
    status : a.status,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    note : a.note,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    copyright : a.copyright,
    approvalDate : a.approvalDate,
    lastReviewDate : a.lastReviewDate,
    effectivePeriod : a.effectivePeriod,
    topic : a.topic,
    author : a.author,
    editor : a.editor,
    reviewer : a.reviewer,
    endorser : a.endorser,
    relatedArtifact : a.relatedArtifact,
    synthesisType : a.synthesisType,
    studyType : a.studyType,
    population : a.population,
    exposure : a.exposure,
    outcome : a.outcome,
    sampleSize : a.sampleSize,
    riskEstimate : a.riskEstimate,
    certainty : a.certainty
  }

define function "ScheduleResource"(arg Schedule):
  arg a
  return Schedule {
    identifier : a.identifier,
    active : a.active,
    serviceCategory : a.serviceCategory,
    serviceType : a.serviceType,
    specialty : a.specialty,
    actor : a.actor,
    planningHorizon : a.planningHorizon,
    comment : a.comment
  }

// define function "SearchParameterResource"(arg SearchParameter):
//   arg a
//   return SearchParameter {
//     url : a.url,
//     version : a.version,
//     name : a.name,
//     derivedFrom : a.derivedFrom,
//     status : a.status,
//     experimental : a.experimental,
//     date : a.date,
//     publisher : a.publisher,
//     contact : a.contact,
//     description : a.description,
//     useContext : a.useContext,
//     jurisdiction : a.jurisdiction,
//     purpose : a.purpose,
//     code : a.code,
//     base : a.base,
//     type : a.type,
//     expression : a.expression,
//     xpath : a.xpath,
//     xpathUsage : a.xpathUsage,
//     target : a.target,
//     multipleOr : a.multipleOr,
//     multipleAnd : a.multipleAnd,
//     comparator : a.comparator,
//     modifier : a.modifier,
//     chain : a.chain,
//     component : a.component
//   }

define function "ServiceRequestResource"(arg ServiceRequest):
  arg a
  return ServiceRequest {
    identifier : a.identifier,
    instantiatesCanonical : a.instantiatesCanonical,
    instantiatesUri : a.instantiatesUri,
    basedOn : a.basedOn,
    replaces : a.replaces,
    requisition : a.requisition,
    status : a.status,
    intent : a.intent,
    category : a.category,
    priority : a.priority,
    doNotPerform : a.doNotPerform,
    code : a.code,
    orderDetail : a.orderDetail,
    quantity : a.quantity,
    subject : a.subject,
    encounter : a.encounter,
    occurrence : a.occurrence,
    asNeeded : a.asNeeded,
    authoredOn : a.authoredOn,
    requester : a.requester,
    performerType : a.performerType,
    performer : a.performer,
    locationCode : a.locationCode,
    locationReference : a.locationReference,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    insurance : a.insurance,
    supportingInfo : a.supportingInfo,
    specimen : a.specimen,
    bodySite : a.bodySite,
    note : a.note,
    patientInstruction : a.patientInstruction,
    relevantHistory : a.relevantHistory
  }

define function "SlotResource"(arg Slot):
  arg a
  return Slot {
    identifier : a.identifier,
    serviceCategory : a.serviceCategory,
    serviceType : a.serviceType,
    specialty : a.specialty,
    appointmentType : a.appointmentType,
    schedule : a.schedule,
    status : a.status,
    start : a.start,
    end : a.end,
    overbooked : a.overbooked,
    comment : a.comment
  }

define function "SpecimenResource"(arg Specimen):
  arg a
  return Specimen {
    identifier : a.identifier,
    accessionIdentifier : a.accessionIdentifier,
    status : a.status,
    type : a.type,
    subject : a.subject,
    receivedTime : a.receivedTime,
    parent : a.parent,
    request : a.request,
    collection : a.collection,
    processing : a.processing,
    container : a.container,
    condition : a.condition,
    note : a.note
  }

define function "SpecimenDefinitionResource"(arg SpecimenDefinition):
  arg a
  return SpecimenDefinition {
    identifier : a.identifier,
    typeCollected : a.typeCollected,
    patientPreparation : a.patientPreparation,
    timeAspect : a.timeAspect,
    collection : a.collection,
    typeTested : a.typeTested
  }

define function "StructureDefinitionResource"(arg StructureDefinition):
  arg a
  return StructureDefinition {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    name : a.name,
    title : a.title,
    status : a.status,
    experimental : a.experimental,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    purpose : a.purpose,
    copyright : a.copyright,
    keyword : a.keyword,
    fhirVersion : a.fhirVersion,
    mapping : a.mapping,
    kind : a.kind,
    abstract : a.abstract,
    context : a.context,
    contextInvariant : a.contextInvariant,
    type : a.type,
    baseDefinition : a.baseDefinition,
    derivation : a.derivation,
    snapshot : a.snapshot,
    differential : a.differential
  }

define function "StructureMapResource"(arg StructureMap):
  arg a
  return StructureMap {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    name : a.name,
    title : a.title,
    status : a.status,
    experimental : a.experimental,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    purpose : a.purpose,
    copyright : a.copyright,
    structure : a.structure,
    import : a.import,
    group : a.group
  }

define function "SubscriptionResource"(arg Subscription):
  arg a
  return Subscription {
    status : a.status,
    contact : a.contact,
    end : a.end,
    reason : a.reason,
    criteria : a.criteria,
    error : a.error,
    channel : a.channel
  }

define function "SubstanceResource"(arg Substance):
  arg a
  return Substance {
    identifier : a.identifier,
    status : a.status,
    category : a.category,
    code : a.code,
    description : a.description,
    instance : a.instance,
    ingredient : a.ingredient
  }

define function "SubstanceNucleicAcidResource"(arg SubstanceNucleicAcid):
  arg a
  return SubstanceNucleicAcid {
    sequenceType : a.sequenceType,
    numberOfSubunits : a.numberOfSubunits,
    areaOfHybridisation : a.areaOfHybridisation,
    oligoNucleotideType : a.oligoNucleotideType,
    subunit : a.subunit
  }

define function "SubstancePolymerResource"(arg SubstancePolymer):
  arg a
  return SubstancePolymer {
    class : a.class,
    geometry : a.geometry,
    copolymerConnectivity : a.copolymerConnectivity,
    modification : a.modification,
    monomerSet : a.monomerSet,
    repeat : a.repeat
  }

define function "SubstanceProteinResource"(arg SubstanceProtein):
  arg a
  return SubstanceProtein {
    sequenceType : a.sequenceType,
    numberOfSubunits : a.numberOfSubunits,
    disulfideLinkage : a.disulfideLinkage,
    subunit : a.subunit
  }

define function "SubstanceReferenceInformationResource"(arg SubstanceReferenceInformation):
  arg a
  return SubstanceReferenceInformation {
    comment : a.comment,
    gene : a.gene,
    geneElement : a.geneElement,
    classification : a.classification,
    target : a.target
  }

define function "SubstanceSourceMaterialResource"(arg SubstanceSourceMaterial):
  arg a
  return SubstanceSourceMaterial {
    sourceMaterialClass : a.sourceMaterialClass,
    sourceMaterialType : a.sourceMaterialType,
    sourceMaterialState : a.sourceMaterialState,
    organismId : a.organismId,
    organismName : a.organismName,
    parentSubstanceId : a.parentSubstanceId,
    parentSubstanceName : a.parentSubstanceName,
    countryOfOrigin : a.countryOfOrigin,
    geographicalLocation : a.geographicalLocation,
    developmentStage : a.developmentStage,
    fractionDescription : a.fractionDescription,
    organism : a.organism,
    partDescription : a.partDescription
  }

define function "SubstanceSpecificationResource"(arg SubstanceSpecification):
  arg a
  return SubstanceSpecification {
    identifier : a.identifier,
    type : a.type,
    status : a.status,
    domain : a.domain,
    description : a.description,
    source : a.source,
    comment : a.comment,
    moiety : a.moiety,
    property : a.property,
    referenceInformation : a.referenceInformation,
    structure : a.structure,
    code : a.code,
    name : a.name,
    molecularWeight : a.molecularWeight,
    relationship : a.relationship,
    nucleicAcid : a.nucleicAcid,
    polymer : a.polymer,
    protein : a.protein,
    sourceMaterial : a.sourceMaterial
  }

define function "SupplyDeliveryResource"(arg SupplyDelivery):
  arg a
  return SupplyDelivery {
    identifier : a.identifier,
    basedOn : a.basedOn,
    partOf : a.partOf,
    status : a.status,
    patient : a.patient,
    type : a.type,
    suppliedItem : a.suppliedItem,
    occurrence : a.occurrence,
    supplier : a.supplier,
    destination : a.destination,
    receiver : a.receiver
  }

define function "SupplyRequestResource"(arg SupplyRequest):
  arg a
  return SupplyRequest {
    identifier : a.identifier,
    status : a.status,
    category : a.category,
    priority : a.priority,
    item : a.item,
    quantity : a.quantity,
    parameter : a.parameter,
    occurrence : a.occurrence,
    authoredOn : a.authoredOn,
    requester : a.requester,
    supplier : a.supplier,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    deliverFrom : a.deliverFrom,
    deliverTo : a.deliverTo
  }

define function "TaskResource"(arg Task):
  arg a
  return Task {
    identifier : a.identifier,
    instantiatesCanonical : a.instantiatesCanonical,
    instantiatesUri : a.instantiatesUri,
    basedOn : a.basedOn,
    groupIdentifier : a.groupIdentifier,
    partOf : a.partOf,
    status : a.status,
    statusReason : a.statusReason,
    businessStatus : a.businessStatus,
    intent : a.intent,
    priority : a.priority,
    code : a.code,
    description : a.description,
    focus : a.focus,
    for : a.for,
    encounter : a.encounter,
    executionPeriod : a.executionPeriod,
    authoredOn : a.authoredOn,
    lastModified : a.lastModified,
    requester : a.requester,
    performerType : a.performerType,
    owner : a.owner,
    location : a.location,
    reasonCode : a.reasonCode,
    reasonReference : a.reasonReference,
    insurance : a.insurance,
    note : a.note,
    relevantHistory : a.relevantHistory,
    restriction : a.restriction,
    input : a.input,
    output : a.output
  }

define function "TerminologyCapabilitiesResource"(arg TerminologyCapabilities):
  arg a
  return TerminologyCapabilities {
    url : a.url,
    version : a.version,
    name : a.name,
    title : a.title,
    status : a.status,
    experimental : a.experimental,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    purpose : a.purpose,
    copyright : a.copyright,
    kind : a.kind,
    software : a.software,
    implementation : a.implementation,
    lockedDate : a.lockedDate,
    codeSystem : a.codeSystem,
    expansion : a.expansion,
    codeSearch : a.codeSearch,
    validateCode : a.validateCode,
    translation : a.translation,
    closure : a.closure
  }

define function "TestReportResource"(arg TestReport):
  arg a
  return TestReport {
    identifier : a.identifier,
    name : a.name,
    status : a.status,
    testScript : a.testScript,
    result : a.result,
    score : a.score,
    tester : a.tester,
    issued : a.issued,
    participant : a.participant,
    setup : a.setup,
    test : a.test,
    teardown : a.teardown
  }

define function "TestScriptResource"(arg TestScript):
  arg a
  return TestScript {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    name : a.name,
    title : a.title,
    status : a.status,
    experimental : a.experimental,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    purpose : a.purpose,
    copyright : a.copyright,
    origin : a.origin,
    destination : a.destination,
    metadata : a.metadata,
    fixture : a.fixture,
    profile : a.profile,
    variable : a.variable,
    setup : a.setup,
    test : a.test,
    teardown : a.teardown
  }

define function "ValueSetResource"(arg ValueSet):
  arg a
  return ValueSet {
    url : a.url,
    identifier : a.identifier,
    version : a.version,
    name : a.name,
    title : a.title,
    status : a.status,
    experimental : a.experimental,
    date : a.date,
    publisher : a.publisher,
    contact : a.contact,
    description : a.description,
    useContext : a.useContext,
    jurisdiction : a.jurisdiction,
    immutable : a.immutable,
    purpose : a.purpose,
    copyright : a.copyright,
    compose : a.compose,
    expansion : a.expansion
  }

define function "VerificationResultResource"(arg VerificationResult):
  arg a
  return VerificationResult {
    target : a.target,
    targetLocation : a.targetLocation,
    need : a.need,
    status : a.status,
    statusDate : a.statusDate,
    validationType : a.validationType,
    validationProcess : a.validationProcess,
    frequency : a.frequency,
    lastPerformed : a.lastPerformed,
    nextScheduled : a.nextScheduled,
    failureAction : a.failureAction,
    primarySource : a.primarySource,
    attestation : a.attestation,
    validator : a.validator
  }

define function "VisionPrescriptionResource"(arg VisionPrescription):
  arg a
  return VisionPrescription {
    identifier : a.identifier,
    status : a.status,
    created : a.created,
    patient : a.patient,
    encounter : a.encounter,
    dateWritten : a.dateWritten,
    prescriber : a.prescriber,
    lensSpecification : a.lensSpecification
  }