## Breaking changes

- The C#-emission settings on `ElmToolkitConfig` moved into a nested `CSharpConfig`, reached
  through the new `CSharp` property, and `CSharpNamespace` lost its prefix in the move:

  ```csharp
  // before
  new ElmToolkitConfig(CSharpNamespace: "MyCompany.MyCqlLibraries", AllowInvalidCSharp: true)

  // after
  new ElmToolkitConfig(
      CSharp: new CSharpConfig(
          Namespace: "MyCompany.MyCqlLibraries",
          AllowInvalidCSharp: true))
  ```

  The matching Packager configuration keys moved with them, so `Elm:CSharpNamespace` and
  `Elm:AllowInvalidCSharp` in `Hl7.Cql.Packager.appsettings.json` become `Elm:CSharp:Namespace` and
  `Elm:CSharp:AllowInvalidCSharp`. The `--cs-namespace` command-line option is unchanged. (#1580)

- `CSharpConfig.Nullability` selects how much of C#'s nullable reference types the generated
  `*.g.cs` opt into, mirroring the `#nullable` directive the generator emits:

  | Value | Directive | Effect |
  | --- | --- | --- |
  | `Disabled` | none | null-oblivious, as before nullable emission was added |
  | `Annotations` | `#nullable enable annotations` | declarations carry honest `T?` annotations; the compiler does not verify them |
  | `Enabled` (default) | `#nullable enable` | annotations plus flow analysis |

  The default is `Enabled`, which is the change in emitted output described in
  [1580-nullable-generated-csharp-annotations.md](1580-nullable-generated-csharp-annotations.md).

  `Annotations` exists because the honest API surface — the point of the change for consumers — does
  not require the compiler to verify it, whereas `Enabled` makes the generator emit null-forgiving
  operators and bridging casts purely to satisfy flow analysis. The demo measure corpora use
  `Annotations` for that reason; see the "Why nullability has three modes" note in
  [Cql/CodeGeneration.NET/README.md](../../../Cql/CodeGeneration.NET/README.md). (#1580)
