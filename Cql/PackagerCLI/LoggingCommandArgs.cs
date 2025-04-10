using Hl7.Cql.Packager.Options;

namespace Hl7.Cql.Packager;

internal record LoggingCommandArgs(
    bool? LogDebug,
    bool? LogAppend) {

    public IEnumerable<KeyValuePair<string, string?>> MapToConfiguration()
    {
        if (LogDebug is { } logDebug)
            yield return KeyValuePair.Create($"{LoggingOptions.ConfigSection}:{nameof(LoggingOptions.Debug)}", (string?)JsonSerializer.Serialize(logDebug));
        if (LogAppend is { } logAppend)
            yield return KeyValuePair.Create($"{LoggingOptions.ConfigSection}:{nameof(LoggingOptions.Append)}", (string?)JsonSerializer.Serialize(logAppend));
    }
}