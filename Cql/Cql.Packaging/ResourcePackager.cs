using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Runtime.Loader;
using System.Text;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Packaging.PostProcessors;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;
using JetBrains.Annotations;
using Library = Hl7.Fhir.Model.Library;
using Microsoft.Extensions.Logging;
using static System.FormattableString;
using Annotation = Hl7.Cql.Elm.Annotation;
using DateTimePrecision = Hl7.Cql.Iso8601.DateTimePrecision;

namespace Hl7.Cql.Packaging;

#pragma warning disable CS1591
internal class ResourcePackager
{
    private readonly LibrarySetExpressionBuilder _librarySetExpressionBuilder;
    private readonly AssemblyCompiler _assemblyCompiler;
    private readonly TypeResolver _typeResolver;
    private readonly FhirResourcePostProcessor? _fhirResourcePostProcessor;

    public ResourcePackager(
        TypeResolver typeResolver,
        AssemblyCompiler assemblyCompiler,
        LibrarySetExpressionBuilder librarySetExpressionBuilder, 
        FhirResourcePostProcessor? fhirResourcePostProcessor)
    {
        _typeResolver = typeResolver;
        _assemblyCompiler = assemblyCompiler;
        _librarySetExpressionBuilder = librarySetExpressionBuilder;
        _fhirResourcePostProcessor = fhirResourcePostProcessor;
    }

    public IReadOnlyCollection<Resource> PackageResources(
        DirectoryInfo elmDirectory,
        DirectoryInfo cqlDirectory,
        string? resourceCanonicalRootUrl = null)
    {
        //
        // 1. LOAD ELM FILES
        //

        LibrarySet librarySet;
        try
        {
            librarySet = new(elmDirectory.FullName);
            librarySet.LoadLibraries(elmDirectory.GetFiles("*.json", SearchOption.AllDirectories));
        }
        catch (Exception e)
        {
            throw new ResourcePackagerErrors(LoadElmFilesException: e).ToException();
        }

        //
        // 2. BUILD EXPRESSIONS
        //      Build the Elm Libraries as far as we can get. Errors are captured to be thrown later,
        //      while we try to continue building the rest of the artifacts up until the point of failure.

        var librariesByNameAndVersion = new Dictionary<string, Library>();
        var definitions = new DefinitionDictionary<LambdaExpression>();
        ExceptionDispatchInfo? expressionBuildingExceptionInfo = null;
        try
        {
            _librarySetExpressionBuilder.ProcessLibrarySet(librarySet, definitions);
        }
        catch (Exception e)
        {
            var librarySetReplacement = new LibrarySet();
            librarySetReplacement.AddLibraries(definitions.Libraries.Select(lib => librarySet.GetLibrary(lib, true)!));
            librarySet = librarySetReplacement;
            expressionBuildingExceptionInfo = ExceptionDispatchInfo.Capture(e);
        }

        //
        // 3. GENERATE C# ASSEMBLIES 
        //

        IDictionary<string, AssemblyData> assembliesByLibraryName;
        try
        {
            assembliesByLibraryName = _assemblyCompiler.Compile(librarySet, definitions);
        }
        catch (Exception e)
        {
            throw new ResourcePackagerErrors(
                ExpressionBuildingException: expressionBuildingExceptionInfo?.SourceException, 
                AssemblyCompilingException:e).ToException();
        }

        //
        // 4. GENERATE FHIR RESOURCES
        //

        try
        {
            var resources = BuildResources(
                elmDirectory,
                cqlDirectory, 
                resourceCanonicalRootUrl, 
                librarySet,
                assembliesByLibraryName, librariesByNameAndVersion);

            if (expressionBuildingExceptionInfo is not null)
            {
                throw new ResourcePackagerErrors(
                    LoadElmFilesException: expressionBuildingExceptionInfo.SourceException)
                    .ToException();
            }

            return resources;
        }
        catch (CqlException<ResourcePackagerErrors>)
        {
            throw;
        }
        catch (Exception e)
        {
            throw new ResourcePackagerErrors(
                LoadElmFilesException: expressionBuildingExceptionInfo?.SourceException,
                ResourceBuildingException: e).ToException();
        }
    }

