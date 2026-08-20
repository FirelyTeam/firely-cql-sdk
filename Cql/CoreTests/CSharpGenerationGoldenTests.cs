/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace CoreTests;

/// <summary>
/// Golden-file tests: regenerate C# from the checked-in ELM corpora under <c>LibrarySets\</c>
/// and verify the output is identical to the checked-in <c>.g.cs</c> files, modulo line-ending
/// differences and a trailing newline (git may rewrite line endings on checkout, so the
/// comparison normalizes those before asserting equality).
/// These tests guard the C# code generator against unintended output changes
/// (e.g. while refactoring the expression-building or code-writing pipeline), exercising it
/// through the public <see cref="ElmToolkit"/> API.
/// When an output change is intentional, regenerate the corpus with PackagerCLI
/// (see its launchSettings.json profiles) and commit the updated <c>.g.cs</c> files.
/// </summary>
[TestClass]
public class CSharpGenerationGoldenTests
{
    /// <summary>
    /// Also asserts assembly compilation succeeds end-to-end via the toolkit (compiled C# ->
    /// .NET assembly), proving the toolkit's default pipeline works beyond just C# text
    /// generation.
    /// </summary>
    [TestMethod]
    public void RR23_CSharp_Matches_CheckedInFiles()
    {
        ElmToolkit? elmToolkitCapture = null;

        AssertGeneratedCSharpMatchesGoldenFiles(
            LibrarySetsDirs.RR23.ElmDir,
            "RR23",
            LibrarySetsDirs.RR23.CSharpDir,
            librarySet =>
            {
                var elmToolkit =
                    new ElmToolkit()
                        .AddElmLibraries(librarySet)
                        .CompileToAssemblies();
                elmToolkitCapture = elmToolkit;

                return elmToolkit
                    .GetElmToCSharpResults()
                    .ToDictionary(t => t.libraryIdentifier.ToString()!, t => t.cSharp);
            },
            version: "1.0.0",
            goldenCorpusIsComplete: true);

        Assert.IsNotNull(elmToolkitCapture);
        var assemblyResults = elmToolkitCapture!.GetElmToAssemblyResults().ToList();
        Assert.AreNotEqual(0, assemblyResults.Count, "No compiled assembly results were produced via the toolkit.");
        foreach (var (libraryIdentifier, _, _, assemblyBinary, _) in assemblyResults)
            Assert.IsNotNull(assemblyBinary, $"AssemblyBinary was null for library {libraryIdentifier}.");
    }

    [TestMethod]
    public void DqmQiCore2025_CMS56_CSharp_Matches_CheckedInFiles() =>
        AssertGeneratedCSharpMatchesGoldenFiles(
            LibrarySetsDirs.DqmQiCore2025.ElmDir,
            "CMS56FHIRFuncStatHipReplacement",
            LibrarySetsDirs.DqmQiCore2025.ExtractedCSharpDir,
            GenerateWithToolkit,
            // Only the top library's C# is checked in (extracted from the packaged FHIR Library
            // resource); its dependencies are generated but have no golden counterpart.
            goldenCorpusIsComplete: false);

    [TestMethod]
    public void FHIRConversionTest_CSharp_Matches_CheckedInFile() =>
        AssertGeneratedCSharpMatchesGoldenFile(
            LibrarySetsDirs.CoreTests.Hl7ElmDir,
            "FHIRConversionTest",
            LibrarySetsDirs.CoreTests.CSharpDir,
            "FHIRConversionTest-2023.0.0",
            GenerateWithToolkit,
            "2023.0.0");

    [TestMethod]
    public void CheckedInGeneratedCorpora_AreNullableWarningClean()
    {
        AssertNoCs86xxWarnings("CoreTestsCSharp", LibrarySetsDirs.CoreTests.CSharpDir);
        AssertNoCs86xxWarnings("DemoMeasuresAuthoring", LibrarySetsDirs.Demo.AuthoringCSharpDir);
        AssertNoCs86xxWarnings("RR23", LibrarySetsDirs.RR23.CSharpDir);
    }

