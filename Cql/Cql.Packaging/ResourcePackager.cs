/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text;
using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Packaging.PostProcessors;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using Annotation = Hl7.Cql.Elm.Annotation;
using Code = Hl7.Fhir.Model.Code;
using DateTimePrecision = Hl7.Cql.Iso8601.DateTimePrecision;

using ElmLibrary = Hl7.Cql.Elm.Library;
using FhirLibrary = Hl7.Fhir.Model.Library;
using FhirResource = Hl7.Fhir.Model.Resource;
using FhirMeasure = Hl7.Fhir.Model.Measure;

namespace Hl7.Cql.Packaging;

#pragma warning disable CS1591

internal class ResourcePackager(
    TypeResolver typeResolver,
    FhirResourcePostProcessor? fhirResourcePostProcessor
    )
{
    private readonly TypeResolver _typeResolver = typeResolver;
    private readonly FhirResourcePostProcessor? _fhirResourcePostProcessor = fhirResourcePostProcessor;

    public IReadOnlyCollection<FhirResource> PackageResources(
        DirectoryInfo elmDirectory,
        DirectoryInfo cqlDirectory,
        string? resourceCanonicalRootUrl,
        LibrarySet elmLibrarySet,
        IReadOnlyDictionary<string, AssemblyData> assembliesByLibraryName)
    {
        var resources = new List<FhirResource>();
        var librariesByVersionedIdentifier = new Dictionary<string, FhirLibrary>();

        void OnResourceCreated(FhirResource resource)
        {
            _fhirResourcePostProcessor?.ProcessResource(resource);
            resources!.Add(resource);
        }

        var typeCrosswalk = new CqlTypeToFhirTypeMapper(_typeResolver);

        foreach (var (name, asmData) in assembliesByLibraryName)
        {
            var library = elmLibrarySet.GetLibrary(name)!;
            var elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{library.GetVersionedIdentifier()}.json"));
            if (!elmFile.Exists)
                elmFile = new FileInfo(Path.Combine(elmDirectory.FullName,
                                                    $"{library.identifier?.id ?? string.Empty}.json"));

            if (!elmFile.Exists)
                throw new InvalidOperationException($"Cannot find ELM file for {library.GetVersionedIdentifier()}");

            var cqlFiles =
                cqlDirectory.GetFiles($"{library.GetVersionedIdentifier()}.cql", SearchOption.AllDirectories);
            if (cqlFiles.Length == 0)
            {
                cqlFiles = cqlDirectory.GetFiles($"{library.identifier!.id}.cql", SearchOption.AllDirectories);
                if (cqlFiles.Length == 0)
                    throw new InvalidOperationException($"{library.identifier!.id}.cql");
            }

            if (cqlFiles.Length > 1)
                throw new InvalidOperationException("More than 1 CQL file found.");

            var cqlFile = cqlFiles[0];
            if (library.GetVersionedIdentifier() is null)
                throw new InvalidOperationException("Library VersionedIdentifier should not be null.");

            var fhirLibrary = LibraryPackager.CreateLibraryResource(elmFile, cqlFile, resourceCanonicalRootUrl, asmData, typeCrosswalk, library);
            librariesByVersionedIdentifier.Add(library.GetVersionedIdentifier()!, fhirLibrary);

            // Analyze datarequirements and add to the FHIR Library resource.
            var dataRequirementsAnalyzer = new DataRequirementsAnalyzer(elmLibrarySet, library);
            var dataRequirements = dataRequirementsAnalyzer.Analyze();
            fhirLibrary.DataRequirement.AddRange(dataRequirements);

            OnResourceCreated(fhirLibrary);
        }

        foreach (var elmLibrary in elmLibrarySet)
        {
            var elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{elmLibrary.GetVersionedIdentifier()}.json"));
            foreach (var def in elmLibrary.statements ?? [])
            {
                if (def.annotation == null)
                    continue;

                var tags = new List<Tag>();
                foreach (var a in def.annotation.OfType<Annotation>())
                {
                    if (a.t == null)
                        continue;

                    foreach (var t in a.t)
                    {
                        if (t != null)
                            tags.Add(t);
                    }
                }

                var measureAnnotation = tags.SingleOrDefault(t => t?.name == "measure");
                var yearAnnotation = tags.SingleOrDefault(t => t?.name == "year");
                if (measureAnnotation != null
                    && !string.IsNullOrWhiteSpace(measureAnnotation.value)
                    && yearAnnotation != null
                    && !string.IsNullOrWhiteSpace(yearAnnotation.value)
                    && int.TryParse(yearAnnotation.value, out var measureYear))
                {
                    FhirMeasure measure = MeasurePackager.CreateMeasureResource(elmFile, resourceCanonicalRootUrl, measureAnnotation, measureYear, librariesByVersionedIdentifier, elmLibrary);
                    OnResourceCreated(measure);
                }
            }
        }

        return resources;
    }
}

