using Hl7.Cql.Elm;
using System;

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
