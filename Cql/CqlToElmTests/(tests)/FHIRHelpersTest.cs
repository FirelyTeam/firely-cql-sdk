/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class FHIRHelpersTest : Base
    {
        [TestMethod]
        public void FHIRHelpers_To_Elm()
        {
            var cql = File.ReadAllText(@"Input\FHIRHelpers-4.0.1.cql");
            var lib = CreateCqlToolkit().MakeLibrary(cql);
            lib.GetErrors().Should().BeEmpty();
            using var fs = new FileStream("FHIRHelpers-4.0.1.json", FileMode.Create, FileAccess.Write, FileShare.Read);
            lib.WriteJson(fs, true);
            fs.Close();
        }

        [TestMethod]
        [Ignore("Will fix in https://github.com/FirelyTeam/firely-cql-sdk/issues/397")]
        public void FHIRHelpers_To_Expressions()
        {
            var cql = File.ReadAllText(@"Input\FHIRHelpers-4.0.1.cql");
            var lib = CreateCqlToolkit().MakeLibrary(cql);
            lib.GetErrors().Should().BeEmpty();
            using var fs = new FileStream("FHIRHelpers-4.0.1.json", FileMode.Create, FileAccess.Write, FileShare.Read);
            lib.WriteJson(fs);
            fs.Close();
            var lambdas = CreateElmToolkit().ProcessLibrary(lib);
            _ = lambdas.CompileAll();
        }

        [TestMethod]
        public void FHIRHelpers_ToConcept_Right_Types()
        {
            var lib = CreateCqlToolkit().MakeLibrary("""
                library FHIRHelpers version '4.0.1'

                using FHIR version '4.0.1'

                define function ToConcept(concept FHIR.CodeableConcept):
                    if concept is null then
                        null
                    else
                        System.Concept {
                            codes: null,
                            display: concept.text.value
                        }
                """);
            var @if = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();
            @if.Should().HaveType(SystemTypes.ConceptType);
        }

        [TestMethod]
        public void FHIRHelpers_ToConcept_Query()
        {
            var lib = CreateCqlToolkit().MakeLibrary("""
                library FHIRHelpers version '4.0.1'

                using FHIR version '4.0.1'

                define function ToCode(coding FHIR.Coding):
                    if coding is null then
                        null
                    else
                        System.Code {
                          code: coding.code.value,
                          system: coding.system.value,
                          version: coding.version.value,
                          display: coding.display.value
                        }
                define function ToConcept(concept FHIR.CodeableConcept):
                    if concept is null then
                        null
                    else
                        System.Concept {
                            codes: concept.coding C return ToCode(C),
                            display: concept.text.value
                        }
                """);

            lib.statements.Should().HaveCount(2);
            var fd = lib.statements[1].Should().BeOfType<FunctionDef>().Subject;
            var lambdas = CreateElmToolkit().ProcessLibrary(lib);
            _ = lambdas.CompileAll();
        }

        [TestMethod]
        public void FHIRHelpers_Coding_To_ListCodes()
        {
            var cqlToolkit = CreateCqlToolkit().AddFHIRHelpers();
            var lib = cqlToolkit.MakeLibrary("""
                                         library Test version '1.0.0'

                                         using FHIR version '4.0.1'

                                         valueset "VS" : 'http://snomed.info/sct'

                                         include FHIRHelpers version '4.0.1' called FHIRHelpers

                                         define function inTest(condition FHIR.Condition, codes List<Code>):
                                           condition.code.coding in "VS"
                                         """);
            lib.statements.Should().HaveCount(1);
            var fd = lib.statements[0].Should().BeOfType<FunctionDef>().Subject;
            var body = fd.expression;
            var any = body.Should().BeOfType<AnyInValueSet>().Subject;
            any.codes.Should().NotBeNull();
            any.codes.resultTypeSpecifier.Should().NotBeNull();
            any.codes.resultTypeSpecifier.Should().Be(SystemTypes.CodeType.ToListType());
            any.codes.Should().BeOfType<Query>();
            any.valueset.Should().NotBeNull();
            any.valueset.name.Should().Be("VS");
            any.resultTypeSpecifier.Should().NotBeNull();
            any.resultTypeSpecifier.Should().Be(SystemTypes.BooleanType);
        }
    }
}