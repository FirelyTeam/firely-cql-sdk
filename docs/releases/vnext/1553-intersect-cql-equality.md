## Fixes

- List `Intersect` now uses CQL equality semantics (same comparer path as `Except`/`Union`/`Distinct`) instead of CLR object equality. This fixes missed matches for value-equal but reference-distinct values, including UCUM-convertible `CqlQuantity` and structurally equal `CqlConcept`/tuple values. The behavior change can add matches, but does not remove matches that were already found under CQL equality. (#1325)

## Internal

- Added `ListSetOperatorBenchmarks` to measure `Intersect`/`Except`/`Union`/`Distinct` across `int`, `string`, `CqlQuantity`, and `CqlConcept`, and captured an A/B baseline for the `Intersect` correctness fix (`.Intersect(right.Cast<object>())` vs `.Intersect(right.Cast<object>(), EqualityComparer)`):
  - On merged `develop`, `CqlQuantity` is already expensive across the whole set-operator family (representative `Values=200` means/allocations): `Intersect` `49,505 μs`/`131,100 KB`, `Except` `50,006 μs`/`131,102 KB`, `Union` `49,840 μs`/`131,124 KB`, `Distinct` `32,599 μs`/`87,363 KB`. This PR extends that pre-existing comparer cost to `Intersect` (which was previously fast because it was incorrect), rather than introducing a new cost model unique to `Intersect`. (#1324, #1325)
  - Intersect-only A/B (same machine/session) with per-row type labels and result-count caveat:

    | Type | Values | Before Mean | After Mean | Before Alloc | After Alloc | Before result count | After result count |
    |---|---:|---:|---:|---:|---:|---:|---:|
    | int | 200 | 14.092 μs | 19.32 μs | 27.49 KB | 27.52 KB | 100 | 100 |
    | string | 200 | 10.624 μs | 17.66 μs | 7.13 KB | 7.16 KB | 100 | 100 |
    | CqlQuantity | 200 | 4.272 μs | 49,505.15 μs | 5.02 KB | 131,099.77 KB | 0 | 100 |
    | CqlConcept | 200 | 7.735 μs | 41.86 μs | 5.02 KB | 19.66 KB | 0 | 100 |
    | int | 2000 | 138.907 μs | 193.04 μs | 260.84 KB | 260.87 KB | 1000 | 1000 |
    | string | 2000 | 114.268 μs | 177.72 μs | 62.10 KB | 62.13 KB | 1000 | 1000 |
    | CqlQuantity | 2000 | 46.117 μs | 512,310.68 μs | 45.92 KB | 1,310,640.67 KB | 0 | 1000 |
    | CqlConcept | 2000 | 92.935 μs | 464.74 μs | 45.92 KB | 187.13 KB | 0 | 1000 |

  - The `~128 MB` quantity outlier is attributable to hash-code canonicalization work: `CqlQuantityCqlComparer.GetHashCodeValue` calls `TryCanonicalize` for hash-key construction, and this comparer path has no per-value or per-unit cache in `CqlQuantityCqlComparer`/`UcumConversionExtensions`; each hash evaluation performs canonicalization work anew.
