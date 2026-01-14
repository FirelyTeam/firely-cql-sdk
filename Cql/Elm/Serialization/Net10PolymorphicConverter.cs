/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#if NET10_0_OR_GREATER

namespace Hl7.Cql.Elm.Serialization;

/// <summary>
/// Custom converter for polymorphic types that have "type" properties conflicting with
/// the type discriminator in .NET 10. This converter manually handles the polymorphic
/// deserialization by reading the "type" discriminator and instantiating the correct type.
/// </summary>
internal class Net10PolymorphicConverter<T> : JsonConverter<T> where T : class
{
    private readonly Dictionary<string, Type> _typeMapping;

    public Net10PolymorphicConverter(Dictionary<string, Type> typeMapping)
    {
        _typeMapping = typeMapping;
    }

    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException("Expected StartObject token");
        }

        // Read the entire object into a JsonDocument to inspect the "type" property
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;

        // Look for the "type" property to determine the concrete type
        if (root.TryGetProperty("type", out var typeProperty))
        {
            var typeName = typeProperty.GetString();
            if (typeName != null && _typeMapping.TryGetValue(typeName, out var concreteType))
            {
                // Deserialize as the concrete type
                var json = root.GetRawText();
                return (T?)JsonSerializer.Deserialize(json, concreteType, options);
            }
        }

        throw new JsonException($"Could not determine concrete type for {typeof(T).Name}");
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        // Use the default serialization which includes the "type" property
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}

/// <summary>
/// Converter factory for polymorphic types in .NET 10
/// </summary>
internal class Net10PolymorphicConverterFactory : JsonConverterFactory
{
    private static readonly Dictionary<string, Type> _cqlToElmBaseTypes = new()
    {
        { "CqlToElmInfo", typeof(CqlToElmInfo) },
        { "Annotation", typeof(Annotation) },
        { "Locator", typeof(Locator) },
        { "CqlToElmError", typeof(CqlToElmError) }
    };

    private static readonly Dictionary<string, Type> _typeSpecifierTypes = new()
    {
        { "NamedTypeSpecifier", typeof(NamedTypeSpecifier) },
        { "ListTypeSpecifier", typeof(ListTypeSpecifier) },
        { "IntervalTypeSpecifier", typeof(IntervalTypeSpecifier) },
        { "TupleTypeSpecifier", typeof(TupleTypeSpecifier) },
        { "ChoiceTypeSpecifier", typeof(ChoiceTypeSpecifier) },
        { "ParameterTypeSpecifier", typeof(ParameterTypeSpecifier) }
    };

    private static readonly Dictionary<string, Type> _aliasedQuerySourceTypes = new()
    {
        { "AliasedQuerySource", typeof(AliasedQuerySource) },
        { "RelationshipClause", typeof(RelationshipClause) },
        { "With", typeof(With) },
        { "Without", typeof(Without) }
    };

    private static readonly Dictionary<string, Type> _relationshipClauseTypes = new()
    {
        { "With", typeof(With) },
        { "Without", typeof(Without) }
    };

    public override bool CanConvert(Type typeToConvert)
    {
        return typeToConvert == typeof(CqlToElmBase) || 
               typeToConvert == typeof(TypeSpecifier) ||
               typeToConvert == typeof(AliasedQuerySource) ||
               typeToConvert == typeof(RelationshipClause);
    }

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeToConvert == typeof(CqlToElmBase))
        {
            return new Net10PolymorphicConverter<CqlToElmBase>(_cqlToElmBaseTypes);
        }
        else if (typeToConvert == typeof(TypeSpecifier))
        {
            return new Net10PolymorphicConverter<TypeSpecifier>(_typeSpecifierTypes);
        }
        else if (typeToConvert == typeof(AliasedQuerySource))
        {
            return new Net10PolymorphicConverter<AliasedQuerySource>(_aliasedQuerySourceTypes);
        }
        else if (typeToConvert == typeof(RelationshipClause))
        {
            return new Net10PolymorphicConverter<RelationshipClause>(_relationshipClauseTypes);
        }

        return null;
    }
}

#endif
