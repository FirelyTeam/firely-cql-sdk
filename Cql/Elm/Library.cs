#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable RS0026 // Do not add multiple public overloads with optional parameters


using Hl7.Cql.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Elm;

public partial class Library
{
    public const string JsonMimeType = "application/elm+json";
    public const string XmlMimeType = "application/elm+xml";
    public const string LibraryNodeProperty = "Library";

    public static readonly JsonSerializerOptions JsonSerializerOptions = GetSerializerOptions(false);
    public static readonly JsonSerializerOptions JsonSerializerOptionsStrict = GetSerializerOptions(true);

    internal bool IsValidated { get; private set; }

    /// <exception cref="CqlException{LibraryMissingNameAndVersionError}"></exception>
    private void Validate()
    {
        if (IsValidated)
            return;

        NameAndVersion(throwError: true);

        if (includes is { Length: > 0 } includeDefs)
        {
            foreach (var includeDef in includeDefs)
            {
                if (includeDef.NameAndVersion(throwError: false) == null)
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
            {
                throw new CouldNotDeserializeFileError(file.FullName, "ELM Library").ToException();
            }

            try
            {
                library.Validate();
            }
            catch (Exception e)
            {
                throw new CouldNotValidateFileError(file.FullName, "ELM Library").ToException(e);
            }
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

    public static IEqualityComparer<Library> EqualityComparerByNameAndVersion { get; } =
        EqualityComparerFactory.For<Library>.CreateByKey(lib => lib.NameAndVersion(true)!);

    public static IComparer<Library> ComparerByNameAndVersion { get; } =
        ComparerFactory.For<Library>.CreateByKey(lib => lib.NameAndVersion(true)!);
}

internal class LibraryByNameAndVersionHashSet : HashSet<Library>
{
    public LibraryByNameAndVersionHashSet() : base(Library.EqualityComparerByNameAndVersion)
    {
    }

    public LibraryByNameAndVersionHashSet(IEnumerable<Library> collection) : base(collection, Library.EqualityComparerByNameAndVersion)
    {
    }

    public LibraryByNameAndVersionHashSet(int capacity) : base(capacity, Library.EqualityComparerByNameAndVersion)
    {
    }

    protected LibraryByNameAndVersionHashSet(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

internal class LibraryByNameAndVersionDictionary<TValue> : Dictionary<Library, TValue>
{
    public LibraryByNameAndVersionDictionary() : base(Library.EqualityComparerByNameAndVersion)
    {
    }

    public LibraryByNameAndVersionDictionary(IDictionary<Library, TValue> dictionary) : base(dictionary, Library.EqualityComparerByNameAndVersion)
    {
    }

    public LibraryByNameAndVersionDictionary(IEnumerable<KeyValuePair<Library, TValue>> collection) : base(collection, Library.EqualityComparerByNameAndVersion)
    {
    }

    public LibraryByNameAndVersionDictionary(int capacity) : base(capacity, Library.EqualityComparerByNameAndVersion)
    {
    }

    protected LibraryByNameAndVersionDictionary(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
