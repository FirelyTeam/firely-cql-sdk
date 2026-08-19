## Breaking changes

- The C#-emission settings on `ElmToolkitConfig` moved into a nested
  `CSharpGeneratingConfig`, reached through the new `CSharpGenerating` property. `CSharpNamespace`
  and `AllowInvalidCSharp` are no longer members of `ElmToolkitConfig` itself:

  ```csharp
  // before
  new ElmToolkitConfig(CSharpNamespace: "MyCompany.MyCqlLibraries", AllowInvalidCSharp: true)

  // after
  new ElmToolkitConfig(
      CSharpGenerating: new CSharpGeneratingConfig(
          CSharpNamespace: "MyCompany.MyCqlLibraries",
          AllowInvalidCSharp: true))
  ```

  The matching Packager configuration keys moved with them, so `Elm:CSharpNamespace` and
  `Elm:AllowInvalidCSharp` in `Hl7.Cql.Packager.appsettings.json` become
  `Elm:CSharpGenerating:CSharpNamespace` and `Elm:CSharpGenerating:AllowInvalidCSharp`. The
  `--cs-namespace` command-line option is unchanged. (#1580)

- `CSharpGeneratingConfig.NullabilityEnabled` controls whether generated `*.g.cs` opt into nullable
  reference types. It defaults to `true`, which is the change in emitted output described in
  [1580-nullable-generated-csharp-annotations.md](1580-nullable-generated-csharp-annotations.md).
  Set it to `false` to keep the previous null-oblivious output — no `#nullable` directive, no
  nullable annotations on declarations, and no null-forgiving operators. (#1580)
