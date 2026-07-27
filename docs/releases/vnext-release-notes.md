# vNext Release Notes

## Breaking Changes

- The generated C# for a CQL `union` of two structurally compatible tuple lists whose element
  types differ now converts both operands to the ELM-declared result type up front, instead of
  erasing them to `IEnumerable<object>`. Libraries generated with an earlier code generator must
  be regenerated; `GeneratorToolVersion` is bumped to `5.1.5.0` accordingly. (#1354)

## Features

## Fixes

## Dependencies

- Upgraded the upstream Java `cql-to-elm-cli`/`elm-fhir` tooling (`org.cqframework`) from `4.0.0` to
  `5.0.0`, applied incrementally one minor/major version at a time (4.1.0 through 5.0.0), regenerating
  and testing at each step. Only `4.6.0` introduced observable ELM-shape changes (interval-literal
  constant-folding, choice-type alphabetical sorting); every other step was a no-op version bump. No
  generated C# output changed as a result — the existing code generator already handles both ELM
  shapes correctly. (#1334)

- Fixed a CQL `union` of two structurally compatible tuple lists with differing element types
  silently evaluating to empty. Both operands were converted through `as IEnumerable<object>`,
  which yields `null` for the value tuples the C# generator lowers compiler-generated tuple types
  to, because `IEnumerable<T>` covariance does not apply to value types. (#1354)
