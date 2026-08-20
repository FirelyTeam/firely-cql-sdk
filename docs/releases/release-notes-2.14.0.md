## Firely CQL SDK 2.14.0

### tl;dr

> **Upgrading?** Here is the short version:
>
> - **Breaking changes:** Packager CLI `--cs-namespace` now correctly populates `Elm:CSharpNamespace` for both `cql` and `elm`, so generated `*.g.cs` types move from the global namespace into the requested namespace when that option is used.
> - **Required migrations:** If you already pass `--cs-namespace`, regenerate artifacts and update any code/tests that referenced the previous global-namespace type identities.
> - **Highlights:** `ValueSetSource` now memoizes facade materialization for repeated `ValueSet.expansion` instances, reducing repeated work in instance-stable resolver scenarios.

---

### Versioning Decision

- This release is cut as **2.14.0 (minor)**, not `2.13.1`, because release content includes a consumer-visible breaking behavior change (`--cs-namespace` now taking effect in Packager output type identities). This follows the repository's existing convention of shipping breaking behavior under minor releases, while patch releases remain non-breaking bugfix updates.

---

### CQL SDK

#### New Public API

- None.

#### Improvements

- `ValueSetSource` now memoizes expansion-facade materialization process-wide by `ValueSet.expansion` instance under weak keys. The memo only hits when a resolver returns the same `ExpansionComponent` instance again; there is no manual tuning or invalidation surface.
- Facade materialization is now eager on `Add` instead of deferred to first query. This reduces repeated expansion walks for queried value sets, but callers that bulk-load value sets they never query now pay that materialization up front.
- In-place mutation of an already-materialized expansion instance is not observed by the memoized facade (replacement with a new expansion instance is observed).

#### Dependency Updates

- `FirelyNetVersion` remains `6.3.0` in `cql-base.props` and `Demo/cql-demo.props`, matching Vonk `FhirNetApiVersion` (`Directory.Packages.props`) at release cut time.

#### Potentially Breaking

- None.

---

### CQL Packager

#### Breaking

- Fixed Packager CLI `--cs-namespace` binding for both `cql` and `elm` commands. The option now correctly sets `Elm:CSharpNamespace`, so generated `*.g.cs` output is wrapped in the requested namespace. For users already passing `--cs-namespace`, this changes generated type identities from global-namespace to namespaced types. (#1570)

#### Improvements

- None.

---

### Demo Projects and Build Tooling

#### Breaking

- None.

#### Improvements

- No consumer-facing release-note entry is required for #1563 or #1583:
  - #1563 updates private integration-runner submodule resources/pointer and maintenance docs/scripts; it does not change shipped SDK/package behavior (`Cql/`, `*.props`, public API, or `GeneratorToolVersion`).
  - #1583 is contributor-facing documentation only (`docs/getting-started.md`, `tools/README.md`), with no shipped runtime/tooling behavior change.

---

### Upgrade Checklist

1. If you pass Packager CLI `--cs-namespace`, regenerate generated `*.g.cs` artifacts and update references/assertions that depended on prior global-namespace output.

---

### Common Items To Check

- PublicAPI shipped/unshipped promotions: no pending public API member entries to promote.
- New or changed exception types: none in this release window.
- Public runtime/operator API changes: none in this release window.
- Code generation version changes: none (`LibrarySetCSharpCodeGenerator.GeneratorToolVersion` remains `5.2.1.0`).
- Invocation toolkit generator support range still covers the current generator version (`LibraryInstanceInvoker_5_0`: `[5.1.0.0, 5.3.0.0)`).
- `FirelyNetVersion` updates: none (`6.3.0` unchanged).
- Packager CLI argument changes: `--cs-namespace` binding fix for `cql` and `elm`.
- Content previously drafted in `docs/releases/vnext-release-notes.md`: none (file remains a static pointer doc).
- All merged PRs since `v2.13.0`: included below.

---

### Pull Requests

| PR | Title |
| --- | --- |
| [#1583](https://github.com/FirelyTeam/firely-cql-sdk/pull/1583) | Document the toolchain each repository script needs |
| [#1570](https://github.com/FirelyTeam/firely-cql-sdk/pull/1570) | Fix ignored `--cs-namespace` in Packager CLI |
| [#1568](https://github.com/FirelyTeam/firely-cql-sdk/pull/1568) | Memoize value set facade materialization in `ValueSetSource` |
| [#1563](https://github.com/FirelyTeam/firely-cql-sdk/pull/1563) | Regenerate integration-runner resources at 5.2.1.0 and pin sync script inputs |
