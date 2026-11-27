/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;

namespace CoreTests;

/// <summary>
/// Compiles and evaluates CQL conditionals whose two branches are literals and whose test holds a
/// <c>case</c> expression or an <c>is</c> type test. By its branches such a conditional prints as
/// an inline ternary; a <c>case</c> and a type test print as statements. <see cref="CSharpEmitterTests"/>
/// pins the C# text of these shapes; this class checks that the C# compiles and gives the CQL result.
/// </summary>
[TestClass]
public class ConditionalTestEmissionTests
{
    [TestMethod]
    [DataRow(
        "if (case when First({1, 2}) = 1 then 1 else 2 end) = 1 then 'x' else 'y'", "x",
        DisplayName = "case in the test, true")]
    [DataRow(
        "if (case when First({1, 2}) = 2 then 1 else 2 end) = 1 then 'x' else 'y'", "y",
        DisplayName = "case in the test, false")]
    [DataRow(
        "if exists (({1, 2, 3}) n where (case when n = 1 then true when n = 2 then false else null end)) then 'x' else 'y'", "x",
        DisplayName = "case in a query in the test, true")]
    [DataRow(
        "if exists (({2, 3}) n where (case when n = 1 then true when n = 2 then false else null end)) then 'x' else 'y'", "y",
        DisplayName = "case in a query in the test, false")]
    [DataRow(
        "if exists (({1, 'a'}) v where (if v is Integer then (v as Integer) > 0 else false)) then 'x' else 'y'", "x",
        DisplayName = "type test in a query in the test, true")]
    [DataRow(
        "if exists (({0, 'a'}) v where (if v is Integer then (v as Integer) > 0 else false)) then 'x' else 'y'", "y",
        DisplayName = "type test in a query in the test, false")]
    public void Conditional_TestHoldsACaseOrATypeTest_CompilesAndEvaluates(string expression, string expected)
    {
        var cql = CqlLibraryString.Parse($"""
            library ConditionalTestEmission version '1.0.0'

            define "Result": {expression}
            """);
        var elmLibrary = new CqlToolkit(config: new CqlToolkitConfig([CqlModel.ElmR1, CqlModel.Fhir401]))
                         .AddCqlLibraries([cql])
                         .TranslateToElm()
                         .GetCqlToolkitResults()
                         .First()
                         .elmLibrary;

        var elmToolkit = new ElmToolkit()
                         .AddElmLibraries([elmLibrary])
                         .CompileToAssemblies();
        var (libraryIdentifier, _, _, assemblyBinary, debugSymbols) = elmToolkit.GetElmToAssemblyResults().First();
        var invoker = new InvocationToolkit()
                      .AddAssemblyBinaries([new AssemblyBinary(assemblyBinary, debugSymbols)])
                      .CreateLibrarySetInvoker();

        var result = invoker.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), libraryIdentifier, "Result");

        Assert.AreEqual(expected, result);
    }
}
