using Hl7.Cql.Compiler;
using Hl7.Cql.Fhir;
using Hl7.Cql.Graph;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Elm;
using Hl7.Cql.Packaging;

namespace CoreTests
{
    [TestClass]
    [TestCategory("UnitTest")]
    public partial class HL7Tests
    {
        public const string Cql15 = "CQL 1.5";
        public const string NotTestedByReferenceEngine = "Not tested by reference engine";
        public const string DoesNotConformToSpec = "Doesn't make sense";
        public const string DocumentationUnclear = "Case not covered by spec";
        public const string NotSupported = "Not supported";
        public const string BadTest = "Test is nonsensical";

        private static ILoggerFactory LoggerFactory { get; } = 
            Microsoft.Extensions.Logging.LoggerFactory
            .Create(logging => logging.AddDebug());

        private static readonly LambdasFacade LambdasByTestName = new();

        private class LambdasFacade
        {
            public LambdasFacade()
            {
                Lambdas = new DefinitionDictionary<LambdaExpression>();
            }
            public LambdaExpression this[string libraryName, string definition] =>
                Lambdas[$"{libraryName}-1.0.0", definition];

            public DefinitionDictionary<LambdaExpression> Lambdas { get; }
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            var hl7TestDirectory = new DirectoryInfo(@"Input\ELM\HL7");
            var fhirHelpersPackage = Hl7.Cql.Elm.Library.LoadFromJson(new FileInfo(@"Input\ELM\Libs\FHIRHelpers-4.0.1.json"));
            var libraryExpressionBuilder = NewLibraryExpressionBuilder();
            var definitions = libraryExpressionBuilder.ProcessLibrary(fhirHelpersPackage);
            LambdasByTestName.Lambdas.Merge(definitions);


            foreach (var file in hl7TestDirectory.GetFiles("*.json"))
            {
                var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(file);
                definitions = libraryExpressionBuilder.ProcessLibrary(elmPackage);
                LambdasByTestName.Lambdas.Merge(definitions);
            }

            var buildOrder = new DirectedGraph();
            MergeAllCqlInto(hl7TestDirectory, buildOrder);
            MergeAllCqlInto(new DirectoryInfo(@"Input\ELM\Libs"), buildOrder);

            var allDelegates = LambdasByTestName.Lambdas.CompileAll();
            Context = FhirCqlContext.WithDataSource(delegates: allDelegates);
        }

        private static LibraryExpressionBuilder NewLibraryExpressionBuilder()
        {
            return new LibraryExpressionBuilderFactory(LoggerFactory).LibraryExpressionBuilder;
        }

        internal static CqlContext Context;


        private static void MergeAllCqlInto(DirectoryInfo libsDirectory, DirectedGraph buildOrder)
        {
            foreach (var lib in libsDirectory.GetFiles().GroupBy(f => Path.GetFileNameWithoutExtension(f.Name)))
            {
                var elm = lib.SingleOrDefault(f => f.Extension == ".json");
                if (elm != null)
                {
                    var package = Hl7.Cql.Elm.Library.LoadFromJson(elm);
                    var includes = package.GetIncludedLibraries(new DirectoryInfo(@"Input\ELM\Libs"));
                    includes.MergeInto(buildOrder);
                }
            }
        }
    }
}
