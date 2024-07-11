/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable RS0026 // Do not add multiple public overloads with optional parameters


using Hl7.Cql.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Elm.Serialization;

namespace Hl7.Cql.Elm;

public partial class Library
{
    public const string JsonMimeType = "application/elm+json";
    public const string XmlMimeType = "application/elm+xml";
    public const string LibraryNodeProperty = "Library";

    public static readonly JsonSerializerOptions JsonSerializerOptions = GetSerializerOptions(false);
    public static readonly JsonSerializerOptions JsonSerializerOptionsStrict = GetSerializerOptions(true);

    internal bool IsValidated { get; private set; }

    /// <exception cref="LibraryMissingIncludeDefPathError"></exception>
    private void Validate()
    {
        if (IsValidated)
            return;

        _ = NameAndVersion(throwError: true);

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
    /// <exception cref="CouldNotDeserializeFileError"></exception>
    /// <exception cref="CouldNotValidateFileError"></exception>
    /// <exception cref="LibraryMissingIncludeDefPathError"></exception>
    public static Library LoadFromJson(
        DirectoryInfo elmDirectory,
        string lib,
        string version,
        bool validate = true)
    {
        var elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{lib}-{version}.json"));
        if (elmFile.Exists)
            return LoadFromJson(elmFile, validate);

        var elmFile2 = new FileInfo(Path.Combine(elmDirectory.FullName, $"{lib}.json"));
        if (elmFile2.Exists)
            return LoadFromJson(elmFile2, validate);

        throw new FileNotFoundException("File does not exist.", elmFile.FullName);
    }

    /// <exception cref="FileNotFoundException"></exception>
    /// <exception cref="CouldNotDeserializeFileError"></exception>
    /// <exception cref="CouldNotValidateFileError"></exception>
    /// <exception cref="LibraryMissingIncludeDefPathError"></exception>
    public static Library LoadFromJson(
        FileInfo file,
        bool validate = true)
    {
        if (!file.Exists)
            throw new FileNotFoundException("File does not exist.", file.FullName);

        using var stream = file.OpenRead();
        var library = LoadFromJson(stream, file.FullName);
        if (validate)
        {
            if (library is null)
            {
                throw new CouldNotDeserializeFileError(file.FullName, typeof(Library).FullName).ToException();
            }

            try
            {
                library.Validate();
            }
            catch (Exception e)
            {
                throw new CouldNotValidateFileError(file.FullName, typeof(Library).FullName).ToException(e);
            }
        }

        return library;
    }

    /// <exception cref="CouldNotDeserializeFileError"></exception>
    public static Library LoadFromJson(Stream stream, string? originalFilePath = null)
    {
        var library = JsonSerializer.Deserialize<Library>(stream, JsonSerializerOptions);
        originalFilePath ??= stream switch
        {
            FileStream { Name: { } name } => name,
            _ => null,
        };

        if (library is null)
            throw new CouldNotDeserializeFileError(originalFilePath, typeof(Library).FullName).ToException();

        library.OriginalFilePath = originalFilePath;
        return library;
    }

    /// <summary>
    /// Writes this library in JSON format to <paramref name="stream"/>.
    /// </summary>
    /// <param name="stream">A writable stream.</param>
    /// <param name="writeIndented">If <see langword="true" />, formats the JSON with indenting.</param>
    public void WriteJson(Stream stream, bool writeIndented = true)
    {
        var options = GetSerializerOptions(false);
        options.WriteIndented = writeIndented;
        JsonSerializer.Serialize(stream, this, options);
    }

    public static IEqualityComparer<Library> EqualityComparerByNameAndVersion { get; } =
        EqualityComparerFactory.For<Library>.CreateByKey(lib => lib.NameAndVersion(true)!);

    public static IComparer<Library> ComparerByNameAndVersion { get; } =
        ComparerFactory.For<Library>.CreateByKey(lib => lib.NameAndVersion(true)!);

    [JsonIgnore]
    internal string? OriginalFilePath { get; private set; }
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
}