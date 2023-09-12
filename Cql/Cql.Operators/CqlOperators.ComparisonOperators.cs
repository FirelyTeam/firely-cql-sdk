#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;
using System;

namespace Hl7.Cql.Runtime
{
    internal partial class CqlOperators
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
            else if (Compare(argument, low, null) >= 0 && Compare(argument, high, null) <= 0)
                return true;
            else return false;
        }

        public bool? Between(CqlDateTime? argument, CqlDateTime? low, CqlDateTime? high)
        {
            if (argument == null || low == null || high == null)
                return null;
            else if (Compare(argument, low, null) >= 0 && Compare(argument, high, null) <= 0)
                return true;
            else return false;
        }

        public bool? Between(CqlTime? argument, CqlTime? low, CqlTime? high)
        {
            if (argument == null || low == null || high == null)
                return null;
            else if (Compare(argument, low, null) >= 0 && Compare(argument, high, null) <= 0)
                return true;
            else return false;
        }

        public bool? Between(string? argument, string? low, string? high)
        {
            if (argument == null || low == null || high == null)
                return null;
            else if (Compare(argument, low, null) >= 0 && Compare(argument, high, null) <= 0)
                return true;
            else return false;
        }
        #endregion

        #region Equal
        public bool? Equal(object? x, object? y) => x == null || y == null ? null : Equals(x, y, null);
        #endregion


        #region Equivalent
        public bool? Equivalent(object? x, object? y) => Equivalent(x!, y!, null);
        #endregion

        #region Greater

        public bool? Greater(object? left, object? right)
        {
            var result = Compare(left!, right!, null);
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
            var result = Compare(left!, right!, null);
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
            var result = Compare(left!, right!, null);
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
            var result = Compare(left!, right!, null);
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
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member