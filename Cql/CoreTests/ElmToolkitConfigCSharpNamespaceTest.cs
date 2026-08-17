/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.Compiler;

namespace CoreTests;

/// <summary>
/// Coverage for <see cref="ElmToolkitConfig.CSharpNamespace"/>, the toolkit setting behind the
/// Packager CLI's <c>--cs-namespace</c> option and the <c>Elm:CSharpNamespace</c> configuration
/// key. Kept in its own class rather than riding along in an operator-lowering fixture, so that
/// deleting or repointing a CQL fixture cannot silently drop the only coverage of a
/// consumer-facing config option.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class ElmToolkitConfigCSharpNamespaceTest
{
    /// <summary>
    /// A value wraps the generated code in that namespace; null (the default) and empty (what a
    /// JSON <c>null</c> binds to — the JSON configuration provider has no null) both produce
    /// namespace-less code.
    /// </summary>
    [TestMethod]
    public void CSharpNamespace_WrapsGeneratedCode()
    {
        StringAssert.Contains(
            Generate(new ElmToolkitConfig(CSharpNamespace: "My.Ns")),
            "namespace My.Ns;", "a namespace set in the config must be emitted.");

        // Anchored on the file-scoped declaration rather than the bare word "namespace", which
        // could appear in any generated comment or string literal.
        Assert.IsFalse(
            ContainsNamespaceDeclaration(Generate(ElmToolkitConfig.Default)),
            "the default (null) must emit namespace-less code.");

        Assert.IsFalse(
            ContainsNamespaceDeclaration(Generate(new ElmToolkitConfig(CSharpNamespace: ""))),
            "an empty value (JSON null binds as \"\") must emit namespace-less code.");
    }

    private static bool ContainsNamespaceDeclaration(string generated) =>
        generated
            .Split('\n')
            .Any(line => line.TrimStart().StartsWith("namespace ", StringComparison.Ordinal));

    private static string Generate(ElmToolkitConfig config)
    {
        LibrarySet librarySet = new();
        librarySet.LoadLibraryAndDependencies(new DirectoryInfo("Input/ELM/HL7"), "LogicTest", "1.0.0");

        return new ElmToolkit(config: config)
            .AddElmLibraries(librarySet)
            .CompileToAssemblies()
            .GetElmToCSharpResults()
            .Single()
            .cSharp;
    }
}
