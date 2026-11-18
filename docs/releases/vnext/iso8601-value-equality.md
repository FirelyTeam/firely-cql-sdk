## Potentially Breaking

- **Runtime (`Hl7.Cql.Iso8601`)** — `DateIso8601`, `DateTimeIso8601` and `TimeIso8601` are equal when they are of the
  same type and have the same components, and they implement `IEquatable<T>`. `Equals` and `GetHashCode` used to
  compare the text of `ToString()`. Two results change:
  - **A value no longer equals an object of another type whose text is the same.** `date.Equals("2024-03-15")` was
    `true` and is `false`, and a `DateTimeIso8601` of day precision no longer equals the `DateIso8601` of the same day.
  - **Two parsed values with the same components are equal, however they were written.** `2024-03-15T10:00:00Z` and
    `2024-03-15T10:00:00+00:00` were different and are equal; so are `+01` and `+01:00`.

  Every pair of values of one type that was equal stays equal. The offset is still part of the value:
  `2024-03-15T10:00:00+01:00` and `2024-03-15T09:00:00Z` name the same instant and are different. `CqlDate`,
  `CqlDateTime` and `CqlTime` take `Equals` and `GetHashCode` from these types, so the same holds for them, and for a
  set or dictionary keyed on them. `GetHashCode` gives other numbers than before.

## Performance

- **Runtime (`Hl7.Cql.Iso8601`)** — Comparing two ISO 8601 values for equality, or hashing one, no longer formats it as
  text.
