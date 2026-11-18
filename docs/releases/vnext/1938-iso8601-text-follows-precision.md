## Potentially Breaking

- **Runtime (`Hl7.Cql.Iso8601`)** — The text of a `DateTimeIso8601`, `DateIso8601` or `TimeIso8601` and its `Precision`
  property now always describe the same value. Three ways of constructing one made them disagree, and all three change:
  - **`DateTimePrecision.Unknown` passed as the precision** keeps every component of the `DateTimeOffset` or `TimeSpan`.
    `Precision` already said so; `ToString()` now shows them too. For example
    `new DateTimeIso8601(dto, DateTimePrecision.Unknown).ToString()` gives `2024-03-15T10:30:45.123+01:00` where it gave
    `2024`, and the `DateIso8601` and `TimeIso8601` constructors that take a precision give `2024-03-15` and
    `10:30:45.123` where they gave `2024` and `10`.
  - **`strict: true` together with a precision** now cuts the value off at that precision, as the same call without
    `strict` always did. `Precision` is the requested precision, and the components after it are `null`. They used to
    stay filled, with `Precision` at the finest component, while `ToString()` showed the requested precision.
    `ToString()` is unchanged on this path. For `DateTimeIso8601`, `DateTimeOffset` and `DateTimeOffsetUtc` follow the
    components, so they are cut off as well.
  - **A precision outside the range of the type** gives the nearest one inside it: a `DateIso8601` constructed with
    `Hour` to `Millisecond` has `Precision` `Day`, and a `TimeIso8601` constructed with `Year` to `Day` has `Precision`
    `Hour`. `Precision` used to repeat the argument. `ToString()` is unchanged on this path.

  `Equals` and `GetHashCode` of these types compare the text, so they move with `ToString()` on the first path: two
  values with different components no longer compare equal there. Values that are parsed, or constructed from
  components without a precision argument, are unchanged. CQL evaluation results are unchanged: the SDK itself passes
  neither `DateTimePrecision.Unknown`, nor `strict` together with a precision, nor a precision outside the range of
  the type. Code of your own that calls `new CqlDateTime(dto, DateTimePrecision.Unknown)` reaches the first path.

  One call that threw now succeeds: `new DateIso8601(dto, precision, strict: true)` for a `DateTimeOffset` in
  February, with a precision other than `Unknown`. (#1524)
