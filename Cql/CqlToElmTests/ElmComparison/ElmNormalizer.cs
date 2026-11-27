/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text.Json;
using System.Text.Json.Nodes;

namespace Hl7.Cql.CqlToElm.Test.ElmComparison;

/// <summary>
/// Rewrites ELM JSON into a canonical form, so that two translations of the same library differ only where their
/// structure differs, not where they spell the same structure differently. Every rule removes a difference in
/// spelling, never one in meaning:
/// <list type="bullet">
/// <item>Source positions, identifiers and annotations (<c>locator</c>, <c>localId</c>, <c>annotation</c>) and the
/// <c>signature</c> a translator records when asked to are dropped.</item>
/// <item>A type named as a qualified name (<c>resultTypeName</c>, <c>asType</c>, <c>isType</c>, <c>operandType</c>,
/// <c>parameterType</c>) becomes the equivalent <c>NamedTypeSpecifier</c> (<c>resultTypeSpecifier</c>, …).</item>
/// <item>An absent collection, an empty one and an empty <c>def</c> list are the same; an attribute that holds its
/// schema default is the same as an absent one. The defaults are those of the ELM schema: <c>accessLevel</c>
/// <c>Public</c>, <c>strict</c> <c>false</c>, an include's <c>mediaType</c> <c>application/elm+xml</c>, an
/// interval's <c>lowClosed</c> and <c>highClosed</c> <c>true</c>, a return clause's <c>distinct</c> <c>true</c> and
/// an aggregate clause's <c>distinct</c> <c>false</c>.</item>
/// <item>A type specifier carries no result type of its own: it is its own type.</item>
/// <item>The types of a choice type and the elements of a tuple type are sets, and are sorted.</item>
/// <item>A <c>Property</c> on an alias, written with <c>scope</c>, is the same as one with an <c>AliasRef</c> source.</item>
/// <item>An expression definition without a <c>type</c> is an <c>ExpressionDef</c>.</item>
/// <item>The definitions of a library (usings, includes, parameters, code systems, value sets, codes, concepts,
/// contexts and statements) are unordered and are sorted by <see cref="DefinitionKey"/>. Every other array keeps
/// its order, since the order of operands is meaningful.</item>
/// </list>
/// </summary>
internal static class ElmNormalizer
{
    /// <summary>
    /// The JSON reader options for ELM, whose expression trees are deeper than the default maximum depth of 64.
    /// </summary>
    public static JsonDocumentOptions DocumentOptions { get; } = new() { MaxDepth = 4096 };

    /// <summary>
    /// The properties that hold the definitions of a library, each a <c>{ "def": [...] }</c> object.
    /// </summary>
    public static IReadOnlyList<string> DefinitionSections { get; } =
        ["usings", "includes", "parameters", "codeSystems", "valueSets", "codes", "concepts", "contexts", "statements"];

    private static readonly HashSet<string> DroppedProperties = new(StringComparer.Ordinal)
    {
        "locator", "localId", "annotation", "signature",
    };

    private static readonly Dictionary<string, string> QualifiedNameToSpecifier = new(StringComparer.Ordinal)
    {
        ["resultTypeName"] = "resultTypeSpecifier",
        ["asType"] = "asTypeSpecifier",
        ["isType"] = "isTypeSpecifier",
        ["operandType"] = "operandTypeSpecifier",
        ["parameterType"] = "parameterTypeSpecifier",
    };

    /// <summary>
    /// The schema defaults of attributes whose default is the same wherever they occur.
    /// </summary>
    private static readonly Dictionary<string, JsonNode> SchemaDefaults = new(StringComparer.Ordinal)
    {
        ["accessLevel"] = JsonValue.Create("Public"),
        ["strict"] = JsonValue.Create(false),
        ["mediaType"] = JsonValue.Create("application/elm+xml"),
    };

    /// <summary>
    /// The schema default of <c>distinct</c> on the clause a query holds under this key: it differs per clause.
    /// </summary>
    private static readonly Dictionary<string, bool> ClauseDistinctDefaults = new(StringComparer.Ordinal)
    {
        ["return"] = true,
        ["aggregate"] = false,
    };

    /// <summary>
    /// Parses ELM JSON and returns its normalized <c>library</c> object.
    /// </summary>
    public static JsonObject NormalizeLibraryJson(string json)
    {
        var document = JsonNode.Parse(json, documentOptions: DocumentOptions)
                       ?? throw new InvalidOperationException("The ELM JSON is null.");
        var library = document["library"] as JsonObject
                      ?? throw new InvalidOperationException("The ELM JSON has no 'library' object.");
        return NormalizeLibrary(library);
    }

