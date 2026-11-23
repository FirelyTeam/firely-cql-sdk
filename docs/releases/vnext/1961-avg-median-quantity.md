## Potentially Breaking

- **Runtime** — `ICqlOperators` gains `Avg(IEnumerable<CqlQuantity?>?)` and `Median(IEnumerable<CqlQuantity?>?)`.
  They have no default interface implementations, so a custom `ICqlOperators` implementation fails to compile until
  both are implemented. A direct call with an untyped `null`, such as `operators.Avg(null)`, is now ambiguous between
  the Decimal and Quantity overloads; cast the argument, as in `operators.Avg((IEnumerable<decimal?>?)null)`.
  Generated C# always passes a typed argument (#1961).

## Fixes

- **Runtime and code generator** — `Avg` and `Median` over a list of Quantities, which translated but failed while
  the C# was built, now evaluate per CQL §9.B: the result has the unit the quantities share, null elements are
  ignored, and a list with no non-null elements or a null list gives null. Quantities in different units give null
  with a warning, as `Sum`, `StdDev` and `Variance` do. This changes CQL evaluation results for those expressions,
  and `GeneratorToolVersion` is now 6.2.4.0; the output for every checked-in library is the same (#1961).
