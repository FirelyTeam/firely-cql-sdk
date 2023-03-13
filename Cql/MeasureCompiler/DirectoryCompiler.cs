using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using Ncqa.Cql.MeasureCompiler.CodeGeneration;
using Ncqa.Cql.Runtime;
using Ncqa.Elm;
using Ncqa.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ncqa.Cql.MeasureCompiler
{
    public class DirectoryCompiler
    {
        private readonly Dictionary<string, ElmPackage> Packages = new Dictionary<string, ElmPackage>();
        private readonly ILogger<DirectoryCompiler> CompilerLogger;
        private readonly ILogger<ExpressionBuilder> BuilderLogger;
        private readonly ILogger<SourceCodeWriter> WriterLogger;


        public OperatorBinding Binding { get; }
        public TypeManager TypeManager { get; }
        public bool UseCache { get; }

        public DirectoryCompiler(DirectoryInfo directory,
            OperatorBinding binding,
            TypeManager typeManager,
            ILogger<DirectoryCompiler> compilerLogger,
            ILogger<ExpressionBuilder> builderLogger,
            ILogger<SourceCodeWriter> writerLogger,
            bool useCache = true)
        {
            Directory = directory ?? throw new ArgumentNullException(nameof(directory));
            Binding = binding ?? throw new ArgumentNullException(nameof(binding));
            TypeManager = typeManager ?? throw new ArgumentNullException(nameof(typeManager));
            CompilerLogger = compilerLogger ?? throw new ArgumentNullException(nameof(compilerLogger));
            BuilderLogger = builderLogger ?? throw new ArgumentNullException(nameof(builderLogger));
            WriterLogger = writerLogger;
            UseCache = useCache;
        }

        public IDictionary<string, Func<ParameterExpression[], LambdaExpression>> CustomImplementations { get; }
            = new Dictionary<string, Func<ParameterExpression[], LambdaExpression>>();

        public DirectoryInfo Directory { get; }

        public DirectedGraph GetPackageGraph()
        {
            var buildOrder = new DirectedGraph();
            foreach (var lib in Directory.GetFiles("*.json"))
            {
                if (!Packages.TryGetValue(Path.GetFileNameWithoutExtension(lib.Name), out var package))
                {
                    package = ElmPackage.LoadFrom(lib)
                        ?? throw new InvalidOperationException($"Cannot deserialize ELM from {lib.FullName}");
                    var includes = ElmPackage.GetIncludedLibraries(package, (name, version) =>
                    {
                        var id = ElmPackage.NameAndVersionFor(name, version);
                        if (id != null)
                        {
                            if (Packages.TryGetValue(id, out var dependency))
                                return dependency;
                            else
                            {
                                var fi = new FileInfo(Path.Combine(Directory.FullName, $"{id}.json"));
                                if (fi.Exists == false)
                                    throw new InvalidOperationException($"ELM json at {fi.FullName} does not exist");
                                dependency = ElmPackage.LoadFrom(fi)!;
                                Packages.Add(id, dependency);
                                return dependency;
                            }
                        }
                        else throw new InvalidOperationException($"Package's name and version cannot be resolved");
                    });
                    MergeGraphInfo(includes, buildOrder);
                }
            }
            return buildOrder;
        }

        public DefinitionDictionary<LambdaExpression> Compile(DirectedGraph packageGraph,
            DefinitionDictionary<LambdaExpression>? output = null,
            IList<IExpressionMutator>? mutators = null)
        {
            output ??= new DefinitionDictionary<LambdaExpression>();
            foreach (var node in packageGraph.Nodes.Values)
            {
                if (node.Properties != null)
                {
                    if (node.Properties.TryGetValue(ElmPackage.PackageNodeProperty, out var packageObject))
                    {
                        if (packageObject is ElmPackage libraryPackage)
                        {
                            var libNav = libraryPackage.NameAndVersion;
                            try
                            {
                                var builder = new ExpressionBuilder(Binding, TypeManager, libraryPackage!, BuilderLogger);
                                foreach (var kvp in CustomImplementations)
                                    builder.CustomImplementations.Add(kvp);
                                if (mutators != null)
                                    foreach (var mutator in mutators)
                                        builder.ExpressionMutators.Add(mutator);

                                if (UseCache)
                                {
                                    builder.ExpressionMutators.Add(new CacheInvokedDefinitionsMutator(libraryPackage.NameAndVersion, $"Cache_{libraryPackage!.NameAndVersion}"));
                                }
                                var libLambdas = builder.Build();
                                output.Merge(libLambdas);
                                CompilerLogger.LogInformation($"Successfully built {libNav}");
                            }
                            catch (Exception ex)
                            {
                                CompilerLogger.LogError(ex, $"Failed to build {libNav}");
                                continue;
                            }
                        }
                        else continue;
                    }
                }
            }
            return output;
        }

        public void WriteCSharp(DirectedGraph packageGraph,
            DefinitionDictionary<LambdaExpression> lambdas,
            DirectoryInfo csDir,
            IList<string>? usings = null,
            IList<(string, string)>? aliasedUsings = null,
            bool forDebugging = false)
        {
            CompilerLogger.LogTrace($"Writing CS source files");
            var sourceCodeWriter = new SourceCodeWriter(WriterLogger, forDebugging);
            if (usings != null)
                foreach (var @using in usings)
                    sourceCodeWriter.Usings.Add(@using);
            if (aliasedUsings != null)
                foreach (var tuple in aliasedUsings)
                    sourceCodeWriter.AliasedUsings.Add(tuple);

            if (!csDir.Exists)
                csDir.Create();
            sourceCodeWriter.Write(lambdas,
                packageGraph,
                lib => new FileStream(Path.Combine(csDir.FullName, $"{lib}.cs"), FileMode.Create));
        }

        private void MergeGraphInfo(DirectedGraph graph, DirectedGraph into)
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
