/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Primitives
{
    /// <summary>
    /// Represents a CQL Concept, which is a collection of codes with an optional display name.
    /// </summary>
    /// <remarks>
    /// A CQL Concept is used to group related codes together, typically for use in clinical quality measures.
    /// </remarks>
    /// <param name="codes">The collection of <see cref="CqlCode"/> instances that define the concept.</param>
    /// <param name="display">The display name of the concept, providing a human-readable description.</param>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#concept-1"/>
    [CqlPrimitiveType(CqlPrimitiveType.Concept)]
    public record CqlConcept(IReadOnlyList<CqlCode>? codes, string? display)
    {
        /// <summary>
        /// Represents a CQL Concept, which is a collection of codes with an optional display name.
        /// </summary>
        /// <remarks>
        /// A CQL Concept is used to group related codes together, typically for use in clinical quality measures.
        /// </remarks>
        /// <see href="https://cql.hl7.org/09-b-cqlreference.html#concept-1"/>
        /// <param name="codes">The collection of <see cref="CqlCode"/> instances that define the concept.</param>
        /// <param name="display">The display name of the concept, providing a human-readable description.</param>
        public CqlConcept(IEnumerable<CqlCode>? codes, string? display) : this(codes?.ToArray(), display) {}

        /// <summary>The collection of <see cref="CqlCode"/> instances that define the concept.</summary>
        public IReadOnlyList<CqlCode> codes { get; init; } = codes;

        /// <summary>The display name of the concept, providing a human-readable description.</summary>
        public string? display { get; init; } = display;
    }
}
