# vNext Release Notes

## Breaking Changes

- The generated C# for a CQL `union` of two structurally compatible tuple lists whose element
  types differ now converts both operands to the ELM-declared result type up front, instead of
  erasing them to `IEnumerable<object>`. Libraries generated with an earlier code generator must
  be regenerated; `GeneratorToolVersion` is bumped to `5.1.5.0` accordingly. (#1354)

- The C# generated for `Interval` construction with choice-typed operands changed (see the corresponding entry under Fixes), so `GeneratorToolVersion` was bumped from `5.1.5.0` to `5.1.6.0`. Consumers holding pre-generated C# for affected libraries should regenerate it; the generated API surface is unchanged, so no `LibraryInstanceInvoker` update is needed.

- The C# generated for CQL libraries has changed shape (generator tool version 5.1.6.0 →
  5.1.7.0); regenerate any checked-in generated C# when upgrading. Multi-branch
  conditionals (`if`/`case … when`) now emit native `if`/`else` statements instead of
  invoked zero-parameter local functions, redundant casts to `object` no longer print,
  duplicate pure subexpressions within a definition are computed once, and local-variable
  naming is contiguous. The generated code is substantially shorter (−4% across the HEDIS
  2025 corpus) and reads like hand-written C#; no public API, method signature, or
  generated-code attribute shape changed, so existing invokers keep working.

## Features

- The Measure packaging step can now emit `Measure.group.code`: the new
  `PackagingToolkitConfig.MeasureGroupCodeSystem` setting (also available as the
  `--measure-group-code-system` PackagerCLI option and the `Packaging:MeasureGroupCodeSystem`
  appsettings key) takes a code system URL, and when set, each measure group's id is also emitted
  as a coding with that system and the group id as its code. When the setting is enabled, group ids
  are validated against the FHIR `code` datatype constraints (non-empty, no leading/trailing
  whitespace, internal whitespace limited to single spaces) and packaging fails with a clear error
  for a `@group` annotation value that violates them. Unset (the default), the output is unchanged.

## Fixes

- `Hasher` no longer shares a single static `MD5` instance across threads, fixing intermittent `CryptographicException: Concurrent operations from multiple threads on this type are not supported` when tuple metadata signature hashes were computed concurrently (e.g. during parallel measure evaluation). It now uses the thread-safe one-shot `MD5.HashData` API (#1372).
- `IndexedBundle.FilterByType<T>` (used by `Retrieve`) no longer yields a candidate resource more than once when several of its codings match the filter, preventing inflated `Retrieve` results / population counts for resources with multiple matching codings (#1365).
- CQL `with`/`without` relationship clauses now compile as an existence filter (semi-join/anti-semi-join) instead of `SelectMany`/`Except`, so a source element with multiple matching related elements is emitted exactly once instead of duplicated (or spuriously deduplicated by `Except` set semantics for `without`) (#1366).
- `VersionedIdentifier.GetHashCode()` is now consistent with `Equals()`, and both now conform to the CQL specification: `id` comparison is case-sensitive (CQL is a case-sensitive language per §3.4.1 of the Developer's Guide) and `version` is matched as an exact opaque string (per §3.2 of the Developer's Guide and §2.1.5 of the Logical Specification), preventing missed matches/duplicate entries in hash-based dependency sets (#1375).
- `Union<T>(CqlInterval<T>?, CqlInterval<T>?)` now correctly merges intervals that meet (not just overlap), and no longer drops the later-ending tail when the right operand starts first (#1359).
- Upgraded the upstream Java `cql-to-elm-cli`/`elm-fhir` tooling (`org.cqframework`) from `4.0.0` to
  `5.0.0`, applied incrementally one minor/major version at a time (4.1.0 through 5.0.0), regenerating
  and testing at each step. Only `4.6.0` introduced observable ELM-shape changes (interval-literal
  constant-folding, choice-type alphabetical sorting); every other step was a no-op version bump.
  Generated ELM / checked-in C# output changed textually but is intended to be behavior-preserving;
  the existing compiler/codegen already handles both ELM shapes correctly. (#1334)

- Fixed a CQL `union` of two structurally compatible tuple lists with differing element types
  silently evaluating to empty. Both operands were converted through `as IEnumerable<object>`,
  which yields `null` for the value tuples the C# generator lowers compiler-generated tuple types
  to, because `IEnumerable<T>` covariance does not apply to value types. (#1354)

- Fixed an `InvalidCastException` at runtime when constructing an `Interval` whose ELM point type is a choice (e.g. `Choice<DateTime, Interval<DateTime>>` resulting from `FHIRHelpers.ToValue`). The binder now anchors the point type on the other operand's static type, or on the single choice alternative that is a valid interval point type, instead of arbitrarily picking one (#1350).
