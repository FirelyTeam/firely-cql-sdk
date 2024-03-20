using System.Runtime.Loader;
using System.Text;
using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using JetBrains.Annotations;
using Library = Hl7.Fhir.Model.Library;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Packaging;

#pragma warning disable CS1591
internal class LibraryPackager
{
    private readonly LibrarySetExpressionBuilder _librarySetExpressionBuilder;
    private readonly AssemblyCompiler _assemblyCompiler;
    private readonly TypeResolver _typeResolver;

    public LibraryPackager(
        TypeResolver typeResolver,
        AssemblyCompiler assemblyCompiler, 
        LibrarySetExpressionBuilder librarySetExpressionBuilder)
    {
        _typeResolver = typeResolver;
        _assemblyCompiler = assemblyCompiler;
        _librarySetExpressionBuilder = librarySetExpressionBuilder;
    }

    internal IEnumerable<Resource> PackageResources(
        DirectoryInfo elmDirectory,
        DirectoryInfo cqlDirectory,
        LibrarySet librarySet,
        LibraryPackageCallbacks callbacks = default)
    {
        // Build the Elm Libraries as far as we can get. Errors are captured to be thrown later,
        // while we try to continue building the rest of the artifacts up until the point of failure.

        var resources = new List<Resource>();
        var librariesByNameAndVersion = new Dictionary<string, Library>();
        var definitions = _librarySetExpressionBuilder.ProcessLibrarySet(librarySet);
        var assemblies = _assemblyCompiler.Compile(librarySet, definitions);
        var typeCrosswalk = new CqlTypeToFhirTypeMapper(_typeResolver);


        var tupleAssembly = assemblies["TupleTypes"];
        var tuplesBinary = new Binary
        {
            Id = "TupleTypes-Binary",
            ContentType = "application/octet-stream",
            Data = tupleAssembly.Binary,
        };
        resources.Add(tuplesBinary);

        foreach (var sourceKvp in tupleAssembly.SourceCode)
        {
            var tuplesSourceBytes = Encoding.UTF8.GetBytes(sourceKvp.Value);
            var tuplesCSharp = new Binary
            {
                Id = sourceKvp.Key.Replace("_", "-"),
                ContentType = "text/plain",
                Data = tuplesSourceBytes,
            };
            resources.Add(tuplesCSharp);
        }

        foreach (var library in librarySet)
        {
            var elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{library.NameAndVersion()}.json"));
            if (!elmFile.Exists)
                elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{library.identifier?.id ?? string.Empty}.json"));

            if (!elmFile.Exists)
                throw new InvalidOperationException($"Cannot find ELM file for {library.NameAndVersion()}");

            var cqlFiles = cqlDirectory.GetFiles($"{library.NameAndVersion()}.cql", SearchOption.AllDirectories);
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

            if (!assemblies.TryGetValue(library.NameAndVersion()!, out var assembly))
                throw new InvalidOperationException($"No assembly for {library.NameAndVersion()}");

            var fhirLibrary = CreateLibraryResource(elmFile, cqlFile, assembly, typeCrosswalk, library, callbacks);
            librariesByNameAndVersion.Add(library.NameAndVersion()!, fhirLibrary);
            resources.Add(fhirLibrary);
        }

        foreach (var library in librarySet)
        {
            var elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{library.NameAndVersion()}.json"));
            foreach (var def in library.statements ?? Enumerable.Empty<ExpressionDef>())
            {
                if (def.annotation == null)
                    continue;

                var tags = new List<Tag>();
                foreach (var a in def.annotation.OfType<Elm.Annotation>())
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
                    var measure = new Measure();
                    measure.Name = measureAnnotation.value;
                    measure.Id = library.identifier?.id!;
                    measure.Version = library.identifier?.version!;
                    measure.Status = PublicationStatus.Active;
                    measure.Date = new DateTimeIso8601(elmFile.LastWriteTimeUtc, Iso8601.DateTimePrecision.Millisecond).ToString();
                    measure.EffectivePeriod = new Period
                    {
                        Start = new DateTimeIso8601(measureYear, 1, 1, 0, 0, 0, 0, 0, 0).ToString(),
                        End = new DateTimeIso8601(measureYear, 12, 31, 23, 59, 59, 999, 0, 0).ToString(),
                    };
                    measure.Group = new List<Measure.GroupComponent>();
                    measure.Url = callbacks.BuildUrlFromResource(measure);
                    if (library.NameAndVersion() is null)
                        throw new InvalidOperationException("Library NameAndVersion should not be null.");

                    if (!librariesByNameAndVersion.TryGetValue(library.NameAndVersion()!, out var libForMeasure) || libForMeasure is null)
                        throw new InvalidOperationException($"We didn't create a measure for library {libForMeasure}");

                    measure.Library = new List<string> { libForMeasure!.Url };
                    resources.Add(measure);
                }
            }
        }

