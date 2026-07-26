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

- `Expand` no longer hangs in an infinite loop with unbounded memory growth when the `per` quantity cannot advance the expansion. A `per` value of zero or less (e.g. `expand { Interval[1, 10] } per 0`, `per -1`, `per 0 days`) now returns `null` from every `Expand` overload — numeric and Date/DateTime/Time, both the list and single-interval forms — instead of looping forever. A fractional `per` over an interval of `Integer` or `Long` (e.g. `expand { Interval[10, 10] } per 0.1`) previously truncated the step to an integer, hanging for values below 1 and silently producing wrong interval widths otherwise; it now throws `NotSupportedException`, because per the CQL specification the result would have to be a list of `Decimal` intervals, which the `Integer`/`Long`-typed overload cannot represent (#1412).
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

- `Expand` no longer emits a trailing interval that overshoots the upper boundary when `per` does not divide the interval width. Per the CQL specification an interval is contributed only if it both starts on or after the lower boundary *and* ends on or before the upper boundary, so `expand { Interval[1.0, 2.0] } per 0.5` now yields two intervals instead of three, and an input narrower than `per` (e.g. `expand { Interval[1.0, 1.2] } per 0.5`, `expand { Interval[1, 10] } per 20`) contributes nothing instead of one overshooting interval. This applies to all twelve `Expand` overloads — numeric and Date/DateTime/Time, both the list and single-interval (point) forms — so results whose last group did not fit the input interval are now shorter by one element (#1413).
- `Expand` now applies the specification's truncation rule to every boundary that is more precise than `per`, not just to some of them, and applies it in the single-interval (point) form as well as the list form. Boundaries more precise than `per` are truncated to `per`'s precision before the intervals are laid down, so the result may be broader than the input range: `expand { Interval[@T10:00:00.000, @T12:00:00.000] } per hour` yields `@T10`, `@T11` and `@T12` (previously the `@T12` interval was missing unless a boundary happened to carry a remainder below the hour), `expand { Interval[@2022-01-01, @2022-03-01] } per 3 months` yields `Interval[@2022-01, @2022-03]`, and `expand Interval[1.0, 10.0] per 1` yields the points `1` through `10`. Because truncation now happens consistently, Date/DateTime/Time results are emitted at `per`'s precision (e.g. `@2022-01` rather than `@2022-01-01` for a monthly expansion) and Decimal results at `per`'s scale. Boundaries *less* precise than `per` are still not broadened; such an interval contributes nothing, as the specification requires (#1413).

- The quantity equivalent operator (`~`) now considers UCUM unit conversion, as required by §9.B of the CQL specification, instead of returning `false` for any two quantities whose units differ. `1 'cm' ~ 0.01 'm'` now returns `true`, matching what `=` and the comparison operators already did. Quantities whose units cannot be canonicalized, or that canonicalize to different base metrics (e.g. `1 'cm' ~ 1 'g'`), are still `false` — equivalence never signals an error (#1415).
- The hash code a quantity gets from the runtime comparer is now computed over its canonicalized UCUM form and a scale-normalized value, instead of over `CqlQuantity.ToString()`. Quantities that compare equal now hash equally, so the `HashSet`-backed list operators (`distinct`, `union`, `except`) deduplicate quantities that differ only by unit conversion (`1 'cm'` and `0.01 'm'`) or by decimal scale (`1.0 'cm'` and `1.00 'cm'`) (#1418).
- Quantity equality (`=`) and the ordering comparisons (`<`, `>`, `<=`, `>=`, `between`) no longer treat quantities of different dimensions as comparable. Each operand was canonicalized to its UCUM base unit and only the resulting *values* were compared, so `1 'cm' = 0.01 'g'` returned `true` and `1 'cm' < 1 'g'` answered as if both were dimensionless. The canonical units must now agree, and when they do not the comparison is `null`, as §9.B requires of every comparison operator: "Attempting to operate on quantities with invalid units will result in a null." Comparisons between convertible units (`1 'cm' = 0.01 'm'`) are unchanged. A unit that is not valid UCUM at all now also yields `null` instead of throwing a `NotSupportedException`, so a measure comparing dirty clinical data degrades to unknown rather than failing the whole define (#1417).
- Equivalence (`~`) is never `null`, so quantities whose units share no base unit are `false` there — `3.5 'cm2' ~ 3.5 'cm'`, matching the spec's own example. This also corrects equivalence for an interval over incommensurable quantity bounds, which previously reported the two intervals equivalent by comparing their canonicalized bounds as bare numbers, and for `Date`/`DateTime`/`Time` values specified to different precisions: `@2012-01-01 ~ @2012-01-01T12` is now `false`, as §9.B specifies ("the comparison stops and the result is false, rather than null"), where it used to be `true` (#1417).
