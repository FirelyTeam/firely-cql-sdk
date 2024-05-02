/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Fhir.Introspection;
using System.Globalization;
using System.Reflection;

namespace Hl7.Cql.Fhir
{
    internal class FhirModelPropertyInfo : PropertyInfo
    {
        private readonly PropertyInfo propertyInfo;

        public FhirModelPropertyInfo(PropertyInfo propertyInfo, PropertyMapping mapping)
        {
            this.propertyInfo = propertyInfo;
            Mapping = mapping;
        }

        public override PropertyAttributes Attributes => propertyInfo.Attributes;

        public override bool CanRead => propertyInfo.CanRead;

        public override bool CanWrite => propertyInfo.CanWrite;

        public override Type PropertyType => propertyInfo.PropertyType;

        public override Type? DeclaringType => propertyInfo.DeclaringType;

        public override string Name => propertyInfo.Name;

        public override Type? ReflectedType => propertyInfo.ReflectedType;

        public PropertyMapping Mapping { get; }

        public override MethodInfo[] GetAccessors(bool nonPublic)
        {
            return propertyInfo.GetAccessors(nonPublic);
        }

        public override object[] GetCustomAttributes(bool inherit)
        {
            return propertyInfo.GetCustomAttributes(inherit);
        }

        public override object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            return propertyInfo.GetCustomAttributes(attributeType, inherit);
        }

        public override MethodInfo? GetGetMethod(bool nonPublic)
        {
            return propertyInfo.GetGetMethod(nonPublic);
        }

        public override ParameterInfo[] GetIndexParameters()
        {
            return propertyInfo.GetIndexParameters();
        }

        public override MethodInfo? GetSetMethod(bool nonPublic)
        {
            return propertyInfo.GetSetMethod(nonPublic);
        }

        // Override to call the mappings GetValue, which is a fast ILEmitted getter
        public override object? GetValue(object? obj, BindingFlags invokeAttr, Binder? binder, object?[]? index, CultureInfo? culture) =>
            obj is not null ? Mapping.GetValue(obj) : null;

        public override bool IsDefined(Type attributeType, bool inherit)
        {
            return propertyInfo.IsDefined(attributeType, inherit);
        }

        // Override to call the mappings SetValue, which is a fast ILEmitted setter
        public override void SetValue(object? obj, object? value, BindingFlags invokeAttr, Binder? binder, object?[]? index, CultureInfo? culture)
        {
            if (obj is not null)
                Mapping.SetValue(obj, value);
        }
    }
}
