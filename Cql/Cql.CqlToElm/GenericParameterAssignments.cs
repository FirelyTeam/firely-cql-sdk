/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using System.Collections.Generic;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// A list of assignments of concrete types to generic parameters.
    /// </summary>
    internal class GenericParameterAssignments : Dictionary<GenericTypeSpecifier, TypeSpecifier>
    {
        /// <inheritdoc/>
        public GenericParameterAssignments()
        {
        }

        /// <inheritdoc/>
        public GenericParameterAssignments(IEnumerable<KeyValuePair<GenericTypeSpecifier, TypeSpecifier>> collection) : base(collection)
        {
        }

        /// <summary>
        /// Construct a new set of assignments with a single initial assignment.
        /// </summary>
        public GenericParameterAssignments(GenericTypeSpecifier key, TypeSpecifier value)
        {
            Add(key, value);
        }

        /// <summary>
        /// Adds a range of assignments to the list.    
        /// </summary>
        public void AddRange(IEnumerable<KeyValuePair<GenericTypeSpecifier, TypeSpecifier>> items)
        {
            foreach (var item in items)
                Add(item.Key, item.Value);
        }

        /// <summary>
        /// Replaces assignments in the current set with those in <paramref name="items"/> and leaves the
        /// rest unchanged.
        /// </summary>
        public void Replace(IEnumerable<KeyValuePair<GenericTypeSpecifier, TypeSpecifier>> items)
        {
            foreach (var item in items)
            {
                Remove(item.Key);
                Add(item.Key, item.Value);
            }
        }
    }

}
