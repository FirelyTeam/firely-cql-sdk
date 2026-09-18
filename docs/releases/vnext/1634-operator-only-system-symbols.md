## Potentially Breaking

- **CQL-to-ELM translator:** eight internal operators are no longer callable with function syntax:
  `Between`, `ProperBetween`, `Interval`, `NotEqual`, `Case`, `ToList`, `MinValue` and `MaxValue`
  (`NotEqual(1, 2)`, `"Interval"(1, 10, true, true)`). CQL defines no function of those names and
  the reference translator rejects the calls; they resolved here because every `SystemLibrary`
  field was reflected into the function symbol table. Such a call now reports `Could not resolve
  call to operator <Name> with signature (...)`. The operator syntax (`between`, `!=`,
  `Interval[...]`, `case`, `minimum`, `maximum`, implicit list promotion) is unchanged. Two side
  effects: `MinValue()` and `MaxValue()` report that error instead of throwing an
  `ArgumentException`, and a user-defined function named `NotEqual` resolves instead of being
  reported as ambiguous with the internal operator. (#1633)
