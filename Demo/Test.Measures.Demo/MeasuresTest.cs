using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;
using CoreTests;
using Hl7.Cql.Compiler;
using CLI.Helpers;
using CqlSdkPrototype.Elm;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Runtime;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Invocation;
using CqlSdkPrototype.Invocation.Extensions;
using CqlSdkPrototype.Invocation.Fluent.Extensions;

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
            var ctx = FhirCqlContext.ForBundle(patientEverything, MY2023);
            var bcs = BCSEHEDISMY2022_1_0_0.Instance;
            var numerator = bcs.Numerator(ctx);
            Assert.IsFalse(numerator);
        }

        [TestMethod]
        public void BCSEHEDIS2022_Numerator_FromResource_Passed()
        {
            var lib = "BCSEHEDISMY2022";
            var version = "1.0.0";
            var dir = LibrarySetsDirs.Demo.ResourcesDir;
            var scope = CreateRuntimeScopeFromFhirResourceFile(dir, lib, version);

            var patientEverything = new Bundle();   // Add data
            var valueSets = Enumerable.Empty<ValueSet>().ToValueSetDictionary();  // Add valuesets
            var ctx = FhirCqlContext.ForBundle(patientEverything, MY2023, valueSets);

            var results = scope
                .EnumerateLibraryDefinitionsResults(ctx, CqlVersionedLibraryIdentifier.FromNameAndVersion(CqlLibraryIdentifier.Parse(lib), CqlLibraryVersion.Parse(version)))
                .ToDictionary(t => t.definitionInvoker.DefinitionName, t => t.getResult());

            Assert.IsTrue(results.TryGetValue("Numerator", out var numerator));
            Assert.IsInstanceOfType(numerator, typeof(bool?));
            Assert.IsFalse((bool?)numerator);

            var lib2 = BCSEHEDISMY2022_1_0_0.Instance;
            var num = lib2.Numerator(ctx);
            Assert.IsFalse((bool?)num);
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
            using var scope = CreateRuntimeScopeFromElmLibraryFile(elmDir, lib, version);
            var results = Run(scope, lib, version, context);
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
            results = Run(scope, lib, version, context);
            elapsed = stopwatch.Elapsed;
            stopwatch.Stop();
            Console.WriteLine($"Run 2: {elapsed}");
            Assert.IsTrue(results.TryGetValue("Numerator", out numerator));
            Assert.IsInstanceOfType(numerator, typeof(bool?));
            Assert.IsFalse((bool?)numerator);
        }

        private static IReadOnlyDictionary<string, object?> Run(
            LibrarySetInvoker scope,
            string lib,
            string version,
            CqlContext context)
        {
            return scope
                   .EnumerateLibraryDefinitionsResults(context, CqlVersionedLibraryIdentifier.Parse($"{lib}-{version}"))
                   .ToDictionary(t => t.definitionInvoker.DefinitionName, t => t.getResult());
        }

        private static LibrarySetInvoker CreateRuntimeScopeFromFhirResourceFile(
            DirectoryInfo dir,
            string lib,
            string version)
        {
            var libFile = new FileInfo(Path.Combine(dir.FullName, $"Library-{lib}-{version}.json")); // Library-BCSEHEDISMY2022-1.0.0
            using var fs = libFile.OpenRead();
            var library = fs.ParseFhir<Library>();
            var allLibs = library.GetDependenciesAndSelf(dir);
            //Runtime
            return allLibs.ToLibrarySetInvoker();
        }

        private static LibrarySetInvoker CreateRuntimeScopeFromElmLibraryFile(
            DirectoryInfo elmDirectory,
            string lib,
            string version,
            LogLevel logLevel = LogLevel.Error,
            int cacheSize = 0)
        {
            var loggerFactory = new ServiceCollection()
                                .AddLogging(builder => builder.AddConsole().SetMinimumLevel(logLevel))
                                .BuildServiceProvider()
                                .GetRequiredService<ILoggerFactory>();

            return CreateRuntimeScopeFromElmLibraryFile(elmDirectory, lib, version, cacheSize, loggerFactory);
        }

        private static LibrarySetInvoker CreateRuntimeScopeFromElmLibraryFile(
            DirectoryInfo elmDirectory,
            string lib,
            string version,
            int cacheSize,
            ILoggerFactory? loggerFactory = null/*,
            Func<LibrarySetInvokerBuilderConfig, LibrarySetInvokerBuilderConfig>? configureLibrarySetInvokerBuilder = null*/)
        {
            LibrarySet librarySet = new();
            librarySet.LoadLibraryAndDependencies(elmDirectory, lib, version);

            var config = ElmToolkitConfig.Default;
            if (cacheSize != 0)
                config = config with { LRUCacheSize = cacheSize };

            if (Debugger.IsAttached)
                config = config with { AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.Embedded };

            var elmToolkit = new ElmToolkit(loggerFactory, config);

            return elmToolkit
                   .AddElmLibraries(librarySet)
                   .ToLibrarySetInvoker(/*configure: configureLibrarySetInvokerBuilder*/);
        }
    }
}