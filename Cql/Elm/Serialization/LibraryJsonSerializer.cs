/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text.Encodings.Web;
using Hl7.Cql.Exceptions;

namespace Hl7.Cql.Elm.Serialization;

// The property should be 'library', not 'Library', to match the JSON structure.
// ReSharper disable once InconsistentNaming
internal record LibraryContainer(Library library);

/// <summary>
/// Internal type responsible for JSON serialization and deserialization of Library objects.
/// This class contains specialized logic for handling ELM JSON format quirks and legacy constructs.
/// </summary>
internal static class LibraryJsonSerializer
{
    /// <summary>
    /// Enables debug assertions for serialization diagnostics.
    /// </summary>
    internal static bool EnableDebugAssertions = true;

    private const int MaxDepth = 4096; // int.MaxValue is not a good idea
    private const int InitialBufferSize = 64 * 1024;
    private static readonly JsonSerializerOptions _jsonSerializerOptions = BuildSerializerOptions(allowOldStyleTypeDiscriminators: false);
    private static readonly JsonSerializerOptions _jsonDeserializerOptions = BuildSerializerOptions(allowOldStyleTypeDiscriminators: true);
    private static readonly JsonDocumentOptions _jsonDocumentOptions = BuildJsonDocumentOptions();

    // A node without options of its own asks its parent for them, and a root with none gives nothing to cache, so
    // every lookup on a deeply nested node would walk the whole chain up to the root. Giving the root options ends
    // that walk at the root.
    private static readonly JsonNodeOptions _jsonNodeOptions = new() { PropertyNameCaseInsensitive = false };

    /// <summary>
    /// Parses the specified JSON string and returns a corresponding JsonNode representation.
    /// </summary>
    /// <param name="json">The JSON string to parse. Cannot be null or empty. The string must contain valid JSON.</param>
    /// <returns>A JsonNode representing the parsed JSON data.</returns>
    /// <exception cref="InvalidOperationException">Thrown if the JSON string cannot be parsed into a JsonNode.</exception>
    internal static JsonNode ParseToJsonNode(string json)
    {
        return JsonNode.Parse(json, _jsonNodeOptions, _jsonDocumentOptions) ??
               throw new InvalidOperationException("JsonNode.Parse unexpectedly returned null.");
    }

    /// <summary>
    /// Deserializes a Library from a JsonNode.
    /// </summary>
    /// <param name="node">The JSON node to deserialize.</param>
    /// <param name="validate">Whether to validate the library after deserialization.</param>
    /// <param name="originalFilePath">Optional file path for error reporting.</param>
    /// <returns>The deserialized Library.</returns>
    internal static Library DeserializeFromJsonNode(JsonNode node, bool validate, string? originalFilePath)
    {
        // Note that we need to reorder the JSON object to ensure that the "type" property is the first property,
        // for which we need to visit the entire object. It is possible to avoid this by first inspecting the
        // compiler tool and version that generated the ELM, so we know whether the compiler tool is known to
        // generate the "type" property first. Also, this will make sure the "type" property is only used for
        // string, if it is used differently, the property is upgraded to "resultTypeSpecifier".
        CorrectLegacyConstructs(node!);

        var container = node.Deserialize<LibraryContainer>(_jsonDeserializerOptions) ??
                        throw new InvalidOperationException("Deserialization unexpectedly returned null.");
        var library = container.library;

        if (validate)
        {
            try
            {
                library.Validate();
            }
            catch (Exception e)
            {
                throw new CouldNotValidateLibraryError(originalFilePath, typeof(Library).FullName).ToException(e);
            }
        }

        return library;
    }

    /// <summary>
    /// Serializes a Library to a JSON string.
    /// </summary>
    /// <param name="library">The library to serialize.</param>
    /// <param name="writeIndented">Whether to format the JSON with indentation.</param>
    /// <returns>The JSON string representation of the library.</returns>
    internal static string SerializeToJson(Library library, bool writeIndented = true)
    {
        using var buffer = SerializeToPooledBuffer(library, writeIndented);
        return Encoding.UTF8.GetString(buffer.WrittenSpan);
    }

