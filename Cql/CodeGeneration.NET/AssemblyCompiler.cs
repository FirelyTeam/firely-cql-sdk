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
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Elm;
using Microsoft.CodeAnalysis.Text;
using Microsoft.Extensions.Options;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.Extensions.Logging;
using static Hl7.Cql.CodeGeneration.NET.CSharpSourceCodeStep;
using Hl7.Fhir.Model;
using Count = Hl7.Cql.Elm.Count;
using Library = Hl7.Cql.Elm.Library;

namespace Hl7.Cql.CodeGeneration.NET
{
    internal class AssemblyCompiler
    {
        private static readonly EmitOptions EmitOptionsPortable = new EmitOptions(debugInformationFormat: DebugInformationFormat.PortablePdb);
        private static readonly CSharpParseOptions CSharpParseOptions = CSharpParseOptions.Default;
        private readonly LibrarySetDefinitionsToCSharpCodeProcessor _librarySetDefinitionsToCSharpCodeProcessor;
        private readonly CSharpCodeStreamPostProcessor? _cSharpCodeStreamPostProcessor;
        private readonly Lazy<Assembly[]> _referencesLazy;
        private readonly IOptions<AssemblyDataWriterOptions> _assemblyDataWriterOptions;
        private readonly ILogger<AssemblyCompiler> _logger;
        private readonly AssemblyDataPostProcessor? _assemblyDataPostProcessor;

