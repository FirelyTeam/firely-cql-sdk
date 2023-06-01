using Hl7.Cql.Primitives;
using System;
using System.Collections.Generic;

namespace Hl7.Cql.ValueSets
{
    /// <summary>
    /// Defines a dictionary of value sets and their codes.
    /// </summary>
    public interface IValueSetDictionary
    {
        /// <summary>
        /// Adds the code to the given value set by its canonical URI.
        /// </summary>
        /// <param name="valueSetUri">The value set's canonical URI.</param>
        /// <param name="code">The code to add.</param>
        /// <exception cref="ArgumentException">If <paramref name="code"/> already exists in the specified value set.</exception>
        /// <exception cref="NotSupportedException">If this implementation does not support adding new codes to a value set.</exception>
        void Add(string valueSetUri, CqlCode code);
        /// <summary>
        /// Adds or overwrites the code to the given value set by its canonical URI, and will not throw if the code exists already.
        /// </summary>
        /// <param name="valueSetUri">The value set's canonical URI.</param>
        /// <param name="code">The code to add.</param>
        /// <exception cref="NotSupportedException">If this implementation does not support adding new codes to a value set.</exception>
        void Set(string valueSetUri, CqlCode code);
        /// <summary>
        /// Returns <see langword="true"/> if the given code is present in the given value set.
        /// This method ignores the code system of the codes present in <paramref name="valueSetUri"/>.
        /// </summary>
        /// <param name="valueSetUri">The value set's canonical URI.</param>
        /// <param name="code">The code to check.</param>
        /// <returns><see langword="true"/> if the given code is present in the given value set.</returns>
        bool IsCodeInValueSet(string valueSetUri, string code);
        /// <summary>
        /// Returns <see langword="true"/> if the given code is present in the given value set.
        /// </summary>
        /// <param name="valueSetUri">The value set's canonical URI.</param>
        /// <param name="code">The code to check.</param>
        /// <param name="systemUriOrOid">The code system's canonical URI or its OID.</param>
        /// <returns><see langword="true"/> if the given code is present in the given value set.</returns>
        bool IsCodeInValueSet(string valueSetUri, string code, string systemUriOrOid);
        /// <summary>
        /// Tries to ge the codes in the value set as an <see cref="IReadOnlyCollection{CqlCode}"/>.
        /// </summary>
        /// <param name="valueSetUri">The value set's canonical URI.</param>
        /// <param name="codes">The <see langword="out"/> parameter for the value set's codes, or <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if the given value set is defined; otherwise, <see langword="false"/>.</returns>
        bool TryGetCodesInValueSet(string valueSetUri, out IReadOnlyCollection<CqlCode>? codes);
    }

}
