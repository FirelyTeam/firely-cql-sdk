/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
#pragma warning disable IDE1006 // Naming violation suppressed.

using Hl7.Cql.Abstractions.Exceptions;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

// ReSharper disable InconsistentNaming

namespace Hl7.Cql.Elm;

file static class StringExtensions
{
    public static string? NullIfEmpty(this string? text) => string.IsNullOrEmpty(text) ? null : text;
}

#region GetNameAndVersion

/// <summary>
/// Interface for getting the name and version of an object.
/// </summary>
internal interface IGetNameAndVersion
{
    /// <summary>
    /// Gets the name with version, or just the name if no version exists.
    /// </summary>
    /// <param name="throwError">Indicates whether to throw an exception if the identifier is missing.</param>
    /// <returns>The name with version, or just the name if no version exists.</returns>
    /// <remarks>The name and version are formatted in CQL style, e.g. "FHIRHelpers-4.0.1".</remarks>
    string? NameAndVersion(bool throwError = true);

    /// <summary>
    /// Gets the versioned identifier, or null if the identifier is missing.
    /// </summary>
    /// <param name="throwError">Indicates whether to throw an exception if the identifier is missing.</param>
    /// <returns>The versioned identifier, or null if the identifier is missing.</returns>
    VersionedIdentifier? GetVersionedIdentifier(bool throwError = true);
}

[DebuggerDisplay("{GetType().Name,nq} {ToString()}")]
partial class Library : IGetNameAndVersion
{
    /// <inheritdoc />
    public string? NameAndVersion(bool throwError = true) =>
        GetVersionedIdentifier(throwError)!
            .NameAndVersion(throwError);

    /// <inheritdoc />
    public VersionedIdentifier? GetVersionedIdentifier(bool throwError = true)
    {
        if (identifier != null) return identifier;

        if (throwError) throw new MissingIdentifierError(this).ToException();
        return null;
    }

    /// <inheritdoc />
    public override string? ToString() => NameAndVersion(false);
}

[DebuggerDisplay("{GetType().Name,nq} {ToString()}")]
partial class IncludeDef : IGetNameAndVersion
{
    /// <inheritdoc />
    public string? NameAndVersion(bool throwError = true) =>
        GetVersionedIdentifier(throwError)!
            .NameAndVersion(throwError);

    /// <inheritdoc />
    public VersionedIdentifier? GetVersionedIdentifier(bool throwError = true)
    {
        if (path is {Length:>0})
            return new()
            {
                id = path,
                version = version is {Length:0} ? null : version
            };

        if (throwError) throw new MissingIdentifierError(this).ToException();
        return null;
    }

    /// <inheritdoc />
    public override string? ToString() => NameAndVersion(false);
}

[DebuggerDisplay("{GetType().Name,nq} {ToString()}")]
partial class VersionedIdentifier : IGetNameAndVersion
{
    /// <inheritdoc />
    public string? NameAndVersion(bool throwError = true)
    {
        if (string.IsNullOrEmpty(id))
        {
            if (throwError) throw new MissingNameError(this).ToException();
            return null;
        }

        if (string.IsNullOrEmpty(version))
        {
            return id;
        }

        return $"{id}-{version}";
    }

    /// <inheritdoc />
    VersionedIdentifier? IGetNameAndVersion.GetVersionedIdentifier(bool throwError) => this;

    /// <inheritdoc />
    public override string? ToString() => NameAndVersion(false);
}

#endregion

#region GetLibraryName

/// <summary>
/// Interface for getting the library name of an object.
/// </summary>
internal interface IGetLibraryName
{
    /// <summary>
    /// Gets the library name.
    /// </summary>
    string? libraryName { get; }
}

partial class IncludeDef : IGetLibraryName
{
    /// <inheritdoc />
    [JsonIgnore]
    [XmlIgnore]
    public string? libraryName => localIdentifier.NullIfEmpty() ?? path.NullIfEmpty();
}

partial class CodeRef : IGetLibraryName { }
partial class CodeSystemRef : IGetLibraryName { }
partial class ConceptRef : IGetLibraryName { }
partial class ExpressionRef : IGetLibraryName { }
partial class IdentifierRef : IGetLibraryName { }
partial class ParameterRef : IGetLibraryName { }
partial class ValueSetRef : IGetLibraryName { }

#endregion

#region GetPath

/// <summary>
/// Interface for getting the path of an object.
/// </summary>
internal interface IGetPath
{
    /// <summary>
    /// Gets the path.
    /// </summary>
    string? path { get; }
}
partial class AggregateExpression : IGetPath { }
partial class ByColumn : IGetPath { }
partial class Property : IGetPath { }

#endregion

#region GetName

/// <summary>
/// Interface for getting the name of an object.
/// </summary>
internal interface IGetName
{
    /// <summary>
    /// The name of the definition by which it can be referenced.
    /// </summary>
    string? name { get; }
}

partial class AliasRef : IReferenceElement { }
partial class CodeRef : IReferenceElement { }
partial class CodeSystemDef : IGetName { }
partial class CodeSystemRef : IReferenceElement { }
partial class ConceptDef : IGetName { }
partial class ConceptRef : IReferenceElement { }
partial class ExpressionDef : IGetName { }
partial class ExpressionRef : IReferenceElement { }
partial class IdentifierRef : IReferenceElement { }
partial class InstanceElement : IGetName { }
partial class OperandDef : IGetName { }
partial class OperandRef : IReferenceElement { }
partial class ParameterDef: IGetName { }
partial class ParameterRef: IReferenceElement { }
partial class QueryLetRef: IGetName { }
partial class Tag: IGetName { }
partial class TupleElement: IGetName { }
partial class TupleElementDefinition: IGetName { }
partial class ValueSetDef: IGetName { }
partial class ValueSetRef: IReferenceElement { }

#endregion

#region GetPrecision

/// <summary>
/// Interface for getting the precision of an object.
/// </summary>
internal interface IGetPrecision
{
    object? GetPrecision();
}

partial class CalculateAgeAt : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class Ends : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class Starts : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class OverlapsAfter : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class OverlapsBefore : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class Overlaps : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class MeetsAfter : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class MeetsBefore : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class Meets : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class After : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class Before : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class ProperIncludedIn : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class ProperIncludes : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class IncludedIn : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class Includes : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class ProperIn : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class In : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class ProperContains : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class Contains : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class SameOrAfter : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class SameOrBefore : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class SameAs : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class DifferenceBetween : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class DurationBetween : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class CalculateAge : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class DateTimeComponentFrom : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precisionSpecified ? precision : null;
}
partial class Round : IGetPrecision
{
    /// <inheritdoc />
    public object? GetPrecision() => precision;
}

#endregion

#region GetSource

/// <summary>
/// Interface for getting the source of an object.
/// </summary>
internal interface IGetSource
{
    Expression source { get; }
}

partial class Property : IGetSource {}
partial class AggregateExpression : IGetSource {}
partial class Repeat : IGetSource {}
partial class ForEach : IGetSource {}
partial class Sort : IGetSource {}
partial class Filter : IGetSource {}
partial class Message : IGetSource {}
partial class Descendents : IGetSource {}
partial class Children : IGetSource {}
partial class IndexOf : IGetSource {}
partial class Slice : IGetSource {}
partial class Last : IGetSource {}
partial class First : IGetSource {}
partial class Combine : IGetSource {}

#endregion