/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Operators;

partial class CqlOperators
{
    private readonly struct ComparerBridge(
        CqlOperators owningCqlOperators,
        int coalesceCompareTo = -1)
        : IComparer<object>, IComparer
    {
        public int Compare(object? x, object? y) =>
            owningCqlOperators.Compare(x, y, null) ?? coalesceCompareTo;
    }

    private readonly struct EqualityComparerBridge(
        CqlOperators owningCqlOperators,
        bool coalesceEqualTo = false)
        : IEqualityComparer<object>, IEqualityComparer
    {
        public new bool Equals(object? x, object? y) =>
            owningCqlOperators.Equals(x, y, null) ?? coalesceEqualTo;

        public int GetHashCode(object obj) =>
            owningCqlOperators.GetHashCode(obj);
    }
}
