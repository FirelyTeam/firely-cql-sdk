using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class WidthTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Width_Integer()
        {
            var library = MakeLibrary(@"
                library WidthTest version '1.0.0'

                define private Width_Integers: width of Interval[3,7]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Width));
            {
                var width = (Width)library.statements[0].expression;
                Assert.IsInstanceOfType(width.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)width.resultTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", width.resultTypeName?.Name);
                Assert.IsNotNull(width.operand);
                Assert.IsInstanceOfType(width.operand, typeof(Interval));
                var interval = (Interval)width.operand;
                AssertIntervalType(interval.resultTypeSpecifier, $"{{{SystemUri}}}Integer");

                var lambda = ExpressionBuilder.Lambda(width);
                var dg = lambda.Compile();
                var ctx = FhirCqlContext.ForBundle();
                var result = dg.DynamicInvoke(ctx);
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(4, result);
            }
        }


        [TestMethod]
        public void Width_Integers_Null()
        {
            var library = MakeLibrary(@"
                library WidthTest version '1.0.0'

                define private Width_Integers_Null: width of (null as Interval<Integer>)
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Width));
            {
                var width = (Width)library.statements[0].expression;
                Assert.IsInstanceOfType(width.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)width.resultTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", width.resultTypeName?.Name);
                Assert.IsNotNull(width.operand);
                Assert.IsInstanceOfType(width.operand, typeof(As));
                var @as = (As)width.operand;
                Assert.IsInstanceOfType(@as.operand, typeof(Null));
                AssertIntervalType(@as.resultTypeSpecifier, $"{{{SystemUri}}}Integer");

                var lambda = ExpressionBuilder.Lambda(width);
                var dg = lambda.Compile();
                var ctx = FhirCqlContext.ForBundle();
                var result = dg.DynamicInvoke(ctx);
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Width_Integers_Null_Interval()
        {
            var library = MakeLibrary(@"
                library WidthTest version '1.0.0'

                define private Width_Integers_Error: width of Interval[1,null)
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Width));
            {
                var width = (Width)library.statements[0].expression;
                Assert.IsInstanceOfType(width.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)width.resultTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", width.resultTypeName?.Name);
                Assert.IsNotNull(width.operand);
                Assert.IsInstanceOfType(width.operand, typeof(Interval));
                var list = (Interval)width.operand;
                AssertIntervalType(list.resultTypeSpecifier, $"{{{SystemUri}}}Integer");

                var lambda = ExpressionBuilder.Lambda(width);
                var dg = lambda.Compile();
                var ctx = FhirCqlContext.ForBundle();
                var result = dg.DynamicInvoke(ctx);
                Assert.IsNull(result);
            }
        }

    }
}
