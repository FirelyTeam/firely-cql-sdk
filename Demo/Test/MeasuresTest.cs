using Cql;
using Hl7.Cql;
using Hl7.Cql.Compiler;
using Hl7.Cql.Firely;
using Hl7.Cql.Primitives;
using System.Runtime.Loader;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Model;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Runtime;
using System.Diagnostics;

namespace Test
{
    [TestClass]
    public class MeasuresTest
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
        public void BCSEHEDIS2022_Numerator()
        {
            var bcs = new BCSEHEDISMY2022_1_0_0(FirelyCqlContext.Create());
            var numerator = bcs.Numerator();
            Assert.IsFalse(numerator);
        }

        [TestMethod]
        public void BCSEHEDIS2022_Numerator_Dynamic()
        {
            var lib = "BCSEHEDISMY2022";
            var version = "1.0.0";
            var dir = new DirectoryInfo("Resources");

            var bundle = new Bundle();
            var valueSets = new HashValueSetDictionary();
            var cqlContext = FirelyCqlContext.Create(bundle, MY2023, valueSets);
            var results = dir.RunLibraryResource(lib, version, cqlContext);

            Assert.IsTrue(results.TryGetValue("Numerator", out var numerator));
            Assert.IsInstanceOfType(numerator, typeof(bool?));
            Assert.IsFalse((bool?)numerator);
        }

        [TestMethod]
        public void BCSEHEDIS2022_Numerator_FromElm()
        {
            var elmDir = new DirectoryInfo("../../../../Elm/Json");
            Assert.IsTrue(elmDir.Exists);

            var lib = "BCSEHEDISMY2022";
            var version = "1.0.0";

            var bundle = new Bundle();
            var valueSets = new HashValueSetDictionary();
            var cqlContext = FirelyCqlContext.Create(bundle, MY2023, valueSets);

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var asmContext = elmDir.LoadElm(lib, version);
            var results = asmContext.Run(lib, version, cqlContext);
            var elapsed = stopwatch.Elapsed;
            stopwatch.Stop();
            Console.WriteLine($"Run 1: {elapsed}");

            Assert.IsTrue(results.TryGetValue("Numerator", out var numerator));
            Assert.IsInstanceOfType(numerator, typeof(bool?));
            Assert.IsFalse((bool?)numerator);

            // Run a second time with a (presumably) different bundle.
            var bundle2 = new Bundle();
            cqlContext = FirelyCqlContext.Create(bundle2, MY2023, valueSets);
            stopwatch.Restart();
            results = asmContext.Run(lib, version, cqlContext);
            elapsed = stopwatch.Elapsed;
            stopwatch.Stop();
            Console.WriteLine($"Run 2: {elapsed}");
            Assert.IsTrue(results.TryGetValue("Numerator", out numerator));
            Assert.IsInstanceOfType(numerator, typeof(bool?));
            Assert.IsFalse((bool?)numerator);


        }

    }
}