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
    public class LengthTest: Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void LengthNullString()
        {
            var library = CreateLibraryForExpression("Length(null as String)");
            var length = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Length>();
            var result = Run<int?>(length);
            result.Should().BeNull();
        }
    }
}
