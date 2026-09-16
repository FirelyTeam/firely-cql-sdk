## Dependency Updates

- `FirelyNetVersion`: `6.3.0` → `6.5.0` — bumps `Hl7.Fhir.Base` and `Hl7.Fhir.R4` for every package that
  consumes Firely .NET SDK types (`Hl7.Cql.Fhir`, `Hl7.Cql.Packaging`, `Hl7.Cql.Packager`) and for the
  demo projects. Set in `cql-base.props` and `Demo/cql-demo.props`; the root `README.md` "External
  Dependencies" table is updated to match. A consumer with its own direct reference to the Firely .NET
  SDK should move it to `6.5.0` as well. This stays within the Firely .NET SDK's own `6.x` major, so it
  is not a MESO trigger on its own (see [versioning.md](../../versioning.md)); no public API, generated
  C# output, or CQL evaluation result changes with it. (#1611)
