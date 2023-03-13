using Microsoft.Extensions.Logging;
using Ncqa.Cql.Runtime;
using Ncqa.Elm;
using Ncqa.Graph;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Ncqa.Cql.MeasureCompiler
{
    public static class Build
    {
        public static DefinitionDictionary<System.Linq.Expressions.LambdaExpression> Lambdas(TypeResolver resolver,
            OperatorBinding operatorBinding,
            DirectoryInfo elmPath, 
            FileInfo? specificFile,
            ILogger<ExpressionBuilder> logger)
        {
            var all = new DefinitionDictionary<System.Linq.Expressions.LambdaExpression>();
            var buildOrder = new DirectedGraph();
            var typeManager = new TypeManager(resolver);
            if (specificFile == null)
                PrepareLambdas(elmPath, all, buildOrder, operatorBinding, typeManager, logger);
            else PrepareLambdasForSingleFile(specificFile, elmPath, all, buildOrder, operatorBinding, typeManager, logger);
            return all;
        }


        private static void PrepareLambdas(DirectoryInfo elmDirectory,
            DefinitionDictionary<System.Linq.Expressions.LambdaExpression> output,
            DirectedGraph buildOrder,
            OperatorBinding operatorBinding,
            TypeManager typeManager,
            ILogger<ExpressionBuilder> logger)
        {
            foreach (var lib in elmDirectory.GetFiles().GroupBy(f => Path.GetFileNameWithoutExtension(f.Name)))
            {
                var elmFileInfo = lib.Single(f => f.Extension == ".json");
                PrepareLambdasForSingleFile(elmFileInfo, elmDirectory, output, buildOrder, operatorBinding, typeManager, logger);
            }
        }

        private static void PrepareLambdasForSingleFile(
            FileInfo elmFileInfo,
            DirectoryInfo elmDirectory,
            DefinitionDictionary<System.Linq.Expressions.LambdaExpression> output,
            DirectedGraph buildOrder,
            OperatorBinding operatorBinding,
            TypeManager typeManager,
            ILogger<ExpressionBuilder> logger)

        {
            if (logger is null)
            {
                throw new ArgumentNullException(nameof(logger));
            }
            var settings = new JsonSerializerSettings
            {
                Converters = new[] { new ElmExpressionConverter() },
                DateParseHandling = DateParseHandling.None,
                MaxDepth = 1024,
            };
            var thisPackage = JsonConvert.DeserializeObject<ElmPackage>(File.ReadAllText(elmFileInfo.FullName), settings);
            var includes = thisPackage!.GetIncludedLibraries(elmDirectory);
            MergeGraphInfo(includes, buildOrder);

            foreach (var node in includes.Nodes.Values)
            {
                if (node.Properties != null)
                {
                    if (node.Properties.TryGetValue(ElmPackage.PackageNodeProperty, out var packageObject))
                    {
                        var libraryPackage = packageObject as ElmPackage;
                        var libraryBuilder = new ExpressionBuilder(operatorBinding, typeManager, libraryPackage!, logger);
                        var libraryLambdas = libraryBuilder.Build();
                        foreach (var libLib in libraryLambdas.Libraries)
                        {
                            string libNav = libLib;
                            if (output.Libraries.Contains(libNav) == false)
                            {
                                var libBuilder = new ExpressionBuilder(operatorBinding, typeManager, libraryPackage!, logger);
                                var libLambdas = libBuilder.Build();
                                output.Merge(libLambdas);
                            }
                        }
                    }
                }
            }



        }

        private static void MergeGraphInfo(DirectedGraph graph, DirectedGraph into)
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
