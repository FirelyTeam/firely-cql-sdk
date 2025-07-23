/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// Defines implicit conversion precdence per the CQL spec.
    /// </summary>
    /// <remarks>
    /// The reference implementation does not seem to obey that subtype is cheaper than
    /// compatible in all cases.
    /// </remarks>
    /// <seealso href="https://cql.hl7.org/03-developersguide.html#conversion-precedence"/>
    internal enum CoercionCost: int
    {
        ExactMatch,
        Subtype,
        MoreCompatible, // null to simple types
        LessCompatible, // null to intervals or lists
        Cast,
        ImplicitToSimpleType,
        ImplicitToClassType,
        IntervalPromotion,    
        ListDemotion,
        IntervalDemotion,
        ListPromotion,

        Incompatible = 1000,
    }
}
