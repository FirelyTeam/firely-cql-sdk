#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Operators
{
    internal partial class CqlOperators
    {
        #region Coalesce

        /// <inheritdoc />
        public T? Coalesce<T>(IEnumerable<T>? source)
        {
            // Non-nullable value types cannot represent null, so they cannot satisfy CQL null semantics.
            // The JIT specializes generic value-type instantiations, eliminating this check for valid T.
            if (default(T) is not null)
                throw new ArgumentException(
                    $"Coalesce<T> requires T to be a reference type or Nullable<U>, but was instantiated with non-nullable value type {typeof(T)}.");

            if (source == null)
                return default;
            var t = source.FirstOrDefault(t => t != null);
            return t;
        }

        /// <inheritdoc />
        [Obsolete("Use Coalesce<T> with T = Nullable<U> instead. The class constraint on Coalesce<T> has been removed.", false)]
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

        /// <inheritdoc />
        public bool? IsNull<T>(T value) => value is null;

        #endregion

        #region IsFalse

        /// <inheritdoc />
        public bool? IsFalse(bool? b) => b == false;

        #endregion

        #region IsTrue

        /// <inheritdoc />
        public bool? IsTrue(bool? b) => b == true;

        #endregion
    }
}
