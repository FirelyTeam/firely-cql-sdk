using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    internal class PointFromTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Point_From_Integer()
        {
            var library = MakeLibrary(@"
                library PointFromTest version '1.0.0'

                define private Point_From_Integers: point from Interval[4,4]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(PointFrom));
            {
                var pointFrom = (PointFrom)library.statements[0].expression;
                Assert.IsInstanceOfType(pointFrom.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)pointFrom.resultTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", pointFrom.resultTypeName?.Name);
                Assert.IsNotNull(pointFrom.operand);
                Assert.IsInstanceOfType(pointFrom.operand, typeof(Interval));
                var interval = (Interval)pointFrom.operand;
                AssertIntervalType(interval.resultTypeSpecifier, $"{{{SystemUri}}}Integer");

                var lambda = LibraryExpressionBuilder.Lambda(pointFrom);
                var dg = lambda.Compile();
                var ctx = FhirCqlContext.ForBundle();
                var result = dg.DynamicInvoke(ctx);
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(4, result);
            }
        }

        [TestMethod]
        public void Point_From_Integer_Closed()
        {
            var library = MakeLibrary(@"
                library PointFromTest version '1.0.0'

                define private Point_From_Integers: point from Interval[4,5)
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(PointFrom));
            {
                var pointFrom = (PointFrom)library.statements[0].expression;
                Assert.IsInstanceOfType(pointFrom.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)pointFrom.resultTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", pointFrom.resultTypeName?.Name);
                Assert.IsNotNull(pointFrom.operand);
                Assert.IsInstanceOfType(pointFrom.operand, typeof(Interval));
                var interval = (Interval)pointFrom.operand;
                AssertIntervalType(interval.resultTypeSpecifier, $"{{{SystemUri}}}Integer");

                var lambda = LibraryExpressionBuilder.Lambda(pointFrom);
                var dg = lambda.Compile();
                var ctx = FhirCqlContext.ForBundle();
                var result = dg.DynamicInvoke(ctx);
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(4, result);
            }
        }


        [TestMethod]
        public void Point_From_Integers_Null()
        {
            var library = MakeLibrary(@"
                library PointFromTest version '1.0.0'

                define private Point_From_Integers_Null: point from (null as Interval<Integer>)
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(PointFrom));
            {
                var pointFrom = (PointFrom)library.statements[0].expression;
                Assert.IsInstanceOfType(pointFrom.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)pointFrom.resultTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", pointFrom.resultTypeName?.Name);
                Assert.IsNotNull(pointFrom.operand);
                Assert.IsInstanceOfType(pointFrom.operand, typeof(As));
                var @as = (As)pointFrom.operand;
                Assert.IsInstanceOfType(@as.operand, typeof(Null));
                AssertIntervalType(@as.resultTypeSpecifier, $"{{{SystemUri}}}Integer");

                var lambda = LibraryExpressionBuilder.Lambda(pointFrom);
                var dg = lambda.Compile();
                var ctx = FhirCqlContext.ForBundle();
                var result = dg.DynamicInvoke(ctx);
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Point_From_Integers_Error()
        {
            var library = MakeLibrary(@"
                library PointFromTest version '1.0.0'

                define private Point_From_Integers_Error: point from Interval[1,4]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(PointFrom));
            {
                var pointFrom = (PointFrom)library.statements[0].expression;
                Assert.IsInstanceOfType(pointFrom.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)pointFrom.resultTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name?.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", pointFrom.resultTypeName?.Name);
                Assert.IsNotNull(pointFrom.operand);
                Assert.IsInstanceOfType(pointFrom.operand, typeof(Interval));
                var list = (Interval)pointFrom.operand;
                AssertIntervalType(list.resultTypeSpecifier, $"{{{SystemUri}}}Integer");

                var lambda = LibraryExpressionBuilder.Lambda(pointFrom);
                var dg = lambda.Compile();
                var ctx = FhirCqlContext.ForBundle();
                Assert.ThrowsException<TargetInvocationException>(() => dg.DynamicInvoke(ctx));
            }
        }

    }
}
