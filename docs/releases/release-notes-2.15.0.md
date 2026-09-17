## Firely CQL SDK 2.15.0

> [!WARNING]
> **.NET 8 support ends on 10 November 2026.** Microsoft's .NET 8 reaches
> [End of Support](https://devblogs.microsoft.com/dotnet/dotnet-8-9-end-of-support/) on that date, and
> CQL SDK 2.x support for .NET 8 ends with it — see
> [discussion #1426](https://github.com/FirelyTeam/firely-cql-sdk/discussions/1426) for the full
> announcement. This release still ships `net8.0` alongside `net10.0`; plan your move to .NET 10
> (Microsoft's current LTS) before that date. Progress on removing the target is tracked in
> [#1427](https://github.com/FirelyTeam/firely-cql-sdk/issues/1427).

### tl;dr

> **Upgrading?** Here is the short version:
>
> - **Breaking changes:** Two CQL-to-ELM translator typing corrections change the C# generated for conditional expressions — an `if`/`else if` chain whose branches share no common type is now typed as the *choice* of those types (generating `object`), while an `if` with one `Any`-typed branch now takes the other branch's concrete type. Separately, expanding a valueset no longer writes the computed expansion back into the `ValueSet` instance the host supplied or the resolver owns.
> - **Required migrations:** Regenerate packaged artifacts and checked-in `*.g.cs` for any library containing those conditional patterns, and re-verify measure output — results move where an `if`/`else` chain previously evaluated branches to `null`. If your host reads `ValueSet.Expansion` back after `Add`/`Load` or after expanding a valueset with `compose.include`, expand for yourself instead.
> - **Highlights:** An `if`/`else if` chain returning lists of different tuple types no longer silently returns `null` for every branch but the first — a defect that produced wrong measure scores with no error and no warning.

---

### Version Level

- **MESO** (`2.15.0`) — the second digit, meaning some small effort may be required. See [versioning.md](../versioning.md) for what the digits mean.

---

### Generated Code Compatibility

- `LibrarySetCSharpCodeGenerator.GeneratorToolVersion`: **5.2.1.0** (unchanged from `2.14.0`).
- Accepted by `LibraryInstanceInvoker_5_0`, whose supported range is `[5.1.0.0, 5.3.0.0)`.

Note that generated C# **does** change in this release for libraries containing the conditional patterns fixed by #1595 and #1606, even though the generator version did not move — the change originates in the ELM the translator produces, upstream of the generator. Regenerate on the basis of the entries below rather than on the generator version.

---

### CQL SDK

#### New Public API

- None.

#### Improvements

- The SDK's versioning policy is now written down in [docs/versioning.md](../versioning.md): the package version uses [EffVer](https://jacobtomlinson.dev/effver/) (Intended Effort Versioning), not Semantic Versioning, and `GeneratorToolVersion` is a separate SemVer scale. If you have been reading our version numbers as SemVer, that document explains what the digits actually promise. (#1589)

#### Dependency Updates

- `FirelyNetVersion`: `6.3.0` → `6.5.0` in `cql-base.props` and `Demo/cql-demo.props`, bumping `Hl7.Fhir.Base` and `Hl7.Fhir.R4` for every package that consumes Firely .NET SDK types (`Hl7.Cql.Fhir`, `Hl7.Cql.Packaging`, `Hl7.Cql.Packager`) and for the demo projects. The root `README.md` "External Dependencies" table matches. A consumer with its own direct reference to the Firely .NET SDK should move it to `6.5.0` as well. No public API, generated C# output, or CQL evaluation result changes with it. (#1611)
- `Microsoft.SourceLink.GitHub`: `8.0.0` → `10.0.401`, resolving the NU1902 advisory warning. The reference is `PrivateAssets="All"`, so it is a build-time asset of the SDK's own compilation and does not appear in a consumer's dependency graph. (#1609)

#### Potentially Breaking

- **CQL-to-ELM translator:** an `if` / `else if` chain whose branches have no common type is now typed as the *choice* of its branch types rather than as the first branch's type. For a define written that way, the generated C# signature changes from that first branch's concrete type to `object` — the same C# an equivalent `case` has always produced. Any code compiled against the previous signature of such a define needs updating, and packaged artifacts need regenerating. Only defines containing this branch-type pattern are affected; every other define generates exactly as before. (#1594, #1595)
- **CQL-to-ELM translator:** an `if` whose `then` or `else` branch is typed `Any` — from a call to an undefined function under `AllowUnresolvedExternals`, from `Message(null, ...)`, or any other expression the translator could not resolve to a more specific type — is no longer typed `Any` itself when the other branch has a concrete type. A define written that way now generates C# typed as that concrete type instead of `object`. Only defines containing this exact pattern are affected; every other define generates exactly as before. (#1601, #1606)
- `ValueSetSource` no longer writes a computed expansion into the valueset handed to `Add` or resolved by `Load`. Two consequences for hosts: a host that read `ValueSet.Expansion` back after `Add`/`Load` no longer finds one there and must expand for itself; and two sources with *different* resolvers handed the same expansion-less instance no longer share the first source's expansion — each now answers from its own resolver's world, so membership answers can move (to the correct ones). (#1591, #1592)
- After an expansion, a valueset that was pulled in through another valueset's `compose.include` no longer carries the computed expansion on the resolver-owned instance: a host that read `ValueSet.Expansion` back from such an included instance after expanding the outer valueset no longer finds one there and must expand for itself. This mirrors the entry #1592 records for the instance handed to `Add` or resolved by `Load`, extended to transitively included instances. (#1597, #1596)

#### Fixes

- **CQL-to-ELM translator:** an `if` / `else if` chain whose branches evaluate to lists of different tuple types no longer returns `null` for all but one branch. The translator typed the whole chain as the first branch's type and cast every other branch down to it; for tuple lists — which the C# code generator lowers to nullable value tuples — that cast is always `null` at run time, with no error and no warning, so those branches silently evaluated to nothing while the branches matching the chain's type kept working. Reconciliation now refuses any cast that cannot hold all of a branch's alternatives, so the chain widens to the choice of its branch types and each branch returns its own value regardless of branch order. **CQL evaluation results change:** a define containing this pattern previously scored as if the affected branches were empty and now returns their values, so measure output can move. (#1594, #1595)
- **CQL-to-ELM translator:** as above, an `if` whose `then` or `else` branch is typed `Any` no longer widens the other, meaningfully-typed branch down to `Any`. `ElmFactory.If` special-cased this reconciliation only for a literal `null` branch; any other `Any`-typed branch, on either side, fell through to the general cost-based reconciliation below, which could judge coercing the well-typed branch *up* to `Any` cheaper than coercing the `Any`-typed branch down to it, and picked that direction. That is visible wherever the conditional feeds a typed consumer: a `such that` clause's relationship lambda expects `Func<T, bool?>`, and a `such that` built from this pattern produced `Func<T, object>` instead, which the C# compiler has no overload to bind (`CannotBindToCqlOperatorError`). The non-`Any` branch's static type now governs whenever the other branch is `Any`-typed, in both directions, matching two things this translator already does elsewhere: the Java reference translator (`cql-to-elm-cli`), which is symmetric here, and this translator's own `case` construct, which already drops `Any` from a branch's result type regardless of which branch it came from. (#1601, #1606)
- A valueset that arrives without an expansion is now expanded on a private copy, so a host cache serving that instance to every consumer in the process is no longer corrupted by the SDK: the computed expansion used to be written into the caller's instance, and a failed expansion used to clear it. Valuesets resolved transitively through `compose.include` are protected the same way. A valueset added or loaded directly is expanded at most once per source through the per-canonical facade layer; a canonical reached only as another valueset's include is expanded anew for every resolver lookup that pulls it in. Hosts that want reuse across sources or across includes can serve valuesets with static expansions or seed sources via `Add(string, IEnumerable<CqlCode>)`. (#1591, #1592)
- Expanding a valueset no longer writes a computed expansion into — or clears one from — the valuesets its `compose.include` pulls in through the resolver. An expansion-less included valueset is now expanded on a private copy as well, closing the gap left by #1591/#1592: a host cache serving such a valueset to every consumer in the process is no longer corrupted by the underlying `ValueSetExpander`'s in-place writes (adjacent defect B of [firely-net-sdk#3582](https://github.com/FirelyTeam/firely-net-sdk/issues/3582)). Only expansion-less valuesets are copied — an included valueset that already carries an expansion is only read by the expander and passes through as-is — and only on the cold path, where a valueset missing the per-source cache has to be expanded at all. (#1597, #1596)

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

- `Microsoft.SourceLink.GitHub` bumped to `10.0.401`, clearing the NU1902 security advisory warning from restore. (#1609)
- Dependabot no longer scans the private `Firely.Cql.Sdk.Integration.Runner` submodule, which it cannot access — removing a recurring job failure from the dependency-update runs. (#1610)

---

### Upgrade Checklist

1. **Regenerate packaged artifacts and checked-in `*.g.cs`** for any CQL library containing an `if`/`else if` chain whose branches have differing types, or an `if` with one `Any`-typed branch. The generated signature changes in both cases (to `object` in the first, to the concrete branch type in the second), even though `GeneratorToolVersion` did not move.
2. **Re-verify measure output.** Where an `if`/`else if` chain previously returned `null` for branches that did not match the chain's type, those branches now return their values, so scores computed on `2.14.0` can differ from scores computed on `2.15.0`. Treat a moved score as expected for those libraries rather than as a new defect.
3. **Update any code compiled against an affected define's previous signature** — this is a source-level change where the signature moved to or from `object`.
4. **If your host reads `ValueSet.Expansion` back** off an instance it passed to `ValueSetSource.Add`/`Load`, or off a valueset reached through another's `compose.include`, expand it yourself — the SDK now expands on a private copy and no longer writes the result back.
5. **If you relied on two `ValueSetSource` instances with different resolvers sharing an expansion** computed by whichever ran first, note that each now answers from its own resolver. Serve valuesets with static expansions, or seed sources via `Add(string, IEnumerable<CqlCode>)`, if you need sharing.
6. **If you are on `net8.0`, start planning the move to `net10.0`** — see the warning at the top of this document.

---

### Common Items To Check

- Version level: **MESO**, stated under `### Version Level` above.
- PublicAPI shipped/unshipped promotions: none to promote — all 13 `PublicAPI.Unshipped.txt` files are header-only.
- New or changed exception types: none in this release window. (#1606 makes the `CannotBindToCqlOperatorError` binding failure stop occurring for the affected pattern; the error type itself is unchanged.)
- Public runtime/operator API changes: none in this release window.
- Generator version and invoker range: stated above under `### Generated Code Compatibility`; neither moved, though generated C# does change for affected libraries.
- `FirelyNetVersion` updates: `6.3.0` → `6.5.0` (#1611), with the root README External Dependencies table updated to match. **Note for maintainers:** `cql-base.props` asks this to match `FhirNetApiVersion` in [Vonk's `Directory.Packages.props`](https://github.com/FirelyTeam/Vonk/blob/develop/Directory.Packages.props), which was still `6.3.0` on Vonk's `develop` when this release was cut. That is the expected order rather than a defect: the SDK moves first, and Vonk moves to `6.5.0` as part of upgrading to this release, so the two converge at adoption. Worth knowing because `Hl7.Cql.Fhir` `2.15.0` declares `Hl7.Fhir.Base >= 6.5.0`, so a host that pins the Firely .NET SDK directly needs to move it in the same step rather than afterwards.
- Packager CLI argument changes: none in this release window.
- MSBuild property, target, or script-flag changes: none consumer-facing. `.github/dependabot.yml` gained a submodule exclusion (#1610), which is CI configuration and outside the version scales.
- Content previously drafted in `docs/releases/vnext-release-notes.md`: none (file remains a static pointer doc).
- All merged PRs since `v2.14.0`: included below.

---

### Pull Requests

| PR | Title |
| --- | --- |
| [#1611](https://github.com/FirelyTeam/firely-cql-sdk/pull/1611) | Update Firely .NET SDK to 6.5.0 |
| [#1610](https://github.com/FirelyTeam/firely-cql-sdk/pull/1610) | Skip private submodules in Dependabot |
| [#1609](https://github.com/FirelyTeam/firely-cql-sdk/pull/1609) | Fix NU1902: bump Microsoft.SourceLink.GitHub to 10.0.401 |
| [#1606](https://github.com/FirelyTeam/firely-cql-sdk/pull/1606) | Don't widen a typed `If` branch to `Any` |
| [#1596](https://github.com/FirelyTeam/firely-cql-sdk/pull/1596) | Expand included valuesets on private copies |
| [#1595](https://github.com/FirelyTeam/firely-cql-sdk/pull/1595) | Widen `if`/`else` branch types instead of narrowing |
| [#1592](https://github.com/FirelyTeam/firely-cql-sdk/pull/1592) | Expand resolved valuesets on a private copy |
| [#1589](https://github.com/FirelyTeam/firely-cql-sdk/pull/1589) | Document EffVer as the versioning scheme |
