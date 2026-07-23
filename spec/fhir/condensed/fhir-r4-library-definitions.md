This page is part of the FHIR Specification (v4.0.1: R4 - Mixed Normative and STU ) in it's permanent home (it will always be available at this URL). The current version which supercedes this version is 5.0.0 . For a full list of available versions, see the Directory of published versions . Page versions: R5 R4B **R4 **R3
- Content
- Examples
- Detailed Descriptions
- Mappings
- Profiles & Extensions
- Operations
- R3 Conversions

## 14.11.6 Resource Library - Detailed Descriptions
Clinical Decision Support Work Group Maturity Level : 2 Trial Use Security Category : Anonymous Compartments : Not linked to any defined compartments

Detailed Descriptions for the elements in the Library resource. **Library **Element Id Library Definition

The Library resource is a general-purpose container for knowledge asset definitions. It can be used to describe and expose existing knowledge assets such as logic libraries and information model descriptions, as well as to describe a collection of knowledge assets. Cardinality 0..* Type DomainResource Invariants **Defined on this element ****lib-0 **Warning Name should be usable as an identifier for the module by machine processing applications such as code generation name.matches('[A-Z]([A-Za-z0-9_]){0,254}') **Library.url **Element Id Library.url Definition

An absolute URI that is used to identify this library when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this library is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the library is stored on different servers. Cardinality 0..1 Type uri Requirements

Allows the library to be referenced by a single globally unique identifier. Summary true Comments

Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred. Multiple instances may share the same URL if they have a distinct version.

The determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author. Considerations for making this decision are found in Technical and Business Versions .

In some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the meta.source element to indicate where the current master source of the resource can be found. **Library.identifier **Element Id Library.identifier Definition

A formal identifier that is used to identify this library when it is represented in other formats, or referenced in a specification, model, design or an instance. e.g. CMS or NQF identifiers for a measure artifact. Note that at least one identifier is required for non-experimental active artifacts. Note This is a business identifier, not a resource identifier (see discussion ) Cardinality 0..* Type Identifier Requirements

Allows externally provided and/or usable business identifiers to be easily associated with the module. Summary true Comments

Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this library outside of FHIR, where it is not possible to use the logical URI. **Library.version **Element Id Library.version Definition

The identifier that is used to identify this version of the library when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the library author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence. To provide a version consistent with the Decision Support Service specification, use the format Major.Minor.Revision (e.g. 1.0.0). For more information on versioning knowledge assets, refer to the Decision Support Service specification. Note that a version is required for non-experimental active artifacts. Note This is a business versionId, not a resource version id (see discussion ) Cardinality 0..1 Type string Summary true Comments

There may be different library instances that have the same identifier but different versions. The version can be appended to the url in a reference to allow a reference to a particular business version of the library with the format [url]|[version]. **Library.name **Element Id Library.name Definition

A natural language name identifying the library. This name should be usable as an identifier for the module by machine processing applications such as code generation. Cardinality 0..1 Type string Requirements

Support human navigation and code generation. Summary true Comments

The name is not expected to be globally unique. The name should be a simple alphanumeric type name to ensure that it is machine-processing friendly. Invariants **Affect this element ****inv-0 **Warning Name should be usable as an identifier for the module by machine processing applications such as code generation name.matches('[A-Z]([A-Za-z0-9_]){0,254}') **Library.title **Element Id Library.title Definition

A short, descriptive, user-friendly title for the library. Cardinality 0..1 Type string Summary true Comments

This name does not need to be machine-processing friendly and may contain punctuation, white-space, etc. **Library.subtitle **Element Id Library.subtitle Definition

An explanatory or alternate title for the library giving additional information about its content. Cardinality 0..1 Type string **Library.status **Element Id Library.status Definition

The status of this library. Enables tracking the life-cycle of the content. Cardinality 1..1 Terminology Binding PublicationStatus ( Required ) Type code Is Modifier true (Reason: This is labeled as "Is Modifier" because applications should not use a retired {{title}} without due consideration) Summary true Comments

Allows filtering of libraries that are appropriate for use vs. not. **Library.experimental **Element Id Library.experimental Definition

A Boolean value to indicate that this library is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage. Cardinality 0..1 Type boolean Requirements

Enables experimental content to be developed following the same lifecycle that would be used for a production-level library. Summary true Comments

Allows filtering of librarys that are appropriate for use versus not. **Library.type **Element Id Library.type Definition

Identifies the type of library such as a Logic Library, Model Definition, Asset Collection, or Module Definition. Cardinality 1..1 Terminology Binding LibraryType ( Extensible ) Type CodeableConcept Summary true **Library.subject[x] **Element Id Library.subject[x] Definition

A code or group definition that describes the intended subject of the contents of the library. Cardinality 0..1 Terminology Binding Subject type ( Extensible ) Type CodeableConcept | Reference ( Group ) [x] Note See Choice of Data Types for further information about how to use [x] Meaning if Missing Patient **Library.date **Element Id Library.date Definition

The date (and optionally time) when the library was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the library changes. Cardinality 0..1 Type dateTime Alternate Names Revision Date Summary true Comments

Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the library. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource. **Library.publisher **Element Id Library.publisher Definition

