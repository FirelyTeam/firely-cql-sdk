using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hl7.Cql.Compiler;
using Hl7.Cql.Firely;
using Hl7.Cql.Elm;
using System.IO;
using Hl7.Cql;
using Hl7.Cql.Model;
using Hl7.Cql.Conversion;

namespace CoreTests
{
    [TestClass]
    public class ExpressionBuilderTests
    {
        private static readonly TypeResolver TypeResolver = new FirelyTypeResolver(Models.Fhir401);
        private static readonly TypeConverter TypeConverter = FirelyTypeConverter.Default;

        private ILogger<ExpressionBuilder> CreateLogger() => LoggerFactory
            .Create(logging => logging.AddDebug())
            .CreateLogger<ExpressionBuilder>();

        [TestMethod]
        public void AggregateQueries_1_0_0()
        {
            var binding = new CqlOperatorsBinding(TypeResolver, TypeConverter);
            var typeManager = new TypeManager(TypeResolver);
            var elm = new FileInfo(@"Input\ELM\Test\Aggregates-1.0.0.json");
            var elmPackage = ElmPackage.LoadFrom(elm);
            var logger = CreateLogger();
            var eb = new ExpressionBuilder(binding, typeManager, elmPackage, logger);
            var expressions = eb.Build();
        }

        [TestMethod]
        public void QueriesTest_1_0_0()
        {
            var binding = new CqlOperatorsBinding(TypeResolver, TypeConverter);
            var typeManager = new TypeManager(TypeResolver);
            var elm = new FileInfo(@"Input\ELM\QueriesTest-1.0.0.json");
            var elmPackage = ElmPackage.LoadFrom(elm);
            var logger = CreateLogger();
            var eb = new ExpressionBuilder(binding, typeManager, elmPackage, logger);
            var expressions = eb.Build();
        }
    }
}
