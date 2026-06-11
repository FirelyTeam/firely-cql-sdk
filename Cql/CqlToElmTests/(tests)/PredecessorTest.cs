/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;

namespace Hl7.Cql.CqlToElm.Test
{

    [TestClass]
    public class PredecessorTest : Base
    {
        [TestMethod]
        public void Predecessor_Integer()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library PointFromTest version '1.0.0'

                define private Point_From_Integers: predecessor of 2
                """);
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


                var ctx = FhirCqlContext.ForBundle();
                var result = Run(predecessor, library, ctx);
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(1, result);
            }
        }

        [TestMethod]
        public void Predecessor_Null()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library PointFromTest version '1.0.0'

                define private Point_From_Integers: predecessor of (null as Integer)
                """);
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


                var ctx = FhirCqlContext.ForBundle();
                var result = Run(predecessor, library, ctx);
                Assert.IsNull(result);
            }
        }

    }
}
