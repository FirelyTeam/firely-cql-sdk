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
    public class OverlapsTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter


        [TestMethod]
        public void Overlaps()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library OverlapsTest version '1.0.0'

                define private Overlaps: Interval[0, 4] overlaps Interval[1, 4]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Overlaps));
            {
                var overlaps = (Overlaps)library.statements[0].expression;
                Assert.IsFalse(overlaps.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", overlaps.resultTypeName.Name);
                Assert.IsInstanceOfType(overlaps.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)overlaps.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(overlaps.operand);
                Assert.AreEqual(2, overlaps.operand.Length);
                Assert.IsInstanceOfType(overlaps.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(overlaps.operand[1], typeof(Interval));
                var result = Run(overlaps);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Overlaps_Before()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library OverlapsTest version '1.0.0'

                define private Overlaps_Before:  Interval[0, 4] overlaps before Interval[1, 4]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(OverlapsBefore));
            {
                var overlaps = (OverlapsBefore)library.statements[0].expression;
                Assert.IsFalse(overlaps.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", overlaps.resultTypeName.Name);
                Assert.IsInstanceOfType(overlaps.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)overlaps.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(overlaps.operand);
                Assert.AreEqual(2, overlaps.operand.Length);
                Assert.IsInstanceOfType(overlaps.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(overlaps.operand[1], typeof(Interval));
                var result = Run(overlaps);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Overlaps_After()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library OverlapsTest version '1.0.0'

                define private Overlaps_After: Interval[0, 4] overlaps after Interval[1, 4]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(OverlapsAfter));
            {
                var overlaps = (OverlapsAfter)library.statements[0].expression;
                Assert.IsFalse(overlaps.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", overlaps.resultTypeName.Name);
                Assert.IsInstanceOfType(overlaps.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)overlaps.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(overlaps.operand);
                Assert.AreEqual(2, overlaps.operand.Length);
                Assert.IsInstanceOfType(overlaps.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(overlaps.operand[1], typeof(Interval));
                var result = Run(overlaps);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Overlaps_Is_Null()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library OverlapsTest version '1.0.0'

                define private Overlaps_Is_Null: Interval[6, 10] overlaps (null as Interval<Integer>)
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Overlaps));
            {
                var overlaps = (Overlaps)library.statements[0].expression;
                Assert.IsFalse(overlaps.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", overlaps.resultTypeName.Name);
                Assert.IsInstanceOfType(overlaps.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)overlaps.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(overlaps.operand);
                Assert.AreEqual(2, overlaps.operand.Length);
                Assert.IsInstanceOfType(overlaps.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(overlaps.operand[1], typeof(As));
                var result = Run(overlaps);
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Overlaps_After_Day()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library OverlapsTest version '1.0.0'

                define private Overlaps_After_Day: Interval[@2023-03-01, @2023-06-01] overlaps after month of Interval[@2023-01-01, @2023-03-01]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(OverlapsAfter));
            {
                var overlaps = (OverlapsAfter)library.statements[0].expression;
                Assert.IsTrue(overlaps.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", overlaps.resultTypeName.Name);
                Assert.IsInstanceOfType(overlaps.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)overlaps.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(overlaps.operand);
                Assert.AreEqual(2, overlaps.operand.Length);
                Assert.IsInstanceOfType(overlaps.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(overlaps.operand[1], typeof(Interval));
                var result = Run(overlaps);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Overlaps_Day()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library OverlapsTest version '1.0.0'

                define private Overlaps_Day: Interval[@2023-01-01, @2023-06-01] overlaps month of Interval[@2023-07-01, @2023-10-01]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Overlaps));
            {
                var overlaps = (Overlaps)library.statements[0].expression;
                Assert.IsTrue(overlaps.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", overlaps.resultTypeName.Name);
                Assert.IsInstanceOfType(overlaps.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)overlaps.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(overlaps.operand);
                Assert.AreEqual(2, overlaps.operand.Length);
                Assert.IsInstanceOfType(overlaps.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(overlaps.operand[1], typeof(Interval));
                var result = Run(overlaps);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }
    }
}
