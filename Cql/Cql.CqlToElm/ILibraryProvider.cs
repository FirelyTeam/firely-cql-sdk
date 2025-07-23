/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CqlToElm
{
    internal interface ILibraryProvider
    {
        bool TryResolveLibrary(string libraryName, string? version, [NotNullWhen(true)] out LibraryBuilder? libraryBuilder, out string? error);
    }
}
