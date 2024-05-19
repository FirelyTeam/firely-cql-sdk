using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Elm.Serialization;

internal class TopLevelDefinitionConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        return typeToConvert == typeof(UsingDef[]) ||
               typeToConvert == typeof(IncludeDef[]) ||
               typeToConvert == typeof(ParameterDef[]) ||
               typeToConvert == typeof(CodeSystemDef[]) ||
               typeToConvert == typeof(ValueSetDef[]) ||
               typeToConvert == typeof(CodeDef[]) ||
               typeToConvert == typeof(ConceptDef[]) ||
               typeToConvert == typeof(ContextDef[]) ||
               typeToConvert == typeof(ExpressionDef[]);
    }

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (!typeToConvert.IsArray)
            throw new InvalidOperationException("This converter only handles specific array types.");

        var element = typeToConvert.GetElementType()!;
        var type = typeof(DefArrayConverter<>).MakeGenericType(element);
        var instance = (JsonConverter)Activator.CreateInstance(type)!;
        return instance;
    }
}