file static class MeasurePackager
{
    public static FhirMeasure CreateMeasureResource(
        FileInfo elmFile,
        string? resourceCanonicalRootUrl,
        Tag measureAnnotation,
        int measureYear,
        Dictionary<string, FhirLibrary> librariesByVersionedIdentifier,
        ElmLibrary elmLibrary)
    {
        var measure = new FhirMeasure();
        measure.Name = measureAnnotation.value;
        measure.Id = elmLibrary.identifier?.id!;
        measure.Version = elmLibrary.identifier?.version!;
        measure.Status = PublicationStatus.Active;
        measure.Date = new DateTimeIso8601(elmFile.LastWriteTimeUtc, DateTimePrecision.Millisecond)
            .ToString();
        measure.EffectivePeriod = new Period
        {
            Start = new DateTimeIso8601(measureYear, 1, 1, 0, 0, 0, 0, 0, 0).ToString(),
            End = new DateTimeIso8601(measureYear, 12, 31, 23, 59, 59, 999, 0, 0).ToString(),
        };
        measure.Group = [];
        measure.Url = measure.CanonicalUri(resourceCanonicalRootUrl);
        if (elmLibrary.GetVersionedIdentifier() is null)
            throw new InvalidOperationException("Library VersionedIdentifier should not be null.");

        if (!librariesByVersionedIdentifier.TryGetValue(elmLibrary.GetVersionedIdentifier()!, out var libForMeasure))
            throw new InvalidOperationException(
                $"We didn't create a measure for library {libForMeasure}");
        AnnotateMeasurePopulations(measure, elmLibrary);
        measure.Library = new List<string> { libForMeasure!.Url };
        return measure;
    }
    private static readonly Dictionary<string, string> Populations = new Dictionary<string, string>
        {
            { "initial-population", "Initial Population" },
            { "numerator", "Numerator" },
            { "denominator", "Denominator" },
            { "denominator-exclusion", "Denominator Exclusion" }
        };
    private static void AnnotateMeasurePopulations(Measure measure, Elm.Library library)
    {
        var defs = library.statements ?? Enumerable.Empty<Hl7.Cql.Elm.ExpressionDef>();
        foreach (var def in defs)
        {
            var annotations = (def.annotation?
                .OfType<Annotation>()
                .SelectMany(a => a.t ?? Enumerable.Empty<Tag>())
                ?? Enumerable.Empty<Tag>())
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
                        throw new InvalidOperationException($"Definition {def.name} has a @group annotation whose value is {tuple.Group}.  Groups must be positive integers.");
                    if (!Populations.ContainsKey(tuple.Population))
                        throw new InvalidOperationException($"Definition {def.name} has a @population annotation whose value is {tuple.Population}.  @population must be one of: {string.Join(", ", Populations.Keys)}");

                    var rate = $"rate-{tuple.Group}";
                    var groupsForRate = measure.Group?
                        .Where(g => g.ElementId == rate)
                        .ToArray() ?? new Measure.GroupComponent[] { };
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
                            Code = new CodeableConcept(rate, MeasureGroupCodeSystem),
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
                                Coding = new List<Coding>
                                {
                                    new Coding
                                    {
                                        System = "http://terminology.hl7.org/CodeSystem/measure-population",
                                         Code = populationSuffix,
                                    }
                                }
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

file static class LibraryPackager
{
    public static FhirLibrary CreateLibraryResource(
        FileInfo elmFile,
        FileInfo? cqlFile,
        string? resourceCanonicalRootUrl,
        AssemblyData assemblyData,
        CqlTypeToFhirTypeMapper typeCrosswalk,
        ElmLibrary? elmLibrary = null)
    {
        if (!elmFile.Exists)
            throw new ArgumentException($"Couldn't find library {elmFile.FullName}", nameof(elmFile));

        if (elmLibrary is null)
        {
            elmLibrary = ElmLibrary.LoadFromJson(elmFile);
            if (elmLibrary is null)
                throw new ArgumentException($"File at {elmFile.FullName} is not valid ELM");
        }

        var fhirLibrary = CreateFhirLibrary(elmLibrary, elmFile, resourceCanonicalRootUrl);
        AddElmAttachment(elmLibrary, elmFile, fhirLibrary);
        var parameters = new List<ParameterDefinition>();
        AddInParameters(elmLibrary, parameters, typeCrosswalk);
        AddOutParameters(elmLibrary, parameters, typeCrosswalk);
        fhirLibrary.Parameter = parameters.Count > 0 ? parameters : null!;

        AddRelatedArtefacts(elmLibrary, fhirLibrary, resourceCanonicalRootUrl);

        var fhirParameters = CreateFhirParameters(elmLibrary);
        if (fhirParameters.Any())
            AddCQLOptions(fhirLibrary, fhirParameters);

        if (cqlFile!.Exists)
            AddCqlAttachment(elmLibrary, fhirLibrary, cqlFile);

        AddDllAttachment(elmLibrary, fhirLibrary, assemblyData);
        foreach (var kvp in assemblyData.SourceCode)
            AddCSharpAttachment(fhirLibrary, kvp);

        return fhirLibrary;
    }

    private static void AddElmAttachment(
        ElmLibrary elmLibrary,
        FileInfo elmFile,
        FhirLibrary fhirLibrary)
    {
        var bytes = File.ReadAllBytes(elmFile.FullName);
        var attachment = new Attachment
        {
            ElementId = $"{elmLibrary.GetVersionedIdentifier()}+elm",
            ContentType = ElmLibrary.JsonMimeType,
            Data = bytes,
        };
        fhirLibrary.Content.Add(attachment);
    }

    private static FhirLibrary CreateFhirLibrary(
        ElmLibrary elmLibrary,
        FileInfo elmFile,
        string? resourceCanonicalRootUrl)
    {
        var fhirLibrary = new FhirLibrary();
        fhirLibrary.Type = LogicLibraryCodeableConcept;
        fhirLibrary.Id = $"{elmLibrary.identifier.id}";
        fhirLibrary.Version = elmLibrary.identifier?.version!;
        fhirLibrary.Name = elmLibrary.identifier?.id!;
        fhirLibrary.Status = PublicationStatus.Active;
        fhirLibrary.Date = new DateTimeIso8601(elmFile.LastWriteTimeUtc, DateTimePrecision.Millisecond).ToString();
        fhirLibrary.Url = fhirLibrary.CanonicalUri(resourceCanonicalRootUrl);
        return fhirLibrary;
    }

    private static void AddRelatedArtefacts(
        ElmLibrary elmLibrary,
        FhirLibrary library,
        string? resourceCanonicalRootUrl)
    {
        foreach (var include in elmLibrary?.includes ?? [])
        {
            string includeVersionString = string.IsNullOrEmpty(include.version) ? string.Empty : $"|{include.version}";
            string includeIdMaybeVersion =
                $"{resourceCanonicalRootUrl.EnsureEndsWith("/")}Library/{include.path}{includeVersionString}";
            library.RelatedArtifact.Add(new RelatedArtifact
            {
                Type = RelatedArtifact.RelatedArtifactType.DependsOn,
                Resource = includeIdMaybeVersion,
            });
        }
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

        var valueSetParameterDefinitions = new List<ParameterDefinition>();
        foreach (var valueSet in elmLibrary.valueSets ?? [])
        {
            var valueSetParameter = new ParameterDefinition
            {
                Type = FHIRAllTypes.ValueSet,
                Name = valueSet.id!,
                Use = OperationParameterUse.In,
            };
            valueSetParameterDefinitions.Add(valueSetParameter);
        }

        parameters.AddRange(valueSetParameterDefinitions);

    }

    private static void AddCqlAttachment(
        ElmLibrary? elmLibrary,
        FhirLibrary fhirLibrary,
        FileInfo cqlFile)
    {
        var cqlBytes = File.ReadAllBytes(cqlFile.FullName);

        var attachment = new Attachment
        {
            ElementId = $"{elmLibrary!.GetVersionedIdentifier()}+cql",
            ContentType = "text/cql",
            Data = cqlBytes,
        };
        fhirLibrary.Content.Add(attachment);
    }

    private static void AddCQLOptions(
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
        AssemblyData assemblyData)
    {
        var assemblyBytes = assemblyData.Binary;
        var attachment = new Attachment
        {
            ElementId = $"{elmLibrary!.GetVersionedIdentifier()}+dll",
            ContentType = "application/octet-stream",
            Data = assemblyBytes,
        };
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
        var typeSpecifier = elmParameter.resultTypeSpecifier ?? elmParameter.parameterTypeSpecifier;
        if (typeSpecifier is null)
            throw new ArgumentException($"{typeSpecifier} is missing on parameter: {elmParameter.name}",
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
                Value = new Code("private"),
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
}