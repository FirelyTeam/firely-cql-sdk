using Hl7.Fhir.Model;
using Hl7.Cql.Model;
using System.Reflection;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Utility;
using Ratio = Hl7.Fhir.Model.Ratio;

namespace Cql.Firely
{
    public class FirelyTypeResolver : ModelTypeResolver
    {
        public override IEnumerable<Assembly> ModelAssemblies => throw new NotImplementedException();

        public override IEnumerable<string> ModelNamespaces => throw new NotImplementedException();

        public FirelyTypeResolver(Hl7.Cql.Model.ModelInfo model) : base(model)
        {
            var x = typeof(Ratio).Assembly;
            AddTypes(typeof(Resource).Assembly);
            AddTypes(typeof(DataType).Assembly);

        }

        public override PropertyInfo? GetProperty(Type type, string propertyName)
        {
            return base.GetProperty(type, propertyName);
        }

        private void AddTypes(Assembly assembly)
        {
            foreach(var type in assembly.GetTypes())
            {
                Add(type);
            }
            Types["{http://hl7.org/fhir}SimpleQuantity"] = Types["{http://hl7.org/fhir}Quantity"];
            Types["{http://hl7.org/fhir}MoneyQuantity"] = Types["{http://hl7.org/fhir}Quantity"];
        }

        private void Add(Type type)
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
