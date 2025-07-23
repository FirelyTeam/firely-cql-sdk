/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class StartsEndsTest : Base
    {
        [TestMethod]
        public void Starts_False()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library StartsEndsTest version '1.0.0'

                define private Starts_False: Interval[@2023-01-01, @2023-06-30] starts Interval[@2023-04-01, @2023-04-30]
                """);
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
                var result = Run(starts, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Starts_True()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library StartsEndsTest version '1.0.0'

                define private Starts_True: Interval[0, 5] starts Interval[0,7]
                """);
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
                var result = Run(starts, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Ends_False()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library StartsEndsTest version '1.0.0'

                define private Ends_False: Interval[-1, 7] ends Interval[0,7]
                """);
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
                var result = Run(ends, library);
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }
    }
}
