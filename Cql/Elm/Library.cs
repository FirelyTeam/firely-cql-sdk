#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using Hl7.Cql.Abstractions.Exceptions;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Elm;

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

    public string? Name => identifier?.id;

    public string? Version => identifier?.version;

    private void Validate(FileInfo file)
    {
        if (string.IsNullOrWhiteSpace(NameAndVersion))
            throw new LibraryMissingNameAndVersionError(this, file.FullName).ToException();
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

    public static Library LoadFromJson(
        FileInfo file,
        bool noValidate = false)
    {
        if (!file.Exists)
            throw new FileNotFoundException($"File does not exist.", file.FullName);
        
        using var stream = file.OpenRead();
        var library = LoadFromJson(stream);
        if (!noValidate) 
            library.Validate(file);

        return library;
    }

    public static Library LoadFromJson(Stream stream) =>
        JsonSerializer.Deserialize<Library>(stream, JsonSerializerOptions) ??
        stream switch
        {
            FileStream fs => throw new ArgumentException($"Stream does not represent a valid {nameof(Library)}: {fs.Name}"),
            _ => throw new ArgumentException($"Stream does not represent a valid {nameof(Library)}")
        };
}

internal interface ILibraryError : ICqlError
{
    Library Library { get; }
}

internal readonly record struct LibraryMissingNameAndVersionError(Library Library, string FilePath) : ILibraryError
{
    public string GetMessage() => $"Library did not have a valid name and version. Library Name&Version: '{Library.NameAndVersion}', Library Path: '{FilePath}'";
}