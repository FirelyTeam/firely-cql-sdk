/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Concurrent;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
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
            // System.Linq.Expressions.dll is intentionally omitted: generated C# no longer uses
            // expression trees — the IR pipeline emits plain C# methods and delegates directly.

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

        /// <summary>
        /// Cache of <see cref="MetadataReference"/> instances per assembly file path. Creating a
        /// metadata reference parses the assembly metadata, which is expensive when compiling many
        /// small libraries in a row (e.g. one per test assertion), so cache them process-wide.
        /// </summary>
        private static readonly ConcurrentDictionary<string, MetadataReference> MetadataReferenceCache = new();

        private static MetadataReference GetOrCreateMetadataReference(string assemblyPath) =>
            MetadataReferenceCache.GetOrAdd(assemblyPath, static path => MetadataReference.CreateFromFile(path));

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

        public IEnumerable<(ElmLibrary library, AssemblyBinaryWithSourceCode assemblyBinaryWithSourceCode)> CompileEachLibraryToAssemblies(
            IEnumerable<(ElmLibrary library, string csharp)> librariesWithCSharp,
            LibrarySet librarySet,
            DebugSymbolsFormat debugSymbolsFormat = DebugSymbolsFormat.None,
            bool allowInvalidCSharp = false,
            BatchProcessExceptionHandlingStrategyBuilder<(ElmLibrary library, string csharp)>? buildExceptionHandlingStrategy = null)
        {
            Assembly[] assemblyReferences = _referencesLazy.Value;

            // Materialized once: librariesWithCSharp is a lazy, side-effecting iterator in the
            // real ElmToolkit pipeline (it generates each library's C# and logs on every
            // enumeration), so it must not be enumerated more than once here.
            var materialized = librariesWithCSharp.ToList();

            // Looked up by identifier so a dependency can be compiled on demand regardless of
            // where it falls in the original enumeration order (see firely-cql-sdk#1373:
            // relying on that order alone to already guarantee "dependencies come before
            // dependents" turned out not to hold reliably -- ElmToolkit builds this sequence
            // from an ImmutableDictionary.Values enumeration, whose order is hash-bucket-driven
            // and varies per process, not insertion-stable).
            var sourceByIdentifier = materialized.ToDictionary(t => t.library.VersionedLibraryIdentifier, t => t);

            CompileLibrariesInDependencyWaves(librarySet, assemblyReferences, debugSymbolsFormat, sourceByIdentifier, buildExceptionHandlingStrategy, out var results, out var failures);

            return materialized
                .TrySelect(
                    t => (t.library, assemblyBinaryWithSourceCode: GetResultOrThrow(t.library.VersionedLibraryIdentifier, results, failures)),
                    buildExceptionHandlingStrategy,
                    allowInvalidCSharp ? YieldWithoutAssemblyBinary : null);

            ShouldYieldValue<(ElmLibrary library, AssemblyBinaryWithSourceCode assemblyBinaryWithSourceCode)> YieldWithoutAssemblyBinary(
                (ElmLibrary library, string csharp) t) =>
                (
                    t.library,
                    assemblyBinaryWithSourceCode: new AssemblyBinaryWithSourceCode(
                        assemblyBytes: null,
                        sourceCode: t.csharp,
                        sourceCodeFileName: BuildFileName(t.library.VersionedLibraryIdentifier))
                );
        }

        /// <summary>
        /// Compiles all libraries in <paramref name="sourceByIdentifier"/> to assemblies, level by
        /// level in dependency order: within a level, libraries whose dependencies have all
        /// already been compiled (or failed) are compiled concurrently via <see cref="Parallel.ForEach{TSource}(IEnumerable{TSource},Action{TSource})"/>.
        /// </summary>
        /// <remarks>
        /// Roslyn's <c>Compilation.Emit(...)</c>
        /// is CPU-bound and each library's compilation is otherwise independent once its
        /// dependencies are compiled. Large library sets (e.g. hundreds of HEDIS measure/shared
        /// libraries) previously compiled one library at a time via recursive memoization, which
        /// made this step dominate the overall build time; compiling independent libraries in
        /// parallel lets it scale with available cores instead.
        /// </remarks>
        private void CompileLibrariesInDependencyWaves(
            LibrarySet librarySet,
            Assembly[] assemblyReferences,
            DebugSymbolsFormat debugSymbolsFormat,
            Dictionary<CqlVersionedLibraryIdentifier, (ElmLibrary library, string csharp)> sourceByIdentifier,
            BatchProcessExceptionHandlingStrategyBuilder<(ElmLibrary library, string csharp)>? buildExceptionHandlingStrategy,
            out ConcurrentDictionary<CqlVersionedLibraryIdentifier, AssemblyBinaryWithSourceCode> results,
            out ConcurrentDictionary<CqlVersionedLibraryIdentifier, ExceptionDispatchInfo> failures)
        {
            var concurrentResults = new ConcurrentDictionary<CqlVersionedLibraryIdentifier, AssemblyBinaryWithSourceCode>();
            var concurrentFailures = new ConcurrentDictionary<CqlVersionedLibraryIdentifier, ExceptionDispatchInfo>();
            results = concurrentResults;
            failures = concurrentFailures;

            // Determine the configured continuation policy up front so wave scheduling can honor
            // Throw/Break by not starting further waves once a failure occurs, instead of
            // compiling the entire graph regardless and only applying the policy afterward in
            // TrySelect (which would contradict the documented stop-on-error behavior and waste
            // substantial work on independent, later waves).
            var continuation = (buildExceptionHandlingStrategy?.Invoke(default) ?? default).ExceptionContinuation;

            var remaining = new HashSet<CqlVersionedLibraryIdentifier>(sourceByIdentifier.Keys);
            while (remaining.Count > 0)
            {
                var ready = remaining
                    .Where(id => librarySet.GetLibraryDependencies(id)
                        .All(dep => !sourceByIdentifier.ContainsKey(dep.VersionedLibraryIdentifier)
                                    || concurrentResults.ContainsKey(dep.VersionedLibraryIdentifier)
                                    || concurrentFailures.ContainsKey(dep.VersionedLibraryIdentifier)))
                    .ToList();

                if (ready.Count == 0)
                    throw new InvalidOperationException(
                        $"Circular dependency detected involving one of: {string.Join(", ", remaining)}.");

                Parallel.ForEach(ready, identifier =>
                {
                    // If any dependency already failed to compile, don't bother attempting to
                    // compile this library -- surface that same failure so downstream item-level
                    // error handling (TrySelect) reports a sensible cause. (CqlVersionedLibraryIdentifier
                    // is a value type, so FirstOrDefault()+null-check can't be used to detect "not found".)
                    CqlVersionedLibraryIdentifier? failedDependency = null;
                    foreach (var dep in librarySet.GetLibraryDependencies(identifier))
                    {
                        if (concurrentFailures.ContainsKey(dep.VersionedLibraryIdentifier))
                        {
                            failedDependency = dep.VersionedLibraryIdentifier;
                            break;
                        }
                    }
                    if (failedDependency is { } failedId)
                    {
                        concurrentFailures[identifier] = concurrentFailures[failedId];
                        return;
                    }

                    try
                    {
                        var self = sourceByIdentifier[identifier];
                        var compiled = CompileNode(self.csharp, concurrentResults, librarySet, self.library, assemblyReferences, debugSymbolsFormat);
                        concurrentResults[identifier] = compiled;
                    }
                    catch (Exception ex)
                    {
                        concurrentFailures[identifier] = ExceptionDispatchInfo.Capture(ex);
                    }
                });

                remaining.ExceptWith(ready);

                // Honor the configured stop-on-error policy: if anything failed in this wave and
                // the policy is not Continue, don't start additional waves. Mark the remaining,
                // not-yet-attempted libraries as failed (rather than silently leaving them absent
                // from both dictionaries) so downstream TrySelect handling has a sensible cause for
                // each of them instead of a bare KeyNotFoundException.
                if (continuation != BatchProcessExceptionContinuation.Continue && !concurrentFailures.IsEmpty && remaining.Count > 0)
                {
                    foreach (var skippedId in remaining)
                    {
                        concurrentFailures.TryAdd(
                            skippedId,
                            ExceptionDispatchInfo.Capture(
                                new InvalidOperationException(
                                    $"Compilation of library '{skippedId}' was skipped because an earlier library failed to compile and the configured exception continuation policy is '{continuation}'.")));
                    }
                    break;
                }
            }
        }

        private static AssemblyBinaryWithSourceCode GetResultOrThrow(
            CqlVersionedLibraryIdentifier identifier,
            ConcurrentDictionary<CqlVersionedLibraryIdentifier, AssemblyBinaryWithSourceCode> results,
            ConcurrentDictionary<CqlVersionedLibraryIdentifier, ExceptionDispatchInfo> failures)
        {
            if (failures.TryGetValue(identifier, out var edi))
                edi.Throw();
            return results[identifier];
        }

        private static CSharpCompilationOptions CreateCSharpCompilationOptions(
            DebugSymbolsFormat debugSymbolsFormat) =>
            new(
                outputKind: OutputKind.DynamicallyLinkedLibrary,
                optimizationLevel: debugSymbolsFormat == DebugSymbolsFormat.None ? OptimizationLevel.Release : OptimizationLevel.Debug,
                deterministic: true, // see: https://github.com/dotnet/roslyn/blob/main/docs/compilers/Deterministic%20Inputs.md
                sourceReferenceResolver: new SourceFileResolver(ImmutableArray<string>.Empty, null)
            );

        private AssemblyBinaryWithSourceCode CompileNode(
            string librarySourceString,
            IReadOnlyDictionary<CqlVersionedLibraryIdentifier, AssemblyBinaryWithSourceCode> assemblies,
            LibrarySet librarySet,
            ElmLibrary library,
            IEnumerable<Assembly> assemblyReferences,
            DebugSymbolsFormat debugSymbolsFormat)
        {
            EmbeddedText[]? embeddedTexts = []; // For embedding C# when enabling debug information
            string libraryVersionedIdentifier = library.VersionedLibraryIdentifier;
            var fileName = BuildFileName(libraryVersionedIdentifier);

            if (debugSymbolsFormat != DebugSymbolsFormat.None)
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
                metadataReferences.Add(GetOrCreateMetadataReference(asm.Location));

            foreach (var libraryDependency in librarySet.GetLibraryDependencies(libraryVersionedIdentifier!))
            {
                if (assemblies.TryGetValue(libraryDependency.VersionedLibraryIdentifier, out var referencedDll))
                {
                    metadataReferences.Add(MetadataReference.CreateFromImage(referencedDll.AssemblyBytes!));
                }
                else
                {
                    // Should be structurally unreachable: CompileEachLibraryToAssemblies compiles
                    // dependencies before dependents by scheduling libraries in dependency-order
                    // waves (CompileLibrariesInDependencyWaves), not by trusting a pre-computed
                    // enumeration order. Fail loudly rather than silently drop the reference
                    // (which used to surface later as a confusing unrelated CS0103 -- see
                    // firely-cql-sdk#1373).
                    throw new InvalidOperationException(
                        $"Library '{libraryVersionedIdentifier}' depends on '{libraryDependency.VersionedLibraryIdentifier}', " +
                        "which has not been compiled yet.");
                }
            }

            var assemblyInfoSourceString = CreateAssemblyInfoSourceString(library);
            var assemblyInfoSourcePath = "AssemblyInfo.cs";
            var assemblyInfoSyntaxTree = ParseSyntaxTree(assemblyInfoSourceString, assemblyInfoSourcePath);

            var compilation = CSharpCompilation.Create($"{libraryVersionedIdentifier!}")
                                               .WithOptions(CreateCSharpCompilationOptions(debugSymbolsFormat))
                                               .WithReferences(metadataReferences)
                                               .AddSyntaxTrees(
                                                   librarySyntaxTree,
                                                   assemblyInfoSyntaxTree
                                               );

            using var codeStream = new MemoryStream();
            MemoryStream? pdbStream = debugSymbolsFormat == DebugSymbolsFormat.PortablePdb ? new MemoryStream() : null;
            using var pdbStreamDisposable = pdbStream as IDisposable;

            var emitOptions = CreateEmitOptions(debugSymbolsFormat);
            var compilationResult = compilation.Emit(codeStream, pdbStream, options: emitOptions, embeddedTexts: embeddedTexts);
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
            var asmData = new AssemblyBinaryWithSourceCode(bytes, new Dictionary<string, string> { { libraryVersionedIdentifier!, librarySourceString } }, debugSymbols);
            return asmData;
        }

        private static string BuildFileName(string libraryVersionedIdentifier) =>
            $"{libraryVersionedIdentifier}.cs";

        private static EmitOptions CreateEmitOptions(DebugSymbolsFormat debugSymbolsFormat)
        {
            var emitOptions = DefaultEmitOptions;
            if (debugSymbolsFormat != DebugSymbolsFormat.None)
                emitOptions = emitOptions.WithDebugInformationFormat((DebugInformationFormat)debugSymbolsFormat);
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

        private static string CreateAssemblyInfoSourceString(ElmLibrary library)
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
                metadataReferences.Add(GetOrCreateMetadataReference(Path.Combine(rtPath, assemblyFileName)));

        }
    }
}
