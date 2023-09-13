using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class XorTest: Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void True_Xor_False()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library XorTest version '1.0.0'

                define private True_Xor_False: true xor false
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Xor));
            {
                var xor = (Xor)library.statements[0].expression;
                Assert.IsNotNull(xor.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", xor.resultTypeName.Name);
                Assert.IsNotNull(xor.resultTypeSpecifier);
                Assert.IsInstanceOfType(xor.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)xor.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(xor.operand);
                Assert.AreEqual(2, xor.operand.Length);
                {
                    var lhs = xor.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", lhsnts.name.Name);
                }
                {
                    var rhs = xor.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(xor);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void True_Xor_True()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library XorTest version '1.0.0'

                define private True_Xor_True: true xor true
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Xor));
            {
                var xor = (Xor)library.statements[0].expression;
                Assert.IsNotNull(xor.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", xor.resultTypeName.Name);
                Assert.IsNotNull(xor.resultTypeSpecifier);
                Assert.IsInstanceOfType(xor.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)xor.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(xor.operand);
                Assert.AreEqual(2, xor.operand.Length);
                {
                    var lhs = xor.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", lhsnts.name.Name);
                }
                {
                    var rhs = xor.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(xor);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void False_Xor_False()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library XorTest version '1.0.0'

                define private False_Xor_False: false xor false
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Xor));
            {
                var xor = (Xor)library.statements[0].expression;
                Assert.IsNotNull(xor.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", xor.resultTypeName.Name);
                Assert.IsNotNull(xor.resultTypeSpecifier);
                Assert.IsInstanceOfType(xor.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)xor.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(xor.operand);
                Assert.AreEqual(2, xor.operand.Length);
                {
                    var lhs = xor.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", lhsnts.name.Name);
                }
                {
                    var rhs = xor.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(xor);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void True_Xor_Null()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library XorTest version '1.0.0'

                define private True_Xor_Null: true xor null
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Xor));
            {
                var xor = (Xor)library.statements[0].expression;
                Assert.IsNotNull(xor.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", xor.resultTypeName.Name);
                Assert.IsNotNull(xor.resultTypeSpecifier);
                Assert.IsInstanceOfType(xor.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)xor.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(xor.operand);
                Assert.AreEqual(2, xor.operand.Length);
                {
                    var lhs = xor.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", lhsnts.name.Name);
                }
                {
                    var rhs = xor.operand[1] as As;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(xor);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Null_Xor_False()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library XorTest version '1.0.0'

                define private Null_Xor_False: null xor false
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Xor));
            {
                var xor = (Xor)library.statements[0].expression;
                Assert.IsNotNull(xor.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", xor.resultTypeName.Name);
                Assert.IsNotNull(xor.resultTypeSpecifier);
                Assert.IsInstanceOfType(xor.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)xor.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(xor.operand);
                Assert.AreEqual(2, xor.operand.Length);
                {
                    var lhs = xor.operand[0] as As;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", lhsnts.name.Name);
                }
                {
                    var rhs = xor.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(xor);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNull(result);

            }
        }

        [TestMethod]
        public void Null_Xor_Null()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library XorTest version '1.0.0'

                define private Null_Xor_Null: null xor null
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Xor));
            {
                var xor = (Xor)library.statements[0].expression;
                Assert.IsNotNull(xor.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", xor.resultTypeName.Name);
                Assert.IsNotNull(xor.resultTypeSpecifier);
                Assert.IsInstanceOfType(xor.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)xor.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}Boolean", nts.name.Name);
                Assert.IsNotNull(xor.operand);
                Assert.AreEqual(2, xor.operand.Length);
                {
                    var lhs = xor.operand[0] as As;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", lhsnts.name.Name);
                }
                {
                    var rhs = xor.operand[1] as As;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}Boolean", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(xor);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void True_Xor_1()
        {
            Assert.ThrowsException<AggregateException>(() => DefaultConverter.ConvertLibrary(@"
                library XorTest version '1.0.0'

                define private True_Xor_1: true xor 1
            "));
        }
    }
}
