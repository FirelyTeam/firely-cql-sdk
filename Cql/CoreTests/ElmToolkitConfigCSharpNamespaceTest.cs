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
/// key. Kept in its own class rather than riding along in the operator-lowering tests, so that a
/// reader looking for this setting's coverage finds it by name.
/// <para>It still generates from the shared <see cref="LogicTestFixture"/>, since the setting is
/// library-agnostic and any fixture would do — the coupling is to that helper, not to the logical
/// operator tests.</para>
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
        // All three cases go through the same declaration-anchored rule, positive included: a bare
        // "namespace My.Ns;" substring search would pass on the very hazard the anchoring exists
        // for — the words appearing inside a generated comment or string literal.
        Assert.AreEqual(
            "namespace My.Ns;",
            NamespaceDeclaration(LogicTestFixture.Generate(new ElmToolkitConfig(CSharpNamespace: "My.Ns"))),
            "a namespace set in the config must be emitted as a file-scoped declaration.");

        Assert.IsNull(
            NamespaceDeclaration(LogicTestFixture.DefaultCSharp),
            "the default (null) must emit namespace-less code.");

        Assert.IsNull(
            NamespaceDeclaration(LogicTestFixture.Generate(new ElmToolkitConfig(CSharpNamespace: ""))),
            "an empty value (JSON null binds as \"\") must emit namespace-less code.");
    }

    /// <summary>The generated file's namespace declaration, or null when it has none.</summary>
    private static string? NamespaceDeclaration(string generated) =>
        generated
            .Split('\n')
            .Select(line => line.Trim())
            .FirstOrDefault(line => line.StartsWith("namespace ", StringComparison.Ordinal));
}
