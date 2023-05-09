using Ncqa.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Ncqa.Cql.Model;

namespace Ncqa.Cql.Runtime.Model
{
    /// <summary>
    /// This class implements <see cref="GetPrimaryCodePath"/> through the provided <see cref="ModelInfo"/>
    /// </summary>
    public class ModelTypeResolver : BaseTypeResolver
    {
        protected ModelTypeResolver(ModelInfo model)
        {
            Model = model;
            ClassInfo = Models.ClassesById(model);
            Properties = new Dictionary<string, PropertyInfo?>();
            patientType = new Lazy<Type?>(GetPatientType);
            patientBirthDate = new Lazy<PropertyInfo?>(GetPatientBirthdate);
        }

        public ModelInfo Model { get; }
        private readonly IDictionary<string, ClassInfo> ClassInfo;
        private readonly IDictionary<string, PropertyInfo?> Properties;

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

        public override Type? PatientType => patientType.Value;
        private Lazy<Type?> patientType;
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
        private Lazy<PropertyInfo?> patientBirthDate;
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
