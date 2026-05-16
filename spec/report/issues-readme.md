# GitHub Issues - CQL Spec Conformance Status

This directory tracks currently relevant CQL specification conformance issues.

## Status After Re-evaluation

The report set was re-evaluated against current implementation and tests.

Resolved and removed issue documents:

- `issue-01-critical-substring-length-bug.md` (resolved)
- `issue-03-high-list-equality-null-elements.md` (resolved)
- `issue-05-high-power-operator-null-return.md` (resolved)

Remaining open issue documents:

- `issue-02-high-endswith-bounds-check.md`
- `issue-04-high-round-test-expectations.md`
- `issue-06-medium-matches-operator-anchoring.md`
- `issue-07-low-unskip-expand-tests.md`

## Open Issues List

### High Priority

- **[issue-02-high-endswith-bounds-check.md](issue-02-high-endswith-bounds-check.md)** - [HIGH]
  - **Bug:** Missing bounds check and empty-suffix handling in `EndsWith`
  - **Impact:** Throws exceptions for oversized suffixes; spec edge case not handled
  - **Fix:** Add explicit empty-string and bounds handling

- **[issue-04-high-round-test-expectations.md](issue-04-high-round-test-expectations.md)** - [HIGH]
  - **Test Issue:** Runtime behavior is correct, test expectations are not
  - **Impact:** Valid spec behavior remains skipped
  - **Fix:** Update `RoundNeg0D5` and `RoundNeg1D5` expected outputs and unskip

### Medium Priority

- **[issue-06-medium-matches-operator-anchoring.md](issue-06-medium-matches-operator-anchoring.md)** - [MEDIUM]
  - **Bug:** `Matches` forces `^...$` anchoring and uses incorrect char/string comparison
  - **Impact:** Violates partial-matching semantics and can mis-evaluate patterns
  - **Fix:** Remove implicit anchoring and use direct regex match semantics

### Low Priority

- **[issue-07-low-unskip-expand-tests.md](issue-07-low-unskip-expand-tests.md)** - [LOW]
  - **Test/coverage Issue:** Expand tests remain skipped
  - **Impact:** Spec-aligned coverage remains disabled
  - **Fix:** Reconcile expected outputs and remove skip entries

## Summary Statistics

- **Open Issues:** 4
- **Resolved/Removed in this pass:** 3
- **Critical:** 0
- **High:** 2
- **Medium:** 1
- **Low:** 1

## Related Documentation

- **[spec-verified-findings.md](spec-verified-findings.md)** - Re-verified findings and current status
- **[cql-spec-deviations-report.md](cql-spec-deviations-report.md)** - Historical comprehensive analysis
- **[spec-content-guide.md](spec-content-guide.md)** - Guide for providing spec content

## Recommended Next Implementation Order

1. **Issue #02** (HIGH) - `EndsWith` bounds and empty-suffix handling
2. **Issue #04** (HIGH) - Round test expectation corrections
3. **Issue #06** (MEDIUM) - `Matches` partial-matching conformance
4. **Issue #07** (LOW) - Unskip and validate Expand tests

---

**Last Re-evaluated:** 2026-05-16  
**CQL Version:** 1.5.3 Release 1 Errata 2  
**Spec Location:** `spec/condensed/`
