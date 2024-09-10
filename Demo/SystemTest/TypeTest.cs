using Cql.WithBuildTasks;
using FluentAssertions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SystemTest
{
    [TestClass]
    public class TypeTest
    {
        private static System_2_0_0 System200 = new SystemLibrary(FhirCqlContext.ForBundle());

        [TestMethod]
        public void ToTime1() => System200.ToTime("T14:30:00.0").Should().Be(new CqlTime(14, 30, 9, 0, null, null));

    }
}
