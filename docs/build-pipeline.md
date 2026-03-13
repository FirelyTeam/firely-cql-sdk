# CQL Build Pipeline

This document describes the cross-platform build scripts, MSBuild props/targets files, and the Java tooling that together implement the multi-stage CQL-to-measure pipeline used across the repository.

## Build Scripts

Two cross-platform build scripts at the repository root drive the multi-stage build interactively or from CI:

| Script | Platform |
|--------|----------|
| `build.ps1` | Windows / PowerShell Core |
| `build.sh` | Linux / macOS / Bash |

### Parameters

**`build.ps1`** (PowerShell):

```powershell
.\build.ps1 [-Framework <net8.0|net10.0>] [-Configuration <Debug|Release>]
            [-EnableCqlTooling] [-EnableElmTooling]
```

**`build.sh`** (Bash):

```bash
./build.sh [--framework <net8.0|net10.0>] [--configuration <Debug|Release>]
           [--enable-cql-tooling] [--enable-elm-tooling]
```

If you run either script without arguments it prompts interactively.

### Examples

```bash
# Build with no code generation (fastest — only compiles C# from committed sources)
./build.sh --framework net10.0 --configuration Debug

# Regenerate ELM from CQL (requires Java + Maven), then build
./build.sh --framework net10.0 --enable-cql-tooling

# Regenerate C# and FHIR resources from ELM (requires PackagerCLI), then build
./build.sh --framework net10.0 --enable-elm-tooling

# Full pipeline: CQL → ELM (Java) → C# + FHIR (PackagerCLI) → assembly
./build.sh --framework net10.0 --enable-cql-tooling --enable-elm-tooling
```

### Two-Phase Build When `ElmToolingEnabled` Is True

When `--enable-elm-tooling` (or `-EnableElmTooling`) is specified, the script performs a **two-phase build**:

1. **Phase 1** — Build `Cql-Sdk.slnf` (core SDK only, without `ElmToolingEnabled`). This ensures `PackagerCLI` and all its dependencies are fully compiled and on disk before any measure project tries to launch the packager executable.

2. **Phase 2** — Build `Cql-Sdk-All.sln` with `ElmToolingEnabled=true` and `-maxcpucount:1` (serialised). Because PackagerCLI is already up-to-date from Phase 1, MSBuild skips recompiling it. The `-maxcpucount:1` flag ensures only one `GenerateCSharp` target fires at a time, preventing file-write races when multiple measure projects run the packager simultaneously.

## MSBuild Props and Targets Files

### `packaging-tooling.props`

Located at the repository root. Imported by every measure project **before** declaring project-specific properties. Defines:

| Property | Default | Description |
|----------|---------|-------------|
| `CqlSolutionDir` | `$(MSBuildThisFileDirectory)` | Root of the repository |
| `CqlToolingTargetsDir` | `$(CqlSolutionDir)/Demo/Cql/Build/` | Directory containing the tooling targets |
| `CqlToolingEnabled` | `false` | Set to `true` to run the Java CQL-to-ELM step |
| `ElmToolingEnabled` | `false` | Set to `true` to run the PackagerCLI ELM-to-C# step |
| `JsonPretty` | `true` | Emit pretty-printed JSON for FHIR resources |
| `PackagerLogFile` | `packager.log` | Packager CLI log output file name |
| `EmbedDebugSymbolsEnable` | `true` (non-Release) | Embed PDB symbols in generated assemblies |

### `packaging-tooling.Targets.xml`

Also at the repository root. Imported by every measure project **after** all other properties are set. It simply forwards to the two tooling targets files:

```xml
<Import Project="$(CqlToolingTargetsDir)CqlToElm.Targets.xml" />
<Import Project="$(CqlToolingTargetsDir)ElmToCSharp.Targets.xml" />
```

### `Demo/Cql/Build/CqlToElm.Targets.xml`

Handles the **CQL → ELM** step using the Java CQL-to-ELM CLI.

**How it works:**

1. A `BeforeTargets="PreBuildEvent"` target named `"Download CQL to ELM CLI"` runs the Maven-based download script (`Java-Dependencies-Download.ps1` on Windows, `.sh` on Unix) to fetch the `cql-to-elm-cli` and `elm-fhir` JARs into `Demo/Cql/Build/target/dependency/`. Downloads are cached; Maven is only invoked when the JAR directory is empty.

