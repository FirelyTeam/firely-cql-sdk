## Fixes

- **Code generator** — Two expressions over a literal value now generate C# that compiles. `GeneratorToolVersion` is
  now 6.2.3.0. Only C# that previously failed to compile changes; the output for every checked-in library is the same (#1953).
  - `Coalesce(null, 15, null)` generated `(null as int?) ?? 15 ?? null as int?`, which C# rejects (CS0019) because
    `… ?? 15` is a plain `int`. A coalesce now stops at the first value-type literal, since no later operand can be
    reached.
  - A null check of an expression that reduces to a literal, such as `Message(5, false, …)` (which returns its source
    `5` when the condition is false), generated `5 is null`, which C# rejects (CS0037). It now generates `false`.
