/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */
#nullable enable
using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Runtime.Serialization;

/// <summary>
/// Provides JSON serialization and deserialization for ITuple instances.
/// </summary>
public class CqlValueTupleJsonConverter : JsonConverter<ITuple>
{
    /// <summary>
    /// Gets the default instance of the CqlValueTupleJsonConverter.
    /// </summary>
    public static CqlValueTupleJsonConverter Default { get; } = new();

    /// <inheritdoc/>
    public override ITuple Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotSupportedException("Deserialization not supported");
    }

    /// <inheritdoc/>
    public override void Write(Utf8JsonWriter writer, ITuple value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        if (value[0] is CqlTupleMetadata { ItemNames: { } names })
        {
            for (int i = 1; i < value.Length; i++)
            {
                writer.WritePropertyName(names[i - 1]);
                JsonSerializer.Serialize(writer, value[i], options);
            }
        }
        else throw new InvalidOperationException("Invalid tuple format");

        writer.WriteEndObject();
    }
}
