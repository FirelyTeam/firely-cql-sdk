## Breaking changes

- Generated `*.g.cs` now opt into nullable annotations (`#nullable enable annotations`) and emit
  nullable reference-type annotations (`T?`) on generated declarations (locals, parameters, and
  return types). This stays in annotations-only mode because full warning-context analysis is not
  compatible with blanket `T?` emission from `System.Type`-only nullability metadata. Value types
  are unchanged; notably `CqlBoolean` is still emitted as `CqlBoolean` (never `CqlBoolean?`), and
  generated value-set/code-system/code/concept definition members remain non-nullable because the
  generator constructs those values directly. (#1564)
