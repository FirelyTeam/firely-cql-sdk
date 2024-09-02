using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using Hl7.Cql.Compiler;

namespace CoreTests
{
    [TestClass]
    public class LibraryExpressionBuilderTests
    {
        [TestMethod]
        public void AggregateQueries_1_0_0()
        {
            using var cqlCompilerServices = ServiceProviderInitializer.CreateCqlCompilerServiceProvider();
            var elm = new FileInfo(@"Input\ELM\Test\Aggregates-1.0.0.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var definitions = cqlCompilerServices.LibraryExpressionBuilder.ProcessLibrary(elmPackage);
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());
        }

        [TestMethod]
        public void FHIRConversionTest_1_0_0()
        {
            using var cqlCompilerServices = ServiceProviderInitializer.CreateCqlCompilerServiceProvider();
            var elm = new FileInfo(@"Input\ELM\HL7\FHIRConversionTest.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var definitions = cqlCompilerServices.LibraryExpressionBuilder.ProcessLibrary(elmPackage);
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());
        }

        [TestMethod]
        public void QueriesTest_1_0_0()
        {
            using var cqlCompilerServices = ServiceProviderInitializer.CreateCqlCompilerServiceProvider();
            var elm = new FileInfo(@"Input\ELM\Test\QueriesTest-1.0.0.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var definitions = cqlCompilerServices.LibraryExpressionBuilder.ProcessLibrary(elmPackage);
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());
        }

        // https://github.com/FirelyTeam/firely-cql-sdk/issues/129
        [TestMethod]
        public void Medication_Request_Example_Test()
        {
            using var cqlCompilerServices = ServiceProviderInitializer.CreateCqlCompilerServiceProvider();
            FileInfo[] files =
            [
                new(@"Input\ELM\Test\Medication_Request_Example.json"),
                new(@"Input\ELM\Libs\FHIRHelpers-4.0.1.json")
            ];
            var librarySet = new LibrarySet();
            librarySet.LoadLibraries(files);

            var fdt = new FhirDateTime(2023, 12, 11, 9, 41, 30, TimeSpan.FromHours(-5));
            var fdts = fdt.ToString();
            var fs = new FhirDateTime(fdts);
            Assert.AreEqual(fdt, fs);

            var definitions = cqlCompilerServices.LibrarySetExpressionBuilder.ProcessLibrarySet(librarySet);
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());
        }


        [TestMethod]
        public void Get_Property_Uses_TypeResolver()
        {
            using var cqlCompilerServices = ServiceProviderInitializer.CreateCqlCompilerServiceProvider();
            var property = ExpressionBuilder.GetProperty(typeof(MeasureReport.PopulationComponent), "id", cqlCompilerServices.TypeManager.Resolver)!;
            Assert.AreEqual(typeof(Element), property.DeclaringType);
            Assert.AreEqual(nameof(Element.ElementId), property.Name);
        }

    }
}