    private List<Resource> BuildResources(
        DirectoryInfo elmDirectory,
        DirectoryInfo cqlDirectory,
        string? resourceCanonicalRootUrl,
        LibrarySet librarySet,
        IDictionary<string, AssemblyData> assembliesByLibraryName,
        IDictionary<string, Library> librariesByNameAndVersion)
    {
        var resources = new List<Resource>();

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

                var fhirLibrary = CreateLibraryResource(elmFile, cqlFile, asmData, typeCrosswalk, library);
                librariesByNameAndVersion.Add(library.NameAndVersion()!, fhirLibrary);
                OnResourceCreated(fhirLibrary);
            }
        }

        foreach (var library in librarySet)
        {
            var elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{library.NameAndVersion()}.json"));
            foreach (var def in library.statements ?? Enumerable.Empty<ExpressionDef>())
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
                    var measure = new Measure();
                    measure.Name = measureAnnotation.value;
                    measure.Id = library.identifier?.id!;
                    measure.Version = library.identifier?.version!;
                    measure.Status = PublicationStatus.Active;
                    measure.Date = new DateTimeIso8601(elmFile.LastWriteTimeUtc, DateTimePrecision.Millisecond)
                        .ToString();
                    measure.EffectivePeriod = new Period
                    {
                        Start = new DateTimeIso8601(measureYear, 1, 1, 0, 0, 0, 0, 0, 0).ToString(),
                        End = new DateTimeIso8601(measureYear, 12, 31, 23, 59, 59, 999, 0, 0).ToString(),
                    };
                    measure.Group = new List<Measure.GroupComponent>();
                    measure.Url = measure.CanonicalUri(resourceCanonicalRootUrl);
                    if (library.NameAndVersion() is null)
                        throw new InvalidOperationException("Library NameAndVersion should not be null.");

                    if (!librariesByNameAndVersion.TryGetValue(library.NameAndVersion()!, out var libForMeasure))
                        throw new InvalidOperationException(
                            $"We didn't create a measure for library {libForMeasure}");

                    measure.Library = new List<string> { libForMeasure!.Url };
                    OnResourceCreated(measure);
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
        var definitions = factory.LibrarySetExpressionBuilder.ProcessLibrarySet(librarySet);
        var assemblyData = factory.AssemblyCompiler.Compile(librarySet, definitions);
        var asmContext = new AssemblyLoadContext($"{lib}-{version}");
        foreach (var (_, asmData) in assemblyData)
        {
            var assemblyBytes = asmData.Binary;
            using var ms = new MemoryStream(assemblyBytes);
            asmContext.LoadFromStream(ms);
        }
        return asmContext;
    }

    #endregion 
}

internal readonly record struct ResourcePackagerErrors(
    Exception? LoadElmFilesException = null,
    Exception? ExpressionBuildingException = null,
    Exception? AssemblyCompilingException = null,
    Exception? ResourceBuildingException = null) : ICqlError
{
    public string GetMessage()
    {
        StringBuilder sb = new();
        int i = 1;
        sb.Append("The following exceptions occurred during Library Packaging:");
        if (LoadElmFilesException is { } lefe)
        {
            if (sb.Length > 0) sb.AppendLine().AppendLine();
            sb.AppendLine(Invariant($"{i++}. LoadElmFilesException"));
            sb.Append(lefe);
        }
        if (ExpressionBuildingException is { } ebe)
        {
            if (sb.Length > 0) sb.AppendLine().AppendLine();
            sb.AppendLine(Invariant($"{i++}. ExpressionBuildingException"));
            sb.Append(ebe);
        }
        if (AssemblyCompilingException is { } ace)
        {
            if (sb.Length > 0) sb.AppendLine().AppendLine();
            sb.AppendLine(Invariant($"{i++}. AssemblyCompilingException"));
            sb.Append(ace);
        }
        if (ResourceBuildingException is { } rbe)
        {
            if (sb.Length > 0) sb.AppendLine().AppendLine();
            sb.AppendLine(Invariant($"{i++}. ResourceBuildingException"));
            sb.Append(rbe);
        }
        return sb.ToString();
    }
}