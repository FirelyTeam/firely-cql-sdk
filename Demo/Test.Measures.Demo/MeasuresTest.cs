/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;
using CoreTests;
using Hl7.Cql.Compiler;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Runtime;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Packaging.Internal;

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
            var patientEverything = new Bundle(); // add some data
            var ctx = FhirCqlContext.ForBundle(patientEverything, MY2023);
            var bcs = BCSEHEDISMY2022_1_0_0.Instance;
            var numerator = bcs.Numerator(ctx);
            Assert.IsFalse(numerator);
        }

        [TestMethod]
        public void BCSEHEDIS2022_Numerator_FromResource_Passed()
        {
            var libraryIdentifier = CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion("BCSEHEDISMY2022", "1.0.0");
            var dir = LibrarySetsDirs.Demo.ResourcesDir;
            var loggerFactory = LoggerFactory.Create(lb => lb.AddConsole());
            using var librarySetInvoker = new InvocationToolkit(loggerFactory)
                                          .AddAssemblyBinariesFromFhirLibraryAndDependencies(
                                              libraryIdentifier,
                                              ResourceFileInfoResolvers.FromDirectory(dir))
                                          .CreateLibrarySetInvoker(libraryIdentifier);
            Assert.AreEqual(12, librarySetInvoker.LibraryInvokers.Count);

            var patientEverything = new Bundle();                                // Add data
            var valueSets = Enumerable.Empty<ValueSet>().ToValueSetDictionary(); // Add valuesets
            var ctx = FhirCqlContext.ForBundle(patientEverything, MY2023, valueSets);

            var results = librarySetInvoker
                          .SelectExpressionsForLibrary(libraryIdentifier)
                          .SelectResults(ctx)
                          .ToDictionary(t => t.definitionInvoker.DefinitionName, t => t.invocationResult);

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

            var patientEverything = new Bundle();                                // Add some data
            var valueSets = Enumerable.Empty<ValueSet>().ToValueSetDictionary(); // Add valuesets
            var context = FhirCqlContext.ForBundle(patientEverything, MY2023, valueSets);

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            using var librarySetInvoker = CreateLibrarySetInvokerFromElmLibraryFile(elmDir, lib, version);
            var results = Run(librarySetInvoker, lib, version, context);
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
            results = Run(librarySetInvoker, lib, version, context);
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
                   .SelectExpressionsForLibrary((CqlVersionedLibraryIdentifier)$"{lib}-{version}")
                   .SelectResults(context)
                   .ToDictionary(t => t.definitionInvoker.DefinitionName, t => t.invocationResult);
        }

        private static LibrarySetInvoker CreateLibrarySetInvokerFromElmLibraryFile(
            DirectoryInfo elmDirectory,
            string lib,
            string version,
            LogLevel logLevel = LogLevel.Error,
            int cacheSize = 0)
        {
            var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole().SetMinimumLevel(logLevel));

            return CreateLibrarySetInvokerFromElmLibraryFile(elmDirectory, lib, version, cacheSize, loggerFactory);
        }

        private static LibrarySetInvoker CreateLibrarySetInvokerFromElmLibraryFile(
            DirectoryInfo elmDirectory,
            string lib,
            string version,
            int cacheSize,
            ILoggerFactory? loggerFactory = null)
        {
            LibrarySet librarySet = new();
            librarySet.LoadLibraryAndDependencies(elmDirectory, lib, version);

            var config = ElmToolkitConfig.Default;
            if (cacheSize != 0)
                config = config with { LRUCacheSize = cacheSize };

            if (Debugger.IsAttached)
                config = config with { DebugSymbolsFormat = DebugSymbolsFormat.Embedded };

            var elmToolkit = new ElmToolkit(loggerFactory, config);

            return elmToolkit
                   .AddElmLibraries(librarySet)
                   .CreateLibrarySetInvoker( /*configure: configureLibrarySetInvokerBuilder*/);
        }
    }
}
