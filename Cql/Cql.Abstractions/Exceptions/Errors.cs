namespace Hl7.Cql.Abstractions.Exceptions;

internal readonly record struct KeyNotFoundError(string Key, string? TypeName = null) : ICqlError
{
    public string GetMessage() => $"{TypeName ?? "Object"} not found by key. Key: '{Key}'";
}
internal readonly record struct UnsupportedSwitchCaseError(object? Value = null, string? TypeName = null) : ICqlError
{
    public string GetMessage() => $"Switch case not supported for {TypeName ?? "Object"}"
                                  + Value is {} obj ? $" of value: '{obj}'" : "";
}

internal readonly record struct CouldNotDeserializeFileError(string? FilePath = null, string? TypeName = null) : ICqlError
{
    public string GetMessage() => $"Could not deserialize to a valid {TypeName ?? "Object"}."
                                  + FilePath is {Length:>0} filePath ? $" Path: '{filePath}'" : "";
}

internal readonly record struct CouldNotValidateFileError(string FilePath, string? TypeName = null) : ICqlError
{
    public string GetMessage() => $"Could not validate {TypeName ?? "Object"}. Path: '{FilePath}'";
}