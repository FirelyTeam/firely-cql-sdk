## Features

- Retrieves with a code or value set filter over a `Bundle` no longer redo per-resource work on every
  retrieve: `Hl7.Cql.Fhir.BundleDataSource` extracts the codings of each resource once per retrieved type
  (and per code property) and reuses them for later retrieves over the same bundle, reads code properties
  through a compiled getter instead of reflection, and matches an explicit list of codes through a set
  lookup rather than scanning the list for every coding (#1450).
