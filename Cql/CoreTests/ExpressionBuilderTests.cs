using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using Hl7.Cql.Packaging;
using Hl7.Cql.Runtime;

namespace CoreTests
{
    [TestClass]
    public class ExpressionBuilderTests
    {
        private static ILoggerFactory LoggerFactory { get; } =
            Microsoft.Extensions.Logging.LoggerFactory
                .Create(logging => logging.AddDebug());

        private static LibraryExpressionBuilderFactory Factory = new(LoggerFactory);

        [TestMethod]
        public void AggregateQueries_1_0_0()
        {
            var elm = new FileInfo(@"Input\ELM\Test\Aggregates-1.0.0.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var definitions = Factory.LibraryExpressionBuilder.ProcessLibrary(elmPackage);
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());
        }

        [TestMethod]
        public void FHIRTypeConversionTest_1_0_0()
        {
            var elm = new FileInfo(@"Input\ELM\HL7\FHIRTypeConversionTest.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var definitions = Factory.LibraryExpressionBuilder.ProcessLibrary(elmPackage);
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());
        }

        [TestMethod]
        public void QueriesTest_1_0_0()
        {
            var elm = new FileInfo(@"Input\ELM\Test\QueriesTest-1.0.0.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var definitions = Factory.LibraryExpressionBuilder.ProcessLibrary(elmPackage);
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());
        }

        // https://github.com/FirelyTeam/firely-cql-sdk/issues/129
        [TestMethod]
        public void Medication_Request_Example_Test()
        {
            var elm = new FileInfo(@"Input\ELM\Test\Medication_Request_Example.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);

            var fdt = new FhirDateTime(2023, 12, 11, 9, 41, 30, TimeSpan.FromHours(-5));
            var fdts = fdt.ToString();
            var fs = new FhirDateTime(fdts);
            Assert.AreEqual(fdt, fs);

            var definitions = Factory.LibraryExpressionBuilder.ProcessLibrary(elmPackage);
            Assert.IsNotNull(definitions);
            Assert.IsTrue(definitions.Libraries.Any());
        }


        [TestMethod]
        public void Get_Property_Uses_TypeResolver()
        {
            var property = Factory.TypeManager.Resolver.GetProperty(typeof(MeasureReport.PopulationComponent), "id");
            Assert.AreEqual(typeof(Element), property.DeclaringType);
            Assert.AreEqual(nameof(Element.ElementId), property.Name);
        }

    }
}
