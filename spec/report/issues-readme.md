# GitHub Issues - CQL Spec Conformance Fixes

This directory contains ready-to-use GitHub issue templates for CQL specification conformance fixes.

## How to Use

1. Open the markdown file for the issue you want to create
2. Copy the entire content
3. Go to GitHub Issues and click "New Issue"
4. Paste the content into the issue description
5. The title is on the first line (after the #)
6. Add the labels mentioned in the file

## Issues List

### Critical Priority

- **[issue-01-critical-substring-length-bug.md](issue-01-critical-substring-length-bug.md)** - [CRITICAL]
  - **Bug:** Substring uses wrong length calculation
  - **Impact:** Can throw exceptions or return incorrect results
  - **Fix:** Change `source.Length` to `source.Length - startIndex`

### High Priority

- **[issue-02-high-endswith-bounds-check.md](issue-02-high-endswith-bounds-check.md)** - [HIGH]
  - **Bug:** Missing bounds check, throws on oversized suffix
  - **Impact:** Throws exceptions for valid inputs
  - **Fix:** Add bounds check and empty string handling

- **[issue-03-high-list-equality-null-elements.md](issue-03-high-list-equality-null-elements.md)** - [HIGH]
  - **Spec Violation:** Null elements should be considered equal
  - **Impact:** Incorrect equality results for lists with nulls
  - **Fix:** Treat `null == null` as `true` in list comparisons

- **[issue-04-high-round-test-expectations.md](issue-04-high-round-test-expectations.md)** - [HIGH]
  - **Test Issue:** Implementation is CORRECT, tests are WRONG
  - **Impact:** None - just fix test expectations
  - **Fix:** Update test XML to expect `-1.0` instead of `0.0`

- **[issue-05-high-power-operator-null-return.md](issue-05-high-power-operator-null-return.md)** - [HIGH]
  - **Bug:** Returns `0` instead of `null` for fractional results
  - **Impact:** Loses precision, violates spec
  - **Fix:** Return `null` when result cannot be represented
  - **Affects:** 10 skipped tests

### Medium Priority

- **[issue-06-medium-matches-operator-anchoring.md](issue-06-medium-matches-operator-anchoring.md)** - [MEDIUM]
  - **Bug:** Auto-anchors patterns, violates "partial matching"
  - **Impact:** Prevents partial regex matches
  - **Fix:** Remove auto-anchoring, fix char comparison

### Low Priority

- **[issue-07-low-unskip-expand-tests.md](issue-07-low-unskip-expand-tests.md)** - [LOW]
  - **Test Issue:** Tests are correct, just need unskipping
  - **Impact:** None - enables existing correct tests
  - **Fix:** Remove from SkippedTests, verify they pass

## Summary Statistics

- **Total Issues:** 7
- **Critical:** 1
- **High:** 4
- **Medium:** 1
- **Low:** 1

## Issue Contents

Each issue template includes:

✅ **Title and Labels** - Ready-to-use title with severity  
✅ **Spec References** - Direct quotes with line numbers from CQL 1.5.3  
✅ **Current Implementation** - Code snippets with file paths  
✅ **Problem Explanation** - Clear description with examples  
✅ **Proposed Fix** - Complete solution with code  
✅ **Impact Analysis** - Risk, breaking changes, test impact  
✅ **Acceptance Criteria** - Checklist of required work  
✅ **Related Files** - All relevant file paths  
✅ **References** - Links to spec reports  

## Related Documentation

- **[spec-verified-findings.md](spec-verified-findings.md)** - Detailed findings with spec quotes
- **[cql-spec-deviations-report.md](cql-spec-deviations-report.md)** - Comprehensive analysis
- **[spec-content-guide.md](spec-content-guide.md)** - Guide for providing spec content

## Recommended Implementation Order

1. **Issue #01** (CRITICAL) - Substring bug - fix immediately
2. **Issue #02** (HIGH) - EndsWith - prevents exceptions
3. **Issue #04** (HIGH) - Round tests - easy win, just test fixes
4. **Issue #03** (HIGH) - List equality - spec violation
5. **Issue #05** (HIGH) - Power operator - affects 10 tests
6. **Issue #06** (MEDIUM) - Matches - regex behavior
7. **Issue #07** (LOW) - Expand - just unskip tests

---

**Generated:** 2026-02-19  
**CQL Version:** 1.5.3 Release 1 Errata 2  
**Spec Location:** `spec/1.5.3 - Release 1 Errata 2/site/`
