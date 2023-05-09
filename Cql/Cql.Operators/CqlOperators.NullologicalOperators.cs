using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    public partial class CqlOperators
    {
        #region Coalesce

        public T Coalesce<T>(IEnumerable<T>? source)
            where T: class
        {
            if (source == null)
                return null!;
            var t = source.FirstOrDefault(t => t != null);
            return t;
        }

        public T? CoalesceValueTypes<T>(IEnumerable<T?>? source)
            where T: struct
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
