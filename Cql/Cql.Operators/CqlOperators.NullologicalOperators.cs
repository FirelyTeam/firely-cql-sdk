/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Runtime
{
    internal partial class CqlOperators
    {
        #region Coalesce

        public T? Coalesce<T>(IEnumerable<T>? source)
            where T : class
        {
            if (source == null)
                return null!;
            var t = source.FirstOrDefault(t => t != null);
            return t;
        }

        public T? CoalesceValueTypes<T>(IEnumerable<T?>? source)
            where T : struct
        {
            if (source == null)
                return null;
            var t = source.FirstOrDefault(t => t != null);
            return t;
        }


        #endregion

        #region IsNull

        public bool? IsNull<T>(T value) where T : class => value == null;
        public bool? IsNullValue<T>(T? value) where T : struct => value.HasValue;

        #endregion

        #region IsFalse

        public bool? IsFalse(bool? b) => b == false;

        #endregion

        #region IsTrue

        public bool? IsTrue(bool? b) => b == true;

        #endregion 
    }
}
