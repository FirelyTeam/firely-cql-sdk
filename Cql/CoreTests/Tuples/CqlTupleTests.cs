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
}