    /// <summary>
    /// The corpora generated with <see cref="CSharpNullability.Annotations"/> are compiled only by
    /// the <c>Demo/*</c> projects, which are outside <c>Cql-Sdk.slnf</c> — the solution filter
    /// contributors build. Without this they are unverified by anything a contributor runs, which is
    /// how a stray annotation outside a <c>#nullable</c> context (CS8669) reached CI once already.
    /// </summary>
    [TestMethod]
    public void CheckedInAnnotationOnlyCorpora_CompileUnderTheirOwnNullableContext()
    {
        AssertCorpusHasNoNullableDiagnostics(
            "DemoMeasures",
            LibrarySetsDirs.Demo.DemoCSharpDir,
            NullableContextOptions.Annotations);
        AssertCorpusHasNoNullableDiagnostics(
            "DemoMeasuresDqmQiCore2025",
            LibrarySetsDirs.DqmQiCore2025.CSharpDir,
            NullableContextOptions.Annotations);
    }

    [TestMethod]
    public void NullabilityDisabled_EmitsNullObliviousCSharp()
    {
        LibrarySet librarySet = new();
        librarySet.LoadLibraryAndDependencies(LibrarySetsDirs.CoreTests.Hl7ElmDir, "FHIRHelpers", "4.0.1");

        var nullOblivious = GenerateWithToolkit(
                librarySet,
                new ElmToolkitConfig(CSharp: new CSharpConfig(Nullability: CSharpNullability.Disabled)))
            .Values
            .First();

        Assert.IsFalse(
            nullOblivious.Contains("#nullable"),
            "With nullability Disabled, no '#nullable' directive should be emitted.");
        Assert.IsFalse(
            nullOblivious.Contains("CqlInterval<CqlDateTime>?"),
            "With nullability Disabled, reference-typed declarations should carry no annotation.");
        Assert.IsFalse(
            nullOblivious.Contains("context!"),
            "With nullability Disabled, no null-forgiving operator should be emitted.");

        // The assertions above only catch the shapes we thought to name. Compiling the result
        // outside a nullable context is the real invariant: any stray annotation is CS8669, which
        // is how the first version of this switch leaked "FhirDateTime? a_ = period?.StartElement;"
        // into a file with no '#nullable' directive.
        AssertNoNullableDiagnostics(
            "NullObliviousFhirHelpers",
            [CSharpSyntaxTree.ParseText(nullOblivious)],
            NullableContextOptions.Disable,
            "null-oblivious generated C#");

        // The same library with nullability on must be the inverse, so this pins the flag rather
        // than a fixture that simply had nothing to annotate.
        var annotated = GenerateWithToolkit(librarySet).Values.First();
        StringAssert.Contains(annotated, "#nullable enable");
        StringAssert.Contains(annotated, "CqlInterval<CqlDateTime?>?");
    }

    /// <summary>
    /// Annotations mode is the point of the tri-state: consumers get the honest nullability of the
    /// generated API, and nothing is emitted purely to satisfy flow analysis. The null-forgiving
    /// operators and bridging casts that <see cref="CSharpNullability.Enabled"/> needs are the
    /// readability cost of having the compiler verify the annotations, so they must be absent here.
    /// </summary>
    [TestMethod]
    public void NullabilityAnnotations_AnnotatesWithoutFlowAnalysisScaffolding()
    {
        LibrarySet librarySet = new();
        librarySet.LoadLibraryAndDependencies(LibrarySetsDirs.CoreTests.Hl7ElmDir, "FHIRHelpers", "4.0.1");

        var annotationsOnly = GenerateWithToolkit(
                librarySet,
                new ElmToolkitConfig(CSharp: new CSharpConfig(Nullability: CSharpNullability.Annotations)))
            .Values
            .First();

        StringAssert.StartsWith(annotationsOnly.TrimStart('﻿'), "#nullable enable annotations");
        StringAssert.Contains(
            annotationsOnly,
            "CqlInterval<CqlDateTime?>?",
            "Annotations mode must still annotate declarations — that is its entire purpose.");

        Assert.IsFalse(
            annotationsOnly.Contains('!') && System.Text.RegularExpressions.Regex.IsMatch(
                annotationsOnly, @"[A-Za-z0-9_\)\]]!(?![=])"),
            "Annotations mode must not emit null-forgiving operators; there are no warnings to silence.");

        // Compiled in its own context, annotation-only output must be diagnostic-free — CS8669 would
        // mean an annotation leaked somewhere the directive does not cover.
        AssertNoNullableDiagnostics(
            "AnnotationsOnlyFhirHelpers",
            [CSharpSyntaxTree.ParseText(annotationsOnly)],
            NullableContextOptions.Annotations,
            "annotation-only generated C#");
    }

