using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class AsTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Integer_As_Decimal()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library AsTest version '1.0.0'

                define private Integer_As_Decimal: 1 as System.Decimal
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(As));
            {
                var @as = AssertAsTypes(library, $"{{{SystemUri}}}Integer", $"{{{SystemUri}}}Decimal");
                AssertAsNull(@as);
            }
        }

        [TestMethod]
        public void ValueSet_As_Vocabulary()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library AsTest version '1.0.0'

                valueset ""vs"": 'http://xyz.com'

                define private ValueSet_As_Vocabulary: ""vs"" as System.Vocabulary
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(As));
            {
                var @as = (As)library.statements[0].expression;
                Assert.IsNotNull(@as.operand);
                Assert.IsInstanceOfType(@as.operand, typeof(ValueSetRef));
                Assert.IsInstanceOfType(@as.asTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)@as.asTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Vocabulary", nts.name?.Name);

                var eb = ExpressionBuilderFor(library);
                var delegates = eb.Build().CompileAll();
                var dg = delegates["AsTest-1.0.0", "ValueSet_As_Vocabulary"];
                var ctx = FhirCqlContext.ForBundle(delegates: delegates);
                var result = dg.DynamicInvoke(ctx);
                Assert.IsNotNull(result);
            }
        }


        [TestMethod]
        public void Null_As_Decimal()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library AsTest version '1.0.0'

                define private Null_As_Decimal: null as System.Decimal
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(As));
            {
                var @as = (As)library.statements[0].expression;
                Assert.IsNotNull(@as.operand);
                Assert.IsInstanceOfType(@as.operand, typeof(Null));
                var operand = (Null)@as.operand;
                Assert.AreEqual($"{{{SystemUri}}}Any", operand.resultTypeName?.Name);

                Assert.IsInstanceOfType(@as.asTypeSpecifier, typeof(NamedTypeSpecifier));
                var nts = (NamedTypeSpecifier)@as.asTypeSpecifier;
                Assert.AreEqual($"{{{SystemUri}}}Decimal", nts.name?.Name);
                AssertAsNull(@as);
            }
        }


        private static As AssertAsTypes(Library library, string literalTypeName, string resultTypeName)
        {
            var @as = (As)library.statements[0].expression;
            Assert.IsNotNull(@as.operand);
            Assert.IsInstanceOfType(@as.operand, typeof(Literal));
            var operand = (Literal)@as.operand;
            Assert.AreEqual(literalTypeName, operand.resultTypeName?.Name);

            Assert.IsInstanceOfType(@as.asTypeSpecifier, typeof(NamedTypeSpecifier));
            var nts = (NamedTypeSpecifier)@as.asTypeSpecifier;
            Assert.AreEqual(resultTypeName, nts.name?.Name);
            return @as;
        }

        private void AssertAs<T>(As @as, T expected)
        {
            var lambda = ExpressionBuilder.Lambda(@as);
            var dg = lambda.Compile();
            var ctx = FhirCqlContext.ForBundle();
            var result = dg.DynamicInvoke(ctx);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(T));
            Assert.AreEqual(expected, result);
        }
        private void AssertAsNull(As @as)
        {
            var lambda = ExpressionBuilder.Lambda(@as);
            var dg = lambda.Compile();
            var ctx = FhirCqlContext.ForBundle();
            var result = dg.DynamicInvoke(ctx);
            Assert.IsNull(result);
        }
    }
}
