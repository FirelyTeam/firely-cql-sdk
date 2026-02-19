# [MEDIUM] Fix Matches operator auto-anchoring behavior

**Labels:** `bug`, `spec-conformance`, `medium`, `string-operators`, `regex`  
**Priority:** MEDIUM  
**Spec Reference:** CQL 1.5.3 spec line 3344

## Description

The `Matches` operator incorrectly auto-adds `^` and `$` anchors to patterns, forcing full string matching. The CQL specification states that regex should use "partial matching" by default, with anchors only when explicitly provided. Additionally, the code has a character comparison bug.

## CQL Specification Quote

**Line 3344:**
> "The Matches operator returns true if the given string matches the given regular expression pattern. Regular expressions should function consistently, regardless of any culture- and locale-specific settings in the environment, should be case-sensitive, **use partial matching**, use single line mode, and allow Unicode characters. **The start/end of line markers ^ and $ can be used to match the entire string.**"

**Spec Examples (Lines 3354-3357):**
```cql
define "MatchesTrue": Matches('1,2three', '\\d,\\d\\w+')
define "MatchesFalse": Matches('1,2three', '\\w+')
define "MatchesTrue2": Matches('http://fhir.org/guides/cqf/common/Library/FHIR-ModelInfo|4.0.1', 'Library')
```

Note: Example 3 shows partial matching - 'Library' matches within the longer URL.

## Current Implementation

**File:** `Cql/Cql.Runtime/Operators/CqlOperators.StringOperators.cs` (Lines 90-102)

```csharp
public bool? Matches(string source, string pattern)
{
    if (source == null || pattern == null) return null;
    else
    {
        // ❌ BUG 1: Wrong character comparison - should be == not .Equals()
        if (pattern[0].Equals("^") == false) pattern = "^" + pattern;
        if (pattern[pattern.Length - 1].Equals("$") == false) pattern += "$";
        
        Regex rx = new(pattern);
        MatchCollection matches = rx.Matches(source);
        
        // ❌ BUG 2: Auto-anchoring violates "partial matching" requirement
        if (matches.Count == 1) return true;
        else return false;
    }
}
```

## The Problems

### Problem 1: Wrong Character Comparison
```csharp
if (pattern[0].Equals("^") == false)
```
- `pattern[0]` is a `char`
- Calling `.Equals("^")` on a char boxes it and compares to a string
- Should be: `pattern[0] == '^'` (direct char comparison)

### Problem 2: Auto-Anchoring Violates Spec
The spec says "use partial matching" and "^ and $ **can be used**" (optional, not mandatory).

By forcing anchors, the implementation:
- Prevents partial matches (contradicts spec line 3344)
- Makes patterns like 'Library' fail to match substrings
- Requires exact full-string matches instead of partial matches

## Proposed Fix

### Option 1: Simple Fix (Recommended)
```csharp
public bool? Matches(string source, string pattern)
{
    if (source == null || pattern == null) return null;
    
    // ✅ Don't auto-anchor - spec says partial matching
    // Users can add ^ and $ themselves if they want full match
    Regex rx = new(pattern);
    return rx.IsMatch(source);
}
```

### Option 2: Conservative Fix
If concerned about breaking existing code that relies on auto-anchoring:

```csharp
public bool? Matches(string source, string pattern)
{
    if (source == null || pattern == null) return null;
    
    // ✅ Only add anchors if not already present
    if (pattern.Length > 0 && pattern[0] != '^' && pattern[pattern.Length - 1] != '$')
    {
        // For backward compatibility, keep auto-anchor behavior
        // but fix the character comparison bug
        pattern = "^" + pattern + "$";
    }
    
    Regex rx = new(pattern);
    return rx.IsMatch(source);
}
```

**Recommendation:** Option 1 - Remove auto-anchoring to match spec. Document as breaking change if needed.

## Impact

- **Risk:** MEDIUM - Changes regex matching behavior
- **Breaking Change:** Potentially - if code relies on auto-anchoring
- **Test Impact:** May need to update tests that expect full-match behavior

## Spec Interpretation Note

The spec example `Matches('1,2three', '\\w+')` returns `false`, which seems to contradict partial matching (would find "three"). This requires further investigation with the reference implementation to clarify exact partial matching semantics.

**For now:** Remove auto-anchoring as spec clearly states "use partial matching".

## Acceptance Criteria

- [ ] Remove auto-anchor logic (or fix char comparison if keeping it)
- [ ] Change to use `rx.IsMatch(source)` instead of checking count
- [ ] Add test: `Matches('http://example.com/Library/test', 'Library')` returns `true`
- [ ] Add test: `Matches('ABC', '^ABC$')` returns `true` (explicit anchors work)
- [ ] Add test: `Matches('ABC', 'ABC')` behavior matches spec
- [ ] Verify existing Matches tests - update if they expect auto-anchoring
- [ ] Document breaking change if removing auto-anchoring

## Related Files

- Implementation: `Cql/Cql.Runtime/Operators/CqlOperators.StringOperators.cs:90-102`
- Tests: Search for `Matches` in `Cql/CqlToElmTests/(tests)/`
- Test XML: `Cql/CqlToElmTests/Input/DQIC/CqlStringOperatorsTest.xml`
- Spec: `spec/1.5.3 - Release 1 Errata 2/site/09-b-cqlreference.html:3335-3358`

## Further Investigation Needed

- [ ] Test with reference CQL implementation to clarify partial match semantics
- [ ] Determine why spec example `Matches('1,2three', '\\w+')` returns false
- [ ] Verify PCRE dialect compatibility

## Reference

- Spec Verified Findings: `spec-report/SPEC_VERIFIED_FINDINGS.md` (Critical Finding #6)
- Deviations Report: `spec-report/CQL_SPEC_DEVIATIONS_REPORT.md` (Appendix C.2)
