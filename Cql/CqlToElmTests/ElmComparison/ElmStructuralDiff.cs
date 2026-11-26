/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text.Json.Nodes;

namespace Hl7.Cql.CqlToElm.Test.ElmComparison;

/// <summary>
/// The kind of a structural difference between the ELM this translator emits and the reference ELM.
/// </summary>
internal enum DivergenceKind
{
    /// <summary>
    /// One side wraps an expression in a conversion (such as <c>As</c>, <c>ToDecimal</c> or a <c>FHIRHelpers</c>
    /// conversion function) where the other has the expression itself, or converts it differently.
    /// </summary>
    ConversionPlacement,

    /// <summary>The reference has a node or definition that this translator does not emit.</summary>
    MissingNode,

    /// <summary>This translator emits a node or definition that the reference does not have.</summary>
    ExtraNode,

    /// <summary>The two sides have a different kind of node in the same place.</summary>
    ReplacedNode,

    /// <summary>The two sides have the same node, typed differently.</summary>
    TypeDifference,

    /// <summary>The two sides have the same node with a different attribute value.</summary>
    ValueDifference,
}

/// <summary>
/// One structural difference.
/// </summary>
/// <param name="Kind">The kind of difference.</param>
/// <param name="Path">Where it is: the definition, then the properties leading to the node.</param>
/// <param name="Detail">What differs, this translator's side first.</param>
internal sealed record Divergence(DivergenceKind Kind, string Path, string Detail)
{
    /// <inheritdoc />
    public override string ToString() => $"{Kind}: {Path}: {Detail}";
}

/// <summary>
/// Compares two normalized ELM libraries (see <see cref="ElmNormalizer"/>) and lists where their structure differs.
/// Definitions are matched by <see cref="ElmNormalizer.DefinitionKey"/>, all other arrays by position.
/// A node of a different kind is reported once and not descended into, so one difference does not cascade into
/// its subtree. A conversion that only one side has is reported once, and the comparison continues with its operand.
/// </summary>
internal static class ElmStructuralDiff
{
    private static readonly HashSet<string> ConversionNodes = new(StringComparer.Ordinal)
    {
        "As", "ToList", "SingletonFrom", "ToBoolean", "ToConcept", "ToDate", "ToDateTime", "ToDecimal", "ToInteger",
        "ToLong", "ToQuantity", "ToRatio", "ToString", "ToTime", "ToInterval",
    };

    /// <summary>
    /// Lists the differences between the normalized <paramref name="actual"/> library, emitted by this translator,
    /// and the normalized <paramref name="reference"/> library.
    /// </summary>
    public static IReadOnlyList<Divergence> Compare(JsonObject actual, JsonObject reference)
    {
        var divergences = new List<Divergence>();
        foreach (var key in Keys(actual, reference))
        {
            if (ElmNormalizer.DefinitionSections.Contains(key))
                CompareDefinitions(key, actual[key]?["def"] as JsonArray, reference[key]?["def"] as JsonArray, divergences);
            else
                CompareNodes(actual[key], reference[key], key, divergences);
        }

        return divergences;
    }

    private static void CompareDefinitions(string section, JsonArray? actual, JsonArray? reference, List<Divergence> divergences)
    {
        var actualByKey = ByKey(section, actual);
        var referenceByKey = ByKey(section, reference);
        foreach (var key in actualByKey.Keys.Union(referenceByKey.Keys).OrderBy(k => k, StringComparer.Ordinal))
        {
            var path = $"{section}[{key}]";
            switch (actualByKey.GetValueOrDefault(key), referenceByKey.GetValueOrDefault(key))
            {
                case (null, { } missing):
                    divergences.Add(new(DivergenceKind.MissingNode, path, $"absent vs {Describe(missing)}"));
                    break;
                case ({ } extra, null):
                    divergences.Add(new(DivergenceKind.ExtraNode, path, $"{Describe(extra)} vs absent"));
                    break;
                case ({ } a, { } r):
                    CompareNodes(a, r, path, divergences);
                    break;
            }
        }
    }

