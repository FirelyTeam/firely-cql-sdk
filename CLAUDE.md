# Firely CQL SDK

This project also maintains GitHub Copilot instructions under [.github/copilot-instructions.md](.github/copilot-instructions.md) and `.github/copilot-instructions/`. This file is the Claude Code equivalent — ported from those documents, with task-specific workflows moved to skills (see the bottom of this file) so they load only when needed.

If the user gives a memory-style instruction ("remember...", "never...", "always..."), add it to this file immediately (or the relevant skill, if it's specific to one workflow) rather than only remembering it for the session.

**Keep this in sync with the Copilot instructions.** When you add, remove, or change a rule here (or in a `.claude/skills/` file), check whether `.github/copilot-instructions.md` or one of its sub-documents states the same rule and needs the equivalent update, and vice versa. A universal convention or gotcha shouldn't exist in one file and not the other; a task-specific workflow should have exactly one canonical copy (here, in `.claude/skills/`), with the Copilot side linking to it rather than restating it.

## Working style

- When asked for ideas, suggestions, or "what's the best way to..." — discuss 2-3 options with trade-offs and wait for the user to pick one before implementing. Don't jump straight to code for exploratory questions.
- When running PowerShell via a terminal tool, always use non-interactive mode (`-NonInteractive`) — interactive PowerShell/`dotnet repl` sessions will hang waiting for input. Don't open an interactive shell unless explicitly asked.
- Prefer the GitHub CLI (`gh`) over raw HTTP/browser steps for issue/PR lookup and edits. If it's missing, install and authenticate it first.

## Code conventions (non-obvious ones)

- **Copyright headers** (`*.cs`, not `*.g.cs`): new files get the standard header with the current year and "Firely, NCQA and contributors". **Never modify an existing file's header** — if Firely isn't already listed as a contributor there, leave it as-is; only new files get the full attribution line.
- **`InternalsVisibleTo`** goes in the `.csproj` (`<InternalsVisibleTo Include="ProjectName" Key="$(LibraryPKHash)" />`), never in `AssemblyInfo.cs`.
- New internal-only utility types/files should stay `internal`, not `public` — only expose what's meant for external consumption.
- Every new `.cs` file needs its own `#nullable enable` directive after the header, even though nullable is enabled globally in props — this repo wants it explicit per file.
- Check `GlobalUsings.cs` before adding a `using` — don't duplicate what's already global.
- Naming: `CqlSdk` prefix for example projects, `Hl7.Cql` namespace prefix for core SDK assemblies.
- Project docs (READMEs, `docs/`) use hierarchical heading numbers (`# 1.`, `## 1.1.`, `### 1.1.1.`) and always cross-reference other documents with real Markdown links (`[label](relative/path.md)`), never a bare filename. Internal-only packages should describe what they do in their README but skip usage code samples (only packages meant for direct consumer use get those).

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

`/spec/condensed/` (see its `README.md` for the section index) is the authoritative CQL 1.5.3 Release 1 Errata 2 spec for this repo — a markdown mirror kept because `cql.hl7.org` may be unreachable in some environments. Check it before implementing/reviewing/fixing any CQL operator, and when writing tests for operator semantics. If `cql.hl7.org` turns out to be reachable during a session, tell the user — it may mean the local mirror needs updating.

## Build

- Build `Cql-Sdk.slnf`, not `Cql-Sdk-All.sln` — the `.sln` includes submodules you likely don't have access to.
- Any change to build scripts/project files must keep working on both Windows and Unix (Linux/macOS/WSL): maintain matching `.ps1`/`.sh` script pairs, use `Condition="'$(OS)' == 'Windows_NT'"` (or `!=`) rather than assuming an OS, and match directory-name case exactly — Unix filesystems are case-sensitive even though this repo is usually edited on Windows. Avoid platform-specific tools like `flock` (no default on macOS); prefer a portable mechanism like directory-based locking.

## Code generation version (`GeneratorToolVersion`)

Any change that alters the C# emitted for CQL libraries requires bumping `LibrarySetCSharpCodeGenerator.GeneratorToolVersion` (hardcoded in `CodeGeneration.NET/_CODE GENERATOR VERSION_.cs`) — and this is broader than it sounds: it also covers `Cql.Compiler` changes that make `CqlOperatorsBinder` emit different `ICqlOperators` calls (different overload, generic args, or conversions), and `ICqlOperators` signature changes that flow into call sites. Use semver on the 4-part version: major for changes needing new `LibraryInstanceInvoker` support, minor for non-breaking additions, patch for bug fixes that don't change the generated API. Check that the current `LibraryInstanceInvoker_X_Y.SupportsVersion` (via `MinSupportedGeneratorToolVersion`/`FirstUnsupportedGeneratorToolVersion` in `Cql.Invocation/Toolkit/Internal/LibraryInvoker.X.Y.cs`) covers the new version, and add a new invoker if a major bump needs one. **Regenerate every checked-in `*.g.cs` file** (`CoreTests/CSharp`, demo library sets, etc.) in the same PR — the version is embedded via `GeneratedCodeAttribute` and must match.

## Release notes

Any breaking change (public API, generated C# output, Packager CLI behavior, build/tooling behavior) must be recorded in [docs/releases/vnext-release-notes.md](docs/releases/vnext-release-notes.md) in the same PR that introduces it — not deferred to release time. See the `cut-release-notes` skill for the full release-cutting procedure.

## Skills

Task-specific workflows live under `.claude/skills/` and load on demand — invoke them (or let them trigger) rather than expecting this always-loaded file to cover the steps:

- `write-pr-description` — updating a PR description from the full branch history
- `file-github-issue` — issue formatting conventions
- `pickup-github-ticket` — resolving a ticket number/URL to a branch and picking up work
- `cut-release-notes` — turning `vnext-release-notes.md` into a versioned release note
- `generate-elm-from-cql` — regenerating ELM JSON after adding CQL test input files
