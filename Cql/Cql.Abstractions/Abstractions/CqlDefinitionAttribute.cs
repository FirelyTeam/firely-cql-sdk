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
    /// Base attribute which declares that this method or property is translated from an ELM definition
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class CqlDefinitionAttribute(string name) : Attribute
    {
        /// <summary>
        /// The name of the definition.
        /// </summary>
        public string Name { get; } = name;
    }
}
