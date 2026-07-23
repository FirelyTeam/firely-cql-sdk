This page is part of the FHIR Specification (v4.0.1: R4 - Mixed Normative and STU ) in it's permanent home (it will always be available at this URL). The current version which supercedes this version is 5.0.0 . For a full list of available versions, see the Directory of published versions . Page versions: R5 R4B **R4 **R3
- Content
- Examples
- Detailed Descriptions
- Mappings
- Profiles & Extensions
- Operations
- R3 Conversions

## 14.14.6 Resource Measure - Detailed Descriptions
Clinical Quality Information Work Group Maturity Level : 2 Trial Use Security Category : Anonymous Compartments : Not linked to any defined compartments

Detailed Descriptions for the elements in the Measure resource. **Measure **Element Id Measure Definition

The Measure resource provides the definition of a quality measure. Cardinality 0..* Type DomainResource Invariants **Defined on this element ****mea-0 **Warning Name should be usable as an identifier for the module by machine processing applications such as code generation name.matches('[A-Z]([A-Za-z0-9_]){0,254}') **mea-1 **Rule Stratifier SHALL be either a single criteria or a set of criteria components group.stratifier.all((code | description | criteria).exists() xor component.exists()) **Measure.url **Element Id Measure.url Definition

An absolute URI that is used to identify this measure when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this measure is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the measure is stored on different servers. Cardinality 0..1 Type uri Requirements

Allows the measure to be referenced by a single globally unique identifier. Summary true Comments

Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred. Multiple instances may share the same URL if they have a distinct version.

The determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author. Considerations for making this decision are found in Technical and Business Versions .

In some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the meta.source element to indicate where the current master source of the resource can be found. **Measure.identifier **Element Id Measure.identifier Definition

A formal identifier that is used to identify this measure when it is represented in other formats, or referenced in a specification, model, design or an instance. Note This is a business identifier, not a resource identifier (see discussion ) Cardinality 0..* Type Identifier Requirements

Allows externally provided and/or usable business identifiers to be easily associated with the module. Summary true Comments

Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this measure outside of FHIR, where it is not possible to use the logical URI. **Measure.version **Element Id Measure.version Definition

The identifier that is used to identify this version of the measure when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the measure author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence. To provide a version consistent with the Decision Support Service specification, use the format Major.Minor.Revision (e.g. 1.0.0). For more information on versioning knowledge assets, refer to the Decision Support Service specification. Note that a version is required for non-experimental active artifacts. Note This is a business versionId, not a resource version id (see discussion ) Cardinality 0..1 Type string Summary true Comments

There may be different measure instances that have the same identifier but different versions. The version can be appended to the url in a reference to allow a reference to a particular business version of the measure with the format [url]|[version]. **Measure.name **Element Id Measure.name Definition

A natural language name identifying the measure. This name should be usable as an identifier for the module by machine processing applications such as code generation. Cardinality 0..1 Type string Requirements

Support human navigation and code generation. Summary true Comments

The name is not expected to be globally unique. The name should be a simple alphanumeric type name to ensure that it is machine-processing friendly. Invariants **Affect this element ****inv-0 **Warning Name should be usable as an identifier for the module by machine processing applications such as code generation name.matches('[A-Z]([A-Za-z0-9_]){0,254}') **Measure.title **Element Id Measure.title Definition

A short, descriptive, user-friendly title for the measure. Cardinality 0..1 Type string Summary true Comments

This name does not need to be machine-processing friendly and may contain punctuation, white-space, etc. **Measure.subtitle **Element Id Measure.subtitle Definition

An explanatory or alternate title for the measure giving additional information about its content. Cardinality 0..1 Type string **Measure.status **Element Id Measure.status Definition

The status of this measure. Enables tracking the life-cycle of the content. Cardinality 1..1 Terminology Binding PublicationStatus ( Required ) Type code Is Modifier true (Reason: This is labeled as "Is Modifier" because applications should not use a retired {{title}} without due consideration) Summary true Comments

Allows filtering of measures that are appropriate for use versus not. **Measure.experimental **Element Id Measure.experimental Definition

A Boolean value to indicate that this measure is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage. Cardinality 0..1 Type boolean Requirements

Enables experimental content to be developed following the same lifecycle that would be used for a production-level measure. Summary true Comments

Allows filtering of measures that are appropriate for use versus not. **Measure.subject[x] **Element Id Measure.subject[x] Definition

The intended subjects for the measure. If this element is not provided, a Patient subject is assumed, but the subject of the measure can be anything. Cardinality 0..1 Terminology Binding Subject type ( Extensible ) Type CodeableConcept | Reference ( Group ) [x] Note See Choice of Data Types for further information about how to use [x] Meaning if Missing Patient Comments

