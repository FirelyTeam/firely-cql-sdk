using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;
using System.Diagnostics;
using System.Runtime.Loader;
using CoreTests;
using Hl7.Cql.Compiler;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;

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
            var context = FhirCqlContext.ForBundle(patientEverything, MY2023);
            var bcs = new BCSEHEDISMY2022_1_0_0(context);
            var numerator = bcs.Numerator();
            Assert.IsFalse(numerator);
        }

        [TestMethod]
        public void BCSEHEDIS2022_Numerator_FromResource()
        {
            var lib = "BCSEHEDISMY2022";
            var version = "1.0.0";
            var dir = LibrarySetsDirs.Demo.ResourcesDir;// new DirectoryInfo("Resources");
            var asmContext = LoadResources(dir, lib, version);

            var patientEverything = new Bundle();   // Add data
            var valueSets = Enumerable.Empty<ValueSet>().ToValueSetDictionary();  // Add valuesets
            var context = FhirCqlContext.ForBundle(patientEverything, MY2023, valueSets);

            var results = asmContext.Run(lib, version, context);
            Assert.IsTrue(results.TryGetValue("Numerator", out var numerator));
            Assert.IsInstanceOfType(numerator, typeof(bool?));
            Assert.IsFalse((bool?)numerator);
        }

        [TestMethod]
        public void BCSEHEDIS2022_Numerator_FromElm()
        {
            var elmDir = LibrarySetsDirs.Demo.ElmDir;
            Assert.IsTrue(elmDir.Exists);

            var lib = "BCSEHEDISMY2022";
            var version = "1.0.0";

            var patientEverything = new Bundle();  // Add some data
            var valueSets = Enumerable.Empty<ValueSet>().ToValueSetDictionary();  // Add valuesets
            var context = FhirCqlContext.ForBundle(patientEverything, MY2023, valueSets);

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var asmContext = LoadElm(elmDir, lib, version);
            var results = asmContext.Run(lib, version, context);
            var elapsed = stopwatch.Elapsed;
            stopwatch.Stop();
            Console.WriteLine($"Run 1: {elapsed}");

            Assert.IsTrue(results.TryGetValue("Numerator", out var numerator));
            Assert.IsInstanceOfType(numerator, typeof(bool?));
            Assert.IsFalse((bool?)numerator);

            // Run a second time with a (presumably) different bundle.
            var bundle2 = new Bundle();
            context = FhirCqlContext.ForBundle(bundle2, MY2023, valueSets);
            stopwatch.Restart();
            results = asmContext.Run(lib, version, context);
            elapsed = stopwatch.Elapsed;
            stopwatch.Stop();
            Console.WriteLine($"Run 2: {elapsed}");
            Assert.IsTrue(results.TryGetValue("Numerator", out numerator));
            Assert.IsInstanceOfType(numerator, typeof(bool?));
            Assert.IsFalse((bool?)numerator);
        }

        [UsedImplicitly]
        public static AssemblyLoadContext LoadResources(
            DirectoryInfo dir,
            string lib,
            string version)
        {
            var libFile = new FileInfo(Path.Combine(dir.FullName, $"{lib}-{version}.json"));
            using var fs = libFile.OpenRead();
            var library = fs.ParseFhir<Library>();
            var dependencies = library.GetDependencies(dir);
            var allLibs = dependencies.AllLibraries();
            var asmContext = new AssemblyLoadContext($"{lib}-{version}");
            allLibs.LoadAssemblies(asmContext);

            var tupleTypes = new FileInfo(Path.Combine(dir.FullName, "TupleTypes-Binary.json"));
            using var tupleFs = tupleTypes.OpenRead();
            var binaries = new[]
            {
                tupleFs.ParseFhir<Binary>()
            };

            binaries.LoadAssembles(asmContext);
            return asmContext;
        }

        [UsedImplicitly]
        public static AssemblyLoadContext LoadElm(
            DirectoryInfo elmDirectory,
            string lib,
            string version,
            LogLevel logLevel = LogLevel.Error,
            int cacheSize = 0)
        {
            var logFactory = LoggerFactory
                .Create(logging =>
                {
                    logging.AddFilter(level => level >= logLevel);
                    logging.AddConsole(console =>
                    {
                        console.LogToStandardErrorThreshold = LogLevel.Error;
                    });
                });
            return LoadElm(elmDirectory, lib, version, logFactory, cacheSize);
        }

        [UsedImplicitly]
        public static AssemblyLoadContext LoadElm(
            DirectoryInfo elmDirectory,
            string lib,
            string version,
            ILoggerFactory logFactory,
            int cacheSize)
        {
            LibrarySet librarySet = new();
            librarySet.LoadLibraryAndDependencies(elmDirectory, lib, version);
            CqlPackagerFactory factory = new CqlPackagerFactory(logFactory, cacheSize);
            var definitions = factory.LibrarySetExpressionBuilder.ProcessLibrarySet(librarySet);
            var assemblyData = factory.AssemblyCompiler.Compile(librarySet, definitions);
            var asmContext = new AssemblyLoadContext($"{lib}-{version}");
            foreach (var (_, asmData) in assemblyData)
            {
                var assemblyBytes = asmData.Binary;
                using var ms = new MemoryStream(assemblyBytes);
                asmContext.LoadFromStream(ms);
            }
            return asmContext;
        }
    }
}