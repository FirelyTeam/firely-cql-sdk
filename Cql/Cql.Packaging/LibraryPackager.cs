#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Conversion;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Graph;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;
using System.Collections.Concurrent;
using System.Linq.Expressions;
using System.Runtime.Loader;
using System.Text;
using elm = Hl7.Cql.Elm;
using Library = Hl7.Fhir.Model.Library;

namespace Hl7.Cql.Packaging
{
    public class LibraryPackager
    {
        internal LibraryPackager()
        {
            FhirTypeConverter.InitializeCache(0);
            TypeConverter = FhirTypeConverter.Default;
        }

        internal LibraryPackager(TypeConverter? typeConverter)
        {
            FhirTypeConverter.InitializeCache(0);
            TypeConverter = typeConverter ?? FhirTypeConverter.Default;
        }

        public static IDictionary<string, elm.Library> LoadLibraries(DirectoryInfo elmDir)
        {
            var dict = new ConcurrentDictionary<string, elm.Library>();
            var files = elmDir.GetFiles("*.json", SearchOption.AllDirectories);
            Parallel.ForEach(files, file =>
            {
                var library = elm.Library.LoadFromJson(file);
                if (library?.NameAndVersion != null)
                {
                    dict.TryAdd(library.NameAndVersion, library);
                }
            });
            return dict;
        }

