﻿/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Model;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Xml;

namespace Hl7.Cql.Elm
{
    /// <summary>
    /// Represents the list of types defined in the CQL System model.
    /// </summary>
    public static class SystemTypes
    {
        /// <summary>
        /// The URI used to as the namespace for the CQL System model types.
        /// </summary>
        public static string SystemModelUri = "urn:hl7-org:elm-types:r1";

        /// <summary>
        /// The shorthand prefix (System) used for the System model types.
        /// </summary>
        public static string SystemModelPrefix = "System";


        /// <summary>
        /// The version of the CQL System model containing these types.
        /// </summary>
        public static string SystemModelVersion = "1.0.0";

        private static readonly ModelInfo bootstrapSystemModel = new()
        {
            url = SystemModelUri,
            version = SystemModelVersion,
            name = SystemModelPrefix
        };

        private static readonly ConcurrentDictionary<string, ParameterTypeSpecifier> gtpTsSingletons = new();

        internal static readonly ParameterTypeSpecifier T = Generic("T");

        internal static ParameterTypeSpecifier Generic(string name) =>
            gtpTsSingletons.GetOrAdd(name, n => new ParameterTypeSpecifier { parameterName = n });

        internal static XmlQualifiedName QualifiedNameForSystemType(string name)
        {
            var nameWithoutPrefix = name.StartsWith(SystemModelPrefix) ? name.Substring(SystemModelPrefix.Length) : name;
            return bootstrapSystemModel.MakeQualifiedTypeName(nameWithoutPrefix);
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static XmlQualifiedName AnyTypeQName = bootstrapSystemModel.MakeQualifiedTypeName("Any");
        public static XmlQualifiedName IntegerTypeQName = bootstrapSystemModel.MakeQualifiedTypeName("Integer");
        public static XmlQualifiedName LongTypeQName = bootstrapSystemModel.MakeQualifiedTypeName("Long");
        public static XmlQualifiedName DecimalTypeQName = bootstrapSystemModel.MakeQualifiedTypeName("Decimal");
        public static XmlQualifiedName QuantityTypeQName = bootstrapSystemModel.MakeQualifiedTypeName("Quantity");
        public static XmlQualifiedName StringTypeQName = bootstrapSystemModel.MakeQualifiedTypeName("String");
        public static XmlQualifiedName DateTypeQName = bootstrapSystemModel.MakeQualifiedTypeName("Date");
        public static XmlQualifiedName TimeTypeQName = bootstrapSystemModel.MakeQualifiedTypeName("Time");
        public static XmlQualifiedName DateTimeTypeQName = bootstrapSystemModel.MakeQualifiedTypeName("DateTime");
        public static XmlQualifiedName BooleanTypeQName = bootstrapSystemModel.MakeQualifiedTypeName("Boolean");
        public static XmlQualifiedName RatioTypeQName = bootstrapSystemModel.MakeQualifiedTypeName("Ratio");
        public static XmlQualifiedName CodeTypeQName = bootstrapSystemModel.MakeQualifiedTypeName("Code");
        public static XmlQualifiedName ConceptTypeQName = bootstrapSystemModel.MakeQualifiedTypeName("Concept");
        public static XmlQualifiedName VocabularyTypeQName = bootstrapSystemModel.MakeQualifiedTypeName("Vocabulary");
        public static XmlQualifiedName ValueSetTypeQName = bootstrapSystemModel.MakeQualifiedTypeName("ValueSet");
        public static XmlQualifiedName CodeSystemTypeQName = bootstrapSystemModel.MakeQualifiedTypeName("CodeSystem");

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
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        /// <summary>
        /// The types that can be used as the point type for an interval, and have a successor and predecessor
        /// </summary>
        internal static IReadOnlyCollection<NamedTypeSpecifier> ValidOrderedTypes = new[]
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