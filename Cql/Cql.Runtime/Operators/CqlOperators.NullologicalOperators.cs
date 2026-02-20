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
            where T : class
        {
            if (source == null)
                return null!;
            var t = source.FirstOrDefault(t => t != null);
            return t;
        }

        /// <inheritdoc />
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
        public bool? IsNull<T>(T value) where T : class => value == null;

        /// <inheritdoc />
        public bool? IsNullValue<T>(T? value) where T : struct => !value.HasValue;

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
