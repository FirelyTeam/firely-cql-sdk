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
/// (e.g. while refactoring the expression-building or code-writing pipeline).
/// When an output change is intentional, regenerate the corpus with PackagerCLI
/// (see its launchSettings.json profiles) and commit the updated <c>.g.cs</c> files.
/// </summary>
[TestClass]
public class CSharpGenerationGoldenTests
{
    [TestMethod]
    public void Regenerated_RR23_CSharp_Matches_CheckedInFiles() =>
        AssertRegeneratedCSharpMatchesGoldenFiles(
            LibrarySetsDirs.RR23.ElmDir,
            "RR23",
            LibrarySetsDirs.RR23.CSharpDir,
            version: "1.0.0",
            goldenCorpusIsComplete: true);

    [TestMethod]
    public void Regenerated_DqmQiCore2025_CMS56_CSharp_Matches_CheckedInFiles() =>
        AssertRegeneratedCSharpMatchesGoldenFiles(
            LibrarySetsDirs.DqmQiCore2025.ElmDir,
            "CMS56FHIRFuncStatHipReplacement",
            LibrarySetsDirs.DqmQiCore2025.ExtractedCSharpDir,
            // Only the top library's C# is checked in (extracted from the packaged FHIR Library
            // resource); its dependencies are generated but have no golden counterpart.
            goldenCorpusIsComplete: false);

    private static void AssertRegeneratedCSharpMatchesGoldenFiles(
        DirectoryInfo elmDir,
        string topLibraryName,
        DirectoryInfo goldenCSharpDir,
        string version = "",
        bool goldenCorpusIsComplete = true)
    {
        LibrarySet librarySet = new();
        librarySet.LoadLibraryAndDependencies(elmDir, topLibraryName, version);

        var elmToolkit =
            new ElmToolkit()
                .AddElmLibraries(librarySet)
                .CompileToAssemblies();

        var generatedByIdentifier =
            elmToolkit
                .GetElmToCSharpResults()
                .ToDictionary(t => t.libraryIdentifier.ToString()!, t => t.cSharp);

        var goldenFiles = goldenCSharpDir.GetFiles("*.g.cs");
        Assert.AreNotEqual(0, goldenFiles.Length, $"No golden .g.cs files found in {goldenCSharpDir.FullName}.");

        foreach (var goldenFile in goldenFiles)
        {
            var libraryIdentifier = goldenFile.Name[..^".g.cs".Length];
            Assert.IsTrue(
                generatedByIdentifier.TryGetValue(libraryIdentifier, out var generated),
                $"No C# was generated for golden file {goldenFile.Name}. Generated libraries: {string.Join(", ", generatedByIdentifier.Keys)}.");

            var golden = File.ReadAllText(goldenFile.FullName);
            Assert.AreEqual(
                NormalizeLineEndings(golden),
                NormalizeLineEndings(generated!),
                $"Regenerated C# for {libraryIdentifier} differs from the checked-in {goldenFile.FullName}.");
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

    private static string NormalizeLineEndings(string text) =>
        text.Replace("\r\n", "\n").TrimEnd('\n');
}
