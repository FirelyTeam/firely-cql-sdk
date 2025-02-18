/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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
