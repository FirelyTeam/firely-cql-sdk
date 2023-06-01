using Hl7.Cql.Runtime;
using Hl7.Fhir.Introspection;
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

            addTypesFromInspector(inspector);
            addEnumsFromInspector(inspector);

            addProfiledTypesAsQuantity();
        }

        public override IEnumerable<Assembly> ModelAssemblies => throw new NotImplementedException();
        public override IEnumerable<string> ModelNamespaces => throw new NotImplementedException();

        /// <summary>
        /// Returns the concrete property for the given property name.
        /// </summary>
        /// <returns>The property, or <c>null</c> if the type or property is unknown.</returns>
        protected override PropertyInfo? GetPropertyCore(Type type, string propertyName) =>
            Inspector
                .FindClassMapping(type)
                ?.FindMappedElementByName(propertyName)
                ?.NativeProperty;

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
                    .NativeType;

        public ModelInspector Inspector { get; }

        private void addProfiledTypesAsQuantity()
        {
            Types["{http://hl7.org/fhir}SimpleQuantity"] = Types["{http://hl7.org/fhir}Quantity"];
            Types["{http://hl7.org/fhir}MoneyQuantity"] = Types["{http://hl7.org/fhir}Quantity"];
        }

        private void addTypesFromInspector(Type type)
        {
            var fhirType = type.GetCustomAttribute<FhirTypeAttribute>();
            var fhirEnum = type.GetCustomAttribute<FhirEnumerationAttribute>();

            if (fhirType != null)
            {
                // http://hl7.org/fhir/StructureDefinition/ is 40 chars long
                var canonical = fhirType.Canonical;
                if (!string.IsNullOrWhiteSpace(canonical))
                {
                    var id = canonical.Substring(40);
                    var typeId = $"{{{Model.url}}}{id}";
                    Types.TryAdd(typeId, type);
                }
            }
            else if (fhirEnum != null)
            {
                var enumId = $"{{{Model.url}}}{fhirEnum.BindingName}";
                Types.TryAdd(enumId, type);
            }

            foreach (var nestedType in type.GetNestedTypes())
            {
                Add(nestedType);
            }
        }
    }
}
