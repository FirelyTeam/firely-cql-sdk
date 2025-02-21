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
    IOptions<PackagerCliOptions> packagerCliProgramOptions)
{
    private readonly PackagerCliOptions _packagerCliOptions = packagerCliProgramOptions.Value;

    public void DumpToConsole()
    {
        StringBuilder? sb = logger.IsEnabled(LogLevel.Information) ? new() : null;

        WriteLine("PackageCLI");
        WriteLine("- Environment -----------------------------------");
        WriteLine($"{"Time",-45} : {DateTimeOffset.Now}");
        WriteLine($"{"Current Directory",-45} : {Environment.CurrentDirectory}");
        WriteLine($"{"DOTNET_ENVIRONMENT",-45} : {Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT")}");
        WriteLine("- Arguments Provided ----------------------------");
        (string name, object? value)[] values = new[]
        {
            // ArgFor("Logging, KeepLog", _cqlToResourcePackagingOptions.DontLogClear),
            // ArgFor("Logging, IncludeDebug",_cqlToResourcePackagingOptions.LogDebugEnabled),
            ArgFor("Cql, InDir", _packagerCliOptions.CqlInDirectory),
            ArgFor("Elm, InDir", _packagerCliOptions.ElmInDirectory),
            ArgFor("CSharp, OutDir", _packagerCliOptions.CSharpOutDirectory),
            ArgFor("Assembly, OutDir", _packagerCliOptions.AssemblyOutDirectory),
            ArgFor("Fhir, OutDir", _packagerCliOptions.FhirOutDirectory),
            ArgFor("Fhir, CanonicalRootUrl", _packagerCliOptions.FhirCanonicalRootUrl),
            ArgFor("Fhir, OverrideDate", _packagerCliOptions.FhirOverrideDate),
        }.Where(t => t.value is not null)
        .ToArray();

        foreach (var (name, value) in values)
            WriteLine($"{name,-45} : {value}");

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