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

This package provides everything needed to execute CQL in .NET applications. However, **we strongly recommend using the Invocation Toolkit** (included in the `Hl7.Cql.Invocation` package) rather than directly using the lower-level APIs.

### Recommended: Use the Invocation Toolkit

The Invocation Toolkit provides a simplified, high-level API for working with CQL:

```csharp
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Microsoft.Extensions.Logging;

var loggerFactory = LoggerFactory.Create(b => b.AddConsole());

var cql = (CqlLibraryString)"""
    library MyLibrary version '1.0.0'
    define "Result" : 'Hello from CQL!'
    """;

using var invoker = new CqlToolkit(loggerFactory)
    .AddCqlLibraries(cql)
    .CreateLibrarySetInvoker();

var result = invoker.InvokeLibraryDefinition(
    FhirCqlContext.WithDataSource(),
    cql.LibraryIdentifier,
    "Result");
```

**Why use the Invocation Toolkit?**
- Simplified, fluent API reduces boilerplate code
- Automatic handling of the CQL→ELM→C#→DLL pipeline
- Proper resource management with IDisposable pattern
- Built-in error handling and logging support
- Production-ready with dependency injection support

For more examples, see the [Examples/CqlSdkExamples](../../Examples/CqlSdkExamples) directory.

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). For getting started, release notes, and contribution guidelines, see the [main README](../../README.md). More information can be found at [Firely's documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html).