# [HIGH] Fix Power operator to return null for non-representable results

**Labels:** `bug`, `spec-conformance`, `high`, `arithmetic-operators`  
**Priority:** HIGH  
**Spec Reference:** CQL 1.5.3 spec line 2997

## Description

The Power operator currently casts fractional results to integer types, losing precision and returning incorrect values (e.g., `0` instead of `0.25`). According to the CQL specification, if a result "cannot be represented" in the return type, the result should be `null`.

## CQL Specification Quote

**Lines 2978-2997:**
```cql
Signature:
^(argument Integer, exponent Integer) Integer
^(argument Long, exponent Long) Long
^(argument Decimal, exponent Decimal) Decimal

Description:
The power (^) operator raises the first argument to the power given by 
the second argument.
...
If the result of the operation cannot be represented, the result is null.
```

**Key Principle (Line 2997):**
> "If the result of the operation **cannot be represented**, the result is null."

## Current Implementation

**File:** `Cql/Cql.Runtime/Operators/CqlOperators.ArithmeticOperators.cs` (Lines 683-699)

```csharp
public int? Power(int? argument, int? exponent)
{
    if (argument == null || exponent == null) return null;
    else return (int?)Math.Pow((double)argument, (double)exponent);
    // ❌ Casts fractional results to int, losing precision
}

public long? Power(long? argument, long? exponent)
{
    if (argument == null || exponent == null) return null;
    else return (long?)Math.Pow((double)argument, (double)exponent);
    // ❌ Same issue for long
}

public decimal? Power(decimal? argument, decimal? exponent)
{
    if (argument == null || exponent == null) return null;
    else return (decimal)Math.Pow((double)argument, (double)exponent);
    // ✓ Decimal version is OK as it preserves precision
}
```

## The Problem

When `Power(2, -2)` is evaluated:
1. `Math.Pow(2, -2)` returns `0.25` (double)
2. Cast to `int?` becomes `0`
3. Expected per spec: `null` (fractional result cannot be represented as Integer)

**Current behavior:**
```cql
Power(2, -2) // Returns 0 ❌ (should be null)
Power(2L, -2L) // Returns 0L ❌ (should be null)
```

**Fractional result `0.25` cannot be represented as Integer**, so per spec line 2997, result should be `null`.

## Proposed Fix

### Option 1: Return null for non-representable results (Recommended)

```csharp
public int? Power(int? argument, int? exponent)
{
    if (argument == null || exponent == null) return null;
    
    var result = Math.Pow((double)argument, (double)exponent);
    
    // ✅ If result has fractional part, cannot represent as integer
    if (result != Math.Floor(result))
        return null;
    
    // ✅ Check if result is within int range
    if (result < int.MinValue || result > int.MaxValue)
        return null;
    
    return (int?)result;
}

public long? Power(long? argument, long? exponent)
{
    if (argument == null || exponent == null) return null;
    
    var result = Math.Pow((double)argument, (double)exponent);
    
    // ✅ If result has fractional part, cannot represent as long
    if (result != Math.Floor(result))
        return null;
    
    // ✅ Check if result is within long range  
    if (result < long.MinValue || result > long.MaxValue)
        return null;
    
    return (long?)result;
}

// Decimal version stays the same - already preserves precision
```

### Option 2: Always return Decimal type (Alternative - Breaking Change)

Change all Power overloads to return `Decimal?`. This would be a **breaking change** but would preserve precision.

**Recommendation:** Use Option 1 (return null) as it matches the spec without breaking changes.

## Impact

- **Risk:** MEDIUM - Changes return values for fractional results
- **Breaking Change:** Potentially - may affect code expecting `0` instead of `null`
- **Test Impact:** 10 skipped tests should be addressed

## Affected Tests

**From `SkippedTests.cs` lines 63-74:**
```csharp
{ "DecimalNegOneStep", "Power returns integers, not decimals" },
{ "DecimalNegTenStep", "Power returns integers, not decimals" },
{ "DecimalNegTwoStep", "Power returns integers, not decimals" },
{ "DecimalOneStep", "Power returns integers, not decimals" },
{ "DecimalPosOneStep", "Power returns integers, not decimals" },
{ "DecimalPosTenStep", "Power returns integers, not decimals" },
{ "DecimalPosTwoStep", "Power returns integers, not decimals" },
{ "DecimalTenStep", "Power returns integers, not decimals" },
{ "DecimalTwoStep", "Power returns integers, not decimals" },
{ "Power2ToNeg2", "Power returns integers, not decimals" },
```

These tests expect decimal results but currently get truncated integers.

## Acceptance Criteria

- [ ] Update `Power(int?, int?)` to return null for fractional results
- [ ] Update `Power(long?, long?)` to return null for fractional results
- [ ] Add test: `Power(2, -2)` returns `null`
- [ ] Add test: `Power(2, 3)` returns `8` (still works for integer results)
- [ ] Add test: `Power(2L, -2L)` returns `null`
- [ ] Review and update 10 skipped tests
- [ ] Verify Power tests pass with new behavior
- [ ] Document breaking change if any existing code relies on truncation

## Related Files

- Implementation: `Cql/Cql.Runtime/Operators/CqlOperators.ArithmeticOperators.cs:683-699`
- Skipped Tests: `Cql/CqlToElmTests/(tests)/SkippedTests.cs:63-74`
- Test XML: `Cql/CqlToElmTests/Input/DQIC/CqlArithmeticFunctionsTest.xml` and `ValueLiteralsAndSelectors.xml`
- Spec: `spec/1.5.3 - Release 1 Errata 2/site/09-b-cqlreference.html:2974-3006`

## Reference

- Spec Verified Findings: `spec-report/SPEC_VERIFIED_FINDINGS.md` (Critical Finding #2)
- Deviations Report: `spec-report/CQL_SPEC_DEVIATIONS_REPORT.md` (Deviation #1)
