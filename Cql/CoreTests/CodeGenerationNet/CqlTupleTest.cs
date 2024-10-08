using System.Dynamic;
using System.IO;
using System.Runtime.Loader;
using System.Text.Json;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests.CodeGenerationNet;

[TestClass]
public class CqlTupleTest
{

    [TestMethod]
    public void Result_ShouldBeDynamicWithNamedItems()
    {
        var file = @"Assemblies/CqlTupleTest-1.0.0.dll";
        var filePath = Path.GetFullPath(file);

        var asm = new AssemblyLoadContext("CqlTupleTest");
        asm.LoadFromAssemblyPath(filePath);

        var ctx = FhirCqlContext.ForBundle();
        var result = asm.Run("CqlTupleTest", "1.0.0", ctx);
        Assert.IsNotNull(result);

        result.TryGetValue("Result", out dynamic obj);
        Assert.IsNotNull(obj);
        Assert.IsInstanceOfType(obj, typeof(ExpandoObject));

        Assert.AreEqual("success", obj.status);
        Assert.AreEqual("some result", obj.result);

        // serialization works out of the box
        var str = JsonSerializer.Serialize(obj);
        Assert.AreEqual("{\"status\":\"success\",\"result\":\"some result\"}", str);
    }
}
