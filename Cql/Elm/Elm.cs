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
using System.Text.Json.Serialization;
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

#region GetPrecision

/// <summary>
/// Interface for getting the precision of an object.
/// </summary>
internal interface IGetPrecision
{
    object? precisionOrNull { get; }
}

partial class CalculateAgeAt : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class Ends : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class Starts : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class OverlapsAfter : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class OverlapsBefore : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class Overlaps : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class MeetsAfter : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class MeetsBefore : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class Meets : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class After : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class Before : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class ProperIncludedIn : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class ProperIncludes : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class IncludedIn : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class Includes : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class ProperIn : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class In : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class ProperContains : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class Contains : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class SameOrAfter : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class SameOrBefore : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class SameAs : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class DifferenceBetween : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class DurationBetween : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class CalculateAge : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class DateTimeComponentFrom : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precisionSpecified ? precision : null;
}
partial class Round : IGetPrecision
{
    /// <inheritdoc />
    public object? precisionOrNull => precision;
}

#endregion

#region GetOperands

/// <summary>
/// Arity is the number of arguments or operands taken by a function.
/// </summary>
internal enum Arity
{
    Unary,
    Binary,
    Ternary,
    Nary,
}

/// <summary>
/// Interface for getting the operands of an object.
/// </summary>
internal interface IGetOperands
{
    TypeSpecifier[] signature { get; }
    Expression[] operands { get; }
    Arity arity { get; }
}

internal interface IUnaryOperator
{
    TypeSpecifier[] signature { get; }
    Expression operand { get; }
}

partial class FunctionRef : IGetOperands
{
    /// <inheritdoc />
    public Expression[] operands => operand;
    /// <inheritdoc />
    Arity IGetOperands.arity => Arity.Nary;
}
partial class NaryExpression : IGetOperands
{
    /// <inheritdoc />
    public Expression[] operands => operand;
    /// <inheritdoc />
    Arity IGetOperands.arity => Arity.Nary;
}
partial class TernaryExpression : IGetOperands
{
    /// <inheritdoc />
    public Expression[] operands => operand;
    /// <inheritdoc />
    Arity IGetOperands.arity => Arity.Ternary;
}
partial class BinaryExpression : IGetOperands
{
    /// <inheritdoc />
    public Expression[] operands => operand;
    /// <inheritdoc />
    Arity IGetOperands.arity => Arity.Binary;
}

partial class UnaryExpression : IGetOperands, IUnaryOperator
{
    /// <inheritdoc />
    public Expression[] operands => [operand];
    /// <inheritdoc />
    Arity IGetOperands.arity => Arity.Unary;
}

partial class Round : IGetOperands, IUnaryOperator
{
    /// <inheritdoc />
    public Expression[] operands => [operand];
    /// <inheritdoc />
    Arity IGetOperands.arity => Arity.Unary;
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