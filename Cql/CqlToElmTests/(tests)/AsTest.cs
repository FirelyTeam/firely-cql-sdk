/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Quantity = Hl7.Fhir.Model.Quantity;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class AsTest : Base
    {
        [TestMethod]
        public void Integer_As_Decimal()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                                                         library AsTest version '1.0.0'

                                                         define private Integer_As_Decimal: 1 as System.Decimal
                                                         """, "Expression of type*");
        }

        [TestMethod]
        public void ValueSet_As_Vocabulary()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                                                         library AsTest version '1.0.0'

                                                         valueset "vs": 'http://xyz.com'

                                                         define private ValueSet_As_Vocabulary: "vs" as System.Vocabulary
                                                         """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(As));

            var @as = (As)library.statements[0].expression;
            Assert.IsNotNull(@as.operand);
            Assert.IsInstanceOfType(@as.operand, typeof(ValueSetRef));
            Assert.IsInstanceOfType(@as.asTypeSpecifier, typeof(NamedTypeSpecifier));
            var nts = (NamedTypeSpecifier)@as.asTypeSpecifier;
            Assert.AreEqual($"{{{SystemUri}}}Vocabulary", nts.name?.Name);

            CreateElmToolkit()
                .UseLibrarySetInvoker(
                    library,
                    lsi =>
                    {
                        var ctx = FhirCqlContext.ForBundle();
                        var result = lsi.InvokeLibraryDefinition(
                            ctx,
                            (CqlVersionedLibraryIdentifier)"AsTest-1.0.0",
                            "ValueSet_As_Vocabulary");
                        Assert.AreEqual(new CqlValueSet("http://xyz.com"), result);
                    });
        }


        [TestMethod]
        public void Null_As_Decimal()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                                                         library AsTest version '1.0.0'

                                                         define private Null_As_Decimal: null as System.Decimal
                                                         """);
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


        private static As AssertAsTypes(
            Library library,
            string literalTypeName,
            string resultTypeName)
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
            var lambda = CreateElmToolkit().Lambda(@as);
            var dg = lambda.Compile();
            var ctx = FhirCqlContext.ForBundle();
            var result = dg.DynamicInvoke(ctx);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void DecimalLiteral_CastAs_Decimal()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("cast (1.0 as System.Any) as System.Decimal");
            var castAs = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<As>();

            castAs.strict.Should().BeTrue();
            castAs.asTypeSpecifier.Should().Be(SystemTypes.DecimalType);
            AssertResult(castAs, 1.0m);
        }

        [TestMethod]
        public void BooleanLiteral_CastAs_Decimal()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("cast (true as System.Any) as System.Decimal");
            var castAs = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<As>();

            castAs.strict.Should().BeTrue();
            castAs.asTypeSpecifier.Should().Be(SystemTypes.DecimalType);
            Assert.ThrowsException<InvalidCastException>(() => AssertResult(castAs, 1.0m));
        }

        [TestMethod]
        public void FhirId_As_FhirString()
        {
            var lib = CreateCqlToolkit().MakeLibrary("""
                                                     library AsTest version '1.0.0'

                                                     using FHIR version '4.0.1'

                                                     define private function f(id FHIR.id): id as FHIR.string
                                                     """);
            lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<As>();
            CreateElmToolkit()
                .UseLibrarySetInvoker(
                    lib,
                    lsi =>
                    {
                        var ctx = FhirCqlContext.ForBundle();
                        var result = lsi.InvokeLibraryDefinition(
                            ctx,
                            lib.VersionedLibraryIdentifier,
                            new("f", typeof(Hl7.Fhir.Model.Id)),
                            new Hl7.Fhir.Model.Id("id"));
                        var fs = result.Should().BeOfType<Hl7.Fhir.Model.FhirString>().Subject;
                        fs.Value.Should().Be("id");
                    });
        }

        [TestMethod]
        public void Choice_As()
        {
            // from MATGlobalCommonFunctionsFHIR4.cql function "Normalize Interval"
            var lib = CreateCqlToolkit().MakeLibrary("""
                                                     library AsTest version '1.0.0'

                                                     using FHIR version '4.0.1'

                                                     define private function f(choice Choice<FHIR.dateTime, FHIR.Range>):
                                                         choice as FHIR.Range
                                                     """);
            CreateElmToolkit()
                .UseLibrarySetInvoker(
                    lib,
                    lsi =>
                    {
                        var ctx = FhirCqlContext.ForBundle();
                        var range = new Hl7.Fhir.Model.Range(new Quantity(1m, "m"), new Quantity(2m, "m"));
                        var result = lsi.InvokeLibraryDefinition(
                            ctx,
                            lib.VersionedLibraryIdentifier,
                            new("f", typeof(object)),
                            range);
                        result.Should().BeOfType<Hl7.Fhir.Model.Range>()
                              .And.Subject.Should().Be(range);
                    });
        }
    }
}