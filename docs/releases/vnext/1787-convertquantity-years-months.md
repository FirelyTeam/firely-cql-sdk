## Fixes

- `ConvertQuantity` between `'a'` and `'mo'` now returns the correct value: `ConvertQuantity(1 'a', 'mo')` is `12 'mo'` (was `0.0833… 'mo'`) and `ConvertQuantity(12 'mo', 'a')` is `1 'a'` (was `144 'a'`). The built-in calendar conversion table had the two directions swapped. This changes CQL evaluation results. (#1785)
