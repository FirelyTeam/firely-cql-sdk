using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class TruncatedDivisionTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        #region Integer

        [TestMethod]
        public void TruncatedDivide_Integer_by_Integer()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Integer_by_Integer version '1.0.0'

                define private TruncatedDivide_Integer_by_Integer: 2 div 4
            ");
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

                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(0, result);
            }
        }

        [TestMethod]
        public void TruncatedDivide_Integer_by_Long()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Integer_by_Long version '1.0.0'

                define private TruncatedDivide_Integer_by_Long: 2 div 3L
            ");
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

                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(long?));
                Assert.AreEqual(0L, result);
            }
        }

        [TestMethod]
        public void TruncatedDivide_Integer_by_Decimal()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Integer_by_Decimal version '1.0.0'

                define private TruncatedDivide_Integer_by_Decimal: 2 div 3.0
            ");
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

                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(0m, result);
            }
        }

        [TestMethod]
        public void TruncatedDivide_Integer_by_Quantity()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Integer_by_Quantity version '1.0.0'

                define private TruncatedDivide_Integer_by_Quantity: 10 div 2.0 '1'
            ");
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

                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(5.0m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);

            }
        }

        [TestMethod]
        public void TruncatedDivide_Integer_by_Null()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Integer_by_Null version '1.0.0'

                define private TruncatedDivide_Integer_by_Null: 1 div null
            ");
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
                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        [TestMethod]
        public void TruncatedDivide_Null_by_Integer()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Null_by_Integer version '1.0.0'

                define private TruncatedDivide_Null_by_Integer: null div 1
            ");
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
                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        #endregion

        #region Long

        [TestMethod]
        public void TruncatedDivide_Long_by_Integer()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Long_by_Integer version '1.0.0'

                define private TruncatedDivide_Long_by_Integer: 10L div 2
            ");
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

                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(long?));
                Assert.AreEqual(5L, result);
            }
        }

        [TestMethod]
        public void TruncatedDivide_Long_by_Long()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Long_by_Long version '1.0.0'

                define private TruncatedDivide_Long_by_Long: 100L div 10L
            ");
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

                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(long?));
                Assert.AreEqual(10L, result);
            }
        }

        [TestMethod]
        public void TruncatedDivide_Long_by_Decimal()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Long_by_Decimal version '1.0.0'

                define private TruncatedDivide_Long_by_Decimal: -3L div 2.0
            ");
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

                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(-1m, result);
            }
        }

        [TestMethod]
        public void TruncatedDivide_Long_by_Quantity()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Long_by_Quantity version '1.0.0'

                define private TruncatedDivide_Long_by_Quantity: 20L div 5.0 '1'
            ");
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

                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(4.0m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }
        }

        [TestMethod]
        public void TruncatedDivide_Long_by_Null()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Long_by_Null version '1.0.0'

                define private TruncatedDivide_Long_by_Null: 1L div null
            ");
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
                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        [TestMethod]
        public void TruncatedDivide_Null_by_Long()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Null_by_Long version '1.0.0'

                define private TruncatedDivide_Null_by_Long: null div 1L
            ");
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
                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        #endregion

        #region Decimal

        [TestMethod]
        public void TruncatedDivide_Decimal_by_Integer()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Decimal_by_Integer version '1.0.0'

                define private TruncatedDivide_Decimal_by_Integer: 0.0 div 3
            ");
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

                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(0m, result);
            }
        }

        [TestMethod]
        public void TruncatedDivide_Decimal_by_Long()
        {
            var library = MakeLibrary(@"
                library DefaultConverter version '1.0.0'

                define private DefaultConverter: 5.0 div 5L
            ");
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

                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(1m, result);
            }
        }

        [TestMethod]
        public void TruncatedDivide_Decimal_by_Decimal()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Decimal_by_Decimal version '1.0.0'

                define private TruncatedDivide_Decimal_by_Decimal: -10.0 div 10.0
            ");
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

                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(-1.0m, result);
            }
        }

        [TestMethod]
        public void TruncatedDivide_Decimal_by_Quantity()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Decimal_by_Quantity version '1.0.0'

                define private TruncatedDivide_Decimal_by_Quantity: 3.0 div 2.0 '1'
            ");
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

                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(1.0m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }
        }

        [TestMethod]
        public void TruncatedDivide_Decimal_by_Null()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Decimal_by_Null version '1.0.0'

                define private TruncatedDivide_Decimal_by_Null: 1.0 div null
            ");
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
                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        [TestMethod]
        public void TruncatedDivide_Null_by_Decimal()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Null_by_Decimal version '1.0.0'

                define private TruncatedDivide_Null_by_Decimal: null div 1.0
            ");
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
                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        #endregion

        #region Quantity

        [TestMethod]
        public void TruncatedDivide_Quantity_by_Quantity()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Quantity_by_Quantity version '1.0.0'

                define private TruncatedDivide_Quantity_by_Quantity: 3.0 '1' div 2.0 '1'
            ");
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

                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(1m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }
        }

        [TestMethod]
        public void TruncatedDivide_Quantity_by_Null()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Quantity_by_Null version '1.0.0'

                define private TruncatedDivide_Quantity_by_Null: 3.0 '1' div null
            ");
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

                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void TruncatedDivide_Null_by_Quantity()
        {
            var library = MakeLibrary(@"
                library TruncatedDivide_Null_by_Quantity version '1.0.0'

                define private TruncatedDivide_Null_by_Quantity: null div 3.0 '1'
            ");
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

                var lambda = LibraryExpressionBuilder.Lambda(divide);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNull(result);
            }
        }

        #endregion

    }
}
