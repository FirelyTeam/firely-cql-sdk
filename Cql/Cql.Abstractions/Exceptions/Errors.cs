namespace Hl7.Cql.Abstractions.Exceptions;

internal readonly record struct KeyNotFoundError(string Key, string? ValueTypeName = null) : ICqlError
{
    public string GetMessage() => $"{ValueTypeName ?? "Object"} not found by key. Key: '{Key}'";
}

internal readonly record struct NotAValidLibraryFileError(string FilePath) : ICqlError
{
    public string GetMessage() => $"Not a valid ELM library. Library Path: '{FilePath}'";
}