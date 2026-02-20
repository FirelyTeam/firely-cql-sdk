/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Exceptions;

internal readonly record struct KeyNotFoundError(string Key, string? TypeName = null) : ICqlError
{
    public string GetMessage() => $"{TypeName ?? "Object"} not found by key. Key: '{Key}'";
}

internal readonly record struct CouldNotValidateLibraryError(string? FilePath, string? TypeName = null) : ICqlError
{
    public string GetMessage() => $"Could not validate {TypeName ?? "Object"}. " +
                                  (FilePath is not null ? $"Path: '{FilePath}'" : "");
}

internal readonly record struct CouldNotConvertInstanceToTargetType(object Instance, Type TargetType) : ICqlError
{
    public string GetMessage() => $"Could not convert instance '{Instance}' of type '{Instance?.GetType()} to type {TargetType}";
}