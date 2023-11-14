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
using Hl7.Cql.Primitives;
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
            TypeConverter = FhirTypeConverter.Create(ModelInfo.ModelInspector);
        }

        internal LibraryPackager(TypeConverter? typeConverter)
        {
            TypeConverter = typeConverter ?? FhirTypeConverter.Create(ModelInfo.ModelInspector);
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
          LogLevel logLevel = LogLevel.Error)
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

            return LoadElm(elmDirectory, lib, version, logFactory);
        }

        public static AssemblyLoadContext LoadElm(DirectoryInfo elmDirectory,
            string lib,
            string version,
            ILoggerFactory logFactory)
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
            var typeConverter = FhirTypeConverter.Create(ModelInfo.ModelInspector);
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

            var cqlLibraries = packageGraph.Nodes.Values
                .Select(node => node.Properties?[elm.Library.LibraryNodeProperty] as elm.Library)
                .Where(p => p is not null)
                .Select(p => p!)
                .ToArray();

            var all = new DefinitionDictionary<LambdaExpression>();
            var cqlLibraryDictionary = cqlLibraries.ToDictionary(lib => lib.NameAndVersion!);
            var scw = new CSharpSourceCodeWriter(codeWriterLogger);
            foreach (var @using in typeResolver.ModelNamespaces)
                scw.Usings.Add(@using);
            foreach (var alias in typeResolver.Aliases)
                scw.AliasedUsings.Add(alias);

            var navToLibraryStream = new Dictionary<string, Stream>();
            var compiler = new AssemblyCompiler(typeResolver, typeManager, operatorBinding);
            var assemblies = compiler.Compile(cqlLibraries, logFactory);
            var fhirLibraries = new Dictionary<string, Library>();
            var typeCrosswalk = new CqlTypeToFhirTypeMapper(typeResolver);
            foreach (var library in cqlLibraries)
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
                var builder = new ExpressionBuilder(operatorBinding,
                    typeManager,
                    library.NameAndVersion!,
                    cqlLibraryDictionary,
                    builderLogger);
                builderLogger.LogInformation($"Building expressions for {library.NameAndVersion}");
                var expressions = builder.Build();
                all.Merge(expressions);
                var fhirLibrary = createLibraryResource(elmFile, cqlFile, assembly, typeCrosswalk, builder, canon, library);
                fhirLibraries.Add(library.NameAndVersion, fhirLibrary);
            }

            var resources = new List<Resource>();
            resources.AddRange(fhirLibraries.Values);

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

            foreach (var library in cqlLibraries)
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
                            if (!fhirLibraries.TryGetValue(library.NameAndVersion, out var libForMeasure) || libForMeasure is null)
                                throw new InvalidOperationException($"We didn't create a measure for library {libForMeasure}");
                            measure.Library = new List<string> { libForMeasure!.Url };
                            resources.Add(measure);
                        }
                    }
                }
            }

            return resources;
        }

        private static readonly Dictionary<string, string> Populations = new Dictionary<string, string>
        {
            { "initial-population", "Initial Population" },
            { "numerator", "Numerator" },
            { "denominator", "Denominator" },
            { "denominator-exclusion", "Denominator Exclusion" }
        };

        private void DiscoverPopulations(Measure measure, Elm.Library library)
        {
            var defs = library.statements ?? Enumerable.Empty<Hl7.Cql.Elm.ExpressionDef>();
            foreach (var def in defs)
            {
                var annotations = (def.annotation?
                    .OfType<elm.Annotation>()
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
                                Code = CodeableConcept((rate, Constants.MeasureGroupCodeSystem)),
                                Description = $"Rate {tuple.Group}",
                            };
                            measure.Group!.Add(group);
                        }
                        else throw new InvalidOperationException($"Rate {rate} is defined twice for this measure.");

                        var pop = $"{rate}-{tuple.Population}";
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
                                Code = CodeableConcept((tuple.Population, Constants.MeasureGroupCodeSystem)),
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

        private CodeableConcept CodeableConcept(params (string code, string system)[] tuples) =>
            new CodeableConcept
            {
                Coding = tuples
                    .Select(t => new Coding { Code = t.code!, System = t.system! })
                    .ToList(),
            };
        private Hl7.Fhir.Model.Library createLibraryResource(FileInfo elmFile,
            FileInfo? cqlFile,
            AssemblyData assembly,
            CqlTypeToFhirTypeMapper typeCrosswalk,
            ExpressionBuilder builder,
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
                    .Select(pd => ElmParameterToFhir(pd, typeCrosswalk, builder));
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

        private static CqlContext GetNewCqlContext() => FhirCqlContext.WithDataSource();

        internal TypeConverter TypeConverter { get; }

        private ParameterDefinition ElmParameterToFhir(Hl7.Cql.Elm.ParameterDef elmParameter,
            CqlTypeToFhirTypeMapper typeCrosswalk,
            ExpressionBuilder builder)
        {
            var typeSpecifier = elmParameter.resultTypeSpecifier ?? elmParameter.parameterTypeSpecifier;
            if (typeSpecifier is null)
                throw new ArgumentException($"{typeSpecifier} is missing on parameter: {elmParameter.name}", nameof(elmParameter));
            var type = typeCrosswalk.TypeEntryFor(typeSpecifier);
            if (type is null || type.FhirType is null)
                throw new ArgumentException($"Unable to identify a valid FHIR type for this parameter.", nameof(elmParameter));

            var cqlTypeExtensions = new List<Extension> {
                new Extension()
                {
                    Url = Constants.ParameterCqlType,
                    Value = new FhirString(type.CqlType!.ToString())
                }
            };

            if (type.ElementType is not null)
            {
                cqlTypeExtensions.Add(new Extension()
                {
                    Url = Constants.ParameterCqlElementType,
                    Value = new FhirString(type.ElementType.CqlType!.ToString())
                });
            }

            if (elmParameter.@default is not null)
            {
                var typeEntry = typeCrosswalk.TypeEntryFor(elmParameter.@default);
                if (typeEntry != null)
                {
                    var lambda = builder.Lambda(elmParameter.@default);
                    var func = lambda.Compile();
                    var value = func.DynamicInvoke(GetNewCqlContext());
                    AddDefaultValueToExtensions(cqlTypeExtensions, value, typeEntry);
                }
            }

            var annotations = (elmParameter.annotation?
                .OfType<Elm.Annotation>()
                .SelectMany(a => a.t ?? Enumerable.Empty<Tag>())
                ?? Enumerable.Empty<Tag>())
                .ToArray();

            if (annotations.Length > 0)
            {
                var uris = annotations
                    .Where(t => t.name == "uri")
                    .ToArray();

                foreach (var uri in uris)
                {
                    cqlTypeExtensions.Add(new Extension()
                    {
                        Url = Constants.ParameterCanonicalUri,
                        Value = new FhirString(uri.value)
                    });
                }
            }

            var parameterDefinition = new ParameterDefinition
            {
                Name = elmParameter.name!,
                Use = OperationParameterUse.In,
                Min = elmParameter.@default is null ? 1 : 0,
                Max = "1"!,
                Type = type.FhirType,
                Extension = cqlTypeExtensions,
            };
            return parameterDefinition;
        }

        private static CqlDate ConvertExpressionToDate(Hl7.Cql.Elm.ParameterDef parameterDef,
            Hl7.Cql.Elm.Date defaultDateValue)
        {
            var yearExpr = defaultDateValue.year ?? throw new InvalidOperationException($"Date expressions must have a year value on parameter: {parameterDef.name}");
            var monthExpr = defaultDateValue.month ?? throw new InvalidOperationException($"Date expressions must have a month value on parameter: {parameterDef.name}");
            var dayExpr = defaultDateValue.day ?? throw new InvalidOperationException($"Date expressions must have a day value on parameter: {parameterDef.name}");

            int year = ConvertExpressionToLiteral<int>(parameterDef, yearExpr, "year");
            int month = ConvertExpressionToLiteral<int>(parameterDef, monthExpr, "month");
            int day = ConvertExpressionToLiteral<int>(parameterDef, dayExpr, "day");

            var dateValue = new CqlDate(year, month, day);
            return dateValue;
        }

        private static T ConvertExpressionToLiteral<T>(ParameterDef elmParameter,
            Hl7.Cql.Elm.Expression expr, string name)
        {
            T val;
            if (expr is Literal literal)
            {
                var (literalValue, _) = ExpressionBuilder.ConvertLiteral(literal, typeof(T));
                if (literalValue is T)
                {
                    val = (T)literalValue!;
                    if (val is null)
                    {
                        throw new InvalidOperationException($"Parameter '{elmParameter.name}' {name} value was null");
                    }
                }
                else throw new InvalidOperationException($"Parameter '{elmParameter.name}' could not convert {name} value to int literal");
            }
            else throw new InvalidOperationException($"Parameter '{elmParameter.name}' must have a literal '{name}' expresssion");
            return val;
        }


        private void AddDefaultValueToExtensions(List<Extension> cqlTypeExtensions, object? value, CqlTypeToFhirMapping defaultType)
        {
            if (defaultType.FhirType != null)
            {
                var defaultValueExt = new Extension()
                {
                    Url = Constants.ParameterCqlDefaultValue
                };
                MapValueToExtension(defaultValueExt, value, defaultType);
                cqlTypeExtensions.Add(defaultValueExt);

                cqlTypeExtensions.Add(new Extension()
                {
                    Url = Constants.ParameterCqlDefaultValueType,
                    Value = new Code<FHIRAllTypes>(defaultType.FhirType),
                });
            }
        }

        private void MapValueToExtension(Extension ext, object? value, CqlTypeToFhirMapping mappedType)
        {
            switch (mappedType.FhirType)
            {
                case FHIRAllTypes.Boolean:
                    ext.Value = new FhirBoolean(value as bool?);
                    break;
                case FHIRAllTypes.Integer:
                    ext.Value = new Integer(value as int?);
                    break;
                case FHIRAllTypes.Decimal:
                    ext.Value = new FhirDecimal(value as decimal?);
                    break;
                case FHIRAllTypes.String:
                    ext.Value = new FhirString(value as string);
                    break;
                case FHIRAllTypes.Date:
                    ext.Value = TypeConverter.Convert<Hl7.Fhir.Model.Date>(value);
                    break;
                case FHIRAllTypes.DateTime:
                    ext.Value = TypeConverter.Convert<FhirDateTime>(value);
                    break;
                case FHIRAllTypes.Time:
                    ext.Value = TypeConverter.Convert<Hl7.Fhir.Model.Time>(value);
                    break;
                case FHIRAllTypes.Quantity:
                    ext.Value = TypeConverter.Convert<Hl7.Fhir.Model.Quantity>(value);
                    break;
                case FHIRAllTypes.Range:
                    ext.Value = TypeConverter.Convert<Hl7.Fhir.Model.Range>(value);
                    break;
                case FHIRAllTypes.Ratio:
                    ext.Value = TypeConverter.Convert<Hl7.Fhir.Model.Ratio>(value);
                    break;
                case FHIRAllTypes.Period:
                    ext.Value = TypeConverter.Convert<Period>(value);
                    break;
                default:
                    throw new InvalidOperationException($"Type '{mappedType.FhirType}' is not supported for Extension mappings");
            }
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

        private static void EnsureDirectory(DirectoryInfo directory, int timeoutMs = 5000)
        {
            var now = System.DateTime.Now;
            var loop = true;
            var timeout = TimeSpan.FromMilliseconds(timeoutMs);
            while (!directory.Exists && loop)
            {
                directory.Create();
                directory.Refresh();
                if (System.DateTime.Now.Subtract(now) > timeout)
                    throw new InvalidOperationException($"Unable to create directory {directory.FullName} after {timeout}");
            }
        }

    }
}
