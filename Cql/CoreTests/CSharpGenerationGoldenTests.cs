/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Ir;
using Hl7.Cql.Compiler.Preprocessing;
using Hl7.Cql.Fhir;
using Microsoft.Extensions.Logging.Abstractions;
using TypeConverter = Hl7.Cql.Conversion.TypeConverter;

namespace CoreTests;

/// <summary>
/// Golden-file tests: regenerate C# from the checked-in ELM corpora under <c>LibrarySets\</c>
/// and verify the output is identical to the checked-in <c>.g.cs</c> files, modulo line-ending
/// differences and a trailing newline (git may rewrite line endings on checkout, so the
/// comparison normalizes those before asserting equality).
/// These tests guard the C# code generator against unintended output changes
/// (e.g. while refactoring the expression-building or code-writing pipeline), and — during the
/// Linq.Expressions removal (docs/linq-expression-removal-plan.md) — prove that the typed-IR
/// pipeline produces the same output as the Expression-based one.
/// When an output change is intentional, regenerate the corpus with PackagerCLI
/// (see its launchSettings.json profiles) and commit the updated <c>.g.cs</c> files.
/// </summary>
[TestClass]
public class CSharpGenerationGoldenTests
{
    [TestMethod]
    public void Regenerated_RR23_CSharp_Matches_CheckedInFiles() =>
        AssertGeneratedCSharpMatchesGoldenFiles(
            LibrarySetsDirs.RR23.ElmDir,
            "RR23",
            LibrarySetsDirs.RR23.CSharpDir,
            GenerateWithOldPipeline,
            version: "1.0.0",
            goldenCorpusIsComplete: true);

    [TestMethod]
    public void Regenerated_DqmQiCore2025_CMS56_CSharp_Matches_CheckedInFiles() =>
        AssertGeneratedCSharpMatchesGoldenFiles(
            LibrarySetsDirs.DqmQiCore2025.ElmDir,
            "CMS56FHIRFuncStatHipReplacement",
            LibrarySetsDirs.DqmQiCore2025.ExtractedCSharpDir,
            GenerateWithOldPipeline,
            // Only the top library's C# is checked in (extracted from the packaged FHIR Library
            // resource); its dependencies are generated but have no golden counterpart.
            goldenCorpusIsComplete: false);

    [TestMethod]
    public void IrPipeline_RR23_CSharp_Matches_CheckedInFiles() =>
        AssertGeneratedCSharpMatchesGoldenFiles(
            LibrarySetsDirs.RR23.ElmDir,
            "RR23",
            LibrarySetsDirs.RR23.CSharpDir,
            GenerateWithIrPipeline,
            version: "1.0.0",
            goldenCorpusIsComplete: true);

    [TestMethod]
    public void IrPipeline_DqmQiCore2025_CMS56_CSharp_Matches_CheckedInFiles() =>
        AssertGeneratedCSharpMatchesGoldenFiles(
            LibrarySetsDirs.DqmQiCore2025.ElmDir,
            "CMS56FHIRFuncStatHipReplacement",
            LibrarySetsDirs.DqmQiCore2025.ExtractedCSharpDir,
            GenerateWithIrPipeline,
            goldenCorpusIsComplete: false);

    private static Dictionary<string, string> GenerateWithOldPipeline(LibrarySet librarySet)
    {
        var elmToolkit =
            new ElmToolkit()
                .AddElmLibraries(librarySet)
                .CompileToAssemblies();

        return elmToolkit
            .GetElmToCSharpResults()
            .ToDictionary(t => t.libraryIdentifier.ToString()!, t => t.cSharp);
    }