2. A second target `GenerateElmFiles` (also `BeforeTargets="PreBuildEvent"`) is gated by:
   - `CqlToolingEnabled == true`
   - `LibrarySet` is non-empty (so only measure projects run it, not the Cql project itself)
   - Target framework is `net10.0` or unspecified (prevents duplicate runs in multi-targeting)

   It uses incremental build inputs/outputs:
   ```xml
   Inputs="@(CqlFiles)"   <!-- *.cql in $(CqlDirectory) -->
   Outputs="@(CqlFiles->'$(ElmDirectory)/%(FileName).json')"
   ```

   The Java command invoked is:
   ```
   java -classpath <JARs> org.cqframework.cql.cql2elm.cli.Main
        -input <CqlDirectory>
        -f JSON
        -output <ElmDirectory>
        -locators true
        -result-types true
        -signatures All
   ```

   Console output is captured and written to `elm-build.log` in the project directory.

3. A `CleanElmFiles` target (runs `AfterTargets="Clean"`) deletes all generated ELM JSON files when `dotnet clean` is run.

**Key properties consumed:**

| Property | Description |
|----------|-------------|
| `CqlDirectory` | Directory containing `*.cql` source files |
| `ElmDirectory` | Output directory for generated `*.json` ELM files |
| `LibrarySet` | Name of the measure library set (e.g. `Demo`) |

### `Demo/Cql/Build/ElmToCSharp.Targets.xml`

Handles the **ELM → C# + FHIR resources** step using the `PackagerCLI` .NET tool.

**How it works:**

A `BeforeTargets="PreBuildEvent"` target named `GenerateCSharp` is gated by:
- `ElmToolingEnabled == true`
- The `PackagerCLI` binary exists at `Cql/PackagerCLI/bin/$(Configuration)/$(ToolTargetFramework)/Hl7.Cql.Packager[.exe]`
- Target framework matches `$(ToolTargetFramework)` (defaults to `net10.0`) or is unspecified

The target:
1. **Deletes** all existing files under `CSharp/**/*.cs` and `$(ResourcesDirectory)/*.json` to avoid stale artefacts when CQL definitions are renamed.
2. **Invokes PackagerCLI** with the `elm` sub-command:
   ```
   Hl7.Cql.Packager elm
       --elm       <ElmDirectory>
       --cql       <CqlDirectory>
       --cs        <CSharpDirectory>
       --fhir      <ResourcesDirectory>
       --canonical-root-url <CanonicalRootUrl>
       --override-utc-date-time "1970-01-01T00:00:00Z"
       --json-pretty true
       --log-file  packager.log
   ```
3. **Adds** the freshly-generated `CSharp/**/*.cs` files to the MSBuild `Compile` item group so Roslyn compiles them as part of the current project.
4. On **error**, touches the CQL source files (`TouchFiles` target) so the next build retries the generation step.

Cleanup targets (`Delete CSharp`, `Delete Resources`, `Delete Results`) run on `dotnet clean`.

**Key properties consumed:**

| Property | Description |
|----------|-------------|
| `ElmDirectory` | Input ELM JSON files |
| `CqlDirectory` | Input CQL source files (for source mapping) |
| `CSharpDirectory` | Output directory for generated `.cs` files (conventionally `<Project>/CSharp/`) |
| `ResourcesDirectory` | Output directory for generated FHIR `Library` JSON resources |
| `CanonicalRootUrl` | Base URL for FHIR canonical identifiers (e.g. `https://fire.ly/fhir/`) |
| `PackagerLogFile` | Path for PackagerCLI log output |
| `LibrariesDirectory` | (Optional) Additional FHIR Library dependencies directory |
| `MeasuresDirectory` | (Optional) FHIR Measure resource directory |
| `Profile` | (Optional) Profile name passed to the packager |

### `Demo/Cql/Build/pom.xml`

Maven project descriptor used exclusively to download the Java CQL-to-ELM tooling JARs. It declares two dependencies:

| Artifact | Purpose |
|----------|---------|
| `info.cqframework:cql-to-elm-cli` | Java CQL-to-ELM command-line interface |
| `info.cqframework:elm-fhir` | ELM-to-FHIR conversion support |

The version is pinned in `Java-Dependencies-Vars.ps1` / `Java-Dependencies-Vars.sh` (currently `3.29.0`). When updating the version you must keep it consistent across:
- `pom.xml`
- `Java-Dependencies-Vars.ps1`
- `Java-Dependencies-Vars.sh`
- `Hl7.Cql.Packager.Program.JavaToolVersion` in `PackagerCLI`

Maven downloads JARs on first build into `Demo/Cql/Build/target/dependency/` and caches them there. Downloads are mutex-protected to handle parallel MSBuild processes safely.

## Further Reading

- [Demo projects](demo-projects.md) — the `Demo/` projects that use this pipeline, and how to configure a measure project
- [CQL Packager Reference](cql-packager.md) — all `cql-package` commands, options, and examples
- [Getting Started](getting-started.md) — prerequisites and first steps
- [cqframework/clinical_quality_language](https://github.com/cqframework/clinical_quality_language) — upstream Java CQL-to-ELM tool
- More information can be found at [Firely's documentation site](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html).
