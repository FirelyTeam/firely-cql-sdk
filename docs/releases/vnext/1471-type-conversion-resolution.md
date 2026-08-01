## Performance

- Type conversions no longer re-decide which converter applies on every call. `TypeConverter.Convert` used to scan
  the registered custom converters — allocating a closure over the type pair, and unable to stop at the first match
  — before consulting the delegate dictionary, and `CanConvert` repeated that scan while also formatting both type
  names into a diagnostics string for a log that reports nothing unless a logger is attached. Conversions run per
  value during an evaluation, so both were paid per element of a query.

  The conversion behind a coded element compared to a string literal (`Encounter.status = 'finished'`) gains the
  most, because the converter that claims that pair identifies it by reading a `FhirEnumeration` attribute, and
  `GetCustomAttribute` constructs a fresh instance per call. Over 200 values on .NET 10:

  | Conversion | Before | After |
  | --- | --- | --- |
  | Coded element's enum → wire literal | 450.90 µs / 157.81 KB | 9.61 µs / 0 B |
  | `FhirDateTime` → `CqlDateTime` | 21.76 µs / 6.25 KB | 13.54 µs / 0 B |
  | `Quantity` → `CqlQuantity` | 17.31 µs / 15.63 KB | 10.72 µs / 9.6 KB |

  Behaviour is unchanged. As a side effect the diagnostics set is no longer mutated without synchronization, which
  sat badly with the concurrent-evaluation contract documented on `CqlContext`. (#1471)
