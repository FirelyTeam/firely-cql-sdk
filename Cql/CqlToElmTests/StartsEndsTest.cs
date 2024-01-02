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
    public class StartsEndsTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter


        [TestMethod]
        public void Starts_False()
        {
            var library = MakeLibrary(@"
                library StartsEndsTest version '1.0.0'

                define private Starts_False: Interval[@2023-01-01, @2023-06-30] starts Interval[@2023-04-01, @2023-04-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Starts));
            {
                var starts = (Starts)library.statements[0].expression;
                Assert.IsFalse(starts.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", starts.resultTypeName.Name);
                Assert.IsInstanceOfType(starts.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)starts.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(starts.operand);
                Assert.AreEqual(2, starts.operand.Length);
                Assert.IsInstanceOfType(starts.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(starts.operand[1], typeof(Interval));
                var result = Run(starts);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Starts_True()
        {
            var library = MakeLibrary(@"
                library StartsEndsTest version '1.0.0'

                define private Starts_True: Interval[0, 5] starts Interval[0,7]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Starts));
            {
                var starts = (Starts)library.statements[0].expression;
                Assert.IsFalse(starts.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", starts.resultTypeName.Name);
                Assert.IsInstanceOfType(starts.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)starts.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(starts.operand);
                Assert.AreEqual(2, starts.operand.Length);
                Assert.IsInstanceOfType(starts.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(starts.operand[1], typeof(Interval));
                var result = Run(starts);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Starts_Precision()
        {
            var library = MakeLibrary(@"
                library StartsEndsTest version '1.0.0'

                define private Starts_Precision: Interval[@2023-01-01, @2023-06-30] starts day from Interval[@2023-01-01, @2023-10-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Starts));
            {
                var starts = (Starts)library.statements[0].expression;
                Assert.IsFalse(starts.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", starts.resultTypeName.Name);
                Assert.IsInstanceOfType(starts.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)starts.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(starts.operand);
                Assert.AreEqual(2, starts.operand.Length);
                Assert.IsInstanceOfType(starts.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(starts.operand[1], typeof(Interval));
                var result = Run(starts);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Ends_False()
        {
            var library = MakeLibrary(@"
                library StartsEndsTest version '1.0.0'

                define private Ends_False: Interval[-1, 7] ends Interval[0,7]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Ends));
            {
                var ends = (Ends)library.statements[0].expression;
                Assert.IsFalse(ends.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ends.resultTypeName.Name);
                Assert.IsInstanceOfType(ends.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)ends.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(ends.operand);
                Assert.AreEqual(2, ends.operand.Length);
                Assert.IsInstanceOfType(ends.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(ends.operand[1], typeof(Interval));
                var result = Run(ends);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }
        [TestMethod]
        public void Ends_Precision()
        {
            var library = MakeLibrary(@"
                library StartsEndsTest version '1.0.0'

                define private Ends_Precision: Interval[@2023-01-01, @2023-06-30] ends day from Interval[@2023-01-01, @2023-10-30]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Ends));
            {
                var ends = (Ends)library.statements[0].expression;
                Assert.IsFalse(ends.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ends.resultTypeName.Name);
                Assert.IsInstanceOfType(ends.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)ends.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(ends.operand);
                Assert.AreEqual(2, ends.operand.Length);
                Assert.IsInstanceOfType(ends.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(ends.operand[1], typeof(Interval));
                var result = Run(ends);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }
    }
}