    private static Dictionary<string, string> GenerateWithIrPipeline(LibrarySet librarySet)
    {
        // Mirrors the service composition of ElmToolkitServices.AddCqlCompilerServices with
        // the typed-IR classes (same wiring as IrPipelineTests in CqlToElmTests).
        var typeResolver = FhirTypeResolver.Default;
        var typeConverter = FhirTypeConverter
            .Create(Hl7.Fhir.Model.ModelInfo.ModelInspector)
            .UseLogger(NullLogger<TypeConverter>.Instance);
        typeConverter.CaptureAvailableConverters();

        var tupleBuilderCache = new TupleBuilderCache(NullLogger<TupleBuilderCache>.Instance);
        var libraryPreprocessorBuilder = new LibraryPreprocessorBuilder(NullLoggerFactory.Instance);

        var expressionBuilder = new IrExpressionBuilder(
            NullLogger<IrExpressionBuilder>.Instance,
            ExpressionBuilderSettings.Default,
            new IrCqlOperatorsBinder(NullLogger<IrCqlOperatorsBinder>.Instance, typeResolver, typeConverter),
            tupleBuilderCache,
            typeResolver,
            typeConverter,
            new IrCqlContextBinder());

        var libraryExpressionBuilder = new IrLibraryExpressionBuilder(
            NullLogger<IrLibraryExpressionBuilder>.Instance,
            expressionBuilder,
            libraryPreprocessorBuilder);

        var librarySetBuilder = new IrLibrarySetExpressionBuilder(libraryExpressionBuilder, libraryPreprocessorBuilder);

        IrDefinitionDictionary definitions = new();
        _ = librarySetBuilder.BuildEachLibraryDefinitions(librarySet, definitions).ToList(); // drain the batch

        return new IrLibrarySetCSharpCodeGenerator(typeResolver, new TypeToCSharpConverter())
            .GenerateEachLibraryToCSharp(librarySet, definitions)
            .ToDictionary(t => t.library.VersionedLibraryIdentifier.ToString()!, t => t.cSharp);
    }

    private static void AssertGeneratedCSharpMatchesGoldenFiles(
        DirectoryInfo elmDir,
        string topLibraryName,
        DirectoryInfo goldenCSharpDir,
        Func<LibrarySet, Dictionary<string, string>> generate,
        string version = "",
        bool goldenCorpusIsComplete = true)
    {
        LibrarySet librarySet = new();
        librarySet.LoadLibraryAndDependencies(elmDir, topLibraryName, version);

        var generatedByIdentifier = generate(librarySet);

        var goldenFiles = goldenCSharpDir.GetFiles("*.g.cs");
        Assert.AreNotEqual(0, goldenFiles.Length, $"No golden .g.cs files found in {goldenCSharpDir.FullName}.");

        foreach (var goldenFile in goldenFiles)
        {
            var libraryIdentifier = goldenFile.Name[..^".g.cs".Length];
            Assert.IsTrue(
                generatedByIdentifier.TryGetValue(libraryIdentifier, out var generated),
                $"No C# was generated for golden file {goldenFile.Name}. Generated libraries: {string.Join(", ", generatedByIdentifier.Keys)}.");

            var golden = File.ReadAllText(goldenFile.FullName);
            AssertEqualCSharp(golden, generated!, libraryIdentifier, goldenFile.FullName);
        }

        if (goldenCorpusIsComplete)
        {
            // Guard against the generator emitting libraries that have no golden counterpart:
            // a complete corpus must match the generated set exactly.
            var goldenIdentifiers = goldenFiles.Select(f => f.Name[..^".g.cs".Length]);
            var extraGenerated = generatedByIdentifier.Keys.Except(goldenIdentifiers).ToList();
            Assert.AreEqual(
                0,
                extraGenerated.Count,
                $"C# was generated for libraries without a checked-in golden file: {string.Join(", ", extraGenerated)}.");
        }
    }

    /// <summary>Asserts equality (line endings normalized), failing with the first differing
    /// line plus surrounding context — far easier to iterate on than two multi-hundred-line
    /// strings in a failure message.</summary>
    private static void AssertEqualCSharp(string golden, string generated, string libraryIdentifier, string goldenPath)
    {
        var goldenLines = NormalizeLineEndings(golden).Split('\n');
        var generatedLines = NormalizeLineEndings(generated).Split('\n');

        for (int i = 0; i < Math.Max(goldenLines.Length, generatedLines.Length); i++)
        {
            var goldenLine = i < goldenLines.Length ? goldenLines[i] : "<end of file>";
            var generatedLine = i < generatedLines.Length ? generatedLines[i] : "<end of file>";
            if (goldenLine != generatedLine)
            {
                var contextStart = Math.Max(0, i - 3);
                var context = string.Join("\n", generatedLines.Skip(contextStart).Take(i - contextStart));
                Assert.Fail(
                    $"Generated C# for {libraryIdentifier} differs from {goldenPath} at line {i + 1}:\n" +
                    $"--- context (generated) ---\n{context}\n" +
                    $"--- golden    : {goldenLine}\n" +
                    $"--- generated : {generatedLine}");
            }
        }
    }

    private static string NormalizeLineEndings(string text) =>
        text.Replace("\r\n", "\n").TrimEnd('\n');
}
