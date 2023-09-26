using Hl7.Cql.Elm;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Xml;
using M = Hl7.Cql.Model;

namespace Hl7.Cql.CqlToElm
{
    internal static class SystemTypes
    {
        public static string SystemModelUri = "urn:hl7-org:elm-types:r1";
        public static string SystemModelPrefix = "System";
        public static string SystemModelVersion = "1.0.0";

        private static readonly M.ModelInfo bootstrapSystemModel = new()
        {
            url = SystemModelUri,
            version = SystemModelVersion,
            name = SystemModelPrefix
        };

        private static readonly ConcurrentDictionary<string, GenericTypeParameterTypeSpecifier> gtpTsSingletons = new();

        public static GenericTypeParameterTypeSpecifier Generic(string name) =>
            gtpTsSingletons.GetOrAdd(name, n => new GenericTypeParameterTypeSpecifier(n));

        public static XmlQualifiedName QualifiedNameForSystemType(string name)
        {
            var nameWithoutPrefix = name.StartsWith(SystemModelPrefix) ? name[SystemModelPrefix.Length..] : name;
            return bootstrapSystemModel.ToQualifiedTypeName(nameWithoutPrefix);
        }

        public static XmlQualifiedName AnyTypeQName = bootstrapSystemModel.ToQualifiedTypeName("Any");
        public static XmlQualifiedName IntegerTypeQName = bootstrapSystemModel.ToQualifiedTypeName("Integer");
        public static XmlQualifiedName LongTypeQName = bootstrapSystemModel.ToQualifiedTypeName("Long");
        public static XmlQualifiedName DecimalTypeQName = bootstrapSystemModel.ToQualifiedTypeName("Decimal");
        public static XmlQualifiedName QuantityTypeQName = bootstrapSystemModel.ToQualifiedTypeName("Quantity");
        public static XmlQualifiedName StringTypeQName = bootstrapSystemModel.ToQualifiedTypeName("String");
        public static XmlQualifiedName DateTypeQName = bootstrapSystemModel.ToQualifiedTypeName("Date");
        public static XmlQualifiedName TimeTypeQName = bootstrapSystemModel.ToQualifiedTypeName("Time");
        public static XmlQualifiedName DateTimeTypeQName = bootstrapSystemModel.ToQualifiedTypeName("DateTime");
        public static XmlQualifiedName BooleanTypeQName = bootstrapSystemModel.ToQualifiedTypeName("Boolean");
        public static XmlQualifiedName RatioTypeQName = bootstrapSystemModel.ToQualifiedTypeName("Ratio");
        public static XmlQualifiedName CodeTypeQName = bootstrapSystemModel.ToQualifiedTypeName("Code");
        public static XmlQualifiedName ConceptTypeQName = bootstrapSystemModel.ToQualifiedTypeName("Concept");
        public static XmlQualifiedName VocabularyTypeQName = bootstrapSystemModel.ToQualifiedTypeName("Vocabulary");
        public static XmlQualifiedName ValueSetTypeQName = bootstrapSystemModel.ToQualifiedTypeName("ValueSet");
        public static XmlQualifiedName CodeSystemTypeQName = bootstrapSystemModel.ToQualifiedTypeName("CodeSystem");

        public static NamedTypeSpecifier AnyType = AnyTypeQName.ToNamedType();
        public static NamedTypeSpecifier IntegerType = IntegerTypeQName.ToNamedType();
        public static NamedTypeSpecifier LongType = LongTypeQName.ToNamedType();
        public static NamedTypeSpecifier DecimalType = DecimalTypeQName.ToNamedType();
        public static NamedTypeSpecifier QuantityType = QuantityTypeQName.ToNamedType();
        public static NamedTypeSpecifier StringType = StringTypeQName.ToNamedType();
        public static NamedTypeSpecifier DateType = DateTypeQName.ToNamedType();
        public static NamedTypeSpecifier TimeType = TimeTypeQName.ToNamedType();
        public static NamedTypeSpecifier DateTimeType = DateTimeTypeQName.ToNamedType();
        public static NamedTypeSpecifier BooleanType = BooleanTypeQName.ToNamedType();
        public static NamedTypeSpecifier RatioType = RatioTypeQName.ToNamedType();
        public static NamedTypeSpecifier CodeType = CodeTypeQName.ToNamedType();
        public static NamedTypeSpecifier ConceptType = ConceptTypeQName.ToNamedType();
        public static NamedTypeSpecifier VocabularyType = VocabularyTypeQName.ToNamedType();
        public static NamedTypeSpecifier ValueSetType = ValueSetTypeQName.ToNamedType();
        public static NamedTypeSpecifier CodeSystemType = CodeSystemTypeQName.ToNamedType();

        public static IReadOnlyCollection<NamedTypeSpecifier> ValidIntervalPointTypes = new[]
            {
                IntegerType,
                LongType,
                DecimalType,
                QuantityType,
                DateType,
                TimeType,
                DateTimeType,
            };
    }
}