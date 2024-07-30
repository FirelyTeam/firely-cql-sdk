/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.Elm;

internal interface ILibraryError : ICqlError
{
    Library Library { get; }
}

internal readonly record struct LibraryMissingIncludeDefPathError(Library Library, IncludeDef IncludeDef) : ILibraryError
{
    public string GetMessage() => $"Library has an include definition with a missing path. Library Identifier: '{Library}', IncludeDef: '{IncludeDef}'";
}

internal readonly record struct MissingNameError(IGetNameAndVersion Source) : ICqlError
{
    public string GetMessage() => $"{Source.GetType().Name} did not have a valid name.";
}

internal readonly record struct MissingIdentifierError(IGetNameAndVersion Source) : ICqlError
{
    public string GetMessage() => $"{Source.GetType().Name} did not have an identifier.";
}

internal readonly record struct MissingAliasError(IGetLibraryName Source) : ICqlError
{
    public string GetMessage() => $"{Source.GetType().Name} did not have an alias. Source: {Source}";
}

internal readonly record struct UntypedOperandInFunctionError(IFunctionElement Func, OperandDef Element) : ICqlError
{
    public string GetMessage() => $"Function {Func.Name}' has a parameter '{Element.name}' without a type specifier.";
}

internal readonly record struct UntypedOperandInFunctionRefError(FunctionRef Func, int Index) : ICqlError
{
    public string GetMessage() => $"Function reference to {Func.name}', and parameter {Index} has no type specifier.";
}