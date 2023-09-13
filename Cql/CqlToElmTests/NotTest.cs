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
    public class NotTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Not_True()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library NotTest version '1.0.0'

                define private Not_True: not true
            ");
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
              

                var lambda = ExpressionBuilder.Lambda(not);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void Not_False()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library NotTest version '1.0.0'

                define private Not_False: not false
            ");
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


                var lambda = ExpressionBuilder.Lambda(not);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(bool?));
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void Not_Null()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library NotTest version '1.0.0'

                define private Not_Null: not null
            ");
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


                var lambda = ExpressionBuilder.Lambda(not);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Not_1() =>
             Assert.ThrowsException<AggregateException>(() => DefaultConverter.ConvertLibrary(@"
                library NotTest version '1.0.0'

                define private Not_1: not 1
            "));
    }
}
