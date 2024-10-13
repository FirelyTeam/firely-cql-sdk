#nullable enable
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Hl7.Cql.Elm.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CoreTests.Tuples;

[TestClass]
public class CqlTupleTest
{
    public static readonly string[] TupleOnLibraryAProperties = ["Name", "DOB"];
    public static readonly string[] TupleOnLibraryBProperties = ["Name", "DOB"];

    [TestMethod]
    public void TestEquality()
    {
        CqlTuple<(string? Name, DateTime? DOB)> tupleA1 = new(TupleOnLibraryAProperties, ("Paul", new DateTime(2000, 12, 31)));
        CqlTuple<(string? Name, DateTime? DOB)> tupleA2 = new(TupleOnLibraryBProperties, ("Paul", new DateTime(2000, 12, 31)));
        Assert.AreEqual(tupleA1, tupleA2);
    }

    [TestMethod]
    public void TestJsonSerialization()
    {
        CqlTuple<(string? Name, DateTime? DOB)> tupleA1 = new(TupleOnLibraryAProperties, ("Paul", new DateTime(2000, 12, 31)));
        var serializedJson = JsonSerializer.Serialize(tupleA1);
        Assert.AreEqual("{\"Name\":\"Paul\",\"DOB\":\"2000-12-31T00:00:00\"}", serializedJson);
    }
}

public class CqlTupleJsonConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        return typeToConvert.IsGenericType
               && typeToConvert.GetGenericTypeDefinition() == typeof(CqlTuple<>);
    }

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var tupleType = typeToConvert.GetGenericArguments()[0] ??
                      throw new InvalidOperationException("This converter only handles array types.");

        var type = typeof(CqlTupleJsonConverter<>).MakeGenericType(tupleType);
        var instance = (JsonConverter)Activator.CreateInstance(type)!;
        return instance;
    }
}

public class CqlTupleJsonConverter<TTuple> : JsonConverter<CqlTuple<TTuple>> where TTuple : struct, ITuple
{
    public override CqlTuple<TTuple> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, CqlTuple<TTuple> value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        INamedPropertiesTuple namedPropertiesTuple = value;
        for (int i = 0; i < namedPropertiesTuple.Properties.Length; i++)
        {
            writer.WritePropertyName(namedPropertiesTuple.Properties[i]);
            JsonSerializer.Serialize(writer, namedPropertiesTuple[i], options);
        }

        writer.WriteEndObject();
    }
}

public interface INamedPropertiesTuple : ITuple
{
    string[] Properties { get; }
}

[JsonConverter(typeof(CqlTupleJsonConverterFactory))]
public readonly struct CqlTuple<TTuple>(
    string[] properties,
    TTuple value) : IEquatable<CqlTuple<TTuple>>, INamedPropertiesTuple
    where TTuple : struct, ITuple
{
    private string[] Properties { get; } = properties;

    public TTuple Value { get; } = value;

    public override bool Equals(object? obj) => obj is CqlTuple<TTuple> tuple && Equals(tuple);

    public bool Equals(CqlTuple<TTuple> other) => Properties.SequenceEqual(other.Properties) && EqualityComparer<TTuple>.Default.Equals(Value, other.Value);

    public override int GetHashCode() => HashCode.Combine(Properties, Value);

    object? ITuple.this[int index] => Value[index];

    int ITuple.Length => Value.Length;

    string[] INamedPropertiesTuple.Properties => Properties;
}