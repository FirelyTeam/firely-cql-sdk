using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Hl7.Cql.CqlToElm.Visitors;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.CqlToElm.LibraryProviders
{

    internal class StreamInspector
    {
        public bool TryIdentify(Stream stream, out LibraryInfo? libraryInfo)
        {
            using var sr = new StreamReader(stream);
            var first = PeekFirstNonWhitespaceCharacter(sr);

            switch (first)
            {
                case '{' when FromJson(stream) is { identifier: not null } lib:
                    {
                        // From ELM in json format - read the info straight from the ELM
                        libraryInfo = new LibraryInfo(lib.identifier, 
                            LibraryBuilder.CreateFromExisting(lib),
                            LibraryInfo.ElmJsonMimeType);
                        return true;
                    }
                case '<' when FromXml(stream) is { identifier: not null } lib:
                    {
                        // From ELM in XML format - read the info straight from the ELM
                        libraryInfo = new LibraryInfo(lib.identifier, 
                            LibraryBuilder.CreateFromExisting(lib),
                            LibraryInfo.ElmXmlMimeType);
                        return true;
                    }
                case var _ when FromCql(sr) is { } vi:
                    {
                        // This is CQL, get the library info from the CQL text
                        libraryInfo = new LibraryInfo(vi, null, LibraryInfo.CqlMimeType);
                        return true;
                    }
                default:
                    {
                        // No idea, return null.
                        libraryInfo = null;
                        return false;
                    }
            }
        }

        internal bool TryCql(Stream stream, [NotNullWhen(true)] out LibraryInfo? libraryInfo)
        {
            using var sr = new StreamReader(stream);
            var vi = FromCql(sr);
            if (vi is { })
            {
                libraryInfo = new LibraryInfo(vi, null, LibraryInfo.CqlMimeType);
                return true;
            }
            else
            {
                libraryInfo = null;
                return false;
            }
        }
        internal bool TryJsonLibrary(Stream stream, [NotNullWhen(true)] out LibraryInfo? libraryInfo)
        {
            using var sr = new StreamReader(stream);
            var first = PeekFirstNonWhitespaceCharacter(sr);
            if (first == '{')
            {
                var lib = FromJson(stream);
                if (lib is { identifier: not null })
                {
                    libraryInfo = new LibraryInfo(lib.identifier,
                        LibraryBuilder.CreateFromExisting(lib), 
                        LibraryInfo.ElmJsonMimeType);
                    return true;
                }
            }
            libraryInfo = null;
            return false;
        }

        internal bool TryXmlLibrary(Stream stream, [NotNullWhen(true)] out LibraryInfo? libraryInfo)
        {
            using var sr = new StreamReader(stream);
            var first = PeekFirstNonWhitespaceCharacter(sr);
            if (first == '<')
            {
                var lib = FromXml(stream);
                if (lib is { identifier: not null })
                {
                    libraryInfo = new LibraryInfo(lib.identifier, 
                        LibraryBuilder.CreateFromExisting(lib),
                        LibraryInfo.ElmXmlMimeType);
                    return true;
                }
            }
            libraryInfo = null;
            return false;
        }

        internal static Library? FromJson(Stream stream)
        {
            try
            {
                return Library.LoadFromJson(stream);
            }
            catch { return null; }
        }

        private Library? FromXml(Stream reader) => null;

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

        private static char? PeekFirstNonWhitespaceCharacter(StreamReader reader)
        {
            if (reader == null)
                throw new ArgumentNullException(nameof(reader), "StreamReader cannot be null.");

            return (char)reader.Peek();
        }
    }
}