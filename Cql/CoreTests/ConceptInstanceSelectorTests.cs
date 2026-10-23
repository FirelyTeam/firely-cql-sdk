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
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace CoreTests;

/// <summary>
/// Spec §9.B, Concept: the structured type <c>Concept { codes List&lt;Code&gt;, display String }</c>. Spec §2,
/// Structured Values (Tuples): an element of the type that the selector leaves out is null, so a <c>Concept</c> selector
/// without a <c>display</c> is a concept with those codes and a null display, and one without <c>codes</c> is a concept
/// with null codes.
/// </summary>
[TestClass]
public class ConceptInstanceSelectorTests
{
    private const string LoincCode = "Code { code: '1234-5', system: 'http://loinc.org' }";

    private const string SnomedCode = "Code { code: '66071002', system: 'http://snomed.info/sct', display: 'Viral hepatitis type B' }";

    private static readonly CqlCode Loinc = new("1234-5", "http://loinc.org");

    private static readonly CqlCode Snomed = new("66071002", "http://snomed.info/sct", display: "Viral hepatitis type B");

    private static IEnumerable<object?[]> ConceptSelectorCases =>
    [
        ["one code with a display", $"Concept {{ codes: {{ {LoincCode} }}, display: 'Blood pressure' }}", new[] { Loinc }, "Blood pressure"],
        ["one code without a display", $"Concept {{ codes: {{ {LoincCode} }} }}", new[] { Loinc }, null],
        ["several codes with a display", $"Concept {{ codes: {{ {LoincCode}, {SnomedCode} }}, display: 'Hepatitis B' }}", new[] { Loinc, Snomed }, "Hepatitis B"],
        ["several codes without a display", $"Concept {{ codes: {{ {LoincCode}, {SnomedCode} }} }}", new[] { Loinc, Snomed }, null],
    ];

    [TestMethod]
    [DynamicData(nameof(ConceptSelectorCases))]
    public void ConceptInstanceSelector_CompilesAndEvaluatesToAConceptWithItsCodesAndDisplay(
        string caseDescription,
        string selector,
        CqlCode[] expectedCodes,
        string? expectedDisplay)
    {
        using var invoker = CompileLibrary($"define \"Concept\": {selector}");

        var result = invoker.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), LibraryIdentifier, "Concept");

        var concept = result.Should().BeOfType<CqlConcept>(caseDescription).Subject;
        concept.codes.Should().Equal(expectedCodes, caseDescription);
        concept.display.Should().Be(expectedDisplay, caseDescription);
    }

    /// <summary>
    /// Spec Appendix A, <c>instanceSelector</c>: <c>Concept { : }</c> is the selector without any element.
    /// </summary>
    private static IEnumerable<object?[]> ConceptSelectorWithoutCodesCases =>
    [
        ["a display without codes", "Concept { display: 'Blood pressure' }", "Blood pressure"],
        ["neither codes nor a display", "Concept { : }", null],
    ];

    [TestMethod]
    [DynamicData(nameof(ConceptSelectorWithoutCodesCases))]
    public void ConceptInstanceSelectorWithoutCodes_CompilesAndEvaluatesToAConceptWithNullCodes(
        string caseDescription,
        string selector,
        string? expectedDisplay)
    {
        using var invoker = CompileLibrary($"define \"Concept\": {selector}");

        var result = invoker.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), LibraryIdentifier, "Concept");

        var concept = result.Should().BeOfType<CqlConcept>(caseDescription).Subject;
        concept.codes.Should().BeNull(caseDescription);
        concept.display.Should().Be(expectedDisplay, caseDescription);
    }

    private static readonly CqlVersionedLibraryIdentifier LibraryIdentifier =
        CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion("ConceptSelector", "1.0.0");

    private static LibrarySetInvoker CompileLibrary(string definitions)
    {
        var cql = $"library ConceptSelector version '1.0.0'\n{definitions}";
        var cqlToolkit = new CqlToolkit().AddCqlLibraries([CqlLibraryString.Parse(cql)]).TranslateToElm();
        var elmToolkit = new ElmToolkit().AddElmFromCqlToolkit(cqlToolkit);
        return elmToolkit.CreateLibrarySetInvoker();
    }
}
