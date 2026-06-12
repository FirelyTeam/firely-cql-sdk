## Firely CQL SDK 2.9.0

### tl;dr

> **Upgrading?** Here is the short version:
>
> - **Breaking changes:** `ICqlOperators.Coalesce<T>` no longer uses `where T : class`; `CoalesceValueTypes<T>` is deprecated.
> - **Required migrations:** If you implement `ICqlOperators`, remove the `where T : class` constraint from your `Coalesce<T>` implementation and use `Coalesce<T>` for nullable value types.
> - **Highlights:** Added preprocessor normalization for legacy ELM `Power` result types and fixed coalesce codegen/binding for nullable value-type scenarios.

---

### CQL SDK

#### New Public API

- None.

#### Improvements

- Added `PowerResultTypeCorrector` to normalize externally produced ELM `Power` result types to `Decimal` before binding, matching the CQL specification.
- Fixed `CS0452` generation failures involving coalesce with nullable value tuple list elements by aligning binder/operator selection and generic type resolution.
- Consolidated coalesce binding behavior and stopped emitting deprecated `CoalesceValueTypes<T>` call sites from the binder.

#### Dependency Updates

- None.

#### Potentially Breaking

- `ICqlOperators.Coalesce<T>` no longer has the `where T : class` constraint.
- `ICqlOperators.CoalesceValueTypes<T>` is now deprecated (`[Obsolete]`). Only use `ICqlOperators.Coalesce<T>` from now on.

---

### CQL Packager

#### Breaking

- None.

#### Improvements

- Fixed `AllowInvalidCSharp` regression so generated C# files are still written even when assembly compilation fails.

---

### Demo Projects and Build Tooling

#### Breaking

- None.

#### Improvements

- Improved validation coverage by decoupling tests from `Expression.Compile()` and adding C# golden-file checks.

---

### Upgrade Checklist

1. If you implement `ICqlOperators`, update your `Coalesce<T>` implementation signature to remove `where T : class`.
2. Replace custom usages of `CoalesceValueTypes<T>` with `Coalesce<T>` over nullable value types where applicable.

---

### Pull Requests

| PR                                                              | Title                                                                                 |
| --------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| [#1306](https://github.com/FirelyTeam/firely-cql-sdk/pull/1306) | fix: normalize legacy ELM Power result type to Decimal in preprocessor (#1305)        |
| [#1308](https://github.com/FirelyTeam/firely-cql-sdk/pull/1308) | Fix CS0452 for coalesce on nullable value tuples in generated C# (#1307)              |
| [#1310](https://github.com/FirelyTeam/firely-cql-sdk/pull/1310) | Fix AllowInvalidCSharp regression: save C# files even when assembly compilation fails |
| [#1311](https://github.com/FirelyTeam/firely-cql-sdk/pull/1311) | Decouple tests from Expression.Compile() and add C# golden-file checks                |
| [#1314](https://github.com/FirelyTeam/firely-cql-sdk/pull/1314) | refactor: consolidate Coalesce binding and deprecate CoalesceValueTypes (#1313)       |
| [#1315](https://github.com/FirelyTeam/firely-cql-sdk/pull/1315) | Set next release version to 2.9.0 (#1309)                                             |
