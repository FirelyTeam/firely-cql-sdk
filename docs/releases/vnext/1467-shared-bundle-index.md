## Features

- Added `Hl7.Cql.Fhir.FhirCqlContext.DataSourceForBundle(Bundle, FhirCqlContextOptions?)`, which builds a reusable
  `IDataSource` over a bundle. A host that evaluates the same, unchanging bundle several times - for instance once per
  measure group for the same subject - can build the source once and pass it to `WithDataSource` for every evaluation,
  so the index over the bundle's entries and the coding caches derived from it are built once instead of once per
  evaluation. `WithDataSource` gives each context a lightweight view over the shared index that resolves value sets
  through the `IValueSetDictionary` it was called with, so evaluations backed by different (for instance
  request-scoped) terminology can share one source. The index is read-only once built and supports any number of
  concurrent readers. (#1467)
