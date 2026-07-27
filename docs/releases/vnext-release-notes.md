# vNext Release Notes

## Breaking Changes

- The generated C# for a CQL `union` of two structurally compatible tuple lists whose element
  types differ now converts both operands to the ELM-declared result type up front, instead of
  erasing them to `IEnumerable<object>`. Libraries generated with an earlier code generator must
  be regenerated; `GeneratorToolVersion` is bumped to `5.1.5.0` accordingly. (#1354)

## Features

- The Measure packaging step can now emit `Measure.group.code`: the new
  `PackagingToolkitConfig.MeasureGroupCodeSystem` setting (also available as the
  `--measure-group-code-system` PackagerCLI option and the `Packaging:MeasureGroupCodeSystem`
  appsettings key) takes a code system URL, and when set, each measure group's id is also emitted
  as a coding with that system and the group id as its code. Unset (the default), the output is
  unchanged.

## Fixes

- Fixed a CQL `union` of two structurally compatible tuple lists with differing element types
  silently evaluating to empty. Both operands were converted through `as IEnumerable<object>`,
  which yields `null` for the value tuples the C# generator lowers compiler-generated tuple types
  to, because `IEnumerable<T>` covariance does not apply to value types. (#1354)
