#nullable enable
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CoreTests.Tuples;

[TestClass]
public class ValueTupleTests
{
    public static readonly TupleMetadata PersonProperties = new(["Name", "ID", "Addresses"]);
    public static readonly TupleMetadata AddressProperties = new (["AddressType", "Street", "City", "Country"]);

    [TestMethod]
    public void TestJsonSerializationNested()
    {
        (TupleMetadata, string? AddressType, string? Street, string? City, string? Country) homeAddr =
            (AddressProperties, "Home", "Joe Street", "Springfield", "USA");

        (TupleMetadata, string? AddressType, string? Street, string? City, string? Country) workAddr =
            (AddressProperties, "Work", "Sue Street", "Jumpville", "Canada");

        (TupleMetadata, string? Name, int? ID, (TupleMetadata, string? AddressType, string? Street, string? City, string? Country)[]? addressses) person =
            (PersonProperties, "John", 10, [homeAddr, workAddr]);

        var serializedJson = JsonSerializer.Serialize(person, new JsonSerializerOptions {
            Converters = { new ValueTupleJsonConverterFactory() },
            WriteIndented = true });

        Assert.AreEqual(
            """
            {
              "Name": "John",
              "ID": 10,
              "Addresses": [
                {
                  "AddressType": "Home",
                  "Street": "Joe Street",
                  "City": "Springfield",
                  "Country": "USA"
                },
                {
                  "AddressType": "Work",
                  "Street": "Sue Street",
                  "City": "Jumpville",
                  "Country": "Canada"
                }
              ]
            }
            """, serializedJson);
    }
}

public record TupleMetadata(string[] PropertyNames);

public class ValueTupleJsonConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        var canConvert = typeof(ITuple).IsAssignableFrom(typeToConvert)
                         && typeToConvert.IsGenericType
                         && typeToConvert.GenericTypeArguments[0] == typeof(TupleMetadata);
        return canConvert;
    }

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options) =>
        ValueTupleJsonConverter.Default;
}

public class ValueTupleJsonConverter : JsonConverter<ITuple>
{
    public static ValueTupleJsonConverter Default { get; } = new();

    public override ITuple Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, ITuple value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        if (value[0] is TupleMetadata { PropertyNames: { } properties })
        {
            for (int i = 1; i < value.Length; i++)
            {
                writer.WritePropertyName(properties[i - 1]);
                JsonSerializer.Serialize(writer, value[i], options);
            }
        }
        else throw new InvalidOperationException("Invalid tuple format");

        writer.WriteEndObject();
    }
}
