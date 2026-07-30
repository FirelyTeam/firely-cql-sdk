## Fixes

- The quantity equivalent operator (`~`) now considers UCUM unit conversion, as required by §9.B of the CQL specification, instead of returning `false` for any two quantities whose units differ. `1 'cm' ~ 0.01 'm'` now returns `true`, matching what `=` and the comparison operators already did. Quantities whose units cannot be canonicalized, or that canonicalize to different base metrics (e.g. `1 'cm' ~ 1 'g'`), are still `false` — equivalence never signals an error (#1415).
