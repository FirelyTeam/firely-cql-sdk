## Improvements

- Patient type and birth-date resolution are now memoized once in shared `BaseTypeResolver` via `PatientTypeInfo`,
  so every resolver gets consistent one-time lookup behavior without per-resolver memoization implementations. (#1518)
