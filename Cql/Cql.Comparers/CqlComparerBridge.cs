#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using System.Collections.Generic;

namespace Hl7.Cql.Comparers
{
    internal class CqlComparerBridge<T> : IComparer<T>, IEqualityComparer<T>
    {
        public CqlComparerBridge(ICqlComparer<T> cqlComparer, int coalesceCompareTo = -1, bool coalesceBoolTo = false)
        {
            CqlComparer = cqlComparer;
            CoalesceCompareTo = coalesceCompareTo;
            CoalesceEqualTo = coalesceBoolTo;
        }

        public ICqlComparer<T> CqlComparer { get; }
        public int CoalesceCompareTo { get; }
        public bool CoalesceEqualTo { get; }

        public int Compare(T? x, T? y) => CqlComparer.Compare(x, y, null) ?? CoalesceCompareTo;

        public bool Equals(T? x, T? y) => CqlComparer.Equals(x, y, null) ?? CoalesceEqualTo;

        public int GetHashCode(T obj) => CqlComparer.GetHashCode(obj);
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member