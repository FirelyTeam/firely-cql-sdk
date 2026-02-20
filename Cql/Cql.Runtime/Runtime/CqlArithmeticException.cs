/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime;

/// <summary>
/// The exception that is thrown when a CQL arithmetic operation cannot be performed.
/// </summary>
/// <remarks>
/// Per the CQL specification and FHIRPath semantics, if a definite-quantity duration above days (or weeks)
/// appears in a date/time arithmetic calculation, the evaluation will end and signal an error to the calling environment.
/// </remarks>
public class CqlArithmeticException : CqlEvaluationException
{
    /// <summary>
    /// Initializes a new instance of <see cref="CqlArithmeticException"/> with the given message.
    /// </summary>
    /// <param name="message">The error message describing why the arithmetic could not be performed.</param>
    public CqlArithmeticException(string message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of <see cref="CqlArithmeticException"/> with the given message and inner exception.
    /// </summary>
    /// <param name="message">The error message describing why the arithmetic could not be performed.</param>
    /// <param name="innerException">The exception that caused this exception, or <see langword="null"/>.</param>
    public CqlArithmeticException(string message, Exception? innerException) : base(message, innerException)
    {
    }
}
