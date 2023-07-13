﻿/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System.Collections;
using System.Collections.Generic;

namespace Hl7.Cql.Comparers
{
    public class NullComparer<T> : IComparer<T>, IComparer
    {

        private readonly IComparer<T> through;

        public NullComparer(IComparer<T> through)
        {
            this.through = through;
        }

        public int Compare(T x, T y)
        {
            if (x == null)
            {
                if (y == null)
                    return 0;
                else return -1;
            }
            else if (y == null)
                return 1;
            else return through.Compare(x!, y!);
        }

        public int Compare(object x, object y) => Compare((T)x, (T)y);
    }

    public class NullValueTypeComparer<T> : IComparer<T?>, IComparer
        where T : struct
    {

        private readonly IComparer<T> through;

        public NullValueTypeComparer(IComparer<T> through)
        {
            this.through = through;
        }

        public int Compare(T? x, T? y)
        {
            if (x == null)
            {
                if (y == null)
                    return 0;
                else return -1;
            }
            else if (y == null)
                return 1;
            else return through.Compare(x.Value, y.Value);
        }

        public int Compare(object x, object y) => Compare((T?)x, (T?)y);
    }
}
