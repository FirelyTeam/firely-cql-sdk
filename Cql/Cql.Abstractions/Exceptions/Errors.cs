namespace Hl7.Cql.Abstractions.Exceptions;

internal readonly record struct KeyNotFoundError(string Key, string? ValueTypeName = null) : ICqlError
{
    public string GetMessage() => $"{ValueTypeName ?? "Object"} not found by key. Key: '{Key}'";
}
internal readonly record struct UnsupportedSwitchCaseError(object Value, string? ValueTypeName = null) : ICqlError
{
    public string GetMessage() => $"Switch case not supported for {ValueTypeName ?? "Object"} of value: '{Value}'";
}

internal readonly record struct CouldNotDeserializeFileError(string FilePath, string? ObjectTypeName = null) : ICqlError
{
    public string GetMessage() => $"Could not deserialize to a valid {ObjectTypeName ?? "Object"}. Path: '{FilePath}'";
}

internal readonly record struct CouldNotValidateFileError(string FilePath, string? ObjectTypeName = null) : ICqlError
{
    public string GetMessage() => $"Could not validate {ObjectTypeName ?? "Object"}. Path: '{FilePath}'";
}