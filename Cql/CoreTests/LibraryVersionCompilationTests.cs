/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Runtime;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace CoreTests;

[TestClass]
public class LibraryVersionCompilationTests
{
    [TestMethod]
    [DataRow("library NoVersion", "NoVersion", null, DisplayName = "no version")]
    [DataRow("library Draft version '1.0.0-draft'", "Draft", "1.0.0-draft", DisplayName = "a version that is not numeric")]
    [DataRow("library Wide version '1.0.70000'", "Wide", "1.0.70000", DisplayName = "a numeric version too wide for an assembly version")]
    [DataRow("library Signed version '1.+0'", "Signed", "1.+0", DisplayName = "a version with a signed part")]
    [DataRow("library Spaced version ' 1.0 '", "Spaced", " 1.0 ", DisplayName = "a numeric version with spaces around it")]
    [DataRow("library Plain version '1.0.0'", "Plain", "1.0.0", DisplayName = "a numeric version")]
    public void CreateLibrarySetInvoker_OfALibraryWithAnyVersionOrNone_CompilesItAndInvokesItsDefinitions(
        string header,
        string name,
        string? version)
    {
        var identifier = CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(name, version);

        using var invoker = CompileLibrary($"{header}\ndefine \"One\": 1", out _);

        invoker.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), identifier, "One").Should().Be(1);
        invoker.LibraryInvokers[identifier].Should().BeAssignableTo<LibraryInstanceInvoker>()
               .Which.Library.Version.Should().Be(version);
    }

    [TestMethod]
    public void GeneratedCSharp_OfALibraryWithoutAVersion_PassesNullForTheVersion()
    {
        using var invoker = CompileLibrary("library NoVersion\ndefine \"One\": 1", out var cSharp);

        cSharp.Should().Contain("""[CqlLibrary("NoVersion", null)]""")
              .And.Contain("public string? Version => null;");
    }

    [TestMethod]
    [DataRow(NullableContextOptions.Enable, DisplayName = "nullable on")]
    [DataRow(NullableContextOptions.Disable, DisplayName = "nullable off")]
    public void GeneratedCSharp_OfALibraryWithoutAVersion_CompilesWithoutWarningsAsACheckedInFile(NullableContextOptions nullable)
    {
        using var invoker = CompileLibrary("library NoVersion\ndefine \"One\": 1", out var cSharp);

        // A checked-in *.g.cs file is built with warnings as errors, in a project with nullable on or off.
        var compilation = CSharpCompilation.Create(
            "NoVersionLibrary",
            [CSharpSyntaxTree.ParseText(cSharp)],
            TrustedPlatformAssemblies.Value,
            new CSharpCompilationOptions(
                OutputKind.DynamicallyLinkedLibrary,
                nullableContextOptions: nullable,
                generalDiagnosticOption: ReportDiagnostic.Error));

        compilation.GetDiagnostics().Where(diagnostic => diagnostic.Severity >= DiagnosticSeverity.Warning)
                   .Select(diagnostic => diagnostic.ToString())
                   .Should().BeEmpty();
    }

    private static readonly Lazy<MetadataReference[]> TrustedPlatformAssemblies = new(() =>
        ((string)AppContext.GetData("TRUSTED_PLATFORM_ASSEMBLIES")!)
            .Split(Path.PathSeparator, StringSplitOptions.RemoveEmptyEntries)
            .Select(path => (MetadataReference)MetadataReference.CreateFromFile(path))
            .ToArray());

    private static LibrarySetInvoker CompileLibrary(string cql, out string cSharp)
    {
        var cqlToolkit = new CqlToolkit().AddCqlLibraries([CqlLibraryString.Parse(cql)]).TranslateToElm();
        var elmToolkit = new ElmToolkit().AddElmFromCqlToolkit(cqlToolkit);
        var invoker = elmToolkit.CreateLibrarySetInvoker();
        cSharp = elmToolkit.GetElmToCSharpResults().Single().cSharp;
        return invoker;
    }
}
