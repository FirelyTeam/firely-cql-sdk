# DQM Content QICore 2025

This library set contains CQL and ELM files from the Digital Quality Measures (DQM) Content QICore 2025 repository.

## About

This content represents quality measures and clinical decision support logic written in Clinical Quality Language (CQL) and compiled to Expression Logical Model (ELM) format, based on the QICore profile of FHIR.

## Modifications

Manual changes were made to the following files after copying from the source repository:

### QICoreCommon.cql
Addresses C# code generator issues:
1. Added explicit `as DateTime` type casts in the `ToAbatementInterval` function definition
2. Added explicit `as DateTime` type casts in the `abatementInterval` function definition

These changes were necessary to resolve type inference issues in the CQL-to-ELM translator.

### CMS69FHIRPCSBMIScreenAndFollowUp.cql
Fixed a syntax error in the `ObservationCancelled` query definition.
Key structural change example from the `ToAbatementInterval` function:

## Source

The CQL and ELM files in this library set are sourced from:
- **Repository/Path**: [cqframework/dqm-content-qicore-2025/tree/master/input/cql](https://github.com/cqframework/dqm-content-qicore-2025[link text](https://github.com/cqframework/dqm-content-qicore-2025/tree/master/input/cql))
- **Commit ID**: `c89ea1a7`
- **Commit Date**: 2026-01-14

## Value set corpus sync

Besides the CQL/ELM sync, `sync-dqm-2025.ps1` also repairs the integration runner's
value set corpus (`IntegrationRunner/Test Data/Value Sets` in the
`Firely.Cql.Sdk.Integration.Runner` submodule) from the
[VSAC FHIR terminology service](https://www.nlm.nih.gov/vsac/support/usingvsac/vsacfhirapi.html).
The upstream dqm-content repository vendored partial VSAC expansions for some large
value sets (truncated at VSAC's 1000-concept page size), and a handful of referenced
value sets are absent from it entirely. The script scans the corpus for both cases and
fetches complete expansions, following VSAC's `offset`/`count` paging until
`expansion.total` concepts are present.
To keep the corpus reproducible, requests are pinned to VSAC release
`ecqm-update-2025-05-08`; when an existing value set file already declares a
`version`, that value is also sent as VSAC's `valueSetVersion` query parameter.

Fetching requires a personal UMLS API key: sign in at [uts.nlm.nih.gov](https://uts.nlm.nih.gov)
and choose "Generate new API Key" under My Profile (a free UMLS Metathesaurus license is
required). Provide it via the `UMLS_API_KEY` environment variable or the `-VsacApiKey`
parameter — never commit it.

Useful invocations:

```powershell
# Full sync: CQL + ELM + value set repair
./sync-dqm-2025.ps1

# Only repair the value set corpus (skips the CQL/ELM sync)
./sync-dqm-2025.ps1 -ValueSetsOnly

# Only sync CQL/ELM (the script's pre-existing behavior)
./sync-dqm-2025.ps1 -SkipValueSets

# Fetch specific value sets regardless of corpus state
./sync-dqm-2025.ps1 -ValueSetsOnly -ValueSetOids 2.16.840.1.113883.3.526.3.1010
```

Without an API key the scan still runs and reports what needs fetching, so
`-ValueSetsOnly` doubles as a corpus health check. Changes the script writes to the
submodule must be committed in the `Firely.Cql.Sdk.Integration.Runner` repository and
the submodule pointer bumped here, like any other submodule change.
