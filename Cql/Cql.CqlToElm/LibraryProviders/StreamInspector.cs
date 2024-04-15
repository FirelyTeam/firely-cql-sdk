using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.LibraryProviders
{

    internal class StreamInspector
    {
        public bool TryIdentify(Stream stream, out LibraryInfo? libraryInfo)
        {
            var sr = new StreamReader(stream);
            var first = PeekFirstNonWhitespaceCharacter(sr);
            switch (first)
            {
                case '{':
                    {
                        var lib = FromJson(stream);
                        if (lib is null || lib.identifier is null)
                        {
                            libraryInfo = null;
                            return false;
                        }
                        else
                        {
                            libraryInfo = new LibraryInfo(lib.identifier, lib, LibraryInfo.ElmJsonMimeType);
                            return true;
                        }
                    }
                case '<':
                    {
                        var lib = FromXml(stream);
                        if (lib is null || lib.identifier is null)
                        {
                            libraryInfo = null;
                            return false;
                        }
                        else
                        {
                            libraryInfo = new LibraryInfo(lib.identifier, lib, LibraryInfo.ElmXmlMimeType);
                            return true;
                        }
                    }
                default:
                    {
                        var vi = FromCql(sr);
                        if (vi is not null)
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
            }
        }

        internal Library? FromJson(Stream stream)
        {
            try
            {
                return Library.LoadFromJson(stream);
            }
            catch { return null; }
        }
        private Library? FromXml(Stream reader) => null;

        private Regex LibraryWithVersion = new Regex("^library\\s+(?'name'\\S+)(\\s+version\\s+'(?'version'\\d+(\\.\\d+)*)')$", RegexOptions.Compiled);
        private Regex LibraryWithoutVersion = new Regex("^library\\s+(?'name'\\S+)$", RegexOptions.Compiled);
        internal VersionedIdentifier? FromCql(StreamReader reader)
        {
            // TODO: use ANTLR?
            var pos = reader.BaseStream.Position;
            var line = reader.ReadLine();
            while (line != null)
            {
                line = line.Trim();
                if (string.IsNullOrWhiteSpace(line))
                    line = reader.ReadLine();
                else
                {
                    // library name version '1.0'
                    // always must be the first non-empty line in a CQL file
                    var versionMatch = LibraryWithVersion.Match(line);
                    if (versionMatch.Success)
                    {
                        reader.BaseStream.Position = pos;
                        return new VersionedIdentifier
                        {
                            id = versionMatch.Groups["name"].Value,
                            version = versionMatch.Groups["version"].Value
                        };
                    }
                    var nonVersionMatch = LibraryWithoutVersion.Match(line);
                    if (nonVersionMatch.Success)
                    {
                        reader.BaseStream.Position = pos;
                        return new VersionedIdentifier
                        {
                            id = nonVersionMatch.Groups["name"].Value,
                            version = null
                        };
                    }
                    else
                    {
                        reader.BaseStream.Position = pos;
                        return null;
                    }
                }
            }
            reader.BaseStream.Position = pos;
            return null;
        }

        private static char? PeekFirstNonWhitespaceCharacter(StreamReader reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader), "StreamReader cannot be null.");
            }

            // Remember the original position
            long originalPosition = reader.BaseStream.Position;

            while (!reader.EndOfStream)
            {
                char currentChar = (char)reader.Read();

                // Check if the current character is not whitespace
                if (!char.IsWhiteSpace(currentChar))
                {
                    // Move the stream position back to the non-whitespace character
                    reader.BaseStream.Position = originalPosition;
                    reader.DiscardBufferedData(); // Necessary to reset the internal buffer and reader's position

                    // Return the non-whitespace character
                    return currentChar;
                }

                // Update the original position since we've read another character
                originalPosition = reader.BaseStream.Position;
            }

            // If we reach the end of the stream without finding a non-whitespace character, return null
            return null;
        }
    }
}
