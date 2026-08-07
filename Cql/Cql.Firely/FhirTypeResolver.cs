#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;

namespace Hl7.Cql.Fhir
{
    public class FhirTypeResolver : BaseTypeResolver
    {
        public static readonly FhirTypeResolver Default = new FhirTypeResolver(ModelInfo.ModelInspector);

        /// <nodoc />
        public FhirTypeResolver(ModelInspector inspector)
        {
            Inspector = inspector;
            _patientType = new Lazy<Type?>(() => Inspector.PatientMapping?.NativeType);

            AddTypesFromInspector();
            // Fix lack of inheritance in the SDK
            adjust();
        }

        internal override bool IsListType(Type type)
        {
            if (type.GetCustomAttribute<FhirTypeAttribute>() != null)
                return false;

            return base.IsListType(type);
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
                // Note the DeclaredOnly here, which is important to get to the Code<T>.Value property,
                // not the inherited PrimitiveType.Value property.
                result = type.GetProperty("Value", BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
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
                        if (propMapping is { NativeProperty: { } nativeProperty })
                            result = new FhirModelPropertyInfo(nativeProperty, propMapping);
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

        /// <remarks>
        /// Resolved once. Asking the inspector for its patient mapping searches its class mappings and allocates
        /// while doing so, and the age operators - which need the patient type - run per element of a query, not
        /// once per patient. Neither the inspector nor its mappings change over the lifetime of this resolver.
        /// </remarks>
        internal override Type? PatientType => _patientType.Value;

        private readonly Lazy<Type?> _patientType;

        internal override PropertyInfo? PatientBirthDateProperty => BirthDateProperty;

        // The FHIR patient model always exposes BirthDate; the nullable override type is inherited from BaseTypeResolver.
        private static readonly PropertyInfo BirthDateProperty =
            ReflectionUtility.PropertyOf(() => default(IPatient)!.BirthDate);

        private ModelInspector Inspector { get; }

        private IDictionary<Type, string> TypeSpecifiers { get; } = new Dictionary<Type, string>();

        private void adjust()
        {
            Types["{http://hl7.org/fhir}positiveInt"] = typeof(Hl7.Fhir.Model.Integer);
            Types["{http://hl7.org/fhir}unsignedInt"] = typeof(Hl7.Fhir.Model.Integer);

            Types["{http://hl7.org/fhir}SimpleQuantity"] = Types["{http://hl7.org/fhir}Quantity"];
            Types["{http://hl7.org/fhir}MoneyQuantity"] = Types["{http://hl7.org/fhir}Quantity"];
        }

        private void AddTypesFromInspector()
        {
            var classes = Inspector.ClassMappings.Select(cm => ($"{{http://hl7.org/fhir}}{cm.Name}", cm.NativeType));

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