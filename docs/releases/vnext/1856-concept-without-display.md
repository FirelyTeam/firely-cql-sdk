## Fixes

- **Code generator** — A `Concept` instance selector without a `display`, such as
  `Concept { codes: { Code { code: '1234-5', system: 'http://loinc.org' } } }`, now compiles. It evaluates to a
  `CqlConcept` with those codes and a null `display`, since an element that a selector leaves out is null. It used to
  fail with "No suitable constructor found for type Hl7.Cql.Primitives.CqlConcept." The generated C# passes `default`
  for the display to the existing two-argument constructor, so it also runs on earlier runtimes. C# generated for
  libraries that compiled before is unchanged, and so is `GeneratorToolVersion`. (#1808)

## New Public API

- **Runtime** — The `display` parameter of both `CqlConcept` constructors defaults to `null`, so `new CqlConcept(codes)`
  creates a concept without a display. The parameter types are unchanged, so code compiled against an earlier version
  is unaffected. (#1808)
