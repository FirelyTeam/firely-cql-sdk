/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using System.Reflection;

namespace Hl7.Cql.Firely
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
            // Fix lack of inheritance in the SDK
            adjust();
        }

        public override IEnumerable<Assembly> ModelAssemblies => Inspector.ClassMappings.Select(cm => cm.NativeType.Assembly).Distinct();
        public override IEnumerable<string> ModelNamespaces => new[] { "Hl7.Fhir.Model" };

        public override IEnumerable<(string alias, string type)> Aliases => base.Aliases
            .Concat(new[]
            {
                ("Range", typeof(Hl7.Fhir.Model.Range).FullName!),
                ("Task", typeof(Hl7.Fhir.Model.Task).FullName!),
            });

        /// <summary>
        /// Returns the concrete property for the given property name.
        /// </summary>
        /// <returns>The property, or <c>null</c> if the type or property is unknown.</returns>
        protected override PropertyInfo? GetPropertyCore(Type type, string propertyName)
        {
            PropertyInfo? result = null;
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Code<>) && propertyName == "value")
            {
                result = ReflectionHelper.FindProperty(type, "Value");
            }
            else
            {
                var cm = Inspector.FindClassMapping(type);
                if (cm != null)
                {
                    if (propertyName == "value" && cm.PrimitiveValueProperty is { } valueProp)
                    {
                        result = valueProp.NativeProperty;
                    }
                    else
                    {
                        result = cm.FindMappedElementByName(propertyName)?.NativeProperty;
                    }
                }
                else
                {
                    var @base = base.GetPropertyCore(type, propertyName);
                    result = @base;
                }
            }
            if (result == null)
            {
            }
            return result;
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

        public override bool ImplementsGenericInterface(Type type, Type genericInterfaceTypeDefinition)
        {
            if (genericInterfaceTypeDefinition == typeof(IEnumerable<>)
                && type.GetCustomAttribute<FhirTypeAttribute>() != null)
                return false;
            return base.ImplementsGenericInterface(type, genericInterfaceTypeDefinition);
        }

        public ModelInspector Inspector { get; }

        internal IDictionary<Type, string> TypeSpecifiers { get; } = new Dictionary<Type, string>();

        private void adjust()
        {
            Types["{http://hl7.org/fhir}positiveInt"] = typeof(Hl7.Fhir.Model.Integer);
            Types["{http://hl7.org/fhir}unsignedInt"] = typeof(Hl7.Fhir.Model.Integer);

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
                TypeSpecifiers.TryAdd(type, name);
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
                TypeSpecifiers.TryAdd(binding.Type, bindingName);

            }
        }
    }
}
