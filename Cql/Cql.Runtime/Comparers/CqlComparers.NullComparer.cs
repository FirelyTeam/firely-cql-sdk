/*
 * Copyright (c) 2023, NCQA and contributors
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
            var result = CompareOnNullsOnly(x, y) ?? through.Compare(x!, y!);
            return result;
        }

        public int Compare(object? x, object? y) => Compare((T?)x, (T?)y);
    }

    // internal class NullValueTypeComparer<T>(IComparer<T> through) : IComparer<T?>, IComparer
    //     where T : struct
    // {
    //     public int Compare(T? x, T? y)
    //     {
    //         if (x == null)
    //         {
    //             if (y == null)
    //                 return 0;
    //             else return -1;
    //         }
    //         else if (y == null)
    //             return 1;
    //         else return through.Compare(x.Value, y.Value);
    //     }
    //
    //     public int Compare(object? x, object? y) => Compare((T?)x, (T?)y);
    // }
}
