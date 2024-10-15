/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */
#nullable enable
using Hl7;
using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Runtime.Serialization;

/// <summary>
/// Provides a JSON converter factory for CqlValueTuple types.
/// </summary>
public class CqlValueTupleJsonConverterFactory : JsonConverterFactory
{
    /// <inheritdoc/>
    public override bool CanConvert(Type typeToConvert)
    {
        var canConvert = typeof(ITuple).IsAssignableFrom(typeToConvert)
                         && typeToConvert.IsGenericType
                         && typeToConvert.GenericTypeArguments[0] == typeof(CqlTupleMetadata);
        return canConvert;
    }

    /// <inheritdoc/>
    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options) =>
        CqlValueTupleJsonConverter.Default;
}
