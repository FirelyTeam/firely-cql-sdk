# vNext Release Notes

## Breaking Changes

### MSBuild properties `CqlToElmEnabled` and `ElmToCSharpEnabled` renamed

The two MSBuild properties that gate the code-generation pipeline stages have been renamed to better reflect their actual scope:

| Old name | New name |
|----------|----------|
| `CqlToElmEnabled` | `CqlToolingEnabled` |
| `ElmToCSharpEnabled` | `ElmToolingEnabled` |

`ElmToCSharpEnabled` was a misnomer — it did not only convert ELM to C#, but drove the full PackagerCLI pipeline that also produces FHIR `Library` resources. `ElmToolingEnabled` more accurately describes the step.

#### Migration

Update any references in your project files, build scripts, and CI pipelines:

```xml
<!-- Before -->
<CqlToElmEnabled>true</CqlToElmEnabled>
<ElmToCSharpEnabled>true</ElmToCSharpEnabled>

<!-- After -->
<CqlToolingEnabled>true</CqlToolingEnabled>
<ElmToolingEnabled>true</ElmToolingEnabled>
```

If you pass these properties on the command line:

```shell
# Before
dotnet build /p:CqlToElmEnabled=true /p:ElmToCSharpEnabled=true

# After
dotnet build /p:CqlToolingEnabled=true /p:ElmToolingEnabled=true
```

The `build.ps1` / `build.sh` scripts at the repository root have also been updated. The script flags follow the same rename:

| Old flag (PowerShell) | New flag (PowerShell) |
|-----------------------|-----------------------|
| `-EnableCqlToElm` | `-EnableCqlTooling` |
| `-EnableElmToCSharp` | `-EnableElmTooling` |

| Old flag (Bash) | New flag (Bash) |
|-----------------|-----------------|
| `--enable-cql-to-elm` | `--enable-cql-tooling` |
| `--enable-elm-to-csharp` | `--enable-elm-tooling` |

### CQL Packager: File logging is no longer enabled by default

Previously, the CQL Packager always wrote log output to a file named `build.log` in the current working directory.

**New behavior:** File logging is disabled by default. To enable file logging, specify the log file path using the new `--log-file` CLI argument.

#### Migration

Before:
```shell
cql-package elm --elm input/elm --fhir output/fhir
# Previously, this would always write logs to ./build.log
```

After:
```shell
# No file logging (new default behavior):
cql-package elm --elm input/elm --fhir output/fhir

# To log to a file, specify --log-file:
cql-package elm --elm input/elm --fhir output/fhir --log-file build.log
```

#### New `--log-file` CLI Argument

A new `--log-file <path>` argument has been added to all commands. It specifies the path of the log file. If this argument is not provided, no file logging is performed.

The existing `--log-append` and `--file-log-level` arguments continue to work as before, but are only relevant when `--log-file` is specified.
