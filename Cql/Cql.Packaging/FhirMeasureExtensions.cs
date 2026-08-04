using Hl7.Cql.Elm;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Packaging;

internal static partial class FhirMeasureExtensions
{
    private static readonly Dictionary<string, string> Populations = new()
    {
        { "initial-population", "Initial Population" },
        { "numerator", "Numerator" },
        { "denominator", "Denominator" },
        { "denominator-exclusion", "Denominator Exclusion" },
        { "initial-population-commercial", "Initial Population Commercial" },
        { "initial-population-exchange", "Initial Population Exchange" },
        { "initial-population-medicare", "Initial Population Medicare" },
        { "initial-population-medicaid", "Initial Population Medicaid" },
        { "denominator-commercial", "Denominator Commercial" },
        { "denominator-exchange", "Denominator Exchange" },
        { "denominator-medicare", "Denominator Medicare" },
        { "denominator-medicaid", "Denominator Medicaid" },
        { "denominator-exclusion-commercial", "Denominator Exclusion Commercial" },
        { "denominator-exclusion-exchange", "Denominator Exclusion Exchange" },
        { "denominator-exclusion-medicare", "Denominator Exclusion Medicare" },
        { "denominator-exclusion-medicaid", "Denominator Exclusion Medicaid" },
        { "numerator-commercial", "Numerator Commercial" },
        { "numerator-exchange", "Numerator Exchange" },
        { "numerator-medicare", "Numerator Medicare" },
        { "numerator-medicaid", "Numerator Medicaid" }
    };

    extension(FhirMeasure)
    {
        public static FhirMeasure CreateMeasureResource(
            FhirLibrary fhirLibrary,
            ElmLibrary elmLibrary,
            Tag measureAnnotation,
            int measureYear,
            ResourceCanonicalBuilder resourceCanonicalBuilder,
            SysDateTime overrideDate,
            string? measureGroupCodeSystem = null)
        {
            var measure = new FhirMeasure();
            var libName = fhirLibrary.Name ?? throw new ArgumentException("Library must have a name", nameof(fhirLibrary));
            var libVer = elmLibrary.identifier?.version!;

            measure.Id = fhirLibrary.Id; // was elmLibrary.identifier?.id
            measure.Version = libVer;
            measure.Name = libName;
            measure.Title = measureAnnotation.value;
            measure.Url = resourceCanonicalBuilder(measure.TypeName, libName);

            measure.Status = PublicationStatus.Active;
            measure.Date = new DateTimeIso8601(overrideDate, Iso8601DateTimePrecision.Millisecond).ToString();
            measure.EffectivePeriod = new Period
            {
                Start = new DateTimeIso8601(measureYear, 1, 1, 0, 0, 0, 0, 0, 0).ToString(),
                End = new DateTimeIso8601(measureYear, 12, 31, 23, 59, 59, 999, 0, 0).ToString(),
            };
            measure.Group = [];

            FhirMeasureExtensions.AnnotateMeasurePopulations(measure, elmLibrary, measureGroupCodeSystem);
            FhirMeasureExtensions.AnnotateMeasureStratifiers(measure, elmLibrary, measureGroupCodeSystem);
            string[] library = [resourceCanonicalBuilder("Library", libName, libVer)];
            measure.Library = library;
            return measure;
        }
    }

