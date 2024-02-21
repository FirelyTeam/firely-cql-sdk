using Hl7.Cql.Packaging.ResourceWriters;
using Microsoft.Extensions.Options;
using System.Runtime.CompilerServices;
using static System.Console;

namespace Hl7.Cql.Packager;

internal class OptionsConsoleDumper
{
    private readonly PackagerOptions _packagerOptions;
    private readonly FhirResourceWriterOptions _fhirResourceWriterOptions;
    private readonly CSharpResourceWriterOptions _csharpResourceWriterOptions;

    public OptionsConsoleDumper(
        IOptions<PackagerOptions> packagerOptions,
        IOptions<FhirResourceWriterOptions> fhirResourceWriterOptions,
        IOptions<CSharpResourceWriterOptions> csharpResourceWriterOptions)
    {
        _packagerOptions = packagerOptions.Value;
        _fhirResourceWriterOptions = fhirResourceWriterOptions.Value;
        _csharpResourceWriterOptions = csharpResourceWriterOptions.Value;
    }

    public void DumpToConsole()
    {
        WriteLine("PackageCLI Arguments Provided");
        WriteLine("-----------------------------");
        (string name, object? value)[] values = new[]
        {
            ArgFor(_packagerOptions.CqlDirectory),
            ArgFor(_packagerOptions.ElmDirectory),
            ArgFor(_packagerOptions.CanonicalRootUrl),
            ArgFor(_packagerOptions.Force),
            ArgFor(_packagerOptions.Debug),
            ArgFor("Fhir", _fhirResourceWriterOptions.OutDirectory),
            ArgFor("Fhir", _fhirResourceWriterOptions.OverrideDate),
            ArgFor("CSharp", _csharpResourceWriterOptions.OutDirectory),
        }.Where(t => t.value is not null)
        .ToArray();

        foreach (var (name, value) in values) 
            WriteLine($"{name,-20} : {value}");
    }

    static (string name, object? value) ArgFor(object? value, [CallerArgumentExpression(nameof(value))] string name = "") => (name.Split('.').Last(), value);
    static (string name, object? value) ArgFor(string prepend, object? value, [CallerArgumentExpression(nameof(value))] string name = "") => (prepend + name.Split('.').Last(), value);

}