## Improvements

- The age operators now resolve the patient's birth date once per evaluation context instead of per element of a
  query. Measured at 174 ns / 512 B per call before and 22.7 ns / 32 B after — an 87 % reduction in time and 94 %
  in allocations. The FHIR path no longer uses reflection to read the birth date: it casts to `IPatient` directly.
  The memoization assumes the patient in context does not change for the lifetime of a `CqlOperators` instance. (#1518)
