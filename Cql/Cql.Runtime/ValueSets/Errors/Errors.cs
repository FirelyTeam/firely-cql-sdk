/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Exceptions;

namespace Hl7.Cql.ValueSets.Errors;

/// <summary>
/// An <see cref="ICqlEvaluationError"/> raised when a value set membership test refers to a value set that the
/// <see cref="IValueSetDictionary"/> of the evaluation cannot resolve. <see cref="HashValueSetDictionary"/> raises it
/// for a value set that was not added to it, which includes every value set when a context is created without value
/// sets. <c>ValueSetSource</c> in <c>Hl7.Cql.Fhir</c> raises it for a value set that was not added to it, that its
/// resource resolver does not find, while no terminology service is attached to ask.
/// </summary>
/// <remarks>
/// Per the CQL specification (Appendix B - CQL Reference, section "Clinical Operators", "In (Valueset)"), "If the
/// value set reference cannot be resolved, a run-time error is thrown." Answering <see langword="false"/> instead
/// would claim the code is not in the value set, which nothing has established.
/// </remarks>
public readonly record struct CqlUnresolvedValueSetError : ICqlEvaluationError
{
    internal CqlUnresolvedValueSetError(string valueSetUri) => ValueSetUri = valueSetUri;

    /// <summary>The canonical URI of the value set that could not be resolved.</summary>
    public string ValueSetUri { get; }

    /// <inheritdoc/>
    public string GetMessage() =>
        $"The value set '{ValueSetUri}' cannot be resolved, so whether a code is in it cannot be determined. " +
        "Give the evaluation a value set dictionary that holds it: add it to the dictionary or, for a " +
        "ValueSetSource, make it available to the source's resource resolver or attach a terminology service " +
        "that knows it.";
}
