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
        "As", "Convert", "ToList", "SingletonFrom", "ToBoolean", "ToConcept", "ToDate", "ToDateTime", "ToDecimal", "ToInteger",
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
            case (null, JsonObject or JsonArray):
                divergences.Add(new(DivergenceKind.MissingNode, path, $"absent vs {Describe(reference)}"));
                return;
            case (JsonObject or JsonArray, null):
                divergences.Add(new(DivergenceKind.ExtraNode, path, $"{Describe(actual)} vs absent"));
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
        if (!SameKind(actual, reference))
        {
            // A conversion on one side only, around a node of the other side's kind: ToDecimal(x) against x,
            // FHIRHelpers.ToConcept(Common.F(x)) against Common.F(x), or As(As(x)) against As(x). Report it, then
            // compare what it converts with the other side.
            if (IsConversion(actual) && Operand(actual) is { } actualOperand && SameKind(actualOperand, reference))
            {
                divergences.Add(new(DivergenceKind.ConversionPlacement, path, $"{Describe(actual)} vs none"));
                CompareNodes(actualOperand, reference, path, divergences);
                return;
            }

            if (IsConversion(reference) && Operand(reference) is { } referenceOperand && SameKind(actual, referenceOperand))
            {
                divergences.Add(new(DivergenceKind.ConversionPlacement, path, $"none vs {Describe(reference)}"));
                CompareNodes(actual, referenceOperand, path, divergences);
                return;
            }

            // Two different conversions of the same operand: As(x) against ToDecimal(x), ToDecimal(x) against
            // FHIRHelpers.ToDecimal(x), or FHIRHelpers.ToDate(x) against FHIRHelpers.ToDateTime(x). Two conversions of
            // the same node type other than a function call, such as As(x) to different types, are compared by their
            // properties instead, so that the type they convert to is a type difference.
            if (IsConversion(actual) && IsConversion(reference)
                && (actualType != referenceType || actualType == "FunctionRef")
                && Operand(actual) is { } a && Operand(reference) is { } r)
            {
                divergences.Add(new(DivergenceKind.ConversionPlacement, path, $"{Describe(actual)} vs {Describe(reference)}"));
                CompareNodes(a, r, path, divergences);
                return;
            }

            // A conversion on one side only, around another conversion, As(ToDecimal(x)) against x, or around a node of
            // the other side's type that differs from it, ToDecimal(Common.F(x)) against Common.G(x).
            if (actualType != referenceType)
            {
                if (IsConversion(actual) && Operand(actual) is { } convertedActual
                    && (IsConversion(convertedActual) || (NodeType(convertedActual) == referenceType && !IsConversion(reference))))
                {
                    divergences.Add(new(DivergenceKind.ConversionPlacement, path, $"{Describe(actual)} vs none"));
                    CompareNodes(convertedActual, reference, path, divergences);
                    return;
                }

                if (IsConversion(reference) && Operand(reference) is { } convertedReference
                    && (IsConversion(convertedReference) || (NodeType(convertedReference) == actualType && !IsConversion(actual))))
                {
                    divergences.Add(new(DivergenceKind.ConversionPlacement, path, $"none vs {Describe(reference)}"));
                    CompareNodes(actual, convertedReference, path, divergences);
                    return;
                }
            }
        }

        if (actualType != referenceType)
        {
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
                var at = actual[key];
                var rt = reference[key];
                // A result type present on one side only is a difference in what the translators annotate, not in
                // the type. Any other type, such as the one an As converts to, is part of what the node means.
                if (key == "resultTypeSpecifier" && (at is null || rt is null))
                    continue;
                if (!JsonNode.DeepEquals(at, rt))
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
    /// The attributes that name a type by its qualified name and have no type specifier spelling: the type of a
    /// literal, of an instance, of a retrieve and of an included related retrieve.
    /// </summary>
    private static readonly HashSet<string> TypeNameProperties = new(StringComparer.Ordinal)
    {
        "valueType", "classType", "dataType", "relatedDataType",
    };

    /// <summary>
    /// Whether the property holds a type: a result type, the type an operation converts to, tests or declares, or
    /// the type a literal, instance or retrieve has.
    /// </summary>
    private static bool IsTypeProperty(string key) =>
        key.EndsWith("TypeSpecifier", StringComparison.Ordinal) || TypeNameProperties.Contains(key);

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

    /// <summary>
    /// What identifies a conversion: its node type, the function it calls and the type it converts to.
    /// </summary>
    private static string ConversionKey(JsonObject conversion) =>
        $"{NodeType(conversion)}|{(string?)conversion["libraryName"]}|{(string?)conversion["name"]}|"
        + $"{conversion["asTypeSpecifier"]?.ToJsonString()}|{conversion["toTypeSpecifier"]?.ToJsonString()}";

    private static bool SameConversion(JsonObject a, JsonObject b) =>
        IsConversion(a) && IsConversion(b) && ConversionKey(a) == ConversionKey(b);

    /// <summary>
    /// Whether two nodes are the same kind of node: the same conversion, or the same function, or otherwise the
    /// same node type.
    /// </summary>
    private static bool SameKind(JsonObject a, JsonObject b)
    {
        if (NodeType(a) != NodeType(b))
            return false;
        if (IsConversion(a) || IsConversion(b))
            return SameConversion(a, b);
        return NodeType(a) != "FunctionRef"
               || ((string?)a["libraryName"] == (string?)b["libraryName"] && (string?)a["name"] == (string?)b["name"]);
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
            null => "absent",
            JsonValue v when v.TryGetValue<string>(out var qualifiedName) => ShortName(qualifiedName),
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
        if (close < 2 || !qualifiedName.StartsWith('{'))
            return qualifiedName;
        var name = qualifiedName[(close + 1)..];
        if (qualifiedName.StartsWith("{urn:hl7-org:elm-types:r1}", StringComparison.Ordinal))
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
