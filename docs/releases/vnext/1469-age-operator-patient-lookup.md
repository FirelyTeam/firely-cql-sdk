## Improvements

- The age operators (`AgeInYears`, `AgeInYearsAt` and their siblings) no longer redo their setup on every call.
  They used to ask the model inspector for its patient mapping, re-resolve `IPatient.BirthDate` by reflection, and
  close `IDataSource.Retrieve<T>` over the patient type before invoking it reflectively — none of which depends on
  the arguments, while measure logic evaluates these operators per element of a query rather than once per patient.
  Re-measured over 200 calls against a one-patient bundle on .NET 10, `AgeAt` is 70.9 µs and 100 KB in the
  per-query-element path, and 127.5 µs and 169 KB when the benchmark includes context setup in the measured region.
  Behaviour is unchanged. (#1469)
