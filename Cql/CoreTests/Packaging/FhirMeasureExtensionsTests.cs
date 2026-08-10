/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */


using Hl7.Cql.Elm;
using Hl7.Cql.Packaging;
using Hl7.FhirPath;
using ElmAnnotation = Hl7.Cql.Elm.Annotation;
using ElmLibrary = Hl7.Cql.Elm.Library;
using FhirLibrary = Hl7.Fhir.Model.Library;
using FhirMeasure = Hl7.Fhir.Model.Measure;

namespace CoreTests.Packaging;

[TestClass]
public class FhirMeasureExtensionsTests
{
    private static readonly System.DateTime TestDate = new(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    private static readonly ResourceCanonicalBuilder CanonicalBuilder =
        (resourceType, identifier, version) => $"http://example.org/fhir/{resourceType}/{identifier}";

    private static Tag CreateTag(string name, string value) => new() { name = name, value = value };

    private static ExpressionDef Def(string name, params Tag[] tags) =>
        new()
        {
            name = name,
            annotation = [new ElmAnnotation { t = tags }],
        };

    /// <summary>
    /// A minimal measure library with two rates (RateA, RateB) that carries the
    /// @measure/@year annotations required for measure creation, plus the given
    /// extra definitions.
    /// </summary>
    private static ExpressionDef[] BaseStatements(params ExpressionDef[] extra) =>
    [
        Def("Initial population",
            CreateTag("measure", "Stratifier Example Measure"),
            CreateTag("year", "2026"),
            CreateTag("group", "RateA"),
            CreateTag("group", "RateB"),
            CreateTag("population", "initial-population")),
        Def("Numerator",
            CreateTag("group", "RateA"),
            CreateTag("group", "RateB"),
            CreateTag("population", "numerator")),
        .. extra,
    ];

    private static FhirMeasure CreateMeasure(params ExpressionDef[] statements) =>
        CreateMeasure(measureGroupCodeSystem: null, statements);

    private static FhirMeasure CreateMeasure(string? measureGroupCodeSystem, params ExpressionDef[] statements)
    {
        var elmLibrary = new ElmLibrary
        {
            identifier = new VersionedIdentifier { id = "StratifierExample", version = "1.0.0" },
            statements = statements,
        };
        var fhirLibrary = new FhirLibrary { Id = "StratifierExample-1.0.0", Name = "StratifierExample" };
        var created = fhirLibrary.TryCreateMeasure(elmLibrary, out var fhirMeasure, CanonicalBuilder, TestDate, measureGroupCodeSystem);
        created.Should().BeTrue();
        return fhirMeasure!;
    }

    [TestMethod]
    public void SingleStratifierDefinition_CreatesContainerWithOneComponent()
    {
        var measure = CreateMeasure(BaseStatements(
            Def("Region Stratifier",
                CreateTag("group", "RateA"),
                CreateTag("stratifier", "Region"))));

        var group = measure.Group.Single(g => g.ElementId == "RateA");
        var container = group.Stratifier.Should().ContainSingle().Subject;
        container.ElementId.Should().Be("RateA-Stratifier");
        container.Code.Should().BeNull("a stratifier with components must not also have a code (FHIR stratifier invariant)");
        container.Description.Should().BeNull("a stratifier with components must not also have a description (FHIR stratifier invariant)");
        container.Criteria.Should().BeNull("the container stratifier only holds components");

        var component = container.Component.Should().ContainSingle().Subject;
        component.ElementId.Should().Be("RateA-StratifierComponent-Region");
        component.Code!.Text.Should().Be("Region");
        component.Description.Should().Be("Region");
        component.Criteria.Language.Should().Be("text/cql-identifier");
        component.Criteria.Expression_.Should().Be("Region Stratifier");

        measure.Group.Single(g => g.ElementId == "RateB").Stratifier.Should().BeEmpty();
    }

    [TestMethod]
    public void MultipleStratifierDefinitions_ShareOneContainerPerGroup()
    {
        var measure = CreateMeasure(BaseStatements(
            Def("Region Stratifier",
                CreateTag("group", "RateA"),
                CreateTag("stratifier", "Region")),
            Def("Age Band Stratifier",
                CreateTag("group", "RateA"),
                CreateTag("stratifier", "AgeBand"))));

        var group = measure.Group.Single(g => g.ElementId == "RateA");
        var container = group.Stratifier.Should().ContainSingle().Subject;
        container.Component.Select(c => c.ElementId).Should().Equal(
            "RateA-StratifierComponent-Region",
            "RateA-StratifierComponent-AgeBand");
        container.Component.Select(c => c.Criteria.Expression_).Should().Equal(
            "Region Stratifier",
            "Age Band Stratifier");
    }

    [TestMethod]
    public void StratifierDefinitionWithMultipleGroups_AddsComponentToEachGroup()
    {
        var measure = CreateMeasure(BaseStatements(
            Def("Region Stratifier",
                CreateTag("group", "RateA"),
                CreateTag("group", "RateB"),
                CreateTag("stratifier", "Region"))));

        foreach (var rate in new[] { "RateA", "RateB" })
        {
            var group = measure.Group.Single(g => g.ElementId == rate);
            var container = group.Stratifier.Should().ContainSingle().Subject;
            container.ElementId.Should().Be($"{rate}-Stratifier");
            var component = container.Component.Should().ContainSingle().Subject;
            component.ElementId.Should().Be($"{rate}-StratifierComponent-Region");
            component.Criteria.Expression_.Should().Be("Region Stratifier");
        }
    }

    [TestMethod]
    public void StratifierDefinitionWithDescription_UsesDescriptionForComponent()
    {
        var measure = CreateMeasure(BaseStatements(
            Def("Region Stratifier",
                CreateTag("group", "RateA"),
                CreateTag("stratifier", "Region"),
                CreateTag("description", "Stratifies by reported region"))));

        var component = measure.Group.Single(g => g.ElementId == "RateA")
                               .Stratifier.Single()
                               .Component.Single();
        component.Description.Should().Be("Stratifies by reported region");
        component.Code!.Text.Should().Be("Region");
    }

    [TestMethod]
    public void DefinitionWithMultipleStratifierTags_AddsOneComponentEach()
    {
        var measure = CreateMeasure(BaseStatements(
            Def("Combined Stratifier",
                CreateTag("group", "RateA"),
                CreateTag("stratifier", "Region"),
                CreateTag("stratifier", "AgeBand"))));

        var container = measure.Group.Single(g => g.ElementId == "RateA").Stratifier.Single();
        container.Component.Select(c => c.ElementId).Should().Equal(
            "RateA-StratifierComponent-Region",
            "RateA-StratifierComponent-AgeBand");
        container.Component.Should().OnlyContain(c => c.Criteria.Expression_ == "Combined Stratifier");
    }

    [TestMethod]
    public void GroupOnlyMentionedByStratifierDefinition_IsCreated()
    {
        var measure = CreateMeasure(BaseStatements(
            Def("Region Stratifier",
                CreateTag("group", "RateC"),
                CreateTag("stratifier", "Region"))));

        var group = measure.Group.Single(g => g.ElementId == "RateC");
        group.Population.Should().BeEmpty();
        group.Stratifier.Single().Component.Single().ElementId.Should().Be("RateC-StratifierComponent-Region");
    }

    [TestMethod]
    public void DuplicateStratifierComponent_Throws()
    {
        var act = () => CreateMeasure(BaseStatements(
            Def("Region Stratifier",
                CreateTag("group", "RateA"),
                CreateTag("stratifier", "Region")),
            Def("Other Region Stratifier",
                CreateTag("group", "RateA"),
                CreateTag("stratifier", "Region"))));

        act.Should().Throw<InvalidOperationException>()
           .WithMessage("*RateA-StratifierComponent-Region*defined twice*");
    }

    [TestMethod]
    public void StratifierWithEmptyValue_Throws()
    {
        var act = () => CreateMeasure(BaseStatements(
            Def("Region Stratifier",
                CreateTag("group", "RateA"),
                CreateTag("stratifier", ""))));

        act.Should().Throw<InvalidOperationException>()
           .WithMessage("*Region Stratifier*empty value*");
    }

    [TestMethod]
    public void StratifierWithoutGroup_Throws()
    {
        var act = () => CreateMeasure(BaseStatements(
            Def("Region Stratifier",
                CreateTag("stratifier", "Region"))));

        act.Should().Throw<InvalidOperationException>()
           .WithMessage("*Region Stratifier*no @group*");
    }

    [TestMethod]
    public void NullTagEntries_AreIgnored()
    {
        // Deserialized ELM can contain null entries in an annotation's tag array.
        var stratifierDef = new ExpressionDef
        {
            name = "Region Stratifier",
            annotation =
            [
                new ElmAnnotation
                {
                    t =
                    [
                        null!,
                        CreateTag("group", "RateA"),
                        CreateTag("stratifier", "Region"),
                    ],
                },
            ],
        };

        var measure = CreateMeasure(BaseStatements(stratifierDef));

        measure.Group.Single(g => g.ElementId == "RateA")
               .Stratifier.Single()
               .Component.Single()
               .ElementId.Should().Be("RateA-StratifierComponent-Region");
    }

    [TestMethod]
    public void DefinitionWithPopulationAndStratifierTags_ProducesBoth()
    {
        // A single define annotated with both @population and @stratifier is supported:
        // it should appear as a population criterion *and* as a stratifier component.
        var measure = CreateMeasure(BaseStatements(
            Def("Denominator Stratifier",
                CreateTag("group", "RateA"),
                CreateTag("population", "denominator"),
                CreateTag("stratifier", "Region"))));

        var group = measure.Group.Single(g => g.ElementId == "RateA");

        group.Population.Should().Contain(p => p.Criteria.Expression_ == "Denominator Stratifier",
            "the definition should contribute a population entry");

        var component = group.Stratifier.Single().Component.Single();
        component.Criteria.Expression_.Should().Be("Denominator Stratifier",
            "the definition should also contribute a stratifier component");
    }

    /// <summary>
    /// The FHIR R4 invariant mea-1 on Measure ("Stratifier SHALL be either a single
    /// criteria or a set of criteria components"), evaluated as the literal FhirPath
    /// expression rather than a hand-rolled C# translation of it.
    /// </summary>
    private const string StratifierInvariant =
        "group.stratifier.all((code | description | criteria).exists() xor component.exists())";

    [TestMethod]
    public void GeneratedStratifiers_SatisfyFhirStratifierInvariant()
    {
        var measure = CreateMeasure(BaseStatements(
            Def("Region Stratifier",
                CreateTag("group", "RateA"),
                CreateTag("group", "RateB"),
                CreateTag("stratifier", "Region")),
            Def("Age Band Stratifier",
                CreateTag("group", "RateA"),
                CreateTag("stratifier", "AgeBand"),
                CreateTag("description", "Stratifies by age band"))));

        new FhirPathCompiler().Compile(StratifierInvariant)
            .Predicate(measure, new EvaluationContext())
            .Should().BeTrue("generated measures must satisfy invariant mea-1: {0}", StratifierInvariant);

        // Targeted halves of the invariant, so a failure identifies which side broke:
        // the container carries no own content, while every component is fully populated.
        var stratifiers = measure.Group.SelectMany(g => g.Stratifier).ToList();
        stratifiers.Should().NotBeEmpty();
        stratifiers.Should().OnlyContain(s => s.Code == null && s.Description == null && s.Criteria == null,
            "container stratifiers must not carry code/description/criteria");
        stratifiers.Should().OnlyContain(s => s.Component.Count > 0,
            "a container with no components would satisfy neither side of the invariant's xor");
        stratifiers.SelectMany(s => s.Component).Should().OnlyContain(
            c => c.Code != null && c.Description != null && c.Criteria != null,
            "the stratification's meaning lives on the components");
    }

    [TestMethod]
    public void LibraryWithoutStratifierTags_ProducesNoStratifiers()
    {
        var measure = CreateMeasure(BaseStatements());

        measure.Group.Should().OnlyContain(g => g.Stratifier.Count == 0);
    }

    [TestMethod]
    public void MeasureGroupCodeSystem_SetsGroupCodeWithGroupIdAsCode()
    {
        const string system = "https://example.org/fhir/CodeSystem/measure-group";

        var measure = CreateMeasure(system, BaseStatements());

        foreach (var rate in new[] { "RateA", "RateB" })
        {
            var group = measure.Group.Single(g => g.ElementId == rate);
            var coding = group.Code!.Coding.Should().ContainSingle().Subject;
            coding.System.Should().Be(system);
            coding.Code.Should().Be(rate);
        }
    }

    [TestMethod]
    public void MeasureGroupCodeSystem_AlsoAppliesToGroupsCreatedByStratifiers()
    {
        const string system = "https://example.org/fhir/CodeSystem/measure-group";

        var measure = CreateMeasure(system, BaseStatements(
            Def("Region Stratifier",
                CreateTag("group", "RateC"),
                CreateTag("stratifier", "Region"))));

        var group = measure.Group.Single(g => g.ElementId == "RateC");
        var coding = group.Code!.Coding.Should().ContainSingle().Subject;
        coding.System.Should().Be(system);
        coding.Code.Should().Be("RateC");
    }

    [TestMethod]
    public void NoMeasureGroupCodeSystem_LeavesGroupCodeUnset()
    {
        var measure = CreateMeasure(BaseStatements());

        measure.Group.Should().OnlyContain(g => g.Code == null);
    }

    [TestMethod]
    [DataRow("Rate\tA", DisplayName = "tab")]
    [DataRow("Rate  A", DisplayName = "double space")]
    [DataRow(" RateA", DisplayName = "leading space")]
    [DataRow("RateA ", DisplayName = "trailing space")]
    public void MeasureGroupCodeSystem_GroupIdViolatingFhirCodeConstraints_Throws(string groupId)
    {
        const string system = "https://example.org/fhir/CodeSystem/measure-group";

        var act = () => CreateMeasure(system, BaseStatements(
            Def("Region Stratifier",
                CreateTag("group", groupId),
                CreateTag("stratifier", "Region"))));

        act.Should().Throw<InvalidOperationException>()
           .WithMessage($"*'{groupId}'*FHIR code*");
    }

    [TestMethod]
    public void MeasureGroupCodeSystem_GroupIdWithSingleInternalSpaces_IsAccepted()
    {
        const string system = "https://example.org/fhir/CodeSystem/measure-group";

        var measure = CreateMeasure(system, BaseStatements(
            Def("Region Stratifier",
                CreateTag("group", "Rate C"),
                CreateTag("stratifier", "Region"))));

        var group = measure.Group.Single(g => g.ElementId == "Rate C");
        group.Code!.Coding.Single().Code.Should().Be("Rate C");
    }

    [TestMethod]
    public void NoMeasureGroupCodeSystem_GroupIdViolatingFhirCodeConstraints_IsNotValidated()
    {
        // Without a code system the group id is never emitted as a FHIR code,
        // so the code datatype constraints don't apply.
        var measure = CreateMeasure(BaseStatements(
            Def("Region Stratifier",
                CreateTag("group", "Rate\tC"),
                CreateTag("stratifier", "Region"))));

        measure.Group.Single(g => g.ElementId == "Rate\tC").Code.Should().BeNull();
    }
}
