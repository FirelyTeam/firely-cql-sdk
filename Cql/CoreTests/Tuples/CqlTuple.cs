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
    public void TestJson()
    {
        CqlTuple<(string? Name, DateTime? DOB)> tupleA1 = new(TupleOnLibraryAProperties, ("Paul", new DateTime(2000, 12, 31)));
        var serialize = JsonSerializer.Serialize(tupleA1);
    }
}


//[JsonConverter(typeof(CqlTupleJsonConverter))]
public readonly struct CqlTuple<TTuple> : IEquatable<CqlTuple<TTuple>>, IJsonSerializable where TTuple : ITuple
{
    private string[] Properties { get; }
    public TTuple Value { get; }

    public CqlTuple(string[] properties, TTuple value)
    {
        Properties = properties;
        Value = value;
    }

    public override bool Equals(object? obj)
    {
        return obj is CqlTuple<TTuple> tuple &&
               Equals(tuple);
    }

    public bool Equals(CqlTuple<TTuple> other)
    {
        return Properties.SequenceEqual(other.Properties) && EqualityComparer<TTuple>.Default.Equals(Value, other.Value);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Properties, Value);
    }

    public void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        for (int i = 0; i < Properties.Length; i++)
        {
            writer.WritePropertyName(Properties[i]);
            JsonSerializer.Serialize(writer, Value[i], options);
        }

        writer.WriteEndObject();
    }

    // public void Deserialize(JsonElement element, JsonSerializerOptions options)
    // {
    //     if (element.ValueKind != JsonValueKind.Object)
    //     {
    //         throw new JsonException("Invalid JSON format");
    //     }
    //
    //     var jsonObject = element.GetObject();
    //
    //     foreach (var property in jsonObject.Properties)
    //     {
    //         var propertyName = property.Name;
    //         var propertyValue = property.Value;
    //
    //         var index = Array.IndexOf(Properties, propertyName);
    //         if (index >= 0)
    //         {
    //             Value[index] = JsonSerializer.Deserialize(propertyValue.GetRawText(), typeof(TTuple).GetGenericArguments()[index], options);
    //         }
    //     }
    // }
}



public interface IJsonSerializable
{
    void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options);
    // void Deserialize(JsonElement element, JsonSerializerOptions options);
}
