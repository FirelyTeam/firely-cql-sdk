/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Parsing;

namespace Hl7.Cql.CqlToElm;

/// <summary>
/// Represents a CQL library with its content as a string
/// as well as its library identifier, extracted from the content.
/// </summary>
public readonly record struct CqlLibraryString
    : IParsable<CqlLibraryString>
{
    /// <summary>
    /// Creates a new instance of <see cref="CqlLibraryString"/> from the given identifier and content.
    /// </summary>
    /// <param name="libraryIdentifier">The identifier of the CQL library.</param>
    /// <param name="cqlContent">The content of the CQL library.</param>
    /// <returns>A new instance of <see cref="CqlLibraryString"/>.</returns>
    public static CqlLibraryString FromIdentifierAndString(
        CqlVersionedLibraryIdentifier libraryIdentifier,
        string cqlContent)
    {
        return new CqlLibraryString(libraryIdentifier, cqlContent);
    }

    #region Parsing

    private static readonly CqlParseErrorHandler OnErrorThrowException = CqlParseErrorHandlerStrategies.OnErrorThrowException(typeof(CqlLibraryString));

    static CqlLibraryString IParsable<CqlLibraryString>.Parse(string s, IFormatProvider? provider) =>
        Parse(s);

    /// <summary>
    /// Parses a CQL string to create a <see cref="CqlLibraryString"/> instance.
    /// </summary>
    /// <param name="cqlContent">The content of the CQL library.</param>
    /// <returns>A new instance of <see cref="CqlLibraryString"/>.</returns>
    /// <exception cref="FormatException">Thrown when the library identifier and version cannot be extracted from the provided CQL string.</exception>
    public static CqlLibraryString Parse(string cqlContent)
    {
        TryParse(cqlContent, out var result, OnErrorThrowException);
        return result!.Value;
    }

    static bool IParsable<CqlLibraryString>.TryParse(
        [NotNullWhen(true)] string? s,
        IFormatProvider? provider,
        out CqlLibraryString result)
    {
        if (!string.IsNullOrEmpty(s) && TryParse(s, out var nresult))
        {
            result = nresult.Value;
            return true;
        }

        result = default;
        return false;
    }

    /// <summary>
    /// Attempts to parse the provided CQL content into a <see cref="CqlLibraryString"/> instance.
    /// </summary>
    /// <param name="cqlContent">
    /// The CQL content to parse. This must be a valid CQL library definition.
    /// </param>
    /// <param name="result">
    /// When this method returns, contains the parsed <see cref="CqlLibraryString"/> instance if the parsing succeeded;
    /// otherwise, <c>null</c>.
    /// </param>
    /// <param name="onError">
    /// An optional delegate to handle parse errors. If provided, this delegate will be invoked for each error encountered
    /// during parsing.
    /// </param>
    /// <returns>
    /// <c>true</c> if the parsing succeeded; otherwise, <c>false</c>.
    /// </returns>
    public static bool TryParse(
        string cqlContent,
        [NotNullWhen(true)]out CqlLibraryString? result,
        CqlParseErrorHandler? onError = null)
    {
        if (!cqlContent.TryParseCqlLibraryDefinition(out var ntuple, onError))
        {
            result = null;
            return false;
        }

        var tuple = ntuple.Value;
        var qualifiedIdentifier = tuple switch
        {
            ({ Length: > 0 } q, { } i, _) => CqlLibraryIdentifier.NewVerbatim($"{q}.{i}"),
            var (_, i, _)                 => CqlLibraryIdentifier.NewVerbatim(i),
        };

        CqlLibraryVersion? version = tuple.version switch
        {
            ({ Length: > 0 } v) => CqlLibraryVersion.NewVerbatim(v),
            _                   => null
        };

        var libVer = CqlVersionedLibraryIdentifier.FromIdentifierAndVersion(qualifiedIdentifier, version);
        result = new CqlLibraryString(libVer, cqlContent);
        return true;
    }

    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="CqlLibraryString"/> struct.
    /// </summary>
    /// <param name="libraryIdentifier">The identifier of the CQL library.</param>
    /// <param name="cql">The content of the CQL library.</param>
    private CqlLibraryString(
        CqlVersionedLibraryIdentifier libraryIdentifier,
        string cql)
    {
        LibraryIdentifier = libraryIdentifier;
        Cql = cql;
    }

    /// <summary>
    /// Gets the identifier of the CQL library.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier { get; }

    /// <summary>
    /// Gets the content of the CQL library.
    /// </summary>
    public string Cql { get; }

    /// <summary>
    /// Deconstructs the <see cref="CqlLibraryString"/> into its components.
    /// </summary>
    /// <param name="libraryIdentifier">The identifier of the CQL library.</param>
    /// <param name="cql">The content of the CQL library.</param>
    public void Deconstruct(
        out CqlVersionedLibraryIdentifier libraryIdentifier,
        out string cql)
    {
        libraryIdentifier = LibraryIdentifier;
        cql = Cql;
    }

    /// <summary>
    /// Implicitly converts a <see cref="CqlLibraryString"/> to a <see cref="string"/> using the CQL content.
    /// </summary>
    /// <returns>Returns the CQL.</returns>
    public static implicit operator string(CqlLibraryString cqlLibraryString) => cqlLibraryString.Cql;

    /// <summary>
    /// Implicitly converts a <see cref="CqlLibraryString"/> to a <see cref="CqlVersionedLibraryIdentifier"/> using the LibraryIdentifier.
    /// </summary>
    /// <returns>Returns the <see cref="CqlVersionedLibraryIdentifier"/>.</returns>
    public static implicit operator CqlVersionedLibraryIdentifier(CqlLibraryString cqlLibraryString) => cqlLibraryString.LibraryIdentifier;

    /// <summary>
    /// Explicitly parses a <see cref="string"/> to a <see cref="CqlLibraryString"/>.
    /// </summary>
    /// <returns>Returns the <see cref="CqlLibraryString"/>.</returns>
    public static explicit operator CqlLibraryString(string cqlLibraryString) => Parse(cqlLibraryString);
}
