using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Hl7.Cql.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Hl7.Cql.CodeGeneration.NET
{
    /// <summary>
    /// Uses the <see cref="CSharpSourceCodeWriter"/> to write source code which is compiled via Roslyn into an assembly.
    /// </summary>
    public class AssemblyGenerator
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="lambdaProvider">Provides lambda expressions.</param>
        /// <param name="sourceCodeWriter">Writes .NET (C#) source code.</param>
        /// <param name="references">Additional references to be added during compilation time.</param>
        public AssemblyGenerator(ILambdaProvider lambdaProvider,
            CSharpSourceCodeWriter sourceCodeWriter,
            params Assembly[] references)
        {
            LambdaProvider = lambdaProvider;
            SourceCodeWriter = sourceCodeWriter;
            References = references;
        }

        internal ILambdaProvider LambdaProvider { get; }
        internal CSharpSourceCodeWriter SourceCodeWriter { get; }
        internal Assembly[] References { get; }

        /// <summary>
        /// Generates an assembly given the <see cref="DirectedGraph"/> containing ELM package nodes.
        /// </summary>
        /// <param name="name">The name of the ELM package to build.  This should exist in <paramref name="dependencies"/>.</param>
        /// <param name="version">The version of the ELM package to build.</param>
        /// <param name="dependencies">A <see cref="DirectedGraph"/> describing the relationships between dependent ELM packages.</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public IDictionary<string, AssemblyData> Generate(string name, string version, DirectedGraph dependencies)
        {
            var navToLibraryStream = new Dictionary<string, Stream>(StringComparer.OrdinalIgnoreCase);

            Stream getStreamForLibrary(string nav)
            {
                if (!navToLibraryStream.TryGetValue(nav, out var stream))
                {
                    stream = new MemoryStream();
                    navToLibraryStream.Add(nav, stream);
                }
                return stream;
            }
            try
            {
                var expressions = LambdaProvider.GetLambdaExpressionsFor(name, version);
                var typeManager = LambdaProvider.TypeManager;
                SourceCodeWriter.Write(expressions,
                    typeManager.TupleTypes,
                    dependencies,
                    getStreamForLibrary,
                    closeStream: false);

                var assemblies = new Dictionary<string, AssemblyData>();
                var tupleStreams = navToLibraryStream
                    .Where(kvp => kvp.Key.StartsWith("Tuples\\"))
                    .Select(kvp => kvp.Value)
                    .ToList();
                const string tupleTypesLibraryId = "TupleTypes";
                var tupleTypesNode = new DirectedGraphNode
                {
                    NodeId = tupleTypesLibraryId
                };
                CompileNode(tupleStreams, assemblies, tupleTypesNode, null);

                var additionalReferences = new[]
                {
                    assemblies[tupleTypesLibraryId]
                };

                var buildOrder = DetermineBuildOrder(dependencies);
                foreach (var node in buildOrder)
                {
                    if (!navToLibraryStream.TryGetValue(node.NodeId, out var sourceCodeStream))
                        throw new InvalidOperationException($"Library {node.NodeId} doesn't exist in the source code dictionary.");
                    CompileNode(sourceCodeStream, assemblies, node, additionalReferences);
                }
                return assemblies;
            }
            finally
            {
                var map = navToLibraryStream;
                foreach (var stream in map.Values)
                {
                    try
                    {
                        stream.Dispose();
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void CompileNode(IEnumerable<Stream> sourceCodeStreams,
            Dictionary<string, AssemblyData> assemblies, DirectedGraphNode node,
            IEnumerable<AssemblyData>? references)
        {
            var metadataReferences = new List<MetadataReference>();
            AddNetCoreReferences(metadataReferences);
            foreach (var asm in References)
            {
                metadataReferences.Add(MetadataReference.CreateFromFile(asm.Location));
            }
            foreach (var edge in node.ForwardEdges)
            {
                if (assemblies.TryGetValue(edge.ToId, out var referencedDll))
                {
                    metadataReferences.Add(MetadataReference.CreateFromFile(referencedDll.Location.FullName));
                }
            }
            if (references != null)
            {
                foreach (var tuple in references)
                {
                    metadataReferences.Add(MetadataReference.CreateFromFile(tuple.Location.FullName));
                }
            }
            var compilation = CSharpCompilation.Create($"{node.NodeId}")
                .WithOptions(new CSharpCompilationOptions(outputKind: OutputKind.DynamicallyLinkedLibrary,
                    optimizationLevel: OptimizationLevel.Release))
                .WithReferences(metadataReferences);
            var sources = new List<string>();
            foreach (var sourceCodeStream in sourceCodeStreams)
            {
                sourceCodeStream.Flush();
                sourceCodeStream.Seek(0, SeekOrigin.Begin);
                var reader = new StreamReader(sourceCodeStream);
                var sourceCode = reader.ReadToEnd().Trim();
                sources.Add(sourceCode);
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
                var ex = new InvalidOperationException($"The following compilation errors were detected when compiling {node.NodeId}:{Environment.NewLine}{sb}");
                ex.Data["Errors"] = errors;
                ex.Data["Warnings"] = warnings;

                throw ex;
            }
            var bytes = codeStream.ToArray();
            var tempFile = new FileInfo(Path.Combine(Path.GetTempPath(), $"{node.NodeId}.dll"));
            File.WriteAllBytes(tempFile.FullName, bytes);
            var data = new AssemblyData(tempFile, sources);
            assemblies.Add(node.NodeId, data);
        }

        private void CompileNode(Stream sourceCodeStream,
            Dictionary<string, AssemblyData> assemblies, DirectedGraphNode node,
            IEnumerable<AssemblyData>? references)
        {
            sourceCodeStream.Flush();
            sourceCodeStream.Seek(0, SeekOrigin.Begin);
            var reader = new StreamReader(sourceCodeStream);
            var sourceCode = reader.ReadToEnd().Trim();
            var tree = SyntaxFactory.ParseSyntaxTree(sourceCode);
            var metadataReferences = new List<MetadataReference>();
            AddNetCoreReferences(metadataReferences);
            foreach (var asm in References)
            {
                metadataReferences.Add(MetadataReference.CreateFromFile(asm.Location));
            }
            foreach (var edge in node.ForwardEdges)
            {
                if (assemblies.TryGetValue(edge.ToId, out var referencedDll))
                {
                    metadataReferences.Add(MetadataReference.CreateFromFile(referencedDll.Location.FullName));
                }
            }
            if (references != null)
            {
                foreach (var tuple in references)
                {
                    metadataReferences.Add(MetadataReference.CreateFromFile(tuple.Location.FullName));
                }
            }
            var compilation = CSharpCompilation.Create($"{node.NodeId}")
                .WithOptions(new CSharpCompilationOptions(outputKind: OutputKind.DynamicallyLinkedLibrary,
                    optimizationLevel: OptimizationLevel.Release))
                .WithReferences(metadataReferences)
                .AddSyntaxTrees(tree);
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

                throw ex;
            }
            var bytes = codeStream.ToArray();
            var tempFile = new FileInfo(Path.Combine(Path.GetTempPath(), $"{node.NodeId}.dll"));
            File.WriteAllBytes(tempFile.FullName, bytes);
            var data = new AssemblyData(tempFile, new List<string> { sourceCode });
            assemblies.Add(node.NodeId, data);
        }

        private void AddNetCoreReferences(List<MetadataReference> metadataReferences)
        {
            var rtPath = Path.GetDirectoryName(typeof(object).Assembly.Location);

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
        }

        private IList<DirectedGraphNode> DetermineBuildOrder(DirectedGraph minimalGraph)
        {
            var sorted = minimalGraph.TopologicalSort()
                .Where(n => n.NodeId != minimalGraph.StartNode.NodeId)
                .ToList();
            return sorted;
        }

        // From https://www.codeproject.com/Articles/1215168/Using-Roslyn-for-Compiling-Code-into-Separate-Net
        private static CSharpCompilation CreateCompilationWithMscorlib(string assemblyOrModuleName,
            string code,
            CSharpCompilationOptions? compilerOptions = null,
            IEnumerable<MetadataReference>? references = null)
        {
            var syntaxTree = SyntaxFactory.ParseSyntaxTree(code, null, "");
            var mscoreLibReference = AssemblyMetadata
                    .CreateFromFile(typeof(string).Assembly.Location)
                    .GetReference();
            IEnumerable<MetadataReference> allReferences = new MetadataReference[] { mscoreLibReference };
            if (references != null)
            {
                allReferences = allReferences.Concat(references);
            }

            var compilation = CSharpCompilation.Create(assemblyOrModuleName,
                new[] { syntaxTree },
                options: compilerOptions,
                references: allReferences);

            return compilation;
        }

        private static byte[] EmitToArray(Compilation compilation)
        {
            using var stream = new MemoryStream();
            var emitResult = compilation.Emit(stream);

            if (!emitResult.Success)
            {
                var firstError = emitResult.Diagnostics
                        .FirstOrDefault(diagnostic => diagnostic.Severity == DiagnosticSeverity.Error);
                throw new ArgumentException(firstError?.GetMessage(), nameof(compilation));
            }
            var bytes = stream.ToArray();
            return bytes;
        }

    }
}
