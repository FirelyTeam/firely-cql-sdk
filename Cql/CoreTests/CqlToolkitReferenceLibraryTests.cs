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
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Runtime;
using Library = Hl7.Cql.Elm.Library;

namespace CoreTests;

[TestClass]
public class CqlToolkitReferenceLibraryTests
{
    private static readonly CqlVersionedLibraryIdentifier FhirHelpers = CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion("FHIRHelpers", "4.0.1");

    [TestMethod]
    public void TranslateToElm_WithAnIncludeAvailableOnlyAsElm_TranslatesWithoutErrors()
    {
        // Arrange
        var cqlToolkit = CreateCqlToolkit(
            """
            library UsesHelpers version '1.0.0'
            using FHIR version '4.0.1'
            include FHIRHelpers version '4.0.1'
            define "Text": FHIRHelpers.ToString(FHIR.string { value: 'x' })
            define "Implicit": FHIR.boolean { value: true } and true
            """);

        // Act
        cqlToolkit.AddReferenceLibraries([ReadFhirHelpersElm()]).TranslateToElm();

        // Assert
        TranslateErrors(cqlToolkit).Should().BeEmpty();
    }

    [TestMethod]
    public void TranslateToElm_WithAnIncludeAvailableOnlyAsElm_ReportsTheErrorsOfTheIncludingLibraryAlone()
    {
        // Arrange
        var cqlToolkit = CreateCqlToolkit(
            """
            library UsesHelpers version '1.0.0'
            using FHIR version '4.0.1'
            include FHIRHelpers version '4.0.1'
            define "Text": FHIRHelpers.ToString(FHIR.string { value: 'x' })
            define "Wrong": 1 + 'a'
            """);

        // Act
        cqlToolkit.AddReferenceLibraries([ReadFhirHelpersElm()]).TranslateToElm();

        // Assert
        TranslateErrors(cqlToolkit).Should().ContainSingle()
            .Which.Should().Contain("Add");
    }

    [TestMethod]
    public void TranslateToElm_WithoutTheReferenceLibrary_ReportsTheIncludeAsUnresolved()
    {
        // Arrange
        var cqlToolkit = CreateCqlToolkit(
            """
            library UsesHelpers version '1.0.0'
            using FHIR version '4.0.1'
            include FHIRHelpers version '4.0.1'
            define "Text": FHIRHelpers.ToString(FHIR.string { value: 'x' })
            """);

        // Act
        cqlToolkit.TranslateToElm();

        // Assert
        TranslateErrors(cqlToolkit).Should().Contain(error => error.Contains("FHIRHelpers"));
    }

    [TestMethod]
    public void TranslateToElm_WithADefinitionWithoutAResultType_ReportsAReferenceToIt()
    {
        // Arrange - ELM translated without result types declares none for its statements.
        var reference = CreateLibrary(
            "Helpers",
            "1.0.0",
            new ExpressionDef { name = "Untyped", accessLevel = AccessModifier.Public, context = "Unfiltered" },
            new ExpressionDef { name = "Typed", accessLevel = AccessModifier.Public, context = "Unfiltered", resultTypeName = SystemTypes.IntegerType.name });
        var cqlToolkit = CreateCqlToolkit(
            """
            library UsesHelpers version '1.0.0'
            include Helpers version '1.0.0'
            define "FromTyped": Helpers."Typed" + 1
            define "FromUntyped": Helpers."Untyped"
            """);

        // Act
        cqlToolkit.AddReferenceLibraries([reference]).TranslateToElm();

        // Assert
        TranslateErrors(cqlToolkit).Should().ContainSingle()
            .Which.Should().Contain("Untyped");
    }

    [TestMethod]
    public void TranslateToElm_WithAFluentFunctionInElmThisTranslatorWrote_CallsItFluently()
    {
        // Arrange
        var helpers = CreateCqlToolkit(
            """
            library Helpers version '1.0.0'
            define fluent function double(a Integer): a * 2
            """).TranslateToElm();
        var helpersElm = helpers.ArtifactsById.Values.Single().ResultElmLibrary!;
        var cqlToolkit = CreateCqlToolkit(
            """
            library UsesHelpers version '1.0.0'
            include Helpers version '1.0.0'
            define "Doubled": 3.double()
            """);

        // Act
        cqlToolkit.AddReferenceLibraries([helpersElm]).TranslateToElm();

        // Assert
        TranslateErrors(cqlToolkit).Should().BeEmpty();
    }