The subject of the measure is critical in interpreting the criteria definitions, as the logic in the measures is evaluated with respect to a particular subject. This corresponds roughly to the notion of a Compartment in that it limits what content is available based on its relationship to the subject. In CQL, this corresponds to the context declaration. **Measure.date **Element Id Measure.date Definition

The date (and optionally time) when the measure was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the measure changes. Cardinality 0..1 Type dateTime Alternate Names Revision Date Summary true Comments

Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the measure. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource. **Measure.publisher **Element Id Measure.publisher Definition

The name of the organization or individual that published the measure. Cardinality 0..1 Type string Requirements

Helps establish the "authority/credibility" of the measure. May also allow for contact. Summary true Comments

Usually an organization but may be an individual. The publisher (or steward) of the measure is the organization or individual primarily responsible for the maintenance and upkeep of the measure. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the measure. This item SHOULD be populated unless the information is available from context. **Measure.contact **Element Id Measure.contact Definition

Contact details to assist a user in finding and communicating with the publisher. Cardinality 0..* Type ContactDetail Summary true Comments

May be a web site, an email address, a telephone number, etc. **Measure.description **Element Id Measure.description Definition

A free text natural language description of the measure from a consumer's perspective. Cardinality 0..1 Type markdown Summary true Comments

This description can be used to capture details such as why the measure was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the measure as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the measure is presumed to be the predominant language in the place the measure was created). **Measure.useContext **Element Id Measure.useContext Definition

The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate measure instances. Cardinality 0..* Type UsageContext Requirements

Assist in searching for appropriate content. Summary true Comments

When multiple useContexts are specified, there is no expectation that all or any of the contexts apply. **Measure.jurisdiction **Element Id Measure.jurisdiction Definition

A legal or geographic region in which the measure is intended to be used. Cardinality 0..* Terminology Binding Jurisdiction ( Extensible ) Type CodeableConcept Summary true Comments

It may be possible for the measure to be used in jurisdictions other than those for which it was originally designed or intended. **Measure.purpose **Element Id Measure.purpose Definition

Explanation of why this measure is needed and why it has been designed as it has. Cardinality 0..1 Type markdown Comments

This element does not describe the usage of the measure. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is. This may be used to point to source materials or specifications that drove the structure of this measure. **Measure.usage **Element Id Measure.usage Definition

A detailed description, from a clinical perspective, of how the measure is used. Cardinality 0..1 Type string **Measure.copyright **Element Id Measure.copyright Definition

A copyright statement relating to the measure and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the measure. Cardinality 0..1 Type markdown Requirements

Consumers must be able to determine any legal restrictions on the use of the measure and/or its content. Alternate Names License; Restrictions **Measure.approvalDate **Element Id Measure.approvalDate Definition

The date on which the resource content was approved by the publisher. Approval happens once when the content is officially approved for usage. Cardinality 0..1 Type date Comments

The 'date' element may be more recent than the approval date because of minor changes or editorial corrections. **Measure.lastReviewDate **Element Id Measure.lastReviewDate Definition

The date on which the resource content was last reviewed. Review happens periodically after approval but does not change the original approval date. Cardinality 0..1 Type date Requirements

Gives a sense of how "current" the content is. Resources that have not been reviewed in a long time may have a risk of being less appropriate/relevant. Comments

If specified, this date follows the original approval date. **Measure.effectivePeriod **Element Id Measure.effectivePeriod Definition

The period during which the measure content was or is planned to be in active use. Cardinality 0..1 Type Period Requirements

Allows establishing a transition before a resource comes into effect and also allows for a sunsetting process when new versions of the measure are or are expected to be used instead. Summary true Comments

The effective period for a measure determines when the content is applicable for usage and is independent of publication and review dates. For example, a measure intended to be used for the year 2016 might be published in 2015. **Measure.topic **Element Id Measure.topic Definition

Descriptive topics related to the content of the measure. Topics provide a high-level categorization grouping types of measures that can be useful for filtering and searching. Cardinality 0..* Terminology Binding DefinitionTopic ( Example ) Type CodeableConcept Requirements

Repositories must be able to determine how to categorize the measure so that it can be found by topical searches. **Measure.author **Element Id Measure.author Definition

An individiual or organization primarily involved in the creation and maintenance of the content. Cardinality 0..* Type ContactDetail **Measure.editor **Element Id Measure.editor Definition

An individual or organization primarily responsible for internal coherence of the content. Cardinality 0..* Type ContactDetail **Measure.reviewer **Element Id Measure.reviewer Definition

An individual or organization primarily responsible for review of some aspect of the content. Cardinality 0..* Type ContactDetail **Measure.endorser **Element Id Measure.endorser Definition

An individual or organization responsible for officially endorsing the content for use in some setting. Cardinality 0..* Type ContactDetail **Measure.relatedArtifact **Element Id Measure.relatedArtifact Definition

