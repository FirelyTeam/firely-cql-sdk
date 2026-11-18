## Potentially Breaking

- **Runtime (`Hl7.Cql.Iso8601`)** — `DateIso8601`, `DateTimeIso8601` and `TimeIso8601` are equal when they are of the
  same type and have the same components, and they implement `IEquatable<T>`. `Equals` and `GetHashCode` used to
  compare the text of `ToString()`. Two results change:
  - **A value no longer equals an object of another type whose text is the same.** `date.Equals("2024-03-15")` was
    `true` and is `false`, and a `DateTimeIso8601` of day precision no longer equals the `DateIso8601` of the same day.
  - **Two parsed values with the same components are equal, however they were written.** `2024-03-15T10:00:00Z` and
    `2024-03-15T10:00:00+00:00` were different and are equal; so are `+01` and `+01:00`.

  Every pair of values of one type that was equal stays equal, with one exception: a value constructed with a
  component after a missing one, such as `new DateIso8601(2024, null, 15)`, no longer equals the value without that
  component. Its text never showed the component. The offset is still part of the value:
  `2024-03-15T10:00:00+01:00` and `2024-03-15T09:00:00Z` name the same instant and are different. `GetHashCode` gives
  other numbers than before. A class derived from one of these types equals only an instance of the same class.

- **Runtime** — `CqlDate`, `CqlDateTime` and `CqlTime` implement `IEquatable<T>` and take `Equals` and `GetHashCode`
  from the types above, so the two results there hold for them as well. This moves CQL evaluation results in two
  places:
  - **`distinct`, `union`, `intersect` and `except`** treat two values with the same components as one value, however
    they were written. A list with `ToDateTime('2024-03-15T10:00:00Z')` and
    `ToDateTime('2024-03-15T10:00:00+00:00')` kept both under `distinct` and keeps one. `=` and `~` already called
    them equal.
  - **`=`, `~` and ordering** take the result "equal" from .NET equality before they compare by CQL rules, so they
    take it for more pairs than before:
    - A comparison at a precision that neither value has, such as `before` at `millisecond` for two values of second
      precision, gave `null` for `...T10:00:00Z` against `...T10:00:00+00:00` and gives `false`. It already gave
      `false` for two values written the same way.
    - `Date(2024, null, 15) = Date(2024)`, which is invalid CQL, was `true` and is `null`; `~` was `true` and is
      `false`.

## Performance

- **Runtime (`Hl7.Cql.Iso8601`)** — Comparing two ISO 8601 values for equality, or hashing one, no longer formats it as
  text.
