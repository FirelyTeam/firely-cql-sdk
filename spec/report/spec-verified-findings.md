# CQL Specification Verified Findings

**Last Re-evaluated:** 2026-05-16  
**CQL Version:** 1.5.3 Release 1 Errata 2  
**Source:** Local spec files in `spec/condensed/`

This document captures the current verification status of previously reported conformance findings.

---

## Resolved Findings

### 1) Substring length calculation

- **Spec basis:** Substring must return up to the remaining characters from `startIndex`.
- **Current status:** **Resolved**.
- **Verification note:** Implementation now computes length using remaining characters (`source.Length - startIndex`).
- **Issue doc removed:** `issue-01-critical-substring-length-bug.md`

### 2) List equality null-element semantics

- **Spec basis:** For list equality, null elements are considered equal.
- **Current status:** **Resolved**.
- **Verification note:** List equality handles `(null, null)` element pairs as equal and tests cover matching-null-element scenarios.
- **Issue doc removed:** `issue-03-high-list-equality-null-elements.md`

### 3) Power typing/null handling alignment

- **Spec basis:** Non-representable results should return `null`; behavior should preserve numeric semantics.
- **Current status:** **Resolved**.
- **Verification note:** `Power(int?, int?)` and `Power(long?, long?)` now return `decimal?`, runtime handles overflow/non-representable outcomes as `null`, and CQL-to-ELM typing is aligned to decimal.
- **Issue doc removed:** `issue-05-high-power-operator-null-return.md`

---

## Open Findings

### 4) EndsWith bounds and empty suffix handling

- **Current status:** **Open**.
- **Why still open:** `EndsWith` still uses `Substring(argument.Length - suffix.Length)` without explicit oversized-suffix guard or explicit empty-suffix handling.
- **Tracking doc:** [issue-02-high-endswith-bounds-check.md](issue-02-high-endswith-bounds-check.md)

### 5) Round negative midpoint test expectations

- **Current status:** **Open (test expectations)**.
- **Why still open:** Runtime rounding behavior is correct (`AwayFromZero`), but test XML still expects `Round(-0.5) -> 0.0` and `Round(-1.5) -> -1.0`, and both remain skipped.
- **Tracking doc:** [issue-04-high-round-test-expectations.md](issue-04-high-round-test-expectations.md)

### 6) Matches auto-anchoring / partial-match semantics

- **Current status:** **Open**.
- **Why still open:** `Matches` still auto-prepends/appends `^`/`$` and uses `pattern[0].Equals("^")` style comparisons.
- **Tracking doc:** [issue-06-medium-matches-operator-anchoring.md](issue-06-medium-matches-operator-anchoring.md)

### 7) Expand tests still skipped

- **Current status:** **Open (test coverage)**.
- **Why still open:** `ExpandPer1` and `ExpandPerHour` remain in skipped test metadata and are not yet verified as active passing coverage.
- **Tracking doc:** [issue-07-low-unskip-expand-tests.md](issue-07-low-unskip-expand-tests.md)

---

## Current Summary Matrix

| Item | Status | Priority | Notes |
|------|--------|----------|-------|
| Substring length | RESOLVED | Critical (historical) | Issue doc removed |
| List equality nulls | RESOLVED | High (historical) | Issue doc removed |
| Power behavior/typing | RESOLVED | High (historical) | Issue doc removed |
| EndsWith bounds/empty suffix | OPEN | High | Runtime change needed |
| Round negative midpoint tests | OPEN | High | Test expectation + skip cleanup needed |
| Matches anchoring | OPEN | Medium | Runtime semantics change needed |
| Expand skipped tests | OPEN | Low | Enable and validate test coverage |

---

## Next Focus

1. Complete `EndsWith` spec-edge handling.
2. Correct and unskip Round negative midpoint tests.
3. Update `Matches` to spec-aligned matching behavior.
4. Unskip and validate Expand coverage.
