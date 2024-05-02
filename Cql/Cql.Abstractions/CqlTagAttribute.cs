/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;

namespace Hl7.Cql.Abstractions
{
    /// <summary>
    /// Representation of a @tag=value in CQL 
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true)]
    public class CqlTagAttribute : Attribute
    {
        /// <summary>
        /// The name of the tag (after @, before =)
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The name of the tag (after =)
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// Creates an instance with the corresponding values set
        /// </summary>
        /// <param name="Name">name</param>
        /// <param name="Value">value</param>
        public CqlTagAttribute(string Name, string Value)
        {
            this.Name = Name;
            this.Value = Value;
        }
    }
}
