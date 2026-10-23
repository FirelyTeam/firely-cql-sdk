## Fixes

- **Code generator** — A `Concept` instance selector without `codes`, such as `Concept { display: 'Blood pressure' }`,
  now compiles, and so does the selector without any element, `Concept { : }`. It evaluates to a `CqlConcept` whose
  `codes` are null, with the display the selector gives or a null one, since an element that a selector leaves out is
  null. It used to fail with "No suitable constructor found for type Hl7.Cql.Primitives.CqlConcept." The generated C#
  passes `default` for the codes to the existing two-argument constructor, so it also runs on earlier runtimes. C#
  generated for libraries that compiled before is unchanged, and so is `GeneratorToolVersion`. (#1857, #1875)

## New Public API

- **Runtime** — The `codes` parameter of the `CqlConcept(IReadOnlyList<CqlCode>?, string?)` constructor defaults to
  `null`, so `new CqlConcept()` and `new CqlConcept(display: "x")` create a concept without codes. The
  `CqlConcept(IEnumerable<CqlCode>?, string?)` constructor still requires its codes, so neither call is ambiguous. The
  parameter types are unchanged, so code compiled against an earlier version is unaffected. (#1857, #1875)
