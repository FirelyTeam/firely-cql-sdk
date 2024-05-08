using System;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Hl7.Cql.Elm.Serialization;

internal class NsNarrativeConverter : JsonConverter<Narrative>
{
    public override void WriteJson(JsonWriter writer, Narrative? value, JsonSerializer serializer)
    {
        var text = value?.Text;
        if (text is null || text.Length == 0) return;

        writer.WriteRaw(text[0]);
    }

    public override Narrative? ReadJson(JsonReader reader, Type objectType, Narrative? existingValue, bool hasExistingValue,
        JsonSerializer serializer)
    {
        var parsedObject = JToken.Load(reader);

        using var sw = new StringWriter();
        using var sb = new JsonTextWriter(sw);
        parsedObject.WriteTo(sb);
        sb.Flush();

        return new Narrative { Text = new[] {sw.ToString()} };
    }
}