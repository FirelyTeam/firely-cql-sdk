/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Elm;
using Hl7.Cql.Packaging;
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

    private static FhirMeasure CreateMeasure(params ExpressionDef[] statements)
    {
        var elmLibrary = new ElmLibrary
        {
            identifier = new VersionedIdentifier { id = "StratifierExample", version = "1.0.0" },
            statements = statements,
        };
        var fhirLibrary = new FhirLibrary { Id = "StratifierExample-1.0.0", Name = "StratifierExample" };
        var created = fhirLibrary.TryCreateMeasure(elmLibrary, out var fhirMeasure, CanonicalBuilder, TestDate);
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
        container.Code!.Text.Should().Be("RateA-Stratifier");
        container.Description.Should().Be("RateA-Stratifier");
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
    public void LibraryWithoutStratifierTags_ProducesNoStratifiers()
    {
        var measure = CreateMeasure(BaseStatements());

        measure.Group.Should().OnlyContain(g => g.Stratifier.Count == 0);
    }
}
