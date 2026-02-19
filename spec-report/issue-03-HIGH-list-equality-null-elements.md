# [HIGH] Fix List equality to treat null elements as equal per spec

**Labels:** `bug`, `spec-conformance`, `spec-violation`, `high`, `equality-operators`  
**Priority:** HIGH  
**Spec Reference:** CQL 1.5.3 spec line 2065, 2082

## Description

The CQL specification explicitly states that for list equality, "null elements are considered equal." The current implementation may not correctly handle this requirement, violating the spec.

## CQL Specification Quote

**Line 2065:**
> "For list types, this means that equality returns true if and only if the lists contain elements of the same type, have the same number of elements, and for each element in the lists, in order, the elements are equal using equality semantics, **with the exception that null elements are considered equal**."

**Spec Example (Line 2082):**
```cql
define "ListEqualIsTrue": { null, 1, 2, 3 } = { null, 1, 2, 3 }
```

This should return `true` because null elements are considered equal in list equality.

## Current Status

**Investigation Required:** The list equality implementation needs to be verified.

**Expected Location:** `Cql/Cql.Runtime/Operators/CqlOperators.EqualityAndEquivalence.cs`

## Expected Behavior

According to the spec, these should all return `true`:
- `{ null } = { null }` → `true`
- `{ null, 1 } = { null, 1 }` → `true`
- `{ null, null } = { null, null }` → `true`
- `{ null, 1, 2, 3 } = { null, 1, 2, 3 }` → `true` (spec example)

But these should return `false`:
- `{ null, 1 } = { null, 2 }` → `false`
- `{ 1 } = { null }` → `false` (or `null` depending on equality semantics)

## Investigation Steps

1. **Locate implementation:** Find list equality code in `CqlOperators.EqualityAndEquivalence.cs`
2. **Review logic:** Check how null elements are compared
3. **Test current behavior:** Write test for `{ null, 1 } = { null, 1 }`
4. **Identify issue:** Determine if null comparison is wrong
5. **Fix if needed:** Ensure null == null returns true for list elements

## Proposed Fix Pattern

The list equality should include special handling:

```csharp
// Pseudo-code for list equality
for (int i = 0; i < list1.Count; i++)
{
    var elem1 = list1[i];
    var elem2 = list2[i];
    
    // ✅ Special case: null elements are considered equal
    if (elem1 == null && elem2 == null)
        continue; // Both null, considered equal
    
    // Normal equality for non-null elements
    if (!AreEqual(elem1, elem2))
        return false;
}
return true;
```

## Impact

- **Risk:** MEDIUM - Affects equality semantics
- **Breaking Change:** Potentially - changes behavior to match spec
- **Test Impact:** Skipped test `EqualNullNull` should pass after fix

## Acceptance Criteria

- [ ] Locate list equality implementation
- [ ] Verify current behavior with test: `{ null, 1 } = { null, 1 }`
- [ ] Fix implementation to treat null elements as equal
- [ ] Add/update test: `{ null, 1, 2, 3 } = { null, 1, 2, 3 }` returns `true`
- [ ] Add/update test: `{ null } = { null }` returns `true`
- [ ] Remove `EqualNullNull` from skipped tests list
- [ ] Verify all equality tests pass

## Related Files

- Implementation: `Cql/Cql.Runtime/Operators/CqlOperators.EqualityAndEquivalence.cs`
- Skipped Tests: `Cql/CqlToElmTests/(tests)/SkippedTests.cs:43`
- Tests: Search for equality tests in `Cql/CqlToElmTests/` and `Cql/CoreTests/`
- Spec: `spec/1.5.3 - Release 1 Errata 2/site/09-b-cqlreference.html:2030-2089`

## Skipped Test

**From `SkippedTests.cs` line 43:**
```csharp
{ "EqualNullNull", "The spec states that null elements are considered equal for list equality." }
```

This test is currently in `DoesNotCompile` - needs investigation.

## Reference

- Spec Verified Findings: `spec-report/SPEC_VERIFIED_FINDINGS.md` (Critical Finding #3)
- Deviations Report: `spec-report/CQL_SPEC_DEVIATIONS_REPORT.md` (Deviation #5)
