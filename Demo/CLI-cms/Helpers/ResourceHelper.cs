using Hl7.Cql.Fhir;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System.Runtime.Loader;
using System.Text.Json;
using Library = Hl7.Fhir.Model.Library;

namespace CLI_cms.Helpers;

internal class ResourceHelper
{
    public static readonly IFhirSerializationEngine FirelySerializer =
     FhirSerializationEngineFactory.Ostrich(ModelInfo.ModelInspector);

    public static readonly JsonSerializerOptions JsonSerializerOptions =
        new JsonSerializerOptions()
            .ForFhir(new FhirJsonPocoDeserializerSettings
            {
                Validator = null
            });

    public static Bundle LoadBundle(string bundleFile)
    {
        byte[] byteArray = File.ReadAllBytes(bundleFile);
        using var bundleStream = new MemoryStream(byteArray);
        using var sr = new StreamReader(bundleStream);
        var json = sr.ReadToEnd();
        var bundle = FirelySerializer.DeserializeFromJson(json) as Bundle
            ?? throw new ArgumentException($"Provided stream is not a bundle resource");

        return bundle;
    }

    public static IValueSetDictionary LoadValueSets(DirectoryInfo directory)
    {
        var valueSets = new List<ValueSet>();
        foreach (var file in directory.GetFiles("*.json"))
        {
            using var fs = file.OpenRead();
            var resource = JsonSerializer.Deserialize<Resource>(fs, JsonSerializerOptions);
            if (resource is Bundle bundle)
                valueSets.AddRange(bundle.Entry.Select(e => e.Resource).OfType<ValueSet>());
            else if (resource is ValueSet valueSet)
                valueSets.Add(valueSet);
        }
        var vsd = valueSets.ToValueSetDictionary(false);
        return vsd;
    }

    public static AssemblyLoadContext LoadResources(DirectoryInfo dir, string lib, string version)
    {
        var libFile = new FileInfo(Path.Combine(dir.FullName, $"{lib}-{version}.json"));
        using var fs = libFile.OpenRead();
        var library = fs.ParseFhir<Library>();
        var dependencies = library.GetDependencies(dir);
        var allLibs = dependencies.AllLibraries();
        var asmContext = new AssemblyLoadContext($"{lib}-{version}");
        allLibs.LoadAssemblies(asmContext);

        var tupleTypes = new FileInfo(Path.Combine(dir.FullName, "TupleTypes-Binary.json"));
        using var tupleFs = tupleTypes.OpenRead();
        var binaries = new[]
        {
                tupleFs.ParseFhir<Binary>()
            };

        binaries.LoadAssembles(asmContext);
        return asmContext;
    }
}
