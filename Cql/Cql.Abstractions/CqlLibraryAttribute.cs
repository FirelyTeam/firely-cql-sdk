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
    /// Declares that this class is the translation of an ELM library.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
    public class CqlLibraryAttribute : Attribute
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="Identifier">The library's identifier.</param>
        /// <param name="Version">The library's version.</param>
        public CqlLibraryAttribute(string Identifier, string Version)
        {
            this.Identifier = Identifier;
            this.Version = Version;
        }

        /// <summary>
        /// The library's identifier.
        /// </summary>
        public string Identifier { get; }
        /// <summary>
        /// The library's version.
        /// </summary>
        public string Version { get; }
    }
}
