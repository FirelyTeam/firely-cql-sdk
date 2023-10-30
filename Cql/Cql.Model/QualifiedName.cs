#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Xml;

namespace Hl7.Cql.Model
{
    public static class QualifiedName
    {
        /// <summary>
        /// Qualifies <paramref name="typeName"/> with the namespace in <paramref name="model"/>.
        /// </summary>
        /// <param name="model">The model containing <paramref name="typeName"/>.</param>
        /// <param name="typeName">The name to qualify.</param>
        /// <returns>A string in the form {<see cref="ModelInfo.url"/>}<paramref name="typeName"/></returns>
        public static XmlQualifiedName MakeQualifiedTypeName(this ModelInfo model, string typeName) =>
            MakeQualifiedTypeName(model.url, typeName);

        /// <summary>
        /// Build an <see cref="XmlQualifiedName"/> based on a type's url and name.
        /// </summary>
        public static XmlQualifiedName MakeQualifiedTypeName(string url, string typeName) => new($"{{{url}}}{typeName}");

    }
}
