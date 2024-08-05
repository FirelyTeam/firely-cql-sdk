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
    public class IncludedInTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        //('starts' | 'ends' | 'occurs')? 'properly'? ('during' | 'included in') dateTimePrecisionSpecifier?
        [TestMethod]
        public void Starts_Properly_During_Year()
        {
            var library = MakeLibrary(@"
                library IncludedInTest version '1.0.0'

                define private Starts_Properly_During_Year: Interval[@2023, @2030] starts properly during year of Interval[@2020, @2030]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ProperIn));
            {
                var properIn = (ProperIn)library.statements[0].expression;
                Assert.IsTrue(properIn.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", properIn.resultTypeName.Name);
                Assert.IsInstanceOfType(properIn.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)properIn.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(properIn.operand);
                Assert.AreEqual(2, properIn.operand.Length);
                Assert.IsInstanceOfType(properIn.operand[0], typeof(Start));
                Assert.IsInstanceOfType(properIn.operand[1], typeof(Interval));
                var result = Run(properIn);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }
        [TestMethod]
        public void Starts_Properly_IncludedIn_Year()
        {
            var library = MakeLibrary(@"
                library IncludedInTest version '1.0.0'

                define private Starts_Properly_IncludedIn_Year: Interval[@2023, @2030] starts properly included in year of Interval[@2020, @2030]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ProperIn));
            {
                var properIn = (ProperIn)library.statements[0].expression;
                Assert.IsTrue(properIn.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", properIn.resultTypeName.Name);
                Assert.IsInstanceOfType(properIn.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)properIn.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(properIn.operand);
                Assert.AreEqual(2, properIn.operand.Length);
                Assert.IsInstanceOfType(properIn.operand[0], typeof(Start));
                Assert.IsInstanceOfType(properIn.operand[1], typeof(Interval));
                var result = Run(properIn);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Starts_During_Year()
        {
            var library = MakeLibrary(@"
                library IncludedInTest version '1.0.0'

                define private Starts_During_Year: Interval[@2023, @2030] starts during year of Interval[@2020, @2030]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(In));
            {
                var @in = (In)library.statements[0].expression;
                Assert.IsTrue(@in.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", @in.resultTypeName.Name);
                Assert.IsInstanceOfType(@in.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)@in.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(@in.operand);
                Assert.AreEqual(2, @in.operand.Length);
                Assert.IsInstanceOfType(@in.operand[0], typeof(Start));
                Assert.IsInstanceOfType(@in.operand[1], typeof(Interval));
                var result = Run(@in);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Starts_IncludedIn_Year()
        {
            var library = MakeLibrary(@"
                library IncludedInTest version '1.0.0'

                define private Starts_During_Year: Interval[@2023, @2030] starts included in year of Interval[@2020, @2030]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(In));
            {
                var @in = (In)library.statements[0].expression;
                Assert.IsTrue(@in.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", @in.resultTypeName.Name);
                Assert.IsInstanceOfType(@in.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)@in.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(@in.operand);
                Assert.AreEqual(2, @in.operand.Length);
                Assert.IsInstanceOfType(@in.operand[0], typeof(Start));
                Assert.IsInstanceOfType(@in.operand[1], typeof(Interval));
                var result = Run(@in);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Properly_During_Year()
        {
            var library = MakeLibrary(@"
                library IncludedInTest version '1.0.0'

                define private Starts_Properly_During_Year: Interval[@2023, @2030] properly during year of Interval[@2020, @2030]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ProperIncludedIn));
            {
                var includedIn = (ProperIncludedIn)library.statements[0].expression;
                Assert.IsTrue(includedIn.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", includedIn.resultTypeName.Name);
                Assert.IsInstanceOfType(includedIn.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)includedIn.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(includedIn.operand);
                Assert.AreEqual(2, includedIn.operand.Length);
                Assert.IsInstanceOfType(includedIn.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(includedIn.operand[1], typeof(Interval));
                var result = Run(includedIn);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Properly_IncludedIn_Year()
        {
            var library = MakeLibrary(@"
                library IncludedInTest version '1.0.0'

                define private Properly_IncludedIn_Year: Interval[@2023, @2030] properly included in year of Interval[@2020, @2030]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ProperIncludedIn));
            {
                var includedIn = (ProperIncludedIn)library.statements[0].expression;
                Assert.IsTrue(includedIn.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", includedIn.resultTypeName.Name);
                Assert.IsInstanceOfType(includedIn.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)includedIn.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(includedIn.operand);
                Assert.AreEqual(2, includedIn.operand.Length);
                Assert.IsInstanceOfType(includedIn.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(includedIn.operand[1], typeof(Interval));
                var result = Run(includedIn);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void During_Year()
        {
            var library = MakeLibrary(@"
                library IncludedInTest version '1.0.0'

                define private Starts_During_Year: Interval[@2023, @2030] during year of Interval[@2020, @2030]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(IncludedIn));
            {
                var includedIn = (IncludedIn)library.statements[0].expression;
                Assert.IsTrue(includedIn.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", includedIn.resultTypeName.Name);
                Assert.IsInstanceOfType(includedIn.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)includedIn.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(includedIn.operand);
                Assert.AreEqual(2, includedIn.operand.Length);
                Assert.IsInstanceOfType(includedIn.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(includedIn.operand[1], typeof(Interval));
                var result = Run(includedIn);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void IncludedIn_Year()
        {
            var library = MakeLibrary(@"
                library IncludedInTest version '1.0.0'

                define private IncludedIn_Year: Interval[@2023, @2030] included in year of Interval[@2020, @2030]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(IncludedIn));
            {
                var includedIn = (IncludedIn)library.statements[0].expression;
                Assert.IsTrue(includedIn.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", includedIn.resultTypeName.Name);
                Assert.IsInstanceOfType(includedIn.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)includedIn.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(includedIn.operand);
                Assert.AreEqual(2, includedIn.operand.Length);
                Assert.IsInstanceOfType(includedIn.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(includedIn.operand[1], typeof(Interval));
                var result = Run(includedIn);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Properly_During()
        {
            var library = MakeLibrary(@"
                library IncludedInTest version '1.0.0'

                define private Properly_During: Interval[@2023, @2030] properly during Interval[@2020, @2031]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ProperIncludedIn));
            {
                var includedIn = (ProperIncludedIn)library.statements[0].expression;
                Assert.IsFalse(includedIn.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", includedIn.resultTypeName.Name);
                Assert.IsInstanceOfType(includedIn.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)includedIn.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(includedIn.operand);
                Assert.AreEqual(2, includedIn.operand.Length);
                Assert.IsInstanceOfType(includedIn.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(includedIn.operand[1], typeof(Interval));
                var result = Run(includedIn);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Properly_IncludedIn()
        {
            var library = MakeLibrary(@"
                library IncludedInTest version '1.0.0'

                define private Properly_IncludedIn: Interval[@2023, @2030] properly included in Interval[@2020, @2031]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ProperIncludedIn));
            {
                var includedIn = (ProperIncludedIn)library.statements[0].expression;
                Assert.IsFalse(includedIn.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", includedIn.resultTypeName.Name);
                Assert.IsInstanceOfType(includedIn.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)includedIn.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(includedIn.operand);
                Assert.AreEqual(2, includedIn.operand.Length);
                Assert.IsInstanceOfType(includedIn.operand[0], typeof(Interval));
                Assert.IsInstanceOfType(includedIn.operand[1], typeof(Interval));
                var result = Run(includedIn);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Starts_During()
        {
            var library = MakeLibrary(@"
                library IncludedInTest version '1.0.0'

                define private Starts_During: Interval[@2023, @2030] starts during Interval[@2020, @2030]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(In));
            {
                var @in = (In)library.statements[0].expression;
                Assert.IsFalse(@in.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", @in.resultTypeName.Name);
                Assert.IsInstanceOfType(@in.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)@in.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(@in.operand);
                Assert.AreEqual(2, @in.operand.Length);
                Assert.IsInstanceOfType(@in.operand[0], typeof(Start));
                Assert.IsInstanceOfType(@in.operand[1], typeof(Interval));
                var result = Run(@in);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Starts_IncludedIn()
        {
            var library = MakeLibrary(@"
                library IncludedInTest version '1.0.0'

                define private Starts_During: Interval[@2023, @2030] starts included in Interval[@2020, @2030]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(In));
            {
                var @in = (In)library.statements[0].expression;
                Assert.IsFalse(@in.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", @in.resultTypeName.Name);
                Assert.IsInstanceOfType(@in.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)@in.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(@in.operand);
                Assert.AreEqual(2, @in.operand.Length);
                Assert.IsInstanceOfType(@in.operand[0], typeof(Start));
                Assert.IsInstanceOfType(@in.operand[1], typeof(Interval));
                var result = Run(@in);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Starts_Properly_During()
        {
            var library = MakeLibrary(@"
                library IncludedInTest version '1.0.0'

                define private Starts_Properly_During_Year: Interval[@2023, @2030] starts properly during Interval[@2020, @2030]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ProperIn));
            {
                var properIn = (ProperIn)library.statements[0].expression;
                Assert.IsFalse(properIn.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", properIn.resultTypeName.Name);
                Assert.IsInstanceOfType(properIn.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)properIn.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(properIn.operand);
                Assert.AreEqual(2, properIn.operand.Length);
                Assert.IsInstanceOfType(properIn.operand[0], typeof(Start));
                Assert.IsInstanceOfType(properIn.operand[1], typeof(Interval));
                var result = Run(properIn);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }
        [TestMethod]
        public void Starts_Properly_IncludedIn()
        {
            var library = MakeLibrary(@"
                library IncludedInTest version '1.0.0'

                define private Starts_Properly_IncludedIn: Interval[@2023, @2030] starts properly included in Interval[@2020, @2030]
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(ProperIn));
            {
                var properIn = (ProperIn)library.statements[0].expression;
                Assert.IsFalse(properIn.precisionSpecified);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", properIn.resultTypeName.Name);
                Assert.IsInstanceOfType(properIn.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                Assert.AreEqual($"{{{SystemUri}}}Boolean", ((NamedTypeSpecifier)properIn.resultTypeSpecifier).name.Name);
                Assert.IsNotNull(properIn.operand);
                Assert.AreEqual(2, properIn.operand.Length);
                Assert.IsInstanceOfType(properIn.operand[0], typeof(Start));
                Assert.IsInstanceOfType(properIn.operand[1], typeof(Interval));
                var result = Run(properIn);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }
    }
}
