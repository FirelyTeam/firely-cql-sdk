## Potentially Breaking

- `ICqlOperators` now consistently annotates the optional `precision` parameter as nullable
  (`string?`) on the remaining 16 interval/age members that still used non-nullable `string`.
  Runtime behavior is unchanged, but this is a breaking contract change for custom
  `ICqlOperators` implementations that must update their signatures to match. (#1527)
