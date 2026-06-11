#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;

namespace Hl7.Cql.Operators
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
            else if (Comparer.Compare(argument, low, null) >= 0 && Comparer.Compare(argument, high, null) <= 0)
                return true;
            else
                return false;
        }

        public bool? Between(CqlDate? argument, CqlDate? low, CqlDate? high)
        {
            if (argument == null || low == null || high == null)
                return null;
            else if (Comparer.Compare(argument, low, null) >= 0 && Comparer.Compare(argument, high, null) <= 0)
                return true;
            else return false;
        }

        public bool? Between(CqlDateTime? argument, CqlDateTime? low, CqlDateTime? high)
        {
            if (argument == null || low == null || high == null)
                return null;
            else if (Comparer.Compare(argument, low, null) >= 0 && Comparer.Compare(argument, high, null) <= 0)
                return true;
            else return false;
        }

        public bool? Between(CqlTime? argument, CqlTime? low, CqlTime? high)
        {
            if (argument == null || low == null || high == null)
                return null;
            else if (Comparer.Compare(argument, low, null) >= 0 && Comparer.Compare(argument, high, null) <= 0)
                return true;
            else return false;
        }

        public bool? Between(string? argument, string? low, string? high)
        {
            if (argument == null || low == null || high == null)
                return null;
            else if (Comparer.Compare(argument, low, null) >= 0 && Comparer.Compare(argument, high, null) <= 0)
                return true;
            else return false;
        }
        #endregion

        #region Greater

        public bool? Greater(object? left, object? right)
        {
            // https://cql.hl7.org/09-b-cqlreference.html#greater
            // Spec:If either argument is null, the result is null.
            if (left is null || right is null)
                return null;

            var result = Comparer.Compare(left!, right!, null);
            return result switch
            {
                null => null,
                > 0  => true,
                _    => false
            };
        }

        #endregion

        #region  Greater Or Equal
        public bool? GreaterOrEqual(object? left, object? right)
        {
            // https://cql.hl7.org/09-b-cqlreference.html#greater-or-equal
            // Spec:If either argument is null, the result is null.
            if (left is null || right is null)
                return null;

            var result = Comparer.Compare(left!, right!, null);
            return result switch
            {
                null => null,
                >= 0 => true,
                _    => false
            };
        }
        #endregion

        #region Less
        public bool? Less(object? left, object? right)
        {
            // https://cql.hl7.org/09-b-cqlreference.html#less
            // Spec:If either argument is null, the result is null.
            if (left is null || right is null)
                return null;

            var result = Comparer.Compare(left!, right!, null);
            return result switch
            {
                null => null,
                < 0  => true,
                _    => false
            };
        }
        #endregion

        #region Less Or Equal
        public bool? LessOrEqual(object? left, object? right)
        {
            // https://cql.hl7.org/09-b-cqlreference.html#less-or-equal
            // Spec:If either argument is null, the result is null.
            if (left is null || right is null)
                return null;

            var result = Comparer.Compare(left!, right!, null);
            if (result == null)
                return null;
            else if (result <= 0)
                return true;
            else return false;
        }
        #endregion
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member