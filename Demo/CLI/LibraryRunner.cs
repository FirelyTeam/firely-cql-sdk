using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System.Reflection;
using System.Text.Json;

namespace CLI
{
    internal static class LibraryRunner
    {
        private static readonly JsonSerializerOptions Options = new JsonSerializerOptions()
            .ForFhir(ModelInfo.ModelInspector);
        public static T ParseFhir<T>(this Stream stream) => JsonSerializer.Deserialize<T>(stream, Options)
            ?? throw new ArgumentException($"Unable to deserialize this stream as {typeof(T).Name}");

        internal static void Run(string library, Bundle bundle, TextWriter output)
        {
            var type = ResolveLibraryType(library) ?? throw new ArgumentException($"Uknown library: {library}");
            var setup = FhirCqlContext.ForBundle(bundle, MY2023, ValueSets.Value,
                new DateTimeOffset(2023, 12, 31, 23, 59, 59, default));
            var instance = Activator.CreateInstance(type, setup);
            var values = new Dictionary<string, object>();
            foreach (var method in type.GetMethods())
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

            output.WriteLine(json);
        }

        private static readonly IDictionary<string, object> MY2023 =
            new Dictionary<string, object>
            {
                        {
                            "Measurement Period",
                            new CqlInterval<CqlDateTime>(
                                new CqlDateTime(2023, 1, 1, 0, 0, 0, 0, 0, 0),
                                new CqlDateTime(2023, 12, 31, 0, 0, 0, 0, 0, 0),
                                true,
                                true)
                        }
            };

        private static Type? ResolveLibraryType(string library)
        {
            var parts = library.Split('-');
            var name = parts[0];
            var version = parts[1];

            var type = Assembly.Load("Measures.Demo")
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

        internal static Lazy<IValueSetDictionary> ValueSets => new(() =>
        {
            var asm = typeof(LibraryRunner).Assembly;
            var names = asm.GetManifestResourceNames();
            var valueSets = new List<ValueSet>();
            foreach (var name in names)
            {
                if (name.Contains(".ValueSets."))
                {
                    var stream = asm.GetManifestResourceStream(name) ?? throw new InvalidOperationException($"Cannot find manifest {name}.");
                    var valueSet = stream.ParseFhir<ValueSet>();
                    valueSets.Add(valueSet);
                }
            }
            var dictionary = valueSets.ToValueSetDictionary();
            return dictionary;
        });

    }
}
