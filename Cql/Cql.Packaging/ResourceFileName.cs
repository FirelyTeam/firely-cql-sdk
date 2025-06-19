using System.Text.Json.Serialization;
using Hl7.Cql.Runtime.Serialization;

namespace Hl7.Cql.Packaging;

/// <summary>
/// Represents a resource file name with Type, Identifier, and optional Version.
/// Each part is separated by a hyphen in the file name.
/// Each part should not contain hyphens nor underscores.
/// </summary>
/// <remarks>
/// A new instance is created using the <see cref="Create"/> method.
/// </remarks>
[JsonConverter(typeof(StringEncapsulatedValueJsonConverter<ResourceFileName>))]
public readonly record struct ResourceFileName : IParsable<ResourceFileName>
{
    // Should not contain underscores - https://build.fhir.org/ig/HL7/cql-ig/conformance.html#library-name-and-url
    // !! Special handling around hyphens as it is used to delimit between resource type, identifier and version

#pragma warning disable CS0162 // Unreachable code detected
    private static readonly char[] InvalidChars = ['-'];
#pragma warning restore CS0162 // Unreachable code detected

    private static readonly ArgValidator<string> ValidateType = Arg.IsRequired().And(Arg.ShouldNotContain(InvalidChars));
    private static readonly ArgValidator<string> ValidateIdentifier = Arg.IsRequired().And(Arg.ShouldNotContain(InvalidChars));
    private static readonly ArgValidator<string?> ValidateVersion = Arg.ShouldNotContain(InvalidChars);

    private ResourceFileName(
        string type,
        string identifier,
        string? version = null) =>
        (Type, Identifier, Version) = (type ?? throw new ArgumentNullException(nameof(type)), identifier ?? throw new ArgumentNullException(nameof(identifier)), version);

    /// <summary>
    /// Creates a new instance of <see cref="ResourceFileName"/>.
    /// </summary>
    /// <param name="type">The type of the resource.</param>
    /// <param name="identifier">The identifier of the resource.</param>
    /// <param name="version">The optional version of the resource.</param>
    /// <returns>A new instance of <see cref="ResourceFileName"/>.</returns>
    /// <exception cref="ArgumentException">Thrown when validation fails.</exception>
    public static ResourceFileName Create(
        string type,
        string identifier,
        string? version = null)
    {
        if (ValidateType(type, ThrowArgumentException)
            && ValidateIdentifier(identifier, ThrowArgumentException)
            && ValidateVersion(version, ThrowArgumentException))
            return new ResourceFileName(type, identifier, version);

        throw new UnreachableException();
    }

    private static void ThrowArgumentException(FormattableString failureMessage, string paramName) => throw new ArgumentException(failureMessage.ToString(null), paramName);

    /// <summary>
    /// Gets the file name with extension.
    /// </summary>
    public string FileName => FileNameWithoutExtension switch
    {
        { Length: > 0 } name => $"{name}.json",
        _ => null!, // Handles default instances
    };

    /// <summary>
    /// Gets the file name without extension.
    /// </summary>
    public string FileNameWithoutExtension => this switch
    {
        { Type: { Length: > 0 } type, Identifier: { } id, Version: { Length: > 0 } ver } => $"{type}-{id}-{ver}",
        { Type: { Length: > 0 } type, Identifier: { } id } => $"{type}-{id}",
        _ => null!, // Handles default instances
    };

    /// <summary>
    /// Gets the type of the resource.
    /// </summary>
    public string Type { get; }

    /// <summary>
    /// Gets the identifier of the resource.
    /// </summary>
    public string Identifier { get; }

    /// <summary>
    /// Gets the optional version of the resource.
    /// </summary>
    public string? Version { get; }

    /// <summary>
    /// Deconstructs the resource file name into its components.
    /// </summary>
    /// <param name="type">The type of the resource.</param>
    /// <param name="identifier">The identifier of the resource.</param>
    /// <param name="version">The optional version of the resource.</param>
    public void Deconstruct(
        out string type,
        out string identifier,
        out string? version)
    {
        type = Type;
        identifier = Identifier;
        version = Version;
    }

    /// <summary>
    /// Deconstructs the resource file name into its type and identifier.
    /// </summary>
    /// <param name="type">The type of the resource.</param>
    /// <param name="identifier">The identifier of the resource.</param>
    public void Deconstruct(
        out string type,
        out string identifier)
    {
        type = Type;
        identifier = Identifier;
    }

    /// <summary>
    /// Returns the string representation of the resource file name.
    /// </summary>
    /// <returns>The string representation of the resource file name.</returns>
    public override string ToString() => FileName ?? ""; // FileName is null in case of default instances.

    /// <summary>
    /// Parses the string representation of a resource file name.
    /// </summary>
    /// <param name="s">The string representation of the resource file name.</param>
    /// <param name="provider">The format provider.</param>
    /// <returns>The parsed <see cref="ResourceFileName"/>.</returns>
    /// <exception cref="FormatException">Thrown when the format is invalid.</exception>
    public static ResourceFileName Parse(string s, IFormatProvider? provider)
    {
        if (TryParse(s, provider, out var result))
            return result;

        throw new FormatException("Invalid format for ResourceFileName.");
    }

    /// <summary>
    /// Tries to parse the string representation of a resource file name.
    /// </summary>
    /// <param name="s">The string representation of the resource file name.</param>
    /// <param name="provider">The format provider.</param>
    /// <param name="result">The parsed <see cref="ResourceFileName"/>.</param>
    /// <returns><c>true</c> if parsing was successful; otherwise, <c>false</c>.</returns>
    public static bool TryParse(
        [NotNullWhen(true)] string? s,
        IFormatProvider? provider,
        out ResourceFileName result)
    {
        if (s is not null)
        {
            if (s.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                s = s[..^5]; // Remove the extension

            var parts = s.Split('-', 4, StringSplitOptions.TrimEntries);
            if (parts?.Length is 2 or 3)
            {
                string type = parts[0];
                string identifier = parts[1];
                string? version = parts.ElementAtOrDefault(2);
                if (ValidateType(type)
                    && ValidateIdentifier(identifier)
                    && ValidateVersion(version))
                {
                    result = new ResourceFileName(type, identifier, version);
                    return true;
                }
            }
        }

        result = default;
        return false;
    }
}

internal delegate void ArgValidationFailHandler(
    FormattableString failureMessage,
    string argName);

internal delegate bool ArgValidator<in T>(
    T? arg,
    ArgValidationFailHandler? handleFailure = null,
    [CallerArgumentExpression(nameof(arg))] string argName = "");

file static class Arg
{
    public static ArgValidator<string?> IsRequired() =>
        FromPredicateAndFailureMessage<string?>(
            val => val is { Length: > 0 },
            argName => $"'{argName}' is required.");

    public static ArgValidator<string?> ShouldNotContain(params char[] chars) =>
        FromPredicateAndFailureMessage<string?>(
            val => val == null || val.IndexOfAny(chars) < 0,
            argName => $"'{argName}' should not contain the character(s): {string.Join(", ", chars.Select(c => $"'{c}'"))}.");

    private delegate FormattableString FailureMessageBuilder(string argName);

    private static ArgValidator<T> FromPredicateAndFailureMessage<T>(
        Predicate<T?> predicate,
        FailureMessageBuilder buildFailureMessage) =>
        (arg, handleFailure, argName) =>
        {
            if (predicate(arg)) return true;
            handleFailure?.Invoke(buildFailureMessage(argName), argName);
            return false;
        };

    public static ArgValidator<T> And<T>(this ArgValidator<T> first, ArgValidator<T>? second) =>
        (arg, paramName, failure) => first(arg, paramName, failure) && (second?.Invoke(arg, paramName, failure) ?? true);
}