using CLI_cms.Helpers;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using System.Reflection;
using System.Text;
using System.Text.Json;
using Dumpify;

namespace CLI_cms;
internal static class LibraryRunner
{
    internal static void Run(CommandLineOptions opt)
    {
        // /* 1st try */
        // var libraryType = ResolveLibraryType(opt.Library) ?? throw new ArgumentException($"Uknown library: {opt.Library}");
        // var valueSets = ResourceHelper.LoadValueSets(new DirectoryInfo(opt.ValueSetDirectory));
        // var patientBundle = ResourceHelper.LoadBundle(opt.TestCaseBundleFile);
        // var inputParameters = LoadInputParameters(opt.TestCaseInputParametersFile);
        //
        // var setup = FhirCqlContext.ForBundle(patientBundle, inputParameters, valueSets);
        // var instance = Activator.CreateInstance(libraryType, setup);
        // var values = new Dictionary<string, object>();
        // foreach (var method in libraryType.GetMethods())
        // {
        //     if (method.GetParameters().Length == 0)
        //     {
        //         var declaration = method.GetCustomAttribute<CqlDeclarationAttribute>();
        //         var valueset = method.GetCustomAttribute<CqlValueSetAttribute>();
        //         if (declaration != null && valueset == null)
        //         {
        //             var value = method.Invoke(instance, Array.Empty<object?>())!;
        //             values.Add(declaration.Name, value);
        //         }
        //     }
        // }
        // var json = JsonSerializer.Serialize(values,
        //     new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector));

        //* 2nd try */
        var libraryType = ResolveLibraryType(opt.Library) ?? throw new ArgumentException($"Uknown library: {opt.Library}");
        //var asmContext = ResourceHelper.LoadResources(new DirectoryInfo(opt.LibraryDirectory), opt.LibraryName, opt.LibraryVersion);
        var valueSets = ResourceHelper.LoadValueSets(new DirectoryInfo(opt.ValueSetDirectory));
        var patientBundle = ResourceHelper.LoadBundle(opt.TestCaseBundleFile);
        var inputParameters = LoadInputParameters(opt.TestCaseInputParametersFile);

        var setup = FhirCqlContext.ForBundle(patientBundle, inputParameters, valueSets);
        var instance = Activator.CreateInstance(libraryType, setup);
        var values = new Dictionary<string, object>();
        foreach (var method in libraryType.GetMethods())
        {
            if (method.GetParameters().Length == 0)
            {
                var declaration = method.GetCustomAttribute<CqlDeclarationAttribute>();
                var valueset = method.GetCustomAttribute<CqlValueSetAttribute>();
                if (declaration != null && valueset == null)
                {
                    try
                    {
                        var value = method.Invoke(instance, [])!;
                        values.Add(declaration.Name, value);
                        // Console.WriteLine($"{opt.Library}.{method.Name} = {value}");
                    }
                    catch (Exception e)
                    {
                        // Console.WriteLine($"{opt.Library}.{method.Name} = {e}");
                        values.Add(declaration.Name, e);
                    }
                }
            }
        }

        values.DumpConsole($"Method/Value or Errors for {opt.Library}");

        // var json = JsonSerializer.Serialize(values,
        //     new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector));

        /* 2nd try */
        //var asmContext = ResourceHelper.LoadResources(new DirectoryInfo(opt.LibraryDirectory), opt.LibraryName, opt.LibraryVersion);

        //var valueSets = ResourceHelper.LoadValueSets(new DirectoryInfo(opt.ValueSetDirectory));
        //var patientBundle = ResourceHelper.LoadBundle(opt.TestCaseBundleFile);
        //var inputParameters = LoadInputParameters(opt.TestCaseInputParametersFile);
        //var context = FhirCqlContext.ForBundle(patientBundle, inputParameters, valueSets);
        //var results = AssemblyLoadContextExtensions.Run(asmContext, opt.LibraryName, opt.LibraryVersion, context);
    }

    private static Type? ResolveLibraryType(string library)
    {
        var parts = library.Split('-');
        var name = parts[0];
        var version = parts[1];

        var type = Assembly.Load("Measures-cms")
            .GetTypes()
            .SingleOrDefault(t =>
            {
                var libAttr = t.GetCustomAttribute<CqlLibraryAttribute>(false);
                if (libAttr != null)
                {
                    if (string.Equals(libAttr.Identifier, name, StringComparison.OrdinalIgnoreCase)
                        && string.Equals(libAttr.Version, version, StringComparison.OrdinalIgnoreCase))
                        return true;
                }
                return false;
            });

        return type;
    }

    private static IDictionary<string, object> LoadInputParameters(string inputParameterFile)
    {
        var parameters = new Dictionary<string, object>();

        var jsonData = File.ReadAllText(inputParameterFile, Encoding.UTF8);
        using (JsonDocument document = JsonDocument.Parse(jsonData))
        {
            var root = document.RootElement;

            // extract input parameter "Measurement Period"
            if (root.TryGetProperty("Measurement Period", out JsonElement period))
            {
                JsonElement start;
                if (!period.TryGetProperty("Start", out start))
                {
                    throw new ArgumentException($"Cannot find parameter 'Measurement Period'.Start in file '{inputParameterFile}'.");
                }
                JsonElement end;
                if (!period.TryGetProperty("End", out end))
                {
                    throw new ArgumentException($"Cannot find parameter 'Measurement Period'.end in file '{inputParameterFile}'.");
                }

                CqlDateTime startCqlDateTime;
                if (!CqlDateTime.TryParse(start.GetString()!, out startCqlDateTime!))
                {
                    throw new ArgumentException($"Cannot convert parameter 'Measurement Period'.start in file '{inputParameterFile}' to CqlDateTime.");
                }
                CqlDateTime endCqlDateTime;
                if (!CqlDateTime.TryParse(end.GetString()!, out endCqlDateTime!))
                {
                    throw new ArgumentException($"Cannot convert parameter 'Measurement Period'.end in file '{inputParameterFile}' to CqlDateTime.");
                }

                parameters.Add(
                    "Measurement Period",
                    new CqlInterval<CqlDateTime>(
                        startCqlDateTime,
                        endCqlDateTime,
                        true,
                        true
                    ));
            }
            else
            {
                throw new ArgumentException($"Cannot find parameter 'Measurement Period' in file '{inputParameterFile}'");
            }
        }

        return parameters;
    }
}
