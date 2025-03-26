/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Operators;

partial class CqlOperators
{
    private readonly struct ComparerBridge(
        CqlOperators owningCqlOperators,
        int coalesceCompareTo = -1)
        : IComparer<object>, IComparer
    {
        public int Compare(object? x, object? y) =>
            owningCqlOperators.Comparer.Compare(x, y, null) ?? coalesceCompareTo;
    }

    private readonly struct EqualityComparerBridge(
        CqlOperators owningCqlOperators,
        bool coalesceEqualTo = false)
        : IEqualityComparer<object>, IEqualityComparer
    {
        public new bool Equals(object? x, object? y) =>
            owningCqlOperators.Comparer.Equals(x, y, null) ?? coalesceEqualTo;

        public int GetHashCode(object obj) =>
            owningCqlOperators.Comparer.GetHashCode(obj);
    }
}
