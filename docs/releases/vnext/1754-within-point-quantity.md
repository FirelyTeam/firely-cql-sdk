## Fixes

- The .NET CQL-to-ELM translator now translates `X within Q of Y` with a point `Y` as membership in
  the interval from `Y - Q` to `Y + Q` (open when `properly` is given), as the specification defines
  it. It previously ignored the quantity and tested `X` against the point interval `[Y, Y]`, so CQL
  evaluation results change for every `within` phrase with a point on the right. `occurs within`
  and `aggregate … starting <quantity>` now translate instead of throwing. (#1730)