    /// <summary>
    /// Returns a normalized copy of an ELM <c>library</c> object.
    /// </summary>
    public static JsonObject NormalizeLibrary(JsonObject library)
    {
        var normalized = (JsonObject)Normalize(library)!;
        foreach (var section in DefinitionSections)
        {
            if (normalized[section] is not JsonObject { } container || container["def"] is not JsonArray definitions)
                continue;
            if (section == "statements")
            {
                foreach (var definition in definitions.OfType<JsonObject>())
                {
                    if (definition["type"] is null)
                        definition.Insert(0, "type", "ExpressionDef");
                }
            }

            var sorted = definitions.Select(d => d!.DeepClone()).OrderBy(d => DefinitionKey(section, d), StringComparer.Ordinal).ToArray();
            container["def"] = new JsonArray(sorted);
        }

        return normalized;
    }

    /// <summary>
    /// The key that identifies a definition within its section: its local identifier for usings and includes, its
    /// name otherwise, and for a function its name and operand types, since functions overload.
    /// </summary>
    public static string DefinitionKey(string section, JsonNode? definition)
    {
        if (definition is not JsonObject d)
            return "";
        if (section is "usings" or "includes")
            return (string?)d["localIdentifier"] ?? "";
        var name = (string?)d["name"] ?? "";
        if ((string?)d["type"] != "FunctionDef")
            return name;
        var operandTypes = d["operand"] is JsonArray operands
                               ? operands.Select(o => o?["operandTypeSpecifier"]?.ToJsonString() ?? "?")
                               : [];
        return $"{name}({string.Join(", ", operandTypes)})";
    }

    private static JsonNode? Normalize(JsonNode? node) =>
        node switch
        {
            JsonObject o => NormalizeObject(o),
            JsonArray a  => new JsonArray(a.Select(Normalize).ToArray()),
            null         => null,
            _            => node.DeepClone(),
        };

    private static JsonObject NormalizeObject(JsonObject source)
    {
        var result = new JsonObject();
        foreach (var (key, value) in source.OrderBy(p => p.Key, StringComparer.Ordinal))
        {
            if (DroppedProperties.Contains(key) || IsEmpty(value))
                continue;
            if (SchemaDefaults.TryGetValue(key, out var schemaDefault) && JsonNode.DeepEquals(value, schemaDefault))
                continue;
            if (QualifiedNameToSpecifier.TryGetValue(key, out var specifierKey))
            {
                // The specifier is the richer spelling; when both are present the qualified name adds nothing.
                if (source[specifierKey] is null && value is JsonValue name && name.TryGetValue<string>(out var qualifiedName))
                    result[specifierKey] = NamedTypeSpecifier(qualifiedName);
                continue;
            }

            var normalized = Normalize(value);
            if (normalized is JsonObject clause && ClauseDistinctDefaults.TryGetValue(key, out var distinctDefault))
                RemoveIfDefault(clause, "distinct", distinctDefault);
            if (normalized is not null && !IsEmpty(normalized))
                result[key] = normalized;
        }

        if ((string?)result["type"] == "Interval")
        {
            RemoveIfDefault(result, "lowClosed", true);
            RemoveIfDefault(result, "highClosed", true);
        }

        // A type specifier is its own type; a result type on it repeats what it already says.
        if (((string?)result["type"])?.EndsWith("TypeSpecifier", StringComparison.Ordinal) == true)
            result.Remove("resultTypeSpecifier");

        // The types of a choice and the elements of a tuple type are sets: their order carries no meaning.
        if ((string?)result["type"] == "ChoiceTypeSpecifier" && result["choice"] is JsonArray choices)
            result["choice"] = Sorted(choices, choice => choice?.ToJsonString() ?? "");
        if ((string?)result["type"] == "TupleTypeSpecifier" && result["element"] is JsonArray elements)
            result["element"] = Sorted(elements, element => (string?)element?["name"] ?? "");

        if ((string?)result["type"] == "Property" && result["source"] is null && (string?)result["scope"] is { } scope)
        {
            result.Remove("scope");
            result["source"] = new JsonObject { ["name"] = scope, ["type"] = "AliasRef" };
        }

        return result;
    }

    private static void RemoveIfDefault(JsonObject node, string key, bool schemaDefault)
    {
        if (node[key] is JsonValue value && value.TryGetValue<bool>(out var flag) && flag == schemaDefault)
            node.Remove(key);
    }

    private static JsonArray Sorted(JsonArray array, Func<JsonNode?, string> key) =>
        new(array.Select(item => item?.DeepClone()).OrderBy(key, StringComparer.Ordinal).ToArray());

    private static JsonObject NamedTypeSpecifier(string qualifiedName) =>
        new() { ["name"] = qualifiedName, ["type"] = "NamedTypeSpecifier" };

    /// <summary>
    /// Whether a value carries nothing: null, an empty array or object, or an object whose only member is an empty
    /// <c>def</c> list.
    /// </summary>
    public static bool IsEmpty(JsonNode? node) =>
        node switch
        {
            null                   => true,
            JsonArray { Count: 0 } => true,
            JsonObject o           => o.Count == 0 || (o.Count == 1 && o.ContainsKey("def") && IsEmpty(o["def"])),
            _                      => false,
        };
}
