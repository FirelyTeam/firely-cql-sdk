/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

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
