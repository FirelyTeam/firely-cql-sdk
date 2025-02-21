using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;

namespace CoreTests;

[TestClass]
public class CqlBooleanTest
{
    [TestMethod]
    public void SomethingTrueEqualsTrue_ShouldBeTrue()
    {
        CqlContext ctx = FhirCqlContext.ForBundle();
        var lib = CqlBooleanTest_1_0_000.Instance;
        Assert.IsTrue(lib.SomethingTrueEqualsTrue(ctx));
    }
}
