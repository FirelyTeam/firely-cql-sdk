## Fixes

- The singleton overloads of the list operators `properly includes` and `properly included in` return `false` for a null list, as `contains` and `in` do, instead of `null`: `null as List<String> properly includes 'a'` and `'a' properly included in null as List<String>` are `false`. The list-list overloads keep returning `null` for a null argument. (#1707)

This changes CQL evaluation results for the affected expressions.
