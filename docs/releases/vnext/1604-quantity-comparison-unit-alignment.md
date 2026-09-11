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
  service will not convert between the operand units directly. Equivalence, which rounds to "the
  precision of the least precise operand" (ibid., 5.2 Equivalent), leaves an operand that already
  carries the target unit untouched rather than converting it into its own unit, which would pad it out
  to the metric service's working scale and stop the genuinely least precise operand from setting the
  rounding precision. **CQL evaluation results change** for cross-unit quantity comparisons; the CMS156
  high-risk-medications-in-the-elderly test case of the MADiE corpus that compares an average daily dose
  against a `'mg/d'` threshold passes.
- **Runtime:** the hash code of a quantity is taken over its value truncated to the CQL `Decimal` scale,
  in the quantity's own unit, before canonicalization. Equality already compared the truncated values, so
  two quantities differing only below the step size of 10^-8 were equal but hashed differently, and the
  set-based operators (`Distinct`, `Union`, `Except`) kept both. The truncation happens in the quantity's
  own unit because that is where equality truncates; a truncated canonical value would collapse every
  clinical dose rate to zero and would keep digits equality drops for units coarser than their base
  (`'kg'`, `'d'`).