        public static AssemblyLoadContext LoadResources(DirectoryInfo dir, string lib, string version)
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

#pragma warning disable RS0027 // API with optional parameter(s) should have the most parameters amongst its public overloads
        public static AssemblyLoadContext LoadElm(DirectoryInfo elmDirectory,
#pragma warning restore RS0027 // API with optional parameter(s) should have the most parameters amongst its public overloads
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

        public static AssemblyLoadContext LoadElm(DirectoryInfo elmDirectory,
            string lib,
            string version,
            ILoggerFactory logFactory,
            int cacheSize)
        {
            var elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{lib}-{version}.json"));
            if (!elmFile.Exists)
                elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{lib}.json"));
            if (!elmFile.Exists)
                throw new ArgumentException($"Cannot find a matching ELM file for {lib} version {version} in {elmDirectory.FullName}", nameof(lib));
            var library = Elm.Library.LoadFromJson(elmFile)
                ?? throw new InvalidOperationException($"File {elmFile.FullName} is not a valid ELM package.");
            var dependencies = Elm.Library
                .GetIncludedLibraries(library, elmDirectory)
                .Packages()
                .ToArray();

            var typeResolver = new FhirTypeResolver(ModelInfo.ModelInspector);
            FhirTypeConverter.InitializeCache(cacheSize);
            var typeConverter = FhirTypeConverter.Default;
            var typeManager = new TypeManager(typeResolver);
            var operatorBinding = new CqlOperatorsBinding(typeResolver, typeConverter);
            var compiler = new AssemblyCompiler(typeResolver, typeManager, operatorBinding);

            var assemblyData = compiler.Compile(dependencies,
                logFactory);

            var asmContext = new AssemblyLoadContext($"{lib}-{version}");
            foreach (var kvp in assemblyData)
            {
                var assemblyBytes = kvp.Value.Binary;
                using var ms = new MemoryStream(assemblyBytes);
                asmContext.LoadFromStream(ms);
            }
            return asmContext;
        }

        internal IEnumerable<Resource> PackageResources(DirectoryInfo elmDirectory,
            DirectoryInfo cqlDirectory,
            DirectedGraph packageGraph,
            TypeResolver typeResolver,
            OperatorBinding operatorBinding,
            TypeManager typeManager,
            Func<Resource, string> canon,
            ILoggerFactory logFactory)
        {
            var builderLogger = logFactory.CreateLogger<ExpressionBuilder>();
            var codeWriterLogger = logFactory.CreateLogger<CSharpSourceCodeWriter>();

            var elmLibraries = packageGraph.Nodes.Values
                .Select(node => node.Properties?[elm.Library.LibraryNodeProperty] as elm.Library)
                .OfType<elm.Library>()
                // Processing this deterministically to reduce different exceptions when running this repeatedly
                .OrderBy(lib => lib.NameAndVersion)
                .ToArray();

            var all = new DefinitionDictionary<LambdaExpression>();
            foreach (var library in elmLibraries)
            {
                builderLogger.LogInformation($"Building expressions for {library.NameAndVersion}");
                var builder = new ExpressionBuilder(operatorBinding, typeManager, library!, builderLogger, new(false));
                var expressions = builder.Build();
                all.Merge(expressions);
            }
            var scw = new CSharpSourceCodeWriter(codeWriterLogger);
            foreach (var @using in typeResolver.ModelNamespaces)
                scw.Usings.Add(@using);
            foreach (var alias in typeResolver.Aliases)
                scw.AliasedUsings.Add(alias);

            var navToLibraryStream = new Dictionary<string, Stream>();
            var compiler = new AssemblyCompiler(typeResolver, typeManager, operatorBinding);
            var assemblies = compiler.Compile(elmLibraries, logFactory);
            var libraries = new Dictionary<string, Library>();
            var typeCrosswalk = new CqlTypeToFhirTypeMapper(typeResolver);
            foreach (var library in elmLibraries)
            {
                var elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{library.NameAndVersion}.json"));
                if (!elmFile.Exists)
                    elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{library.identifier?.id ?? string.Empty}.json"));
                if (!elmFile.Exists)
                    throw new InvalidOperationException($"Cannot find ELM file for {library.NameAndVersion}");
                var cqlFiles = cqlDirectory.GetFiles($"{library.NameAndVersion}.cql", SearchOption.AllDirectories);
                if (cqlFiles.Length == 0)
                {
                    cqlFiles = cqlDirectory.GetFiles($"{library.identifier!.id}.cql", SearchOption.AllDirectories);
                    if (cqlFiles.Length == 0)
                        throw new InvalidOperationException($"{library.identifier!.id}.cql");
                }
                if (cqlFiles.Length > 1)
                    throw new InvalidOperationException($"More than 1 CQL file found.");
                var cqlFile = cqlFiles[0];
                if (library.NameAndVersion is null)
                    throw new InvalidOperationException("Library NameAndVersion should not be null.");
                if (!assemblies.TryGetValue(library.NameAndVersion, out var assembly))
                    throw new InvalidOperationException($"No assembly for {library.NameAndVersion}");
                var builder = new ExpressionBuilder(operatorBinding, typeManager, library, builderLogger, new(false));
                var fhirLibrary = createLibraryResource(elmFile, cqlFile, assembly, typeCrosswalk, canon, library);
                libraries.Add(library.NameAndVersion, fhirLibrary);
            }

            var resources = new List<Resource>();
            resources.AddRange(libraries.Values);

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

            foreach (var library in elmLibraries)
            {
                var elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{library.NameAndVersion}.json"));
                foreach (var def in library.statements ?? Enumerable.Empty<Hl7.Cql.Elm.ExpressionDef>())
                {
                    if (def.annotation != null)
                    {
                        var tags = new List<Tag>();
                        foreach (var a in def.annotation.OfType<Elm.Annotation>())
                        {
                            if (a.t != null)
                            {
                                foreach (var t in a.t)
                                {
                                    if (t != null)
                                        tags.Add(t);
                                }
                            }
                        }
                        var measureAnnotation = tags
                            .SingleOrDefault(t => t?.name == "measure");
                        var yearAnnotation = tags
                            .SingleOrDefault(t => t?.name == "year");
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
                            measure.Date = new DateTimeIso8601(elmFile.LastWriteTimeUtc, Iso8601.DateTimePrecision.Millisecond)
                                .ToString();
                            measure.EffectivePeriod = new Period
                            {
                                Start = new DateTimeIso8601(measureYear, 1, 1, 0, 0, 0, 0, 0, 0).ToString(),
                                End = new DateTimeIso8601(measureYear, 12, 31, 23, 59, 59, 999, 0, 0).ToString(),
                            };
                            measure.Group = new List<Measure.GroupComponent>();
                            measure.Url = canon(measure)!;
                            if (library.NameAndVersion is null)
                                throw new InvalidOperationException("Library NameAndVersion should not be null.");
                            if (!libraries.TryGetValue(library.NameAndVersion, out var libForMeasure) || libForMeasure is null)
                                throw new InvalidOperationException($"We didn't create a measure for library {libForMeasure}");
                            measure.Library = new List<string> { libForMeasure!.Url };
                            resources.Add(measure);
                        }
                    }
                }
            }

            return resources;
        }

