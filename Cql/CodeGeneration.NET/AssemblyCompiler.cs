#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Elm;
using Hl7.Cql.Graph;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;

namespace Hl7.Cql.Compiler
{
    public class AssemblyCompiler
    {
        public AssemblyCompiler(TypeResolver typeResolver,
            TypeManager? typeManager = null,
            OperatorBinding? operatorBinding = null)
        {
            TypeResolver = typeResolver;
            TypeManager = typeManager ?? new TypeManager(typeResolver);
            Binding = operatorBinding ?? new CqlOperatorsBinding(typeResolver);
        }

        public TypeResolver TypeResolver { get; }
        public TypeManager TypeManager { get; }
        public OperatorBinding Binding { get; }

        public AssemblyLoadContext Load(IEnumerable<Library> elmPackages,
                    ILogger<ExpressionBuilder>? builderLogger = null,
                    ILogger<CSharpSourceCodeWriter>? codeWriterLogger = null,
                    LogLevel logLevel = LogLevel.Information)
        {
            var assemblies = Compile(elmPackages, builderLogger, codeWriterLogger, logLevel);
            var assemblyLoadContext = new AssemblyLoadContext("UnitTest", false);
            foreach (var kvp in assemblies)
            {
                using var ms = new MemoryStream(kvp.Value.Binary);
                assemblyLoadContext.LoadFromStream(ms);
            }
            return assemblyLoadContext;
        }

        public IDictionary<string, AssemblyData> Compile(IEnumerable<Library> elmPackages,
                    ILogger<ExpressionBuilder>? builderLogger = null,
                    ILogger<CSharpSourceCodeWriter>? codeWriterLogger = null,
                    LogLevel logLevel = LogLevel.Information)
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
            builderLogger ??= logFactory.CreateLogger<ExpressionBuilder>();
            codeWriterLogger ??= logFactory.CreateLogger<CSharpSourceCodeWriter>();

            var graph = Library.GetIncludedLibraries(elmPackages);
            var references = new[]
            {
            // Core engine references
                typeof(Hl7.Cql.CqlDeclarationAttribute).Assembly, // Cql.Abstractions
                typeof(Hl7.Cql.Comparers.CqlComparers).Assembly, // Cql.Comparers
                typeof(Hl7.Cql.Conversion.IUnitConverter).Assembly, // Cql.Conversion
                typeof(Hl7.Cql.Operators.ICqlOperators).Assembly, // Cql.Operators
                typeof(Hl7.Cql.Primitives.CqlPrimitiveType).Assembly, // Cql.Primitives
                typeof(Hl7.Cql.Runtime.CqlContext).Assembly, // Cql.Runtime
                typeof(Hl7.Cql.ValueSets.IValueSetDictionary).Assembly, // Cql.ValueSets
                typeof(Hl7.Cql.Iso8601.DateIso8601).Assembly, // Iso8601
            }
            .Concat(TypeResolver.ModelAssemblies)
            .Distinct()
            .ToArray();

            var namespaces = new[]
            {
                typeof(CqlDeclarationAttribute).Namespace!,
                typeof(ValueSetFacade).Namespace!,
                typeof(Iso8601.DateIso8601).Namespace!,
            }
            .Concat(TypeResolver.ModelNamespaces)
            .Distinct()
            .ToArray();

            var scw = new CSharpSourceCodeWriter(codeWriterLogger);
            foreach (var @using in namespaces)
                scw.Usings.Add(@using);
            var aliases = TypeResolver.Aliases;
            foreach (var alias in aliases)
                scw.AliasedUsings.Add(alias);


            var all = new DefinitionDictionary<LambdaExpression>();
            foreach (var package in elmPackages)
            {
                var builder = new ExpressionBuilder(Binding, TypeManager, package, builderLogger);
                var expressions = builder.Build();
                all.Merge(expressions);
            }

            var navToLibraryStream = new Dictionary<string, Stream>();
            var assemblies = Generate(all,
                TypeManager,
                graph,
                scw,
                navToLibraryStream,
                references);
            return assemblies;
        }


