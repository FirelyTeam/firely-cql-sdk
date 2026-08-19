## Breaking changes

- Generated `*.g.cs` now opt into nullable analysis (`#nullable enable`) and emit nullable
  reference-type annotations (`T?`) on generated declarations (locals, parameters, and return
  types). This is intentionally a blanket annotation for reference types because the code model
  carries `System.Type`, which does not encode reference-type nullability. Value types are
  unchanged; notably `CqlBoolean` is still emitted as `CqlBoolean` (never `CqlBoolean?`). (#1564)
