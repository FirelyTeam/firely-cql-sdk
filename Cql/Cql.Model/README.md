# Hl7.Cql.Model

A support package for HL7.Cql that incorporates CQL model information into the runtime.

## Overview

This package provides model definitions and metadata that enable the CQL runtime to understand and work with different data models, including FHIR and ELM. It contains embedded model information files that describe the structure and types available in supported models.

## Key Features

- **Model Information**: Embedded XML files with model definitions for FHIR, QICore, US Core and ELM
- **Type Mapping**: Runtime type mapping between CQL types and model types
- **Model Binding**: Integration of model information with CQL runtime
- **FHIR 4.0.1 Support**: Complete model information for FHIR R4
- **QICore and US Core Support**: Model information for QICore 4.1.1 and 6.0.0, and the US Core versions they build on (3.1.1 and 6.1.0)
- **ELM R1 Support**: Model information for Expression Logical Model R1

## Embedded Resources

- **FHIR 4.0.1 Model Info**: Complete FHIR R4 model definitions
- **QICore 4.1.1 and 6.0.0 Model Infos**: QI-Core profile model definitions
- **US Core 3.1.1 and 6.1.0 Model Infos**: US Core profile model definitions, used together with QICore 4.1.1 and 6.0.0 respectively
- **ELM R1 Model Info**: Expression Logical Model definitions

The QICore and US Core model infos are unmodified copies of the ones in the `quick` artifact of the Java [CQL tooling](https://github.com/cqframework/clinical_quality_language), at the version pinned in [`Demo/Cql/Build/pom.xml`](../../Demo/Cql/Build/pom.xml). Translating CQL against them is opt-in: select them through the `CqlModel` members of `Hl7.Cql.CqlToElm` (`QICore411`, `USCore311`, `QICore600`, `USCore610`).

## Usage

This package provides model metadata used by the CQL compiler and runtime to understand the structure of data being processed.

## Dependencies

- **Hl7.Cql.Runtime**: Core CQL runtime components

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). For getting started, release notes, and contribution guidelines, see the [main README](../../README.md).