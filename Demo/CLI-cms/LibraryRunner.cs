using CLI_cms.Helpers;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace CLI_cms;
internal static class LibraryRunner
{
    private static readonly IDictionary<string, object> MY2022 =
        new Dictionary<string, object>
        {
                        {
                            "Measurement Period",
                            new CqlInterval<CqlDateTime>(
                                new CqlDateTime(2022, 1, 1, 0, 0, 0, 0, 0, 0),
                                new CqlDateTime(2022, 12, 31, 0, 0, 0, 0, 0, 0),
                                true,
                                true
                            )
                        }
        };

    internal static void Run(CommandLineOptions opt)
    {
        var library = Path.GetFileNameWithoutExtension(opt.LibraryFile);
        var libraryDirectory = Path.GetDirectoryName(opt.LibraryFile);
        var parts = library.Split('-');
        var lib = parts[0];
        var version = parts[1];
        var dir = new DirectoryInfo(libraryDirectory!);
        var asmContext = ResourceHelper.LoadResources(dir, lib, version);

        var valueSets = ResourceHelper.LoadValueSets(new DirectoryInfo(opt.ValueSetDirectory));
        var patientBundle = ResourceHelper.LoadBundle(opt.TestingBundleFile);
        var context = FhirCqlContext.ForBundle(patientBundle, MY2022, valueSets);

        var results = AssemblyLoadContextExtensions.Run(asmContext, lib, version, context);

        //var library = Path.GetFileNameWithoutExtension(opt.LibraryFile);
        //var libraryType = ResolveLibraryType(library) ?? throw new ArgumentException($"Uknown library: {library}");
        //var valueSets = ResourceHelper.LoadValueSets(new DirectoryInfo(opt.ValueSetDirectory));
        //var patientBundle = ResourceHelper.LoadBundle(opt.TestingBundleFile);

        //var setup = FhirCqlContext.ForBundle(patientBundle, MY2022, valueSets);
        //var instance = Activator.CreateInstance(libraryType, setup);
        //var values = new Dictionary<string, object>();
        //foreach (var method in libraryType.GetMethods())
        //{
        //    if (method.GetParameters().Length == 0)
        //    {
        //        var declaration = method.GetCustomAttribute<CqlDeclarationAttribute>();
        //        var valueset = method.GetCustomAttribute<CqlValueSetAttribute>();
        //        if (declaration != null && valueset == null)
        //        {
        //            var value = method.Invoke(instance, Array.Empty<object?>())!;
        //            values.Add(declaration.Name, value);
        //        }
        //    }
        //}
        //var json = JsonSerializer.Serialize(values,
        //    new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector));

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


}
