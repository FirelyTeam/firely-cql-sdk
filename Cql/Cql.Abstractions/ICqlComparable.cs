/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;

namespace Hl7.Cql.Abstractions
{
    /// <summary>
    /// <para>Defines a generalized type-specific comparison method that a value type or class implements to order or sort its instances.</para>
    /// <para>This interface differs from <see cref="IComparable{T}"/> because it includes a precision paramter in its <see cref="CompareTo(T?, string?)"/> method.</para>
    /// </summary>
    /// <typeparam name="T">
    /// The type of object to compare.
    /// </typeparam>
    public interface ICqlComparable<T>
        where T : class
    {
        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="other">An object to compare with this instance.</param>
        /// <param name="precision">The specified precision, or <see langword="null"/>.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared.  
        /// If the value is less than zero, this object is less than <paramref name="other"/>.  
        /// If the value is zero, this object is equal to <paramref name="other"/>.  
        /// If the value is greater than zero, this object is greater than <paramref name="other"/>.
        /// If the value is <see langword="null"/>, this comparison is uncertain because of <paramref name="precision"/>.
        /// </returns>
        int? CompareTo(T? other, string? precision = null);
    }
}
