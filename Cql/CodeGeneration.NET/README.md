# Hl7.Cql.CodeGeneration.NET

A support package for HL7.Cql that prints a typed IR (intermediate representation) as C# source code and supports compiling the C# to .NET assemblies.

## Overview

This package provides functionality to generate readable C# source code from the typed IR produced by `Hl7.Cql.Compiler`. It's used in the CQL compilation pipeline to produce human-readable C# code from the compiled CQL expressions and can also generate .NET assemblies from that generated C#.

## Key Features

- **IR to C# Printing**: Transforms the typed IR (carrying `System.Type` on each node) into readable C# source code by direct string emission — no Roslyn syntax-tree construction
- **Nullable-aware generated declarations**: `CSharpConfig.Nullability` selects one of three modes, mirroring the `#nullable` directive the generator emits — `Disabled` (no directive, null-oblivious, as before nullable emission existed), `Annotations` (`#nullable enable annotations`), and `Enabled` (`#nullable enable`, the default). Because the IR stores `System.Type` (which cannot express reference-type nullability), declaration signatures use blanket `T?` annotations for reference types while preserving value-type behavior. A deliberate carve-out keeps generated value-set/code-system/code/concept definition members non-nullable where the generator constructs the value directly. `as`-casts stay unannotated because `as T?` is illegal in C# (CS8651).
- **Code Formatting**: Generates well-formatted, readable C# code
- **Roslyn Integration**: Uses Microsoft.CodeAnalysis.CSharp to compile already-generated C# source text into .NET assemblies
- **Debugging Support**: Generated code includes debugging information, and debugging information is included in the .NET assemblies based on the DebugSymbolsFormat setting

### Why nullability has three modes rather than a switch (#1564)

The value #1564 asks for is an honest **API surface**: a consumer calling a generated library should
see that nearly every CQL value can be null. That is what `Annotations` delivers, and it is cheap —
the annotations follow from the blanket rule and nothing else has to change.

Asking the compiler to *verify* those annotations (`Enabled`) is a much larger commitment, because
the generator then has to emit constructs whose only purpose is to satisfy flow analysis:
null-forgiving operators and nullability-bridging casts. Those are noise in code that is meant to be
readable, and getting them right is not a local problem — nested (generic-argument) nullability is
decided in three places that must agree:

1. generated declarations, from the blanket rule;
2. call-site generic type arguments — which cannot be left unannotated, because C# drops the `?` from
   an unconstrained `T?` on substitution, so `IEnumerable<T?>` only becomes `IEnumerable<X?>` when the
   type argument itself is written `X?`;
3. `ICqlOperators`' own signatures, which today use **both** conventions — 207 members annotate their
   inner generic arguments and about 136 do not.

While (3) is inconsistent, no rule for (1) can agree with it everywhere. Measured on a five-library
probe, blanket annotation leaves 155 CS86xx; deriving declarations from each value's declared
nullability gives 102; explicit casts at the convention boundaries give 106; unannotated type
arguments give 1,327. Each change redistributes the mismatch instead of removing it.

So `Enabled` is the default and is used wherever it is already clean, while
`Demo/Measures.Demo` and `Demo/Measures.dqm-content-qicore-2025` use `Annotations` through their
packager profiles. They still publish honest signatures; they simply do not carry the scaffolding.
Making one convention out of (3) is the prerequisite for turning full checks on everywhere, and is
tracked separately for a future major version.

### Nullability metadata may only be read from assemblies whose annotations do not vary by runtime

`NullabilityInfoContext` reports different nullability for the same declaration on different
frameworks — `List<T>`'s `IEnumerable<T>` constructor parameter is `NotNull` on .NET 8 and `Nullable`
on .NET 10 — so reading framework metadata makes the emitted C# depend on which runtime the packager
ran on. The Packager ships for both, so the same ELM would produce different C#, a golden test could
only pass on one of them, and `GeneratorToolVersion` could not describe two outputs.
`CSharpEmitter.HasStableNullabilityMetadata` excludes `System.*`/`mscorlib`/`netstandard` for that
reason; everything the SDK ships or references is compiled once and is safe.

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