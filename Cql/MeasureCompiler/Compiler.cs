using Microsoft.Extensions.Logging;
using Ncqa.Cql.Runtime;
using Ncqa.Elm;
using Ncqa.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Logging.Debug;
using System.Linq;
using System.Diagnostics;
using Ncqa.Cql.MeasureCompiler.CodeGeneration;
using System.Linq.Expressions;

namespace Ncqa.Cql.MeasureCompiler
{
    public class Compiler
    {
        private readonly IList<IExpressionMutator>? Mutators;
        private readonly Dictionary<string, DateTime> LastCompiled = new Dictionary<string, DateTime>();
        private readonly Dictionary<string, DefinitionDictionary<System.Linq.Expressions.LambdaExpression>> Lambdas = new Dictionary<string, DefinitionDictionary<System.Linq.Expressions.LambdaExpression>>();
        private readonly ILogger<Compiler> Logger;
        private readonly ILogger<SourceCodeWriter> WriterLogger;

        private const string TimeFormatString = "YYYY-MM-dd hh:mm:ss tt";
        public OperatorBinding Binding { get; }
        public TypeManager TypeManager { get; }
        public bool UseCache { get; }

        public IDictionary<string, Func<ParameterExpression[], LambdaExpression>> CustomImplementations { get; } 
            = new Dictionary<string, Func<ParameterExpression[], LambdaExpression>>();


        public Compiler(OperatorBinding binding, TypeManager typeManager, 
            bool useCache = true, 
            ILogger<Compiler>? logger = null, 
            ILogger<SourceCodeWriter>? writerLogger = null,
            IList<IExpressionMutator>? mutators = null)
        {
            Binding = binding ?? throw new ArgumentNullException(nameof(binding));
            TypeManager = typeManager ?? throw new ArgumentNullException(nameof(typeManager));
            UseCache = useCache;
            Mutators = mutators;
            var lf = LoggerFactory.Create(logging => logging.AddDebug());
            Logger = logger ?? lf.CreateLogger<Compiler>();
            WriterLogger = writerLogger ?? lf.CreateLogger<SourceCodeWriter>();
        }


        public DirectedGraph GetDependencyGraph(FileInfo elmFile, DirectoryInfo elmDirectory)
        {
            var buildOrder = new DirectedGraph();
            var package = ElmPackage.LoadFrom(elmFile);
            var includes = package!.GetIncludedLibraries(elmDirectory);
            MergeGraphInfo(includes, buildOrder);
            return buildOrder;
        }

        public DirectedGraph GetDependencyGraph(DirectoryInfo elmDirectory)
        {           
            var buildOrder = new DirectedGraph();
            foreach (var lib in elmDirectory.GetFiles("*.json"))
            {
                var package = ElmPackage.LoadFrom(lib);
                var includes = package!.GetIncludedLibraries(elmDirectory);
                MergeGraphInfo(includes, buildOrder);
            }
            return buildOrder;
        }

        public DefinitionDictionary<LambdaExpression> Compile(DirectoryInfo elmPath,
            FileInfo? specificFile,
            bool force,
            ILogger<ExpressionBuilder> logger)
        {
            var lambdas = new DefinitionDictionary<System.Linq.Expressions.LambdaExpression>();
            var buildOrder = new DirectedGraph();
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            if (specificFile == null)
            {
                Logger.LogInformation("Compiling all ELM files");
                PrepareLambdas(elmPath, lambdas, buildOrder, force, logger);
            }
            else
            {
                if (specificFile.Exists)
                {
                    Logger.LogInformation($"Compiling ELM file {specificFile.Name}");
                    try
                    {
                        PrepareLambdasForSingleFile(specificFile, elmPath, lambdas, buildOrder, force, logger);
                    }catch (Exception ex)
                    {
                        Logger.LogError(ex, $"Could not compile: {specificFile.Name}");
                    }
                }
                else
                {
                    var msg = $"ELM file {specificFile.FullName} does not exist.";
                    var ex = new InvalidOperationException(msg);
                    Logger.LogError(ex, msg);
                    throw ex;
                }
            }
            stopwatch.Stop();
            long elapsed = stopwatch.ElapsedMilliseconds;
            Logger.LogTrace($"Finished compiling ELM in {TimeSpan.FromMilliseconds(elapsed)}");
            return lambdas;
        }

