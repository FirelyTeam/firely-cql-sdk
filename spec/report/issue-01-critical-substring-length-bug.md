# [CRITICAL] Fix Substring length calculation bug

**Labels:** `bug`, `spec-conformance`, `critical`, `string-operators`  
**Priority:** CRITICAL  
**Spec Reference:** CQL 1.5.3 spec line 3477-3481

## Description

The `Substring` operator has a critical bug in length calculation that can cause incorrect results or exceptions. When calculating the maximum substring length, the implementation uses `source.Length` instead of `source.Length - startIndex`, which causes it to attempt reading beyond the string bounds.

## CQL Specification Quote

**Lines 3477-3481:**
> "The Substring operator returns the string within stringToSub, starting at the 0-based index startIndex, and consisting of length characters.
>
> If length is omitted, the substring returned starts at startIndex and continues to the end of stringToSub.
>
> If stringToSub or startIndex is null, or startIndex is out of range, the result is null."

**Spec Example (Line 3486):**
```cql
define "SubstringWithLength": Substring('ABCDE', 2, 1) // 'C'
```

## Current Implementation

**File:** `Cql/Cql.Runtime/Operators/CqlOperators.StringOperators.cs` (Lines 144-162)

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
        var subLength = Math.Min(length.Value, source.Length);  // ❌ BUG!
        return source.Substring(startIndex.Value, subLength);
    }
}
```

## The Problem

Line 159: `var subLength = Math.Min(length.Value, source.Length);`

**Bug:** Uses `source.Length` (total length) instead of remaining characters `source.Length - startIndex.Value`.

### Example Failure Case

```csharp
Substring("abcdef", 3, 5)
// source.Length = 6
// startIndex = 3
// length requested = 5
// 
// Current calculation: Math.Min(5, 6) = 5
// Tries to get 5 characters starting at index 3
// But only 3 characters remain: "def"
// Result: ArgumentOutOfRangeException or wrong behavior
//
// Correct calculation: Math.Min(5, 6-3) = Math.Min(5, 3) = 3
// Gets 3 characters: "def" ✓
```

## Proposed Fix

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
        // ✅ FIX: Use remaining length, not total length
        var subLength = Math.Min(length.Value, source.Length - startIndex.Value);
        return source.Substring(startIndex.Value, subLength);
    }
}
```

## Impact

- **Risk:** HIGH - Can cause exceptions or return incorrect substrings
- **Breaking Change:** No - fixes incorrect behavior to match spec
- **Test Impact:** May expose existing tests that rely on buggy behavior

## Acceptance Criteria

- [ ] Fix line 159 to use `source.Length - startIndex.Value`
- [ ] Add test: `Substring("abcdef", 3, 5)` returns `"def"`
- [ ] Add test: `Substring("ABCDE", 2, 1)` returns `"C"` (spec example)
- [ ] Add test: `Substring("ABC", 1, 10)` returns `"BC"` (length exceeds remaining)
- [ ] Verify existing Substring tests still pass
- [ ] Update any tests that relied on buggy behavior

## Related Files

- Implementation: `Cql/Cql.Runtime/Operators/CqlOperators.StringOperators.cs:144-162`
- Tests: `Cql/CqlToElmTests/(tests)/` (search for Substring tests)
- Spec: `spec/1.5.3 - Release 1 Errata 2/site/09-b-cqlreference.html:3467-3489`

## Reference

- Spec Verified Findings: `spec-report/spec-verified-findings.md` (Critical Finding #4)
- Deviations Report: `spec-report/cql-spec-deviations-report.md`
