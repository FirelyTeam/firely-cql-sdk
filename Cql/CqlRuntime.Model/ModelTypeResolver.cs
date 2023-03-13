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
    public abstract class ModelTypeResolver : BaseTypeResolver
    {
        protected ModelTypeResolver(ModelInfo model)
        {
            Model = model;
            ClassInfo = Models.ClassesById(model);
            Properties = new Dictionary<string, PropertyInfo?>();
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
    }
}
