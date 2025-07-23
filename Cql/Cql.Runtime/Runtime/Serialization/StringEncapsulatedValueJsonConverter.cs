/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime.Serialization;

internal class StringEncapsulatedValueJsonConverter<TStringValue> : JsonConverter<TStringValue>
    where TStringValue : IParsable<TStringValue>
{
    public override TStringValue Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.String)
        {
            throw new JsonException();
        }

        string value = reader.GetString()!;
        return TStringValue.Parse(value, null);
    }

    public override void Write(
        Utf8JsonWriter writer,
        TStringValue value,
        JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}
