# Hl7.Cql.CqlToElm

A support package for HL7.Cql that contains functionality to convert CQL to ELM.

## Overview

This package provides the conversion functionality that transforms Clinical Quality Language (CQL) source code into Expression Logical Model (ELM) representation. This is a critical step in the CQL compilation pipeline.

## Key Features

- **CQL to ELM Conversion**: Complete conversion from CQL text to ELM JSON
- **Syntax Analysis**: Parse and analyze CQL syntax using ANTLR4 grammar
- **Error Handling**: Comprehensive error reporting for CQL syntax and semantic issues
- **Model Integration**: Integration with CQL model information for type checking
- **Configuration Support**: Configurable conversion options and settings

## Conversion Process

1. **Parsing**: Uses ANTLR4 grammar to parse CQL text into abstract syntax trees
2. **Semantic Analysis**: Validates semantics and resolves references
3. **ELM Generation**: Converts AST into ELM JSON representation
4. **Validation**: Ensures generated ELM is valid and complete

## Usage

This package is used in the CQL compilation pipeline to convert CQL source to ELM:

```csharp
// Used by packaging tools and CLI to convert
// CQL source files into ELM JSON representation
```

## Dependencies

- **Hl7.Cql.Model**: Model definitions and metadata
- **Hl7.Cql.Runtime**: Runtime components for type resolution
- **Elm**: ELM abstractions and utilities
- **Iso8601**: ISO 8601 date/time handling
- **Hl7.Cql.Grammar**: CQL grammar and parsing components
- **Microsoft.Extensions.Configuration**: Configuration framework
- **Microsoft.Extensions.DependencyInjection**: Dependency injection
- **Microsoft.Extensions.Logging**: Logging framework

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). More information can be found at [Firely's documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html).