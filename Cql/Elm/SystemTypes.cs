/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Model;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Dynamic;


namespace Hl7.Cql.Elm
{
    /// <summary>
    /// Represents the list of types defined in the CQL System model (r1).
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
        /// <summary>
        /// Create a new instance of a NamedType, given the name of a system type.
        /// </summary>
        public static NamedTypeSpecifier CreateNamedType(string name) => bootstrapSystemModel.MakeQualifiedTypeName(name).ToNamedType();

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static NamedTypeSpecifier AnyType = CreateNamedType("Any");
        public static NamedTypeSpecifier IntegerType = CreateNamedType("Integer");
        public static NamedTypeSpecifier LongType = CreateNamedType("Long");
        public static NamedTypeSpecifier DecimalType = CreateNamedType("Decimal");
        public static NamedTypeSpecifier QuantityType = CreateNamedType("Quantity");
        public static NamedTypeSpecifier StringType = CreateNamedType("String");
        public static NamedTypeSpecifier DateType = CreateNamedType("Date");
        public static NamedTypeSpecifier TimeType = CreateNamedType("Time");
        public static NamedTypeSpecifier DateTimeType = CreateNamedType("DateTime");
        public static NamedTypeSpecifier BooleanType = CreateNamedType("Boolean");
        public static NamedTypeSpecifier RatioType = CreateNamedType("Ratio");
        public static NamedTypeSpecifier CodeType = CreateNamedType("Code");
        public static NamedTypeSpecifier ConceptType = CreateNamedType("Concept");
        public static NamedTypeSpecifier VocabularyType = CreateNamedType("Vocabulary");
        public static NamedTypeSpecifier ValueSetType = CreateNamedType("ValueSet");
        public static NamedTypeSpecifier CodeSystemType = CreateNamedType("CodeSystem");
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        /// <summary>
        /// The types that can be used as the point type for an interval, and have a successor and predecessor
        /// </summary>
        internal static IEnumerable<NamedTypeSpecifier> OrderedTypes
        {
            get
            {
                yield return IntegerType;
                yield return LongType;
                yield return DecimalType;
                yield return QuantityType;
                yield return DateType;
                yield return TimeType;
                yield return DateTimeType;
                yield return StringType;
            }
        }

        internal static readonly TypeSpecifier[] NumericTypes = new[] { IntegerType, LongType, DecimalType, QuantityType };
    }
}