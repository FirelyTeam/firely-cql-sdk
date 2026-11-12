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
        TranslateErrors(cqlToolkit).Should().Contain(error => error.StartsWith("Unable to resolve library: FHIRHelpers version '4.0.1'"));
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
    public void TranslateToElm_WithAFunctionWithAnUntypedOperand_ReportsACallToIt()
    {
        // Arrange
        var untyped = CreateIntegerFunction("F");
        untyped.operand = [new OperandDef { name = "a" }];
        var reference = CreateLibrary("Helpers", "1.0.0", untyped, CreateIntegerFunction("G"));
        var cqlToolkit = CreateCqlToolkit(
            """
            library UsesHelpers version '1.0.0'
            include Helpers version '1.0.0'
            define "FromTyped": Helpers.G(1)
            define "FromUntyped": Helpers.F(1)
            """);

        // Act
        cqlToolkit.AddReferenceLibraries([reference]).TranslateToElm();

        // Assert
        TranslateErrors(cqlToolkit).Should().ContainSingle()
            .Which.Should().StartWith("Could not resolve call to").And.Contain("F");
    }

    [TestMethod]
    public void TranslateToElm_WithAStatementWithoutANameInTheReferenceLibrary_ResolvesTheInclude()
    {
        // Arrange
        var reference = CreateLibrary(
            "Helpers",
            "1.0.0",
            new ExpressionDef { accessLevel = AccessModifier.Public, context = "Unfiltered", resultTypeSpecifier = SystemTypes.IntegerType },
            new ExpressionDef { name = "Typed", accessLevel = AccessModifier.Public, context = "Unfiltered", resultTypeSpecifier = SystemTypes.IntegerType });
        var cqlToolkit = CreateCqlToolkit(
            """
            library UsesHelpers version '1.0.0'
            include Helpers version '1.0.0'
            define "FromTyped": Helpers."Typed" + 1
            """);

        // Act
        cqlToolkit.AddReferenceLibraries([reference]).TranslateToElm();

        // Assert
        TranslateErrors(cqlToolkit).Should().BeEmpty();
    }

    [TestMethod]
    public void TranslateToElm_WithAFluentFunctionInElmJsonThisTranslatorWrote_CallsItFluently()
    {
        // Arrange - the ELM goes through JSON, as a host that stores it reads it back.
        var helpers = CreateCqlToolkit(
            """
            library Helpers version '1.0.0'
            define fluent function double(a Integer): a * 2
            """).TranslateToElm();
        var helpersElm = Library.ParseFromJson(helpers.ArtifactsById.Values.Single().ResultElmLibrary!.SerializeToJson());
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
        var doubled = cqlToolkit.ArtifactsById.Values.Single().ResultElmLibrary!.statements.Single(statement => statement.name == "Doubled");
        doubled.expression.Should().BeOfType<FunctionRef>()
            .Which.name.Should().Be("double");
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
            .Which.Should().Contain("Unable to resolve library: Helpers version '1.0.0'").And.Contain("'Twice'");
    }

    [TestMethod]
    public void TranslateToElm_WithReferencesToParametersAndTerminologyOfAReferenceLibrary_TranslatesWithoutErrors()
    {
        // Arrange
        var helpers = CreateCqlToolkit(
            """
            library Helpers version '1.0.0'
            codesystem "Snomed": 'http://snomed.info/sct'
            valueset "Conditions": 'http://example.org/ValueSet/conditions'
            code "Asthma": '195967001' from "Snomed"
            concept "Respiratory": { "Asthma" }
            parameter "Threshold" Integer default 3
            """).TranslateToElm();
        var helpersElm = Library.ParseFromJson(helpers.ArtifactsById.Values.Single().ResultElmLibrary!.SerializeToJson());
        var cqlToolkit = CreateCqlToolkit(
            """
            library UsesHelpers version '1.0.0'
            include Helpers version '1.0.0'
            define "CodeSystem": Helpers."Snomed"
            define "ValueSet": Helpers."Conditions"
            define "Code": Helpers."Asthma"
            define "Concept": Helpers."Respiratory"
            define "Parameter": Helpers."Threshold" + 1
            """);

        // Act
        cqlToolkit.AddReferenceLibraries([helpersElm]).TranslateToElm();

        // Assert
        TranslateErrors(cqlToolkit).Should().BeEmpty();
    }

    [TestMethod]
    public void TranslateToElm_WithLibraryQualifiedIdentifiersOfAReferenceLibrary_ReferencesItsDefinitions()
    {
        // Arrange
        var helpers = CreateCqlToolkit(
            """
            library Helpers version '1.0.0'
            using FHIR version '4.0.1'
            valueset "Conditions": 'http://example.org/ValueSet/conditions'
            context Patient
            define "Encounters": [Encounter]
            define "Mother": singleton from ([RelatedPerson])
            """).TranslateToElm();
        var helpersElm = Library.ParseFromJson(helpers.ArtifactsById.Values.Single().ResultElmLibrary!.SerializeToJson());
        var cqlToolkit = CreateCqlToolkit(
            """
            library UsesHelpers version '1.0.0'
            using FHIR version '4.0.1'
            include Helpers version '1.0.0'
            context Patient
            define "Source": Helpers."Encounters" E return E.id
            define "Terminology": [Condition: Helpers."Conditions"]
            define "Context": [Helpers."Mother" -> Observation]
            """);

        // Act
        cqlToolkit.AddReferenceLibraries([helpersElm]).TranslateToElm();

        // Assert
        TranslateErrors(cqlToolkit).Should().BeEmpty();
        var statements = cqlToolkit.ArtifactsById.Values.Single().ResultElmLibrary!.statements.ToDictionary(statement => statement.name, statement => statement.expression);
        var source = statements["Source"].Should().BeOfType<Query>().Which.source.Should().ContainSingle().Which.expression;
        source.Should().BeOfType<ExpressionRef>().Which.Should().BeEquivalentTo(new { name = "Encounters", libraryName = "Helpers" });
        statements["Terminology"].Should().BeOfType<Retrieve>().Which.codes
            .Should().BeOfType<ValueSetRef>().Which.Should().BeEquivalentTo(new { name = "Conditions", libraryName = "Helpers" });
        statements["Context"].Should().BeOfType<Retrieve>().Which.context
            .Should().BeOfType<ExpressionRef>().Which.Should().BeEquivalentTo(new { name = "Mother", libraryName = "Helpers" });
    }

    [TestMethod]
    public void TranslateToElm_WithTwoParametersOfTheSameNameInTheReferenceLibrary_ReportsTheIncludeAsAnError()
    {
        // Arrange
        var reference = CreateLibrary("Helpers", "1.0.0");
        reference.parameters =
        [
            new ParameterDef { name = "P", accessLevel = AccessModifier.Public, parameterTypeSpecifier = SystemTypes.IntegerType },
            new ParameterDef { name = "P", accessLevel = AccessModifier.Public, parameterTypeSpecifier = SystemTypes.StringType },
        ];
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
            .Which.Should().Contain("Unable to resolve library: Helpers version '1.0.0'").And.Contain("'P'");
    }

    [TestMethod]
    public void TranslateToElm_WithClashingDefinitionsInAQualifiedReferenceLibrary_NamesTheQualifiedLibrary()
    {
        // Arrange
        var reference = CreateLibrary("Helpers", "1.0.0", CreateIntegerFunction("Twice"), CreateIntegerFunction("Twice"));
        reference.identifier.system = "Acme";
        var cqlToolkit = CreateCqlToolkit(
            """
            library UsesHelpers version '1.0.0'
            include Acme.Helpers version '1.0.0' called Helpers
            define "Value": 1
            """);

        // Act
        cqlToolkit.AddReferenceLibraries([reference]).TranslateToElm();

        // Assert
        TranslateErrors(cqlToolkit).Should().ContainSingle()
            .Which.Should().StartWith("Unable to resolve library: Acme.Helpers version '1.0.0'").And.Contain("'Twice'");
    }

    [TestMethod]
    public void TranslateToElm_WithAReferenceLibraryDeclaredWithAQualifiedName_ResolvesTheQualifiedInclude()
    {
        // Arrange - the translator writes the qualifier of the library name as the system of its identifier.
        var helpers = CreateCqlToolkit(
            """
            library Acme.Helpers version '1.0.0'
            define "Value": 1
            """).TranslateToElm();
        var helpersElm = Library.ParseFromJson(helpers.ArtifactsById.Values.Single().ResultElmLibrary!.SerializeToJson());
        var cqlToolkit = CreateCqlToolkit(
            """
            library UsesHelpers version '1.0.0'
            include Acme.Helpers version '1.0.0' called Helpers
            define "Value": Helpers."Value"
            """);

        // Act
        cqlToolkit.AddReferenceLibraries([helpersElm]).TranslateToElm();

        // Assert
        helpersElm.identifier.system.Should().Be("Acme");
        TranslateErrors(cqlToolkit).Should().BeEmpty();
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
    public void AddReferenceLibraries_BeforeACqlLibraryWithTheSameIdentifier_KeepsTheCqlLibrary()
    {
        // Arrange - the CQL of Helpers defines "Value", its ELM does not.
        var cqlLibraries = new[]
        {
            """
            library Helpers version '1.0.0'
            define "Value": 1
            """,
            """
            library UsesHelpers version '1.0.0'
            include Helpers version '1.0.0'
            define "Result": Helpers."Value"
            """,
        };

        // Act
        var cqlToolkit = new CqlToolkit()
            .AddReferenceLibraries([CreateLibrary("Helpers", "1.0.0")])
            .AddCqlLibraries(cqlLibraries.Select(CqlLibraryString.Parse))
            .TranslateToElm();

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
