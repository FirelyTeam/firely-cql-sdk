# vNext Release Notes

## Breaking Changes

- The C# generated for `Interval` construction with choice-typed operands changed (see the corresponding entry under Fixes), so `GeneratorToolVersion` was bumped from `5.1.4.0` to `5.1.5.0`. Consumers holding pre-generated C# for affected libraries should regenerate it; the generated API surface is unchanged, so no `LibraryInstanceInvoker` update is needed.

## Features

## Fixes

- Fixed an `InvalidCastException` at runtime when constructing an `Interval` whose ELM point type is a choice (e.g. `Choice<DateTime, Interval<DateTime>>` resulting from `FHIRHelpers.ToValue`). The binder now anchors the point type on the other operand's static type, or on the single choice alternative that is a valid interval point type, instead of arbitrarily picking one (#1350).
