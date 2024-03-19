#pragma warning disable IDE1006 // Naming violation suppressed.

using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.Elm;

#region NameAndVersion

internal interface IGetNameAndVersion
{
    /// <summary>
    /// Gets the name with version, or just the name if no version exists.
    /// </summary>
    string? NameAndVersion(bool throwError = true);
}

partial class Library : IGetNameAndVersion
{
    /// <inheritedoc/>
    public string? NameAndVersion(bool throwError = true)
    {
        if (identifier == null)
        {
            if (throwError) throw new MissingIdentifierError(this).ToException();
            return null;
        }
        return identifier.NameAndVersion(throwError);
    }
}

partial class IncludeDef : IGetNameAndVersion
{
    /// <inheritedoc/>
    public string? NameAndVersion(bool throwError = true)
    {
        if (string.IsNullOrEmpty(path))
        {
            if (throwError) throw new MissingNameError(this).ToException();
            return null;
        }

        if (string.IsNullOrEmpty(version))
        {
            return path;
        }

        return $"{path}-{version}";
    }
}

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
}

#endregion

#region LibraryName

internal interface IGetLibraryName
{
    string? libraryName { get; }
}
partial class CodeRef : IGetLibraryName {}
partial class CodeSystemRef : IGetLibraryName {}
partial class ConceptRef : IGetLibraryName {}
partial class ExpressionRef : IGetLibraryName {}
partial class IdentifierRef : IGetLibraryName {}
partial class ParameterRef : IGetLibraryName {}
partial class ValueSetRef : IGetLibraryName {}

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