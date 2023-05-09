using Ncqa.Cql.Model;
using Ncqa.Cql.Runtime.Model;
using Ncqa.Fhir;
using Ncqa.Fhir.R4.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ncqa.Cql.Runtime.FhirR4
{
    public class FhirTypeResolver : ModelTypeResolver
    {
        public static readonly FhirTypeResolver Default = new();

        public FhirTypeResolver() : this(Models.Fhir401)
        {
        }

        public FhirTypeResolver(ModelInfo? model = null): base(model ?? Models.Fhir401)
        {
            MapTypes(typeof(Resource))
            .MapTypes(typeof(Element))
            .Adjust();
        }

        internal IDictionary<Type, string> TypeSpecifiers { get; } = new Dictionary<Type, string>();

        protected FhirTypeResolver MapTypes(Type baseType)
        {
            var derivedTypes = baseType.Assembly
                .GetTypes()
                .Where(t => baseType.IsAssignableFrom(t));

            MapTypes(derivedTypes);
            return this;
        }

        private void MapTypes(IEnumerable<Type> derivedTypes)
        {
            foreach (var type in derivedTypes)
            {
                MapType(type);
                MapTypes(type.GetNestedTypes());
            }
        }

        private FhirTypeResolver Adjust()
        {
            Types["{http://hl7.org/fhir}SimpleQuantity"] = typeof(Quantity);
            Types["{http://hl7.org/fhir}MoneyQuantity"] = typeof(Quantity);
            return this;
        }

        private void MapType(Type type)
        {
            var fhirUriAttributes = type.GetCustomAttributes(typeof(FhirUriAttribute), false)
                .Cast<FhirUriAttribute>();
            foreach (var fhirUriAttribute in fhirUriAttributes)
            {
                // http://hl7.org/fhir/StructureDefinition/ is 40 characters long
                var resourceName = fhirUriAttribute.Uri.Substring(40);
                var key = $"{{http://hl7.org/fhir}}{resourceName}";
                Types.Add(key, type);
                TypeSpecifiers.Add(type, key);
            }
            MapBoundProperties(type);
        }

        private void MapBoundProperties(Type type)
        {
            // Value set bindings to CodeElement properties are used in the generated elm as 1st class types.
            foreach (var property in type.GetProperties())
            {
                if (property.PropertyType == typeof(CodeElement)
                    || property.PropertyType == typeof(ICollection<CodeElement>))
                {
                    var valueSetBindings = property
                        .GetCustomAttributes(typeof(ValueSetBindingAttribute), false)
                        .Cast<ValueSetBindingAttribute>();
                    foreach (var binding in valueSetBindings)
                    {
                        var normalizedName = binding.Name.Replace('-', '_');
                        var modelUrl = $"{{http://hl7.org/fhir}}{normalizedName}";
                        if (!Types.TryGetValue(modelUrl, out var existing))
                        {
                            Types.Add(modelUrl, typeof(CodeElement));
                        }
                    }
                }
            }
        }
    }
}