    private static Dictionary<string, JsonNode> ByKey(string section, JsonArray? definitions)
    {
        var byKey = new Dictionary<string, JsonNode>(StringComparer.Ordinal);
        foreach (var definition in definitions ?? [])
        {
            if (definition is null)
                continue;
            var key = ElmNormalizer.DefinitionKey(section, definition);
            // Two definitions with the same key are an error in their library; keep both apart rather than drop one.
            var unique = key;
            for (var i = 2; byKey.ContainsKey(unique); i++)
                unique = $"{key}#{i}";
            byKey.Add(unique, definition);
        }

        return byKey;
    }

    private static void CompareNodes(JsonNode? actual, JsonNode? reference, string path, List<Divergence> divergences)
    {
        switch (actual, reference)
        {
            case (null, null):
                return;
            case (null, JsonObject r):
                divergences.Add(new(DivergenceKind.MissingNode, path, $"absent vs {Describe(r)}"));
                return;
            case (JsonObject a, null):
                divergences.Add(new(DivergenceKind.ExtraNode, path, $"{Describe(a)} vs absent"));
                return;
            case (JsonObject a, JsonObject r):
                CompareObjects(a, r, path, divergences);
                return;
            case (JsonArray a, JsonArray r):
                CompareArrays(a, r, path, divergences);
                return;
            default:
                if (!JsonNode.DeepEquals(actual, reference))
                    divergences.Add(new(DivergenceKind.ValueDifference, path, $"{Value(actual)} vs {Value(reference)}"));
                return;
        }
    }

    private static void CompareObjects(JsonObject actual, JsonObject reference, string path, List<Divergence> divergences)
    {
        var actualType = NodeType(actual);
        var referenceType = NodeType(reference);
        if (actualType != referenceType)
        {
            // A conversion on one side only: report it, then compare what it converts with the other side.
            if (IsConversion(actual) && Operand(actual) is { } actualOperand && (NodeType(actualOperand) == referenceType || IsConversion(actualOperand)))
            {
                divergences.Add(new(DivergenceKind.ConversionPlacement, path, $"{Describe(actual)} vs none"));
                CompareNodes(actualOperand, reference, path, divergences);
                return;
            }

            if (IsConversion(reference) && Operand(reference) is { } referenceOperand && (NodeType(referenceOperand) == actualType || IsConversion(referenceOperand)))
            {
                divergences.Add(new(DivergenceKind.ConversionPlacement, path, $"none vs {Describe(reference)}"));
                CompareNodes(actual, referenceOperand, path, divergences);
                return;
            }

            // Two different conversions of the same operand.
            if (IsConversion(actual) && IsConversion(reference) && Operand(actual) is { } a && Operand(reference) is { } r)
            {
                divergences.Add(new(DivergenceKind.ConversionPlacement, path, $"{Describe(actual)} vs {Describe(reference)}"));
                CompareNodes(a, r, path, divergences);
                return;
            }

            divergences.Add(new(DivergenceKind.ReplacedNode, path, $"{Describe(actual)} vs {Describe(reference)}"));
            return;
        }

        foreach (var key in Keys(actual, reference))
        {
            if (key == "type")
                continue;
            var childPath = $"{path}.{key}";
            if (IsTypeProperty(key))
            {
                // Present on one side only is a difference in what the translators annotate, not in the type.
                if (actual[key] is { } at && reference[key] is { } rt && !JsonNode.DeepEquals(at, rt))
                    divergences.Add(new(DivergenceKind.TypeDifference, childPath, $"{TypeText(at)} vs {TypeText(rt)}"));
                continue;
            }

            CompareNodes(actual[key], reference[key], childPath, divergences);
        }
    }

