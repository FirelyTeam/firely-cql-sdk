/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.Compiler;

namespace CoreTests;

/// <summary>
/// Golden-file tests: regenerate C# from the checked-in ELM corpora under <c>LibrarySets\</c>
/// and verify the output is identical to the checked-in <c>.g.cs</c> files, modulo line-ending
/// differences and a trailing newline (git may rewrite line endings on checkout, so the
/// comparison normalizes those before asserting equality).
/// These tests guard the C# code generator against unintended output changes
/// (e.g. while refactoring the expression-building or code-writing pipeline). Before phase 6 of
/// the Linq.Expressions removal (docs/linq-expression-removal-plan.md) these tests also proved
/// the typed-IR pipeline produced byte-identical output to the Expression-based one; now that the
/// typed-IR pipeline is the only pipeline (the old one is deleted), the old-pipeline and
/// IR-pipeline variants collapsed into a single set of tests through the public
/// <see cref="ElmToolkit"/> API.
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

    private static Dictionary<string, string> GenerateWithToolkit(LibrarySet librarySet)
    {
        var elmToolkit =
            new ElmToolkit()
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
        text.Replace("\r\n", "\n").TrimEnd('\n');
}
