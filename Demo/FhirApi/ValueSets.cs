using Hl7.Cql.Firely;
using Hl7.Cql.ValueSetLoaders;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;

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
