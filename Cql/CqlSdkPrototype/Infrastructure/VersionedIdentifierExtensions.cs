using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Infrastructure;

public static class VersionedIdentifierExtensions
{
    internal static CqlVersionedLibraryIdentifier ToCqlVersionedLibraryIdentifier(this VersionedIdentifier identifier)
    {
        // We have to check for nulls because the generated ELM code does not emit nullability annotations.
        ArgumentNullException.ThrowIfNull(identifier);
        ArgumentNullException.ThrowIfNull(identifier.id);

        var cqlLibraryIdentifier = CqlLibraryIdentifier.Parse(identifier.id);
        CqlLibraryVersion? cqlLibraryVersion = identifier.version is null ? null : CqlLibraryVersion.Parse(identifier.version);
        return CqlVersionedLibraryIdentifier.FromNameAndVersion(cqlLibraryIdentifier, cqlLibraryVersion);
    }
}