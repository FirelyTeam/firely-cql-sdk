# Hl7.Cql.CodeGeneration.NET

A support package for HL7.Cql that prints a typed IR (intermediate representation) as C# source code and supports compiling the C# to .NET assemblies.

## Overview

This package provides functionality to generate readable C# source code from the typed IR produced by `Hl7.Cql.Compiler`. It's used in the CQL compilation pipeline to produce human-readable C# code from the compiled CQL expressions and can also generate .NET assemblies from that generated C#.

## Key Features

- **IR to C# Printing**: Transforms the typed IR (carrying `System.Type` on each node) into readable C# source code by direct string emission — no Roslyn syntax-tree construction
- **Nullable-aware generated declarations**: Generated `*.g.cs` files emit `#nullable enable` (full nullable checks + annotations). Because the IR stores `System.Type` (which cannot express reference-type nullability), declaration signatures use blanket `T?` annotations for reference types while preserving value-type behavior. A deliberate carve-out keeps generated value-set/code-system/code/concept definition members non-nullable where the generator constructs the value directly. `as`-casts stay unannotated because `as T?` is illegal in C# (CS8651).
- **Code Formatting**: Generates well-formatted, readable C# code
- **Roslyn Integration**: Uses Microsoft.CodeAnalysis.CSharp to compile already-generated C# source text into .NET assemblies
- **Debugging Support**: Generated code includes debugging information, and debugging information is included in the .NET assemblies based on the DebugSymbolsFormat setting

Design note for #1564: generated code compiles under full nullable checking without blanket CS86xx suppression.

## Usage

This package is used internally by the CQL packaging pipeline to generate C# source code that can be included in FHIR Library resources or used for debugging purposes, and can generate .NET assemblies.

## Dependencies

- **Hl7.Cql.Compiler**: CQL compilation services
- **Hl7.Cql.CqlToElm**: CQL to ELM conversion
- **Hl7.Cql.Runtime**: Runtime components
- **Microsoft.CodeAnalysis.CSharp**: Roslyn C# compiler services
- **Microsoft.Extensions.Logging**: Logging framework support

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). For getting started, release notes, and contribution guidelines, see the [main README](../../README.md).