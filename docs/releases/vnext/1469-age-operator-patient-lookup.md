## Performance

- The age operators (`AgeInYears`, `AgeInYearsAt` and their siblings) no longer redo their setup on every call.
  They used to ask the model inspector for its patient mapping, re-resolve `IPatient.BirthDate` by reflection, and
  close `IDataSource.Retrieve<T>` over the patient type before invoking it reflectively — none of which depends on
  the arguments, while measure logic evaluates these operators per element of a query rather than once per patient.
  Over 200 calls against a one-patient bundle on .NET 10, `AgeAt` went from 2.441 ms and 1.25 MB to 65.4 µs and
  100 KB. Behaviour is unchanged. (#1469)
