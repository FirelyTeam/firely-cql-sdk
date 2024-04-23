using System.Text;
using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Packaging.PostProcessors;
using Hl7.Fhir.Model;
using FhirLibrary = Hl7.Fhir.Model.Library;
using Annotation = Hl7.Cql.Elm.Annotation;
using DateTimePrecision = Hl7.Cql.Iso8601.DateTimePrecision;
using Library = Hl7.Cql.Elm.Library;

namespace Hl7.Cql.Packaging;

#pragma warning disable CS1591
internal class ResourcePackager
{
    private readonly TypeResolver _typeResolver;
    private readonly FhirResourcePostProcessor? _fhirResourcePostProcessor;

    public ResourcePackager(
        TypeResolver typeResolver,
        FhirResourcePostProcessor? fhirResourcePostProcessor)
    {
        _typeResolver = typeResolver;
        _fhirResourcePostProcessor = fhirResourcePostProcessor;
    }

    public IReadOnlyCollection<Resource> PackageResources(
        DirectoryInfo elmDirectory,
        DirectoryInfo cqlDirectory,
        string? resourceCanonicalRootUrl,
        LibrarySet librarySet,
        IReadOnlyDictionary<string, AssemblyData> assembliesByLibraryName)
    {
        var resources = new List<Resource>();
        var librariesByNameAndVersion = new Dictionary<string, FhirLibrary>();

        void OnResourceCreated(Resource resource)
        {
            _fhirResourcePostProcessor?.ProcessResource(resource);
            resources!.Add(resource);
        }

        var typeCrosswalk = new CqlTypeToFhirTypeMapper(_typeResolver);

        foreach (var (name, asmData) in assembliesByLibraryName)
        {
            if (name is "TupleTypes")
            {
                var tuplesBinary = new Binary
                {
                    Id = "TupleTypes-Binary",
                    ContentType = "application/octet-stream",
                    Data = asmData.Binary,
                };
                OnResourceCreated(tuplesBinary);

                foreach (var sourceKvp in asmData.SourceCode)
                {
                    var tuplesSourceBytes = Encoding.UTF8.GetBytes(sourceKvp.Value);
                    var tuplesCSharpBinary = new Binary
                    {
                        Id = sourceKvp.Key.Replace("_", "-"),
                        ContentType = "text/plain",
                        Data = tuplesSourceBytes,
                    };
                    OnResourceCreated(tuplesCSharpBinary);
                }
            }
            else
            {
                var library = librarySet.GetLibrary(name)!;
                var elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{library.NameAndVersion()}.json"));
                if (!elmFile.Exists)
                    elmFile = new FileInfo(Path.Combine(elmDirectory.FullName,
                        $"{library.identifier?.id ?? string.Empty}.json"));

                if (!elmFile.Exists)
                    throw new InvalidOperationException($"Cannot find ELM file for {library.NameAndVersion()}");

                var cqlFiles =
                    cqlDirectory.GetFiles($"{library.NameAndVersion()}.cql", SearchOption.AllDirectories);
                if (cqlFiles.Length == 0)
                {
                    cqlFiles = cqlDirectory.GetFiles($"{library.identifier!.id}.cql", SearchOption.AllDirectories);
                    if (cqlFiles.Length == 0)
                        throw new InvalidOperationException($"{library.identifier!.id}.cql");
                }

                if (cqlFiles.Length > 1)
                    throw new InvalidOperationException($"More than 1 CQL file found.");

                var cqlFile = cqlFiles[0];
                if (library.NameAndVersion() is null)
                    throw new InvalidOperationException("Library NameAndVersion should not be null.");

                var fhirLibrary = CreateLibraryResource(elmFile, cqlFile, resourceCanonicalRootUrl, asmData, typeCrosswalk, library);
                librariesByNameAndVersion.Add(library.NameAndVersion()!, fhirLibrary);
                OnResourceCreated(fhirLibrary);
            }
        }

        foreach (var library in librarySet)
        {
            var elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{library.NameAndVersion()}.json"));
            foreach (var def in library.statements ?? [])
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
                    Measure measure = CreateMeasureResource(elmFile, resourceCanonicalRootUrl, measureAnnotation, measureYear, librariesByNameAndVersion, library);
                    OnResourceCreated(measure);
                }
            }
        }

        return resources;
    }

    private static Measure CreateMeasureResource(
        FileInfo elmFile,
        string? resourceCanonicalRootUrl,
        Tag measureAnnotation,
        int measureYear,
        Dictionary<string, FhirLibrary> librariesByNameAndVersion,
        Elm.Library elmLibrary)
    {
        var measure = new Measure();
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
        if (elmLibrary.NameAndVersion() is null)
            throw new InvalidOperationException("Library NameAndVersion should not be null.");

        if (!librariesByNameAndVersion.TryGetValue(elmLibrary.NameAndVersion()!, out var libForMeasure))
            throw new InvalidOperationException(
                $"We didn't create a measure for library {libForMeasure}");
        measure.Library = new List<string> { libForMeasure!.Url };
        return measure;
    }

    private static FhirLibrary CreateLibraryResource(
        FileInfo elmFile,
        FileInfo? cqlFile,
        string? resourceCanonicalRootUrl,
        AssemblyData assembly,
        CqlTypeToFhirTypeMapper typeCrosswalk,
        Elm.Library? elmLibrary = null)
    {
        if (!elmFile.Exists)
            throw new ArgumentException($"Couldn't find library {elmFile.FullName}", nameof(elmFile));

        if (elmLibrary is null)
        {
            elmLibrary = Elm.Library.LoadFromJson(elmFile);
            if (elmLibrary is null)
                throw new ArgumentException($"File at {elmFile.FullName} is not valid ELM");
        }

        var bytes = File.ReadAllBytes(elmFile.FullName);
        var attachment = new Attachment
        {
            ElementId = $"{elmLibrary.NameAndVersion()}+elm",
            ContentType = Elm.Library.JsonMimeType,
            Data = bytes,
        };
        var library = new FhirLibrary();
        library.Content.Add(attachment);
        library.Type = LogicLibraryCodeableConcept;
        string libraryId = $"{elmLibrary!.NameAndVersion()}";
        library.Id = libraryId!;
        library.Version = elmLibrary!.identifier?.version!;
        library.Name = elmLibrary!.identifier?.id!;
        library.Status = PublicationStatus.Active;
        library.Date = new DateTimeIso8601(elmFile.LastWriteTimeUtc, Iso8601.DateTimePrecision.Millisecond).ToString();
        library.Url = library.CanonicalUri(resourceCanonicalRootUrl);
        var parameters = new List<ParameterDefinition>();
        var inParams = elmLibrary.parameters?
            .Select(pd => ElmParameterToFhir(pd, typeCrosswalk));
        if (inParams is not null)
            parameters.AddRange(inParams);
        var outParams = elmLibrary.statements?
            .Where(def => def.name != "Patient" && def is not FunctionDef)
            .Select(def => ElmDefinitionToParameter(def, typeCrosswalk));
        if (outParams is not null)
            parameters.AddRange(outParams);
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
        library.Parameter = parameters.Count > 0 ? parameters : null!;

        foreach (var include in elmLibrary?.includes ?? [])
        {
            var includeId = $"{include.path}-{include.version}";
            library.RelatedArtifact.Add(new RelatedArtifact
            {
                Type = RelatedArtifact.RelatedArtifactType.DependsOn,
                Resource = includeId,
            });
        }

        if (cqlFile!.Exists)
        {
            var cqlBytes = File.ReadAllBytes(cqlFile.FullName);

            var cqlAttachment = new Attachment
            {
                ElementId = $"{elmLibrary!.NameAndVersion()}+cql",
                ContentType = "text/cql",
                Data = cqlBytes,
            };
            library.Content.Add(cqlAttachment);
        }

        if (assembly != null)
        {
            var assemblyBytes = assembly.Binary;
            var assemblyAttachment = new Attachment
            {
                ElementId = $"{elmLibrary!.NameAndVersion()}+dll",
                ContentType = "application/octet-stream",
                Data = assemblyBytes,
            };
            library.Content.Add(assemblyAttachment);
            foreach (var kvp in assembly.SourceCode)
            {
                var sourceBytes = Encoding.UTF8.GetBytes(kvp.Value);
                //var sourceBase64 = System.Convert.ToBase64String(sourceBytes);
                var sourceAttachment = new Attachment
                {
                    ElementId = $"{kvp.Key}+csharp",
                    ContentType = "text/plain",
                    Data = sourceBytes,
                };
                library.Content.Add(sourceAttachment);
            }
        }
        return library;
    }

    private static readonly CodeableConcept LogicLibraryCodeableConcept = new()
    {
        Coding =
        [
            new Coding
            {
                Code = "logic-library"!,
                System = "http://terminology.hl7.org/CodeSystem/library-type"!
            }
        ]
    };

    private static ParameterDefinition ElmParameterToFhir(
        ParameterDef elmParameter,
        CqlTypeToFhirTypeMapper typeCrosswalk)
    {
        var typeSpecifier = elmParameter.resultTypeSpecifier ?? elmParameter.parameterTypeSpecifier;
        if (typeSpecifier is null)
            throw new ArgumentException($"{typeSpecifier} is missing on parameter: {elmParameter.name}", nameof(elmParameter));
        var type = typeCrosswalk.TypeEntryFor(typeSpecifier);
        if (type is null || type.FhirType is null)
            throw new ArgumentException($"Unable to identify a valid FHIR type for this parameter.", nameof(elmParameter));

        var annotations = (elmParameter.annotation?
                               .OfType<Elm.Annotation>()
                               .SelectMany(a => a.t ?? [])
                           ?? [])
            .ToArray();

        var parameterDefinition = new ParameterDefinition
        {
            Name = elmParameter.name!,
            Use = OperationParameterUse.In,
            Min = elmParameter.@default is null ? 1 : 0,
            Max = "1"!,
            Type = type.FhirType,
        };
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
        if (type is null || type.FhirType is null)
            throw new ArgumentException($"Unable to identify a valid FHIR type for this definition.", nameof(definition));
        var parameterDefinition = new ParameterDefinition
        {
            Name = definition.name!,
            Use = OperationParameterUse.Out,
            Min = 0,
            Max = "1",
            Type = type.FhirType!,
        };
        if (type.ElementType is not null && type.ElementType.FhirType is not null)
        {
            parameterDefinition.Extension =
            [
                new Extension
                {
                    Value = new Code<FHIRAllTypes>(type.ElementType.FhirType),
                    Url = Constants.ParameterElementTypeExtensionUri
                }
            ];
        }

        if (definition.accessLevel == Elm.AccessModifier.Private)
        {
            parameterDefinition.Extension.Add(new Extension
            {
                Value = new Hl7.Fhir.Model.Code("private"),
                Url = Constants.ParameterAccessLevel,
            });
        }

        return parameterDefinition;
    }
}