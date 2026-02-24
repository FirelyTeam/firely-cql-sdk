/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm.Serialization;

namespace Hl7.Cql.Elm;

#pragma warning disable CS1591

public partial class Library
{
    /// <summary>
    /// Parses a JSON string and returns a corresponding Library object.
    /// </summary>
    /// <remarks>If validation is enabled and the JSON does not conform to the expected structure, an
    /// exception will be thrown.</remarks>
    /// <param name="json">The JSON string representation of the Library to be parsed. It must be a valid JSON format.</param>
    /// <param name="validate">Indicates whether to validate the JSON structure against the expected schema. Defaults to <see
    /// langword="true"/>.</param>
    /// <returns>A Library object that represents the parsed data from the provided JSON string.</returns>
    public static Library ParseFromJson(string json, bool validate = true)
    {
        var node = LibraryJsonSerializer.ParseToJsonNode(json);

        return LibraryJsonSerializer.DeserializeFromJsonNode(node, validate, null);
    }

    /// <summary>
    /// Loads a library definition from a JSON file located in the specified directory, searching by library name and
    /// version.
    /// </summary>
    /// <param name="elmDirectory">The directory that contains the JSON files representing library definitions. This parameter cannot be null.</param>
    /// <param name="lib">The name of the library to load. Used to construct the expected JSON filename.</param>
    /// <param name="version">The version of the library to load. Used to construct the expected JSON filename.</param>
    /// <param name="validate">Indicates whether to validate the loaded library. The default is <see langword="true"/>.</param>
    /// <param name="enumerationOptions">Options that control how files are enumerated in the directory, including whether to search subdirectories. If
    /// null, the default is to search recursively.</param>
    /// <returns>A <see cref="Library"/> object representing the loaded library definition.</returns>
    /// <exception cref="FileNotFoundException">Thrown if a JSON file matching the specified library name and version cannot be found in the directory or its
    /// subdirectories.</exception>
    public static Library LoadFromJson(
        DirectoryInfo elmDirectory,
        string lib,
        string version,
        bool validate = true,
        EnumerationOptions? enumerationOptions = null)
    {
        enumerationOptions ??= Hl7.Cql.Runtime.Defaults.EnumerationOptionsRecurseSubdirectories;

        var elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{lib}-{version}.json"));
        if (elmFile.Exists)
            return LoadFromJson(elmFile, validate);

        var elmFile2 = new FileInfo(Path.Combine(elmDirectory.FullName, $"{lib}.json"));
        if (elmFile2.Exists)
            return LoadFromJson(elmFile2, validate);

        // Search in subdirectories only if enabled
        if (enumerationOptions.RecurseSubdirectories)
        {
            var files = elmDirectory.EnumerateFiles($"{lib}-{version}.json", enumerationOptions);
            var firstFile = files.FirstOrDefault();
            if (firstFile is not null)
                return LoadFromJson(firstFile, validate);

            var files2 = elmDirectory.EnumerateFiles($"{lib}.json", enumerationOptions);
            var firstFile2 = files2.FirstOrDefault();
            if (firstFile2 is not null)
                return LoadFromJson(firstFile2, validate);
        }

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
