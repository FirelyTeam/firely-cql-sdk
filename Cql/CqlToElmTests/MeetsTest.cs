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
    public class MeetsTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter


        [TestMethod]
        public void Meets()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library MeetsTest version '1.0.0'

                define private Meets: Interval[6, 10] meets Interval[0, 5]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Meets));
            {
                var meets = (Meets)library.statements[0].expression;
                Assert.IsFalse(meets.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", meets.resultTypeName.Name);
                Assert.IsInstanceOfType(meets.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)meets.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(meets.operand);
                Assert.AreEqual(2, meets.operand.Length);
                Assert.IsInstanceOfType(meets.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(meets.operand[1], typeof(Interval));
                var result = Run(meets);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Meets_Before()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library MeetsTest version '1.0.0'

                define private Meets_Before: Interval[-5, -1] meets before Interval[0, 5]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(MeetsBefore));
            {
                var meets = (MeetsBefore)library.statements[0].expression;
                Assert.IsFalse(meets.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", meets.resultTypeName.Name);
                Assert.IsInstanceOfType(meets.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)meets.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(meets.operand);
                Assert.AreEqual(2, meets.operand.Length);
                Assert.IsInstanceOfType(meets.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(meets.operand[1], typeof(Interval));
                var result = Run(meets);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Meets_After()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library MeetsTest version '1.0.0'

                define private Meets_After: Interval[6, 10] meets after Interval[0, 7]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(MeetsAfter));
            {
                var meets = (MeetsAfter)library.statements[0].expression;
                Assert.IsFalse(meets.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", meets.resultTypeName.Name);
                Assert.IsInstanceOfType(meets.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)meets.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(meets.operand);
                Assert.AreEqual(2, meets.operand.Length);
                Assert.IsInstanceOfType(meets.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(meets.operand[1], typeof(Interval));
                var result = Run(meets);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Meets_Is_Null()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library MeetsTest version '1.0.0'

                define private Meets_Is_Null: Interval[6, 10] meets (null as Interval<Integer>)
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Meets));
            {
                var meets = (Meets)library.statements[0].expression;
                Assert.IsFalse(meets.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", meets.resultTypeName.Name);
                Assert.IsInstanceOfType(meets.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)meets.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(meets.operand);
                Assert.AreEqual(2, meets.operand.Length);
                Assert.IsInstanceOfType(meets.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(meets.operand[1], typeof(As));
                var result = Run(meets);
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Meets_After_Day()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library MeetsTest version '1.0.0'

                define private Meets_After_Day: Interval[@2023-03-01, @2023-06-01] meets after month of Interval[@2023-01-01, @2023-03-01]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(MeetsAfter));
            {
                var meets = (MeetsAfter)library.statements[0].expression;
                Assert.IsTrue(meets.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", meets.resultTypeName.Name);
                Assert.IsInstanceOfType(meets.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)meets.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(meets.operand);
                Assert.AreEqual(2, meets.operand.Length);
                Assert.IsInstanceOfType(meets.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(meets.operand[1], typeof(Interval));
                var result = Run(meets);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Meets_Day()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library MeetsTest version '1.0.0'

                define private Meets_Day: Interval[@2023-01-01, @2023-06-01] meets month of Interval[@2023-07-01, @2023-10-01]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Meets));
            {
                var meets = (Meets)library.statements[0].expression;
                Assert.IsTrue(meets.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", meets.resultTypeName.Name);
                Assert.IsInstanceOfType(meets.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)meets.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(meets.operand);
                Assert.AreEqual(2, meets.operand.Length);
                Assert.IsInstanceOfType(meets.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(meets.operand[1], typeof(Interval));
                var result = Run(meets);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }
    }
}
