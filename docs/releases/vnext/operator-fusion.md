## Improvements

- The compiler now fuses the four immediately-consumed `Where`/`Select` chains into single-pass
  operators, so the intermediate `List` those chains built only to walk once and discard is never
  allocated: `Exists(Where(s, p))` becomes `WhereAny(s, p)`, `Select(Where(s, p), f)` becomes
  `WhereSelect(s, p, f)`, `Where(Select(s, f), p)` becomes `SelectWhere(s, f, p)`, and
  `Distinct(Select(s, f))` becomes `SelectDistinct(s, f)`. The four operators are new members on
  `ICqlOperators`, the generator version moves accordingly, and every checked-in generated `.g.cs`
  has been regenerated (#1484).

  Each fused operator is non-short-circuiting by construction: it invokes the same lambdas over the
  same elements, in the same relative order, as the composition it replaces, so results, `Message`
  side effects and exception surfaces are unchanged. One documented nuance: single-pass
  `WhereSelect`/`SelectWhere` interleave the two lambdas per element (`p(x₁), f(x₁), p(x₂)…`)
  instead of running all `p` and then all `f`. No evaluation is added or skipped; only if *two
  different lambdas would both throw* can the surfacing exception differ. No observable difference
  showed up on the measurement corpus.

  Measured on a prototype of this change over the dqm-content-qicore-2025 corpus (1,340 fusions
  across 86 of 89 libraries), in an order-balanced steady-state A/B — 900 cases × 100 reps, medians
  of reps 86–100, with bundle deserialization cached out of the loop, so these are fixture-free
  numbers for the evaluation itself and not end-to-end wall time. At dop1: CPU 525 ms → 496 ms
  (−5.5%), allocation 407 KB/case → 382 KB/case (−6.1%, with all eight round-pairs landing in
  −5.7…−6.6%), gen0 collections 22 → 20 and GC pause 17.1 ms → 15.2 ms (−8% / −11%). dop4 medians
  were −9% wall/CPU with one adverse round, direction consistent; the hottest library (CMS117, with
  its n³ cross-join pipelines) improved 7.7%. Correctness was gated on a per-case oracle: 900 cases
  × 3 reps produced byte-identical outcome files for base vs fused. Treat the percentages as
  indicative of this corpus and protocol rather than a guarantee for any particular measure.
