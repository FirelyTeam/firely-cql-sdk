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
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CodeGeneration.NET
{
    internal class AssemblyCompiler
    {
        private static readonly EmitOptions DefaultEmitOptions = new();
        private static readonly CSharpParseOptions CSharpParseOptions = CSharpParseOptions.Default;

        private static readonly string[] AssemblyFileNames = [
            "System.Private.CoreLib.dll",
            "System.Runtime.dll",
            "System.Console.dll",
            "netstandard.dll",

            "System.Text.RegularExpressions.dll", // IMPORTANT!
            "System.Linq.dll",
            "System.Linq.Expressions.dll", // IMPORTANT!

            "System.IO.dll",
            "System.Net.Primitives.dll",
            "System.Net.Http.dll",
            "System.Private.Uri.dll",
            "System.Reflection.dll",
            "System.ComponentModel.Primitives.dll",
            "System.Globalization.dll",
            "System.Collections.Concurrent.dll",
            "System.Collections.NonGeneric.dll",
            "Microsoft.CSharp.dll",

            "System.Diagnostics.Tools.dll",
            "System.Diagnostics.Debug.dll",
            "System.Collections.dll",

            "System.ObjectModel.dll",
            "System.ComponentModel.dll",
            "System.ComponentModel.Annotations.dll",
            "System.ComponentModel.TypeConverter.dll",
        ];

        private readonly Lazy<Assembly[]> _referencesLazy;

        public AssemblyCompiler(TypeResolver typeResolver)
        {
            _referencesLazy = new Lazy<Assembly[]>(
                () =>
                {
                    var references = new[]
                        {                                        // @formatter off

                            // Core engine references
                            typeof(Iso8601.DateIso8601),         // Iso8601
                            typeof(CqlDefinitionAttribute),     // Cql.Abstractions
                            typeof(CqlContext),                  // Cql.Runtime

                        }                                        // @formatter on
                        .Select(type => type.Assembly)
                        .Concat(typeResolver.ModelAssemblies)
                        .Distinct()
                        .ToArray();
                    return references;
                });
        }

        public IEnumerable<(Library library, AssemblyBinaryWithSourceCode assemblyBinaryWithSourceCode)> CompileEachLibraryToAssemblies(
            IEnumerable<(Library library, string csharp)> librariesWithCSharp,
            LibrarySet librarySet,
            AssemblyCompilerDebugInformationFormat debugInformationFormat = AssemblyCompilerDebugInformationFormat.None,
            bool allowInvalidCSharp = false,
            BatchProcessExceptionHandlingStrategyBuilder<(Library library, string csharp)>? buildExceptionHandlingStrategy = null)
        {
            Dictionary<string, AssemblyBinaryWithSourceCode> results = new();
            Assembly[] assemblyReferences = _referencesLazy.Value;
            return librariesWithCSharp
                .TrySelect(
                    t =>
                    {
                        var (library, cSharp) = t;
                        var assemblyBinaryWithSourceCode = CompileNode(cSharp, results, librarySet, library, assemblyReferences, debugInformationFormat);
                        results.Add(library.VersionedLibraryIdentifier, assemblyBinaryWithSourceCode);
                        return (library, assemblyBinaryWithSourceCode);
                    },
                    buildExceptionHandlingStrategy,
                    allowInvalidCSharp ? YieldWithoutAssemblyBinary : null);

            ShouldYieldValue<(Library library, AssemblyBinaryWithSourceCode assemblyBinaryWithSourceCode)> YieldWithoutAssemblyBinary(
                (Library library, string csharp) t) =>
                (
                    t.library,
                    assemblyBinaryWithSourceCode: new AssemblyBinaryWithSourceCode(
                        assemblyBytes: null,
                        sourceCode: t.csharp,
                        sourceCodeFileName: BuildFileName(t.library.VersionedLibraryIdentifier))
                );
        }

        private static CSharpCompilationOptions CreateCSharpCompilationOptions(
            AssemblyCompilerDebugInformationFormat debugInformationFormat) =>
            new(
                outputKind: OutputKind.DynamicallyLinkedLibrary,
                optimizationLevel: debugInformationFormat == AssemblyCompilerDebugInformationFormat.None ? OptimizationLevel.Release : OptimizationLevel.Debug,
                deterministic: true, // see: https://github.com/dotnet/roslyn/blob/main/docs/compilers/Deterministic%20Inputs.md
                sourceReferenceResolver: new SourceFileResolver(ImmutableArray<string>.Empty, null)
            );

        private AssemblyBinaryWithSourceCode CompileNode(
            string librarySourceString,
            Dictionary<string, AssemblyBinaryWithSourceCode> assemblies,
            LibrarySet librarySet,
            Library library,
            IEnumerable<Assembly> assemblyReferences,
            AssemblyCompilerDebugInformationFormat debugInformationFormat)
        {
            EmbeddedText[]? embeddedTexts = []; // For embedding C# when enabling debug information
            string libraryVersionedIdentifier = library.VersionedLibraryIdentifier;
            var fileName = BuildFileName(libraryVersionedIdentifier);

            if (debugInformationFormat != AssemblyCompilerDebugInformationFormat.None)
            {
                // Embed C# source code
                var sourceText = SourceText.From(librarySourceString, Encoding.UTF8);
                var embeddedText = EmbeddedText.FromSource(fileName, sourceText);
                embeddedTexts = [embeddedText];
            }

            var librarySyntaxTree = ParseSyntaxTree(librarySourceString, fileName);
            var metadataReferences = new List<MetadataReference>();
            AddNetCoreReferences(metadataReferences);
            foreach (var asm in assemblyReferences)
                metadataReferences.Add(MetadataReference.CreateFromFile(asm.Location));

            foreach (var libraryDependency in librarySet.GetLibraryDependencies(libraryVersionedIdentifier!))
                if (assemblies.TryGetValue(libraryDependency.VersionedLibraryIdentifier, out var referencedDll))
                    metadataReferences.Add(MetadataReference.CreateFromImage(referencedDll.AssemblyBytes!));

            var assemblyInfoSourceString = CreateAssemblyInfoSourceString(library);
            var assemblyInfoSourcePath = "AssemblyInfo.cs";
            var assemblyInfoSyntaxTree = ParseSyntaxTree(assemblyInfoSourceString, assemblyInfoSourcePath);

            var compilation = CSharpCompilation.Create($"{libraryVersionedIdentifier!}")
                                               .WithOptions(CreateCSharpCompilationOptions(debugInformationFormat))
                                               .WithReferences(metadataReferences)
                                               .AddSyntaxTrees(
                                                   librarySyntaxTree,
                                                   assemblyInfoSyntaxTree
                                               );

            using var codeStream = new MemoryStream();
            MemoryStream? pdbStream = debugInformationFormat == AssemblyCompilerDebugInformationFormat.PortablePdb ? new MemoryStream() : null;
            using var pdbStreamDisposable = pdbStream as IDisposable;

            var emitOptions = CreateEmitOptions(debugInformationFormat);
            var compilationResult = compilation.Emit(codeStream, pdbStream, options:emitOptions, embeddedTexts: embeddedTexts);
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
            var asmData = new AssemblyBinaryWithSourceCode(bytes, new Dictionary<string, string> { { libraryVersionedIdentifier!, librarySourceString }}, debugSymbols);
            return asmData;
        }

        private static string BuildFileName(string libraryVersionedIdentifier) =>
            $"{libraryVersionedIdentifier}.cs";

        private static EmitOptions CreateEmitOptions(AssemblyCompilerDebugInformationFormat debugInformationFormat)
        {
            var emitOptions = DefaultEmitOptions;
            if (debugInformationFormat != AssemblyCompilerDebugInformationFormat.None)
                emitOptions = emitOptions.WithDebugInformationFormat((DebugInformationFormat)debugInformationFormat);
            return emitOptions;
        }

        private static string CreateMD5HashStringDirectory(string text)
        {
            text = System.Convert.ToBase64String(MD5.HashData(Encoding.UTF8.GetBytes(text)));
            return text.Replace('/', '-');
        }

        private static SyntaxTree ParseSyntaxTree(string text, string path)
        {
            var sourceText = SourceText.From(text, Encoding.UTF8);
            var syntaxTree = SyntaxFactory.ParseSyntaxTree(sourceText, CSharpParseOptions, path);
            return syntaxTree;
        }

        private static string CreateAssemblyInfoSourceString(Library library)
        {
            var (name, version) = library.VersionedLibraryIdentifier;

            var text = $"""
                        [assembly: Hl7.Cql.Abstractions.CqlLibraryAttribute("{name}", "{version}")]
                        [assembly: System.Reflection.AssemblyVersion("{version}")]
                        """;
            return text;
        }

        private static void AddNetCoreReferences(List<MetadataReference> metadataReferences)
        {
            var rtPath = Path.GetDirectoryName(typeof(object).Assembly.Location)
                         ?? throw new InvalidOperationException($"Couldn't identify system file path for the System assembly");

            foreach (var assemblyFileName in AssemblyFileNames)
                metadataReferences.Add(MetadataReference.CreateFromFile(Path.Combine(rtPath, assemblyFileName)));

        }
    }
}