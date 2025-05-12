/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Packaging;

internal class ResourcePackager(
    ILoggerFactory loggerFactory,
    TypeResolver typeResolver,
    ResourceCanonicalBuilder resourceCanonicalBuilder)
{
    private readonly CqlTypeToFhirTypeMapper _cqlTypeToFhirTypeMapper = new(typeResolver);

    public readonly record struct SourceArtefacts(
        string LibraryIdentifier,
        string CqlString,
        ElmLibrary ElmLibrary,
        string CSharpSourceCode,
        byte[] AssemblyBinary);

    public IEnumerable<(string libraryIdentifier, FhirLibrary fhirLibrary, FhirMeasure? fhirMeasure)> PackageEachElmLibraryToFhirResources(
        ElmLibrarySet librarySet,
        Func<string, SourceArtefacts> inputsById,
        SysDateTime? overrideDate = null,
        BatchProcessExceptionHandlingStrategyBuilder<ElmLibrary>? buildExceptionHandlingStrategy = null,
        Action<ElmLibrary>? onNextLibrary = null)
    {
        var libraryPackagerLogger = loggerFactory.CreateLogger(typeof(LibraryPackager));

        return librarySet.TrySelect(PackageResource, buildExceptionHandlingStrategy);

        (string versionedIdentifier, FhirLibrary fhirLibrary, FhirMeasure? fhirMeasure) PackageResource(ElmLibrary elmLibrary)
        {
            onNextLibrary?.Invoke(elmLibrary);

            string versionedIdentifier = elmLibrary.VersionedLibraryIdentifier;
            var localOverrideDate = overrideDate ?? SysDateTime.Now;
            var (_, cqlString, elmLibraryInput, cSharpSourceCode, assemblyBinary) = inputsById(versionedIdentifier);
            if (versionedIdentifier != elmLibraryInput.VersionedLibraryIdentifier) throw new InvalidOperationException("Versioned identifiers do not match.");

            var fhirLibrary = LibraryPackager.CreateLibraryResource(
                libraryPackagerLogger,
                _cqlTypeToFhirTypeMapper,
                elmLibrary,
                null,
                Encoding.Default.GetBytes(cqlString),
                assemblyBinary,
                GetCSharpSourceCodeByName(),
                librarySet,
                resourceCanonicalBuilder,
                localOverrideDate);

            IEnumerable<KeyValuePair<string, string>>? GetCSharpSourceCodeByName()
            {
                yield return KeyValuePair.Create(versionedIdentifier, cSharpSourceCode);
            }

            MeasurePackager.TryCreateMeasure(
                elmLibrary,
                fhirLibrary,
                out var fhirMeasure,
                resourceCanonicalBuilder,
                localOverrideDate);
            return (versionedIdentifier, fhirLibrary, fhirMeasure);
        }
    }

    internal static string BuildResourceUrl(
        string resourceCanonicalRootUrl,
        string resourceType,
        string name,
        string? version = null)
    {
        string includeVersionString = string.IsNullOrEmpty(version) ? string.Empty : $"|{version}";
        string includeIdMaybeVersion = $"{resourceCanonicalRootUrl}{resourceType}/{name}{includeVersionString}";
        return includeIdMaybeVersion;
    }
}

