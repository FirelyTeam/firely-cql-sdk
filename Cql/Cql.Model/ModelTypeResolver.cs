#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Hl7.Cql.Model
{
    /// <summary>
    /// This class implements <see cref="GetPrimaryCodePath"/> through the provided <see cref="ModelInfo"/>
    /// </summary>
    public abstract class ModelTypeResolver : BaseTypeResolver
    {
        protected ModelTypeResolver(ModelInfo model)
        {
            Model = model;
            patientType = new Lazy<Type?>(GetPatientType);
            patientBirthDate = new Lazy<PropertyInfo?>(GetPatientBirthdate);
        }

        public ModelInfo Model { get; }

        public override Type? PatientType => patientType.Value;
        private readonly Lazy<Type?> patientType;
        private Type? GetPatientType()
        {
            if (!string.IsNullOrWhiteSpace(Model.patientClassName))
            {
                var ns = Model.name;
                var unprefixedClassName = Model.patientClassName[(ns.Length + 2)..];
                var typeSpecifier = $"{{{Model.url}}}{unprefixedClassName}";
                var type = ResolveType(typeSpecifier);
                return type;
            }
            else if (!string.IsNullOrWhiteSpace(Model.patientClassIdentifier))
            {
                var ns = Model.name;
                var unprefixedClassName = Model.patientClassIdentifier[(ns.Length + 2)..];
                var typeSpecifier = $"{{{Model.url}}}{unprefixedClassName}";
                var type = ResolveType(typeSpecifier);
                return type;
            }
            else return null;
        }

        private readonly IDictionary<string, ClassInfo> ClassInfo = new Dictionary<string, ClassInfo>();
        private readonly IDictionary<string, PropertyInfo?> Properties = new Dictionary<string, PropertyInfo?>();

        public override PropertyInfo? GetPrimaryCodePath(string typeSpecifier)
        {
            PropertyInfo? propertyInfo = null;
            if (Properties.TryGetValue(typeSpecifier, out propertyInfo))
            {
                return propertyInfo;
            }
            else
            {
                if (ClassInfo.TryGetValue(typeSpecifier, out var classInfo)
                    && !string.IsNullOrWhiteSpace(classInfo.primaryCodePath)
                    && Types.TryGetValue(typeSpecifier, out var type))
                {
                    propertyInfo = GetProperty(type, classInfo.primaryCodePath);
                }
                Properties.Add(typeSpecifier, propertyInfo);
                return propertyInfo;
            }
        }

        public override PropertyInfo? PatientBirthDateProperty => patientBirthDate.Value;
        private readonly Lazy<PropertyInfo?> patientBirthDate;
        private PropertyInfo? GetPatientBirthdate()
        {
            var patientType = PatientType;
            if (patientType != null)
            {
                var property = GetProperty(patientType, Model.patientBirthDatePropertyName);
                return property;
            }
            else return null;
        }
    }
}
