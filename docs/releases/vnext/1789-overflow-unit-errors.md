## Fixes

- `+` of a Date, DateTime or Time and a quantity whose unit is not a time-valued unit of that type (such as `1 'cm'`,
  `1 'hour'` added to a Date, or `1 'year'` added to a Time) signals a CQL error,
  `CqlException<CqlUnsupportedTemporalUnitError>`, instead of `ArgumentException`.
- `-` of a Date, DateTime or Time and such a quantity signals the same `CqlException<CqlUnsupportedTemporalUnitError>`
  instead of `ArgumentException`.
- `expand` of a Date, DateTime or Time interval, or a list of them, by a `per` whose unit is not a temporal unit (such as
  `per 1 'cm'`) signals the same `CqlException<CqlUnsupportedTemporalUnitError>` instead of `ArgumentException`.
- `ConvertQuantity` (`convert ... to`) to a unit the quantity cannot be converted to (such as `convert 1 'mg' to 'mL'`)
  is `null`, reported as a warning through the message event, as the specification requires ("Otherwise, the result is
  null"), instead of `ArgumentException`.

This changes CQL evaluation results for the affected expressions, which per [versioning.md](../../versioning.md) forces
a **MESO** bump. Generated C# and `GeneratorToolVersion` are unchanged.
