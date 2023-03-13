using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ncqa.Cql.MeasureCompiler;
using Ncqa.Cql.MeasureCompiler.CodeGeneration;
using Ncqa.Cql.Runtime;
using Ncqa.Cql.Runtime.FhirR4;
using Ncqa.Elm;
using Ncqa.Fhir.R4;
using Ncqa.Fhir.R4.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CoreTests
{
    [TestClass]
    public class ExpressionBuilderTests
    {
        private ILogger<ExpressionBuilder> CreateLogger() => LoggerFactory
            .Create(logging => logging.AddDebug())
            .CreateLogger<ExpressionBuilder>();

        [TestMethod]
        public void QueriesTest_1_0_0()
        {
            var binding = new FhirOperatorsBinding(FhirTypeConverter.Default, FhirTypeResolver.Default);
            var typeManager = new TypeManager(FhirTypeResolver.Default);
            var elm = new FileInfo(@"Input\ELM\QueriesTest-1.0.0.json");
            var elmPackage = ElmPackage.LoadFrom(elm);
            var logger = CreateLogger();
            var eb = new ExpressionBuilder(binding, typeManager, elmPackage, logger);
            var expressions = eb.Build();
        }
    }
}
