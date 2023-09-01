using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;
using System.Diagnostics;

namespace Test
{
    [TestClass]
    public class MeasuresTest
    {
        private readonly IDictionary<string, object> MY2023 =
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
            var patientEverything = new Bundle();  // add some data
            var engineSetup = FhirCqlEngineSetup.ForBundle(patientEverything, MY2023);
            var bcs = new BCSEHEDISMY2022_1_0_0(engineSetup.NewContext());
            var numerator = bcs.Numerator();
            Assert.IsFalse(numerator);
        }

        [TestMethod]
        public void BCSEHEDIS2022_Numerator_FromResource()
        {
            var lib = "BCSEHEDISMY2022";
            var version = "1.0.0";
            var dir = new DirectoryInfo("Resources");
            var asmContext = LibraryPackager.LoadResources(dir, lib, version);

            var patientEverything = new Bundle();   // Add data
            var valueSets = Enumerable.Empty<ValueSet>().ToValueSetDictionary();  // Add valuesets
            var setup = FhirCqlEngineSetup.ForBundle(patientEverything, MY2023, valueSets);

            var results = asmContext.Run(lib, version, setup);
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

            var patientEverything = new Bundle();  // Add some data
            var valueSets = Enumerable.Empty<ValueSet>().ToValueSetDictionary();  // Add valuesets
            var setup = FhirCqlEngineSetup.ForBundle(patientEverything, MY2023, valueSets);

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var asmContext = LibraryPackager.LoadElm(elmDir, lib, version);
            var results = asmContext.Run(lib, version, setup);
            var elapsed = stopwatch.Elapsed;
            stopwatch.Stop();
            Console.WriteLine($"Run 1: {elapsed}");

            Assert.IsTrue(results.TryGetValue("Numerator", out var numerator));
            Assert.IsInstanceOfType(numerator, typeof(bool?));
            Assert.IsFalse((bool?)numerator);

            // Run a second time with a (presumably) different bundle.
            var bundle2 = new Bundle();
            setup = FhirCqlEngineSetup.ForBundle(bundle2, MY2023, valueSets);
            stopwatch.Restart();
            results = asmContext.Run(lib, version, setup);
            elapsed = stopwatch.Elapsed;
            stopwatch.Stop();
            Console.WriteLine($"Run 2: {elapsed}");
            Assert.IsTrue(results.TryGetValue("Numerator", out numerator));
            Assert.IsInstanceOfType(numerator, typeof(bool?));
            Assert.IsFalse((bool?)numerator);
        }

    }
}