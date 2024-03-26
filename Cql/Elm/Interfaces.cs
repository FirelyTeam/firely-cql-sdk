#pragma warning disable IDE1006 // Naming violation suppressed.
#pragma warning disable RS0016 // Undocumented public api members.

using System;
using Hl7.Cql.Abstractions.Exceptions;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Hl7.Cql.Elm;


#region NameAndVersion

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

#region interface IGetAlias (from libraryName)

/// <summary>
/// Gets an alias
/// </summary>
public interface IGetLibraryAlias
{
    /// <summary>
    /// Gets the alias.
    /// </summary>
    /// <param name="throwError">Indicates whether to throw an exception if the alias is missing.</param>
    /// <returns>The alias.</returns>
    string? GetLibraryAlias(bool throwError = true);
}

static class Sanitizer
{
    public static string? SanitizeLibraryName(this IGetLibraryAlias source, string? libraryNameWithVersion, bool throwError = true)
    {
        if (!string.IsNullOrEmpty(libraryNameWithVersion))
        {
            return SanitizeNameAndVersion(libraryNameWithVersion);
        }

        if (throwError)
            throw new MissingAliasError(source).ToException();

        return null!;
    }

    public static string SanitizeNameAndVersion(string libraryNameWithVersion)
    {
        var parts = libraryNameWithVersion.Split('-', 2);
        if (parts.Length == 1) return parts[0];

        var version = parts[1];
        var versionParts = version.Split('.');
        version = string.Join('.', versionParts.Select(vp => vp.TrimStart('0'))); // Remove leading zeros
        return $"{parts[0]}-{version}";
    }
}

partial class IncludeDef : IGetLibraryAlias
{
    /// <inheritdoc/>
    public string? GetLibraryAlias(bool throwError = true) =>
        this.SanitizeLibraryName(localIdentifier, false)
        ?? this.SanitizeLibraryName(path, throwError);
}


partial class CodeRef : IGetLibraryAlias
{
    /// <inheritdoc/>
    public string? GetLibraryAlias(bool throwError = true) => this.SanitizeLibraryName(libraryName, throwError);
}

partial class CodeSystemRef : IGetLibraryAlias
{
    /// <inheritdoc/>
    public string? GetLibraryAlias(bool throwError = true) => this.SanitizeLibraryName(libraryName, throwError);
}
partial class ConceptRef : IGetLibraryAlias
{
    /// <inheritdoc/>
    public string? GetLibraryAlias(bool throwError = true) => this.SanitizeLibraryName(libraryName, throwError);
}

partial class ExpressionRef : IGetLibraryAlias
{
    /// <inheritdoc/>
    public string? GetLibraryAlias(bool throwError = true) => this.SanitizeLibraryName(libraryName, throwError);
}

partial class IdentifierRef : IGetLibraryAlias
{
    /// <inheritdoc/>
    public string? GetLibraryAlias(bool throwError = true) => this.SanitizeLibraryName(libraryName, throwError);
}

partial class ParameterRef : IGetLibraryAlias
{
    /// <inheritdoc/>
    public string? GetLibraryAlias(bool throwError = true) => this.SanitizeLibraryName(libraryName, throwError);
}

partial class ValueSetRef : IGetLibraryAlias
{
    /// <inheritdoc/>
    public string? GetLibraryAlias(bool throwError = true) => this.SanitizeLibraryName(libraryName, throwError);
}

#endregion

#region Path

internal interface IGetPath
{
    string? path { get; }
}
partial class AggregateExpression : IGetPath { }
partial class ByColumn : IGetPath { }
partial class Property : IGetPath { }

#endregion

#region Name

internal interface IGetName 
{
    string? name { get; }
}
partial class AliasRef : IGetName { }
partial class CodeRef : IGetName { }
partial class CodeSystemDef : IGetName { }
partial class CodeSystemRef : IGetName { }
partial class ConceptDef : IGetName { }
partial class ConceptRef : IGetName { }
partial class ExpressionDef : IGetName { }

partial class ExpressionRef : IGetName
{ }
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