# Hl7.Cql.Invocation

A support package for HL7.Cql that contains functionality to invoke CQL from libraries.

## Overview

This package provides high-level APIs for invoking CQL libraries and expressions through the **Invocation Toolkit**. It simplifies the process of loading, compiling, and executing CQL libraries in .NET applications, and is the **recommended way** to work with CQL libraries in production applications.

## Key Features

- **Invocation Toolkit**: Fluent, builder-style API for CQL execution
- **Library Loading**: Load and manage CQL libraries from various sources (strings, files, directories, FHIR resources)
- **Expression Invocation**: Execute specific CQL expressions and functions with type-safe parameter passing
- **Context Management**: Handle execution context and parameter passing seamlessly
- **Result Processing**: Process and return CQL execution results with error handling
- **Integration Pipeline**: Combines CQL→ELM→C#→DLL compilation and packaging functionality
- **FHIR Resource Support**: Load libraries from packaged FHIR Library resources

## Why Use the Invocation Toolkit?

The Invocation Toolkit provides several advantages over direct usage of lower-level APIs:

1. **Simplified API**: Reduces boilerplate code with a fluent interface
2. **Automatic Pipeline Management**: Handles the complete CQL→ELM→C#→DLL pipeline automatically
3. **Resource Management**: Proper lifecycle management with IDisposable pattern
4. **Error Handling**: Built-in error handling with configurable continuation policies
5. **Logging Support**: Integrated logging throughout the execution pipeline
6. **Production Ready**: Designed for production use with dependency injection support

## Usage

### Basic Example: Invoke a Simple CQL Expression

```csharp
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Microsoft.Extensions.Logging;

// Create a CQL toolkit with logging
var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
var cqlToolkit = new CqlToolkit(loggerFactory);

// Define your CQL
var cql = (CqlLibraryString)"""
    library HelloWorld version '1.0.0'
    define "Greeting" : 'Hello from CQL!'
    """;

// Add the CQL library and create an invoker
using var librarySetInvoker = cqlToolkit
    .AddCqlLibraries(cql)
    .CreateLibrarySetInvoker();

// Create a CQL context with FHIR data
var cqlContext = FhirCqlContext.WithDataSource();

// Invoke the definition
var result = librarySetInvoker.InvokeLibraryDefinition(
    cqlContext: cqlContext,
    libraryIdentifier: cql.LibraryIdentifier,
    definitionSignature: "Greeting");

Console.WriteLine(result); // Output: Hello from CQL!
```

### Example: Loading from FHIR Resources

```csharp
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;

// Create an invocation toolkit
var invocationToolkit = new InvocationToolkit();

// Load libraries from a directory of FHIR resources
invocationToolkit.AddAssemblyBinariesInFhirLibrariesFromDirectory(
    new DirectoryInfo("path/to/fhir/resources"));

// Create the library set invoker
using var librarySetInvoker = invocationToolkit.CreateLibrarySetInvoker();

// Execute all expressions
var results = librarySetInvoker
    .SelectExpressions()
    .SelectResults(cqlContext)
    .ToList();
```

### Example: Using Parameters and Arguments

```csharp
// CQL with a parameter
var cql = (CqlLibraryString)"""
    library ParameterExample version '1.0.0'
    parameter PatientId String
    define "Message" : 'Patient ID: ' + PatientId
    """;

using var librarySetInvoker = cqlToolkit
    .AddCqlLibraries(cql)
    .CreateLibrarySetInvoker();

// Pass parameters in the context
var cqlContext = FhirCqlContext.WithDataSource(
    parameters: new Dictionary<string, object>
    {
        { "PatientId", "patient-123" }
    });

var result = librarySetInvoker.InvokeLibraryDefinition(
    cqlContext: cqlContext,
    libraryIdentifier: cql.LibraryIdentifier,
    definitionSignature: "Message");
```

For comprehensive examples, see the [Examples/CqlSdkExamples](../../Examples/CqlSdkExamples) directory in the repository.

## Dependencies

- **CodeGeneration.NET**: .NET code generation utilities
- **Hl7.Cql.CqlToElm**: CQL to ELM conversion
- **Hl7.Cql.Packaging**: CQL packaging functionality

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). For getting started, release notes, and contribution guidelines, see the [main README](../../README.md). More information can be found at [Firely's documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html).