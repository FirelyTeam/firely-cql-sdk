## Dependency Updates

- `FirelyNetVersion`: `6.6.0` → `6.7.0`, bumping `Hl7.Fhir.Base` and `Hl7.Fhir.R4` for every package that consumes Firely .NET SDK types (`Hl7.Cql.Fhir`, `Hl7.Cql.Packaging`, `Hl7.Cql.Packager`) and for the demo projects. A consumer with its own direct reference to the Firely .NET SDK should move it to `6.7.0` as well. `Hl7.Fhir.Base` `6.7.0` has the same dependencies as `6.6.0`, so no other package version moves with it. No public API, generated C# output, or CQL evaluation result changes with it. (#1814)
