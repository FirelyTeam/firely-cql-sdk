#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Linq;

namespace Hl7.Cql.Model
{
    public static class TypeInfoHelpers
    {
        /// <summary>
        /// Returns the unqualified name for this <see cref="TypeInfo"/>.
        /// </summary>
        /// <returns>The name for a <see cref="SimpleTypeInfo"/> or <see cref="ClassInfo"/> or null otherwise.</returns>
        public static string? GetNameFromTypeInfo(this TypeInfo typeInfo)
        {
            var (ns, name) = typeInfo switch
            {
                SimpleTypeInfo sti => (sti.@namespace, sti.name),
                ClassInfo c => (c.@namespace, c.name),
                _ => (null, null)
            };

            if (ns is null && name is null)
                return null;
            else if (ns is null) // if there is no namespace, it is part of the name
                return name?.Split('.', 2).LastOrDefault();
            else
                return name;
        }


    }
}
