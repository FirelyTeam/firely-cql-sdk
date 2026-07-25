## Fixes

- The hash code a quantity gets from the runtime comparer is now computed over its canonicalized UCUM form and a scale-normalized value, instead of over `CqlQuantity.ToString()`. Quantities that compare equal now hash equally, so the `HashSet`-backed list operators (`distinct`, `union`, `except`) deduplicate quantities that differ only by unit conversion (`1 'cm'` and `0.01 'm'`) or by decimal scale (`1.0 'cm'` and `1.00 'cm'`) (#1418).
