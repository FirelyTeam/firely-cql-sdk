namespace Hl7.Cql.Abstractions.Exceptions;

internal readonly record struct KeyNotFoundError(string Key, string? ValueTypeName = null) : ICqlError
{
    public string GetMessage() => $"{ValueTypeName ?? "Object"} not found by key. Key: '{Key}'";
}

internal readonly record struct CouldNotDeserializeFileError(string FilePath, string? ObjectTypeName = null) : ICqlError
{
    public string GetMessage() => $"Could not deserialize to a valid {ObjectTypeName ?? "Object"}. Path: '{FilePath}'";
}