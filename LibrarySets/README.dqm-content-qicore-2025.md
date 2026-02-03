# DQM Content QICore 2025

This library set contains CQL and ELM files from the Digital Quality Measures (DQM) Content QICore 2025 repository.

## About

This content represents quality measures and clinical decision support logic written in Clinical Quality Language (CQL) and compiled to Expression Logical Model (ELM) format, based on the QICore profile of FHIR.

## Modifications

Manual changes were made to the following files after copying from the source repository:

### QICoreCommon.cql
Addresses C# code generator issues:
1. Added explicit `as DateTime` type casts in the `ToAbatementInterval` function (line 401)
2. Added explicit `as DateTime` type casts in the `abatementInterval` function (line 424)

These changes were necessary to resolve type inference issues in the CQL-to-ELM translator.

### CMS69FHIRPCSBMIScreenAndFollowUp.cql
Fixed a syntax error in the `ObservationCancelled` query (line 107).
Key structural change example from the `ToAbatementInterval` function:

## Source

The CQL and ELM files in this library set are sourced from:
- **Repository/Path**: [cqframework/dqm-content-qicore-2025/tree/master/input/cql](https://github.com/cqframework/dqm-content-qicore-2025[link text](https://github.com/cqframework/dqm-content-qicore-2025/tree/master/input/cql))
- **Commit ID**: `c89ea1a7`
- **Commit Date**: 2026-01-14