        private IDictionary<string, AssemblyData> Generate(DefinitionDictionary<LambdaExpression> expressions,
           TypeManager typeManager,
           DirectedGraph dependencies,
           CSharpSourceCodeWriter writer,
           Dictionary<string, Stream> navToLibraryStream,
           IEnumerable<Assembly> references)
        {
            Stream getStreamForLibrary(string nav)
            {
                if (!navToLibraryStream.TryGetValue(nav, out var stream))
                {
                    stream = new MemoryStream();
                    navToLibraryStream.Add(nav, stream);
                }
                return stream;
            }
            writer.Write(expressions,
                typeManager.TupleTypes,
                dependencies,
                getStreamForLibrary,
                closeStream: false);

            var assemblies = new Dictionary<string, AssemblyData>();
            var tupleStreams = navToLibraryStream
                .Where(kvp => kvp.Key.StartsWith("Tuples\\"));
            var tupleAssembly = CompileTuples(tupleStreams, references);
            var additionalReferences = new[]
            {
                tupleAssembly
            };
            assemblies.Add("TupleTypes", tupleAssembly);
            var buildOrder = DetermineBuildOrder(dependencies);
            foreach (var node in buildOrder)
            {
                if (!navToLibraryStream.TryGetValue(node.NodeId, out var sourceCodeStream))
                    throw new InvalidOperationException($"Library {node.NodeId} doesn't exist in the source code dictionary.");
                CompileNode(sourceCodeStream, assemblies, node, references, additionalReferences);
            }
            return assemblies;
        }

        private AssemblyData CompileTuples(IEnumerable<KeyValuePair<string, Stream>> tupleStreams,
            IEnumerable<Assembly> assemblyReferences)
        {
            var metadataReferences = new List<MetadataReference>();
            AddNetCoreReferences(metadataReferences);
            foreach (var asm in assemblyReferences)
            {
                metadataReferences.Add(MetadataReference.CreateFromFile(asm.Location));
            }
            var compilation = CSharpCompilation.Create($"Tuples")
                .WithOptions(new CSharpCompilationOptions(outputKind: OutputKind.DynamicallyLinkedLibrary,
                    optimizationLevel: OptimizationLevel.Release))
                .WithReferences(metadataReferences);

            var sources = new Dictionary<string, string>();
            foreach (var kvp in tupleStreams)
            {
                var sourceCodeStream = kvp.Value;
                sourceCodeStream.Flush();
                sourceCodeStream.Seek(0, SeekOrigin.Begin);
                var reader = new StreamReader(sourceCodeStream);
                var sourceCode = reader.ReadToEnd().Trim();
                sources.Add(kvp.Key.Substring("Tuples\\".Length), sourceCode);
                var tree = SyntaxFactory.ParseSyntaxTree(sourceCode);

                compilation = compilation.AddSyntaxTrees(tree);
            }
            var codeStream = new MemoryStream();
            var compilationResult = compilation.Emit(codeStream);
            var errors = new List<Diagnostic>();
            var warnings = new List<Diagnostic>();
            if (!compilationResult.Success)
            {
                var sb = new StringBuilder();
                foreach (var diag in compilationResult.Diagnostics)
                {
                    switch (diag.Severity)
                    {
                        case DiagnosticSeverity.Warning:
                            warnings.Add(diag);
                            break;
                        case DiagnosticSeverity.Error:
                            errors.Add(diag);
                            break;
                        case DiagnosticSeverity.Hidden:
                        case DiagnosticSeverity.Info:
                        default:
                            break;
                    }
                    sb.AppendLine(diag.ToString());
                }
                var ex = new InvalidOperationException($"The following compilation errors were detected when compiling Tuples:{Environment.NewLine}{sb}");
                ex.Data["Errors"] = errors;
                ex.Data["Warnings"] = warnings;

                throw ex;
            }
            var bytes = codeStream.ToArray();
            var asmData = new AssemblyData(bytes, sources);
            return asmData;
        }

