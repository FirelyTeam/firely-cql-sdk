/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime
{
    /// <summary>
    /// Information about a call to a function.
    /// </summary>
    public class FunctionCallEvent
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="name">The name of the definition or function.</param>
        /// <param name="locator">The location in the source code.</param>
        /// <param name="localId">The local ID for this ELM node.</param>
        public FunctionCallEvent(string? name, string? locator, string? localId)
        {
            Name = name;
            Locator = locator;
            LocalId = localId;
        }

        /// <summary>
        /// The name of the definition or function.
        /// </summary>
        public string? Name { get; }
        /// <summary>
        /// The location in the source code.
        /// </summary>
        public string? Locator { get; }
        /// <summary>
        /// The local ID for this ELM node.
        /// </summary>
        public string? LocalId { get; }
    }
}
