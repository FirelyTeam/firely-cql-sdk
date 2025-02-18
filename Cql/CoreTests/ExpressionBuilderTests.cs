using Hl7.Fhir.Model;
using Hl7.Cql.Compiler;
using Hl7.Cql.Runtime.Hosting;
using CqlSdkPrototype.Elm.Internal;

namespace CoreTests
{
    [TestClass]
    public class LibraryExpressionBuilderTests
    {
        private static ServiceProvider BuildServiceProvider() => ElmToolkitServices.AddCqlCompilerServices(new ServiceCollection().AddDebugLogging()).BuildServiceProvider(validateScopes: true);

        [TestMethod]
        public void AggregateQueries_1_0_0()
        {
            using var serviceProvider = BuildServiceProvider();
            using var servicesScope = serviceProvider.CreateScope();
            var elm = new FileInfo(@"Input\ELM\Test\Aggregates-1.0.0.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var definitions = servicesScope.ServiceProvider.GetRequiredService<LibraryExpressionBuilder>().ProcessLibrary(elmPackage);
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());
        }

        [TestMethod]
        public void FHIRConversionTest_1_0_0()
        {
            using var serviceProvider = BuildServiceProvider();
            using var servicesScope = serviceProvider.CreateScope();
            var elm = new FileInfo(@"Input\ELM\HL7\FHIRConversionTest.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var definitions = servicesScope.ServiceProvider.GetRequiredService<LibraryExpressionBuilder>().ProcessLibrary(elmPackage);
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());
        }

        [TestMethod]
        public void QueriesTest_1_0_0()
        {
            using var serviceProvider = BuildServiceProvider();
            using var servicesScope = serviceProvider.CreateScope();
            var elm = new FileInfo(@"Input\ELM\Test\QueriesTest-1.0.0.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var definitions = servicesScope.ServiceProvider.GetRequiredService<LibraryExpressionBuilder>().ProcessLibrary(elmPackage);
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());
        }

        // https://github.com/FirelyTeam/firely-cql-sdk/issues/129
        [TestMethod]
        public void Medication_Request_Example_Test()
        {
            using var serviceProvider = BuildServiceProvider();
            using var servicesScope = serviceProvider.CreateScope();
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

            var librarySetExpressionBuilder = servicesScope.ServiceProvider.GetRequiredService<LibrarySetExpressionBuilder>();
            var definitions = librarySetExpressionBuilder.ProcessLibrarySet(librarySet);
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());
        }
    }
}