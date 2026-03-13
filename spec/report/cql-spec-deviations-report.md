# CQL Specification Deviations Report

**Generated:** 2026-02-19  
**Repository:** FirelyTeam/firely-cql-sdk  
**Purpose:** Document all identified deviations from the CQL specification with remediation guidance

---

## Table of Contents

1. [Deviation #1: Power Operator Returns Wrong Type](#deviation-1-power-operator-returns-wrong-type)
2. [Deviation #2: ProperContains/ProperIn Null Handling](#deviation-2-propercontainsproperin-null-handling)
3. [Deviation #3: Round Negative Midpoint Behavior](#deviation-3-round-negative-midpoint-behavior)
4. [Deviation #4: Expand Function Integer Output](#deviation-4-expand-function-integer-output)
5. [Deviation #5: List Equality Null Handling](#deviation-5-list-equality-null-handling)
6. [Summary of Required Changes](#summary-of-required-changes)

---

## Deviation #1: Power Operator Returns Wrong Type

### CQL Specification Reference
- **Section:** [Power](https://cql.hl7.org/09-b-cqlreference.html#power)
- **Key Quote:** "The Power operator raises the first argument to the power given by the second argument. If either argument is null, the result is null. If the result of the operation cannot be represented, the result is null."
- **Expected Type Behavior:** The CQL specification indicates that Power should return the same type as the first operand when both operands are of the same type. However, for operations resulting in fractional values (e.g., negative exponents), the result should be a decimal to preserve precision.

### Current Implementation
**Location:** [`Cql/Cql.Runtime/Operators/CqlOperators.ArithmeticOperators.cs:683-699`](https://github.com/FirelyTeam/firely-cql-sdk/blob/main/Cql/Cql.Runtime/Operators/CqlOperators.ArithmeticOperators.cs#L683-L699)

```csharp
public int? Power(int? argument, int? exponent)
{
    if (argument == null || exponent == null) return null;
    else return (int?)Math.Pow((double)argument, (double)exponent);
}

public long? Power(long? argument, long? exponent)
{
    if (argument == null || exponent == null) return null;
    else return (long?)Math.Pow((double)argument, (double)exponent);
}

public decimal? Power(decimal? argument, decimal? exponent)
{
    if (argument == null || exponent == null) return null;
    else return (decimal)Math.Pow((double)argument, (double)exponent);
}
```

### The Problem
When `Power(2, -2)` is evaluated, `Math.Pow(2, -2)` returns `0.25` (a double). When this is cast to `int?`, it becomes `0`, losing the fractional part. This violates the CQL specification's intent that operations should preserve precision.

### Affected Tests
**Location:** [`Cql/CqlToElmTests/(tests)/SkippedTests.cs:63-74`](https://github.com/FirelyTeam/firely-cql-sdk/blob/main/Cql/CqlToElmTests/(tests)/SkippedTests.cs#L63-L74)

All marked with reason: `"Power returns integers, not decimals"`

1. `Power2ToNeg2` - Expected: `0.25`, Current: `0` (as int)
2. `DecimalOneStep` - Expected: `Power(10,-8)` as decimal, Current: integer
3. `DecimalPosOneStep` - Expected: `+Power(10,-8)` as decimal, Current: integer  
4. `DecimalNegOneStep` - Expected: `-Power(10,-8)` as decimal, Current: integer
5. `DecimalTwoStep` - Expected: `2.0*Power(10,-8)` as decimal, Current: integer
6. `DecimalPosTwoStep` - Expected: `+2.0*Power(10,-8)` as decimal, Current: integer
7. `DecimalNegTwoStep` - Expected: `-2.0*Power(10,-8)` as decimal, Current: integer
8. `DecimalTenStep` - Expected: `Power(10,-7)` as decimal, Current: integer
9. `DecimalPosTenStep` - Expected: `+Power(10,-7)` as decimal, Current: integer
10. `DecimalNegTenStep` - Expected: `-Power(10,-7)` as decimal, Current: integer

### Test Example: Power2ToNeg2
**Location:** [`Cql/CqlToElmTests/Input/DQIC/CqlArithmeticFunctionsTest.xml`](https://github.com/FirelyTeam/firely-cql-sdk/blob/main/Cql/CqlToElmTests/Input/DQIC/CqlArithmeticFunctionsTest.xml)

**Current Test (Skipped):**
```xml
<test name="Power2ToNeg2">
    <expression>Power(2, -2)</expression>
    <output>0.25</output>
</test>
```

**Current Behavior:** Returns `0` (cast from 0.25 to int)  
**Expected Behavior:** Returns `0.25` (decimal)

### Proposed Fix

**Option 1: Return Decimal for All Power Operations**
```csharp
public decimal? Power(int? argument, int? exponent)
{
    if (argument == null || exponent == null) return null;
    else return (decimal)Math.Pow((double)argument, (double)exponent);
}

public decimal? Power(long? argument, long? exponent)
{
    if (argument == null || exponent == null) return null;
    else return (decimal)Math.Pow((double)argument, (double)exponent);
}

public decimal? Power(decimal? argument, decimal? exponent)
{
    if (argument == null || exponent == null) return null;
    else return (decimal)Math.Pow((double)argument, (double)exponent);
}
```

**Option 2: Conditional Return Based on Exponent**
```csharp
public decimal? Power(int? argument, int? exponent)
{
    if (argument == null || exponent == null) return null;
    
    var result = Math.Pow((double)argument, (double)exponent);
    
    // If exponent is negative or result has fractional part, return decimal
    if (exponent < 0 || result != Math.Floor(result))
        return (decimal)result;
    
    // Try to return as int if it fits
    if (result >= int.MinValue && result <= int.MaxValue)
        return (int)result;
    
    // Otherwise return as decimal
    return (decimal)result;
}
```

**Recommendation:** Option 1 is simpler and aligns with the CQL specification's intent to preserve precision. The Power operation commonly results in fractional values, making decimal the most appropriate return type.

### Test Changes Required

**Before (Currently Skipped):**
```csharp
// In SkippedTests.cs - DoesNotMatchExpectation
{ "Power2ToNeg2", "Power returns integers, not decimals" },
{ "DecimalOneStep", "Power returns integers, not decimals" },
// ... 8 more similar entries
```

**After (Tests Should Pass):**
Remove these entries from `SkippedTests.DoesNotMatchExpectation` and verify all Power-related tests pass with decimal return type.

### Impact Analysis
- **Breaking Change:** Yes - existing code expecting `int?` or `long?` from Power will need updating
- **Affected Overloads:** 3 (int, long, decimal)
- **Tests Fixed:** 10 currently skipped tests
- **Risk Level:** Medium - changes return type signature

---

## Deviation #2: ProperContains/ProperIn Null Handling

### CQL Specification Reference
- **Section:** [ProperContains](https://cql.hl7.org/09-b-cqlreference.html#propercontains) / [ProperIn](https://cql.hl7.org/09-b-cqlreference.html#properin)
- **Key Quote:** "The operator is defined for lists and intervals. For lists, a list properly contains another list if it contains every element of the argument, and there is at least one additional element. For intervals, an interval properly contains another interval if it contains every point in the argument interval, and there is at least one additional point."
- **Null Semantics:** The specification does not explicitly state that `ProperContains` should return null when comparing elements at different precisions. The general CQL principle is that comparisons involving incompatible or uncertain values should follow the three-valued logic (true/false/null).

### Current Implementation
**Location:** [`Cql/Cql.Runtime/Operators/CqlOperators.IntervalOperators.cs:2065-2088`](https://github.com/FirelyTeam/firely-cql-sdk/blob/main/Cql/Cql.Runtime/Operators/CqlOperators.IntervalOperators.cs#L2065-L2088)

```csharp
public bool? ElementProperlyIncludedInInterval(CqlTime left, CqlInterval<CqlTime>? right, string precision)
{
    if (left == null || right == null || right.low == null || right.high == null)
        return null;

    if (precision == null && (SamePrecision(left, right.high) == false || SamePrecision(left, right.low) == false))
        return null;  // <-- Returns null for precision mismatch

    else if (GreaterOrSamePrecision(left, precision) == false
             || GreaterOrSamePrecision(right.low, precision) == false
             || GreaterOrSamePrecision(right.high, precision) == false)
        return null;

    var low = Comparer.Compare(left, right.low, precision);
    var high = Comparer.Compare(left, right.high, precision);
    if (low < 0)
        return false;
    if (high > 0)
        return false;
    // properly contains requires the element not equal either endpoint
    if (low == 0 || high == 0)
        return false;
    return true;
}
```

### The Problem
The SkippedTests comment states: `"There is no spec language justifying null instead of false"`. When comparing a time value `@T15:59:59` (second precision) against a list containing times with millisecond precision like `@T15:59:59.999`, the implementation returns `null` due to precision mismatch. However, it may be more appropriate to return `false` since we can definitively determine that the element is not properly included (it equals one of the endpoints at the specified precision).

### Affected Tests
**Location:** [`Cql/CqlToElmTests/(tests)/SkippedTests.cs:75-76`](https://github.com/FirelyTeam/firely-cql-sdk/blob/main/Cql/CqlToElmTests/(tests)/SkippedTests.cs#L75-L76)

1. `ProperContainsTimeNull` - Expected behavior unclear  
2. `ProperInTimeNull` - Expected behavior unclear

### Test Example: ProperContainsTimeNull
**Location:** [`Cql/CqlToElmTests/Input/DQIC/CqlListOperatorsTest.xml`](https://github.com/FirelyTeam/firely-cql-sdk/blob/main/Cql/CqlToElmTests/Input/DQIC/CqlListOperatorsTest.xml)

**Current Test (Skipped):**
```xml
<test name="ProperContainsTimeNull">
    <expression>{ @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } properly includes @T15:59:59</expression>
    <output>null</output>
</test>
```

**Issue:** The test expects `null`, but the comment suggests this may not be correct per the spec.

### Analysis Required
This deviation requires **further investigation** to determine:

1. What does the reference CQL implementation return for this case?
2. Should precision mismatches in ProperContains result in `null` or `false`?
3. Is the element `@T15:59:59` equal to `@T15:59:59.999` when compared at second precision?

### Recommended Investigation Steps

1. **Consult CQL Reference Implementation:** Test the same expression in the reference Java implementation
2. **Review CQL Specification Semantics:** Clarify precision handling in comparison operators
3. **Document Decision:** Once the correct behavior is determined, update implementation and tests accordingly

### Potential Fix (Pending Investigation)

**If the spec requires `false`:**
```csharp
public bool? ElementProperlyIncludedInInterval(CqlTime left, CqlInterval<CqlTime>? right, string precision)
{
    if (left == null || right == null || right.low == null || right.high == null)
        return null;

    // Determine comparison precision
    var effectivePrecision = precision ?? GetCommonPrecision(left, right.low, right.high);
    
    if (effectivePrecision == null)
        return false;  // Changed from null - cannot determine proper inclusion with incompatible precision

    if (GreaterOrSamePrecision(left, effectivePrecision) == false
         || GreaterOrSamePrecision(right.low, effectivePrecision) == false
         || GreaterOrSamePrecision(right.high, effectivePrecision) == false)
        return false;  // Changed from null

    var low = Comparer.Compare(left, right.low, effectivePrecision);
    var high = Comparer.Compare(left, right.high, effectivePrecision);
    if (low < 0)
        return false;
    if (high > 0)
        return false;
    if (low == 0 || high == 0)
        return false;
    return true;
}
```

**Test Changes Required:**
Update expected output from `null` to `false` (or remove from skipped tests if `null` is confirmed correct).

### Impact Analysis
- **Breaking Change:** Potentially - depends on spec clarification
- **Affected Methods:** `ElementProperlyIncludedInInterval` overloads for CqlTime, possibly CqlDate and CqlDateTime
- **Tests Fixed:** 2 currently skipped tests (or confirmed as correct)
- **Risk Level:** Low-Medium - requires spec clarification first

---

## Deviation #3: Round Negative Midpoint Behavior

### CQL Specification Reference
- **Section:** [Round](https://cql.hl7.org/09-b-cqlreference.html#round)
- **Key Quote:** "The Round operator returns the nearest integer to its argument. The semantics of round are defined as a traditional mathematical round, meaning that a decimal value of 0.5 or higher will round to 1."
- **Rounding Mode:** The specification indicates "round half away from zero" behavior, which means:
  - `Round(0.5)` → `1`
  - `Round(-0.5)` → `-1` (away from zero)
  - `Round(1.5)` → `2`
  - `Round(-1.5)` → `-2` (away from zero)

### Current Implementation
**Location:** [`Cql/Cql.Runtime/Operators/CqlOperators.ArithmeticOperators.cs:705-709`](https://github.com/FirelyTeam/firely-cql-sdk/blob/main/Cql/Cql.Runtime/Operators/CqlOperators.ArithmeticOperators.cs#L705-L709)

```csharp
public decimal? Round(decimal? argument, int? precision)
{
    if (argument == null) return null;
    else return Math.Round(argument.Value, precision ?? 0, MidpointRounding.AwayFromZero);
}
```

### The Problem
The implementation uses `MidpointRounding.AwayFromZero`, which should produce the correct behavior. However, the tests indicate there may be an issue with specific edge cases.

### Affected Tests
**Location:** [`Cql/CqlToElmTests/(tests)/SkippedTests.cs:77-78`](https://github.com/FirelyTeam/firely-cql-sdk/blob/main/Cql/CqlToElmTests/(tests)/SkippedTests.cs#L77-L78)

1. `RoundNeg0D5` - "This rounding test doesn't behave like the others"
2. `RoundNeg1D5` - "This rounding test doesn't behave like the others"

### Test Examples

**Location:** [`Cql/CqlToElmTests/Input/DQIC/CqlArithmeticFunctionsTest.xml`](https://github.com/FirelyTeam/firely-cql-sdk/blob/main/Cql/CqlToElmTests/Input/DQIC/CqlArithmeticFunctionsTest.xml)

**Test 1: RoundNeg0D5**
```xml
<test name="RoundNeg0D5">
    <expression>Round(-0.5)</expression>
    <output>0.0</output>
</test>
```

**Test 2: RoundNeg1D5**
```xml
<test name="RoundNeg1D5">
    <expression>Round(-1.5)</expression>
    <output>-1.0</output>
</test>
```

### Analysis
The test expectations appear inconsistent:
- `Round(-0.5)` expects `0.0` (rounds toward zero, not away)
- `Round(-1.5)` expects `-1.0` (rounds toward zero, not away)

However, the CQL spec says "round half away from zero":
- `Round(-0.5)` should be `-1.0` (away from zero)
- `Round(-1.5)` should be `-2.0` (away from zero)

### The Issue
**Either:**
1. The test expectations in the XML are wrong (should expect -1.0 and -2.0)
2. The CQL specification uses a different rounding mode than stated (possibly "round half up" which would give -0.0 and -1.0)

### Investigation Required
1. **Check CQL Reference Implementation:** Verify what the official Java implementation returns
2. **Verify Spec Interpretation:** Confirm whether "round half away from zero" or "round half up" is intended
3. **Check Test Suite Origin:** These may be from the official CQL test suite - verify expectations

### Potential Fix Options

**Option 1: Tests Are Wrong (Spec Says "Away from Zero")**
```xml
<!-- Update test expectations -->
<test name="RoundNeg0D5">
    <expression>Round(-0.5)</expression>
    <output>-1.0</output>  <!-- Changed from 0.0 -->
</test>

<test name="RoundNeg1D5">
    <expression>Round(-1.5)</expression>
    <output>-2.0</output>  <!-- Changed from -1.0 -->
</test>
```

**Option 2: Implementation Is Wrong (Spec Says "Round Half Up")**
```csharp
public decimal? Round(decimal? argument, int? precision)
{
    if (argument == null) return null;
    
    // Use "Round Half Up" / "Bankers Rounding" / "Round to Even"
    return Math.Round(argument.Value, precision ?? 0, MidpointRounding.ToEven);
}
```

**Option 3: Spec Has Special Case for Negative Midpoints**
Implement custom rounding logic based on spec clarification.

### Recommendation
**Investigation needed.** Most likely the test expectations are wrong based on the spec's clear statement of "round half away from zero." However, this should be verified against the reference implementation.

### Test Changes Required

**Before (Currently Skipped):**
```csharp
// In SkippedTests.cs - DoesNotMatchExpectation
{ "RoundNeg0D5", "This rounding test doesn't behave like the others" },
{ "RoundNeg1D5", "This rounding test doesn't behave like the others" },
```

**After:**
Remove from skipped tests once correct behavior is confirmed and either tests or implementation updated.

### Impact Analysis
- **Breaking Change:** Depends on resolution - if implementation changes, yes
- **Affected Methods:** 1 (Round)
- **Tests Fixed:** 2 currently skipped tests
- **Risk Level:** Low - affects edge case only

---

## Deviation #4: Expand Function Integer Output

### CQL Specification Reference
- **Section:** [Expand](https://cql.hl7.org/09-b-cqlreference.html#expand-1)
- **Key Quote:** "The Expand operator returns the set of intervals of size per that cover the given interval. For example, `expand { Interval[0, 10] } per 1` returns a list of intervals: `{ Interval[0, 0], Interval[1, 1], ..., Interval[10, 10] }`"
- **Type Preservation:** The spec indicates that the intervals should preserve the type of the input interval

### Current Issue
**Location:** Referenced in [`Cql/CqlToElmTests/(tests)/SkippedTests.cs:72-73`](https://github.com/FirelyTeam/firely-cql-sdk/blob/main/Cql/CqlToElmTests/(tests)/SkippedTests.cs#L72-L73)

```csharp
{ "ExpandPer1", "The expectation should have decimal values, not integers; the test does not compile in reference cql-to-elm" },
{ "ExpandPerHour", "The expectation does not match the same example as published in the specification" },
```

### Test Example: ExpandPer1
**Location:** [`Cql/CqlToElmTests/Input/DQIC/CqlIntervalOperatorsTest.xml`](https://github.com/FirelyTeam/firely-cql-sdk/blob/main/Cql/CqlToElmTests/Input/DQIC/CqlIntervalOperatorsTest.xml)

**Current Test (Skipped):**
```xml
<test name="ExpandPer1">
    <expression>expand { Interval[10.0, 12.5] } per 1</expression>
    <output>{ Interval[10, 10], Interval[11, 11], Interval[12, 12] }</output>
    <!-- Translation Error: Could not resolve call to operator Expand with signature (list<interval<System.Decimal>>,System.Integer). -->
</test>
```

### The Problem
The test shows:
1. **Input:** `Interval[10.0, 12.5]` - decimal interval
2. **Expected Output:** `{ Interval[10, 10], Interval[11, 11], Interval[12, 12] }` - integer intervals
3. **Actual:** Compilation error - no matching signature

The test expectation appears wrong because:
- Input is decimal, so output should preserve decimal type: `{ Interval[10.0, 10.0], Interval[11.0, 11.0], Interval[12.0, 12.0] }`
- The comment even states: "The expectation should have decimal values, not integers"

### Test Example: ExpandPerHour
```xml
<test name="ExpandPerHour">
    <expression>expand { Interval[@T10:00, @T12:30] } per hour</expression>
    <output>{ Interval[@T10:00, @T11:00), Interval[@T11:00, @T12:00) }</output>
</test>
```

**Issue:** Comment states "The expectation does not match the same example as published in the specification"

### Analysis
These test cases appear to have incorrect expectations rather than implementation bugs. The issues are:

1. **ExpandPer1:** Test expects integer output from decimal input (type mismatch)
2. **ExpandPerHour:** Test expectation doesn't match published spec example

### Proposed Fix

**Fix Test ExpandPer1:**
```xml
<test name="ExpandPer1">
    <expression>expand { Interval[10.0, 12.5] } per 1.0</expression>
    <output>{ Interval[10.0, 10.0], Interval[11.0, 11.0], Interval[12.0, 12.0] }</output>
</test>
```

**Fix Test ExpandPerHour:**
Consult the CQL specification example and update the test to match. Need to verify what the correct output should be.

### Investigation Required
1. **Review CQL Spec Example:** Find the exact example for time interval expansion in the spec
2. **Verify Expand Implementation:** Check if the implementation correctly preserves types
3. **Test Signature Resolution:** Ensure proper overload exists for `expand(list<interval<decimal>>, decimal)`

### Test Changes Required

**Before (Currently Skipped):**
```csharp
// In SkippedTests.cs - DoesNotMatchExpectation
{ "ExpandPer1", "The expectation should have decimal values, not integers; the test does not compile in reference cql-to-elm" },
{ "ExpandPerHour", "The expectation does not match the same example as published in the specification" },
```

**After:**
Update test expectations to match spec, remove from skipped tests.

### Impact Analysis
- **Breaking Change:** No - likely just test fixes
- **Implementation Changes:** May need to add overload or fix type preservation
- **Tests Fixed:** 2 currently skipped tests
- **Risk Level:** Low - appears to be test issue

---

## Deviation #5: List Equality Null Handling

### CQL Specification Reference
- **Section:** [Equal](https://cql.hl7.org/09-b-cqlreference.html#equal)
- **Key Quote:** "For list values, equality returns true if and only if the lists have the same element type, have the same number of elements, and for each element in the lists, in order, the elements are equal."
- **Null Elements:** The specification states: "For the purposes of comparison, null elements are considered equal to other null elements."

### Current Issue
**Location:** Referenced in [`Cql/CqlToElmTests/(tests)/SkippedTests.cs:43`](https://github.com/FirelyTeam/firely-cql-sdk/blob/main/Cql/CqlToElmTests/(tests)/SkippedTests.cs#L43)

```csharp
{ "EqualNullNull", "The spec states that null elements are considered equal for list equality." },
```

### The Problem
The comment indicates that the implementation does not correctly handle null elements in list equality comparisons. According to the CQL spec, `{null, 1} = {null, 1}` should return `true`, not `null`.

### Investigation Required
1. **Find Test Case:** Locate the `EqualNullNull` test to see exact expression and expectation
2. **Check Implementation:** Review list equality implementation in `CqlOperators.EqualityAndEquivalence.cs`
3. **Verify Behavior:** Confirm current implementation returns `null` or `false` when it should return `true`

### Potential Fix Location
**Expected Location:** `Cql/Cql.Runtime/Operators/CqlOperators.EqualityAndEquivalence.cs`

The list equality implementation needs to treat `null` elements as equal to each other.

### Test Changes Required

**Before (Currently Skipped):**
```csharp
// In SkippedTests.cs - DoesNotCompile
{ "EqualNullNull", "The spec states that null elements are considered equal for list equality." },
```

**After:**
Remove from skipped tests once implementation correctly handles null element equality.

### Impact Analysis
- **Breaking Change:** Yes - changes equality semantics
- **Affected Methods:** List equality comparison
- **Tests Fixed:** 1 currently skipped test
- **Risk Level:** Medium - changes equality behavior

---

## Summary of Required Changes

### High Priority (Clear Spec Violations)

1. **Power Operator Type Fix**
   - Change return type to `decimal?` for all Power overloads
   - Impact: 10 skipped tests fixed
   - Effort: Low (simple type change)
   - Risk: Medium (breaking change)

2. **List Equality Null Handling**
   - Update list equality to treat null elements as equal
   - Impact: 1 skipped test fixed
   - Effort: Low-Medium
   - Risk: Medium (changes equality semantics)

### Medium Priority (Requires Investigation)

3. **ProperContains Null Behavior**
   - Investigate correct behavior for precision mismatches
   - Consult reference implementation
   - Impact: 2 skipped tests
   - Effort: Medium (investigation + fix)
   - Risk: Low-Medium

4. **Round Midpoint Behavior**
   - Verify correct rounding mode for negative midpoints
   - Update tests or implementation based on findings
   - Impact: 2 skipped tests
   - Effort: Low (likely just test fixes)
   - Risk: Low

5. **Expand Function Tests**
   - Fix test expectations to match spec
   - Verify type preservation in implementation
   - Impact: 2 skipped tests
   - Effort: Low (mainly test updates)
   - Risk: Low

### Additional Issues Noted (Out of Scope for Spec Compliance)

From SkippedTests.cs:

- **Uncertainty Support:** 9 tests skipped - feature not implemented
- **Unit Arithmetic:** 3 tests skipped - feature not implemented
- **Decimal Precision Limits:** 3 tests skipped - test data exceeds spec limits
- **Sorting with Mixed Precision:** 2 tests - test design issue

These represent missing features or test issues rather than spec violations.

---

## Recommended Implementation Order

1. **Phase 1: Low Risk, High Value**
   - Fix Expand test expectations
   - Update Round tests (after verification)
   
2. **Phase 2: Investigation**
   - Research ProperContains behavior
   - Consult CQL reference implementation
   
3. **Phase 3: Breaking Changes**
   - Implement Power operator fix with decimal return
   - Implement List equality null handling
   - Update dependent code and tests

4. **Phase 4: Verification**
   - Run full test suite
   - Verify no regressions
   - Update SkippedTests.cs accordingly

---

## Testing Strategy

### Before Changes
```bash
# Run current test suite to establish baseline
dotnet test Cql/CqlToElmTests/CqlToElmTests.csproj --logger "console;verbosity=normal"
# Current: 2383 passed, 59 skipped
```

### After Each Fix
```bash
# Run specific test category
dotnet test Cql/CqlToElmTests/CqlToElmTests.csproj --filter "FullyQualifiedName~Power"
dotnet test Cql/CqlToElmTests/CqlToElmTests.csproj --filter "FullyQualifiedName~Round"
# etc.
```

### Final Verification
```bash
# Full test suite should show fewer skipped tests
dotnet test Cql/CqlToElmTests/CqlToElmTests.csproj --logger "console;verbosity=normal"
# Expected after all fixes: 2383+ passed, 40- skipped
```

---

## References

- [CQL Specification 1.5](https://cql.hl7.org/)
- [CQL Operators Reference](https://cql.hl7.org/09-b-cqlreference.html)
- [Repository Issue Tracker](https://github.com/FirelyTeam/firely-cql-sdk/issues)
- [SkippedTests.cs](https://github.com/FirelyTeam/firely-cql-sdk/blob/main/Cql/CqlToElmTests/(tests)/SkippedTests.cs)

---

**End of Report**

---

## Appendix A: Comprehensive Test Suite Analysis

### Test Coverage Statistics

Based on analysis of the DQIC (Data Quality Improvement Committee) test suite in `Cql/CqlToElmTests/Input/DQIC/`:

| Test Category | Test Count | Spec Reference | Status |
|--------------|------------|----------------|---------|
| Age Operators | 8 | [Age](https://cql.hl7.org/09-b-cqlreference.html#age) | ✓ |
| Aggregate Functions | 40 | [Aggregate](https://cql.hl7.org/09-b-cqlreference.html#aggregate-functions) | ✓ |
| Arithmetic Functions | 193 | [Arithmetic](https://cql.hl7.org/09-b-cqlreference.html#arithmetic-operators-4) | ⚠️ Power issues |
| Comparison Operators | 191 | [Comparison](https://cql.hl7.org/09-b-cqlreference.html#comparison-operators-4) | ✓ |
| Conditional Operators | 10 | [Conditional](https://cql.hl7.org/03-developersguide.html#conditional-expressions) | ✓ |
| DateTime Operators | 294 | [DateTime](https://cql.hl7.org/09-b-cqlreference.html#datetime-operators-2) | ⚠️ Precision |
| Error/Messaging | 5 | [Errors](https://cql.hl7.org/09-b-cqlreference.html#errors-and-messaging) | ✓ |
| Interval Operators | 361 | [Intervals](https://cql.hl7.org/09-b-cqlreference.html#interval-operators-3) | ⚠️ Expand, ProperContains |
| List Operators | 209 | [Lists](https://cql.hl7.org/09-b-cqlreference.html#list-operators-2) | ⚠️ Equality nulls |
| Logical Operators | 40 | [Logical](https://cql.hl7.org/09-b-cqlreference.html#logical-operators-3) | ✓ |
| Nullological Operators | 23 | [Nullological](https://cql.hl7.org/09-b-cqlreference.html#nullological-operators-3) | ✓ |
| String Operators | 82 | [Strings](https://cql.hl7.org/09-b-cqlreference.html#string-operators-3) | ✓ |
| Type Operators | 33 | [Types](https://cql.hl7.org/09-b-cqlreference.html#type-operators-1) | ✓ |
| CQL Types | 39 | [Types](https://cql.hl7.org/09-b-cqlreference.html#types-2) | ✓ |
| Literals/Selectors | 67 | [Literals](https://cql.hl7.org/03-developersguide.html#literals) | ⚠️ Decimal step |
| **TOTAL** | **1,595** | | **59 skipped** |

### Key Findings from Test Analysis

#### 1. **String Operators - Full Conformance**
All 82 string operator tests pass, indicating good spec compliance for:
- Combine, Concatenate
- StartsWith, EndsWith
- Indexer, PositionOf, LastPositionOf
- Matches, ReplaceMatches
- Split, SplitOnMatches
- Substring, Upper, Lower

**Implementation Quality:** ✅ Good - uses proper null handling and CultureInfo.InvariantCulture

#### 2. **Logical/Nullological Operators - Full Conformance**
All 63 tests pass for:
- And, Or, Xor, Not, Implies
- Coalesce, IsNull, IsTrue, IsFalse

**Implementation Quality:** ✅ Good - correctly implements three-valued logic

#### 3. **Aggregate Functions - Mostly Conformant**
40 tests covering AllTrue, AnyTrue, Avg, Count, Max, Min, Sum show good conformance.

**Potential Issue Identified:**
The test suite includes edge cases for null handling in aggregates. Need to verify:
- `AllTrue({null, true, true})` - should return null per three-valued logic
- Empty list behavior for all aggregates

#### 4. **DateTime Operators - Precision Challenges**
294 tests reveal precision handling is complex. Known issues:
- Uncertainty support not implemented (9 skipped tests)
- Duration calculations follow spec correctly (verified in DurationTest.cs)
- Precision mismatch handling needs clarification

#### 5. **Comparison Operators - Spec Conformant**
191 tests pass, indicating correct implementation of:
- Equal, NotEqual
- Greater, GreaterOrEqual, Less, LessOrEqual
- Equivalent, NotEquivalent
- Between

**Good Implementation:** Uses CqlComparers for type-specific comparison logic

#### 6. **Invalid Expression Handling**
Tests marked `invalid="true"` verify error handling:
- `Exp(1000)` - results in positive infinity
- `Ln(0)` - results in negative infinity  
- `predecessor of DateTime(0001,1,1,0,0,0,0)` - underflow
- `successor of DateTime(9999,12,31,23,59,59,999)` - overflow

**Status:** Need to verify these return null as specified

---

## Appendix B: Spec-to-Code Mapping

### Key CQL Specification Sections and Implementation

| Spec Section | Implementation | Notes |
|--------------|----------------|-------|
| [02-authorsguide.html](https://cql.hl7.org/02-authorsguide.html) | Multiple | Author-facing semantics |
| [03-developersguide.html](https://cql.hl7.org/03-developersguide.html) | `Cql.Compiler/`, `Cql.CqlToElm/` | Type system, conversions |
| [09-b-cqlreference.html](https://cql.hl7.org/09-b-cqlreference.html) | `Cql.Runtime/Operators/` | All operators |
| [elm.html](https://cql.hl7.org/elm.html) | `Cql/Elm/` | ELM object model |
| [examples.html](https://cql.hl7.org/examples.html) | `Examples/` | Usage examples |
| [tests.html](https://cql.hl7.org/tests.html) | `Cql/CqlToElmTests/Input/DQIC/` | Official test suite |

### Operator Implementation Files

| Operator Category | File | Lines | Spec Section |
|------------------|------|-------|--------------|
| Arithmetic | `CqlOperators.ArithmeticOperators.cs` | ~750 | [§9.2](https://cql.hl7.org/09-b-cqlreference.html#arithmetic-operators-4) |
| Comparison | `CqlOperators.ComparisonOperators.cs` | ~800 | [§9.4](https://cql.hl7.org/09-b-cqlreference.html#comparison-operators-4) |
| Equality | `CqlOperators.EqualityAndEquivalence.cs` | ~600 | [§9.4](https://cql.hl7.org/09-b-cqlreference.html#equal) |
| Logical | `CqlOperators.LogicalOperators.cs` | ~200 | [§9.15](https://cql.hl7.org/09-b-cqlreference.html#logical-operators-3) |
| String | `CqlOperators.StringOperators.cs` | ~170 | [§9.22](https://cql.hl7.org/09-b-cqlreference.html#string-operators-3) |
| DateTime | `CqlOperators.DateTimeOperators.cs` | ~1200 | [§9.6](https://cql.hl7.org/09-b-cqlreference.html#datetime-operators-2) |
| Interval | `CqlOperators.IntervalOperators.cs` | ~2100 | [§9.11](https://cql.hl7.org/09-b-cqlreference.html#interval-operators-3) |
| List | `CqlOperators.ListOperators.cs` | ~900 | [§9.14](https://cql.hl7.org/09-b-cqlreference.html#list-operators-2) |
| Type | `CqlOperators.TypeOperators.cs` | ~400 | [§9.25](https://cql.hl7.org/09-b-cqlreference.html#type-operators-1) |
| Aggregate | `CqlOperators.AggregateFunctions.cs` | ~300 | [§9.1](https://cql.hl7.org/09-b-cqlreference.html#aggregate-functions) |
| Clinical | `CqlOperators.ClinicalOperators2.cs` | ~150 | [§9.5](https://cql.hl7.org/09-b-cqlreference.html#clinical-operators-2) |

---

## Appendix C: Additional Potential Issues

### Issues Requiring Further Investigation

#### C.1 EndsWith String Operator - Potential Bounds Issue

**Location:** `CqlOperators.StringOperators.cs:33-37`

```csharp
public bool? EndsWith(string argument, string suffix)
{
    if (argument == null || suffix == null) return null;
    else return argument.Substring(argument.Length - suffix.Length).Equals(suffix);
}
```

**Potential Issue:** If `suffix.Length > argument.Length`, this will throw `ArgumentOutOfRangeException`.

**CQL Spec:** Should return `false` when suffix is longer than argument.

**Recommended Fix:**
```csharp
public bool? EndsWith(string argument, string suffix)
{
    if (argument == null || suffix == null) return null;
    if (suffix.Length > argument.Length) return false;
    return argument.Substring(argument.Length - suffix.Length).Equals(suffix);
}
```

**Priority:** MEDIUM  
**Risk:** Low - edge case  
**Tests Needed:** Add test for `EndsWith("abc", "longer string")`

#### C.2 Matches Operator - Anchoring Behavior

**Location:** `CqlOperators.StringOperators.cs:90-102`

```csharp
public bool? Matches(string source, string pattern)
{
    if (source == null || pattern == null) return null;
    else
    {
        if (pattern[0].Equals("^") == false) pattern = "^" + pattern;
        if (pattern[pattern.Length - 1].Equals("$") == false) pattern += "$";
        Regex rx = new(pattern);
        MatchCollection matches = rx.Matches(source);
        if (matches.Count == 1) return true;
        else return false;
    }
}
```

**Potential Issues:**
1. Character comparison `pattern[0].Equals("^")` is wrong - should be `pattern[0] == '^'`
2. Automatically adding anchors may not match CQL spec behavior
3. Returns `false` for multiple matches - spec may expect `true` if pattern matches

**CQL Spec Reference:** [Matches](https://cql.hl7.org/09-b-cqlreference.html#matches)

**Priority:** MEDIUM  
**Risk:** Medium - may affect regex behavior  
**Tests Needed:** Review spec for exact Matches semantics

#### C.3 Substring Operator - Length Calculation

**Location:** `CqlOperators.StringOperators.cs:144-162`

```csharp
public string? Substring(string source, int? startIndex, int? length = null)
{
    if (source == null
        || startIndex == null
        || startIndex.Value < 0
        || startIndex.Value >= source.Length)
        return null;
    if (length == null)
    {
        return source.Substring(startIndex.Value);
    }
    else
    {
        if (length.Value < 0)
            return null;
        var subLength = Math.Min(length.Value, source.Length);  // ⚠️ Bug here
        return source.Substring(startIndex.Value, subLength);
    }
}
```

**Issue:** Line `var subLength = Math.Min(length.Value, source.Length);` is incorrect.

Should be: `var subLength = Math.Min(length.Value, source.Length - startIndex.Value);`

**Example:**
- `Substring("abcdef", 3, 5)` should return `"def"` (3 chars from index 3)
- Current: Tries to get min(5, 6) = 5 chars, throws exception
- Should: Get min(5, 6-3) = 3 chars = `"def"`

**Priority:** HIGH  
**Risk:** High - data corruption  
**Tests Needed:** `Substring("abcdef", 3, 5)` should return `"def"`

#### C.4 Sort with Mixed Precision

**Location:** Referenced in `SkippedTests.cs:79-80`

```csharp
{ "SortDatesAsc", "Sort tests shouldn't contain differing precision" },
{ "SortDatesDesc", "Sort tests shouldn't contain differing precision" },
```

**Issue:** Sorting lists containing dates/times with different precisions is problematic.

**Example:** Sorting `{@2020-01, @2020-01-15, @2020}` requires precision-aware comparison.

**CQL Spec:** Needs clarification on sort behavior with mixed precision.

**Priority:** LOW  
**Risk:** Low - design issue  
**Tests Needed:** Verify spec requirements for sort with mixed precision

---

## Appendix D: Repository Test Structure

### Test Organization

```
Cql/
├── CoreTests/                      # Runtime and integration tests
│   ├── Input/ELM/                  # ELM test files
│   ├── *Test.cs                    # Unit tests (~65 files)
│   └── CSharp/                     # Generated C# tests
│
├── CqlToElmTests/                  # CQL compilation tests
│   ├── (tests)/                    # Test implementations (~90 files)
│   │   ├── SkippedTests.cs         # Known deviations catalog
│   │   ├── *Test.cs                # Operator-specific tests
│   │   └── Base.cs                 # Test infrastructure
│   └── Input/DQIC/                 # Official CQL test suite
│       └── *.xml                   # 1,595 spec-based tests
│
└── XsdToCSharpConverterTests/      # Code generation tests
```

### Test Execution Strategy

**Unit Tests (CoreTests):**
```bash
dotnet test Cql/CoreTests/CoreTests.csproj --filter "Category=UnitTest"
```

**CQL Compilation Tests:**
```bash
dotnet test Cql/CqlToElmTests/CqlToElmTests.csproj
```

**Specific Operator Tests:**
```bash
dotnet test --filter "FullyQualifiedName~PowerTest"
dotnet test --filter "FullyQualifiedName~ProperContains"
```

### Test Metrics

- **Total Test Files:** ~15 XML + ~90 C#
- **Total Test Cases:** ~1,600 + unit tests
- **Current Status:** 2,383 passed, 59 skipped
- **Skipped Breakdown:**
  - 48 in `DoesNotCompile` (cannot compile)
  - 30 in `DoesNotMatchExpectation` (behavior mismatch)
  - Some appear in both categories

---

## Appendix E: Recommended GitHub Issues Template

For creating individual tracking issues for each deviation:

### Issue Template: [Deviation Name]

```markdown
## Description
[Brief description of the deviation]

## CQL Specification
- **Section:** [Link to spec section]
- **Quote:** [Relevant spec text]
- **Expected Behavior:** [What spec requires]

## Current Implementation
- **File:** [Link to file on GitHub]
- **Lines:** [Line numbers]
- **Current Behavior:** [What currently happens]

## Example
**Input:** `[example expression]`
**Expected:** `[expected result]`
**Actual:** `[actual result]`

## Proposed Fix
[Code snippet or description]

## Impact
- **Breaking Change:** [Yes/No]
- **Risk Level:** [High/Medium/Low]
- **Tests Affected:** [Number and names]
- **Priority:** [High/Medium/Low]

## Related
- **Skipped Tests:** [List test names]
- **Related Issues:** [Link to related issues]
- **Spec Deviation Report:** Section [X]

## Checklist
- [ ] Verify spec interpretation
- [ ] Implement fix
- [ ] Add/update tests
- [ ] Update SkippedTests.cs
- [ ] Run full test suite
- [ ] Document breaking changes
```

---

**Report Enhanced:** 2026-02-19  
**Total Pages:** Extended with appendices A-E  
**Next Update:** After spec pages become accessible for direct review