Related artifacts such as additional documentation, justification, or bibliographic references. Cardinality 0..* Type RelatedArtifact Requirements

Measures must be able to provide enough information for consumers of the content (and/or interventions or results produced by the content) to be able to determine and understand the justification for and evidence in support of the content. Comments

Each related artifact is either an attachment, or a reference to another resource, but not both. **Measure.library **Element Id Measure.library Definition

A reference to a Library resource containing the formal logic used by the measure. Cardinality 0..* Type canonical ( Library ) **Measure.disclaimer **Element Id Measure.disclaimer Definition

Notices and disclaimers regarding the use of the measure or related to intellectual property (such as code systems) referenced by the measure. Cardinality 0..1 Type markdown Requirements

Some organizations require that notices and disclosures be included when publishing measures that reference their intellecutal property. Summary true **Measure.scoring **Element Id Measure.scoring Definition

Indicates how the calculation is performed for the measure, including proportion, ratio, continuous-variable, and cohort. The value set is extensible, allowing additional measure scoring types to be represented. Cardinality 0..1 Terminology Binding MeasureScoring ( Extensible ) Type CodeableConcept Summary true **Measure.compositeScoring **Element Id Measure.compositeScoring Definition

If this is a composite measure, the scoring method used to combine the component measures to determine the composite score. Cardinality 0..1 Terminology Binding CompositeMeasureScoring ( Extensible ) Type CodeableConcept Summary true **Measure.type **Element Id Measure.type Definition

Indicates whether the measure is used to examine a process, an outcome over time, a patient-reported outcome, or a structure measure such as utilization. Cardinality 0..* Terminology Binding MeasureType ( Extensible ) Type CodeableConcept Summary true **Measure.riskAdjustment **Element Id Measure.riskAdjustment Definition

A description of the risk adjustment factors that may impact the resulting score for the measure and how they may be accounted for when computing and reporting measure results. Cardinality 0..1 Type string Summary true Comments

Describes the method of adjusting for clinical severity and conditions present at the start of care that can influence patient outcomes for making valid comparisons of outcome measures across providers. Indicates whether a measure is subject to the statistical process for reducing, removing, or clarifying the influences of confounding factors to allow for more useful comparisons. **Measure.rateAggregation **Element Id Measure.rateAggregation Definition

Describes how to combine the information calculated, based on logic in each of several populations, into one summarized result. Cardinality 0..1 Type string Summary true Comments

