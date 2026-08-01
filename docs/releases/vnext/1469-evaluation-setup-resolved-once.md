## Performance

Two pieces of per-call setup on the evaluation path are now resolved once. Both were paid per element of a query,
because measure logic evaluates the operators involved per element rather than once per patient.

- The age operators (`AgeInYears`, `AgeInYearsAt` and their siblings) used to ask the model inspector for its
  patient mapping, re-resolve `IPatient.BirthDate` by reflection, and close `IDataSource.Retrieve<T>` over the
  patient type before invoking it reflectively — none of which depends on the arguments. Over 200 calls against a
  one-patient bundle on .NET 10, `AgeAt` went from 2.441 ms and 1.25 MB to 65.4 µs and 100 KB.

- Type conversions used to re-decide which converter applied on every call. `TypeConverter.Convert` scanned the
  registered custom converters — allocating a closure over the type pair, and unable to stop at the first match —
  before consulting the delegate dictionary, and `CanConvert` repeated that scan while also formatting both type
  names into a diagnostics string for a log that reports nothing unless a logger is attached.

  The conversion behind a coded element compared to a string literal (`Encounter.status = 'finished'`) gains the
  most, because the converter that claims that pair identifies it by reading a `FhirEnumeration` attribute, and
  `GetCustomAttribute` constructs a fresh instance per call. Over 200 values on .NET 10:

  | Conversion | Before | After |
  | --- | --- | --- |
  | Coded element's enum → wire literal | 450.90 µs / 157.81 KB | 9.61 µs / 0 B |
  | `FhirDateTime` → `CqlDateTime` | 21.76 µs / 6.25 KB | 13.54 µs / 0 B |
  | `Quantity` → `CqlQuantity` | 17.31 µs / 15.63 KB | 10.72 µs / 9.6 KB |

  As a side effect the diagnostics set is no longer mutated without synchronization, which sat badly with the
  concurrent-evaluation contract documented on `CqlContext`.

Behaviour is unchanged in both cases. (#1469)