    [TestMethod]
    public void TranslateToElm_WithTwoFunctionsOfTheSameSignatureInTheReferenceLibrary_ReportsTheIncludeAsAnError()
    {
        // Arrange
        var reference = CreateLibrary(
            "Helpers",
            "1.0.0",
            CreateIntegerFunction("Twice"),
            CreateIntegerFunction("Twice"));
        var cqlToolkit = CreateCqlToolkit(
            """
            library UsesHelpers version '1.0.0'
            include Helpers version '1.0.0'
            define "Value": 1
            """);

        // Act
        cqlToolkit.AddReferenceLibraries([reference]).TranslateToElm();

        // Assert
        TranslateErrors(cqlToolkit).Should().ContainSingle()
            .Which.Should().Contain("Helpers");
    }

    [TestMethod]
    public void AddReferenceLibraries_WithTheIdentifierOfACqlLibrary_KeepsTheCqlLibrary()
    {
        // Arrange - the CQL of Helpers defines "Value", its ELM does not.
        var cqlToolkit = CreateCqlToolkit(
            """
            library Helpers version '1.0.0'
            define "Value": 1
            """,
            """
            library UsesHelpers version '1.0.0'
            include Helpers version '1.0.0'
            define "Result": Helpers."Value"
            """);

        // Act
        cqlToolkit.AddReferenceLibraries([CreateLibrary("Helpers", "1.0.0")]).TranslateToElm();

        // Assert
        TranslateErrors(cqlToolkit).Should().BeEmpty();
    }

    [TestMethod]
    public void TranslateToElm_WithAnIncludeAvailableOnlyAsElm_ProducesElmThatEvaluates()
    {
        // Arrange
        var fhirHelpers = ReadFhirHelpersElm();
        var cqlToolkit = CreateCqlToolkit(
            """
            library UsesHelpers version '1.0.0'
            using FHIR version '4.0.1'
            include FHIRHelpers version '4.0.1'
            define "Text": FHIRHelpers.ToString(FHIR.string { value: 'x' })
            define "Implicit": FHIR.boolean { value: true } and true
            """);
        cqlToolkit.AddReferenceLibraries([fhirHelpers]).TranslateToElm();
        var elmToolkit = new ElmToolkit()
            .AddElmLibraries(fhirHelpers)
            .AddElmFromCqlToolkit(cqlToolkit);

        // Act
        using var librarySetInvoker = elmToolkit.CreateLibrarySetInvoker();
        var cqlContext = FhirCqlContext.ForBundle();
        var libraryIdentifier = CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion("UsesHelpers", "1.0.0");

        // Assert
        librarySetInvoker.InvokeLibraryDefinition(cqlContext, libraryIdentifier, "Text").Should().Be("x");
        librarySetInvoker.InvokeLibraryDefinition(cqlContext, libraryIdentifier, "Implicit").Should().Be(true);
        cqlToolkit.ArtifactsById.Keys.Should().NotContain(FhirHelpers);
    }

    private static CqlToolkit CreateCqlToolkit(params string[] cqlLibraries) =>
        new CqlToolkit().AddCqlLibraries(cqlLibraries.Select(CqlLibraryString.Parse));

    private static List<string> TranslateErrors(CqlToolkit cqlToolkit) =>
        cqlToolkit.ArtifactsById.Values
            .SelectMany(artifacts => artifacts.ResultElmLibrary?.GetErrors() ?? [])
            .Where(error => error.errorSeverity == ErrorSeverity.error)
            .Select(error => error.message)
            .ToList();

    private static Library CreateLibrary(
        string name,
        string version,
        params ExpressionDef[] statements) =>
        new()
        {
            identifier = new VersionedIdentifier { id = name, version = version },
            statements = statements,
        };

    private static FunctionDef CreateIntegerFunction(string name) =>
        new()
        {
            name = name,
            accessLevel = AccessModifier.Public,
            context = "Unfiltered",
            operand = [new OperandDef { name = "a", operandTypeSpecifier = SystemTypes.IntegerType }],
            resultTypeSpecifier = SystemTypes.IntegerType,
        };

    private static Library ReadFhirHelpersElm() =>
        Library.ParseFromJson(File.ReadAllText(Path.Combine("Input", "ELM", "HL7", "FHIRHelpers-4.0.1.json")));
}
