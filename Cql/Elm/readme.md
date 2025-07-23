# Hl7.Cql.Elm

A support package for HL7.Cql that contains abstractions for the Expression Logical Model (ELM) and utilities to deserialize an ELM library into classes.

## Overview

This package provides the core abstractions and utilities for working with Expression Logical Model (ELM) in the CQL SDK. ELM is the intermediate representation that CQL expressions are compiled into before being executed.

## Key Features

- **ELM Abstractions**: Core classes and interfaces for ELM representation
- **Deserialization Utilities**: Tools for deserializing ELM JSON into .NET objects
- **Library Management**: Support for loading and managing ELM libraries
- **JSON Support**: Built-in support for ELM JSON format
- **Code Analysis Integration**: Integration with Roslyn for code analysis scenarios

## Usage

This package provides the foundation for working with ELM in the CQL compilation and execution pipeline:

```csharp
// Used to deserialize ELM JSON into .NET objects
// and work with ELM abstractions in the compilation pipeline
```

## Dependencies

- **Hl7.Cql.Firely**: FHIR integration components
- **Hl7.Cql.Model**: Model definitions and metadata
- **Microsoft.CodeAnalysis.CSharp**: Roslyn C# compiler services
- **System.Text.Json**: JSON serialization support

## Use Cases

- Loading ELM libraries from JSON files
- Converting ELM expressions into executable code
- Analyzing and transforming ELM structures
- Integrating ELM processing with code generation

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). More information can be found at [Firely's documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html).