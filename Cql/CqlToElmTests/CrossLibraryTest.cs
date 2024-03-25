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
    public class CrossLibraryTest: Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void ExpressionRef_Across_Library()
        {
            var foo = ConvertLibrary(@"
                library Foo version '1.0.0'

                define F: 'foo'
            ");
            foo.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Literal>();

            var bar = ConvertLibrary(@"
                library Bar version '1.0.0'

                include Foo version '1.0.0' called foo

                define G: foo.F
            ");
            bar.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ExpressionRef>();

        }
    }
}
