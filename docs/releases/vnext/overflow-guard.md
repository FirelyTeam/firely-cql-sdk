## Fixes

- Operations whose result cannot be represented evaluate to `null` instead of ending evaluation with a .NET exception, as
  the specification's arithmetic rule requires ("operations that cause arithmetic overflow or underflow, or otherwise
  cannot be performed (such as division by 0) will result in null, rather than a run-time error"). One set of guarded
  arithmetic and conversion helpers replaces the per-operator overflow handling, and each overflow is reported as a
  warning through the message event. The following results change:
  - `+` and `-` of a Date or DateTime and a calendar quantity (`year`, `month`, `week`, `day`) whose value is outside the
    Integer range, or whose number of weeks in days is outside the Decimal range: `null` instead of `OverflowException`.
  - `+` and `-` of two quantities whose units differ, where converting a value to the other unit leaves the Decimal
    range: `null` instead of `OverflowException`.
  - `*`, `/` and `div` of quantities, where the product or quotient (directly or after unit conversion) leaves the
    Decimal range: `null` instead of `OverflowException`.
  - `+` and `-` of two quantities in the same unit whose result leaves the Decimal range: `null` instead of a
    quantity without a value.
  - `mod` of quantities whose units differ, where converting the divisor leaves the Decimal range: `null` instead of
    `OverflowException`.
  - `*` of two Decimals, and `/` and `div` of two Decimals, whose result leaves the Decimal range: `null` instead of
    `OverflowException`.
  - `div` of the minimum Integer or Long by `-1`: `null` instead of `OverflowException`.
  - `mod` of the minimum Integer or Long by `-1`: `0` instead of `OverflowException`.
  - `Ceiling`, `Floor` and `Truncate` of a Decimal outside the Integer range: `null` instead of `OverflowException`.
  - `Exp` whose result exceeds the Decimal range, and `Ln(0)`: `null` instead of `OverflowException`.
  - `Round` with a negative precision: `null` instead of `ArgumentOutOfRangeException`; with a precision above 28: the
    argument unchanged instead of `ArgumentOutOfRangeException`.
  - `ConvertQuantity` and `CanConvertQuantity` where the converted value leaves the Decimal range: `null` and `false`
    instead of `OverflowException`.
  - Comparisons of quantities whose units differ (`=`, `<`, `>`, `between`, and the interval operators `before`,
    `after`, `meets`, `overlaps`, `includes`, `contains`, `except`, `same or before`, `same or after` over quantity
    intervals), where a canonical value leaves the Decimal range: unknown (`null`, or `false` for equivalence) instead of
    `OverflowException`.
  - `expand` of an Integer, Long or Decimal interval by a `per` beyond the type's range, and of a Date or DateTime
    interval by a `per` of weeks beyond the Decimal range in days: the partitions that fit instead of `OverflowException`.
- Integer and Long results that wrapped around silently are `null` instead: `*` of two Integers or two Longs whose
  product leaves the range, and `Abs` of the minimum Integer or Long.
- `duration between` and `difference between` of DateTimes in minutes, seconds or milliseconds whose
  count exceeds the Integer range (for example `duration in milliseconds between` two DateTimes 25 days apart) are
  `null` instead of `2147483647` or a wrapped negative count.
- The `Date`, `DateTime` and `Time` operators given components that do not form a value of the type (a year outside
  0001 to 9999, a month outside 1 to 12, a component given below one that is not, a timezone offset that cannot be
  represented) throw `CqlException<CqlInvalidDateTimeComponentsError>` instead of `ArgumentException`,
  `ArgumentOutOfRangeException` or `OverflowException`.

This changes CQL evaluation results for the affected expressions, which per [versioning.md](../../versioning.md) forces
a **MESO** bump. Generated C# and `GeneratorToolVersion` are unchanged.
