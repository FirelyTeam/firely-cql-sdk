## Fixes

- **CQL to ELM translation** — The `&` operator now treats a null operand as the empty string, as CQL §9.B
  *Concatenate* requires: each operand of the translated `Concatenate` is wrapped in `Coalesce(X, '')`, as §6
  *Translation Semantics* specifies. `'a' & null` used to be null and is now `'a'`. `+` is unchanged and still gives
  null when either operand is null. This changes CQL evaluation results; regenerate ELM from CQL to pick it up.
  Generated C# for a given ELM is unchanged. (#1933)
