using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Invocation;

public abstract class LibraryInvokerOnInstance(ILibrary library) : LibraryInvoker
{
    public ILibrary Library { get; } = library;

    public override CqlVersionedLibraryIdentifier LibraryVersionedIdentifier { get; } =
        CqlVersionedLibraryIdentifier.FromNameAndVersion(CqlLibraryIdentifier.Parse(library.Name),
                                                         CqlLibraryVersion.Parse(library.Version));
}