        public void WriteCSharp(DirectedGraph buildOrder,
            DefinitionDictionary<System.Linq.Expressions.LambdaExpression> lambdas,
            DirectoryInfo csDir,
            IList<string>? usings = null,
            IList<(string,string)>? aliasedUsings = null,
            string? @namespace = null,
            bool forDebugging = false)
        {
            Logger.LogTrace($"Writing CS source files");
            var sourceCodeWriter = new SourceCodeWriter(WriterLogger, forDebugging);
            if (usings != null)
                foreach (var @using in usings)
                    sourceCodeWriter.Usings.Add(@using);
            if (aliasedUsings != null)
                foreach (var tuple in aliasedUsings)
                    sourceCodeWriter.AliasedUsings.Add(tuple);

            sourceCodeWriter.Namespace = @namespace;

            if (!csDir.Exists)
                csDir.Create();
            sourceCodeWriter.Write(lambdas,
                buildOrder,
                lib => new FileStream(Path.Combine(csDir.FullName, $"{lib}.cs"), FileMode.Create));
        }

        private void PrepareLambdasForSingleFile(FileInfo elmFileInfo,
            DirectoryInfo elmDirectory,
            DefinitionDictionary<System.Linq.Expressions.LambdaExpression> output,
            DirectedGraph buildOrder,
            bool force,
            ILogger<ExpressionBuilder> logger)
        {
            if (logger is null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            var thisPackage = ElmPackage.LoadFrom(elmFileInfo);
            var includes = thisPackage!.GetIncludedLibraries(elmDirectory);
            MergeGraphInfo(includes, buildOrder);

            foreach (var node in includes.Nodes.Values)
            {
                if (node.Properties != null)
                {
                    if (node.Properties.TryGetValue(ElmPackage.PackageNodeProperty, out var packageObject))
                    {
                        if (packageObject is ElmPackage libraryPackage)
                        {
                            var build = force;
                            var libNav = libraryPackage.NameAndVersion;
                            if (!Lambdas.TryGetValue(libNav, out var existingLambdas))
                            {
                                Logger.LogTrace($"No previous entry found for {libNav}, so compiling.");
                                build = true;
                            }
                            if (!build && LastCompiled.TryGetValue(libNav, out var lastCompiled))
                            {
                                Logger.LogTrace($"{libNav} last compiled on {lastCompiled.ToString(TimeFormatString)}");
                                if (lastCompiled <= elmFileInfo.LastWriteTime)
                                {
                                    Logger.LogTrace($"ELM file last write time is {elmFileInfo.LastWriteTime.ToString(TimeFormatString)}, which is newer than last compiled.");
                                    build = true;
                                }
                            }
                            if (build)
                            {
                                try
                                {
                                    var builder = new ExpressionBuilder(Binding, TypeManager, libraryPackage!, logger);
                                    foreach (var kvp in CustomImplementations)
                                        builder.CustomImplementations.Add(kvp);
                                    if (Mutators != null)
                                        foreach (var mutator in Mutators)
                                            builder.ExpressionMutators.Add(mutator);

                                    if (UseCache)
                                    {
                                        builder.ExpressionMutators.Add(new CacheInvokedDefinitionsMutator(libraryPackage.NameAndVersion, $"Cache_{libraryPackage!.NameAndVersion}"));
                                    }
                                    var libLambdas = builder.Build();
                                    Lambdas[libNav] = libLambdas;
                                    LastCompiled[libNav] = DateTime.Now;
                                    output.Merge(libLambdas);
                                    Logger.LogInformation($"Successfully built {libNav}");
                                }
                                catch (Exception ex)
                                {
                                    Logger.LogError(ex, $"Failed to build {libNav}");
                                    continue;
                                }
                            }
                            else
                            {
                                Logger.LogInformation($"Skipping {libNav}; up-to-date");
                                output.Merge(existingLambdas!);
                            }
                        }
                    }
                }
            }
        }


        private void PrepareLambdas(DirectoryInfo elmDirectory,
            DefinitionDictionary<System.Linq.Expressions.LambdaExpression> output,
            DirectedGraph buildOrder,
            bool force,
            ILogger<ExpressionBuilder> logger)
        {
            foreach (var lib in elmDirectory.GetFiles("*.json"))
            {
                PrepareLambdasForSingleFile(lib, elmDirectory, output, buildOrder, force, logger);
            }
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
