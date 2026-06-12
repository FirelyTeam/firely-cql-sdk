# vNext Release Notes

## Breaking Changes

- **#1313** — Removed the `where T : class` constraint from `ICqlOperators.Coalesce<T>`. External implementations of `ICqlOperators` must remove the constraint from their `Coalesce<T>` implementation. `ICqlOperators.CoalesceValueTypes<T>` is now deprecated (`[Obsolete]`); use `Coalesce<T>` with `T = Nullable<U>` (e.g. `Coalesce<int?>`) instead.

## Features

## Fixes

- **#1305** — Added `PowerResultTypeCorrector` to the ELM library preprocessor pipeline. This corrects a compatibility issue with externally-provided ELM produced by the Java `cql2elm` translator, which incorrectly stamps `Power` nodes with an `Integer` or `Long` result type when both operands are integer-typed. The preprocessor now normalizes all `Power` node result types to `Decimal` before expression binding, matching the CQL specification. Our own `CqlToElm` translator was already correct and is unaffected.
- **#1307 / #1313** — Fixed `CS0452` compilation failures in generated C# when coalescing lists of nullable value tuples. The `where T : class` constraint on `ICqlOperators.Coalesce<T>` was removed and the operator binder now always binds `Coalesce<T>` using the actual list element type resolved via the type resolver (for nullable value types, `T` is the nullable type itself, e.g. `Coalesce<int?>`, preserving CQL null semantics). `CoalesceValueTypes<T>` is deprecated and no longer emitted by the binder.
