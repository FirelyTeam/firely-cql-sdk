using Hl7.Cql.Elm;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Packaging;

internal static class FhirLibraryExtensions
{
    /// <summary>
    /// Gets the content type for a given attachment suffix.
    /// </summary>
    private static string GetContentTypeForSuffix(string suffix) => suffix switch
    {
        Constants.ElementIdSuffixes.Cql    => Constants.ContentMimeTypes.Cql,
        Constants.ElementIdSuffixes.Elm    => Constants.ContentMimeTypes.Elm,
        Constants.ElementIdSuffixes.CSharp => Constants.ContentMimeTypes.CSharp,
        Constants.ElementIdSuffixes.Dll    => Constants.ContentMimeTypes.Binary,
        Constants.ElementIdSuffixes.Pdb    => Constants.ContentMimeTypes.Binary,
        _                                   => throw new ArgumentException($"Unknown suffix: {suffix}", nameof(suffix))
    };

    extension(FhirLibrary)
    {
        /// <summary>
        /// Reads and deserializes a FHIR Library resource from JSON string.
        /// </summary>
        public static FhirLibrary ReadLibraryFromJson(string json)
        {
            var lib = JsonSerializer.Deserialize<FhirLibrary>(json, JsonSerializerOptions.ForFhir)
                      ?? throw new InvalidOperationException("Failed to deserialize FHIR library from JSON.");
            return lib;
        }

        public static FhirLibrary Create(
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

        public static FhirLibrary Create(
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
                    elmLibrary = ElmLibrary.ParseFromJson(Encoding.UTF8.GetString(elmBytes));
                    break;
                case (not null, null):
                    elmBytes = Encoding.UTF8.GetBytes(elmLibrary.SerializeToJson(true));
                    break;
            }

            var fhirLibrary = FhirLibrary.Create(elmLibrary, resourceCanonicalBuilder, elmFileLastWriteTimeUtc ?? SysDateTime.Now);

            fhirLibrary.Content.Add(CreateElmAttachment(elmLibrary.VersionedLibraryIdentifier, elmBytes));

            var parameters = new List<ParameterDefinition>();
            AddInParameters(elmLibrary, parameters, typeCrosswalk);
            AddOutParameters(elmLibrary, parameters, typeCrosswalk);
            fhirLibrary.Parameter = parameters.Count > 0 ? parameters : null!;

            fhirLibrary.AddRelatedArtefacts(elmLibrary, elmLibrarySet, resourceCanonicalBuilder);
            fhirLibrary.AddDataRequirements(elmLibrary, elmLibrarySet);
            fhirLibrary.SetCqlOptionsParameterAndExtension(elmLibrary);

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
    }

    extension(FhirLibrary fhirLibrary)
    {
        /// <summary>
        /// Serializes a FHIR Library resource to JSON string.
        /// </summary>
        public string WriteLibraryToJson(bool pretty = false) =>
            JsonSerializer.Serialize(fhirLibrary, pretty ? JsonSerializerOptions.ForFhirPretty : JsonSerializerOptions.ForFhir);


        public void SetCqlOptionsParameterAndExtension(
            ElmLibrary elmLibrary)
        {
            var fhirParameters = CreateFhirParameters(elmLibrary);
            if (!fhirParameters.Any())
                return;

            // Add or replace CQL Options as a contained resource
            // See: https://build.fhir.org/domainresource-definitions.html#DomainResource.contained

            // Ensure Contained collection is initialized
            fhirLibrary.Contained ??= [];

            // Find and remove existing options parameter
            var existingParameter =
                fhirLibrary.Contained.OfType<Parameters>().FirstOrDefault(p => p.Id == "options");
            if (existingParameter != null)
            {
                fhirLibrary.Contained.Remove(existingParameter);
            }

            // Now add new options parameter
            var optionsParameter = new Parameters();
            optionsParameter.Id = "options";
            optionsParameter.Parameter.AddRange(fhirParameters);
            fhirLibrary.Contained.Add(optionsParameter);

            // Add and replace existing CQL options extension, or add new one

            // See requirement for Contained resources: https://build.fhir.org/domainresource.html#invs
            // dom-3: If the resource is contained in another resource,
            //        it SHALL be referred to from elsewhere in the resource
            //        or SHALL refer to the containing resource
            //
            // This is done by adding an extension. (Example: https://build.fhir.org/ig/HL7/cql-ig/Library-CQLExample.json.html)

            // Find and remove existing options extension
            var existingExtension = fhirLibrary.Extension.FirstOrDefault(e => e.Url == Constants.Hl7FhirStructureDefinitionCqlOptions);
            if (existingExtension != null)
            {
                fhirLibrary.Extension.Remove(existingExtension);
            }

            // Now add new options extensions
            var optionsExtension = new Extension
            {
                Url = Constants.Hl7FhirStructureDefinitionCqlOptions,
                Value = new ResourceReference { Reference = "#options" },
            };
            fhirLibrary.Extension.Add(optionsExtension);
        }

