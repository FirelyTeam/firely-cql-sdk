## Fixes

- **Code generator** — A library without a version, or with a version that isn't numeric such as `1.0.0-draft`, now
  compiles and can be invoked. One case still fails: a library without a version whose name contains a dash, when it
  refers to its own definitions, which #1540 tracks. The generated class always carries the two-argument
  `[CqlLibrary]`, with `null` for a missing version. `ILibrary.Version` returns `null` for such a library, declared
  `string?` in an annotations context of its own, so a checked-in file compiles with nullable on or off. The compiled
  assembly gets an `AssemblyVersion` only when the library's version consists of unsigned decimal parts, each below
  65535. `GeneratorToolVersion` is now 6.2.1.0. For a library with a numeric version, the generated C# is unchanged
  apart from that marker. (#1846, #1849)

## Potentially Breaking

- **Runtime** — `ILibrary.Version`, `CqlLibraryAttribute.Version` and the `Version` parameter of `CqlLibraryAttribute`'s
  constructor are declared `string?`, since a library can have no version. Compiled code is unaffected. Code that reads
  them with nullable warnings enabled may get a new warning. (#1846, #1849)
