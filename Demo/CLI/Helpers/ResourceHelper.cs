/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Dumpify;
using Hl7.Cql.Conversion;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System.Runtime.Loader;
using System.Text.Json;
using static Hl7.Fhir.Model.Parameters;
using Library = Hl7.Fhir.Model.Library;

namespace CLI.Helpers;

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
        foreach (var file in directory.GetFiles("*.json", SearchOption.AllDirectories))
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

    public static AssemblyLoadContext LoadResources(
        DirectoryInfo dir,
        string lib,
        string version)
    {
        var libFile = new FileInfo(Path.Combine(dir.FullName, $"{lib}-{version}.json"));
        using var fs = libFile.OpenRead();
        var library = fs.ParseFhir<Library>();
        //var dependencies = library.GetDependencies(dir);

        var deps = library.GetDependenciesAndSelf(dir);

        //var allLibs = dependencies.AllLibraries();
        var asmContext = new AssemblyLoadContext($"{lib}-{version}");
        //allLibs.LoadAssemblies(asmContext);
        deps.LoadAssemblies(asmContext);

        var tupleTypes = new FileInfo(Path.Combine(dir.FullName, "TupleTypes-Binary.json"));
        using var tupleFs = tupleTypes.OpenRead();
        var binaries = new[]
        {
            tupleFs.ParseFhir<Binary>()
        };     

        binaries.LoadAssemblies(asmContext);
        return asmContext;
    }


    public static Bundle CreateBundle(string[] files)
    {
        var bundle = new Bundle();
        foreach (var file in files)
        {
            byte[] byteArray = File.ReadAllBytes(file);
            using var bundleStream = new MemoryStream(byteArray);
            using var sr = new StreamReader(bundleStream);
            var json = sr.ReadToEnd();
            var resource = FirelySerializer.DeserializeFromJson(json) as Resource
                   ?? throw new ArgumentException($"Provided stream is not a resource");
            bundle.AddResourceEntry(resource, $"{resource.TypeName}/{resource.Id}");
        }
        return bundle;
    }

    public static IDictionary<string, object> LoadInputParameters(string inputParameterFile)
    {
        Console.WriteLine("Loading test case input parameters");
        var parametersConverted = new Dictionary<string, object>();

        if (!File.Exists(inputParameterFile))
        {
            Console.WriteLine("No input parameter file found. Parameters set to default.");
            return parametersConverted;
        }

        byte[] byteArray = File.ReadAllBytes(inputParameterFile);
        using var bundleStream = new MemoryStream(byteArray);
        using var sr = new StreamReader(bundleStream);
        var json = sr.ReadToEnd();
        var parametersResource = FirelySerializer.DeserializeFromJson(json) as Parameters
                     ?? throw new ArgumentException($"Provided stream is not a Parameters resource");

        var crosswalk = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);

        foreach ( var parameter in parametersResource.Parameter)
        {
            var cqltype = parameter.Value.GetType();
            var typeEntry = crosswalk.TypeEntryFor(cqltype);
            var converted = ConvertParameterToCqlModel(parameter, typeEntry);
            parametersConverted.Add(parameter.Name, converted!);         
        }

        parametersConverted.DumpConsole("Input Parameters");
        return parametersConverted;
    }

    internal static readonly TypeConverter FhirTypeConverter = Hl7.Cql.Fhir.FhirTypeConverter.Create(Hl7.Fhir.Model.ModelInfo.ModelInspector);
    internal static readonly CqlTypeToFhirTypeMapper CqlTypeToFhirTypeMapper = new CqlTypeToFhirTypeMapper(FhirTypeResolver.Default);
    public static object? ConvertParameterToCqlModel(ParameterComponent parameter, CqlTypeToFhirMapping? mappedType)
    {
        switch (mappedType!.CqlType)
        {
            //add other types here
            case CqlPrimitiveType.Integer:
                return FhirTypeConverter.Convert<int?>(parameter);
            case CqlPrimitiveType.Interval:
                if (mappedType.ElementType == null)
                    throw new InvalidOperationException($"Parameter {parameter.Name} cannot have type interval without an element type");
                switch (mappedType.ElementType.CqlType)
                {
                    case CqlPrimitiveType.DateTime:
                        return FhirTypeConverter.Convert<CqlInterval<CqlDateTime>>(parameter);
                    case CqlPrimitiveType.Date:
                        return FhirTypeConverter.Convert<CqlInterval<CqlDate>>(parameter);
                    case CqlPrimitiveType.Integer:
                        return FhirTypeConverter.Convert<CqlInterval<int?>>(parameter);
                    case CqlPrimitiveType.Decimal:
                        return FhirTypeConverter.Convert<CqlInterval<decimal?>>(parameter);
                    case CqlPrimitiveType.Quantity:
                        return FhirTypeConverter.Convert<CqlInterval<CqlQuantity>>(parameter);
                    default:
                        throw new InvalidOperationException($"Parameter {parameter.Name} has type interval and an invalid element type: {mappedType.ElementType.CqlType}");
                }
            default: return null;
        }
    }
}