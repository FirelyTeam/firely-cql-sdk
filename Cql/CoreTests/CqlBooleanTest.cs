using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests;

[TestClass]
public class CqlBooleanTest
{
    [TestMethod]
    public void SomethingTrueEqualsTrue_ShouldBeTrue()
    {
        CqlContext ctx = FhirCqlContext.ForBundle();
        var lib = new CqlBooleanTest_1_0_000();
        Assert.IsTrue(lib.SomethingTrueEqualsTrue(ctx));
    }
}
