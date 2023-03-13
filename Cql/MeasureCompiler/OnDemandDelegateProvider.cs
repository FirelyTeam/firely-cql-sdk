using Microsoft.Extensions.Logging;
using Ncqa.Cql.Runtime;
using Ncqa.Elm;
using Ncqa.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ncqa.Cql.MeasureCompiler
{
    public class OnDemandDelegateProvider : IDelegateProvider, ILambdaProvider
    {
        public OnDemandDelegateProvider(IEnumerable<ElmPackage> packages,
            OperatorBinding binding,
            TypeManager typeManager,
            ILogger<ExpressionBuilder> logger,
            bool useCache = true,
            IDictionary<string, Func<ParameterExpression[], LambdaExpression>>? customImplementations = null,
            IList<IExpressionMutator>? mutators = null)
        {
            PackagesByNameAndVersionString = packages.ToDictionary(p => p.NameAndVersion);
            Binding = binding ?? throw new ArgumentNullException(nameof(binding));
            TypeManager = typeManager ?? throw new ArgumentNullException(nameof(typeManager));
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            UseCache = useCache;
            CustomImplementations = customImplementations;
            Mutators = mutators;
            if (UseCache && Mutators != null && Mutators.Any(m => m is CacheInvokedDefinitionsMutator))
                throw new ArgumentException($"{nameof(useCache)} is true but {nameof(Mutators)} contans an instance of {nameof(CacheInvokedDefinitionsMutator)}; either set useCache to false or don't add your own {nameof(CacheInvokedDefinitionsMutator)} to {nameof(Mutators)}", nameof(Mutators));
        }

        private readonly IDictionary<string, Func<ParameterExpression[], LambdaExpression>>? CustomImplementations;
        private readonly IList<IExpressionMutator>? Mutators;
        private readonly IDictionary<string, ElmPackage> PackagesByNameAndVersionString;
        private readonly ILogger<ExpressionBuilder> Logger;

        public OperatorBinding Binding { get; }
        public TypeManager TypeManager { get; }
        public bool UseCache { get; }

        public DirectedGraph GetDependenciesFor(string name, string? version)
        {
            var nav = ElmPackage.NameAndVersionFor(name, version);
            if (nav == null)
                throw new ArgumentNullException("Name and version could not be determined.", nameof(name));
            if (PackagesByNameAndVersionString.TryGetValue(nav!,
                out var package))
            {
                var includes = ElmPackage.GetIncludedLibraries(package, (n, v) =>
                {
                    var _nav = ElmPackage.NameAndVersionFor(n, v);
                    if (nav != null && PackagesByNameAndVersionString.TryGetValue(_nav!, out var dependency))
                        return dependency;
                    else throw new InvalidOperationException($"Package with name \"{name}\" and version \"{version}\" cannot be resolved.");
                });
                return includes;
            }
            else throw new ArgumentException($"Package with name \"{name}\" and version \"{version}\" cannot be resolved.", nameof(name));
        }

        public DefinitionDictionary<LambdaExpression> GetLambdaExpressionsFor(string name, string? version)
        {
            var dependencies = GetDependenciesFor(name, version);
            var allLambdas = new DefinitionDictionary<LambdaExpression>();
            foreach (var node in dependencies.Nodes.Values)
            {
                if (node.Properties != null)
                {
                    if (node.Properties.TryGetValue(ElmPackage.PackageNodeProperty, out var packageObject))
                    {
                        var libraryPackage = packageObject as ElmPackage;
                        var libNav = libraryPackage!.NameAndVersion;
                        var builder = new ExpressionBuilder(Binding, TypeManager, libraryPackage!, Logger);
                        if (CustomImplementations != null)
                        {
                            foreach (var kvp in CustomImplementations)
                            {
                                builder.CustomImplementations.Add(kvp);
                            }
                        }
                        if (Mutators != null)
                            foreach (var mutator in Mutators)
                                builder.ExpressionMutators.Add(mutator);

                        if (UseCache)
                        {
                            builder.ExpressionMutators.Add(new CacheInvokedDefinitionsMutator(libraryPackage.NameAndVersion, $"Cache_{libraryPackage!.NameAndVersion}"));
                        }
                        var lambdas = builder.Build();
                        allLambdas.Merge(lambdas);
                    }
                }
            }
            return allLambdas;
        }

        public DefinitionDictionary<Delegate> GetDelegatesFor(string name, string? version = null)
        {
            var lambdas = GetLambdaExpressionsFor(name, version);
            var delegates = lambdas.CompileAll();
            return delegates;
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
