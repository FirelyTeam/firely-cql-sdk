using Cql;
using Hl7.Cql;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Poco.Fhir.R4;
using Hl7.Cql.Poco.Fhir.R4.Model;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime.FhirR4;
using System.Runtime.Loader;

namespace Test
{
    [TestClass]
    public class CompilerTests
    {

        private IDictionary<string, object> MY2023 =
            new Dictionary<string, object>
            {
                {
                    "Measurement Period",
                    new CqlInterval<CqlDateTime>(
                        new CqlDateTime(2023, 1, 1, 0, 0, 0, 0, 0, 0),
                        new CqlDateTime(2023, 12, 31, 0, 0, 0, 0, 0, 0),
                        true,
                        true)
                }
            };

        [TestMethod]
        public void Compile_All()
        {
            var elmDir = new DirectoryInfo("Resources");
            var results = FhirCqlContext.Run(elmDir, "BCSEHEDISMY2022", "1.0.0", 
                FhirCqlContext.Create(new Bundle(), MY2023));
        }
    }
}