Publication Build: This will be filled in by the publication tooling

## Physical Representation
*Page standards status: *Normative Maturity Level : N


- Schemata
- Library References
- Data Model References

The physical representation for CQL is specifically concerned with communicating the logic involved in any given artifact. As discussed in the previous sections, the unit of distribution for CQL is the library, which corresponds to a single file of CQL at the author level, or a single ELM document at the physical level.

### Schemata


The physical representation is simply a set of XML schemata which define XML types for each class defined in the ELM UML model. A CQL physical library is then an ELM document with a single *Library *element as the root.

The physical representation for ELM is defined by the following schemata:

Schema Description **expression.xsd **Defines expression logic components without reference to clinically relevant constructs **clinicalexpression.xsd **Introduces expression components that contain clinically-relevant constructs **library.xsd **Defines the overall library container for ELM

Table 7‑A - The schemata that defines the ELM physical representation

As with the logical portion of the specification, this documentation is intended to provide an overview only, the schemata are the actual specification and should be considered the source of truth.

#### Media Types and Namespaces


The schema for ELM is described for XML using the above XSDs. To support multiple serialization formats, the following media types and namespaces are defined: Content Type Description **text/cql **The content is a text document containing CQL **text/cql-identifier **The content is plain text, containing only the name of a top-level CQL construct such as an expression definition **text/cql-expression **The content is plain text, containing only a single expression (i.e. a string that can be parsed using the `expression`production rule of the grammar) **application/elm+xml **The content is an ELM document, rendered as XML **application/elm+json **The content is an ELM document, rendered as JSON

Optionally, a version parameter can be used with CQL and ELM media types to indicate the specification version of the content. The value of the version parameter is always and only the major and minor components of the version of the CQL specification, and can reference any published version of the specification, currently 1.0, 1.1, 1.2, 1.3, 1.4, and 1.5.

For example, to specify that a library is CQL version 1.4, the following content type would be used:
```
text/cql; version=1.4

```


Implementations consuming CQL or ELM that has a version indicated by the content type in this way should respect the version specified. Implementations should deal gracefully when processing CQL for versions they do not understand, but this is an implementation decision, especially given the backwards-compatible and future-compatible possibilities of CQL and ELM.
>

The text/cql-identifier and text/cql-expression media types, as well as use of the version parameter with all the media types, are new features being introduced in CQL 1.5, and are trial-use. Namespace Description **urn:hl7-org:elm:r1 **The URI for ELM **urn:hl7-org:cql:r1 **The URI for CQL

When serializing an ELM document using JSON, each XML element is serialized as a JSON object, according to the following rules:
- XML elements and attributes are serialized as JSON attributes of the same name.
- When necessary to distinguish the type of an object, an extra “type” attribute is added to the JSON representation which contains the name of the ELM class represented by the JSON data.
- XML namespaces are serialized using curly braces. E.g. "t:Integer" in XML becomes "{urn:hl7-org:elm-types:r1}Integer" in JSON.
- Mixed content serialization is not supported, ELM XML documents should not contain mixed content.

### Library References


The implementation environment must provide a mechanism for library references to be resolved based on their names and versions.

### Data Model References


In addition, the implementation environment must provide a mechanism for data model references to be resolved. At a minimum, the data model definition must define the structure of all the types available within the data model, generally by providing an XSD or similar class structure definition. If the implementation environment is only concerned with translation or execution of ELM documents, then the type structures for each data model are sufficient. However, to fully enable the authoring features of CQL syntax, the data model reference must also define the following:

Component Description **Name **The name of the model. **Version **The version of the model. **URL **The XML namespace associated with the model. This namespace is used by the CQL-to-ELM translator to establish the URL used to reference types from the model schema within an ELM document. **Schema Location **The physical location of the model xsd relative to the ELM document. This information can be provided, but is not required. **Target Qualifier **If specified, determines the namespace qualifier that should be used when referencing types of the data model within the ELM document. **Context Information **The set of available contexts that may be used with the model. For patient contexts, Patient Birth Date information must be supplied as well to allow the CQL-to-ELM translator to render references to patient-age-related functions (AgeInYears, AgeInYearsAt, etc.) into the non-patient-aware age-related functions in ELM (CalculateAgeInYears, CalculateAgeInYearsAt, etc.). This information is not required, but if it is not present, references to patient-age-related functions will be passed directly through to ELM as FunctionRefs.

Table 7‑B - The data model reference required components

For each type available in the data model, the following information should be provided:

Component Description **Name **The name of the type within the data model. This corresponds to the name of the class within the class model, or the name of the type in the case of an xsd. In FHIR, for example, this corresponds to the name of the underlying resource. **Identifier **A unique identifier for the class that may be independent of the name. In FHIR, for example, this corresponds to the profile identifier. **Label **This information specifies the name of the type as it is referenced from CQL. Note that this need not be a language-valid identifier, as CQL allows quoted-identifiers to be used. However, the label must be unique. In the simplest case, the label corresponds directly with the class name. Whether or not a label is provided, a class can still be referenced from CQL by its name. **Primary Code Filter **If the type has the notion of a primary code filter (e.g., Encounter), the name of the attribute that is to be used if no code filter attribute is named within a retrieve **Retrievable **A boolean flag indicating whether the class can be referenced as a topic in a retrieve. If this flag is not set, values of this class cannot be retrieved directly, but may still be accessible as elements of other class values. **Context Relationships **Information about how the data for this type relates to contexts defined in the model. For example, for a Patient context, models may contain a PatientId, providing the linkage to a Patient context. **Target Context Relationships **If applicable, information about how the data for this type can be used to reference contexts. For example, for a RelatedPerson type, the model may contain a LinkedPatientId, providing a reference to a Patient context that can be used in a related-context retrieve.

Table 7‑C - The required information for each type available in the data model

The information defined here is formally described in the modelinfo.xsd document included in the specification. The QUICK module in the CQL-to-ELM translator contains an instance of this schema, quick-modelinfo.xml, which defines this metadata for the QUICK model.
>

Note that the actual model info definition and associated artifacts are part of the reference implementation for CQL and not a normative aspect of the CQL specification. CQL only specifies the expected behavior at the conceptual level. How that behavior is achieved with respect to any particular data model is an implementation aspect and not prescribed by this specification.