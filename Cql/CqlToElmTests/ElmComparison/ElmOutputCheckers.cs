/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text.Json.Nodes;
using System.Xml;
using System.Xml.Schema;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test.ElmComparison;

/// <summary>
/// Checks ELM this translator emits against checkers that do not depend on how it was produced: the
/// <c>Hl7.Cql.Elm</c> JSON reader must read it back to the same JSON, and the library it reads must be valid
/// against the ELM XML schema (<c>Cql/Elm/Schema</c>).
/// </summary>
/// <remarks>
/// The schema is checked on the library read back from the JSON, not on the translator's own object graph, which
/// holds translator-specific subclasses of the ELM types that the XML serializer does not know. Checking the
/// library as read also makes the chain end to end: what is checked is what a consumer of the JSON gets.
/// </remarks>
internal sealed class ElmOutputCheckers
{
    private static readonly XmlSerializer LibrarySerializer = new(typeof(Library));

    private readonly XmlSchemaSet _schemas;

    /// <summary>
    /// Creates the checkers with the ELM schema in <paramref name="schemaDirectory"/>.
    /// </summary>
    public ElmOutputCheckers(string schemaDirectory)
    {
        // The schemas include and import each other by relative path, which only a resolver can follow.
        _schemas = new XmlSchemaSet { XmlResolver = new XmlUrlResolver() };
        _schemas.Add(null, Path.Combine(schemaDirectory, "types.xsd"));
        _schemas.Add(null, Path.Combine(schemaDirectory, "library.xsd"));
        _schemas.Compile();
    }

    /// <summary>
    /// Runs both checks on the JSON of an emitted library and returns the problems found, none when it passes.
    /// </summary>
    public IReadOnlyList<string> Check(string json)
    {
        Library reread;
        try
        {
            reread = Library.ParseFromJson(json);
        }
        catch (Exception e)
        {
            return [$"reader: {e.GetType().Name}: {e.Message}"];
        }

        var problems = new List<string>();
        var original = JsonNode.Parse(json, documentOptions: ElmNormalizer.DocumentOptions);
        var roundTripped = JsonNode.Parse(reread.SerializeToJson(writeIndented: false), documentOptions: ElmNormalizer.DocumentOptions);
        if (FirstDifference(original, roundTripped, "$") is { } difference)
            problems.Add($"round trip: {difference}");

        try
        {
            problems.AddRange(ValidateAgainstSchema(reread).Select(message => $"schema: {message}"));
        }
        catch (Exception e)
        {
            // The XML serializer cannot write the library, so it cannot be validated: that fails the check too.
            problems.Add($"schema: {e.GetType().Name}: {e.Message}");
        }

        return problems;
    }

    /// <summary>
    /// Serializes the library to ELM XML and returns the schema validation errors and warnings.
    /// </summary>
    public IReadOnlyList<string> ValidateAgainstSchema(Library library)
    {
        using var writer = new StringWriter(CultureInfo.InvariantCulture);
        LibrarySerializer.Serialize(writer, library);
        return ValidateXml(writer.ToString());
    }

    /// <summary>
    /// Validates ELM XML against the schema and returns the errors and warnings.
    /// </summary>
    public IReadOnlyList<string> ValidateXml(string xml)
    {
        var messages = new List<string>();
        var settings = new XmlReaderSettings
        {
            ValidationType = ValidationType.Schema,
            Schemas = _schemas,
            ValidationFlags = XmlSchemaValidationFlags.ReportValidationWarnings,
        };
        settings.ValidationEventHandler += (_, e) => messages.Add($"{e.Severity}: {e.Message}");
        using var reader = XmlReader.Create(new StringReader(xml), settings);
        while (reader.Read())
        {
        }

        return messages;
    }

    /// <summary>
    /// The first place where two JSON trees differ, or <see langword="null"/> when they are the same. An absent value
    /// and an empty collection are the same: the reader materializes empty definition lists the writer leaves out.
    /// </summary>
    public static string? FirstDifference(JsonNode? before, JsonNode? after, string path)
    {
        if (ElmNormalizer.IsEmpty(before) && ElmNormalizer.IsEmpty(after))
            return null;
        switch (before, after)
        {
            case (JsonObject b, JsonObject a):
                foreach (var key in b.Select(p => p.Key).Union(a.Select(p => p.Key)))
                {
                    if (FirstDifference(b[key], a[key], $"{path}.{key}") is { } difference)
                        return difference;
                }

                return null;
            case (JsonArray b, JsonArray a):
                if (b.Count != a.Count)
                    return $"{path}: {b.Count} elements written, {a.Count} read back";
                for (var i = 0; i < b.Count; i++)
                {
                    if (FirstDifference(b[i], a[i], $"{path}[{i}]") is { } difference)
                        return difference;
                }

                return null;
            default:
                return JsonNode.DeepEquals(before, after) ? null : $"{path}: {Text(before)} written, {Text(after)} read back";
        }
    }

    private static string Text(JsonNode? node)
    {
        var text = node?.ToJsonString() ?? "absent";
        return text.Length > 80 ? text[..80] + "…" : text;
    }
}
