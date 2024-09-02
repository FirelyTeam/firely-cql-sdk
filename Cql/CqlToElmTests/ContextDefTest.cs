using FluentAssertions;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    internal class ContextDefTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter


        [TestMethod]
        public void Context_Of_Known_Model()
        {
            var lib = MakeLibrary(@"
                library UsingTest version '1.0.0'

                using FHIR

                context FHIR.Patient
                context Observation
            ");

            Assert.IsNotNull(lib.contexts);
            lib.contexts.Select(c => c.name).Should().BeEquivalentTo("FHIR.Patient", "Observation");

            lib.statements.Should().ContainEquivalentOf(new
            {
                name = "Patient",
                context = "FHIR.Patient",
                resultTypeSpecifier = Models.Fhir401.MakeQualifiedTypeName("Patient").ToNamedType()
            }, p => p.ExcludingMissingMembers());
            lib.statements.Should().ContainEquivalentOf(new
            {
                name = "Observation",
                context = "Observation",
                resultTypeSpecifier = Models.Fhir401.MakeQualifiedTypeName("Observation").ToNamedType()
            }, p => p.ExcludingMissingMembers());
        }

        [TestMethod]
        public void Context_Of_Unknown_Model()
        {
            var lib = MakeLibrary(@"
                library UsingTest version '1.0.0'

                using FHIR

                context FHIRX.Patient
            ", "Could not resolve model name FHIRX");
        }

        [TestMethod]
        public void Context_UnknonwType_on_Known_Model()
        {
            var lib = MakeLibrary(@"
                library UsingTest version '1.0.0'

                using FHIR

                context FHIR.doesnotexist
            ", "Could not resolve context name doesnotexist in model FHIR.");
        }

        [TestMethod]
        public void Context_Not_A_Model()
        {
            var lib = MakeLibrary(@"
                library UsingTest version '1.0.0'
                
                define derp: false
                
                context derp.herp
            ", "Could not resolve model name derp");
        }

        [TestMethod]
        public void Context_Of_Unknown_Type()
        {
            var lib = MakeLibrary(@"
                library UsingTest version '1.0.0'

                using FHIR

                context ObservationX
            ", "Could not resolve context name ObservationX in model FHIR.");
        }

        [TestMethod]
        public void Context_Unfiltered_Retrieve_Null_Context()
        {
            var lib = MakeLibrary(@"
                library UsingTest version '1.0.0'

                using FHIR version '4.0.1'

                define patients: [Patient]
            ");
            var retrieve = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Retrieve>();
            retrieve.context.Should().BeNull();
        }

    }
}