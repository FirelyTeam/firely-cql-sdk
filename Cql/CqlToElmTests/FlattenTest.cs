using FluentAssertions;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class FlattenTest: Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter


        [TestMethod]
        public void FlattenEmpty()
        {
            var library = MakeLibrary(@"
                library ListTest version '1.0.0'

                define private FlattenEmpty: Flatten({{},{}})
            ").ShouldSucceed();
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Flatten));
            {
                var flatten = (Flatten)library.statements[0].expression;
            }
        }

        [TestMethod]
        public void FlattenListNullAndNull()
        {
            var lib = CreateLibraryForExpression("Flatten({{null}, {null}})");
            var flatten = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Flatten>();
            var result = Run<List<object>>(flatten); // {null, null}
            result!.Count.Should().Be(2);
            var equal = CreateLibraryForExpression("Flatten({{null}, {null}}) = {null, null}")
                .Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equal>();
            var eqr = Run<bool?>(equal); // {null, null}
            eqr.Should().BeTrue();
        }
    }
}