        return resources;
    }

    private static Library CreateLibraryResource(
        FileInfo elmFile,
        FileInfo? cqlFile,
        AssemblyData assembly,
        CqlTypeToFhirTypeMapper typeCrosswalk,
        Elm.Library? elmLibrary = null,
        LibraryPackageCallbacks callbacks = default)
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
        var library = new Library();
        library.Content.Add(attachment);
        library.Type = LogicLibraryCodeableConcept;
        string libraryId = $"{elmLibrary!.NameAndVersion()}";
        library.Id = libraryId!;
        library.Version = elmLibrary!.identifier?.version!;
        library.Name = elmLibrary!.identifier?.id!;
        library.Status = PublicationStatus.Active;
        library.Date = new DateTimeIso8601(elmFile.LastWriteTimeUtc, Iso8601.DateTimePrecision.Millisecond).ToString();
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
        foreach (var valueSet in elmLibrary.valueSets ?? Enumerable.Empty<ValueSetDef>())
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

        foreach (var include in elmLibrary?.includes ?? Enumerable.Empty<IncludeDef>())
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

        library.Url = callbacks.BuildUrlFromResource(library);
        callbacks.NotifyLibraryResourceCreated(library);
        return library;
    }

    private static readonly CodeableConcept LogicLibraryCodeableConcept = new()
    {
        Coding = new List<Coding>
        {
            new Coding
            {
                Code = "logic-library"!,
                System = "http://terminology.hl7.org/CodeSystem/library-type"!
            }
        }
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
                               .SelectMany(a => a.t ?? Enumerable.Empty<Tag>())
                           ?? Enumerable.Empty<Tag>())
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
            parameterDefinition.Extension = new List<Extension>()
            {
                new Extension
                {
                    Value = new Code<FHIRAllTypes>(type.ElementType.FhirType),
                    Url = Constants.ParameterElementTypeExtensionUri
                }
            };
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

    #region Static Utiltities

    [UsedImplicitly]
    [Obsolete("Use LibrarySet.LoadLibraries instead.")]
    public static IReadOnlyDictionary<string, Elm.Library> LoadLibraries(DirectoryInfo elmDir)
    {
        LibrarySet ls = new(elmDir.FullName);
        ls.LoadLibraries(elmDir.GetFiles("*.json", SearchOption.AllDirectories));
        return ls.AsReadOnlyDictionary;
    }

    [UsedImplicitly]
    public static AssemblyLoadContext LoadResources(
        DirectoryInfo dir, 
        string lib, 
        string version)
    {
        var libFile = new FileInfo(Path.Combine(dir.FullName, $"{lib}-{version}.json"));
        using var fs = libFile.OpenRead();
        var library = fs.ParseFhir<Library>();
        var dependencies = library.GetDependencies(dir);
        var allLibs = dependencies.AllLibraries();
        var asmContext = new AssemblyLoadContext($"{lib}-{version}");
        allLibs.LoadAssemblies(asmContext);

        var tupleTypes = new FileInfo(Path.Combine(dir.FullName, "TupleTypes-Binary.json"));
        using var tupleFs = tupleTypes.OpenRead();
        var binaries = new[]
        {
                tupleFs.ParseFhir<Binary>()
            };

        binaries.LoadAssembles(asmContext);
        return asmContext;
    }

    [UsedImplicitly]
    public static AssemblyLoadContext LoadElm(
        DirectoryInfo elmDirectory,
        string lib,
        string version,
        LogLevel logLevel = LogLevel.Error,
        int cacheSize = 0)
    {
        var logFactory = LoggerFactory
                      .Create(logging =>
                      {
                          logging.AddFilter(level => level >= logLevel);
                          logging.AddConsole(console =>
                          {
                              console.LogToStandardErrorThreshold = LogLevel.Error;
                          });
                      });
        return LoadElm(elmDirectory, lib, version, logFactory, cacheSize);
    }

    [UsedImplicitly]
    public static AssemblyLoadContext LoadElm(
        DirectoryInfo elmDirectory,
        string lib,
        string version,
        ILoggerFactory logFactory,
        int cacheSize)
    {
        LibrarySet librarySet = new();
        librarySet.LoadLibraryAndDependencies(elmDirectory, lib, version);
        LibraryPackagerFactory factory = new LibraryPackagerFactory(logFactory, cacheSize);
        var assemblyData = factory.AssemblyCompiler.Compile(librarySet);
        var asmContext = new AssemblyLoadContext($"{lib}-{version}");
        foreach (var kvp in assemblyData)
        {
            var assemblyBytes = kvp.Value.Binary;
            using var ms = new MemoryStream(assemblyBytes);
            asmContext.LoadFromStream(ms);
        }
        return asmContext;
    }

    #endregion 
}