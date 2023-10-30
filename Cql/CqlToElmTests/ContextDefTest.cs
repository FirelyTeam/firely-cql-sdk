using FluentAssertions;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class ContextDefTest : Base
    {
        private static Library MakeLibrary(string cql, bool expectErrors = false)
        {
            var services = LibraryTest.MakeMinimalServiceCollection()
                .AddModels(mp =>
                {
                    mp.Add(Models.ElmR1);
                    mp.Add(Models.Fhir401);
                });

            var provider = services.BuildServiceProvider();
            var converter = provider.GetRequiredService<CqlToElmConverter>();

            var library = converter.ConvertLibrary(cql);
            var hasErrors = library.GetErrors().Any(e => e.errorSeverity == ErrorSeverity.error);
            hasErrors.Should().Be(expectErrors, "because the test case should {0} errors", expectErrors ? "have" : "not have");

            return library;
        }

        [TestMethod]
        public void Context_Of_Known_Model()
        {
            var lib = MakeLibrary(@"
                library UsingTeest version '1.0.0'

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
                library UsingTeest version '1.0.0'

                using FHIR

                context FHIRX.Patient
            ", expectErrors: true);

            lib.ShouldReportError("There is no model matching qualifier 'FHIRX'.");
        }

        [TestMethod]
        public void Context_Of_Unknown_Type()
        {
            var lib = MakeLibrary(@"
                library UsingTeest version '1.0.0'

                using FHIR

                context ObservationX
            ", expectErrors: true);

            lib.ShouldReportError("There is no type named 'ObservationX' in model(s) http://hl7.org/fhir (version unspecified).");
        }

    }
}