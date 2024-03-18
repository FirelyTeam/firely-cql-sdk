﻿#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Graph;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Hl7.Cql.CodeGeneration.NET
{
    internal class AssemblyCompiler
    {
        private readonly TypeManager _typeManager;
        private readonly CSharpSourceCodeWriter _cSharpSourceCodeWriter;
        private readonly Lazy<Assembly[]> _referencesLazy;

        public AssemblyCompiler(
            CSharpSourceCodeWriter cSharpSourceCodeWriter,
            TypeManager typeManager)
        {
            _cSharpSourceCodeWriter = cSharpSourceCodeWriter;
            _typeManager = typeManager;
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

                        }                                        // @formatter on
                        .Select(type => type.Assembly)
                        .Concat(typeManager.Resolver.ModelAssemblies)
                        .Distinct()
                        .ToArray();
                    return references;
                });
        }

        public IDictionary<string, AssemblyData> Compile(
            LibrarySet librarySet, 
            DefinitionDictionary<LambdaExpression>? definitions = null)
        {
            Dictionary<string, Stream> navToLibraryStream = new();
            definitions ??= new();

            Stream getStreamForLibrary(string nav)
            {
                if (!navToLibraryStream.TryGetValue(nav, out var stream))
                {
                    stream = new MemoryStream();
                    navToLibraryStream.Add(nav, stream);
                }
                return stream;
            }

            _cSharpSourceCodeWriter.Write(
                definitions,
                _typeManager.TupleTypes,
                librarySet,
                getStreamForLibrary,
                closeStream: false);

            var assemblies = new Dictionary<string, AssemblyData>();
            var tupleStreams = navToLibraryStream
                .Where(kvp => kvp.Key.StartsWith("Tuples" + Path.DirectorySeparatorChar));
            var tupleAssembly = CompileTuples(tupleStreams, _referencesLazy.Value);
            var additionalReferences = new[]
            {
                tupleAssembly
            };
            assemblies.Add("TupleTypes", tupleAssembly);
            foreach (var library in librarySet)
            {
                if (!navToLibraryStream.TryGetValue(library.NameAndVersion()!, out var sourceCodeStream))
                    throw new InvalidOperationException($"Library {library.NameAndVersion()!} doesn't exist in the source code dictionary.");

                CompileNode(sourceCodeStream, assemblies, librarySet, library, _referencesLazy.Value, additionalReferences);
            }
            return assemblies;
        }

        private static AssemblyData CompileTuples(
            IEnumerable<KeyValuePair<string, Stream>> tupleStreams,
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

        private static void CompileNode(
            Stream sourceCodeStream,
            Dictionary<string, AssemblyData> assemblies,
            LibrarySet librarySet,
            Library library,
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
            foreach (var libraryDependency in librarySet.GetLibraryDependencies(library.NameAndVersion()!))
            {
                if (assemblies.TryGetValue(libraryDependency.NameAndVersion()!, out var referencedDll))
                {
                    metadataReferences.Add(MetadataReference.CreateFromImage(referencedDll.Binary));
                }
            }
            if (dependencyAssemblies != null)
            {
                foreach (var assemblyDependency in dependencyAssemblies)
                {
                    metadataReferences.Add(MetadataReference.CreateFromImage(assemblyDependency.Binary));
                }
            }
            var asmInfo = new StringBuilder();
            var parts = library.NameAndVersion()!.Split('-');
            string name = parts[0];
            string version = string.Empty;
            if (parts.Length > 1)
                version = parts[1];
            asmInfo.AppendLine(CultureInfo.InvariantCulture, $"[assembly: Hl7.Cql.Abstractions.CqlLibraryAttribute(\"{name}\", \"{version}\")]");
            var asmInfoTree = SyntaxFactory.ParseSyntaxTree(asmInfo.ToString());

            var compilation = CSharpCompilation.Create($"{library.NameAndVersion()!}")
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
                var ex = new InvalidOperationException($"The following compilation errors were detected when compiling {library.NameAndVersion()!}:{Environment.NewLine}{sb}");
                ex.Data["Errors"] = errors;
                ex.Data["Warnings"] = warnings;

                throw ex;
            }
            var bytes = codeStream.ToArray();
            var asmData = new AssemblyData(bytes, new Dictionary<string, string> { { library.NameAndVersion()!, sourceCode } });
            assemblies.Add(library.NameAndVersion()!, asmData);
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