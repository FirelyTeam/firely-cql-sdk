## Features

- `Hl7.Cql.Fhir.FhirCqlContextOptions` now accepts an injected `IMetricService` implementation for UCUM quantity operations through `MetricService`, and cross-unit `Add`/`Subtract` now work with the default metric service while returning results in the most granular input unit per CQL §9.B (#1282).

## Fixes

- Quantity `Multiply` by a scalar (`'1'`) now preserves the non-`'1'` operand unit instead of incorrectly collapsing the result unit to `'1'` (#1282).
- Quantity `Between` now returns `null` for dimension-incompatible comparisons instead of producing a boolean result from incompatible units (#1282).
- Quantity arithmetic now returns `null` (not `NotSupportedException`) when UCUM operations are invalid/incompatible for the requested operator, matching CQL §9.B null semantics (#1282).
- Quantity `Modulo` and `TruncatedDivide` now align with the updated UCUM arithmetic paths for cross-unit cases (including commensurable unit handling and null on invalid combinations) (#1282).
- `CanConvertQuantity` now correctly checks convertibility (instead of always returning `false` for non-null inputs) by evaluating unit conversion through `UnitConverter.ChangeUnits` (#1282).
- `DefaultUcumMetricService.TryConvertTo` now delegates directly to `Fhir.Metrics` (the temporary workaround is removed); `Fhir.Metrics` is updated from `1.3.0` to `1.4.0` in existing references, and this PR adds a new `Fhir.Metrics` reference in `Cql.Firely` (#1282, closes #1296).
