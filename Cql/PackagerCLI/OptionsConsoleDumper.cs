/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit;

namespace Hl7.Cql.Packager;

internal class OptionsConsoleDumper(
    ILogger<OptionsConsoleDumper> logger,
    IOptions<PackagerCliOptions> packagerCliProgramOptions,
    IOptions<CqlToolkitConfig> cqlToolkitConfigOptions,
    IOptions<ElmToolkitConfig> elmToolkitConfigOptions)
{
    public void DumpToConsole()
    {
        StringBuilder? sb = logger.IsEnabled(LogLevel.Information) ? new() : null;

        WriteLine("PackageCLI");
        WriteLine("- Environment -----------------------------------");
        WriteLine($"{"Time",-45} : {DateTimeOffset.Now}");
        WriteLine($"{"Current Directory",-45} : {Environment.CurrentDirectory}");
        WriteLine($"{"DOTNET_ENVIRONMENT",-45} : {Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT")}");
        WriteLine("- Configuration ---------------------------------");

        JsonSerializerOptions jsonOpt = new();
        jsonOpt.WriteIndented = true;
        //jsonOpt.ReferenceHandler = ReferenceHandler.Preserve;
        //jsonOpt.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault;
        jsonOpt.Converters.Add(new JsonStringEnumConverter());
        jsonOpt.Converters.Add(new FileSystemInfoJsonConverter<FileInfo>());
        jsonOpt.Converters.Add(new FileSystemInfoJsonConverter<DirectoryInfo>());
        //jsonOpt.Converters.Add(new DefaultValueIgnoringConverter<CqlToolkitConfig>());
        var root = new
        {
            Packager = packagerCliProgramOptions.Value,
            Cql = cqlToolkitConfigOptions.Value,
            Elm = elmToolkitConfigOptions.Value,
        };

        WriteLine(JsonSerializer.Serialize(root, jsonOpt));

        // (string name, object? value)[] values = new[]
        // {
        //     // ArgFor("Logging, KeepLog", _cqlToResourcePackagingOptions.DontLogClear),
        //     // ArgFor("Logging, IncludeDebug",_cqlToResourcePackagingOptions.LogDebugEnabled),
        //     ArgFor("Cql, InDir", _packagerCliOptions.CqlFromDirectory),
        //     ArgFor("Elm, InDir", _packagerCliOptions.ElmFromDirectory),
        //     ArgFor("CSharp, OutDir", _packagerCliOptions.CSharpOutDirectory),
        //     ArgFor("Assembly, OutDir", _packagerCliOptions.AssemblyOutDirectory),
        //     ArgFor("Fhir, OutDir", _packagerCliOptions.FhirOutDirectory),
        //     ArgFor("Fhir, CanonicalRootUrl", _packagerCliOptions.FhirCanonicalRootUrl),
        //     ArgFor("Fhir, OverrideDate", _packagerCliOptions.FhirOverrideDate),
        // }.Where(t => t.value is not null)
        // .ToArray();
        //
        // foreach (var (name, value) in values)
        //     WriteLine($"{name,-45} : {value}");

        if (sb is not null)
            logger.LogInformation("{options}", sb.ToString());

        void WriteLine(string s)
        {
            if (sb is not null)
                sb.AppendLine(s);
            else
                Console.WriteLine(s);
        }
    }

    static (string name, object? value) ArgFor(object? value, [CallerArgumentExpression(nameof(value))] string name = "") => (name.Split('.').Last(), value);
    static (string name, object? value) ArgFor(string prepend, object? value, [CallerArgumentExpression(nameof(value))] string name = "") => (prepend + name.Split('.').Last(), value);

}

file class FileSystemInfoJsonConverter<TFileSystemInfo > : JsonConverter<TFileSystemInfo >
    where TFileSystemInfo : FileSystemInfo
{
    public override TFileSystemInfo? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

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


// file class DefaultValueIgnoringConverter<T> : JsonConverter<T>
// {
//     public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
//     {
//         throw new NotImplementedException();
//     }
//
//     public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
//     {
//         writer.WriteStartObject();
//
//         foreach (PropertyInfo property in typeof(T).GetProperties(BindingFlags.GetProperty|BindingFlags.Public|BindingFlags.Instance))
//         {
//             if (property.GetCustomAttributes<JsonIgnoreAttribute>().Any())
//                 continue;
//
//             var defaultValueAttribute = property.GetCustomAttribute<DefaultValueAttribute>();
//             var propertyValue = property.GetValue(value);
//
//             if (defaultValueAttribute == null || !Equals(propertyValue, defaultValueAttribute.Value))
//             {
//                 writer.WritePropertyName(property.Name);
//                 //base.WriteAsPropertyName(writer, propertyValue, options);
//                 JsonSerializer.Serialize(writer, propertyValue, options);
//             }
//         }
//
//         writer.WriteEndObject();
//     }
// }
