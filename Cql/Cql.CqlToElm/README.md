# 1. Hl7.Cql.CqlToElm

A support package for HL7.Cql that contains functionality to convert CQL to ELM.

## 1.1. Overview

This package provides the conversion functionality that transforms Clinical Quality Language (CQL) source code into Expression Logical Model (ELM) representation. This is a critical step in the CQL compilation pipeline.

> **Important**: This .NET-based CQL to ELM converter is currently in early development and only supports basic CQL translation. **It is NOT PRODUCTION READY.** For production use, we **strongly recommend** using the mature, battle-tested [Java-based CQL to ELM tooling](https://github.com/cqframework/clinical_quality_language/tree/master/Src/java) instead.

## 1.2. Key Features

- **CQL to ELM Conversion**: Complete conversion from CQL text to ELM JSON
- **Syntax Analysis**: Parse and analyze CQL syntax using ANTLR4 grammar
- **Error Handling**: Comprehensive error reporting for CQL syntax and semantic issues
- **Model Integration**: Integration with CQL model information for type checking
- **Configuration Support**: Configurable conversion options and settings

## 1.3. Conversion Process

1. **Parsing**: Uses ANTLR4 grammar to parse CQL text into abstract syntax trees
2. **Semantic Analysis**: Validates semantics and resolves references
3. **ELM Generation**: Converts AST into ELM JSON representation
4. **Validation**: Ensures generated ELM is valid and complete

## 1.4. Reference Configuration

The translator's defaults reproduce the configuration the repository's reference ELM is produced with: the Java CQL
translator run by [`Demo/Cql/Build/CqlTooling.Targets.xml`](../../Demo/Cql/Build/CqlTooling.Targets.xml) with
`-locators true -result-types true -signatures All` and no promotion or demotion flags. That ELM records
`translatorOptions = EnableLocators,EnableResultTypes`.

| Setting | Default |
|---|---|
| `DisableListPromotion`, `DisableListDemotion` | `false`: a single value converts to a list and a list to a single value where needed |
| `EnableIntervalPromotion`, `EnableIntervalDemotion` | `false`: a point and a point interval do not convert into each other |
| `AmbiguousTypeBehavior` | `PreferModel`: a type name defined by both System and a model resolves to the model's type |

`CqlToolkitConfig` and `CqlToElmOptions` use these defaults, and so does the Packager CLI's default settings file.
The translator census in `CqlToElmTests` runs on them, so its results compare with the reference ELM. A caller that
needs other behavior sets the switches on `CqlToolkitConfig`.

## 1.5. Usage

This package is used in the CQL compilation pipeline to convert CQL source to ELM.

## 1.6. Dependencies

- **Hl7.Cql.Model**: Model definitions and metadata
- **Hl7.Cql.Runtime**: Runtime components for type resolution
- **Elm**: ELM abstractions and utilities
- **Iso8601**: ISO 8601 date/time handling
- **Hl7.Cql.Grammar**: CQL grammar and parsing components
- **Microsoft.Extensions.Configuration**: Configuration framework
- **Microsoft.Extensions.DependencyInjection**: Dependency injection
- **Microsoft.Extensions.Logging**: Logging framework

## 1.7. Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). For getting started, release notes, and contribution guidelines, see the [main README](../../README.md).