file static class MeasurePackager
{
    public static bool TryCreateMeasure(
        ElmLibrary elmLibrary,
        FhirLibrary fhirLibrary,
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
            fhirMeasure = CreateMeasureResource(
                fhirLibrary,
                measureAnnotation,
                measureYear,
                elmLibrary,
                resourceCanonicalBuilder,
                overrideDate);
            return true;
        }

        fhirMeasure = null;
        return false;
    }

    private static FhirMeasure CreateMeasureResource(
        FhirLibrary fhirLibrary,
        Tag measureAnnotation,
        int measureYear,
        ElmLibrary elmLibrary,
        ResourceCanonicalBuilder resourceCanonicalBuilder,
        SysDateTime overrideDate)
    {
        var measure = new FhirMeasure();
        var libName = fhirLibrary.Name;
        var libVer = elmLibrary.identifier?.version!;

        measure.Id = fhirLibrary.Id; // was elmLibrary.identifier?.id
        measure.Version = libVer;
        measure.Name = libName;
        measure.Title = measureAnnotation.value;
        measure.Url = resourceCanonicalBuilder(measure.TypeName, libName!);

        measure.Status = PublicationStatus.Active;
        measure.Date = new DateTimeIso8601(overrideDate, Iso8601DateTimePrecision.Millisecond).ToString();
        measure.EffectivePeriod = new Period
        {
            Start = new DateTimeIso8601(measureYear, 1, 1, 0, 0, 0, 0, 0, 0).ToString(),
            End = new DateTimeIso8601(measureYear, 12, 31, 23, 59, 59, 999, 0, 0).ToString(),
        };
        measure.Group = [];

        AnnotateMeasurePopulations(measure, elmLibrary);
        string[] library = [resourceCanonicalBuilder("Library", libName!, libVer)];
        measure.Library = library;
        return measure;
    }

    private static readonly Dictionary<string, string> Populations = new()
    {
        { "initial-population", "Initial Population" },
        { "numerator", "Numerator" },
        { "denominator", "Denominator" },
        { "denominator-exclusion", "Denominator Exclusion" }
    };

    private static void AnnotateMeasurePopulations(Measure measure, ElmLibrary library)
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
                    if (!int.TryParse(tuple.Group, out var groupNumber))
                        throw new InvalidOperationException(
                            $"Definition {def.name} has a @group annotation whose value is {tuple.Group}.  Groups must be positive integers.");
                    if (!Populations.ContainsKey(tuple.Population))
                        throw new InvalidOperationException(
                            $"Definition {def.name} has a @population annotation whose value is {tuple.Population}.  @population must be one of: {string.Join(", ", Populations.Keys)}");

                    var rate = $"rate-{tuple.Group}";
                    var groupsForRate = measure.Group?
                                               .Where(g => g.ElementId == rate)
                                               .ToArray() ?? [];
                    Measure.GroupComponent? group;
                    if (groupsForRate.Length == 1)
                    {
                        group = groupsForRate[0];
                    }
                    else if (groupsForRate.Length == 0)
                    {
                        group = new Measure.GroupComponent
                        {
                            ElementId = rate,
                            //Code = new CodeableConcept(rate, MeasureGroupCodeSystem),
                            Description = $"Rate {tuple.Group}",
                        };
                        measure.Group!.Add(group);
                    }
                    else throw new InvalidOperationException($"Rate {rate} is defined twice for this measure.");

                    var populationSuffix = productLine != null ? $"{tuple.Population}-{productLine.value}" : tuple.Population;
                    var pop = $"{rate}-{populationSuffix}";
                    var populationsForGroup = group.Population
                                                   .Where(p => p.ElementId == pop)
                                                   .ToArray();
                    Measure.PopulationComponent? population;
                    if (populationsForGroup.Length == 1)
                    {
                        population = populationsForGroup[0];
                    }
                    else if (populationsForGroup.Length == 0)
                    {
                        population = new Measure.PopulationComponent
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
}

internal static class LibraryPackager
{
    public static FhirLibrary CreateLibraryResource(
        ILogger logger,
        CqlTypeToFhirTypeMapper typeCrosswalk,
        ElmLibrary? elmLibrary,
        byte[]? elmBytes,
        byte[]? cqlBytes,
        byte[]? assemblyBytes,
        IEnumerable<KeyValuePair<string, string>>? cSharpSourceCodeById,
        ElmLibrarySet elmLibrarySet,
        ResourceCanonicalBuilder resourceCanonicalBuilder,
        SysDateTime? elmFileLastWriteTimeUtc = null)
    {
        switch (elmLibrary, elmBytes)
        {
            case (null, null):
                throw new ArgumentException("Either elmLibrary or elmBytes must be provided.", nameof(elmLibrary));
            case (null, not null):
                elmLibrary = ElmLibrary.ParseFromJson(Encoding.Default.GetString(elmBytes));
                break;
            case (not null, null):
                elmBytes = Encoding.Default.GetBytes(elmLibrary.SerializeToJson(true));
                break;
        }

        var fhirLibrary = CreateFhirLibrary(elmLibrary, resourceCanonicalBuilder, elmFileLastWriteTimeUtc ?? SysDateTime.Now);
        AddElmAttachment(elmLibrary, fhirLibrary, elmBytes);
        var parameters = new List<ParameterDefinition>();
        AddInParameters(elmLibrary, parameters, typeCrosswalk);
        AddOutParameters(elmLibrary, parameters, typeCrosswalk);
        fhirLibrary.Parameter = parameters.Count > 0 ? parameters : null!;

        AddRelatedArtefacts(elmLibrary, fhirLibrary, elmLibrarySet, resourceCanonicalBuilder);
        AddDataRequirements(elmLibrary, fhirLibrary, elmLibrarySet);

        var fhirParameters = CreateFhirParameters(elmLibrary);
        if (fhirParameters.Any())
            AddCqlOptions(fhirLibrary, fhirParameters);

        if (cqlBytes != null)
            AddCqlAttachment(elmLibrary, fhirLibrary, cqlBytes);

        if (assemblyBytes != null)
            AddDllAttachment(elmLibrary, fhirLibrary, assemblyBytes);

        if (cSharpSourceCodeById != null)
            foreach (var kvp in cSharpSourceCodeById)
                AddCSharpAttachment(fhirLibrary, kvp);

        return fhirLibrary;
    }