    /// <summary>
    /// Serializes a Library to a stream in JSON format.
    /// </summary>
    /// <param name="library">The library to serialize.</param>
    /// <param name="stream">The stream to write to.</param>
    /// <param name="writeIndented">Whether to format the JSON with indentation.</param>
    /// <remarks>The library is serialized in full before the stream is touched, so a serialization that fails writes nothing.</remarks>
    internal static void SerializeToStream(Library library, Stream stream, bool writeIndented = true)
    {
        using var buffer = SerializeToPooledBuffer(library, writeIndented);
        stream.Write(buffer.WrittenSpan);
        stream.Flush();
    }

    /// <summary>
    /// Serializes a Library to UTF-8 JSON with <see cref="Environment.NewLine"/> as its line break, into a pooled buffer
    /// the caller reads through <see cref="PooledByteBufferWriter.WrittenSpan"/> and disposes.
    /// </summary>
    /// <param name="library">The library to serialize.</param>
    /// <param name="writeIndented">Whether to format the JSON with indentation.</param>
    internal static PooledByteBufferWriter SerializeToPooledBuffer(Library library, bool writeIndented)
    {
        var buffer = new PooledByteBufferWriter(InitialBufferSize);
        try
        {
            using var writer = new Utf8JsonWriter(buffer, CreateWriterOptions(writeIndented));
            JsonSerializer.Serialize(writer, new LibraryContainer(library), _jsonSerializerOptions);
        }
        catch
        {
            buffer.Dispose();
            throw;
        }

        return buffer;
    }

    // The one write instance serves both formats: the indentation belongs to the writer, which ignores the
    // options' WriteIndented, so no second set of serializer metadata is built for indented output.
    private static JsonWriterOptions CreateWriterOptions(bool writeIndented) =>
        new()
        {
            Indented = writeIndented,
            MaxDepth = MaxDepth,
            SkipValidation = true,
        };

    /// <summary>
    /// Serializes a Library to UTF-8 JSON with LF line breaks, whatever the platform's new line is.
    /// </summary>
    /// <param name="library">The library to serialize.</param>
    /// <param name="writeIndented">Whether to format the JSON with indentation.</param>
    internal static byte[] SerializeToUtf8(Library library, bool writeIndented)
    {
        using var buffer = new PooledByteBufferWriter(InitialBufferSize);
        var writerOptions = CreateWriterOptions(writeIndented);
        writerOptions.NewLine = "\n";
        using (var writer = new Utf8JsonWriter(buffer, writerOptions))
        {
            JsonSerializer.Serialize(writer, new LibraryContainer(library), _jsonSerializerOptions);
        }

        return buffer.WrittenSpan.ToArray();
    }

    /// <summary>
    /// Re-indents already-serialized ELM JSON without going through the object model.
    /// </summary>
    /// <param name="utf8Json">The UTF-8 JSON to reformat.</param>
    /// <param name="writeIndented">Whether to format the JSON with indentation.</param>
    /// <returns>The same JSON content, differing only in insignificant JSON formatting, with LF line breaks.</returns>
    /// <remarks>
    /// This copies the tokens of the text from a <see cref="Utf8JsonReader"/> to a <see cref="Utf8JsonWriter"/>
    /// one at a time, so it builds no document and does not walk the ELM nodes through
    /// <see cref="PolymorphicTypeResolver"/> and its modifiers. Empty or malformed JSON, and nesting deeper than
    /// the maximum depth of 4,096, throw a <see cref="JsonException"/>. Once the
    /// serializer's metadata is built, serializing costs less than this; a process that serializes nothing
    /// else saves building that metadata by re-formatting instead. The reason to keep this route is
    /// fidelity: unlike <see cref="SerializeToJson"/> it neither drops empty collections nor applies the
    /// corrections made while reading, so it keeps the content of the source, which serializing does not
    /// reproduce. The text is not guaranteed byte-identical to the input even when
    /// <paramref name="writeIndented"/> matches it: whitespace is regenerated, and string escaping is
    /// normalized to the writer's encoder.
    /// </remarks>
    internal static byte[] ReformatUtf8Json(byte[] utf8Json, bool writeIndented)
    {
        // Indented output is larger than its input, so size for growth.
        using var buffer = new PooledByteBufferWriter(writeIndented ? utf8Json.Length * 2 : utf8Json.Length);
        var writerOptions = CreateWriterOptions(writeIndented);
        writerOptions.NewLine = "\n";
        // The default encoder escapes characters that are legal unescaped in JSON, such as '<' and
        // '&', which appear in the CQL annotations ELM carries. Relaxed escaping keeps the output
        // closer to the source text; it is safe here because this JSON is embedded as an attachment,
        // never interpolated into HTML.
        writerOptions.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

        var reader = new Utf8JsonReader(utf8Json, new JsonReaderOptions { MaxDepth = MaxDepth });
        var any = false;
        using (var writer = new Utf8JsonWriter(buffer, writerOptions))
        {
            while (reader.Read())
            {
                any = true;
                CopyToken(ref reader, writer);
            }
        }

        if (!any)
            throw new JsonException("The JSON is empty.");

        return buffer.WrittenSpan.ToArray();
    }

