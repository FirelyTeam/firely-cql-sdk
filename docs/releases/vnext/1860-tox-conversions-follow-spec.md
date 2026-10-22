## Fixes

- **Runtime** — The `To*` conversions follow the formats and ranges the CQL specification gives them, and return null,
  never an exception, for an argument outside them. The matching `ConvertsTo*` operators follow, since each gives the
  answer of its `To*` conversion. The following results change (#1839):
  - `ToDateTime` of a string whose hour, minute, second or timezone offset is out of range
    (`ToDateTime('2014-01-01T25:00:00Z')`, `'2014-01-01T10:61:00'`, `'2014-01-01T10:00:00+15:00'`), or whose instant
    in UTC falls outside `0001-01-01` to `9999-12-31` (`'0001-01-01T00:00:00+01:00'`): null instead of
    `ArgumentOutOfRangeException`. `ConvertsToDateTime` of such a string is false instead of throwing.
  - `ToTime` of a string whose hour, minute or second is out of range (`ToTime('25:00:00')`, `ToTime('10:61')`): null
    instead of a Time holding that component. With an offset more than 14 hours from UTC (`'10:00:00+15:00'`): null
    instead of `ArgumentOutOfRangeException`.
  - `ToDate` of a string that is a valid DateTime: its date, ignoring the time portion, instead of null.
    `ToDate('2014-01-01T12:30:00')` is `@2014-01-01`.
  - `ToQuantity` of a string accepts the format `(+|-)?#0(.0#)?('<unit>')?`, with spaces allowed only between the
    value and the unit. A value without a unit gets the unit `'1'` (`ToQuantity('5')` is `5 '1'` instead of null), and
    the unit may follow the value directly (`ToQuantity('5\'mg\'')` is `5 'mg'` instead of null). A unit that is not
    quoted at both ends (`ToQuantity('444 \'cm')` was `444 'cm'`, `ToQuantity('5 mg')` was `5 'mg'`) or is empty, a
    value with a group separator or a leading decimal point, and a space before the value or after the unit give null.
    The unit is not yet checked against UCUM (#1782).
  - `ToDecimal`, `ToInteger` and `ToLong` of a string accept only `(+|-)?#0(.0#)?` and `(+|-)?#0`. Surrounding
    whitespace (`ToInteger(' 1 ')`), a group separator (`ToDecimal('1,000')`), a trailing sign (`ToDecimal('1-')`) and
    a leading decimal point (`ToDecimal('.5')`) give null instead of a number.
  - `ToBoolean` of an Integer, Long or Decimal other than 0 and 1 (`ToBoolean(2)`, `ToBoolean(2L)`, `ToBoolean(0.5)`):
    null instead of false.
  - `ToInteger` of a Long outside the Integer range (`ToInteger(3000000000L)`): null instead of the wrapped value
    `-1294967296`.
- **Runtime** — `CqlQuantity.TryParse` accepts the format of `ToQuantity` described above, which `CqlRatio.TryParse`
  already used for each quantity: a quantity without a unit gets the unit `'1'`, and an unquoted, unterminated or empty
  unit is rejected. `CqlDateTime.TryParse`, `CqlTime.TryParse`, `DateTimeIso8601.TryParse` and `TimeIso8601.TryParse`
  return false for an hour, minute, second or offset out of range, instead of throwing `ArgumentOutOfRangeException`
  or, for a Time, accepting the value. The string conversions of `ICqlOperators.Convert<T>` to `CqlQuantity`,
  `CqlDateTime` and `CqlTime` use these parsers and change with them. (#1839)
- **CQL to ELM translation** — A DateTime literal with an hour, minute, second or offset out of range
  (`@2014-01-01T25:00:00Z`) reports "Unparseable date/time literal" instead of failing translation with
  `ArgumentOutOfRangeException`. A Time literal with an hour, minute or second out of range (`@T24:59:59.999`)
  reports "Unparseable time literal" instead of translating to a Time holding that component. (#1839)

This changes CQL evaluation results for the affected expressions. Generated C# and `GeneratorToolVersion` are unchanged.
