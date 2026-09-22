## Potentially Breaking

- **CQL-to-ELM translator:** eight internal operators are no longer callable with function syntax:
  `Between`, `ProperBetween`, `Interval`, `NotEqual`, `Case`, `ToList`, `MinValue` and `MaxValue`
  (`NotEqual(1, 2)`, `"Interval"(1, 10, true, true)`). CQL defines no function of those names and
  the reference translator rejects the calls; they resolved here because every `SystemLibrary`
  field was reflected into the function symbol table. Such a call now reports `Could not resolve
  call to operator <Name> with signature (...)`. The operator syntax (`between`, `!=`,
  `Interval[...]`, `case`, `minimum`, `maximum`, implicit list promotion) is unchanged. (#1634)

## Fixes

- **CQL-to-ELM translator:** `MinValue()` and `MaxValue()` report the error above instead of
  throwing an `ArgumentException`, and a user-defined function named `NotEqual` resolves instead
  of being reported as ambiguous with the internal operator. (#1634)
- **CQL-to-ELM translator:** a system function called with function syntax now runs the same
  validators as its operator form, so `DifferenceBetween(@2023-01-01, @2024-02-01, 'Hour')`
  reports the Date precision error instead of translating. (#1634)
- **CQL-to-ELM translator:** `Interval` built with a non-literal high closed argument took that
  argument's expression from the low boundary; the index is corrected. No CQL syntax reaches the
  case any more, so this is not observable from a library. (#1634)
