# Hl7.Cql.Compiler

A support package for HL7.Cql that translates ELM into C# expression trees and can emit those expression trees into either runtime Delegates or C# source code.

## Overview

This package provides the compilation infrastructure that converts ELM (Expression Logical Model) representations into executable .NET code. It serves as the bridge between the logical CQL expressions and their runtime execution.

## Key Features

- **ELM to Expression Trees**: Converts ELM JSON into .NET Expression objects
- **C# Code Generation**: Emits human-readable C# source code from expression trees
- **Runtime Delegate Creation**: Compiles expressions into executable delegates for immediate execution
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

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). More information can be found at [Firely's documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html).