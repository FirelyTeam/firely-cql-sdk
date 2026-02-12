using Hl7.Cql.Elm;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Packaging;

internal static class FhirMeasureExtensions
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
            SysDateTime overrideDate)
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

            FhirMeasureExtensions.AnnotateMeasurePopulations(measure, elmLibrary);
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
            SysDateTime overrideDate)
        {
            var tags = elmLibrary.statements?
                                 .SelectMany(def => def.annotation?.OfType<ElmAnnotation>()?.SelectMany(a => a.t ?? []) ?? [])
                                 .ToList() ?? [];

            var measureAnnotation = tags.SingleOrDefault(t => t?.name == "measure");
            var yearAnnotation = tags.SingleOrDefault(t => t?.name == "year");
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
                    measureYear, resourceCanonicalBuilder, overrideDate);
                return true;
            }

            fhirMeasure = null;
            return false;
        }
    }

    private static void AnnotateMeasurePopulations(FhirMeasure fhirMeasure, ElmLibrary library)
    {
        var defs = library.statements ?? Enumerable.Empty<Hl7.Cql.Elm.ExpressionDef>();
        foreach (var def in defs)
        {
            var annotations = (def.annotation?
                                  .OfType<ElmAnnotation>()
                                  .SelectMany(a => a.t ?? Enumerable.Empty<Tag>())
                               ?? [])
                .ToArray();
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

                    var rate = $"rate-{tuple.Group}";
                    var groupsForRate = fhirMeasure.Group?
                                                   .Where(g => g.ElementId == rate)
                                                   .ToArray() ?? [];
                    FhirMeasure.GroupComponent? group;
                    if (groupsForRate.Length == 1)
                    {
                        group = groupsForRate[0];
                    }
                    else if (groupsForRate.Length == 0)
                    {
                        group = new FhirMeasure.GroupComponent
                        {
                            ElementId = rate,
                            //Code = new CodeableConcept(rate, MeasureGroupCodeSystem),
                            Description = $"Rate {tuple.Group}",
                        };
                        fhirMeasure.Group!.Add(group);
                    }
                    else throw new InvalidOperationException($"Rate {rate} is defined twice for this measure.");

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

    extension(FhirMeasure fhirMeasure)
    { }
}