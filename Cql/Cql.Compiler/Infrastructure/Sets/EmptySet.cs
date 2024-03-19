﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Compiler.Infrastructure.Sets
{
    internal readonly struct EmptySet<T>  : IReadOnlySet<T>
    {
        public static EmptySet<T> Instance { get; } = new EmptySet<T>();

        public IEnumerator<T> GetEnumerator()
        {
            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public int Count => 0;

        public bool Contains(T item) => false;

        public bool IsProperSubsetOf(IEnumerable<T> other) => false;

        public bool IsProperSupersetOf(IEnumerable<T> other) => false;

        public bool IsSubsetOf(IEnumerable<T> other) => false;

        public bool IsSupersetOf(IEnumerable<T> other) => false;

        public bool Overlaps(IEnumerable<T> other) => false;

        public bool SetEquals(IEnumerable<T> other) => !other.Any();
    }
}