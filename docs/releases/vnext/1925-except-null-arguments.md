## Fixes

- **Runtime** — List `except` now follows CQL §9.B *Except* when either argument is null. A null first
  argument gives null; it used to give the second argument, so `null except { 1, 3, 5 }` was `{ 1, 3, 5 }`.
  A null second argument is treated as an empty list, so duplicates are removed from the result:
  `{ 1, 1, 2 } except null` is now `{ 1, 2 }`, where it used to be `{ 1, 1, 2 }`. This changes CQL
  evaluation results for both cases. Generated C# is unchanged.
