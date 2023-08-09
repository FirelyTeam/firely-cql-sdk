using Hl7.Cql.Firely;
using Hl7.Cql.Packaging;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSetLoaders;
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
            var cqlContext = FirelyCqlContext.Create(patientEverything, MY2023);
            var bcs = new BCSEHEDISMY2022_1_0_0(cqlContext);
            var numerator = bcs.Numerator();
            Assert.IsFalse(numerator);
        }

        [TestMethod]
        public void BCSEHEDIS2022_Numerator_FromResource()
        {
            var lib = "BCSEHEDISMY2022";
            var version = "1.0.0";
            var dir = new DirectoryInfo("Resources");
            var asmContext = dir.LoadResources(lib, version);

            var patientEverything = new Bundle();   // Add data
            var valueSets = Enumerable.Empty<ValueSet>().ToValueSetDictionary();  // Add valuesets
            var cqlContext = FirelyCqlContext.Create(patientEverything, MY2023, valueSets);

            var results = asmContext.Run(lib, version, cqlContext);
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
            var cqlContext = FirelyCqlContext.Create(patientEverything, MY2023, valueSets);

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

        [TestMethod]
        public void DevDays()
        {
            var bundle = new Bundle();
            var suckedIntoJetEngine = new Condition();
            suckedIntoJetEngine.Onset = new FhirDateTime(2022, 6, 9);
            suckedIntoJetEngine.Code = new CodeableConcept("http://hl7.org/fhir/sid/icd-10", "V97.33");
            bundle.AddResourceEntry(suckedIntoJetEngine, "http://ncqa.org/fhir/test/devdays/condition-1");

            var rtx = FirelyCqlContext.Create(bundle, MY2023);
            var measure = new DevDays_2023_0_0(rtx);
            var ip = measure.Initial_population();
            Assert.IsTrue(ip);

            var numerator = measure.Numerator();
            Assert.IsFalse(numerator);

            var subsequentEncounter = new Condition();
            subsequentEncounter.Onset = new FhirDateTime(2022, 6, 10);
            subsequentEncounter.Code = new CodeableConcept("http://hl7.org/fhir/sid/icd-10", "V97.33XD");
            bundle.AddResourceEntry(subsequentEncounter, "http://ncqa.org/fhir/test/devdays/condition-2");

            measure = new DevDays_2023_0_0(rtx);
            numerator = measure.Numerator();
            Assert.IsTrue(numerator);

        }

    }
}