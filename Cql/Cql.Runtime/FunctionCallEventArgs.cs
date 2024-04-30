/* 
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime
{
    /// <summary>
    /// Data for a context event, which is a generic event raised by the CQL engine or one of its custom extension components.
    /// </summary>
    public class ContextEventArgs
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>       
        public ContextEventArgs(object? state = null)
        {
            State = state;
        }

        /// <summary>
        /// Generic state for the event.
        /// </summary>
        public object? State { get; }
    }
}
