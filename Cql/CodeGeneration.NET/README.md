# Hl7.Cql.CodeGeneration.NET

A support package for HL7.Cql that converts .NET lambda expressions into C# source code and supports compiling the C# to .NET assemblies.

## Overview

This package provides functionality to generate readable C# source code from .NET Expression objects. It's used in the CQL compilation pipeline to produce human-readable C# code from the compiled CQL expressions and can also generate .NET assemblies from that generated C#.

## Key Features

- **Expression to C# Conversion**: Transforms .NET Expression trees into readable C# source code
- **Code Formatting**: Generates well-formatted, readable C# code
- **Roslyn Integration**: Uses Microsoft.CodeAnalysis.CSharp for syntax tree generation
- **Lambda Expression Support**: Full support for converting lambda expressions
- **Debugging Support**: Generated code includes debugging information, and debugging information is included in the .NET assemblies based on the DebugSymbolsFormat setting

## Usage

This package is used internally by the CQL packaging pipeline to generate C# source code that can be included in FHIR Library resources or used for debugging purposes, and can generate .NET assemblies.

## Dependencies

- **Hl7.Cql.Compiler**: CQL compilation services
- **Hl7.Cql.CqlToElm**: CQL to ELM conversion
- **Hl7.Cql.Runtime**: Runtime components
- **Microsoft.CodeAnalysis.CSharp**: Roslyn C# compiler services
- **Microsoft.Extensions.Logging**: Logging framework support

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). More information can be found at [Firely's documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html).