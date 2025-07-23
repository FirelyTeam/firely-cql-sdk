/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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
