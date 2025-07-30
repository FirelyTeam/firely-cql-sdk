# Hl7.Cql

The main package for evaluating logic in the HL7 CQL language.

## Overview

This is the primary package of the Firely CQL SDK that provides a comprehensive platform for evaluating Clinical Quality Language (CQL) logic. It aggregates all the core components needed for CQL execution in .NET applications.

## Key Features

- **Complete CQL Engine**: Full implementation of the CQL specification
- **ELM Processing**: Support for Expression Logical Model execution
- **FHIR Integration**: Direct integration with FHIR data models
- **Code Generation**: Ability to compile CQL to .NET assemblies
- **Runtime Execution**: High-performance CQL expression evaluation
- **Model Binding**: Support for multiple data models (FHIR, custom models)

## Components Included

This package includes all core CQL functionality by referencing:

- **Hl7.Cql.Abstractions**: Core interfaces and abstractions
- **Hl7.Cql.Compiler**: ELM to .NET compilation
- **Hl7.Cql.Runtime**: Runtime execution engine
- **Hl7.Cql.Model**: Model definitions and metadata
- **Hl7.Cql.Firely**: FHIR integration layer
- **Hl7.Cql.Invocation**: High-level invocation APIs
- **Hl7.Cql.Elm**: ELM abstractions and utilities
- **CodeGeneration.NET**: C# code generation
- **Iso8601**: ISO 8601 date/time support

## Usage

This package provides everything needed to execute CQL in .NET applications.

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). For getting started, release notes, and contribution guidelines, see the [main README](../../README.md). More information can be found at [Firely's documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html).