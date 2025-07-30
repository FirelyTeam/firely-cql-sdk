# Hl7.Cql.Elm

A support package for HL7.Cql that contains ELM (Expression Logical Model) abstractions and deserialization utilities.

## Overview

This package provides the ELM object model and utilities for working with ELM documents. ELM is the intermediate representation used by CQL - Clinical Quality Language expressions are compiled into ELM format before being executed by the CQL runtime.

## Key Features

- **ELM Object Model**: Complete object model for ELM specifications
- **JSON Deserialization**: Load ELM libraries from JSON format
- **Type System**: ELM type specifications and validation
- **Expression Trees**: All ELM expression types and operators
- **Library Management**: ELM library loading and dependency resolution
- **Error Handling**: Comprehensive error reporting for ELM processing

## Usage

This package provides the foundational ELM types and utilities used by the CQL compilation and runtime systems.

## Use Cases

- Loading compiled CQL libraries in ELM format
- ELM document validation and processing
- Building tools that work with ELM representations
- CQL compiler output handling

## Dependencies

- **Hl7.Cql.Runtime**: CQL runtime type definitions

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). More information can be found at [Firely's documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html).