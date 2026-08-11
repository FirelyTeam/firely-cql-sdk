## Performance

- Type conversions no longer re-decide which converter applies on every call. `TypeConverter.Convert` used to scan
  the registered custom converters — allocating a closure over the type pair, and unable to stop at the first match
  — before consulting the delegate dictionary, and `CanConvert` repeated that scan. Conversions run per value
  during an evaluation, so both were paid per element of a query.

  The conversion behind a coded element compared to a string literal (`Encounter.status = 'finished'`) gains the
  most, because the converter that claims that pair identifies it by reading a `FhirEnumeration` attribute, and
  `GetCustomAttribute` constructs a fresh instance per call. Over 200 values on .NET 10:

  | Conversion | Before | After |
  | --- | --- | --- |
  | Coded element's enum → wire literal | 274.17 µs / 157.81 KB | 5.83 µs / 0 B |
  | `FhirDateTime` → `CqlDateTime` | 14.35 µs / 10.94 KB | 9.28 µs / 4.69 KB |
  | `Quantity` → `CqlQuantity` | 9.23 µs / 15.63 KB | 6.42 µs / 9.38 KB |

  Behaviour is unchanged. (#1471)