    private static void CopyToken(ref Utf8JsonReader reader, Utf8JsonWriter writer)
    {
        switch (reader.TokenType)
        {
            case JsonTokenType.StartObject: writer.WriteStartObject(); break;
            case JsonTokenType.EndObject: writer.WriteEndObject(); break;
            case JsonTokenType.StartArray: writer.WriteStartArray(); break;
            case JsonTokenType.EndArray: writer.WriteEndArray(); break;
            case JsonTokenType.PropertyName:
            case JsonTokenType.String:
            {
                var isName = reader.TokenType == JsonTokenType.PropertyName;
                if (!reader.ValueIsEscaped)
                {
                    if (isName) writer.WritePropertyName(reader.ValueSpan); else writer.WriteStringValue(reader.ValueSpan);
                    break;
                }

                var max = reader.ValueSpan.Length;
                byte[]? rented = null;
                Span<byte> scratch = max <= 256 ? stackalloc byte[256] : (rented = System.Buffers.ArrayPool<byte>.Shared.Rent(max));
                try
                {
                    var length = reader.CopyString(scratch);
                    if (isName) writer.WritePropertyName(scratch[..length]); else writer.WriteStringValue(scratch[..length]);
                }
                finally
                {
                    if (rented is not null) System.Buffers.ArrayPool<byte>.Shared.Return(rented);
                }

                break;
            }
            case JsonTokenType.Number: writer.WriteRawValue(reader.ValueSpan, skipInputValidation: true); break;
            case JsonTokenType.True: writer.WriteBooleanValue(true); break;
            case JsonTokenType.False: writer.WriteBooleanValue(false); break;
            case JsonTokenType.Null: writer.WriteNullValue(); break;
        }
    }

    /// <summary>
    /// Rewrites CRLF and lone CR to LF in UTF-8 JSON, returning <paramref name="utf8Json"/> itself when it
    /// contains no carriage return.
    /// </summary>
    /// <remarks>
    /// Line endings are insignificant between JSON tokens, but a file is checked out with whatever endings
    /// the platform uses, and these bytes are embedded verbatim as a base64 attachment where git cannot
    /// normalize them. Without this the same library packaged on Windows and on Unix produces different
    /// attachments. CR inside a JSON string literal is escaped as <c>\r</c> and so is not affected.
    /// </remarks>
    internal static byte[] NormalizeNewLinesUtf8(byte[] utf8Json)
    {
        const byte cr = (byte)'\r';
        const byte lf = (byte)'\n';

        var source = utf8Json.AsSpan();
        var next = source.IndexOf(cr);
        if (next < 0)
            return utf8Json;

        // Every CRLF collapses to one byte, and a lone CR is replaced in place.
        var normalized = new byte[source.Length - source.Count("\r\n"u8)];
        var destination = normalized.AsSpan();

        while (next >= 0)
        {
            source[..next].CopyTo(destination);
            destination[next] = lf;
            destination = destination[(next + 1)..];

            // CRLF and a lone CR both collapse to a single LF.
            var skip = next + 1 < source.Length && source[next + 1] == lf ? next + 2 : next + 1;
            source = source[skip..];
            next = source.IndexOf(cr);
        }

        source.CopyTo(destination);
        return normalized;
    }

    /// <summary>
    /// Gets the JSON document options used for parsing.
    /// </summary>
    internal static JsonDocumentOptions GetJsonDocumentOptions() => _jsonDocumentOptions;

    /// <summary>
    /// Gets the JSON node options used for parsing.
    /// </summary>
    internal static JsonNodeOptions GetJsonNodeOptions() => _jsonNodeOptions;

