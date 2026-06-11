# vNext Release Notes

## Breaking Changes

## Features

## Fixes

- **#1305** — Added `PowerResultTypeCorrector` to the ELM library preprocessor pipeline. This corrects a compatibility issue with externally-provided ELM produced by the Java `cql2elm` translator, which incorrectly stamps `Power` nodes with an `Integer` or `Long` result type when both operands are integer-typed. The preprocessor now normalizes all `Power` node result types to `Decimal` before expression binding, matching the CQL specification. Our own `CqlToElm` translator was already correct and is unaffected.
- **#1307** — Fixed `CS0452` compilation failures in generated C# when coalescing lists of nullable value tuples. The operator binder now resolves the actual list element type via the type resolver (instead of naively taking the first generic type argument), so value-type elements — including nullable value tuples — bind to `ICqlOperators.CoalesceValueTypes<T>` rather than the class-constrained `Coalesce<T>` overload.
