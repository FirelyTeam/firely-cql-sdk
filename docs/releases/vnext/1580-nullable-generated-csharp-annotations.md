## Breaking changes

- Generated `*.g.cs` now opt into nullable checks and annotations (`#nullable enable`) and emit
  nullable reference-type annotations (`T?`) on generated declarations (locals, parameters, and
  return types). Value types remain unchanged, and generated
  value-set/code-system/code/concept definition members remain non-nullable because the generator
  constructs those values directly. (#1564)
