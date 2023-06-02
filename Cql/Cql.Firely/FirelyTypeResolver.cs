using Hl7.Cql.Runtime;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using System.Reflection;

namespace Cql.Firely
{

    // TODO: for type mappings, we need to be sure we include this exception
    /// <summary>
    /// The list of elements that would normally be represented using a CodeOfT enum, but that we
    /// want to be generated as a normal Code instead.
    /// </summary>
    //private readonly List<string> _codedElementOverrides = new()
    //        {
    //            "CapabilityStatement.rest.resource.type"
    //        };


    public class FirelyTypeResolver : BaseTypeResolver
    {
        public FirelyTypeResolver(ModelInspector inspector)
        {
            Inspector = inspector;

            addTypesFromInspector();
            addProfiledTypesAsQuantity();
        }

        public override IEnumerable<Assembly> ModelAssemblies => Inspector.ClassMappings.Select(cm => cm.NativeType.Assembly).Distinct();
        public override IEnumerable<string> ModelNamespaces => new[] { "Hl7.Fhir.Model" };

        /// <summary>
        /// Returns the concrete property for the given property name.
        /// </summary>
        /// <returns>The property, or <c>null</c> if the type or property is unknown.</returns>
        protected override PropertyInfo? GetPropertyCore(Type type, string propertyName)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Code<>) && propertyName == "value")
            {
                return ReflectionHelper.FindProperty(type, "Value");
            }

            var cm = Inspector.FindClassMapping(type);
            if (cm is null) return null;

            if (propertyName == "value" && cm.PrimitiveValueProperty is { } valueProp)
            {
                return valueProp.NativeProperty;
            }
            else
            {
                return cm.FindMappedElementByName(propertyName)?.NativeProperty;
            }

        }

        public override PropertyInfo? GetPrimaryCodePath(string typeSpecifier)
        {
            var type = ResolveType(typeSpecifier);
            if (type is null) return null;

            var mapping = Inspector.FindClassMapping(type);

            return mapping
                ?.PrimaryCodePath
                ?.NativeProperty;
        }

        public override Type? PatientType => Inspector.PatientMapping?.NativeType;

        public override PropertyInfo? PatientBirthDateProperty =>
            Inspector.PatientMapping
                    ?.PatientBirthDateMapping
                    ?.NativeProperty;

        public ModelInspector Inspector { get; }

        private void addProfiledTypesAsQuantity()
        {
            Types["{http://hl7.org/fhir}SimpleQuantity"] = Types["{http://hl7.org/fhir}Quantity"];
            Types["{http://hl7.org/fhir}MoneyQuantity"] = Types["{http://hl7.org/fhir}Quantity"];
        }

        private void addTypesFromInspector()
        {
            var classes = Inspector.ClassMappings.Where(cm => cm.CqlTypeSpecifier is not null).Select(cm => (cm.CqlTypeSpecifier!, cm.NativeType));
            //var enums = Inspector.EnumMappings.Select(em => (em.CqlTypeSpecifier, em.NativeType));
            var nested = Inspector.BackboneClassMappings.Where(cm => cm.CqlTypeSpecifier is not null).Select(cm => (cm.CqlTypeSpecifier!, cm.NativeType));
            var all = classes.Concat(nested);

            // Ignore the valuesets, we have to resolve via bindings for now.
            foreach (var (name, type) in classes)
            {
                Types.TryAdd(name, type);
            }

            var bindings = from cm in Inspector.ClassMappings.Concat(Inspector.BackboneClassMappings)
                           from pm in cm.PropertyMappings
                           orderby pm.BindingName
                           where pm.BindingName is not null
                           group pm by pm.BindingName into pmg
                           select new { Name = pmg.Key, Type = pmg.First().ImplementingType };

            foreach (var binding in bindings)
            {
                var bindingName = "{http://hl7.org/fhir}" +
                    binding.Name.Replace("-", "_");

                Types.TryAdd(bindingName, binding.Type);
            }
        }
    }
}
