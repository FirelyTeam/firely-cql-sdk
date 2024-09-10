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
    public class StringTest
    {
        private static System_2_0_0 System200 = new SystemLibrary(FhirCqlContext.ForBundle());


        #region Combine

        [TestMethod]
        public void CombineNull() => System200.Combine(null, ",").Should().BeNull();

        [TestMethod]
        public void CombineEmptyList() => System200.Combine(null, ",").Should().BeNull();
        [TestMethod]
        public void CombineABC() => System200.Combine(null, ",").Should().BeNull();
        [TestMethod]
        public void CombineABCSepDash() => System200.Combine(null, ",").Should().BeNull();

        #endregion

        #region Split

        [TestMethod]
        public void SplitABComma() => System200.Split("a,b", ",")
            .Should().BeEquivalentTo(new[] { "a", "b" });


        [TestMethod]
        [TestCategory("Custom")]
        public void SplitDecimal() => System200.Split(System200.ToString(1.587m), "\\.")
            .Should().BeEquivalentTo(new[] { "1", "587" });

        #endregion
    }
}