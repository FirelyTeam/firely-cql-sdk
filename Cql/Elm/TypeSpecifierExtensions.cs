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
    }
}
