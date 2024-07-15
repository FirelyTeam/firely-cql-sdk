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
    public class StartEndTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Start_of()
        {
            var library = MakeLibrary(@"
                library StartEndTest version '1.0.0'

                define private Start_of: start of Interval[1, 3]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Start));
            {
                var start = (Start)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Integer", start.resultTypeName.Name);
                Assert.IsInstanceOfType(start.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Integer", ((NamedTypeSpecifier)start.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(start.operand);
                Assert.IsInstanceOfType(start.operand, typeof(Interval));
                var result = Run(start);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(1, result);
            }
        }

        [TestMethod]
        public void Start_of_null()
        {
            var library = MakeLibrary(@"
                library StartEndTest version '1.0.0'

                define private Start_of_null: start of (null as Interval<Integer>)
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Start));
            {
                var start = (Start)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Integer", start.resultTypeName.Name);
                Assert.IsInstanceOfType(start.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Integer", ((NamedTypeSpecifier)start.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(start.operand);
                Assert.IsInstanceOfType(start.operand, typeof(As));
                var result = Run(start);
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Start_of_point_null()
        {
            var library = MakeLibrary(@"
                library StartEndTest version '1.0.0'

                define private Start_of_point_null: start of Interval(null, 10]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Start));
            {
                var start = (Start)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Integer", start.resultTypeName.Name);
                Assert.IsInstanceOfType(start.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Integer", ((NamedTypeSpecifier)start.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(start.operand);
                Assert.IsInstanceOfType(start.operand, typeof(Interval));
                var result = Run(start);
                Assert.IsNull(result);
            }
        }


        [TestMethod]
        public void End_of()
        {
            var library = MakeLibrary(@"
                library EndEndTest version '1.0.0'

                define private End_of: end of Interval[1, 3]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(End));
            {
                var end = (End)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Integer", end.resultTypeName.Name);
                Assert.IsInstanceOfType(end.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Integer", ((NamedTypeSpecifier)end.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(end.operand);
                Assert.IsInstanceOfType(end.operand, typeof(Interval));
                var result = Run(end);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(3, result);
            }
        }

        [TestMethod]
        public void End_of_null()
        {
            var library = MakeLibrary(@"
                library EndEndTest version '1.0.0'

                define private End_of_null: end of (null as Interval<Integer>)
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(End));
            {
                var end = (End)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Integer", end.resultTypeName.Name);
                Assert.IsInstanceOfType(end.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Integer", ((NamedTypeSpecifier)end.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(end.operand);
                Assert.IsInstanceOfType(end.operand, typeof(As));
                var result = Run(end);
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void End_of_point_null()
        {
            var library = MakeLibrary(@"
                library EndEndTest version '1.0.0'

                define private End_of_point_null: end of Interval[10, null)
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(End));
            {
                var end = (End)library.statements[0].expression;
                Assert.AreEqual($"{{{SystemUri}}}Integer", end.resultTypeName.Name);
                Assert.IsInstanceOfType(end.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Integer", ((NamedTypeSpecifier)end.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(end.operand);
                Assert.IsInstanceOfType(end.operand, typeof(Interval));
                var result = Run(end);
                Assert.IsNull(result);
            }
        }

    }
}
