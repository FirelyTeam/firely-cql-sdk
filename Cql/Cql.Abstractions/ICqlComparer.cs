/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions
{
    /// <summary>
    /// Defines a method that a type implements to compare two objects.
    /// </summary>
    public interface ICqlComparer : IEquivalenceComparer
    {
        /// <summary>
        /// Compares two objects for equality.  This method is equivalent to calling <see cref="Compare(object, object, string?)"/> and comparing its result with 0.  When equal, this method returns <see langword="true"/>.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <param name="precision">The precision to use in this comparison, or <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if the objects are equal, <see langword="false"/> if not, and <see langword="null"/> if the answer cannot be computed due to uncertainty related to <paramref name="precision"/>.</returns>
        bool? Equals(object? x, object? y, string? precision);
        /// <summary>
        /// Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <param name="precision">The precision to use in this comparison, or <see langword="null"/>.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared.  
        /// If the value is less than zero, <paramref name="x"/> is less than <paramref name="y"/>.  
        /// If the value is zero, <paramref name="x"/> is equal to <paramref name="y"/>.  
        /// If the value is greater than zero, <paramref name="x"/> is greater than <paramref name="y"/>.
        /// If the value is <see langword="null"/>, this comparison is uncertain because of <paramref name="precision"/>.
        /// </returns>
        int? Compare(object? x, object? y, string? precision);
        /// <summary>
        /// Computes a hash code for <paramref name="x"/>.
        /// If <see cref="Equals(object?, object?, string?)"/> returns <see langword="true"/> for two objects x and y, this method must return the same value for both x and y.
        /// If it returns <see langword="false"/>, this method must return two different values for x and y.
        /// </summary>
        /// <param name="x">The object whose hash code to compute.</param>
        /// <returns>The hash code for <paramref name="x"/>.</returns>
        int GetHashCode(object x);
    }

    /// <summary>
    /// Defines a method that a type implements to compare two objects.
    /// </summary>
    /// <typeparam name="T">
    /// The type of object to compare.
    /// </typeparam>
    public interface ICqlComparer<in T> : IEquivalenceComparer<T>
    {
        /// <summary>
        /// Compares two objects for equality.  This method is equivalent to calling <see cref="Compare(T, T, string?)"/> and comparing its result with 0.  When equal, this method returns <see langword="true"/>.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <param name="precision">The precision to use in this comparison, or <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if the objects are equal, <see langword="false"/> if not, and <see langword="null"/> if the answer cannot be computed due to uncertainty related to <paramref name="precision"/>.</returns>
        bool? Equals(T? x, T? y, string? precision);
        /// <summary>
        /// Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <param name="precision">The precision to use in this comparison, or <see langword="null"/>.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared.  
        /// If the value is less than zero, <paramref name="x"/> is less than <paramref name="y"/>.  
        /// If the value is zero, <paramref name="x"/> is equal to <paramref name="y"/>.  
        /// If the value is greater than zero, <paramref name="x"/> is greater than <paramref name="y"/>.
        /// If the value is <see langword="null"/>, this comparison is uncertain because of <paramref name="precision"/>.
        /// </returns>
        int? Compare(T? x, T? y, string? precision);
        /// <summary>
        /// Computes a hash code for <paramref name="x"/>.
        /// If <see cref="Equals(T, T, string?)"/> returns <see langword="true"/> for two objects x and y, this method must return the same value for both x and y.
        /// If it returns <see langword="false"/>, this method must return two different values for x and y.
        /// </summary>
        /// <param name="x">The object whose hash code to compute.</param>
        /// <returns>The hash code for <paramref name="x"/>.</returns>
        int GetHashCode(T x);

    }
}
