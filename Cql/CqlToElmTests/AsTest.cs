using FluentAssertions;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            var library = MakeLibrary(@"
                library AsTest version '1.0.0'

                define private Integer_As_Decimal: 1 as System.Decimal
            ", "Expression of type*");

        }

        [TestMethod]
        public void ValueSet_As_Vocabulary()
        {
            var library = MakeLibrary(@"
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

                var eb = LibraryExpressionBuilder;
                var delegates = eb.ProcessLibrary(library).CompileAll();
                var dg = delegates["AsTest-1.0.0", "ValueSet_As_Vocabulary"];
                var ctx = FhirCqlContext.ForBundle(delegates: delegates);
                var result = dg.DynamicInvoke(ctx);
                Assert.IsNotNull(result);
            }
        }


        [TestMethod]
        public void Null_As_Decimal()
        {
            var library = MakeLibrary(@"
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
            @as.strict.Should().BeFalse();

            Assert.IsInstanceOfType(@as.asTypeSpecifier, typeof(NamedTypeSpecifier));
            var nts = (NamedTypeSpecifier)@as.asTypeSpecifier;
            Assert.AreEqual(resultTypeName, nts.name?.Name);
            return @as;
        }

        private void AssertAsNull(As @as)
        {
            var lambda = LibraryExpressionBuilder.Lambda(@as);
            var dg = lambda.Compile();
            var ctx = FhirCqlContext.ForBundle();
            var result = dg.DynamicInvoke(ctx);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void DecimalLiteral_CastAs_Decimal()
        {
            var library = CreateLibraryForExpression("cast (1.0 as System.Any) as System.Decimal");
            var castAs = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<As>();

            castAs.strict.Should().BeTrue();
            castAs.asTypeSpecifier.Should().Be(SystemTypes.DecimalType);
            AssertResult(castAs, 1.0m);
        }

        [TestMethod]
        public void BooleanLiteral_CastAs_Decimal()
        {
            var library = CreateLibraryForExpression("cast (true as System.Any) as System.Decimal");
            var castAs = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<As>();

            castAs.strict.Should().BeTrue();
            castAs.asTypeSpecifier.Should().Be(SystemTypes.DecimalType);
            Assert.ThrowsException<InvalidCastException>(() => AssertResult(castAs, 1.0m));
        }

        [TestMethod]
        public void FhirId_As_FhirString()
        {
            var lib = MakeLibrary(@"
                library AsTest version '1.0.0'

                using FHIR version '4.0.1'

                define private function f(id FHIR.id): id as FHIR.string
            ");
            var @as = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<As>();
            var lambdas = LibraryExpressionBuilder.ProcessLibrary(lib);
            var delegates = lambdas.CompileAll();
            var dg = delegates[lib.NameAndVersion(), "f", [typeof(Hl7.Fhir.Model.Id)]];
            var ctx = FhirCqlContext.ForBundle();
            var result = dg.DynamicInvoke([ctx, new Hl7.Fhir.Model.Id("id")]);
            var fs = result.Should().BeOfType<Hl7.Fhir.Model.FhirString>().Subject;
            fs.Value.Should().Be("id");
        }

        [TestMethod]
        public void Choice_As()
        {
            // from MATGlobalCommonFunctionsFHIR4.cql function "Normalize Interval"
            var lib = MakeLibrary(@"
                library AsTest version '1.0.0'

                using FHIR version '4.0.1'


                context Patient

                define private function f(choice Choice<FHIR.dateTime, FHIR.Range>):
                    choice as FHIR.Range
            ");
            var lambdas = LibraryExpressionBuilder.ProcessLibrary(lib);
        }
    }
}
