## Fixes

- **Code generator** — A library without a version, or with a version that isn't numeric such as `1.0.0-draft`, now
  compiles and can be invoked. The generated class always carries the two-argument `[CqlLibrary]`, with `null` for a
  missing version, and `ILibrary.Version` returns `null` for such a library. The compiled assembly gets an
  `AssemblyVersion` only when the library's version is a numeric `major[.minor[.build[.revision]]]` that fits one.
  `GeneratorToolVersion` is now 6.2.1.0. For a library with a numeric version, the generated C# is unchanged apart from
  that marker. (#1846, #1849)

## Potentially Breaking

- **Runtime** — `ILibrary.Version`, `CqlLibraryAttribute.Version` and the `Version` parameter of `CqlLibraryAttribute`'s
  constructor are declared `string?`, since a library can have no version. Compiled code is unaffected. Code that reads
  them with nullable warnings enabled may get a new warning. (#1846, #1849)
