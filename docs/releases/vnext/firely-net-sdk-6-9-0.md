## Dependency Updates

- **Runtime (`Hl7.Cql.Fhir`)** — `FirelyNetVersion`: `6.8.0` → `6.9.0`, bumping `Hl7.Fhir.Base` and `Hl7.Fhir.R4` for every
  package that consumes Firely .NET SDK types (`Hl7.Cql.Fhir`, `Hl7.Cql.Packaging`, `Hl7.Cql.Packager`) and for the demo
  projects. A consumer with its own direct reference to the Firely .NET SDK should move it to `6.9.0` as well.
  `Hl7.Fhir.Base` `6.9.0` depends on `Fhir.Metrics` `1.4.1`, which `FhirMetricsVersion` already is, so no other package
  version moves with it. No public API or generated C# output changes with it, but two behavior changes in `6.9.0` can
  change CQL evaluation results:
  - A value set without an expansion, which `ValueSetSource` expands itself, now counts nested codes towards its cap of
    5,000 codes, so a nested expansion over the cap fails with `ValueSetExpansionTooBigException` instead of being
    accepted. An include that intersects value sets, or a code system with value sets, now keeps the nested codes it
    used to drop, so such a value set can have more members. A value set that arrives with its expansion is unchanged.
  - A FHIR `date`, `dateTime`, `instant` or `time` value followed by a line break no longer converts to a CQL value; it
    becomes `null`. A time without seconds still converts as before. (#1934)