    private static void AddElmAttachment(
        ElmLibrary elmLibrary,
        FhirLibrary fhirLibrary,
        byte[] elmBytes)
    {
        var bytes = elmBytes;
        var attachment = new Attachment
        {
            ElementId = $"{elmLibrary.VersionedLibraryIdentifier}+elm",
            ContentType = ElmLibrary.JsonMimeType,
            Data = bytes,
        };
        fhirLibrary.Content.Add(attachment);
    }

    private static FhirLibrary CreateFhirLibrary(
        ElmLibrary elmLibrary,
        ResourceCanonicalBuilder resourceCanonicalBuilder,
        SysDateTime date)
    {
        // https://hl7.org/fhir/uv/cql/STU1/StructureDefinition-cql-library.html
        var fhirLibrary = new FhirLibrary();
        fhirLibrary.Type = LogicLibraryCodeableConcept;
        fhirLibrary.Id = FhirIdGenerator.GenerateFhirId(elmLibrary.VersionedLibraryIdentifier);
        fhirLibrary.Version = elmLibrary.identifier?.version!;
        fhirLibrary.Name = elmLibrary.identifier?.id!;
        fhirLibrary.Url = resourceCanonicalBuilder(fhirLibrary.TypeName, elmLibrary.identifier?.id!); // NOTE: We do NOT include the version
        fhirLibrary.Title = fhirLibrary.Name;
        fhirLibrary.Status = PublicationStatus.Active;
        fhirLibrary.Date = new DateTimeIso8601(date.ToLocalTime(), Iso8601DateTimePrecision.Millisecond).ToString();

        if (elmLibrary.contexts?.Any(context => nameof(ResourceType.Patient).Equals(context?.name)) ?? false)
        {
            fhirLibrary.Subject = new CodeableConcept("http://hl7.org/fhir/resource-types", nameof(ResourceType.Patient));
        }

        if (fhirLibrary.Meta is {} meta)
            meta.LastUpdated = date;

        return fhirLibrary;
    }

    private static void AddRelatedArtefacts(
        ElmLibrary elmLibrary,
        FhirLibrary library,
        ElmLibrarySet elmLibrarySet,
        ResourceCanonicalBuilder resourceCanonicalBuilder)
    {
        List<RelatedArtifact> result = [];
        var dependencies = elmLibrarySet.GetLibraryDependencies(elmLibrary);
        foreach (var dependency in dependencies.Prepend(elmLibrary))
        {
            foreach (IncludeDef include in dependency?.includes ?? [])
            {
                var resourceUrl = resourceCanonicalBuilder("Library", include.path, include.version);
                var ra = new RelatedArtifact
                {
                    Display = $"Library {include.localIdentifier}",
                    Type = RelatedArtifact.RelatedArtifactType.DependsOn,
                    Resource = resourceUrl,
                };
                if (!result.Any(r => r.IsExactly(ra)))
                    result.Add(ra);
            }

            foreach (ValueSetDef include in dependency?.valueSets ?? [])
            {
                var ra = new RelatedArtifact
                {
                    Display = $"{include.GetTypeSpecifier()} {include.name}",
                    Type = RelatedArtifact.RelatedArtifactType.DependsOn,
                    Resource = include.id,
                };
                if (!result.Any(r => r.IsExactly(ra)))
                    result.Add(ra);
            }
        }
        library.RelatedArtifact.AddRange(result);
        library.RelatedArtifact.Sort((x, y) => x.Display!.CompareTo(y.Display));
    }

    private static void AddDataRequirements(
        ElmLibrary elmLibrary,
        FhirLibrary library,
        ElmLibrarySet elmLibrarySet
        )
    {
        // Analyze datarequirements and add to the FHIR Library resource.
        var dataRequirementsAnalyzer = new DataRequirementsAnalyzer(elmLibrarySet, elmLibrary);
        var dataRequirements = dataRequirementsAnalyzer.Analyze();
        library.DataRequirement.AddRange(dataRequirements);
        library.DataRequirement = library.DataRequirement
        .OrderBy(dr => dr.Type)  // Primary sorting by Type
        .ThenBy(dr => dr.CodeFilter?.FirstOrDefault()?.ValueSet ?? string.Empty) // Secondary sorting by ValueSet
        .ToList();
    }

