using Microsoft.Extensions.Options;
using System.Runtime.CompilerServices;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Packaging;
using static System.Console;
using Hl7.Cql.Packaging.PostProcessors;

namespace Hl7.Cql.Packager;

internal class OptionsConsoleDumper
{
    private readonly CqlToResourcePackagingOptions _options;
    private readonly FhirResourceWriterOptions _fhirResourceWriterOptions;
    private readonly CSharpCodeWriterOptions _csharpCodeWriterOptions;

    public OptionsConsoleDumper(
        IOptions<CqlToResourcePackagingOptions> packagerOptions,
        IOptions<FhirResourceWriterOptions> fhirResourceWriterOptions,
        IOptions<CSharpCodeWriterOptions> csharpResourceWriterOptions)
    {
        _options = packagerOptions.Value;
        _fhirResourceWriterOptions = fhirResourceWriterOptions.Value;
        _csharpCodeWriterOptions = csharpResourceWriterOptions.Value;
    }

    public void DumpToConsole()
    {
        WriteLine("PackageCLI");
        WriteLine("- Environment -----------------------------------");
        WriteLine("{0,-20} : {1}", "Current Directory", Environment.CurrentDirectory);
        WriteLine("- Arguments Provided ----------------------------");
        (string name, object? value)[] values = new[]
        {
            ArgFor(_options.CqlDirectory),
            ArgFor(_options.ElmDirectory),
            ArgFor(_options.CanonicalRootUrl),
            ArgFor(_options.Force),
            ArgFor(_options.Debug),
            ArgFor("Fhir", _fhirResourceWriterOptions.OutDirectory),
            ArgFor("Fhir", _fhirResourceWriterOptions.OverrideDate),
            ArgFor("CSharp", _csharpCodeWriterOptions.OutDirectory),
        }.Where(t => t.value is not null)
        .ToArray();

        foreach (var (name, value) in values) 
            WriteLine($"{name,-20} : {value}");
    }

    static (string name, object? value) ArgFor(object? value, [CallerArgumentExpression(nameof(value))] string name = "") => (name.Split('.').Last(), value);
    static (string name, object? value) ArgFor(string prepend, object? value, [CallerArgumentExpression(nameof(value))] string name = "") => (prepend + name.Split('.').Last(), value);

}