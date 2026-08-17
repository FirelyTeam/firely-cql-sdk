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
/// Generates C# from the <c>LogicTest</c> ELM fixture, shared by the tests that inspect emitted
/// text. One helper rather than a copy per test class, so the load-and-compile chain (and the cost
/// of it) is stated once.
/// </summary>
internal static class LogicTestFixture
{
    private const string LibraryName = "LogicTest";
    private const string LibraryVersion = "1.0.0";

    /// <summary>
    /// The fixture's C# under the default configuration. Cached: generating it runs a full ELM
    /// load plus a Roslyn compile, and every assertion over the default output wants the same
    /// string.
    /// </summary>
    public static string DefaultCSharp => _defaultCSharp.Value;

    private static readonly Lazy<string> _defaultCSharp = new(() => Generate(ElmToolkitConfig.Default));

    /// <summary>Generates with a specific configuration, for tests that vary one.</summary>
    public static string Generate(ElmToolkitConfig config)
    {
        LibrarySet librarySet = new();
        librarySet.LoadLibraryAndDependencies(new DirectoryInfo("Input/ELM/HL7"), LibraryName, LibraryVersion);

        return new ElmToolkit(config: config)
            .AddElmLibraries(librarySet)
            .CompileToAssemblies()
            .GetElmToCSharpResults()
            .Single()
            .cSharp;
    }
}
