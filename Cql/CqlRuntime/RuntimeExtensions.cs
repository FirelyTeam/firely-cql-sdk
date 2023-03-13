using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    public static class RuntimeExtensions
    {
        public static TProp PropertyOrDefault<T, TProp>(this T @object, Func<T, TProp> access)
        {
            if (@object == null)
                return default!;
            else return access(@object);
        }
    }
}