    private static void CompareArrays(JsonArray actual, JsonArray reference, string path, List<Divergence> divergences)
    {
        var common = Math.Min(actual.Count, reference.Count);
        for (var i = 0; i < common; i++)
            CompareNodes(actual[i], reference[i], $"{path}[{i}]", divergences);
        for (var i = common; i < actual.Count; i++)
            divergences.Add(new(DivergenceKind.ExtraNode, $"{path}[{i}]", $"{Describe(actual[i])} vs absent"));
        for (var i = common; i < reference.Count; i++)
            divergences.Add(new(DivergenceKind.MissingNode, $"{path}[{i}]", $"absent vs {Describe(reference[i])}"));
    }

    /// <summary>
    /// Whether the property holds a type: a result type or the type an operation converts to or declares.
    /// </summary>
    private static bool IsTypeProperty(string key) =>
        key.EndsWith("TypeSpecifier", StringComparison.Ordinal);

    private static bool IsConversion(JsonObject node)
    {
        var type = NodeType(node);
        if (type is not null && ConversionNodes.Contains(type))
            return true;
        // Model conversions are calls to FHIRHelpers functions such as ToString, ToDateTime and ToInterval.
        return type == "FunctionRef"
               && (string?)node["libraryName"] == "FHIRHelpers"
               && ((string?)node["name"])?.StartsWith("To", StringComparison.Ordinal) == true
               && node["operand"] is JsonArray { Count: 1 };
    }

    private static JsonObject? Operand(JsonObject conversion) =>
        conversion["operand"] switch
        {
            JsonObject o                => o,
            JsonArray { Count: 1 } list => list[0] as JsonObject,
            _                           => null,
        };

    private static string? NodeType(JsonObject node) => (string?)node["type"];

    private static IEnumerable<string> Keys(JsonObject actual, JsonObject reference) =>
        actual.Select(p => p.Key).Union(reference.Select(p => p.Key)).OrderBy(k => k, StringComparer.Ordinal);

    private static string Describe(JsonNode? node) =>
        node switch
        {
            JsonObject o when NodeType(o) is { } type && (string?)o["name"] is { } name => $"{type} {name}",
            JsonObject o when NodeType(o) is { } type                                   => type,
            JsonObject                                                                  => "object",
            JsonArray a                                                                 => $"array of {a.Count}",
            _                                                                           => Value(node),
        };

    private static string TypeText(JsonNode? node) =>
        node switch
        {
            null => "?",
            JsonObject o when NodeType(o) == "NamedTypeSpecifier" => ShortName((string?)o["name"]),
            JsonObject o when NodeType(o) == "ListTypeSpecifier"  => $"List<{TypeText(o["elementType"])}>",
            JsonObject o when NodeType(o) == "IntervalTypeSpecifier" => $"Interval<{TypeText(o["pointType"])}>",
            JsonObject o when NodeType(o) == "ChoiceTypeSpecifier" =>
                $"Choice<{string.Join(", ", (o["choice"] as JsonArray ?? []).Select(TypeText))}>",
            JsonObject o when NodeType(o) == "TupleTypeSpecifier" =>
                $"Tuple{{{string.Join(", ", (o["element"] as JsonArray ?? []).Select(e => $"{(string?)e?["name"]} {TypeText(e?["elementType"])}"))}}}",
            _ => node.ToJsonString(),
        };

    /// <summary>
    /// A qualified type name as <c>Integer</c> for a System type, and as the last segment of its model namespace
    /// and its name otherwise (<c>fhir.Encounter</c>, <c>qicore.Encounter</c>), so types of the same name in different
    /// models stay apart.
    /// </summary>
    private static string ShortName(string? qualifiedName)
    {
        if (qualifiedName is null)
            return "?";
        var close = qualifiedName.LastIndexOf('}');
        var name = qualifiedName[(close + 1)..];
        if (close < 0 || qualifiedName.StartsWith("{urn:hl7-org:elm-types:r1}", StringComparison.Ordinal))
            return name;
        var model = qualifiedName[1..close].TrimEnd('/');
        return $"{model[(model.LastIndexOfAny(['/', ':']) + 1)..]}.{name}";
    }

    private static string Value(JsonNode? node)
    {
        var text = node?.ToJsonString() ?? "absent";
        return text.Length > 80 ? text[..80] + "…" : text;
    }
}
