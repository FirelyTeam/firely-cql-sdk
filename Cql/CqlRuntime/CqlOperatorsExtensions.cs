using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    public static class CqlOperatorsExtensions
    {
        public static bool? Not(this ICqlOperators operators, Lazy<bool?> @bool) => operators.Not(@bool.Value);
    }
}
