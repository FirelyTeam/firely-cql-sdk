/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime.IO;

namespace CqlSdkExamples;

internal partial class Program
{
    public void PickExample(string? code)
    {
        // <codegen-switch>
        switch (code)
        {
            case "000": RunAll(); return;
            case "210": LoadCqlFromDirSaveElmToDir(); return;
            case "220": LoadElmFromDirSaveCSharpDllAndPdbToDir(); return;
            case "221": LoadCqlFromDemoDirSaveCSharpToDir(); return;
            case "222": LoadElmFromDirWithCSharpNamespaceSaveCSharpToDir(); return;
            case "230": PackageCqlElmCSharpAndDllFromDirsSaveFhirResourcesToDir(); return;
            case "240": PackageViaCqlAndElmToolkitsSaveFhirResourcesToDir(); return;
            case "250": PackageViaCqlToolkitsSaveFhirResourcesToDir(); return;
            case "251": PackageInclDebugSymbolsViaCqlToolkitsSaveFhirResourcesToDir(); return;
            case "310": InvokingCqlHelloWorld(); return;
            case "320": InvokingCqlHelloWorldWithParameter(); return;
            case "330": InvokingCqlHelloWorldWithFunctionArgument(); return;
            case "400": InvokingFromAllFhirResourcesInDirectory(); return;
            case "410": InvokingFromFhirResourceAndDependenciesInDirectory(); return;
            case "500": ExtendingFunctionalityLogLibraryStatements(); return;
        }
        // </codegen-switch>
    }

    private void SetCurrentDirectory(string path)
    {
        DirectoryPreparationStrategy.CreateIfNotExists(new DirectoryInfo(path));
        Environment.CurrentDirectory = path;
    }

    private static readonly string InitialCurrentDirectory = Environment.CurrentDirectory;

    private static readonly string LibrarySetsDirectory =
        (new DirectoryInfo(Environment.CurrentDirectory)
             .FindParentDirectoryContaining("LibrarySets")
         ?? throw new DirectoryNotFoundException("Could not find LibrarySets directory in any of the parent directories.")
        )
        .CreateSubdirectory("LibrarySets")
        .FullName;
}

file static class DirectoryInfoExtensions
{
    public static IEnumerable<DirectoryInfo> SelfAndParents(
        this DirectoryInfo dir)
    {
        var current = dir;
        while (current != null)
        {
            yield return current;
            current = current.Parent;
        }
    }

    public static DirectoryInfo? FindParentDirectoryContaining(
        this DirectoryInfo dir,
        string searchPattern,
        SearchOption searchOption = SearchOption.TopDirectoryOnly) =>
        dir.SelfAndParents()
           .FirstOrDefault(d => d.EnumerateFileSystemInfos(searchPattern, searchOption).Any());
}
