namespace Hl7.Cql.Runtime.Parsing;

/// <summary>
/// Provides a collection of predefined error messages for parsing operations in the CQL runtime.
/// </summary>
public static class CqlParseErrors
{
    /// <summary>
    /// Represents an error message indicating that additional tokens were found after the expected end of input.
    /// </summary>
    public const string MoreTokensAfterEndOfInput = "More tokens after expected end of input.";

    /// <summary>
    /// Represents an error message indicating that a specific token was expected but not found.
    /// </summary>
    public const string ExpectedTokenNotFound_1 = "Expected {0} token not found.";

    /// <summary>
    /// Represents an error message indicating that a specific token was expected but not found, with a suggestion to use a different token.
    /// </summary>
    public const string TextOpenedButNotClosed = "Text is opened with a special character, but not closed.";

    /// <summary>
    /// Represents an error message indicating that a specific token was expected but not found, with a suggestion to use a different token.
    /// </summary>
    public const string MultipleQualifiersNotSupported = "Multiple qualifiers not supported.";

    /// <summary>
    /// Represents an error message indicating that a specific token was expected but not found, with a suggestion to use a different token.
    /// </summary>
    public const string SyntaxErrorFound = "Syntax error found.";

    /// <summary>
    /// Represents an error message indicating a syntax error with a specific message.
    /// </summary>
    public const string SyntaxError_1 = "Syntax error: {0}.";

    /// <summary>
    /// Represents an error message indicating that a specific token was expected but not found, with a suggestion to use a different token.
    /// </summary>
    public const string NullOrEmpty = "Input is null or empty.";

    /// <summary>
    /// Represents an error message indicating that a specific token was expected but not found, with a suggestion to use a different token.
    /// </summary>
    public const string CannotSplitIdentifierAndVersionByDash = "Cannot split identifier and version by dash.";
}