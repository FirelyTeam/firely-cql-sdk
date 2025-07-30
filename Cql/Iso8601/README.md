# Hl7.Cql.Iso8601

A support package for HL7.Cql that contains implementations of ISO 8601 date, time, and datetime structures for use in the CQL engine.

## Overview

This package provides ISO 8601 compliant date and time types that support the precision semantics required by CQL. These structures can have nullable values beyond the most significant component (year for dates, hour for times) and maintain an understanding of precision.

## Key Features

- **Precision-Aware Dates**: Date structures with nullable day/month components
- **Precision-Aware Times**: Time structures with nullable minute/second components  
- **Precision-Aware DateTimes**: Combined date/time with configurable precision
- **ISO 8601 Compliance**: Full compliance with ISO 8601 standards
- **CQL Semantics**: Designed specifically for CQL precision and comparison semantics
- **Nullable Components**: Support for partial dates and times (e.g., "2023-01" for January 2023)

## Usage

These types are used throughout the CQL engine to represent temporal values with appropriate precision semantics.

## Use Cases

- Representing partial dates (year-month, year only)
- Temporal comparisons with precision awareness
- CQL temporal arithmetic operations
- Date/time parsing and formatting with precision preservation

## Further Reading

This package is part of the [Firely CQL SDK](https://github.com/FirelyTeam/firely-cql-sdk). For getting started, release notes, and contribution guidelines, see the [main README](../../README.md). More information can be found at [Firely's documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html).