using System;

namespace Hl7.Cql
{
    /// <summary>
    /// <para>Defines a generalized type-specific comparison method that a value type or class implements to order or sort its instances.</para>
    /// <para>This interface differs from <see cref="IComparable{T}"/> because it includes a precision paramter in its <see cref="CompareTo(T?, string?)"/> method.</para>
    /// <para>Where <see cref="ICqlComparable{T}"/> uses CQL equality semantics, this interface implements equivalence semantics.</para>
    /// </summary>
    /// <typeparam name="T">
    /// The type of object to compare.
    /// </typeparam>
    public interface IEquivalentable<T>
        where T: class
    {
        /// <summary>
        /// Compares this object to <paramref name="other"/> for equivalence.
        /// </summary>
        /// <param name="other">The object to compare.</param>
        /// <param name="precision">The precision to use in this comparison, or <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if this object is equivalent to <paramref name="other"/>, else <see langword="false"/>.
        bool Equivalent(T? other, string? precision);

    }
}
