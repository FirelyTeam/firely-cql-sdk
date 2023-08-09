using Hl7.Cql.ValueSetLoaders;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System.Text.Json;

namespace FhirApi
{
    internal static class ValueSetProvider
    {
        private static readonly JsonSerializerOptions Options = new JsonSerializerOptions()
            .ForFhir(ModelInfo.ModelInspector);
        public static T ParseFhir<T>(this Stream stream) => JsonSerializer.Deserialize<T>(stream, Options)
            ?? throw new ArgumentException($"Unable to deserialize this stream as {typeof(T).Name}");
        public static ValueTask<T> ParseFhirAsync<T>(this Stream stream) =>
            JsonSerializer.DeserializeAsync<T>(stream, Options)!;
        public static void WriteFhir<T>(this Stream stream, T fhir) =>
            JsonSerializer.Serialize<T>(stream, fhir, Options);
        public static string ToJson<T>(this T fhir) =>
            JsonSerializer.Serialize<T>(fhir, Options);

        internal static IValueSetDictionary ValueSets => valueSets.Value;
        private static Lazy<IValueSetDictionary> valueSets => new Lazy<IValueSetDictionary>(() =>
        {
            var asm = typeof(SimpleLibraryHandler).Assembly;
            var names = asm.GetManifestResourceNames();
            var valueSets = new List<ValueSet>();
            foreach (var name in names)
            {
                if (name.StartsWith("FhirApi.ValueSets."))
                {
                    var stream = asm.GetManifestResourceStream(name)!;
                    var valueSet = stream.ParseFhir<ValueSet>();
                    valueSets.Add(valueSet);
                }
            }
            var dictionary = valueSets.ToValueSetDictionary(false);
            return dictionary;
        });
    }
}
