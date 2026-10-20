## New Public API

- **Invocation toolkit** — `CqlAssemblyWithNewerReferenceError`, a new `ICqlAssemblyInfoError` in
  `Hl7.Cql.Invocation.Toolkit.Errors`, is the `CqlAssemblyInfo.ReadError` of an assembly that references a newer
  version of an assembly than the host has. It names the assembly (`AssemblyName`), the referenced assembly
  (`ReferencedAssemblyName`), the version referenced (`ReferencedVersion`) and the host's version (`HostVersion`).
  (#1830, #1838)

## Potentially Breaking

- **Invocation toolkit — `InvocationToolkit.ReadCqlAssemblyInfo` reports an assembly that references a newer version
  of an assembly than the host has as not supported.** It compares each assembly the read assembly references with the
  host's assembly of the same name: the SDK's, the Firely .NET SDK's, the .NET runtime's, or any other the host has.
  Such an assembly read as supported before. It now reads with `IsSupported` false and `HasReadErrors` true, a
  `CqlAssemblyWithNewerReferenceError` as its `ReadError`, and no libraries listed. That covers a `+dll` packaged by a
  later release of the SDK, which references that release's assemblies, and one compiled on a newer .NET than the
  host runs. A reference to an assembly the host does not have, such as the assembly of an included library, is still
  left to the load. (#1830, #1838)
  - **Who sees a difference:** any host that reads `IsSupported` or `HasReadErrors`, such as one that rejects FHIR
    `Library` attachments it cannot run. Through the default load context the toolkit could not load these assemblies
    anyway: `CreateLibrarySetInvoker` failed for the whole library set they were added to. A host whose own resolver
    binds older copies of the referenced assemblies could load them, though, and now sees them reported as not
    supported.
  - **What to do:** treat `CqlAssemblyWithNewerReferenceError` like any other `ReadError`, or skip the check for
    assemblies whose references the host resolves itself.
