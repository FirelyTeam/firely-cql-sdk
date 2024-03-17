#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable RS0026 // Do not add multiple public overloads with optional parameters


using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Fhir.Model;
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

    [JsonIgnore]
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

    [JsonIgnore]
    public string? Name => identifier?.id;

    [JsonIgnore]
    public string? Version => identifier?.version;

    internal bool IsValidated { get; private set; }

    /// <exception cref="CqlException{LibraryMissingNameAndVersionError}"></exception>
    private void Validate(FileInfo file)
    {
        if (string.IsNullOrWhiteSpace(NameAndVersion))
            throw new LibraryMissingNameAndVersionError(this, file.FullName).ToException();

        if (includes is { Length: > 0 } includeDefs)
        {
            foreach (var includeDef in includeDefs)
            {
                if (string.IsNullOrEmpty(includeDef.path))
                    throw new LibraryMissingIncludeDefPathError(this, includeDef).ToException();
            }
        }

        IsValidated = true;
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

    /// <exception cref="FileNotFoundException"></exception>
    /// <exception cref="CqlException{LibraryMissingNameAndVersionError}"></exception>
    /// <exception cref="CqlException{NotAValidLibraryFileError}"></exception>
    public static Library? LoadFromJson(
        DirectoryInfo elmDirectory,
        string lib,
        string version,
        bool validate = true)
    {
        var elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{lib}-{version}.json"));
        if (!elmFile.Exists) elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{lib}.json"));
        return LoadFromJson(elmFile, validate);
    }

    /// <exception cref="FileNotFoundException"></exception>
    /// <exception cref="CqlException{LibraryMissingNameAndVersionError}"></exception>
    /// <exception cref="CqlException{NotAValidLibraryFileError}"></exception>
    public static Library? LoadFromJson(
        FileInfo file,
        bool validate = true)
    {
        if (!file.Exists)
            throw new FileNotFoundException("File does not exist.", file.FullName);
        
        using var stream = file.OpenRead();
        var library = LoadFromJson(stream);
        if (validate)
        {
            if (library is null)
                throw new NotAValidLibraryFileError(file.FullName).ToException();
            library.Validate(file);
        }

        return library;
    }

    /// <exception cref="ArgumentException"></exception>
    public static Library? LoadFromJson(Stream stream) =>
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
internal readonly record struct LibraryMissingIncludeDefPathError(Library Library, IncludeDef IncludeDef) : ILibraryError
{
    public string GetMessage() => $"Library has an include definition with a missing path. Library Identifier: '{Library.NameAndVersion}'";
}