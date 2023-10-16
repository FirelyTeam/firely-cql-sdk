/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Elm
{
    /// <summary>
    /// A list of assignments of concrete types to generic parameters.
    /// </summary>
    public class GenericParameterAssignments : Dictionary<ParameterTypeSpecifier, TypeSpecifier>
    {
        /// <inheritdoc/>
        public GenericParameterAssignments()
        {
        }

        /// <inheritdoc/>
        public GenericParameterAssignments(IEnumerable<KeyValuePair<ParameterTypeSpecifier, TypeSpecifier>> collection)            
        {
            foreach (var kvp in collection)
                Add(kvp.Key, kvp.Value);
        }

        /// <summary>
        /// Adds a range of assignments to the list.    
        /// </summary>
        public void AddRange(IEnumerable<KeyValuePair<ParameterTypeSpecifier, TypeSpecifier>> items)
        {
            foreach (var item in items)
                Add(item.Key, item.Value);
        }
    }

}
