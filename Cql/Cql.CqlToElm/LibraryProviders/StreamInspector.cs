/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Cql.CqlToElm.Visitors;

namespace Hl7.Cql.CqlToElm.LibraryProviders
{
    internal class StreamInspector
    {
        internal VersionedIdentifier? FromCql(StreamReader reader)
        {
            try
            {
                var library = CqlToElmConverter.ParseLibrary(reader);
                return library.libraryDefinition()?.Parse();
            }
            catch (InvalidOperationException)
            {
                // Should return when we find parser errors.
                return null;
            }
        }
    }
}
