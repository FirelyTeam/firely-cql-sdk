/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime.Parsing;

/// <summary>
/// Represents a parse error in CQL (Clinical Quality Language).
/// </summary>
/// <param name="FormattableString">The formattable string containing the error message.</param>
public readonly record struct CqlParseError(FormattableString FormattableString)
{
    /// <summary>
    /// Gets the format string of the error message.
    /// </summary>
    public string Format => FormattableString.Format;
    /// <summary>
    /// Gets the arguments used in the format string of the error message.
    /// </summary>
    public object?[] Arguments => FormattableString.GetArguments();
    /// <summary>
    /// Returns the string representation of the error message.
    /// </summary>
    /// <returns>The formatted error message as a string.</returns>
    public override string ToString() => FormattableString.ToString(null);
    /// <summary>
    /// Implicitly converts a string to a <see cref="CqlParseError"/>.
    /// </summary>
    /// <param name="message">The error message as a string.</param>
    public static implicit operator CqlParseError(string message) => new(FormattableStringFactory.Create(message));
    /// <summary>
    /// Implicitly converts a tuple containing a format string and a single argument to a <see cref="CqlParseError"/>.
    /// </summary>
    /// <param name="message">A tuple containing the format string and argument.</param>
    public static implicit operator CqlParseError((string format, object arg) message) => new(FormattableStringFactory.Create(message.format, message.arg));
    /// <summary>
    /// Implicitly converts a tuple containing a format string and two arguments to a <see cref="CqlParseError"/>.
    /// </summary>
    /// <param name="message">A tuple containing the format string and two arguments.</param>
    public static implicit operator CqlParseError((string format, object arg1, object args2) message) => new(FormattableStringFactory.Create(message.format, message.arg1, message.args2));
    /// <summary>
    /// Implicitly converts a tuple containing a format string and an array of arguments to a <see cref="CqlParseError"/>.
    /// </summary>
    /// <param name="message">A tuple containing the format string and arguments array.</param>
    public static implicit operator CqlParseError((string format, object[] args) message) => new(FormattableStringFactory.Create(message.format, message.args));
    /// <summary>
    /// Implicitly converts a <see cref="FormattableString"/> to a <see cref="CqlParseError"/>.
    /// </summary>
    /// <param name="message">The formattable string containing the error message.</param>
    public static implicit operator CqlParseError(FormattableString message) => new(message);
}