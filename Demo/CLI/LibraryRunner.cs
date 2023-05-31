using Hl7.Cql;
using Hl7.Cql.Poco.Fhir.R4;
using Hl7.Cql.Poco.Fhir.R4.Model;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime.FhirR4;
using Hl7.Cql.ValueSetLoaders;
using Hl7.Cql.ValueSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CLI
{
    internal static class LibraryRunner
    {
        internal static void Run(string library, Bundle bundle, TextWriter output)
        {
            var type = ResolveLibraryType(library);
            if (type == null)
            {
                throw new ArgumentException($"Uknown library: {library}");
            }
            var context = FhirCqlContext.Create(bundle, MY2023, ValueSets.Value,
                new DateTimeOffset(2023, 12, 31, 23, 59, 59, default));
            var instance = Activator.CreateInstance(type, context);
            var values = new Dictionary<string, object>();
            foreach (var method in type.GetMethods())
            {
                if (method.GetParameters().Length == 0)
                {
                    var declaration = method.GetCustomAttribute<CqlDeclarationAttribute>();
                    var valueset = method.GetCustomAttribute<CqlValueSetAttribute>();
                    if (declaration != null && valueset == null)
                    {
                        var value = method.Invoke(instance, Array.Empty<object?>());
                        values.Add(declaration.Name, value);
                    }
                }
            }
            var json = FhirJson.SerializeToString(values);
            output.WriteLine(json);
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

        private static Type? ResolveLibraryType(string library)
        {
            var parts = library.Split('-');
            var name = parts[0];
            var version = parts[1];

            var type = typeof(FHIRHelpers_4_0_001).Assembly
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

        internal static Lazy<IValueSetDictionary> ValueSets => new Lazy<IValueSetDictionary>(() =>
        {
            var asm = typeof(LibraryRunner).Assembly;
            var names = asm.GetManifestResourceNames();
            var valueSets = new List<ValueSet>();
            foreach (var name in names)
            {
                if (name.Contains(".ValueSets."))
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
