using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Compiler;
using Hl7.Cql.Fhir;
using Hl7.Cql.Elm;
using System.IO;
using Hl7.Cql.Model;
using Hl7.Cql.Conversion;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Cql.Abstractions;

namespace CoreTests
{
    [TestClass]
    public class ExpressionBuilderTests
    {
        private static readonly TypeResolver TypeResolver = new FhirTypeResolver(Hl7.Fhir.Model.ModelInfo.ModelInspector);
        private static readonly TypeConverter TypeConverter = FhirTypeConverter.Create(Hl7.Fhir.Model.ModelInfo.ModelInspector);

        private ILogger<ExpressionBuilder> CreateLogger() => LoggerFactory
            .Create(logging => logging.AddDebug())
            .CreateLogger<ExpressionBuilder>();

        [TestMethod]
        public void AggregateQueries_1_0_0()
        {
            var binding = new CqlOperatorsBinding(TypeResolver, TypeConverter);
            var typeManager = new TypeManager(TypeResolver);
            var elm = new FileInfo(@"Input\ELM\Test\Aggregates-1.0.0.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var logger = CreateLogger();
            var eb = new ExpressionBuilder(binding, typeManager, elmPackage, logger);
            var expressions = eb.Build();
        }

        [TestMethod]
        public void QueriesTest_1_0_0()
        {
            var binding = new CqlOperatorsBinding(TypeResolver, TypeConverter);
            var typeManager = new TypeManager(TypeResolver);
            var elm = new FileInfo(@"Input\ELM\Test\QueriesTest-1.0.0.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var logger = CreateLogger();
            var eb = new ExpressionBuilder(binding, typeManager, elmPackage, logger);
            var expressions = eb.Build();
        }
    }
}