        private void CompileNode(Stream sourceCodeStream,
            Dictionary<string, AssemblyData> assemblies,
            DirectedGraphNode node,
            IEnumerable<Assembly> assemblyReferences,
            IEnumerable<AssemblyData>? dependencyAssemblies)
        {
            sourceCodeStream.Flush();
            sourceCodeStream.Seek(0, SeekOrigin.Begin);
            var reader = new StreamReader(sourceCodeStream);
            var sourceCode = reader.ReadToEnd().Trim();
            var tree = SyntaxFactory.ParseSyntaxTree(sourceCode);
            var metadataReferences = new List<MetadataReference>();
            AddNetCoreReferences(metadataReferences);
            foreach (var asm in assemblyReferences)
            {
                metadataReferences.Add(MetadataReference.CreateFromFile(asm.Location));
            }
            foreach (var edge in node.ForwardEdges)
            {
                if (assemblies.TryGetValue(edge.ToId, out var referencedDll))
                {
                    metadataReferences.Add(MetadataReference.CreateFromImage(referencedDll.Binary));
                }
            }
            if (dependencyAssemblies != null)
            {
                foreach (var dependency in dependencyAssemblies)
                {
                    metadataReferences.Add(MetadataReference.CreateFromImage(dependency.Binary));
                }
            }
            var asmInfo = new StringBuilder();
            var parts = node.NodeId.Split('-');
            string name = parts[0];
            string version = string.Empty;
            if (parts.Length > 1)
                version = parts[1];
            asmInfo.AppendLine(CultureInfo.InvariantCulture, $"[assembly: Hl7.Cql.CqlLibraryAttribute(\"{name}\", \"{version}\")]");
            var asmInfoTree = SyntaxFactory.ParseSyntaxTree(asmInfo.ToString());

            var compilation = CSharpCompilation.Create($"{node.NodeId}")
                .WithOptions(new CSharpCompilationOptions(outputKind: OutputKind.DynamicallyLinkedLibrary,
                    optimizationLevel: OptimizationLevel.Release))
                .WithReferences(metadataReferences)
                .AddSyntaxTrees(tree, asmInfoTree);
            var codeStream = new MemoryStream();
            var compilationResult = compilation.Emit(codeStream);
            var errors = new List<Diagnostic>();
            var warnings = new List<Diagnostic>();
            if (!compilationResult.Success)
            {
                var sb = new StringBuilder();
                foreach (var diag in compilationResult.Diagnostics)
                {
                    switch (diag.Severity)
                    {
                        case DiagnosticSeverity.Warning:
                            warnings.Add(diag);
                            break;
                        case DiagnosticSeverity.Error:
                            errors.Add(diag);
                            break;
                        case DiagnosticSeverity.Hidden:
                        case DiagnosticSeverity.Info:
                        default:
                            break;
                    }
                    sb.AppendLine(diag.ToString());
                }
                var ex = new InvalidOperationException($"The following compilation errors were detected when compiling {node.NodeId}:{Environment.NewLine}{sb}");
                ex.Data["Errors"] = errors;
                ex.Data["Warnings"] = warnings;

                //       throw ex;
            }
            var bytes = codeStream.ToArray();
            var asmData = new AssemblyData(bytes, new Dictionary<string, string> { { node.NodeId, sourceCode } });
            assemblies.Add(node.NodeId, asmData);
        }


        private void AddNetCoreReferences(List<MetadataReference> metadataReferences)
        {
            var rtPath = Path.GetDirectoryName(typeof(object).Assembly.Location) ??
                throw new InvalidOperationException($"Couldn't identify system file path for the System assembly");

            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Private.CoreLib.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Runtime.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Console.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "netstandard.dll")));

            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Text.RegularExpressions.dll"))); // IMPORTANT!
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Linq.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Linq.Expressions.dll"))); // IMPORTANT!

            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.IO.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Net.Primitives.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Net.Http.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Private.Uri.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Reflection.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.ComponentModel.Primitives.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Globalization.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Collections.Concurrent.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Collections.NonGeneric.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "Microsoft.CSharp.dll")));

            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Diagnostics.Tools.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Diagnostics.Debug.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.Collections.dll")));

            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.ObjectModel.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.ComponentModel.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.ComponentModel.Annotations.dll")));
            metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, "System.ComponentModel.TypeConverter.dll")));


        }
        private IList<DirectedGraphNode> DetermineBuildOrder(DirectedGraph minimalGraph)
        {
            var sorted = minimalGraph.TopologicalSort()
                .Where(n => n.NodeId != minimalGraph.StartNode.NodeId && n.NodeId != minimalGraph.EndNode.NodeId)
                .ToList();
            return sorted;
        }

    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member