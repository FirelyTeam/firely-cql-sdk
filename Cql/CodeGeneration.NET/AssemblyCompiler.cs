#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET.PostProcessors;
using Hl7.Cql.Compiler;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Hl7.Cql.CodeGeneration.NET
{
    internal class AssemblyCompiler
    {
        private readonly CSharpLibrarySetToStreamsWriter _cSharpLibrarySetToStreamsWriter;
        private readonly CSharpCodeStreamPostProcessor? _cSharpCodeStreamPostProcessor;
        private readonly Lazy<Assembly[]> _referencesLazy;
        private readonly AssemblyDataPostProcessor? _assemblyDataPostProcessor;

        public AssemblyCompiler(
            CSharpLibrarySetToStreamsWriter cSharpLibrarySetToStreamsWriter,
            TypeResolver typeResolver,
            CSharpCodeStreamPostProcessor? cSharpCodeStreamPostProcessor = null,
            AssemblyDataPostProcessor? assemblyDataPostProcessor = null)
        {
            _assemblyDataPostProcessor = assemblyDataPostProcessor;
            _cSharpLibrarySetToStreamsWriter = cSharpLibrarySetToStreamsWriter;
            _cSharpCodeStreamPostProcessor = cSharpCodeStreamPostProcessor;
            _referencesLazy = new Lazy<Assembly[]>(
                () =>
                {
                    var references = new[]
                        {                                        // @formatter off

                            // Core engine references
                            typeof(CqlDeclarationAttribute),     // Cql.Abstractions
                            typeof(Comparers.CqlComparers),      // Cql.Comparers
                            typeof(Conversion.IUnitConverter),   // Cql.Conversion
                            typeof(Operators.ICqlOperators),     // Cql.Operators
                            typeof(Primitives.CqlPrimitiveType), // Cql.Primitives
                            typeof(CqlContext),                  // Cql.Runtime
                            typeof(IValueSetDictionary),         // Cql.ValueSets
                            typeof(Iso8601.DateIso8601),         // Iso8601
                            typeof(IServiceCollection),
                            typeof(ServiceCollectionDescriptorExtensions),
                            typeof(ICqlLibrary),

                        }                                        // @formatter on
                        .Select(type => type.Assembly)
                        .Concat(typeResolver.ModelAssemblies)
                        .Distinct()
                        .ToArray();
                    return references;
                });
        }

        public IReadOnlyDictionary<string, AssemblyData> Compile(
            LibrarySet librarySet,
            DefinitionDictionary<LambdaExpression> definitions)
        {
            ArgumentNullException.ThrowIfNull(definitions);

            Dictionary<string, AssemblyData> results = new();

            List<(string libraryName, Stream stream)> items = [];

            _cSharpLibrarySetToStreamsWriter.ProcessDefinitions(
                definitions,
                librarySet, new(
                    onAfterStep: CSharpSourceCodeStep
                ));


            return results;

            void CSharpSourceCodeStep(CSharpSourceCodeStep next)
            {
                switch (next)
                {
                    case CSharpSourceCodeStep.OnStream onStream:
                        // Write out C# File
                        _cSharpCodeStreamPostProcessor?.ProcessStream(onStream.Name, onStream.Stream);
                        items.Add((onStream.Name, onStream.Stream));
                        break;

                    case NET.CSharpSourceCodeStep.OnDone:
                        if (_assemblyDataPostProcessor != null)
                            foreach (var referenceAssembly in _referencesLazy.Value)
                                _assemblyDataPostProcessor.ProcessReferenceAssembly(referenceAssembly);

                        // Compile Libraries
                        foreach (var (libraryName, stream) in items)
                        {
                            var library = librarySet.GetLibrary(libraryName)!;
                            var libraryAssembly = CompileNode(stream, results, librarySet, library, _referencesLazy.Value);
                            results.Add(library.GetVersionedIdentifier()!, libraryAssembly);
                            _assemblyDataPostProcessor?.ProcessAssemblyData(library.GetVersionedIdentifier()!, libraryAssembly);
                        }
                        break;
                }
            }
        }

        private static CSharpCompilationOptions CreateCSharpCompilationOptions() =>
            new(
                outputKind: OutputKind.DynamicallyLinkedLibrary,
                optimizationLevel: OptimizationLevel.Release,
                deterministic: true, // see: https://github.com/dotnet/roslyn/blob/main/docs/compilers/Deterministic%20Inputs.md
                sourceReferenceResolver: new SourceFileResolver(ImmutableArray<string>.Empty, null)
            );

        private static AssemblyData CompileNode(
            Stream sourceCodeStream,
            Dictionary<string, AssemblyData> assemblies,
            LibrarySet librarySet,
            Elm.Library library,
            IEnumerable<Assembly> assemblyReferences)
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
            foreach (var libraryDependency in librarySet.GetLibraryDependencies(library.GetVersionedIdentifier()!))
            {
                if (assemblies.TryGetValue(libraryDependency.GetVersionedIdentifier()!, out var referencedDll))
                {
                    metadataReferences.Add(MetadataReference.CreateFromImage(referencedDll.Binary));
                }
            }
            var asmInfo = new StringBuilder();
            var parts = library.GetVersionedIdentifier()!.Split('-');
            string name = parts[0];
            string version = string.Empty;
            if (parts.Length > 1)
                version = parts[1];
            asmInfo.AppendLine(CultureInfo.InvariantCulture, $"[assembly: Hl7.Cql.Abstractions.CqlLibraryAttribute(\"{name}\", \"{version}\")]");
            var asmInfoTree = SyntaxFactory.ParseSyntaxTree(asmInfo.ToString());

            var compilation = CSharpCompilation.Create($"{library.GetVersionedIdentifier()!}")
                .WithOptions(CreateCSharpCompilationOptions())
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
                var ex = new InvalidOperationException($"The following compilation errors were detected when compiling {library.GetVersionedIdentifier()!}:{Environment.NewLine}{sb}");
                ex.Data["Errors"] = errors;
                ex.Data["Warnings"] = warnings;

                throw ex;
            }
            var bytes = codeStream.ToArray();
            var asmData = new AssemblyData(bytes, new Dictionary<string, string> { { library.GetVersionedIdentifier()!, sourceCode } });
            return asmData;
        }


        private static void AddNetCoreReferences(List<MetadataReference> metadataReferences)
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
    }
}