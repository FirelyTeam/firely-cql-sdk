/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    private class NullComparer<T>(IComparer<T> through) : IComparer<T>, IComparer
    {
        public int Compare(T? x, T? y)
        {
            var result = CompareEitherNullReturnsValue(x is null, y is null)
                             .OrValue(() => null)
                         ?? CompareValues(x, y);
            return result;
        }

        private int CompareValues(T? x, T? y)
        {
            return through.Compare(x!, y!);
        }

        public int Compare(object? x, object? y)
        {
            return Compare((T?)x, (T?)y);
        }
    }
}
