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

namespace CoreTests;

[TestClass]
public class LibraryVersionCompilationTests
{
    [TestMethod]
    [DataRow("library NoVersion", "NoVersion", null, DisplayName = "no version")]
    [DataRow("library Draft version '1.0.0-draft'", "Draft", "1.0.0-draft", DisplayName = "a version that is not numeric")]
    [DataRow("library Wide version '1.0.70000'", "Wide", "1.0.70000", DisplayName = "a numeric version too wide for an assembly version")]
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
              .And.Contain("public string Version => null;");
    }

    private static LibrarySetInvoker CompileLibrary(string cql, out string cSharp)
    {
        var cqlToolkit = new CqlToolkit().AddCqlLibraries([CqlLibraryString.Parse(cql)]).TranslateToElm();
        var elmToolkit = new ElmToolkit().AddElmFromCqlToolkit(cqlToolkit);
        var invoker = elmToolkit.CreateLibrarySetInvoker();
        cSharp = elmToolkit.GetElmToCSharpResults().Single().cSharp;
        return invoker;
    }
}
