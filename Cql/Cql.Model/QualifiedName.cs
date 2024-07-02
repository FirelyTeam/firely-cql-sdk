#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Text.RegularExpressions;
using System.Xml;

namespace Hl7.Cql.Model
{

    public static class QualifiedName
    {
        /// <summary>
        /// A regex for parsing a CQL qualified name in a <see cref="NamedTypeSpecifier"/>
        /// </summary>
        public static readonly Regex QualifiedNameRegEx = new("{(?'uri'.*)}(?'name'.*)", RegexOptions.Compiled);

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

        /// <summary>
        /// Splits the qualified name into an url and a type.
        /// </summary>
        public static void Deconstruct(this XmlQualifiedName qname, out string uri, out string name)
        {
            var match = QualifiedNameRegEx.Match(qname.Name);
            if (match.Success)
            {
                uri = match.Groups["uri"].Value;
                name = match.Groups["name"].Value;
            }
            else
                throw new ArgumentException("NamedTypeSpecifier name does not match the expected pattern '{uri}name'.", nameof(name));
        }


    }
}
