using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class DistinctTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void DistinctABCABC()
        {
            var library = CreateLibraryForExpression("distinct { 'a', 'b', 'c', 'a', 'b', 'c'}");
            var distinct = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Distinct>();
            var result = Run<IEnumerable<string>?>(distinct)!.ToArray();
            result.Length.Should().Be(3);
            result.Contains("a").Should().BeTrue();
            result.Contains("b").Should().BeTrue();
            result.Contains("c").Should().BeTrue();

        }
    }
}
