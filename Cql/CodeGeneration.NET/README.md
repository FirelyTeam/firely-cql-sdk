# Hl7.Cql.CodeGeneration.NET

A support package for HL7.Cql that prints a typed IR (intermediate representation) as C# source code and supports compiling the C# to .NET assemblies.

## Overview

This package provides functionality to generate readable C# source code from the typed IR produced by `Hl7.Cql.Compiler`. It's used in the CQL compilation pipeline to produce human-readable C# code from the compiled CQL expressions and can also generate .NET assemblies from that generated C#.

## Key Features

- **IR to C# Printing**: Transforms the typed IR (carrying `System.Type` on each node) into readable C# source code by direct string emission — no Roslyn syntax-tree construction
- **Nullable-aware generated declarations**: Generated `*.g.cs` files emit `#nullable enable` (full nullable checks + annotations) when `CSharpConfig.NullabilityEnabled` is on, which is the default; with it off the output is null-oblivious, as it was before nullable emission existed. Because the IR stores `System.Type` (which cannot express reference-type nullability), declaration signatures use blanket `T?` annotations for reference types while preserving value-type behavior. A deliberate carve-out keeps generated value-set/code-system/code/concept definition members non-nullable where the generator constructs the value directly. `as`-casts stay unannotated because `as T?` is illegal in C# (CS8651).
- **Code Formatting**: Generates well-formatted, readable C# code
- **Roslyn Integration**: Uses Microsoft.CodeAnalysis.CSharp to compile already-generated C# source text into .NET assemblies
- **Debugging Support**: Generated code includes debugging information, and debugging information is included in the .NET assemblies based on the DebugSymbolsFormat setting

Design notes for #1564:

- Generated code compiles under full nullable checking without blanket CS86xx suppression — for the
  corpora that have it enabled. `Demo/Measures.Demo` and `Demo/Measures.dqm-content-qicore-2025`
  are still generated with `NullabilityEnabled` off through their packager profiles, because blanket
  annotation leaves ~677 CS86xx across them that need the declaration rules to agree across emission
  positions first. They opt back in when that lands.
- **Nullability metadata may only be read from assemblies whose annotations do not vary by runtime.**
  `NullabilityInfoContext` reports different nullability for the same declaration on different
  frameworks — `List<T>`'s `IEnumerable<T>` constructor parameter is `NotNull` on .NET 8 and
  `Nullable` on .NET 10 — so reading framework metadata makes the emitted C# depend on which runtime
  the packager ran on. `CSharpEmitter.HasStableNullabilityMetadata` excludes
  `System.*`/`mscorlib`/`netstandard` for that reason; everything the SDK ships or references is
  compiled once and is safe.

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