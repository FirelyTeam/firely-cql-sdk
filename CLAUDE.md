# Firely CQL SDK

This project also maintains GitHub Copilot instructions under [.github/copilot-instructions.md](.github/copilot-instructions.md) and `.github/copilot-instructions/`. This file is the Claude Code equivalent — ported from those documents, with task-specific workflows moved to skills (see the bottom of this file) so they load only when needed.

If the user gives a memory-style instruction ("remember...", "never...", "always..."), add it to this file immediately (or the relevant skill, if it's specific to one workflow) rather than only remembering it for the session.

**Keep this in sync with the Copilot instructions.** When you add, remove, or change a rule here (or in a `.claude/skills/` file), check whether `.github/copilot-instructions.md` or one of its sub-documents states the same rule and needs the equivalent update, and vice versa. A universal convention or gotcha shouldn't exist in one file and not the other; a task-specific workflow should have exactly one canonical copy (here, in `.claude/skills/`), with the Copilot side linking to it rather than restating it.

## Working style

- When asked for ideas, suggestions, or "what's the best way to..." — discuss 2-3 options with trade-offs and wait for the user to pick one before implementing. Don't jump straight to code for exploratory questions.
- When running PowerShell via a terminal tool, always use non-interactive mode (`-NonInteractive`) — interactive PowerShell/`dotnet repl` sessions will hang waiting for input. Don't open an interactive shell unless explicitly asked.
- Prefer the GitHub CLI (`gh`) over raw HTTP/browser steps for issue/PR lookup and edits. If it's missing, install and authenticate it first.
- Tick off acceptance-criteria checkboxes in a PR's linked issue (and the PR body) automatically, whenever their truth may have changed: after pushing work, after a follow-up commit that addresses review comments, and when reviewing a PR — including someone else's. Do it before reporting the review or the task done — see the `sync-acceptance-criteria` skill.
- After fixing a review comment and pushing the fix, mark that conversation resolved (it doesn't happen automatically) — see the `resolve-pr-review-comments` skill.
- While reviewing someone else's PR, never commit to that PR branch. Send findings to the author (or `@copilot`) to apply instead; if a reviewer pushes code, that reviewer has now contributed to the branch and the review is no longer eligible as approval, so a second reviewer becomes required.
- When requesting `@copilot` to apply PR changes, post a PR comment (not only a review body mention) that includes the complete ask in that comment: exact file path, concrete before/after change, and rationale. Do not post pointer-only asks like "apply item 11."
- When checking whether `@copilot` work landed, check all channels: issue comments, PR reviews, inline PR comments, and timeline events (`copilot_work_started`/`copilot_work_finished`). If a session finished and head SHA did not change, nothing was applied. Any `since` filter must use the real source event timestamp, not an approximate rounded time.
- When a convention change is needed in `CLAUDE.md` or `.github/copilot-instructions/`, file an issue and have `@copilot` apply it on a branch instead of editing instruction files ad hoc in a local working copy.

## Code conventions (non-obvious ones)

- **Copyright headers** (`*.cs`, not `*.g.cs`): new files get the standard header with the current year and "Firely, NCQA and contributors". **Never modify an existing file's header** — if Firely isn't already listed as a contributor there, leave it as-is; only new files get the full attribution line.
- **`InternalsVisibleTo`** goes in the `.csproj` (`<InternalsVisibleTo Include="ProjectName" Key="$(LibraryPKHash)" />`), never in `AssemblyInfo.cs`.
- New internal-only utility types/files should stay `internal`, not `public` — only expose what's meant for external consumption.
- Every new `.cs` file needs its own `#nullable enable` directive after the header, even though nullable is enabled globally in props — this repo wants it explicit per file.
- Check `GlobalUsings.cs` before adding a `using` — don't duplicate what's already global.
- **Reflection goes through [`ReflectionUtility`](Cql/Cql.Abstractions/Abstractions/Infrastructure/ReflectionUtility.cs)**, not string-based lookups. Use `MethodOf(() => x.Method(…))`, `PropertyOf(() => x.Prop)`, `ConstructorOf(() => new T(…))` and `GenericMethodDefinitionOf(() => x.Generic<T>(…))` instead of `typeof(X).GetMethod("Name")` / `GetProperty("Name")`. The expression form is checked by the compiler, follows renames, and returns a non-null result or throws with the offending expression in the message — so it also removes the `!` and the null-guard that string lookups drag along. The class is `internal` to `HL7.Cql.Abstractions`, which grants `InternalsVisibleTo` to every SDK assembly (`Hl7.Cql.Runtime`, `Hl7.Cql.Fhir`, `Hl7.Cql.Compiler`, …) plus `CoreTests`, so it is available essentially everywhere. `nameof` in a `GetMethod`/`GetProperty` call is not a substitute: it survives renames but still resolves by string at run time and still cannot see an overload change.
- Naming: `CqlSdk` prefix for example projects, `Hl7.Cql` namespace prefix for core SDK assemblies.
- Project docs (READMEs, `docs/`) use hierarchical heading numbers (`# 1.`, `## 1.1.`, `### 1.1.1.`) and always cross-reference other documents with real Markdown links (`[label](relative/path.md)`), never a bare filename. Internal-only packages should describe what they do in their README but skip usage code samples (only packages meant for direct consumer use get those).
- **Mermaid diagrams** in markdown docs must be pre-rendered to `.svg` and embedded as an image, not left as a raw `` ```mermaid `` fenced block — GitHub's inline renderer doesn't reliably support `classDiagram` `namespace` blocks, multi-target `style` directives, or custom `<<stereotype>>` annotations, which this repo's diagrams use. See the `generate-svg-from-mermaid` skill.

## Nullological operators — interface vs implementation return type

`IsNull`/`IsTrue`/`IsFalse` on [`ICqlOperators`](Cql/Cql.Runtime/Operators/ICqlOperators.cs) **must** return `bool?` even though the CQL spec (§9.B) guarantees they never return null — this keeps the operator-binding system consistent across all operators. The implementation class (`CqlOperators`) returns the narrower `bool`, which implicitly converts. Don't "fix" the interface to `bool`.

## CQL evaluation errors: use `ICqlError` + `CqlException<TError>`, not raw .NET exceptions

For any error the CQL spec says should "signal an error to the calling environment" during expression evaluation (arithmetic failures, type mismatches, spec-mandated date/time errors, etc.), throw a `CqlException<TError>` wrapping a `public readonly record struct` implementing `ICqlError` — not `InvalidOperationException`/`ArgumentException` (those stay reserved for actual programming errors, e.g. bad method arguments).

The struct holds raw metadata (unit name, value, etc.) as constructor parameters; `GetMessage()` builds the human-readable string lazily, on demand, rather than at the throw site. This keeps error handling strongly-typed (`catch (CqlException<CqlUcumYearArithmeticError> e)`) and avoids allocating message strings for errors that get caught without ever being displayed.

```csharp
// correct — metadata in, message built lazily
public readonly record struct CqlArithmeticError(string Unit, string CalendarEquivalent) : ICqlError
{
    public string GetMessage() => $"Use '{CalendarEquivalent}' instead of UCUM unit '{Unit}'.";
}
// wrong — don't pass a pre-built message string into the struct
```

See [Cql/Cql.Abstractions/CLAUDE.md](Cql/Cql.Abstractions/CLAUDE.md) for where these structs live and how that project is organized.

## FHIR `Library.Name` vs `Library.Id`

These are **not interchangeable**. `Library.Name` is the canonical identifier used for `CqlVersionedLibraryIdentifier` and CQL `library` declarations; `Library.Id` is just the FHIR server resource id. Never fall back with `library.Name ?? library.Id` — validate `Name` is present and fail explicitly if not. Always build identifiers via `CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(name, version)`, not manual string formatting.

## CQL specification conformance

`/spec/cql/condensed/` (see `/spec/cql/README.md` for the section index and which spec version is mirrored) is the authoritative CQL 1.5.3 Release 1 Errata 2 spec for this repo — a markdown mirror kept because `cql.hl7.org` may be unreachable in some environments. Check it before implementing/reviewing/fixing any CQL operator, and when writing tests for operator semantics. If `cql.hl7.org` turns out to be reachable during a session, tell the user — it may mean the local mirror needs updating.

A similar mirror for FHIR spec pages actually used by this repo (e.g. `Measure`/`Library` resource definitions, Quality Measure IG conformance) lives at `/spec/fhir/condensed/`, fetched on demand per-page via `tools/condense_spec/fetch_fhir_page.py <url>` rather than vendored wholesale — see `/spec/fhir/README.md` for which pages are cached and when they were last fetched.

## Validating emitted output

A test that pins the exact text of something the SDK emits answers "did the output change?", never "is the output correct?" — and when the expectation written first is itself wrong, the assertion turns a defect into a defended invariant. So wherever the emitted format has an independent checker, assert against it as well as against the string: the string pins the shape, the checker pins the validity. A validator, a parser, or a round-trip back through the reader all serve; pick whichever the format already has.

For FHIR primitives that checker is `Hl7.Fhir.Model.<Type>.IsValidValue(value)` (`FhirDateTime`, `Time`, `Date`, `Instant`, …), a public static on the already-referenced `Hl7.Fhir.Base` — one line per emission point.

"Pre-existing" and "out of scope" are reasons not to *fix* invalid output in the change at hand. They are never reasons to write a test asserting the invalid output is correct, or a comment claiming an invariant the code does not hold — quarantine it with a comment pointing at the tracking issue instead.

## Build

- Build `Cql-Sdk.slnf`, not `Cql-Sdk-All.sln` — the `.sln` includes submodules you likely don't have access to.
- Any change to build scripts/project files must keep working on both Windows and Unix (Linux/macOS/WSL): maintain matching `.ps1`/`.sh` script pairs, use `Condition="'$(OS)' == 'Windows_NT'"` (or `!=`) rather than assuming an OS, and match directory-name case exactly — Unix filesystems are case-sensitive even though this repo is usually edited on Windows. Avoid platform-specific tools like `flock` (no default on macOS); prefer a portable mechanism like directory-based locking.
- CI skips the full build when every changed file matches an `ignorePatterns` entry in `build/azure-pipelines.yml` (currently `docs/`, any `*.md` file, and `.claude/`). If a PR touching only those also needs CI to actually run (e.g. testing a skill's shell commands), touch a non-ignored file too.

## Dependency version bumps — update the root README table

When any external package version is bumped in a `.csproj` or `.props` file, also update the version number in the **"External Dependencies" table in the root `README.md`** — not just the sub-project READMEs (which don't state version numbers). The root README's versioned table is the only place the canonical pinned versions are documented for consumers, and it silently drifts after bumps that only touch `csproj` files. Likewise, check `docs/` for any design or assessment doc that mentions a version number for the same package and update it too.

## Code generation version (`GeneratorToolVersion`)

Any change that alters the C# emitted for CQL libraries requires bumping `LibrarySetCSharpCodeGenerator.GeneratorToolVersion` (hardcoded in `Cql/CodeGeneration.NET/_CODE GENERATOR VERSION_.cs`) — and this is broader than it sounds: it also covers `Cql.Compiler` changes that make `CqlOperatorsBinder` emit different `ICqlOperators` calls (different overload, generic args, or conversions), and `ICqlOperators` signature changes that flow into call sites. Use semver on the 4-part version: major for changes needing new `LibraryInstanceInvoker` support, minor for non-breaking additions, patch for bug fixes that don't change the generated API. Check that the current `LibraryInstanceInvoker_<major>_<minor>.SupportsVersion` (via `MinSupportedGeneratorToolVersion`/`FirstUnsupportedGeneratorToolVersion` in `Cql/Cql.Invocation/Toolkit/Internal/LibraryInvoker.<major>.<minor>.cs`, e.g. `LibraryInvoker.5.0.cs`) covers the new version, and add a new invoker if a major bump needs one. **Regenerate every checked-in `*.g.cs` file** (`CoreTests/CSharp`, demo library sets, etc.) in the same PR, then **commit only the files whose content actually changed** — `git checkout` the ones whose sole difference is the embedded `GeneratedCodeAttribute` version header. Checked-in generated files therefore carry a mix of versions, which is fine and intentional: the version is an internal marker, the invoker toolkit accepts any version inside the supported range (see `SupportsVersion` above), and the golden tests normalize it away before comparing. Keeping header-only churn out of the commit is what makes the PR diff reviewable — a real change to one library shouldn't hide inside ninety files that differ by one line each.

## Release notes

Any breaking change (public API, generated C# output, Packager CLI behavior, build/tooling behavior) must be recorded in the same PR that introduces it — not deferred to release time. Add a new fragment file under [docs/releases/vnext/](docs/releases/vnext/README.md) (one file per PR, see that folder's README for the naming/format convention) rather than editing the shared `vnext-release-notes.md` (now a static pointer doc — not directly editable), which causes merge conflicts between parallel PRs (see [#1432](https://github.com/FirelyTeam/firely-cql-sdk/issues/1432)). When cutting a release, fragment files under `docs/releases/vnext/` are the sole source — fold them into the versioned release notes, then delete them. See the `cut-release-notes` skill for the full procedure.

## Skills

Task-specific workflows live under `.claude/skills/` and load on demand — invoke them (or let them trigger) rather than expecting this always-loaded file to cover the steps:

- `write-pr-description` — updating a PR description from the full branch history
- `file-github-issue` — issue formatting conventions, and superseding a stale issue with a fresh one
- `pickup-github-ticket` — resolving a ticket number/URL to a branch and picking up work
- `cut-release-notes` — consolidating all pending release-note content (fragment files under `docs/releases/vnext/`) into a versioned release note, then deleting the fragments
- `generate-elm-from-cql` — regenerating ELM JSON after adding CQL test input files
- `generate-svg-from-mermaid` — adding/editing a Mermaid diagram and rendering it to a committed `.svg`
- `run-integration-benchmarks` — running the Integration Runner submodule's BenchmarkDotNet project and comparing against its committed baselines (INTERNAL USE ONLY)
