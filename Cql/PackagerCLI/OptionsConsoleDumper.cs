using Microsoft.Extensions.Options;
using System.Runtime.CompilerServices;
using System.Text;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Packaging;
using Hl7.Cql.Packaging.PostProcessors;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Packager;

internal class OptionsConsoleDumper
{
    private readonly ILogger<OptionsConsoleDumper> _logger;
    private readonly CqlToResourcePackagingOptions _options;
    private readonly FhirResourceWriterOptions _fhirResourceWriterOptions;
    private readonly CSharpCodeWriterOptions _csharpCodeWriterOptions;

    public OptionsConsoleDumper(
        ILogger<OptionsConsoleDumper> logger,
        IOptions<CqlToResourcePackagingOptions> packagerOptions,
        IOptions<FhirResourceWriterOptions> fhirResourceWriterOptions,
        IOptions<CSharpCodeWriterOptions> csharpResourceWriterOptions)
    {
        _logger = logger;
        _options = packagerOptions.Value;
        _fhirResourceWriterOptions = fhirResourceWriterOptions.Value;
        _csharpCodeWriterOptions = csharpResourceWriterOptions.Value;
    }

    public void DumpToConsole()
    {
        StringBuilder? sb = _logger.IsEnabled(LogLevel.Information) ? new() : null;

        WriteLine("PackageCLI");
        WriteLine("- Environment -----------------------------------");
        WriteLine($"{"Current Directory",-38} : {Environment.CurrentDirectory}");
        WriteLine("- Arguments Provided ----------------------------");
        (string name, object? value)[] values = new[]
        {
            ArgFor(_options.Force),
            ArgFor(_options.Debug),
            ArgFor("Resource, CanonicalRootUrl", _options.CanonicalRootUrl),
            ArgFor("Cql, InDirectory", _options.CqlDirectory),
            ArgFor("Elm, InDirectory", _options.ElmDirectory),
            ArgFor("Fhir, OutDirectory", _fhirResourceWriterOptions.OutDirectory),
            ArgFor("Fhir, OverrideDate", _fhirResourceWriterOptions.OverrideDate),
            ArgFor("CSharp, OutDirectory", _csharpCodeWriterOptions.OutDirectory),
            ArgFor("CSharp, TypeFormat", _csharpCodeWriterOptions.TypeFormat),
        }.Where(t => t.value is not null)
        .ToArray();

        foreach (var (name, value) in values)
            WriteLine($"{name,-38} : {value}");

        if (sb is not null)
            _logger.LogInformation("{options}", sb.ToString());

        void WriteLine(string s)
        {
            sb?.AppendLine(s);
            Console.WriteLine(s);
        }
    }

    static (string name, object? value) ArgFor(object? value, [CallerArgumentExpression(nameof(value))] string name = "") => (name.Split('.').Last(), value);
    static (string name, object? value) ArgFor(string prepend, object? value, [CallerArgumentExpression(nameof(value))] string name = "") => (prepend + name.Split('.').Last(), value);

}