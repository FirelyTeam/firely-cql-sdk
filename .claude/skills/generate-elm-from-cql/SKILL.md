---
name: generate-elm-from-cql
description: Regenerate ELM JSON files after adding or changing CQL input files in a test/library-set project (e.g. CoreTests/Input/ELM/HL7). Use when the user adds CQL files and needs the corresponding ELM generated.
---

# Generate ELM from CQL

`CqlToolingEnabled` is defined centrally in [packaging-tooling.props](../../../packaging-tooling.props) (default `false`, with a commented-out `true` override) and imported by library-set-style projects such as `CoreTests.csproj`. It's shared, not per-project — flipping it affects every project that imports that file, so toggle it, build, then revert promptly rather than leaving it flipped:

1. Uncomment the `<CqlToolingEnabled>true</CqlToolingEnabled>` override in `packaging-tooling.props`.
2. Build the specific project whose CQL files changed (e.g. `dotnet build Cql/CoreTests/CoreTests.csproj`) — this generates the ELM files.
3. Confirm an ELM file was generated for every CQL file. The output location is that project's `ElmDirectory` MSBuild property (for `CoreTests`, that's `Input/ELM/HL7`).
4. Re-comment the override back to `false` before committing — don't leave codegen enabled for other builds.
