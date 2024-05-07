using FluentAssertions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class FHIRHelpersTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize(co =>
        {
            co.EnableListDemotion = true; // FHIRHelpers requires this
        });
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void FHIRHelpers_To_Elm()
        {
            var cql = File.ReadAllText(@"Input\FHIRHelpers-4.0.1.cql");
            var lib = MakeLibrary(cql);
            lib.GetErrors().Should().BeEmpty();
            using var fs = new FileStream("FHIRHelpers-4.0.1.json", FileMode.Create, FileAccess.Write, FileShare.Read);
            lib.WriteJson(fs, true);
            fs.Close();
        }

        [TestMethod]
        public void FHIRHelpers_To_Expressions()
        {
            var cql = File.ReadAllText(@"Input\FHIRHelpers-4.0.1.cql");
            var lib = MakeLibrary(cql);
            lib.GetErrors().Should().BeEmpty();
            using var fs = new FileStream("FHIRHelpers-4.0.1.json", FileMode.Create, FileAccess.Write, FileShare.Read);
            lib.WriteJson(fs);
            fs.Close();
            var eb = ExpressionBuilderFor(lib);
            var lambdas = eb.Build();
            var delegates = lambdas.CompileAll();
        }

        [TestMethod]
        public void FHIRHelpers_ToConcept_Right_Types()
        {
            var lib = MakeLibrary(@"
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
            ");
            var @if = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<If>();
            @if.Should().HaveType(SystemTypes.ConceptType);
        }

        [TestMethod]
        public void FHIRHelpers_ToConcept_Query()
        {
            var lib = MakeLibrary(@"
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
            ");

            lib.statements.Should().HaveCount(2);
            var fd = lib.statements[1].Should().BeOfType<FunctionDef>().Subject;
            var eb = ExpressionBuilderFor(lib);
            var lambdas = eb.Build();
            var delegates = lambdas.CompileAll();
        }

    }
}