The measure rate for an organization or clinician is based upon the entities’ aggregate data and summarizes the performance of the entity over a given time period (e.g., monthly, quarterly, yearly). The aggregated data are derived from the results of a specific measure algorithm and, if appropriate, the application of specific risk adjustment models. Can also be used to describe how to risk adjust the data based on supplemental data elements described in the eMeasure (e.g., pneumonia hospital measures antibiotic selection in the ICU versus non-ICU and then the roll-up of the two). This could be applied to aggregated cohort measure definitions (e.g., CDC's aggregate reporting for TB at the state level). **Measure.rationale **Element Id Measure.rationale Definition

Provides a succinct statement of the need for the measure. Usually includes statements pertaining to importance criterion: impact, gap in care, and evidence. Cardinality 0..1 Type markdown Requirements

Measure developers need to be able to provide a detailed description of the purpose of the measure. This element provides detailed rationale, where the purpose element provides a summary of the rationale. Summary true **Measure.clinicalRecommendationStatement **Element Id Measure.clinicalRecommendationStatement Definition

Provides a summary of relevant clinical guidelines or other clinical recommendations supporting the measure. Cardinality 0..1 Type markdown Summary true **Measure.improvementNotation **Element Id Measure.improvementNotation Definition

Information on whether an increase or decrease in score is the preferred result (e.g., a higher score indicates better quality OR a lower score indicates better quality OR quality is within a range). Cardinality 0..1 Terminology Binding MeasureImprovementNotation ( Required ) Type CodeableConcept Requirements

Measure consumers and implementers must be able to determine how to interpret a measure score. Summary true **Measure.definition **Element Id Measure.definition Definition

Provides a description of an individual term used within the measure. Cardinality 0..* Type markdown Requirements

Measure developers must be able to provide precise definitions of terms used within measure descriptions and guidance to help communicate the intent of the measure. Summary true **Measure.guidance **Element Id Measure.guidance Definition

Additional guidance for the measure including how it can be used in a clinical context, and the intent of the measure. Cardinality 0..1 Type markdown Requirements

Measure developers must be able to provide additional guidance for implementers to understand the intent with greater specificity than that provided in the population criteria of the measure. This element provides detailed guidance, where the usage element provides a summary of the guidance. Summary true **Measure.group **Element Id Measure.group Definition

A group of population criteria for the measure. Cardinality 0..* **Measure.group.code **Element Id Measure.group.code Definition

Indicates a meaning for the group. This can be as simple as a unique identifier, or it can establish meaning in a broader context by drawing from a terminology, allowing groups to be correlated across measures. Cardinality 0..1 Type CodeableConcept **Measure.group.description **Element Id Measure.group.description Definition

The human readable description of this population group. Cardinality 0..1 Type string **Measure.group.population **Element Id Measure.group.population Definition

A population criteria for the measure. Cardinality 0..* **Measure.group.population.code **Element Id Measure.group.population.code Definition

The type of population criteria. Cardinality 0..1 Terminology Binding MeasurePopulationType ( Extensible ) Type CodeableConcept **Measure.group.population.description **Element Id Measure.group.population.description Definition

The human readable description of this population criteria. Cardinality 0..1 Type string **Measure.group.population.criteria **Element Id Measure.group.population.criteria Definition

An expression that specifies the criteria for the population, typically the name of an expression in a library. Cardinality 1..1 Type Expression Comments

In the case of a continuous-variable or ratio measure, this may be the name of a function that calculates the value of the individual observation for each patient or event in the population. For these types of measures, individual observations are reported as observation resources included in the evaluatedResources bundle for each patient. See the MeasureReport resource or the Quality Reporting topic for more information. **Measure.group.stratifier **Element Id Measure.group.stratifier Definition

The stratifier criteria for the measure report, specified as either the name of a valid CQL expression defined within a referenced library or a valid FHIR Resource Path. Cardinality 0..* **Measure.group.stratifier.code **Element Id Measure.group.stratifier.code Definition

Indicates a meaning for the stratifier. This can be as simple as a unique identifier, or it can establish meaning in a broader context by drawing from a terminology, allowing stratifiers to be correlated across measures. Cardinality 0..1 Type CodeableConcept **Measure.group.stratifier.description **Element Id Measure.group.stratifier.description Definition

The human readable description of this stratifier criteria. Cardinality 0..1 Type string **Measure.group.stratifier.criteria **Element Id Measure.group.stratifier.criteria Definition

An expression that specifies the criteria for the stratifier. This is typically the name of an expression defined within a referenced library, but it may also be a path to a stratifier element. Cardinality 0..1 Type Expression **Measure.group.stratifier.component **Element Id Measure.group.stratifier.component Definition

A component of the stratifier criteria for the measure report, specified as either the name of a valid CQL expression defined within a referenced library or a valid FHIR Resource Path. Cardinality 0..* Comments

Stratifiers are defined either as a single criteria, or as a set of component criteria. **Measure.group.stratifier.component.code **Element Id Measure.group.stratifier.component.code Definition

Indicates a meaning for the stratifier component. This can be as simple as a unique identifier, or it can establish meaning in a broader context by drawing from a terminology, allowing stratifiers to be correlated across measures. Cardinality 0..1 Type CodeableConcept **Measure.group.stratifier.component.description **Element Id Measure.group.stratifier.component.description Definition

The human readable description of this stratifier criteria component. Cardinality 0..1 Type string **Measure.group.stratifier.component.criteria **Element Id Measure.group.stratifier.component.criteria Definition

An expression that specifies the criteria for this component of the stratifier. This is typically the name of an expression defined within a referenced library, but it may also be a path to a stratifier element. Cardinality 1..1 Type Expression **Measure.supplementalData **Element Id Measure.supplementalData Definition

The supplemental data criteria for the measure report, specified as either the name of a valid CQL expression within a referenced library, or a valid FHIR Resource Path. Cardinality 0..* Comments

Note that supplemental data are reported as observations for each patient and included in the evaluatedResources bundle. See the MeasureReport resource or the Quality Reporting topic for more information. **Measure.supplementalData.code **Element Id Measure.supplementalData.code Definition

Indicates a meaning for the supplemental data. This can be as simple as a unique identifier, or it can establish meaning in a broader context by drawing from a terminology, allowing supplemental data to be correlated across measures. Cardinality 0..1 Type CodeableConcept **Measure.supplementalData.usage **Element Id Measure.supplementalData.usage Definition

An indicator of the intended usage for the supplemental data element. Supplemental data indicates the data is additional information requested to augment the measure information. Risk adjustment factor indicates the data is additional information used to calculate risk adjustment factors when applying a risk model to the measure calculation. Cardinality 0..* Terminology Binding MeasureDataUsage ( Extensible ) Type CodeableConcept **Measure.supplementalData.description **Element Id Measure.supplementalData.description Definition

The human readable description of this supplemental data. Cardinality 0..1 Type string **Measure.supplementalData.criteria **Element Id Measure.supplementalData.criteria Definition

The criteria for the supplemental data. This is typically the name of a valid expression defined within a referenced library, but it may also be a path to a specific data element. The criteria defines the data to be returned for this element. Cardinality 1..1 Type Expression