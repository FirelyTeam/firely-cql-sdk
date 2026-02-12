using Hl7.Cql.Elm;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Packaging;

internal static class FhirLibraryExtensions
{
    /// <summary>
    /// Gets the content type for a given attachment suffix.
    /// </summary>
    private static string GetContentTypeForSuffix(string suffix) => suffix switch
    {
        "+cql"    => "text/cql",
        "+elm"    => "application/elm+json",
        "+csharp" => "text/plain",
        "+dll"    => "application/octet-stream",
        "+pdb"    => "application/octet-stream",
        _         => throw new ArgumentException($"Unknown suffix: {suffix}", nameof(suffix))
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
    }

    extension(FhirLibrary fhirLibrary)
    {
        /// <summary>
        /// Serializes a FHIR Library resource to JSON string.
        /// </summary>
        public string WriteLibraryToJson(bool pretty = false) =>
            JsonSerializer.Serialize(fhirLibrary, pretty ? JsonSerializerOptions.ForFhirPretty : JsonSerializerOptions.ForFhir);


        public void AddDataRequirements(
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


        public void AddRelatedArtefacts(
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

            fhirLibrary.RelatedArtifact.AddRange(result);
            fhirLibrary.RelatedArtifact.Sort((x, y) => string.Compare(x.Display, y.Display ?? "", StringComparison.Ordinal));
        }

        public void AddCqlOptions(
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
}