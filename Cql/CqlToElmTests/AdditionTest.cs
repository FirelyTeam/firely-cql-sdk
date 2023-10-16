using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class AdditionTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        #region Same type

        [TestMethod]
        public void Add_Integer_to_Integer()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Integer_to_Integer version '1.0.0'

                define private Three: 1 + 2
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Integer", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", lhsnts.name.Name);
                    Assert.AreEqual("1", lhs.value);
                }
                {
                    var rhs = add.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhsnts.name.Name);
                    Assert.AreEqual("2", rhs.value);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(3, result);
            }
        }

        [TestMethod]
        public void Add_Long_to_Long()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Long_to_Long version '1.0.0'

                define private Three: 1L + 2L
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Long", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", lhsnts.name.Name);
                    Assert.AreEqual("1", lhs.value);
                }
                {
                    var rhs = add.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhsnts.name.Name);
                    Assert.AreEqual("2", rhs.value);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(long?));
                Assert.AreEqual(3L, result);
            }
        }

        [TestMethod]
        public void Add_Decimal_to_Decimal()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Decimal_to_Decimal version '1.0.0'

                define private Three: -1.0 + 2.0
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", lhsnts.name.Name);
                    Assert.AreEqual("-1.0", lhs.value);

                }
                {
                    var rhs = add.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                    Assert.AreEqual("2.0", rhs.value);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(1.0m, result);
            }
        }

        [TestMethod]
        public void Add_Quantity_to_Quantity()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Decimal_to_Quantity version '1.0.0'

                define private Three: -1.0 '1' + 2.0 '1'
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Quantity;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", lhsnts.name.Name);
                    Assert.AreEqual(-1.0m, lhs.value);
                    Assert.AreEqual(UCUMUnits.Default, lhs.unit);
                }
                {
                    var rhs = add.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                    Assert.AreEqual(2.0m, rhs.value);
                    Assert.AreEqual(UCUMUnits.Default, rhs.unit);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(1.0m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }
        }

        #endregion

        #region Left-hand conversions

        [TestMethod]
        public void Add_Integer_to_Long()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Integer_to_Long version '1.0.0'

                define private Three: 1 + 2L
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Long", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as ToLong;
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
                    var rhs = add.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhsnts.name.Name);
                    Assert.AreEqual("2", rhs.value);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(long?));
                Assert.AreEqual((long?)3, result);
            }



        }

        [TestMethod]
        public void Add_Integer_to_Decimal()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Integer_to_Decimal version '1.0.0'

                define private Three: 1 + 2.0
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as ToDecimal;
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
                    var rhs = add.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                    Assert.AreEqual("2.0", rhs.value);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(3.0m, result);
            }



        }

        [TestMethod]
        public void Add_Integer_to_Quantity()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Integer_to_Quantity version '1.0.0'

                define private Three: 1 + 2.0 '1'
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as ToQuantity;
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
                    var rhs = add.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                    Assert.AreEqual(2.0m, rhs.value);
                    Assert.AreEqual(UCUMUnits.Default, rhs.unit);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(3.0m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }
        }

        [TestMethod]
        public void Add_Long_to_Decimal()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Long_to_Decimal version '1.0.0'

                define private Three: 1L + 2.0
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as ToDecimal;
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
                    var rhs = add.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                    Assert.AreEqual("2.0", rhs.value);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(3.0m, result);
            }



        }

        [TestMethod]
        public void Add_Long_to_Quantity()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Integer_to_Quantity version '1.0.0'

                define private Three: 1L + 2.0 '1'
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as ToQuantity;
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
                    var rhs = add.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                    Assert.AreEqual(2.0m, rhs.value);
                    Assert.AreEqual(UCUMUnits.Default, rhs.unit);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(3.0m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }
        }

        [TestMethod]
        public void Add_Decimal_to_Quantity()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Decimal_to_Quantity version '1.0.0'

                define private Three: -1.0 + 2.0 '1'
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as ToQuantity;
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
                    var rhs = add.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                    Assert.AreEqual(2.0m, rhs.value);
                    Assert.AreEqual(UCUMUnits.Default, rhs.unit);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(1.0m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }



        }

        #endregion

        #region Right-hand conversions

        [TestMethod]
        public void Add_Long_to_Integer()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Long_to_Integer version '1.0.0'

                define private Three: 1L + 2
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Long", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Long", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Literal;
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
                    var rhs = add.operand[1] as ToLong;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Long", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(long?));
                Assert.AreEqual((long?)3, result);
            }
        }

        [TestMethod]
        public void Add_Decimal_to_Integer()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Decimal_to_Integer version '1.0.0'

                define private Three: 5.25 + 2
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Literal;
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
                    var rhs = add.operand[1] as ToDecimal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual((decimal?)7.25, result);
            }
        }

        [TestMethod]
        public void Add_Quantity_to_Integer()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Decimal_to_Integer version '1.0.0'

                define private Three: 5.25 '1' + 2
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Quantity;
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
                    var rhs = add.operand[1] as ToQuantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(7.25m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }
        }

        [TestMethod]
        public void Add_Decimal_to_Long()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Decimal_to_Long version '1.0.0'

                define private Three: 5.25 + 2L
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Literal;
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
                    var rhs = add.operand[1] as ToDecimal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual((decimal?)7.25, result);
            }
        }

        [TestMethod]
        public void Add_Quantity_to_Long()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Quantity_to_Long version '1.0.0'

                define private Three: 5.25 '1' + 2L
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Quantity;
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
                    var rhs = add.operand[1] as ToQuantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(7.25m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }
        }

        [TestMethod]
        public void Add_Quantity_to_Decimal()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Quantity_to_Decimal version '1.0.0'

                define private Three: 5.25 '1' + 2.0
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Quantity;
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
                    var rhs = add.operand[1] as ToQuantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(7.25m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }
        }

        #endregion

        #region Nulls

        [TestMethod]
        public void Add_Null_to_Integer()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Null_to_Integer version '1.0.0'

                define private AddNull: null + 1
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Integer", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as As;
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
                    var rhs = add.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        [TestMethod]
        public void Add_Integer_to_Null()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Null_to_Integer version '1.0.0'

                define private AddNull: 1 + null
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Integer", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Integer", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Literal;
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
                    var rhs = add.operand[1] as As;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Integer", lhsnts.name.Name);
                }
                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.AreEqual(null, result);
            }
        }

        #endregion

        #region Dates/times

        [TestMethod]
        public void Add_Quantity_to_Date()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Quantity_to_Date version '1.0.0'

                define private Three: @2023-01-01 + 1 month
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Date", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Date", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Date;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Date", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Date", lhsnts.name.Name);
                }
                {
                    var rhs = add.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlDate));
                var date = (CqlDate)result;
                Assert.AreEqual(2023, date.Value.Year);
                Assert.AreEqual(2, date.Value.Month);
                Assert.AreEqual(1, date.Value.Day);
            }
        }

        [TestMethod]
        public void Add_Null_to_Date()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Quantity_to_Date version '1.0.0'

                define private Three: @2023-01-01 + null
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Date", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Date", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Date;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Date", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Date", lhsnts.name.Name);
                }
                {

                    var rhs = add.operand[1] as As;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Add_Quantity_to_DateTime()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Quantity_to_DateTime version '1.0.0'

                define private Three: @2023-01-01T01:23:45.300+01:30 + 1 month
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Elm.DateTime;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}DateTime", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}DateTime", lhsnts.name.Name);
                }
                {
                    var rhs = add.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlDateTime));
                var dateTime = (CqlDateTime)result;
                Assert.AreEqual(Iso8601.DateTimePrecision.Millisecond, dateTime.Precision);
                Assert.AreEqual(2023, dateTime.Value.Year);
                Assert.AreEqual(2, dateTime.Value.Month);
                Assert.AreEqual(1, dateTime.Value.Day);
                Assert.AreEqual(1, dateTime.Value.Hour);
                Assert.AreEqual(23, dateTime.Value.Minute);
                Assert.AreEqual(45, dateTime.Value.Second);
                Assert.AreEqual(300, dateTime.Value.Millisecond);
                Assert.AreEqual(1.5m, dateTime.Value.RationalOffset);

            }
        }

        [TestMethod]
        public void Add_Null_to_DateTime()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Null_To_DateTime version '1.0.0'

                define private Three: @2023-01-01T01:23:45.300+01:30 + null
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}DateTime", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Elm.DateTime;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}DateTime", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}DateTime", lhsnts.name.Name);
                }
                {

                    var rhs = add.operand[1] as As;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Add_Quantity_to_Time()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DefaultConverter version '1.0.0'

                define private Three: @T01:23:45 + 1 hour
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Time", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Time", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Elm.Time;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Time", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Time", lhsnts.name.Name);
                }
                {
                    var rhs = add.operand[1] as Quantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlTime));
                var time = (CqlTime)result;
                Assert.AreEqual(Iso8601.DateTimePrecision.Second, time.Precision);
                Assert.AreEqual(2, time.Value.Hour);
                Assert.AreEqual(23, time.Value.Minute);
                Assert.AreEqual(45, time.Value.Second);
            }
        }

        [TestMethod]
        public void Add_Null_to_Time()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Null_To_DateTime version '1.0.0'

                define private Three: @T01:23:45 + null
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Time", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Time", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Elm.Time;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Time", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Time", lhsnts.name.Name);
                }
                {

                    var rhs = add.operand[1] as As;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Add_DateTypes_to_Quantity()
        {
            Assert.ThrowsException<AggregateException>(() => DefaultConverter.ConvertLibrary(@"
                library Add_Date_to_Quantity version '1.0.0'

                define private Test: 1 month + @2023-01-01
            "));
            Assert.ThrowsException<AggregateException>(() => DefaultConverter.ConvertLibrary(@"
                library Add_Time_to_Quantity version '1.0.0'

                define private Test: 1 month + @T01:23:45
            "));
            Assert.ThrowsException<AggregateException>(() => DefaultConverter.ConvertLibrary(@"
                library Add_DateTime_to_Quantity version '1.0.0'

                define private Test: 1 month + @2023-01-01T01:23:45.300+01:30
            "));
        }

        #endregion

        [TestMethod]
        public void Add_Three_Decimals()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Decimal_to_Decimal version '1.0.0'

                define private Three: 1.0 + (2.0 + 3.0)
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Literal;
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
                    var rhs = add.operand[1] as Add;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Decimal", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(decimal?));
                Assert.AreEqual(6.0m, result);
            }
        }

        [TestMethod]
        public void Add_Quantity_to_Two_Decimals()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library Add_Decimal_to_Decimal version '1.0.0'

                define private Three: 1.0 '1' + (2.0 + 3.0)
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Add));
            {
                var add = (Add)library.statements[0].expression;
                Assert.IsNotNull(add.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", add.resultTypeName.Name);
                Assert.IsNotNull(add.resultTypeSpecifier);
                Assert.IsInstanceOfType(add.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)add.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Quantity", nts.name.Name);
                Assert.IsNotNull(add.operand);
                Assert.AreEqual(2, add.operand.Length);
                {
                    var lhs = add.operand[0] as Quantity;
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
                    var rhs = add.operand[1] as ToQuantity;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Quantity", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(add);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(CqlQuantity));
                var quantity = (CqlQuantity)result;
                Assert.AreEqual(6.0m, quantity.value);
                Assert.AreEqual(UCUMUnits.Default, quantity.unit);
            }
        }



    }
}