    /// <summary>
    /// Builds JSON serializer options for ELM serialization.
    /// </summary>
    /// <param name="allowOldStyleTypeDiscriminators">Whether to allow old-style type discriminators.</param>
    /// <returns>Configured JsonSerializerOptions.</returns>
    internal static JsonSerializerOptions BuildSerializerOptions(bool allowOldStyleTypeDiscriminators = false)
    {
        var options = new JsonSerializerOptions
        {
            MaxDepth = MaxDepth,
            UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow,
        };

        options.Converters.Add(new TopLevelDefinitionConverterFactory(allowOldStyleTypeDiscriminators));
        options.Converters.Add(new XmlQualifiedNameConverter());
        options.Converters.Add(new JsonStringEnumConverter());

        var resolver = new PolymorphicTypeResolver(allowOldStyleTypeDiscriminators)
                      .WithAddedModifier(ModifyNarrative)
                      .WithAddedModifier(DoNotSerializeDefaultValues)
                      .WithAddedModifier(HandleSpecifiedProperties)
                      .WithAddedModifier(RespectXmlIgnoreAttribute)
                      .WithAddedModifier(GuardNestingDepth);

        options.TypeInfoResolver = resolver;

        return options;
    }

    private static JsonDocumentOptions BuildJsonDocumentOptions() =>
        new() { MaxDepth = MaxDepth };

    /// <summary>
    /// Throws a <see cref="JsonException"/> when the stack cannot take another level of nesting, so that
    /// ELM nested deeper than the thread's stack allows fails with a catchable exception, not a stack overflow.
    /// </summary>
    private static void EnsureStackForNesting()
    {
        if (!RuntimeHelpers.TryEnsureSufficientExecutionStack())
            throw new JsonException("The ELM is nested too deeply for the available stack.");
    }

    private static void GuardNestingDepth(JsonTypeInfo ti)
    {
        if (ti.Kind != JsonTypeInfoKind.Object) return;

        var onDeserializing = ti.OnDeserializing;
        ti.OnDeserializing = onDeserializing is null
            ? _ => EnsureStackForNesting()
            : o => { EnsureStackForNesting(); onDeserializing(o); };

        var onSerializing = ti.OnSerializing;
        ti.OnSerializing = onSerializing is null
            ? _ => EnsureStackForNesting()
            : o => { EnsureStackForNesting(); onSerializing(o); };
    }

    private static void CorrectLegacyConstructs(JsonNode a)
    {
        EnsureStackForNesting();
            switch (a)
            {
                case JsonObject jo:
                    reorder(jo);
                    fixType(jo);
                    for (int i = 0; i < jo.Count;)
                    {
                        var value = jo.GetAt(i).Value;
                        if (value is not null)
                        {
                            CorrectLegacyConstructs(value);

                            if (isEmptyObjectOrArray(value))
                            {
                                jo.RemoveAt(i);
                                continue;
                            }
                        }

                        i++;
                    }
                    break;
                case JsonArray ja:
                    for (int i = ja.Count - 1; i >= 0; i--)
                    {
                        var item = ja[i];
                        if (item is null) continue;

                        CorrectLegacyConstructs(item);

                        if (isEmptyObjectOrArray(item))
                        {
                            ja.RemoveAt(i);
                        }
                    }
                    break;
            }

            static void reorder(JsonObject o)
            {
                var index = o.IndexOf("type");
                if (index <= 0) return;

                var typeProp = o.GetAt(index).Value;
                o.RemoveAt(index);
                o.Insert(0, "type", typeProp);
            }

            static void fixType(JsonObject o)
            {
                if (!o.TryGetPropertyValue("type", out var typeProp)) return;

                if (typeProp is null)
                    throw new JsonException("The 'type' property must be a string, but was null.", o.GetPath() + ".type", null, null);

                // If "type" is an object (not a discriminator string), remove it
                if (typeProp.GetValueKind() == JsonValueKind.Object)
                {
                    o.Remove("type");
                    return;
                }

                // If "type" is an array (legacy ChoiceTypeSpecifier.type), convert to "choice"
                if (typeProp.GetValueKind() == JsonValueKind.Array)
                {
                    // Only convert if there's no "choice" property already
                    if (!o.ContainsKey("choice"))
                    {
                        o.Remove("type");
                        o.Add("choice", typeProp);
                    }
                    else
                    {
                        // If both exist, remove the legacy "type" property
                        o.Remove("type");
                    }
                }
            }

            static bool isEmptyObjectOrArray(JsonNode node) =>
                node is JsonObject { Count: 0 } or JsonArray { Count: 0 };
        }

