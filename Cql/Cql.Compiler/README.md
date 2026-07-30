# Hl7.Cql.Compiler

A support package for HL7.Cql that translates ELM into a typed intermediate representation (IR) and can emit that IR as C# source code.

## Overview

This package provides the compilation infrastructure that converts ELM (Expression Logical Model) representations into C# source code. It serves as the bridge between the logical CQL expressions and the generated C# that is later compiled into a .NET assembly.

## Key Features

- **ELM to Typed IR**: Converts ELM JSON into a small set of typed IR nodes (carrying `System.Type`) that model C# code constructs
- **C# Code Generation**: Emits human-readable C# source code directly from the typed IR
- **Operator Binding**: Maps CQL operators to their .NET runtime implementations
- **Expression Building Context**: Manages compilation state and dependencies

## Usage

This package is primarily used by the CQL packager and other compilation tools to transform CQL logic into executable .NET code.

## Dependencies

- **Hl7.Cql.Model**: CQL model definitions
- **Hl7.Cql.Runtime**: Runtime execution components
- **Elm**: ELM model definitions
- **Microsoft.Extensions.Logging**: Logging framework support

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). For getting started, release notes, and contribution guidelines, see the [main README](../../README.md).