    // Kept as a single-argument method so it still converts to the Func<LibrarySet, …> the
    // golden-file helpers take.
    private static Dictionary<string, string> GenerateWithToolkit(LibrarySet librarySet) =>
        GenerateWithToolkit(librarySet, null);

    private static Dictionary<string, string> GenerateWithToolkit(
        LibrarySet librarySet,
        ElmToolkitConfig? config)
    {
        var elmToolkit =
            new ElmToolkit(config: config)
                .AddElmLibraries(librarySet)
                .CompileToAssemblies();

        return elmToolkit
            .GetElmToCSharpResults()
            .ToDictionary(t => t.libraryIdentifier.ToString()!, t => t.cSharp);
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

            AssertNullableConventions(generated!);
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

    private static void AssertGeneratedCSharpMatchesGoldenFile(
        DirectoryInfo elmDir,
        string topLibraryName,
        DirectoryInfo goldenCSharpDir,
        string libraryIdentifier,
        Func<LibrarySet, Dictionary<string, string>> generate,
        string version = "")
    {
        LibrarySet librarySet = new();
        librarySet.LoadLibraryAndDependencies(elmDir, topLibraryName, version);

        var generatedByIdentifier = generate(librarySet);
        Assert.IsTrue(
            generatedByIdentifier.TryGetValue(libraryIdentifier, out var generated),
            $"No C# was generated for golden file {libraryIdentifier}.g.cs. Generated libraries: {string.Join(", ", generatedByIdentifier.Keys)}.");

        var goldenPath = Path.Combine(goldenCSharpDir.FullName, $"{libraryIdentifier}.g.cs");
        Assert.IsTrue(File.Exists(goldenPath), $"Missing golden file: {goldenPath}");

        AssertNullableConventions(generated!);
        var golden = File.ReadAllText(goldenPath);
        AssertEqualCSharp(golden, generated!, libraryIdentifier, goldenPath);
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
                var contextStart = Math.Max(0, i - 8);
                string Window(string[] lines) => string.Join("\n",
                    lines.Skip(contextStart).Take(Math.Min(i + 4, lines.Length) - contextStart));
                Assert.Fail(
                    $"Generated C# for {libraryIdentifier} differs from {goldenPath} at line {i + 1}:\n" +
                    $"--- golden window ---\n{Window(goldenLines)}\n" +
                    $"--- generated window ---\n{Window(generatedLines)}\n" +
                    $"--- golden    : {goldenLine}\n" +
                    $"--- generated : {generatedLine}");
            }
        }
    }

    private static string NormalizeLineEndings(string text) =>
        NormalizeGeneratedCodeVersion(text.Replace("\r\n", "\n")).TrimEnd('\n');

    private static string NormalizeGeneratedCodeVersion(string text) =>
        System.Text.RegularExpressions.Regex.Replace(
            text,
            "\\[System\\.CodeDom\\.Compiler\\.GeneratedCode\\(\"\\.NET Code Generation\", \"[^\"]+\"\\)\\]",
            "[System.CodeDom.Compiler.GeneratedCode(\".NET Code Generation\", \"<normalized>\")]");

    private static void AssertNullableConventions(string generated)
    {
        var normalized = generated.Replace("\r\n", "\n");
        var firstLine = normalized.Split('\n')[0];
        // These corpora are generated with the default CSharpNullability.Enabled, so the directive
        // must be the full one. Annotations-only is a supported mode — it is simply not the mode
        // these corpora are generated in, and the exact directive is part of what they pin.
        Assert.AreEqual(
            "#nullable enable",
            firstLine,
            "Golden corpora are generated with CSharpNullability.Enabled, so the first line must be "
            + "exactly '#nullable enable'. '#nullable enable annotations' here means the corpus was "
            + "generated in the wrong mode.");

        var hasBlanketNullablePragmaDisable =
            System.Text.RegularExpressions.Regex.IsMatch(
                normalized,
                @"#pragma\s+warning\s+disable\s+CS86\d{2}",
                System.Text.RegularExpressions.RegexOptions.CultureInvariant);
        Assert.IsFalse(
            hasBlanketNullablePragmaDisable,
            "Generated C# must not suppress nullable warnings via blanket CS86xx pragma disables.");
    }

    private static void AssertNoCs86xxWarnings(string assemblyName, DirectoryInfo csharpDir) =>
        AssertCorpusHasNoNullableDiagnostics(assemblyName, csharpDir, NullableContextOptions.Enable);

    private static void AssertCorpusHasNoNullableDiagnostics(
        string assemblyName,
        DirectoryInfo csharpDir,
        NullableContextOptions nullableContextOptions)
    {
        // Recursive: the dqm corpus keeps its libraries in cms/ and lib/ subdirectories.
        var gcsFiles = csharpDir.GetFiles("*.g.cs", SearchOption.AllDirectories);
        Assert.AreNotEqual(0, gcsFiles.Length, $"No generated files found in {csharpDir.FullName}.");

        AssertNoNullableDiagnostics(
            assemblyName,
            gcsFiles.Select(f => CSharpSyntaxTree.ParseText(File.ReadAllText(f.FullName), path: f.FullName)).ToArray(),
            nullableContextOptions,
            csharpDir.FullName);
    }

    /// <summary>
    /// Compiles the given sources under <paramref name="nullableContextOptions"/> and asserts no
    /// CS86xx diagnostic is reported. Scoped to the nullable family on purpose: compiling generated
    /// code standalone also raises reference-resolution noise (CS1701, CS0436) that says nothing
    /// about the emitted code.
    /// </summary>
    private static void AssertNoNullableDiagnostics(
        string assemblyName,
        SyntaxTree[] syntaxTrees,
        NullableContextOptions nullableContextOptions,
        string description)
    {
        var compilation = CSharpCompilation.Create(
            assemblyName,
            syntaxTrees: syntaxTrees,
            references: GetCompilationReferences(),
            options: new CSharpCompilationOptions(
                outputKind: OutputKind.DynamicallyLinkedLibrary,
                nullableContextOptions: nullableContextOptions));

        var nullableDiagnostics = compilation.GetDiagnostics()
            .Where(d => d.Severity >= DiagnosticSeverity.Warning && d.Id.StartsWith("CS86", StringComparison.Ordinal))
            .ToList();

        Assert.AreEqual(
            0,
            nullableDiagnostics.Count,
            $"Expected no CS86xx diagnostics in {description} under {nullableContextOptions}. Found:{Environment.NewLine}{string.Join(Environment.NewLine, nullableDiagnostics.Take(200))}");
    }

    private static IEnumerable<MetadataReference> GetCompilationReferences()
    {
        var tpa = AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES") as string
            ?? throw new InvalidOperationException("Trusted platform assemblies were not available.");

        var references = tpa
            .Split(Path.PathSeparator, StringSplitOptions.RemoveEmptyEntries)
            .Select(path => MetadataReference.CreateFromFile(path))
            .ToList();

        references.Add(MetadataReference.CreateFromFile(typeof(CqlDefinitionAttribute).Assembly.Location));
        references.Add(MetadataReference.CreateFromFile(typeof(CqlContext).Assembly.Location));
        references.Add(MetadataReference.CreateFromFile(typeof(DateIso8601).Assembly.Location));
        references.Add(MetadataReference.CreateFromFile(typeof(Resource).Assembly.Location));

        return references
            .GroupBy(r => r.Display, StringComparer.OrdinalIgnoreCase)
            .Select(g => g.First());
    }
}
