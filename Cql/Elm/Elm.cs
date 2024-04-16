#pragma warning disable IDE1006 // Naming violation suppressed.
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Hl7.Cql.Abstractions.Exceptions;
using System.Diagnostics;
using System.Text.Json.Serialization;

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
    /// <inheritedoc/>
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
    /// Gets the name.
    /// </summary>
    string? name { get; }
}
partial class AliasRef : IGetName { }
partial class CodeRef : IGetName { }
partial class CodeSystemDef : IGetName { }
partial class CodeSystemRef : IGetName { }
partial class ConceptDef : IGetName { }
partial class ConceptRef : IGetName { }
partial class ExpressionDef : IGetName { }
partial class ExpressionRef : IGetName { }
partial class IdentifierRef : IGetName { }
partial class InstanceElement : IGetName { }
partial class OperandDef : IGetName { }
partial class OperandRef : IGetName { }
partial class ParameterDef: IGetName { }
partial class ParameterRef: IGetName { }
partial class QueryLetRef: IGetName { }
partial class Tag: IGetName { }
partial class TupleElement: IGetName { }
partial class TupleElementDefinition: IGetName { }
partial class ValueSetDef: IGetName { }
partial class ValueSetRef: IGetName { }

#endregion

#region GetDateTimePrecision

public interface IGetDateTimePrecision
{
    DateTimePrecision precision { get; }
    bool precisionSpecified { get; }
}

public static class IGetDateTimePrecisionExtensions
{
    public static DateTimePrecision? precisionNullable(this IGetDateTimePrecision obj) => obj.precisionSpecified ? obj.precision : null;
}

partial class CalculateAgeAt : IGetDateTimePrecision {}
partial class Ends : IGetDateTimePrecision {}
partial class Starts : IGetDateTimePrecision {}
partial class OverlapsAfter : IGetDateTimePrecision {}
partial class OverlapsBefore : IGetDateTimePrecision {}
partial class Overlaps : IGetDateTimePrecision {}
partial class MeetsAfter : IGetDateTimePrecision {}
partial class MeetsBefore : IGetDateTimePrecision {}
partial class Meets : IGetDateTimePrecision {}
partial class After : IGetDateTimePrecision {}
partial class Before : IGetDateTimePrecision {}
partial class ProperIncludedIn : IGetDateTimePrecision {}
partial class ProperIncludes : IGetDateTimePrecision {}
partial class IncludedIn : IGetDateTimePrecision {}
partial class Includes : IGetDateTimePrecision { }
partial class ProperIn : IGetDateTimePrecision { }
partial class In : IGetDateTimePrecision { }
partial class ProperContains : IGetDateTimePrecision { }
partial class Contains : IGetDateTimePrecision { }
partial class SameOrAfter : IGetDateTimePrecision { }
partial class SameOrBefore : IGetDateTimePrecision { }
partial class SameAs : IGetDateTimePrecision { }
partial class DifferenceBetween : IGetDateTimePrecision { }
partial class DurationBetween : IGetDateTimePrecision { }
partial class CalculateAge : IGetDateTimePrecision { }
partial class CalculateAgeAt : IGetDateTimePrecision { }
partial class DateTimeComponentFrom : IGetDateTimePrecision { }

#endregion