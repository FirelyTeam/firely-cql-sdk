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
/// and verify the output is identical to the checked-in <c>.g.cs</c> files.
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
            version: "1.0.0");

    [TestMethod]
    public void Regenerated_DqmQiCore2025_CMS56_CSharp_Matches_CheckedInFiles() =>
        AssertRegeneratedCSharpMatchesGoldenFiles(
            LibrarySetsDirs.DqmQiCore2025.ElmDir,
            "CMS56FHIRFuncStatHipReplacement",
            LibrarySetsDirs.DqmQiCore2025.ExtractedCSharpDir);

    private static void AssertRegeneratedCSharpMatchesGoldenFiles(
        DirectoryInfo elmDir,
        string topLibraryName,
        DirectoryInfo goldenCSharpDir,
        string version = "")
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
    }

    private static string NormalizeLineEndings(string text) =>
        text.Replace("\r\n", "\n").TrimEnd('\n');
}
