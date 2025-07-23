/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Serialization;

internal class TopLevelDefinitionConverterFactory : JsonConverterFactory
{
    public TopLevelDefinitionConverterFactory(bool allowOldStyleTypeDiscriminators = false)
    {
        AllowOldStyleTypeDiscriminators = allowOldStyleTypeDiscriminators;
    }

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
        var element = typeToConvert.GetElementType() ??
                      throw new InvalidOperationException("This converter only handles array types.");

        var type = typeof(PolymorphicArrayJsonConverter<>).MakeGenericType(element);
        var instance = (JsonConverter)Activator.CreateInstance(type, args: AllowOldStyleTypeDiscriminators)!;
        return instance;
    }

    public bool AllowOldStyleTypeDiscriminators { get; }
}