    private static void HandleSpecifiedProperties(JsonTypeInfo ti)
    {
        var specifiedProps = ti.Properties.SelectMany(getSpecifiedProperty);

        foreach (var prop in specifiedProps)
        {
            var originalSetter = prop.ValueProp.Set;

            // On deserialization, if we need to set the property,
            // make sure we set the xxxSpecified property to true.
            prop.ValueProp.Set = (obj, value) =>
            {
                originalSetter?.Invoke(obj, value);
                prop.ValuePropSpecified.Set?.Invoke(obj, true);
            };

            // Only serialize the property if xxxSpecified is true.
            // Preserve the existing ShouldSerialize logic (e.g., from DoNotSerializeDefaultValues).
            var existingShouldSerialize = prop.ValueProp.ShouldSerialize;
            prop.ValueProp.ShouldSerialize = (obj, value) =>
            {
                var shouldSerialize = (bool?)prop.ValuePropSpecified.Get?.Invoke(obj) == true;
                AssertSpecifiedWhenNotDefault(prop, value, shouldSerialize);

                // If the specified flag is false, don't serialize
                if (!shouldSerialize) return false;

                // Otherwise, defer to the existing ShouldSerialize logic
                return existingShouldSerialize?.Invoke(obj, value) ?? true;
            };

            // The xxxSpecified prop should never be serialized itself.
            prop.ValuePropSpecified.ShouldSerialize = (_, _) => false;
        }

        IEnumerable<PropAndSpecified> getSpecifiedProperty(JsonPropertyInfo prop)
        {
            if (prop.Name.EndsWith("Specified") &&
                ti.Properties.FirstOrDefault(p => p.Name == prop.Name[..^9]) is { } valueProp)
            {
                yield return new PropAndSpecified(valueProp, prop);
            }
        }
    }

    // Conditional on DEBUG: a Release build drops the call, so it neither reads EnableDebugAssertions nor boxes a default value.
    [Conditional("DEBUG")]
    private static void AssertSpecifiedWhenNotDefault(PropAndSpecified prop, object? value, bool shouldSerialize)
    {
        if (EnableDebugAssertions && !shouldSerialize && !IsDefaultValue(value))
            Debug.Fail($"Property '{prop.ValueProp.Name}' is set to '{value}', but " +
                       $"the '{prop.ValuePropSpecified.Name}' is false.");
    }

    private static void DoNotSerializeDefaultValues(JsonTypeInfo ti)
    {
        foreach (var prop in ti.Properties)
        {
            if (prop.PropertyType.IsEnum || ti.Type == typeof(Interval))
            {
                prop.ShouldSerialize = static (_, value) => value is not null;
                continue;
            }

            var defaultAttr = prop.AttributeProvider?
                .GetCustomAttributes(typeof(DefaultValueAttribute), false)
                .FirstOrDefault() as DefaultValueAttribute;

            var defaultValue = defaultAttr?.Value ?? GetDefaultValue(prop.PropertyType);

            prop.ShouldSerialize = defaultValue is null
                ? static (_, value) => value is not null
                : (_, value) => value is not null && !Equals(value, defaultValue);
        }
    }

    private static object? GetDefaultValue(Type type) =>
        type.IsValueType ? Activator.CreateInstance(type) : null;

    private static bool IsDefaultValue(object? o) =>
        o is null || o.Equals(GetDefaultValue(o.GetType()));

    private static void RespectXmlIgnoreAttribute(JsonTypeInfo ti)
    {
        // Properties marked with [XmlIgnore] should also be ignored in JSON serialization.
        // This allows us to avoid duplicating [JsonIgnore] attributes on computed properties.
        foreach (var prop in ti.Properties)
        {
            var hasXmlIgnore = prop.AttributeProvider?
                .GetCustomAttributes(typeof(XmlIgnoreAttribute), false)
                .Length > 0;

            if (hasXmlIgnore)
            {
                prop.ShouldSerialize = (_, _) => false;
            }
        }
    }

    private static void ModifyNarrative(JsonTypeInfo ti)
    {
        // Make sure Narrative.Text is serialized as "value" in the json, not as "Text"
        if (ti.Type != typeof(Narrative)) return;

        var valueProp = ti.Properties.FirstOrDefault(p => p.Name == "Text");

        if (valueProp is not null)
            valueProp.Name = "value";
    }

    private record PropAndSpecified(JsonPropertyInfo ValueProp, JsonPropertyInfo ValuePropSpecified);
}
