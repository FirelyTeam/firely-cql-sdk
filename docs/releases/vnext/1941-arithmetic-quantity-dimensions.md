## Fixes

- **Runtime** — Adding or subtracting quantities whose units have different dimensions now gives null, as CQL §9.B
  *Add* and *Subtract* require ("units of 'cm2' and 'cm' cannot" be added). `5.5 'cm' + 2 'cm2'` used to give
  `0.0552 'm'`, because the UCUM service combined the values without checking that the units measure the same
  dimension. Units of the same dimension, such as `'cm'` and `'m'`, are unaffected. Generated C# is unchanged.
