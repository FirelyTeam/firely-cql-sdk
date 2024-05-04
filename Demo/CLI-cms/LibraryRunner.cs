﻿using CLI_cms.Helpers;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace CLI_cms;
internal static class LibraryRunner
{
    internal static void Run(CommandLineOptions opt)
    {
        //var library = Path.GetFileNameWithoutExtension(opt.Library);
        //var libraryDirectory = Path.GetDirectoryName(opt.Library);
        //var parts = library.Split('-');
        //var lib = parts[0];
        //var version = parts[1];
        //var dir = new DirectoryInfo(libraryDirectory!);
        //var asmContext = ResourceHelper.LoadResources(dir, lib, version);

        //var valueSets = ResourceHelper.LoadValueSets(new DirectoryInfo(opt.ValueSetDirectory));
        //var patientBundle = ResourceHelper.LoadBundle(opt.TestingBundleFile);
        //var context = FhirCqlContext.ForBundle(patientBundle, MY2022, valueSets);

        //var results = AssemblyLoadContextExtensions.Run(asmContext, lib, version, context);

        var libraryType = ResolveLibraryType(opt.Library) ?? throw new ArgumentException($"Uknown library: {opt.Library}");
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
                    var value = method.Invoke(instance, Array.Empty<object?>())!;
                    values.Add(declaration.Name, value);
                }
            }
        }
        var json = JsonSerializer.Serialize(values,
            new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector));

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
