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

internal class ResourcePackager
(
    ILoggerFactory loggerFactory,
    TypeResolver typeResolver,
    ResourceCanonicalBuilder resourceCanonicalBuilder)
{
    private readonly CqlTypeToFhirTypeMapper _cqlTypeToFhirTypeMapper = new(typeResolver);

    public readonly record struct InputArtifacts
    (
        string CqlString,
        ElmLibrary ElmLibrary,
        string CSharpSourceCode,
        byte[] AssemblyBinary,
        byte[]? DebugSymbols);

    public IEnumerable<(string libraryIdentifier, FhirLibrary fhirLibrary, FhirMeasure? fhirMeasure)> PackageEachElmLibraryToFhirResources(
        ElmLibrarySet librarySet,
        Func<string, InputArtifacts> inputsById,
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
            var (cqlString, elmLibraryInput, cSharpSourceCode, assemblyBinary, debugSymbols) = inputsById(versionedIdentifier);
            if (versionedIdentifier != elmLibraryInput.VersionedLibraryIdentifier) throw new InvalidOperationException("Versioned identifiers do not match.");

            var fhirLibrary = LibraryPackager.CreateLibraryResource(
                _cqlTypeToFhirTypeMapper,
                elmLibrary,
                null,
                Encoding.Default.GetBytes(cqlString),
                assemblyBinary,
                debugSymbols,
                GetCSharpSourceCodeByName(),
                librarySet,
                resourceCanonicalBuilder,
                localOverrideDate);

            IEnumerable<KeyValuePair<string, string>>? GetCSharpSourceCodeByName()
            {
                yield return KeyValuePair.Create(versionedIdentifier, cSharpSourceCode);
            }

            MeasurePackager.TryCreateMeasure(fhirLibrary,
                                             elmLibrary,
                                             out var fhirMeasure,
                                             resourceCanonicalBuilder, localOverrideDate);
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
        FhirLibrary fhirLibrary,
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
            fhirMeasure = CreateMeasureResource(
                fhirLibrary,
                elmLibrary,
                measureAnnotation,
                measureYear, resourceCanonicalBuilder, overrideDate);
            return true;
        }

        fhirMeasure = null;
        return false;
    }

    private static FhirMeasure CreateMeasureResource(
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

        AnnotateMeasurePopulations(measure, elmLibrary);
        string[] library = [resourceCanonicalBuilder("Library", libName, libVer)];
        measure.Library = library;
        return measure;
    }

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

    private static void AnnotateMeasurePopulations(FhirMeasure measure, ElmLibrary library)
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
                    var groupsForRate = measure.Group?
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
                        measure.Group!.Add(group);
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
}

