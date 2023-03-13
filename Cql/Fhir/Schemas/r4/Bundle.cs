using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ncqa.Fhir.Schemas.r4
{
    public partial class Bundle
    {
        [JsonProperty("resourceType")]
        public string? ResourceType { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("meta")]
        public Meta? Meta { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("entry")]
        public Entry[]? Entry { get; set; }
    }

    public partial class Entry
    {
        [JsonProperty("fullUrl")]
        public Uri? FullUrl { get; set; }

        [JsonProperty("resource")]
        public EntryResource? Resource { get; set; }
    }

    public partial class EntryResource
    {
        [JsonProperty("resourceType")]
        public string? ResourceType { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("meta")]
        public Meta? Meta { get; set; }

        [JsonProperty("text")]
        public Text? Text { get; set; }

        [JsonProperty("url")]
        public Uri? Url { get; set; }

        [JsonProperty("version")]
        public Version? Version { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("experimental", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Experimental { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("publisher")]
        public string? Publisher { get; set; }

        [JsonProperty("contact")]
        public Contact[]? Contact { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string? Kind { get; set; }

        [JsonProperty("software", NullValueHandling = NullValueHandling.Ignore)]
        public Software? Software { get; set; }

        [JsonProperty("fhirVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string? FhirVersion { get; set; }

        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string[]? Format { get; set; }

        [JsonProperty("rest", NullValueHandling = NullValueHandling.Ignore)]
        public Rest[]? Rest { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string? Code { get; set; }

        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Search { get; set; }

        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
        public ElementExtension[]? Extension { get; set; }

        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string? Comment { get; set; }

        [JsonProperty("system", NullValueHandling = NullValueHandling.Ignore)]
        public bool? System { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; }

        [JsonProperty("instance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Instance { get; set; }

        [JsonProperty("parameter", NullValueHandling = NullValueHandling.Ignore)]
        public Parameter[]? Parameter { get; set; }

        [JsonProperty("mapping", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceMapping[]? Mapping { get; set; }

        [JsonProperty("abstract", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Abstract { get; set; }

        [JsonProperty("snapshot", NullValueHandling = NullValueHandling.Ignore)]
        public Snapshot? Snapshot { get; set; }

        [JsonProperty("differential", NullValueHandling = NullValueHandling.Ignore)]
        public Differential? Differential { get; set; }

        [JsonProperty("baseDefinition", NullValueHandling = NullValueHandling.Ignore)]
        public Uri? BaseDefinition { get; set; }

        [JsonProperty("derivation", NullValueHandling = NullValueHandling.Ignore)]
        public string? Derivation { get; set; }


        [JsonProperty("purpose", NullValueHandling = NullValueHandling.Ignore)]
        public string? Purpose { get; set; }
    }

    public partial class BaseDefinitionExtension
    {
        [JsonProperty("url")]
        public Uri? Url { get; set; }

        [JsonProperty("valueString")]
        public string? ValueString { get; set; }
    }

    public partial class Contact
    {
        [JsonProperty("telecom")]
        public Telecom[]? Telecom { get; set; }
    }

    public partial class Telecom
    {
        [JsonProperty("system")]
        public string? System { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }
    }

    public partial class Differential
    {
        [JsonProperty("element")]
        public DifferentialElement[]? Element { get; set; }
    }

    public partial class DifferentialElement
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("path")]
        public string? Path { get; set; }

        [JsonProperty("short")]
        public string? Short { get; set; }

        [JsonProperty("definition")]
        public string? Definition { get; set; }

        [JsonProperty("min")]
        public long Min { get; set; }

        [JsonProperty("max")]
        public string? Max { get; set; }

        [JsonProperty("mapping", NullValueHandling = NullValueHandling.Ignore)]
        public ElementMapping[]? Mapping { get; set; }

        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string? Comment { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement[]? Type { get; set; }

        [JsonProperty("isSummary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSummary { get; set; }

        [JsonProperty("isModifier", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsModifier { get; set; }

        [JsonProperty("isModifierReason", NullValueHandling = NullValueHandling.Ignore)]
        public string? IsModifierReason { get; set; }

        [JsonProperty("binding", NullValueHandling = NullValueHandling.Ignore)]
        public ElementBinding? Binding { get; set; }

        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string[]? Alias { get; set; }

        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
        public ElementExtension[]? Extension { get; set; }

        [JsonProperty("constraint", NullValueHandling = NullValueHandling.Ignore)]
        public Constraint[]? Constraint { get; set; }

        [JsonProperty("requirements", NullValueHandling = NullValueHandling.Ignore)]
        public string? Requirements { get; set; }

        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public string[]? Condition { get; set; }

        [JsonProperty("meaningWhenMissing", NullValueHandling = NullValueHandling.Ignore)]
        public string? MeaningWhenMissing { get; set; }

        [JsonProperty("orderMeaning", NullValueHandling = NullValueHandling.Ignore)]
        public string? OrderMeaning { get; set; }

        [JsonProperty("contentReference", NullValueHandling = NullValueHandling.Ignore)]
        public string? ContentReference { get; set; }

        [JsonProperty("example", NullValueHandling = NullValueHandling.Ignore)]
        public Example[]? Example { get; set; }

        [JsonProperty("slicing", NullValueHandling = NullValueHandling.Ignore)]
        public Slicing? Slicing { get; set; }
    }

    public partial class ElementBinding
    {
        [JsonProperty("extension")]
        public BindingExtension[]? Extension { get; set; }

        [JsonProperty("strength")]
        public string? Strength { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; }

        [JsonProperty("valueSet", NullValueHandling = NullValueHandling.Ignore)]
        public Uri? ValueSet { get; set; }
    }

    public partial class BindingExtension
    {
        [JsonProperty("url")]
        public Uri? Url { get; set; }

        [JsonProperty("valueCanonical", NullValueHandling = NullValueHandling.Ignore)]
        public Uri? ValueCanonical { get; set; }

        [JsonProperty("valueString", NullValueHandling = NullValueHandling.Ignore)]
        public string? ValueString { get; set; }

        [JsonProperty("valueBoolean", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValueBoolean { get; set; }
    }

    public partial class Constraint
    {
        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("severity")]
        public string? Severity { get; set; }

        [JsonProperty("human")]
        public string? Human { get; set; }

        [JsonProperty("expression")]
        public string? Expression { get; set; }

        [JsonProperty("xpath")]
        public string? Xpath { get; set; }

        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
        public ConstraintExtension[]? Extension { get; set; }

        [JsonProperty("requirements", NullValueHandling = NullValueHandling.Ignore)]
        public string? Requirements { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public Uri? Source { get; set; }
    }

    public partial class ConstraintExtension
    {
        [JsonProperty("url")]
        public Uri? Url { get; set; }

        [JsonProperty("valueBoolean", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValueBoolean { get; set; }

        [JsonProperty("valueMarkdown", NullValueHandling = NullValueHandling.Ignore)]
        public string? ValueMarkdown { get; set; }
    }

    public partial class Example
    {
        [JsonProperty("label")]
        public string? Label { get; set; }

        [JsonProperty("valueIdentifier", NullValueHandling = NullValueHandling.Ignore)]
        public Telecom? ValueIdentifier { get; set; }

        [JsonProperty("valueDateTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ValueDateTime { get; set; }

        [JsonProperty("valueId", NullValueHandling = NullValueHandling.Ignore)]
        public string? ValueId { get; set; }

        [JsonProperty("valueUnsignedInt", NullValueHandling = NullValueHandling.Ignore)]
        public long? ValueUnsignedInt { get; set; }

        [JsonProperty("valueString", NullValueHandling = NullValueHandling.Ignore)]
        public string? ValueString { get; set; }

        [JsonProperty("valueCode", NullValueHandling = NullValueHandling.Ignore)]
        public string? ValueCode { get; set; }

        [JsonProperty("valueBoolean", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValueBoolean { get; set; }
    }

    public partial class ElementExtension
    {
        [JsonProperty("url")]
        public Uri? Url { get; set; }

        [JsonProperty("valueString", NullValueHandling = NullValueHandling.Ignore)]
        public string? ValueString { get; set; }

        [JsonProperty("valueCode", NullValueHandling = NullValueHandling.Ignore)]
        public string? ValueCode { get; set; }

        [JsonProperty("valueInteger", NullValueHandling = NullValueHandling.Ignore)]
        public long? ValueInteger { get; set; }
    }

    public partial class ElementMapping
    {
        [JsonProperty("identity")]
        public string? Identity { get; set; }

        [JsonProperty("map")]
        public string? Map { get; set; }
    }

    public partial class Slicing
    {
        [JsonProperty("discriminator")]
        public Discriminator[]? Discriminator { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("rules")]
        public string? Rules { get; set; }
    }

    public partial class Discriminator
    {
        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("path")]
        public string? Path { get; set; }
    }

    public partial class TypeElement
    {
        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
        public TypeExtension[]? Extension { get; set; }

        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("targetProfile", NullValueHandling = NullValueHandling.Ignore)]
        public Uri[]? TargetProfile { get; set; }

        [JsonProperty("profile", NullValueHandling = NullValueHandling.Ignore)]
        public Uri[]? Profile { get; set; }
    }

    public partial class TypeExtension
    {
        [JsonProperty("url")]
        public Uri? Url { get; set; }

        [JsonProperty("valueUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string? ValueUrl { get; set; }

        [JsonProperty("valueBoolean", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValueBoolean { get; set; }
    }

    public partial class ResourceMapping
    {
        [JsonProperty("identity")]
        public string? Identity { get; set; }

        [JsonProperty("uri")]
        public Uri? Uri { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }

    public partial class Meta
    {
        [JsonProperty("lastUpdated")]
        public DateTimeOffset LastUpdated { get; set; }
    }

    public partial class Parameter
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("use")]
        public string? Use { get; set; }

        [JsonProperty("min")]
        public long Min { get; set; }

        [JsonProperty("max")]
        public string? Max { get; set; }

        [JsonProperty("documentation", NullValueHandling = NullValueHandling.Ignore)]
        public string? Documentation { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; }

        [JsonProperty("searchType", NullValueHandling = NullValueHandling.Ignore)]
        public string? SearchType { get; set; }

        [JsonProperty("targetProfile", NullValueHandling = NullValueHandling.Ignore)]
        public Uri[]? TargetProfile { get; set; }

        [JsonProperty("part", NullValueHandling = NullValueHandling.Ignore)]
        public Part[]? Part { get; set; }

        [JsonProperty("binding", NullValueHandling = NullValueHandling.Ignore)]
        public ParameterBinding? Binding { get; set; }
    }

    public partial class ParameterBinding
    {
        [JsonProperty("strength")]
        public string? Strength { get; set; }

        [JsonProperty("valueSet")]
        public Uri? ValueSet { get; set; }
    }

    public partial class Part
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("use")]
        public string? Use { get; set; }

        [JsonProperty("min")]
        public long Min { get; set; }

        [JsonProperty("max")]
        public string? Max { get; set; }

        [JsonProperty("documentation")]
        public string? Documentation { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; }

        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
        public PartExtension[]? Extension { get; set; }

        [JsonProperty("part", NullValueHandling = NullValueHandling.Ignore)]
        public Part[]? PartPart { get; set; }
    }

    public partial class PartExtension
    {
        [JsonProperty("url")]
        public Uri? Url { get; set; }

        [JsonProperty("valueUri")]
        public string? ValueUri { get; set; }
    }

    public partial class ResourceResourceClass
    {
        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("param", NullValueHandling = NullValueHandling.Ignore)]
        public string[]? Param { get; set; }
    }

    public partial class Rest
    {
        [JsonProperty("mode")]
        public string? Mode { get; set; }

        [JsonProperty("documentation")]
        public string? Documentation { get; set; }

        [JsonProperty("security")]
        public Security? Security { get; set; }

        [JsonProperty("resource")]
        public RestResource[]? Resource { get; set; }

        [JsonProperty("interaction", NullValueHandling = NullValueHandling.Ignore)]
        public Interaction[]? Interaction { get; set; }

        [JsonProperty("searchParam", NullValueHandling = NullValueHandling.Ignore)]
        public SearchParam[]? SearchParam { get; set; }

        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public Operation[]? Operation { get; set; }
    }

    public partial class Interaction
    {
        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("documentation")]
        public string? Documentation { get; set; }
    }

    public partial class Operation
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("definition")]
        public Uri? Definition { get; set; }
    }

    public partial class RestResource
    {
        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("profile", NullValueHandling = NullValueHandling.Ignore)]
        public Uri? Profile { get; set; }

        [JsonProperty("interaction")]
        public Interaction[]? Interaction { get; set; }

        [JsonProperty("conditionalCreate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConditionalCreate { get; set; }

        [JsonProperty("conditionalUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConditionalUpdate { get; set; }

        [JsonProperty("conditionalDelete", NullValueHandling = NullValueHandling.Ignore)]
        public string? ConditionalDelete { get; set; }

        [JsonProperty("referencePolicy", NullValueHandling = NullValueHandling.Ignore)]
        public string[]? ReferencePolicy { get; set; }

        [JsonProperty("searchInclude", NullValueHandling = NullValueHandling.Ignore)]
        public string[]? SearchInclude { get; set; }

        [JsonProperty("searchRevInclude", NullValueHandling = NullValueHandling.Ignore)]
        public string[]? SearchRevInclude { get; set; }

        [JsonProperty("searchParam", NullValueHandling = NullValueHandling.Ignore)]
        public SearchParam[]? SearchParam { get; set; }
    }

    public partial class SearchParam
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("definition")]
        public Uri? Definition { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("documentation")]
        public string? Documentation { get; set; }
    }

    public partial class Security
    {
        [JsonProperty("cors")]
        public bool Cors { get; set; }

        [JsonProperty("service")]
        public Service[]? Service { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }
    }

    public partial class Service
    {
        [JsonProperty("coding")]
        public Coding[]? Coding { get; set; }

        [JsonProperty("text")]
        public string? Text { get; set; }
    }

    public partial class Coding
    {
        [JsonProperty("system")]
        public Uri? System { get; set; }

        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("display")]
        public string? Display { get; set; }
    }

    public partial class Snapshot
    {
        [JsonProperty("element")]
        public SnapshotElement[]? Element { get; set; }
    }

    public partial class SnapshotElement
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("path")]
        public string? Path { get; set; }

        [JsonProperty("short")]
        public string? Short { get; set; }

        [JsonProperty("definition")]
        public string? Definition { get; set; }

        [JsonProperty("min")]
        public long Min { get; set; }

        [JsonProperty("max")]
        public string? Max { get; set; }

        [JsonProperty("base")]
        public Base? Base { get; set; }

        [JsonProperty("isModifier")]
        public bool IsModifier { get; set; }

        [JsonProperty("isSummary")]
        public bool IsSummary { get; set; }

        [JsonProperty("mapping", NullValueHandling = NullValueHandling.Ignore)]
        public ElementMapping[]? Mapping { get; set; }

        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string? Comment { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeElement[]? Type { get; set; }

        [JsonProperty("constraint", NullValueHandling = NullValueHandling.Ignore)]
        public Constraint[]? Constraint { get; set; }

        [JsonProperty("isModifierReason", NullValueHandling = NullValueHandling.Ignore)]
        public string? IsModifierReason { get; set; }

        [JsonProperty("binding", NullValueHandling = NullValueHandling.Ignore)]
        public ElementBinding? Binding { get; set; }

        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string[]? Alias { get; set; }

        [JsonProperty("requirements", NullValueHandling = NullValueHandling.Ignore)]
        public string? Requirements { get; set; }

        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
        public ElementExtension[]? Extension { get; set; }

        [JsonProperty("representation", NullValueHandling = NullValueHandling.Ignore)]
        public string[]? Representation { get; set; }

        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public string[]? Condition { get; set; }

        [JsonProperty("meaningWhenMissing", NullValueHandling = NullValueHandling.Ignore)]
        public string? MeaningWhenMissing { get; set; }

        [JsonProperty("orderMeaning", NullValueHandling = NullValueHandling.Ignore)]
        public string? OrderMeaning { get; set; }

        [JsonProperty("contentReference", NullValueHandling = NullValueHandling.Ignore)]
        public string? ContentReference { get; set; }

        [JsonProperty("example", NullValueHandling = NullValueHandling.Ignore)]
        public Example[]? Example { get; set; }

        [JsonProperty("slicing", NullValueHandling = NullValueHandling.Ignore)]
        public Slicing? Slicing { get; set; }
    }

    public partial class Base
    {
        [JsonProperty("path")]
        public string? Path { get; set; }

        [JsonProperty("min")]
        public long Min { get; set; }

        [JsonProperty("max")]
        public string? Max { get; set; }
    }

    public partial class Software
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
    }

    public partial class Text
    {
        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("div")]
        public string? Div { get; set; }
    }
}
