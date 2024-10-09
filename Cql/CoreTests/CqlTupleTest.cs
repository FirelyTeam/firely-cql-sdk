using System.Text.Json;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class CqlTupleTest
{
    [TestMethod]
    public void Result_ShouldBeTupleWithNamedItems()
    {
        CqlContext ctx = FhirCqlContext.ForBundle();
        var lib = new CqlTupleTest_1_0_0(ctx);
        var result = lib.Result();

        Assert.IsNotNull(result);
        var resultValue = result.Value;

        Assert.AreEqual("success", resultValue.status); // works only because the compiler replaces resultValue.status with resultValue.Item1
        Assert.AreEqual("some result", resultValue.result); // works only because the compiler replaces resultValue.result with resultValue.Item2

        Assert.IsNotNull(resultValue.GetType().GetField("Item1")); // works
        Assert.IsNotNull(resultValue.GetType().GetField("Item2"));
        Assert.IsNotNull(resultValue.GetType().GetField("status")); // fails, because the compiler replaced all custom names with default names, the custom names are not part of the runtime type information
        Assert.IsNotNull(resultValue.GetType().GetField("result")); // fails, because the compiler replaced all custom names with default names, the custom names are not part of the runtime type information
        // see https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples#tuple-field-names

        var str = JsonSerializer.Serialize(resultValue);
        Assert.AreEqual("{\"status\":\"success\",\"result\":\"some result\"}", str); //fails, because a tuple without field names can't be serialized to JSON
    }
}
