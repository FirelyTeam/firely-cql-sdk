using Hl7.Cql.Poco.Fhir.R4;
using Hl7.Cql.Poco.Fhir.R4.Model;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.FhirR4;
using Hl7.Cql.ValueSetLoaders;
using Hl7.Cql.ValueSets;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Text;

namespace FhirApi
{
    public static class LibraryHandler
    {
        public static IResult Evaluate(Parameters @in)
        {
            Parameters? parameters = null;
            var library = @in.parameter?.SingleOrDefault(p => p.name == "library");
            if (library != null
                && library.value is StringElement stringElement
                && !string.IsNullOrWhiteSpace(stringElement.value))
            {
                switch (stringElement.value.ToLowerInvariant())
                {
                    case "bcsehedismy2022-1.0.0":
                        parameters = RunBCSE(@in);
                        break;
                    default:
                        return Results.NotFound();
                }
            }
            else return Results.BadRequest();

            var json = FhirJson.SerializeToString(parameters);
            return Results
               .Content(json, "application/fhir+json", Encoding.UTF8);
        }

        private static IDictionary<string, object> MY2023 =
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
        private static Parameters? RunBCSE(Parameters @in)
        {
            var subject = @in.parameter
                .SingleOrDefault(p => p.name == "subject");
            if (subject != null && subject.value is IdElement id)
            {
                var dataStream = typeof(LibraryHandler)
                    .Assembly
                    .GetManifestResourceStream(id.value);
                if (dataStream != null)
                {
                    var @out = new Parameters
                    {
                        parameter = new List<Parameters.ParameterComponent>()
                    };
                    var bundle = FhirJson.Deserialize<Bundle>(dataStream);
                    var valueSets = ValueSets.Value;
                    var context = FhirRuntimeContext.Create(bundle,
                        MY2023,
                        valueSets,
                        new DateTimeOffset(2023, 12, 31, 23, 59, 59, default));
                    var bcse = new BCSEHEDISMY2022_1_0_0(context);
                    @out.parameter.Add(new Parameters.ParameterComponent
                    {
                        name = "Numerator",
                        value = new BooleanElement { value = bcse.Numerator() }
                    });
                    return @out;
                }
                else throw new InvalidOperationException($"Subject {id.value} not found");
            }
            else throw new InvalidOperationException($"Subject not specified");

        }

        internal static Lazy<IValueSetDictionary> ValueSets => new Lazy<IValueSetDictionary>(() =>
        {
            var asm = typeof(LibraryHandler).Assembly;
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
