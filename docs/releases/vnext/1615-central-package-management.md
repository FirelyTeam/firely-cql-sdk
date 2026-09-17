## Dependency Updates

- **Build tooling:** external package versions are now managed centrally in a root `Directory.Packages.props`
  instead of being declared per-project. This is internal to how the SDK is built and changes nothing a
  consumer references, with one exception recorded below. (#1615)
- **Documentation:** the root `README.md`'s "External Dependencies" table has been removed. It restated the
  pinned versions by hand and drifted repeatedly without anyone noticing. To see which packages the SDK
  depends on and at exactly which versions, read
  [`Directory.Packages.props`](https://github.com/FirelyTeam/firely-cql-sdk/blob/develop/Directory.Packages.props)
  in the repository root — it is what the build uses, so it cannot be out of date. (#1615)
- **Runtime/compiler packages:** `Microsoft.Extensions.Logging.Abstractions` moves `10.0.7` → `10.0.3`, back in
  line with the rest of the `Microsoft.Extensions.*` family. It had been pinned separately to satisfy a
  transitive floor from an older Firely .NET SDK release; the current Firely .NET SDK no longer imposes it.
  Two packages the pin was lifting transitively move with it:
  `Microsoft.Extensions.DependencyInjection.Abstractions` `10.0.7` → `10.0.3` and
  `System.Diagnostics.DiagnosticSource` `10.0.7` → `10.0.3`.

  For consumers this **lowers a minimum**, so it is not a breaking change: the dependency floor the affected
  `Hl7.Cql.*` packages declare drops from `10.0.7` to `10.0.3`, and an application already resolving `10.0.7`
  or newer keeps doing so. No public API, generated C# output, or CQL evaluation result changes with it. (#1615)
