# [HIGH] Update Round test expectations - implementation is correct

**Labels:** `test-fix`, `spec-conformance`, `high`, `arithmetic-operators`  
**Priority:** HIGH  
**Spec Reference:** CQL 1.5.3 spec line 3018, 3032

## Description

**GOOD NEWS:** The Round operator implementation is **CORRECT** and matches the CQL specification! 

The issue is that the **test expectations are wrong**. The XML tests expect incorrect values that don't match the spec. This issue is to update the test expectations to match the specification.

## CQL Specification Quote

**Line 3018:**
> "The Round operator returns the nearest whole number to its argument. The semantics of round are defined as a traditional round (i.e. to the nearest whole number), meaning that a decimal value greater than or equal to 0.5 and less than 1.0 will round to 1, **and a decimal value less than or equal to -0.5 and greater than -1.0 will round to -1**."

**Spec Example (Line 3032):**
```cql
define "RoundNegativePointFive": Round(-0.5) // -1
```

The spec explicitly states `-0.5` rounds to `-1` (away from zero).

## Current Implementation (CORRECT ✓)

**File:** `Cql/Cql.Runtime/Operators/CqlOperators.ArithmeticOperators.cs` (Lines 705-709)

```csharp
public decimal? Round(decimal? argument, int? precision)
{
    if (argument == null) return null;
    else return Math.Round(argument.Value, precision ?? 0, MidpointRounding.AwayFromZero);
    // ✅ This is CORRECT - uses AwayFromZero per spec
}
```

`MidpointRounding.AwayFromZero` behavior:
- `Round(0.5)` → `1` ✓
- `Round(-0.5)` → `-1` ✓ (away from zero)
- `Round(1.5)` → `2` ✓
- `Round(-1.5)` → `-2` ✓ (away from zero)

This **matches the spec exactly**.

## The Problem: Test Expectations are WRONG

**File:** `Cql/CqlToElmTests/Input/DQIC/CqlArithmeticFunctionsTest.xml`

**Currently in `SkippedTests.cs` lines 77-78:**
```csharp
{ "RoundNeg0D5", "This rounding test doesn't behave like the others" },
{ "RoundNeg1D5", "This rounding test doesn't behave like the others" },
```

### Test 1: RoundNeg0D5

**Current (WRONG):**
```xml
<test name="RoundNeg0D5">
    <expression>Round(-0.5)</expression>
    <output>0.0</output>  <!-- ❌ WRONG! -->
</test>
```

**Should be (per spec line 3032):**
```xml
<test name="RoundNeg0D5">
    <expression>Round(-0.5)</expression>
    <output>-1.0</output>  <!-- ✅ CORRECT -->
</test>
```

### Test 2: RoundNeg1D5

**Current (WRONG):**
```xml
<test name="RoundNeg1D5">
    <expression>Round(-1.5)</expression>
    <output>-1.0</output>  <!-- ❌ WRONG! -->
</test>
```

**Should be (following spec pattern):**
```xml
<test name="RoundNeg1D5">
    <expression>Round(-1.5)</expression>
    <output>-2.0</output>  <!-- ✅ CORRECT -->
</test>
```

## What Needs to Change

1. **Update XML test expectations** in `CqlArithmeticFunctionsTest.xml`
2. **Remove from skipped tests** in `SkippedTests.cs`
3. **Verify tests pass** with correct expectations

## Impact

- **Risk:** VERY LOW - just fixing incorrect test expectations
- **Breaking Change:** No - implementation already correct
- **Code Changes:** None to implementation, only test expectations

## Acceptance Criteria

- [ ] Update `RoundNeg0D5` expected output from `0.0` to `-1.0`
- [ ] Update `RoundNeg1D5` expected output from `-1.0` to `-2.0`
- [ ] Remove both tests from `SkippedTests.DoesNotMatchExpectation`
- [ ] Run Round tests - verify they now pass
- [ ] Verify no other Round tests are affected
- [ ] Document in commit: "Tests were wrong, implementation was correct"

## Related Files

- **Tests to Update:** `Cql/CqlToElmTests/Input/DQIC/CqlArithmeticFunctionsTest.xml`
  - Find `<test name="RoundNeg0D5">` - change output to `-1.0`
  - Find `<test name="RoundNeg1D5">` - change output to `-2.0`

- **Skipped Tests:** `Cql/CqlToElmTests/(tests)/SkippedTests.cs:77-78`
  - Remove `RoundNeg0D5` entry
  - Remove `RoundNeg1D5` entry

- **Implementation (NO CHANGES NEEDED):** `Cql/Cql.Runtime/Operators/CqlOperators.ArithmeticOperators.cs:705-709`

- **Spec:** `spec/1.5.3 - Release 1 Errata 2/site/09-b-cqlreference.html:3008-3033`

## Reference

- Spec Verified Findings: `spec-report/spec-verified-findings.md` (Critical Finding #1)
- Deviations Report: `spec-report/cql-spec-deviations-report.md` (Deviation #3)
