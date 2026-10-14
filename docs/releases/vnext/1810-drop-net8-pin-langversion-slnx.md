## Breaking changes

- **Build/tooling** — `net8.0` is no longer a supported target framework. The SDK now targets `net10.0`
  only. .NET 8 reached [End of Support on 10 November 2026](https://devblogs.microsoft.com/dotnet/dotnet-8-9-end-of-support/),
  and CQL SDK 2.x support for it ended on the same date — see
  [discussion #1426](https://github.com/FirelyTeam/firely-cql-sdk/discussions/1426). Applications still
  running on .NET 8 must move to .NET 10 to take this release. (#1810)

- **Build/tooling** — the legacy `Cql-Sdk-All.sln` is removed in favour of `Cql-Sdk-All.slnx`. The
  `Cql-Sdk.slnf` and `Cql-Sdk-Demos-Examples.slnf` solution filters are unchanged apart from the solution
  they point at, and continue to work as before. Anything referencing the solution by filename — scripts,
  pipelines, IDE configuration — needs to use the new name. (#1810)

- **Build/tooling** — the `test-multiframework.ps1` and `test-multiframework.sh` scripts are removed.
  They existed only to run the test suite against two target frameworks and compare the results, which
  no longer applies. Run `dotnet test` on the test projects directly. `build.ps1` and `build.sh` no
  longer accept `--framework net8.0`, and their interactive prompt now asks only for the build
  configuration. (#1810)

## Fixes

- **Build/tooling** — `LangVersion` is pinned to a specific C# version instead of `latest`. `latest`
  resolves to whatever the installed SDK supports rather than to the target framework's default, so it
  varied by machine and allowed language features ahead of the target framework. (#1810)
