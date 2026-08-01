## Fixes

- `Median` of an odd number of elements returned an arbitrary element of the source instead of the median: it
  indexed into the original argument rather than into the sorted, null-stripped values. All three overloads
  (`Decimal`, `Integer`, `Long`) were affected.
- `GeometricMean` took the Nth root over the total number of elements, counting the nulls it had excluded from the
  product. The spec (§9.B) defines it as `Power(Product(X), 1 / Count(X))`, and CQL's `Count` is the number of
  non-null elements.
- String comparison hashed the raw string while comparing the Unicode-normalized one, so the hash-based operators
  (`distinct`, `union`, `except`, `includes`) could report two strings that CQL considers equal — differing only in
  normalization form — as distinct values.
- `ListEqual` and `Equivalent` over two lists disposed the left enumerator twice and never disposed the right one.

## Performance

Evaluation-time work removed across the runtime operators, comparers, conversions and the POCO data source. Nothing
in CQL-to-ELM translation or code generation is affected, and no generated C# changes.

- A `BundleDataSource` retrieve is evaluated once and hands back its matches, where it used to hand back a query
  that re-decided code membership on every walk. A retrieve typically feeds a definition whose value is cached and
  then read by several expressions, and the bundle does not change during an evaluation. The result is now a
  materialized collection, so it costs one list's worth of memory that a single-use retrieve did not pay before.
- `TypeConverter` remembers which conversion applies to a (from, to) pair rather than scanning the registered
  custom converters ahead of the lookup on every conversion, and `CanConvert` no longer formats a diagnostics
  string per call when no logger is attached to receive it.
- `LateBoundProperty` — the operator behind every property read through a choice or union type — resolves the
  property once per (type, name) instead of per access, which also stops allocating a wrapper `PropertyInfo` each
  time.
- The age operators (`AgeInYears`, `AgeInYearsAt` and friends) no longer resolve the model's patient mapping and
  close the retrieve over the patient type by reflection on every call. This is the largest single win: measure
  logic evaluates these per element of a query, not once per patient.
- Comparing a coded element against a string literal (`Encounter.status = 'finished'`) is generated as a conversion
  of the enum behind the element to its FHIR wire literal followed by a string comparison, and the conversion is
  what the type-converter memo above removes the per-comparison cost from — resolving it used to read a
  `FhirEnumeration` attribute every time. `ICqlOperators.EnumEqualsString`, which routes the same comparison
  through the enum comparer in one step, benefits separately from a memo of the wire literal; no generated library
  calls that operator today, but hosts driving `ICqlOperators` directly may.
- `sort` and `sort by` return a fully evaluated list. A lazy result re-ran the whole sort — and, for `sort by`, the
  sort expression for every element — each time it was walked, and evaluated the sort expression three times per
  element even on the first walk.
- `includes` / `included in` over two lists indexes the containing list instead of scanning it once per element of
  the contained one.
- `Avg`, `GeometricMean`, `Median`, `Collapse`, `Tail` and `properly includes` each walk their arguments once.

Measured with the new `CqlExecutionBenchmarks`, over 200 resources, on .NET 10, from one before/after pair of runs:

| Operator shape                                        | Before   | After    |
| ----------------------------------------------------- | -------- | -------- |
| Age operator, per element                             | 13.2 µs  | 0.23 µs  |
| Coded element vs. string literal, per element         | 2.60 µs  | 0.058 µs |
| `includes` over two 200-element lists                 | 672 µs   | 16 µs    |
| Late-bound property access, per element               | 0.90 µs  | 0.12 µs  |
| Code-filtered retrieve read by 8 expressions          | 172 µs   | 26 µs    |
| `sort by` whose result is walked twice                | 181 µs   | 92 µs    |

The coded-element row measures the two-step form the code generator emits, not
`ICqlOperators.EnumEqualsString` — the benchmark carries both, and the operator no generated library calls is
labelled as such.