The name of the organization or individual that published the library. Cardinality 0..1 Type string Requirements

Helps establish the "authority/credibility" of the library. May also allow for contact. Summary true Comments

Usually an organization but may be an individual. The publisher (or steward) of the library is the organization or individual primarily responsible for the maintenance and upkeep of the library. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the library. This item SHOULD be populated unless the information is available from context. **Library.contact **Element Id Library.contact Definition

Contact details to assist a user in finding and communicating with the publisher. Cardinality 0..* Type ContactDetail Summary true Comments

May be a web site, an email address, a telephone number, etc. **Library.description **Element Id Library.description Definition

A free text natural language description of the library from a consumer's perspective. Cardinality 0..1 Type markdown Summary true Comments

This description can be used to capture details such as why the library was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the library as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the library is presumed to be the predominant language in the place the library was created). **Library.useContext **Element Id Library.useContext Definition

The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate library instances. Cardinality 0..* Type UsageContext Requirements

Assist in searching for appropriate content. Summary true Comments

When multiple useContexts are specified, there is no expectation that all or any of the contexts apply. **Library.jurisdiction **Element Id Library.jurisdiction Definition

A legal or geographic region in which the library is intended to be used. Cardinality 0..* Terminology Binding Jurisdiction ( Extensible ) Type CodeableConcept Summary true Comments

It may be possible for the library to be used in jurisdictions other than those for which it was originally designed or intended. **Library.purpose **Element Id Library.purpose Definition

Explanation of why this library is needed and why it has been designed as it has. Cardinality 0..1 Type markdown Comments

This element does not describe the usage of the library. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is. This may be used to point to source materials or specifications that drove the structure of this library. **Library.usage **Element Id Library.usage Definition

A detailed description of how the library is used from a clinical perspective. Cardinality 0..1 Type string **Library.copyright **Element Id Library.copyright Definition

A copyright statement relating to the library and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the library. Cardinality 0..1 Type markdown Requirements

Consumers must be able to determine any legal restrictions on the use of the library and/or its content. Alternate Names License; Restrictions **Library.approvalDate **Element Id Library.approvalDate Definition

The date on which the resource content was approved by the publisher. Approval happens once when the content is officially approved for usage. Cardinality 0..1 Type date Comments

The 'date' element may be more recent than the approval date because of minor changes or editorial corrections. **Library.lastReviewDate **Element Id Library.lastReviewDate Definition

The date on which the resource content was last reviewed. Review happens periodically after approval but does not change the original approval date. Cardinality 0..1 Type date Requirements

Gives a sense of how "current" the content is. Resources that have not been reviewed in a long time may have a risk of being less appropriate/relevant. Comments

If specified, this date follows the original approval date. **Library.effectivePeriod **Element Id Library.effectivePeriod Definition

The period during which the library content was or is planned to be in active use. Cardinality 0..1 Type Period Requirements

Allows establishing a transition before a resource comes into effect and also allows for a sunsetting process when new versions of the library are or are expected to be used instead. Summary true Comments

The effective period for a library determines when the content is applicable for usage and is independent of publication and review dates. For example, a measure intended to be used for the year 2016 might be published in 2015. **Library.topic **Element Id Library.topic Definition

Descriptive topics related to the content of the library. Topics provide a high-level categorization of the library that can be useful for filtering and searching. Cardinality 0..* Terminology Binding DefinitionTopic ( Example ) Type CodeableConcept Requirements

Repositories must be able to determine how to categorize the library so that it can be found by topical searches. **Library.author **Element Id Library.author Definition

An individiual or organization primarily involved in the creation and maintenance of the content. Cardinality 0..* Type ContactDetail **Library.editor **Element Id Library.editor Definition

An individual or organization primarily responsible for internal coherence of the content. Cardinality 0..* Type ContactDetail **Library.reviewer **Element Id Library.reviewer Definition

An individual or organization primarily responsible for review of some aspect of the content. Cardinality 0..* Type ContactDetail **Library.endorser **Element Id Library.endorser Definition

An individual or organization responsible for officially endorsing the content for use in some setting. Cardinality 0..* Type ContactDetail **Library.relatedArtifact **Element Id Library.relatedArtifact Definition

Related artifacts such as additional documentation, justification, or bibliographic references. Cardinality 0..* Type RelatedArtifact Requirements

Libraries must be able to provide enough information for consumers of the content (and/or interventions or results produced by the content) to be able to determine and understand the justification for and evidence in support of the content. Comments

Each related artifact is either an attachment, or a reference to another resource, but not both. **Library.parameter **Element Id Library.parameter Definition

The parameter element defines parameters used by the library. Cardinality 0..* Type ParameterDefinition **Library.dataRequirement **Element Id Library.dataRequirement Definition

Describes a set of data that must be provided in order to be able to successfully perform the computations defined by the library. Cardinality 0..* Type DataRequirement **Library.content **Element Id Library.content Definition

The content of the library as an Attachment. The content may be a reference to a url, or may be directly embedded as a base-64 string. Either way, the contentType of the attachment determines how to interpret the content. Cardinality 0..* Type Attachment Summary true