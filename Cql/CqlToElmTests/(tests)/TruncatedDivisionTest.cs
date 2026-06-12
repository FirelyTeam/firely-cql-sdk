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
    public class TruncatedDivisionTest : Base
    {
        #region Integer

        [TestMethod]
        public void TruncatedDivideIntegerByInteger()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideIntegerByInteger version '1.0.0'

                define private TruncatedDivideIntegerByInteger: 2 div 4
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Integer", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as Literal;
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
                    var rhs = divide.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhsnts.name.Name);
                }

                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(0, result);
            }
        }

        [TestMethod]
        public void TruncatedDivideIntegerByLong()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideIntegerByLong version '1.0.0'

                define private TruncatedDivideIntegerByLong: 2 div 3L
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Long", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as ToLong;
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
                    var rhs = divide.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhsnts.name.Name);
                }

                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(long?));
                Assert.AreEqual(0L, result);
            }
        }

        [TestMethod]
        public void TruncatedDivideIntegerByDecimal()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideIntegerByDecimal version '1.0.0'

                define private TruncatedDivideIntegerByDecimal: 2 div 3.0
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as ToDecimal;
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
                    var rhs = divide.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(0m, result);
            }
        }

        [TestMethod]
        public void TruncatedDivideIntegerByQuantity()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideIntegerByQuantity version '1.0.0'

                define private TruncatedDivideIntegerByQuantity: 10 div 2.0 '1'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as ToQuantity;
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
                    var rhs = divide.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(5.0m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);

            }
        }

        [TestMethod]
        public void TruncatedDivideIntegerByNull()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideIntegerByNull version '1.0.0'

                define private TruncatedDivideIntegerByNull: 1 div null
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Integer", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as Literal;
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
                    var rhs = divide.operand[1] as As;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", lhsnts.name.Name);
                }
                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        [TestMethod]
        public void TruncatedDivideNullByInteger()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideNullByInteger version '1.0.0'

                define private TruncatedDivideNullByInteger: null div 1
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Integer", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as As;
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
                    var rhs = divide.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhsnts.name.Name);
                }
                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        #endregion

        #region Long

        [TestMethod]
        public void TruncatedDivideLongByInteger()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideLongByInteger version '1.0.0'

                define private TruncatedDivideLongByInteger: 10L div 2
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Long", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as Literal;
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
                    var rhs = divide.operand[1] as ToLong;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhsnts.name.Name);
                }

                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(long?));
                Assert.AreEqual(5L, result);
            }
        }

        [TestMethod]
        public void TruncatedDivideLongByLong()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideLongByLong version '1.0.0'

                define private TruncatedDivideLongByLong: 100L div 10L
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Long", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as Literal;
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
                    var rhs = divide.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhsnts.name.Name);
                }

                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(long?));
                Assert.AreEqual(10L, result);
            }
        }

        [TestMethod]
        public void TruncatedDivideLongByDecimal()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideLongByDecimal version '1.0.0'

                define private TruncatedDivideLongByDecimal: -3L div 2.0
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as ToDecimal;
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
                    var rhs = divide.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(-1m, result);
            }
        }

        [TestMethod]
        public void TruncatedDivideLongByQuantity()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideLongByQuantity version '1.0.0'

                define private TruncatedDivideLongByQuantity: 20L div 5.0 '1'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as ToQuantity;
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
                    var rhs = divide.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(4.0m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }
        }

        [TestMethod]
        public void TruncatedDivideLongByNull()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideLongByNull version '1.0.0'

                define private TruncatedDivideLongByNull: 1L div null
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Long", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as Literal;
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
                    var rhs = divide.operand[1] as As;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", lhsnts.name.Name);
                }
                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        [TestMethod]
        public void TruncatedDivideNullByLong()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideNullByLong version '1.0.0'

                define private TruncatedDivideNullByLong: null div 1L
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Long", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as As;
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
                    var rhs = divide.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhsnts.name.Name);
                }
                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        #endregion

        #region Decimal

        [TestMethod]
        public void TruncatedDivideDecimalByInteger()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideDecimalByInteger version '1.0.0'

                define private TruncatedDivideDecimalByInteger: 0.0 div 3
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as Literal;
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
                    var rhs = divide.operand[1] as ToDecimal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(0m, result);
            }
        }

        [TestMethod]
        public void TruncatedDivideDecimalByLong()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library DefaultConverter version '1.0.0'

                define private DefaultConverter: 5.0 div 5L
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as Literal;
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
                    var rhs = divide.operand[1] as ToDecimal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(1m, result);
            }
        }

        [TestMethod]
        public void TruncatedDivideDecimalByDecimal()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideDecimalByDecimal version '1.0.0'

                define private TruncatedDivideDecimalByDecimal: -10.0 div 10.0
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as Literal;
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
                    var rhs = divide.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(-1.0m, result);
            }
        }

        [TestMethod]
        public void TruncatedDivideDecimalByQuantity()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideDecimalByQuantity version '1.0.0'

                define private TruncatedDivideDecimalByQuantity: 3.0 div 2.0 '1'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as ToQuantity;
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
                    var rhs = divide.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(1.0m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }
        }

        [TestMethod]
        public void TruncatedDivideDecimalByNull()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideDecimalByNull version '1.0.0'

                define private TruncatedDivideDecimalByNull: 1.0 div null
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as Literal;
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
                    var rhs = divide.operand[1] as As;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", lhsnts.name.Name);
                }
                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        [TestMethod]
        public void TruncatedDivideNullByDecimal()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideNullByDecimal version '1.0.0'

                define private TruncatedDivideNullByDecimal: null div 1.0
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as As;
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
                    var rhs = divide.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }
                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        #endregion

        #region Quantity

        [TestMethod]
        public void TruncatedDivideQuantityByQuantity()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideQuantityByQuantity version '1.0.0'

                define private TruncatedDivideQuantityByQuantity: 3.0 '1' div 2.0 '1'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as Quantity;
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
                    var rhs = divide.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(1m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }
        }

        [TestMethod]
        public void TruncatedDivideQuantityByNull()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideQuantityByNull version '1.0.0'

                define private TruncatedDivideQuantityByNull: 3.0 '1' div null
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as Quantity;
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
                    var rhs = divide.operand[1] as As;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void TruncatedDivideNullByQuantity()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library TruncatedDivideNullByQuantity version '1.0.0'

                define private TruncatedDivideNullByQuantity: null div 3.0 '1'
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(TruncatedDivide));
            {
                var divide = (TruncatedDivide)library.statements[0].expression;
                Assert.IsNotNull(divide.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", divide.resultTypeName.Name);
                Assert.IsNotNull(divide.resultTypeSpecifier);
                Assert.IsInstanceOfType(divide.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)divide.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(divide.operand);
                Assert.AreEqual(2, divide.operand.Length);
                {
                    var lhs = divide.operand[0] as As;
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
                    var rhs = divide.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var result = Run(divide, library, FhirCqlContext.ForBundle());
                Assert.IsNull(result);
            }
        }

        #endregion

    }
}