    private static void AddOutParameters(
        ElmLibrary elmLibrary,
        List<ParameterDefinition> parameters,
        CqlTypeToFhirTypeMapper typeCrosswalk)
    {
        var outParams = elmLibrary.statements?
                                  .Where(def => def.name != "Patient" && def is not FunctionDef)
                                  .Select(def => ElmDefinitionToParameter(def, typeCrosswalk));
        if (outParams is not null)
            parameters.AddRange(outParams);
    }

    private static void AddInParameters(
        ElmLibrary elmLibrary,
        List<ParameterDefinition> parameters,
        CqlTypeToFhirTypeMapper typeCrosswalk)
    {
        var inParams = elmLibrary.parameters?
            .Select(pd => ElmParameterToFhir(pd, typeCrosswalk));

        if (inParams is not null)
            parameters.AddRange(inParams);


    }

    private static void AddCqlAttachment(
        ElmLibrary? elmLibrary,
        FhirLibrary fhirLibrary,
        byte[] cqlBytes)
    {
        var attachment = new Attachment
        {
            ElementId = $"{elmLibrary!.VersionedLibraryIdentifier}+cql",
            ContentType = "text/cql",
            Data = cqlBytes,
        };
        fhirLibrary.Content.Add(attachment);
    }

    private static void AddCqlOptions(
        FhirLibrary fhirLibrary,
        IReadOnlyList<Parameters.ParameterComponent> fhirParameters)
    {
        // Adding CQL Options as a contained resource
        // See: https://build.fhir.org/domainresource-definitions.html#DomainResource.contained

        var p = new Parameters();
        p.Id = "options";
        p.Parameter.AddRange(fhirParameters);
        fhirLibrary.Contained = [p];

        // See requirement for Contained resources: https://build.fhir.org/domainresource.html#invs
        // dom-3: If the resource is contained in another resource,
        //        it SHALL be referred to from elsewhere in the resource
        //        or SHALL refer to the containing resource
        //
        // This is done by adding an extension. (Example: https://build.fhir.org/ig/HL7/cql-ig/Library-CQLExample.json.html)

        var extension = new Extension
        {
            Url = "http://hl7.org/fhir/StructureDefinition/cqf-cqlOptions",
            Value = new ResourceReference { Reference = "#options" },
        };
        fhirLibrary.Extension.Add(extension);
    }

    private static void AddCSharpAttachment(FhirLibrary library, KeyValuePair<string, string> kvp)
    {
        var sourceBytes = Encoding.UTF8.GetBytes(kvp.Value);
        var attachment = new Attachment
        {
            ElementId = $"{kvp.Key}+csharp",
            ContentType = "text/plain",
            Data = sourceBytes,
        };
        library.Content.Add(attachment);
    }

    private static void AddDllAttachment(
        ElmLibrary? elmLibrary,
        FhirLibrary library,
        byte[] assemblyBytes)
    {
        var attachment = new Attachment
        {
            ElementId = $"{elmLibrary!.VersionedLibraryIdentifier}+dll",
            ContentType = "application/octet-stream",
            Data = assemblyBytes,
        };
        // TODO: Add extension indicating dll includes debug symbols
        library.Content.Add(attachment);
    }

    private static void AddFhirParameterIfNotNull(
        List<Parameters.ParameterComponent> parameters,
        string name,
        string? value)
    {
        //TODO: use mapper when values in CqlToElmInfo results anything but strings
        if (!string.IsNullOrEmpty(value))
            parameters.Add(new Parameters.ParameterComponent { Name = name, Value = new FhirString(value) });
    }

    private static IReadOnlyList<Parameters.ParameterComponent> CreateFhirParameters(ElmLibrary elmLibrary)
    {
        var fhirParameters = new List<Parameters.ParameterComponent>();
        foreach (var annotation in elmLibrary?.annotation ?? [])
        {
            if (annotation is not CqlToElmInfo cqlOptions)
                continue;

            // translatorVersion
            AddFhirParameterIfNotNull(fhirParameters, nameof(cqlOptions.translatorVersion),
                                      cqlOptions.translatorVersion);

            // translatorOptions
            if (!string.IsNullOrEmpty(cqlOptions.translatorOptions))
            {
                var optionArray = cqlOptions.translatorOptions.Split(',');
                foreach (string item in optionArray)
                {
                    AddFhirParameterIfNotNull(fhirParameters, "option", item);
                }
            }

            // signatureLevel
            AddFhirParameterIfNotNull(fhirParameters, nameof(cqlOptions.signatureLevel), cqlOptions.signatureLevel);

            // compatibilityLevel
            AddFhirParameterIfNotNull(fhirParameters, "compatibilityLevel", "1.5");

            // format
            AddFhirParameterIfNotNull(fhirParameters, "format", "JSON");
        }

        return fhirParameters;
    }

