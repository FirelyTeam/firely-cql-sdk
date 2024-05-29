#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
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
    /// Enumerates the System types
    /// </summary>
    public enum CqlPrimitiveType
    {
        Any,
        Boolean,
        Code,
        CodeSystem,
        Concept,
        Date,
        DateTime,
        Decimal,
        List,
        Long,
        Integer,
        Interval,
        Quantity,
        Ratio,
        String,
        Time,
        ValueSet,
        Vocabulary,
        Tuple,
        Fhir
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member