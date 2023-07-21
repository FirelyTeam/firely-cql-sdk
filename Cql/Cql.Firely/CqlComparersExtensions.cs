/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;

namespace Hl7.Cql.Firely
{
    public static class CqlComparersExtensions
    {
        public static CqlComparers AddFirelyComparers(this CqlComparers comparers)
        {
            return comparers;
        }
    }
}
