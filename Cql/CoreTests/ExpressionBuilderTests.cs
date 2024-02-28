using Hl7.Cql.Compiler;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace CoreTests
{
    [TestClass]
    public class ExpressionBuilderTests
    {
        private ExpressionBuilderService NewExpressionBuilderService()
        {
            var loggerFactory = LoggerFactory.Create(logging => logging.AddDebug());
            var expressionBuilderCreator = new ExpressionBuilderFactory(loggerFactory);
            return expressionBuilderCreator.ExpressionBuilderService;
        }

        [TestMethod]
        public void AggregateQueries_1_0_0()
        {
            var elm = new FileInfo(@"Input\ELM\Test\Aggregates-1.0.0.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            _ = NewExpressionBuilderService().BuildLibraryDefinitions(elmPackage);
        }

        [TestMethod]
        public void QueriesTest_1_0_0()
        {
            var elm = new FileInfo(@"Input\ELM\Test\QueriesTest-1.0.0.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            _ = NewExpressionBuilderService().BuildLibraryDefinitions(elmPackage);
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

            var expressions = NewExpressionBuilderService().BuildLibraryDefinitions(elmPackage);
            Assert.IsNotNull(expressions);
        }


        [TestMethod]
        public void Get_Property_Uses_TypeResolver()
        {
            var lib = new Hl7.Cql.Elm.Library
            {
                identifier = new Hl7.Cql.Elm.VersionedIdentifier()
                {
                    id = "Id"
                }
            };

            var property = NewExpressionBuilderService().GetProperty(lib, typeof(MeasureReport.PopulationComponent), "id");
            Assert.AreEqual(typeof(Element), property.DeclaringType);
            Assert.AreEqual(nameof(Element.ElementId), property.Name);
        }

    }
}
