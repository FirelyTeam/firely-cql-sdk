## Fixes

- **Code generator** — A non-strict `as` whose operand is a value cast to a choice or to `Any` compiles when the value's
  own type cannot be the target, and evaluates to null, as the specification requires for a value of another type.
  `((@2024-01-01) as Choice<Date, DateTime>) after @2030-01-01T00:00`, and the same comparison with `before`, `>`, `<`,
  `>=` and `<=`, failed C# compilation with CS0039 ("Cannot convert type 'CqlDate' to 'CqlDateTime'"), so the whole
  library could not be evaluated; the comparison is now null. Other casts of that shape compile the same way, such as
  `(true as Any) as Decimal` and `('a' as Choice<String, Integer>) as Integer`. `GeneratorToolVersion` is now 6.2.2.0,
  up from 6.2.1.0. For a library that compiled before, the generated C# is unchanged apart from that version.
  (#1869, #1879)
