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
        using var ms = new StringWriter();
        using var stringWriter = new JsonTextWriter(ms);

        SkipOnce = true;
        serializer.Serialize(stringWriter, value);

        stringWriter.Flush();
        var objString = ms.ToString();

        // Sorry, I have no idea why this bit gets appended. Just removing it now, it is getting late.
        objString = objString.Replace("}null}", "}}");
        var parsedObject = JObject.Parse(objString);
        parsedObject.AddFirst(new JProperty("type", value is not null ? value.GetType().Name : JValue.CreateNull()));

        parsedObject.WriteTo(writer);
    }

    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        var parsedObject = JToken.Load(reader);
        var typeToken = parsedObject["type"];
        var statedType = typeToken?.ToString();

        if (statedType == null && objectType.IsAbstract)
                throw new JsonException("Could not find the 'type' property in the JSON object.");

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

    public override bool CanConvert(Type objectType)
    {
        if (SkipOnce)
        {
            SkipOnce = false;
            return false;
        }


        var xmlattrs = objectType.GetCustomAttributes<XmlIncludeAttribute>(false);
        if (xmlattrs.Any()) return true;

        if (objectType.BaseType is { } baseType && baseType != typeof(Element))
        {
            xmlattrs = baseType.GetCustomAttributes<XmlIncludeAttribute>(false)
                .Where(ca => ca.Type == objectType);
            return xmlattrs.Any();
        }

        return false;
    }

    [ThreadStatic]
    private static bool SkipOnce;

}