# [HIGH] Fix EndsWith bounds check and empty string handling

**Labels:** `bug`, `spec-conformance`, `high`, `string-operators`  
**Priority:** HIGH  
**Spec Reference:** CQL 1.5.3 spec line 3234-3238

## Description

The `EndsWith` operator is missing critical bounds checking and empty string handling, causing it to throw `ArgumentOutOfRangeException` when the suffix is longer than the argument string. The spec also requires specific behavior for empty strings that is not implemented.

## CQL Specification Quote

**Lines 3234-3238:**
> "The EndsWith operator returns true if the given string ends with the given suffix.
>
> **If the suffix is the empty string, the result is true.**
>
> If either argument is null, the result is null."

**Spec Examples (Lines 3242-3244):**
```cql
define "EndsWithIsTrue": EndsWith('ABC', 'C') // true
define "EndsWithIsFalse": EndsWith('ABC', 'Z') // false
define "EndsWithIsNull": EndsWith('ABC', null) // null
```

## Current Implementation

**File:** `Cql/Cql.Runtime/Operators/CqlOperators.StringOperators.cs` (Lines 33-37)

```csharp
public bool? EndsWith(string argument, string suffix)
{
    if (argument == null || suffix == null) return null;
    else return argument.Substring(argument.Length - suffix.Length).Equals(suffix);
    // ❌ Throws if suffix.Length > argument.Length
    // ❌ Doesn't handle empty string case per spec
}
```

## The Problems

1. **Missing bounds check:** If `suffix.Length > argument.Length`, `argument.Length - suffix.Length` is negative, causing `ArgumentOutOfRangeException`
2. **Missing empty string handling:** Spec requires `EndsWith(anything, "")` to return `true`

### Example Failure Cases

```csharp
EndsWith("ABC", "ABCDEFG")
// suffix.Length = 7, argument.Length = 3
// Calculates: 3 - 7 = -2
// Tries: argument.Substring(-2)
// Result: ArgumentOutOfRangeException ❌

EndsWith("ABC", "")
// Should return true per spec
// Current: Substring(3) returns "ABC", equals("") returns false ❌
```

## Proposed Fix

```csharp
public bool? EndsWith(string argument, string suffix)
{
    if (argument == null || suffix == null) return null;
    
    // ✅ Handle empty string case per spec line 3236
    if (suffix.Length == 0) return true;
    
    // ✅ Bounds check: suffix can't be longer than argument
    if (suffix.Length > argument.Length) return false;
    
    return argument.Substring(argument.Length - suffix.Length).Equals(suffix);
}
```

## Impact

- **Risk:** MEDIUM - Currently throws exceptions for valid inputs
- **Breaking Change:** No - fixes incorrect behavior to match spec
- **Test Impact:** May need to add tests for edge cases

## Acceptance Criteria

- [ ] Add empty string check: if `suffix.Length == 0` return `true`
- [ ] Add bounds check: if `suffix.Length > argument.Length` return `false`
- [ ] Add test: `EndsWith("ABC", "")` returns `true`
- [ ] Add test: `EndsWith("ABC", "ABCDEFG")` returns `false` (not exception)
- [ ] Add test: `EndsWith("ABC", "C")` returns `true` (spec example)
- [ ] Add test: `EndsWith("ABC", "Z")` returns `false` (spec example)
- [ ] Verify existing EndsWith tests still pass

## Related Files

- Implementation: `Cql/Cql.Runtime/Operators/CqlOperators.StringOperators.cs:33-37`
- Tests: Search for `EndsWith` in `Cql/CqlToElmTests/(tests)/`
- Test XML: `Cql/CqlToElmTests/Input/DQIC/CqlStringOperatorsTest.xml`
- Spec: `spec/1.5.3 - Release 1 Errata 2/site/09-b-cqlreference.html:3225-3245`

## Reference

- Spec Verified Findings: `spec-report/SPEC_VERIFIED_FINDINGS.md` (Critical Finding #5)
- Deviations Report: `spec-report/CQL_SPEC_DEVIATIONS_REPORT.md` (Appendix C.1)
