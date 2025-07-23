/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Primitives
{
    /// <summary>
    /// Represents a CodeSystem in CQL (Clinical Quality Language).
    /// A CodeSystem is a collection of codes with a defined meaning,
    /// typically used in healthcare to represent concepts such as diagnoses, procedures, or medications.
    /// </summary>
    /// <param name="id">The canonical URL of the code system, which uniquely identifies it.</param>
    /// <param name="version">The version of the code system, if applicable. This can be null if no version is specified.</param>
    /// <param name="codes">A read-only list of <see cref="CqlCode"/> objects that belong to this code system.</param>
    /// <remarks>
    /// This class is a record type, which provides value-based equality and immutability.
    /// It inherits from <see cref="CqlVocabulary"/>, which provides common properties for vocabulary elements.
    /// </remarks>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#codesystem"/>
    [CqlPrimitiveType(CqlPrimitiveType.CodeSystem)]
    public record CqlCodeSystem(string id, string? version, IReadOnlyList<CqlCode> codes) : CqlVocabulary(id, version);
}
