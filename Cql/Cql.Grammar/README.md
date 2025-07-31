# Hl7.Cql.CqlToElm.Grammar

A support package for HL7.Cql that contains the ANTLR-based grammar for parsing CQL.

## Overview

This package provides the ANTLR4 grammar definition and generated parser components for the Clinical Quality Language (CQL). It enables parsing of CQL text into abstract syntax trees that can be processed by other components.

## Key Features

- **CQL Grammar**: Complete ANTLR4 grammar definition for CQL
- **Generated Parser**: ANTLR4-generated lexer and parser classes
- **Visitor Pattern Support**: Generated visitor classes for AST traversal
- **CQL Language Support**: Full support for CQL language constructs

## Grammar Source

The CQL grammar is based on the official grammar located at:
https://github.com/cqframework/clinical_quality_language/blob/master/Src/grammar/cql.g4

## Usage

This package provides the parsing infrastructure used by CQL-to-ELM conversion.

## Dependencies

- **Antlr4.Runtime.Standard**: ANTLR4 runtime for .NET

## Note on Build Process

The ANTLR4 build tasks require MSBuild and cannot be run from VS Code, Rider, or standard `dotnet build`. Generated files are included in the repository to enable building without requiring ANTLR4 code generation.

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). For getting started, release notes, and contribution guidelines, see the [main README](../../README.md). More information can be found at [Firely's documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html).