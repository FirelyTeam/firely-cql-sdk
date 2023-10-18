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
    internal class NullTypeSpecifier : TypeSpecifier
    {
        public static readonly NullTypeSpecifier Instance = new();

        internal override IEnumerable<ParameterTypeSpecifier> GetGenericParameters() => System.Array.Empty<ParameterTypeSpecifier>();

        internal override TypeSpecifier ReplaceGenericParameters(GenericParameterAssignments assignments) => this;
    }

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
        public GenericParameterAssignments(IEnumerable<KeyValuePair<ParameterTypeSpecifier, TypeSpecifier>> collection) : base(collection)
        {
        }

        /// <summary>
        /// Construct a new set of assignments with a single initial assignment.
        /// </summary>
        public GenericParameterAssignments(ParameterTypeSpecifier key, TypeSpecifier value)
        {
            Add(key, value);
        }

        /// <summary>
        /// Adds a range of assignments to the list.    
        /// </summary>
        public void AddRange(IEnumerable<KeyValuePair<ParameterTypeSpecifier, TypeSpecifier>> items)
        {
            foreach (var item in items)
                Add(item.Key, item.Value);
        }

        /// <summary>
        /// Replaces assignments in the current set with those in <paramref name="items"/> and leaves the
        /// rest unchanged.
        /// </summary>
        public void Replace(IEnumerable<KeyValuePair<ParameterTypeSpecifier, TypeSpecifier>> items)
        {
            foreach(var item in items)
            {
                Remove(item.Key);
                Add(item.Key, item.Value);
            }
        }

        /// <summary>
        /// Returns a version of the assignments with the special NullTypeSpecifier replaced with AnyTypeSpecifier.
        /// </summary>
        /// <returns></returns>
        public GenericParameterAssignments WithNullAsAny()
        {
            return new GenericParameterAssignments(this.Select(replace));

            static KeyValuePair<ParameterTypeSpecifier, TypeSpecifier> replace(KeyValuePair<ParameterTypeSpecifier, TypeSpecifier> item)
            {
                if (item.Value is NullTypeSpecifier)
                    return new(item.Key, SystemTypes.AnyType);
                else
                    return item;
            }
        }
    }

}
