/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class MultiplicationTest : Base
    {
        #region Integer

        [TestMethod]
        public void MultiplyIntegerByInteger()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyIntegerByInteger version '1.0.0'

                define private Multiply_Integer_to_Integer: 2 * 3
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Integer", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as Literal;
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
                    var rhs = multiply.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhsnts.name.Name);
                }

                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(6, result);
            }
        }

        [TestMethod]
        public void MultiplyIntegerByLong()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyIntegerByLong version '1.0.0'

                define private Multiply_Integer_to_Integer: 2 * 3L
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Long", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as ToLong;
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
                    var rhs = multiply.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhsnts.name.Name);
                }

                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(long?));
                Assert.AreEqual(6L, result);
            }
        }

        [TestMethod]
        public void MultiplyIntegerByDecimal()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyIntegerByDecimal version '1.0.0'

                define private Multiply_Integer_to_Integer: 2 * 3.0
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as ToDecimal;
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
                    var rhs = multiply.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(6.0m, result);
            }
        }

        [TestMethod]
        public void MultiplyIntegerByQuantity()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyIntegerByQuantity version '1.0.0'

                define private MultiplyIntegerByQuantity: 2 * 3.0 '1'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as ToQuantity;
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
                    var rhs = multiply.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(6.0m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);

            }
        }

        [TestMethod]
        public void MultiplyIntegerByNull()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyIntegerByNull version '1.0.0'

                define private Product: 1 * null
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Integer", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhsnts.name.Name);
                }
                {
                    var rhs = multiply.operand[1] as As;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", lhsnts.name.Name);
                }
                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        [TestMethod]
        public void MultiplyNullByInteger()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyIntegerByNull version '1.0.0'

                define private Product: null * 1
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Integer", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as As;
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
                    var rhs = multiply.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhsnts.name.Name);
                }
                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        #endregion

        #region Long

        [TestMethod]
        public void MultiplyLongByInteger()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyLongByInteger version '1.0.0'

                define private Multiply_Integer_to_Integer: -2L * 3
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Long", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as Literal;
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
                    var rhs = multiply.operand[1] as ToLong;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhsnts.name.Name);
                }

                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(long?));
                Assert.AreEqual(-6L, result);
            }
        }

        [TestMethod]
        public void MultiplyLongByLong()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyLongByInteger version '1.0.0'

                define private Multiply_Integer_to_Integer: -2L * 3L
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Long", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as Literal;
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
                    var rhs = multiply.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhsnts.name.Name);
                }

                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(long?));
                Assert.AreEqual(-6L, result);
            }
        }

        [TestMethod]
        public void MultiplyLongByDecimal()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyLongByInteger version '1.0.0'

                define private Multiply_Integer_to_Integer: -2L * 3.0
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as ToDecimal;
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
                    var rhs = multiply.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(-6.0m, result);
            }
        }

        [TestMethod]
        public void MultiplyLongByQuantity()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyIntegerByQuantity version '1.0.0'

                define private MultiplyIntegerByQuantity: 2L * 3.0 '1'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as ToQuantity;
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
                    var rhs = multiply.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(6.0m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }
        }

        [TestMethod]
        public void MultiplyLongByNull()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyLongByNull version '1.0.0'

                define private Product: 1L * null
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Long", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhsnts.name.Name);
                }
                {
                    var rhs = multiply.operand[1] as As;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", lhsnts.name.Name);
                }
                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        [TestMethod]
        public void MultiplyNullByLong()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyIntegerByNull version '1.0.0'

                define private Product: null * 1L
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Long", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as As;
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
                    var rhs = multiply.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhsnts.name.Name);
                }
                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        #endregion

        #region Decimal

        [TestMethod]
        public void MultiplyDecimalByInteger()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyDecimalByInteger version '1.0.0'

                define private Multiply_Integer_to_Integer: 0.0 * 3
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as Literal;
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
                    var rhs = multiply.operand[1] as ToDecimal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(0m, result);
            }
        }

        [TestMethod]
        public void MultiplyDecimalByLong()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyDecimalByInteger version '1.0.0'

                define private Multiply_Integer_to_Integer: 5.0 * 5L
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as Literal;
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
                    var rhs = multiply.operand[1] as ToDecimal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(25m, result);
            }
        }

        [TestMethod]
        public void MultiplyDecimalByDecimal()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyDecimalByInteger version '1.0.0'

                define private Multiply_Integer_to_Integer: -10.0 * 10.0
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as Literal;
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
                    var rhs = multiply.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(-100.0m, result);
            }
        }

        [TestMethod]
        public void MultiplyDecimalByQuantity()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyIntegerByQuantity version '1.0.0'

                define private MultiplyIntegerByQuantity: 2.0 * 3.0 '1'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as ToQuantity;
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
                    var rhs = multiply.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(6.0m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }
        }

        [TestMethod]
        public void MultiplyDecimalByNull()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyDecimalByNull version '1.0.0'

                define private Product: 1.0 * null
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }
                {
                    var rhs = multiply.operand[1] as As;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", lhsnts.name.Name);
                }
                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        [TestMethod]
        public void MultiplyNullByDecimal()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyIntegerByNull version '1.0.0'

                define private Product: null * 1.0
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as As;
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
                    var rhs = multiply.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }
                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        #endregion

        #region Quantity

        [TestMethod]
        public void MultiplyQuantityByQuantity()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyQuantityByQuantity version '1.0.0'

                define private MultiplyQuantityByQuantity: 3.0 '1' * 2.0 '1'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as Quantity;
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
                    var rhs = multiply.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(6m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }
        }

        [TestMethod]
        public void MultiplyQuantityByNull()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyQuantityByNull version '1.0.0'

                define private MultiplyQuantityByNull: 3.0 '1' * null
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as Quantity;
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
                    var rhs = multiply.operand[1] as As;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void MultiplyNullByQuantity()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library MultiplyNullByQuantity version '1.0.0'

                define private MultiplyNullByQuantity: null * 3.0 '1'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Multiply));
            {
                var multiply = (Multiply)library.statements[0].expression;
                Assert.IsNotNull(multiply.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", multiply.resultTypeName.Name);
                Assert.IsNotNull(multiply.resultTypeSpecifier);
                Assert.IsInstanceOfType(multiply.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)multiply.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(multiply.operand);
                Assert.AreEqual(2, multiply.operand.Length);
                {
                    var lhs = multiply.operand[0] as As;
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
                    var rhs = multiply.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var result = Run(multiply, library, FhirCqlContext.ForBundle());
                Assert.IsNull(result);
            }
        }

        #endregion

    }
}
