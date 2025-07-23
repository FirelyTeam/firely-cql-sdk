# Hl7.Cql.Model

CQL Model abstractions for working with CQL data models.

## Overview

This package provides abstractions for CQL models and contains embedded model information for FHIR and ELM. It enables the CQL engine to understand and work with different data model structures.

## Key Features

- **Model Abstractions**: Core abstractions for CQL data models
- **FHIR 4.0.1 Model Info**: Complete model information for FHIR R4
- **ELM R1 Model Info**: Model information for Expression Logical Model R1
- **Embedded Resources**: Model definition files embedded as resources
- **Type Mapping**: Support for mapping between CQL types and model types

## Embedded Model Information

- **FHIR 4.0.1**: Complete FHIR R4 model definitions (`fhir-modelinfo-4.0.1.xml`)
- **ELM R1**: Expression Logical Model definitions (`elm-modelinfo-r1.xml`)

## Usage

This package provides the foundational model information needed by the CQL engine to understand data structures:

```csharp
// Model information is automatically loaded and used
// by CQL components during compilation and execution
```

## Use Cases

- Providing model metadata to the CQL compiler
- Runtime type resolution and validation
- Supporting multiple data models in CQL expressions
- Model-aware code generation and optimization

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). More information can be found at [Firely's documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html).