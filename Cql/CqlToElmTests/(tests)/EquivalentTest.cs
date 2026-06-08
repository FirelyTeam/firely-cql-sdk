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
    public class EquivalentTest : Base
    {
        #region Integer

        [TestMethod]
        public void Integer_EquivalentTo_Integer()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Integer_EquivalentTo_Integer: 1 ~ 1
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Integer_EquivalentTo_Integer_False()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Integer_EquivalentTo_Integer_False: 1 ~ 2
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Integer_EquivalentTo_Long()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Integer_EquivalentTo_Long: 1 ~ 1L
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as ToLong;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Integer_EquivalentTo_Decimal_False()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Integer_EquivalentTo_Decimal_False: 1 ~ 2.01
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as ToDecimal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Integer_EquivalentTo_Quantity()
        {
            // 1 converts to 1.0 '1' and '1' units are equal to all units
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Integer_EquivalentTo_Quantity: 1 ~ 1.0 'g'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as ToQuantity;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Integer_EquivalentTo_Quantity_False()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Integer_EquivalentTo_Quantity_False: 1 ~ 2.0 '1'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as ToQuantity;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Integer_EquivalentTo_Null()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("1 ~ null");
            var equal = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equivalent>();
            AssertResult(equal, false);
        }

        [TestMethod]
        public void Null_EquivalentTo_Integer()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("null ~ 1");
            var equal = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equivalent>();
            AssertResult(equal, false);
        }

        #endregion

        #region Long

        [TestMethod]
        public void Long_EquivalentTo_Long()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Long_EquivalentTo_Long: 1L ~ 1L
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Long_EquivalentTo_Long_False()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Long_EquivalentTo_Long_False: 1L ~ 2L
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Long_EquivalentTo_Integer()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Long_EquivalentTo_Long: 1L ~ 1
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as ToLong;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Long_EquivalentTo_Decimal_False()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Long_EquivalentTo_Decimal_False: 1L ~ 2.0
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as ToDecimal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Long_EquivalentTo_Quantity()
        {
            // 1L converts to 1.0 '1' and '1' units are equal to all units
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Long_EquivalentTo_Quantity: 1L ~ 1.0 'g'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as ToQuantity;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Long_EquivalentTo_Quantity_False()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Long_EquivalentTo_Quantity_False: 1L ~ 2 '1'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as ToQuantity;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Long_EquivalentTo_Null()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("1L ~ null");
            var equal = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equivalent>();
            AssertResult(equal, false);
        }

        [TestMethod]
        public void Null_EquivalentTo_Long()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("null ~ 1L");
            var equal = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equivalent>();
            AssertResult(equal, false);
        }

        #endregion

        #region Decimal

        [TestMethod]
        public void Decimal_EquivalentTo_Decimal()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Decimal_EquivalentTo_Decimal: 1.0 ~ 1.0
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Decimal_EquivalentTo_Decimal_False()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Decimal_EquivalentTo_Decimal_False: 1.0 ~ 2.0
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Decimal_EquivalentTo_Integer()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Decimal_EquivalentTo_Decimal: 1.0 ~ 1
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as ToDecimal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Decimal_EquivalentTo_Long_False()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Decimal_EquivalentTo_Long_False: 2.0 ~ 1L
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as ToDecimal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Decimal_EquivalentTo_Quantity()
        {
            // 1.0 converts to 1.0 '1' and '1' units are equal to all units
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Decimal_EquivalentTo_Quantity: 1.0 ~ 1.0 'g'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as ToQuantity;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Decimal_EquivalentTo_Quantity_False()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Decimal_EquivalentTo_Quantity_False: 1.0 ~ 2.0 '1'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as ToQuantity;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Decimal_EquivalentTo_Null()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("1.0 ~ null");
            var equal = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equivalent>();
            AssertResult(equal, false);
        }

        [TestMethod]
        public void Null_EquivalentTo_Decimal()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("null ~ 1.0");
            var equal = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equivalent>();
            AssertResult(equal, false);
        }

        #endregion

        #region Quantity

        [TestMethod]
        public void Quantity_EquivalentTo_Quantity()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Quantity_EquivalentTo_Quantity: 1.0 '1' ~ 1.0 '1'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as Quantity;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Quantity_EquivalentTo_Quantity_False()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Quantity_EquivalentTo_Quantity_False: 1.0 '1' ~ 2.0 '1'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as Quantity;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Quantity_EquivalentTo_Integer()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Quantity_EquivalentTo_Quantity: 1.0 '1' ~ 1
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as Quantity;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as ToQuantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Quantity_EquivalentTo_Long_False()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Quantity_EquivalentTo_Long_False: 2.0 '1' ~ 1L
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as Quantity;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as ToQuantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Quantity_EquivalentTo_Decimal()
        {
            // 1.0 converts to 1.0 '1' and '1' units are equal to all units
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private Quantity_EquivalentTo_Decimal: 1.0 'g' ~ 1.0
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as Quantity;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as ToQuantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Quantity_EquivalentTo_Null()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("1.0 '1' ~ null");
            var equal = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equivalent>();
            AssertResult(equal, false);
        }

        [TestMethod]
        public void Null_EquivalentTo_Quantity()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("null ~ 1.0 '1'");
            var equal = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equivalent>();
            AssertResult(equal, false);
        }

        #endregion

        #region String

        [TestMethod]
        public void String_EquivalentTo_String()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library EqualsTest version '1.0.0'

                define private String_EquivalentTo_String: 'hello' ~ 'hello'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Equivalent));
            {
                var equal = (Equivalent)library.statements[0].expression;
                Assert.IsNotNull(equal.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", equal.resultTypeName.Name);
                Assert.IsNotNull(equal.resultTypeSpecifier);
                Assert.IsInstanceOfType(equal.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)equal.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(equal.operand);
                Assert.AreEqual(2, equal.operand.Length);
                {
                    var lhs = equal.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}String", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}String", lhsnts.name.Name);
                }
                {
                    var rhs = equal.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}String", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}String", rhsnts.name.Name);
                }

                var lambda = CreateElmToolkit().Lambda(equal);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void String_EquivalentTo_Null()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("'hello' ~ null");
            var equal = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equivalent>();
            AssertResult(equal, false);
        }

        [TestMethod]
        public void Null_EquivalentTo_String()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("null ~ 'hello'");
            var equal = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Equivalent>();
            AssertResult(equal, false);
        }

        #endregion

        #region Code and Concept

        [TestMethod]
        public void Concept_EquivalentTo_Code()
        {
            var cqlToolkit = CreateCqlToolkit();
            var library = cqlToolkit.MakeLibrary("""
                 library EqualsTest version '1.0.0'
                 using FHIR version '4.0.1'

                 define "Code1": Code { system: 'http://loinc.org', code: '8480-6', display: 'Systolic blood pressure' }

                 define "Concept1":
                    Concept {
                        codes: { "Code1" },
                        display: 'Concept1'
                    }

                 define "AreEquivalent": "Concept1" ~ "Code1"
                 """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(3, library.statements.Length);
        }

        [TestMethod]
        public void FhirCodeableConcept_EquivalentTo_Concept()
        {
            var cqlToolkit = CreateCqlToolkit().AddFHIRHelpers();
            var library = cqlToolkit.MakeLibrary("""
                 library EqualsTest version '1.0.0'
                 using FHIR version '4.0.1'

                 include FHIRHelpers version '4.0.1'

                 define "Fhir Codeable Concept":
                    FHIR.CodeableConcept {
                        coding: {
                            FHIR.Coding {
                                system: FHIR.uri {value: 'http://loinc.org'},
                                code: FHIR.code {value: '8480-6'},
                                display: FHIR.string { value: 'Systolic blood pressure'}
                            }
                        },
                        text: FHIR.string{value: 'FhirCodeableConcept'}
                    }

                 define "Concept1":
                     Concept {
                         codes: {
                            Code { system: 'http://loinc.org', code: '8480-6', display: 'Systolic blood pressure' }
                         },
                         display: 'Concept1'
                     }

                 define "AreEquivalent": "Fhir Codeable Concept" ~ "Concept1"
                 """);
            Assert.IsNotNull(library.statements);
        }

        [TestMethod]
        [Ignore("Will fix in https://github.com/FirelyTeam/firely-cql-sdk/issues/788")]
        public void FhirCodeableConcept_EquivalentTo_Code()
        {
            var cqlToolkit = CreateCqlToolkit().AddFHIRHelpers();
            var library = cqlToolkit.MakeLibrary("""
                 library EqualsTest version '1.0.0'
                 using FHIR version '4.0.1'

                 include FHIRHelpers version '4.0.1'

                 define "Fhir Codeable Concept":
                    FHIR.CodeableConcept {
                        coding: {
                            FHIR.Coding {
                                system: FHIR.uri {value: 'http://loinc.org'},
                                code: FHIR.code {value: '8480-6'},
                                display: FHIR.string { value: 'Systolic blood pressure'}
                            }
                        },
                        text: FHIR.string{value: 'FhirCodeableConcept'}
                    }

                 define "Code1": Code { system: 'http://loinc.org', code: '8480-6', display: 'Systolic blood pressure' }

                 define "AreEquivalent": "Fhir Codeable Concept" ~ "Code1"
                 """);
            Assert.IsNotNull(library.statements);
        }

        [TestMethod]
        public void FhirCodeableConcept_EquivalentTo_Concept_ResolvesToEquivalent()
        {
            var cqlToolkit = CreateCqlToolkit().AddFHIRHelpers();
            var library = cqlToolkit.MakeLibrary("""
                 library EqualsTest version '1.0.0'
                 using FHIR version '4.0.1'

                 include FHIRHelpers version '4.0.1'

                 define "Fhir Codeable Concept":
                    FHIR.CodeableConcept {
                        coding: {
                            FHIR.Coding {
                                system: FHIR.uri {value: 'http://loinc.org'},
                                code: FHIR.code {value: '8480-6'},
                                display: FHIR.string { value: 'Systolic blood pressure'}
                            }
                        },
                        text: FHIR.string{value: 'FhirCodeableConcept'}
                    }

                 define "Concept1":
                     Concept {
                         codes: {
                            Code { system: 'http://loinc.org', code: '8480-6', display: 'Systolic blood pressure' }
                         },
                         display: 'Concept1'
                     }

                 define "AreEquivalent": "Fhir Codeable Concept" ~ "Concept1"
                 """);
            // MakeLibrary already asserts the translation reported no errors. Verify
            // the FHIR.CodeableConcept vs Concept type mismatch resolved to Equivalent
            // rather than producing an unresolved-operator error.
            var areEquivalent = library.ShouldDefine<ExpressionDef>("AreEquivalent");
            areEquivalent.expression.Should().BeOfType<Equivalent>();
        }

        [TestMethod]
        public void FhirCode_EquivalentTo_CqlCode_String()
        {
            var cqlToolkit = CreateCqlToolkit();
            var library = cqlToolkit.MakeLibrary("""
                 library EqualsTest version '1.0.0'
                 using FHIR version '4.0.1'

                 define "Test Code Equivalence": true
                 """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
        }

        #endregion
    }
}
