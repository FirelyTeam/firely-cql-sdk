## Breaking changes

- Generated `*.g.cs` now opt into nullable reference types and emit nullable reference-type
  annotations (`T?`) on generated declarations (locals, parameters, and return types). Value types
  remain unchanged, and generated value-set/code-system/code/concept definition members remain
  non-nullable because the generator constructs those values directly.

  How far the opt-in goes is selected by `CSharpConfig.Nullability`, which defaults to `Enabled`
  (`#nullable enable`, annotations verified by the compiler). See
  [1580-csharp-config.md](1580-csharp-config.md) for the mode table — the demo measure corpora ship
  on `Annotations`, so consumers of those libraries get the annotations without the compiler
  checking them. (#1564)
