/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm;

#pragma warning disable CS1591

// The property should be 'library', not 'Library', to match the JSON structure.
// ReSharper disable once InconsistentNaming
internal record LibraryContainer(Library library);

public partial class Library
{
    internal static bool EnableDebugAssertions = true;

    /// <summary>
    /// Loads a library from a JSON string.
    /// </summary>
    public static Library ParseFromJson(string json, bool validate = true)
    {
        var node = JsonNode.Parse(json) ??
                   throw new InvalidOperationException("JsonNode.Parse unexpectedly returned null.");

        return LibraryJsonSerializer.DeserializeFromJsonNode(node, validate, null);
    }

    /// <summary>
    /// Loads a library from a directory containing ELM files.
    /// </summary>
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

        throw new FileNotFoundException($"File '{elmFile.FullName}' does not exist.", elmFile.FullName);
    }

    /// <summary>
    /// Loads a library from a JSON file.
    /// </summary>
    public static Library LoadFromJson(FileInfo file, bool validate = true)
    {
        if (!file.Exists)
            throw new FileNotFoundException($"File {file.FullName} does not exist.");

        using var stream = file.OpenRead();
        return LoadFromJson(stream, validate, originalFilePath: file.FullName);
    }

    /// <summary>
    /// Loads a library from a stream containing JSON.
    /// </summary>
    public static Library LoadFromJson(Stream stream, bool validate = true, string? originalFilePath = null)
    {
        var node = JsonNode.Parse(stream, documentOptions: LibraryJsonSerializer.GetJsonDocumentOptions()) ??
                   throw new InvalidOperationException("JsonNode.Parse unexpectedly returned null.");

        originalFilePath ??= stream switch
        {
            FileStream { Name: { } name } => name,
            _                             => null,
        };

        return LibraryJsonSerializer.DeserializeFromJsonNode(node, validate, originalFilePath);
    }

    /// <summary>
    /// Serializes this library to a JSON string.
    /// </summary>
    public string SerializeToJson(bool writeIndented = true)
    {
        return LibraryJsonSerializer.SerializeToJson(this, writeIndented);
    }

    /// <summary>
    /// Writes this library in JSON format to <paramref name="stream"/>.
    /// </summary>
    /// <param name="stream">A writable stream.</param>
    /// <param name="writeIndented">If <see langword="true" />, formats the JSON with indenting.</param>
    public void WriteJson(Stream stream, bool writeIndented = true)
    {
        LibraryJsonSerializer.SerializeToStream(this, stream, writeIndented);
    }

    /// <summary>
    /// Builds JSON serializer options for ELM serialization.
    /// This method is exposed for testing purposes.
    /// </summary>
    internal static JsonSerializerOptions BuildSerializerOptions(bool allowOldStyleTypeDiscriminators = false)
    {
        return LibraryJsonSerializer.BuildSerializerOptions(allowOldStyleTypeDiscriminators);
    }
}
