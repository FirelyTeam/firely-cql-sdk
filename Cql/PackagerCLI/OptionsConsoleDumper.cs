/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Microsoft.Extensions.Options;
using System.Runtime.CompilerServices;
using System.Text;
using Hl7.Cql.Packaging;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Packager;

internal class OptionsConsoleDumper(
    ILogger<OptionsConsoleDumper> logger,
    IOptions<PackagerCliOptions> packagerCliProgramOptions,
    IOptions<CqlToResourcePackagingOptions> cqlToResourcePackagingOptions,
    IOptions<FhirResourceWriterOptions> fhirResourceWriterOptions)
{
    private readonly PackagerCliOptions _packagerCliOptions = packagerCliProgramOptions.Value;
    private readonly CqlToResourcePackagingOptions _cqlToResourcePackagingOptions = cqlToResourcePackagingOptions.Value;
    private readonly FhirResourceWriterOptions _fhirResourceWriterOptions = fhirResourceWriterOptions.Value;

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
            // ArgFor(_options.Force),
            ArgFor(_cqlToResourcePackagingOptions.LogDebugEnabled),
            ArgFor("InDir, Cql", _cqlToResourcePackagingOptions.CqlDirectory),
            ArgFor("InDir, Elm", _cqlToResourcePackagingOptions.ElmDirectory),
            ArgFor("OutDir, CSharp", _packagerCliOptions.OutDirectoryCSharp),
            ArgFor("OutDir, Assemblies", _packagerCliOptions.OutDirectoryAssemblies),
            ArgFor("OutDir, Fhir", _fhirResourceWriterOptions.OutDirectory),
            ArgFor("Resource, CanonicalRootUrl", _cqlToResourcePackagingOptions.CanonicalRootUrl),
            ArgFor("Fhir, OverrideDate", _fhirResourceWriterOptions.OverrideDate),
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