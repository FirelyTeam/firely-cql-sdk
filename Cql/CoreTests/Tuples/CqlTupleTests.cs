#nullable enable
using CqlSdkPrototype.Invocation;
using CqlSdkPrototype.Invocation.Extensions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
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

    [TestMethod]
    public void ExpressionReturningNestedTuplesFromDirectLibraryInstance_ResultCanBeSerialized()
    {
        var ctx = FhirCqlContext.ForBundle();
        var obj = CqlNestedTupleTest_1_0_0.Instance.Result(ctx);
        Assert.IsNotNull(obj);
        Assert.IsInstanceOfType(obj, typeof(ITuple));

        var str = JsonSerializer.Serialize(obj, new JsonSerializerOptions() { WriteIndented = true, Converters = { new CqlValueTupleJsonConverterFactory() }});
        Assert.AreEqual(
            """
            {
              "status": "success",
              "result": {
                "result1": "some first result",
                "result2": "some second result"
              }
            }
            """, str);
    }

    /// <seealso cref="InvocationToolkitTests.TestRuntimeScopeAgainstLibraryDefinitionResults"/>
    [TestMethod]
    public void ExpressionReturningNestedTuplesFromAssemblyLoadedLibraryInstance_ResultCanBeSerialized()
    {
        var filePath = new DirectoryInfo(Directory.GetCurrentDirectory())
                       .SelfAndParents()
                       .Select(dir => Path.GetFullPath(Path.Combine(dir.FullName, "Dlls", "CqlNestedTupleTest-1.0.0.dll")))
                       .First(File.Exists);
        var ctx = FhirCqlContext.ForBundle();
        using var librarySetInvoker = new InvocationToolkit()
                                    .AddAssemblyBinaries(AssemblyBinary.Default.LoadFromFile(new FileInfo(filePath)))
                                    .CreateLibrarySetInvoker();

        // Act
        var result = librarySetInvoker
                     .EnumerateLibraryDefinitionsResults(ctx, CqlVersionedLibraryIdentifier.Parse("CqlNestedTupleTest-1.0.0"))
                     .Select(t => (definition: t.definitionInvoker.DefinitionName, t.getResult()))
                     .ToDictionary();
        Assert.IsNotNull(result);
        result.TryGetValue("Result", out var obj);
        Assert.IsNotNull(obj);
        Assert.IsInstanceOfType(obj, typeof(ITuple));

        var str = JsonSerializer.Serialize(obj, new JsonSerializerOptions() { WriteIndented = true, Converters = { new CqlValueTupleJsonConverterFactory() }});
        Assert.AreEqual(
            """
            {
              "status": "success",
              "result": {
                "result1": "some first result",
                "result2": "some second result"
              }
            }
            """, str);
    }
}