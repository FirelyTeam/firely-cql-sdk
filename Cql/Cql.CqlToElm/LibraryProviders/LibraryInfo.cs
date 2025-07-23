/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.LibraryProviders
{
    internal record LibraryInfo(VersionedIdentifier? VersionedIdentifier, LibraryBuilder? Library, string MimeType)
    {
        // https://www.iana.org/assignments/media-types/application/elm+json
        public const string ElmJsonMimeType = "application/elm+json";
        // https://www.iana.org/assignments/media-types/application/elm+xml
        public const string ElmXmlMimeType = "application/elm+xml";
        // https://www.iana.org/assignments/media-types/text/cql
        public const string CqlMimeType = "text/cql";
    }

}
