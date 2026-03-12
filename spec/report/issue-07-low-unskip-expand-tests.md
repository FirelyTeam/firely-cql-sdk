# [LOW] Unskip Expand tests - they match the spec

**Labels:** `test-fix`, `spec-conformance`, `low`, `interval-operators`  
**Priority:** LOW  
**Spec Reference:** CQL 1.5.3 spec line 4329, 4338

## Description

The Expand operator tests are currently skipped with a comment suggesting the test expectations are wrong. However, after reviewing the CQL specification, **the test expectations are actually CORRECT** and match the spec examples exactly. These tests should be unskipped.

## CQL Specification Quote

**Lines 4329-4339:**
> "If the interval boundaries are more precise than the per quantity, the more precise values will be **truncated to the precision specified by the per quantity**. In these cases, the resulting list of intervals may be more broad than the input range due to this truncation. For example:
>
> ```cql
> expand { Interval[@T10:00, @T12:30] } per hour
> expand { Interval[10.0, 12.5] } per 1
> ```
>
> The above examples would result in:
>
> ```cql
> { Interval[@T10, @T10], Interval[@T11, @T11], Interval[@T12, @T12] }
> { Interval[10, 10], Interval[11, 11], Interval[12, 12] }
> ```

**Note:** The spec shows `Interval[10, 10]` (integer) not `Interval[10.0, 10.0]` (decimal).

## Current Skipped Tests

**From `SkippedTests.cs` lines 72-73:**
```csharp
{ "ExpandPer1", "The expectation should have decimal values, not integers; the test does not compile in reference cql-to-elm" },
{ "ExpandPerHour", "The expectation does not match the same example as published in the specification" },
```

## Test Expectations (CORRECT ✓)

**File:** `Cql/CqlToElmTests/Input/DQIC/CqlIntervalOperatorsTest.xml`

### Test: ExpandPer1
```xml
<test name="ExpandPer1">
    <expression>expand { Interval[10.0, 12.5] } per 1</expression>
    <output>{ Interval[10, 10], Interval[11, 11], Interval[12, 12] }</output>
    <!-- Translation Error: Could not resolve call to operator Expand with signature (list<interval<System.Decimal>>,System.Integer). -->
</test>
```

**This MATCHES the spec example on line 4338!** ✓

The comment about "should have decimal values" is **incorrect** - the spec explicitly shows integer intervals when truncated to `per 1` precision.

### Test: ExpandPerHour
```xml
<test name="ExpandPerHour">
    <expression>expand { Interval[@T10:00, @T12:30] } per hour</expression>
    <output>{ Interval[@T10:00, @T11:00), Interval[@T11:00, @T12:00) }</output>
</test>
```

**Expected per spec (line 4337):**
```cql
{ Interval[@T10, @T10], Interval[@T11, @T11], Interval[@T12, @T12] }
```

The test expectation **differs slightly** from the spec:
- Test shows: `[@T10:00, @T11:00)` (half-open intervals with minutes)
- Spec shows: `[@T10, @T10]` (closed intervals truncated to hours)

## What Needs to Happen

1. **ExpandPer1:** 
   - Test expectation is CORRECT per spec
   - Remove from skipped tests
   - Fix compilation error if needed (signature resolution)
   - Verify implementation produces correct output

2. **ExpandPerHour:**
   - Update test expectation to match spec exactly
   - Change to: `{ Interval[@T10, @T10], Interval[@T11, @T11], Interval[@T12, @T12] }`
   - Remove from skipped tests
   - Verify implementation

## Impact

- **Risk:** VERY LOW - just enabling tests that match spec
- **Breaking Change:** No - verifying spec-compliant behavior
- **Test Impact:** Two tests move from skipped to active

## Acceptance Criteria

- [ ] For **ExpandPer1**:
  - [ ] Verify implementation truncates to integer precision
  - [ ] Fix any compilation/signature resolution issues
  - [ ] Remove from `SkippedTests.DoesNotMatchExpectation`
  - [ ] Verify test passes

- [ ] For **ExpandPerHour**:
  - [ ] Update expected output to match spec (closed intervals, truncated precision)
  - [ ] Remove from `SkippedTests.DoesNotMatchExpectation`
  - [ ] Verify test passes

- [ ] Verify Expand implementation correctly:
  - [ ] Truncates interval boundaries to `per` precision
  - [ ] Returns intervals at the truncated precision level
  - [ ] Handles both temporal and numeric intervals

## Related Files

- Implementation: `Cql/Cql.Runtime/Operators/CqlOperators.IntervalOperators.cs` (search for Expand)
- Skipped Tests: `Cql/CqlToElmTests/(tests)/SkippedTests.cs:72-73`
- Test XML: `Cql/CqlToElmTests/Input/DQIC/CqlIntervalOperatorsTest.xml`
- Spec: `spec/1.5.3 - Release 1 Errata 2/site/09-b-cqlreference.html:4293-4350`

## Investigation Notes

The comment "test does not compile in reference cql-to-elm" suggests there may be a signature resolution issue. This might be:
- Missing overload for `expand(list<interval<decimal>>, integer)`
- Type inference issue
- Something else

Need to investigate if this is an implementation gap or just a test setup issue.

## Reference

- Spec Verified Findings: `spec-report/spec-verified-findings.md` (Critical Finding #7)
- Deviations Report: `spec-report/cql-spec-deviations-report.md` (Deviation #4)
