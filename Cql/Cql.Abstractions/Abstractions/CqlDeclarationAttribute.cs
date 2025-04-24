/*
 * Copyright (c) 2025, Firely and NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions
{

    /// <summary>
    /// Declares that this class is the translation of an ELM definition.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class CqlDeclarationAttribute(string declarationName) : Attribute
    {
        /// <summary>
        /// The name of the definition.
        /// </summary>
        public string DeclarationName { get; } = declarationName;
    }
}
