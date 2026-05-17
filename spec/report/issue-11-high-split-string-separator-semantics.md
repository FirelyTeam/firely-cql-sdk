# [HIGH] Fix Split separator semantics to use full string separator

**Labels:** `bug`, `spec-conformance`, `high`, `string-operators`, `split`  
**Priority:** HIGH  
**Spec Reference:** CQL 1.5.3, String operators (`spec/condensed/09-b-cqlreference.md`, section `#### Split`)

## Description

`Split(stringToSplit, separator)` currently treats the separator as a **set of delimiter characters** by calling:

```csharp
stringToSplit.Split(separator.ToCharArray())
```

This is not equivalent to CQL's `Split(..., separator String)` semantics, where `separator` is a string token/pattern literal (non-regex), not a character bag.

## CQL Specification Basis

From `spec/condensed/09-b-cqlreference.md` under **Split**:

- Signature: `Split(stringToSplit String, separator String) List<String>`
- If `stringToSplit` is null, result is null.
- If `stringToSplit` does not contain any appearance of `separator`, result is `{ stringToSplit }`.

The operator definition implies matching on occurrences of the separator string, not any character contained in separator.

## Updated Implementation

**File:** `Cql/Cql.Runtime/Operators/CqlOperators.StringOperators.cs`

```csharp
public IEnumerable<string>? Split(string stringToSplit, string separator)
{
    if (stringToSplit == null)
        return null;
    if (separator == null)
        return new[] { stringToSplit };
    else return stringToSplit.Split([separator], StringSplitOptions.None);
}
```

## Why This Was Incorrect

Using `separator.ToCharArray()` changes semantics:

- `Split("A--B--C", "--")` should split by `"--"` token.
- Current logic splits on `'-'` characters individually.

This can produce different tokenization and empty segments than string-separator semantics.

## Impact

- **Spec conformance risk:** High in string operator behavior.
- **Behavioral risk:** High for multi-character separators.
- **Confidence risk:** Existing report text claims full string conformance while this mismatch exists.

## Implemented Fix

Use a true string-separator split overload:

```csharp
stringToSplit.Split(new[] { separator }, StringSplitOptions.None)
```

Null semantics are unchanged.

## Acceptance Criteria

- [x] `Split` uses full string separator semantics (not char-array splitting)
- [x] Existing Split tests still pass
- [x] Add/adjust tests for multi-character separators
- [x] Verify no regressions in `SplitOnMatches` (regex variant)
- [x] Update conformance report status accordingly

## Suggested Test Additions

- [x] `Split('A--B--C', '--')` -> `{ 'A', 'B', 'C' }`
- [x] `Split('A::B:C', '::')` -> `{ 'A', 'B:C' }`
- [x] `Split('abc', 'xyz')` -> `{ 'abc' }`

## Verification

- `dotnet test Cql/CqlToElmTests/CqlToElmTests.csproj --framework net8.0` passed with updated `CqlStringOperatorsTest.xml`.
- `SplitOnMatches` implementation is unchanged (`Regex.Split`) and no regressions were introduced by this fix.

## Related Files

- Implementation: `Cql/Cql.Runtime/Operators/CqlOperators.StringOperators.cs`
- Existing XML tests: `Cql/CqlToElmTests/Input/DQIC/CqlStringOperatorsTest.xml`
- Spec: `spec/condensed/09-b-cqlreference.md`

## Notes

This issue is distinct from `Matches` anchoring behavior (#1199). It specifically targets `Split` token semantics and should be addressed independently.
