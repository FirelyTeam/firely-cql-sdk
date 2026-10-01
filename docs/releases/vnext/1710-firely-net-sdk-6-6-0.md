## Dependency Updates

- `FirelyNetVersion`: `6.5.0` → `6.6.0` in `Directory.Packages.props`, bumping `Hl7.Fhir.Base` and `Hl7.Fhir.R4`
  for every package that consumes Firely .NET SDK types (`Hl7.Cql.Fhir`, `Hl7.Cql.Packaging`, `Hl7.Cql.Packager`)
  and for the demo projects. A consumer with its own direct reference to the Firely .NET SDK should move it to
  `6.6.0` as well. No public API, generated C# output, or CQL evaluation result changes with it. (#1710)
- `MicrosoftExtensionsVersion`: `10.0.3` → `10.0.9`, moving the whole `Microsoft.Extensions.*` family together.
  `Hl7.Fhir.Base` `6.6.0` depends on `Microsoft.Extensions.Caching.Memory` `10.0.9`, which requires
  `Microsoft.Extensions.Logging.Abstractions` at that version or newer, so the dependency floor the affected
  `Hl7.Cql.*` packages declare rises accordingly. An application already resolving `10.0.9` or newer is
  unaffected. (#1710)
