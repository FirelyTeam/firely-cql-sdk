using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Builders;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq.Expressions;

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
            var libraryExpressionBuilder = NewLibraryDefinitionsBuilder();
            var definitions = libraryExpressionBuilder.ProcessLibrary(fhirHelpersPackage);
            LambdasByTestName.Lambdas.Merge(definitions);


            foreach (var file in hl7TestDirectory.GetFiles("*.json"))
            {
                var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(file);
                definitions = libraryExpressionBuilder.ProcessLibrary(elmPackage);
                LambdasByTestName.Lambdas.Merge(definitions);
            }

            var librarySet = new LibrarySet();
            librarySet.LoadLibraries(hl7TestDirectory.GetFiles("*.json", SearchOption.TopDirectoryOnly));
            librarySet.LoadLibraries(new DirectoryInfo(@"Input\ELM\Libs").GetFiles("*.json", SearchOption.TopDirectoryOnly));

            var allDelegates = LambdasByTestName.Lambdas.CompileAll();
            Context = FhirCqlContext.WithDataSource(delegates: allDelegates);
        }

        private static LibraryDefinitionsBuilder NewLibraryDefinitionsBuilder()
        {
            return new CqlCompilerFactory(LoggerFactory).LibraryDefinitionsBuilder;
        }

        internal static CqlContext Context;
    }
}
