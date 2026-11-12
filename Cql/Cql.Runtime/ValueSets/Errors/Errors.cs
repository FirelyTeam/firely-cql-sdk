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

/// <summary>
/// An <see cref="ICqlEvaluationError"/> raised when a code without a code system, such as a string, is tested for
/// membership in a value set that holds codes from more than one code system: nothing says which system the code is
/// from, so it could match a code of a system it was never meant for.
/// </summary>
/// <remarks>
/// <para>
/// Per the CQL specification (Appendix B - CQL Reference, section "Clinical Operators", "In (Valueset)"), for the
/// String overload, "if the resolved value set contains codes from multiple code systems, a run-time error is thrown
/// because the operation is ambiguous." The runtime tests a <c>Code</c> without a system the same way as a string, so it
/// raises this error as well.
/// </para>
/// <para>
/// Code systems are told apart ignoring case, and a code of the value set that has no system does not count as a code
/// system of its own.
/// </para>
/// </remarks>
public readonly record struct CqlAmbiguousStringInValueSetError : ICqlEvaluationError
{
    internal CqlAmbiguousStringInValueSetError(string? valueSetUri, string code)
    {
        ValueSetUri = valueSetUri;
        Code = code;
    }

    /// <summary>
    /// The canonical URI of the value set, or <see langword="null"/> when an <see cref="InMemoryValueSet"/> was tested
    /// on its own rather than through an <see cref="IValueSetDictionary"/>.
    /// </summary>
    public string? ValueSetUri { get; }

    /// <summary>The code that was tested.</summary>
    public string Code { get; }

    /// <inheritdoc/>
    public string GetMessage() =>
        $"Whether '{Code}' is in the value set{(ValueSetUri is null ? "" : $" '{ValueSetUri}'")} is ambiguous: the " +
        "value set holds codes from more than one code system, and the code tested does not say which system it is " +
        "from. Test a Code that names its system instead.";
}