        private Hl7.Fhir.Model.Library createLibraryResource(FileInfo elmFile,
            FileInfo? cqlFile,
            AssemblyData assembly,
            CqlTypeToFhirTypeMapper typeCrosswalk,
            Func<Resource, string> canon,
            elm.Library? elmLibrary = null)
        {
            if (elmFile.Exists)
            {
                if (elmLibrary is null)
                {
                    elmLibrary = elm.Library.LoadFromJson(elmFile);
                    if (elmLibrary is null)
                        throw new ArgumentException($"File at {elmFile.FullName} is not valid ELM");
                }
                var bytes = File.ReadAllBytes(elmFile.FullName);
                var attachment = new Attachment
                {
                    ElementId = $"{elmLibrary.NameAndVersion}+elm",
                    ContentType = elm.Library.JsonMimeType,
                    Data = bytes,
                };
                var library = new Hl7.Fhir.Model.Library();
                library.Content.Add(attachment);
                library.Type = LogicLibraryCodeableConcept;
                string libraryId = $"{elmLibrary!.NameAndVersion}";
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
                foreach (var valueSet in elmLibrary.valueSets ?? Enumerable.Empty<elm.ValueSetDef>())
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

                foreach (var include in elmLibrary?.includes ?? Enumerable.Empty<elm.IncludeDef>())
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
                        ElementId = $"{elmLibrary!.NameAndVersion}+cql",
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
                        ElementId = $"{elmLibrary!.NameAndVersion}+dll",
                        ContentType = "application/octet-stream",
                        Data = assemblyBytes,
                    };
                    library.Content.Add(assemblyAttachment);
                    foreach (var kvp in assembly.SourceCode)
                    {
                        var sourceBytes = Encoding.UTF8.GetBytes(kvp.Value);
                        var sourceBase64 = System.Convert.ToBase64String(sourceBytes);
                        var sourceAttachment = new Attachment
                        {
                            ElementId = $"{kvp.Key}+csharp",
                            ContentType = "text/plain",
                            Data = sourceBytes,
                        };
                        library.Content.Add(sourceAttachment);
                    }

                }
                library.Url = canon(library)!;
                return library;
            }
            else throw new ArgumentException($"Couldn't find library {elmFile.FullName}", nameof(elmFile));
        }

        private static readonly CodeableConcept LogicLibraryCodeableConcept = new CodeableConcept
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

        internal TypeConverter TypeConverter { get; }

        private ParameterDefinition ElmParameterToFhir(Hl7.Cql.Elm.ParameterDef elmParameter,
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

        private ParameterDefinition ElmDefinitionToParameter(Hl7.Cql.Elm.ExpressionDef definition,
            CqlTypeToFhirTypeMapper typeCrosswalk)
        {
            var resultTypeSpecifier = definition.resultTypeSpecifier;
            if (resultTypeSpecifier is null && !string.IsNullOrWhiteSpace(definition.resultTypeName.Name))
                resultTypeSpecifier = new Hl7.Cql.Elm.NamedTypeSpecifier
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

            if (definition.accessLevel == elm.AccessModifier.Private)
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
}
