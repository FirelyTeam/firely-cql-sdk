/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Packager;

internal class OptionsConsoleDumper(
    ILogger<OptionsConsoleDumper> logger,
    IOptions<CqlOptions> cqlOptions,
    IOptions<ElmOptions> elmOptions,
    IOptions<PackagingOptions> packagingOptions,
    IOptions<LoggingOptions> loggingOptions)
{
    public void DumpToConsole()
    {
        StringBuilder? sb = logger.IsEnabled(LogLevel.Information) ? new() : null;

        WriteLine("PackageCLI");
        WriteLine("- Environment -----------------------------------");
        WriteLine($"{"Time",-45} : {DateTimeOffset.Now}");
        WriteLine($"{"Current Directory",-45} : {Environment.CurrentDirectory}");
        WriteLine($"{"Build",-45} : {typeof(PackagerCli).Assembly.GetCustomAttribute<AssemblyConfigurationAttribute>()?.Configuration}");
        WriteLine("- Configuration ---------------------------------");

        JsonSerializerOptions jsonOpt = new();
        jsonOpt.WriteIndented = true;
        jsonOpt.Converters.Add(new JsonStringEnumConverter());
        jsonOpt.Converters.Add(new FileSystemInfoJsonConverter<FileInfo>());
        jsonOpt.Converters.Add(new FileSystemInfoJsonConverter<DirectoryInfo>());

        var root = new
        {
            Cql = cqlOptions.Value,
            Elm = elmOptions.Value,
            Packaging = packagingOptions.Value,
            Logging = loggingOptions.Value,
        };

        WriteLine(JsonSerializer.Serialize(root, jsonOpt));

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
}

file class FileSystemInfoJsonConverter<TFileSystemInfo > : JsonConverter<TFileSystemInfo >
    where TFileSystemInfo : FileSystemInfo
{
    public override TFileSystemInfo? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options) =>
        throw new NotImplementedException();

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
