# vNext Release Notes

## Breaking Changes

## Features

## Improvements

- Optimized the `RunLibrary`/`SelectResults` hot path: replaced repeated dictionary/reflection lookups with cached delegates and reduced allocations on the definition-evaluation path (#1322, #1323).
- Reduced allocations and removed several O(n²) patterns in `CqlComparers`/`CqlOperators`: `Distinct` now uses a `HashSet`-based O(n) algorithm instead of `List.Contains`, comparer type-resolution is memoized, boxing was removed from equality fast paths, and `CqlConcept` comparisons cache their sorted code arrays instead of re-sorting on every call (#1324, #1327).

## Fixes

- The C# compiler now collapses ELM choice types whose alternatives all map to the same .NET type (e.g. `Choice<Condition, Condition>` produced for unions of QiCore Condition profiles) to that single type instead of `object`. Generated code stays strongly typed and no longer falls back to late-bound property access (seen in e.g. CMS125 "Right Mastectomy Diagnosis"). The generator tool version was bumped to 5.1.2.0 and the checked-in generated libraries were regenerated.
