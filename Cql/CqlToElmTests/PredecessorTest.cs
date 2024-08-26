using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{

    [TestClass]
    public class PredecessorTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Predecessor_Integer()
        {
            var library = MakeLibrary(@"
                library PointFromTest version '1.0.0'

                define private Point_From_Integers: predecessor of 2
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Predecessor));
            {
                var predecessor = (Predecessor)library.statements[0].expression;
                Assert.IsInstanceOfType(predecessor.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)predecessor.resultTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", predecessor.resultTypeName?.Name);
                Assert.IsNotNull(predecessor.operand);
                Assert.IsInstanceOfType(predecessor.operand, typeof(Literal));


                var lambda = LibraryExpressionBuilder.Lambda(predecessor);
                var dg = lambda.Compile();
                var ctx = FhirCqlContext.ForBundle();
                var result = dg.DynamicInvoke(ctx);
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(1, result);
            }
        }

        [TestMethod]
        public void Predecessor_Null()
        {
            var library = MakeLibrary(@"
                library PointFromTest version '1.0.0'

                define private Point_From_Integers: predecessor of (null as Integer)
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Predecessor));
            {
                var predecessor = (Predecessor)library.statements[0].expression;
                Assert.IsInstanceOfType(predecessor.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)predecessor.resultTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", predecessor.resultTypeName?.Name);
                Assert.IsNotNull(predecessor.operand);
                Assert.IsInstanceOfType(predecessor.operand, typeof(As));


                var lambda = LibraryExpressionBuilder.Lambda(predecessor);
                var dg = lambda.Compile();
                var ctx = FhirCqlContext.ForBundle();
                var result = dg.DynamicInvoke(ctx);
                Assert.IsNull(result);
            }
        }

    }
}
