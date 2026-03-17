# Hl7.Cql.Packaging

A support package for HL7.Cql that contains support for packaging CQL artifacts as a FHIR Library resource.

## Overview

This package provides functionality to package compiled CQL artifacts (assemblies, source code, and metadata) into FHIR Library resources. It enables the distribution and management of CQL libraries in FHIR-compliant formats.

## Key Features

- **FHIR Library Creation**: Generates FHIR Library resources from CQL artifacts
- **Artifact Packaging**: Bundles compiled assemblies, source code, and metadata
- **Canonical URL Management**: Handles proper FHIR canonical URL generation
- **Version Management**: Supports versioning of CQL libraries
- **Dependency Tracking**: Manages library dependencies and references

## Usage

This package is used by the CQL packager tool to create FHIR Library resources that can be distributed and used in FHIR-based systems.

## Dependencies

- **CodeGeneration.NET**: .NET code generation utilities
- **Hl7.Cql.Compiler**: CQL compilation services
- **Hl7.Cql.Firely**: FHIR integration components
- **Hl7.Fhir.R4**: FHIR R4 model and serialization

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). For getting started, release notes, and contribution guidelines, see the [main README](../../README.md).