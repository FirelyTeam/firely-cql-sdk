/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// Enumerates the operators in the CQL specification.
    /// </summary>
    internal static class CqlOperator
    {
        public const string Ratio = nameof(Ratio);
        public const string Retrieve = nameof(Retrieve);
        public const string MinValue = nameof(MinValue);
        public const string MaxValue = nameof(MaxValue);
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member