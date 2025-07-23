/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions
{
    /// <summary>
    /// Representation of a @tag=value in CQL
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true)]
    public class CqlTagAttribute(string name, string value) : Attribute
    {
        /// <summary>
        /// The name of the tag (after @, before =)
        /// </summary>
        public string Name { get; } = name;

        /// <summary>
        /// The name of the tag (after =)
        /// </summary>
        public string Value { get; } = value;
    }
}
