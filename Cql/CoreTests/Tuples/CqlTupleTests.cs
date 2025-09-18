/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.Fhir.Serialization.Extensions;
using Hl7.Cql.Primitives;

namespace CoreTests.Tuples;

[TestClass]
public class CqlTupleTests
{
    private static readonly CqlTupleMetadata SimpleTupleMetadata = new([typeof(string), typeof(int)], ["Name", "Age"]);
    private static readonly CqlTupleMetadata NestedTupleMetadata = new([typeof(string), typeof((CqlTupleMetadata, string, int))], ["Group", "Person"]);
    private static readonly CqlTupleMetadata ArrayTupleMetadata = new([typeof(string[]), typeof(int[])], ["Names", "Ages"]);
    
    // Large tuple metadata for testing tuples with more than 8 items
    private static readonly CqlTupleMetadata LargeTuple9Metadata = new([
        typeof(string), typeof(int), typeof(bool), typeof(double), typeof(char),
        typeof(byte), typeof(short), typeof(long), typeof(decimal)
    ], ["Item1", "Item2", "Item3", "Item4", "Item5", "Item6", "Item7", "Item8", "Item9"]);
    
    private static readonly CqlTupleMetadata LargeTuple10Metadata = new([
        typeof(string), typeof(int), typeof(bool), typeof(double), typeof(char),
        typeof(byte), typeof(short), typeof(long), typeof(decimal), typeof(float)
    ], ["Item1", "Item2", "Item3", "Item4", "Item5", "Item6", "Item7", "Item8", "Item9", "Item10"]);
    
    private static readonly CqlTupleMetadata LargeTuple15Metadata = new([
        typeof(string), typeof(int), typeof(bool), typeof(double), typeof(char),
        typeof(byte), typeof(short), typeof(long), typeof(decimal), typeof(float),
        typeof(uint), typeof(ulong), typeof(ushort), typeof(sbyte), typeof(DateTime)
    ], ["Item1", "Item2", "Item3", "Item4", "Item5", "Item6", "Item7", "Item8", "Item9", "Item10", 
        "Item11", "Item12", "Item13", "Item14", "Item15"]);

    private static JsonSerializerOptions JsonSerializerOptions =>
        FhirDeserializationExtensions.JsonSerializerOptions
                                     .Mutate(o =>
                                     {
                                         o.WriteIndented = true;
                                         return o;
                                     });


    [TestMethod]
    public void Tuple_CanBeCreatedAndAccessed()
    {
        // Arrange
        (CqlTupleMetadata, string Name, int Age) tuple = (SimpleTupleMetadata, "Alice", 30);

        // Act & Assert
        Assert.AreEqual("Alice", tuple.Name);
        Assert.AreEqual(30, tuple.Age);
        Assert.AreEqual(SimpleTupleMetadata, tuple.Item1);
    }

    [TestMethod]
    public void Tuple_NestedTuple_CanBeCreatedAndAccessed()
    {
        // Arrange
        (CqlTupleMetadata, string Name, int Age) person = (SimpleTupleMetadata, "Bob", 25);
        (CqlTupleMetadata, string Group, (CqlTupleMetadata, string Name, int Age) Person) group = (NestedTupleMetadata, "Developers", person);

        // Act & Assert
        Assert.AreEqual("Developers", group.Group);
        Assert.AreEqual("Bob", group.Person.Name);
        Assert.AreEqual(25, group.Person.Age);
        Assert.AreEqual(NestedTupleMetadata, group.Item1);
    }

    [TestMethod]
    public void Tuple_ArrayTuple_CanBeCreatedAndAccessed()
    {
        // Arrange
        (CqlTupleMetadata, string[] Names, int[] Ages) tuple = (ArrayTupleMetadata, ["Tom", "Jerry"], [5, 6]);

        // Act & Assert
        Assert.AreEqual(2, tuple.Names.Length);
        Assert.AreEqual("Tom", tuple.Names[0]);
        Assert.AreEqual(6, tuple.Ages[1]);
        Assert.AreEqual(ArrayTupleMetadata, tuple.Item1);
    }

