using Hl7.Cql.Poco.Fhir.R4.Model;
using Hl7.Cql.Poco.Fhir.R4;
using Hl7.Cql.ValueSetLoaders;
using Hl7.Cql.ValueSets;

namespace FhirApi
{
    internal static class ValueSetProvider
    {
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
                    var stream = asm.GetManifestResourceStream(name);
                    var valueSet = FhirJson.Deserialize<ValueSet>(stream);
                    valueSets.Add(valueSet);
                }
            }
            var loader = new FhirR4ValueSetLoader(valueSets, false);
            var dictionary = loader.Load();
            return dictionary;
        });
    }
}
