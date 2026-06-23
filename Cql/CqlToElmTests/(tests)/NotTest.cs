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
    public class NotTest : Base
    {
        [TestMethod]
        public void Not_True()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library NotTest version '1.0.0'

                define private Not_True: not true
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Not));
            {
                var not = (Not)library.statements[0].expression;
                Assert.IsNotNull(not.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", not.resultTypeName.Name);
                Assert.IsNotNull(not.resultTypeSpecifier);
                Assert.IsInstanceOfType(not.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)not.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(not.operand);
                {
                    Assert.IsInstanceOfType(not.operand, typeof(Literal));
                    var operand = not.operand as Literal;
                    Assert.IsNotNull(operand!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", operand.resultTypeName.Name);
                    Assert.IsNotNull(operand.resultTypeSpecifier);
                    Assert.IsInstanceOfType(operand.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)operand.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", lhsnts.name.Name);
                }


                var result = Run(not, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Not_False()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library NotTest version '1.0.0'

                define private Not_False: not false
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Not));
            {
                var not = (Not)library.statements[0].expression;
                Assert.IsNotNull(not.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", not.resultTypeName.Name);
                Assert.IsNotNull(not.resultTypeSpecifier);
                Assert.IsInstanceOfType(not.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)not.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(not.operand);
                {
                    var operand = not.operand as Literal;
                    Assert.IsNotNull(operand!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", operand.resultTypeName.Name);
                    Assert.IsNotNull(operand.resultTypeSpecifier);
                    Assert.IsInstanceOfType(operand.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)operand.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", lhsnts.name.Name);
                }


                var result = Run(not, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Not_Null()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library NotTest version '1.0.0'

                define private Not_Null: not null
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Not));
            {
                var not = (Not)library.statements[0].expression;
                Assert.IsNotNull(not.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", not.resultTypeName.Name);
                Assert.IsNotNull(not.resultTypeSpecifier);
                Assert.IsInstanceOfType(not.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)not.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(not.operand);
                {
                    var operand = not.operand as As;
                    Assert.IsNotNull(operand!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", operand.resultTypeName.Name);
                    Assert.IsNotNull(operand.resultTypeSpecifier);
                    Assert.IsInstanceOfType(operand.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)operand.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", lhsnts.name.Name);
                }


                var result = Run(not, library, FhirCqlContext.ForBundle());
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Not_1() =>
            CreateCqlToolkit().MakeLibrary("""
                library NotTest version '1.0.0'

                define private Not_1: not 1
                """, "Could not resolve*");
    }
}