    private static readonly CodeableConcept LogicLibraryCodeableConcept = new()
    {
        Coding =
        [
            new Coding
            {
                Code = "logic-library",
                System = "http://terminology.hl7.org/CodeSystem/library-type"
            }
        ]
    };

    private static ParameterDefinition ElmParameterToFhir(
        ParameterDef elmParameter,
        CqlTypeToFhirTypeMapper typeCrosswalk)
    {
        var typeSpecifier = elmParameter.resultTypeSpecifier
                            ?? elmParameter.parameterTypeSpecifier
                            ?? (elmParameter.resultTypeName is not null ? new NamedTypeSpecifier { name = elmParameter.resultTypeName } : null)
                            ?? (elmParameter.parameterType is not null ? new NamedTypeSpecifier { name = elmParameter.parameterType } : null);

        if (typeSpecifier is null)
            throw new ArgumentException($"TypeSpecifier is missing on parameter: {elmParameter.name}",
                                        nameof(elmParameter));

        var type = typeCrosswalk.TypeEntryFor(typeSpecifier);
        if (type?.FhirType is null)
            throw new ArgumentException("Unable to identify a valid FHIR type for this parameter.",
                                        nameof(elmParameter));

        var parameterDefinition = new ParameterDefinition
        {
            Name = elmParameter.name!,
            Use = OperationParameterUse.In,
            Min = elmParameter.@default is null ? 1 : 0,
            Max = "1",
            Type = type.FhirType,
        };
        AddParameterCqlTypeExtension(type, parameterDefinition);
        return parameterDefinition;
    }

    private static ParameterDefinition ElmDefinitionToParameter(
        ExpressionDef definition,
        CqlTypeToFhirTypeMapper typeCrosswalk)
    {
        var resultTypeSpecifier = definition.resultTypeSpecifier;
        if (resultTypeSpecifier is null && !string.IsNullOrWhiteSpace(definition.resultTypeName.Name))
            resultTypeSpecifier = new NamedTypeSpecifier
            {
                name = definition.resultTypeName
            };

        var type = typeCrosswalk.TypeEntryFor(resultTypeSpecifier);
        if (type?.FhirType is null)
            throw new ArgumentException("Unable to identify a valid FHIR type for this definition.",
                                        nameof(definition));

        var parameterDefinition = new ParameterDefinition
        {
            Name = definition.name!,
            Use = OperationParameterUse.Out,
            Min = 0,
            Max = "1",
            Type = type.FhirType!,
        };

        AddParameterCqlTypeExtension(type, parameterDefinition);

        if (definition.accessLevel == AccessModifier.Private)
        {
            parameterDefinition.Extension.Add(new Extension
            {
                Value = new FhirModelCode("private"),
                Url = Constants.Hl7FhirStructureDefinitionCqlAccessLevel,
            });
        }

        return parameterDefinition;
    }

    private static void AddParameterCqlTypeExtension(CqlTypeToFhirMapping type, ParameterDefinition parameterDefinition)
    {
        var cqlType = type.CqlType;
        var cqlElementType = type.ElementType?.CqlType;
        switch (cqlType)
        {
            case null:
                return;

            case CqlPrimitiveType.List
                when type.ElementType?.FhirType is { } elementFhirType:
                parameterDefinition.Type = elementFhirType;
                parameterDefinition.Max = "*";
                break;
        }

        var cqlTypeName =
            (cqlType, cqlElementType) switch
            {
                // Don't show "generic" for List
                (CqlPrimitiveType.List, _) => cqlType.ToString(),

                // "Generic" display
                (_, CqlPrimitiveType.Fhir) => $"{cqlType}<{cqlElementType}.{type.ElementType!.FhirType}>",
                (_, { }) => $"{cqlType}<{cqlElementType}>",

                // Non-"Generic" display
                _ => cqlType.ToString(),
            };

        parameterDefinition.Extension =
        [
            new Extension
            {
                Url = Constants.Hl7FhirStructureDefinitionCqlType,
                Value = new FhirString(cqlTypeName),
            }
        ];
    }
}