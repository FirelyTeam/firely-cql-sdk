Publication Build: This will be filled in by the publication tooling

## Appendix C - Reference Implementations
*Page standards status: *Informative Maturity Level : N/A


- CQL-ELM Translator Reference Implementation
- CQL Execution Framework Reference Implementation
- Other CQL-related Tools
- Formatting and Usage

As part of the Clinical Quality Framework effort, reference implementations of a CQL-to-ELM translator, a native ELM execution engine, and other CQL-related tools are maintained. This appendix provides a brief overview of where to find more information on these reference implementations.

### CQL-ELM Translator Reference Implementation


The CQL-to-ELM Translator is a reference implementation for the translation of text-based CQL library documents into an XML or JSON representation using the ELM. In addition to being developed and used as part of CQF pilots, the translator has been integrated into production authoring environments for both Clinical Decision Support and Clinical Quality Measurement. The implementation can also be used as the first step in a process to enable distribution, translation, execution, and integration of CQL-based quality artifacts.

The CQL-to-ELM Translator is licensed under the open source Apache Version 2.0 license, and available as part of the clinical_quality_language project on GitHub: https://github.com/cqframework/clinical_quality_language, as well as a Maven Package ( Snapshots ).

For an overview of the project, along with current status, refer to the following document:

https://github.com/cqframework/clinical_quality_language/blob/master/Src/java/cql-to-elm/OVERVIEW.md

### CQL Execution Framework Reference Implementation


A reference implementation for executing CQL is currently under development. This reference implementation was used in CQF pilots and has been integrated into production eCQM testing tools.

The CQL execution framework is licensed under the open source Apache Version 2.0 license, and available as part of the clinical_quality_language project on GitHub: https://github.com/cqframework/cql-execution.

For an overview of the project along with current status, refer to the following document:

https://github.com/cqframework/cql-execution/blob/master/OVERVIEW.md

### Other CQL-related Tools


Other CQL-related tools such as a graphical CQL grammar parsetree viewer, a ModelInfo generator, and a CQL syntax highlighting plugin for Atom are also available. The Clinical Quality Framework Initiative maintains a list of known Community Projects on the CQL Github Wiki:

https://github.com/cqframework/clinical_quality_language/wiki/Community-Projects

#### CQL-to-ELM Translator and Formatter

- https://github.com/cqframework/clinical_quality_language: CQL-to-ELM Translator

#### JavaScript Execution Engine

- https://github.com/cqframework/cql-execution: Java-Script Execution Engine
- https://github.com/cqframework/cql-exec-fhir: A FHIR data source provider for the CQL Execution framework
- https://github.com/cqframework/cql-exec-vsac: A VSAC-enabled value set provider for the CQL Execution framework
- https://github.com/cqframework/cql-exec-examples: Simple examples demonstrating how to use cql-execution, cql-exec-fhir, and cql-exec-vsac

#### CQL Translation Service

- https://github.com/cqframework/cql-translation-service: RESTful service for translating CQL to ELM

#### Java Execution Engine

- https://github.com/dbcg/cql_engine

#### CQL Execution Service

- https://github.com/dbcg/cql_execution_service
- https://github.com/AHRQ-CDS/AHRQ-CDS-Connect-CQL-SERVICES: Expose CQL via Custom-API or CDS Hooks interface (built on JavaScript CQL Execution Engine)

#### Atom Plugin

- https://github.com/cqframework/atom-cql-support

#### CDS Connect

- https://cds.ahrq.gov/: Repository of CDS including CQL-based artifacts
- https://cds.ahrq.gov/authoring/: CDS Authoring Tool capable of exporting FHIR-based CQL logic
- https://github.com/AHRQ-CDS/AHRQ-CDS-Connect-Authoring-Tool: CDS Authoring Tool Source Code

#### CQL Testing

- https://github.com/AHRQ-CDS/CQL-Testing-Framework

#### CQL Server-side Functionality

- https://github.com/samply/blaze: A FHIR® server with internal, fast CQL Evaluation Engine
- https://github.com/dbcg/cqf-ruler: HAPI FHIR server plugin to enable CQL evaluation and Clinical Reasoning functionality
- https://github.com/PheMA/cql-on-omop: Translates CQL (ELM) to OMOP for evaluation against an OHDSI repository

#### CQL Tooling

- https://github.com/cqframework/cqf-tooling: Tooling to support CQL library tooling and other handy utilities related to CQL-based FHIR content

### Formatting and Usage


Because of the flexibility and broad applicability of CQL, it necessarily covers a breadth of topics. The Clinical Quality Framework Initiative provides recommendations and guidance to ensure consistent and appropriate use of CQL in the following wiki:
- https://github.com/cqframework/CQL-Formatting-and-Usage-Wiki/wiki/Formatting-and-Usage-Topics