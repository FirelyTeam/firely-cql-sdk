using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.CqlToElm.Test
{
    // define "SDE Sex":
    // case
    //     when Patient.gender = 'male' then Code { code: 'M', system: 'http://hl7.org/fhir/v3/AdministrativeGender', display: 'Male' }
    //     when Patient.gender = 'female' then Code { code: 'F', system: 'http://hl7.org/fhir/v3/AdministrativeGender', display: 'Female' }
    //     else null
    //   end

    [TestClass]
    public class CodeTest : Base
    {
        [TestMethod]
        public void CreatedCodeByPropertyNames()
        {
            // This test checks that the code is returned as expected using the correct values as per the property names,
            // instead of just using the positions the parameters in the constructor.

            // Arrange
            var cqlToolkit = CreateCqlToolkit();

            using var invoker =
                cqlToolkit.AddCqlLibraries(
                              (CqlLibraryString)"""
                                                library ReturnCodes version '1.0.0'

                                                define MaleCode:
                                                    Code { code: 'M', system: 'http://hl7.org/fhir/v3/AdministrativeGender', display: 'Male' }

                                                define FemaleCode:
                                                    Code { code: 'F', display: 'Female', system: 'http://hl7.org/fhir/v3/AdministrativeGender' }
                                                """)
                          .CreateLibrarySetInvoker(
                              new ElmToolkitConfig(AssemblyCompilerDebugInformationFormat: AssemblyCompilerDebugInformationFormat.Embedded));

            var ctx = FhirCqlContext.CreateContext();

            // Act
            var codes =
                invoker.SelectExpressions()
                       .SelectResults(ctx)
                       .ToDictionary(r => r.definitionInvoker.DefinitionName, r => (CqlCode)r.invocationResult!);

            // Assert
            Assert.AreEqual(new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Female"), codes["FemaleCode"]);
            Assert.AreEqual(new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Male"), codes["MaleCode"]);
        }
    }
}