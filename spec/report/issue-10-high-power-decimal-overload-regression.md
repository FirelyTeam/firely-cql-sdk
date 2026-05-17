# [HIGH] Re-open Power conformance: decimal overload non-representable handling and active regression

**Labels:** `bug`, `spec-conformance`, `high`, `arithmetic-operators`, `power`  
**Priority:** HIGH  
**Spec Reference:** CQL 1.5.3, Power operator (`spec/condensed/09-b-cqlreference.md`, section `#### Power`)

## Description

Power conformance should be re-opened. There are two concrete issues:

1. **Implementation inconsistency in `Power(decimal?, decimal?)`:** non-representable results are not handled defensively (unlike integer/long overloads).
2. **Active failing conformance test:** `PowerIntegerByDecimalSmall` is currently failing in `CqlToElmTests` with a large numeric mismatch (`Expected 8.0`, `Actual 1.00000002302585`).

Even though the conformance status file marks Power as resolved, current test evidence shows this area is still unstable.

## CQL Specification Basis

From `spec/condensed/09-b-cqlreference.md` under **Power**:

- If either argument is `null`, result is `null`.
- **If the result cannot be represented, the result is `null`.**

## Evidence

### 1) Decimal overload lacks non-representable guards

**File:** `Cql/Cql.Runtime/Operators/CqlOperators.ArithmeticOperators.cs`

- `Power(int?, int?)` and `Power(long?, long?)` guard `NaN`, `Infinity`, and `OverflowException`, returning `null`.
- `Power(decimal?, decimal?)` currently does:

```csharp
public decimal? Power(decimal? argument, decimal? exponent)
{
    if (argument == null || exponent == null) return null;
    else return (decimal)Math.Pow((double)argument, (double)exponent);
}
```

This path does not explicitly guard non-representable values consistently with the other overloads and spec intent.

### 2) Active failing test

**Command executed:**

```bash
dotnet test Cql/CqlToElmTests/CqlToElmTests.csproj -c Release --no-build --filter FullyQualifiedName~PowerIntegerByDecimalSmall
```

**Observed failure (both net8.0 and net10.0):**

- Test: `PowerIntegerByDecimalSmall`
- File/line: `Cql/CqlToElmTests/(tests)/PowerTest.cs:239`
- Message: `Assert.AreEqual failed. Expected:<8.0>. Actual:<1.00000002302585>.`

## Impact

- **Spec conformance risk:** High (Power semantics and representability behavior).
- **Runtime correctness risk:** High (unexpected numeric result in targeted conformance test).
- **Process risk:** High (status docs currently report Power as resolved).

## Proposed Fix Plan

1. **Harden `Power(decimal?, decimal?)`:**
   - Add explicit handling for `NaN`/`Infinity`.
   - Catch `OverflowException` and return `null`.
   - Keep behavior consistent across all Power overloads.
2. **Investigate `PowerIntegerByDecimalSmall` regression path:**
   - Validate expression translation/typing pipeline for this specific test.
   - Confirm whether failure originates in runtime operator evaluation, conversion path, or generated invocation.
3. **Unblock and restore conformance coverage:**
   - Reconcile stale skip metadata for old Power rationale in `SkippedTests.cs`.
4. **Update report status once fixed and verified with targeted tests.**

## Acceptance Criteria

- [ ] `Power(decimal?, decimal?)` returns `null` for non-representable results (spec compliant)
- [ ] `PowerIntegerByDecimalSmall` passes on net8.0 and net10.0
- [ ] No regressions in existing Power tests
- [ ] Conformance report files updated to reflect final verified status

## Related Files

- Implementation: `Cql/Cql.Runtime/Operators/CqlOperators.ArithmeticOperators.cs`
- Interface: `Cql/Cql.Runtime/Operators/ICqlOperators.cs`
- Tests: `Cql/CqlToElmTests/(tests)/PowerTest.cs`
- Skip metadata: `Cql/CqlToElmTests/(tests)/SkippedTests.cs`
- Spec: `spec/condensed/09-b-cqlreference.md`

## Notes

Previous issue #1198 was closed as resolved. This issue tracks newly observed evidence that Power conformance is not fully stable and needs re-validation/fix.