        public AssemblyCompiler(
            IOptions<AssemblyDataWriterOptions> assemblyDataWriterOptions,
            ILogger<AssemblyCompiler> logger,
            LibrarySetDefinitionsToCSharpCodeProcessor librarySetDefinitionsToLibrarySetDefinitionsToCSharpCodeProcessor,
            TypeResolver typeResolver,
            CSharpCodeStreamPostProcessor? cSharpCodeStreamPostProcessor = null,
            AssemblyDataPostProcessor? assemblyDataPostProcessor = null)
        {
            _assemblyDataWriterOptions = assemblyDataWriterOptions;
            _logger = logger;
            _assemblyDataPostProcessor = assemblyDataPostProcessor;
            _librarySetDefinitionsToCSharpCodeProcessor = librarySetDefinitionsToLibrarySetDefinitionsToCSharpCodeProcessor;
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

                        }                                        // @formatter on
                        .Select(type => type.Assembly)
                        .Concat(typeResolver.ModelAssemblies)
                        .Distinct()
                        .ToArray();
                    return references;
                });
        }

        /// <see cref="LibrarySetDefinitionsToCSharpCodeProcessor.GenerateCSharpV2"/>
        /// <see cref="CompileV2"/>
        [Obsolete("Use CompileV2 instead after generating the C# source with LibrarySetDefinitionsToCSharpCodeProcessor.GenerateCSharpV2", error:false)]
        public IReadOnlyDictionary<string, AssemblyDataWithSourceCode> Compile(
            LibrarySet librarySet,
            DefinitionDictionary<LambdaExpression> definitions,
            ProcessBatchItemExceptionHandling libraryCSharpWritingExceptionHandling = default,
            ProcessBatchItemExceptionHandling libraryAssemblyWritingExceptionHandling = default)
        {
            ArgumentNullException.ThrowIfNull(definitions);

            Dictionary<string, AssemblyDataWithSourceCode> results = new();

            List<(string libraryName, Stream stream)> items = [];

            _librarySetDefinitionsToCSharpCodeProcessor.ProcessDefinitions(
                librarySet,
                definitions,
                callbacks: new(onAfterStep: CSharpSourceCodeStep),
                processLibraryToCSharpExceptionHandling: libraryCSharpWritingExceptionHandling);

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

                        CompileAssemblies();
                        break;
                }
            }

            void CompileAssemblies()
            {
                var inputs = from item in items
                                  let libraryName = item.libraryName!
                                  let library = librarySet.GetLibrary(libraryName)!
                                  let stream = item.stream!
                                  select (libraryName, library, stream);
                inputs
                    .TryProcessEach(item => CompileAssembly(item.library, item.stream))
                    .HandleEachOutcome(outcome =>
                    {
                        if (outcome.Exception?.SourceException is { } exception)
                        {
                            var libraryName = outcome.Input.libraryName;
                            switch (libraryAssemblyWritingExceptionHandling)
                            {
                                case ProcessBatchItemExceptionHandling.ThrowException:
                                    _logger.LogError(exception, "Error writing library '{libraryName}' to .NET assembly.", libraryName);
                                    break;
                                case ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue:
                                    _logger.LogWarning(exception, "Error writing library '{libraryName}' to .NET assembly, continuing", libraryName);
                                    break;
                                case ProcessBatchItemExceptionHandling.IgnoreExceptionAndBreak:
                                    _logger.LogWarning(exception, "Error writing library '{libraryName}' to .NET assembly, aborting", libraryName);
                                    break;
                            }
                        }
                    })
                    .HandleExceptions(libraryAssemblyWritingExceptionHandling)
                    .Count() // We must enumerate all
                    ;
            }

            void CompileAssembly(Library library, Stream stream)
            {
                var libraryAssembly = CompileNode(stream, results, librarySet, library, _referencesLazy.Value);
                results.Add(library.GetVersionedIdentifier()!, libraryAssembly);
                _assemblyDataPostProcessor?.ProcessAssemblyData(library.GetVersionedIdentifier()!, libraryAssembly);
            }
        }

        public IEnumerable<(Library library, Func<AssemblyDataWithSourceCode> generateAssemblyDataWithSourceCode)> CompileV2(
            LibrarySet librarySet,
            IEnumerable<(Library Library, string CSharp)> input)
        {
            Dictionary<string, AssemblyDataWithSourceCode> results = new();
            Assembly[] assemblyReferences = _referencesLazy.Value;
            foreach (var (library, cSharp) in input)
                yield return (library, () => CompileNodeV2(cSharp, results, librarySet, library, assemblyReferences));
        }

        private CSharpCompilationOptions CreateCSharpCompilationOptions() =>
            new(
                outputKind: OutputKind.DynamicallyLinkedLibrary,
                optimizationLevel: _assemblyDataWriterOptions.Value.DebugModeAssemblies ? OptimizationLevel.Debug : OptimizationLevel.Release,
                deterministic: true, // see: https://github.com/dotnet/roslyn/blob/main/docs/compilers/Deterministic%20Inputs.md
                sourceReferenceResolver: new SourceFileResolver(ImmutableArray<string>.Empty, null)
            );

        private AssemblyDataWithSourceCode CompileNode(
            Stream sourceCodeStream,
            Dictionary<string, AssemblyDataWithSourceCode> assemblies,
            LibrarySet librarySet,
            Elm.Library library,
            IEnumerable<Assembly> assemblyReferences)
        {
            var librarySourceString = GetSourceCodeString(sourceCodeStream);
            return CompileNodeV2(librarySourceString, assemblies, librarySet, library, assemblyReferences);
        }

        private AssemblyDataWithSourceCode CompileNodeV2(
            string librarySourceString,
            Dictionary<string, AssemblyDataWithSourceCode> assemblies,
            LibrarySet librarySet,
            Library library,
            IEnumerable<Assembly> assemblyReferences)
        {
            var libraryVersionedIdentifier = library.GetVersionedIdentifier()!;
            var librarySourcePath = $"{libraryVersionedIdentifier}.cs";
            if (_assemblyDataWriterOptions.Value.DebugModeAssemblies)
            {
                var tempDir = Path.Combine(Path.GetTempPath(), "CqlCompiler", $"{libraryVersionedIdentifier}.cs");
                Directory.CreateDirectory(tempDir);
                librarySourcePath = Path.Combine(tempDir, $"{CreateMD5HashStringDirectory(librarySourceString)}.cs");
                File.WriteAllText(librarySourcePath, librarySourceString);
            }

            var librarySyntaxTree = ParseSyntaxTree(librarySourceString, librarySourcePath);
            var metadataReferences = new List<MetadataReference>();
            AddNetCoreReferences(metadataReferences);
            foreach (var asm in assemblyReferences)
                metadataReferences.Add(MetadataReference.CreateFromFile(asm.Location));

            foreach (var libraryDependency in librarySet.GetLibraryDependencies(libraryVersionedIdentifier!))
                if (assemblies.TryGetValue(libraryDependency.GetVersionedIdentifier()!, out var referencedDll))
                    metadataReferences.Add(MetadataReference.CreateFromImage(referencedDll.AssemblyBytes));

            var assemblyInfoSourceString = CreateAssemblyInfoSourceString(library);
            var assemblyInfoSourcePath = "AssemblyInfo.cs";
            var assemblyInfoSyntaxTree = ParseSyntaxTree(assemblyInfoSourceString, assemblyInfoSourcePath);

            var compilation = CSharpCompilation.Create($"{libraryVersionedIdentifier!}")
                                               .WithOptions(CreateCSharpCompilationOptions())
                                               .WithReferences(metadataReferences)
                                               .AddSyntaxTrees(
                                                   librarySyntaxTree,
                                                   assemblyInfoSyntaxTree
                                               );

            using var codeStream = new MemoryStream();
            MemoryStream? pdbStream = _assemblyDataWriterOptions.Value.DebugModeAssemblies ? new MemoryStream() : null;
            using var pdbStreamDisposable = pdbStream as IDisposable ?? new EmptyDisposable();

            var compilationResult = compilation.Emit(codeStream, pdbStream, options:EmitOptionsPortable);
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
                var ex = new InvalidOperationException($"The following compilation errors were detected when compiling {libraryVersionedIdentifier!}:{Environment.NewLine}{sb}");
                ex.Data["Errors"] = errors;
                ex.Data["Warnings"] = warnings;
                ex.Data["SourceCode"] = librarySourceString;
                throw ex;
            }
            var bytes = codeStream.ToArray();
            var debugSymbols = pdbStream?.ToArray();
            var asmData = new AssemblyDataWithSourceCode(bytes, new Dictionary<string, string> { { libraryVersionedIdentifier!, librarySourceString }}, debugSymbols);
            return asmData;
        }

        private static string CreateMD5HashStringDirectory(string text)
        {
            text = System.Convert.ToBase64String(MD5.HashData(Encoding.UTF8.GetBytes(text)));
            return text.Replace('/', '-');
        }

        private static string GetSourceCodeString(Stream sourceCodeStream)
        {
            sourceCodeStream.Flush();
            sourceCodeStream.Seek(0, SeekOrigin.Begin);
            var reader = new StreamReader(sourceCodeStream);
            var sourceCode = reader.ReadToEnd().Trim();
            return sourceCode;
        }

        private static SyntaxTree ParseSyntaxTree(string text, string path)
        {
            var sourceText = SourceText.From(text, Encoding.UTF8);
            var syntaxTree = SyntaxFactory.ParseSyntaxTree(sourceText, CSharpParseOptions, path);
            return syntaxTree;
        }

        private static string CreateAssemblyInfoSourceString(Library library)
        {
            var parts = library.GetVersionedIdentifier()!.Split('-');
            string name = parts[0];
            string version = string.Empty;
            if (parts.Length > 1)
                version = parts[1];
            var text = $"""
                        [assembly: Hl7.Cql.Abstractions.CqlLibraryAttribute("{name}", "{version}")]
                        [assembly: System.Reflection.AssemblyVersion("{version}")]
                        """;
            return text;
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