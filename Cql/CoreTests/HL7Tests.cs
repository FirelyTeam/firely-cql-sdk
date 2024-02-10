using Hl7.Cql.Compiler;
using Hl7.Cql.Fhir;
using Hl7.Cql.Graph;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using Library = Hl7.Cql.Elm.Library;

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

        private static ILogger<ExpressionBuilder> CreateLogger() => LoggerFactory
            .Create(logging => logging.AddDebug())
            .CreateLogger<ExpressionBuilder>();

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
            var resolver = new FhirTypeResolver(ModelInfo.ModelInspector);
            var binding = new CqlOperatorsBinding(resolver, FhirTypeConverter.Create(Hl7.Fhir.Model.ModelInfo.ModelInspector));
            var typeManager = new TypeManager(resolver);

            var fhirHelpersPackage = Hl7.Cql.Elm.Library.LoadFromJson(new FileInfo(@"Input\ELM\Libs\FHIRHelpers-4.0.1.json"));
            var fhirHelpersBuilder = new ExpressionBuilder(binding, typeManager, fhirHelpersPackage, CreateLogger());
            var fhirHelpersLambdas = fhirHelpersBuilder.BuildDefinitions();
            LambdasByTestName.Lambdas.Merge(fhirHelpersLambdas);


            foreach (var file in hl7TestDirectory.GetFiles("*.json"))
            {
                //if (file.Name == "CqlComparisonOperatorsTest.json"
                //    || file.Name == "CqlConditionalOperatorsTest.json")
                //    continue;
                var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(file);
                var includes = elmPackage.GetIncludedLibraries(new DirectoryInfo(@"Input\ELM\Libs"));
                var builder = new ExpressionBuilder(binding, typeManager, elmPackage, CreateLogger());
                var lambdas = builder.BuildDefinitions();
                LambdasByTestName.Lambdas.Merge(lambdas);
            }

            var buildOrder = new DirectedGraph();
            MergeAllCqlInto(hl7TestDirectory, buildOrder);
            MergeAllCqlInto(new DirectoryInfo(@"Input\ELM\Libs"), buildOrder);

            var logFactory = LoggerFactory
                .Create(logging =>
                {
                    logging.AddConsole();
                });

            var allDelegates = LambdasByTestName.Lambdas.CompileAll();
            Context = FhirCqlContext.WithDataSource(delegates: allDelegates);
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
                    MergeGraphInto(includes, buildOrder);
                }
            }
        }

        private static void MergeGraphInto(DirectedGraph graph, DirectedGraph into)
        {
            foreach (var sourceNode in graph.Nodes)
            {
                if (!into.Nodes.ContainsKey(sourceNode.Key))
                    into.Add(sourceNode.Value);
            }
            foreach (var edge in graph.Edges)
            {
                if (!into.Edges.ContainsKey(edge.Key))
                    into.Add(edge.Value);
            }
            var orphaned = true;
            foreach (var edge in into.Edges)
            {
                if (edge.Value.ToId == graph.StartNode.NodeId)
                {
                    orphaned = false;
                    break;
                }
            }
            if (orphaned)
            {
                into.Add(new DirectedGraphEdge(into.StartNode.NodeId, graph.StartNode.NodeId));
            }
        }
    }

}