    [TestMethod]
    public void Tuple_WithSimpleTuple_SerializesToJson()
    {
        // Arrange
        (CqlTupleMetadata, string Name, int Age) tuple = (SimpleTupleMetadata, "Charlie", 40);

        // Act
        var json = JsonSerializer.Serialize(tuple, JsonSerializerOptions);

        // Assert
        Assert.That.MultilinesAreEqual(
            """
            {
              "Name": "Charlie",
              "Age": 40
            }
            """,
            json);
    }

    [TestMethod]
    public void Tuple_WithNestedTuple_SerializesToJson()
    {
        // Arrange
        (CqlTupleMetadata, string Name, int Age) person = (SimpleTupleMetadata, "Dana", 22);
        (CqlTupleMetadata, string Group, (CqlTupleMetadata, string Name, int Age) Person) group =
            (NestedTupleMetadata, "QA", person);

        // Act
        var json = JsonSerializer.Serialize(group, JsonSerializerOptions);

        // Assert
        Assert.That.MultilinesAreEqual(
            """
            {
              "Group": "QA",
              "Person": {
                "Name": "Dana",
                "Age": 22
              }
            }
            """,
            json);
    }

    [TestMethod]
    public void Tuple_WithArrayTuple_SerializesToJson()
    {
        // Arrange
        (CqlTupleMetadata, string[] Names, int[] Ages) tuple = (ArrayTupleMetadata, ["Tom", "Jerry"], [5, 6]);

        // Act
        var json = JsonSerializer.Serialize(tuple, JsonSerializerOptions);

        // Assert
        Assert.That.MultilinesAreEqual(
            """
            {
              "Names": [
                "Tom",
                "Jerry"
              ],
              "Ages": [
                5,
                6
              ]
            }
            """,
            json);
    }

    [TestMethod]
    public void Tuple_DeserializesFromJson_ThrowNotSupported()
    {
        // Arrange
        var json = "{\"Name\":\"Frank\",\"Age\":33}";

        // Act
        Action act = () =>
        {
            var tuple = JsonSerializer.Deserialize<(CqlTupleMetadata, string Name, int Age)>(json, JsonSerializerOptions);
        };

        // Assert
        Assert.Throws<NotSupportedException>(act);
    }

    [TestMethod]
    public void Tuple_With9Items_CanBeCreatedAndAccessed()
    {
        // Arrange
        (CqlTupleMetadata, string, int, bool, double, char, byte, short, long, decimal) tuple = 
            (LargeTuple9Metadata, "test", 42, true, 3.14, 'X', 255, 1000, 123456789L, 99.99m);

        // Act & Assert
        Assert.AreEqual(LargeTuple9Metadata, tuple.Item1);
        Assert.AreEqual("test", tuple.Item2);
        Assert.AreEqual(42, tuple.Item3);
        Assert.AreEqual(true, tuple.Item4);
        Assert.AreEqual(3.14, tuple.Item5);
        Assert.AreEqual('X', tuple.Item6);
        Assert.AreEqual((byte)255, tuple.Item7);
        Assert.AreEqual((short)1000, tuple.Item8);
        Assert.AreEqual(123456789L, tuple.Item9);
        Assert.AreEqual(99.99m, tuple.Item10);
    }

    [TestMethod]
    public void Tuple_With10Items_CanBeCreatedAndAccessed()
    {
        // Arrange
        (CqlTupleMetadata, string, int, bool, double, char, byte, short, long, decimal, float) tuple = 
            (LargeTuple10Metadata, "test", 42, true, 3.14, 'X', 255, 1000, 123456789L, 99.99m, 1.5f);

        // Act & Assert
        Assert.AreEqual(LargeTuple10Metadata, tuple.Item1);
        Assert.AreEqual("test", tuple.Item2);
        Assert.AreEqual(42, tuple.Item3);
        Assert.AreEqual(true, tuple.Item4);
        Assert.AreEqual(3.14, tuple.Item5);
        Assert.AreEqual('X', tuple.Item6);
        Assert.AreEqual((byte)255, tuple.Item7);
        Assert.AreEqual((short)1000, tuple.Item8);
        Assert.AreEqual(123456789L, tuple.Item9);
        Assert.AreEqual(99.99m, tuple.Item10);
        Assert.AreEqual(1.5f, tuple.Item11);
    }