internal static class LibraryPackager
{
    public static FhirLibrary CreateLibraryResource(
        CqlTypeToFhirTypeMapper typeCrosswalk,
        ElmLibrary? elmLibrary,
        byte[]? elmBytes,
        byte[]? cqlBytes,
        byte[]? assemblyBytes,
        byte[]? debugSymbols,
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

        fhirLibrary.Content.Add(CreateElmAttachment(elmLibrary.VersionedLibraryIdentifier, elmBytes));

        var parameters = new List<ParameterDefinition>();
        AddInParameters(elmLibrary, parameters, typeCrosswalk);
        AddOutParameters(elmLibrary, parameters, typeCrosswalk);
        fhirLibrary.Parameter = parameters.Count > 0 ? parameters : null!;

        fhirLibrary.AddRelatedArtefacts(elmLibrary, elmLibrarySet, resourceCanonicalBuilder);
        fhirLibrary.AddDataRequirements(elmLibrary, elmLibrarySet);

        var fhirParameters = CreateFhirParameters(elmLibrary);
        if (fhirParameters.Any())
            fhirLibrary.AddCqlOptions(fhirParameters);

        if (cqlBytes != null)
            fhirLibrary.Content.Add(CreateCqlAttachment(elmLibrary!.VersionedLibraryIdentifier, cqlBytes));

        if (assemblyBytes is { Length: > 0 } dll)
            fhirLibrary.Content.Add(CreateDllAttachment(elmLibrary!.VersionedLibraryIdentifier, dll));

        if (debugSymbols is { Length: > 0 } pdb)
            fhirLibrary.Content.Add(CreatePdbAttachment(elmLibrary!.VersionedLibraryIdentifier, pdb));

        if (cSharpSourceCodeById != null)
            foreach (var kvp in cSharpSourceCodeById)
                fhirLibrary.Content.Add(CreateCSharpAttachment(kvp));

        return fhirLibrary;
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

        if (fhirLibrary.Meta is { } meta)
            meta.LastUpdated = date;

        return fhirLibrary;
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
                Url = Constants.Hl7FhirStructureDefinitionCqlAccessModifier,
            });
        }

        return parameterDefinition;
    }

    private static void AddParameterCqlTypeExtension(
        CqlTypeToFhirMapping type,
        ParameterDefinition parameterDefinition)
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
                (_, { })                   => $"{cqlType}<{cqlElementType}>",

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

    /// <summary>
    /// Extracts an attachment from a FHIR Library to a file.
    /// Returns true if extraction was successful, false otherwise.
    /// </summary>
    public static bool ExtractAttachment(
        Attachment attachment,
        string outputPath,
        bool isBinary = false)
    {
        if (attachment.Data is null)
        {
            return false;
        }

        var data = attachment.Data;

        // Ensure output directory exists
        var outputDir = Path.GetDirectoryName(outputPath);
        if (!string.IsNullOrEmpty(outputDir) && !Directory.Exists(outputDir))
        {
            Directory.CreateDirectory(outputDir);
        }

        if (isBinary)
        {
            File.WriteAllBytes(outputPath, data);
        }
        else
        {
            var text = Encoding.UTF8.GetString(data);
            File.WriteAllText(outputPath, text);
        }

        return true;
    }

    /// <summary>
    /// Creates an ELM attachment for a FHIR Library resource.
    /// </summary>
    private static Attachment CreateElmAttachment(CqlVersionedLibraryIdentifier libraryIdentifier, byte[] elmBytes) =>
        new()
        {
            ElementId = $"{libraryIdentifier}+elm",
            ContentType = ElmLibrary.JsonMimeType,
            Data = elmBytes,
        };

    /// <summary>
    /// Creates a CQL attachment for a FHIR Library resource.
    /// </summary>
    private static Attachment CreateCqlAttachment(CqlVersionedLibraryIdentifier libraryIdentifier, byte[] cqlBytes) =>
        new()
        {
            ElementId = $"{libraryIdentifier}+cql",
            ContentType = "text/cql",
            Data = cqlBytes,
        };

    /// <summary>
    /// Creates a C# source code attachment for a FHIR Library resource.
    /// </summary>
    private static Attachment CreateCSharpAttachment(KeyValuePair<string, string> kvp) =>
        new()
        {
            ElementId = $"{kvp.Key}+csharp",
            ContentType = "text/plain",
            Data = Encoding.UTF8.GetBytes(kvp.Value),
        };

    /// <summary>
    /// Creates a DLL attachment for a FHIR Library resource.
    /// </summary>
    private static Attachment CreateDllAttachment(CqlVersionedLibraryIdentifier libraryIdentifier, byte[] assemblyBytes) =>
        new()
        {
            ElementId = $"{libraryIdentifier}+dll",
            ContentType = "application/octet-stream",
            Data = assemblyBytes,
        };

    /// <summary>
    /// Creates a PDB attachment for a FHIR Library resource.
    /// </summary>
    private static Attachment CreatePdbAttachment(CqlVersionedLibraryIdentifier libraryIdentifier, byte[] debugSymbols) =>
        new()
        {
            ElementId = $"{libraryIdentifier}+pdb",
            ContentType = "application/octet-stream",
            Data = debugSymbols,
        };
}