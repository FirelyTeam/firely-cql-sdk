#nullable enable
using System.IO;
using System.Runtime.Loader;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class AssemblyLoadContextTests
{
    [TestMethod]
    public void TestAssemblyLoadContext()
    {
        // Arrange
        var file = @"Dlls/CqlNestedTupleTest-1.0.0.dll";
        var filePath = Path.GetFullPath(file);
        var asm = new AssemblyLoadContext("CqlNestedTupleTest");
        asm.LoadFromAssemblyPath(filePath);
        var ctx = FhirCqlContext.ForBundle();

        // Act
        var result = asm.Run("CqlNestedTupleTest", "1.0.0", ctx);

        // Assert
        Assert.IsNotNull(result);
        result.TryGetValue("Result", out var obj);
        Assert.IsNotNull(obj);
    }
}