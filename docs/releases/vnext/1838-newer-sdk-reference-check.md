## New Public API

- **Invocation toolkit** — `CqlAssemblyWithNewerReferenceError`, a new `ICqlAssemblyInfoError` in
  `Hl7.Cql.Invocation.Toolkit.Errors`, is the `CqlAssemblyInfo.ReadError` of an assembly that references a newer
  version of an assembly than the host has. It names the assembly (`AssemblyName`), the referenced assembly
  (`ReferencedAssemblyName`), the version referenced (`ReferencedVersion`) and the host's version (`HostVersion`).
  (#1830, #1838)

## Improvements

- **Invocation toolkit** — `InvocationToolkit.ReadCqlAssemblyInfo` compares each assembly that the assembly it reads
  references with the host's assembly of the same name: the SDK's, the Firely .NET SDK's, the .NET runtime's, or any
  other the host has. An assembly that references a newer version than the host's now reads as not supported
  (`IsSupported` is false), with a `CqlAssemblyWithNewerReferenceError` as its `ReadError` and no libraries listed,
  where it read as supported before. That covers a `+dll` packaged by a later release of the SDK, which references
  that release's assemblies, and one compiled on a newer .NET than the host runs. The toolkit cannot load such an
  assembly, and `CreateLibrarySetInvoker` fails for the whole library set it is added to. A reference to an assembly
  the host does not have, such as the assembly of an included library, is still left to the load. A host that
  resolves such references to its own older assemblies itself sees these assemblies reported as not supported too.
  (#1830, #1838)
