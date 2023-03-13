using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ncqa.Cql.Runtime
{
    public partial class CqlOperatorsBase
    {
        #region Between

        public bool? Between(int? argument, int? low, int? high)
        {
            if (argument == null || low == null || high == null) 
                return null;
            else if (argument >= low && argument <= high) 
                return true;
            else return false;
        }

        public bool? Between(long? argument, long? low, long? high)
        {
            if (argument == null || low == null || high == null) 
                return null;
            else if (argument >= low && argument <= high) 
                return true;
            else 
                return false;
        }

        public bool? Between(decimal? argument, decimal? low, decimal? high)
        {
            if (argument == null || low == null || high == null) 
                return null;
            else if (argument >= low && argument <= high) 
                return true;
            else return false;
        }
        public bool? Between(CqlQuantity? argument, CqlQuantity? low, CqlQuantity? high)
        {
            if (argument?.value == null || low?.value == null || high?.value == null)
                return null;
            else if (argument.unit != low.unit && argument.unit != high.unit)
                throw new NotSupportedException("Only like quantity units are comparable.");
            else
                return Between(argument.value, low.value, high.value);

        }

        public bool? Between(CqlDate? argument, CqlDate? low, CqlDate? high)
        {
            if (argument == null || low == null || high == null)
                return null;
            else if (Context.Compare(argument, low, null) >= 0 && Context.Compare(argument, high, null) <= 0)
                return true;
            else return false;
        }

        public bool? Between(CqlDateTime? argument, CqlDateTime? low, CqlDateTime? high)
        {
            if (argument == null || low == null || high == null)
                return null;
            else if (Context.Compare(argument, low, null) >= 0 && Context.Compare(argument, high, null) <= 0)
                return true;
            else return false;
        }

        public bool? Between(CqlTime? argument, CqlTime? low, CqlTime? high)
        {
            if (argument == null || low == null || high == null)
                return null;
            else if (Context.Compare(argument, low, null) >= 0 && Context.Compare(argument, high, null) <= 0)
                return true;
            else return false;
        }

        public bool? Between(string? argument, string? low, string? high)
        {
            if (argument == null || low == null || high == null)
                return null;
            else if (Context.Compare(argument, low, null) >= 0 && Context.Compare(argument, high, null) <= 0)
                return true;
            else return false;
        }
        #endregion

        #region Equal
        public bool? Equal(object? x, object? y) => x == null || y == null ? null : Context.Equals(x, y, null);
        #endregion


        #region Equivalent
        public bool? Equivalent(object? x, object? y) => Context.Equivalent(x!, y!, null);
        #endregion

        #region Greater

        public bool? Greater(object? left, object? right)
        {
            var result = Context.Compare(left!, right!, null);
            if (result == null)
                return null;
            else if (result > 0)
                return true;
            else return false;
        }

        #endregion

        #region  Greater Or Equal
        public bool? GreaterOrEqual(object? left, object? right)
        {
            var result = Context.Compare(left!, right!, null);
            if (result == null)
                return null;
            else if (result >= 0)
                return true;
            else return false;
        }
        #endregion

        #region Less
        public bool? Less(object? left, object? right)
        {
            var result = Context.Compare(left!, right!, null);
            if (result == null)
                return null;
            else if (result < 0)
                return true;
            else return false;
        }
        #endregion

        #region Less Or Equal
        public bool? LessOrEqual(object? left, object? right)
        {
            var result = Context.Compare(left!, right!, null);
            if (result == null)
                return null;
            else if (result <= 0)
                return true;
            else return false;
        }
        #endregion

        #region  Not Equal
        public bool? NotEqual(object? left, object? right)
        {
            var eq = Equal(left, right);
            if (eq is null)
                return null;
            else return !eq.Value;
        }
        #endregion

        #region  Not Equivalent

        public bool? NotEquivalent(object? left, object? right)
        {
            var eq = Equal(left, right);
            if (eq is null)
                return null;
            else return !eq.Value;
        }

        #endregion

    }
}
