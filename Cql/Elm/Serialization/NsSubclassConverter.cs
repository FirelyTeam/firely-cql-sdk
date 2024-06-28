using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Hl7.Cql.Elm.Serialization;

internal class NsSubclassConverter : JsonConverter
{
    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        SkipOnce = true;
        serializer.Serialize(writer, value);
    }

    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        var parsedObject = JToken.Load(reader);
        var typeToken = parsedObject["type"];
        var statedType = typeToken?.ToString();

        if (statedType == null && objectType.IsAbstract)
                throw new JsonException("Expected a 'type' property in the JSON object.");

        var concreteType = objectType.Name == statedType || statedType is null
            ? objectType
            : findSubtype(objectType, statedType);

        var contract = serializer.ContractResolver.ResolveContract(concreteType);
        var result = contract.DefaultCreator!.Invoke();

        typeToken?.Parent?.Remove(); // don't consider the 'type' element for deserialization.

        using var subReader = parsedObject.CreateReader();
        serializer.Populate(subReader, result);

        return result;

        static Type findSubtype(Type objectType, string name) =>
            objectType.GetCustomAttributes<XmlIncludeAttribute>(false)
                .FirstOrDefault(a => a.Type?.Name == name)?.Type ??
                throw new JsonException($"There is no {nameof(XmlIncludeAttribute)} on type {objectType} for " +
                                    $" the specified type '{name}'.");

    }

    public static bool IsPartOfAnnotatedSubclassHierarchy(Type type) =>
        type.GetCustomAttributes<XmlIncludeAttribute>(false).Any() ||
            (type.BaseType != null && type.BaseType != typeof(Element) && IsPartOfAnnotatedSubclassHierarchy(type.BaseType));

    public override bool CanConvert(Type objectType)
    {
        if (SkipOnce)
        {
            SkipOnce = false;
            return false;
        }

        return IsPartOfAnnotatedSubclassHierarchy(objectType);
    }


    [ThreadStatic]
    private static bool SkipOnce;

}