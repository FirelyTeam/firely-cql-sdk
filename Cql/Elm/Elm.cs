/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Threading;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Runtime;

// ReSharper disable InconsistentNaming

namespace Hl7.Cql.Elm;

#region GetVersionedIdentifier

internal static class IGetVersionedIdentifierExtensions
{
    /// <summary>
    /// Retrieves the versioned library identifier string from the specified
    /// <see cref="IGetVersionedIdentifier"/> instance. This string represents the
    /// name and version of the library in a formatted manner.
    /// </summary>
    /// <param name="getVersionedIdentifier">
    /// The <see cref="IGetVersionedIdentifier"/> instance from which to retrieve the versioned library identifier string.
    /// </param>
    /// <returns>
    /// A string representing the versioned library identifier if available; otherwise, <c>null</c>.
    /// </returns>
    public static string? GetVersionedLibraryIdentifierString(
        this IGetVersionedIdentifier getVersionedIdentifier) =>
        getVersionedIdentifier.VersionedIdentifier switch
        {
            ({ } result, _) => result.GetVersionedLibraryIdentifierString(),
            _               => null
        };
}

/// <summary>
/// Interface for getting the versioned identifier an object.
/// </summary>
internal interface IGetVersionedIdentifier
{
    /// <summary>
    /// Gets the versioned identifier, or null if the identifier is missing.
    /// </summary>
    /// <value>The versioned identifier, or error if the identifier is missing.</value>
    (VersionedIdentifier? Result, Exception? Error) VersionedIdentifier { get; }

    /// <summary>
    /// Gets the versioned library identifier.
    /// </summary>
    [JsonIgnore]
    [XmlIgnore]
    CqlVersionedLibraryIdentifier VersionedLibraryIdentifier { get; }
}

[DebuggerDisplay("{GetType().Name,nq} {ToString()}")]
partial class Library : IGetVersionedIdentifier
{
    /// <nodoc />
    public Library()
    {
    }

    /// <nodoc />
    public Library(VersionedIdentifier identifier)
    {
        this.identifier = identifier;
    }

    /// <inheritdoc />
    (VersionedIdentifier? Result, Exception? Error) IGetVersionedIdentifier.VersionedIdentifier =>
        identifier switch
        {
            null => (null, new MissingIdentifierError(this).ToException()),
            _    => (identifier, null)
        };

    /// <inheritdoc />
    [JsonIgnore]
    [XmlIgnore]
    public CqlVersionedLibraryIdentifier VersionedLibraryIdentifier
    {
        get
        {
            if (identifier is not { id.Length: > 0 })
                throw new MissingIdentifierError(this).ToException();
            return CqlVersionedLibraryIdentifier.ParseFromNameAndVersion(identifier.id, identifier.version);
        }
    }

    /// <inheritdoc />
    public override string? ToString() => this.GetVersionedLibraryIdentifierString();
}

[DebuggerDisplay("{GetType().Name,nq} {ToString()}")]
partial class IncludeDef : IGetVersionedIdentifier
{
    /// <inheritdoc />
    (VersionedIdentifier? Result, Exception? Error) IGetVersionedIdentifier.VersionedIdentifier =>
        path switch
        {
            { Length: > 0 } => (new() { id = path, version = version is { Length: 0 } ? null : version }, null),
            _               => (null, new MissingIdentifierError(this).ToException())
        };


    /// <inheritdoc />
    [JsonIgnore]
    [XmlIgnore]
    public CqlVersionedLibraryIdentifier VersionedLibraryIdentifier
    {
        get
        {
            if (path is not { Length: > 0 })
                throw new MissingIdentifierError(this).ToException();
            return CqlVersionedLibraryIdentifier.ParseFromNameAndVersion(path, version);
        }
    }

    /// <inheritdoc />
    public override string? ToString() => this.GetVersionedLibraryIdentifierString();
}

[DebuggerDisplay("{GetType().Name,nq} {ToString()}")]
partial class VersionedIdentifier : IGetVersionedIdentifier
{
    internal string? GetVersionedLibraryIdentifierString() =>
        CqlVersionedLibraryIdentifier.BuildString(id, version);

    /// <inheritdoc />
    (VersionedIdentifier? Result, Exception? Error) IGetVersionedIdentifier.VersionedIdentifier => (this, null);

    /// <inheritdoc />
    [JsonIgnore]
    [XmlIgnore]
    public CqlVersionedLibraryIdentifier VersionedLibraryIdentifier
    {
        get
        {
            if (id is not { Length: > 0 })
                throw new MissingIdentifierError(this).ToException();
            return CqlVersionedLibraryIdentifier.ParseFromNameAndVersion(id, version);
        }
    }

    /// <inheritdoc />
    public override string? ToString() => GetVersionedLibraryIdentifierString();
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

partial class Element
{
    /// <summary>
    /// Returns the type of the element, either from resultTypeSpecifier or resultTypeName.
    /// </summary>
    public virtual TypeSpecifier? GetTypeSpecifier() =>
        resultTypeSpecifier ?? resultTypeName?.ToNamedType();
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
partial class OperandDef : IGetName
{
    /// <inheritdoc />
    public override TypeSpecifier? GetTypeSpecifier() =>
        operandTypeSpecifier ?? operandType?.ToNamedType() ?? base.GetTypeSpecifier();
}
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