/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packager.Commands.Logging;
using Hl7.Cql.Packager.Options;
using Hl7.Cql.Packaging.Toolkit;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Packager;

internal class OptionsConsoleDumper(
    ILogger<OptionsConsoleDumper> logger,
    IConsole console,
    IOptions<CqlOptions> cqlOptions,
    IOptions<ElmOptions> elmOptions,
    IOptions<PackagingOptions> packagingOptions,
    IOptions<LoggingOptions> loggingOptions,
    IServiceProvider serviceProvider)
{
    public void DumpToConsole()
    {
        StringBuilder? sb = logger.IsEnabled(LogLevel.Information) ? new() : null;

        var assembly = typeof(Program).Assembly;
        //var attr = assembly.GetCustomAttributes();

        WriteLine("- PackageCLI ------------------------------------");
        WriteLine($"{"Build",-20} : {assembly.GetCustomAttribute<AssemblyConfigurationAttribute>()?.Configuration}");
        WriteLine($"{"Version",-20} : {assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion.Split('+')[0]}");
        WriteLine($"{"Path",-20} : {assembly.Location}");
        WriteLine($"{"Command Line Args",-20} : {string.Join(' ', GetCommandLineArgs()[1..])}");
        WriteLine("- Environment -----------------------------------");
        WriteLine($"{"Current Time",-20} : {DateTimeOffset.Now:O}");
        WriteLine($"{"Current Directory",-20} : {CurrentDirectory}");
        WriteLine($"{".NET Runtime",-20} : {RuntimeInformation.FrameworkDescription.Replace(".NET ", "")}");
        WriteLine($"{"OS / Architecture",-20} : {RuntimeInformation.OSDescription} / {RuntimeInformation.OSArchitecture}");
        WriteLine("- Configuration ---------------------------------");
        JsonSerializerOptions jsonOpt = new();
        jsonOpt.WriteIndented = true;
        jsonOpt.Converters.Add(new JsonStringEnumConverter());
        jsonOpt.Converters.Add(new FileSystemInfoJsonConverter<FileInfo>());
        jsonOpt.Converters.Add(new FileSystemInfoJsonConverter<DirectoryInfo>());
        jsonOpt.Converters.Add(new KeyToStringDictionaryJsonConverter<CqlLibraryIdentifier, string>());

        // Build the root object dynamically to include command-specific options
        var rootDict = new Dictionary<string, object?>
        {
            ["Cql"] = cqlOptions.Value,
            ["Elm"] = elmOptions.Value,
            ["Packaging"] = packagingOptions.Value,
            ["Logging"] = loggingOptions.Value,
        };

        // Try to add command-specific options if they're registered and have non-null values
        TryAddCommandOptionsIfUsed<Commands.ExtractLibraryAttachments.ExtractLibraryAttachmentsOptions>(rootDict, "ExtractLibraryAttachments");
        TryAddCommandOptionsIfUsed<Commands.ReplaceLibraryAttachments.ReplaceLibraryAttachmentsOptions>(rootDict, "ReplaceLibraryAttachments");

        WriteLine(JsonSerializer.Serialize(rootDict, jsonOpt));

        if (sb is not null)
            logger.LogInformation("{options}", sb.ToString());

        void WriteLine(string s)
        {
            if (sb is not null)
                sb.AppendLine(s);
            else
                console.WriteLine(s);
        }

        void TryAddCommandOptionsIfUsed<T>(Dictionary<string, object?> dict, string key) where T : class
        {
            var options = serviceProvider.GetService<IOptions<T>>();
            if (options is not null && HasNonNullProperties(options.Value))
            {
                dict[key] = options.Value;
            }
        }

        bool HasNonNullProperties(object? obj)
        {
            if (obj is null) return false;

            var properties = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var prop in properties)
            {
                var value = prop.GetValue(obj);
                if (value is not null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

file class FileSystemInfoJsonConverter<TFileSystemInfo > : JsonConverter<TFileSystemInfo >
    where TFileSystemInfo : FileSystemInfo
{
    public override TFileSystemInfo? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options) =>
        throw new NotImplementedException("Deserialization is not implemented.");

    public override void Write(
        Utf8JsonWriter writer,
        TFileSystemInfo  value,
        JsonSerializerOptions options)
    {
        if (value.FullName is {} fn)
            writer.WriteStringValue(fn);
        else
            writer.WriteNullValue();
    }
}


/// <remarks>For serializing <see cref="PackagingToolkitConfig.FixedLibraryCanonicals"/></remarks>
file class KeyToStringDictionaryJsonConverter<TKey, TValue> :
    JsonConverter<IReadOnlyDictionary<TKey, TValue>>
{
    public override IReadOnlyDictionary<TKey, TValue>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        throw new NotImplementedException("Deserialization is not implemented.");

    public override void Write(
        Utf8JsonWriter writer,
        IReadOnlyDictionary<TKey, TValue> value,
        JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        foreach (var kvp in value)
        {
            var propertyName = kvp.Key?.ToString();
            if (propertyName is { })
            {
                writer.WritePropertyName(propertyName ?? "");
                // Serialize the key as a string
                JsonSerializer.Serialize(writer, kvp.Value, options);
            }
        }
        writer.WriteEndObject();
    }
}
