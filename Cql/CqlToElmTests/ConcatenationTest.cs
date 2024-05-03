using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]

    public class ConcatenationTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Add_String_To_String()
        {
            var library = MakeLibrary(@"
                library Add_Integer_to_Integer version '1.0.0'

                define private Three: 'hello' & 'world'
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Concatenate));
            {
                var concatenate = (Concatenate)library.statements[0].expression;
                Assert.IsNotNull(concatenate.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}String", concatenate.resultTypeName.Name);
                Assert.IsNotNull(concatenate.resultTypeSpecifier);
                Assert.IsInstanceOfType(concatenate.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)concatenate.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}String", nts.name.Name);
                Assert.IsNotNull(concatenate.operand);
                Assert.AreEqual(2, concatenate.operand.Length);
                {
                    var lhs = concatenate.operand[0] as Literal;
                    Assert.IsNotNull(lhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}String", lhs!.resultTypeName.Name);
                    Assert.IsNotNull(lhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(lhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var lhsnts = (NamedTypeSpecifier)lhs.resultTypeSpecifier;
                    Assert.IsNotNull(lhsnts.name);
                    Assert.IsNotNull(lhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}String", lhsnts.name.Name);
                    Assert.AreEqual("hello", lhs.value);
                }
                {
                    var rhs = concatenate.operand[1] as Literal;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}String", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}String", rhsnts.name.Name);
                    Assert.AreEqual("world", rhs.value);
                }

                var lambda = ExpressionBuilder.Lambda(concatenate);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(string));
                Assert.AreEqual("helloworld", result);
            }



        }

        [TestMethod]
        public void Add_Three_Strings()
        {
            var library = MakeLibrary(@"
                library Add_Integer_to_Integer version '1.0.0'

                define private Three: 'hello' & (' ' & 'world')
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(Concatenate));
            {
                var concatenate = (Concatenate)library.statements[0].expression;
                Assert.IsNotNull(concatenate.resultTypeName);
                Assert.AreEqual($"{{{SystemUri}}}String", concatenate.resultTypeName.Name);
                Assert.IsNotNull(concatenate.resultTypeSpecifier);
                Assert.IsInstanceOfType(concatenate.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)concatenate.resultTypeSpecifier;
                Assert.IsNotNull(nts.name);
                Assert.IsNotNull(nts.name.Name);
                Assert.AreEqual($"{{{SystemUri}}}String", nts.name.Name);
                Assert.IsNotNull(concatenate.operand);
                Assert.AreEqual(2, concatenate.operand.Length);
                {
                    var lhs = concatenate.operand[0] as Literal;
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
                    var rhs = concatenate.operand[1] as Concatenate;
                    Assert.IsNotNull(rhs!.resultTypeName);
                    Assert.AreEqual($"{{{SystemUri}}}String", rhs!.resultTypeName.Name);
                    Assert.IsNotNull(rhs.resultTypeSpecifier);
                    Assert.IsInstanceOfType(rhs.resultTypeSpecifier, typeof(NamedTypeSpecifier));
                    var rhsnts = (NamedTypeSpecifier)rhs.resultTypeSpecifier;
                    Assert.IsNotNull(rhsnts.name);
                    Assert.IsNotNull(rhsnts.name.Name);
                    Assert.AreEqual($"{{{SystemUri}}}String", rhsnts.name.Name);
                }

                var lambda = ExpressionBuilder.Lambda(concatenate);
                var dg = lambda.Compile();
                var result = dg.DynamicInvoke(FhirCqlContext.ForBundle());
                Assert.IsInstanceOfType(result, typeof(string));
                Assert.AreEqual("hello world", result);
            }



        }

    }
}
