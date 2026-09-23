## Fixes

- **Runtime:** comparing two quantities whose units differ now converts both into the finer of the two
  operand units instead of into the canonical UCUM base unit. Canonicalizing rescales each value by its
  unit's factor, and for a clinical unit far from its base that factor drives the value below the step
  size of the CQL `Decimal` type — `0.25 'mg/d'` canonicalizes to `0.0000000028935185 'g.s-1'`, while a
  `Decimal` has "a *scale* (meaning number of possible digits to the right of the decimal) of 8 [...]
  with a step size of 10^-8" (CQL 1.5.3 Errata 2, Appendix B, 1.1 Decimal). The `Decimal` comparer
  quantizes to that step, so every pair of quantities in a clinical dose range quantized to zero and
  compared equal: `0.25 'mg/d' > 0.125 'mg/d'` answered `false` whenever either side arrived in
  canonical form, as it does out of quantity division, and `0.25 'mg/d' > 0.125 'mg.d-1'` answered
  `false` purely because the two spellings of one unit are different strings. The operand units are the
  scale the values were authored at, so the quantization is meaningful there. Commensurability is still
  decided on the canonical form, so incommensurable units keep answering `null` for comparison and
  `false` for equivalence, and the canonical form remains the fallback common unit when the metric
  service will not convert between the operand units directly. Two spellings of one unit carry the same
  factor, so neither operand is converted and the answer does not depend on the operand order; a genuine
  conversion is rounded back onto the step size the comparison works in, so that quantities exactly equal
  across a conversion that is not exact in decimal (`0.25 'mg/d' = 250 'ug/d'`) stay equal. Equivalence,
  which rounds to "the precision of the least precise operand" (ibid., 5.2 Equivalent), now rounds both
  operands at that operand's step size expressed in the common unit rather than at a count of decimal
  places, because across units the two are not the same thing: `1000.4 'mg'` is written to one decimal
  place but resolves a tenth of a milligram, which is finer than the single decimal place of `1.0 'g'`.
  **CQL evaluation results change** for
  cross-unit quantity comparisons; the CMS156 high-risk-medications-in-the-elderly test case of the MADiE
  corpus that compares an average daily dose against a `'mg/d'` threshold passes.
- **Runtime:** every quantity now hashes to one bucket, so the set-based operators (`Distinct`, `Union`,
  `Except`) collapse quantities the comparer calls equal. They previously kept both when the pair was
  equal across a unit conversion or differed only below the step size of 10^-8. Quantity equality is not
  transitive — the `'1'` unit matches any unit, values are compared truncated to the CQL `Decimal` scale
  in the finer of the two operand units, and equivalence rounds to the least precise operand — so every
  value-derived hash separates some pair that compares equal. **This makes the set-based operators
  quadratic in the number of quantities**: with one bucket, every insertion is a linear scan of the set,
  and each step of that scan is a unit-aware quantity comparison that may call the metric service. A
  `Distinct` over a couple of thousand quantities in mixed units takes minutes rather than the
  milliseconds it did, and should be avoided at that size; collections whose quantities all share one
  unit take the same-unit fast path, which compares the values directly and never reaches the service,
  and stay in the milliseconds.
