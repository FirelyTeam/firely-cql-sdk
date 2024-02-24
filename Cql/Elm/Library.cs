#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using Hl7.Cql.Graph;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Elm
{
    [DebuggerDisplay("Library ({NameAndVersion})")]
    public partial class Library
    {
        public const string JsonMimeType = "application/elm+json";
        public const string XmlMimeType = "application/elm+xml";
        public const string LibraryNodeProperty = "Library";

        public static readonly JsonSerializerOptions JsonSerializerOptions = GetSerializerOptions(false);
        public static readonly JsonSerializerOptions JsonSerializerOptionsStrict = GetSerializerOptions(true);

        public string? NameAndVersion
        {
            get
            {
                if (identifier == null)
                    return null;
                else if (string.IsNullOrWhiteSpace(identifier.version))
                    return identifier.id;
                else return $"{identifier.id}-{identifier.version}";
            }
        }

        public string? Name
        {
            get
            {
                if (identifier == null)
                    return null;
                return identifier.id;
            }
        }

        public string? Version
        {
            get
            {
                if (identifier == null)
                    return null;
                return identifier.version;
            }
        }

        private static JsonSerializerOptions GetSerializerOptions(bool strict)
        {
            var options = new JsonSerializerOptions()
            {
                MaxDepth = int.MaxValue
            }
            .AddLibraryConverters()
            .AddPolymorphicConverters(strict);
            options.Converters.Add(new XmlQualifiedNameConverter());
            options.Converters.Add(new JsonStringEnumConverter());
            return options;
        }

        public static Library LoadFromJson(FileInfo file)
        {
            if (!file.Exists)
                throw new ArgumentException($"File {file.FullName} does not exist.");
            using var stream = file.OpenRead();
            return LoadFromJson(stream);
        }
        public static Library LoadFromJson(Stream stream) =>
            JsonSerializer.Deserialize<Library>(stream, JsonSerializerOptions) ??
            stream switch
            {
                FileStream fs => throw new ArgumentException(
                    $"Stream does not represent a valid {nameof(Library)}: {fs.Name}"),
                _ => throw new ArgumentException(
                    $"Stream does not represent a valid {nameof(Library)}")
            };

        /// <summary>
        /// Get a flat list of ELM libraries included in the set of libraries passed in. 
        /// </summary>
        /// <param name="libraries">top-level libraries</param>
        /// <returns>flat list of all included libraries</returns>
        public static IEnumerable<Library> GetIncludedElmLibraries(IEnumerable<Library> libraries)
            => libraries.GetIncludedElmLibraries();
    }
}
