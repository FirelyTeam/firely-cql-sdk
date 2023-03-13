using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ncqa.Fhir.Schemas.r4
{

    public partial class Schema
    {

        [JsonProperty("id")]
        public Uri? Id { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("discriminator")]
        public Discriminator? Discriminator { get; set; }

        [JsonProperty("oneOf")]
        public OneOf[]? OneOf { get; set; }

        [JsonProperty("definitions")]
        public Dictionary<string, Definition>? Definitions { get; set; }
    }

    public partial class Definition
    {
        [JsonProperty("oneOf", NullValueHandling = NullValueHandling.Ignore)]
        public OneOf[]? OneOf { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum? Type { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; }

        [JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string? Pattern { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Property>? Properties { get; set; }

        [JsonProperty("additionalProperties", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdditionalProperties { get; set; }

        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public string[]? DefinitionRequired { get; set; }
    }

    public partial class OneOf
    {
        [JsonProperty("$ref")]
        public string? Ref { get; set; }
    }

    public partial class Property
    {
        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("$ref", NullValueHandling = NullValueHandling.Ignore)]
        public string? Ref { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public Items? Items { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum? Type { get; set; }

        [JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string? Pattern { get; set; }

        [JsonProperty("enum", NullValueHandling = NullValueHandling.Ignore)]
        public string[]? Enum { get; set; }

        [JsonProperty("const", NullValueHandling = NullValueHandling.Ignore)]
        public string? Const { get; set; }
    }

    public partial class Items
    {
        [JsonProperty("$ref", NullValueHandling = NullValueHandling.Ignore)]
        public string? Ref { get; set; }

        [JsonProperty("enum", NullValueHandling = NullValueHandling.Ignore)]
        public string[]? Enum { get; set; }
    }

    public partial class Discriminator
    {
        [JsonProperty("propertyName")]
        public string? PropertyName { get; set; }

        [JsonProperty("mapping")]
        public Dictionary<string, string>? Mapping { get; set; }
    }

    public enum TypeEnum { Array, Boolean, Number, String };

    internal static class SchemaConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                TypeEnumConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null!;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "array":
                    return TypeEnum.Array;
                case "boolean":
                    return TypeEnum.Boolean;
                case "number":
                    return TypeEnum.Number;
                case "string":
                    return TypeEnum.String;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object? untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.Array:
                    serializer.Serialize(writer, "array");
                    return;
                case TypeEnum.Boolean:
                    serializer.Serialize(writer, "boolean");
                    return;
                case TypeEnum.Number:
                    serializer.Serialize(writer, "number");
                    return;
                case TypeEnum.String:
                    serializer.Serialize(writer, "string");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

}
