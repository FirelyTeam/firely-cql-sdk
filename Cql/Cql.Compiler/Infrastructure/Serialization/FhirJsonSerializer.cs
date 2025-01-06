using System;
using System.IO;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;

namespace Hl7.Cql.Compiler.Infrastructure.Serialization;

internal class FhirJsonSerializer([FromKeyedServices("Fhir")] JsonSerializerOptions jsonSerializerOptions)
{
    public JsonSerializerOptions JsonSerializerOptions { get; } = jsonSerializerOptions;

    private static ArgumentException NewCannotDeserialize(Type type, string? targetDescription)
    {
        return new ArgumentException($"Unable to deserialize {targetDescription} as {type.Name}");
    }

    public T ParseFhir<T>(ReadOnlySpan<char> span)
    {
        return JsonSerializer.Deserialize<T>(span, JsonSerializerOptions) ?? throw NewCannotDeserialize(typeof(T), "the readonly character span");
    }

    public T ParseFhir<T>(string json)
    {
        return JsonSerializer.Deserialize<T>(json, JsonSerializerOptions) ?? throw NewCannotDeserialize(typeof(T), "the string");
    }

    public T LoadFhir<T>(FileInfo file)
    {
        using var stream = file.OpenRead();
        return ParseFhir<T>(stream);
    }

    public T ParseFhir<T>(Stream readableStream) =>
        JsonSerializer.Deserialize<T>(readableStream, JsonSerializerOptions) ?? throw NewCannotDeserialize(typeof(T),
            readableStream as FileStream is { } fileStream
                ? $"the file '{fileStream.Name}'"
                : "the stream");
}