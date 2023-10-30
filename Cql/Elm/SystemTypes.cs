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

        private static NamedTypeSpecifier makeNT(string name) => bootstrapSystemModel.MakeQualifiedTypeName(name).ToNamedType();

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static NamedTypeSpecifier AnyType = makeNT("Any");
        public static NamedTypeSpecifier IntegerType = makeNT("Integer");
        public static NamedTypeSpecifier LongType = makeNT("Long");
        public static NamedTypeSpecifier DecimalType = makeNT("Decimal");
        public static NamedTypeSpecifier QuantityType = makeNT("Quantity");
        public static NamedTypeSpecifier StringType = makeNT("String");
        public static NamedTypeSpecifier DateType = makeNT("Date");
        public static NamedTypeSpecifier TimeType = makeNT("Time");
        public static NamedTypeSpecifier DateTimeType = makeNT("DateTime");
        public static NamedTypeSpecifier BooleanType = makeNT("Boolean");
        public static NamedTypeSpecifier RatioType = makeNT("Ratio");
        public static NamedTypeSpecifier CodeType = makeNT("Code");
        public static NamedTypeSpecifier ConceptType = makeNT("Concept");
        public static NamedTypeSpecifier VocabularyType = makeNT("Vocabulary");
        public static NamedTypeSpecifier ValueSetType = makeNT("ValueSet");
        public static NamedTypeSpecifier CodeSystemType = makeNT("CodeSystem");
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