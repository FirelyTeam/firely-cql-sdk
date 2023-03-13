using System;
using System.Reflection;

namespace Ncqa.Cql.Runtime
{
    public abstract class TypeResolver
    {
        #region CQL types defined in section 1
        public abstract Type AnyType { get; }
        public abstract Type BooleanType { get; }
        public abstract Type CodeType { get; }
        public abstract Type CodeSystemType { get; }
        public abstract Type ConceptType { get; }
        public abstract Type DateType { get; }
        public abstract Type DateTimeType { get; }
        public abstract Type DecimalType { get; }
        public abstract Type LongType { get; }
        public abstract Type IntervalType(Type pointType);
        public abstract Type IntegerType { get; }
        public abstract Type QuantityType { get; }
        public abstract Type RatioType { get; }
        public abstract Type StringType { get; }
        public abstract Type TimeType { get; }
        public abstract Type ValueSetType { get; }
        public abstract Type VocabularyType { get; }

        #endregion

        public abstract Type? ResolveType(string typeSpecifier);
        public abstract PropertyInfo? GetPrimaryCodePath(string typeSpecifier);

        public abstract PropertyInfo? GetProperty(Type type, string propertyName);
        public abstract bool IsListType(Type type, Type genericInterfaceTypeDefinition);
        public abstract Type? GetElementType(Type type, bool @throw);
        public abstract Type? GetElementType(Type type);
    }
}
