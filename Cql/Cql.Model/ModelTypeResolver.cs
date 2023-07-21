/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using System;
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