    [TestMethod]
    public void Tuple_With15Items_CanBeCreatedAndAccessed()
    {
        // Arrange
        var testDate = new DateTime(2023, 1, 1);
        (CqlTupleMetadata, string, int, bool, double, char, byte, short, long, decimal, float, uint, ulong, ushort, sbyte, DateTime) tuple = 
            (LargeTuple15Metadata, "test", 42, true, 3.14, 'X', 255, 1000, 123456789L, 99.99m, 1.5f, 4000u, 9876543210ul, 500, -50, testDate);

        // Act & Assert
        Assert.AreEqual(LargeTuple15Metadata, tuple.Item1);
        Assert.AreEqual("test", tuple.Item2);
        Assert.AreEqual(42, tuple.Item3);
        Assert.AreEqual(true, tuple.Item4);
        Assert.AreEqual(3.14, tuple.Item5);
        Assert.AreEqual('X', tuple.Item6);
        Assert.AreEqual((byte)255, tuple.Item7);
        Assert.AreEqual((short)1000, tuple.Item8);
        Assert.AreEqual(123456789L, tuple.Item9);
        Assert.AreEqual(99.99m, tuple.Item10);
        Assert.AreEqual(1.5f, tuple.Item11);
        Assert.AreEqual(4000u, tuple.Item12);
        Assert.AreEqual(9876543210ul, tuple.Item13);
        Assert.AreEqual((ushort)500, tuple.Item14);
        Assert.AreEqual((sbyte)-50, tuple.Item15);
        Assert.AreEqual(testDate, tuple.Item16);
    }

    [TestMethod]
    public void Tuple_With9Items_SerializesToJson()
    {
        // Arrange
        (CqlTupleMetadata, string, int, bool, double, char, byte, short, long, decimal) tuple = 
            (LargeTuple9Metadata, "test", 42, true, 3.14, 'X', 255, 1000, 123456789L, 99.99m);

        // Act
        var json = JsonSerializer.Serialize(tuple, JsonSerializerOptions);

        // Assert
        Assert.That.MultilinesAreEqual(
            """
            {
              "Item1": "test",
              "Item2": 42,
              "Item3": true,
              "Item4": 3.14,
              "Item5": "X",
              "Item6": 255,
              "Item7": 1000,
              "Item8": 123456789,
              "Item9": 99.99
            }
            """,
            json);
    }

    [TestMethod]
    public void Tuple_With10Items_SerializesToJson()
    {
        // Arrange
        (CqlTupleMetadata, string, int, bool, double, char, byte, short, long, decimal, float) tuple = 
            (LargeTuple10Metadata, "test", 42, true, 3.14, 'X', 255, 1000, 123456789L, 99.99m, 1.5f);

        // Act
        var json = JsonSerializer.Serialize(tuple, JsonSerializerOptions);

        // Assert
        Assert.That.MultilinesAreEqual(
            """
            {
              "Item1": "test",
              "Item2": 42,
              "Item3": true,
              "Item4": 3.14,
              "Item5": "X",
              "Item6": 255,
              "Item7": 1000,
              "Item8": 123456789,
              "Item9": 99.99,
              "Item10": 1.5
            }
            """,
            json);
    }

    [TestMethod]
    public void Tuple_With15Items_SerializesToJson()
    {
        // Arrange
        var testDate = new DateTime(2023, 1, 1);
        (CqlTupleMetadata, string, int, bool, double, char, byte, short, long, decimal, float, uint, ulong, ushort, sbyte, DateTime) tuple = 
            (LargeTuple15Metadata, "test", 42, true, 3.14, 'X', 255, 1000, 123456789L, 99.99m, 1.5f, 4000u, 9876543210ul, 500, -50, testDate);

        // Act
        var json = JsonSerializer.Serialize(tuple, JsonSerializerOptions);

        // Assert
        Assert.That.MultilinesAreEqual(
            """
            {
              "Item1": "test",
              "Item2": 42,
              "Item3": true,
              "Item4": 3.14,
              "Item5": "X",
              "Item6": 255,
              "Item7": 1000,
              "Item8": 123456789,
              "Item9": 99.99,
              "Item10": 1.5,
              "Item11": 4000,
              "Item12": 9876543210,
              "Item13": 500,
              "Item14": -50,
              "Item15": "2023-01-01T00:00:00"
            }
            """,
            json);
    }
}