/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Linq;
using System.Xml;

namespace Hl7.Cql.Elm
{
    /// <summary>
    /// Helper methods for creating type specifiers.
    /// </summary>
    public static class TypeSpecifierExtensions
    {
        /// <summary>
        /// Create a named type specifier from the qualified name of the simple type.
        /// </summary>
        public static NamedTypeSpecifier ToNamedType(this XmlQualifiedName qname) =>
            new() { name = qname };

        /// <summary>
        /// Create list with elements of the specified type.
        /// </summary>
        public static ListTypeSpecifier ToListType(this TypeSpecifier name) =>
            new() { elementType = name };

        /// <summary>
        /// Create an interval with the specified point type.
        /// </summary>
        public static IntervalTypeSpecifier ToIntervalType(this TypeSpecifier name) =>
            new() { pointType = name };

        /// <summary>
        /// Determines if a types can be used as the point type for an interval, and has a successor and predecessor.
        /// </summary>
        public static bool IsValidOrderedType(this TypeSpecifier type) => SystemTypes.ValidOrderedTypes.Contains(type);

        /// <summary>
        /// Determines if a type is numeric.
        /// </summary>
        public static bool IsNumericType(this TypeSpecifier type) => SystemTypes.NumericTypes.Contains(type);


    }
}
