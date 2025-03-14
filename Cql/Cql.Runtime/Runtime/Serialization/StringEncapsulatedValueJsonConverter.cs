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