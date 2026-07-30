# Hl7.Cql.Fhir

A support package for HL7.Cql that contains the bindings to use Firely's .NET SDK POCOs for FHIR.

## Overview

This package provides the integration layer between the CQL runtime and Firely's FHIR .NET SDK, enabling CQL expressions to work directly with FHIR data models and resources.

## Key Features

- **FHIR POCO Bindings**: Direct integration with Firely's FHIR .NET SDK POCOs
- **Type Mappings**: Automatic conversion between CQL types and FHIR types
- **Resource Navigation**: Support for navigating FHIR resource hierarchies in CQL
- **FHIR R4 Support**: Complete support for FHIR R4 specification
- **Data Binding**: Efficient binding of FHIR data to CQL execution context

## Usage

This package enables CQL expressions to work with FHIR resources and data types using the familiar Firely .NET SDK object models.

## Dependencies

- **Hl7.Cql.Runtime**: Core CQL runtime components
- **Hl7.Fhir.R4**: Firely's FHIR R4 .NET SDK
- **Fhir.Metrics**: Open-source UCUM unit conversion library

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). For getting started, release notes, and contribution guidelines, see the [main README](../../README.md).