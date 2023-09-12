/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Generic;

namespace Hl7.Cql.Graph
{
    internal static class ExtensionMethods
    {
        public static HashSet<T> ToHashSet<T>(this IEnumerable<T> hashSet) => new HashSet<T>(hashSet);
    }
}
