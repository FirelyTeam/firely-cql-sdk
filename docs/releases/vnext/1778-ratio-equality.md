## Fixes

- Ratio literals compile and run. A ratio selector such as `1 'mg':2 'mL'` used to stop C# generation
  with "Operator Ratio is not supported yet", and a ratio literal whose quantities have no unit, such
  as the titre `1:128`, failed CQL-to-ELM translation; such a quantity now takes the default unit
  `'1'`, as the specification prescribes.
- `=`, `!=`, `~` and `!~` on ratios follow the specification. Equality compares numerator with
  numerator and denominator with denominator using quantity equality, so `1:8 = 2:16` is false and a
  comparison with an unknown part is null unless the other part differs. Equivalence compares the
  ratios the two represent, numerator divided by denominator, with unit conversion, so
  `1:100 ~ 10:1000` and `1 'mg':2 'mL' ~ 2 'mg':4 'mL'` are true. A ratio that cannot be divided (a
  zero denominator or a null part) is equivalent to no ratio, so `1:0 ~ 1:0` is false. `Distinct`,
  `Union` and `Except` deduplicate equal ratios.
- Generated C# for existing libraries is unchanged (no `GeneratorToolVersion` change) and so are
  existing evaluation results: ratio comparisons previously failed to compile or threw "Cannot
  compare type CqlRatio".
