# Hl7.Cql.Model

A support package for HL7.Cql that incorporates CQL model information into the runtime.

## Overview

This package provides model definitions and metadata that enable the CQL runtime to understand and work with different data models, including FHIR and ELM. It contains embedded model information files that describe the structure and types available in supported models.

## Key Features

- **Model Information**: Embedded XML files with model definitions for FHIR and ELM
- **Type Mapping**: Runtime type mapping between CQL types and model types
- **Model Binding**: Integration of model information with CQL runtime
- **FHIR 4.0.1 Support**: Complete model information for FHIR R4
- **ELM R1 Support**: Model information for Expression Logical Model R1

## Embedded Resources

- **FHIR 4.0.1 Model Info**: Complete FHIR R4 model definitions
- **ELM R1 Model Info**: Expression Logical Model definitions

## Usage

This package provides model metadata used by the CQL compiler and runtime to understand the structure of data being processed.

## Dependencies

- **Hl7.Cql.Runtime**: Core CQL runtime components

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). For getting started, release notes, and contribution guidelines, see the [main README](../../README.md).