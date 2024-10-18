/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Primitives
{
    /// <summary>
    /// The temporary base class for tuple types generated into the LINQ expressions.
    /// This is not used during CQL runtime, because the C# compiler will replace this with value tuples instead.
    /// </summary>
    [CqlPrimitiveType(CqlPrimitiveType.Tuple)]
    internal abstract class TupleBaseType
    {
    }
}
