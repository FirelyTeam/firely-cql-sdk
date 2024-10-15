﻿#nullable enable
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Serialization;

namespace CoreTests.Tuples;

[TestClass]
public class CqlTupleTests
{
    // Generated C# as part of Library
    public static readonly CqlTupleMetadata PersonProperties = new([typeof(string), typeof(int?), typeof((CqlTupleMetadata, string?, string?, string?)[])], ["Name", "ID", "Addresses"]);
    public static readonly CqlTupleMetadata AddressProperties = new ([typeof(string), typeof(string), typeof(string), typeof(string)], ["AddressType", "Street", "City", "Country"]);

    [TestMethod]
    public void TestCqlTupleMetadataEquality()
    {
        CqlTupleMetadata m1 = new CqlTupleMetadata([typeof(int?), typeof(string)], ["id", "name"]);
        CqlTupleMetadata m2 = new CqlTupleMetadata([typeof(int?), typeof(string)], ["id", "name"]);
        CqlTupleMetadata mOther = new CqlTupleMetadata([typeof(string)], ["name"]);

        Assert.AreEqual(m1, m2);
        Assert.IsFalse(m1.Equals(null));
        Assert.IsTrue(m1.Equals(m2));
        Assert.IsTrue(m1.Equals((object)m2));
        Assert.IsTrue(m1 == m2);
        Assert.IsFalse(m1 != m2);

        Assert.AreNotEqual(m1, mOther);
        Assert.IsFalse(m1.Equals(mOther));
        Assert.IsFalse(m1.Equals((object)mOther));
        Assert.IsFalse(m1 == mOther);
        Assert.IsTrue(m1 != mOther);
    }

    [TestMethod]
    public void TestJsonSerializationNested()
    {
        // Generated C# as part of Library
        (CqlTupleMetadata, string? AddressType, string? Street, string? City, string? Country) homeAddr =
            (AddressProperties, "Home", "Joe Street", "Springfield", "USA");

        (CqlTupleMetadata, string? AddressType, string? Street, string? City, string? Country) workAddr =
            (AddressProperties, "Work", "Sue Street", "Jumpville", "Canada");

        (CqlTupleMetadata, string? Name, int? ID, (CqlTupleMetadata, string? AddressType, string? Street, string? City, string? Country)[]? addressses) person =
            (PersonProperties, "John", 10, [homeAddr, workAddr]);

        var serializedJson = JsonSerializer.Serialize(person, new JsonSerializerOptions {
            Converters = { new CqlValueTupleJsonConverterFactory() },
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