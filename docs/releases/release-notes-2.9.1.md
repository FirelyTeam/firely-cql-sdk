## Firely CQL SDK 2.9.1

### tl;dr

> **Upgrading?** Here is the short version:
>
> - **Breaking changes:** None.
> - **Required migrations:** None.
> - **Highlights:** Significant runtime performance improvements to `RunLibrary`/`SelectResults` and to `CqlComparers`/`CqlOperators` (notably `Distinct`), plus a fix for ELM choice-type handling in generated code. This release contains no correctness or behavior changes to CQL evaluation results.

---

### CQL SDK

#### New Public API

- None.

#### Improvements

- Optimized the `RunLibrary`/`SelectResults` hot path with a value-set fast path, a direct-delegate invoker, and cache tuning, reducing evaluation overhead by roughly 40% in benchmarks (#1322, #1323).
- Fixed O(n²) hot paths in `CqlComparers`/`CqlOperators`: `Distinct` now uses a `HashSet`-based O(n) algorithm instead of repeated `List.Contains` scans, comparer type-resolution is memoized instead of re-walking base types on every call, boxing was removed from equality fast paths, and `CqlConcept` comparisons cache their sorted code arrays instead of re-sorting on every `Compare` (#1324, #1327).
- The C# compiler now collapses ELM choice types whose alternatives all map to the same .NET type (e.g. `Choice<Condition, Condition>` produced for unions of QiCore Condition profiles) to that single type instead of `object`. Generated code stays strongly typed and no longer falls back to late-bound property access (seen in e.g. CMS125 "Right Mastectomy Diagnosis"). The generator tool version was bumped to 5.1.2.0 and the checked-in generated libraries were regenerated (#1317).

#### Dependency Updates

- None.

#### Potentially Breaking

- None.

---

### CQL Packager

#### Breaking

- None.

#### Improvements

- None.

---

### Demo Projects and Build Tooling

#### Breaking

- None.

#### Improvements

- None.

---

### Upgrade Checklist

- No action required. This release is fully backward compatible with 2.9.0.

---

### Pull Requests

| PR                                                              | Title                                                                                    |
| ---------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| [#1317](https://github.com/FirelyTeam/firely-cql-sdk/pull/1317) | Collapse single-type ELM choice types to concrete type                                    |
| [#1323](https://github.com/FirelyTeam/firely-cql-sdk/pull/1323) | Optimize RunLibrary/SelectResults hot path: value set fast path, direct-delegate invoker, cache tuning (-40%) |
| [#1327](https://github.com/FirelyTeam/firely-cql-sdk/pull/1327) | Fix O(n²) Distinct and comparer dispatch hot paths (#1324)                                |
