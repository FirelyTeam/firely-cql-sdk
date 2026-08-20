## Firely CQL SDK 2.14.0

### tl;dr

> **Upgrading?** Here is the short version:
>
> - **Breaking changes:** Packager CLI `--cs-namespace` now correctly populates `Elm:CSharpNamespace` for both `cql` and `elm`, so generated `*.g.cs` types move from the global namespace into the requested namespace when that option is used. Separately, `ValueSetSource` no longer observes in-place edits to a `ValueSet.Expansion` it has already built a facade from.
> - **Required migrations:** If you already pass `--cs-namespace`, regenerate artifacts and update any code/tests that referenced the previous global-namespace type identities. If your host edits a `ValueSet.Expansion` in place after handing the value set to a `ValueSetSource`, assign a new expansion instance and pass that replacement to a subsequent/new `ValueSetSource` instead of mutating the existing one.
> - **Highlights:** `ValueSetSource` now memoizes facade materialization for repeated `ValueSet.Expansion` instances, reducing repeated work in instance-stable resolver scenarios.

---

### Version Level

- **MESO** — the second digit, meaning some small effort may be required. `--cs-namespace` now taking effect moves generated type identities for every consumer already passing that option, so their checked-in `*.g.cs` and anything compiled against it must be regenerated (#1570). That is a migration step, not a drop-in upgrade, and a third-digit bump would not signal it. #1568 independently qualifies: `ValueSetSource` no longer observing in-place edits to a `ValueSet.Expansion` is a behavior change, recorded under `#### Potentially Breaking` below.

  These terms come from [EffVer](https://jacobtomlinson.dev/effver/), which was written down as this project's policy — in [docs/versioning.md](https://github.com/FirelyTeam/firely-cql-sdk/blob/develop/docs/versioning.md) — only after `2.14.0` was cut. The label here is applied retrospectively for consistency with later release notes; the version number itself was chosen on the same reasoning and is unchanged.

---

### Generated Code Compatibility

- `LibrarySetCSharpCodeGenerator.GeneratorToolVersion`: **5.2.1.0** (unchanged from `2.13.0`).
- Accepted by `LibraryInstanceInvoker_5_0`, whose supported range is `[5.1.0.0, 5.3.0.0)`.

---

### CQL SDK

#### New Public API

- None.

#### Improvements

- `ValueSetSource` now memoizes expansion-facade materialization process-wide by `ValueSet.Expansion` instance under weak keys. The memo only hits when a resolver returns the same `ExpansionComponent` instance again; there is no manual tuning or invalidation surface. (#1568)

#### Dependency Updates

- `FirelyNetVersion` remains `6.3.0` in `cql-base.props` and `Demo/cql-demo.props`, matching Vonk `FhirNetApiVersion` (`Directory.Packages.props`) at release cut time.

#### Potentially Breaking

- `ValueSetSource` no longer observes in-place edits to a `ValueSet.Expansion` it has already built a facade from. Previously the facade was built from a deferred walk of `expansion.contains` that ran on first query, and each `ValueSetSource` rebuilt it from the live expansion; the codes are now materialized at `Add` and the result is shared process-wide against that `ExpansionComponent` instance. A host that appends to `contains` or adjusts `total` after a successful build will not see the change. Replacing `ValueSet.Expansion` with a new instance is observed only when that replacement is supplied to a subsequent/new `ValueSetSource`; existing sources keep the earlier facade, as does editing an expansion after a build *failed* on it. (#1568)
- Facade materialization moved from first query to `Add`. A caller that bulk-loads value sets it never queries (`Add(IEnumerable<ValueSet>)`, `ToValueSetDictionary`) now pays the expansion walk and code interning up front rather than never. (#1568)

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

- None.

---

### Upgrade Checklist

1. If you pass Packager CLI `--cs-namespace`, regenerate generated `*.g.cs` artifacts and update references/assertions that depended on prior global-namespace output.
2. If you replace a `ValueSet.Expansion` after a `ValueSetSource` has already built a facade from the prior instance, supply the replacement to a subsequent/new `ValueSetSource` to observe the new membership.

---

### Common Items To Check

- PublicAPI shipped/unshipped promotions: no pending public API member entries to promote.
- New or changed exception types: none in this release window.
- Public runtime/operator API changes: none in this release window.
- Generator version and invoker range: stated above under `### Generated Code Compatibility`; neither moved this release.
- `FirelyNetVersion` updates: none (`6.3.0` unchanged).
- Packager CLI argument changes: `--cs-namespace` binding fix for `cql` and `elm`.
- MSBuild property, target, or script-flag changes: `LibrarySets/sync-dqm-2025.ps1` gained `-ValueSetsOnly`, `-SkipValueSets`, `-VsacApiKey` and `-ValueSetOids` (#1563). It is a repository-maintenance script, not shipped tooling, so no consumer-facing entry is warranted.
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
