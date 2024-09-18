using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using System.Diagnostics;
using System.IO;
using Test.Deck;

namespace Test
{
    [TestClass]
    public class MeasuresTest : TestBase
    {
        private readonly IDictionary<string, object> MY2022 =
            new Dictionary<string, object>
            {
                {
                    "Measurement Period",
                    new CqlInterval<CqlDateTime>(
                        new CqlDateTime(2022, 1, 1, 0, 0, 0, 0, 0, 0),
                        new CqlDateTime(2022, 12, 31, 0, 0, 0, 0, 0, 0),
                        true,
                        true
                    )
                }
            };

        [TestMethod]
        public void BCSEHEDIS2022_Numerator()
        {
            var patientEverything = new Bundle();  // add some data
            var context = FhirCqlContext.ForBundle(patientEverything, MY2022);
            var bcs = BCSEHEDISMY2022_1_0_0.Instance;
            var numerator = bcs.Numerator(context);
            Assert.IsFalse(numerator);
        }

        [TestMethod]
        public void BCSEHEDIS2022_Numerator_FromResource_Passed()
        {
            var lib = "BCSEHEDISMY2022";
            var version = "1.0.0";
            var dir = new DirectoryInfo("Resources");
            var asmContext = LibraryPackager.LoadResources(dir, lib, version);

            byte[] byteArray = File.ReadAllBytes("Inputs/Bundles/95029_pass.json");
            using var stream = new MemoryStream(byteArray);
            var patientBundle = LoadBundle(stream);

            var directory = new DirectoryInfo("Inputs/ValueSets");
            var valueSets = LoadValueSets(directory);// Add valuesets

            var context = FhirCqlContext.ForBundle(patientBundle, MY2022, valueSets);

            var results = asmContext.Run(lib, version, context);

            Assert.IsTrue(results.TryGetValue("Numerator", out var numerator));
            Assert.IsInstanceOfType(numerator, typeof(bool?));
            Assert.IsTrue((bool?)numerator);

            var lib2 = BCSEHEDISMY2022_1_0_0.Instance;
            var num = lib2.Numerator(context);
            Assert.IsTrue((bool?)num);
        }

        [TestMethod]
        public void BCSEHEDIS2022_Numerator_FromResource_Fail()
        {
            var lib = "BCSEHEDISMY2022";
            var version = "1.0.0";
            var dir = new DirectoryInfo("Resources");
            var asmContext = LibraryPackager.LoadResources(dir, lib, version);

            byte[] byteArray = File.ReadAllBytes("Inputs/Bundles/95029_fail.json");
            using var stream = new MemoryStream(byteArray);
            var patientBundle = LoadBundle(stream);

            var directory = new DirectoryInfo("Inputs/ValueSets");
            var valueSets = LoadValueSets(directory);// Add valuesets

            var context = FhirCqlContext.ForBundle(patientBundle, MY2022, valueSets);

            var results = asmContext.Run(lib, version, context);

            Assert.IsTrue(results.TryGetValue("Numerator", out var numerator));
            Assert.IsInstanceOfType(numerator, typeof(bool?));
            Assert.IsFalse((bool?)numerator);

            var lib2 = BCSEHEDISMY2022_1_0_0.Instance;
            var num = lib2.Numerator(context);
            Assert.IsFalse((bool?)num);
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
            var context = FhirCqlContext.ForBundle(patientEverything, MY2022, valueSets);

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var asmContext = LibraryPackager.LoadElm(elmDir, lib, version);
            var results = asmContext.Run(lib, version, context);
            var elapsed = stopwatch.Elapsed;
            stopwatch.Stop();
            Console.WriteLine($"Run 1: {elapsed}");

            Assert.IsTrue(results.TryGetValue("Numerator", out var numerator));
            Assert.IsInstanceOfType(numerator, typeof(bool?));
            Assert.IsFalse((bool?)numerator);

            // Run a second time with a (presumably) different bundle.
            var bundle2 = new Bundle();
            context = FhirCqlContext.ForBundle(bundle2, MY2022, valueSets);
            stopwatch.Restart();
            results = asmContext.Run(lib, version, context);
            elapsed = stopwatch.Elapsed;
            stopwatch.Stop();
            Console.WriteLine($"Run 2: {elapsed}");
            Assert.IsTrue(results.TryGetValue("Numerator", out numerator));
            Assert.IsInstanceOfType(numerator, typeof(bool?));
            Assert.IsFalse((bool?)numerator);
        }

    }
}