    extension(FhirLibrary fhirLibrary)
    {
        public bool TryCreateMeasure(
            ElmLibrary elmLibrary,
            [NotNullWhen(true)] out FhirMeasure? fhirMeasure,
            ResourceCanonicalBuilder resourceCanonicalBuilder,
            SysDateTime overrideDate,
            string? measureGroupCodeSystem = null)
        {
            var tags = elmLibrary.statements?
                                 .SelectMany(GetAnnotationTags)
                                 .ToList() ?? [];

            var measureAnnotation = tags.SingleOrDefault(t => t.name == "measure");
            var yearAnnotation = tags.SingleOrDefault(t => t.name == "year");
            if (measureAnnotation != null
                && !string.IsNullOrWhiteSpace(measureAnnotation.value)
                && yearAnnotation != null
                && !string.IsNullOrWhiteSpace(yearAnnotation.value)
                && int.TryParse(yearAnnotation.value, out var measureYear))
            {
                fhirMeasure = FhirMeasure.CreateMeasureResource(
                    fhirLibrary,
                    elmLibrary,
                    measureAnnotation,
                    measureYear, resourceCanonicalBuilder, overrideDate,
                    measureGroupCodeSystem);
                return true;
            }

            fhirMeasure = null;
            return false;
        }
    }

    private static Tag[] GetAnnotationTags(Hl7.Cql.Elm.ExpressionDef def) =>
        (def.annotation?
            .OfType<ElmAnnotation>()
            .SelectMany(a => a.t ?? Enumerable.Empty<Tag>())
         ?? [])
        .Where(t => t is not null)
        .ToArray();

    private static FhirMeasure.GroupComponent GetOrCreateGroup(FhirMeasure fhirMeasure, string groupId, string? measureGroupCodeSystem)
    {
        var groupsForId = fhirMeasure.Group?
                                     .Where(g => g.ElementId == groupId)
                                     .ToArray() ?? [];
        if (groupsForId.Length == 1)
            return groupsForId[0];
        if (groupsForId.Length > 1)
            throw new InvalidOperationException($"Group {groupId} is defined twice for this measure.");

        var group = new FhirMeasure.GroupComponent
        {
            ElementId = groupId,
            Description = $"Group {groupId}",
        };
        if (!string.IsNullOrWhiteSpace(measureGroupCodeSystem))
        {
            if (!FhirCodeConstraint().IsMatch(groupId))
                throw new InvalidOperationException(
                    $"Group id '{groupId}' cannot be used as the code of Measure.group.code: a FHIR code must be non-empty, without leading or trailing whitespace, and with no whitespace other than single spaces. Fix the @group annotation value or unset the measure group code system.");

            group.Code = new CodeableConcept
            {
                Coding =
                [
                    new Coding
                    {
                        System = measureGroupCodeSystem,
                        Code = groupId,
                    }
                ]
            };
        }
        fhirMeasure.Group!.Add(group);
        return group;
    }

    // The FHIR `code` datatype constraint (https://hl7.org/fhir/R4/datatypes.html#code):
    // at least one character, no leading/trailing whitespace, internal whitespace only single spaces.
    [GeneratedRegex(@"^[^\s]+( [^\s]+)*$")]
    private static partial Regex FhirCodeConstraint();

    private static void AnnotateMeasurePopulations(FhirMeasure fhirMeasure, ElmLibrary library, string? measureGroupCodeSystem)
    {
        var defs = library.statements ?? Enumerable.Empty<Hl7.Cql.Elm.ExpressionDef>();
        foreach (var def in defs)
        {
            var annotations = GetAnnotationTags(def);
            if (annotations.Length > 0)
            {
                var groups = annotations
                             .Where(t => t.name == "group")
                             .ToArray();
                var populations = annotations
                                  .Where(t => t.name == "population")
                                  .ToArray();
                var productLine = annotations
                    .FirstOrDefault(t => t.name == "productline");

                var tuples = from g in groups
                             from p in populations
                             select new { Group = g.value, Population = p.value };
                foreach (var tuple in tuples)
                {
                    if (!Populations.ContainsKey(tuple.Population))
                        throw new InvalidOperationException(
                            $"Definition {def.name} has a @population annotation whose value is {tuple.Population}.  @population must be one of: {string.Join(", ", Populations.Keys)}");

                    var rate = $"{tuple.Group}";
                    var group = GetOrCreateGroup(fhirMeasure, rate, measureGroupCodeSystem);

                    var populationSuffix = productLine != null ? $"{tuple.Population}-{productLine.value}" : tuple.Population;
                    var pop = $"{rate}-{populationSuffix}";
                    var populationsForGroup = group.Population
                                                   .Where(p => p.ElementId == pop)
                                                   .ToArray();
                    FhirMeasure.PopulationComponent? population;
                    if (populationsForGroup.Length == 1)
                    {
                        population = populationsForGroup[0];
                    }
                    else if (populationsForGroup.Length == 0)
                    {
                        population = new FhirMeasure.PopulationComponent
                        {
                            ElementId = pop,
                            Code = new CodeableConcept
                            {
                                Coding =
                                [
                                    new Coding
                                    {
                                        System = "http://terminology.hl7.org/CodeSystem/measure-population",
                                        Code = populationSuffix,
                                        Display = Populations[populationSuffix]
                                    }
                                ]
                            },
                            Description = Populations[tuple.Population],
                            Criteria = new Hl7.Fhir.Model.Expression
                            {
                                Language = "text/cql-identifier"!,
                                ExpressionElement = new FhirString(def.name)
                            }
                        };
                        group.Population.Add(population);
                    }
                    else throw new InvalidOperationException($"Population {pop} is defined twice for this measure.");
                }
            }
        }
    }