        private void AddDataRequirements(
            ElmLibrary elmLibrary,
            ElmLibrarySet elmLibrarySet)
        {
            // Analyze datarequirements and add to the FHIR Library resource.
            var dataRequirementsAnalyzer = new DataRequirementsAnalyzer(elmLibrarySet, elmLibrary);
            var dataRequirements = dataRequirementsAnalyzer.Analyze();
            fhirLibrary.DataRequirement.AddRange(dataRequirements);
            fhirLibrary.DataRequirement = fhirLibrary.DataRequirement
                                                     .OrderBy(dr => dr.Type)                                                  // Primary sorting by Type
                                                     .ThenBy(dr => dr.CodeFilter?.FirstOrDefault()?.ValueSet ?? string.Empty) // Secondary sorting by ValueSet
                                                     .ToList();
        }


        private void AddRelatedArtefacts(
            ElmLibrary elmLibrary,
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
                        Display = $"Library {include.path}",
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

            fhirLibrary.RelatedArtifact.AddRange(result);
            fhirLibrary.RelatedArtifact.Sort((x, y) => string.Compare(x.Display, y.Display ?? "", StringComparison.Ordinal));
        }

        /// <summary>
        /// Replaces or adds an attachment to a FHIR Library resource.
        /// The content type is automatically inferred from the elementIdSuffix.
        /// </summary>
        public void ReplaceOrAddAttachment(
            CqlVersionedLibraryIdentifier libraryIdentifier,
            string elementIdSuffix,
            byte[] data)
        {
            var attachmentId = $"{libraryIdentifier}{elementIdSuffix}";
            var contentType = GetContentTypeForSuffix(elementIdSuffix);

            // Ensure Content collection is initialized
            fhirLibrary.Content ??= [];

            // Find existing attachment with this ID
            var existingAttachment = fhirLibrary.Content.FirstOrDefault(a => a.ElementId != null && a.ElementId == attachmentId);

            if (existingAttachment != null)
            {
                // Replace existing attachment
                existingAttachment.ContentType = contentType;
                existingAttachment.Data = data;
            }
            else
            {
                // Add new attachment
                var newAttachment = new Attachment
                {
                    ElementId = attachmentId,
                    ContentType = contentType,
                    Data = data
                };
                fhirLibrary.Content.Add(newAttachment);
            }
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

    /// <summary>
    /// Creates an ELM attachment for a FHIR Library resource.
    /// </summary>
    public static Attachment CreateElmAttachment(CqlVersionedLibraryIdentifier libraryIdentifier, byte[] elmBytes) =>
        new()
        {
            ElementId = $"{libraryIdentifier}{Constants.ElementIdSuffixes.Elm}",
            ContentType = ElmLibrary.JsonMimeType,
            Data = elmBytes,
        };

    /// <summary>
    /// Creates a CQL attachment for a FHIR Library resource.
    /// </summary>
    public static Attachment CreateCqlAttachment(CqlVersionedLibraryIdentifier libraryIdentifier, byte[] cqlBytes) =>
        new()
        {
            ElementId = $"{libraryIdentifier}{Constants.ElementIdSuffixes.Cql}",
            ContentType = Constants.ContentMimeTypes.Cql,
            Data = cqlBytes,
        };

    /// <summary>
    /// Creates a C# source code attachment for a FHIR Library resource.
    /// </summary>
    public static Attachment CreateCSharpAttachment(KeyValuePair<string, string> kvp) =>
        new()
        {
            ElementId = $"{kvp.Key}{Constants.ElementIdSuffixes.CSharp}",
            ContentType = Constants.ContentMimeTypes.CSharp,
            Data = Encoding.UTF8.GetBytes(kvp.Value),
        };

    /// <summary>
    /// Creates a DLL attachment for a FHIR Library resource.
    /// </summary>
    public static Attachment CreateDllAttachment(CqlVersionedLibraryIdentifier libraryIdentifier, byte[] assemblyBytes) =>
        new()
        {
            ElementId = $"{libraryIdentifier}{Constants.ElementIdSuffixes.Dll}",
            ContentType = Constants.ContentMimeTypes.Binary,
            Data = assemblyBytes,
        };

    /// <summary>
    /// Creates a PDB attachment for a FHIR Library resource.
    /// </summary>
    public static Attachment CreatePdbAttachment(CqlVersionedLibraryIdentifier libraryIdentifier, byte[] debugSymbols) =>
        new()
        {
            ElementId = $"{libraryIdentifier}{Constants.ElementIdSuffixes.Pdb}",
            ContentType = Constants.ContentMimeTypes.Binary,
            Data = debugSymbols,
        };
}
