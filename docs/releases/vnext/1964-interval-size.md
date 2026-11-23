## Potentially Breaking

- **Runtime** — `ICqlOperators` gains `Size` for intervals of Integer, Long, Decimal and Quantity. It has no default
  interface implementation, so a custom `ICqlOperators` implementation fails to compile until the four overloads are
  implemented (#1964).

## Fixes

- **CQL to ELM translation, code generator and runtime** — `Size(Interval<T>)`, which reported "could not resolve
  function", now translates and evaluates per CQL §9.B: `(end of argument - start of argument) + point-size`, so
  `Size(Interval[3, 7])` and `Size(Interval[3, 8))` are both 5. The point-size is 1 for Integer and Long and the
  Decimal minimum precision for Decimal and Quantity. A null interval or a null boundary gives null, and so does a
  size outside the type's range. This changes CQL evaluation results for those expressions, and `GeneratorToolVersion`
  is now 6.4.0.0; the output for every checked-in library is the same (#1964).