    private static FhirMeasure.StratifierComponent GetOrCreateStratifier(FhirMeasure.GroupComponent group)
    {
        var id = $"{group.ElementId}-Stratifier";
        var existing = group.Stratifier.FirstOrDefault(s => s.ElementId == id);
        if (existing != null)
            return existing;

        // Only the element id is set: the FHIR invariant on Measure.group.stratifier
        // ((code | description | criteria).exists() xor component.exists()) forbids
        // code/description/criteria on a stratifier that holds components.
        var container = new FhirMeasure.StratifierComponent
        {
            ElementId = id,
        };
        group.Stratifier.Add(container);
        return container;
    }

    private static void AnnotateMeasureStratifiers(FhirMeasure fhirMeasure, ElmLibrary library, string? measureGroupCodeSystem)
    {
        var defs = library.statements ?? Enumerable.Empty<Hl7.Cql.Elm.ExpressionDef>();
        foreach (var def in defs)
        {
            var annotations = GetAnnotationTags(def);
            var stratifiers = annotations
                              .Where(t => t.name == "stratifier")
                              .ToArray();
            if (stratifiers.Length == 0)
                continue;

            foreach (var stratifier in stratifiers)
            {
                if (string.IsNullOrWhiteSpace(stratifier.value))
                    throw new InvalidOperationException(
                        $"Definition {def.name} has a @stratifier annotation with an empty value.");
            }

            var groups = annotations
                         .Where(t => t.name == "group")
                         .ToArray();
            if (groups.Length == 0)
                throw new InvalidOperationException(
                    $"Definition {def.name} has a @stratifier annotation but no @group annotation. Add a @group annotation for each measure group the stratifier belongs to.");

            var description = annotations.FirstOrDefault(t => t.name == "description");

            var tuples = from g in groups
                         from s in stratifiers
                         select new { Group = g.value, Stratifier = s.value };
            foreach (var tuple in tuples)
            {
                var group = GetOrCreateGroup(fhirMeasure, tuple.Group, measureGroupCodeSystem);
                var container = GetOrCreateStratifier(group);

                var componentId = $"{tuple.Group}-StratifierComponent-{tuple.Stratifier}";
                if (container.Component.Any(c => c.ElementId == componentId))
                    throw new InvalidOperationException($"Stratifier component {componentId} is defined twice for this measure.");

                container.Component.Add(new FhirMeasure.ComponentComponent
                {
                    ElementId = componentId,
                    Code = new CodeableConcept { Text = tuple.Stratifier },
                    Description = description?.value ?? tuple.Stratifier,
                    Criteria = new Hl7.Fhir.Model.Expression
                    {
                        Language = "text/cql-identifier",
                        ExpressionElement = new FhirString(def.name)
                    }
                });
            }
        }
    }
}
