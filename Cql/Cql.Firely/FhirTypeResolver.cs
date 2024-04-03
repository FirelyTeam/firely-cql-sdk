#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using Hl7.FhirPath.Sprache;
using System.Reflection;

namespace Hl7.Cql.Fhir
{
    public class FhirTypeResolver : BaseTypeResolver
    {
        public static readonly FhirTypeResolver Default = new FhirTypeResolver(ModelInfo.ModelInspector);

        internal FhirTypeResolver(ModelInspector inspector)
        {
            Inspector = inspector;

            addTypesFromInspector();
            // Fix lack of inheritance in the SDK
            adjust();
        }

        public override bool ImplementsGenericInterface(Type type, Type genericInterfaceTypeDefinition)
        {
            if (genericInterfaceTypeDefinition == typeof(IEnumerable<>)
                && type.GetCustomAttribute<FhirTypeAttribute>() != null)
                return false;
            return base.ImplementsGenericInterface(type, genericInterfaceTypeDefinition);
        }


        internal override IEnumerable<Assembly> ModelAssemblies => Inspector.ClassMappings.Select(cm => cm.NativeType.Assembly).Distinct();
        internal override IEnumerable<string> ModelNamespaces => new[] { "Hl7.Fhir.Model" };

        internal override IEnumerable<(string alias, string type)> Aliases => base.Aliases
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
                        var propMapping = cm.FindMappedElementByName(propertyName);
                        if (propMapping is not null)
                            result = new FhirModelPropertyInfo(propMapping.NativeProperty, propMapping);
                    }
                }
                else
                {
                    var @base = base.GetPropertyCore(type, propertyName);
                    result = @base;
                }
            }

            return result;
        }

        internal override PropertyInfo? GetPrimaryCodePath(string typeSpecifier)
        {
            // This is not used by the data source, but we'll implement it nonetheless.
            var specifiedType = ResolveType(typeSpecifier);
            if (specifiedType == null) return null;

            var codeInterfaceType = typeof(ICoded<>).MakeGenericType(specifiedType);
            var codeProperty = codeInterfaceType.GetProperty("Code", BindingFlags.Instance | BindingFlags.Public);

            return codeProperty;
        }

        /// <summary>
        /// Returns a boolean indicating if we should use the type instead of the property
        /// </summary>
        internal override bool ShouldUseSourceObject(Type type, string propertyName)
        {
            // only handling FhirDateTime to avoid string conversions which are expensive
            return type == typeof(FhirDateTime) && propertyName == "value";
        }

        internal override Type? PatientType => Inspector.PatientMapping?.NativeType;

        internal override PropertyInfo? PatientBirthDateProperty => typeof(IPatient).GetProperty(nameof(IPatient.BirthDate));

        internal ModelInspector Inspector { get; }

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
            var classes = Inspector.ClassMappings.Select(cm => (getTypeSpecFromMapping(cm), cm.NativeType));

            static string getTypeSpecFromMapping(ClassMapping cm)
            {
                string fhirPrefix = "{http://hl7.org/fhir}";
                return cm.IsBackboneType switch
                {
                    false => fhirPrefix + cm.Name,
                    true => fhirPrefix + cm.DefinitionPath
                };
            }

            // Ignore the valuesets, we have to resolve via bindings for now.
            foreach (var (name, type) in classes)
            {
                Types.TryAdd(name, type);
                TypeSpecifiers.TryAdd(type, name);
            }

            var bindings = from cm in Inspector.ClassMappings
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
