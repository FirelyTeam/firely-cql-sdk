## Changes

- Upgraded the pinned Java CQL tooling (`cql-to-elm-cli` and `elm-fhir`) from `5.0.0` to `5.1.0`.
  All CQL test-project ELM files regenerated; the only observable change is the `translatorVersion`
  metadata field in each ELM JSON file (5.0.0 → 5.1.0). No ELM AST content changed, so no
  `GeneratorToolVersion` bump is required. (#1444)
